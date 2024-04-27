using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Quran
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Windows Project C#\Quran\Quran\Database1.mdf;Integrated Security=True");
        private void login_button_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from users where username = '"+usernameLogin_box.Text+"'  and password = '"+passwordLogin_box.Text+"'" , conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                LodingPage2 LodingPage2 = new LodingPage2();
                this.Hide();
				LodingPage2.Show();
            }
            else
            {
                MessageBox.Show(" erorr !!");

            }
            conn.Close();
        }

        private void Register_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterPage registerPage = new RegisterPage(); 
                
                   
            registerPage.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
