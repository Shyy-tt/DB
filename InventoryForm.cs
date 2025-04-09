using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Grocery
{
    public partial class InventoryForm : Form
    {
        private static string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SalesDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;";

        public InventoryForm()
        {
            InitializeComponent();

            // Safety check - ensure dgvInventory exists
            if (inventoryView == null)
            {
                inventoryView = new DataGridView
                {
                    Dock = DockStyle.Fill,
                    Name = "dgvInventory"
                };
                this.Controls.Add(inventoryView);
            }

            LoadInventoryData();
            ConfigureDataGridView();
        }

        public void LoadInventoryData()
        {
            try
            {
                string query = @"SELECT 
                               i.ItemID, 
                               i.ItemName, 
                               inv.QuantityInStock, 
                               inv.ExpiryDate,
                               inv.LastStockUpdate
                               FROM Inventory inv
                               JOIN Items i ON inv.ItemID = i.ItemID
                               ORDER BY inv.ExpiryDate";

                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    inventoryView.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading inventory: {ex.Message}");
            }
        }

        private void ConfigureDataGridView()
        {
            inventoryView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Safe column access with null checks
            if (inventoryView.Columns.Contains("ExpiryDate"))
            {
                inventoryView.Columns["ExpiryDate"].DefaultCellStyle.Format = "dd/MM/yyyy";
                inventoryView.Columns["ExpiryDate"].HeaderText = "Expiry Date";
            }

            if (inventoryView.Columns.Contains("LastStockUpdate"))
            {
                inventoryView.Columns["LastStockUpdate"].DefaultCellStyle.Format = "g";
                inventoryView.Columns["LastStockUpdate"].HeaderText = "Last Updated";
            }

            if (inventoryView.Columns.Contains("QuantityInStock"))
            {
                inventoryView.Columns["QuantityInStock"].HeaderText = "Qty In Stock";
            }

            // Highlight expired items
            inventoryView.CellFormatting += (sender, e) =>
            {
                if (inventoryView.Columns.Contains("ExpiryDate") &&
                    e.ColumnIndex == inventoryView.Columns["ExpiryDate"].Index &&
                    e.Value != null)
                {
                    DateTime expiryDate = (DateTime)e.Value;
                    if (expiryDate < DateTime.Today)
                    {
                        e.CellStyle.BackColor = Color.LightPink;
                        e.CellStyle.ForeColor = Color.DarkRed;
                    }
                }
            };
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            LoadInventoryData();
        }

        private void dgvInventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void InventoryForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;
        }

        private void searchInvBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}