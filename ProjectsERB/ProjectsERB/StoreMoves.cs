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
    public partial class StoreMoves : Form
    {
        public StoreMoves()
        {
            InitializeComponent();
        }
        ERBContext context = new ERBContext();
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = context.invoices.Where(ps => ps.InvoiceType_ID == 1
            && dateTimePicker1.Value.Date <= ps.BillDate
            && ps.BillDate >= dateTimePicker2.Value.Date).Select(p => new { p.ID, p.BillDate, InvoiceType = p.InvoiceType.TypeName, PriceType = p.invoiceTypePrice.Name, PaymentType = p.Payment_Type.TypeName, SupplierName = p.Person.Name, p.TotalBill, p.TotalCash, p.TotalReset }).ToList();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = context.invoices.Where(ps => ps.InvoiceType_ID == 2
            && dateTimePicker3.Value.Date <= ps.BillDate
            && ps.BillDate >= dateTimePicker4.Value.Date).Select(p=>new {p.ID,p.BillDate,InvoiceType=p.InvoiceType.TypeName,PriceType=p.invoiceTypePrice.Name,PaymentType=p.Payment_Type.TypeName,SupplierName=p.Person.Name,p.TotalBill,p.TotalCash,p.TotalReset }).ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView3.DataSource = context.invoices.Where(ps => ps.InvoiceType_ID == 6
            && dateTimePicker5.Value.Date <= ps.BillDate
            && ps.BillDate >= dateTimePicker6.Value.Date).Select(p => new { p.ID, p.BillDate, InvoiceType = p.InvoiceType.TypeName, PriceType = p.invoiceTypePrice.Name, PaymentType = p.Payment_Type.TypeName, SupplierName = p.Person.Name, p.TotalBill, p.TotalCash, p.TotalReset }).ToList();
        }

        private void materialTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePicker4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView4.DataSource = context.invoices.Where(ps => ps.InvoiceType_ID == 5
            && dateTimePicker5.Value.Date <= ps.BillDate
            && ps.BillDate >= dateTimePicker6.Value.Date).Select(p => new { p.ID, p.BillDate, InvoiceType = p.InvoiceType.TypeName, PriceType = p.invoiceTypePrice.Name, PaymentType = p.Payment_Type.TypeName, SupplierName = p.Person.Name, p.TotalBill, p.TotalCash, p.TotalReset }).ToList();
        }
    }
}
