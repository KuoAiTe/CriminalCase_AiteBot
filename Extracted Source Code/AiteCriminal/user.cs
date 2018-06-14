using Microsoft.CSharp.RuntimeBinder;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq.Expressions;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;

namespace AiteCriminal
{
	public static class user
	{
		public class Stage
		{
			public int case_stars;

			public int high_score;

			public int is_Elite;

			public int MaxScore
			{
				get
				{
					int result = 1120000;
					if (user.isCaseElite)
					{
						result = 1310000;
						if (user.stage_id == 1023)
						{
							result = 1330000;
						}
						else if (user.stage_id == 1033)
						{
							result = 1400000;
						}
					}
					else if (user.stage_id == 1023)
					{
						result = 1100000;
					}
					else if (user.stage_id == 1033)
					{
						result = 1200000;
					}
					return result;
				}
			}
		}

		[CompilerGenerated]
		private static class <get_isCurrent_case>o__SiteContainer0
		{
			public static CallSite<Func<CallSite, object, bool>> <>p__Site1;

			public static CallSite<Func<CallSite, object, int, object>> <>p__Site2;

			public static CallSite<Func<CallSite, object, object>> <>p__Site3;

			public static CallSite<Func<CallSite, object, object>> <>p__Site4;
		}

		[CompilerGenerated]
		private static class <get_available_stars>o__SiteContainer5
		{
			public static CallSite<Func<CallSite, object, int>> <>p__Site6;

			public static CallSite<Func<CallSite, object, string, object>> <>p__Site7;

			public static CallSite<Func<CallSite, object, string, object>> <>p__Site8;
		}

		[CompilerGenerated]
		private static class <set_available_stars>o__SiteContainer9
		{
			public static CallSite<Func<CallSite, object, string, int, object>> <>p__Sitea;

			public static CallSite<Func<CallSite, object, string, object>> <>p__Siteb;
		}

		[CompilerGenerated]
		private static class <CheckisElite>o__SiteContainerc
		{
			public static CallSite<Func<CallSite, object, IEnumerable>> <>p__Sited;

			public static CallSite<Func<CallSite, object, string, object>> <>p__Sitee;

			public static CallSite<Func<CallSite, object, string, object>> <>p__Sitef;

			public static CallSite<Func<CallSite, object, bool>> <>p__Site10;

			public static CallSite<Func<CallSite, object, int, object>> <>p__Site11;
		}

		[CompilerGenerated]
		private static class <isCollectMode>o__SiteContainer12
		{
			public static CallSite<Func<CallSite, object, int>> <>p__Site13;

			public static CallSite<Func<CallSite, object, string, object>> <>p__Site14;

			public static CallSite<Func<CallSite, object, string, object>> <>p__Site15;

			public static CallSite<Func<CallSite, object, string, object>> <>p__Site16;
		}

		[CompilerGenerated]
		private static class <get_level>o__SiteContainer17
		{
			public static CallSite<Func<CallSite, object, int>> <>p__Site18;

			public static CallSite<Func<CallSite, object, string, object>> <>p__Site19;

			public static CallSite<Func<CallSite, object, string, object>> <>p__Site1a;
		}

		[CompilerGenerated]
		private static class <set_level>o__SiteContainer1b
		{
			public static CallSite<Func<CallSite, object, string, int, object>> <>p__Site1c;

			public static CallSite<Func<CallSite, object, string, object>> <>p__Site1d;
		}

		[CompilerGenerated]
		private static class <get_xp>o__SiteContainer1e
		{
			public static CallSite<Func<CallSite, object, int>> <>p__Site1f;

			public static CallSite<Func<CallSite, object, object>> <>p__Site20;

			public static CallSite<Func<CallSite, object, object>> <>p__Site21;
		}

		[CompilerGenerated]
		private static class <set_xp>o__SiteContainer22
		{
			public static CallSite<Func<CallSite, object, int, object>> <>p__Site23;

			public static CallSite<Func<CallSite, object, object>> <>p__Site24;
		}

		[CompilerGenerated]
		private static class <get_food_0>o__SiteContainer25
		{
			public static CallSite<Func<CallSite, object, int>> <>p__Site26;

			public static CallSite<Func<CallSite, object, string, object>> <>p__Site27;

			public static CallSite<Func<CallSite, object, string, object>> <>p__Site28;

			public static CallSite<Func<CallSite, object, string, object>> <>p__Site29;
		}

		[CompilerGenerated]
		private static class <set_food_0>o__SiteContainer2a
		{
			public static CallSite<Func<CallSite, object, string, int, object>> <>p__Site2b;

			public static CallSite<Func<CallSite, object, string, object>> <>p__Site2c;

			public static CallSite<Func<CallSite, object, string, object>> <>p__Site2d;
		}

		[CompilerGenerated]
		private static class <get_food_1>o__SiteContainer2e
		{
			public static CallSite<Func<CallSite, object, int>> <>p__Site2f;

			public static CallSite<Func<CallSite, object, string, object>> <>p__Site30;

			public static CallSite<Func<CallSite, object, string, object>> <>p__Site31;

			public static CallSite<Func<CallSite, object, string, object>> <>p__Site32;
		}

		[CompilerGenerated]
		private static class <set_food_1>o__SiteContainer33
		{
			public static CallSite<Func<CallSite, object, string, int, object>> <>p__Site34;

			public static CallSite<Func<CallSite, object, string, object>> <>p__Site35;

			public static CallSite<Func<CallSite, object, string, object>> <>p__Site36;
		}

		[CompilerGenerated]
		private static class <get_food_2>o__SiteContainer37
		{
			public static CallSite<Func<CallSite, object, int>> <>p__Site38;

			public static CallSite<Func<CallSite, object, string, object>> <>p__Site39;

			public static CallSite<Func<CallSite, object, string, object>> <>p__Site3a;

			public static CallSite<Func<CallSite, object, string, object>> <>p__Site3b;
		}

		[CompilerGenerated]
		private static class <set_food_2>o__SiteContainer3c
		{
			public static CallSite<Func<CallSite, object, string, int, object>> <>p__Site3d;

			public static CallSite<Func<CallSite, object, string, object>> <>p__Site3e;

			public static CallSite<Func<CallSite, object, string, object>> <>p__Site3f;
		}

		[CompilerGenerated]
		private static class <get_coins>o__SiteContainer40
		{
			public static CallSite<Func<CallSite, object, int>> <>p__Site41;

			public static CallSite<Func<CallSite, object, object>> <>p__Site42;

			public static CallSite<Func<CallSite, object, object>> <>p__Site43;
		}

		[CompilerGenerated]
		private static class <set_coins>o__SiteContainer44
		{
			public static CallSite<Func<CallSite, object, int, object>> <>p__Site45;

			public static CallSite<Func<CallSite, object, object>> <>p__Site46;
		}

		[CompilerGenerated]
		private static class <get_energy>o__SiteContainer47
		{
			public static CallSite<Func<CallSite, object, int>> <>p__Site48;

			public static CallSite<Func<CallSite, object, object>> <>p__Site49;

			public static CallSite<Func<CallSite, object, object>> <>p__Site4a;
		}

		[CompilerGenerated]
		private static class <set_energy>o__SiteContainer4b
		{
			public static CallSite<Func<CallSite, object, int, object>> <>p__Site4c;

			public static CallSite<Func<CallSite, object, object>> <>p__Site4d;
		}

		[CompilerGenerated]
		private static class <Medal>o__SiteContainer4e
		{
			public static CallSite<Func<CallSite, object, int>> <>p__Site4f;

			public static CallSite<Func<CallSite, object, string, object>> <>p__Site50;

			public static CallSite<Func<CallSite, object, string, object>> <>p__Site51;

