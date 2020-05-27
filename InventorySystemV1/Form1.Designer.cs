namespace InventorySystemV1
{
    partial class Form1
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
            this.NameLabl = new System.Windows.Forms.Label();
            this.NameTxt = new System.Windows.Forms.TextBox();
            this.AddInventoryBtn = new System.Windows.Forms.Button();
            this.Addresslabl = new System.Windows.Forms.Label();
            this.Adminlabl = new System.Windows.Forms.Label();
            this.AddressTxt = new System.Windows.Forms.TextBox();
            this.AdminTxt = new System.Windows.Forms.TextBox();
            this.InventoryGridView = new System.Windows.Forms.DataGridView();
            this.EditInventoryBtn = new System.Windows.Forms.Button();
            this.productsBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.spbtn = new System.Windows.Forms.Button();
            this.transformationBtn = new System.Windows.Forms.Button();
            this.ReportOnInventoryBTN = new System.Windows.Forms.Button();
            this.ProductsRepo = new System.Windows.Forms.Button();
            this.Transfererepoo = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // NameLabl
            // 
            this.NameLabl.AutoSize = true;
            this.NameLabl.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabl.Location = new System.Drawing.Point(12, 9);
            this.NameLabl.Name = "NameLabl";
            this.NameLabl.Size = new System.Drawing.Size(61, 24);
            this.NameLabl.TabIndex = 0;
            this.NameLabl.Text = "Name";
            // 
            // NameTxt
            // 
            this.NameTxt.Location = new System.Drawing.Point(91, 12);
            this.NameTxt.Multiline = true;
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(140, 24);
            this.NameTxt.TabIndex = 1;
            // 
            // AddInventoryBtn
            // 
            this.AddInventoryBtn.Font = new System.Drawing.Font("Tempus Sans ITC", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddInventoryBtn.Location = new System.Drawing.Point(1, 107);
            this.AddInventoryBtn.Name = "AddInventoryBtn";
            this.AddInventoryBtn.Size = new System.Drawing.Size(166, 41);
            this.AddInventoryBtn.TabIndex = 2;
            this.AddInventoryBtn.Text = "Add Inventory";
            this.AddInventoryBtn.UseVisualStyleBackColor = true;
            this.AddInventoryBtn.Click += new System.EventHandler(this.AddInventoryBtn_Click);
            // 
            // Addresslabl
            // 
            this.Addresslabl.AutoSize = true;
            this.Addresslabl.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addresslabl.Location = new System.Drawing.Point(12, 42);
            this.Addresslabl.Name = "Addresslabl";
            this.Addresslabl.Size = new System.Drawing.Size(79, 24);
            this.Addresslabl.TabIndex = 3;
            this.Addresslabl.Text = "Address";
            // 
            // Adminlabl
            // 
            this.Adminlabl.AutoSize = true;
            this.Adminlabl.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adminlabl.Location = new System.Drawing.Point(22, 75);
            this.Adminlabl.Name = "Adminlabl";
            this.Adminlabl.Size = new System.Drawing.Size(69, 24);
            this.Adminlabl.TabIndex = 4;
            this.Adminlabl.Text = "Admin";
            // 
            // AddressTxt
            // 
            this.AddressTxt.Location = new System.Drawing.Point(91, 47);
            this.AddressTxt.Multiline = true;
            this.AddressTxt.Name = "AddressTxt";
            this.AddressTxt.Size = new System.Drawing.Size(140, 24);
            this.AddressTxt.TabIndex = 5;
            // 
            // AdminTxt
            // 
            this.AdminTxt.Location = new System.Drawing.Point(91, 77);
            this.AdminTxt.Multiline = true;
            this.AdminTxt.Name = "AdminTxt";
            this.AdminTxt.Size = new System.Drawing.Size(140, 24);
            this.AdminTxt.TabIndex = 6;
            // 
            // InventoryGridView
            // 
            this.InventoryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InventoryGridView.Location = new System.Drawing.Point(359, 6);
            this.InventoryGridView.Name = "InventoryGridView";
            this.InventoryGridView.Size = new System.Drawing.Size(420, 418);
            this.InventoryGridView.TabIndex = 7;
            // 
            // EditInventoryBtn
            // 
            this.EditInventoryBtn.Font = new System.Drawing.Font("Tempus Sans ITC", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditInventoryBtn.Location = new System.Drawing.Point(164, 107);
            this.EditInventoryBtn.Name = "EditInventoryBtn";
            this.EditInventoryBtn.Size = new System.Drawing.Size(163, 41);
            this.EditInventoryBtn.TabIndex = 8;
            this.EditInventoryBtn.Text = "Edit Inventory";
            this.EditInventoryBtn.UseVisualStyleBackColor = true;
            this.EditInventoryBtn.Click += new System.EventHandler(this.EditInventoryBtn_Click);
            // 
            // productsBtn
            // 
            this.productsBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.productsBtn.Font = new System.Drawing.Font("Tempus Sans ITC", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsBtn.Location = new System.Drawing.Point(1, 145);
            this.productsBtn.Name = "productsBtn";
            this.productsBtn.Size = new System.Drawing.Size(352, 31);
            this.productsBtn.TabIndex = 9;
            this.productsBtn.Text = "Add And Edit Products";
            this.productsBtn.UseVisualStyleBackColor = false;
            this.productsBtn.Click += new System.EventHandler(this.productsBtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(352, 31);
            this.button1.TabIndex = 10;
            this.button1.Text = "Add And Edit Supplier and Customers";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // spbtn
            // 
            this.spbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.spbtn.Font = new System.Drawing.Font("Tempus Sans ITC", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spbtn.Location = new System.Drawing.Point(1, 201);
            this.spbtn.Name = "spbtn";
            this.spbtn.Size = new System.Drawing.Size(352, 40);
            this.spbtn.TabIndex = 11;
            this.spbtn.Text = "Add And Edit Supply Permission";
            this.spbtn.UseVisualStyleBackColor = false;
            this.spbtn.Click += new System.EventHandler(this.spbtn_Click);
            // 
            // transformationBtn
            // 
            this.transformationBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.transformationBtn.Font = new System.Drawing.Font("Tempus Sans ITC", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transformationBtn.Location = new System.Drawing.Point(1, 237);
            this.transformationBtn.Name = "transformationBtn";
            this.transformationBtn.Size = new System.Drawing.Size(352, 29);
            this.transformationBtn.TabIndex = 12;
            this.transformationBtn.Text = "transformation";
            this.transformationBtn.UseVisualStyleBackColor = false;
            this.transformationBtn.Click += new System.EventHandler(this.transformationBtn_Click);
            // 
            // ReportOnInventoryBTN
            // 
            this.ReportOnInventoryBTN.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ReportOnInventoryBTN.Font = new System.Drawing.Font("Tempus Sans ITC", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportOnInventoryBTN.Location = new System.Drawing.Point(1, 263);
            this.ReportOnInventoryBTN.Name = "ReportOnInventoryBTN";
            this.ReportOnInventoryBTN.Size = new System.Drawing.Size(352, 29);
            this.ReportOnInventoryBTN.TabIndex = 13;
            this.ReportOnInventoryBTN.Text = "ReportOnInventory";
            this.ReportOnInventoryBTN.UseVisualStyleBackColor = false;
            this.ReportOnInventoryBTN.Click += new System.EventHandler(this.ReportOnInventory_Click);
            // 
            // ProductsRepo
            // 
            this.ProductsRepo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ProductsRepo.Font = new System.Drawing.Font("Tempus Sans ITC", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductsRepo.Location = new System.Drawing.Point(1, 289);
            this.ProductsRepo.Name = "ProductsRepo";
            this.ProductsRepo.Size = new System.Drawing.Size(352, 30);
            this.ProductsRepo.TabIndex = 14;
            this.ProductsRepo.Text = "ReportOnProducts";
            this.ProductsRepo.UseVisualStyleBackColor = false;
            this.ProductsRepo.Click += new System.EventHandler(this.ProductsRepo_Click);
            // 
            // Transfererepoo
            // 
            this.Transfererepoo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Transfererepoo.Font = new System.Drawing.Font("Tempus Sans ITC", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Transfererepoo.Location = new System.Drawing.Point(1, 315);
            this.Transfererepoo.Name = "Transfererepoo";
            this.Transfererepoo.Size = new System.Drawing.Size(352, 30);
            this.Transfererepoo.TabIndex = 15;
            this.Transfererepoo.Text = "ReportOnTransfereproducts";
            this.Transfererepoo.UseVisualStyleBackColor = false;
            this.Transfererepoo.Click += new System.EventHandler(this.Transfererepoo_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("Tempus Sans ITC", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1, 341);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(352, 30);
            this.button2.TabIndex = 16;
            this.button2.Text = "Reportonproducswithtime";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Font = new System.Drawing.Font("Tempus Sans ITC", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(1, 377);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(352, 30);
            this.button3.TabIndex = 17;
            this.button3.Text = "ProtectsCloseToExpire";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Transfererepoo);
            this.Controls.Add(this.ProductsRepo);
            this.Controls.Add(this.ReportOnInventoryBTN);
            this.Controls.Add(this.transformationBtn);
            this.Controls.Add(this.spbtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.productsBtn);
            this.Controls.Add(this.EditInventoryBtn);
            this.Controls.Add(this.InventoryGridView);
            this.Controls.Add(this.AdminTxt);
            this.Controls.Add(this.AddressTxt);
            this.Controls.Add(this.Adminlabl);
            this.Controls.Add(this.Addresslabl);
            this.Controls.Add(this.AddInventoryBtn);
            this.Controls.Add(this.NameTxt);
            this.Controls.Add(this.NameLabl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InventoryGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabl;
        private System.Windows.Forms.TextBox NameTxt;
        private System.Windows.Forms.Button AddInventoryBtn;
        private System.Windows.Forms.Label Addresslabl;
        private System.Windows.Forms.Label Adminlabl;
        private System.Windows.Forms.TextBox AddressTxt;
        private System.Windows.Forms.TextBox AdminTxt;
        private System.Windows.Forms.DataGridView InventoryGridView;
        private System.Windows.Forms.Button EditInventoryBtn;
        private System.Windows.Forms.Button productsBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button spbtn;
        private System.Windows.Forms.Button transformationBtn;
        private System.Windows.Forms.Button ReportOnInventoryBTN;
        private System.Windows.Forms.Button ProductsRepo;
        private System.Windows.Forms.Button Transfererepoo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

