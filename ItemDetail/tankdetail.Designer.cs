namespace Doubledr.ItemDetail
{
	public partial class tankdetail : global::System.Windows.Forms.Form
	{
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}
		private void InitializeComponent()
		{
			this.button1 = new global::System.Windows.Forms.Button();
			this.groupBox1 = new global::System.Windows.Forms.GroupBox();
			this.textBox2 = new global::System.Windows.Forms.TextBox();
			this.textBox1 = new global::System.Windows.Forms.TextBox();
			this.trackBar2 = new global::System.Windows.Forms.TrackBar();
			this.trackBar1 = new global::System.Windows.Forms.TrackBar();
			this.comboBox2 = new global::System.Windows.Forms.ComboBox();
			this.label10 = new global::System.Windows.Forms.Label();
			this.label9 = new global::System.Windows.Forms.Label();
			this.label8 = new global::System.Windows.Forms.Label();
			this.tb_define = new global::System.Windows.Forms.TextBox();
			this.tb_price = new global::System.Windows.Forms.TextBox();
			this.tb_attrack = new global::System.Windows.Forms.TextBox();
			this.comboBox1 = new global::System.Windows.Forms.ComboBox();
			this.label7 = new global::System.Windows.Forms.Label();
			this.label6 = new global::System.Windows.Forms.Label();
			this.checkedListBox1 = new global::System.Windows.Forms.CheckedListBox();
			this.label5 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.label11 = new global::System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.trackBar2).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.trackBar1).BeginInit();
			base.SuspendLayout();
			this.button1.Location = new global::System.Drawing.Point(342, 335);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(96, 23);
			this.button1.TabIndex = 4;
			this.button1.Text = "关闭（保存）";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.groupBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.groupBox1.Controls.Add(this.textBox2);
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Controls.Add(this.trackBar2);
			this.groupBox1.Controls.Add(this.trackBar1);
			this.groupBox1.Controls.Add(this.comboBox2);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.tb_define);
			this.groupBox1.Controls.Add(this.tb_price);
			this.groupBox1.Controls.Add(this.tb_attrack);
			this.groupBox1.Controls.Add(this.comboBox1);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.checkedListBox1);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.ForeColor = global::System.Drawing.Color.Blue;
			this.groupBox1.Location = new global::System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new global::System.Drawing.Size(426, 317);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "数据";
			this.textBox2.Location = new global::System.Drawing.Point(280, 217);
			this.textBox2.Name = "textBox2";
			this.textBox2.ReadOnly = true;
			this.textBox2.Size = new global::System.Drawing.Size(58, 21);
			this.textBox2.TabIndex = 20;
			this.textBox1.Location = new global::System.Drawing.Point(108, 217);
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new global::System.Drawing.Size(58, 21);
			this.textBox1.TabIndex = 19;
			this.textBox1.Visible = false;
			this.trackBar2.Location = new global::System.Drawing.Point(226, 211);
			this.trackBar2.Maximum = 255;
			this.trackBar2.Minimum = 1;
			this.trackBar2.Name = "trackBar2";
			this.trackBar2.Orientation = global::System.Windows.Forms.Orientation.Vertical;
			this.trackBar2.Size = new global::System.Drawing.Size(45, 100);
			this.trackBar2.TabIndex = 18;
			this.trackBar2.TickFrequency = 5;
			this.trackBar2.TickStyle = global::System.Windows.Forms.TickStyle.TopLeft;
			this.trackBar2.Value = 1;
			this.trackBar2.Scroll += new global::System.EventHandler(this.trackBar2_Scroll);
			this.trackBar1.Location = new global::System.Drawing.Point(63, 211);
			this.trackBar1.Maximum = 99;
			this.trackBar1.Minimum = 1;
			this.trackBar1.Name = "trackBar1";
			this.trackBar1.Orientation = global::System.Windows.Forms.Orientation.Vertical;
			this.trackBar1.Size = new global::System.Drawing.Size(45, 100);
			this.trackBar1.TabIndex = 17;
			this.trackBar1.TickFrequency = 5;
			this.trackBar1.TickStyle = global::System.Windows.Forms.TickStyle.TopLeft;
			this.trackBar1.Value = 1;
			this.trackBar1.Visible = false;
			this.trackBar1.Scroll += new global::System.EventHandler(this.trackBar1_Scroll);
			this.comboBox2.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox2.FlatStyle = global::System.Windows.Forms.FlatStyle.System;
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Items.AddRange(new object[]
			{
				"２弹",
				"４弹",
				"８弹",
				"１６弹",
				"３２弹",
				"４８弹",
				"６４弹",
				"无限弹"
			});
			this.comboBox2.Location = new global::System.Drawing.Point(238, 141);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new global::System.Drawing.Size(100, 20);
			this.comboBox2.TabIndex = 16;
			this.comboBox2.SelectedIndexChanged += new global::System.EventHandler(this.comboBox2_SelectedIndexChanged);
			this.label10.AutoSize = true;
			this.label10.FlatStyle = global::System.Windows.Forms.FlatStyle.System;
			this.label10.ForeColor = global::System.Drawing.SystemColors.ControlText;
			this.label10.Location = new global::System.Drawing.Point(19, 220);
			this.label10.Name = "label10";
			this.label10.Size = new global::System.Drawing.Size(41, 12);
			this.label10.TabIndex = 14;
			this.label10.Text = "载重量";
			this.label10.Visible = false;
			this.label9.AutoSize = true;
			this.label9.FlatStyle = global::System.Windows.Forms.FlatStyle.System;
			this.label9.ForeColor = global::System.Drawing.SystemColors.ControlText;
			this.label9.Location = new global::System.Drawing.Point(179, 220);
			this.label9.Name = "label9";
			this.label9.Size = new global::System.Drawing.Size(41, 12);
			this.label9.TabIndex = 13;
			this.label9.Text = "自重量";
			this.label8.AutoSize = true;
			this.label8.FlatStyle = global::System.Windows.Forms.FlatStyle.System;
			this.label8.ForeColor = global::System.Drawing.SystemColors.ControlText;
			this.label8.Location = new global::System.Drawing.Point(179, 144);
			this.label8.Name = "label8";
			this.label8.Size = new global::System.Drawing.Size(29, 12);
			this.label8.TabIndex = 12;
			this.label8.Text = "弹数";
			this.tb_define.Location = new global::System.Drawing.Point(66, 100);
			this.tb_define.Name = "tb_define";
			this.tb_define.ReadOnly = true;
			this.tb_define.Size = new global::System.Drawing.Size(100, 21);
			this.tb_define.TabIndex = 11;
			this.tb_define.DoubleClick += new global::System.EventHandler(this.tb_define_DoubleClick);
			this.tb_price.Location = new global::System.Drawing.Point(238, 61);
			this.tb_price.Name = "tb_price";
			this.tb_price.ReadOnly = true;
			this.tb_price.Size = new global::System.Drawing.Size(100, 21);
			this.tb_price.TabIndex = 10;
			this.tb_price.DoubleClick += new global::System.EventHandler(this.tb_price_DoubleClick);
			this.tb_attrack.Location = new global::System.Drawing.Point(66, 61);
			this.tb_attrack.Name = "tb_attrack";
			this.tb_attrack.ReadOnly = true;
			this.tb_attrack.Size = new global::System.Drawing.Size(100, 21);
			this.tb_attrack.TabIndex = 9;
			this.tb_attrack.DoubleClick += new global::System.EventHandler(this.tb_attrack_DoubleClick);
			this.comboBox1.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.FlatStyle = global::System.Windows.Forms.FlatStyle.System;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[]
			{
				"个",
				"组",
				"全"
			});
			this.comboBox1.Location = new global::System.Drawing.Point(238, 101);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new global::System.Drawing.Size(100, 20);
			this.comboBox1.TabIndex = 8;
			this.comboBox1.SelectedIndexChanged += new global::System.EventHandler(this.comboBox1_SelectedIndexChanged);
			this.label7.AutoSize = true;
			this.label7.ForeColor = global::System.Drawing.SystemColors.ControlText;
			this.label7.Location = new global::System.Drawing.Point(179, 103);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(53, 12);
			this.label7.TabIndex = 7;
			this.label7.Text = "攻击范围";
			this.label6.AutoSize = true;
			this.label6.FlatStyle = global::System.Windows.Forms.FlatStyle.System;
			this.label6.ForeColor = global::System.Drawing.SystemColors.ControlText;
			this.label6.Location = new global::System.Drawing.Point(19, 141);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(65, 12);
			this.label6.TabIndex = 6;
			this.label6.Text = "可装备部位";
			this.checkedListBox1.CheckOnClick = true;
			this.checkedListBox1.FormattingEnabled = true;
			this.checkedListBox1.Items.AddRange(new object[]
			{
				"主",
				"副",
				"ＳＥ"
			});
			this.checkedListBox1.Location = new global::System.Drawing.Point(94, 141);
			this.checkedListBox1.Name = "checkedListBox1";
			this.checkedListBox1.Size = new global::System.Drawing.Size(65, 52);
			this.checkedListBox1.TabIndex = 5;
			this.checkedListBox1.SelectedIndexChanged += new global::System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
			this.label5.AutoSize = true;
			this.label5.FlatStyle = global::System.Windows.Forms.FlatStyle.System;
			this.label5.ForeColor = global::System.Drawing.SystemColors.ControlText;
			this.label5.Location = new global::System.Drawing.Point(19, 103);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(41, 12);
			this.label5.TabIndex = 4;
			this.label5.Text = "防御力";
			this.label4.AutoSize = true;
			this.label4.FlatStyle = global::System.Windows.Forms.FlatStyle.System;
			this.label4.ForeColor = global::System.Drawing.SystemColors.ControlText;
			this.label4.Location = new global::System.Drawing.Point(19, 64);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(41, 12);
			this.label4.TabIndex = 3;
			this.label4.Text = "攻击力";
			this.label3.AutoSize = true;
			this.label3.FlatStyle = global::System.Windows.Forms.FlatStyle.System;
			this.label3.ForeColor = global::System.Drawing.SystemColors.ControlText;
			this.label3.Location = new global::System.Drawing.Point(179, 64);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(29, 12);
			this.label3.TabIndex = 2;
			this.label3.Text = "价格";
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(130, 28);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(29, 12);
			this.label2.TabIndex = 1;
			this.label2.Text = "名称";
			this.label1.AutoSize = true;
			this.label1.ForeColor = global::System.Drawing.SystemColors.ControlText;
			this.label1.Location = new global::System.Drawing.Point(19, 28);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(89, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "正在编辑的道具";
			this.label11.AutoSize = true;
			this.label11.ForeColor = global::System.Drawing.Color.Red;
			this.label11.Location = new global::System.Drawing.Point(23, 340);
			this.label11.Name = "label11";
			this.label11.Size = new global::System.Drawing.Size(197, 12);
			this.label11.TabIndex = 5;
			this.label11.Text = "说明：双击文本框跳出修改数据界面";
			base.AcceptButton = this.button1;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 12f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(450, 370);
			base.Controls.Add(this.label11);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.groupBox1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "tankdetail";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "坦克道具资料";
			base.Load += new global::System.EventHandler(this.tankdetail_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.trackBar2).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.trackBar1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}
		private global::System.ComponentModel.IContainer components;
		private global::System.Windows.Forms.Button button1;
		private global::System.Windows.Forms.GroupBox groupBox1;
		private global::System.Windows.Forms.TextBox tb_define;
		private global::System.Windows.Forms.TextBox tb_price;
		private global::System.Windows.Forms.TextBox tb_attrack;
		private global::System.Windows.Forms.ComboBox comboBox1;
		private global::System.Windows.Forms.Label label7;
		private global::System.Windows.Forms.Label label6;
		private global::System.Windows.Forms.CheckedListBox checkedListBox1;
		private global::System.Windows.Forms.Label label5;
		private global::System.Windows.Forms.Label label4;
		private global::System.Windows.Forms.Label label3;
		private global::System.Windows.Forms.Label label2;
		private global::System.Windows.Forms.Label label1;
		private global::System.Windows.Forms.Label label8;
		private global::System.Windows.Forms.Label label9;
		private global::System.Windows.Forms.Label label10;
		private global::System.Windows.Forms.ComboBox comboBox2;
		private global::System.Windows.Forms.TrackBar trackBar1;
		private global::System.Windows.Forms.TextBox textBox2;
		private global::System.Windows.Forms.TextBox textBox1;
		private global::System.Windows.Forms.TrackBar trackBar2;
		private global::System.Windows.Forms.Label label11;
	}
}