			public static CallSite<Func<CallSite, object, string, object>> <>p__Site52;
		}

		[CompilerGenerated]
		private static class <Elite_Medal>o__SiteContainer53
		{
			public static CallSite<Func<CallSite, object, int>> <>p__Site54;

			public static CallSite<Func<CallSite, object, string, object>> <>p__Site55;

			public static CallSite<Func<CallSite, object, string, object>> <>p__Site56;

			public static CallSite<Func<CallSite, object, string, object>> <>p__Site57;
		}

		[CompilerGenerated]
		private static class <get_start_time>o__SiteContainer58
		{
			public static CallSite<Func<CallSite, object, int>> <>p__Site59;

			public static CallSite<Func<CallSite, object, object>> <>p__Site5a;

			public static CallSite<Func<CallSite, object, object>> <>p__Site5b;
		}

		public static int teammate_index = -1;

		public static bool Loop_USE_TEAMMTE = false;

		public static bool Get_Report = true;

		public static int current_season = 1;

		private static string Last1 = string.Empty;

		private static string Last2 = string.Empty;

		private static string Last3 = string.Empty;

		private static string Last4 = string.Empty;

		private static string Last5 = string.Empty;

		private static string Last6 = string.Empty;

		public static bool isAcceptGift = false;

		public static bool Log_Report = true;

		public static bool Get_Energy2 = true;

		public static bool Log_Energy2 = true;

		public static bool Get_Energy1 = true;

		public static bool Log_Energy1 = true;

		public static bool Get_Card = true;

		public static bool Log_Card = true;

		public static bool isRunning = false;

		public static int card_count = 0;

		public static bool isAutoPlay = false;

		public static Dictionary<string, int> pet_xp = new Dictionary<string, int>();

		public static Dictionary<string, string> pet_name = new Dictionary<string, string>
		{
			{
				"1",
				"德國牧羊犬"
			},
			{
				"2",
				"查理士王小獵犬"
			},
			{
				"3",
				"黃金獵犬"
			},
			{
				"4",
				"拳師犬"
			},
			{
				"5",
				"秋田犬"
			},
			{
				"6",
				"巴哥犬"
			},
			{
				"7",
				"吉娃娃"
			},
			{
				"8",
				"牧羊犬"
			},
			{
				"9",
				"大麥町"
			},
			{
				"10",
				"傑克羅素梗"
			},
			{
				"11",
				"聖伯納"
			},
			{
				"12",
				"哈士奇"
			},
			{
				"13",
				"老虎"
			},
			{
				"14",
				"熊貓"
			},
			{
				"15",
				"機器狗"
			},
			{
				"16",
				"猴子"
			},
			{
				"17",
				"紅熊貓"
			},
			{
				"18",
				"貓"
			},
			{
				"19",
				"海獅"
			},
			{
				"20",
				"海豚"
			},
			{
				"21",
				"鵜鶘"
			},
			{
				"22",
				"貓頭鷹"
			},
			{
				"23",
				"浣熊"
			},
			{
				"24",
				"短吻鱷"
			},
			{
				"25",
				"松鼠"
			},
			{
				"26",
				"狐狸"
			},
			{
				"27",
				"兔子"
			},
			{
				"28",
				"熊"
			},
			{
				"29",
				"小狐狸"
			},
			{
				"30",
				"獅子"
			},
			{
				"31",
				"山羊"
			},
			{
				"32",
				"機器貓"
			},
			{
				"33",
				"黑猩猩"
			},
			{
				"34",
				"狼"
			},
			{
				"35",
				"鼠"
			},
			{
				"36",
				"巴吉度獵犬"
			},
			{
				"37",
				"駱駝"
			},
			{
				"38",
				"長頸鹿"
			},
			{
				"39",
				"豹"
			},
			{
				"40",
				"大象"
			},
			{
				"41",
				"鶴"
			},
			{
				"42",
				"龍"
			},
			{
				"43",
				"鴨嘴獸"
			},
			{
				"44",
				"袋鼠"
			},
			{
				"45",
				"無尾熊"
			},
			{
				"46",
				"鸚鵡"
			},
			{
				"47",
				"樹懶"
			},
			{
				"48",
				"大羊駝"
			},
			{
				"49",
				"老鷹"
			},
			{
				"50",
				"緬因貓"
			},
			{
				"51",
				"熊"
			}
		};

		public static Dictionary<int, string> case_name = new Dictionary<int, string>
		{
			{
				1,
				"ROSA WOLF死亡之謎"
			},
			{
				2,
				"陳屍花園中"
			},
			{
				3,
				"兇殘屠夫犯罪現場"
			},
			{
				4,
				"船廠兇案犯罪現場"
			},
			{
				5,
				"俄國問題"
			},
			{
				6,
				"好警察，沒命的警察"
			},
			{
				7,
				"十字架之刑"
			},
			{
				8,
				"美麗已是過去式"
			},
			{
				9,
				"熱火煉獄"
			},
			{
				10,
				"刀鋒下的秘密"
			},
			{
				11,
				"龍潭虎穴"
			},
			{
				12,
				"交易所血案"
			},
			{
				13,
				"Grimsborough炸彈警告"
			},
			{
				14,
				"時尚的犧牲者"
			},
			{
				15,
				"家族血緣"
			},
			{
				16,
				"死亡之吻"
			},
			{
				17,
				"最後的晚餐"
			},
			{
				18,
				"暗夜殺手"
			},
			{
				19,
				"無辜的迷途羔羊"
			},
			{
				20,
				"致命遊戲"
			},
			{
				21,
				"秘密實驗"
			},
			{
				22,
				"求生或求死"
			},
			{
				23,
				"最後的旅程"
			},
			{
				24,
				"兇手剖析"
			},
			{
				25,
				"Grimsborough 的亡魂"
			},
			{
				26,
				"召喚儀式"
			},
			{
				27,
				"湖泊的新娘"
			},
			{
				28,
				"鬧鬼的榆木莊園"
			},
			{
				29,
				"無火不起煙"
			},
			{
				30,
				"Wollcrafts 的怪物"
			},
			{
				31,
				"狗咬狗"
			},
			{
				32,
				"校園兇殺案"
			},
			{
				33,
				"致命溫柔"
			},
			{
				34,
				"死亡比賽"
			},
			{
				35,
				"走投無路"
			},
			{
				36,
				"惡魔的遊樂場"
			},
			{
				37,
				"死神與怪人"
			},
			{
				38,
				"春假慘案"
			},
			{
				39,
				"死亡標記"
			},
			{
				40,
				"小學兇殺"
			},
			{
				41,
				"墨跡死神"
			},
			{
				42,
				"血與榮耀"
			},
			{
				43,
				"怪奇水域"
			},
			{
				44,
				"死亡氣息"
			},
			{
				45,
				"美人命薄"
			},
			{
				46,
				"亡命揮桿"
			},
			{
				47,
				"婚禮與葬禮"
			},
			{
				48,
				"紅顏多薄命"
			},
			{
				49,
				"飛來橫禍"
			},
			{
				50,
				"舞台春秋"
			},
			{
				51,
				"一切到此為止"
			},
			{
				52,
				"勇氣新世界"
			},
			{
				53,
				"掩埋殺意"
			},
			{
				54,
				"渲染事實"
			},
			{
				55,
				"塵歸塵"
			},
			{
				56,
				"腥風血雨即將興起"
			},
			{
				201,
				"鯊魚攻擊"
			},
			{
				202,
				"絕命飛輪"
			},
			{
				203,
				"水下殺機"
			},
			{
				204,
				"玩命對抗"
			},
			{
				205,
				"寒冰女王"
			},
			{
				206,
				"BAYOU 之血"
			},
			{
				207,
				"囊中之物"
			},
			{
				208,
				"萬惡之源"
			},
			{
				209,
				"在空想中死亡"
			},
			{
				210,
				"扭曲的真相"
			},
			{
				211,
				"無心的屍體"
			},
			{
				212,
				"報應"
			},
			{
				213,
				"東方的承諾"
			},
			{
				214,
				"懦弱無能"
			},
			{
				215,
				"死亡迴旋"
			},
			{
				216,
				"殺人時刻"
			},
			{
				217,
				"秘密"
			},
			{
				218,
				"風暴過後"
			},
			{
				219,
				"烏雲密布引殺機"
			},
			{
				220,
				"開放性傷口"
			},
			{
				221,
				"Thunderdome體育館中的秘密"
			},
			{
				222,
				"老鼠與人"
			},
			{
				223,
				"暴風眼"
			},
			{
				224,
				"命懸一線"
			}
		};

