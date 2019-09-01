namespace ProjectsERB
{
    partial class UpdateProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateProduct));
            this.SaveProduct = new System.Windows.Forms.Button();
            this.priceIn = new System.Windows.Forms.NumericUpDown();
            this.priceOutOne = new System.Windows.Forms.NumericUpDown();
            this.priceOutAll = new System.Windows.Forms.NumericUpDown();
            this.countity = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NameOfProduct = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NameOfCat = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.priceIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceOutOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceOutAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countity)).BeginInit();
            this.SuspendLayout();
            // 
            // SaveProduct
            // 
            this.SaveProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveProduct.Location = new System.Drawing.Point(235, 298);
            this.SaveProduct.Name = "SaveProduct";
            this.SaveProduct.Size = new System.Drawing.Size(116, 39);
            this.SaveProduct.TabIndex = 17;
            this.SaveProduct.Text = "حفظ";
            this.SaveProduct.UseVisualStyleBackColor = true;
            this.SaveProduct.Click += new System.EventHandler(this.SaveProduct_Click);
            // 
            // priceIn
            // 
            this.priceIn.DecimalPlaces = 2;
            this.priceIn.Location = new System.Drawing.Point(69, 100);
            this.priceIn.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.priceIn.Name = "priceIn";
            this.priceIn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.priceIn.Size = new System.Drawing.Size(120, 20);
            this.priceIn.TabIndex = 13;
            this.priceIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // priceOutOne
            // 
            this.priceOutOne.DecimalPlaces = 2;
            this.priceOutOne.Location = new System.Drawing.Point(69, 180);
            this.priceOutOne.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.priceOutOne.Name = "priceOutOne";
            this.priceOutOne.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.priceOutOne.Size = new System.Drawing.Size(120, 20);
            this.priceOutOne.TabIndex = 14;
            this.priceOutOne.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // priceOutAll
            // 
            this.priceOutAll.DecimalPlaces = 2;
            this.priceOutAll.Location = new System.Drawing.Point(332, 177);
            this.priceOutAll.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.priceOutAll.Name = "priceOutAll";
            this.priceOutAll.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.priceOutAll.Size = new System.Drawing.Size(120, 20);
            this.priceOutAll.TabIndex = 15;
            this.priceOutAll.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // countity
            // 
            this.countity.Location = new System.Drawing.Point(332, 242);
            this.countity.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.countity.Name = "countity";
            this.countity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.countity.Size = new System.Drawing.Size(120, 20);
            this.countity.TabIndex = 16;
            this.countity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(522, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "الكمية";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(467, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "سعر البيع جملة";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(195, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "سعر البيع قطاعى";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(211, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "سعر الشراء";
            // 
            // NameOfProduct
            // 
            this.NameOfProduct.Location = new System.Drawing.Point(316, 97);
            this.NameOfProduct.Name = "NameOfProduct";
            this.NameOfProduct.Size = new System.Drawing.Size(136, 20);
            this.NameOfProduct.TabIndex = 12;
            this.NameOfProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(496, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "اسم المنتج";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(488, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "اسم الصنف";
            // 
            // NameOfCat
            // 
            this.NameOfCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NameOfCat.FormattingEnabled = true;
            this.NameOfCat.Location = new System.Drawing.Point(309, 19);
            this.NameOfCat.Name = "NameOfCat";
            this.NameOfCat.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NameOfCat.Size = new System.Drawing.Size(136, 21);
            this.NameOfCat.TabIndex = 5;
            // 
            // UpdateProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(622, 358);
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
            this.Name = "UpdateProduct";
            this.Text = "تعديل المنتج";
            this.Load += new System.EventHandler(this.UpdateProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.priceIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceOutOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceOutAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveProduct;
        private System.Windows.Forms.NumericUpDown priceIn;
        private System.Windows.Forms.NumericUpDown priceOutOne;
        private System.Windows.Forms.NumericUpDown priceOutAll;
        private System.Windows.Forms.NumericUpDown countity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NameOfProduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox NameOfCat;
    }
}