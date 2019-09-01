namespace ProjectsERB
{
    partial class AddProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProduct));
            this.NameOfCat = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NameOfProduct = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.countity = new System.Windows.Forms.NumericUpDown();
            this.priceOutAll = new System.Windows.Forms.NumericUpDown();
            this.priceOutOne = new System.Windows.Forms.NumericUpDown();
            this.priceIn = new System.Windows.Forms.NumericUpDown();
            this.SaveProduct = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.countity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceOutAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceOutOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceIn)).BeginInit();
            this.SuspendLayout();
            // 
            // NameOfCat
            // 
            this.NameOfCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NameOfCat.FormattingEnabled = true;
            this.NameOfCat.Location = new System.Drawing.Point(313, 25);
            this.NameOfCat.Name = "NameOfCat";
            this.NameOfCat.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NameOfCat.Size = new System.Drawing.Size(136, 21);
            this.NameOfCat.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(471, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "اسم الصنف";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(471, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "اسم المنتج";
            // 
            // NameOfProduct
            // 
            this.NameOfProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameOfProduct.Location = new System.Drawing.Point(268, 87);
            this.NameOfProduct.Multiline = true;
            this.NameOfProduct.Name = "NameOfProduct";
            this.NameOfProduct.Size = new System.Drawing.Size(181, 42);
            this.NameOfProduct.TabIndex = 2;
            this.NameOfProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(154, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "سعر الشراء";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(463, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "سعر البيع جملة";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(138, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "سعر البيع قطاعى";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(471, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "الكمية";
            // 
            // countity
            // 
            this.countity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countity.Location = new System.Drawing.Point(329, 243);
            this.countity.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.countity.Name = "countity";
            this.countity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.countity.Size = new System.Drawing.Size(120, 24);
            this.countity.TabIndex = 3;
            this.countity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // priceOutAll
            // 
            this.priceOutAll.DecimalPlaces = 2;
            this.priceOutAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceOutAll.Location = new System.Drawing.Point(329, 178);
            this.priceOutAll.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.priceOutAll.Name = "priceOutAll";
            this.priceOutAll.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.priceOutAll.Size = new System.Drawing.Size(120, 24);
            this.priceOutAll.TabIndex = 3;
            this.priceOutAll.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // priceOutOne
            // 
            this.priceOutOne.DecimalPlaces = 2;
            this.priceOutOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceOutOne.Location = new System.Drawing.Point(12, 178);
            this.priceOutOne.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.priceOutOne.Name = "priceOutOne";
            this.priceOutOne.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.priceOutOne.Size = new System.Drawing.Size(120, 24);
            this.priceOutOne.TabIndex = 3;
            this.priceOutOne.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // priceIn
            // 
            this.priceIn.DecimalPlaces = 2;
            this.priceIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceIn.Location = new System.Drawing.Point(12, 98);
            this.priceIn.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.priceIn.Name = "priceIn";
            this.priceIn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.priceIn.Size = new System.Drawing.Size(120, 24);
            this.priceIn.TabIndex = 3;
            this.priceIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // SaveProduct
            // 
            this.SaveProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveProduct.Location = new System.Drawing.Point(367, 313);
            this.SaveProduct.Name = "SaveProduct";
            this.SaveProduct.Size = new System.Drawing.Size(110, 39);
            this.SaveProduct.TabIndex = 4;
            this.SaveProduct.Text = "حفظ";
            this.SaveProduct.UseVisualStyleBackColor = true;
            this.SaveProduct.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(210, 313);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 39);
            this.button1.TabIndex = 5;
            this.button1.Text = "أضافة اسم صنف";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(91, 313);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 39);
            this.button2.TabIndex = 6;
            this.button2.Text = "اغلاق";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(574, 364);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SaveProduct);
            this.Controls.Add(this.priceIn);
            this.Controls.Add(this.priceOutOne);
            this.Controls.Add(this.priceOutAll);
            this.Controls.Add(this.countity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NameOfProduct);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameOfCat);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddProduct";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافة متنج";
            this.Load += new System.EventHandler(this.AddProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.countity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceOutAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceOutOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceIn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox NameOfCat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NameOfProduct;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown countity;
        private System.Windows.Forms.NumericUpDown priceOutAll;
        private System.Windows.Forms.NumericUpDown priceOutOne;
        private System.Windows.Forms.NumericUpDown priceIn;
        private System.Windows.Forms.Button SaveProduct;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}