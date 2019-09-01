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
    public partial class AddProduct : Form
    {
        ERBContext context = new ERBContext();
        //ShowAllProducts SP = new ShowAllProducts();

        public AddProduct()
        {
            InitializeComponent();
        }

        private void showCat() {
            var query = (from cat in context.categories
                         select cat.Name).ToList();
            NameOfCat.DisplayMember = "Name";
            NameOfCat.ValueMember = "ID";
            NameOfCat.DataSource = query;
        }
     
        private void button1_Click(object sender, EventArgs e)
        {
            int ID = (from cat in context.categories
                     where cat.Name == NameOfCat.SelectedValue.ToString()
                     select cat.ID).FirstOrDefault();
            string ProductName = NameOfProduct.Text;
            decimal Pricein = priceIn.Value;
            decimal PriceOutAll = priceOutAll.Value;
            decimal PriceOutOne = priceOutOne.Value;
            int Qoutity = (int)countity.Value;

            var query = (from pro in context.Products
                         where pro.Name == ProductName
                         select pro).Count();

            if (query==0 && ProductName != " " && 
                ProductName != null && ProductName.Length>=1 
                && Pricein > 0 && PriceOutAll > 0 && PriceOutOne >0 && Qoutity > 0)
            {
                context.Products.Add(new Products()
                {
                    PriceIn = Pricein,
                    PriceOutOne = PriceOutOne,
                    PriceOutAll = PriceOutAll,
                    Quantity = Qoutity,
                    Categories_ID = ID,
                    Name = ProductName
                });
                context.SaveChanges();
                NameOfProduct.Text = "";
                priceIn.Value = 0;
                priceOutAll.Value = 0;
                priceOutOne.Value=0;
                countity.Value = 0;
                MessageBox.Show("تم اضافة المنتج");
                //this.Close();
            }
            else
            {
                if(query != 0)
                MessageBox.Show("هذا المنتج موجود مسبقا ");
                else if (ProductName == " " && ProductName == null && ProductName.Length <1)
                    MessageBox.Show("من فضلك ادخل اسم المنتج");
                else
                    MessageBox.Show("من فضلك ادخل قيمة");
            }



        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AddCategory cat = new AddCategory();
            cat.ShowDialog();
            context = new ERBContext();
            showCat();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            showCat();

        }
    }
}
