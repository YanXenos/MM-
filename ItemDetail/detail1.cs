using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Doubledr.Data;

namespace Doubledr.ItemDetail
{
	public partial class detail1 : Form
	{
		public detail1()
		{
			this.InitializeComponent();
		}
		private void callPrice(ref TextBox tb, string caption, int maxvalue, int current, long basic_address)
		{
			DatadictSelect datadictSelect = new DatadictSelect();
			datadictSelect.Owner = this;
			datadictSelect.caption = caption;
			datadictSelect.maxvalue = maxvalue;
			datadictSelect.current = current;
			if (datadictSelect.ShowDialog() == DialogResult.OK)
			{
				tb.Text = datadictSelect.returntext;
				mm1data mmdata = ((Form1)base.Owner).mmdata;
				mmdata.ModifyDataList.Add(new ModifyDatastruct(basic_address + (long)this.itemid, (byte)datadictSelect.returnvalue));
				mmdata.setItemPrice(this.itemid, datadictSelect.returnvalue);
			}
			datadictSelect.Dispose();
			GC.Collect();
		}
		private void detail1_Load(object sender, EventArgs e)
		{
			if (this.itemid > 0 && this.itemid < 255)
			{
				this.ShowAndHide();
				Form1 form = (Form1)base.Owner;
				this.label2.Text = static_data.item_name[this.itemid, 1].ToString();
				if (this.tb_attrack.Visible)
				{
					this.tb_attrack.Text = form.mmdata.Gethumenitem(this.itemid);
				}
				if (this.tb_define.Visible)
				{
					this.tb_define.Text = form.mmdata.Gethumenitem(this.itemid);
				}
				if (this.tb_price.Visible)
				{
					this.tb_price.Text = form.mmdata.getItemPrice(this.itemid);
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
			}
		}
		private void ShowAndHide()
		{
			if (this.itemid <= 34)
			{
				this.label4.Visible = false;
				this.tb_attrack.Visible = false;
				this.label7.Visible = false;
				this.comboBox1.Visible = false;
				return;
			}
			if (this.itemid <= 64)
			{
				this.label5.Visible = false;
				this.tb_define.Visible = false;
				return;
			}
			this.label4.Visible = false;
			this.tb_attrack.Visible = false;
			this.label7.Visible = false;
			this.comboBox1.Visible = false;
			this.label5.Visible = false;
			this.tb_define.Visible = false;
			this.label6.Visible = false;
			this.checkedListBox1.Visible = false;
		}
		private void button1_Click(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.OK;
		}
		private void tb_attrack_DoubleClick(object sender, EventArgs e)
		{
			DatadictSelect datadictSelect = new DatadictSelect();
			datadictSelect.Owner = this;
			datadictSelect.caption = "修改 " + this.label2.Text + " 的攻击力";
			datadictSelect.maxvalue = 800;
			datadictSelect.current = Convert.ToInt32(this.tb_attrack.Text);
			if (datadictSelect.ShowDialog() == DialogResult.OK)
			{
				this.tb_attrack.Text = datadictSelect.returntext;
				mm1data mmdata = ((Form1)base.Owner).mmdata;
				mmdata.sethumenitem(this.itemid, datadictSelect.returnvalue);
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
		private void tb_define_DoubleClick(object sender, EventArgs e)
		{
			DatadictSelect datadictSelect = new DatadictSelect();
			datadictSelect.Owner = this;
			datadictSelect.caption = "修改 " + this.label2.Text + " 的防御力";
			datadictSelect.maxvalue = 800;
			datadictSelect.current = Convert.ToInt32(this.tb_define.Text);
			if (datadictSelect.ShowDialog() == DialogResult.OK)
			{
				this.tb_define.Text = datadictSelect.returntext;
				mm1data mmdata = ((Form1)base.Owner).mmdata;
				mmdata.sethumenitem(this.itemid, datadictSelect.returnvalue);
			}
			datadictSelect.Dispose();
			GC.Collect();
		}
		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			mm1data mmdata = ((Form1)base.Owner).mmdata;
			mmdata.setAttackRange(this.itemid, this.comboBox1.SelectedIndex);
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
