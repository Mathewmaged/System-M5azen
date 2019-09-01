using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectsERB
{
    public partial class UpdateCategory : Form
    {
        ERBContext context = new ERBContext();
        public UpdateCategory()
        {
            InitializeComponent();
        }
        public string categoryName { get; set; }
        public int countclick { get; set; }
        public int ID { get; set; }
        private void UpdateCategory_Load(object sender, EventArgs e)
        {
            updatetextbox.Text = categoryName;
        }

        private void SaveUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                countclick = 1;
                categoryName = updatetextbox.Text;             
                if (categoryName.Length >= 1 && categoryName != "" && categoryName != null)
                {
                    
                    var query2 = (from cat in context.categories
                                  where cat.Name.Equals(categoryName)
                                  select cat).Count();
                    if (query2 == 0)
                    {
                        var query = (from cat in context.categories
                                     where cat.ID == ID
                                     select cat).FirstOrDefault();
                        query.Name = categoryName;
                        context.SaveChanges();
                        this.Close();
                    }
                    else
                        MessageBox.Show("هذا الصنف موجود مسبقا");
                   
                }
                else
                {
                    MessageBox.Show("من فضلك ادخل اسم الصنف صحيحا");
                }
            }
            catch (Exception ex) {
               MessageBox.Show(ex.Message);
                //MessageBox.Show("من فضلك ادخل اسم الصنف صحيحا");
               
            }

        }
    }
}
