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
using Newtonsoft.Json.Linq;
namespace Quran
{

    public partial class HomePage : Form
    {
		static int currentIndex = 0;
		public HomePage()
        {
            InitializeComponent();
            LoadData(); // استدعاء طريقة LoadData() عند تحميل الصفحة
        }

        SqlConnection surat = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Windows Project C#\Quran\Quran\Database1.mdf;Integrated Security=True");

        //---------------------








        //--------------------
        private void HomePage_Load(object sender, EventArgs e)
        {
            detail.Text = " ";
			detail1.Text = " ";
			detail2.Text = " ";
		}

        private void sura_como_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = sura_como.SelectedItem.ToString();

            StringBuilder dataText = new StringBuilder();
			StringBuilder dataText1 = new StringBuilder();
			StringBuilder dataText2 = new StringBuilder();

			try
            {
                surat.Open();
                SqlCommand cmd = new SqlCommand($"SELECT Turun, Banyak_Ayat , no_word_surat FROM surat WHERE id = {sura_como.SelectedIndex}", surat);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string turun = reader["Turun"].ToString();
                    string Banyak_Ayat = reader["Banyak_Ayat"].ToString();
					string no_word_surat = reader["no_word_surat"].ToString();

					// إضافة النص إلى dataText بالترتيب المطلوب         
					dataText.AppendLine("النوع: " + turun);
                    dataText1.AppendLine("عدد السور: " + Banyak_Ayat);
					dataText2.AppendLine("عدد كلماتها: " + no_word_surat);
				}
                else
                {
                    dataText.AppendLine("لا توجد بيانات متاحة لهذا العنصر.");
                }
            }
            catch (Exception ex)
            {
                dataText.AppendLine("حدث خطأ: " + ex.Message);
            }
            finally
            {
                surat.Close();
            }

            // عرض البيانات في TextBox
            detail.Text = dataText.ToString();
			detail1.Text = dataText1.ToString();
			detail2.Text = dataText2.ToString();

		}

		// طريقة لتحميل البيانات من قاعدة البيانات وتعبئة sura_como.Items بها
		private void LoadData()
        {
            try
            {
                surat.Open();
                SqlCommand cmd = new SqlCommand("SELECT Name_Surat FROM surat", surat);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    sura_como.Items.Add(reader["Name_Surat"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while loading data: " + ex.Message);
            }
            finally
            {
                surat.Close();
            }
        }

        private void data_ayt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void detail_Click(object sender, EventArgs e)
        {
			
		}

		private void dispalySurat_TextChanged(object sender, EventArgs e)
		{


			
		}

		private void guna2ImageButton3_Click(object sender, EventArgs e)
		{
			Login login = new Login();
			this.Hide();

			login.Show();
		}

		private void next_Click(object sender, EventArgs e)
		{
			try
			{
				surat.Open();
				SqlCommand cmd = new SqlCommand($"SELECT aya FROM ayats WHERE id = {sura_como.SelectedIndex}", surat);
				SqlDataReader reader = cmd.ExecuteReader();

				if (reader.Read()) // Check if there are rows available
				{
					string ayat = reader["aya"].ToString();
					JObject jsonDataAsJson = JObject.Parse(ayat);

					currentIndex++;
					if (jsonDataAsJson.ContainsKey(currentIndex.ToString()))
					{
						dispalySurat.Text = jsonDataAsJson[currentIndex.ToString()].ToString();
					}
					else
					{
						currentIndex = 1;
						dispalySurat.Text = jsonDataAsJson[currentIndex.ToString()].ToString();
					}
				}
				else
				{
					MessageBox.Show("No data found for the selected sura.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message);
			}
			finally
			{
				surat.Close();
			}
		}

		private void back_Click(object sender, EventArgs e)
		{
			try
			{
				surat.Open();
				SqlCommand cmd = new SqlCommand($"SELECT aya FROM ayats WHERE id = {sura_como.SelectedIndex}", surat);
				SqlDataReader reader = cmd.ExecuteReader();

				if (reader.Read()) // Check if there are rows available
				{
					string ayat = reader["aya"].ToString();
					JObject jsonDataAsJson = JObject.Parse(ayat);

					currentIndex = currentIndex - 1;
					if (jsonDataAsJson.ContainsKey(currentIndex.ToString()))
					{
						dispalySurat.Text = jsonDataAsJson[currentIndex.ToString()].ToString();
					}
					else
					{
						currentIndex = 1;
						dispalySurat.Text = jsonDataAsJson[currentIndex.ToString()].ToString();
					}
				}
				else
				{
					MessageBox.Show("No data found for the selected sura.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message);
			}
			finally
			{
				surat.Close();
			}
		}
	}
	
}
