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
    public partial class UpdateProduct : Form
    {
        ERBContext context = new ERBContext();
        public int IDPro { get; set; }
        public UpdateProduct()
        {
            InitializeComponent();
        }
     
        private void showCat()
        {
            var query = (from cat in context.categories
                         select cat.Name).ToList();
            NameOfCat.DisplayMember = "Name";
            NameOfCat.ValueMember = "ID";
            NameOfCat.DataSource = query;
        }
        private void SaveProduct_Click(object sender, EventArgs e)
        {
            var query = (from p in context.Products
                         where p.ID == IDPro
                         select p).FirstOrDefault();

            int ID = (from cat in context.categories
                      where cat.Name == NameOfCat.SelectedValue.ToString()
                      select cat.ID).FirstOrDefault();
            query.Name = NameOfProduct.Text;
           query.PriceIn= priceIn.Value;
            query.PriceOutAll = priceOutAll.Value;
            query.PriceOutOne = priceOutOne.Value;
            query.Quantity= (int)countity.Value;
            query.Categories_ID = ID;

            var query2 = (from pro in context.Products
                         where pro.Name == NameOfProduct.Text
                          select pro).FirstOrDefault();
            var query3 = (from p in context.Products
                         where p.ID == IDPro
                         select p).FirstOrDefault();
            //if (query2 == 1 && NameOfProduct.Text== query3.Name && NameOfProduct.Text != " " 
            //    && NameOfProduct.Text != null && NameOfProduct.Text.Length >= 1
            //    && priceIn.Value > 0 && priceOutOne.Value > 0 
            //    && priceOutAll.Value > 0 && countity.Value > 0)
            //{
            //    context.SaveChanges();

            //}
             if (query2 == null && NameOfProduct.Text != " " &&
                  NameOfProduct.Text != null && NameOfProduct.Text.Length >= 1
                && priceIn.Value >= 0 && priceOutOne.Value >= 0 
                && priceOutAll.Value >= 0 && countity.Value >= 0)
            {
                context.SaveChanges();
                 this.Close();
            }
            else
            {
                if (query2 != null)
                {
                    if(query2.ID==query.ID && NameOfProduct.Text != " " &&
                  NameOfProduct.Text != null && NameOfProduct.Text.Length >= 1
                && priceIn.Value >= 0 && priceOutOne.Value >= 0
                && priceOutAll.Value >= 0 && countity.Value >= 0)
                    {
                        context.SaveChanges();
                        this.Close();
                    }
                    else if(query2.ID!=query.ID)
                    {
                        MessageBox.Show("من فضلك ادخل اسم المنتج صيحيح بدون تكرار مع اسم منتج اخر");
                    }
                    else if (NameOfProduct.Text == " " && NameOfProduct.Text == null
                    && NameOfProduct.Text.Length < 1)
                        MessageBox.Show("من فضلك ادخل اسم المنتج");
                    else
                        MessageBox.Show("من فضلك ادخل قيمة");
                }
                else if (NameOfProduct.Text == " " && NameOfProduct.Text == null 
                    && NameOfProduct.Text.Length < 1)
                    MessageBox.Show("من فضلك ادخل اسم المنتج");
                else
                    MessageBox.Show("من فضلك ادخل قيمة");
            }

        }

        private void UpdateProduct_Load(object sender, EventArgs e)
        {
            

            var query = (from p in context.Products
                         where p.ID == IDPro
                         select p).FirstOrDefault();
            var query2 = (from cat in context.categories
                          select cat.Name).ToList();
            NameOfCat.DisplayMember = "Name";
            NameOfCat.ValueMember = "ID";
            NameOfCat.DataSource = query2;

            var query3 = (from p in context.categories
                          where p.ID == query.Categories_ID
                          select p.Name).FirstOrDefault();
            NameOfCat.SelectedItem = query3;
            NameOfProduct.Text = query.Name;
            priceIn.Value = query.PriceIn;
            priceOutAll.Value = query.PriceOutAll;
            priceOutOne.Value = query.PriceOutOne;
            countity.Value = query.Quantity;
        }
    }
}
