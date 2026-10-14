using System;

namespace Doubledr.ItemDetail
{
	public struct checklistitem
	{
		public checklistitem(string text, int id)
		{
			this.Text = text;
			this.index = id;
		}
		public override string ToString()
		{
			return this.Text;
		}
		public string Text;
		public int index;
	}
}
