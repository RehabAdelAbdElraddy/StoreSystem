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
    public partial class ProductsReports : Form
    {
        DataTable dt;
        InventorySystemDB db;
        public ProductsReports()
        {
            InitializeComponent();
            db = new InventorySystemDB();
            dt = new DataTable();
            dt.Columns.Add("Name");
            dt.Columns.Add("InventoryName");
            dt.Columns.Add("qamtity");
            dt.Columns.Add("productionDate");
            dt.Columns.Add("aexperationDate");
            dt.Columns.Add("SupplierName");
        }

        private void ProductsReports_Load(object sender, EventArgs e)
        {
            

            var inventory = db.Inventories.Select(i => i.Name);
            foreach (var item in inventory)
            {
                comboBox1.Items.Add(item);
            }

        }

        private void Duration_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            var products = db.Products.Select(a => new { name = a.Name, code = a.P_Code });
            foreach (var item in products)
            {
                var q = db.Permission_Products.Where(a => a.P_Code == item.code&&a.Permission.Inventory.Name==comboBox1.SelectedItem.ToString()&&a.Permission.P_Date>=dateTimePicker1.Value&&a.Permission.P_Date<=dateTimePicker2.Value).Select(a => new { name = a.Product.Name, InventoryName = a.Permission.Inventory.Name, Quantitty = a.Quantity, productionDate = a.ProductionDate, ExperyDate = a.ExperationDate, supplier = a.Customer_Suppliers.Name });

                foreach (var item2 in q)
                {
                    listBox2.Items.Add("The Prodect Is ( " + item2.name + "  ) " + "The inventory ( " + item2.InventoryName + " ) " + "The Qantity is = " + item2.Quantitty + "  The ProductionDate is = " + item2.productionDate + "The ExperationDate is = " + item2.ExperyDate + "The Subblier is = " + item2.supplier);
                    listBox2.Items.Add("--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");

                }

            }
        }
    }
}
