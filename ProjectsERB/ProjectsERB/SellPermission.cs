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
    public partial class SellPermission : Form
    {
        public ERBContext context = new ERBContext();
        public int Value = 0;
        public SellPermission()
        {
            InitializeComponent();

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //category List
            var data = (from i in context.categories
                        select i).ToList();
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "ID";
            comboBox1.DataSource = data;
            //mndob List
            var mndobdata = (from n in context.person
                             where n.PersonType_ID == 2
                             select n).ToList();
            comboBox2.DisplayMember = "Name";
            comboBox2.ValueMember = "ID";
            comboBox2.DataSource = mndobdata;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedItem = int.Parse(comboBox1.SelectedValue.ToString());
            var quantdata = (from n in context.Products
                             where n.Categories_ID == selectedItem
                             select n).ToList();
            listBox1.DisplayMember = "Name";
            listBox1.ValueMember = "ID";
            listBox1.DataSource = quantdata;
        }
        private void add_drg(string column0, string column1, string column2, string column3)
        {
            DataGridViewRow row = (DataGridViewRow)dataGridView2.Rows[0].Clone();
            row.Cells[0].Value = column0;
            row.Cells[1].Value = column1;
            row.Cells[2].Value = column2;
            row.Cells[3].Value = column3;
            dataGridView2.Rows.Add(row);
        }
       
        private void button1_Click(object sender, EventArgs e)
        {

            #region mathew
            //DataGridViewRow row = new DataGridViewRow();
            //int selectedItem = int.Parse(listBox1.SelectedValue.ToString());
            //var quantdata = (from n in context.Products
            //                 where n.ID == selectedItem
            //                 select n).FirstOrDefault();
            //    int i = 0;
            //    row = (DataGridViewRow)dataGridView2.Rows[i].Clone();
            //    row.Cells[0].Value = quantdata.Name;

            //if (numericUpDown1.Value != 0)
            //{
            //    if (quantdata.Quantity >= numericUpDown1.Value)
            //    {
            //        row.Cells[1].Value = numericUpDown1.Value;
            //        row.Cells[2].Value = quantdata.PriceOutOne * numericUpDown1.Value;
            //        dataGridView2.Rows.Add(row);
            //        i++;
            //    }
            //    else
            //    {
            //        MessageBox.Show("Max Quantity = " + quantdata.Quantity, "Error");
            //    }
            //}
            //else MessageBox.Show("Quantity can't be 0", "Error");
            //int sum = 0;
            //if (numericUpDown1.Value != 0)
            //{
            //    for (int l = 0; l < dataGridView2.Rows.Count; ++l)
            //    {
            //        sum += Convert.ToInt32(dataGridView2.Rows[l].Cells[2].Value);
            //    }
            //    textBox1.Text = sum.ToString();
            //}

            #endregion

            if (listBox1.SelectedItems.Count > 0)
            {
                if (textBox1.Text != "")
                {
                    int prodsids = int.Parse(listBox1.SelectedValue.ToString());
                    var prds = context.invoice_products.Where(iv => iv.SerialNumber == textBox1.Text && iv.Product_ID == prodsids).FirstOrDefault();
                    if (prds != null)
                    {
                        if (numericUpDown1.Value > 0)
                        {

                            int prodID = int.Parse(listBox1.SelectedValue.ToString());
                            var prodin = context.invoice_products.Where(iv => iv.SerialNumber == textBox1.Text && iv.Product_ID == prodsids&&iv.Invoice.InvoiceType_ID==1).Sum(vs=> (int?)vs.Quantity)??0;
                            var prodin2 = context.invoice_products.Where(iv => iv.SerialNumber == textBox1.Text && iv.Product_ID == prodsids && iv.Invoice.InvoiceType_ID == 4).Sum(vs => (int?)vs.Quantity) ?? 0;
                            var prodout1 = context.invoice_products.Where(iv => iv.SerialNumber == textBox1.Text && iv.Product_ID == prodsids && iv.Invoice.InvoiceType_ID == 3).Sum(vs => (int?)vs.Quantity)??0;
                            var prodout2 = context.invoice_products.Where(iv => iv.SerialNumber == textBox1.Text && iv.Product_ID == prodsids && iv.Invoice.InvoiceType_ID == 2).Sum(vs => (int?)vs.Quantity)??0;
                            var prodout3 = context.invoice_products.Where(iv => iv.SerialNumber == textBox1.Text && iv.Product_ID == prodsids && iv.Invoice.InvoiceType_ID == 5).Sum(vs => (int?)vs.Quantity) ?? 0;

                            var totalfound = ((prodin-prodout1)+prodin2)-prodout3;
                            var prod = context.Products.Where(ps => ps.ID == prodID).FirstOrDefault();
                            if (dataGridView2.Rows.Count <= 1)
                            {
                                if (numericUpDown1.Value <= totalfound)
                                {

                                    add_drg(prod.Name, numericUpDown1.Value.ToString(),textBox1.Text, prod.ID.ToString());
                                }
                                else
                                {
                                    MessageBox.Show("الكمية المتاحة : " + totalfound);
                                }
                            }
                            else
                            {
                                bool flag = false;
                                for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
                                {
                                    int id = int.Parse(dataGridView2.Rows[i].Cells[3].Value.ToString());
                                    string serial = dataGridView2.Rows[i].Cells[2].Value.ToString();
                                    if (id == prodID&&serial==textBox1.Text)
                                    {
                                        flag = true;

                                        decimal qunatity = decimal.Parse(dataGridView2.Rows[i].Cells[1].Value.ToString());
                                        if (totalfound >= qunatity + numericUpDown1.Value)
                                        {
                                            dataGridView2.Rows[i].Cells[1].Value =
                                                    int.Parse(dataGridView2.Rows[i].Cells[1].Value.ToString())
                                                    + numericUpDown1.Value;
                                        }
                                        else
                                        {
                                            MessageBox.Show("الكمية المتاحة : " + totalfound);

                                        }
                                    }
                                }
                                if (flag == false)
                                {
                                    if (numericUpDown1.Value <= totalfound)
                                    {

                                        add_drg(prod.Name, numericUpDown1.Value.ToString(),textBox1.Text, prod.ID.ToString());
                                    }
                                    else
                                    {
                                        MessageBox.Show("الكمية المتاحة : " +totalfound);
                                    }
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("يرجي اضافة الكمية المراد اضافتها");
                        }
                    }
                    else
                    {
                        MessageBox.Show("يرجي كتابة كود المنتج صحيح");

                    }
                }
                else
                {
                    MessageBox.Show("يرجي كتابة كود المنتج");
                }
            }
            else
            {
                MessageBox.Show("يرجي اختيار المنتج المراد اضافتة");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            Invoice invoice = new Invoice();
           
            invoice.invoiceTypePriceID = 1;
            invoice.BillDate = (DateTime.Now).Date;
            invoice.TotalCash = 0;
            
            //change Invoice Type to 3
            invoice.InvoiceType_ID = 3;
            invoice.PaymentType_ID = 1;
            invoice.Pesron_ID = int.Parse(comboBox2.SelectedValue.ToString());
            invoice.TotalBill = 0;
            invoice.TotalReset = 0;

            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                int i = row.Index;
                if (i<dataGridView2.RowCount-1)
                {
                    string value1 = row.Cells[0].Value.ToString();
                    var quantdata = (from n in context.Products
                                     where n.Name == value1
                                     select n).FirstOrDefault();
                    int value2 = int.Parse(row.Cells[1].Value.ToString());
                    string ser = row.Cells[2].Value.ToString();
                    invoice.InvoiceProduct.Add(new InvoiceProduct { Quantity = value2, SerialNumber = ser, Product_ID = quantdata.ID });
                }
            }
            
            if (dataGridView2.Rows.Count != 1)
            {
                context.invoices.Add(invoice);
                context.SaveChanges();
                context = new ERBContext();
                MessageBox.Show("تم الحفظ", "تأكيد");
                dataGridView2.Rows.Clear();
            }
            else
                MessageBox.Show("لا توجد بيانات", "خطأ");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                if (dataGridView2.SelectedRows[0].Cells[0].Value != null)
                {
                    int rowIndex = dataGridView2.CurrentCell.RowIndex;
                    dataGridView2.Rows.RemoveAt(rowIndex);
                    int sum = 0;
                    if (numericUpDown1.Value != 0)
                    {
                        //for (int l = 0; l < dataGridView2.Rows.Count; ++l)
                        //{
                        //    sum += Convert.ToInt32(dataGridView2.Rows[l].Cells[2].Value);
                        //}
                        //textBox1.Text = sum.ToString();
                    }
                }
            }
            else
            {
                MessageBox.Show("يرجي اختيار المنتج المراد مسحه");
            }
        }
              
        private void button4_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

            int Value1 = int.Parse(selectedRow.Cells[0].Value.ToString());
            var Q = (from i in context.invoices
                     where i.ID ==Value1
                     select i).FirstOrDefault();
            var c = (from n in context.invoice_products
                     where n.Invoice_ID == Value1
                     select n).ToList();
            context.invoices.Remove(Q);
            foreach (var item in c)
            {
                item.Products.Quantity += item.Quantity;
                context.invoice_products.Remove(item);
            }
            context.SaveChanges();
            dataGridView1.Rows.RemoveAt(selectedRow.Index);
            MessageBox.Show("تم المسح", "تأكيد");
        }
              
        private void button5_Click(object sender, EventArgs e)
        {
            int personID = int.Parse(comboBox2.SelectedValue.ToString());
            dataGridView1.Rows.Clear();
            DataGridViewRow row = new DataGridViewRow();
            DateTime T = DateTime.Now.Date;
            var quantdata = (from n in context.invoices
                             where n.BillDate == T&&n.invoicestatus==0&&
                             n.InvoiceType_ID==3&&n.Pesron_ID== personID
                             select n).ToList();
            int c = 0;
            foreach (var item in quantdata)
            {
                row = (DataGridViewRow)dataGridView1.Rows[c].Clone();
                row.Cells[0].Value = item.ID;
                row.Cells[1].Value = item.BillDate.ToString();
                var name = (from i in context.person where
                            i.ID == item.Pesron_ID
                            select i.Name).FirstOrDefault();
                row.Cells[2].Value = name;
                row.Cells[3].Value = item.TotalBill.ToString();
                dataGridView1.Rows.Add(row);
                c++;
            }
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dataGridView1.Rows.Count > 1)
            {

                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                ShowBillDetails ShowBill = new ShowBillDetails();
                ShowBill.Value = int.Parse(selectedRow.Cells[0].Value.ToString());
                ShowBill.ShowDialog();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = "";
            if(listBox1.SelectedValue.ToString()!="0")
            {
                int id = int.Parse(listBox1.SelectedValue.ToString());
                AutoCompleteStringCollection autotext = new AutoCompleteStringCollection();
                var prodser = context.invoice_products.Where(p => p.Product_ID == id).Select(p=>p.SerialNumber).Distinct().ToList();
                autotext.AddRange(prodser.ToArray());
                textBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
                textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
                textBox1.AutoCompleteCustomSource = autotext;
            }
        }
    }
}
