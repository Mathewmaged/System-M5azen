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
    public partial class RepresentAccountsMoney : Form
    {
        public RepresentAccountsMoney()
        {
            InitializeComponent();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
        ERBContext context = new ERBContext();
        private void RepresentAccountsMoney_Load(object sender, EventArgs e)
        {
            var persons = context.person.Select(p => new { p.ID, p.Name, p.Phone, Money =p.AccountMoney, p.PersonType_ID });
            dataGridView1.DataSource = persons.Where(p => p.PersonType_ID == 1).ToList();
            dataGridView2.DataSource = persons.Where(p => p.PersonType_ID == 3).ToList();
            calculatetotals();
        }

        private void calculatetotals()
        {
            decimal mon=0, mon2=0;
            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                 mon += decimal.Parse(dataGridView1.Rows[i].Cells["Money"].Value.ToString());
               
            }
            for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
            {
                mon2 += decimal.Parse(dataGridView2.Rows[i].Cells["Money"].Value.ToString());

            }
            textBox1.Text = mon.ToString();
            textBox2.Text = mon2.ToString(); ;
        }
    }
}
