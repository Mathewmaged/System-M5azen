using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using validation_library;
using ssl;
using Elm5zenDatabase;
using System.Windows.Forms;

namespace ProjectsERB
{
    public partial class addUsers : Form
    {
        public addUsers()
        {
            InitializeComponent();
        }
        ERBContext context = new ERBContext();
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                login_check lg = new login_check();
                sslDalc sl = new sslDalc();
                lg.logincheck_name = textBox1.Text;
                lg.logincheck_username = textBox2.Text;
                lg.logincheck_password = sl.Encrypt(textBox3.Text);
                lg.logincheck_type = 1;
                context.login_checks.Add(lg);
                context.SaveChanges();
                MessageBox.Show("تم التسجيل");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                getall();

            }
            else
            {
                MessageBox.Show("يرجي ملئ جميع البيانات");
            }
        }

        private void addUsers_Load(object sender, EventArgs e)
        {
            getall();
        }

        private void getall()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = context.login_checks.Select(iv=>new { iv.ID,Name =iv.logincheck_name,UserName=iv.logincheck_username,Password=iv.logincheck_password}).ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count>0)
            {
                int id = int.Parse(dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString());
                var us = context.login_checks.Where(sd => sd.ID == id).FirstOrDefault();
                context.login_checks.Remove(us);
                context.SaveChanges();
                getall();
            }
        }
    }
}
