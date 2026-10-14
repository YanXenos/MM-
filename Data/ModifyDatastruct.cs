using System;

namespace Doubledr.Data
{
	public struct ModifyDatastruct
	{
		public ModifyDatastruct(long addr, byte value)
		{
			this.address = addr;
			this.newvalue = value;
		}
		public long address;
		public byte newvalue;
	}
}
