namespace Doubledr.ItemDetail
{
	public partial class DatadictSelect : global::System.Windows.Forms.Form
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
			this.button2 = new global::System.Windows.Forms.Button();
			this.button1 = new global::System.Windows.Forms.Button();
			this.checkedListBox1 = new global::System.Windows.Forms.CheckedListBox();
			base.SuspendLayout();
			this.button2.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.button2.Location = new global::System.Drawing.Point(242, 283);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(75, 23);
			this.button2.TabIndex = 4;
			this.button2.Text = "取消";
			this.button2.UseVisualStyleBackColor = true;
			this.button1.Location = new global::System.Drawing.Point(161, 283);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(75, 23);
			this.button1.TabIndex = 3;
			this.button1.Text = "确定";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.checkedListBox1.CheckOnClick = true;
			this.checkedListBox1.FormattingEnabled = true;
			this.checkedListBox1.Location = new global::System.Drawing.Point(12, 12);
			this.checkedListBox1.MultiColumn = true;
			this.checkedListBox1.Name = "checkedListBox1";
			this.checkedListBox1.Size = new global::System.Drawing.Size(302, 260);
			this.checkedListBox1.TabIndex = 5;
			this.checkedListBox1.ItemCheck += new global::System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox1_ItemCheck);
			base.AcceptButton = this.button1;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 12f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.CancelButton = this.button2;
			base.ClientSize = new global::System.Drawing.Size(326, 318);
			base.Controls.Add(this.checkedListBox1);
			base.Controls.Add(this.button2);
			base.Controls.Add(this.button1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.Name = "DatadictSelect";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "DatadictSelect";
			base.Load += new global::System.EventHandler(this.DatadictSelect_Load);
			base.ResumeLayout(false);
		}
		private global::System.ComponentModel.IContainer components;
		private global::System.Windows.Forms.Button button2;
		private global::System.Windows.Forms.Button button1;
		private global::System.Windows.Forms.CheckedListBox checkedListBox1;
	}
}
