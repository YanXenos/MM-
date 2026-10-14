using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Resources;
using System.Windows.Forms;
using Doubledr.Data;

namespace Doubledr.ItemDetail
{
	public partial class enengy : Form
	{
		public enengy()
		{
			this.InitializeComponent();
		}
		private void enengy_Load(object sender, EventArgs e)
		{
			this.f1 = (Form1)base.Owner;
			DataTable dataTable = new DataTable("item");
			dataTable.Columns.Add("itemname");
			for (int i = 0; i < static_data.item_name.GetLength(0); i++)
			{
				dataTable.Rows.Add(new object[]
				{
					static_data.item_name[i, 1]
				});
			}
			this.comboBox1.DataSource = dataTable;
			this.comboBox1.DisplayMember = "itemname";
			try
			{
				this.myAssembly = Assembly.Load("resouce");
				this.myManager = new ResourceManager("resouce.mm", this.myAssembly);
			}
			catch
			{
				this.hasimage = false;
			}
			this.refreshdata();
		}
		private void refreshdata()
		{
			this.jname.Text = static_data.enemy_name[this.enemyid, 0].ToString();
			this.cname.Text = static_data.enemy_name[this.enemyid, 1].ToString();
			this.nu_hp.Value = this.f1.mmdata.Getenemy_HP(this.enemyid);
			this.nu_attrack.Value = this.f1.mmdata.Getenemy_attrack(this.enemyid);
			this.nu_define.Value = this.f1.mmdata.Getenemy_define(this.enemyid);
			this.comboBox1.SelectedIndex = this.f1.mmdata.Getenemy_zhanlipin(this.enemyid);
			if (this.enemyid < 24)
			{
				this.comboBox1.Enabled = false;
			}
			else
			{
				this.comboBox1.Enabled = true;
			}
			string text = this.f1.mmdata.Getenemy_jia(this.enemyid);
			if (text == "")
			{
				this.nu_jia.Enabled = false;
				this.cb_jia.Checked = false;
				this.jia = 0;
			}
			else
			{
				this.nu_jia.Enabled = true;
				this.nu_jia.Value = Convert.ToInt16(text);
				this.cb_jia.Checked = true;
				this.jia = (int)this.nu_jia.Value;
			}
			this.nu_speed.Value = this.f1.mmdata.Getenemy_speed(this.enemyid);
			this.nu_mingzhong.Value = this.f1.mmdata.Getenemy_mingzhong(this.enemyid);
			this.nu_level.Value = this.f1.mmdata.Getenemy_level(this.enemyid);
			this.nu_exp.Value = this.f1.mmdata.Getenemy_exp(this.enemyid);
			this.nu_money.Value = this.f1.mmdata.Getenemy_money(this.enemyid);
			if (this.hasimage)
			{
				string name = Convert.ToString(Convert.ToInt16(this.enemyid), 16);
				Image image = (Image)this.myManager.GetObject(name);
				this.panel1.Width = image.Width;
				this.panel1.Height = image.Height;
				this.panel1.BackgroundImage = image;
			}
			this.hp = (int)this.nu_hp.Value;
			this.speed = (int)this.nu_speed.Value;
			this.mingzhong = (int)this.nu_mingzhong.Value;
			this.level = (int)this.nu_level.Value;
			this.exp = (int)this.nu_exp.Value;
			this.attrack = (int)this.nu_attrack.Value;
			this.define = (int)this.nu_define.Value;
			this.money = (int)this.nu_money.Value;
			this.speed = (int)this.nu_speed.Value;
			this.zhanlipin = this.comboBox1.SelectedIndex;
		}
		private void button3_Click(object sender, EventArgs e)
		{
			int num = this.f1.Select_listview_index();
			if (num > 0)
			{
				this.f1.set_listview_index(num - 1);
				this.enemyid--;
				this.refreshdata();
			}
		}
		private void button4_Click(object sender, EventArgs e)
		{
			int num = this.f1.Select_listview_index();
			if (num >= 0 && num < this.f1.get_listview_count() - 1)
			{
				this.f1.set_listview_index(num + 1);
				this.enemyid++;
				this.refreshdata();
			}
		}
		private void button1_Click(object sender, EventArgs e)
		{
			if (this.hp != (int)this.nu_hp.Value)
			{
				this.f1.mmdata.setenemy_HP(this.enemyid, (int)this.nu_hp.Value);
			}
			if (this.attrack != (int)this.nu_attrack.Value)
			{
				this.f1.mmdata.setenemy_attrack(this.enemyid, (int)this.nu_attrack.Value);
			}
			if (this.define != (int)this.nu_define.Value)
			{
				this.f1.mmdata.setenemy_define(this.enemyid, (int)this.nu_define.Value);
			}
			if (this.exp != (int)this.nu_exp.Value)
			{
				this.f1.mmdata.setenemy_exp(this.enemyid, (int)this.nu_exp.Value);
			}
			if (this.money != (int)this.nu_money.Value)
			{
				this.f1.mmdata.setenemy_money(this.enemyid, (int)this.nu_money.Value);
			}
			if (this.level != (int)this.nu_level.Value)
			{
				this.f1.mmdata.setenemy_level(this.enemyid, (int)this.nu_level.Value);
			}
			if (this.mingzhong != (int)this.nu_mingzhong.Value)
			{
				this.f1.mmdata.setenemy_mingzhong(this.enemyid, (int)this.nu_mingzhong.Value);
			}
			if (this.speed != (int)this.nu_speed.Value)
			{
				this.f1.mmdata.setenemy_speed(this.enemyid, (int)this.nu_speed.Value);
			}
			if (this.jia != (int)this.nu_jia.Value)
			{
				this.f1.mmdata.setenemy_jia(this.enemyid, (int)this.nu_jia.Value);
			}
			if (this.enemyid >= 24 && this.zhanlipin != this.comboBox1.SelectedIndex)
			{
				this.f1.mmdata.setenemy_zhanlipin(this.enemyid, this.comboBox1.SelectedIndex);
			}
			base.DialogResult = DialogResult.OK;
		}
		public int enemyid;
		private Form1 f1;
		private int hp;
		private int attrack;
		private int define;
		private int jia;
		private int speed;
		private int mingzhong;
		private int level;
		private int exp;
		private int money;
		private int zhanlipin;
		private bool hasimage = true;
		private Assembly myAssembly;
		private ResourceManager myManager;
	}
}
