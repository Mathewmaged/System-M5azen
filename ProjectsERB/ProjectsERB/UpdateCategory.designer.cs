namespace ProjectsERB
{
    partial class UpdateCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateCategory));
            this.updatetextbox = new System.Windows.Forms.TextBox();
            this.SaveUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // updatetextbox
            // 
            this.updatetextbox.Location = new System.Drawing.Point(54, 45);
            this.updatetextbox.Name = "updatetextbox";
            this.updatetextbox.Size = new System.Drawing.Size(131, 20);
            this.updatetextbox.TabIndex = 0;
            // 
            // SaveUpdate
            // 
            this.SaveUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveUpdate.Location = new System.Drawing.Point(54, 156);
            this.SaveUpdate.Name = "SaveUpdate";
            this.SaveUpdate.Size = new System.Drawing.Size(162, 29);
            this.SaveUpdate.TabIndex = 1;
            this.SaveUpdate.Text = "حفظ التعديل";
            this.SaveUpdate.UseVisualStyleBackColor = true;
            this.SaveUpdate.Click += new System.EventHandler(this.SaveUpdate_Click);
            // 
            // UpdateCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.SaveUpdate);
            this.Controls.Add(this.updatetextbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdateCategory";
            this.Text = "UpdateCategory";
            this.Load += new System.EventHandler(this.UpdateCategory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox updatetextbox;
        private System.Windows.Forms.Button SaveUpdate;
    }
}