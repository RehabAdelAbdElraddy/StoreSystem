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
    public partial class switching : Form
    {
        InventorySystemDB db;
        NumericUpDown numericUpDown;
        List<NumericUpDown> numericUpDowns;
        List<string> products;
        int? sum = 0;
        public switching()
        {
            InitializeComponent();
            db = new InventorySystemDB();
        }

        private void switching_Load(object sender, EventArgs e)
        {
            var Q2 = db.Customer_Suppliers.Where(s => s.IsCustomer == false).Select(s => s.Name);
            SuppliercomboBox.Items.Add("admin");
            foreach (var item in Q2)
            {
                SuppliercomboBox.Items.Add(item);
            }
            SuppliercomboBox.SelectedIndex = 0;
            var Q = db.Inventories.Select(i => new { id = i.ID, name = i.Name });

            foreach (var item in Q)
            {
                FromInventoryCBox.Items.Add(item.name);
                TocomboBox1.Items.Add(item.name);
            }
            var Qproduct = db.Products.Select(i => new { id = i.P_Code});

            foreach (var item in Qproduct)
            {
                ProductList.Items.Add(item.id);
            }


            //var Q3 = db.Products.Select(p => p.P_Code);
            //foreach (var item in Q3)
            //{
            //    ProductList.Items.Add(item);
            //}
        }




        private void QBTn_Click_1(object sender, EventArgs e)
        {
            int x = 10;
            //int xx = 1;
            numericUpDowns = new List<NumericUpDown>();
            products = new List<string>();
            foreach (var item in ProductList.SelectedItems)
            {
                products.Add(item.ToString());
                // MessageBox.Show(item.ToString());
                numericUpDown = new NumericUpDown();
                numericUpDowns.Add(numericUpDown);

                numericUpDown.Name = item.ToString();
                Label label = new Label();
                label.Text = item.ToString();
                label.Location = new System.Drawing.Point(300, 240 + x);
                numericUpDown.Location = new System.Drawing.Point(350, 240 + x);
                numericUpDown.Width = 50;
                numericUpDown.Height = 25;
                x += 30;
                this.Controls.Add(numericUpDown);
                this.Controls.Add(label);
            }
        }

        private void FromInventoryCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime PDate = dateTimePicker2.Value;
            DateTime EDate = dateTimePicker3.Value;
           string SEdate= EDate.ToString("yyyy-MM-dd");
            string Spdate = PDate.ToString("yyyy-MM-dd");
            //.ToString("yyyy-MM-dd");
            string supplier = SuppliercomboBox.SelectedItem.ToString();
            int SID = db.Customer_Suppliers.FirstOrDefault(a => a.Name == supplier).ID;
            string Frominventoryname = FromInventoryCBox.SelectedItem.ToString();
            int FromInventoryid = db.Inventories.FirstOrDefault(a => a.Name == Frominventoryname).ID;
            string pcode = ProductList.SelectedItem.ToString();
            var PNumber= db.Permissions.Where(a => a.Inventory_ID == FromInventoryid&&a.Type== "Supply").Select(a => a.P_Number);
            List<string> p = new List<string>();
            List<int?> Total = new List<int?>();
            //List<List<int?>> Q = new List<List<int?>>();
            foreach (var item in PNumber)
            {
              var query=  db.Permission_Products.FirstOrDefault(a => a.P_Number == item && a.P_Code == pcode);
                if(query!=null)
                Total.Add(query.Quantity);
            }
           
            foreach (var item in Total)
            {
                sum += item;
            }
            Label label = new Label();
            label.Text = "Qantity = "+ sum.ToString();
           label.Location = new System.Drawing.Point(190, 250);
            this.Controls.Add(label);
            //foreach (var item in p)
            //{
            //    int x = 10;
            //    foreach (var item2 in item)
            //    {
            //        ProductList.Items.Add(item2);
            //        //Label label = new Label();
            //        //var qnty = db.Permission_Products.FirstOrDefault(l => l.P_Code == item2).Quantity;
            //        //MessageBox.Show(qnty);
            //        //label.Text = item2.ToString()+"Qantity = "+ qnty ;
            //        //label.Location = new System.Drawing.Point(190, 240 + x);
            //        //x += 30;
            //        //this.Controls.Add(label);
            //    }
            //}


            //for (int i = 0; i < p.Count; i++)
            //{


            //        ProductList.Items.Add(p[i]);


            //}
        }

        private void SwitchBtn_Click(object sender, EventArgs e)
        {
            string Frominventoryname = FromInventoryCBox.SelectedItem.ToString();
            int FromInventoryid = db.Inventories.FirstOrDefault(a => a.Name == Frominventoryname).ID;
            string Targetinventoryname = TocomboBox1.SelectedItem.ToString();
            int TargetInventoryid = db.Inventories.FirstOrDefault(a => a.Name == Targetinventoryname).ID;
            string SEdate = dateTimePicker3.Value.ToString("yyyy-MM-dd");
            string Spdate = dateTimePicker2.Value.ToString("yyyy-MM-dd");
            string supplier = SuppliercomboBox.SelectedItem.ToString();
            int SID = db.Customer_Suppliers.FirstOrDefault(a => a.Name == supplier).ID;
            
            //list  of int
            //var ListOfPermissions = db.Permissions.Where(a => a.Inventory_ID == FromInventoryid).Select(a => a.P_Number).ToList();
            //List<int?> TotalQntyInInv = new List<int?>();

            //foreach (var item in ListOfPermissions)
            //{
            //    var query = db.Permission_Products.FirstOrDefault(p => p.P_Number == item && p.P_Code == products[0] && p.Supplier_ID == SID && p.ProductionDate == Spdate && p.ExperationDate == SEdate).Quantity;
            //    TotalQntyInInv.Add(query);
            //}
            //int? totalQnty = 0;
            //foreach (var item in TotalQntyInInv)
            //{
            //    totalQnty += item;
            //}
            //MessageBox.Show("The Totla Qnty Of This Product In this Invetory is = " + totalQnty);

            //7an mw3d el na2l 
            //decrease el kmya from 
            //ans add new permisiion to (done)
            //add in transfere table  (done)

            int qntytomove = (int)numericUpDowns[0].Value;
            Transfere transfere = new Transfere();
            transfere.id = 0;
            transfere.FromInventory = FromInventoryid;
            transfere.ToInventory = TargetInventoryid;
            transfere.P_Code = products[0];
            transfere.TransfereDate = DateTime.Now.ToString("yyyy-MM-dd");
            transfere.PDate = Spdate;
            transfere.EDate = SEdate;
            transfere.Qnty = qntytomove;
            transfere.supplierid = SID;
            db.Transferes.Add(transfere);
            db.SaveChanges();
            Permission permission = new Permission();

            permission.P_Number = 0;
            permission.P_Date = DateTime.Now;
            permission.Inventory_ID = TargetInventoryid;
            permission.Type = "Supply";
            Permission_Products permission_Products = new Permission_Products();
            permission_Products.P_Code = products[0];
            permission_Products.Quantity = qntytomove;
            permission_Products.Supplier_ID = SID;
            permission_Products.ProductionDate = Spdate;
            permission_Products.ExperationDate = Spdate;
            permission.Permission_Products.Add(permission_Products);
            db.Permissions.Add(permission);
            db.SaveChanges();
            bool flag = false;
            string bcode = "";
            var ListOfPermissions1 = db.Permissions.Where(a => a.Inventory_ID == FromInventoryid).Select(a => a.P_Number).ToList();
            
            foreach (var item in ListOfPermissions1)
            {
                bcode = products[0];
                Permission_Products OldPermissionproducts = db.Permission_Products.FirstOrDefault(p => p.P_Number == item && p.P_Code == bcode && p.Supplier_ID == SID && p.ProductionDate == Spdate && p.ExperationDate == SEdate);
               if(OldPermissionproducts.Quantity>=qntytomove)
                {
                    OldPermissionproducts.Quantity = OldPermissionproducts.Quantity - qntytomove;
                    flag = true;
                    break;
                }
               else
                {
                    flag = false;
                }
            }
            if(flag==false)
            {
                // MessageBox.Show("The qnty is less than the target");

                foreach (var item in ListOfPermissions1)
                {
                    Permission_Products OldPermissionproducts = db.Permission_Products.FirstOrDefault(p => p.P_Number == item && p.P_Code == products[0] && p.Supplier_ID == SID && p.ProductionDate == Spdate && p.ExperationDate == SEdate);
                    while (OldPermissionproducts.Quantity !=0&& qntytomove!=0)
                    {
                        OldPermissionproducts.Quantity--;
                        qntytomove--;
                    }
                }

            }

            db.SaveChanges();

        }

    }
}
