using System;
using System.Collections;
using System.IO;

namespace Doubledr.Data
{
	public class mm1data
	{
		public static bool checkrom(string filepath)
		{
			FileStream fileStream;
			try
			{
				fileStream = new FileStream(filepath, FileMode.Open, FileAccess.Read);
				if (fileStream == null)
				{
					return false;
				}
			}
			catch
			{
				return false;
			}
			BinaryReader binaryReader = new BinaryReader(fileStream);
			if (binaryReader.BaseStream.Length != 786448L)
			{
				binaryReader.Close();
				return false;
			}
			binaryReader.BaseStream.Seek(0L, SeekOrigin.Begin);
			byte[] array = binaryReader.ReadBytes(16);
			for (int i = 0; i < 16; i++)
			{
				if (!array[i].Equals(static_data.zzjb_head_data[i]))
				{
					binaryReader.Close();
					return false;
				}
			}
			binaryReader.BaseStream.Seek(140188L, SeekOrigin.Begin);
			if (binaryReader.ReadByte() != 89)
			{
				binaryReader.Close();
				return false;
			}
			binaryReader.Close();
			return true;
		}
		public mm1data(string filepath)
		{
			this.m_ErrStr = "";
			this.FilePath = filepath;
			this.ModifyDataList = new ArrayList();
			this.DataDict = new int[233];
			this.ItemOterAttr = new int[117];
			this.ItemPrice = new int[222];
			this.EngineLoader = new int[24];
			this.tank_item_weight = new int[80];
			this.humen_item = new int[64];
			this.tank_item_attack = new int[52];
			this.tank_item_define = new int[80];
			this.enemy_1 = new byte[131];
			this.enemy_HP = new int[131];
			this.enemy_addr_2 = new byte[131];
			this.enemy_attrack = new int[131];
			this.enemy_addr_3 = new byte[131];
			this.enemy_define = new int[131];
			this.enemy_jiacode = new int[15];
			this.enemy_jia = new int[15];
			this.enemy_exp = new int[131];
			this.enemy_money = new int[131];
			this.enemy_speed = new int[131];
			this.enemy_zhanlipin = new int[107];
			this.humaninit = new int[117];
			this.dipan_define = new int[16];
			this.dipan_weight = new int[16];
			this.tank_dancang = new int[8];
			this.tank_kaidong = new int[8];
			this.tank_bullet = new int[48];
			this.enemy_tongji = new int[11];
			this.Init_Data();
		}
		private bool Init_Data()
		{
			try
			{
				this.br = new BinaryReader(new FileStream(this.FilePath, FileMode.Open, FileAccess.Read, FileShare.Read));
			}
			catch (Exception ex)
			{
				this.br.Close();
				this.m_ErrStr = ex.Message;
				return false;
			}
			int[] array = new int[274];
			this.br.BaseStream.Seek(139514L, SeekOrigin.Begin);
			this.br.ReadBytes(71).CopyTo(this.DataDict, 0);
			this.br.BaseStream.Seek(-1L, SeekOrigin.Current);
			this.br.ReadBytes(274).CopyTo(array, 0);
			for (int i = 0; i < 137; i++)
			{
				int num = array[i * 2] + array[i * 2 + 1] * 256;
				this.DataDict[71 + i] = num;
			}
			this.br.ReadBytes(50).CopyTo(array, 0);
			for (int j = 0; j < 25; j++)
			{
				int num = (array[j * 2] + array[j * 2 + 1] * 256) * 10;
				this.DataDict[208 + j] = num;
			}
			this.br.ReadBytes(117).CopyTo(this.ItemOterAttr, 0);
			this.br.BaseStream.Seek(140385L, SeekOrigin.Begin);
			this.br.ReadBytes(222).CopyTo(this.ItemPrice, 0);
			this.br.BaseStream.Seek(137220L, SeekOrigin.Begin);
			this.br.ReadBytes(24).CopyTo(this.EngineLoader, 0);
			this.br.BaseStream.Seek(140108L, SeekOrigin.Begin);
			this.br.ReadBytes(80).CopyTo(this.tank_item_weight, 0);
			this.br.BaseStream.Seek(1L, SeekOrigin.Current);
			this.br.ReadBytes(64).CopyTo(this.humen_item, 0);
			this.br.ReadBytes(52).CopyTo(this.tank_item_attack, 0);
			this.br.ReadBytes(80).CopyTo(this.tank_item_define, 0);
			this.br.BaseStream.Seek(231534L, SeekOrigin.Begin);
			this.br.ReadBytes(131).CopyTo(this.enemy_1, 0);
			this.br.BaseStream.Seek(231959L, SeekOrigin.Begin);
			this.br.ReadBytes(131).CopyTo(this.enemy_HP, 0);
			this.br.BaseStream.Seek(232483L, SeekOrigin.Begin);
			this.br.ReadBytes(131).CopyTo(this.enemy_addr_2, 0);
			this.br.BaseStream.Seek(232090L, SeekOrigin.Begin);
			this.br.ReadBytes(131).CopyTo(this.enemy_attrack, 0);
			this.br.BaseStream.Seek(232614L, SeekOrigin.Begin);
			this.br.ReadBytes(131).CopyTo(this.enemy_addr_3, 0);
			this.br.BaseStream.Seek(232221L, SeekOrigin.Begin);
			this.br.ReadBytes(131).CopyTo(this.enemy_define, 0);
			this.br.BaseStream.Seek(231929L, SeekOrigin.Begin);
			this.br.ReadBytes(15).CopyTo(this.enemy_jia, 0);
			this.br.ReadBytes(15).CopyTo(this.enemy_jiacode, 0);
			this.br.BaseStream.Seek(232745L, SeekOrigin.Begin);
			this.br.ReadBytes(131).CopyTo(this.enemy_exp, 0);
			this.br.ReadBytes(131).CopyTo(this.enemy_money, 0);
			this.br.BaseStream.Seek(232352L, SeekOrigin.Begin);
			this.br.ReadBytes(131).CopyTo(this.enemy_speed, 0);
			this.br.BaseStream.Seek(140607L, SeekOrigin.Begin);
			this.br.ReadBytes(107).CopyTo(this.enemy_zhanlipin, 0);
			this.br.BaseStream.Seek(164045L, SeekOrigin.Begin);
			this.br.ReadBytes(117).CopyTo(this.humaninit, 0);
			this.br.BaseStream.Seek(139424L, SeekOrigin.Begin);
			this.br.ReadBytes(16).CopyTo(this.dipan_define, 0);
			this.br.BaseStream.Seek(164162L, SeekOrigin.Begin);
			this.br.ReadBytes(16).CopyTo(this.dipan_weight, 0);
			this.br.BaseStream.Seek(139406L, SeekOrigin.Begin);
			this.br.ReadBytes(8).CopyTo(this.tank_dancang, 0);
			this.br.BaseStream.Seek(139496L, SeekOrigin.Begin);
			this.br.ReadBytes(8).CopyTo(this.tank_kaidong, 0);
			this.br.BaseStream.Seek(139280L, SeekOrigin.Begin);
			this.br.ReadBytes(48).CopyTo(this.tank_bullet, 0);
			this.br.BaseStream.Seek(519136L, SeekOrigin.Begin);
			this.br.ReadBytes(11).CopyTo(this.enemy_tongji, 0);
			this.br.BaseStream.Seek(131088L, SeekOrigin.Begin);
			this.junhao = (int)this.br.ReadByte();
			this.br.Close();
			return true;
		}
		public string getItemPrice(int itemcode)
		{
			if (itemcode > 221)
			{
				return "没这个物品";
			}
			int num = this.ItemPrice[itemcode];
			if (num == 255)
			{
				return "无价,不可丢弃";
			}
			if (num == 254)
			{
				return "无价,可以丢弃";
			}
			return this.DataDict[num].ToString();
		}
		public void setItemPrice(int itemcode, int value)
		{
			this.ItemPrice[itemcode] = value;
			this.ModifyDataList.Add(new ModifyDatastruct(140385L + (long)itemcode, (byte)value));
		}
		public string Gethumenitem(int itemcode)
		{
			if (itemcode > 64)
			{
				return "不是人类装备";
			}
			int num = this.humen_item[itemcode - 1];
			if (num > 232)
			{
				return "没这个数值";
			}
			return this.DataDict[num].ToString();
		}
		public void sethumenitem(int itemcode, int value)
		{
			this.humen_item[itemcode - 1] = value;
			this.ModifyDataList.Add(new ModifyDatastruct(140188L + (long)itemcode, (byte)value));
		}
		public string GetTankAttack(int itemcode)
		{
			if (itemcode < 65 || itemcode > 116)
			{
				return "不是坦克武器";
			}
			int num = this.tank_item_attack[itemcode - 65];
			if (num > 232)
			{
				return "没这个数值";
			}
			return this.DataDict[num].ToString();
		}
		public void setTankAttack(int itemcode, int value)
		{
			this.tank_item_attack[itemcode - 65] = value;
			this.ModifyDataList.Add(new ModifyDatastruct(140188L + (long)itemcode, (byte)value));
		}
		public string GetTankDefine(int itemcode)
		{
			if (itemcode < 65 || itemcode > 144)
			{
				return "不是坦克装备";
			}
			int num = this.tank_item_define[itemcode - 65];
			if (num > 232)
			{
				return "没这个数值";
			}
			return this.DataDict[num].ToString();
		}
		public void setTankDefine(int itemcode, int value)
		{
			this.tank_item_define[itemcode - 65] = value;
			this.ModifyDataList.Add(new ModifyDatastruct(140240L + (long)itemcode, (byte)value));
		}
		public byte GetItemUse(int itemcode)
		{
			if (itemcode > 116)
			{
				return 0;
			}
			return Convert.ToByte(this.ItemOterAttr[itemcode]);
		}
		public void setAttackRange(int itemcode, int value)
		{
			this.ItemOterAttr[itemcode] = ((this.ItemOterAttr[itemcode] & 231) | value * 8);
			this.ModifyDataList.Add(new ModifyDatastruct((long)(139908 + itemcode), (byte)this.ItemOterAttr[itemcode]));
		}
		public void setbullets(int itemcode, int value)
		{
			this.ItemOterAttr[itemcode] = ((this.ItemOterAttr[itemcode] & 248) | value);
			this.ModifyDataList.Add(new ModifyDatastruct((long)(139908 + itemcode), (byte)this.ItemOterAttr[itemcode]));
		}
		public void setItemuse(int itemcode, int value)
		{
			this.ItemOterAttr[itemcode] = ((this.ItemOterAttr[itemcode] & 31) | value);
			this.ModifyDataList.Add(new ModifyDatastruct((long)(139908 + itemcode), (byte)this.ItemOterAttr[itemcode]));
		}
		public string GetTankItemWeight(int itemcode)
		{
			if (itemcode < 65 || itemcode > 144)
			{
				return "不是坦克装备";
			}
			int num = this.tank_item_weight[itemcode - 65];
			return ((float)num / 10f).ToString("F");
		}
		public void setTankItemWeight(int itemcode, int value)
		{
			this.tank_item_weight[itemcode - 65] = value;
			this.ModifyDataList.Add(new ModifyDatastruct(140043L + (long)itemcode, (byte)value));
		}
		public string GetmotWeight(int itemcode)
		{
			if (itemcode < 121 || itemcode > 144)
			{
				return "不是发动机";
			}
			int num = Convert.ToInt32(this.EngineLoader[itemcode - 121]);
			if (num > 232)
			{
				return "没这个数值";
			}
			return num.ToString("F");
		}
		public void setmotWeight(int itemcode, int value)
		{
			this.EngineLoader[itemcode - 121] = value;
			this.ModifyDataList.Add(new ModifyDatastruct(137099L + (long)itemcode, (byte)value));
		}
		public int Getenemy_HP(int enemyid)
		{
			int num = (int)(this.enemy_1[enemyid] & 192);
			if (num != 0)
			{
				return this.enemy_HP[enemyid];
			}
			return 4 * this.enemy_HP[enemyid];
		}
		public void setenemy_HP(int enemyid, int value)
		{
			if (value > 255)
			{
				this.enemy_1[enemyid] |=  63;
				this.enemy_HP[enemyid] = value / 4;
			}
			else
			{
				this.enemy_1[enemyid] |= 64;
                this.enemy_HP[enemyid] = value;
			}
			this.ModifyDataList.Add(new ModifyDatastruct(231534L + (long)enemyid, this.enemy_1[enemyid]));
			this.ModifyDataList.Add(new ModifyDatastruct(231959L + (long)enemyid, (byte)this.enemy_HP[enemyid]));
		}
		public int Getenemy_zhanlipin(int enemyid)
		{
			if (enemyid < 24)
			{
				return 0;
			}
			return this.enemy_zhanlipin[enemyid - 24];
		}
		public void setenemy_zhanlipin(int enemyid, int value)
		{
			if (enemyid < 24)
			{
				return;
			}
			this.enemy_zhanlipin[enemyid - 24] = value;
			this.ModifyDataList.Add(new ModifyDatastruct(140607L + (long)enemyid - 24L, (byte)this.enemy_zhanlipin[enemyid - 24]));
		}
		public int Getenemy_attrack(int enemyid)
		{
			if ((this.enemy_addr_2[enemyid] & 128) == 0)
			{
				return this.enemy_attrack[enemyid];
			}
			return 4 * this.enemy_attrack[enemyid];
		}
		public void setenemy_attrack(int enemyid, int value)
		{
			if (value > 255)
			{
				this.enemy_addr_2[enemyid] |= 128;
				this.enemy_attrack[enemyid] = value / 4;
			}
			else
			{
				this.enemy_addr_2[enemyid] |= 127;
				this.enemy_attrack[enemyid] = value;
			}
			this.ModifyDataList.Add(new ModifyDatastruct(232483L + (long)enemyid, this.enemy_addr_2[enemyid]));
			this.ModifyDataList.Add(new ModifyDatastruct(232090L + (long)enemyid, (byte)this.enemy_attrack[enemyid]));
		}
		public int Getenemy_define(int enemyid)
		{
			if ((this.enemy_addr_3[enemyid] & 128) == 0)
			{
				return this.enemy_define[enemyid];
			}
			return 4 * this.enemy_define[enemyid];
		}
        public void setenemy_define(int enemyid, int value)
        {
            if (value > 255)
            {
                this.enemy_addr_3[enemyid] |= 128;
                this.enemy_define[enemyid] = value / 4;
            }
            else
            {
                this.enemy_addr_3[enemyid] &= 127;
                this.enemy_define[enemyid] = value;
            }

            int result = this.enemy_define[enemyid];

            if (result < 0 || result > 255)
            {
                throw new ArgumentOutOfRangeException(
                    nameof(value), "转换后的数值必须在 0~255 之间");
            }

            this.ModifyDataList.Add(
                new ModifyDatastruct(232614L + enemyid, this.enemy_addr_3[enemyid]));

            this.ModifyDataList.Add(
                new ModifyDatastruct(232221L + enemyid, (byte)result));
        }
        public string Getenemy_jia(int enemyid)
		{
			for (int i = 0; i < this.enemy_jiacode.Length; i++)
			{
				if (this.enemy_jiacode[i] == enemyid)
				{
					return this.enemy_jia[i].ToString();
				}
			}
			return "";
		}
		public void setenemy_jia(int enemyid, int value)
		{
			for (int i = 0; i < this.enemy_jiacode.Length; i++)
			{
				if (this.enemy_jiacode[i] == enemyid)
				{
					this.enemy_jia[i] = value;
					this.ModifyDataList.Add(new ModifyDatastruct(231929L + (long)i, (byte)value));
					return;
				}
			}
		}
		public int Getenemy_speed(int enemyid)
		{
			return this.enemy_speed[enemyid];
		}
		public void setenemy_speed(int enemyid, int value)
		{
			this.enemy_speed[enemyid] = value;
			this.ModifyDataList.Add(new ModifyDatastruct(232352L + (long)enemyid, (byte)this.enemy_speed[enemyid]));
		}
		public int Getenemy_mingzhong(int enemyid)
		{
			return (int)(this.enemy_addr_2[enemyid] & 127);
		}
        public void setenemy_mingzhong(int enemyid, int value)
        {
            this.enemy_addr_2[enemyid] =
                (byte)((this.enemy_addr_2[enemyid] & 128) | (byte)value);

            this.ModifyDataList.Add(
                new ModifyDatastruct(232483L + (long)enemyid, this.enemy_addr_2[enemyid]));
        }
        public int Getenemy_level(int enemyid)
		{
			return (int)(this.enemy_addr_3[enemyid] & 127);
		}
        public void setenemy_level(int enemyid, int value)
        {
            this.enemy_addr_3[enemyid] =
                (byte)((this.enemy_addr_3[enemyid] & 128) | (value & 127));

            this.ModifyDataList.Add(
                new ModifyDatastruct(232614L + (long)enemyid, this.enemy_addr_3[enemyid]));
        }
        public int Getenemy_exp(int enemyid)
		{
			if ((this.enemy_1[enemyid] & 32) == 0)
			{
				return this.enemy_exp[enemyid];
			}
			return 100 * this.enemy_exp[enemyid];
		}
		public void setenemy_exp(int enemyid, int value)
		{
			if (value > 255)
			{
				this.enemy_1[enemyid] |= 32;
				this.enemy_exp[enemyid] = value / 100;
			}
			else
			{
				this.enemy_1[enemyid] |= 223;
				this.enemy_exp[enemyid] = value;
			}
			this.ModifyDataList.Add(new ModifyDatastruct(231534L + (long)enemyid, this.enemy_1[enemyid]));
			this.ModifyDataList.Add(new ModifyDatastruct(232745L + (long)enemyid, (byte)this.enemy_exp[enemyid]));
		}
		public int Getenemy_money(int enemyid)
		{
			if ((this.enemy_1[enemyid] & 16) == 0)
			{
				return this.enemy_money[enemyid];
			}
			return 100 * this.enemy_money[enemyid];
		}
		public void setenemy_money(int enemyid, int value)
		{
			if (value > 255)
			{
				this.enemy_1[enemyid] |= 16;
				this.enemy_money[enemyid] = value / 100;
			}
			else
			{
				this.enemy_1[enemyid] |= 239;
				this.enemy_money[enemyid] = value;
			}
			this.ModifyDataList.Add(new ModifyDatastruct(231534L + (long)enemyid, this.enemy_1[enemyid]));
			this.ModifyDataList.Add(new ModifyDatastruct(232876L + (long)enemyid, (byte)this.enemy_money[enemyid]));
		}
		public int Gethumen_level(int index)
		{
			return this.humaninit[33 + index];
		}
		public void sethumen_level(int index, int value)
		{
			if (value > 255)
			{
				return;
			}
			this.humaninit[33 + index] = value;
			this.ModifyDataList.Add(new ModifyDatastruct(164078L + (long)index, (byte)value));
		}
		public int Gethumen_HP(int index)
		{
			return this.humaninit[2 * index + 3] + this.humaninit[2 * index + 4] * 256;
		}
		public void sethumen_HP(int index, int value)
		{
			this.humaninit[2 * index + 3] = (value & 255);
			this.humaninit[2 * index + 4] = (value & 65280) / 256;
			this.ModifyDataList.Add(new ModifyDatastruct(164045L + (long)(2 * index) + 3L, (byte)this.humaninit[2 * index + 3]));
			this.ModifyDataList.Add(new ModifyDatastruct(164045L + (long)(2 * index) + 4L, (byte)this.humaninit[2 * index + 4]));
		}
		public int Gethumen_attrack(int index)
		{
			return this.humaninit[2 * index + 15] + this.humaninit[2 * index + 15 + 1] * 256;
		}
		public void sethumen_attrack(int index, int value)
		{
			this.humaninit[2 * index + 15] = (value & 255);
			this.humaninit[2 * index + 15 + 1] = (value & 65280) / 256;
			this.ModifyDataList.Add(new ModifyDatastruct(164045L + (long)(2 * index) + 15L, (byte)this.humaninit[2 * index + 15]));
			this.ModifyDataList.Add(new ModifyDatastruct(164045L + (long)(2 * index) + 15L + 1L, (byte)this.humaninit[2 * index + 15 + 1]));
		}
		public int Gethumen_define(int index)
		{
			return this.humaninit[2 * index + 21] + this.humaninit[2 * index + 21 + 1] * 256;
		}
		public void sethumen_define(int index, int value)
		{
			this.humaninit[2 * index + 21] = (value & 255);
			this.humaninit[2 * index + 21 + 1] = (value & 65280) / 256;
			this.ModifyDataList.Add(new ModifyDatastruct(164045L + (long)(2 * index) + 21L, (byte)this.humaninit[2 * index + 21]));
			this.ModifyDataList.Add(new ModifyDatastruct(164045L + (long)(2 * index) + 21L + 1L, (byte)this.humaninit[2 * index + 21 + 1]));
		}
		public int Gethumen_qiang(int index)
		{
			return this.humaninit[36 + index];
		}
		public void sethumen_qiang(int index, int value)
		{
			if (value > 255)
			{
				return;
			}
			this.humaninit[36 + index] = value;
			this.ModifyDataList.Add(new ModifyDatastruct(164081L + (long)index, (byte)value));
		}
		public int Gethumen_zhili(int index)
		{
			return this.humaninit[39 + index];
		}
		public void sethumen_zhili(int index, int value)
		{
			if (value > 255)
			{
				return;
			}
			this.humaninit[39 + index] = value;
			this.ModifyDataList.Add(new ModifyDatastruct(164084L + (long)index, (byte)value));
		}
		public int Gethumen_speed(int index)
		{
			return this.humaninit[42 + index];
		}
		public void sethumen_speed(int index, int value)
		{
			if (value > 255)
			{
				return;
			}
			this.humaninit[42 + index] = value;
			this.ModifyDataList.Add(new ModifyDatastruct(164087L + (long)index, (byte)value));
		}
		public int Gethumen_tili(int index)
		{
			return this.humaninit[45 + index];
		}
		public void sethumen_tili(int index, int value)
		{
			if (value > 255)
			{
				return;
			}
			this.humaninit[45 + index] = value;
			this.ModifyDataList.Add(new ModifyDatastruct(164090L + (long)index, (byte)value));
		}
		public int Gethumen_level2(int index, int off)
		{
			return this.humaninit[48 + index + 3 * off];
		}
		public void sethumen_level2(int index, int off, int value)
		{
			if (value > 255)
			{
				return;
			}
			this.humaninit[48 + index + 3 * off] = value;
			this.ModifyDataList.Add(new ModifyDatastruct(164093L + (long)index + (long)(3 * off), (byte)value));
		}
		public int Gethumen_item(int index, int off)
		{
			return this.humaninit[57 + 8 * index + off];
		}
		public void sethumen_item(int index, int off, int value)
		{
			if (value > 255)
			{
				return;
			}
			this.humaninit[57 + 8 * index + off] = value;
			this.ModifyDataList.Add(new ModifyDatastruct(164102L + (long)(8 * index) + (long)off, (byte)value));
		}
		public int Gethumen_tool(int index, int off)
		{
			return this.humaninit[81 + 8 * index + off];
		}
		public void sethumen_tool(int index, int off, int value)
		{
			if (value > 255)
			{
				return;
			}
			this.humaninit[81 + 8 * index + off] = value;
			this.ModifyDataList.Add(new ModifyDatastruct(164126L + (long)(8 * index) + (long)off, (byte)value));
		}
		public int Gethumen_money()
		{
			return this.humaninit[0] + this.humaninit[1] * 256 + this.humaninit[2] * 65536;
		}
		public void sethumen_money(int value)
		{
			this.humaninit[0] = (value & 255);
			this.humaninit[1] = (value & 65280) / 256;
			this.humaninit[2] = (value & 16711680) / 65536;
			this.ModifyDataList.Add(new ModifyDatastruct(164045L, (byte)this.humaninit[0]));
			this.ModifyDataList.Add(new ModifyDatastruct(164046L, (byte)this.humaninit[1]));
			this.ModifyDataList.Add(new ModifyDatastruct(164047L, (byte)this.humaninit[2]));
		}
		public int Gethumen_exp(int index)
		{
			return this.humaninit[3 * index + 108] + this.humaninit[3 * index + 108 + 1] * 256 + this.humaninit[3 * index + 108 + 2] * 65536;
		}
		public void sethumen_exp(int index, int value)
		{
			this.humaninit[3 * index + 108] = (value & 255);
			this.humaninit[3 * index + 108 + 1] = (value & 65280) / 256;
			this.humaninit[3 * index + 108 + 2] = (value & 16711680) / 65536;
			this.ModifyDataList.Add(new ModifyDatastruct(164045L + (long)(3 * index) + 108L, (byte)this.humaninit[3 * index + 108]));
			this.ModifyDataList.Add(new ModifyDatastruct(164045L + (long)(3 * index) + 108L + 1L, (byte)this.humaninit[3 * index + 108 + 1]));
			this.ModifyDataList.Add(new ModifyDatastruct(164045L + (long)(3 * index) + 108L + 2L, (byte)this.humaninit[3 * index + 108 + 2]));
		}
		public int Getdipan_define(int index)
		{
			return this.dipan_define[2 * index] + this.dipan_define[2 * index + 1] * 256;
		}
		public void setdipan_define(int index, int value)
		{
			this.dipan_define[2 * index] = (value & 255);
			this.dipan_define[2 * index + 1] = (value & 65280) / 256;
			this.ModifyDataList.Add(new ModifyDatastruct(139424L + (long)(2 * index), (byte)this.dipan_define[2 * index]));
			this.ModifyDataList.Add(new ModifyDatastruct(139424L + (long)(2 * index) + 1L, (byte)this.dipan_define[2 * index + 1]));
		}
		public int Getdipan_weight(int index)
		{
            int s = 0;
            int d = this.dipan_weight[2 * index];
            int ds = this.dipan_weight[2 * index + 1];
            s = d + ds * 256;
            return s;

        }
		public void setddipan_weight(int index, int value)
		{
			this.dipan_weight[2 * index] = (value & 255);
			this.dipan_weight[2 * index + 1] = (value & 65280) / 256;
			this.ModifyDataList.Add(new ModifyDatastruct(164162L + (long)(2 * index), (byte)this.dipan_weight[2 * index]));
			this.ModifyDataList.Add(new ModifyDatastruct(164162L + (long)(2 * index) + 1L, (byte)this.dipan_weight[2 * index + 1]));
		}
		public int Gettank_dancang(int index)
		{
			return this.tank_dancang[index];
		}
		public void settank_dancang(int index, int value)
		{
			if (value > 255)
			{
				return;
			}
			this.tank_dancang[index] = value;
			this.ModifyDataList.Add(new ModifyDatastruct(139406L + (long)index, (byte)value));
		}
		public int Gettank_kaidong(int index)
		{
			return this.tank_kaidong[index];
		}
		public void settank_kaidong(int index, int value)
		{
			if (value > 255)
			{
				return;
			}
			this.tank_kaidong[index] = value;
			this.ModifyDataList.Add(new ModifyDatastruct(139496L + (long)index, (byte)value));
		}
		public int Gettank_bullet(int index, int off)
		{
			return this.tank_bullet[6 * index + off];
		}
		public void settank_bullet(int index, int off, int value)
		{
			if (value > 255)
			{
				return;
			}
			this.tank_bullet[6 * index + off] = value;
			this.ModifyDataList.Add(new ModifyDatastruct(139280L + (long)(6 * index) + (long)off, (byte)value));
		}
		public int Gettongji_money(int index)
		{
			return this.DataDict[this.enemy_tongji[index]];
		}
		public void settongji_money(int index, int value)
		{
			if (value > 255)
			{
				return;
			}
			this.enemy_tongji[index] = value;
			this.ModifyDataList.Add(new ModifyDatastruct(519136L, (byte)value));
		}
		public ArrayList getEachMenuData(menulist list)
		{
			ArrayList arrayList = new ArrayList();
			switch (list)
			{
			case menulist.人类武器:
				for (int i = 35; i <= 64; i++)
				{
					string[] array = new string[ListviewData.colmun_lenth[(int)list]];
					array[0] = i.ToString();
					array[1] = static_data.item_name[i, 1].ToString();
					array[2] = this.getItemPrice(i);
					array[3] = this.Gethumenitem(i);
					byte itemUse = this.GetItemUse(i);
					for (int j = 0; j < 3; j++)
					{
						if ((itemUse & this.sdata[j]) != 0)
						{
							array[4 + j] = "√";
						}
						else
						{
							array[4 + j] = "—";
						}
					}
					array[7] = this.attackRangestr[(int)((itemUse & 24) / 8)];
					arrayList.Add(array);
				}
				break;
			case menulist.人类防具:
				for (int k = 1; k <= 34; k++)
				{
					string[] array = new string[ListviewData.colmun_lenth[(int)list]];
					array[0] = k.ToString();
					array[1] = static_data.item_name[k, 1].ToString();
					array[2] = this.getItemPrice(k);
					array[3] = this.Gethumenitem(k);
					byte itemUse2 = this.GetItemUse(k);
					for (int l = 0; l < 3; l++)
					{
						if ((itemUse2 & this.sdata[l]) != 0)
						{
							array[4 + l] = "√";
						}
						else
						{
							array[4 + l] = "—";
						}
					}
					arrayList.Add(array);
				}
				break;
			case menulist.人类道具:
				for (int m = 153; m <= 202; m++)
				{
					string[] array = new string[ListviewData.colmun_lenth[(int)list]];
					array[0] = m.ToString();
					array[1] = static_data.item_name[m, 1].ToString();
					array[2] = this.getItemPrice(m);
					arrayList.Add(array);
				}
				break;
			case menulist.坦克主炮:
				for (int n = 65; n <= 84; n++)
				{
					string[] array = new string[ListviewData.colmun_lenth[(int)list]];
					array[0] = n.ToString();
					array[1] = static_data.item_name[n, 1].ToString();
					array[2] = this.getItemPrice(n);
					array[3] = this.GetTankAttack(n);
					array[4] = this.GetTankDefine(n);
					byte itemUse3 = this.GetItemUse(n);
					array[5] = this.sdata1[(int)(itemUse3 & 7)];
					array[6] = this.GetTankItemWeight(n);
					for (int num = 0; num < 3; num++)
					{
						if ((itemUse3 & this.sdata[num]) != 0)
						{
							array[7 + num] = "√";
						}
						else
						{
							array[7 + num] = "—";
						}
					}
					array[10] = this.attackRangestr[(int)((itemUse3 & 24) / 8)];
					arrayList.Add(array);
				}
				break;
			case menulist.坦克副炮:
				for (int num2 = 101; num2 <= 116; num2++)
				{
					string[] array = new string[ListviewData.colmun_lenth[(int)list]];
					array[0] = num2.ToString();
					array[1] = static_data.item_name[num2, 1].ToString();
					array[2] = this.getItemPrice(num2);
					array[3] = this.GetTankAttack(num2);
					array[4] = this.GetTankDefine(num2);
					byte itemUse4 = this.GetItemUse(num2);
					array[5] = this.sdata1[(int)(itemUse4 & 7)];
					array[6] = this.GetTankItemWeight(num2);
					for (int num3 = 0; num3 < 3; num3++)
					{
						if ((itemUse4 & this.sdata[num3]) != 0)
						{
							array[7 + num3] = "√";
						}
						else
						{
							array[7 + num3] = "—";
						}
					}
					array[10] = this.attackRangestr[(int)((itemUse4 & 24) / 8)];
					arrayList.Add(array);
				}
				break;
			case menulist.坦克SE:
				for (int num4 = 85; num4 <= 100; num4++)
				{
					string[] array = new string[ListviewData.colmun_lenth[(int)list]];
					array[0] = num4.ToString();
					array[1] = static_data.item_name[num4, 1].ToString();
					array[2] = this.getItemPrice(num4);
					array[3] = this.GetTankAttack(num4);
					array[4] = this.GetTankDefine(num4);
					byte itemUse5 = this.GetItemUse(num4);
					array[5] = this.sdata1[(int)(itemUse5 & 7)];
					array[6] = this.GetTankItemWeight(num4);
					for (int num5 = 0; num5 < 3; num5++)
					{
						if ((itemUse5 & this.sdata[num5]) != 0)
						{
							array[7 + num5] = "√";
						}
						else
						{
							array[7 + num5] = "—";
						}
					}
					array[10] = this.attackRangestr[(int)((itemUse5 & 24) / 8)];
					arrayList.Add(array);
				}
				break;
			case menulist.坦克引擎:
				for (int num6 = 121; num6 <= 144; num6++)
				{
					string[] array = new string[ListviewData.colmun_lenth[(int)list]];
					array[0] = num6.ToString();
					array[1] = static_data.item_name[num6, 1].ToString();
					array[2] = this.getItemPrice(num6);
					array[3] = this.GetTankDefine(num6);
					array[4] = this.GetTankItemWeight(num6);
					array[5] = this.GetmotWeight(num6);
					arrayList.Add(array);
				}
				break;
			case menulist.坦克底盘:
				for (int num7 = 145; num7 <= 152; num7++)
				{
					string[] array = new string[ListviewData.colmun_lenth[(int)list]];
					array[0] = num7.ToString();
					array[1] = static_data.item_name[num7, 1].ToString();
					array[2] = this.getItemPrice(num7);
					arrayList.Add(array);
				}
				break;
			case menulist.坦克道具:
				for (int num8 = 203; num8 <= 221; num8++)
				{
					string[] array = new string[ListviewData.colmun_lenth[(int)list]];
					array[0] = num8.ToString();
					array[1] = static_data.item_name[num8, 1].ToString();
					array[2] = this.getItemPrice(num8);
					arrayList.Add(array);
				}
				break;
			case menulist.C装置:
				for (int num9 = 117; num9 <= 120; num9++)
				{
					string[] array = new string[ListviewData.colmun_lenth[(int)list]];
					array[0] = num9.ToString();
					array[1] = static_data.item_name[num9, 1].ToString();
					array[2] = this.getItemPrice(num9);
					array[3] = this.GetTankDefine(num9);
					array[4] = this.GetTankItemWeight(num9);
					arrayList.Add(array);
				}
				break;
			case menulist.怪物数据:
				for (int num10 = 0; num10 < 131; num10++)
				{
					string[] array = new string[ListviewData.colmun_lenth[(int)list]];
					array[0] = num10.ToString();
					array[1] = static_data.enemy_name[num10, 0].ToString();
					array[2] = static_data.enemy_name[num10, 1].ToString();
					array[3] = this.Getenemy_HP(num10).ToString();
					array[4] = this.Getenemy_attrack(num10).ToString();
					array[5] = this.Getenemy_define(num10).ToString();
					array[6] = this.Getenemy_jia(num10);
					array[7] = this.Getenemy_speed(num10).ToString();
					array[8] = this.Getenemy_mingzhong(num10).ToString();
					array[9] = this.Getenemy_level(num10).ToString();
					array[10] = this.Getenemy_exp(num10).ToString();
					array[11] = this.Getenemy_money(num10).ToString();
					int num11 = this.Getenemy_zhanlipin(num10);
					if (num10 < 24)
					{
						array[12] = "—";
					}
					else
					{
						array[12] = static_data.item_name[num11, 1].ToString();
					}
					arrayList.Add(array);
				}
				break;
			}
			return arrayList;
		}
		public string[] getsingleMenuData(menulist list, int index)
		{
			string[] array = new string[ListviewData.colmun_lenth[(int)list]];
			switch (list)
			{
			case menulist.人类武器:
			{
				int num = 35 + index;
				array[0] = num.ToString();
				array[1] = static_data.item_name[num, 1].ToString();
				array[2] = this.getItemPrice(num);
				array[3] = this.Gethumenitem(num);
				byte itemUse = this.GetItemUse(num);
				for (int i = 0; i < 3; i++)
				{
					if ((itemUse & this.sdata[i]) != 0)
					{
						array[4 + i] = "√";
					}
					else
					{
						array[4 + i] = "—";
					}
				}
				array[7] = this.attackRangestr[(int)((itemUse & 24) / 8)];
				break;
			}
			case menulist.人类防具:
			{
				int num = index + 1;
				array = new string[ListviewData.colmun_lenth[(int)list]];
				array[0] = num.ToString();
				array[1] = static_data.item_name[num, 1].ToString();
				array[2] = this.getItemPrice(num);
				array[3] = this.Gethumenitem(num);
				byte itemUse = this.GetItemUse(num);
				for (int j = 0; j < 3; j++)
				{
					if ((itemUse & this.sdata[j]) != 0)
					{
						array[4 + j] = "√";
					}
					else
					{
						array[4 + j] = "—";
					}
				}
				break;
			}
			case menulist.人类道具:
			{
				int num = index + 153;
				array = new string[ListviewData.colmun_lenth[(int)list]];
				array[0] = num.ToString();
				array[1] = static_data.item_name[num, 1].ToString();
				array[2] = this.getItemPrice(num);
				break;
			}
			case menulist.坦克主炮:
			{
				int num = index + 65;
				array = new string[ListviewData.colmun_lenth[(int)list]];
				array[0] = num.ToString();
				array[1] = static_data.item_name[num, 1].ToString();
				array[2] = this.getItemPrice(num);
				array[3] = this.GetTankAttack(num);
				array[4] = this.GetTankDefine(num);
				byte itemUse = this.GetItemUse(num);
				array[5] = this.sdata1[(int)(itemUse & 7)];
				array[6] = this.GetTankItemWeight(num);
				for (int k = 0; k < 3; k++)
				{
					if ((itemUse & this.sdata[k]) != 0)
					{
						array[7 + k] = "√";
					}
					else
					{
						array[7 + k] = "—";
					}
				}
				array[10] = this.attackRangestr[(int)((itemUse & 24) / 8)];
				break;
			}
			case menulist.坦克副炮:
			{
				int num = index + 101;
				array = new string[ListviewData.colmun_lenth[(int)list]];
				array[0] = num.ToString();
				array[1] = static_data.item_name[num, 1].ToString();
				array[2] = this.getItemPrice(num);
				array[3] = this.GetTankAttack(num);
				array[4] = this.GetTankDefine(num);
				byte itemUse = this.GetItemUse(num);
				array[5] = this.sdata1[(int)(itemUse & 7)];
				array[6] = this.GetTankItemWeight(num);
				for (int l = 0; l < 3; l++)
				{
					if ((itemUse & this.sdata[l]) != 0)
					{
						array[7 + l] = "√";
					}
					else
					{
						array[7 + l] = "—";
					}
				}
				array[10] = this.attackRangestr[(int)((itemUse & 24) / 8)];
				break;
			}
			case menulist.坦克SE:
			{
				int num = index + 85;
				array = new string[ListviewData.colmun_lenth[(int)list]];
				array[0] = num.ToString();
				array[1] = static_data.item_name[num, 1].ToString();
				array[2] = this.getItemPrice(num);
				array[3] = this.GetTankAttack(num);
				array[4] = this.GetTankDefine(num);
				byte itemUse = this.GetItemUse(num);
				array[5] = this.sdata1[(int)(itemUse & 7)];
				array[6] = this.GetTankItemWeight(num);
				for (int m = 0; m < 3; m++)
				{
					if ((itemUse & this.sdata[m]) != 0)
					{
						array[7 + m] = "√";
					}
					else
					{
						array[7 + m] = "—";
					}
				}
				array[10] = this.attackRangestr[(int)((itemUse & 24) / 8)];
				break;
			}
			case menulist.坦克引擎:
			{
				int num = index + 121;
				array = new string[ListviewData.colmun_lenth[(int)list]];
				array[0] = num.ToString();
				array[1] = static_data.item_name[num, 1].ToString();
				array[2] = this.getItemPrice(num);
				array[3] = this.GetTankDefine(num);
				array[4] = this.GetTankItemWeight(num);
				array[5] = this.GetmotWeight(num);
				break;
			}
			case menulist.坦克底盘:
			{
				int num = index + 145;
				array = new string[ListviewData.colmun_lenth[(int)list]];
				array[0] = num.ToString();
				array[1] = static_data.item_name[num, 1].ToString();
				array[2] = this.getItemPrice(num);
				break;
			}
			case menulist.坦克道具:
			{
				int num = index + 203;
				array = new string[ListviewData.colmun_lenth[(int)list]];
				array[0] = num.ToString();
				array[1] = static_data.item_name[num, 1].ToString();
				array[2] = this.getItemPrice(num);
				break;
			}
			case menulist.C装置:
			{
				int num = index + 117;
				array = new string[ListviewData.colmun_lenth[(int)list]];
				array[0] = num.ToString();
				array[1] = static_data.item_name[num, 1].ToString();
				array[2] = this.getItemPrice(num);
				array[3] = this.GetTankDefine(num);
				array[4] = this.GetTankItemWeight(num);
				break;
			}
			case menulist.怪物数据:
			{
				int num = index;
				array = new string[ListviewData.colmun_lenth[(int)list]];
				array[0] = num.ToString();
				array[1] = static_data.enemy_name[num, 0].ToString();
				array[2] = static_data.enemy_name[num, 1].ToString();
				array[3] = this.Getenemy_HP(num).ToString();
				array[4] = this.Getenemy_attrack(num).ToString();
				array[5] = this.Getenemy_define(num).ToString();
				array[6] = this.Getenemy_jia(num);
				array[7] = this.Getenemy_speed(num).ToString();
				array[8] = this.Getenemy_mingzhong(num).ToString();
				array[9] = this.Getenemy_level(num).ToString();
				array[10] = this.Getenemy_exp(num).ToString();
				array[11] = this.Getenemy_money(num).ToString();
				int num2 = this.Getenemy_zhanlipin(num);
				if (num < 24)
				{
					array[12] = "—";
				}
				else
				{
					array[12] = static_data.item_name[num2, 1].ToString();
				}
				break;
			}
			}
			return array;
		}
		public ArrayList ModifyDataList;
		public static bool IsOpen;
		public string FilePath;
		private BinaryReader br;
		private string m_ErrStr;
		public byte[] sdata = new byte[]
		{
			128,
			64,
			32
		};
		public string[] sdata1 = new string[]
		{
			"2",
			"4",
			"8",
			"16",
			"32",
			"48",
			"64",
			"∞"
		};
		public string[] attackRangestr = new string[]
		{
			"个",
			"组",
			"全"
		};
		public int[] DataDict;
		public int[] ItemOterAttr;
		public int[] ItemPrice;
		public int[] EngineLoader;
		public int[] tank_item_weight;
		public int[] humen_item;
		public int[] tank_item_attack;
		public int[] tank_item_define;
		public int[] humaninit;
		public int[] dipan_define;
		public int[] dipan_weight;
		public int[] tank_dancang;
		public int[] tank_kaidong;
		public int[] tank_bullet;
		public int[] enemy_tongji;
		public int junhao;
		public byte[] enemy_1;
		public int[] enemy_HP;
		public byte[] enemy_addr_2;
		public int[] enemy_attrack;
		public byte[] enemy_addr_3;
		public int[] enemy_define;
		public int[] enemy_jiacode;
		public int[] enemy_jia;
		public int[] enemy_exp;
		public int[] enemy_money;
		public int[] enemy_zhanlipin;
		public int[] enemy_speed;
	}
}
