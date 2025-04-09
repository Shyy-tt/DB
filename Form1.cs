using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grocery
{
    public partial class Form1 : Form
    {
        Dashboard dashboard;
        ItemForm item;
        InventoryForm inventory;
        SalesForm salesform;
        ReportForm report;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void itemsButton_Click(object sender, EventArgs e)
        {/*
            ItemForm itemform = new ItemForm();
            itemform.Show();*/

            if (item == null || item.IsDisposed)
            {
                item = new ItemForm();
                item.MdiParent = this; // Attach to MDI parent
                item.FormBorderStyle = FormBorderStyle.None; // Remove window border
                item.Dock = DockStyle.Fill; // Fill parent form
                item.WindowState = FormWindowState.Maximized; // Maximize within MDI
                item.FormClosed += Item_FormClosed;
                item.Show();
            }
            else
            {
                item.WindowState = FormWindowState.Maximized;
                item.BringToFront(); // Make sure it's on top
                item.Activate();
            }
        }

        private void Item_FormClosed(object sender, FormClosedEventArgs e)
        {
            item = null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void inventoryButton_Click(object sender, EventArgs e)
        {
            if (inventory == null || inventory.IsDisposed)
            {
                inventory = new InventoryForm();
                inventory.MdiParent = this; // Attach to MDI parent
                inventory.FormBorderStyle = FormBorderStyle.None; // Remove window border
                inventory.Dock = DockStyle.Fill; // Fill parent form
                inventory.WindowState = FormWindowState.Maximized; // Maximize within MDI
                inventory.FormClosed += Inventory_FormClosed;
                inventory.Show();
            }
            else
            {
                inventory.WindowState = FormWindowState.Maximized;
                inventory.BringToFront(); // Make sure it's on top
                inventory.Activate();
            }
        }

        private void Inventory_FormClosed(object sender, FormClosedEventArgs e)
        {
            inventory = null;
        }

        private void salesButton_Click(object sender, EventArgs e)
        {

        }
        bool menuExpand = false;
        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                menuContainer.Height += 10;
                if (menuContainer.Height >= 416)
                {
                    menuTransition.Stop();
                    menuExpand = true;
                }
            }
            else {
                menuContainer.Height -= 10;
                if (menuContainer.Height <= 85) {
                    menuTransition.Stop();
                    menuExpand = false;
                }
            }
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
        }
        bool sidebarExpand = true;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand) {
                sidebar.Width -= 5;
                if (sidebar.Width <= 140) {
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                    /*
                    panelDashboard.Width = sidebar.Width;
                    panelLogout.Width = sidebar.Width;
                    menuContainer.Width = sidebar.Width;*/
                }
            }
            else {
                sidebar.Width += 5;
                if (sidebar.Width >= 463) {
                    sidebarExpand = true;
                    sidebarTransition.Stop();
                    /*
                    panelDashboard.Width = sidebar.Width;
                    panelLogout.Width = sidebar.Width;
                    menuContainer.Width = sidebar.Width;*/
                }
            }
        }

        private void dashboardButton_Click(object sender, EventArgs e)
        {
            
        }

        private void sidebarButton_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }
    }
}
