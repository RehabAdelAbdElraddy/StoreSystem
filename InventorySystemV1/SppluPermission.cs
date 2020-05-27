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
    public partial class SppluPermission : Form
    {
        InventorySystemDB db;
        NumericUpDown numericUpDown;
        List<NumericUpDown> numericUpDowns;
        List<string> products;
        public SppluPermission()
        {
            InitializeComponent();
            db = new InventorySystemDB();
        }

        private void SppluPermission_Load(object sender, EventArgs e)
        {
           

            var Q = db.Inventories.Select(i => new { id = i.ID, name = i.Name });

            foreach (var item in Q)
            {
                InventoryCBox.Items.Add(item.name);
            }

            Typecbox.Items.Add("Supply");
            Typecbox.Items.Add("Exchange");
            var Q2 = db.Customer_Suppliers.Where(s=>s.IsCustomer==false).Select(s =>   s.Name );
            SuppliercomboBox.Items.Add("admin");
            foreach (var item in Q2)
            {
                SuppliercomboBox.Items.Add(item);
            }
            SuppliercomboBox.SelectedIndex = 0;
            var Q22 = db.Customer_Suppliers.Where(s => s.IsCustomer == true).Select(s => s.Name);
            CustomerCBox.Items.Add("admin");
            foreach (var item in Q22)
            {
                CustomerCBox.Items.Add(item);
            }
            CustomerCBox.SelectedIndex = 0;

            var Q3 = db.Products.Select(p => p.P_Code);
            foreach (var item in Q3)
            {
                ProductList.Items.Add(item);
            }

            var Q4 = db.Permission_Products.Select(p => new { p.P_Number,p.P_Code,p.Quantity,p.Supplier_ID,p.ProductionDate,p.ExperationDate});
            PermissinGrid.DataSource = Q4.ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            string inventoryname = InventoryCBox.SelectedItem.ToString();
           
            string Type = Typecbox.SelectedItem.ToString();
            string supplier= SuppliercomboBox.SelectedItem.ToString();
            string customer = SuppliercomboBox.SelectedItem.ToString();

            DateTime Date = dateTimePicker1.Value;
            string PDate = dateTimePicker2.Value.ToString("yyyy-MM-dd");
            string EDate = dateTimePicker3.Value.ToString("yyyy-MM-dd");


            int Inventoryid = db.Inventories.FirstOrDefault(a => a.Name == inventoryname).ID;
            int SID = db.Customer_Suppliers.FirstOrDefault(a => a.Name == supplier).ID;
            int CID = db.Customer_Suppliers.FirstOrDefault(a => a.Name == customer).ID;

            Permission permission = new Permission();
            permission.P_Date = Date;
            permission.Inventory_ID = Inventoryid;
            permission.Type = Type;
            permission.P_Number = 0;
            db.Permissions.Add(permission);
            db.SaveChanges();
            db.Entry(permission).GetDatabaseValues();
            int Pid = permission.P_Number;
           // MessageBox.Show(Pid.ToString());
            //Permission_Products permission_Products = new Permission_Products();
            //permission_Products.Supplier_ID = SID;
            //if(Type== "Supply")
            //{
            //    permission_Products.ProductionDate = PDate;
            //    permission_Products.ExperationDate = EDate;
            //}
          
           
           
          DateTime  ConvertPDate = DateTime.ParseExact(PDate, "yyyy-MM-dd", null);
            DateTime ConvertEDate = DateTime.ParseExact(EDate, "yyyy-MM-dd", null);
            List<int> Qnty = new List<int>();
            foreach (var item in numericUpDowns)
            {
                int x = (int)item.Value;
                  Qnty.Add(x);
            }
            for (int i = 0; i < products.Count; i++)
            {
                Permission_Products permission_Products = new Permission_Products();
                permission_Products.P_Number = Pid;
                permission_Products.P_Code = products[i];
               // permission_Products.Supplier_ID = SID;
                permission_Products.Quantity = Qnty[i];
               
                if (Type == "Supply")
                {
                    permission_Products.Supplier_ID = SID;

                    permission_Products.ProductionDate = PDate;
                    permission_Products.ExperationDate = EDate;
                }
                else 
                {
                    permission_Products.Supplier_ID = CID;
                    permission_Products.ProductionDate = null;
                    permission_Products.ExperationDate = null;
                }
                db.Permission_Products.Add(permission_Products);
            }




            db.SaveChanges();

            var Q4 = db.Permissions.Select(p => new { p.P_Number, p.P_Date, p.Inventory_ID, p.Type });
            PermissinGrid.DataSource = Q4.ToList();
        }

        private void ProductList_Click(object sender, EventArgs e)
        {
            //int x = 10;
            //foreach (var item in ProductList.SelectedItems)
            //{
            //    MessageBox.Show(item.ToString());

            //    NumericUpDown numericUpDown = new NumericUpDown();
            //    numericUpDown.Name = item.ToString();
            //    numericUpDown.Location = new System.Drawing.Point(200, 240 + x);
            //    numericUpDown.Width = 50;
            //    numericUpDown.Height = 25;
            //    x += 30;
            //    this.Controls.Add(numericUpDown);
            //}

        }

        private void ProductList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
         
        }

        private void QBTn_Click(object sender, EventArgs e)
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
                label.Location = new System.Drawing.Point(200, 240 + x);
                numericUpDown.Location = new System.Drawing.Point(250, 240 + x);
                numericUpDown.Width = 50;
                numericUpDown.Height = 25;
                x += 30;
                this.Controls.Add(numericUpDown);
                this.Controls.Add(label);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            foreach (var item in numericUpDowns)
            {
               
                    MessageBox.Show(item.Value.ToString());
                    MessageBox.Show(item.Name);
                
            }

        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            int PIrmissionId = (int)PermissinGrid.CurrentRow.Cells[0].Value;
            string Product_Code = PermissinGrid.CurrentRow.Cells[1].Value.ToString();


            string inventoryname = InventoryCBox.SelectedItem.ToString();
            string Type = Typecbox.SelectedItem.ToString();
            string supplier = SuppliercomboBox.SelectedItem.ToString();
            string customer = SuppliercomboBox.SelectedItem.ToString();
            DateTime Date = dateTimePicker1.Value;
            string PDate = dateTimePicker2.Value.ToString("yyyy-MM-dd");
            string EDate = dateTimePicker3.Value.ToString("yyyy-MM-dd");
            int Inventoryid = db.Inventories.FirstOrDefault(a => a.Name == inventoryname).ID;
            int SID = db.Customer_Suppliers.FirstOrDefault(a => a.Name == supplier).ID;
            int CID = db.Customer_Suppliers.FirstOrDefault(a => a.Name == customer).ID;
            var OLDpermission_Products = db.Permission_Products.FirstOrDefault(p => p.P_Number == PIrmissionId && p.P_Code == Product_Code);
            var OLDpermission = db.Permissions.FirstOrDefault(p => p.P_Number == PIrmissionId);
            OLDpermission.P_Date = Date;
            OLDpermission.Inventory_ID = Inventoryid;
            OLDpermission.Type = Type;
          //  OLDpermission_Products.Supplier_ID = SID;
            if (Type == "Supply")
            {
                OLDpermission_Products.Supplier_ID = SID;
                OLDpermission_Products.ProductionDate = PDate;
                OLDpermission_Products.ExperationDate = EDate;
            }
            else
            {
                OLDpermission_Products.Supplier_ID = CID;
                OLDpermission_Products.ProductionDate = null;
                OLDpermission_Products.ExperationDate = null;
            }
            List<int> Qnty = new List<int>();
           

            foreach (var item in numericUpDowns)
            {
                int x = (int)item.Value;
                Qnty.Add(x);
                OLDpermission_Products.Quantity = x;
            }
            db.SaveChanges();
            var Q4 = db.Permission_Products.Select(p => new { p.P_Number, p.P_Code, p.Quantity, p.Supplier_ID, p.ProductionDate, p.ExperationDate });
            PermissinGrid.DataSource = Q4.ToList();
        }
    }
}
