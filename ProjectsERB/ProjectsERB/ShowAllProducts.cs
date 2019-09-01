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
    public partial class ShowAllProducts : Form

    {
      //  public int IDPro { get; set; }
        ERBContext context = new ERBContext();
       
        public ShowAllProducts()
        {
            InitializeComponent();
        }
        private void ShowAllProduct()
        {
            Datagridviewshow.Rows.Clear();
            context = new ERBContext();
            var query2 = (from p in context.Products
                         select p).ToList();
            foreach (var item in query2)
            {
                test(item.Name, item.PriceIn, item.PriceOutAll, item.PriceOutOne, item.Quantity,item.ID);
            }
        }

        private void test(string name,decimal PriceIn, decimal PriceOutAll, decimal PriceOutOne, decimal Quantity,int ID) {
          
            DataGridViewRow row = (DataGridViewRow)Datagridviewshow.Rows[0].Clone();
            row.Cells[0].Value = name;
            row.Cells[1].Value = PriceIn;
            row.Cells[2].Value = PriceOutAll;
            row.Cells[3].Value = PriceOutOne;
            row.Cells[4].Value = Quantity;
            row.Cells[5].Value = ID;
            Datagridviewshow.Rows.Add(row);
        }


        private void AddProduct_Click(object sender, EventArgs e)
        {
            AddProduct AP = new AddProduct();
            AP.ShowDialog();            
            ShowAllProduct();
        }

        private void DeleteProduct_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = int.Parse(Datagridviewshow.SelectedRows[0].Cells[5].Value.ToString());
                var query = (from p in context.Products
                             where p.ID == ID
                             select p).FirstOrDefault();
                context.Products.Remove(query);
                context.SaveChanges();
                ShowAllProduct();
            }
            catch(Exception es)
            {
                MessageBox.Show("من فضلك اختار المنتج الذى تريد مسحه ");
            }
           
        }

        private void UpdateProduct_Click(object sender, EventArgs e)
        {

           
                UpdateProduct Update = new UpdateProduct();

                //Update.Name= Datagridviewshow.SelectedRows[0].Cells[0].Value.ToString();
                //Update.PriceIn = decimal.Parse(Datagridviewshow.SelectedRows[0].Cells[1].Value.ToString());
                //Update.PriceOutAll = decimal.Parse(Datagridviewshow.SelectedRows[0].Cells[2].Value.ToString());
                //Update.PriceOutOne = decimal.Parse(Datagridviewshow.SelectedRows[0].Cells[3].Value.ToString());
                //Update.Quantity = int.Parse(Datagridviewshow.SelectedRows[0].Cells[4].Value.ToString());
                //Update.ID = int.Parse(Datagridviewshow.SelectedRows[0].Cells[5].Value.ToString());
              Update.IDPro = int.Parse(Datagridviewshow.SelectedRows[0].Cells[5].Value.ToString());
                 Update.Visible = false;
                Update.ShowDialog();
            ShowAllProduct();

        }

        private void ShowAllProducts_Load(object sender, EventArgs e)
        {
            ShowAllProduct();

        }
    }
}