		public static int count = 0;

		public static int stickers_pack_count = 0;

		private static string _id;

		private static string _signature;

		private static int _case_id = 1;

		private static int _scene_id = 0;

		public static int _score = 0;

		private static int _time_spent = 10;

		public static Dictionary<int, user.Stage> stage = new Dictionary<int, user.Stage>();

		private static object lockMe = new object();

		[Dynamic]
		public static dynamic data;

		[Dynamic]
		public static dynamic StageData;

		[Dynamic]
		public static dynamic StartData;

		[Dynamic]
		public static dynamic EndData;

		public static List<friends> FriendList = new List<friends>();

		public static List<friends> GiftFriendList = new List<friends>();

		public static CookieContainer logincookie = new CookieContainer();

		public static string Last_Message
		{
			get
			{
				return string.Concat(new string[]
				{
					user.Last6,
					"\r\n",
					user.Last5,
					"\r\n",
					user.Last4,
					"\r\n",
					user.Last3,
					"\r\n",
					user.Last2,
					"\r\n",
					user.Last1
				});
			}
			set
			{
				user.Last6 = user.Last5;
				user.Last5 = user.Last4;
				user.Last4 = user.Last3;
				user.Last3 = user.Last2;
				user.Last2 = user.Last1;
				user.Last1 = value;
			}
		}

