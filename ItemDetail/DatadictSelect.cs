using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Doubledr.Data;

namespace Doubledr.ItemDetail
{
	public partial class DatadictSelect : Form
	{
		public DatadictSelect()
		{
			this.InitializeComponent();
		}
		private void DatadictSelect_Load(object sender, EventArgs e)
		{
			mm1data mmdata;
			if (base.Owner is Form1)
			{
				mmdata = ((Form1)base.Owner).mmdata;
			}
			else
			{
				mmdata = ((Form1)base.Owner.Owner).mmdata;
			}
			this.Text = this.caption;
			DataTable dataTable = new DataTable();
			dataTable.Columns.Add("c");
			dataTable.Columns.Add("v");
			dataTable.Columns[1].DataType = 1.GetType();
			for (int i = 0; i < mmdata.DataDict.Length; i++)
			{
				dataTable.Rows.Add(new object[]
				{
					i,
					mmdata.DataDict[i]
				});
			}
			DataView dataView = new DataView(dataTable);
			dataView.Sort = "v";
			if (this.maxvalue != 0)
			{
				dataView.RowFilter = "v<=" + this.maxvalue.ToString();
			}
			bool flag = true;
			for (int j = 0; j < dataView.Count; j++)
			{
				this.checkedListBox1.Items.Add(new checklistitem(dataView[j][1].ToString(), (int)Convert.ToInt16(dataView[j][0].ToString())));
				if (flag & Convert.ToInt32(dataView[j][1]) == this.current)
				{
					this.checkedListBox1.SetItemChecked(j, flag);
					this.checkedListBox1.SelectedIndex = j;
					this.selectitemid = j;
					flag = false;
				}
			}
			if (this.maxvalue == 0)
			{
				this.checkedListBox1.Items.Add(new checklistitem("无价,可以丢弃", 254));
				this.checkedListBox1.Items.Add(new checklistitem("无价,不可丢弃", 255));
				if (flag)
				{
					if (this.current == -1)
					{
						this.checkedListBox1.SetItemChecked(this.checkedListBox1.Items.Count - 2, true);
						this.checkedListBox1.SelectedIndex = this.checkedListBox1.Items.Count - 2;
						this.selectitemid = this.checkedListBox1.Items.Count - 2;
					}
					if (this.current == -2)
					{
						this.checkedListBox1.SetItemChecked(this.checkedListBox1.Items.Count - 1, true);
						this.checkedListBox1.SelectedIndex = this.checkedListBox1.Items.Count - 1;
						this.selectitemid = this.checkedListBox1.Items.Count - 1;
					}
				}
			}
		}
		private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
		{
			if (this.selectitemid >= 0 && this.selectitemid != e.Index)
			{
				this.checkedListBox1.SetItemChecked(this.selectitemid, false);
				this.selectitemid = e.Index;
			}
		}
		private void button1_Click(object sender, EventArgs e)
		{
			if (this.checkedListBox1.CheckedItems.Count == 0)
			{
				base.DialogResult = DialogResult.Cancel;
				return;
			}
			this.returnvalue = ((checklistitem)this.checkedListBox1.CheckedItems[0]).index;
			this.returntext = this.checkedListBox1.CheckedItems[0].ToString();
			base.DialogResult = DialogResult.OK;
		}
		public int returnvalue;
		public string returntext;
		public int maxvalue;
		public string caption;
		public int current;
		private int selectitemid = -1;
	}
}
