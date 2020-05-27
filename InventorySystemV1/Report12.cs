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
    public partial class Report12 : Form
    {
        InventorySystemDB db;
        public Report12()
        {
            InitializeComponent();
            db = new InventorySystemDB();
        }

        private void Duration_Click(object sender, EventArgs e)
        {

            DateTime dateValue;

            var q = db.Permission_Products.Select(a => new{ name = a.Product.Name, InventoryName = a.Permission.Inventory.Name, Quantitty = a.Quantity, productionDate = a.ProductionDate, ExperyDate = a.ExperationDate, supplier = a.Customer_Suppliers.Name, pdate = a.Permission.P_Date  });
            foreach (var item in q)
            {
                DateTime.TryParse(item.ExperyDate, out dateValue);

                if (item.pdate >= from.Value && item.pdate <= to.Value)
                {   if (dateValue-DateTime.Now <=new TimeSpan(40, 14, 32, 17, 685))
                    {
                        listBox2.Items.Add("The Prodect Is ( " + item.name + "  ) " + " The inventory ( " + item.InventoryName + " ) "  + "The Qantity is = " + item.Quantitty + "  The ProductionDate is = " + item.productionDate + "The ExperationDate is = " + item.ExperyDate + "The Subblier is = " + item.supplier);
                        listBox2.Items.Add("-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");

                    }
                    }
            }


        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
