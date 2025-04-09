namespace Grocery
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.itemsButton = new System.Windows.Forms.Button();
            this.inventoryButton = new System.Windows.Forms.Button();
            this.salesButton = new System.Windows.Forms.Button();
            this.reportButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sidebarButton = new System.Windows.Forms.PictureBox();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panelDashboard = new System.Windows.Forms.Panel();
            this.dashboardButton = new System.Windows.Forms.Button();
            this.menuContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.menuButton = new System.Windows.Forms.Button();
            this.panelLogout = new System.Windows.Forms.Panel();
            this.logoutbutton = new System.Windows.Forms.Button();
            this.menuTransition = new System.Windows.Forms.Timer(this.components);
            this.sidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sidebarButton)).BeginInit();
            this.sidebar.SuspendLayout();
            this.panelDashboard.SuspendLayout();
            this.menuContainer.SuspendLayout();
            this.panelLogout.SuspendLayout();
            this.SuspendLayout();
            // 
            // itemsButton
            // 
            this.itemsButton.BackColor = System.Drawing.Color.DarkOrchid;
            this.itemsButton.FlatAppearance.BorderSize = 0;
            this.itemsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemsButton.Font = new System.Drawing.Font("Stencil", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemsButton.ForeColor = System.Drawing.Color.White;
            this.itemsButton.Image = ((System.Drawing.Image)(resources.GetObject("itemsButton.Image")));
            this.itemsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.itemsButton.Location = new System.Drawing.Point(54, 91);
            this.itemsButton.Margin = new System.Windows.Forms.Padding(0);
            this.itemsButton.Name = "itemsButton";
            this.itemsButton.Size = new System.Drawing.Size(379, 83);
            this.itemsButton.TabIndex = 0;
            this.itemsButton.Text = "        ITEMS";
            this.itemsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.itemsButton.UseVisualStyleBackColor = false;
            this.itemsButton.Click += new System.EventHandler(this.itemsButton_Click);
            // 
            // inventoryButton
            // 
            this.inventoryButton.BackColor = System.Drawing.Color.DarkOrchid;
            this.inventoryButton.FlatAppearance.BorderSize = 0;
            this.inventoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inventoryButton.Font = new System.Drawing.Font("Stencil", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryButton.ForeColor = System.Drawing.Color.White;
            this.inventoryButton.Image = ((System.Drawing.Image)(resources.GetObject("inventoryButton.Image")));
            this.inventoryButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inventoryButton.Location = new System.Drawing.Point(54, 174);
            this.inventoryButton.Margin = new System.Windows.Forms.Padding(0);
            this.inventoryButton.Name = "inventoryButton";
            this.inventoryButton.Size = new System.Drawing.Size(379, 83);
            this.inventoryButton.TabIndex = 1;
            this.inventoryButton.Text = "        INVENTORY";
            this.inventoryButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inventoryButton.UseVisualStyleBackColor = false;
            this.inventoryButton.Click += new System.EventHandler(this.inventoryButton_Click);
            // 
            // salesButton
            // 
            this.salesButton.BackColor = System.Drawing.Color.DarkOrchid;
            this.salesButton.FlatAppearance.BorderSize = 0;
            this.salesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salesButton.Font = new System.Drawing.Font("Stencil", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesButton.ForeColor = System.Drawing.Color.White;
            this.salesButton.Image = ((System.Drawing.Image)(resources.GetObject("salesButton.Image")));
            this.salesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.salesButton.Location = new System.Drawing.Point(54, 257);
            this.salesButton.Margin = new System.Windows.Forms.Padding(0);
            this.salesButton.Name = "salesButton";
            this.salesButton.Size = new System.Drawing.Size(379, 83);
            this.salesButton.TabIndex = 2;
            this.salesButton.Text = "        SALES";
            this.salesButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.salesButton.UseVisualStyleBackColor = false;
            this.salesButton.Click += new System.EventHandler(this.salesButton_Click);
            // 
            // reportButton
            // 
            this.reportButton.BackColor = System.Drawing.Color.DarkOrchid;
            this.reportButton.FlatAppearance.BorderSize = 0;
            this.reportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportButton.Font = new System.Drawing.Font("Stencil", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportButton.ForeColor = System.Drawing.Color.White;
            this.reportButton.Image = ((System.Drawing.Image)(resources.GetObject("reportButton.Image")));
            this.reportButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reportButton.Location = new System.Drawing.Point(54, 340);
            this.reportButton.Margin = new System.Windows.Forms.Padding(0);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(379, 83);
            this.reportButton.TabIndex = 3;
            this.reportButton.Text = "        REPORTS";
            this.reportButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reportButton.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrchid;
            this.panel1.Controls.Add(this.sidebarButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1582, 85);
            this.panel1.TabIndex = 4;
            // 
            // sidebarButton
            // 
            this.sidebarButton.Image = ((System.Drawing.Image)(resources.GetObject("sidebarButton.Image")));
            this.sidebarButton.Location = new System.Drawing.Point(53, 12);
            this.sidebarButton.Name = "sidebarButton";
            this.sidebarButton.Size = new System.Drawing.Size(54, 56);
            this.sidebarButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sidebarButton.TabIndex = 5;
            this.sidebarButton.TabStop = false;
            this.sidebarButton.Click += new System.EventHandler(this.sidebarButton_Click);
            // 
            // sidebar
            // 
            this.sidebar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sidebar.BackColor = System.Drawing.Color.DarkOrchid;
            this.sidebar.Controls.Add(this.panelDashboard);
            this.sidebar.Controls.Add(this.menuContainer);
            this.sidebar.Controls.Add(this.panelLogout);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.sidebar.Location = new System.Drawing.Point(0, 85);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(463, 768);
            this.sidebar.TabIndex = 5;
            // 
            // panelDashboard
            // 
            this.panelDashboard.Controls.Add(this.dashboardButton);
            this.panelDashboard.Location = new System.Drawing.Point(3, 3);
            this.panelDashboard.Name = "panelDashboard";
            this.panelDashboard.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.panelDashboard.Size = new System.Drawing.Size(433, 87);
            this.panelDashboard.TabIndex = 8;
            // 
            // dashboardButton
            // 
            this.dashboardButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dashboardButton.BackColor = System.Drawing.Color.DarkOrchid;
            this.dashboardButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dashboardButton.FlatAppearance.BorderSize = 0;
            this.dashboardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboardButton.Font = new System.Drawing.Font("Stencil", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardButton.ForeColor = System.Drawing.Color.White;
            this.dashboardButton.Image = ((System.Drawing.Image)(resources.GetObject("dashboardButton.Image")));
            this.dashboardButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardButton.Location = new System.Drawing.Point(50, 10);
            this.dashboardButton.Name = "dashboardButton";
            this.dashboardButton.Size = new System.Drawing.Size(380, 83);
            this.dashboardButton.TabIndex = 6;
            this.dashboardButton.Text = "        DASHBOARD";
            this.dashboardButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardButton.UseVisualStyleBackColor = false;
            this.dashboardButton.Click += new System.EventHandler(this.dashboardButton_Click);
            // 
            // menuContainer
            // 
            this.menuContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.menuContainer.Controls.Add(this.menuButton);
            this.menuContainer.Controls.Add(this.itemsButton);
            this.menuContainer.Controls.Add(this.inventoryButton);
            this.menuContainer.Controls.Add(this.salesButton);
            this.menuContainer.Controls.Add(this.reportButton);
            this.menuContainer.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.menuContainer.Location = new System.Drawing.Point(0, 93);
            this.menuContainer.Margin = new System.Windows.Forms.Padding(0);
            this.menuContainer.Name = "menuContainer";
            this.menuContainer.Size = new System.Drawing.Size(433, 85);
            this.menuContainer.TabIndex = 8;
            // 
            // menuButton
            // 
            this.menuButton.BackColor = System.Drawing.Color.DarkOrchid;
            this.menuButton.FlatAppearance.BorderSize = 0;
            this.menuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuButton.Font = new System.Drawing.Font("Stencil", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuButton.ForeColor = System.Drawing.Color.White;
            this.menuButton.Image = ((System.Drawing.Image)(resources.GetObject("menuButton.Image")));
            this.menuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuButton.Location = new System.Drawing.Point(54, 0);
            this.menuButton.Margin = new System.Windows.Forms.Padding(0);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(379, 91);
            this.menuButton.TabIndex = 7;
            this.menuButton.Text = "        MENU";
            this.menuButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuButton.UseVisualStyleBackColor = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // panelLogout
            // 
            this.panelLogout.Controls.Add(this.logoutbutton);
            this.panelLogout.Location = new System.Drawing.Point(3, 181);
            this.panelLogout.Name = "panelLogout";
            this.panelLogout.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.panelLogout.Size = new System.Drawing.Size(430, 87);
            this.panelLogout.TabIndex = 10;
            // 
            // logoutbutton
            // 
            this.logoutbutton.BackColor = System.Drawing.Color.DarkOrchid;
            this.logoutbutton.FlatAppearance.BorderSize = 0;
            this.logoutbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutbutton.Font = new System.Drawing.Font("Stencil", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutbutton.ForeColor = System.Drawing.Color.White;
            this.logoutbutton.Image = ((System.Drawing.Image)(resources.GetObject("logoutbutton.Image")));
            this.logoutbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutbutton.Location = new System.Drawing.Point(50, 6);
            this.logoutbutton.Name = "logoutbutton";
            this.logoutbutton.Size = new System.Drawing.Size(377, 83);
            this.logoutbutton.TabIndex = 6;
            this.logoutbutton.Text = "        LOG OUT";
            this.logoutbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutbutton.UseVisualStyleBackColor = false;
            // 
            // menuTransition
            // 
            this.menuTransition.Interval = 10;
            this.menuTransition.Tick += new System.EventHandler(this.menuTransition_Tick);
            // 
            // sidebarTransition
            // 
            this.sidebarTransition.Interval = 10;
            this.sidebarTransition.Tick += new System.EventHandler(this.sidebarTransition_Tick);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1582, 853);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sidebarButton)).EndInit();
            this.sidebar.ResumeLayout(false);
            this.panelDashboard.ResumeLayout(false);
            this.menuContainer.ResumeLayout(false);
            this.panelLogout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button itemsButton;
        private System.Windows.Forms.Button inventoryButton;
        private System.Windows.Forms.Button salesButton;
        private System.Windows.Forms.Button reportButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox sidebarButton;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel panelDashboard;
        private System.Windows.Forms.Button dashboardButton;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.FlowLayoutPanel menuContainer;
        private System.Windows.Forms.Timer menuTransition;
        private System.Windows.Forms.Panel panelLogout;
        private System.Windows.Forms.Button logoutbutton;
        private System.Windows.Forms.Timer sidebarTransition;
    }
}