		public static bool isCurrent_case
		{
			get
			{
				if (user.<get_isCurrent_case>o__SiteContainer0.<>p__Site1 == null)
				{
					user.<get_isCurrent_case>o__SiteContainer0.<>p__Site1 = CallSite<Func<CallSite, object, bool>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.None, typeof(bool), typeof(user)));
				}
				Func<CallSite, object, bool> arg_12F_0 = user.<get_isCurrent_case>o__SiteContainer0.<>p__Site1.Target;
				CallSite arg_12F_1 = user.<get_isCurrent_case>o__SiteContainer0.<>p__Site1;
				if (user.<get_isCurrent_case>o__SiteContainer0.<>p__Site2 == null)
				{
					user.<get_isCurrent_case>o__SiteContainer0.<>p__Site2 = CallSite<Func<CallSite, object, int, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Equal, typeof(user), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
					}));
				}
				Func<CallSite, object, int, object> arg_12A_0 = user.<get_isCurrent_case>o__SiteContainer0.<>p__Site2.Target;
				CallSite arg_12A_1 = user.<get_isCurrent_case>o__SiteContainer0.<>p__Site2;
				if (user.<get_isCurrent_case>o__SiteContainer0.<>p__Site3 == null)
				{
					user.<get_isCurrent_case>o__SiteContainer0.<>p__Site3 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "current_case", typeof(user), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, object, object> arg_120_0 = user.<get_isCurrent_case>o__SiteContainer0.<>p__Site3.Target;
				CallSite arg_120_1 = user.<get_isCurrent_case>o__SiteContainer0.<>p__Site3;
				if (user.<get_isCurrent_case>o__SiteContainer0.<>p__Site4 == null)
				{
					user.<get_isCurrent_case>o__SiteContainer0.<>p__Site4 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "response", typeof(user), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				return arg_12F_0(arg_12F_1, arg_12A_0(arg_12A_1, arg_120_0(arg_120_1, user.<get_isCurrent_case>o__SiteContainer0.<>p__Site4.Target(user.<get_isCurrent_case>o__SiteContainer0.<>p__Site4, user.StageData)), user.case_id));
			}
		}

		public static string Version
		{
			get
			{
				return "V" + Assembly.GetExecutingAssembly().GetName().Version;
			}
		}

		public static int available_stars
		{
			get
			{
				int result;
				try
				{
					if (user.<get_available_stars>o__SiteContainer5.<>p__Site6 == null)
					{
						user.<get_available_stars>o__SiteContainer5.<>p__Site6 = CallSite<Func<CallSite, object, int>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.None, typeof(int), typeof(user)));
					}
					Func<CallSite, object, int> arg_EB_0 = user.<get_available_stars>o__SiteContainer5.<>p__Site6.Target;
					CallSite arg_EB_1 = user.<get_available_stars>o__SiteContainer5.<>p__Site6;
					if (user.<get_available_stars>o__SiteContainer5.<>p__Site7 == null)
					{
						user.<get_available_stars>o__SiteContainer5.<>p__Site7 = CallSite<Func<CallSite, object, string, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetIndex(CSharpBinderFlags.None, typeof(user), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					Func<CallSite, object, string, object> arg_E6_0 = user.<get_available_stars>o__SiteContainer5.<>p__Site7.Target;
					CallSite arg_E6_1 = user.<get_available_stars>o__SiteContainer5.<>p__Site7;
					if (user.<get_available_stars>o__SiteContainer5.<>p__Site8 == null)
					{
						user.<get_available_stars>o__SiteContainer5.<>p__Site8 = CallSite<Func<CallSite, object, string, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetIndex(CSharpBinderFlags.None, typeof(user), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					result = arg_EB_0(arg_EB_1, arg_E6_0(arg_E6_1, user.<get_available_stars>o__SiteContainer5.<>p__Site8.Target(user.<get_available_stars>o__SiteContainer5.<>p__Site8, user.StageData, "response"), "available_stars"));
				}
				catch
				{
					result = 0;
				}
				return result;
			}
			set
			{
				try
				{
					if (user.<set_available_stars>o__SiteContainer9.<>p__Sitea == null)
					{
						user.<set_available_stars>o__SiteContainer9.<>p__Sitea = CallSite<Func<CallSite, object, string, int, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetIndex(CSharpBinderFlags.None, typeof(user), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
						}));
					}
					Func<CallSite, object, string, int, object> arg_B7_0 = user.<set_available_stars>o__SiteContainer9.<>p__Sitea.Target;
					CallSite arg_B7_1 = user.<set_available_stars>o__SiteContainer9.<>p__Sitea;
					if (user.<set_available_stars>o__SiteContainer9.<>p__Siteb == null)
					{
						user.<set_available_stars>o__SiteContainer9.<>p__Siteb = CallSite<Func<CallSite, object, string, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetIndex(CSharpBinderFlags.None, typeof(user), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					arg_B7_0(arg_B7_1, user.<set_available_stars>o__SiteContainer9.<>p__Siteb.Target(user.<set_available_stars>o__SiteContainer9.<>p__Siteb, user.StageData, "response"), "available_stars", value);
				}
				catch
				{
				}
			}
		}

		public static int level
		{
			get
			{
				if (user.<get_level>o__SiteContainer17.<>p__Site18 == null)
				{
					user.<get_level>o__SiteContainer17.<>p__Site18 = CallSite<Func<CallSite, object, int>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.None, typeof(int), typeof(user)));
				}
				Func<CallSite, object, int> arg_EB_0 = user.<get_level>o__SiteContainer17.<>p__Site18.Target;
				CallSite arg_EB_1 = user.<get_level>o__SiteContainer17.<>p__Site18;
				if (user.<get_level>o__SiteContainer17.<>p__Site19 == null)
				{
					user.<get_level>o__SiteContainer17.<>p__Site19 = CallSite<Func<CallSite, object, string, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetIndex(CSharpBinderFlags.None, typeof(user), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				Func<CallSite, object, string, object> arg_E6_0 = user.<get_level>o__SiteContainer17.<>p__Site19.Target;
				CallSite arg_E6_1 = user.<get_level>o__SiteContainer17.<>p__Site19;
				if (user.<get_level>o__SiteContainer17.<>p__Site1a == null)
				{
					user.<get_level>o__SiteContainer17.<>p__Site1a = CallSite<Func<CallSite, object, string, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetIndex(CSharpBinderFlags.None, typeof(user), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				return arg_EB_0(arg_EB_1, arg_E6_0(arg_E6_1, user.<get_level>o__SiteContainer17.<>p__Site1a.Target(user.<get_level>o__SiteContainer17.<>p__Site1a, user.data, "response"), "level"));
			}
			set
			{
				if (user.<set_level>o__SiteContainer1b.<>p__Site1c == null)
				{
					user.<set_level>o__SiteContainer1b.<>p__Site1c = CallSite<Func<CallSite, object, string, int, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetIndex(CSharpBinderFlags.None, typeof(user), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
					}));
				}
				Func<CallSite, object, string, int, object> arg_B7_0 = user.<set_level>o__SiteContainer1b.<>p__Site1c.Target;
				CallSite arg_B7_1 = user.<set_level>o__SiteContainer1b.<>p__Site1c;
				if (user.<set_level>o__SiteContainer1b.<>p__Site1d == null)
				{
					user.<set_level>o__SiteContainer1b.<>p__Site1d = CallSite<Func<CallSite, object, string, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetIndex(CSharpBinderFlags.None, typeof(user), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				arg_B7_0(arg_B7_1, user.<set_level>o__SiteContainer1b.<>p__Site1d.Target(user.<set_level>o__SiteContainer1b.<>p__Site1d, user.data, "response"), "level", value);
			}
		}

		public static int xp
		{
			get
			{
				if (user.<get_xp>o__SiteContainer1e.<>p__Site1f == null)
				{
					user.<get_xp>o__SiteContainer1e.<>p__Site1f = CallSite<Func<CallSite, object, int>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.None, typeof(int), typeof(user)));
				}
				Func<CallSite, object, int> arg_D7_0 = user.<get_xp>o__SiteContainer1e.<>p__Site1f.Target;
				CallSite arg_D7_1 = user.<get_xp>o__SiteContainer1e.<>p__Site1f;
				if (user.<get_xp>o__SiteContainer1e.<>p__Site20 == null)
				{
					user.<get_xp>o__SiteContainer1e.<>p__Site20 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "xp", typeof(user), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, object, object> arg_D2_0 = user.<get_xp>o__SiteContainer1e.<>p__Site20.Target;
				CallSite arg_D2_1 = user.<get_xp>o__SiteContainer1e.<>p__Site20;
				if (user.<get_xp>o__SiteContainer1e.<>p__Site21 == null)
				{
					user.<get_xp>o__SiteContainer1e.<>p__Site21 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "response", typeof(user), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				return arg_D7_0(arg_D7_1, arg_D2_0(arg_D2_1, user.<get_xp>o__SiteContainer1e.<>p__Site21.Target(user.<get_xp>o__SiteContainer1e.<>p__Site21, user.data)));
			}
			set
			{
				if (user.<set_xp>o__SiteContainer22.<>p__Site23 == null)
				{
					user.<set_xp>o__SiteContainer22.<>p__Site23 = CallSite<Func<CallSite, object, int, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "xp", typeof(user), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
					}));
				}
				Func<CallSite, object, int, object> arg_A3_0 = user.<set_xp>o__SiteContainer22.<>p__Site23.Target;
				CallSite arg_A3_1 = user.<set_xp>o__SiteContainer22.<>p__Site23;
				if (user.<set_xp>o__SiteContainer22.<>p__Site24 == null)
				{
					user.<set_xp>o__SiteContainer22.<>p__Site24 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "response", typeof(user), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				arg_A3_0(arg_A3_1, user.<set_xp>o__SiteContainer22.<>p__Site24.Target(user.<set_xp>o__SiteContainer22.<>p__Site24, user.data), value);
			}
		}

		public static int food_0
		{
			get
			{
				int result;
				try
				{
					if (user.<get_food_0>o__SiteContainer25.<>p__Site26 == null)
					{
						user.<get_food_0>o__SiteContainer25.<>p__Site26 = CallSite<Func<CallSite, object, int>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.None, typeof(int), typeof(user)));
					}
					Func<CallSite, object, int> arg_141_0 = user.<get_food_0>o__SiteContainer25.<>p__Site26.Target;
					CallSite arg_141_1 = user.<get_food_0>o__SiteContainer25.<>p__Site26;
					if (user.<get_food_0>o__SiteContainer25.<>p__Site27 == null)
					{
						user.<get_food_0>o__SiteContainer25.<>p__Site27 = CallSite<Func<CallSite, object, string, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetIndex(CSharpBinderFlags.None, typeof(user), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					Func<CallSite, object, string, object> arg_13C_0 = user.<get_food_0>o__SiteContainer25.<>p__Site27.Target;
					CallSite arg_13C_1 = user.<get_food_0>o__SiteContainer25.<>p__Site27;
					if (user.<get_food_0>o__SiteContainer25.<>p__Site28 == null)
					{
						user.<get_food_0>o__SiteContainer25.<>p__Site28 = CallSite<Func<CallSite, object, string, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetIndex(CSharpBinderFlags.None, typeof(user), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					Func<CallSite, object, string, object> arg_132_0 = user.<get_food_0>o__SiteContainer25.<>p__Site28.Target;
					CallSite arg_132_1 = user.<get_food_0>o__SiteContainer25.<>p__Site28;
					if (user.<get_food_0>o__SiteContainer25.<>p__Site29 == null)
					{
						user.<get_food_0>o__SiteContainer25.<>p__Site29 = CallSite<Func<CallSite, object, string, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetIndex(CSharpBinderFlags.None, typeof(user), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					result = arg_141_0(arg_141_1, arg_13C_0(arg_13C_1, arg_132_0(arg_132_1, user.<get_food_0>o__SiteContainer25.<>p__Site29.Target(user.<get_food_0>o__SiteContainer25.<>p__Site29, user.data, "response"), "inventory"), "food_0"));
				}
				catch
				{
					result = 0;
				}
				return result;
			}
			set
			{
				if (user.<set_food_0>o__SiteContainer2a.<>p__Site2b == null)
				{
					user.<set_food_0>o__SiteContainer2a.<>p__Site2b = CallSite<Func<CallSite, object, string, int, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetIndex(CSharpBinderFlags.None, typeof(user), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
					}));
				}
				Func<CallSite, object, string, int, object> arg_10D_0 = user.<set_food_0>o__SiteContainer2a.<>p__Site2b.Target;
				CallSite arg_10D_1 = user.<set_food_0>o__SiteContainer2a.<>p__Site2b;
				if (user.<set_food_0>o__SiteContainer2a.<>p__Site2c == null)
				{
					user.<set_food_0>o__SiteContainer2a.<>p__Site2c = CallSite<Func<CallSite, object, string, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetIndex(CSharpBinderFlags.None, typeof(user), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				Func<CallSite, object, string, object> arg_102_0 = user.<set_food_0>o__SiteContainer2a.<>p__Site2c.Target;
				CallSite arg_102_1 = user.<set_food_0>o__SiteContainer2a.<>p__Site2c;
				if (user.<set_food_0>o__SiteContainer2a.<>p__Site2d == null)
				{
					user.<set_food_0>o__SiteContainer2a.<>p__Site2d = CallSite<Func<CallSite, object, string, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetIndex(CSharpBinderFlags.None, typeof(user), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				arg_10D_0(arg_10D_1, arg_102_0(arg_102_1, user.<set_food_0>o__SiteContainer2a.<>p__Site2d.Target(user.<set_food_0>o__SiteContainer2a.<>p__Site2d, user.data, "response"), "inventory"), "food_0", value);
			}
		}

		public static int food_1
		{
			get
			{
				int result;
				try
				{
					if (user.<get_food_1>o__SiteContainer2e.<>p__Site2f == null)
					{
						user.<get_food_1>o__SiteContainer2e.<>p__Site2f = CallSite<Func<CallSite, object, int>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.None, typeof(int), typeof(user)));
					}
					Func<CallSite, object, int> arg_141_0 = user.<get_food_1>o__SiteContainer2e.<>p__Site2f.Target;
					CallSite arg_141_1 = user.<get_food_1>o__SiteContainer2e.<>p__Site2f;
					if (user.<get_food_1>o__SiteContainer2e.<>p__Site30 == null)
					{
						user.<get_food_1>o__SiteContainer2e.<>p__Site30 = CallSite<Func<CallSite, object, string, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetIndex(CSharpBinderFlags.None, typeof(user), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					Func<CallSite, object, string, object> arg_13C_0 = user.<get_food_1>o__SiteContainer2e.<>p__Site30.Target;
					CallSite arg_13C_1 = user.<get_food_1>o__SiteContainer2e.<>p__Site30;
					if (user.<get_food_1>o__SiteContainer2e.<>p__Site31 == null)
					{
						user.<get_food_1>o__SiteContainer2e.<>p__Site31 = CallSite<Func<CallSite, object, string, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetIndex(CSharpBinderFlags.None, typeof(user), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					Func<CallSite, object, string, object> arg_132_0 = user.<get_food_1>o__SiteContainer2e.<>p__Site31.Target;
					CallSite arg_132_1 = user.<get_food_1>o__SiteContainer2e.<>p__Site31;
					if (user.<get_food_1>o__SiteContainer2e.<>p__Site32 == null)
					{
						user.<get_food_1>o__SiteContainer2e.<>p__Site32 = CallSite<Func<CallSite, object, string, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetIndex(CSharpBinderFlags.None, typeof(user), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					result = arg_141_0(arg_141_1, arg_13C_0(arg_13C_1, arg_132_0(arg_132_1, user.<get_food_1>o__SiteContainer2e.<>p__Site32.Target(user.<get_food_1>o__SiteContainer2e.<>p__Site32, user.data, "response"), "inventory"), "food_1"));
				}
				catch
				{
					result = 0;
				}
				return result;
			}
			set
			{
				if (user.<set_food_1>o__SiteContainer33.<>p__Site34 == null)
				{
					user.<set_food_1>o__SiteContainer33.<>p__Site34 = CallSite<Func<CallSite, object, string, int, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetIndex(CSharpBinderFlags.None, typeof(user), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
					}));
				}
				Func<CallSite, object, string, int, object> arg_10D_0 = user.<set_food_1>o__SiteContainer33.<>p__Site34.Target;
				CallSite arg_10D_1 = user.<set_food_1>o__SiteContainer33.<>p__Site34;
				if (user.<set_food_1>o__SiteContainer33.<>p__Site35 == null)
				{
					user.<set_food_1>o__SiteContainer33.<>p__Site35 = CallSite<Func<CallSite, object, string, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetIndex(CSharpBinderFlags.None, typeof(user), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				Func<CallSite, object, string, object> arg_102_0 = user.<set_food_1>o__SiteContainer33.<>p__Site35.Target;
				CallSite arg_102_1 = user.<set_food_1>o__SiteContainer33.<>p__Site35;
				if (user.<set_food_1>o__SiteContainer33.<>p__Site36 == null)
				{
					user.<set_food_1>o__SiteContainer33.<>p__Site36 = CallSite<Func<CallSite, object, string, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetIndex(CSharpBinderFlags.None, typeof(user), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				arg_10D_0(arg_10D_1, arg_102_0(arg_102_1, user.<set_food_1>o__SiteContainer33.<>p__Site36.Target(user.<set_food_1>o__SiteContainer33.<>p__Site36, user.data, "response"), "inventory"), "food_1", value);
			}
		}

		public static int food_2
		{
			get
			{
				int result;
				try
				{
					if (user.<get_food_2>o__SiteContainer37.<>p__Site38 == null)
					{
						user.<get_food_2>o__SiteContainer37.<>p__Site38 = CallSite<Func<CallSite, object, int>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.None, typeof(int), typeof(user)));
					}
					Func<CallSite, object, int> arg_141_0 = user.<get_food_2>o__SiteContainer37.<>p__Site38.Target;
					CallSite arg_141_1 = user.<get_food_2>o__SiteContainer37.<>p__Site38;
					if (user.<get_food_2>o__SiteContainer37.<>p__Site39 == null)
					{
						user.<get_food_2>o__SiteContainer37.<>p__Site39 = CallSite<Func<CallSite, object, string, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetIndex(CSharpBinderFlags.None, typeof(user), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					Func<CallSite, object, string, object> arg_13C_0 = user.<get_food_2>o__SiteContainer37.<>p__Site39.Target;
					CallSite arg_13C_1 = user.<get_food_2>o__SiteContainer37.<>p__Site39;
					if (user.<get_food_2>o__SiteContainer37.<>p__Site3a == null)
					{
						user.<get_food_2>o__SiteContainer37.<>p__Site3a = CallSite<Func<CallSite, object, string, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetIndex(CSharpBinderFlags.None, typeof(user), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					Func<CallSite, object, string, object> arg_132_0 = user.<get_food_2>o__SiteContainer37.<>p__Site3a.Target;
					CallSite arg_132_1 = user.<get_food_2>o__SiteContainer37.<>p__Site3a;
					if (user.<get_food_2>o__SiteContainer37.<>p__Site3b == null)
					{
						user.<get_food_2>o__SiteContainer37.<>p__Site3b = CallSite<Func<CallSite, object, string, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetIndex(CSharpBinderFlags.None, typeof(user), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					result = arg_141_0(arg_141_1, arg_13C_0(arg_13C_1, arg_132_0(arg_132_1, user.<get_food_2>o__SiteContainer37.<>p__Site3b.Target(user.<get_food_2>o__SiteContainer37.<>p__Site3b, user.data, "response"), "inventory"), "food_2"));
				}
				catch
				{
					result = 0;
				}
				return result;
			}
			set
			{
				if (user.<set_food_2>o__SiteContainer3c.<>p__Site3d == null)
				{
					user.<set_food_2>o__SiteContainer3c.<>p__Site3d = CallSite<Func<CallSite, object, string, int, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetIndex(CSharpBinderFlags.None, typeof(user), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
					}));
				}
				Func<CallSite, object, string, int, object> arg_10D_0 = user.<set_food_2>o__SiteContainer3c.<>p__Site3d.Target;
				CallSite arg_10D_1 = user.<set_food_2>o__SiteContainer3c.<>p__Site3d;
				if (user.<set_food_2>o__SiteContainer3c.<>p__Site3e == null)
				{
					user.<set_food_2>o__SiteContainer3c.<>p__Site3e = CallSite<Func<CallSite, object, string, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetIndex(CSharpBinderFlags.None, typeof(user), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				Func<CallSite, object, string, object> arg_102_0 = user.<set_food_2>o__SiteContainer3c.<>p__Site3e.Target;
				CallSite arg_102_1 = user.<set_food_2>o__SiteContainer3c.<>p__Site3e;
				if (user.<set_food_2>o__SiteContainer3c.<>p__Site3f == null)
				{
					user.<set_food_2>o__SiteContainer3c.<>p__Site3f = CallSite<Func<CallSite, object, string, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetIndex(CSharpBinderFlags.None, typeof(user), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				arg_10D_0(arg_10D_1, arg_102_0(arg_102_1, user.<set_food_2>o__SiteContainer3c.<>p__Site3f.Target(user.<set_food_2>o__SiteContainer3c.<>p__Site3f, user.data, "response"), "inventory"), "food_2", value);
			}
		}

		public static int coins
		{
			get
			{
				if (user.<get_coins>o__SiteContainer40.<>p__Site41 == null)
				{
					user.<get_coins>o__SiteContainer40.<>p__Site41 = CallSite<Func<CallSite, object, int>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.None, typeof(int), typeof(user)));
				}
				Func<CallSite, object, int> arg_D7_0 = user.<get_coins>o__SiteContainer40.<>p__Site41.Target;
				CallSite arg_D7_1 = user.<get_coins>o__SiteContainer40.<>p__Site41;
				if (user.<get_coins>o__SiteContainer40.<>p__Site42 == null)
				{
					user.<get_coins>o__SiteContainer40.<>p__Site42 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "coins", typeof(user), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, object, object> arg_D2_0 = user.<get_coins>o__SiteContainer40.<>p__Site42.Target;
				CallSite arg_D2_1 = user.<get_coins>o__SiteContainer40.<>p__Site42;
				if (user.<get_coins>o__SiteContainer40.<>p__Site43 == null)
				{
					user.<get_coins>o__SiteContainer40.<>p__Site43 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "response", typeof(user), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				return arg_D7_0(arg_D7_1, arg_D2_0(arg_D2_1, user.<get_coins>o__SiteContainer40.<>p__Site43.Target(user.<get_coins>o__SiteContainer40.<>p__Site43, user.data)));
			}
			set
			{
				if (user.<set_coins>o__SiteContainer44.<>p__Site45 == null)
				{
					user.<set_coins>o__SiteContainer44.<>p__Site45 = CallSite<Func<CallSite, object, int, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "coins", typeof(user), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
					}));
				}
				Func<CallSite, object, int, object> arg_A3_0 = user.<set_coins>o__SiteContainer44.<>p__Site45.Target;
				CallSite arg_A3_1 = user.<set_coins>o__SiteContainer44.<>p__Site45;
				if (user.<set_coins>o__SiteContainer44.<>p__Site46 == null)
				{
					user.<set_coins>o__SiteContainer44.<>p__Site46 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "response", typeof(user), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				arg_A3_0(arg_A3_1, user.<set_coins>o__SiteContainer44.<>p__Site46.Target(user.<set_coins>o__SiteContainer44.<>p__Site46, user.data), value);
			}
		}

		public static int energy
		{
			get
			{
				if (user.<get_energy>o__SiteContainer47.<>p__Site48 == null)
				{
					user.<get_energy>o__SiteContainer47.<>p__Site48 = CallSite<Func<CallSite, object, int>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.None, typeof(int), typeof(user)));
				}
				Func<CallSite, object, int> arg_D7_0 = user.<get_energy>o__SiteContainer47.<>p__Site48.Target;
				CallSite arg_D7_1 = user.<get_energy>o__SiteContainer47.<>p__Site48;
				if (user.<get_energy>o__SiteContainer47.<>p__Site49 == null)
				{
					user.<get_energy>o__SiteContainer47.<>p__Site49 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "energy", typeof(user), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, object, object> arg_D2_0 = user.<get_energy>o__SiteContainer47.<>p__Site49.Target;
				CallSite arg_D2_1 = user.<get_energy>o__SiteContainer47.<>p__Site49;
				if (user.<get_energy>o__SiteContainer47.<>p__Site4a == null)
				{
					user.<get_energy>o__SiteContainer47.<>p__Site4a = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "response", typeof(user), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				return arg_D7_0(arg_D7_1, arg_D2_0(arg_D2_1, user.<get_energy>o__SiteContainer47.<>p__Site4a.Target(user.<get_energy>o__SiteContainer47.<>p__Site4a, user.data)));
			}
			set
			{
				if (user.<set_energy>o__SiteContainer4b.<>p__Site4c == null)
				{
					user.<set_energy>o__SiteContainer4b.<>p__Site4c = CallSite<Func<CallSite, object, int, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "energy", typeof(user), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
					}));
				}
				Func<CallSite, object, int, object> arg_A3_0 = user.<set_energy>o__SiteContainer4b.<>p__Site4c.Target;
				CallSite arg_A3_1 = user.<set_energy>o__SiteContainer4b.<>p__Site4c;
				if (user.<set_energy>o__SiteContainer4b.<>p__Site4d == null)
				{
					user.<set_energy>o__SiteContainer4b.<>p__Site4d = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "response", typeof(user), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				arg_A3_0(arg_A3_1, user.<set_energy>o__SiteContainer4b.<>p__Site4d.Target(user.<set_energy>o__SiteContainer4b.<>p__Site4d, user.data), value);
			}
		}

		public static string id
		{
			get
			{
				return user._id;
			}
			set
			{
				user._id = value;
			}
		}

		public static bool isCaseElite
		{
			get
			{
				return user.CheckisElite(user.case_id);
			}
		}

		public static string signature
		{
			get
			{
				return user._signature;
			}
			set
			{
				user._signature = value;
			}
		}

		public static int case_id
		{
			get
			{
				return user._case_id;
			}
			set
			{
				user._case_id = value;
			}
		}

		public static int stage_id
		{
			get
			{
				if (user.scene_id <= 3)
				{
					return 1010 + user.scene_id;
				}
				if (user.scene_id > 3 & user.scene_id <= 6)
				{
					return 1020 + (user.scene_id - 3);
				}
				return 1030 + (user.scene_id - 6);
			}
		}

		public static int scene_id
		{
			get
			{
				return user._scene_id;
			}
			set
			{
				user._scene_id = value;
			}
		}

		public static int items_found
		{
			get
			{
				if (user.scene_id == 6)
				{
					return 60;
				}
				if (user.isCaseElite)
				{
					if (user.current_star == 0)
					{
						return 7;
					}
					if (user.current_star == 1)
					{
						return 8;
					}
					if (user.current_star == 2)
					{
						return 9;
					}
					if (user.current_star == 3)
					{
						return 10;
					}
					if (user.current_star == 4)
					{
						return 12;
					}
					return 14;
				}
				else
				{
					if (user.current_star == 0)
					{
						return 6;
					}
					return user.current_star + 7;
				}
			}
		}

		public static string score
		{
			get
			{
				return Convert.ToString(user._score);
			}
			set
			{
				user._score = Convert.ToInt32(value);
			}
		}

		public static int time_spent
		{
			get
			{
				if (user.scene_id != 6)
				{
					return user._time_spent;
				}
				return 400;
			}
			set
			{
				user._time_spent = value;
			}
		}

		public static int start_time
		{
			get
			{
				int result;
				try
				{
					if (user.<get_start_time>o__SiteContainer58.<>p__Site59 == null)
					{
						user.<get_start_time>o__SiteContainer58.<>p__Site59 = CallSite<Func<CallSite, object, int>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.None, typeof(int), typeof(user)));
					}
					Func<CallSite, object, int> arg_D7_0 = user.<get_start_time>o__SiteContainer58.<>p__Site59.Target;
					CallSite arg_D7_1 = user.<get_start_time>o__SiteContainer58.<>p__Site59;
					if (user.<get_start_time>o__SiteContainer58.<>p__Site5a == null)
					{
						user.<get_start_time>o__SiteContainer58.<>p__Site5a = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "start_time", typeof(user), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					Func<CallSite, object, object> arg_D2_0 = user.<get_start_time>o__SiteContainer58.<>p__Site5a.Target;
					CallSite arg_D2_1 = user.<get_start_time>o__SiteContainer58.<>p__Site5a;
					if (user.<get_start_time>o__SiteContainer58.<>p__Site5b == null)
					{
						user.<get_start_time>o__SiteContainer58.<>p__Site5b = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "response", typeof(user), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					result = arg_D7_0(arg_D7_1, arg_D2_0(arg_D2_1, user.<get_start_time>o__SiteContainer58.<>p__Site5b.Target(user.<get_start_time>o__SiteContainer58.<>p__Site5b, user.StartData)));
				}
				catch
				{
					result = 0;
				}
				return result;
			}
		}

		public static int current_star
		{
			get
			{
				int result;
				try
				{
					result = user.stage[user.stage_id].case_stars;
				}
				catch
				{
					result = 0;
				}
				return result;
			}
			set
			{
				try
				{
					user.stage[user.stage_id].case_stars = value;
				}
				catch
				{
				}
			}
		}

		public static int high_score
		{
			get
			{
				return user.stage[user.stage_id].high_score;
			}
			set
			{
				user.stage[user.stage_id].high_score = value;
			}
		}

		public static string sig
		{
			get
			{
				byte[] array = new MD5CryptoServiceProvider().ComputeHash(Encoding.ASCII.GetBytes(string.Concat(new object[]
				{
					user.score,
					user.start_time,
					user.id,
					"bauchu"
				})));
				string text = "";
				byte[] array2 = array;
				for (int i = 0; i < array2.Length; i++)
				{
					byte b = array2[i];
					text += b.ToString("x2");
				}
				return text;
			}
		}

		public static string star(int st)
		{
			if (st == 1)
			{
				return "★☆☆☆☆";
			}
			if (st == 2)
			{
				return "★★☆☆☆";
			}
			if (st == 3)
			{
				return "★★★☆☆";
			}
			if (st == 4)
			{
				return "★★★★☆";
			}
			if (st == 5)
			{
				return "★★★★★";
			}
			return "☆☆☆☆☆";
		}

		public static string get_case_name(int case_id)
		{
			string result;
			try
			{
				result = case_id + " - " + user.case_name[case_id];
			}
			catch
			{
				result = case_id + " - 名字暫時不支援";
			}
			return result;
		}

		public static string get_pet_name(string pet_id)
		{
			string result;
			try
			{
				result = user.pet_name[pet_id];
			}
			catch
			{
				result = "寵物編號:" + pet_id;
			}
			return result;
		}

		public static bool CheckisElite(int case_id)
		{
			try
			{
				if (user.<CheckisElite>o__SiteContainerc.<>p__Sited == null)
				{
					user.<CheckisElite>o__SiteContainerc.<>p__Sited = CallSite<Func<CallSite, object, IEnumerable>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.None, typeof(IEnumerable), typeof(user)));
				}
				Func<CallSite, object, IEnumerable> arg_EB_0 = user.<CheckisElite>o__SiteContainerc.<>p__Sited.Target;
				CallSite arg_EB_1 = user.<CheckisElite>o__SiteContainerc.<>p__Sited;
				if (user.<CheckisElite>o__SiteContainerc.<>p__Sitee == null)
				{
					user.<CheckisElite>o__SiteContainerc.<>p__Sitee = CallSite<Func<CallSite, object, string, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetIndex(CSharpBinderFlags.None, typeof(user), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				Func<CallSite, object, string, object> arg_E6_0 = user.<CheckisElite>o__SiteContainerc.<>p__Sitee.Target;
				CallSite arg_E6_1 = user.<CheckisElite>o__SiteContainerc.<>p__Sitee;
				if (user.<CheckisElite>o__SiteContainerc.<>p__Sitef == null)
				{
					user.<CheckisElite>o__SiteContainerc.<>p__Sitef = CallSite<Func<CallSite, object, string, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetIndex(CSharpBinderFlags.None, typeof(user), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				foreach (object current in arg_EB_0(arg_EB_1, arg_E6_0(arg_E6_1, user.<CheckisElite>o__SiteContainerc.<>p__Sitef.Target(user.<CheckisElite>o__SiteContainerc.<>p__Sitef, user.data, "response"), "elite_cases_launched")))
				{
					if (user.<CheckisElite>o__SiteContainerc.<>p__Site10 == null)
					{
						user.<CheckisElite>o__SiteContainerc.<>p__Site10 = CallSite<Func<CallSite, object, bool>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(user), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					Func<CallSite, object, bool> arg_1A4_0 = user.<CheckisElite>o__SiteContainerc.<>p__Site10.Target;
					CallSite arg_1A4_1 = user.<CheckisElite>o__SiteContainerc.<>p__Site10;
					if (user.<CheckisElite>o__SiteContainerc.<>p__Site11 == null)
					{
						user.<CheckisElite>o__SiteContainerc.<>p__Site11 = CallSite<Func<CallSite, object, int, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Equal, typeof(user), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
						}));
					}
					if (arg_1A4_0(arg_1A4_1, user.<CheckisElite>o__SiteContainerc.<>p__Site11.Target(user.<CheckisElite>o__SiteContainerc.<>p__Site11, current, case_id)))
					{
						return true;
					}
				}
			}
			catch
			{
			}
			return false;
		}

		public static bool isCollectMode(int case_id)
		{
			bool result;
			try
			{
				if (user.<isCollectMode>o__SiteContainer12.<>p__Site13 == null)
				{
					user.<isCollectMode>o__SiteContainer12.<>p__Site13 = CallSite<Func<CallSite, object, int>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(int), typeof(user)));
				}
				Func<CallSite, object, int> arg_144_0 = user.<isCollectMode>o__SiteContainer12.<>p__Site13.Target;
				CallSite arg_144_1 = user.<isCollectMode>o__SiteContainer12.<>p__Site13;
				if (user.<isCollectMode>o__SiteContainer12.<>p__Site14 == null)
				{
					user.<isCollectMode>o__SiteContainer12.<>p__Site14 = CallSite<Func<CallSite, object, string, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetIndex(CSharpBinderFlags.None, typeof(user), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
					}));
				}
				Func<CallSite, object, string, object> arg_13F_0 = user.<isCollectMode>o__SiteContainer12.<>p__Site14.Target;
				CallSite arg_13F_1 = user.<isCollectMode>o__SiteContainer12.<>p__Site14;
				if (user.<isCollectMode>o__SiteContainer12.<>p__Site15 == null)
				{
					user.<isCollectMode>o__SiteContainer12.<>p__Site15 = CallSite<Func<CallSite, object, string, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetIndex(CSharpBinderFlags.None, typeof(user), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				Func<CallSite, object, string, object> arg_133_0 = user.<isCollectMode>o__SiteContainer12.<>p__Site15.Target;
				CallSite arg_133_1 = user.<isCollectMode>o__SiteContainer12.<>p__Site15;
				if (user.<isCollectMode>o__SiteContainer12.<>p__Site16 == null)
				{
					user.<isCollectMode>o__SiteContainer12.<>p__Site16 = CallSite<Func<CallSite, object, string, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetIndex(CSharpBinderFlags.None, typeof(user), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				if (arg_144_0(arg_144_1, arg_13F_0(arg_13F_1, arg_133_0(arg_133_1, user.<isCollectMode>o__SiteContainer12.<>p__Site16.Target(user.<isCollectMode>o__SiteContainer12.<>p__Site16, user.data, "response"), "replay_cases"), case_id.ToString())) == 1)
				{
					result = true;
				}
				else
				{
					result = false;
				}
			}
			catch
			{
				result = false;
			}
			return result;
		}

		public static int Medal(int case_id)
		{
			int result;
			try
			{
				if (user.<Medal>o__SiteContainer4e.<>p__Site4f == null)
				{
					user.<Medal>o__SiteContainer4e.<>p__Site4f = CallSite<Func<CallSite, object, int>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.None, typeof(int), typeof(user)));
				}
				Func<CallSite, object, int> arg_143_0 = user.<Medal>o__SiteContainer4e.<>p__Site4f.Target;
				CallSite arg_143_1 = user.<Medal>o__SiteContainer4e.<>p__Site4f;
				if (user.<Medal>o__SiteContainer4e.<>p__Site50 == null)
				{
					user.<Medal>o__SiteContainer4e.<>p__Site50 = CallSite<Func<CallSite, object, string, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetIndex(CSharpBinderFlags.None, typeof(user), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
					}));
				}
				Func<CallSite, object, string, object> arg_13E_0 = user.<Medal>o__SiteContainer4e.<>p__Site50.Target;
				CallSite arg_13E_1 = user.<Medal>o__SiteContainer4e.<>p__Site50;
				if (user.<Medal>o__SiteContainer4e.<>p__Site51 == null)
				{
					user.<Medal>o__SiteContainer4e.<>p__Site51 = CallSite<Func<CallSite, object, string, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetIndex(CSharpBinderFlags.None, typeof(user), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				Func<CallSite, object, string, object> arg_132_0 = user.<Medal>o__SiteContainer4e.<>p__Site51.Target;
				CallSite arg_132_1 = user.<Medal>o__SiteContainer4e.<>p__Site51;
				if (user.<Medal>o__SiteContainer4e.<>p__Site52 == null)
				{
					user.<Medal>o__SiteContainer4e.<>p__Site52 = CallSite<Func<CallSite, object, string, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetIndex(CSharpBinderFlags.None, typeof(user), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				result = arg_143_0(arg_143_1, arg_13E_0(arg_13E_1, arg_132_0(arg_132_1, user.<Medal>o__SiteContainer4e.<>p__Site52.Target(user.<Medal>o__SiteContainer4e.<>p__Site52, user.data, "response"), "medals"), case_id.ToString()));
			}
			catch
			{
				result = 0;
			}
			return result;
		}

		public static int Elite_Medal(int case_id)
		{
			int result;
			try
			{
				if (user.<Elite_Medal>o__SiteContainer53.<>p__Site54 == null)
				{
					user.<Elite_Medal>o__SiteContainer53.<>p__Site54 = CallSite<Func<CallSite, object, int>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.None, typeof(int), typeof(user)));
				}
				Func<CallSite, object, int> arg_143_0 = user.<Elite_Medal>o__SiteContainer53.<>p__Site54.Target;
				CallSite arg_143_1 = user.<Elite_Medal>o__SiteContainer53.<>p__Site54;
				if (user.<Elite_Medal>o__SiteContainer53.<>p__Site55 == null)
				{
					user.<Elite_Medal>o__SiteContainer53.<>p__Site55 = CallSite<Func<CallSite, object, string, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetIndex(CSharpBinderFlags.None, typeof(user), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
					}));
				}
				Func<CallSite, object, string, object> arg_13E_0 = user.<Elite_Medal>o__SiteContainer53.<>p__Site55.Target;
				CallSite arg_13E_1 = user.<Elite_Medal>o__SiteContainer53.<>p__Site55;
				if (user.<Elite_Medal>o__SiteContainer53.<>p__Site56 == null)
				{
					user.<Elite_Medal>o__SiteContainer53.<>p__Site56 = CallSite<Func<CallSite, object, string, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetIndex(CSharpBinderFlags.None, typeof(user), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				Func<CallSite, object, string, object> arg_132_0 = user.<Elite_Medal>o__SiteContainer53.<>p__Site56.Target;
				CallSite arg_132_1 = user.<Elite_Medal>o__SiteContainer53.<>p__Site56;
				if (user.<Elite_Medal>o__SiteContainer53.<>p__Site57 == null)
				{
					user.<Elite_Medal>o__SiteContainer53.<>p__Site57 = CallSite<Func<CallSite, object, string, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetIndex(CSharpBinderFlags.None, typeof(user), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				result = arg_143_0(arg_143_1, arg_13E_0(arg_13E_1, arg_132_0(arg_132_1, user.<Elite_Medal>o__SiteContainer53.<>p__Site57.Target(user.<Elite_Medal>o__SiteContainer53.<>p__Site57, user.data, "response"), "elite_medals"), case_id.ToString()));
			}
			catch
			{
				result = 0;
			}
			return result;
		}

		public static void Clear_FetchCase_Info()
		{
			for (int i = 0; i < 9; i++)
			{
				user.stage[user.get_stage_id(i)].case_stars = 0;
				user.stage[user.get_stage_id(i)].high_score = 0;
			}
		}

		public static int get_stage_index(int id)
		{
			if (id < 1011 || id > 1033)
			{
				return 1011;
			}
			if (id >= 1011 & id <= 1013)
			{
				return id - 1011;
			}
			if (id >= 1021 & id <= 1023)
			{
				return id - 1018;
			}
			if (id >= 1021 & id <= 1033)
			{
				return id - 1025;
			}
			return 1011;
		}

		public static int get_stage_id(int index)
		{
			if (index >= 0 && index <= 2)
			{
				return index + 1011;
			}
			if (index >= 3 && index <= 5)
			{
				return index + 1018;
			}
			if (index >= 6 && index <= 8)
			{
				return index + 1025;
			}
			return 1;
		}

		public static void RewardLog(string sErrMsg)
		{
			lock (user.lockMe)
			{
				using (StreamWriter streamWriter = new StreamWriter("share.log", true))
				{
					streamWriter.WriteLine(DateTime.Now.ToString() + " : " + sErrMsg);
					Console.WriteLine(sErrMsg);
					streamWriter.Close();
				}
			}
		}

		public static void AiteLog(string sErrMsg)
		{
			lock (user.lockMe)
			{
				using (StreamWriter streamWriter = new StreamWriter("Aite.log", true))
				{
					streamWriter.WriteLine(DateTime.Now.ToString() + " : " + sErrMsg);
					Console.WriteLine(sErrMsg);
					streamWriter.Close();
				}
			}
		}

		public static void PetLog(string sErrMsg)
		{
			lock (user.lockMe)
			{
				using (StreamWriter streamWriter = new StreamWriter("pet.log", true))
				{
					streamWriter.WriteLine(DateTime.Now.ToString() + " : " + sErrMsg);
					Console.WriteLine(sErrMsg);
					user.Last_Message = sErrMsg;
					streamWriter.Close();
				}
			}
		}

		public static void CardLog(string sErrMsg)
		{
			lock (user.lockMe)
			{
				using (StreamWriter streamWriter = new StreamWriter("card.log", true))
				{
					streamWriter.WriteLine(string.Concat(new object[]
					{
						DateTime.Now.ToString(),
						" : [",
						++user.card_count,
						"]",
						sErrMsg
					}));
					user.Last_Message = sErrMsg;
					Console.WriteLine(sErrMsg);
					streamWriter.Close();
				}
			}
		}

		public static void Notification(string msg)
		{
			user.Last_Message = msg;
		}

		public static void WriteLog(string sErrMsg)
		{
			lock (user.lockMe)
			{
				using (StreamWriter streamWriter = new StreamWriter("criminal.log", true))
				{
					streamWriter.WriteLine(DateTime.Now.ToString() + " : " + sErrMsg);
					Console.WriteLine(sErrMsg);
					user.Last_Message = sErrMsg;
					streamWriter.Close();
				}
			}
		}
	}
}
