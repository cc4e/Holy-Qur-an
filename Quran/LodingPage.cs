using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quran
{
	public partial class LodingPage : Form
	{
		public LodingPage()
		{
			InitializeComponent();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			panel2.Width += 2;
			if(panel2.Width >= 487) {
				timer1.Stop();
				Login login = new Login();
				this.Hide();
				login.Show();

			}
		}
	}
}
