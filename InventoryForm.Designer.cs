namespace Grocery
{
    partial class InventoryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.inventoryView = new System.Windows.Forms.DataGridView();
            this.refresh = new System.Windows.Forms.Button();
            this.searchInvBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryView)).BeginInit();
            this.SuspendLayout();
            // 
            // inventoryView
            // 
            this.inventoryView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventoryView.Location = new System.Drawing.Point(86, 247);
            this.inventoryView.Name = "inventoryView";
            this.inventoryView.RowHeadersWidth = 51;
            this.inventoryView.RowTemplate.Height = 24;
            this.inventoryView.Size = new System.Drawing.Size(1455, 535);
            this.inventoryView.TabIndex = 0;
            this.inventoryView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventory_CellContentClick);
            // 
            // refresh
            // 
            this.refresh.BackColor = System.Drawing.Color.DarkOrchid;
            this.refresh.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.refresh.Location = new System.Drawing.Point(1122, 131);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(130, 43);
            this.refresh.TabIndex = 1;
            this.refresh.Text = "REFRESH";
            this.refresh.UseVisualStyleBackColor = false;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // searchInvBox
            // 
            this.searchInvBox.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchInvBox.Location = new System.Drawing.Point(524, 173);
            this.searchInvBox.Name = "searchInvBox";
            this.searchInvBox.Size = new System.Drawing.Size(507, 44);
            this.searchInvBox.TabIndex = 2;
            this.searchInvBox.TextChanged += new System.EventHandler(this.searchInvBox_TextChanged);
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.DarkOrchid;
            this.searchButton.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.searchButton.Location = new System.Drawing.Point(1122, 180);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(130, 43);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "SEARCH";
            this.searchButton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkViolet;
            this.label1.Location = new System.Drawing.Point(553, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(478, 95);
            this.label1.TabIndex = 4;
            this.label1.Text = "INVENTORY";
            // 
            // InventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1639, 858);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchInvBox);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.inventoryView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InventoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InventoryForm";
            this.Load += new System.EventHandler(this.InventoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inventoryView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView inventoryView;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.TextBox searchInvBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label label1;
    }
}