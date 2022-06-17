using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace ShopSvet
{
    public partial class AvtorizForm : Form
    {
        public AvtorizForm()
        {
            InitializeComponent();
        }
        public bool pop = false;
        public static string conString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\svetBD.mdb";
        private OleDbConnection connection;
        public int count = 0;
        public DataTable dt = new DataTable();
        private void Vhodbutton_Click(object sender, EventArgs e)
        {
            connection = new OleDbConnection(conString);
            connection.Open();
            OleDbDataAdapter ada = new OleDbDataAdapter("SELECT COUNT (*) FROM авторизация WHERE логин = '" + LogintextBox.Text + "'and пароль = '" + PasswordtextBox.Text + "'", connection);
            
            ada.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1" && count ==0)
            {
                Product product = new Product();
                product.Show();
                this.Close();
            }
            else if (dt.Rows[0][0].ToString() != "1" && count == 0)
            {
                MessageBox.Show("Неправильный логин или пароль");
                pop = true;
            }
            if (pop)
            {
                CaptchatextBox.Visible = true;
                pictureBox1.Visible = true;
                count++;
                captcha();
            }
            
        }

        void captcha()
        {
            string captcha = "8h2T";
            
            if (CaptchatextBox.Text == captcha)
            {
                if (dt.Rows[0][0].ToString() == "0")
                {
                    Product product = new Product();
                    product.Show();
                    this.Close();
                }
                else
                {
                    count++;
                }
            }
            else if (count !=1)
            {
                LogintextBox.Enabled = false;
                PasswordtextBox.Enabled = false;
                CaptchatextBox.Enabled = false;
                Vhodbutton.Enabled = false;
                timer1.Start();
                MessageBox.Show("Неверные логин, пароль или каптча. Повторите попытку через 10 секунд", "Предупреждение");
                label4.Visible = true;
                label5.Visible = true;
                count++;
            }
        }
        public int sec = 10;
        private void timer1_Tick(object sender, EventArgs e)
        {
            label5.Text = sec.ToString();
            sec -= 1;

            if (sec == 0)
            {
                LogintextBox.Enabled = true;
                PasswordtextBox.Enabled = true;
                CaptchatextBox.Enabled = true;
                Vhodbutton.Enabled = true;
                label5.Text = "0";
                timer1.Stop();
                sec = 10;
            }
        }

        private void AvtorizForm_Load(object sender, EventArgs e)
        {

        }

        private void AvtorizForm_Load_1(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "svetBDDataSet11.авторизация". При необходимости она может быть перемещена или удалена.
            this.авторизацияTableAdapter1.Fill(this.svetBDDataSet11.авторизация);

        }
    }
}
