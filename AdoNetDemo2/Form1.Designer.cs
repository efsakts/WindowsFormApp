
namespace AdoNetDemo2
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
            this.dwgProducts = new System.Windows.Forms.DataGridView();
            this.labelname = new System.Windows.Forms.Label();
            this.labelunitp = new System.Windows.Forms.Label();
            this.labelstock = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxUnitp = new System.Windows.Forms.TextBox();
            this.tbxStock = new System.Windows.Forms.TextBox();
            this.gbxAdd = new System.Windows.Forms.GroupBox();
            this.buttonadd = new System.Windows.Forms.Button();
            this.groupBoxupdate = new System.Windows.Forms.GroupBox();
            this.buttonupdate = new System.Windows.Forms.Button();
            this.textboxstockup = new System.Windows.Forms.TextBox();
            this.labelnameupdate = new System.Windows.Forms.Label();
            this.textBoxunitup = new System.Windows.Forms.TextBox();
            this.labelupriceupdate = new System.Windows.Forms.Label();
            this.textBoxnameup = new System.Windows.Forms.TextBox();
            this.labelstockupdate = new System.Windows.Forms.Label();
            this.buttonremove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dwgProducts)).BeginInit();
            this.gbxAdd.SuspendLayout();
            this.groupBoxupdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // dwgProducts
            // 
            this.dwgProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dwgProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dwgProducts.Location = new System.Drawing.Point(101, 12);
            this.dwgProducts.Name = "dwgProducts";
            this.dwgProducts.RowHeadersWidth = 51;
            this.dwgProducts.RowTemplate.Height = 24;
            this.dwgProducts.Size = new System.Drawing.Size(458, 149);
            this.dwgProducts.TabIndex = 0;
            this.dwgProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dwgProducts_CellClick);
            this.dwgProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dwgProducts_CellContentClick);
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.labelname.Location = new System.Drawing.Point(47, 65);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(49, 17);
            this.labelname.TabIndex = 1;
            this.labelname.Text = "Name:";
            this.labelname.Click += new System.EventHandler(this.labelname_Click);
            // 
            // labelunitp
            // 
            this.labelunitp.AutoSize = true;
            this.labelunitp.Location = new System.Drawing.Point(47, 109);
            this.labelunitp.Name = "labelunitp";
            this.labelunitp.Size = new System.Drawing.Size(73, 17);
            this.labelunitp.TabIndex = 2;
            this.labelunitp.Text = "Unit Price:";
            // 
            // labelstock
            // 
            this.labelstock.AutoSize = true;
            this.labelstock.Location = new System.Drawing.Point(47, 159);
            this.labelstock.Name = "labelstock";
            this.labelstock.Size = new System.Drawing.Size(47, 17);
            this.labelstock.TabIndex = 3;
            this.labelstock.Text = "Stock:";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(195, 60);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(100, 22);
            this.tbxName.TabIndex = 4;
            this.tbxName.TextChanged += new System.EventHandler(this.tbxName_TextChanged);
            // 
            // tbxUnitp
            // 
            this.tbxUnitp.Location = new System.Drawing.Point(195, 103);
            this.tbxUnitp.Name = "tbxUnitp";
            this.tbxUnitp.Size = new System.Drawing.Size(100, 22);
            this.tbxUnitp.TabIndex = 5;
            this.tbxUnitp.TextChanged += new System.EventHandler(this.tbxUnitp_TextChanged);
            // 
            // tbxStock
            // 
            this.tbxStock.Location = new System.Drawing.Point(195, 153);
            this.tbxStock.Name = "tbxStock";
            this.tbxStock.Size = new System.Drawing.Size(100, 22);
            this.tbxStock.TabIndex = 6;
            this.tbxStock.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // gbxAdd
            // 
            this.gbxAdd.Controls.Add(this.buttonadd);
            this.gbxAdd.Controls.Add(this.tbxStock);
            this.gbxAdd.Controls.Add(this.labelname);
            this.gbxAdd.Controls.Add(this.tbxUnitp);
            this.gbxAdd.Controls.Add(this.labelunitp);
            this.gbxAdd.Controls.Add(this.tbxName);
            this.gbxAdd.Controls.Add(this.labelstock);
            this.gbxAdd.Location = new System.Drawing.Point(48, 176);
            this.gbxAdd.Name = "gbxAdd";
            this.gbxAdd.Size = new System.Drawing.Size(344, 223);
            this.gbxAdd.TabIndex = 7;
            this.gbxAdd.TabStop = false;
            this.gbxAdd.Text = "add a product";
            // 
            // buttonadd
            // 
            this.buttonadd.Location = new System.Drawing.Point(216, 194);
            this.buttonadd.Name = "buttonadd";
            this.buttonadd.Size = new System.Drawing.Size(75, 23);
            this.buttonadd.TabIndex = 7;
            this.buttonadd.Text = "add";
            this.buttonadd.UseVisualStyleBackColor = true;
            this.buttonadd.Click += new System.EventHandler(this.buttonadd_Click);
            // 
            // groupBoxupdate
            // 
            this.groupBoxupdate.Controls.Add(this.buttonupdate);
            this.groupBoxupdate.Controls.Add(this.textboxstockup);
            this.groupBoxupdate.Controls.Add(this.labelnameupdate);
            this.groupBoxupdate.Controls.Add(this.textBoxunitup);
            this.groupBoxupdate.Controls.Add(this.labelupriceupdate);
            this.groupBoxupdate.Controls.Add(this.textBoxnameup);
            this.groupBoxupdate.Controls.Add(this.labelstockupdate);
            this.groupBoxupdate.Location = new System.Drawing.Point(407, 176);
            this.groupBoxupdate.Name = "groupBoxupdate";
            this.groupBoxupdate.Size = new System.Drawing.Size(344, 223);
            this.groupBoxupdate.TabIndex = 8;
            this.groupBoxupdate.TabStop = false;
            this.groupBoxupdate.Text = "update a product";
            this.groupBoxupdate.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // buttonupdate
            // 
            this.buttonupdate.Location = new System.Drawing.Point(216, 194);
            this.buttonupdate.Name = "buttonupdate";
            this.buttonupdate.Size = new System.Drawing.Size(75, 23);
            this.buttonupdate.TabIndex = 7;
            this.buttonupdate.Text = "update";
            this.buttonupdate.UseVisualStyleBackColor = true;
            this.buttonupdate.Click += new System.EventHandler(this.buttonupdate_Click);
            // 
            // textboxstockup
            // 
            this.textboxstockup.Location = new System.Drawing.Point(195, 153);
            this.textboxstockup.Name = "textboxstockup";
            this.textboxstockup.Size = new System.Drawing.Size(100, 22);
            this.textboxstockup.TabIndex = 6;
            // 
            // labelnameupdate
            // 
            this.labelnameupdate.AutoSize = true;
            this.labelnameupdate.Location = new System.Drawing.Point(47, 65);
            this.labelnameupdate.Name = "labelnameupdate";
            this.labelnameupdate.Size = new System.Drawing.Size(49, 17);
            this.labelnameupdate.TabIndex = 1;
            this.labelnameupdate.Text = "Name:";
            // 
            // textBoxunitup
            // 
            this.textBoxunitup.Location = new System.Drawing.Point(195, 103);
            this.textBoxunitup.Name = "textBoxunitup";
            this.textBoxunitup.Size = new System.Drawing.Size(100, 22);
            this.textBoxunitup.TabIndex = 5;
            // 
            // labelupriceupdate
            // 
            this.labelupriceupdate.AutoSize = true;
            this.labelupriceupdate.Location = new System.Drawing.Point(47, 109);
            this.labelupriceupdate.Name = "labelupriceupdate";
            this.labelupriceupdate.Size = new System.Drawing.Size(73, 17);
            this.labelupriceupdate.TabIndex = 2;
            this.labelupriceupdate.Text = "Unit Price:";
            // 
            // textBoxnameup
            // 
            this.textBoxnameup.Location = new System.Drawing.Point(195, 60);
            this.textBoxnameup.Name = "textBoxnameup";
            this.textBoxnameup.Size = new System.Drawing.Size(100, 22);
            this.textBoxnameup.TabIndex = 4;
            this.textBoxnameup.TextChanged += new System.EventHandler(this.textBoxnameup_TextChanged);
            // 
            // labelstockupdate
            // 
            this.labelstockupdate.AutoSize = true;
            this.labelstockupdate.Location = new System.Drawing.Point(47, 159);
            this.labelstockupdate.Name = "labelstockupdate";
            this.labelstockupdate.Size = new System.Drawing.Size(47, 17);
            this.labelstockupdate.TabIndex = 3;
            this.labelstockupdate.Text = "Stock:";
            // 
            // buttonremove
            // 
            this.buttonremove.Location = new System.Drawing.Point(386, 415);
            this.buttonremove.Name = "buttonremove";
            this.buttonremove.Size = new System.Drawing.Size(117, 23);
            this.buttonremove.TabIndex = 9;
            this.buttonremove.Text = "remove";
            this.buttonremove.UseVisualStyleBackColor = true;
            this.buttonremove.Click += new System.EventHandler(this.buttonremove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonremove);
            this.Controls.Add(this.groupBoxupdate);
            this.Controls.Add(this.gbxAdd);
            this.Controls.Add(this.dwgProducts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dwgProducts)).EndInit();
            this.gbxAdd.ResumeLayout(false);
            this.gbxAdd.PerformLayout();
            this.groupBoxupdate.ResumeLayout(false);
            this.groupBoxupdate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dwgProducts;
        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.Label labelunitp;
        private System.Windows.Forms.Label labelstock;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxUnitp;
        private System.Windows.Forms.TextBox tbxStock;
        private System.Windows.Forms.GroupBox gbxAdd;
        private System.Windows.Forms.Button buttonadd;
        private System.Windows.Forms.GroupBox groupBoxupdate;
        private System.Windows.Forms.Button buttonupdate;
        private System.Windows.Forms.TextBox textboxstockup;
        private System.Windows.Forms.Label labelnameupdate;
        private System.Windows.Forms.TextBox textBoxunitup;
        private System.Windows.Forms.Label labelupriceupdate;
        private System.Windows.Forms.TextBox textBoxnameup;
        private System.Windows.Forms.Label labelstockupdate;
        private System.Windows.Forms.Button buttonremove;
    }
}

