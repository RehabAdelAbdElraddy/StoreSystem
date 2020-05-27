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
    public partial class ReportOnInventory : Form
    {
        InventorySystemDB db;
        
        public ReportOnInventory()
        {
            InitializeComponent();
            db = new InventorySystemDB();
        }

        private void ReportOnInventory_Load(object sender, EventArgs e)
        {
            var query = db.Inventories.Select(i => new { i.ID});
            foreach (var item in query)
            {
                var qu2 = db.Permission_Products.Where(p => p.Permission.Inventory_ID == item.ID).Select(p => new {Inventory = p.Permission.Inventory.Name, product= p.P_Code,qnty= p.Quantity}).ToList();
                foreach (var item2 in qu2)
                {
                     listBox1.Items.Add("The Inventory( "+item2.Inventory+"  ) "+"The Product ( "+item2.product+" ) "+"The Qantity is = "+item2.qnty);
                    listBox1.Items.Add("----------------------------------------------------------------------------------------------------------------------------------");

                }

            }


            
        }
        
        private void Duration_Click(object sender, EventArgs e)
        {
            DateTime t = new DateTime();
            t = dateTimePicker1.Value;
            var query = db.Inventories.Select(i => new { i.ID });
            foreach (var item in query)
            {
                var qu2 = db.Permission_Products.Where(p => p.Permission.Inventory_ID == item.ID).Select(p => new { Inventory = p.Permission.Inventory.Name, product = p.P_Code, qnty = p.Quantity, Date = p.Permission.P_Date });
                foreach (var item2 in qu2)
                {
                    if(item2.Date>=dateTimePicker1.Value&& item2.Date <= dateTimePicker2.Value)
                    {
                       
                        listBox1.Items.Add("-----------------------------------------------------------------------------------------------------------------------------------");
                        listBox1.Items.Add("The Inventory( " + item2.Inventory + "  ) " + "The Product ( " + item2.product + " ) " + "The Qantity is = " + item2.qnty+"Date = "+item2.Date);
                    }
                }

            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}

                    //if (DateTime.Compare((DateTime) item2.Date, t) >= 0 && DateTime.Compare((DateTime) item2.Date, t) <= 0)









