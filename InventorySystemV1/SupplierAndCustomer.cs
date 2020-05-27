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
    public partial class SupplierAndCustomer : Form
    {
        InventorySystemDB db;
        public SupplierAndCustomer()
        {
            InitializeComponent();
            db = new InventorySystemDB();
            var q = db.Customer_Suppliers.Select(c => new { c.ID, c.Name, c.Phone, c.Fax, c.Mobile, c.Email, c.Website });
            CUst_suppGrid.DataSource = q.ToList();

        }

        private void AddAsCustomerBTn_Click(object sender, EventArgs e)
        {
            Customer_Suppliers customer = new Customer_Suppliers();
            customer.Name = name.Text;
            customer.Phone = phone.Text;
            customer.Fax = Fax.Text;
            customer.Email = Email.Text;
            customer.Mobile = Mobile.Text;
            customer.Website = WebSite.Text;
            customer.IsCustomer = true;
            db.Customer_Suppliers.Add(customer);
            db.SaveChanges();
         var q=   db.Customer_Suppliers.Select(c => new { c.ID, c.Name,c.Phone,c.Fax,c.Mobile,c.Email,c.Website });
            CUst_suppGrid.DataSource = q.ToList();
            name.Text = "";
            phone.Text = "";
            Fax.Text = "";
            Email.Text = "";
            Mobile.Text = "";
            WebSite.Text = "";

        }

        private void AddAsSupplierBTn_Click(object sender, EventArgs e)
        {
            Customer_Suppliers suppliers = new Customer_Suppliers();
           suppliers.Name = name.Text;
           suppliers.Phone = phone.Text;
           suppliers.Fax = Fax.Text;
           suppliers.Email = Email.Text;
           suppliers.Mobile = Mobile.Text;
           suppliers.Website = WebSite.Text;
            suppliers.IsCustomer = false;
            db.Customer_Suppliers.Add(suppliers);
            db.SaveChanges();
            var q = db.Customer_Suppliers.Select(c => new { c.ID, c.Name, c.Phone, c.Fax, c.Mobile, c.Email, c.Website });
            CUst_suppGrid.DataSource = q.ToList();
            name.Text = "";
            phone.Text = "";
            Fax.Text = "";
            Email.Text = "";
            Mobile.Text = "";
            WebSite.Text = "";
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            int id = (int)CUst_suppGrid.CurrentRow.Cells[0].Value;
            var Oldcust = db.Customer_Suppliers.FirstOrDefault(i => i.ID == id);
            Oldcust.Name = name.Text;
            Oldcust.Phone = phone.Text;
            Oldcust.Fax = Fax.Text;
            Oldcust.Email = Email.Text;
            Oldcust.Mobile = Mobile.Text;
            Oldcust.Website = WebSite.Text;
            db.SaveChanges();
            var q = db.Customer_Suppliers.Select(c => new { c.ID, c.Name, c.Phone, c.Fax, c.Mobile, c.Email, c.Website });
            CUst_suppGrid.DataSource = q.ToList();
            name.Text = "";
            phone.Text = "";
            Fax.Text = "";
            Email.Text = "";
            Mobile.Text = "";
            WebSite.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var q = db.Customer_Suppliers.Where(c=>c.IsCustomer==true).Select(c => new { c.ID, c.Name, c.Phone, c.Fax, c.Mobile, c.Email, c.Website });
            CUst_suppGrid.DataSource = q.ToList();
        }

        private void Suppliers_Click(object sender, EventArgs e)
        {
            var q = db.Customer_Suppliers.Where(c => c.IsCustomer == false).Select(c => new { c.ID, c.Name, c.Phone, c.Fax, c.Mobile, c.Email, c.Website });
            CUst_suppGrid.DataSource = q.ToList();
        }
    }
}
