using System;
using System.Collections;

namespace Doubledr.Data
{
	internal class ListviewData
	{
		public ListviewData()
		{
			this.ListviewHeaderText.Add(new string[]
			{
				"物品代码",
				"武器名",
				"价格(G)",
				"攻击力",
				"主",
				"机",
				"兵",
				"攻击范围"
			});
			this.ListviewHeaderText.Add(new string[]
			{
				"物品代码",
				"防具名",
				"价格(G)",
				"防御力",
				"主",
				"机",
				"兵"
			});
			this.ListviewHeaderText.Add(new string[]
			{
				"物品代码",
				"道具名",
				"价格(G)"
			});
			this.ListviewHeaderText.Add(new string[]
			{
				"物品代码",
				"武器名",
				"价格(G)",
				"攻击力",
				"防御力",
				"弹数",
				"重量(T)",
				"主",
				"副",
				"SE",
				"攻击范围"
			});
			this.ListviewHeaderText.Add(new string[]
			{
				"物品代码",
				"引擎名",
				"价格(G)",
				"防御力",
				"重量(T)",
				"载重量(T)"
			});
			this.ListviewHeaderText.Add(new string[]
			{
				"物品代码",
				"底盘名",
				"价格(G)"
			});
			this.ListviewHeaderText.Add(new string[]
			{
				"物品代码",
				"Ｃ装置名",
				"价格",
				"防御",
				"重量(T)"
			});
			this.ListviewHeaderText.Add(new string[]
			{
				"怪物代码",
				"日名",
				"中文名",
				"HP",
				"攻击力",
				"防御力",
				"护甲",
				"速度",
				"命中率",
				"战斗等级",
				"经验值",
				"金钱值",
				"战利品"
			});
		}
		public string[] GetListViewHeader(menulist list)
		{
			switch (list)
			{
			case menulist.人类武器:
			case menulist.人类防具:
			case menulist.人类道具:
				return (string[])this.ListviewHeaderText[(int)list];
			case menulist.坦克主炮:
			case menulist.坦克副炮:
			case menulist.坦克SE:
				return (string[])this.ListviewHeaderText[3];
			case menulist.坦克引擎:
			case menulist.坦克底盘:
				return (string[])this.ListviewHeaderText[list - menulist.人类道具];
			case menulist.坦克道具:
				return (string[])this.ListviewHeaderText[2];
			case menulist.C装置:
				return (string[])this.ListviewHeaderText[6];
			case menulist.怪物数据:
			case menulist.赏金首资料:
				return (string[])this.ListviewHeaderText[list - menulist.坦克主炮];
			default:
				return null;
			}
		}
		public static menulist currentmenu = menulist.人类武器;
		public static int[] colmun_lenth = new int[]
		{
			8,
			7,
			3,
			11,
			11,
			11,
			6,
			3,
			3,
			5,
			13,
			3
		};
		public ArrayList ListviewHeaderText = new ArrayList();
	}
}
