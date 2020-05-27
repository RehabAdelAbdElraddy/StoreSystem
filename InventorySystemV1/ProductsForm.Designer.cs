namespace InventorySystemV1
{
    partial class ProductsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ProductsGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.PCodeTxt = new System.Windows.Forms.TextBox();
            this.AddProductBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.PNameTxt = new System.Windows.Forms.TextBox();
            this.EditProductBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.UnitscheckedListBox1 = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductsGridView
            // 
            this.ProductsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsGridView.Location = new System.Drawing.Point(467, 1);
            this.ProductsGridView.Name = "ProductsGridView";
            this.ProductsGridView.Size = new System.Drawing.Size(321, 373);
            this.ProductsGridView.TabIndex = 0;
            this.ProductsGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductsGridView_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product Code";
            // 
            // PCodeTxt
            // 
            this.PCodeTxt.Location = new System.Drawing.Point(140, 21);
            this.PCodeTxt.Multiline = true;
            this.PCodeTxt.Name = "PCodeTxt";
            this.PCodeTxt.Size = new System.Drawing.Size(174, 28);
            this.PCodeTxt.TabIndex = 2;
            // 
            // AddProductBtn
            // 
            this.AddProductBtn.Font = new System.Drawing.Font("Tempus Sans ITC", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProductBtn.Location = new System.Drawing.Point(12, 252);
            this.AddProductBtn.Name = "AddProductBtn";
            this.AddProductBtn.Size = new System.Drawing.Size(192, 56);
            this.AddProductBtn.TabIndex = 3;
            this.AddProductBtn.Text = "Add Product";
            this.AddProductBtn.UseVisualStyleBackColor = true;
            this.AddProductBtn.Click += new System.EventHandler(this.AddProductBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Product Name";
            // 
            // PNameTxt
            // 
            this.PNameTxt.Location = new System.Drawing.Point(140, 61);
            this.PNameTxt.Multiline = true;
            this.PNameTxt.Name = "PNameTxt";
            this.PNameTxt.Size = new System.Drawing.Size(174, 28);
            this.PNameTxt.TabIndex = 5;
            // 
            // EditProductBtn
            // 
            this.EditProductBtn.Font = new System.Drawing.Font("Tempus Sans ITC", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditProductBtn.Location = new System.Drawing.Point(219, 252);
            this.EditProductBtn.Name = "EditProductBtn";
            this.EditProductBtn.Size = new System.Drawing.Size(192, 56);
            this.EditProductBtn.TabIndex = 6;
            this.EditProductBtn.Text = "Edit Product";
            this.EditProductBtn.UseVisualStyleBackColor = true;
            this.EditProductBtn.Click += new System.EventHandler(this.EditProductBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Measurment Unit";
            // 
            // UnitscheckedListBox1
            // 
            this.UnitscheckedListBox1.FormattingEnabled = true;
            this.UnitscheckedListBox1.Location = new System.Drawing.Point(152, 103);
            this.UnitscheckedListBox1.Name = "UnitscheckedListBox1";
            this.UnitscheckedListBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.UnitscheckedListBox1.Size = new System.Drawing.Size(162, 134);
            this.UnitscheckedListBox1.TabIndex = 8;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 14;
            this.listBox1.Location = new System.Drawing.Point(323, 343);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox1.Size = new System.Drawing.Size(120, 88);
            this.listBox1.TabIndex = 9;
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.UnitscheckedListBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EditProductBtn);
            this.Controls.Add(this.PNameTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddProductBtn);
            this.Controls.Add(this.PCodeTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProductsGridView);
            this.Name = "ProductsForm";
            this.Text = "ProductsForm";
            this.Load += new System.EventHandler(this.ProductsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ProductsGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PCodeTxt;
        private System.Windows.Forms.Button AddProductBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PNameTxt;
        private System.Windows.Forms.Button EditProductBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox UnitscheckedListBox1;
        private System.Windows.Forms.ListBox listBox1;
    }
}