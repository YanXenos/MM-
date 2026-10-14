using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Doubledr.other
{
	public partial class note : Form
	{
		public note()
		{
			this.InitializeComponent();
		}
		private void button1_Click(object sender, EventArgs e)
		{
			base.Hide();
		}
		private void note_Load(object sender, EventArgs e)
		{
			this.textBox1.Select(0, 0);
		}
	}
}
