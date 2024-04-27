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
	public partial class LodingPage2 : Form
	{
		public LodingPage2()
		{
			InitializeComponent();
		}

		private void timer2_Tick(object sender, EventArgs e)
		{
			panel2.Width += 2;
			if (panel2.Width >= 487)
			{
				timer2.Stop();
				HomePage HomePage = new HomePage();
				this.Hide();
				HomePage.Show();
			}
		}

		private void LodingPage2_Load(object sender, EventArgs e)
		{



		}
	}
}
