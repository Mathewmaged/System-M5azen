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
    public partial class Invoice_Sell : Form
    {
        public Invoice_Sell()
        {
            InitializeComponent();
        }
        ERBContext context = new ERBContext();
        private void Invoice_Sell_Load(object sender, EventArgs e)
        {
            showallsellers();
            showcomerce();
            showpayment();
            showbilltype();
        }

        private void showsellinvoice()
        {
            if (comboBox1.DataSource != null)
            {
                int personID = int.Parse(comboBox1.SelectedValue.ToString());
                var invoicesperm = context.InvoiceSellPermisions.Where(i => i.PermisionIDs.Pesron_ID == personID);
                int index = 0;
                dataGridView3.Rows.Clear();

                foreach (var item in invoicesperm)
                {

                    int personID2 = int.Parse(comboBox3.SelectedValue.ToString());
                    var invoices = context.invoices.Where(iv => iv.ID==item.InvoiceSellID&&iv.InvoiceType_ID == 2 && iv.Pesron_ID == personID2);
                    foreach (var invo in invoices)
                    {
                        index++;
                        add_drg3(index.ToString(),
                            invo.ID.ToString(),
                            invo.invoiceTypePrice.Name,
                            invo.Payment_Type.TypeName,
                            invo.Person.Name,
                            invo.BillDate.Date.ToString("dd-MM-yyyy"),
                            invo.TotalBill.ToString(),
                            invo.TotalCash.ToString(),
                            invo.TotalReset.ToString());
                    }
                }
            }
        }

        private void showbilltype()
        {

            
            var list = new List<object>();
            list.Add(new { ID = 1, Name = "جملة" });
            list.Add(new { ID = 2, Name = "قطاعي" });
            comboBox4.DisplayMember = "Name";
            comboBox4.ValueMember = "ID";
            comboBox4.DataSource = list;
           
            


        }
        void calculateinvoice()           
        {
            decimal sum = 0;
            for (int i = 0; i < dataGridView4.Rows.Count-1; i++)
            {
                int prodid = int.Parse(dataGridView4.Rows[i].Cells[4].Value.ToString());
                var prod = context.Products.FirstOrDefault(p => p.ID == prodid);
                if (int.Parse(comboBox4.SelectedValue.ToString()) == 1)
                {
                    sum+=(decimal.Parse(dataGridView4.Rows[i].Cells[2].Value.ToString())*prod.PriceOutAll);
                }
                else if (int.Parse(comboBox4.SelectedValue.ToString()) == 2)
                {
                    sum += (decimal.Parse(dataGridView4.Rows[i].Cells[2].Value.ToString()) * prod.PriceOutOne);

                }
            }
            numericUpDown4.Value = sum;
            numericUpDown2.Value = sum;
            
        }

        private void showpayment()
        {
            var seller = context.PaymentType.ToList();
            comboBox2.DisplayMember = "TypeName";
            comboBox2.ValueMember = "ID";
            comboBox2.DataSource = seller;
        }

        private void showcomerce()
        {
            var seller = context.person.Where(p => p.PersonType_ID == 3).ToList();
            comboBox3.DisplayMember = "Name";
            comboBox3.ValueMember = "ID";
            comboBox3.DataSource = seller;
        }

        private void showallsellers()
        {
            var seller = context.person.Where(p => p.PersonType_ID == 2).ToList();
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "ID";
            comboBox1.DataSource = seller;
        }
        private void add_drg(string column0, string column1, string column2, string column3, string column4)
        {
            DataGridViewRow row = (DataGridViewRow)dataGridView2.Rows[0].Clone();
            row.Cells[0].Value = column0;
            row.Cells[1].Value = column1;
            row.Cells[2].Value = column2;
            row.Cells[3].Value = column3;
            row.Cells[4].Value = column4;



            dataGridView2.Rows.Add(row);
        }
        private void add_drg1(string column0, string column1, string column2, string column3)
        {
            DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
            row.Cells[0].Value = column0;
            row.Cells[1].Value = column1;
            row.Cells[2].Value = column2;
            row.Cells[3].Value = column3;


            dataGridView1.Rows.Add(row);
        }
        private void add_drg2(string column0, string column1, string column2, string column3, string column4)
        {
            DataGridViewRow row = (DataGridViewRow)dataGridView4.Rows[0].Clone();
            row.Cells[0].Value = column0;
            row.Cells[1].Value = column1;
            row.Cells[2].Value = column2;
            row.Cells[3].Value = column3;
            row.Cells[4].Value = column4;

            dataGridView4.Rows.Add(row);
        }

        private void add_drg3(string column0, string column1, string column2, string column3, string column4, string column5, string column6, string column7, string column8)
        {
            DataGridViewRow row = (DataGridViewRow)dataGridView3.Rows[0].Clone();
            row.Cells[0].Value = column0;
            row.Cells[1].Value = column1;
            row.Cells[2].Value = column2;
            row.Cells[3].Value = column3;
            row.Cells[4].Value = column4;
            row.Cells[5].Value = column5;
            row.Cells[6].Value = column6;
            row.Cells[7].Value = column7;
            row.Cells[8].Value = column8;

            dataGridView3.Rows.Add(row);
        }
        List<InvoiceProduct> products = null;
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (dataGridView1.SelectedRows[0].Cells[1].Value != null)
                {
                    int ivid = int.Parse(dataGridView1.SelectedRows[0].Cells[1].Value.ToString());
                    int staus = context.invoices.FirstOrDefault(i => i.ID == ivid).invoicestatus;
                    products = context.invoice_products.Where(ip => ip.Invoice_ID == ivid).ToList();
                    dataGridView2.Rows.Clear();
                    int co = 1;
                    if (staus == 0)
                    {
                        foreach (var item in products)
                        {


                            add_drg(co.ToString(), item.Products.Name, item.Quantity.ToString(),item.SerialNumber, item.Product_ID.ToString());
                            co++;
                        }
                    }
                    else if(staus==1)
                    {
                        var i = context.InvoiceSellPermisions.Where(isv=>isv.InvoicePermisionID==ivid);
                        
                        foreach (var item in products)
                        {

                            int quantity = 0;
                            foreach (var items in i)
                            {
                                quantity += (from inpr in context.invoice_products
                                             where inpr.Invoice_ID == items.InvoiceSellID&&inpr.Product_ID==item.Product_ID
                                             select inpr.Quantity).FirstOrDefault();


                            }

                            if (item.Quantity - quantity != 0)
                            {
                                add_drg(co.ToString(), item.Products.Name, (item.Quantity - quantity).ToString(),item.SerialNumber, item.Product_ID.ToString());
                                co++;
                            }
                        }
                        if(dataGridView2.Rows.Count<=1)
                        {
                            context.invoices.FirstOrDefault(isa => isa.ID == ivid).invoicestatus = 2;
                            context.SaveChanges();
                            comboBox1.SelectedIndex = 0;
                        }
                        
                        
                    }
                }
                else
                {
                    MessageBox.Show("لا يوجد فاتورة");
                }
            }
            else
            {
                MessageBox.Show("يرجي اختيار الفاتورة");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedValue.ToString()!="")
            {
                int pid = int.Parse(comboBox1.SelectedValue.ToString());
                var invoices = context.invoices.Where(i => i.Pesron_ID == pid&&i.invoicestatus!=2&&i.InvoiceType_ID==3);
                int co = 1;
                dataGridView1.Rows.Clear();
                foreach (var invo in invoices)
                {
                    add_drg1(co.ToString(),invo.ID.ToString(),invo.BillDate.ToString("dd-MM-yyyy"),invo.TotalBill.ToString());
                }
            }
            
        }
        int c = 1;
        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                decimal quant = decimal.Parse(dataGridView2.SelectedRows[0].Cells[2].Value.ToString());
                
                if (numericUpDown1.Value != 0&&numericUpDown1.Value<=quant)
                {
                    bool f = false;
                    for (int i = 0; i < dataGridView4.Rows.Count-1; i++)
                    {
                        if(dataGridView4.Rows[i].Cells[4].Value.ToString()== dataGridView2.SelectedRows[0].Cells[4].Value.ToString()&& dataGridView4.Rows[i].Cells[3].Value.ToString() == dataGridView2.SelectedRows[0].Cells[3].Value.ToString())
                        {
                            dataGridView4.Rows[i].Cells[2].Value = decimal.Parse(dataGridView4.Rows[i].Cells[2].Value.ToString()) + numericUpDown1.Value;

                            dataGridView2.SelectedRows[0].Cells[2].Value = quant - numericUpDown1.Value;
                            f = true;
                            
                        }
                    }



                    if (!f)
                    {
                        add_drg2(c.ToString(),
                            dataGridView2.SelectedRows[0].Cells[1].Value.ToString(),
                            numericUpDown1.Value.ToString(),
                           dataGridView2.SelectedRows[0].Cells[3].Value.ToString(),
                            dataGridView2.SelectedRows[0].Cells[4].Value.ToString());
                        c++;
                        dataGridView2.SelectedRows[0].Cells[2].Value = quant - numericUpDown1.Value;
                    }
                    calculateinvoice();
                    comboBox1.Enabled = false;
                    dataGridView1.Enabled = false;
                }
                else
                {
                    MessageBox.Show("يرجي اضافة الكمية صحيحة");
                }
            }
            else
            {
                MessageBox.Show("يرجي اختيار المنتج المراد اضافة من القائمة");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView4.Rows.Count > 1)
            {
                if (dataGridView4.SelectedRows.Count > 0)
                {
                    for (int i = 0; i < dataGridView2.Rows.Count-1; i++)
                    {
                        if(dataGridView2.Rows[i].Cells[3].Value.ToString()==dataGridView4.SelectedRows[0].Cells[3].Value.ToString())
                        {
                            dataGridView2.Rows[i].Cells[2].Value = decimal.Parse(dataGridView4.SelectedRows[0].Cells[2].Value.ToString())
                                                                + decimal.Parse(dataGridView2.Rows[i].Cells[2].Value.ToString());
                        }
                    }
                    dataGridView4.Rows.Remove(dataGridView4.SelectedRows[0]);
                }
                else
                {
                    MessageBox.Show("يرجي اختيار المنتج المراد مسحه");
                }
                calculateinvoice();
                if(dataGridView4.Rows.Count<=1)
                {
                    dataGridView1.Enabled = true;
                    comboBox1.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("لا يوجد منتج للمسح");
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(dataGridView4.Rows.Count>0)
            {
                calculateinvoice();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count>=1&&dataGridView4.Rows.Count>1)
            {
                int id=int.Parse(dataGridView1.SelectedRows[0].Cells[1].Value.ToString());
                var invoice_out = context.invoices.Where(ivs => ivs.InvoiceType_ID == 3 && ivs.ID == id).FirstOrDefault();
                Invoice iv = new Invoice();
                for (int i = 0; i < dataGridView4.Rows.Count-1; i++)
                {
                    int ids=int.Parse(dataGridView4.Rows[i].Cells[4].Value.ToString());
                    int quantity = int.Parse(dataGridView4.Rows[i].Cells[2].Value.ToString());
                    string ser = dataGridView4.Rows[i].Cells[3].Value.ToString();
                    iv.InvoiceProduct.Add(new InvoiceProduct { Product_ID = ids, Quantity = quantity,SerialNumber=ser });
                }
                iv.invoicestatus = 0;
                iv.InvoiceType_ID = 2;
                iv.PaymentType_ID = int.Parse(comboBox2.SelectedValue.ToString());
                iv.invoiceTypePriceID = int.Parse(comboBox4.SelectedValue.ToString());
                iv.TotalCash =numericUpDown4.Value;
                iv.TotalBill =numericUpDown2.Value;
                iv.TotalReset =numericUpDown3.Value;
                iv.BillDate = DateTime.Now.Date;
                iv.Pesron_ID = int.Parse(comboBox3.SelectedValue.ToString());
                context.invoices.Add(iv);
                var per = new InvoiceSellPermision();
                per.InvoiceSellID = iv.ID;
                per.InvoicePermisionID = invoice_out.ID; 
                invoice_out.PermisionInvoice.Add(per);
                iv.Sells.Add(per);
                invoice_out.invoicestatus = 1;
                context.SaveChanges();
                MessageBox.Show("تم الحفظ");
                dataGridView4.Rows.Clear();
                dataGridView1.Enabled = true;
                dataGridView1.Rows.Clear();
                dataGridView2.Rows.Clear();
                comboBox1.Enabled = true;
            }
            else
            {
                MessageBox.Show("يرجي اختيار اذن الخروج و ملئ الفاتورة بالمنتاجات");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            context = new ERBContext();
            showsellinvoice();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(dataGridView3.Rows.Count>1)
            {
                if(dataGridView3.SelectedRows.Count>0)
                {
                    int invoiceID = int.Parse(dataGridView3.SelectedRows[0].Cells[1].Value.ToString());
                    var invoice = context.invoices.FirstOrDefault(ivs => ivs.ID == invoiceID);
                    foreach (var item in invoice.InvoiceProduct.ToList())
                    {
                        item.Quantity = 0;
                    }
                    context.SaveChanges();
                    if (invoice.PaymentType_ID == 2)

                        invoice.Sells.FirstOrDefault().PermisionIDs.invoicestatus=1;
                    foreach (var item in invoice.InvoiceProduct.ToList())
                    {
                       context.invoice_products.Remove(item);
                    }
                    foreach (var item in invoice.Sells.ToList())
                    {
                        context.InvoiceSellPermisions.Remove(item);
                    }
                    invoice.Person.AccountMoney -= invoice.TotalReset;
                    // invoice.ResetCashMoney.FirstOrDefault(rs => rs.Invoice == invoice);///.Remove(new ResetCashMoney { Invoice = invoice });
                    if(invoice.PaymentType_ID==2)
                    context.RestCashMoneys.Remove(invoice.ResetCashMoney.FirstOrDefault(rs => rs.Invoice == invoice));
                    context.invoices.Remove(invoice);

                    context.SaveChanges();
                    MessageBox.Show("تم الاسترجاع الفاتورة");
                    showsellinvoice();

                }
                else
                {
                    MessageBox.Show("يرجي اختيار الفاتورة المراد استرجعها");
                }
            }
            else
            {
                MessageBox.Show("لا يوجد فواتير للاسترجاع");

            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (dataGridView3.Rows.Count > 1)
            {
                if (dataGridView3.SelectedRows.Count > 0)
                {
                    int invoiceID = int.Parse(dataGridView3.SelectedRows[0].Cells[1].Value.ToString());
                    var invoice = context.invoices.FirstOrDefault(ivs => ivs.ID == invoiceID);
                    //invoice.Sells.FirstOrDefault().PermisionIDs.invoicestatus = 1;
                    foreach (var item in invoice.InvoiceProduct.ToList())
                    {
                        context.invoice_products.Remove(item);
                    }
                    foreach (var item in invoice.Sells.ToList())
                    {
                        context.InvoiceSellPermisions.Remove(item);
                    }
                    if (invoice.PaymentType_ID == 2)

                        context.RestCashMoneys.Remove(invoice.ResetCashMoney.FirstOrDefault(rs => rs.Invoice == invoice));
                    //context.RestCashMoneys.Remove(new ResetCashMoney { Invoice = invoice });
                    context.invoices.Remove(invoice);

                    context.SaveChanges();
                    MessageBox.Show("تم مسح الفاتورة");
                    showsellinvoice();

                }
                else
                {
                    MessageBox.Show("يرجي اختيار الفاتورة المراد مسحها");
                }
            }
            else
            {
                MessageBox.Show("لا يوجد فواتير للمسح");

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (dataGridView3.Rows.Count > 1 && dataGridView3.SelectedRows.Count > 0)
            {
                showbillproducts sb = new showbillproducts();
                sb.inovice_id = int.Parse(dataGridView3.SelectedRows[0].Cells[1].Value.ToString());
                if (dataGridView3.SelectedRows[0].Cells[2].Value.ToString() == "جملة")
                    sb.pricetype = 1;
                else
                    sb.pricetype = 2;
                sb.ShowDialog();
            }
            else
            {
                MessageBox.Show("يرجي اختيار الفاتورة المراد عرض منتجاتها");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if(dataGridView2.Rows.Count>1&&dataGridView1.SelectedRows.Count>0&&dataGridView1.Enabled)
            {
                Invoice iv = new Invoice();
                iv.BillDate = DateTime.Now.Date;
                iv.invoicestatus = 0;
                iv.invoiceTypePriceID = 1;
                iv.InvoiceType_ID = 4;
                iv.PaymentType_ID = 1;
                iv.Pesron_ID = int.Parse(comboBox1.SelectedValue.ToString());
                iv.TotalBill = 0;
                iv.TotalCash = 0;
                iv.TotalReset = 0;
                for (int i = 0; i < dataGridView2.Rows.Count-1; i++)
                {
                    InvoiceProduct ivpd = new InvoiceProduct();
                    ivpd.Product_ID = int.Parse(dataGridView2.Rows[i].Cells[4].Value.ToString());
                    ivpd.Quantity = int.Parse(dataGridView2.Rows[i].Cells[2].Value.ToString());
                    ivpd.SerialNumber = dataGridView2.Rows[i].Cells[3].Value.ToString();
                    iv.InvoiceProduct.Add(ivpd);
                }
                context.invoices.Add(iv);
                int ivid = int.Parse(dataGridView1.SelectedRows[0].Cells[1].Value.ToString());
                context.invoices.FirstOrDefault(ivs => ivs.ID == ivid).invoicestatus = 2;
                context.SaveChanges();
                MessageBox.Show("تم عمل مرتجع للمنتجات");
                dataGridView1.Rows.Clear();
                dataGridView2.Rows.Clear();
            }
            else
            {
                MessageBox.Show("لا يوجد منتجات للمرتجع");
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (int.Parse(comboBox2.SelectedValue.ToString()) == 2)
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

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
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
        /*
* if (listBox3.SelectedItems.Count > 0)
{
if (textBox1.Text != "")
{
  int prodsids = int.Parse(listBox3.SelectedValue.ToString());
  var prds = context.invoice_products.Where(iv => iv.SerialNumber == textBox1.Text && iv.Product_ID == prodsids).FirstOrDefault();
  if (prds != null)
  {
      if (numericUpDown1.Value > 0)
      {

          int prodID = int.Parse(listBox3.SelectedValue.ToString());
          var prodin = context.invoice_products.Where(iv => iv.SerialNumber == textBox1.Text && iv.Product_ID == prodsids && iv.Invoice.InvoiceType_ID == 1).Sum(vs => (int?)vs.Quantity) ?? 0;
          var prodout1 = context.invoice_products.Where(iv => iv.SerialNumber == textBox1.Text && iv.Product_ID == prodsids && iv.Invoice.InvoiceType_ID == 2).Sum(vs => (int?)vs.Quantity) ?? 0;
          var prodout2 = context.invoice_products.Where(iv => iv.SerialNumber == textBox1.Text && iv.Product_ID == prodsids && iv.Invoice.InvoiceType_ID == 3).Sum(vs => (int?)vs.Quantity) ?? 0;
          var prodin2 = context.invoice_products.Where(iv => iv.SerialNumber == textBox1.Text && iv.Product_ID == prodsids && iv.Invoice.InvoiceType_ID == 4).Sum(vs => (int?)vs.Quantity) ?? 0;

          var totalfound = ((prodin + prodin2) - (prodout1 + prodout2));
          var prod = context.Products.Where(ps => ps.ID == prodID).FirstOrDefault();
          if (dataGridView2.Rows.Count <= 1)
          {
              if (numericUpDown1.Value <= totalfound)
              {

                  counter++;
                         add_drg(counter.ToString(), prod.Name, numericUpDown1.Value.ToString(),textBox1.Text, prod.ID.ToString());
                         calculateTotalBill();
                          listBox1.SelectedIndex = -1;

                         listBox3.Items.Clear();
                         listBox3.SelectedIndex = -1;
                          numericUpDown1.Value = 0;
              }
              else
              {
                  MessageBox.Show("الكمية المتاحة : " + totalfound);
              }
          }
          else
          {
              bool flag = false;
              for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
              {
                  int id = int.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
                  string serial = dataGridView1.Rows[i].Cells[3].Value.ToString();
                  if (id == prodID && serial == textBox1.Text)
                  {
                      flag = true;

                      decimal qunatity = decimal.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
                      if (totalfound >= qunatity + numericUpDown1.Value)
                      {
                          dataGridView1.Rows[i].Cells[2].Value =
                                  int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString())
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

                      counter++;
                      add_drg(counter.ToString(), prod.Name, numericUpDown1.Value.ToString(), textBox1.Text, prod.ID.ToString());
                      calculateTotalBill();
                      listBox1.SelectedIndex = -1;

                      listBox3.Items.Clear();
                      listBox3.SelectedIndex = -1;
                      numericUpDown1.Value = 0;
                  }
                  else
                  {
                      MessageBox.Show("الكمية المتاحة : " + 
                      );
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
*/
    }
}
