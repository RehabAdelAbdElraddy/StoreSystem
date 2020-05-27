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
    public partial class Transfererepo : Form
    {
        InventorySystemDB db;
        public Transfererepo()
        {
            InitializeComponent();
            db = new InventorySystemDB();
        }

        private void Duration_Click(object sender, EventArgs e)
        {
            DateTime dateValue;

            var q = db.Transferes.Select(a => new { Productname = a.Product.Name, FromInventory = a.Inventory.Name, ToInventory = a.Inventory1.Name, Quantity = a.Qnty, supplier = a.Customer_Suppliers.Name, productionDate = a.PDate, ExperyDate = a.EDate, transfere=a.TransfereDate });
            foreach (var item in q)
            {
                DateTime.TryParse(item.transfere, out dateValue);
                
                if (dateValue >= dateTimePicker1.Value && dateValue <= dateTimePicker2.Value)
                {
                    listBox2.Items.Add("The Prodect Is ( " + item.Productname + "  ) " + "From The inventory ( " + item.FromInventory + " ) " + "To The inventory ( " + item.ToInventory + " ) " + "The Qantity is = " + item.Quantity + "  The ProductionDate is = " + item.productionDate + "The ExperationDate is = " + item.ExperyDate + "The Subblier is = " + item.supplier+ " The TransfrerDate is = "+item.transfere);
                    listBox2.Items.Add("-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                }
            }
        }

        //private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{

        //}
    }
}
