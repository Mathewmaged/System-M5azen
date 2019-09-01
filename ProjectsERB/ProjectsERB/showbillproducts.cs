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
    public partial class showbillproducts : Form
    {
        ERBContext context = new ERBContext();
        public showbillproducts()
        {
            InitializeComponent();
        }
        public int inovice_id { get; set; }
        public int pricetype { get; set; }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void add_drg(string column0, string column1, string column2, string column3)
        {
            DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
            row.Cells[0].Value = column0;
            row.Cells[1].Value = column1;
            row.Cells[2].Value = column2;
            row.Cells[3].Value = column3;
          
            
            

            dataGridView1.Rows.Add(row);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showbillproducts_Load(object sender, EventArgs e)
        {
            var invoicesprod = context.invoice_products.Where(i => i.Invoice_ID == inovice_id);
            int count = 1;
            foreach (var item in invoicesprod)
            {
                if (pricetype == 0)
                {
                    add_drg(count.ToString()
                        , item.Products.Name
                        , item.Quantity.ToString()
                        , item.Products.PriceIn.ToString());
                }
                else if (pricetype == 1)
                {
                    add_drg(count.ToString()
                        , item.Products.Name
                        , item.Quantity.ToString()
                        , item.Products.PriceOutAll.ToString());
                }
                else if (pricetype == 2)
                {
                    add_drg(count.ToString()
                        , item.Products.Name
                        , item.Quantity.ToString()
                        , item.Products.PriceOutOne.ToString());
                }
                count++;

            }
        }
    }
}
