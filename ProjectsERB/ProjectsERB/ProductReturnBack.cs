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

    public partial class ProductReturnBack : Form
    {
        ERBContext Our = new ERBContext();
        public ProductReturnBack()
        {
            InitializeComponent();
            

        }
        public void getall() {
            var query = (from c in Our.invoice_products
                         where c.Invoice.InvoiceType.ID == 5
                         &&c.Invoice.invoicestatus==0
                         select new
                        {
                             personName=c.Invoice.Person.Name,
                            c.Invoice.Person.Phone,
                            c.Invoice.Person.Address,
                            c.Invoice.BillDate,
                            ProductName = c.Products.Name,
                            c.Quantity,
                            c.SerialNumber,
                            c.Invoice.InvoiceType.TypeName,
                             invoiceNumber = c.Invoice.ID
                         }).ToList();
            dataGridView2.DataSource = query.ToList();
            textBox2.Enabled = false;
            button2.Enabled = false;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string serial = textBox1.Text;
            var query = from c in Our.invoice_products
                        where c.SerialNumber == serial && c.Invoice.InvoiceType.ID == 1 && c.Invoice.Person.PersonType_ID==1
                        select new {
                            invoiceNumber =c.Invoice.ID,
                            personName=c.Invoice.Person.Name,
                            c.Invoice.Person.Phone,
                            c.Invoice.Person.Address,
                            c.Invoice.BillDate,
                            ProductName =c.Products.Name ,
                            c.Quantity,
                            c.SerialNumber,
                            c.Invoice.InvoiceType.TypeName
                        };
            dataGridView1.DataSource = query.ToList();




        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox2.Enabled = true;
            button2.Enabled = true;
            int index = dataGridView1.CurrentCell.RowIndex;
            label3.Text = dataGridView1.Rows[index].Cells["ProductName"].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox2.Text != "0" && dataGridView1.SelectedRows.Count > 0)
            {
                int quantity;
                int.TryParse(textBox2.Text, out quantity);
                var queryProductFatora = (from productFatora in Our.invoice_products
                                          where productFatora.Products.Name == label3.Text
                                          select productFatora).FirstOrDefault();
                int? prodID = queryProductFatora.Product_ID;
                var prodin = Our.invoice_products.Where(iv => iv.SerialNumber == textBox1.Text && iv.Product_ID == prodID && iv.Invoice.InvoiceType_ID == 1).Sum(vs => (int?)vs.Quantity) ?? 0;
                var prodout1 = Our.invoice_products.Where(iv => iv.SerialNumber == textBox1.Text && iv.Product_ID == prodID && iv.Invoice.InvoiceType_ID == 5).Sum(vs => (int?)vs.Quantity) ?? 0;
                var prodout2 = Our.invoice_products.Where(iv => iv.SerialNumber == textBox1.Text && iv.Product_ID == prodID && iv.Invoice.InvoiceType_ID == 3).Sum(vs => (int?)vs.Quantity) ?? 0;
                var prodin2 = Our.invoice_products.Where(iv => iv.SerialNumber == textBox1.Text && iv.Product_ID == prodID && iv.Invoice.InvoiceType_ID == 4).Sum(vs => (int?)vs.Quantity) ?? 0;
                var totalfound = ((prodin + prodin2) - (prodout2 + prodout1));

                if (totalfound >= quantity || totalfound >= quantity)
                {
                    int index = dataGridView1.CurrentCell.RowIndex;
                    //queryProductFatora.Quantity -= quantity;
                    //queryProductFatora.Products.Quantity -= quantity;
                    InvoiceProduct add = new InvoiceProduct();
                    //string a = ;
                    //string a = DateTime.Now.ToShortDateString();
                    add.Quantity = quantity;
                    add.SerialNumber = textBox1.Text;
                    string name = dataGridView1.Rows[index].Cells["personName"].Value.ToString();

                    Products productDetails = (from Product in Our.Products
                                               where Product.Name == label3.Text
                                               select Product).FirstOrDefault();
                    Person personDetails = (from person in Our.person
                                            where person.Name == name && person.PersonType_ID == 1
                                            select person).FirstOrDefault();
                    add.Product_ID = productDetails.ID;
                    Invoice x = new Invoice();
                    x.BillDate = DateTime.Now.Date;//Convert.ToDateTime(DateTime.Today.ToString("yyyy-MM-dd"));
                    x.Pesron_ID = personDetails.ID;
                    x.InvoiceType_ID = 5;
                    x.PaymentType_ID = 1;
                    x.invoicestatus = 0;
                    x.invoiceTypePrice = productDetails.InvoiceProduct.Select(ip => ip.Invoice.invoiceTypePrice).FirstOrDefault();
                    x.TotalBill = (quantity * productDetails.PriceIn);
                    x.TotalCash = (quantity * productDetails.PriceIn);
                    add.Invoice = x;
                    x.Person.AccountMoney -= x.TotalCash;
                    //delete from orginal fatora 
                    //int id;
                    //int.TryParse(dataGridView1.Rows[index].Cells["invoiceNumber"].Value.ToString(), out id);
                    //var queryFatora = (from fatora in Our.invoices
                    //                   where fatora.ID == id
                    //                   select fatora).FirstOrDefault();
                    //queryFatora.TotalBill -= x.TotalBill;
                    //if (queryFatora.TotalCash > queryFatora.TotalReset)
                    //{
                    //    queryFatora.TotalCash -= x.TotalCash;
                    //}
                    //else
                    //{
                    //    queryFatora.TotalReset -= x.TotalCash;

                    //}


                    Our.invoice_products.Add(add);
                    Our.SaveChanges();

                    MessageBox.Show("تمام ");
                    getall();
                    textBox1.Text = "";
                    label3.Text = "";
                    dataGridView1.DataSource = null;
                    textBox2.Text = "0";




                }
                else
                {
                    MessageBox.Show("الكميه المرتجعه مش موجوده ف المخزن " + totalfound);

                }
            }
            else
            {
                MessageBox.Show("يرجي اختيار و ملئ البيانات صحيحة");
            }

        }


        private void button3_Click_1(object sender, EventArgs e)
        {
            if (textBox2.Text != "" && textBox2.Text != "0" && dataGridView2.SelectedRows.Count > 0)
            {
                int quantity;
                int.TryParse(textBox2.Text, out quantity);
                int id;
                int index = dataGridView2.CurrentCell.RowIndex;
                int.TryParse(dataGridView2.Rows[index].Cells["invoiceNumber"].Value.ToString(), out id);
                var query = (from c in Our.invoice_products
                             where c.Invoice_ID == id
                             select c).FirstOrDefault();
                //query.Quantity += quantity;
                //query.Invoice.BillDate= Convert.ToDateTime(DateTime.Today.ToString("yyyy-MM-dd"));
                //query.Invoice.TotalBill += (query.Products.PriceIn * quantity);
                //query.Invoice.TotalCash += (query.Products.PriceIn * quantity);
                //var query3 = (from c in Our.invoice_products
                //             where c.SerialNumber == query.SerialNumber && c.Invoice.InvoiceType_ID == 1
                //             select c).FirstOrDefault();
                //query3.Quantity -= quantity;
                //query3.Invoice.TotalBill -= query.Invoice.TotalBill;
                //query3.Invoice.TotalCash -= query.Invoice.TotalCash;
                //query3.Products.Quantity -= quantity;
                int? prodID = query.Product_ID;
                string ser = dataGridView2.Rows[index].Cells["SerialNumber"].Value.ToString();
                var prodin = Our.invoice_products.Where(iv => iv.SerialNumber == ser && iv.Product_ID == prodID && iv.Invoice.InvoiceType_ID == 1).Sum(vs => (int?)vs.Quantity) ?? 0;
                var prodout1 = Our.invoice_products.Where(iv => iv.SerialNumber == ser && iv.Product_ID == prodID && iv.Invoice.InvoiceType_ID == 5).Sum(vs => (int?)vs.Quantity) ?? 0;
                var prodout2 = Our.invoice_products.Where(iv => iv.SerialNumber == ser && iv.Product_ID == prodID && iv.Invoice.InvoiceType_ID == 3).Sum(vs => (int?)vs.Quantity) ?? 0;
                var prodin2 = Our.invoice_products.Where(iv => iv.SerialNumber == ser && iv.Product_ID == prodID && iv.Invoice.InvoiceType_ID == 4).Sum(vs => (int?)vs.Quantity) ?? 0;
                var totalfound = ((prodin + prodout1 + prodin2) - (prodout2));
                if (quantity <= totalfound)
                {
                    query.Quantity = quantity;

                    query.Invoice.TotalBill = (query.Products.PriceIn * quantity);
                    query.Invoice.TotalCash = (query.Products.PriceIn * quantity);
                    Our.SaveChanges();
                    getall();
                    textBox1.Text = "";
                    label3.Text = "";
                    dataGridView1.DataSource = null;

                    textBox2.Text = "0";
                }
                else
                {
                    MessageBox.Show("الكمية المراد تعديلها غير متاحها في المخزن");
                }
            }
            else
            {
                MessageBox.Show("يرجي اختيار و ملئ البيانات صحيحة");

            }
        }

        private void ProductReturnBack_Load(object sender, EventArgs e)
        {
            getall();
            AutoCompleteStringCollection autotext = new AutoCompleteStringCollection();

            var prodser = Our.invoice_products.Select(p => p.SerialNumber).Distinct().ToList();
            autotext.AddRange(prodser.ToArray());
            textBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBox1.AutoCompleteCustomSource = autotext;
        }

        private void dataGridView2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox2.Enabled = true;
            button2.Enabled = true;
            int index = dataGridView2.CurrentCell.RowIndex;
            label3.Text = dataGridView2.Rows[index].Cells["ProductName"].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(dataGridView2.SelectedRows.Count>0)
            {

                int? invoiceid = int.Parse(dataGridView2.SelectedRows[0].Cells["invoiceNumber"].Value.ToString());
                var invoice = Our.invoices.Where(iv => iv.ID == invoiceid).FirstOrDefault();
                invoice.invoicestatus = 2;
                Our.SaveChanges();
                MessageBox.Show("تم المسح");
                getall();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {

                int? invoiceid = int.Parse(dataGridView2.SelectedRows[0].Cells["invoiceNumber"].Value.ToString());
                var invoice = Our.invoices.Where(iv => iv.ID == invoiceid).FirstOrDefault();
                invoice.invoicestatus = 2;
                foreach (var item in invoice.InvoiceProduct)
                {
                    item.Quantity = 0;
                }
                invoice.Person.AccountMoney += invoice.TotalBill;
                Our.SaveChanges();
                MessageBox.Show("تم الاسترجاع");
                getall();
            }
        }
    }
}
