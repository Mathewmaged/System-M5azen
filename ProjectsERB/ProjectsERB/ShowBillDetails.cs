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
    public partial class ShowBillDetails : Form
    {
        ERBContext context = new ERBContext();
        //SellPermission SellPermission = new SellPermission();
        public int Value { get; set; }
        public ShowBillDetails()
        {
            InitializeComponent();

           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void ShowBillDetails_Load(object sender, EventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            int getId = Value;
            var BillData = (from i in context.invoice_products
                            where i.Invoice_ID == getId
                            select i).ToList();
            int c = 0;
            foreach (var item in BillData)
            {
                row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[0].Value = item.Products.Name;
                row.Cells[1].Value = item.Quantity;
                row.Cells[2].Value = item.Products.PriceOutOne * item.Quantity;
                row.Cells[3].Value = item.SerialNumber;
                dataGridView1.Rows.Add(row);
                c++;
            }
        }
    }
}
