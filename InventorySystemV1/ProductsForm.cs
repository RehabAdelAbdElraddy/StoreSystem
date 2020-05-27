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
    public partial class ProductsForm : Form
    {
        InventorySystemDB db;
        public ProductsForm()
        {
            InitializeComponent();
            db = new InventorySystemDB();
            
        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {
            var query = db.MeasurmentUnits.Select(u => new { u.Unit_ID, u.Unit_Name });
            foreach (var item in query)
            {
                UnitscheckedListBox1.Items.Add(item.Unit_Name);

            }

            var query2 = db.Products.Select(i => new { i.P_Code, i.Name });
            //foreach (var item in query2.ToList()[1].mus)
            //{
            //    MessageBox.Show(item.Unit_Name);
            //}
            ProductsGridView.DataSource = query2.ToList();


        }

        private void AddProductBtn_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.P_Code = PCodeTxt.Text;
            product.Name = PNameTxt.Text;
          MeasurmentUnit measurmentUnit = new MeasurmentUnit();

            foreach (var item in UnitscheckedListBox1.SelectedItems)
            {
             
                var query = db.MeasurmentUnits.First(u => u.Unit_Name == item.ToString());
                 measurmentUnit = query;
                measurmentUnit.Products.Add(product);
            }
            db.Products.Add(product);
            db.SaveChanges();
            var query2 = db.Products.Select(i => new { i.P_Code, i.Name});
            //foreach (var item in query2.ToList()[1].mus)
            //{
            //    MessageBox.Show(item.Unit_Name);
            //} 
            ProductsGridView.DataSource = query2.ToList();
            PNameTxt.Text = "";
            PCodeTxt.Text = "";

        }

        private void EditProductBtn_Click(object sender, EventArgs e)
        {
            string id = ProductsGridView.CurrentRow.Cells[0].Value.ToString();
            var OldP = db.Products.FirstOrDefault(i => i.P_Code == id);
            OldP.Name = PNameTxt.Text;
            List<MeasurmentUnit> measurmentUnits = new List<MeasurmentUnit>();
            foreach (var item in OldP.MeasurmentUnits)
            {
                measurmentUnits.Add(item);
            }
            foreach (var item in measurmentUnits)
            {
                OldP.MeasurmentUnits.Remove(item);
            }
            //OldP.P_Code = PCodeTxt.Text;
            MeasurmentUnit measurmentUnit = new MeasurmentUnit();

            foreach (var item in UnitscheckedListBox1.SelectedItems)
            {

               var query4 = db.MeasurmentUnits.First(u => u.Unit_Name == item.ToString());
                measurmentUnit = query4;
                measurmentUnit.Products.Add(OldP);
            }
            db.SaveChanges();
            var query = db.Products.Select(i => new { i.P_Code, i.Name});
            ProductsGridView.DataSource = query.ToList();
            PNameTxt.Text = "";
            PCodeTxt.Text = "";
        }

        private void ProductsGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = ProductsGridView.CurrentRow.Cells[0].Value.ToString();
            var OldP = db.Products.FirstOrDefault(i => i.P_Code == id);
            foreach (var item in OldP.MeasurmentUnits)
            {
                listBox1.Items.Add(item.Unit_Name);
            }
        }
    }
}
