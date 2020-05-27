using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySystemV1
{
    public partial class Form1 : Form
    {
        InventorySystemDB db;
        public Form1()
        {
            InitializeComponent();
            db = new InventorySystemDB();
        }

        private void AddInventoryBtn_Click(object sender, EventArgs e)
        {
            
            Inventory inventory = new Inventory();
            inventory.ID = 0;
            inventory.Name = NameTxt.Text;
            inventory.Address = AddressTxt.Text;
            inventory.Admin = AdminTxt.Text;
            db.Inventories.Add(inventory);
            db.SaveChanges();
            NameTxt.Text = "";
            AddressTxt.Text = "";
            AdminTxt.Text = "";
            var query = db.Inventories.Select(i => new { i.ID, i.Name, i.Address, i.Admin });
            InventoryGridView.DataSource = query.ToList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var query = db.Inventories.Select(i => new {i.ID, i.Name, i.Address, i.Admin });
            InventoryGridView.DataSource = query.ToList();
        }

        private void EditInventoryBtn_Click(object sender, EventArgs e)
        {
            int id = (int)InventoryGridView.CurrentRow.Cells[0].Value;
            var OldInv = db.Inventories.FirstOrDefault(i => i.ID == id);
            OldInv.Name = NameTxt.Text;
            OldInv.Address = AddressTxt.Text;
            OldInv.Admin = AdminTxt.Text;
            NameTxt.Text = "";
            AddressTxt.Text = "";
            AdminTxt.Text = "";
            db.SaveChanges();
            var query = db.Inventories.Select(i => new { i.ID, i.Name, i.Address, i.Admin });
            InventoryGridView.DataSource = query.ToList();


        }

        private void productsBtn_Click(object sender, EventArgs e)
        {
            ProductsForm products_form = new ProductsForm();
           
            products_form.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SupplierAndCustomer supplierAndCustomerform = new SupplierAndCustomer();
            supplierAndCustomerform.Show();
            this.Hide();
        }

        private void spbtn_Click(object sender, EventArgs e)
        {
            SppluPermission sppluPermission = new SppluPermission();
            sppluPermission.Show();
            this.Hide();
        }

        private void transformationBtn_Click(object sender, EventArgs e)
        {

            switching switching = new switching();
            switching.Show();
            this.Hide();
        }

        private void ReportOnInventory_Click(object sender, EventArgs e)
        {
            ReportOnInventory reportOnInventory = new ReportOnInventory();
                reportOnInventory.Show();
            this.Hide();

        }

        private void ProductsRepo_Click(object sender, EventArgs e)
        {
            ProductsReports productsReports = new ProductsReports();
            productsReports.Show();
            this.Hide();
        }

        private void Transfererepoo_Click(object sender, EventArgs e)
        {
            Transfererepo transfererepo = new Transfererepo();
            transfererepo.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            report11 r = new report11();
            r.Show();
            this.Hide();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Report12 r = new Report12();
            r.Show();
            this.Hide();
        }

        //private void ExchangBtn_Click(object sender, EventArgs e)
        //{
        //    ExcahngPermission excahngPermission = new ExcahngPermission();
        //    excahngPermission.Show();
        //    this.Hide();
        //}
    }
}
