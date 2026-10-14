using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Doubledr.Data;
using Doubledr.ItemDetail;
using Doubledr.other;

namespace Doubledr
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			this.InitializeComponent();
			this.about = new about();
			this.note = new note();
			this.listdata = new ListviewData();
			this.setListViewHeader();
            this.listView1.Visible = false;

        }

		private void OpenMMRom()
		{
            
            /*if (mm1data.IsOpen)
			{
				MessageBox.Show("已经打开过了！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
				return;
			}*/
            OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "nes files (*.nes)|*.nes";
			openFileDialog.FilterIndex = 1;
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
                this.listView1.Visible = true;
                this.Text = "重装机兵[FC]全资料修改器-" + Path.GetFileNameWithoutExtension(openFileDialog.FileName); ;
                if (mm1data.checkrom(openFileDialog.FileName))
				{
					this.mmdata = new mm1data(openFileDialog.FileName);
					mm1data.IsOpen = true;
					ListviewData.currentmenu = menulist.人类防具;
					this.refreshListView(menulist.人类武器);
					this.comboBox1.SelectedIndex = 0;
					this.comboBox1.Tag = 0;
					this.comboBox34.SelectedIndex = 0;
					this.comboBox34.Tag = 0;
					this.comboBox18.SelectedIndex = 0;
					if (this.mmdata.junhao == 162)
					{
						this.checkBox2.Checked = true;
						return;
					}
				}
				else
				{
					MessageBox.Show("打开的文件有错，可能不是zzjb的rom", "错误", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
				}
			}
		}
		private void bind_initdata()
		{
			int selectedIndex = this.comboBox1.SelectedIndex;
			this.numericUpDown1.Value = this.mmdata.Gethumen_level(selectedIndex);
			this.numericUpDown2.Value = this.mmdata.Gethumen_level2(selectedIndex, 0);
			this.numericUpDown4.Value = this.mmdata.Gethumen_level2(selectedIndex, 1);
			this.numericUpDown3.Value = this.mmdata.Gethumen_level2(selectedIndex, 2);
			this.numericUpDown8.Value = this.mmdata.Gethumen_attrack(selectedIndex);
			this.numericUpDown7.Value = this.mmdata.Gethumen_define(selectedIndex);
			this.numericUpDown6.Value = this.mmdata.Gethumen_qiang(selectedIndex);
			this.numericUpDown5.Value = this.mmdata.Gethumen_zhili(selectedIndex);
			this.numericUpDown10.Value = this.mmdata.Gethumen_tili(selectedIndex);
			this.numericUpDown9.Value = this.mmdata.Gethumen_speed(selectedIndex);
			this.numericUpDown13.Value = this.mmdata.Gethumen_HP(selectedIndex);
			this.numericUpDown12.Value = this.mmdata.Gethumen_exp(selectedIndex);
			this.numericUpDown14.Value = this.mmdata.Gethumen_money();
			this.comboBox2.SelectedIndex = this.mmdata.Gethumen_item(selectedIndex, 0);
			this.comboBox3.SelectedIndex = this.mmdata.Gethumen_item(selectedIndex, 1);
			this.comboBox4.SelectedIndex = this.mmdata.Gethumen_item(selectedIndex, 2);
			this.comboBox5.SelectedIndex = this.mmdata.Gethumen_item(selectedIndex, 3);
			this.comboBox6.SelectedIndex = this.mmdata.Gethumen_item(selectedIndex, 4);
			this.comboBox7.SelectedIndex = this.mmdata.Gethumen_item(selectedIndex, 5);
			this.comboBox8.SelectedIndex = this.mmdata.Gethumen_item(selectedIndex, 6);
			this.comboBox9.SelectedIndex = this.mmdata.Gethumen_item(selectedIndex, 7);
			this.comboBox17.SelectedIndex = this.mmdata.Gethumen_tool(selectedIndex, 0);
			this.comboBox16.SelectedIndex = this.mmdata.Gethumen_tool(selectedIndex, 1);
			this.comboBox15.SelectedIndex = this.mmdata.Gethumen_tool(selectedIndex, 2);
			this.comboBox14.SelectedIndex = this.mmdata.Gethumen_tool(selectedIndex, 3);
			this.comboBox13.SelectedIndex = this.mmdata.Gethumen_tool(selectedIndex, 4);
			this.comboBox12.SelectedIndex = this.mmdata.Gethumen_tool(selectedIndex, 5);
			this.comboBox11.SelectedIndex = this.mmdata.Gethumen_tool(selectedIndex, 6);
			this.comboBox10.SelectedIndex = this.mmdata.Gethumen_tool(selectedIndex, 7);
		}
		private void bind_init_tank()
		{
			int selectedIndex = this.comboBox34.SelectedIndex;
			this.numericUpDown20.Value = this.mmdata.Getdipan_define(selectedIndex);
			this.numericUpDown11.Value = this.mmdata.Gettank_dancang(selectedIndex);
			this.numericUpDown15.Value = this.mmdata.Getdipan_weight(selectedIndex);
			this.comboBox33.SelectedIndex = this.mmdata.Gettank_bullet(selectedIndex, 0);
			this.comboBox32.SelectedIndex = this.mmdata.Gettank_bullet(selectedIndex, 1);
			this.comboBox31.SelectedIndex = this.mmdata.Gettank_bullet(selectedIndex, 2);
			this.comboBox30.SelectedIndex = this.mmdata.Gettank_bullet(selectedIndex, 3);
			this.comboBox29.SelectedIndex = this.mmdata.Gettank_bullet(selectedIndex, 4);
			this.comboBox28.SelectedIndex = this.mmdata.Gettank_bullet(selectedIndex, 5);
			int num = this.mmdata.Gettank_kaidong(selectedIndex);
			for (int i = 0; i < 3; i++)
			{
				if ((num & (int)this.mmdata.sdata[i]) != 0)
				{
					this.checkedListBox1.SetItemChecked(i, true);
				}
				else
				{
					this.checkedListBox1.SetItemChecked(i, false);
				}
			}
		}
		private void save_inittank()
		{
			if (this.comboBox34.Tag == null)
			{
				return;
			}
			int index = (int)this.comboBox34.Tag;
			if (this.numericUpDown20.Value != this.mmdata.Getdipan_define(index))
			{
				this.mmdata.setdipan_define(index, (int)this.numericUpDown20.Value);
			}
			if (this.numericUpDown11.Value != this.mmdata.Gettank_dancang(index))
			{
				this.mmdata.settank_dancang(index, (int)this.numericUpDown11.Value);
			}
			if (this.numericUpDown15.Value != this.mmdata.Getdipan_weight(index))
			{
				this.mmdata.setddipan_weight(index, (int)this.numericUpDown15.Value);
			}
			if (this.comboBox33.SelectedIndex != this.mmdata.Gettank_bullet(index, 0))
			{
				this.mmdata.settank_bullet(index, 0, this.comboBox33.SelectedIndex);
			}
			if (this.comboBox32.SelectedIndex != this.mmdata.Gettank_bullet(index, 1))
			{
				this.mmdata.settank_bullet(index, 1, this.comboBox32.SelectedIndex);
			}
			if (this.comboBox31.SelectedIndex != this.mmdata.Gettank_bullet(index, 2))
			{
				this.mmdata.settank_bullet(index, 2, this.comboBox31.SelectedIndex);
			}
			if (this.comboBox30.SelectedIndex != this.mmdata.Gettank_bullet(index, 3))
			{
				this.mmdata.settank_bullet(index, 3, this.comboBox30.SelectedIndex);
			}
			if (this.comboBox29.SelectedIndex != this.mmdata.Gettank_bullet(index, 4))
			{
				this.mmdata.settank_bullet(index, 4, this.comboBox29.SelectedIndex);
			}
			if (this.comboBox28.SelectedIndex != this.mmdata.Gettank_bullet(index, 5))
			{
				this.mmdata.settank_bullet(index, 5, this.comboBox28.SelectedIndex);
			}
			int num = 0;
			for (int i = 0; i < 3; i++)
			{
				if (this.checkedListBox1.GetItemChecked(i))
				{
					num |= (int)this.mmdata.sdata[i];
				}
			}
			if (num != this.mmdata.Gettank_kaidong(index))
			{
				this.mmdata.settank_kaidong(index, num);
			}
		}
		private void save_initdata()
		{
			if (this.comboBox1.Tag == null)
			{
				return;
			}
			int index = (int)this.comboBox1.Tag;
			if (this.numericUpDown1.Value != this.mmdata.Gethumen_level(index))
			{
				this.mmdata.sethumen_level(index, (int)this.numericUpDown1.Value);
			}
			if (this.numericUpDown2.Value != this.mmdata.Gethumen_level2(index, 0))
			{
				this.mmdata.sethumen_level2(index, 0, (int)this.numericUpDown2.Value);
			}
			if (this.numericUpDown4.Value != this.mmdata.Gethumen_level2(index, 1))
			{
				this.mmdata.sethumen_level2(index, 1, (int)this.numericUpDown4.Value);
			}
			if (this.numericUpDown3.Value != this.mmdata.Gethumen_level2(index, 2))
			{
				this.mmdata.sethumen_level2(index, 2, (int)this.numericUpDown3.Value);
			}
			if (this.numericUpDown8.Value != this.mmdata.Gethumen_attrack(index))
			{
				this.mmdata.sethumen_attrack(index, (int)this.numericUpDown8.Value);
			}
			if (this.numericUpDown7.Value != this.mmdata.Gethumen_define(index))
			{
				this.mmdata.sethumen_define(index, (int)this.numericUpDown7.Value);
			}
			if (this.numericUpDown6.Value != this.mmdata.Gethumen_qiang(index))
			{
				this.mmdata.sethumen_qiang(index, (int)this.numericUpDown6.Value);
			}
			if (this.numericUpDown5.Value != this.mmdata.Gethumen_zhili(index))
			{
				this.mmdata.sethumen_zhili(index, (int)this.numericUpDown5.Value);
			}
			if (this.numericUpDown10.Value != this.mmdata.Gethumen_tili(index))
			{
				this.mmdata.sethumen_tili(index, (int)this.numericUpDown10.Value);
			}
			if (this.numericUpDown9.Value != this.mmdata.Gethumen_speed(index))
			{
				this.mmdata.sethumen_speed(index, (int)this.numericUpDown9.Value);
			}
			if (this.numericUpDown13.Value != this.mmdata.Gethumen_HP(index))
			{
				this.mmdata.sethumen_HP(index, (int)this.numericUpDown13.Value);
			}
			if (this.numericUpDown12.Value != this.mmdata.Gethumen_exp(index))
			{
				this.mmdata.sethumen_exp(index, (int)this.numericUpDown12.Value);
			}
			if (this.numericUpDown14.Value != this.mmdata.Gethumen_money())
			{
				this.mmdata.sethumen_money((int)this.numericUpDown14.Value);
			}
			if (this.comboBox2.SelectedIndex != this.mmdata.Gethumen_item(index, 0))
			{
				this.mmdata.sethumen_item(index, 0, this.comboBox2.SelectedIndex);
			}
			if (this.comboBox3.SelectedIndex != this.mmdata.Gethumen_item(index, 1))
			{
				this.mmdata.sethumen_item(index, 1, this.comboBox3.SelectedIndex);
			}
			if (this.comboBox4.SelectedIndex != this.mmdata.Gethumen_item(index, 2))
			{
				this.mmdata.sethumen_item(index, 2, this.comboBox4.SelectedIndex);
			}
			if (this.comboBox5.SelectedIndex != this.mmdata.Gethumen_item(index, 3))
			{
				this.mmdata.sethumen_item(index, 3, this.comboBox5.SelectedIndex);
			}
			if (this.comboBox6.SelectedIndex != this.mmdata.Gethumen_item(index, 4))
			{
				this.mmdata.sethumen_item(index, 4, this.comboBox6.SelectedIndex);
			}
			if (this.comboBox7.SelectedIndex != this.mmdata.Gethumen_item(index, 5))
			{
				this.mmdata.sethumen_item(index, 5, this.comboBox7.SelectedIndex);
			}
			if (this.comboBox8.SelectedIndex != this.mmdata.Gethumen_item(index, 6))
			{
				this.mmdata.sethumen_item(index, 6, this.comboBox8.SelectedIndex);
			}
			if (this.comboBox9.SelectedIndex != this.mmdata.Gethumen_item(index, 7))
			{
				this.mmdata.sethumen_item(index, 7, this.comboBox9.SelectedIndex);
			}
			if (this.comboBox17.SelectedIndex != this.mmdata.Gethumen_tool(index, 0))
			{
				this.mmdata.sethumen_tool(index, 0, this.comboBox17.SelectedIndex);
			}
			if (this.comboBox16.SelectedIndex != this.mmdata.Gethumen_tool(index, 1))
			{
				this.mmdata.sethumen_tool(index, 1, this.comboBox16.SelectedIndex);
			}
			if (this.comboBox15.SelectedIndex != this.mmdata.Gethumen_tool(index, 2))
			{
				this.mmdata.sethumen_tool(index, 2, this.comboBox15.SelectedIndex);
			}
			if (this.comboBox14.SelectedIndex != this.mmdata.Gethumen_tool(index, 3))
			{
				this.mmdata.sethumen_tool(index, 3, this.comboBox14.SelectedIndex);
			}
			if (this.comboBox13.SelectedIndex != this.mmdata.Gethumen_tool(index, 4))
			{
				this.mmdata.sethumen_tool(index, 4, this.comboBox13.SelectedIndex);
			}
			if (this.comboBox12.SelectedIndex != this.mmdata.Gethumen_tool(index, 5))
			{
				this.mmdata.sethumen_tool(index, 5, this.comboBox12.SelectedIndex);
			}
			if (this.comboBox11.SelectedIndex != this.mmdata.Gethumen_tool(index, 6))
			{
				this.mmdata.sethumen_tool(index, 6, this.comboBox11.SelectedIndex);
			}
			if (this.comboBox10.SelectedIndex != this.mmdata.Gethumen_tool(index, 7))
			{
				this.mmdata.sethumen_tool(index, 7, this.comboBox10.SelectedIndex);
			}
		}
		private void bind_tongji()
		{
			this.textBox1.Text = this.mmdata.Gettongji_money(this.comboBox18.SelectedIndex).ToString();
		}
		private void toolStripButton1_Click_1(object sender, EventArgs e)
		{
			this.OpenMMRom();
		}
		private void 浏览OToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.OpenMMRom();
		}
		private void setListViewHeader()
		{
			this.listView1.Clear();
			string[] listViewHeader = this.listdata.GetListViewHeader(ListviewData.currentmenu);
			for (int i = 0; i < listViewHeader.GetLength(0); i++)
			{
				this.listView1.Columns.Add(listViewHeader[i]);
			}
		}
		private void refreshListView(menulist list)
		{
			if (!mm1data.IsOpen || list == ListviewData.currentmenu)
			{
				return;
			}
			ListviewData.currentmenu = list;
			this.toolStripStatusLabel2.Text = ListviewData.currentmenu.ToString();
			if (list == menulist.初始数据)
			{
				this.listView1.Visible = false;
				this.panel1.Visible = true;
				return;
			}
			this.panel1.Visible = false;
			this.listView1.Visible = true;
			this.setListViewHeader();
			ArrayList eachMenuData = this.mmdata.getEachMenuData(ListviewData.currentmenu);
			for (int i = 0; i < eachMenuData.Count; i++)
			{
				string[] array = (string[])eachMenuData[i];
				this.listView1.Items.Add(array[0]);
				for (int j = 1; j < array.GetLength(0); j++)
				{
					this.listView1.Items[i].SubItems.Add(array[j]);
				}
			}
            this.listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
		private void 人类武器ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.refreshListView(menulist.人类武器);
		}
		private void 人类防具ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.refreshListView(menulist.人类防具);
		}
		private void 人类道具ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.refreshListView(menulist.人类道具);
		}
		private void 坦克主炮ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.refreshListView(menulist.坦克主炮);
		}
		private void 坦克副炮ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.refreshListView(menulist.坦克副炮);
		}
		private void 坦克ＳＥToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.refreshListView(menulist.坦克SE);
		}
		private void toolStripMenuItem1_Click(object sender, EventArgs e)
		{
			this.refreshListView(menulist.坦克引擎);
		}
		private void toolStripMenuItem2_Click(object sender, EventArgs e)
		{
			this.refreshListView(menulist.坦克底盘);
		}
		private void 坦克道具ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.refreshListView(menulist.坦克道具);
		}
		private void toolStripMenuItem3_Click(object sender, EventArgs e)
		{
			this.refreshListView(menulist.C装置);
		}
		private void listView1_DoubleClick(object sender, EventArgs e)
		{
			if (this.listView1.SelectedIndices[0] < 0)
			{
				return;
			}
			int num = (int)Convert.ToInt16(this.listView1.SelectedItems[0].Text);
			Form form;
			if (ListviewData.currentmenu <= menulist.人类道具)
			{
				form = new detail1();
				((detail1)form).itemid = num;
			}
			else if (ListviewData.currentmenu <= menulist.C装置)
			{
				form = new tankdetail();
				((tankdetail)form).itemid = num;
			}
			else if (ListviewData.currentmenu == menulist.怪物数据)
			{
				form = new enengy();
				((enengy)form).enemyid = num;
			}
			else
			{
				form = new Form();
			}
			if (form.ShowDialog(this) == DialogResult.OK)
			{
				string[] array = this.mmdata.getsingleMenuData(ListviewData.currentmenu, this.listView1.SelectedIndices[0]);
				for (int i = 0; i < array.GetLength(0); i++)
				{
					this.listView1.SelectedItems[0].SubItems[i].Text = array[i];
                }
            }
			form.Dispose();
			GC.Collect();
		}
		private void toolStripButton2_Click(object sender, EventArgs e)
		{
			this.saveData();
		}
		private void saveData()
		{
			if (!mm1data.IsOpen)
			{
				return;
			}
			this.save_initdata();
			this.save_inittank();
			if (this.mmdata.ModifyDataList.Count == 0)
			{
				MessageBox.Show(this, "没有更改！");
				return;
			}
			FileStream output = new FileStream(this.mmdata.FilePath, FileMode.Open, FileAccess.Write);
			BinaryWriter binaryWriter = new BinaryWriter(output);
			for (int i = 0; i < this.mmdata.ModifyDataList.Count; i++)
			{
				long address = ((ModifyDatastruct)this.mmdata.ModifyDataList[i]).address;
				byte newvalue = ((ModifyDatastruct)this.mmdata.ModifyDataList[i]).newvalue;
				binaryWriter.BaseStream.Seek(address, SeekOrigin.Begin);
				binaryWriter.BaseStream.WriteByte(newvalue);
			}
			binaryWriter.Flush();
			binaryWriter.Close();
			this.mmdata.ModifyDataList.Clear();
			MessageBox.Show(this, "保存完毕！");
		}
		private void 保存SToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.saveData();
		}
		private void 关于AToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.about.ShowDialog(this);
		}
		private void toolStripButton3_Click(object sender, EventArgs e)
		{
			this.refreshListView(menulist.怪物数据);
		}
		public int Select_listview_index()
		{
			if (this.listView1.Items.Count > 0)
			{
				return this.listView1.SelectedIndices[0];
			}
			return -1;
		}
		public void set_listview_index(int index)
		{
			if (this.listView1.Items.Count > index)
			{
				this.listView1.Items[index].Selected = true;
			}
		}
		public int get_listview_count()
		{
			return this.listView1.Items.Count;
		}
		private void toolStripButton6_Click(object sender, EventArgs e)
		{
			this.about.ShowDialog(this);
		}
		private void toolStripButton5_Click(object sender, EventArgs e)
		{
			this.note.ShowDialog(this);
		}
		private void 说明NToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.note.ShowDialog(this);
		}
		private void toolStripButton7_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		private void 退出XToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		private void toolStripButton4_Click(object sender, EventArgs e)
		{
			this.refreshListView(menulist.初始数据);
		}
		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.save_initdata();
			this.comboBox1.Tag = this.comboBox1.SelectedIndex;
			this.bind_initdata();
		}
		private void Form1_Load(object sender, EventArgs e)
		{
			this.panel1.Visible = false;
		}
		private void comboBox34_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.save_inittank();
			this.comboBox34.Tag = this.comboBox34.SelectedIndex;
			this.bind_init_tank();
		}
		private void comboBox18_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.bind_tongji();
		}
		private void textBox1_DoubleClick(object sender, EventArgs e)
		{
			DatadictSelect datadictSelect = new DatadictSelect();
			datadictSelect.Owner = this;
			datadictSelect.caption = "修改 " + this.comboBox18.SelectedText + " 的赏金";
			datadictSelect.maxvalue = 200000;
			datadictSelect.current = Convert.ToInt32(this.textBox1.Text);
			if (datadictSelect.ShowDialog() == DialogResult.OK)
			{
				this.textBox1.Text = datadictSelect.returntext;
				this.mmdata.settongji_money(this.comboBox18.SelectedIndex, datadictSelect.returnvalue);
			}
			datadictSelect.Dispose();
			GC.Collect();
		}
		private void checkBox2_CheckedChanged(object sender, EventArgs e)
		{
			if (this.checkBox2.Checked)
			{
				this.mmdata.ModifyDataList.Add(new ModifyDatastruct(131088L, 162));
				return;
			}
			this.mmdata.ModifyDataList.Add(new ModifyDatastruct(131088L, 1));
		}
		public mm1data mmdata;
		private ListviewData listdata;
		private about about;
		private note note;
	}
}
