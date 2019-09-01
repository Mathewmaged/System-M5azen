using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using ERB_Model;
using Elm5zenDatabase;

namespace ProjectsERB
{
    public partial class Invoice_Buy : Form
    {
        //ERBEntities context = new ERBEntities();
        ERBContext context = new ERBContext();
        public Invoice_Buy()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            getAllMoard();
            getCategory();
            getinvoicetype();
            dataGridView2.Rows.Clear();
            showallbillin();
        }

        private void showallbillin()
        {
            var invoices = context.invoices.Where(i => i.InvoiceType.ID == 1);
            int count = 0;
            dataGridView1.Rows.Clear();
            foreach (var item in invoices)
            {
                count++;
                add_drg1(count.ToString()
                    , item.ID.ToString()
                    , item.Payment_Type.TypeName
                    , item.Person.Name
                    , item.BillDate.ToString("dd-MM-yyyy")
                    , item.TotalBill.ToString()
                    , item.TotalCash.ToString()
                    , item.TotalReset.ToString());
            }
        }

       

        private void getinvoicetype()
        {
            var invoice_type_id = context.PaymentType.ToList();
            comboBox2.DisplayMember = "TypeName";
            comboBox2.ValueMember = "ID";
            comboBox2.DataSource = invoice_type_id;

        }

        private void getCategory()
        {
            var category = context.categories.ToList();
            listBox1.DisplayMember = "Name";
            listBox1.ValueMember = "ID";
            listBox1.DataSource = category;
            listBox1.SelectedIndex = -1;
        }

