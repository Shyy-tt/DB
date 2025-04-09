using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Grocery
{
    public partial class ItemForm : Form
    {
        private static string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SalesDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;";

        public ItemForm()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;

            // Initialize event handlers
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            searchButton.Click += searchButton_Click;
            searchBox.TextChanged += SearchBox_TextChanged;

            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            // Load initial data
            ProductData();
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            // Trigger search immediately when text changes
            searchButton_Click(sender, e);
        }

        private void ItemForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;

            ProductData();
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                string searchText = searchBox.Text.Trim();
                string query = @"SELECT ItemID, ItemName, ItemDesc 
                     FROM Items
                     WHERE @SearchText = '' OR 
                           CAST(ItemID AS VARCHAR) LIKE @SearchText + '%' OR 
                           ItemName LIKE @SearchText + '%' OR
                           ItemDesc LIKE '%' + @SearchText + '%'";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@SearchText", searchText);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Clear existing columns if they exist
                    dataGridView1.Columns.Clear();

                    // Add only ItemID and ItemName columns
                    dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
                    {
                        DataPropertyName = "ItemID",
                        HeaderText = "Item ID",
                        Name = "ItemID"
                    });
                    dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
                    {
                        DataPropertyName = "ItemName",
                        HeaderText = "Item Name",
                        Name = "ItemName"
                    });
                    dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
                    {
                        DataPropertyName = "ItemDesc",
                        HeaderText = "Description",
                        Name = "ItemDesc"
                    });

                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching data: {ex.Message}");
            }
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            try
            {
                int itemId = int.Parse(itemidBox.Text);
                string itemName = itemNameBox.Text;
                string itemDesc = descBox.Text;
                int quantity = int.Parse(quantityBox.Text);
                DateTime expiryDate = dateTimePicker1.Value;

                // Validate expiry date
                if (expiryDate < DateTime.Today)
                {
                    MessageBox.Show("Expiry date cannot be in the past");
                    return;
                }

                // Validate quantity
                if (quantity < 0)
                {
                    MessageBox.Show("Quantity cannot be negative");
                    return;
                }

                // First check if item already exists
                bool itemExists = CheckIfItemExists(itemId);

                if (itemExists)
                {
                    MessageBox.Show("Item with this ID already exists");
                    return;
                }

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlTransaction transaction = conn.BeginTransaction();

                    try
                    {
                        // 1. Insert into Items table
                        string itemQuery = "INSERT INTO Items(ItemID, ItemName, ItemDesc) VALUES (@ItemID, @ItemName, @ItemDesc)";
                        using (SqlCommand itemCmd = new SqlCommand(itemQuery, conn, transaction))
                        {
                            itemCmd.Parameters.AddWithValue("@ItemID", itemId);
                            itemCmd.Parameters.AddWithValue("@ItemName", itemName);
                            itemCmd.Parameters.AddWithValue("@ItemDesc", string.IsNullOrEmpty(itemDesc) ? DBNull.Value : (object)itemDesc);
                            itemCmd.ExecuteNonQuery();
                        }

                        // 2. Insert into Inventory table with quantity and expiry date
                        string inventoryQuery = @"INSERT INTO Inventory 
                                              (ItemID, QuantityInStock, ExpiryDate) 
                                              VALUES (@ItemID, @Quantity, @ExpiryDate)";
                        using (SqlCommand inventoryCmd = new SqlCommand(inventoryQuery, conn, transaction))
                        {
                            inventoryCmd.Parameters.AddWithValue("@ItemID", itemId);
                            inventoryCmd.Parameters.AddWithValue("@Quantity", quantity);
                            inventoryCmd.Parameters.AddWithValue("@ExpiryDate", expiryDate);
                            inventoryCmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        MessageBox.Show("Item and inventory record created successfully");

                        // Clear form fields
                        itemidBox.Clear();
                        itemNameBox.Clear();
                        descBox.Clear();
                        quantityBox.Clear();
                        priceBox.Clear();
                        dateTimePicker1.Value = DateTime.Today;

                        // Refresh data
                        ProductData();
                        RefreshInventoryForm();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show($"Error: {ex.Message}");
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric values for ID and Quantity");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void RefreshInventoryForm()
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is InventoryForm inventoryForm)
                {
                    inventoryForm.LoadInventoryData();
                }
            }
        }

        private bool CheckIfItemExists(int itemId)
        {
            string query = "SELECT COUNT(1) FROM Items WHERE ItemID = @ItemID";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ItemID", itemId);
                    return (int)cmd.ExecuteScalar() > 0;
                }
            }
        }

        private void ProductData()
        {
            try
            {
                string query = "SELECT ItemID, ItemName, ItemDesc FROM Items";

                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Clear existing columns if they exist
                    dataGridView1.Columns.Clear();

                    // Add only ItemID and ItemName columns
                    dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
                    {
                        DataPropertyName = "ItemID",
                        HeaderText = "Item ID",
                        Name = "ItemID"
                    });
                    dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
                    {
                        DataPropertyName = "ItemName",
                        HeaderText = "Item Name",
                        Name = "ItemName"
                    });
                    dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
                    {
                        DataPropertyName = "ItemDesc",
                        HeaderText = "Description",
                        Name = "ItemDesc"
                    });

                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}");
            }
        }

        private void deleteButton_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(itemidBox.Text))
            {
                MessageBox.Show("Please enter an Item ID");
                return;
            }

            try
            {
                int itemId = int.Parse(itemidBox.Text);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // First delete from Inventory
                    string deleteInventoryQuery = "DELETE FROM Inventory WHERE ItemID = @ItemID";
                    using (SqlCommand cmd = new SqlCommand(deleteInventoryQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@ItemID", itemId);
                        cmd.ExecuteNonQuery();
                    }

                    // Then delete from Items
                    string deleteItemQuery = "DELETE FROM Items WHERE ItemID = @ItemID";
                    using (SqlCommand cmd = new SqlCommand(deleteItemQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@ItemID", itemId);
                        int rowsDeleted = cmd.ExecuteNonQuery();

                        if (rowsDeleted > 0)
                        {
                            MessageBox.Show("Record Deleted Successfully");
                            itemidBox.Clear();
                            itemNameBox.Clear();
                            quantityBox.Clear();
                            priceBox.Clear();
                            dataGridView1.DataSource = null;
                            ProductData();
                        }
                        else
                        {
                            MessageBox.Show("No item found with this ID");
                        }
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid numeric ID");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                int itemId = Convert.ToInt32(row.Cells["ItemID"].Value);

                // Get details from both Items and Inventory tables
                string query = @"SELECT i.ItemDesc, inv.QuantityInStock, inv.ExpiryDate 
                     FROM Items i
                     LEFT JOIN Inventory inv ON i.ItemID = inv.ItemID
                     WHERE i.ItemID = @ItemID";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ItemID", itemId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Populate all fields
                            itemidBox.Text = row.Cells["ItemID"].Value.ToString();
                            itemNameBox.Text = row.Cells["ItemName"].Value.ToString();
                            descBox.Text = reader["ItemDesc"] != DBNull.Value ? reader["ItemDesc"].ToString() : "";
                            quantityBox.Text = reader["QuantityInStock"].ToString();
                            dateTimePicker1.Value = Convert.ToDateTime(reader["ExpiryDate"]);
                        }
                    }
                }
            }
        }

        private void itemNameBox_TextChanged(object sender, EventArgs e)
        {
            // Empty event handler
        }

        private void itemidBox_TextChanged(object sender, EventArgs e)
        {
            // Empty event handler
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Empty event handler
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(itemidBox.Text))
            {
                MessageBox.Show("Please select an item to update");
                return;
            }

            try
            {
                int itemId = int.Parse(itemidBox.Text);
                string newItemName = itemNameBox.Text;
                string newItemDesc = descBox.Text;
                int newQuantity = int.Parse(quantityBox.Text);
                DateTime newExpiryDate = dateTimePicker1.Value;

                // Validate expiry date
                if (newExpiryDate < DateTime.Today)
                {
                    MessageBox.Show("Expiry date cannot be in the past");
                    return;
                }

                // Validate quantity
                if (newQuantity < 0)
                {
                    MessageBox.Show("Quantity cannot be negative");
                    return;
                }

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlTransaction transaction = conn.BeginTransaction();

                    try
                    {
                        // 1. Update Items table
                        string updateItemQuery = "UPDATE Items SET ItemName = @ItemName, ItemDesc = @ItemDesc WHERE ItemID = @ItemID";
                        using (SqlCommand itemCmd = new SqlCommand(updateItemQuery, conn, transaction))
                        {
                            itemCmd.Parameters.AddWithValue("@ItemID", itemId);
                            itemCmd.Parameters.AddWithValue("@ItemName", newItemName);
                            itemCmd.Parameters.AddWithValue("@ItemDesc", string.IsNullOrEmpty(newItemDesc) ? DBNull.Value : (object)newItemDesc);
                            int itemsUpdated = itemCmd.ExecuteNonQuery();

                            if (itemsUpdated == 0)
                            {
                                transaction.Rollback();
                                MessageBox.Show("Item not found");
                                return;
                            }
                        }

                        // 2. Update Inventory table
                        string updateInventoryQuery = @"UPDATE Inventory 
                                           SET QuantityInStock = @Quantity, 
                                               ExpiryDate = @ExpiryDate
                                           WHERE ItemID = @ItemID";
                        using (SqlCommand inventoryCmd = new SqlCommand(updateInventoryQuery, conn, transaction))
                        {
                            inventoryCmd.Parameters.AddWithValue("@ItemID", itemId);
                            inventoryCmd.Parameters.AddWithValue("@Quantity", newQuantity);
                            inventoryCmd.Parameters.AddWithValue("@ExpiryDate", newExpiryDate);
                            inventoryCmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        MessageBox.Show("Record updated successfully");

                        // Refresh data
                        ProductData();
                        RefreshInventoryForm();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show($"Error updating record: {ex.Message}");
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric values for ID and Quantity");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void quantityBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void descBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void priceBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}