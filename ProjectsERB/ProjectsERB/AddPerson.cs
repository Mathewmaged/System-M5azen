using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Elm5zenDatabase;

namespace ProjectsERB
{
    public partial class AddPerson : Form
    {
        ERBContext app = new ERBContext();
        public AddPerson()
        {
            InitializeComponent();
        }
        public void getall()
        {
            var query = (from pers in app.person
                         select new { pers.ID, pers.Name, pers.Phone, pers.PersonType.TypeName, pers.Address }).ToList();
            dataGridView1.DataSource = query;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = ""; 
            comboBox1.SelectedIndex = 0;

        }
        public Person searchForGrid() {
            int index = dataGridView1.CurrentCell.RowIndex;
            int id;
            int.TryParse(dataGridView1.Rows[index].Cells["Id"].Value.ToString(), out id);
            var query = app.person.FirstOrDefault(p => p.ID == id);
            return query;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Person p = new Person();
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                p.Name = textBox1.Text;
                p.Address = textBox3.Text;
                int id = (comboBox1.SelectedIndex) + 1;
                //var query = (from c in app.PersonTypes
                //            where c.ID==id
                //            select c.ID).FirstOrDefault();
                p.PersonType_ID = id;
                int number;
                if (int.TryParse(textBox2.Text, out number))
                {
                    p.Phone = textBox2.Text;
                    app.person.Add(p);
                    app.SaveChanges();
                    MessageBox.Show("تم حفظ");
                    getall();
                }
                else
                {
                    MessageBox.Show("مينفعش ندخل حروف فى رقم التليفون ");
                }
            }
            else {

                MessageBox.Show("اتاكد انك دخلت كل حاجه ");

            }

        }
        private void button3_Click(object sender, EventArgs e)
        {
            Person update = searchForGrid();
            update.Name= textBox1.Text;
            update.Phone = textBox2.Text ;
            update.Address=textBox3.Text ;
            update.AccountMoney = 0;
            update.PersonType_ID = comboBox1.SelectedIndex + 1;
            app.SaveChanges();
            MessageBox.Show("تم التعديل بنجاح ");
            getall();
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            try
            {

                Person del = searchForGrid();
                app.person.Remove(del);
                app.SaveChanges();
                getall();
                MessageBox.Show(" تم المسح");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {

                Person update = searchForGrid();
                textBox1.Text = update.Name;
                textBox2.Text = update.Phone;
                textBox3.Text = update.Address;
                comboBox1.SelectedIndex = (int)(update.PersonType_ID) - 1;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void AddPerson_Load(object sender, EventArgs e)
        {
            this.comboBox1.DisplayMember = "TypeName";
            this.comboBox1.ValueMember = "ID";
            this.comboBox1.DataSource = app.PersonTypes.ToList();
            this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            getall();
        }
    }
}
