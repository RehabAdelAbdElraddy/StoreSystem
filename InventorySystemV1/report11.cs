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
    public partial class report11 : Form
    {
        InventorySystemDB db;
        public report11()
        {
            InitializeComponent();
            db = new InventorySystemDB();
        }

        private void Duration_Click(object sender, EventArgs e)
        {
            var products = db.Products.Select(a => new { name = a.Name, code = a.P_Code });
            foreach (var item in products)
            {
                var q = db.Permission_Products.Where(a=>a.Permission.P_Date >= dateTimePicker1.Value && a.Permission.P_Date <= dateTimePicker2.Value).Select(a => new { name = a.Product.Name, InventoryName = a.Permission.Inventory.Name, Quantitty = a.Quantity, productionDate = a.ProductionDate, ExperyDate = a.ExperationDate, supplier = a.Customer_Suppliers.Name,pdate=a.Permission.P_Date });

                foreach (var item2 in q)
                {          if ((DateTime.Now - item2.pdate ) >= new TimeSpan(1, 14, 32, 17, 685))
                    {
                        listBox2.Items.Add("The Prodect Is ( " + item2.name + "  ) " + "The inventory ( " + item2.InventoryName + " ) " + "The Qantity is = " + item2.Quantitty + "  The ProductionDate is = " + item2.productionDate + "The ExperationDate is = " + item2.ExperyDate + "The Subblier is = " + item2.supplier);
                        listBox2.Items.Add("--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                    }
                }

            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
