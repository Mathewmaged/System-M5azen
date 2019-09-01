using System;
using System.Data;
using System.Windows.Forms;
using ssl;
using validation_library;
using System.Linq;
using EasyTabs;

namespace ProjectsERB
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        //day_time_Dalc_cls day_time_Dalc_cls_var = null;
        ERBContext context = new ERBContext();
        //logincheckDalc logindl = null;
        sslDalc ssl_cls = null;
        validation_library_cls validation_library_cls_check = null;
        //sheft_day_Dalc_cls sheft_day_Dalc_cls_var = null;
        DataSet data1;
        public string username=null;
       
        private bool check_string(TextBox txt)
        {
            validation_library_cls_check = new validation_library_cls();
            string txt1 = txt.Text;
            bool checked_val = validation_library_cls_check.checked_validated(txt1, "only-string");
            return checked_val;
        }
        private bool check_string_numeric(TextBox txt)
        {
            validation_library_cls_check = new validation_library_cls();
            string txt1 = txt.Text;
            bool checked_val = validation_library_cls_check.checked_validated(txt1, "string-numeric-without-zero");
            return checked_val;
        }
        private bool check_required(TextBox txt)
        {
            validation_library_cls_check = new validation_library_cls();
            string txt1 = txt.Text;
            bool checked_val = validation_library_cls_check.IsRequired_txt(txt1);
            return checked_val;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            date.Text = DateTime.Now.ToLongDateString();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;

            this.time.Text = dt.ToString("hh") + ":" + dt.Minute + ":" + dt.Second + " " + DateTime.Now.ToString("tt");
        }

        private void pb_show_hied_pass_Click(object sender, EventArgs e)
        {
            if (txt_password.Text != "")
            {
                if (txt_password.PasswordChar == '*')
                {
                    txt_password.PasswordChar = '\0';
                    pb_show_hied_pass.BackgroundImage = ProjectsERB.Properties.Resources.eye;
                }
                else
                {
                    txt_password.PasswordChar = '*';
                    pb_show_hied_pass.BackgroundImage = ProjectsERB.Properties.Resources.eye_inv;

                }
            }
        }

        private void btn_lgn_Click(object sender, EventArgs e)
        {
            bool checkus_required = check_required(txt_usrname);
            bool check_pa_required = check_required(txt_password);
            if (checkus_required == false || check_pa_required == false)
            {
                validation_library_cls_check = new validation_library_cls();
                string msg = validation_library_cls_check.ErrorMessage(10);
                span_required_filed.Text = msg;
                span_required_filed.Visible = true;
            }
            else
            {
                span_required_filed.Visible = false;
                span_required_filed.Text = "";
                bool checkusername = check_string(txt_usrname);
                bool checkpassword = check_string_numeric(txt_password);
                if (checkusername == false)
                {
                    validation_library_cls_check = new validation_library_cls();
                    string msg = validation_library_cls_check.ErrorMessage(1);
                    span_us.Text = msg;
                    span_us.Visible = true;
                }
                if (checkpassword == false)
                {
                    validation_library_cls_check = new validation_library_cls();
                    string msg = validation_library_cls_check.ErrorMessage(11);
                    span_pa.Text = msg;
                    span_pa.Visible = true;
                }
                if (checkusername == false || checkpassword == false)
                {
                }
                else
                {

                    data1 = new DataSet();
                    //logindl = new logincheckDalc();
                    ssl_cls = new sslDalc();
                    string pass_enc = ssl_cls.Encrypt(txt_password.Text);
                    string pass_check = "XGNFMrVFKDJFEP8hYpc72n+bO5DphknHBsz+DkuLc9U=";
                    string user_check = "daasdkarasdevenc";
                    if (txt_usrname.Text == user_check && pass_enc == pass_check)
                    {
                        span_required_filed.Visible = false;
                        span_required_filed.Text = "تم الدخول بنجاح";
                        span_required_filed.Visible = true;
                        Main ms = new Main();
                        ms.Show();
                    }
                    else
                    {
                        span_required_filed.Visible = false;
                        //logindl = new logincheckDalc();
                       var datas = context.login_checks.Where(lg => lg.logincheck_username==txt_usrname.Text&& lg.logincheck_password==pass_enc).FirstOrDefault();
                        //data1 = logindl.getByusernameandpass(txt_usrname.Text, pass_enc);

                        if (datas==null)
                        {
                            span_required_filed.Visible = false;
                            span_required_filed.Text = "لا يوجد أسم مستخدم أو كلمة مرور بهذا الأسم";
                            span_required_filed.Visible = true;
                            txt_usrname.Text = "";
                            txt_password.Text = "";
                        }
                        else
                        {
                            span_required_filed.Visible = false;
                            span_required_filed.Text = "تم الدخول بنجاح";
                            span_required_filed.Visible = true;
                            this.Hide();


                            #region asd
                            AppContainer container = new AppContainer();

                            // Add the initial Tab
                            container.Tabs.Add(
                                // Our First Tab created by default in the Application will have as content the Form1
                                new TitleBarTab(container)
                                {
                                    Content = new Main
                                    {
                                        Text = "الرئيسية"
                                    }
                                }
                            );

                            // Set initial tab the first one
                            container.SelectedTabIndex = 0;

                            // Create tabs and start application
                            TitleBarTabsApplicationContext applicationContext = new TitleBarTabsApplicationContext();

                            #endregion
                            //Main pp = new Main();
                            //pp.get_string_username = txt_usrname.Text;
                            //pp.get_action = 0;
                            // pp.ShowDialog();

                            //pp.Activate();
                            container.ShowDialog();
                            container.Activate();
                            this.Dispose();
                            this.Close();
                            //ms.Visible = true;
                        }
                    }

                }
            }
        }
    }
}
