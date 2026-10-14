namespace Doubledr
{
	public partial class Form1 : global::System.Windows.Forms.Form
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.人类武器ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.人类防具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.人类道具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.坦克主炮ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.坦克副炮ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.坦克ＳＥToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.坦克道具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.listView1 = new System.Windows.Forms.ListView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox18 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label27 = new System.Windows.Forms.Label();
            this.numericUpDown15 = new System.Windows.Forms.NumericUpDown();
            this.label48 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label44 = new System.Windows.Forms.Label();
            this.numericUpDown11 = new System.Windows.Forms.NumericUpDown();
            this.label43 = new System.Windows.Forms.Label();
            this.comboBox28 = new System.Windows.Forms.ComboBox();
            this.label37 = new System.Windows.Forms.Label();
            this.comboBox29 = new System.Windows.Forms.ComboBox();
            this.label38 = new System.Windows.Forms.Label();
            this.comboBox30 = new System.Windows.Forms.ComboBox();
            this.label39 = new System.Windows.Forms.Label();
            this.comboBox31 = new System.Windows.Forms.ComboBox();
            this.label40 = new System.Windows.Forms.Label();
            this.comboBox32 = new System.Windows.Forms.ComboBox();
            this.label41 = new System.Windows.Forms.Label();
            this.comboBox33 = new System.Windows.Forms.ComboBox();
            this.label42 = new System.Windows.Forms.Label();
            this.numericUpDown20 = new System.Windows.Forms.NumericUpDown();
            this.label52 = new System.Windows.Forms.Label();
            this.comboBox34 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDown14 = new System.Windows.Forms.NumericUpDown();
            this.label47 = new System.Windows.Forms.Label();
            this.numericUpDown13 = new System.Windows.Forms.NumericUpDown();
            this.label46 = new System.Windows.Forms.Label();
            this.numericUpDown12 = new System.Windows.Forms.NumericUpDown();
            this.label45 = new System.Windows.Forms.Label();
            this.comboBox10 = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.comboBox11 = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.comboBox12 = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.comboBox13 = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.comboBox14 = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.comboBox15 = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.comboBox16 = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.comboBox17 = new System.Windows.Forms.ComboBox();
            this.label26 = new System.Windows.Forms.Label();
            this.comboBox9 = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.numericUpDown10 = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.numericUpDown9 = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown6 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown7 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown8 = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown20)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripSeparator2,
            this.toolStripSplitButton1,
            this.toolStripDropDownButton1,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator3,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripButton7});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(834, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(33, 22);
            this.toolStripButton1.Text = "浏览";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.ToolTipText = "打开重装机兵的rom文件";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(33, 22);
            this.toolStripButton2.Text = "保存";
            this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton2.ToolTipText = "保存所做的修改";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.人类武器ToolStripMenuItem,
            this.人类防具ToolStripMenuItem,
            this.人类道具ToolStripMenuItem});
            this.toolStripSplitButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(66, 22);
            this.toolStripSplitButton1.Text = "人类物品";
            this.toolStripSplitButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // 人类武器ToolStripMenuItem
            // 
            this.人类武器ToolStripMenuItem.Name = "人类武器ToolStripMenuItem";
            this.人类武器ToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.人类武器ToolStripMenuItem.Text = "人类武器";
            this.人类武器ToolStripMenuItem.Click += new System.EventHandler(this.人类武器ToolStripMenuItem_Click);
            // 
            // 人类防具ToolStripMenuItem
            // 
            this.人类防具ToolStripMenuItem.Name = "人类防具ToolStripMenuItem";
            this.人类防具ToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.人类防具ToolStripMenuItem.Text = "人类防具";
            this.人类防具ToolStripMenuItem.Click += new System.EventHandler(this.人类防具ToolStripMenuItem_Click);
            // 
            // 人类道具ToolStripMenuItem
            // 
            this.人类道具ToolStripMenuItem.Name = "人类道具ToolStripMenuItem";
            this.人类道具ToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.人类道具ToolStripMenuItem.Text = "人类道具";
            this.人类道具ToolStripMenuItem.Click += new System.EventHandler(this.人类道具ToolStripMenuItem_Click);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.坦克主炮ToolStripMenuItem,
            this.坦克副炮ToolStripMenuItem,
            this.坦克ＳＥToolStripMenuItem,
            this.toolStripMenuItem3,
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.坦克道具ToolStripMenuItem});
            this.toolStripDropDownButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(66, 22);
            this.toolStripDropDownButton1.Text = "坦克物品";
            this.toolStripDropDownButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // 坦克主炮ToolStripMenuItem
            // 
            this.坦克主炮ToolStripMenuItem.Name = "坦克主炮ToolStripMenuItem";
            this.坦克主炮ToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.坦克主炮ToolStripMenuItem.Text = "坦克主炮";
            this.坦克主炮ToolStripMenuItem.Click += new System.EventHandler(this.坦克主炮ToolStripMenuItem_Click);
            // 
            // 坦克副炮ToolStripMenuItem
            // 
            this.坦克副炮ToolStripMenuItem.Name = "坦克副炮ToolStripMenuItem";
            this.坦克副炮ToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.坦克副炮ToolStripMenuItem.Text = "坦克副炮";
            this.坦克副炮ToolStripMenuItem.Click += new System.EventHandler(this.坦克副炮ToolStripMenuItem_Click);
            // 
            // 坦克ＳＥToolStripMenuItem
            // 
            this.坦克ＳＥToolStripMenuItem.Name = "坦克ＳＥToolStripMenuItem";
            this.坦克ＳＥToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.坦克ＳＥToolStripMenuItem.Text = "坦克ＳＥ";
            this.坦克ＳＥToolStripMenuItem.Click += new System.EventHandler(this.坦克ＳＥToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(118, 22);
            this.toolStripMenuItem3.Text = "C装置";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(118, 22);
            this.toolStripMenuItem1.Text = "坦克引擎";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(118, 22);
            this.toolStripMenuItem2.Text = "坦克底盘";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // 坦克道具ToolStripMenuItem
            // 
            this.坦克道具ToolStripMenuItem.Name = "坦克道具ToolStripMenuItem";
            this.坦克道具ToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.坦克道具ToolStripMenuItem.Text = "坦克道具";
            this.坦克道具ToolStripMenuItem.Click += new System.EventHandler(this.坦克道具ToolStripMenuItem_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(57, 22);
            this.toolStripButton3.Text = "怪物资料";
            this.toolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(57, 22);
            this.toolStripButton4.Text = "初始数据";
            this.toolStripButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(33, 22);
            this.toolStripButton5.Text = "说明";
            this.toolStripButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(33, 22);
            this.toolStripButton6.Text = "关于";
            this.toolStripButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton6.Click += new System.EventHandler(this.toolStripButton6_Click);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(33, 22);
            this.toolStripButton7.Text = "退出";
            this.toolStripButton7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton7.Click += new System.EventHandler(this.toolStripButton7_Click);
            // 
            // listView1
            // 
            this.listView1.BackgroundImageTiled = true;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 25);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(834, 564);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 589);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(834, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(35, 17);
            this.toolStripStatusLabel1.Text = "当前:";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.ForeColor = System.Drawing.Color.Red;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(834, 564);
            this.panel1.TabIndex = 4;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkBox2);
            this.groupBox4.Controls.Add(this.checkBox1);
            this.groupBox4.Location = new System.Drawing.Point(620, 186);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(174, 132);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "补丁";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.ForeColor = System.Drawing.Color.Blue;
            this.checkBox2.Location = new System.Drawing.Point(32, 37);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(102, 28);
            this.checkBox2.TabIndex = 0;
            this.checkBox2.Text = "解决中文版\r\n军号无敌的BUG";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Enabled = false;
            this.checkBox1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox1.ForeColor = System.Drawing.Color.Blue;
            this.checkBox1.Location = new System.Drawing.Point(32, 75);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(90, 16);
            this.checkBox1.TabIndex = 53;
            this.checkBox1.Text = "出场就有3人";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label29);
            this.groupBox3.Controls.Add(this.label28);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.comboBox18);
            this.groupBox3.Location = new System.Drawing.Point(444, 186);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(174, 132);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "通缉犯赏金";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.ForeColor = System.Drawing.Color.Red;
            this.label29.Location = new System.Drawing.Point(6, 96);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(101, 12);
            this.label29.TabIndex = 60;
            this.label29.Text = "修改请双击文本框";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(131, 68);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(11, 12);
            this.label28.TabIndex = 3;
            this.label28.Text = "G";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(8, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(121, 21);
            this.textBox1.TabIndex = 2;
            this.textBox1.DoubleClick += new System.EventHandler(this.textBox1_DoubleClick);
            // 
            // comboBox18
            // 
            this.comboBox18.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox18.FormattingEnabled = true;
            this.comboBox18.Items.AddRange(new object[] {
            "水怪",
            "水鬼",
            "马歇尔",
            "大象",
            "神密人",
            "蜈蚣",
            "戈麦斯",
            "弗朗",
            "波特",
            "沙漠之舟",
            "帕鲁"});
            this.comboBox18.Location = new System.Drawing.Point(8, 37);
            this.comboBox18.Name = "comboBox18";
            this.comboBox18.Size = new System.Drawing.Size(121, 20);
            this.comboBox18.TabIndex = 1;
            this.comboBox18.SelectedIndexChanged += new System.EventHandler(this.comboBox18_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label27);
            this.groupBox2.Controls.Add(this.numericUpDown15);
            this.groupBox2.Controls.Add(this.label48);
            this.groupBox2.Controls.Add(this.checkedListBox1);
            this.groupBox2.Controls.Add(this.label44);
            this.groupBox2.Controls.Add(this.numericUpDown11);
            this.groupBox2.Controls.Add(this.label43);
            this.groupBox2.Controls.Add(this.comboBox28);
            this.groupBox2.Controls.Add(this.label37);
            this.groupBox2.Controls.Add(this.comboBox29);
            this.groupBox2.Controls.Add(this.label38);
            this.groupBox2.Controls.Add(this.comboBox30);
            this.groupBox2.Controls.Add(this.label39);
            this.groupBox2.Controls.Add(this.comboBox31);
            this.groupBox2.Controls.Add(this.label40);
            this.groupBox2.Controls.Add(this.comboBox32);
            this.groupBox2.Controls.Add(this.label41);
            this.groupBox2.Controls.Add(this.comboBox33);
            this.groupBox2.Controls.Add(this.label42);
            this.groupBox2.Controls.Add(this.numericUpDown20);
            this.groupBox2.Controls.Add(this.label52);
            this.groupBox2.Controls.Add(this.comboBox34);
            this.groupBox2.Location = new System.Drawing.Point(444, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(350, 175);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "坦克初始属性";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.ForeColor = System.Drawing.Color.Red;
            this.label27.Location = new System.Drawing.Point(249, 70);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(77, 24);
            this.label27.TabIndex = 59;
            this.label27.Text = "重量换算成吨\r\n需除以100";
            // 
            // numericUpDown15
            // 
            this.numericUpDown15.Location = new System.Drawing.Point(276, 42);
            this.numericUpDown15.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDown15.Name = "numericUpDown15";
            this.numericUpDown15.Size = new System.Drawing.Size(50, 21);
            this.numericUpDown15.TabIndex = 58;
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(225, 44);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(53, 12);
            this.label48.TabIndex = 57;
            this.label48.Text = "底盘重量";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.ColumnWidth = 50;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "主",
            "副",
            "SE"});
            this.checkedListBox1.Location = new System.Drawing.Point(51, 75);
            this.checkedListBox1.MultiColumn = true;
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(180, 20);
            this.checkedListBox1.TabIndex = 56;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(6, 78);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(29, 12);
            this.label44.TabIndex = 55;
            this.label44.Text = "开洞";
            // 
            // numericUpDown11
            // 
            this.numericUpDown11.Location = new System.Drawing.Point(169, 43);
            this.numericUpDown11.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDown11.Name = "numericUpDown11";
            this.numericUpDown11.Size = new System.Drawing.Size(50, 21);
            this.numericUpDown11.TabIndex = 54;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(118, 45);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(53, 12);
            this.label43.TabIndex = 53;
            this.label43.Text = "弹仓上限";
            // 
            // comboBox28
            // 
            this.comboBox28.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox28.FormattingEnabled = true;
            this.comboBox28.Items.AddRange(new object[] {
            "空",
            "皮帽",
            "布帽",
            "铁盔",
            "钢盔",
            "银盔",
            "金冠",
            "草帽",
            "头巾",
            "布衣",
            "皮衣",
            "披风",
            "铁衣",
            "铜衣",
            "钢衣",
            "银衣",
            "金衣",
            "草鞋",
            "布鞋",
            "皮鞋",
            "皮靴",
            "铁靴",
            "钢靴",
            "金靴",
            "背心",
            "皮甲",
            "金甲",
            "钢甲",
            "铁甲",
            "布手套",
            "皮手套",
            "铁爪",
            "铜爪",
            "钢爪",
            "金爪",
            "激光炮(1)",
            "激光炮(2)",
            "激光炮(3)",
            "激光炮(4)",
            "激光炮(5)",
            "激光炮(6)",
            "弹攻",
            "弩",
            "短枪",
            "战斧",
            "火枪",
            "回旋镖",
            "钢刀",
            "长枪",
            "机枪",
            "弹筒枪",
            "来福枪",
            "排炮",
            "军刀",
            "声纳枪",
            "火焰炮",
            "中子炮",
            "弹筒",
            "音波枪",
            "宝刀",
            "火箭炮",
            "穿甲炮",
            "飞龙火",
            "迫击炮",
            "首",
            "45炮",
            "55炮",
            "75炮",
            "80高炮",
            "95炮",
            "105加农炮",
            "115T型炮",
            "125加农炮",
            "125T型炮",
            "135加农炮",
            "140高炮",
            "155加农炮",
            "160滑膛炮",
            "165T型炮",
            "175加农炮",
            "195加农炮",
            "165钢炮",
            "180高炮",
            "205加农炮",
            "220炮",
            "ATM导弹",
            "喷火",
            "弹炮",
            "LI旋炮",
            "电光",
            "汽弹",
            "拉卡",
            "福特",
            "火狼",
            "台风",
            "雷电",
            "巨炮",
            "火神",
            "气旋",
            "截击",
            "托卢",
            "07机关炮",
            "09机关炮",
            "格林炮",
            "11机关炮",
            "09火炮",
            "11火炮",
            "15机关炮",
            "激光",
            "雷神",
            "18机关炮",
            "闪电",
            "20火炮",
            "25机关炮",
            "火龙",
            "风暴",
            "波坦",
            "HAL9000",
            "尼克",
            "艾米",
            "SOLOMON2",
            "MOT1",
            "MOT2",
            "MOT3",
            "SOLO",
            "SOL1",
            "SOL2",
            "BUL",
            "BUL1",
            "BUL11",
            "HUN0",
            "HUN1",
            "HUN2",
            "V24",
            "V32",
            "V48",
            "SIL0",
            "SIL1",
            "SIL2",
            "OHC",
            "涡轮",
            "喷气",
            "V48金刚式",
            "V66",
            "V100",
            "WEN",
            "HOR",
            "CAR",
            "TAN",
            "BAO",
            "HU",
            "RLA",
            "KHU",
            "毛巾",
            "面具",
            "口罩",
            "军号",
            "兴奋剂",
            "灭火器",
            "烟雾",
            "消火栓",
            "榴弹",
            "穿甲弹",
            "手雷",
            "导弹",
            "火瓶",
            "酸瓶",
            "石子",
            "钱包",
            "参丸",
            "党参",
            "人参",
            "灵丹",
            "喷雾剂",
            "地图",
            "空",
            "修理箱",
            "再生丸",
            "古币",
            "探雷器",
            "探测仪",
            "醉药",
            "钥匙",
            "扳手",
            "象牙",
            "光镜",
            "宝石镜",
            "太阳镜",
            "眼镜",
            "戒指",
            "纹身",
            "金棒",
            "游戏机",
            "女内衣",
            "男内衣",
            "解药",
            "药液",
            "银棒",
            "铜棒",
            "笔记",
            "日记",
            "密码本",
            "花板",
            "传真,",
            "迷彩条,",
            "PAG40,",
            "PAG80,",
            "PAGL,",
            "PAGLL,",
            "药箱,",
            "石蜡,",
            "空调,",
            "暖风机,",
            "冷风机,",
            "气扇,",
            "雷达,",
            "护屏,",
            "消活栓,",
            "卡通兔,",
            "撞击板,",
            "鸟类,",
            "铅竹"});
            this.comboBox28.Location = new System.Drawing.Point(215, 150);
            this.comboBox28.Name = "comboBox28";
            this.comboBox28.Size = new System.Drawing.Size(89, 20);
            this.comboBox28.TabIndex = 32;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(168, 153);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(41, 12);
            this.label37.TabIndex = 31;
            this.label37.Text = "装备六";
            // 
            // comboBox29
            // 
            this.comboBox29.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox29.FormattingEnabled = true;
            this.comboBox29.Items.AddRange(new object[] {
            "空",
            "皮帽",
            "布帽",
            "铁盔",
            "钢盔",
            "银盔",
            "金冠",
            "草帽",
            "头巾",
            "布衣",
            "皮衣",
            "披风",
            "铁衣",
            "铜衣",
            "钢衣",
            "银衣",
            "金衣",
            "草鞋",
            "布鞋",
            "皮鞋",
            "皮靴",
            "铁靴",
            "钢靴",
            "金靴",
            "背心",
            "皮甲",
            "金甲",
            "钢甲",
            "铁甲",
            "布手套",
            "皮手套",
            "铁爪",
            "铜爪",
            "钢爪",
            "金爪",
            "激光炮(1)",
            "激光炮(2)",
            "激光炮(3)",
            "激光炮(4)",
            "激光炮(5)",
            "激光炮(6)",
            "弹攻",
            "弩",
            "短枪",
            "战斧",
            "火枪",
            "回旋镖",
            "钢刀",
            "长枪",
            "机枪",
            "弹筒枪",
            "来福枪",
            "排炮",
            "军刀",
            "声纳枪",
            "火焰炮",
            "中子炮",
            "弹筒",
            "音波枪",
            "宝刀",
            "火箭炮",
            "穿甲炮",
            "飞龙火",
            "迫击炮",
            "首",
            "45炮",
            "55炮",
            "75炮",
            "80高炮",
            "95炮",
            "105加农炮",
            "115T型炮",
            "125加农炮",
            "125T型炮",
            "135加农炮",
            "140高炮",
            "155加农炮",
            "160滑膛炮",
            "165T型炮",
            "175加农炮",
            "195加农炮",
            "165钢炮",
            "180高炮",
            "205加农炮",
            "220炮",
            "ATM导弹",
            "喷火",
            "弹炮",
            "LI旋炮",
            "电光",
            "汽弹",
            "拉卡",
            "福特",
            "火狼",
            "台风",
            "雷电",
            "巨炮",
            "火神",
            "气旋",
            "截击",
            "托卢",
            "07机关炮",
            "09机关炮",
            "格林炮",
            "11机关炮",
            "09火炮",
            "11火炮",
            "15机关炮",
            "激光",
            "雷神",
            "18机关炮",
            "闪电",
            "20火炮",
            "25机关炮",
            "火龙",
            "风暴",
            "波坦",
            "HAL9000",
            "尼克",
            "艾米",
            "SOLOMON2",
            "MOT1",
            "MOT2",
            "MOT3",
            "SOLO",
            "SOL1",
            "SOL2",
            "BUL",
            "BUL1",
            "BUL11",
            "HUN0",
            "HUN1",
            "HUN2",
            "V24",
            "V32",
            "V48",
            "SIL0",
            "SIL1",
            "SIL2",
            "OHC",
            "涡轮",
            "喷气",
            "V48金刚式",
            "V66",
            "V100",
            "WEN",
            "HOR",
            "CAR",
            "TAN",
            "BAO",
            "HU",
            "RLA",
            "KHU",
            "毛巾",
            "面具",
            "口罩",
            "军号",
            "兴奋剂",
            "灭火器",
            "烟雾",
            "消火栓",
            "榴弹",
            "穿甲弹",
            "手雷",
            "导弹",
            "火瓶",
            "酸瓶",
            "石子",
            "钱包",
            "参丸",
            "党参",
            "人参",
            "灵丹",
            "喷雾剂",
            "地图",
            "空",
            "修理箱",
            "再生丸",
            "古币",
            "探雷器",
            "探测仪",
            "醉药",
            "钥匙",
            "扳手",
            "象牙",
            "光镜",
            "宝石镜",
            "太阳镜",
            "眼镜",
            "戒指",
            "纹身",
            "金棒",
            "游戏机",
            "女内衣",
            "男内衣",
            "解药",
            "药液",
            "银棒",
            "铜棒",
            "笔记",
            "日记",
            "密码本",
            "花板",
            "传真,",
            "迷彩条,",
            "PAG40,",
            "PAG80,",
            "PAGL,",
            "PAGLL,",
            "药箱,",
            "石蜡,",
            "空调,",
            "暖风机,",
            "冷风机,",
            "气扇,",
            "雷达,",
            "护屏,",
            "消活栓,",
            "卡通兔,",
            "撞击板,",
            "鸟类,",
            "铅竹"});
            this.comboBox29.Location = new System.Drawing.Point(53, 150);
            this.comboBox29.Name = "comboBox29";
            this.comboBox29.Size = new System.Drawing.Size(89, 20);
            this.comboBox29.TabIndex = 30;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(6, 153);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(41, 12);
            this.label38.TabIndex = 29;
            this.label38.Text = "装备五";
            // 
            // comboBox30
            // 
            this.comboBox30.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox30.FormattingEnabled = true;
            this.comboBox30.Items.AddRange(new object[] {
            "空",
            "皮帽",
            "布帽",
            "铁盔",
            "钢盔",
            "银盔",
            "金冠",
            "草帽",
            "头巾",
            "布衣",
            "皮衣",
            "披风",
            "铁衣",
            "铜衣",
            "钢衣",
            "银衣",
            "金衣",
            "草鞋",
            "布鞋",
            "皮鞋",
            "皮靴",
            "铁靴",
            "钢靴",
            "金靴",
            "背心",
            "皮甲",
            "金甲",
            "钢甲",
            "铁甲",
            "布手套",
            "皮手套",
            "铁爪",
            "铜爪",
            "钢爪",
            "金爪",
            "激光炮(1)",
            "激光炮(2)",
            "激光炮(3)",
            "激光炮(4)",
            "激光炮(5)",
            "激光炮(6)",
            "弹攻",
            "弩",
            "短枪",
            "战斧",
            "火枪",
            "回旋镖",
            "钢刀",
            "长枪",
            "机枪",
            "弹筒枪",
            "来福枪",
            "排炮",
            "军刀",
            "声纳枪",
            "火焰炮",
            "中子炮",
            "弹筒",
            "音波枪",
            "宝刀",
            "火箭炮",
            "穿甲炮",
            "飞龙火",
            "迫击炮",
            "首",
            "45炮",
            "55炮",
            "75炮",
            "80高炮",
            "95炮",
            "105加农炮",
            "115T型炮",
            "125加农炮",
            "125T型炮",
            "135加农炮",
            "140高炮",
            "155加农炮",
            "160滑膛炮",
            "165T型炮",
            "175加农炮",
            "195加农炮",
            "165钢炮",
            "180高炮",
            "205加农炮",
            "220炮",
            "ATM导弹",
            "喷火",
            "弹炮",
            "LI旋炮",
            "电光",
            "汽弹",
            "拉卡",
            "福特",
            "火狼",
            "台风",
            "雷电",
            "巨炮",
            "火神",
            "气旋",
            "截击",
            "托卢",
            "07机关炮",
            "09机关炮",
            "格林炮",
            "11机关炮",
            "09火炮",
            "11火炮",
            "15机关炮",
            "激光",
            "雷神",
            "18机关炮",
            "闪电",
            "20火炮",
            "25机关炮",
            "火龙",
            "风暴",
            "波坦",
            "HAL9000",
            "尼克",
            "艾米",
            "SOLOMON2",
            "MOT1",
            "MOT2",
            "MOT3",
            "SOLO",
            "SOL1",
            "SOL2",
            "BUL",
            "BUL1",
            "BUL11",
            "HUN0",
            "HUN1",
            "HUN2",
            "V24",
            "V32",
            "V48",
            "SIL0",
            "SIL1",
            "SIL2",
            "OHC",
            "涡轮",
            "喷气",
            "V48金刚式",
            "V66",
            "V100",
            "WEN",
            "HOR",
            "CAR",
            "TAN",
            "BAO",
            "HU",
            "RLA",
            "KHU",
            "毛巾",
            "面具",
            "口罩",
            "军号",
            "兴奋剂",
            "灭火器",
            "烟雾",
            "消火栓",
            "榴弹",
            "穿甲弹",
            "手雷",
            "导弹",
            "火瓶",
            "酸瓶",
            "石子",
            "钱包",
            "参丸",
            "党参",
            "人参",
            "灵丹",
            "喷雾剂",
            "地图",
            "空",
            "修理箱",
            "再生丸",
            "古币",
            "探雷器",
            "探测仪",
            "醉药",
            "钥匙",
            "扳手",
            "象牙",
            "光镜",
            "宝石镜",
            "太阳镜",
            "眼镜",
            "戒指",
            "纹身",
            "金棒",
            "游戏机",
            "女内衣",
            "男内衣",
            "解药",
            "药液",
            "银棒",
            "铜棒",
            "笔记",
            "日记",
            "密码本",
            "花板",
            "传真,",
            "迷彩条,",
            "PAG40,",
            "PAG80,",
            "PAGL,",
            "PAGLL,",
            "药箱,",
            "石蜡,",
            "空调,",
            "暖风机,",
            "冷风机,",
            "气扇,",
            "雷达,",
            "护屏,",
            "消活栓,",
            "卡通兔,",
            "撞击板,",
            "鸟类,",
            "铅竹"});
            this.comboBox30.Location = new System.Drawing.Point(215, 126);
            this.comboBox30.Name = "comboBox30";
            this.comboBox30.Size = new System.Drawing.Size(89, 20);
            this.comboBox30.TabIndex = 28;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(168, 129);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(41, 12);
            this.label39.TabIndex = 27;
            this.label39.Text = "装备四";
            // 
            // comboBox31
            // 
            this.comboBox31.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox31.FormattingEnabled = true;
            this.comboBox31.Items.AddRange(new object[] {
            "空",
            "皮帽",
            "布帽",
            "铁盔",
            "钢盔",
            "银盔",
            "金冠",
            "草帽",
            "头巾",
            "布衣",
            "皮衣",
            "披风",
            "铁衣",
            "铜衣",
            "钢衣",
            "银衣",
            "金衣",
            "草鞋",
            "布鞋",
            "皮鞋",
            "皮靴",
            "铁靴",
            "钢靴",
            "金靴",
            "背心",
            "皮甲",
            "金甲",
            "钢甲",
            "铁甲",
            "布手套",
            "皮手套",
            "铁爪",
            "铜爪",
            "钢爪",
            "金爪",
            "激光炮(1)",
            "激光炮(2)",
            "激光炮(3)",
            "激光炮(4)",
            "激光炮(5)",
            "激光炮(6)",
            "弹攻",
            "弩",
            "短枪",
            "战斧",
            "火枪",
            "回旋镖",
            "钢刀",
            "长枪",
            "机枪",
            "弹筒枪",
            "来福枪",
            "排炮",
            "军刀",
            "声纳枪",
            "火焰炮",
            "中子炮",
            "弹筒",
            "音波枪",
            "宝刀",
            "火箭炮",
            "穿甲炮",
            "飞龙火",
            "迫击炮",
            "首",
            "45炮",
            "55炮",
            "75炮",
            "80高炮",
            "95炮",
            "105加农炮",
            "115T型炮",
            "125加农炮",
            "125T型炮",
            "135加农炮",
            "140高炮",
            "155加农炮",
            "160滑膛炮",
            "165T型炮",
            "175加农炮",
            "195加农炮",
            "165钢炮",
            "180高炮",
            "205加农炮",
            "220炮",
            "ATM导弹",
            "喷火",
            "弹炮",
            "LI旋炮",
            "电光",
            "汽弹",
            "拉卡",
            "福特",
            "火狼",
            "台风",
            "雷电",
            "巨炮",
            "火神",
            "气旋",
            "截击",
            "托卢",
            "07机关炮",
            "09机关炮",
            "格林炮",
            "11机关炮",
            "09火炮",
            "11火炮",
            "15机关炮",
            "激光",
            "雷神",
            "18机关炮",
            "闪电",
            "20火炮",
            "25机关炮",
            "火龙",
            "风暴",
            "波坦",
            "HAL9000",
            "尼克",
            "艾米",
            "SOLOMON2",
            "MOT1",
            "MOT2",
            "MOT3",
            "SOLO",
            "SOL1",
            "SOL2",
            "BUL",
            "BUL1",
            "BUL11",
            "HUN0",
            "HUN1",
            "HUN2",
            "V24",
            "V32",
            "V48",
            "SIL0",
            "SIL1",
            "SIL2",
            "OHC",
            "涡轮",
            "喷气",
            "V48金刚式",
            "V66",
            "V100",
            "WEN",
            "HOR",
            "CAR",
            "TAN",
            "BAO",
            "HU",
            "RLA",
            "KHU",
            "毛巾",
            "面具",
            "口罩",
            "军号",
            "兴奋剂",
            "灭火器",
            "烟雾",
            "消火栓",
            "榴弹",
            "穿甲弹",
            "手雷",
            "导弹",
            "火瓶",
            "酸瓶",
            "石子",
            "钱包",
            "参丸",
            "党参",
            "人参",
            "灵丹",
            "喷雾剂",
            "地图",
            "空",
            "修理箱",
            "再生丸",
            "古币",
            "探雷器",
            "探测仪",
            "醉药",
            "钥匙",
            "扳手",
            "象牙",
            "光镜",
            "宝石镜",
            "太阳镜",
            "眼镜",
            "戒指",
            "纹身",
            "金棒",
            "游戏机",
            "女内衣",
            "男内衣",
            "解药",
            "药液",
            "银棒",
            "铜棒",
            "笔记",
            "日记",
            "密码本",
            "花板",
            "传真,",
            "迷彩条,",
            "PAG40,",
            "PAG80,",
            "PAGL,",
            "PAGLL,",
            "药箱,",
            "石蜡,",
            "空调,",
            "暖风机,",
            "冷风机,",
            "气扇,",
            "雷达,",
            "护屏,",
            "消活栓,",
            "卡通兔,",
            "撞击板,",
            "鸟类,",
            "铅竹"});
            this.comboBox31.Location = new System.Drawing.Point(53, 126);
            this.comboBox31.Name = "comboBox31";
            this.comboBox31.Size = new System.Drawing.Size(89, 20);
            this.comboBox31.TabIndex = 26;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(6, 129);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(41, 12);
            this.label40.TabIndex = 25;
            this.label40.Text = "装备三";
            // 
            // comboBox32
            // 
            this.comboBox32.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox32.FormattingEnabled = true;
            this.comboBox32.Items.AddRange(new object[] {
            "空",
            "皮帽",
            "布帽",
            "铁盔",
            "钢盔",
            "银盔",
            "金冠",
            "草帽",
            "头巾",
            "布衣",
            "皮衣",
            "披风",
            "铁衣",
            "铜衣",
            "钢衣",
            "银衣",
            "金衣",
            "草鞋",
            "布鞋",
            "皮鞋",
            "皮靴",
            "铁靴",
            "钢靴",
            "金靴",
            "背心",
            "皮甲",
            "金甲",
            "钢甲",
            "铁甲",
            "布手套",
            "皮手套",
            "铁爪",
            "铜爪",
            "钢爪",
            "金爪",
            "激光炮(1)",
            "激光炮(2)",
            "激光炮(3)",
            "激光炮(4)",
            "激光炮(5)",
            "激光炮(6)",
            "弹攻",
            "弩",
            "短枪",
            "战斧",
            "火枪",
            "回旋镖",
            "钢刀",
            "长枪",
            "机枪",
            "弹筒枪",
            "来福枪",
            "排炮",
            "军刀",
            "声纳枪",
            "火焰炮",
            "中子炮",
            "弹筒",
            "音波枪",
            "宝刀",
            "火箭炮",
            "穿甲炮",
            "飞龙火",
            "迫击炮",
            "首",
            "45炮",
            "55炮",
            "75炮",
            "80高炮",
            "95炮",
            "105加农炮",
            "115T型炮",
            "125加农炮",
            "125T型炮",
            "135加农炮",
            "140高炮",
            "155加农炮",
            "160滑膛炮",
            "165T型炮",
            "175加农炮",
            "195加农炮",
            "165钢炮",
            "180高炮",
            "205加农炮",
            "220炮",
            "ATM导弹",
            "喷火",
            "弹炮",
            "LI旋炮",
            "电光",
            "汽弹",
            "拉卡",
            "福特",
            "火狼",
            "台风",
            "雷电",
            "巨炮",
            "火神",
            "气旋",
            "截击",
            "托卢",
            "07机关炮",
            "09机关炮",
            "格林炮",
            "11机关炮",
            "09火炮",
            "11火炮",
            "15机关炮",
            "激光",
            "雷神",
            "18机关炮",
            "闪电",
            "20火炮",
            "25机关炮",
            "火龙",
            "风暴",
            "波坦",
            "HAL9000",
            "尼克",
            "艾米",
            "SOLOMON2",
            "MOT1",
            "MOT2",
            "MOT3",
            "SOLO",
            "SOL1",
            "SOL2",
            "BUL",
            "BUL1",
            "BUL11",
            "HUN0",
            "HUN1",
            "HUN2",
            "V24",
            "V32",
            "V48",
            "SIL0",
            "SIL1",
            "SIL2",
            "OHC",
            "涡轮",
            "喷气",
            "V48金刚式",
            "V66",
            "V100",
            "WEN",
            "HOR",
            "CAR",
            "TAN",
            "BAO",
            "HU",
            "RLA",
            "KHU",
            "毛巾",
            "面具",
            "口罩",
            "军号",
            "兴奋剂",
            "灭火器",
            "烟雾",
            "消火栓",
            "榴弹",
            "穿甲弹",
            "手雷",
            "导弹",
            "火瓶",
            "酸瓶",
            "石子",
            "钱包",
            "参丸",
            "党参",
            "人参",
            "灵丹",
            "喷雾剂",
            "地图",
            "空",
            "修理箱",
            "再生丸",
            "古币",
            "探雷器",
            "探测仪",
            "醉药",
            "钥匙",
            "扳手",
            "象牙",
            "光镜",
            "宝石镜",
            "太阳镜",
            "眼镜",
            "戒指",
            "纹身",
            "金棒",
            "游戏机",
            "女内衣",
            "男内衣",
            "解药",
            "药液",
            "银棒",
            "铜棒",
            "笔记",
            "日记",
            "密码本",
            "花板",
            "传真,",
            "迷彩条,",
            "PAG40,",
            "PAG80,",
            "PAGL,",
            "PAGLL,",
            "药箱,",
            "石蜡,",
            "空调,",
            "暖风机,",
            "冷风机,",
            "气扇,",
            "雷达,",
            "护屏,",
            "消活栓,",
            "卡通兔,",
            "撞击板,",
            "鸟类,",
            "铅竹"});
            this.comboBox32.Location = new System.Drawing.Point(215, 101);
            this.comboBox32.Name = "comboBox32";
            this.comboBox32.Size = new System.Drawing.Size(89, 20);
            this.comboBox32.TabIndex = 24;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(168, 104);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(41, 12);
            this.label41.TabIndex = 23;
            this.label41.Text = "装备二";
            // 
            // comboBox33
            // 
            this.comboBox33.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox33.FormattingEnabled = true;
            this.comboBox33.Items.AddRange(new object[] {
            "空",
            "皮帽",
            "布帽",
            "铁盔",
            "钢盔",
            "银盔",
            "金冠",
            "草帽",
            "头巾",
            "布衣",
            "皮衣",
            "披风",
            "铁衣",
            "铜衣",
            "钢衣",
            "银衣",
            "金衣",
            "草鞋",
            "布鞋",
            "皮鞋",
            "皮靴",
            "铁靴",
            "钢靴",
            "金靴",
            "背心",
            "皮甲",
            "金甲",
            "钢甲",
            "铁甲",
            "布手套",
            "皮手套",
            "铁爪",
            "铜爪",
            "钢爪",
            "金爪",
            "激光炮(1)",
            "激光炮(2)",
            "激光炮(3)",
            "激光炮(4)",
            "激光炮(5)",
            "激光炮(6)",
            "弹攻",
            "弩",
            "短枪",
            "战斧",
            "火枪",
            "回旋镖",
            "钢刀",
            "长枪",
            "机枪",
            "弹筒枪",
            "来福枪",
            "排炮",
            "军刀",
            "声纳枪",
            "火焰炮",
            "中子炮",
            "弹筒",
            "音波枪",
            "宝刀",
            "火箭炮",
            "穿甲炮",
            "飞龙火",
            "迫击炮",
            "首",
            "45炮",
            "55炮",
            "75炮",
            "80高炮",
            "95炮",
            "105加农炮",
            "115T型炮",
            "125加农炮",
            "125T型炮",
            "135加农炮",
            "140高炮",
            "155加农炮",
            "160滑膛炮",
            "165T型炮",
            "175加农炮",
            "195加农炮",
            "165钢炮",
            "180高炮",
            "205加农炮",
            "220炮",
            "ATM导弹",
            "喷火",
            "弹炮",
            "LI旋炮",
            "电光",
            "汽弹",
            "拉卡",
            "福特",
            "火狼",
            "台风",
            "雷电",
            "巨炮",
            "火神",
            "气旋",
            "截击",
            "托卢",
            "07机关炮",
            "09机关炮",
            "格林炮",
            "11机关炮",
            "09火炮",
            "11火炮",
            "15机关炮",
            "激光",
            "雷神",
            "18机关炮",
            "闪电",
            "20火炮",
            "25机关炮",
            "火龙",
            "风暴",
            "波坦",
            "HAL9000",
            "尼克",
            "艾米",
            "SOLOMON2",
            "MOT1",
            "MOT2",
            "MOT3",
            "SOLO",
            "SOL1",
            "SOL2",
            "BUL",
            "BUL1",
            "BUL11",
            "HUN0",
            "HUN1",
            "HUN2",
            "V24",
            "V32",
            "V48",
            "SIL0",
            "SIL1",
            "SIL2",
            "OHC",
            "涡轮",
            "喷气",
            "V48金刚式",
            "V66",
            "V100",
            "WEN",
            "HOR",
            "CAR",
            "TAN",
            "BAO",
            "HU",
            "RLA",
            "KHU",
            "毛巾",
            "面具",
            "口罩",
            "军号",
            "兴奋剂",
            "灭火器",
            "烟雾",
            "消火栓",
            "榴弹",
            "穿甲弹",
            "手雷",
            "导弹",
            "火瓶",
            "酸瓶",
            "石子",
            "钱包",
            "参丸",
            "党参",
            "人参",
            "灵丹",
            "喷雾剂",
            "地图",
            "空",
            "修理箱",
            "再生丸",
            "古币",
            "探雷器",
            "探测仪",
            "醉药",
            "钥匙",
            "扳手",
            "象牙",
            "光镜",
            "宝石镜",
            "太阳镜",
            "眼镜",
            "戒指",
            "纹身",
            "金棒",
            "游戏机",
            "女内衣",
            "男内衣",
            "解药",
            "药液",
            "银棒",
            "铜棒",
            "笔记",
            "日记",
            "密码本",
            "花板",
            "传真,",
            "迷彩条,",
            "PAG40,",
            "PAG80,",
            "PAGL,",
            "PAGLL,",
            "药箱,",
            "石蜡,",
            "空调,",
            "暖风机,",
            "冷风机,",
            "气扇,",
            "雷达,",
            "护屏,",
            "消活栓,",
            "卡通兔,",
            "撞击板,",
            "鸟类,",
            "铅竹"});
            this.comboBox33.Location = new System.Drawing.Point(53, 101);
            this.comboBox33.Name = "comboBox33";
            this.comboBox33.Size = new System.Drawing.Size(89, 20);
            this.comboBox33.TabIndex = 22;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(6, 104);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(41, 12);
            this.label42.TabIndex = 21;
            this.label42.Text = "装备一";
            // 
            // numericUpDown20
            // 
            this.numericUpDown20.Location = new System.Drawing.Point(57, 44);
            this.numericUpDown20.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDown20.Name = "numericUpDown20";
            this.numericUpDown20.Size = new System.Drawing.Size(50, 21);
            this.numericUpDown20.TabIndex = 6;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(6, 46);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(53, 12);
            this.label52.TabIndex = 1;
            this.label52.Text = "底盘防御";
            // 
            // comboBox34
            // 
            this.comboBox34.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox34.FormattingEnabled = true;
            this.comboBox34.Items.AddRange(new object[] {
            "WEN-轻型坦克",
            "HOR-吉普车",
            "CAR-救护车",
            "TAN",
            "BAO",
            "HU",
            "RLA-红狼坦克",
            "KHU-重型坦克"});
            this.comboBox34.Location = new System.Drawing.Point(6, 20);
            this.comboBox34.Name = "comboBox34";
            this.comboBox34.Size = new System.Drawing.Size(121, 20);
            this.comboBox34.TabIndex = 0;
            this.comboBox34.SelectedIndexChanged += new System.EventHandler(this.comboBox34_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDown14);
            this.groupBox1.Controls.Add(this.label47);
            this.groupBox1.Controls.Add(this.numericUpDown13);
            this.groupBox1.Controls.Add(this.label46);
            this.groupBox1.Controls.Add(this.numericUpDown12);
            this.groupBox1.Controls.Add(this.label45);
            this.groupBox1.Controls.Add(this.comboBox10);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.comboBox11);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.comboBox12);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.comboBox13);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.comboBox14);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.comboBox15);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.comboBox16);
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Controls.Add(this.comboBox17);
            this.groupBox1.Controls.Add(this.label26);
            this.groupBox1.Controls.Add(this.comboBox9);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.comboBox8);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.comboBox7);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.comboBox6);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.comboBox5);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.comboBox4);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.numericUpDown10);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.numericUpDown9);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.numericUpDown5);
            this.groupBox1.Controls.Add(this.numericUpDown6);
            this.groupBox1.Controls.Add(this.numericUpDown7);
            this.groupBox1.Controls.Add(this.numericUpDown8);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.numericUpDown4);
            this.groupBox1.Controls.Add(this.numericUpDown3);
            this.groupBox1.Controls.Add(this.numericUpDown2);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(34, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 315);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "人物初始属性";
            // 
            // numericUpDown14
            // 
            this.numericUpDown14.Location = new System.Drawing.Point(266, 18);
            this.numericUpDown14.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numericUpDown14.Name = "numericUpDown14";
            this.numericUpDown14.Size = new System.Drawing.Size(73, 21);
            this.numericUpDown14.TabIndex = 59;
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(219, 20);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(29, 12);
            this.label47.TabIndex = 58;
            this.label47.Text = "金钱";
            // 
            // numericUpDown13
            // 
            this.numericUpDown13.Location = new System.Drawing.Point(154, 44);
            this.numericUpDown13.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numericUpDown13.Name = "numericUpDown13";
            this.numericUpDown13.Size = new System.Drawing.Size(59, 21);
            this.numericUpDown13.TabIndex = 57;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(119, 46);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(17, 12);
            this.label46.TabIndex = 56;
            this.label46.Text = "HP";
            // 
            // numericUpDown12
            // 
            this.numericUpDown12.Location = new System.Drawing.Point(266, 44);
            this.numericUpDown12.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numericUpDown12.Name = "numericUpDown12";
            this.numericUpDown12.Size = new System.Drawing.Size(73, 21);
            this.numericUpDown12.TabIndex = 55;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(219, 46);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(41, 12);
            this.label45.TabIndex = 54;
            this.label45.Text = "经验值";
            // 
            // comboBox10
            // 
            this.comboBox10.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox10.FormattingEnabled = true;
            this.comboBox10.Items.AddRange(new object[] {
            "空",
            "皮帽",
            "布帽",
            "铁盔",
            "钢盔",
            "银盔",
            "金冠",
            "草帽",
            "头巾",
            "布衣",
            "皮衣",
            "披风",
            "铁衣",
            "铜衣",
            "钢衣",
            "银衣",
            "金衣",
            "草鞋",
            "布鞋",
            "皮鞋",
            "皮靴",
            "铁靴",
            "钢靴",
            "金靴",
            "背心",
            "皮甲",
            "金甲",
            "钢甲",
            "铁甲",
            "布手套",
            "皮手套",
            "铁爪",
            "铜爪",
            "钢爪",
            "金爪",
            "激光炮(1)",
            "激光炮(2)",
            "激光炮(3)",
            "激光炮(4)",
            "激光炮(5)",
            "激光炮(6)",
            "弹攻",
            "弩",
            "短枪",
            "战斧",
            "火枪",
            "回旋镖",
            "钢刀",
            "长枪",
            "机枪",
            "弹筒枪",
            "来福枪",
            "排炮",
            "军刀",
            "声纳枪",
            "火焰炮",
            "中子炮",
            "弹筒",
            "音波枪",
            "宝刀",
            "火箭炮",
            "穿甲炮",
            "飞龙火",
            "迫击炮",
            "首",
            "45炮",
            "55炮",
            "75炮",
            "80高炮",
            "95炮",
            "105加农炮",
            "115T型炮",
            "125加农炮",
            "125T型炮",
            "135加农炮",
            "140高炮",
            "155加农炮",
            "160滑膛炮",
            "165T型炮",
            "175加农炮",
            "195加农炮",
            "165钢炮",
            "180高炮",
            "205加农炮",
            "220炮",
            "ATM导弹",
            "喷火",
            "弹炮",
            "LI旋炮",
            "电光",
            "汽弹",
            "拉卡",
            "福特",
            "火狼",
            "台风",
            "雷电",
            "巨炮",
            "火神",
            "气旋",
            "截击",
            "托卢",
            "07机关炮",
            "09机关炮",
            "格林炮",
            "11机关炮",
            "09火炮",
            "11火炮",
            "15机关炮",
            "激光",
            "雷神",
            "18机关炮",
            "闪电",
            "20火炮",
            "25机关炮",
            "火龙",
            "风暴",
            "波坦",
            "HAL9000",
            "尼克",
            "艾米",
            "SOLOMON2",
            "MOT1",
            "MOT2",
            "MOT3",
            "SOLO",
            "SOL1",
            "SOL2",
            "BUL",
            "BUL1",
            "BUL11",
            "HUN0",
            "HUN1",
            "HUN2",
            "V24",
            "V32",
            "V48",
            "SIL0",
            "SIL1",
            "SIL2",
            "OHC",
            "涡轮",
            "喷气",
            "V48金刚式",
            "V66",
            "V100",
            "WEN",
            "HOR",
            "CAR",
            "TAN",
            "BAO",
            "HU",
            "RLA",
            "KHU",
            "毛巾",
            "面具",
            "口罩",
            "军号",
            "兴奋剂",
            "灭火器",
            "烟雾",
            "消火栓",
            "榴弹",
            "穿甲弹",
            "手雷",
            "导弹",
            "火瓶",
            "酸瓶",
            "石子",
            "钱包",
            "参丸",
            "党参",
            "人参",
            "灵丹",
            "喷雾剂",
            "地图",
            "空",
            "修理箱",
            "再生丸",
            "古币",
            "探雷器",
            "探测仪",
            "醉药",
            "钥匙",
            "扳手",
            "象牙",
            "光镜",
            "宝石镜",
            "太阳镜",
            "眼镜",
            "戒指",
            "纹身",
            "金棒",
            "游戏机",
            "女内衣",
            "男内衣",
            "解药",
            "药液",
            "银棒",
            "铜棒",
            "笔记",
            "日记",
            "密码本",
            "花板",
            "传真,",
            "迷彩条,",
            "PAG40,",
            "PAG80,",
            "PAGL,",
            "PAGLL,",
            "药箱,",
            "石蜡,",
            "空调,",
            "暖风机,",
            "冷风机,",
            "气扇,",
            "雷达,",
            "护屏,",
            "消活栓,",
            "卡通兔,",
            "撞击板,",
            "鸟类,",
            "铅竹"});
            this.comboBox10.Location = new System.Drawing.Point(266, 254);
            this.comboBox10.Name = "comboBox10";
            this.comboBox10.Size = new System.Drawing.Size(73, 20);
            this.comboBox10.TabIndex = 52;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(219, 257);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(41, 12);
            this.label19.TabIndex = 51;
            this.label19.Text = "工具八";
            // 
            // comboBox11
            // 
            this.comboBox11.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox11.FormattingEnabled = true;
            this.comboBox11.Items.AddRange(new object[] {
            "空",
            "皮帽",
            "布帽",
            "铁盔",
            "钢盔",
            "银盔",
            "金冠",
            "草帽",
            "头巾",
            "布衣",
            "皮衣",
            "披风",
            "铁衣",
            "铜衣",
            "钢衣",
            "银衣",
            "金衣",
            "草鞋",
            "布鞋",
            "皮鞋",
            "皮靴",
            "铁靴",
            "钢靴",
            "金靴",
            "背心",
            "皮甲",
            "金甲",
            "钢甲",
            "铁甲",
            "布手套",
            "皮手套",
            "铁爪",
            "铜爪",
            "钢爪",
            "金爪",
            "激光炮(1)",
            "激光炮(2)",
            "激光炮(3)",
            "激光炮(4)",
            "激光炮(5)",
            "激光炮(6)",
            "弹攻",
            "弩",
            "短枪",
            "战斧",
            "火枪",
            "回旋镖",
            "钢刀",
            "长枪",
            "机枪",
            "弹筒枪",
            "来福枪",
            "排炮",
            "军刀",
            "声纳枪",
            "火焰炮",
            "中子炮",
            "弹筒",
            "音波枪",
            "宝刀",
            "火箭炮",
            "穿甲炮",
            "飞龙火",
            "迫击炮",
            "首",
            "45炮",
            "55炮",
            "75炮",
            "80高炮",
            "95炮",
            "105加农炮",
            "115T型炮",
            "125加农炮",
            "125T型炮",
            "135加农炮",
            "140高炮",
            "155加农炮",
            "160滑膛炮",
            "165T型炮",
            "175加农炮",
            "195加农炮",
            "165钢炮",
            "180高炮",
            "205加农炮",
            "220炮",
            "ATM导弹",
            "喷火",
            "弹炮",
            "LI旋炮",
            "电光",
            "汽弹",
            "拉卡",
            "福特",
            "火狼",
            "台风",
            "雷电",
            "巨炮",
            "火神",
            "气旋",
            "截击",
            "托卢",
            "07机关炮",
            "09机关炮",
            "格林炮",
            "11机关炮",
            "09火炮",
            "11火炮",
            "15机关炮",
            "激光",
            "雷神",
            "18机关炮",
            "闪电",
            "20火炮",
            "25机关炮",
            "火龙",
            "风暴",
            "波坦",
            "HAL9000",
            "尼克",
            "艾米",
            "SOLOMON2",
            "MOT1",
            "MOT2",
            "MOT3",
            "SOLO",
            "SOL1",
            "SOL2",
            "BUL",
            "BUL1",
            "BUL11",
            "HUN0",
            "HUN1",
            "HUN2",
            "V24",
            "V32",
            "V48",
            "SIL0",
            "SIL1",
            "SIL2",
            "OHC",
            "涡轮",
            "喷气",
            "V48金刚式",
            "V66",
            "V100",
            "WEN",
            "HOR",
            "CAR",
            "TAN",
            "BAO",
            "HU",
            "RLA",
            "KHU",
            "毛巾",
            "面具",
            "口罩",
            "军号",
            "兴奋剂",
            "灭火器",
            "烟雾",
            "消火栓",
            "榴弹",
            "穿甲弹",
            "手雷",
            "导弹",
            "火瓶",
            "酸瓶",
            "石子",
            "钱包",
            "参丸",
            "党参",
            "人参",
            "灵丹",
            "喷雾剂",
            "地图",
            "空",
            "修理箱",
            "再生丸",
            "古币",
            "探雷器",
            "探测仪",
            "醉药",
            "钥匙",
            "扳手",
            "象牙",
            "光镜",
            "宝石镜",
            "太阳镜",
            "眼镜",
            "戒指",
            "纹身",
            "金棒",
            "游戏机",
            "女内衣",
            "男内衣",
            "解药",
            "药液",
            "银棒",
            "铜棒",
            "笔记",
            "日记",
            "密码本",
            "花板",
            "传真,",
            "迷彩条,",
            "PAG40,",
            "PAG80,",
            "PAGL,",
            "PAGLL,",
            "药箱,",
            "石蜡,",
            "空调,",
            "暖风机,",
            "冷风机,",
            "气扇,",
            "雷达,",
            "护屏,",
            "消活栓,",
            "卡通兔,",
            "撞击板,",
            "鸟类,",
            "铅竹"});
            this.comboBox11.Location = new System.Drawing.Point(154, 254);
            this.comboBox11.Name = "comboBox11";
            this.comboBox11.Size = new System.Drawing.Size(59, 20);
            this.comboBox11.TabIndex = 50;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(107, 257);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(41, 12);
            this.label20.TabIndex = 49;
            this.label20.Text = "工具七";
            // 
            // comboBox12
            // 
            this.comboBox12.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox12.FormattingEnabled = true;
            this.comboBox12.Items.AddRange(new object[] {
            "空",
            "皮帽",
            "布帽",
            "铁盔",
            "钢盔",
            "银盔",
            "金冠",
            "草帽",
            "头巾",
            "布衣",
            "皮衣",
            "披风",
            "铁衣",
            "铜衣",
            "钢衣",
            "银衣",
            "金衣",
            "草鞋",
            "布鞋",
            "皮鞋",
            "皮靴",
            "铁靴",
            "钢靴",
            "金靴",
            "背心",
            "皮甲",
            "金甲",
            "钢甲",
            "铁甲",
            "布手套",
            "皮手套",
            "铁爪",
            "铜爪",
            "钢爪",
            "金爪",
            "激光炮(1)",
            "激光炮(2)",
            "激光炮(3)",
            "激光炮(4)",
            "激光炮(5)",
            "激光炮(6)",
            "弹攻",
            "弩",
            "短枪",
            "战斧",
            "火枪",
            "回旋镖",
            "钢刀",
            "长枪",
            "机枪",
            "弹筒枪",
            "来福枪",
            "排炮",
            "军刀",
            "声纳枪",
            "火焰炮",
            "中子炮",
            "弹筒",
            "音波枪",
            "宝刀",
            "火箭炮",
            "穿甲炮",
            "飞龙火",
            "迫击炮",
            "首",
            "45炮",
            "55炮",
            "75炮",
            "80高炮",
            "95炮",
            "105加农炮",
            "115T型炮",
            "125加农炮",
            "125T型炮",
            "135加农炮",
            "140高炮",
            "155加农炮",
            "160滑膛炮",
            "165T型炮",
            "175加农炮",
            "195加农炮",
            "165钢炮",
            "180高炮",
            "205加农炮",
            "220炮",
            "ATM导弹",
            "喷火",
            "弹炮",
            "LI旋炮",
            "电光",
            "汽弹",
            "拉卡",
            "福特",
            "火狼",
            "台风",
            "雷电",
            "巨炮",
            "火神",
            "气旋",
            "截击",
            "托卢",
            "07机关炮",
            "09机关炮",
            "格林炮",
            "11机关炮",
            "09火炮",
            "11火炮",
            "15机关炮",
            "激光",
            "雷神",
            "18机关炮",
            "闪电",
            "20火炮",
            "25机关炮",
            "火龙",
            "风暴",
            "波坦",
            "HAL9000",
            "尼克",
            "艾米",
            "SOLOMON2",
            "MOT1",
            "MOT2",
            "MOT3",
            "SOLO",
            "SOL1",
            "SOL2",
            "BUL",
            "BUL1",
            "BUL11",
            "HUN0",
            "HUN1",
            "HUN2",
            "V24",
            "V32",
            "V48",
            "SIL0",
            "SIL1",
            "SIL2",
            "OHC",
            "涡轮",
            "喷气",
            "V48金刚式",
            "V66",
            "V100",
            "WEN",
            "HOR",
            "CAR",
            "TAN",
            "BAO",
            "HU",
            "RLA",
            "KHU",
            "毛巾",
            "面具",
            "口罩",
            "军号",
            "兴奋剂",
            "灭火器",
            "烟雾",
            "消火栓",
            "榴弹",
            "穿甲弹",
            "手雷",
            "导弹",
            "火瓶",
            "酸瓶",
            "石子",
            "钱包",
            "参丸",
            "党参",
            "人参",
            "灵丹",
            "喷雾剂",
            "地图",
            "空",
            "修理箱",
            "再生丸",
            "古币",
            "探雷器",
            "探测仪",
            "醉药",
            "钥匙",
            "扳手",
            "象牙",
            "光镜",
            "宝石镜",
            "太阳镜",
            "眼镜",
            "戒指",
            "纹身",
            "金棒",
            "游戏机",
            "女内衣",
            "男内衣",
            "解药",
            "药液",
            "银棒",
            "铜棒",
            "笔记",
            "日记",
            "密码本",
            "花板",
            "传真,",
            "迷彩条,",
            "PAG40,",
            "PAG80,",
            "PAGL,",
            "PAGLL,",
            "药箱,",
            "石蜡,",
            "空调,",
            "暖风机,",
            "冷风机,",
            "气扇,",
            "雷达,",
            "护屏,",
            "消活栓,",
            "卡通兔,",
            "撞击板,",
            "鸟类,",
            "铅竹"});
            this.comboBox12.Location = new System.Drawing.Point(266, 227);
            this.comboBox12.Name = "comboBox12";
            this.comboBox12.Size = new System.Drawing.Size(73, 20);
            this.comboBox12.TabIndex = 48;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(219, 230);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(41, 12);
            this.label21.TabIndex = 47;
            this.label21.Text = "工具六";
            // 
            // comboBox13
            // 
            this.comboBox13.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox13.FormattingEnabled = true;
            this.comboBox13.Items.AddRange(new object[] {
            "空",
            "皮帽",
            "布帽",
            "铁盔",
            "钢盔",
            "银盔",
            "金冠",
            "草帽",
            "头巾",
            "布衣",
            "皮衣",
            "披风",
            "铁衣",
            "铜衣",
            "钢衣",
            "银衣",
            "金衣",
            "草鞋",
            "布鞋",
            "皮鞋",
            "皮靴",
            "铁靴",
            "钢靴",
            "金靴",
            "背心",
            "皮甲",
            "金甲",
            "钢甲",
            "铁甲",
            "布手套",
            "皮手套",
            "铁爪",
            "铜爪",
            "钢爪",
            "金爪",
            "激光炮(1)",
            "激光炮(2)",
            "激光炮(3)",
            "激光炮(4)",
            "激光炮(5)",
            "激光炮(6)",
            "弹攻",
            "弩",
            "短枪",
            "战斧",
            "火枪",
            "回旋镖",
            "钢刀",
            "长枪",
            "机枪",
            "弹筒枪",
            "来福枪",
            "排炮",
            "军刀",
            "声纳枪",
            "火焰炮",
            "中子炮",
            "弹筒",
            "音波枪",
            "宝刀",
            "火箭炮",
            "穿甲炮",
            "飞龙火",
            "迫击炮",
            "首",
            "45炮",
            "55炮",
            "75炮",
            "80高炮",
            "95炮",
            "105加农炮",
            "115T型炮",
            "125加农炮",
            "125T型炮",
            "135加农炮",
            "140高炮",
            "155加农炮",
            "160滑膛炮",
            "165T型炮",
            "175加农炮",
            "195加农炮",
            "165钢炮",
            "180高炮",
            "205加农炮",
            "220炮",
            "ATM导弹",
            "喷火",
            "弹炮",
            "LI旋炮",
            "电光",
            "汽弹",
            "拉卡",
            "福特",
            "火狼",
            "台风",
            "雷电",
            "巨炮",
            "火神",
            "气旋",
            "截击",
            "托卢",
            "07机关炮",
            "09机关炮",
            "格林炮",
            "11机关炮",
            "09火炮",
            "11火炮",
            "15机关炮",
            "激光",
            "雷神",
            "18机关炮",
            "闪电",
            "20火炮",
            "25机关炮",
            "火龙",
            "风暴",
            "波坦",
            "HAL9000",
            "尼克",
            "艾米",
            "SOLOMON2",
            "MOT1",
            "MOT2",
            "MOT3",
            "SOLO",
            "SOL1",
            "SOL2",
            "BUL",
            "BUL1",
            "BUL11",
            "HUN0",
            "HUN1",
            "HUN2",
            "V24",
            "V32",
            "V48",
            "SIL0",
            "SIL1",
            "SIL2",
            "OHC",
            "涡轮",
            "喷气",
            "V48金刚式",
            "V66",
            "V100",
            "WEN",
            "HOR",
            "CAR",
            "TAN",
            "BAO",
            "HU",
            "RLA",
            "KHU",
            "毛巾",
            "面具",
            "口罩",
            "军号",
            "兴奋剂",
            "灭火器",
            "烟雾",
            "消火栓",
            "榴弹",
            "穿甲弹",
            "手雷",
            "导弹",
            "火瓶",
            "酸瓶",
            "石子",
            "钱包",
            "参丸",
            "党参",
            "人参",
            "灵丹",
            "喷雾剂",
            "地图",
            "空",
            "修理箱",
            "再生丸",
            "古币",
            "探雷器",
            "探测仪",
            "醉药",
            "钥匙",
            "扳手",
            "象牙",
            "光镜",
            "宝石镜",
            "太阳镜",
            "眼镜",
            "戒指",
            "纹身",
            "金棒",
            "游戏机",
            "女内衣",
            "男内衣",
            "解药",
            "药液",
            "银棒",
            "铜棒",
            "笔记",
            "日记",
            "密码本",
            "花板",
            "传真,",
            "迷彩条,",
            "PAG40,",
            "PAG80,",
            "PAGL,",
            "PAGLL,",
            "药箱,",
            "石蜡,",
            "空调,",
            "暖风机,",
            "冷风机,",
            "气扇,",
            "雷达,",
            "护屏,",
            "消活栓,",
            "卡通兔,",
            "撞击板,",
            "鸟类,",
            "铅竹"});
            this.comboBox13.Location = new System.Drawing.Point(154, 227);
            this.comboBox13.Name = "comboBox13";
            this.comboBox13.Size = new System.Drawing.Size(59, 20);
            this.comboBox13.TabIndex = 46;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(107, 230);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(41, 12);
            this.label22.TabIndex = 45;
            this.label22.Text = "工具五";
            // 
            // comboBox14
            // 
            this.comboBox14.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox14.FormattingEnabled = true;
            this.comboBox14.Items.AddRange(new object[] {
            "空",
            "皮帽",
            "布帽",
            "铁盔",
            "钢盔",
            "银盔",
            "金冠",
            "草帽",
            "头巾",
            "布衣",
            "皮衣",
            "披风",
            "铁衣",
            "铜衣",
            "钢衣",
            "银衣",
            "金衣",
            "草鞋",
            "布鞋",
            "皮鞋",
            "皮靴",
            "铁靴",
            "钢靴",
            "金靴",
            "背心",
            "皮甲",
            "金甲",
            "钢甲",
            "铁甲",
            "布手套",
            "皮手套",
            "铁爪",
            "铜爪",
            "钢爪",
            "金爪",
            "激光炮(1)",
            "激光炮(2)",
            "激光炮(3)",
            "激光炮(4)",
            "激光炮(5)",
            "激光炮(6)",
            "弹攻",
            "弩",
            "短枪",
            "战斧",
            "火枪",
            "回旋镖",
            "钢刀",
            "长枪",
            "机枪",
            "弹筒枪",
            "来福枪",
            "排炮",
            "军刀",
            "声纳枪",
            "火焰炮",
            "中子炮",
            "弹筒",
            "音波枪",
            "宝刀",
            "火箭炮",
            "穿甲炮",
            "飞龙火",
            "迫击炮",
            "首",
            "45炮",
            "55炮",
            "75炮",
            "80高炮",
            "95炮",
            "105加农炮",
            "115T型炮",
            "125加农炮",
            "125T型炮",
            "135加农炮",
            "140高炮",
            "155加农炮",
            "160滑膛炮",
            "165T型炮",
            "175加农炮",
            "195加农炮",
            "165钢炮",
            "180高炮",
            "205加农炮",
            "220炮",
            "ATM导弹",
            "喷火",
            "弹炮",
            "LI旋炮",
            "电光",
            "汽弹",
            "拉卡",
            "福特",
            "火狼",
            "台风",
            "雷电",
            "巨炮",
            "火神",
            "气旋",
            "截击",
            "托卢",
            "07机关炮",
            "09机关炮",
            "格林炮",
            "11机关炮",
            "09火炮",
            "11火炮",
            "15机关炮",
            "激光",
            "雷神",
            "18机关炮",
            "闪电",
            "20火炮",
            "25机关炮",
            "火龙",
            "风暴",
            "波坦",
            "HAL9000",
            "尼克",
            "艾米",
            "SOLOMON2",
            "MOT1",
            "MOT2",
            "MOT3",
            "SOLO",
            "SOL1",
            "SOL2",
            "BUL",
            "BUL1",
            "BUL11",
            "HUN0",
            "HUN1",
            "HUN2",
            "V24",
            "V32",
            "V48",
            "SIL0",
            "SIL1",
            "SIL2",
            "OHC",
            "涡轮",
            "喷气",
            "V48金刚式",
            "V66",
            "V100",
            "WEN",
            "HOR",
            "CAR",
            "TAN",
            "BAO",
            "HU",
            "RLA",
            "KHU",
            "毛巾",
            "面具",
            "口罩",
            "军号",
            "兴奋剂",
            "灭火器",
            "烟雾",
            "消火栓",
            "榴弹",
            "穿甲弹",
            "手雷",
            "导弹",
            "火瓶",
            "酸瓶",
            "石子",
            "钱包",
            "参丸",
            "党参",
            "人参",
            "灵丹",
            "喷雾剂",
            "地图",
            "空",
            "修理箱",
            "再生丸",
            "古币",
            "探雷器",
            "探测仪",
            "醉药",
            "钥匙",
            "扳手",
            "象牙",
            "光镜",
            "宝石镜",
            "太阳镜",
            "眼镜",
            "戒指",
            "纹身",
            "金棒",
            "游戏机",
            "女内衣",
            "男内衣",
            "解药",
            "药液",
            "银棒",
            "铜棒",
            "笔记",
            "日记",
            "密码本",
            "花板",
            "传真,",
            "迷彩条,",
            "PAG40,",
            "PAG80,",
            "PAGL,",
            "PAGLL,",
            "药箱,",
            "石蜡,",
            "空调,",
            "暖风机,",
            "冷风机,",
            "气扇,",
            "雷达,",
            "护屏,",
            "消活栓,",
            "卡通兔,",
            "撞击板,",
            "鸟类,",
            "铅竹"});
            this.comboBox14.Location = new System.Drawing.Point(266, 203);
            this.comboBox14.Name = "comboBox14";
            this.comboBox14.Size = new System.Drawing.Size(73, 20);
            this.comboBox14.TabIndex = 44;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(219, 206);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(41, 12);
            this.label23.TabIndex = 43;
            this.label23.Text = "工具四";
            // 
            // comboBox15
            // 
            this.comboBox15.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox15.FormattingEnabled = true;
            this.comboBox15.Items.AddRange(new object[] {
            "空",
            "皮帽",
            "布帽",
            "铁盔",
            "钢盔",
            "银盔",
            "金冠",
            "草帽",
            "头巾",
            "布衣",
            "皮衣",
            "披风",
            "铁衣",
            "铜衣",
            "钢衣",
            "银衣",
            "金衣",
            "草鞋",
            "布鞋",
            "皮鞋",
            "皮靴",
            "铁靴",
            "钢靴",
            "金靴",
            "背心",
            "皮甲",
            "金甲",
            "钢甲",
            "铁甲",
            "布手套",
            "皮手套",
            "铁爪",
            "铜爪",
            "钢爪",
            "金爪",
            "激光炮(1)",
            "激光炮(2)",
            "激光炮(3)",
            "激光炮(4)",
            "激光炮(5)",
            "激光炮(6)",
            "弹攻",
            "弩",
            "短枪",
            "战斧",
            "火枪",
            "回旋镖",
            "钢刀",
            "长枪",
            "机枪",
            "弹筒枪",
            "来福枪",
            "排炮",
            "军刀",
            "声纳枪",
            "火焰炮",
            "中子炮",
            "弹筒",
            "音波枪",
            "宝刀",
            "火箭炮",
            "穿甲炮",
            "飞龙火",
            "迫击炮",
            "首",
            "45炮",
            "55炮",
            "75炮",
            "80高炮",
            "95炮",
            "105加农炮",
            "115T型炮",
            "125加农炮",
            "125T型炮",
            "135加农炮",
            "140高炮",
            "155加农炮",
            "160滑膛炮",
            "165T型炮",
            "175加农炮",
            "195加农炮",
            "165钢炮",
            "180高炮",
            "205加农炮",
            "220炮",
            "ATM导弹",
            "喷火",
            "弹炮",
            "LI旋炮",
            "电光",
            "汽弹",
            "拉卡",
            "福特",
            "火狼",
            "台风",
            "雷电",
            "巨炮",
            "火神",
            "气旋",
            "截击",
            "托卢",
            "07机关炮",
            "09机关炮",
            "格林炮",
            "11机关炮",
            "09火炮",
            "11火炮",
            "15机关炮",
            "激光",
            "雷神",
            "18机关炮",
            "闪电",
            "20火炮",
            "25机关炮",
            "火龙",
            "风暴",
            "波坦",
            "HAL9000",
            "尼克",
            "艾米",
            "SOLOMON2",
            "MOT1",
            "MOT2",
            "MOT3",
            "SOLO",
            "SOL1",
            "SOL2",
            "BUL",
            "BUL1",
            "BUL11",
            "HUN0",
            "HUN1",
            "HUN2",
            "V24",
            "V32",
            "V48",
            "SIL0",
            "SIL1",
            "SIL2",
            "OHC",
            "涡轮",
            "喷气",
            "V48金刚式",
            "V66",
            "V100",
            "WEN",
            "HOR",
            "CAR",
            "TAN",
            "BAO",
            "HU",
            "RLA",
            "KHU",
            "毛巾",
            "面具",
            "口罩",
            "军号",
            "兴奋剂",
            "灭火器",
            "烟雾",
            "消火栓",
            "榴弹",
            "穿甲弹",
            "手雷",
            "导弹",
            "火瓶",
            "酸瓶",
            "石子",
            "钱包",
            "参丸",
            "党参",
            "人参",
            "灵丹",
            "喷雾剂",
            "地图",
            "空",
            "修理箱",
            "再生丸",
            "古币",
            "探雷器",
            "探测仪",
            "醉药",
            "钥匙",
            "扳手",
            "象牙",
            "光镜",
            "宝石镜",
            "太阳镜",
            "眼镜",
            "戒指",
            "纹身",
            "金棒",
            "游戏机",
            "女内衣",
            "男内衣",
            "解药",
            "药液",
            "银棒",
            "铜棒",
            "笔记",
            "日记",
            "密码本",
            "花板",
            "传真,",
            "迷彩条,",
            "PAG40,",
            "PAG80,",
            "PAGL,",
            "PAGLL,",
            "药箱,",
            "石蜡,",
            "空调,",
            "暖风机,",
            "冷风机,",
            "气扇,",
            "雷达,",
            "护屏,",
            "消活栓,",
            "卡通兔,",
            "撞击板,",
            "鸟类,",
            "铅竹"});
            this.comboBox15.Location = new System.Drawing.Point(154, 203);
            this.comboBox15.Name = "comboBox15";
            this.comboBox15.Size = new System.Drawing.Size(59, 20);
            this.comboBox15.TabIndex = 42;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(107, 206);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(41, 12);
            this.label24.TabIndex = 41;
            this.label24.Text = "工具三";
            // 
            // comboBox16
            // 
            this.comboBox16.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox16.FormattingEnabled = true;
            this.comboBox16.Items.AddRange(new object[] {
            "空",
            "皮帽",
            "布帽",
            "铁盔",
            "钢盔",
            "银盔",
            "金冠",
            "草帽",
            "头巾",
            "布衣",
            "皮衣",
            "披风",
            "铁衣",
            "铜衣",
            "钢衣",
            "银衣",
            "金衣",
            "草鞋",
            "布鞋",
            "皮鞋",
            "皮靴",
            "铁靴",
            "钢靴",
            "金靴",
            "背心",
            "皮甲",
            "金甲",
            "钢甲",
            "铁甲",
            "布手套",
            "皮手套",
            "铁爪",
            "铜爪",
            "钢爪",
            "金爪",
            "激光炮(1)",
            "激光炮(2)",
            "激光炮(3)",
            "激光炮(4)",
            "激光炮(5)",
            "激光炮(6)",
            "弹攻",
            "弩",
            "短枪",
            "战斧",
            "火枪",
            "回旋镖",
            "钢刀",
            "长枪",
            "机枪",
            "弹筒枪",
            "来福枪",
            "排炮",
            "军刀",
            "声纳枪",
            "火焰炮",
            "中子炮",
            "弹筒",
            "音波枪",
            "宝刀",
            "火箭炮",
            "穿甲炮",
            "飞龙火",
            "迫击炮",
            "首",
            "45炮",
            "55炮",
            "75炮",
            "80高炮",
            "95炮",
            "105加农炮",
            "115T型炮",
            "125加农炮",
            "125T型炮",
            "135加农炮",
            "140高炮",
            "155加农炮",
            "160滑膛炮",
            "165T型炮",
            "175加农炮",
            "195加农炮",
            "165钢炮",
            "180高炮",
            "205加农炮",
            "220炮",
            "ATM导弹",
            "喷火",
            "弹炮",
            "LI旋炮",
            "电光",
            "汽弹",
            "拉卡",
            "福特",
            "火狼",
            "台风",
            "雷电",
            "巨炮",
            "火神",
            "气旋",
            "截击",
            "托卢",
            "07机关炮",
            "09机关炮",
            "格林炮",
            "11机关炮",
            "09火炮",
            "11火炮",
            "15机关炮",
            "激光",
            "雷神",
            "18机关炮",
            "闪电",
            "20火炮",
            "25机关炮",
            "火龙",
            "风暴",
            "波坦",
            "HAL9000",
            "尼克",
            "艾米",
            "SOLOMON2",
            "MOT1",
            "MOT2",
            "MOT3",
            "SOLO",
            "SOL1",
            "SOL2",
            "BUL",
            "BUL1",
            "BUL11",
            "HUN0",
            "HUN1",
            "HUN2",
            "V24",
            "V32",
            "V48",
            "SIL0",
            "SIL1",
            "SIL2",
            "OHC",
            "涡轮",
            "喷气",
            "V48金刚式",
            "V66",
            "V100",
            "WEN",
            "HOR",
            "CAR",
            "TAN",
            "BAO",
            "HU",
            "RLA",
            "KHU",
            "毛巾",
            "面具",
            "口罩",
            "军号",
            "兴奋剂",
            "灭火器",
            "烟雾",
            "消火栓",
            "榴弹",
            "穿甲弹",
            "手雷",
            "导弹",
            "火瓶",
            "酸瓶",
            "石子",
            "钱包",
            "参丸",
            "党参",
            "人参",
            "灵丹",
            "喷雾剂",
            "地图",
            "空",
            "修理箱",
            "再生丸",
            "古币",
            "探雷器",
            "探测仪",
            "醉药",
            "钥匙",
            "扳手",
            "象牙",
            "光镜",
            "宝石镜",
            "太阳镜",
            "眼镜",
            "戒指",
            "纹身",
            "金棒",
            "游戏机",
            "女内衣",
            "男内衣",
            "解药",
            "药液",
            "银棒",
            "铜棒",
            "笔记",
            "日记",
            "密码本",
            "花板",
            "传真,",
            "迷彩条,",
            "PAG40,",
            "PAG80,",
            "PAGL,",
            "PAGLL,",
            "药箱,",
            "石蜡,",
            "空调,",
            "暖风机,",
            "冷风机,",
            "气扇,",
            "雷达,",
            "护屏,",
            "消活栓,",
            "卡通兔,",
            "撞击板,",
            "鸟类,",
            "铅竹"});
            this.comboBox16.Location = new System.Drawing.Point(266, 178);
            this.comboBox16.Name = "comboBox16";
            this.comboBox16.Size = new System.Drawing.Size(73, 20);
            this.comboBox16.TabIndex = 40;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(219, 181);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(41, 12);
            this.label25.TabIndex = 39;
            this.label25.Text = "工具二";
            // 
            // comboBox17
            // 
            this.comboBox17.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox17.FormattingEnabled = true;
            this.comboBox17.Items.AddRange(new object[] {
            "空",
            "皮帽",
            "布帽",
            "铁盔",
            "钢盔",
            "银盔",
            "金冠",
            "草帽",
            "头巾",
            "布衣",
            "皮衣",
            "披风",
            "铁衣",
            "铜衣",
            "钢衣",
            "银衣",
            "金衣",
            "草鞋",
            "布鞋",
            "皮鞋",
            "皮靴",
            "铁靴",
            "钢靴",
            "金靴",
            "背心",
            "皮甲",
            "金甲",
            "钢甲",
            "铁甲",
            "布手套",
            "皮手套",
            "铁爪",
            "铜爪",
            "钢爪",
            "金爪",
            "激光炮(1)",
            "激光炮(2)",
            "激光炮(3)",
            "激光炮(4)",
            "激光炮(5)",
            "激光炮(6)",
            "弹攻",
            "弩",
            "短枪",
            "战斧",
            "火枪",
            "回旋镖",
            "钢刀",
            "长枪",
            "机枪",
            "弹筒枪",
            "来福枪",
            "排炮",
            "军刀",
            "声纳枪",
            "火焰炮",
            "中子炮",
            "弹筒",
            "音波枪",
            "宝刀",
            "火箭炮",
            "穿甲炮",
            "飞龙火",
            "迫击炮",
            "首",
            "45炮",
            "55炮",
            "75炮",
            "80高炮",
            "95炮",
            "105加农炮",
            "115T型炮",
            "125加农炮",
            "125T型炮",
            "135加农炮",
            "140高炮",
            "155加农炮",
            "160滑膛炮",
            "165T型炮",
            "175加农炮",
            "195加农炮",
            "165钢炮",
            "180高炮",
            "205加农炮",
            "220炮",
            "ATM导弹",
            "喷火",
            "弹炮",
            "LI旋炮",
            "电光",
            "汽弹",
            "拉卡",
            "福特",
            "火狼",
            "台风",
            "雷电",
            "巨炮",
            "火神",
            "气旋",
            "截击",
            "托卢",
            "07机关炮",
            "09机关炮",
            "格林炮",
            "11机关炮",
            "09火炮",
            "11火炮",
            "15机关炮",
            "激光",
            "雷神",
            "18机关炮",
            "闪电",
            "20火炮",
            "25机关炮",
            "火龙",
            "风暴",
            "波坦",
            "HAL9000",
            "尼克",
            "艾米",
            "SOLOMON2",
            "MOT1",
            "MOT2",
            "MOT3",
            "SOLO",
            "SOL1",
            "SOL2",
            "BUL",
            "BUL1",
            "BUL11",
            "HUN0",
            "HUN1",
            "HUN2",
            "V24",
            "V32",
            "V48",
            "SIL0",
            "SIL1",
            "SIL2",
            "OHC",
            "涡轮",
            "喷气",
            "V48金刚式",
            "V66",
            "V100",
            "WEN",
            "HOR",
            "CAR",
            "TAN",
            "BAO",
            "HU",
            "RLA",
            "KHU",
            "毛巾",
            "面具",
            "口罩",
            "军号",
            "兴奋剂",
            "灭火器",
            "烟雾",
            "消火栓",
            "榴弹",
            "穿甲弹",
            "手雷",
            "导弹",
            "火瓶",
            "酸瓶",
            "石子",
            "钱包",
            "参丸",
            "党参",
            "人参",
            "灵丹",
            "喷雾剂",
            "地图",
            "空",
            "修理箱",
            "再生丸",
            "古币",
            "探雷器",
            "探测仪",
            "醉药",
            "钥匙",
            "扳手",
            "象牙",
            "光镜",
            "宝石镜",
            "太阳镜",
            "眼镜",
            "戒指",
            "纹身",
            "金棒",
            "游戏机",
            "女内衣",
            "男内衣",
            "解药",
            "药液",
            "银棒",
            "铜棒",
            "笔记",
            "日记",
            "密码本",
            "花板",
            "传真,",
            "迷彩条,",
            "PAG40,",
            "PAG80,",
            "PAGL,",
            "PAGLL,",
            "药箱,",
            "石蜡,",
            "空调,",
            "暖风机,",
            "冷风机,",
            "气扇,",
            "雷达,",
            "护屏,",
            "消活栓,",
            "卡通兔,",
            "撞击板,",
            "鸟类,",
            "铅竹"});
            this.comboBox17.Location = new System.Drawing.Point(154, 178);
            this.comboBox17.Name = "comboBox17";
            this.comboBox17.Size = new System.Drawing.Size(59, 20);
            this.comboBox17.TabIndex = 38;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(107, 181);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(41, 12);
            this.label26.TabIndex = 37;
            this.label26.Text = "工具一";
            // 
            // comboBox9
            // 
            this.comboBox9.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox9.FormattingEnabled = true;
            this.comboBox9.Items.AddRange(new object[] {
            "空",
            "皮帽",
            "布帽",
            "铁盔",
            "钢盔",
            "银盔",
            "金冠",
            "草帽",
            "头巾",
            "布衣",
            "皮衣",
            "披风",
            "铁衣",
            "铜衣",
            "钢衣",
            "银衣",
            "金衣",
            "草鞋",
            "布鞋",
            "皮鞋",
            "皮靴",
            "铁靴",
            "钢靴",
            "金靴",
            "背心",
            "皮甲",
            "金甲",
            "钢甲",
            "铁甲",
            "布手套",
            "皮手套",
            "铁爪",
            "铜爪",
            "钢爪",
            "金爪",
            "激光炮(1)",
            "激光炮(2)",
            "激光炮(3)",
            "激光炮(4)",
            "激光炮(5)",
            "激光炮(6)",
            "弹攻",
            "弩",
            "短枪",
            "战斧",
            "火枪",
            "回旋镖",
            "钢刀",
            "长枪",
            "机枪",
            "弹筒枪",
            "来福枪",
            "排炮",
            "军刀",
            "声纳枪",
            "火焰炮",
            "中子炮",
            "弹筒",
            "音波枪",
            "宝刀",
            "火箭炮",
            "穿甲炮",
            "飞龙火",
            "迫击炮",
            "首",
            "45炮",
            "55炮",
            "75炮",
            "80高炮",
            "95炮",
            "105加农炮",
            "115T型炮",
            "125加农炮",
            "125T型炮",
            "135加农炮",
            "140高炮",
            "155加农炮",
            "160滑膛炮",
            "165T型炮",
            "175加农炮",
            "195加农炮",
            "165钢炮",
            "180高炮",
            "205加农炮",
            "220炮",
            "ATM导弹",
            "喷火",
            "弹炮",
            "LI旋炮",
            "电光",
            "汽弹",
            "拉卡",
            "福特",
            "火狼",
            "台风",
            "雷电",
            "巨炮",
            "火神",
            "气旋",
            "截击",
            "托卢",
            "07机关炮",
            "09机关炮",
            "格林炮",
            "11机关炮",
            "09火炮",
            "11火炮",
            "15机关炮",
            "激光",
            "雷神",
            "18机关炮",
            "闪电",
            "20火炮",
            "25机关炮",
            "火龙",
            "风暴",
            "波坦",
            "HAL9000",
            "尼克",
            "艾米",
            "SOLOMON2",
            "MOT1",
            "MOT2",
            "MOT3",
            "SOLO",
            "SOL1",
            "SOL2",
            "BUL",
            "BUL1",
            "BUL11",
            "HUN0",
            "HUN1",
            "HUN2",
            "V24",
            "V32",
            "V48",
            "SIL0",
            "SIL1",
            "SIL2",
            "OHC",
            "涡轮",
            "喷气",
            "V48金刚式",
            "V66",
            "V100",
            "WEN",
            "HOR",
            "CAR",
            "TAN",
            "BAO",
            "HU",
            "RLA",
            "KHU",
            "毛巾",
            "面具",
            "口罩",
            "军号",
            "兴奋剂",
            "灭火器",
            "烟雾",
            "消火栓",
            "榴弹",
            "穿甲弹",
            "手雷",
            "导弹",
            "火瓶",
            "酸瓶",
            "石子",
            "钱包",
            "参丸",
            "党参",
            "人参",
            "灵丹",
            "喷雾剂",
            "地图",
            "空",
            "修理箱",
            "再生丸",
            "古币",
            "探雷器",
            "探测仪",
            "醉药",
            "钥匙",
            "扳手",
            "象牙",
            "光镜",
            "宝石镜",
            "太阳镜",
            "眼镜",
            "戒指",
            "纹身",
            "金棒",
            "游戏机",
            "女内衣",
            "男内衣",
            "解药",
            "药液",
            "银棒",
            "铜棒",
            "笔记",
            "日记",
            "密码本",
            "花板",
            "传真,",
            "迷彩条,",
            "PAG40,",
            "PAG80,",
            "PAGL,",
            "PAGLL,",
            "药箱,",
            "石蜡,",
            "空调,",
            "暖风机,",
            "冷风机,",
            "气扇,",
            "雷达,",
            "护屏,",
            "消活栓,",
            "卡通兔,",
            "撞击板,",
            "鸟类,",
            "铅竹"});
            this.comboBox9.Location = new System.Drawing.Point(266, 146);
            this.comboBox9.Name = "comboBox9";
            this.comboBox9.Size = new System.Drawing.Size(73, 20);
            this.comboBox9.TabIndex = 36;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(219, 149);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(41, 12);
            this.label18.TabIndex = 35;
            this.label18.Text = "装备八";
            // 
            // comboBox8
            // 
            this.comboBox8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Items.AddRange(new object[] {
            "空",
            "皮帽",
            "布帽",
            "铁盔",
            "钢盔",
            "银盔",
            "金冠",
            "草帽",
            "头巾",
            "布衣",
            "皮衣",
            "披风",
            "铁衣",
            "铜衣",
            "钢衣",
            "银衣",
            "金衣",
            "草鞋",
            "布鞋",
            "皮鞋",
            "皮靴",
            "铁靴",
            "钢靴",
            "金靴",
            "背心",
            "皮甲",
            "金甲",
            "钢甲",
            "铁甲",
            "布手套",
            "皮手套",
            "铁爪",
            "铜爪",
            "钢爪",
            "金爪",
            "激光炮(1)",
            "激光炮(2)",
            "激光炮(3)",
            "激光炮(4)",
            "激光炮(5)",
            "激光炮(6)",
            "弹攻",
            "弩",
            "短枪",
            "战斧",
            "火枪",
            "回旋镖",
            "钢刀",
            "长枪",
            "机枪",
            "弹筒枪",
            "来福枪",
            "排炮",
            "军刀",
            "声纳枪",
            "火焰炮",
            "中子炮",
            "弹筒",
            "音波枪",
            "宝刀",
            "火箭炮",
            "穿甲炮",
            "飞龙火",
            "迫击炮",
            "首",
            "45炮",
            "55炮",
            "75炮",
            "80高炮",
            "95炮",
            "105加农炮",
            "115T型炮",
            "125加农炮",
            "125T型炮",
            "135加农炮",
            "140高炮",
            "155加农炮",
            "160滑膛炮",
            "165T型炮",
            "175加农炮",
            "195加农炮",
            "165钢炮",
            "180高炮",
            "205加农炮",
            "220炮",
            "ATM导弹",
            "喷火",
            "弹炮",
            "LI旋炮",
            "电光",
            "汽弹",
            "拉卡",
            "福特",
            "火狼",
            "台风",
            "雷电",
            "巨炮",
            "火神",
            "气旋",
            "截击",
            "托卢",
            "07机关炮",
            "09机关炮",
            "格林炮",
            "11机关炮",
            "09火炮",
            "11火炮",
            "15机关炮",
            "激光",
            "雷神",
            "18机关炮",
            "闪电",
            "20火炮",
            "25机关炮",
            "火龙",
            "风暴",
            "波坦",
            "HAL9000",
            "尼克",
            "艾米",
            "SOLOMON2",
            "MOT1",
            "MOT2",
            "MOT3",
            "SOLO",
            "SOL1",
            "SOL2",
            "BUL",
            "BUL1",
            "BUL11",
            "HUN0",
            "HUN1",
            "HUN2",
            "V24",
            "V32",
            "V48",
            "SIL0",
            "SIL1",
            "SIL2",
            "OHC",
            "涡轮",
            "喷气",
            "V48金刚式",
            "V66",
            "V100",
            "WEN",
            "HOR",
            "CAR",
            "TAN",
            "BAO",
            "HU",
            "RLA",
            "KHU",
            "毛巾",
            "面具",
            "口罩",
            "军号",
            "兴奋剂",
            "灭火器",
            "烟雾",
            "消火栓",
            "榴弹",
            "穿甲弹",
            "手雷",
            "导弹",
            "火瓶",
            "酸瓶",
            "石子",
            "钱包",
            "参丸",
            "党参",
            "人参",
            "灵丹",
            "喷雾剂",
            "地图",
            "空",
            "修理箱",
            "再生丸",
            "古币",
            "探雷器",
            "探测仪",
            "醉药",
            "钥匙",
            "扳手",
            "象牙",
            "光镜",
            "宝石镜",
            "太阳镜",
            "眼镜",
            "戒指",
            "纹身",
            "金棒",
            "游戏机",
            "女内衣",
            "男内衣",
            "解药",
            "药液",
            "银棒",
            "铜棒",
            "笔记",
            "日记",
            "密码本",
            "花板",
            "传真,",
            "迷彩条,",
            "PAG40,",
            "PAG80,",
            "PAGL,",
            "PAGLL,",
            "药箱,",
            "石蜡,",
            "空调,",
            "暖风机,",
            "冷风机,",
            "气扇,",
            "雷达,",
            "护屏,",
            "消活栓,",
            "卡通兔,",
            "撞击板,",
            "鸟类,",
            "铅竹"});
            this.comboBox8.Location = new System.Drawing.Point(154, 146);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(59, 20);
            this.comboBox8.TabIndex = 34;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(107, 149);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 12);
            this.label17.TabIndex = 33;
            this.label17.Text = "装备七";
            // 
            // comboBox7
            // 
            this.comboBox7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Items.AddRange(new object[] {
            "空",
            "皮帽",
            "布帽",
            "铁盔",
            "钢盔",
            "银盔",
            "金冠",
            "草帽",
            "头巾",
            "布衣",
            "皮衣",
            "披风",
            "铁衣",
            "铜衣",
            "钢衣",
            "银衣",
            "金衣",
            "草鞋",
            "布鞋",
            "皮鞋",
            "皮靴",
            "铁靴",
            "钢靴",
            "金靴",
            "背心",
            "皮甲",
            "金甲",
            "钢甲",
            "铁甲",
            "布手套",
            "皮手套",
            "铁爪",
            "铜爪",
            "钢爪",
            "金爪",
            "激光炮(1)",
            "激光炮(2)",
            "激光炮(3)",
            "激光炮(4)",
            "激光炮(5)",
            "激光炮(6)",
            "弹攻",
            "弩",
            "短枪",
            "战斧",
            "火枪",
            "回旋镖",
            "钢刀",
            "长枪",
            "机枪",
            "弹筒枪",
            "来福枪",
            "排炮",
            "军刀",
            "声纳枪",
            "火焰炮",
            "中子炮",
            "弹筒",
            "音波枪",
            "宝刀",
            "火箭炮",
            "穿甲炮",
            "飞龙火",
            "迫击炮",
            "首",
            "45炮",
            "55炮",
            "75炮",
            "80高炮",
            "95炮",
            "105加农炮",
            "115T型炮",
            "125加农炮",
            "125T型炮",
            "135加农炮",
            "140高炮",
            "155加农炮",
            "160滑膛炮",
            "165T型炮",
            "175加农炮",
            "195加农炮",
            "165钢炮",
            "180高炮",
            "205加农炮",
            "220炮",
            "ATM导弹",
            "喷火",
            "弹炮",
            "LI旋炮",
            "电光",
            "汽弹",
            "拉卡",
            "福特",
            "火狼",
            "台风",
            "雷电",
            "巨炮",
            "火神",
            "气旋",
            "截击",
            "托卢",
            "07机关炮",
            "09机关炮",
            "格林炮",
            "11机关炮",
            "09火炮",
            "11火炮",
            "15机关炮",
            "激光",
            "雷神",
            "18机关炮",
            "闪电",
            "20火炮",
            "25机关炮",
            "火龙",
            "风暴",
            "波坦",
            "HAL9000",
            "尼克",
            "艾米",
            "SOLOMON2",
            "MOT1",
            "MOT2",
            "MOT3",
            "SOLO",
            "SOL1",
            "SOL2",
            "BUL",
            "BUL1",
            "BUL11",
            "HUN0",
            "HUN1",
            "HUN2",
            "V24",
            "V32",
            "V48",
            "SIL0",
            "SIL1",
            "SIL2",
            "OHC",
            "涡轮",
            "喷气",
            "V48金刚式",
            "V66",
            "V100",
            "WEN",
            "HOR",
            "CAR",
            "TAN",
            "BAO",
            "HU",
            "RLA",
            "KHU",
            "毛巾",
            "面具",
            "口罩",
            "军号",
            "兴奋剂",
            "灭火器",
            "烟雾",
            "消火栓",
            "榴弹",
            "穿甲弹",
            "手雷",
            "导弹",
            "火瓶",
            "酸瓶",
            "石子",
            "钱包",
            "参丸",
            "党参",
            "人参",
            "灵丹",
            "喷雾剂",
            "地图",
            "空",
            "修理箱",
            "再生丸",
            "古币",
            "探雷器",
            "探测仪",
            "醉药",
            "钥匙",
            "扳手",
            "象牙",
            "光镜",
            "宝石镜",
            "太阳镜",
            "眼镜",
            "戒指",
            "纹身",
            "金棒",
            "游戏机",
            "女内衣",
            "男内衣",
            "解药",
            "药液",
            "银棒",
            "铜棒",
            "笔记",
            "日记",
            "密码本",
            "花板",
            "传真,",
            "迷彩条,",
            "PAG40,",
            "PAG80,",
            "PAGL,",
            "PAGLL,",
            "药箱,",
            "石蜡,",
            "空调,",
            "暖风机,",
            "冷风机,",
            "气扇,",
            "雷达,",
            "护屏,",
            "消活栓,",
            "卡通兔,",
            "撞击板,",
            "鸟类,",
            "铅竹"});
            this.comboBox7.Location = new System.Drawing.Point(266, 119);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(73, 20);
            this.comboBox7.TabIndex = 32;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(219, 122);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 12);
            this.label16.TabIndex = 31;
            this.label16.Text = "装备六";
            // 
            // comboBox6
            // 
            this.comboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Items.AddRange(new object[] {
            "空",
            "皮帽",
            "布帽",
            "铁盔",
            "钢盔",
            "银盔",
            "金冠",
            "草帽",
            "头巾",
            "布衣",
            "皮衣",
            "披风",
            "铁衣",
            "铜衣",
            "钢衣",
            "银衣",
            "金衣",
            "草鞋",
            "布鞋",
            "皮鞋",
            "皮靴",
            "铁靴",
            "钢靴",
            "金靴",
            "背心",
            "皮甲",
            "金甲",
            "钢甲",
            "铁甲",
            "布手套",
            "皮手套",
            "铁爪",
            "铜爪",
            "钢爪",
            "金爪",
            "激光炮(1)",
            "激光炮(2)",
            "激光炮(3)",
            "激光炮(4)",
            "激光炮(5)",
            "激光炮(6)",
            "弹攻",
            "弩",
            "短枪",
            "战斧",
            "火枪",
            "回旋镖",
            "钢刀",
            "长枪",
            "机枪",
            "弹筒枪",
            "来福枪",
            "排炮",
            "军刀",
            "声纳枪",
            "火焰炮",
            "中子炮",
            "弹筒",
            "音波枪",
            "宝刀",
            "火箭炮",
            "穿甲炮",
            "飞龙火",
            "迫击炮",
            "首",
            "45炮",
            "55炮",
            "75炮",
            "80高炮",
            "95炮",
            "105加农炮",
            "115T型炮",
            "125加农炮",
            "125T型炮",
            "135加农炮",
            "140高炮",
            "155加农炮",
            "160滑膛炮",
            "165T型炮",
            "175加农炮",
            "195加农炮",
            "165钢炮",
            "180高炮",
            "205加农炮",
            "220炮",
            "ATM导弹",
            "喷火",
            "弹炮",
            "LI旋炮",
            "电光",
            "汽弹",
            "拉卡",
            "福特",
            "火狼",
            "台风",
            "雷电",
            "巨炮",
            "火神",
            "气旋",
            "截击",
            "托卢",
            "07机关炮",
            "09机关炮",
            "格林炮",
            "11机关炮",
            "09火炮",
            "11火炮",
            "15机关炮",
            "激光",
            "雷神",
            "18机关炮",
            "闪电",
            "20火炮",
            "25机关炮",
            "火龙",
            "风暴",
            "波坦",
            "HAL9000",
            "尼克",
            "艾米",
            "SOLOMON2",
            "MOT1",
            "MOT2",
            "MOT3",
            "SOLO",
            "SOL1",
            "SOL2",
            "BUL",
            "BUL1",
            "BUL11",
            "HUN0",
            "HUN1",
            "HUN2",
            "V24",
            "V32",
            "V48",
            "SIL0",
            "SIL1",
            "SIL2",
            "OHC",
            "涡轮",
            "喷气",
            "V48金刚式",
            "V66",
            "V100",
            "WEN",
            "HOR",
            "CAR",
            "TAN",
            "BAO",
            "HU",
            "RLA",
            "KHU",
            "毛巾",
            "面具",
            "口罩",
            "军号",
            "兴奋剂",
            "灭火器",
            "烟雾",
            "消火栓",
            "榴弹",
            "穿甲弹",
            "手雷",
            "导弹",
            "火瓶",
            "酸瓶",
            "石子",
            "钱包",
            "参丸",
            "党参",
            "人参",
            "灵丹",
            "喷雾剂",
            "地图",
            "空",
            "修理箱",
            "再生丸",
            "古币",
            "探雷器",
            "探测仪",
            "醉药",
            "钥匙",
            "扳手",
            "象牙",
            "光镜",
            "宝石镜",
            "太阳镜",
            "眼镜",
            "戒指",
            "纹身",
            "金棒",
            "游戏机",
            "女内衣",
            "男内衣",
            "解药",
            "药液",
            "银棒",
            "铜棒",
            "笔记",
            "日记",
            "密码本",
            "花板",
            "传真,",
            "迷彩条,",
            "PAG40,",
            "PAG80,",
            "PAGL,",
            "PAGLL,",
            "药箱,",
            "石蜡,",
            "空调,",
            "暖风机,",
            "冷风机,",
            "气扇,",
            "雷达,",
            "护屏,",
            "消活栓,",
            "卡通兔,",
            "撞击板,",
            "鸟类,",
            "铅竹"});
            this.comboBox6.Location = new System.Drawing.Point(154, 119);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(59, 20);
            this.comboBox6.TabIndex = 30;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(107, 122);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 12);
            this.label15.TabIndex = 29;
            this.label15.Text = "装备五";
            // 
            // comboBox5
            // 
            this.comboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "空",
            "皮帽",
            "布帽",
            "铁盔",
            "钢盔",
            "银盔",
            "金冠",
            "草帽",
            "头巾",
            "布衣",
            "皮衣",
            "披风",
            "铁衣",
            "铜衣",
            "钢衣",
            "银衣",
            "金衣",
            "草鞋",
            "布鞋",
            "皮鞋",
            "皮靴",
            "铁靴",
            "钢靴",
            "金靴",
            "背心",
            "皮甲",
            "金甲",
            "钢甲",
            "铁甲",
            "布手套",
            "皮手套",
            "铁爪",
            "铜爪",
            "钢爪",
            "金爪",
            "激光炮(1)",
            "激光炮(2)",
            "激光炮(3)",
            "激光炮(4)",
            "激光炮(5)",
            "激光炮(6)",
            "弹攻",
            "弩",
            "短枪",
            "战斧",
            "火枪",
            "回旋镖",
            "钢刀",
            "长枪",
            "机枪",
            "弹筒枪",
            "来福枪",
            "排炮",
            "军刀",
            "声纳枪",
            "火焰炮",
            "中子炮",
            "弹筒",
            "音波枪",
            "宝刀",
            "火箭炮",
            "穿甲炮",
            "飞龙火",
            "迫击炮",
            "首",
            "45炮",
            "55炮",
            "75炮",
            "80高炮",
            "95炮",
            "105加农炮",
            "115T型炮",
            "125加农炮",
            "125T型炮",
            "135加农炮",
            "140高炮",
            "155加农炮",
            "160滑膛炮",
            "165T型炮",
            "175加农炮",
            "195加农炮",
            "165钢炮",
            "180高炮",
            "205加农炮",
            "220炮",
            "ATM导弹",
            "喷火",
            "弹炮",
            "LI旋炮",
            "电光",
            "汽弹",
            "拉卡",
            "福特",
            "火狼",
            "台风",
            "雷电",
            "巨炮",
            "火神",
            "气旋",
            "截击",
            "托卢",
            "07机关炮",
            "09机关炮",
            "格林炮",
            "11机关炮",
            "09火炮",
            "11火炮",
            "15机关炮",
            "激光",
            "雷神",
            "18机关炮",
            "闪电",
            "20火炮",
            "25机关炮",
            "火龙",
            "风暴",
            "波坦",
            "HAL9000",
            "尼克",
            "艾米",
            "SOLOMON2",
            "MOT1",
            "MOT2",
            "MOT3",
            "SOLO",
            "SOL1",
            "SOL2",
            "BUL",
            "BUL1",
            "BUL11",
            "HUN0",
            "HUN1",
            "HUN2",
            "V24",
            "V32",
            "V48",
            "SIL0",
            "SIL1",
            "SIL2",
            "OHC",
            "涡轮",
            "喷气",
            "V48金刚式",
            "V66",
            "V100",
            "WEN",
            "HOR",
            "CAR",
            "TAN",
            "BAO",
            "HU",
            "RLA",
            "KHU",
            "毛巾",
            "面具",
            "口罩",
            "军号",
            "兴奋剂",
            "灭火器",
            "烟雾",
            "消火栓",
            "榴弹",
            "穿甲弹",
            "手雷",
            "导弹",
            "火瓶",
            "酸瓶",
            "石子",
            "钱包",
            "参丸",
            "党参",
            "人参",
            "灵丹",
            "喷雾剂",
            "地图",
            "空",
            "修理箱",
            "再生丸",
            "古币",
            "探雷器",
            "探测仪",
            "醉药",
            "钥匙",
            "扳手",
            "象牙",
            "光镜",
            "宝石镜",
            "太阳镜",
            "眼镜",
            "戒指",
            "纹身",
            "金棒",
            "游戏机",
            "女内衣",
            "男内衣",
            "解药",
            "药液",
            "银棒",
            "铜棒",
            "笔记",
            "日记",
            "密码本",
            "花板",
            "传真,",
            "迷彩条,",
            "PAG40,",
            "PAG80,",
            "PAGL,",
            "PAGLL,",
            "药箱,",
            "石蜡,",
            "空调,",
            "暖风机,",
            "冷风机,",
            "气扇,",
            "雷达,",
            "护屏,",
            "消活栓,",
            "卡通兔,",
            "撞击板,",
            "鸟类,",
            "铅竹"});
            this.comboBox5.Location = new System.Drawing.Point(266, 95);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(73, 20);
            this.comboBox5.TabIndex = 28;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(219, 98);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 12);
            this.label14.TabIndex = 27;
            this.label14.Text = "装备四";
            // 
            // comboBox4
            // 
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "空",
            "皮帽",
            "布帽",
            "铁盔",
            "钢盔",
            "银盔",
            "金冠",
            "草帽",
            "头巾",
            "布衣",
            "皮衣",
            "披风",
            "铁衣",
            "铜衣",
            "钢衣",
            "银衣",
            "金衣",
            "草鞋",
            "布鞋",
            "皮鞋",
            "皮靴",
            "铁靴",
            "钢靴",
            "金靴",
            "背心",
            "皮甲",
            "金甲",
            "钢甲",
            "铁甲",
            "布手套",
            "皮手套",
            "铁爪",
            "铜爪",
            "钢爪",
            "金爪",
            "激光炮(1)",
            "激光炮(2)",
            "激光炮(3)",
            "激光炮(4)",
            "激光炮(5)",
            "激光炮(6)",
            "弹攻",
            "弩",
            "短枪",
            "战斧",
            "火枪",
            "回旋镖",
            "钢刀",
            "长枪",
            "机枪",
            "弹筒枪",
            "来福枪",
            "排炮",
            "军刀",
            "声纳枪",
            "火焰炮",
            "中子炮",
            "弹筒",
            "音波枪",
            "宝刀",
            "火箭炮",
            "穿甲炮",
            "飞龙火",
            "迫击炮",
            "首",
            "45炮",
            "55炮",
            "75炮",
            "80高炮",
            "95炮",
            "105加农炮",
            "115T型炮",
            "125加农炮",
            "125T型炮",
            "135加农炮",
            "140高炮",
            "155加农炮",
            "160滑膛炮",
            "165T型炮",
            "175加农炮",
            "195加农炮",
            "165钢炮",
            "180高炮",
            "205加农炮",
            "220炮",
            "ATM导弹",
            "喷火",
            "弹炮",
            "LI旋炮",
            "电光",
            "汽弹",
            "拉卡",
            "福特",
            "火狼",
            "台风",
            "雷电",
            "巨炮",
            "火神",
            "气旋",
            "截击",
            "托卢",
            "07机关炮",
            "09机关炮",
            "格林炮",
            "11机关炮",
            "09火炮",
            "11火炮",
            "15机关炮",
            "激光",
            "雷神",
            "18机关炮",
            "闪电",
            "20火炮",
            "25机关炮",
            "火龙",
            "风暴",
            "波坦",
            "HAL9000",
            "尼克",
            "艾米",
            "SOLOMON2",
            "MOT1",
            "MOT2",
            "MOT3",
            "SOLO",
            "SOL1",
            "SOL2",
            "BUL",
            "BUL1",
            "BUL11",
            "HUN0",
            "HUN1",
            "HUN2",
            "V24",
            "V32",
            "V48",
            "SIL0",
            "SIL1",
            "SIL2",
            "OHC",
            "涡轮",
            "喷气",
            "V48金刚式",
            "V66",
            "V100",
            "WEN",
            "HOR",
            "CAR",
            "TAN",
            "BAO",
            "HU",
            "RLA",
            "KHU",
            "毛巾",
            "面具",
            "口罩",
            "军号",
            "兴奋剂",
            "灭火器",
            "烟雾",
            "消火栓",
            "榴弹",
            "穿甲弹",
            "手雷",
            "导弹",
            "火瓶",
            "酸瓶",
            "石子",
            "钱包",
            "参丸",
            "党参",
            "人参",
            "灵丹",
            "喷雾剂",
            "地图",
            "空",
            "修理箱",
            "再生丸",
            "古币",
            "探雷器",
            "探测仪",
            "醉药",
            "钥匙",
            "扳手",
            "象牙",
            "光镜",
            "宝石镜",
            "太阳镜",
            "眼镜",
            "戒指",
            "纹身",
            "金棒",
            "游戏机",
            "女内衣",
            "男内衣",
            "解药",
            "药液",
            "银棒",
            "铜棒",
            "笔记",
            "日记",
            "密码本",
            "花板",
            "传真,",
            "迷彩条,",
            "PAG40,",
            "PAG80,",
            "PAGL,",
            "PAGLL,",
            "药箱,",
            "石蜡,",
            "空调,",
            "暖风机,",
            "冷风机,",
            "气扇,",
            "雷达,",
            "护屏,",
            "消活栓,",
            "卡通兔,",
            "撞击板,",
            "鸟类,",
            "铅竹"});
            this.comboBox4.Location = new System.Drawing.Point(154, 95);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(59, 20);
            this.comboBox4.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(107, 98);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 12);
            this.label13.TabIndex = 25;
            this.label13.Text = "装备三";
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "空",
            "皮帽",
            "布帽",
            "铁盔",
            "钢盔",
            "银盔",
            "金冠",
            "草帽",
            "头巾",
            "布衣",
            "皮衣",
            "披风",
            "铁衣",
            "铜衣",
            "钢衣",
            "银衣",
            "金衣",
            "草鞋",
            "布鞋",
            "皮鞋",
            "皮靴",
            "铁靴",
            "钢靴",
            "金靴",
            "背心",
            "皮甲",
            "金甲",
            "钢甲",
            "铁甲",
            "布手套",
            "皮手套",
            "铁爪",
            "铜爪",
            "钢爪",
            "金爪",
            "激光炮(1)",
            "激光炮(2)",
            "激光炮(3)",
            "激光炮(4)",
            "激光炮(5)",
            "激光炮(6)",
            "弹攻",
            "弩",
            "短枪",
            "战斧",
            "火枪",
            "回旋镖",
            "钢刀",
            "长枪",
            "机枪",
            "弹筒枪",
            "来福枪",
            "排炮",
            "军刀",
            "声纳枪",
            "火焰炮",
            "中子炮",
            "弹筒",
            "音波枪",
            "宝刀",
            "火箭炮",
            "穿甲炮",
            "飞龙火",
            "迫击炮",
            "首",
            "45炮",
            "55炮",
            "75炮",
            "80高炮",
            "95炮",
            "105加农炮",
            "115T型炮",
            "125加农炮",
            "125T型炮",
            "135加农炮",
            "140高炮",
            "155加农炮",
            "160滑膛炮",
            "165T型炮",
            "175加农炮",
            "195加农炮",
            "165钢炮",
            "180高炮",
            "205加农炮",
            "220炮",
            "ATM导弹",
            "喷火",
            "弹炮",
            "LI旋炮",
            "电光",
            "汽弹",
            "拉卡",
            "福特",
            "火狼",
            "台风",
            "雷电",
            "巨炮",
            "火神",
            "气旋",
            "截击",
            "托卢",
            "07机关炮",
            "09机关炮",
            "格林炮",
            "11机关炮",
            "09火炮",
            "11火炮",
            "15机关炮",
            "激光",
            "雷神",
            "18机关炮",
            "闪电",
            "20火炮",
            "25机关炮",
            "火龙",
            "风暴",
            "波坦",
            "HAL9000",
            "尼克",
            "艾米",
            "SOLOMON2",
            "MOT1",
            "MOT2",
            "MOT3",
            "SOLO",
            "SOL1",
            "SOL2",
            "BUL",
            "BUL1",
            "BUL11",
            "HUN0",
            "HUN1",
            "HUN2",
            "V24",
            "V32",
            "V48",
            "SIL0",
            "SIL1",
            "SIL2",
            "OHC",
            "涡轮",
            "喷气",
            "V48金刚式",
            "V66",
            "V100",
            "WEN",
            "HOR",
            "CAR",
            "TAN",
            "BAO",
            "HU",
            "RLA",
            "KHU",
            "毛巾",
            "面具",
            "口罩",
            "军号",
            "兴奋剂",
            "灭火器",
            "烟雾",
            "消火栓",
            "榴弹",
            "穿甲弹",
            "手雷",
            "导弹",
            "火瓶",
            "酸瓶",
            "石子",
            "钱包",
            "参丸",
            "党参",
            "人参",
            "灵丹",
            "喷雾剂",
            "地图",
            "空",
            "修理箱",
            "再生丸",
            "古币",
            "探雷器",
            "探测仪",
            "醉药",
            "钥匙",
            "扳手",
            "象牙",
            "光镜",
            "宝石镜",
            "太阳镜",
            "眼镜",
            "戒指",
            "纹身",
            "金棒",
            "游戏机",
            "女内衣",
            "男内衣",
            "解药",
            "药液",
            "银棒",
            "铜棒",
            "笔记",
            "日记",
            "密码本",
            "花板",
            "传真,",
            "迷彩条,",
            "PAG40,",
            "PAG80,",
            "PAGL,",
            "PAGLL,",
            "药箱,",
            "石蜡,",
            "空调,",
            "暖风机,",
            "冷风机,",
            "气扇,",
            "雷达,",
            "护屏,",
            "消活栓,",
            "卡通兔,",
            "撞击板,",
            "鸟类,",
            "铅竹"});
            this.comboBox3.Location = new System.Drawing.Point(266, 70);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(73, 20);
            this.comboBox3.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(219, 73);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 12);
            this.label12.TabIndex = 23;
            this.label12.Text = "装备二";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "空",
            "皮帽",
            "布帽",
            "铁盔",
            "钢盔",
            "银盔",
            "金冠",
            "草帽",
            "头巾",
            "布衣",
            "皮衣",
            "披风",
            "铁衣",
            "铜衣",
            "钢衣",
            "银衣",
            "金衣",
            "草鞋",
            "布鞋",
            "皮鞋",
            "皮靴",
            "铁靴",
            "钢靴",
            "金靴",
            "背心",
            "皮甲",
            "金甲",
            "钢甲",
            "铁甲",
            "布手套",
            "皮手套",
            "铁爪",
            "铜爪",
            "钢爪",
            "金爪",
            "激光炮(1)",
            "激光炮(2)",
            "激光炮(3)",
            "激光炮(4)",
            "激光炮(5)",
            "激光炮(6)",
            "弹攻",
            "弩",
            "短枪",
            "战斧",
            "火枪",
            "回旋镖",
            "钢刀",
            "长枪",
            "机枪",
            "弹筒枪",
            "来福枪",
            "排炮",
            "军刀",
            "声纳枪",
            "火焰炮",
            "中子炮",
            "弹筒",
            "音波枪",
            "宝刀",
            "火箭炮",
            "穿甲炮",
            "飞龙火",
            "迫击炮",
            "首",
            "45炮",
            "55炮",
            "75炮",
            "80高炮",
            "95炮",
            "105加农炮",
            "115T型炮",
            "125加农炮",
            "125T型炮",
            "135加农炮",
            "140高炮",
            "155加农炮",
            "160滑膛炮",
            "165T型炮",
            "175加农炮",
            "195加农炮",
            "165钢炮",
            "180高炮",
            "205加农炮",
            "220炮",
            "ATM导弹",
            "喷火",
            "弹炮",
            "LI旋炮",
            "电光",
            "汽弹",
            "拉卡",
            "福特",
            "火狼",
            "台风",
            "雷电",
            "巨炮",
            "火神",
            "气旋",
            "截击",
            "托卢",
            "07机关炮",
            "09机关炮",
            "格林炮",
            "11机关炮",
            "09火炮",
            "11火炮",
            "15机关炮",
            "激光",
            "雷神",
            "18机关炮",
            "闪电",
            "20火炮",
            "25机关炮",
            "火龙",
            "风暴",
            "波坦",
            "HAL9000",
            "尼克",
            "艾米",
            "SOLOMON2",
            "MOT1",
            "MOT2",
            "MOT3",
            "SOLO",
            "SOL1",
            "SOL2",
            "BUL",
            "BUL1",
            "BUL11",
            "HUN0",
            "HUN1",
            "HUN2",
            "V24",
            "V32",
            "V48",
            "SIL0",
            "SIL1",
            "SIL2",
            "OHC",
            "涡轮",
            "喷气",
            "V48金刚式",
            "V66",
            "V100",
            "WEN",
            "HOR",
            "CAR",
            "TAN",
            "BAO",
            "HU",
            "RLA",
            "KHU",
            "毛巾",
            "面具",
            "口罩",
            "军号",
            "兴奋剂",
            "灭火器",
            "烟雾",
            "消火栓",
            "榴弹",
            "穿甲弹",
            "手雷",
            "导弹",
            "火瓶",
            "酸瓶",
            "石子",
            "钱包",
            "参丸",
            "党参",
            "人参",
            "灵丹",
            "喷雾剂",
            "地图",
            "空",
            "修理箱",
            "再生丸",
            "古币",
            "探雷器",
            "探测仪",
            "醉药",
            "钥匙",
            "扳手",
            "象牙",
            "光镜",
            "宝石镜",
            "太阳镜",
            "眼镜",
            "戒指",
            "纹身",
            "金棒",
            "游戏机",
            "女内衣",
            "男内衣",
            "解药",
            "药液",
            "银棒",
            "铜棒",
            "笔记",
            "日记",
            "密码本",
            "花板",
            "传真,",
            "迷彩条,",
            "PAG40,",
            "PAG80,",
            "PAGL,",
            "PAGLL,",
            "药箱,",
            "石蜡,",
            "空调,",
            "暖风机,",
            "冷风机,",
            "气扇,",
            "雷达,",
            "护屏,",
            "消活栓,",
            "卡通兔,",
            "撞击板,",
            "鸟类,",
            "铅竹"});
            this.comboBox2.Location = new System.Drawing.Point(154, 70);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(59, 20);
            this.comboBox2.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(107, 73);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 12);
            this.label11.TabIndex = 21;
            this.label11.Text = "装备一";
            // 
            // numericUpDown10
            // 
            this.numericUpDown10.Location = new System.Drawing.Point(51, 252);
            this.numericUpDown10.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDown10.Name = "numericUpDown10";
            this.numericUpDown10.Size = new System.Drawing.Size(50, 21);
            this.numericUpDown10.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 257);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 19;
            this.label10.Text = "体力";
            // 
            // numericUpDown9
            // 
            this.numericUpDown9.Location = new System.Drawing.Point(51, 279);
            this.numericUpDown9.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDown9.Name = "numericUpDown9";
            this.numericUpDown9.Size = new System.Drawing.Size(50, 21);
            this.numericUpDown9.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 281);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 17;
            this.label9.Text = "速度";
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.Location = new System.Drawing.Point(51, 225);
            this.numericUpDown5.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(50, 21);
            this.numericUpDown5.TabIndex = 16;
            // 
            // numericUpDown6
            // 
            this.numericUpDown6.Location = new System.Drawing.Point(51, 198);
            this.numericUpDown6.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDown6.Name = "numericUpDown6";
            this.numericUpDown6.Size = new System.Drawing.Size(50, 21);
            this.numericUpDown6.TabIndex = 15;
            // 
            // numericUpDown7
            // 
            this.numericUpDown7.Location = new System.Drawing.Point(51, 174);
            this.numericUpDown7.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDown7.Name = "numericUpDown7";
            this.numericUpDown7.Size = new System.Drawing.Size(50, 21);
            this.numericUpDown7.TabIndex = 14;
            // 
            // numericUpDown8
            // 
            this.numericUpDown8.Location = new System.Drawing.Point(51, 147);
            this.numericUpDown8.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDown8.Name = "numericUpDown8";
            this.numericUpDown8.Size = new System.Drawing.Size(50, 21);
            this.numericUpDown8.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 12;
            this.label8.Text = "智力";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 11;
            this.label7.Text = "强度";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "攻击";
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(51, 122);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(50, 21);
            this.numericUpDown4.TabIndex = 9;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(51, 95);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(50, 21);
            this.numericUpDown3.TabIndex = 8;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(51, 71);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(50, 21);
            this.numericUpDown2.TabIndex = 7;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(51, 44);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(50, 21);
            this.numericUpDown1.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "LV战斗";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "LV驾驶";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "LV修理";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "防御";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "水平";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "主",
            "机",
            "兵"});
            this.comboBox1.Location = new System.Drawing.Point(6, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(834, 611);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "重装机兵[FC]全资料修改器";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown20)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		private global::System.ComponentModel.IContainer components;
		private global::System.Windows.Forms.ToolStrip toolStrip1;
		private global::System.Windows.Forms.ToolStripButton toolStripButton1;
		private global::System.Windows.Forms.ToolStripButton toolStripButton2;
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private global::System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
		private global::System.Windows.Forms.ToolStripMenuItem 坦克主炮ToolStripMenuItem;
		private global::System.Windows.Forms.ToolStripMenuItem 坦克副炮ToolStripMenuItem;
		private global::System.Windows.Forms.ToolStripMenuItem 坦克ＳＥToolStripMenuItem;
		private global::System.Windows.Forms.ToolStripMenuItem 坦克道具ToolStripMenuItem;
		private global::System.Windows.Forms.ToolStripDropDownButton toolStripSplitButton1;
		private global::System.Windows.Forms.ToolStripMenuItem 人类武器ToolStripMenuItem;
		private global::System.Windows.Forms.ToolStripMenuItem 人类防具ToolStripMenuItem;
		private global::System.Windows.Forms.ToolStripMenuItem 人类道具ToolStripMenuItem;
		private global::System.Windows.Forms.ListView listView1;
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
		private global::System.Windows.Forms.ToolStripButton toolStripButton3;
		private global::System.Windows.Forms.ToolStripButton toolStripButton4;
		private global::System.Windows.Forms.StatusStrip statusStrip1;
		private global::System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
		private global::System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private global::System.Windows.Forms.ToolStripButton toolStripButton5;
		private global::System.Windows.Forms.ToolStripButton toolStripButton6;
		private global::System.Windows.Forms.ToolStripButton toolStripButton7;
		private global::System.Windows.Forms.Panel panel1;
		private global::System.Windows.Forms.GroupBox groupBox1;
		private global::System.Windows.Forms.ComboBox comboBox1;
		private global::System.Windows.Forms.Label label1;
		private global::System.Windows.Forms.Label label5;
		private global::System.Windows.Forms.Label label4;
		private global::System.Windows.Forms.Label label3;
		private global::System.Windows.Forms.Label label2;
		private global::System.Windows.Forms.NumericUpDown numericUpDown1;
		private global::System.Windows.Forms.NumericUpDown numericUpDown4;
		private global::System.Windows.Forms.NumericUpDown numericUpDown3;
		private global::System.Windows.Forms.NumericUpDown numericUpDown2;
		private global::System.Windows.Forms.Label label6;
		private global::System.Windows.Forms.Label label7;
		private global::System.Windows.Forms.Label label8;
		private global::System.Windows.Forms.NumericUpDown numericUpDown5;
		private global::System.Windows.Forms.NumericUpDown numericUpDown6;
		private global::System.Windows.Forms.NumericUpDown numericUpDown7;
		private global::System.Windows.Forms.NumericUpDown numericUpDown8;
		private global::System.Windows.Forms.NumericUpDown numericUpDown9;
		private global::System.Windows.Forms.Label label9;
		private global::System.Windows.Forms.NumericUpDown numericUpDown10;
		private global::System.Windows.Forms.Label label10;
		private global::System.Windows.Forms.Label label11;
		private global::System.Windows.Forms.ComboBox comboBox2;
		private global::System.Windows.Forms.ComboBox comboBox9;
		private global::System.Windows.Forms.Label label18;
		private global::System.Windows.Forms.ComboBox comboBox8;
		private global::System.Windows.Forms.Label label17;
		private global::System.Windows.Forms.ComboBox comboBox7;
		private global::System.Windows.Forms.Label label16;
		private global::System.Windows.Forms.ComboBox comboBox6;
		private global::System.Windows.Forms.Label label15;
		private global::System.Windows.Forms.ComboBox comboBox5;
		private global::System.Windows.Forms.Label label14;
		private global::System.Windows.Forms.ComboBox comboBox4;
		private global::System.Windows.Forms.Label label13;
		private global::System.Windows.Forms.ComboBox comboBox3;
		private global::System.Windows.Forms.Label label12;
		private global::System.Windows.Forms.ComboBox comboBox10;
		private global::System.Windows.Forms.Label label19;
		private global::System.Windows.Forms.ComboBox comboBox11;
		private global::System.Windows.Forms.Label label20;
		private global::System.Windows.Forms.ComboBox comboBox12;
		private global::System.Windows.Forms.Label label21;
		private global::System.Windows.Forms.ComboBox comboBox13;
		private global::System.Windows.Forms.Label label22;
		private global::System.Windows.Forms.ComboBox comboBox14;
		private global::System.Windows.Forms.Label label23;
		private global::System.Windows.Forms.ComboBox comboBox15;
		private global::System.Windows.Forms.Label label24;
		private global::System.Windows.Forms.ComboBox comboBox16;
		private global::System.Windows.Forms.Label label25;
		private global::System.Windows.Forms.ComboBox comboBox17;
		private global::System.Windows.Forms.Label label26;
		private global::System.Windows.Forms.CheckBox checkBox1;
		private global::System.Windows.Forms.GroupBox groupBox2;
		private global::System.Windows.Forms.ComboBox comboBox28;
		private global::System.Windows.Forms.Label label37;
		private global::System.Windows.Forms.ComboBox comboBox29;
		private global::System.Windows.Forms.Label label38;
		private global::System.Windows.Forms.ComboBox comboBox30;
		private global::System.Windows.Forms.Label label39;
		private global::System.Windows.Forms.ComboBox comboBox31;
		private global::System.Windows.Forms.Label label40;
		private global::System.Windows.Forms.ComboBox comboBox32;
		private global::System.Windows.Forms.Label label41;
		private global::System.Windows.Forms.ComboBox comboBox33;
		private global::System.Windows.Forms.Label label42;
		private global::System.Windows.Forms.NumericUpDown numericUpDown20;
		private global::System.Windows.Forms.Label label52;
		private global::System.Windows.Forms.ComboBox comboBox34;
		private global::System.Windows.Forms.NumericUpDown numericUpDown11;
		private global::System.Windows.Forms.Label label43;
		private global::System.Windows.Forms.Label label44;
		private global::System.Windows.Forms.CheckedListBox checkedListBox1;
		private global::System.Windows.Forms.NumericUpDown numericUpDown12;
		private global::System.Windows.Forms.Label label45;
		private global::System.Windows.Forms.NumericUpDown numericUpDown13;
		private global::System.Windows.Forms.Label label46;
		private global::System.Windows.Forms.NumericUpDown numericUpDown14;
		private global::System.Windows.Forms.Label label47;
		private global::System.Windows.Forms.NumericUpDown numericUpDown15;
		private global::System.Windows.Forms.Label label48;
		private global::System.Windows.Forms.Label label27;
		private global::System.Windows.Forms.GroupBox groupBox3;
		private global::System.Windows.Forms.Label label28;
		private global::System.Windows.Forms.TextBox textBox1;
		private global::System.Windows.Forms.ComboBox comboBox18;
		private global::System.Windows.Forms.GroupBox groupBox4;
		private global::System.Windows.Forms.CheckBox checkBox2;
		private global::System.Windows.Forms.Label label29;
	}
}
