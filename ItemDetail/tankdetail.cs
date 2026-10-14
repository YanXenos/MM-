using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Doubledr.Data;

namespace Doubledr.ItemDetail
{
	public partial class tankdetail : Form
	{
		public tankdetail()
		{
			this.InitializeComponent();
		}
		private void tankdetail_Load(object sender, EventArgs e)
		{
			if (this.itemid > 0 && this.itemid < 255)
			{
				this.ShowAndHide();
				Form1 form = (Form1)base.Owner;
				this.label2.Text = static_data.item_name[this.itemid, 1].ToString();
				if (this.tb_attrack.Visible)
				{
					this.tb_attrack.Text = form.mmdata.GetTankAttack(this.itemid);
				}
				if (this.tb_price.Visible)
				{
					this.tb_price.Text = form.mmdata.getItemPrice(this.itemid);
				}
				if (this.tb_define.Visible)
				{
					this.tb_define.Text = form.mmdata.GetTankDefine(this.itemid);
				}
				if (this.comboBox1.Visible)
				{
					this.comboBox1.SelectedIndex = (int)((form.mmdata.GetItemUse(this.itemid) & 24) / 8);
				}
				if (this.checkedListBox1.Visible)
				{
					for (int i = 0; i < 3; i++)
					{
						this.checkedListBox1.SetItemChecked(i, (form.mmdata.GetItemUse(this.itemid) & form.mmdata.sdata[i]) != 0);
					}
				}
				if (this.comboBox2.Visible)
				{
					this.comboBox2.SelectedIndex = (int)(form.mmdata.GetItemUse(this.itemid) & 7);
				}
				if (this.label10.Visible)
				{
					int value = (int)Convert.ToSingle(form.mmdata.GetmotWeight(this.itemid));
					this.textBox1.Text = value.ToString("F");
					this.trackBar1.Value = value;
				}
				if (this.label9.Visible)
				{
					float num = 10f * Convert.ToSingle(form.mmdata.GetTankItemWeight(this.itemid));
					this.textBox2.Text = (num / 10f).ToString("F");
					this.trackBar2.Value = (int)num;
				}
			}
		}
		private void ShowAndHide()
		{
			if (this.itemid <= 116)
			{
				return;
			}
			if (this.itemid <= 120)
			{
				this.label4.Visible = false;
				this.label7.Visible = false;
				this.label6.Visible = false;
				this.label8.Visible = false;
				this.comboBox2.Visible = false;
				this.tb_attrack.Visible = false;
				this.comboBox1.Visible = false;
				this.checkedListBox1.Visible = false;
				return;
			}
			if (this.itemid <= 144)
			{
				this.label4.Visible = false;
				this.label7.Visible = false;
				this.label6.Visible = false;
				this.label8.Visible = false;
				this.comboBox2.Visible = false;
				this.tb_attrack.Visible = false;
				this.comboBox1.Visible = false;
				this.checkedListBox1.Visible = false;
				this.label10.Visible = true;
				this.trackBar1.Visible = true;
				this.textBox1.Visible = true;
				return;
			}
			this.label4.Visible = false;
			this.label7.Visible = false;
			this.label6.Visible = false;
			this.label8.Visible = false;
			this.comboBox2.Visible = false;
			this.tb_attrack.Visible = false;
			this.comboBox1.Visible = false;
			this.checkedListBox1.Visible = false;
			this.label5.Visible = false;
			this.tb_define.Visible = false;
			this.label9.Visible = false;
			this.trackBar2.Visible = false;
			this.textBox2.Visible = false;
		}
		private void trackBar1_Scroll(object sender, EventArgs e)
		{
			this.textBox1.Text = this.trackBar1.Value.ToString("F");
		}
		private void trackBar2_Scroll(object sender, EventArgs e)
		{
			this.textBox2.Text = ((float)this.trackBar2.Value / 10f).ToString("F");
		}
		private void button1_Click(object sender, EventArgs e)
		{
			if (this.label9.Visible)
			{
				mm1data mmdata = ((Form1)base.Owner).mmdata;
				mmdata.setTankItemWeight(this.itemid, this.trackBar2.Value);
			}
			if (this.label10.Visible)
			{
				mm1data mmdata2 = ((Form1)base.Owner).mmdata;
				mmdata2.setmotWeight(this.itemid, this.trackBar1.Value);
			}
			base.DialogResult = DialogResult.OK;
		}
		private void tb_attrack_DoubleClick(object sender, EventArgs e)
		{
			DatadictSelect datadictSelect = new DatadictSelect();
			datadictSelect.Owner = this;
			datadictSelect.caption = "修改 " + this.label2.Text + " 的攻击力";
			datadictSelect.maxvalue = 999;
			datadictSelect.current = (int)Convert.ToInt16(this.tb_attrack.Text);
			if (datadictSelect.ShowDialog() == DialogResult.OK)
			{
				this.tb_attrack.Text = datadictSelect.returntext;
				mm1data mmdata = ((Form1)base.Owner).mmdata;
				mmdata.setTankAttack(this.itemid, datadictSelect.returnvalue);
			}
			datadictSelect.Dispose();
			GC.Collect();
		}
		private void tb_define_DoubleClick(object sender, EventArgs e)
		{
			DatadictSelect datadictSelect = new DatadictSelect();
			datadictSelect.Owner = this;
			datadictSelect.caption = "修改 " + this.label2.Text + " 的防御力";
			datadictSelect.maxvalue = 999;
			datadictSelect.current = (int)Convert.ToInt16(this.tb_define.Text);
			if (datadictSelect.ShowDialog() == DialogResult.OK)
			{
				this.tb_define.Text = datadictSelect.returntext;
				mm1data mmdata = ((Form1)base.Owner).mmdata;
				mmdata.setTankDefine(this.itemid, datadictSelect.returnvalue);
			}
			datadictSelect.Dispose();
			GC.Collect();
		}
		private void tb_price_DoubleClick(object sender, EventArgs e)
		{
			int current;
			if (this.tb_price.Text == "无价,可以丢弃")
			{
				current = -1;
			}
			else if (this.tb_price.Text == "无价,不可丢弃")
			{
				current = -2;
			}
			else
			{
				current = Convert.ToInt32(this.tb_price.Text);
			}
			DatadictSelect datadictSelect = new DatadictSelect();
			datadictSelect.Owner = this;
			datadictSelect.caption = "修改 " + this.label2.Text + " 的价格";
			datadictSelect.maxvalue = 0;
			datadictSelect.current = current;
			if (datadictSelect.ShowDialog() == DialogResult.OK)
			{
				this.tb_price.Text = datadictSelect.returntext;
				mm1data mmdata = ((Form1)base.Owner).mmdata;
				mmdata.setItemPrice(this.itemid, datadictSelect.returnvalue);
			}
			datadictSelect.Dispose();
			GC.Collect();
		}
		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			mm1data mmdata = ((Form1)base.Owner).mmdata;
			mmdata.setAttackRange(this.itemid, this.comboBox1.SelectedIndex);
		}
		private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{
			mm1data mmdata = ((Form1)base.Owner).mmdata;
			mmdata.setbullets(this.itemid, this.comboBox2.SelectedIndex);
		}
		private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			Form1 form = (Form1)base.Owner;
			int num = 0;
			for (int i = 0; i < 3; i++)
			{
				if (this.checkedListBox1.GetItemChecked(i))
				{
					num |= (int)form.mmdata.sdata[i];
				}
			}
			form.mmdata.setItemuse(this.itemid, num);
		}
		public int itemid;
	}
}
