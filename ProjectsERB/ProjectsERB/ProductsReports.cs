using Elm5zenDatabase;
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
    public partial class ProductsReports : Form
    {
        ERBContext context = new ERBContext();
        public ProductsReports()
        {
            InitializeComponent();

           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            search();
        }
        void search()
        {
            dataGridView1.Rows.Clear();
            int selectedItem = int.Parse(comboBox1.SelectedValue.ToString());
            DateTime datefrom = (dateTimePicker1.Value).Date;
            DateTime dateto = (dateTimePicker2.Value).Date;
            DataGridViewRow row = new DataGridViewRow();
            var prodata = (from i in context.Products
                           where i.Categories_ID == selectedItem
                           select i).ToList();

            int c = 0;
            foreach (var item in prodata)
            {
                int totalin = 0;
                int totalout = 0;
                row = (DataGridViewRow)dataGridView1.Rows[c].Clone();
                row.Cells[0].Value = item.Name;
                var Quantin = (from n in context.invoice_products
                               where n.Products.Name == item.Name
                               && n.Invoice.InvoiceType_ID == 1
                               && (n.Invoice.BillDate >= datefrom.Date
                               && n.Invoice.BillDate <= dateto.Date)
                               select n.Quantity).ToList();


              

                var Quantout = (from n in context.invoice_products
                                where n.Products.Name == item.Name
                                && n.Invoice.InvoiceType_ID == 2
                                && (n.Invoice.BillDate >= datefrom.Date
                                && n.Invoice.BillDate <= dateto.Date)
                                select n.Quantity).ToList();



                if (Quantin != null && Quantout != null)
                {
                    foreach (var item1 in Quantin)
                    {
                        totalin = totalin + item1;
                    }
                    foreach (var item1 in Quantout)
                    {
                        totalout = totalout + item1;
                    }
                    row.Cells[1].Value = totalin + totalout;
                    row.Cells[2].Value = totalout;
                    row.Cells[3].Value = totalin;

                    dataGridView1.Rows.Add(row);
                    c++;
                }
                else
                    MessageBox.Show("لا يوجد يبانات في هذا التاريخ", "خطأ");
            }
        }
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            search();
        }

        private void ProductsReports_Load(object sender, EventArgs e)
        {
            //category List
            var data = (from i in context.categories
                        select i).ToList();
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "ID";
            comboBox1.DataSource = data;
        }
    }
}
