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
    public partial class RegisterPage : Form
    {
        public RegisterPage()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Windows Project C#\Quran\Quran\Database1.mdf;Integrated Security=True");
        private void nameR_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void usernameR_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2GradientTileButton2_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();

            login.Show();

        }

        private void guna2GradientTileButton1_Click(object sender, EventArgs e)
        {
            if (!IsStrongPassword(passwordR_box.Text))
            {
                MessageBox.Show("كلمة المرور ضعيفة! يجب أن تحتوي على حروف كبيرة وصغيرة وأرقام وتكون طولها على الأقل 8 أحرف.");
                return;
            }

            conn.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO users (username, Password, name) VALUES ('" + usernameR_box.Text + "', '" + passwordR_box.Text + "', '" + nameR_box.Text + "')", conn);
            // cmd.Parameters.AddWithValue("@UserName", usernameR_box.Text);
            // cmd.Parameters.AddWithValue("@Password", passwordR_box.Text);
            // cmd.Parameters.AddWithValue("@Name", nameR_box.Text);

            // تنفيذ الاستعلام
            cmd.ExecuteNonQuery();
            MessageBox.Show("تمت الإضافة بنجاح!");
            conn.Close();
        }

        static bool IsStrongPassword(string password)
        {
            
            if (password.Length < 8)
                return false;

            bool hasUpperCase = false;
            bool hasLowerCase = false;
            bool hasDigit = false;

            foreach (char c in password)
            {
                if (char.IsUpper(c))
                    hasUpperCase = true;
                else if (char.IsLower(c))
                    hasLowerCase = true;
                else if (char.IsDigit(c))
                    hasDigit = true;
            }

            return hasUpperCase && hasLowerCase && hasDigit;
        }

    }
}