        private void getAllMoard()
        {
            var morad = context.person.Where(p => p.PersonType_ID == 1).ToList();
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "ID";
            comboBox1.DataSource = morad;
        }

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            
            if (listBox1.SelectedItems.Count > 0)
            {
                Categories subcat = listBox1.SelectedItem as Categories;

                var prods = context.Products.Where(s => s.Categories_ID == subcat.ID);
                listBox3.Items.Clear();
                listBox3.DisplayMember = "Name";
                listBox3.ValueMember = "ID";
                foreach (var item in prods)
                {
                    listBox3.Items.Add(item);
                }
                listBox3.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("يرجي اختيار عنصر من نوع الصنف");
            }
        }

        #region Canceled
        /* private void listBox2_MouseClick(object sender, MouseEventArgs e)
        {
            /*if (listBox1.SelectedItems.Count > 0)
            {
                int id = int.Parse(listBox1.SelectedValue.ToString());
                var subcat = context.categories.Where(s => s.categories_ID == id);
                
                listBox2.Items.Clear();
                listBox2.DisplayMember = "Name";
                listBox2.ValueMember = "ID";
                foreach (var item in subcat)
                {
                    listBox2.Items.Add(item);
                }
                listBox2.SelectedIndex = -1;
                listBox3.Items.Clear();
            }
            else
            {
                MessageBox.Show("يرجي اختيار عنصر من نوع الصنف");
            }
            if (listBox2.SelectedItems.Count > 0)
            {
                SubCategories subcat = listBox2.SelectedItem as SubCategories;
                
                var prods = context.Products.Where(s => s.SubCategories_ID == subcat.ID);
                listBox3.Items.Clear();
                listBox3.DisplayMember = "Name";
                listBox3.ValueMember = "ID";
                foreach (var item in prods)
                {
                    listBox3.Items.Add(item);
                }
                listBox3.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("يرجي اختيار عنصر من نوع الصنف");
            }
        }*/ 
        #endregion

        private void add_drg(string column0, string column1, string column2, string column3, string column4)
        {
            DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
            row.Cells[0].Value = column0;
            row.Cells[1].Value = column1;
            row.Cells[2].Value = column2;
            row.Cells[3].Value = column3;
            row.Cells[4].Value = column4;

            dataGridView1.Rows.Add(row);
        }

        private void add_drg1(string column0, string column1, string column2, string column3, string column4, string column5, string column6, string column7)
        {
            DataGridViewRow row = (DataGridViewRow)dataGridView2.Rows[0].Clone();
            row.Cells[0].Value = column0;
            row.Cells[1].Value = column1;
            row.Cells[2].Value = column2;
            row.Cells[3].Value = column3;
            row.Cells[4].Value = column4;
            row.Cells[5].Value = column5;
            row.Cells[6].Value = column6;
            row.Cells[7].Value = column7;

            dataGridView2.Rows.Add(row);
        }
        int counter = 0;
        //Add products to invoice
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (numericUpDown1.Value > 0 && listBox3.SelectedItems.Count > 0)
            {
                Products prd = listBox3.SelectedItem as Products;


                decimal price = prd.PriceIn;
                int price_id = prd.ID;
                int i = 0;
                bool f = false;
                if (dataGridView1.Rows.Count > 1)
                {
                    for (i = 0; i < dataGridView1.Rows.Count-1; i++)
                    {
                        int id = int.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());

                        if (id == prd.ID)
                        {
                            dataGridView1.Rows[i].Cells[2].Value = int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString())
                                                                    + numericUpDown1.Value;
                            f = true;
                            listBox1.SelectedIndex = -1;
                           // listBox2.Items.Clear();
                           // listBox2.SelectedIndex = -1;
                            listBox3.Items.Clear();
                            listBox3.SelectedIndex = -1;
                            numericUpDown1.Value = 0;
                            calculateTotalBill();
                            break;

                        }
                    }
                }

                if (!f)
                {
                    counter++;
                    add_drg(counter.ToString(), prd.Name, numericUpDown1.Value.ToString(), price.ToString(), prd.ID.ToString());
                    calculateTotalBill();
                    listBox1.SelectedIndex = -1;

                    listBox3.Items.Clear();
                    listBox3.SelectedIndex = -1;
                    numericUpDown1.Value = 0;
                }

            }
            else
            {
                MessageBox.Show("يرجي اختيار المنتج الصحيح و ادخال الكمية");
            } 
         
            
            
        }

        //Remove products from invoice 
        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 1)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
                    calculateTotalBill();
                }
                else
                {
                    MessageBox.Show("يرجي اختيار المنتج للمسح");
                }
            }
            else
            {
                MessageBox.Show("لا يوجد منتج للمسح");
            }
        }

        void calculateTotalBill()
        {
            decimal sum=0;
            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                decimal price = decimal.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());
                int quantity = int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
                sum += quantity * price;
            }
           numericUpDown4.Value = sum;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            numericUpDown2.Value =numericUpDown4.Value;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (numericUpDown2.Value != 0)
            {
                decimal sum = numericUpDown4.Value - numericUpDown2.Value;
                if (sum >= 0)
                    numericUpDown3.Text = (sum).ToString();
                else
                {
                    numericUpDown2.Value = numericUpDown4.Value;

                    numericUpDown3.Value = 0;
                    MessageBox.Show("يرجي ادخال المبلغ صحيح");
                }
            }
            else
            {
               // MessageBox.Show("يرجي ادخال المبلغ صحيح");
                numericUpDown3.Value = numericUpDown4.Value;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(int.Parse(comboBox2.SelectedValue.ToString())==2)
            {
                //textBox3.ReadOnly = true;
                numericUpDown2.Enabled = true;

            }
            else if (int.Parse(comboBox2.SelectedValue.ToString()) == 1)
            {
                // textBox3.ReadOnly = false;
                numericUpDown2.Enabled = false;
                numericUpDown2.Value = numericUpDown4.Value;

            }
        }

        string generate_code()
        {
               return DateTime.Now.ToString("dd") 
                + DateTime.Now.ToString("MM") 
                + DateTime.Now.ToString("yyyy") 
                + DateTime.Now.ToString("HH") 
                + DateTime.Now.ToString("mm") 
                + DateTime.Now.ToString("ss");
        }

        bool checnk_form()
        {
            if(dataGridView1.Rows.Count<=1)
            {
                MessageBox.Show("يرجي ادخال المنتاجات المراد حفظها للفاتورة");
                return false;
            }
            else if(numericUpDown2.Value==0)
            {
                MessageBox.Show("يرجي ادخال السعر صحيح");
                return false;
            }
            return true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (checnk_form())
                {
                    Invoice invoice = new Invoice();

                    invoice.Pesron_ID = int.Parse(comboBox1.SelectedValue.ToString());
                    invoice.InvoiceType_ID = 1;
                    invoice.PaymentType_ID = int.Parse(comboBox2.SelectedValue.ToString());
                    invoice.TotalBill = numericUpDown4.Value;
                    invoice.TotalCash = numericUpDown2.Value;
                    invoice.TotalReset = numericUpDown3.Value;
                    invoice.BillDate = DateTime.Now.Date;
                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        int id = int.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
                       
                        int quantity = int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
                        InvoiceProduct ips = new InvoiceProduct();
                        ips.Product_ID = id;
                        
                        ips.Quantity = quantity;
                        ips.SerialNumber = generate_code() + i;
                        invoice.InvoiceProduct.Add(ips);
                    }
                    context.invoices.Add(invoice);
                    context.SaveChanges();
                    dataGridView1.Rows.Clear();
                    counter = 0;
                   numericUpDown4.Value = 0;
                    numericUpDown2.Value =0;
                    numericUpDown3.Value = 0;
                    MessageBox.Show("تم حفظ الفاتورة");
                    dataGridView2.Rows.Clear();
                    showallbillin();
                    numericUpDown2.Enabled = false;
                    //listBox2.Items.Clear();
                    listBox3.Items.Clear();

                }
            }
            catch(Exception)
            {
                MessageBox.Show("لقد حدث خطأ اثناء عملية حفظ البيانات يرجي المحاولة في وقت لاحق");
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count >= 1 && dataGridView2.Rows.Count > 1)
            {
                int invid=int.Parse(dataGridView2.SelectedRows[0].Cells[1].Value.ToString());
                var invoice = context.invoices.FirstOrDefault(i => i.ID == invid);
                foreach (var item in invoice.InvoiceProduct.ToList())
                {
                    context.invoice_products.Remove(item);
                }
                if (invoice.PaymentType_ID == 2)

                    context.RestCashMoneys.Remove(invoice.ResetCashMoney.FirstOrDefault(rs => rs.Invoice == invoice));
                context.invoices.Remove(invoice);
                context.SaveChanges();
                dataGridView2.Rows.Clear();
                showallbillin();
            }
            else {
                MessageBox.Show("يرجي التاكد من اختيار الفاتورة الصحيحة");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count >= 1 && dataGridView2.Rows.Count>1)
            {
                showbillproducts sbp = new showbillproducts();
                sbp.inovice_id = int.Parse(dataGridView2.SelectedRows[0].Cells[1].Value.ToString());
                sbp.ShowDialog();
            }
            else {
                MessageBox.Show("يرجي اختيار الفاتورة لعرض منتاجاتها");
            }
        }

        private void dataGridView2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
        bool check_availableproducts(int bill_id)
        {
           int x= context.invoice_products.Where(ips => ips.Invoice_ID==bill_id&&ips.Quantity <= ips.Products.Quantity).Count();
            if (x > 0)
                return true;
            else
                return false;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count >= 1 && dataGridView2.Rows.Count > 1)
            {
                int invid = int.Parse(dataGridView2.SelectedRows[0].Cells[1].Value.ToString());
                if (check_availableproducts(invid))
                {
                    var invoice = context.invoices.FirstOrDefault(i => i.ID == invid);

                    var ips = context.invoice_products.Where(ip => ip.Invoice_ID == invid).ToList();
                    foreach (var item in ips)
                    {
                        item.Quantity = 0;
                    }
                    context.SaveChanges();
                    context.invoice_products.RemoveRange(ips);
                    invoice.Person.AccountMoney -= invoice.TotalReset;
                    if(invoice.PaymentType_ID==2)
                    context.RestCashMoneys.Remove(invoice.ResetCashMoney.FirstOrDefault(rs => rs.Invoice == invoice));
                    context.invoices.Remove(invoice);
                    context.SaveChanges();
                    dataGridView2.Rows.Clear();
                    showallbillin();
                    //if (invoice.PaymentType_ID == 1)
                    //{
                        
                    //}
                    //else
                    //{
                    //    var ips = context.invoice_products.Where(ip => ip.Invoice_ID == invid).ToList();
                    //    var rs = context.RestCashMoneys.FirstOrDefault(r => r.Invoice.ID == invid);
                    //    context.invoice_products.RemoveRange(ips);
                    //    context.RestCashMoneys.Remove(rs);
                    //    context.invoices.Remove(invoice);
                    //    context.SaveChanges();
                    //    dataGridView2.Rows.Clear();
                    //    showallbillin();
                    //}
                }
                else
                {
                    MessageBox.Show("لا يوجد كميات متاحة في المخزن لاسترجاع الفاتورة");
                }
            }
            else
            {
                MessageBox.Show("يرجي التاكد من اختيار الفاتورة الصحيحة");
            }
        }
    }
}
