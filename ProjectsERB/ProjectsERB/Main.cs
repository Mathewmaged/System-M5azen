using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using EasyTabs;

namespace ProjectsERB
{
    public partial class Main : Form
    {
        protected TitleBarTabs ParentTabs
        {
            get
            {
                return (ParentForm as TitleBarTabs);
            }
        }
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            ParentTabs.Tabs.Add(new TitleBarTab(ParentTabs)
            {
                Content = new ShowAllProducts
                {
                    Text = "اضافة منتجات"
                }
            });
            ParentTabs.SelectedTabIndex = ParentTabs.Tabs.Count-1;

           
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            ParentTabs.Tabs.Add(new TitleBarTab(ParentTabs)
            {
                Content = new Invoice_Buy
                {
                    Text = "فاتورة شراء"
                }
            });
            ParentTabs.SelectedTabIndex = ParentTabs.Tabs.Count - 1;
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            ParentTabs.Tabs.Add(new TitleBarTab(ParentTabs)
            {
                Content = new SellPermission
                {
                    Text = "أذن تحميل"
                }
            });
            ParentTabs.SelectedTabIndex = ParentTabs.Tabs.Count - 1;
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            ParentTabs.Tabs.Add(new TitleBarTab(ParentTabs)
            {
                Content = new Invoice_Sell
                {
                    Text = "فاتورة بيع"
                }
            });
            ParentTabs.SelectedTabIndex = ParentTabs.Tabs.Count - 1;
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            ParentTabs.Tabs.Add(new TitleBarTab(ParentTabs)
            {
                Content = new AddPerson
                {
                    Text = "أضافة الأشخاص"
                }
            });
            ParentTabs.SelectedTabIndex = ParentTabs.Tabs.Count - 1;
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            ParentTabs.Tabs.Add(new TitleBarTab(ParentTabs)
            {
                Content = new ProductReturnBack
                {
                    Text = "مرتجع المخزن للمورد"
                }
            });
            ParentTabs.SelectedTabIndex = ParentTabs.Tabs.Count - 1;
        }

        private void panel7_Click(object sender, EventArgs e)
        {
            ParentTabs.Tabs.Add(new TitleBarTab(ParentTabs)
            {
                Content = new addUsers
                {
                    Text = "اضافة مستخدمين"
                }
            });
            ParentTabs.SelectedTabIndex = ParentTabs.Tabs.Count - 1;
        }

        private void panel8_Click(object sender, EventArgs e)
        {
            ParentTabs.Tabs.Add(new TitleBarTab(ParentTabs)
            {
                Content = new Invoice_Backs
                {
                    Text = "مرتجع التاجر للمخزن"
                }
            });
            ParentTabs.SelectedTabIndex = ParentTabs.Tabs.Count - 1;

        }

        private void panel9_Click(object sender, EventArgs e)
        {
            ParentTabs.Tabs.Add(new TitleBarTab(ParentTabs)
            {
                Content = new RepresentAccountsMoney
                {
                    Text = "عرض المديونات"
                }
            });
            ParentTabs.SelectedTabIndex = ParentTabs.Tabs.Count - 1;
        }

        private void panel10_Click(object sender, EventArgs e)
        {
            ParentTabs.Tabs.Add(new TitleBarTab(ParentTabs)
            {
                Content = new StoreMoves
                {
                    Text = "حركة المخزن"
                }
            });
            ParentTabs.SelectedTabIndex = ParentTabs.Tabs.Count - 1;
        }

        private void panel11_Click(object sender, EventArgs e)
        {
            ParentTabs.Tabs.Add(new TitleBarTab(ParentTabs)
            {
                Content = new ProductsReports
                {
                    Text = "حركة المنتج"
                }
            });
            ParentTabs.SelectedTabIndex = ParentTabs.Tabs.Count - 1;
        }
    }
}
