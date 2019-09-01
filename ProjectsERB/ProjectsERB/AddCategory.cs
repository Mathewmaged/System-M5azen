using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Elm5zenDatabase;

namespace ProjectsERB
{
    public partial class AddCategory : Form
    {
        ERBContext context = new ERBContext();
        //Categories cat = new Categories();


        public AddCategory()
        {
            InitializeComponent();
            
        }

        private void ShowCategories() {
            context = new ERBContext();
            var query = (context.categories).ToList();
            listBoxCategories.DisplayMember = "Name";
            listBoxCategories.ValueMember = "ID";
            listBoxCategories.DataSource = query;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var query = (from cat in context.categories
                         where cat.Name.Equals(textNameOfCat.Text)
                         select cat.Name).Count();

            if (textNameOfCat.Text.Length >= 1 && textNameOfCat.Text != " ")
            {
                Categories cat = new Categories();

                if (query == 0)
                {
                    cat.Name = textNameOfCat.Text;
                    context.categories.Add(cat);
                    context.SaveChanges();
                    textNameOfCat.Text = "";
                    ShowCategories();
                }
                else
                {
                    MessageBox.Show("تم ادخل هذا الصنف من قبل");
                    textNameOfCat.Text = "";
                }

            }
            else
            {
                MessageBox.Show("من فضلك ادخل اسم الصنف");
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string test = listBoxCategories.GetItemText(listBoxCategories.SelectedItem).ToString();
            UpdateCategory uc = new UpdateCategory();
            uc.categoryName = test;
            uc.ID = int.Parse(listBoxCategories.SelectedValue.ToString());
            uc.ShowDialog();
            ShowCategories();
               }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(listBoxCategories.SelectedValue.ToString());
            var quer = (from cat in context.categories
                        where cat.ID == ID
                        select cat).FirstOrDefault();
            context.categories.Remove(quer);
            context.SaveChanges();
            ShowCategories();
        }

        private void buttonAddSub_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddCategory_Load(object sender, EventArgs e)
        {
            ShowCategories();
        }
    }                     
}
