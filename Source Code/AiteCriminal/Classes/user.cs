using Microsoft.CSharp.RuntimeBinder;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using Newtonsoft.Json.Linq;
namespace AiteCriminal
{
	public static class user
	{
		public static int teammate_index;

		public static bool Loop_USE_TEAMMTE;

		public static bool Get_Report;

		public static int current_season;

		private static string Last1;

		private static string Last2;

		private static string Last3;

		private static string Last4;

		private static string Last5;

		private static string Last6;

		public static bool isAcceptGift;

		public static bool Log_Report;

		public static bool Get_Energy2;

		public static bool Log_Energy2;

		public static bool Get_Energy1;

		public static bool Log_Energy1;

		public static bool Get_Card;

		public static bool Log_Card;

		public static bool isRunning;

		public static int card_count;

		public static bool isAutoPlay;

		public static Dictionary<string, int> pet_xp;

		public static Dictionary<int, string> case_name;

		public static int count;

		public static int stickers_pack_count;

		private static string _id;

		private static string _signature;

		private static int _case_id;

		private static int _scene_id;

		public static int _score;

		private static int _time_spent;

		public static Dictionary<int, user.Stage> stage;

		private static object lockMe;

		public static dynamic data;

		public static dynamic StageData;

		public static dynamic StartData;

		public static dynamic EndData;

		public static List<Friends> FriendList;

		public static List<Friends> GiftFriendList;

		public static CookieContainer logincookie;

		public static int available_stars
		{
			get
			{
				int stageData;
				try
				{
					stageData = Convert.ToInt32(user.StageData["response"]["available_stars"]);
				}
				catch
				{
					stageData = 0;
				}
				return stageData;
			}
			set
			{
				try
				{
					user.StageData["response"]["available_stars"] = value;
				}
				catch
				{
				}
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

		public static int coins
		{
			get
			{
				return Convert.ToInt32(user.data["response"]["coins"]);
			}
			set
			{
                user.data["response"]["coins"] = value;
			}
		}

		public static int current_star
		{
			get
			{
				int caseStars;
				try
				{
					caseStars = user.stage[user.stage_id].case_stars;
				}
				catch
				{
					caseStars = 0;
				}
				return caseStars;
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

		public static int energy
		{
			get
			{
				return Convert.ToInt32(user.data["response"]["energy"]);
			}
			set
			{
                user.data["response"]["energy"] = value;
			}
		}

		public static int food_0
		{
			get
			{
				int num;
				try
				{
					num = user.data["response"]["inventory"]["food_0"];
				}
				catch
				{
					num = 0;
				}
				return num;
			}
			set
			{
                user.data["response"]["inventory"]["food_0"] = value;
			}
		}

		public static int food_1
		{
			get
			{
				int num;
				try
				{
					num = Convert.ToInt32(user.data["response"]["inventory"]["food_1"]);
				}
				catch
				{
					num = 0;
				}
				return num;
			}
			set
			{
                user.data["response"]["inventory"]["food_1"] = value;
			}
		}

		public static int food_2
		{
			get
			{
				int num;
				try
				{
					num = Convert.ToInt32(user.data["response"]["inventory"]["food_2"]);
				}
				catch
				{
					num = 0;
				}
				return num;
			}
			set
			{
				user.data["response"]["inventory"]["food_2"] = value;
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

		public static bool isCurrent_case
		{
			get
			{
				return (bool)(user.StageData["response"]["current_case"] == user.case_id);
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
				if (!user.isCaseElite)
				{
					if (user.current_star == 0)
					{
						return 6;
					}
					return user.current_star + 7;
				}
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
		}

		public static string Last_Message
		{
			get
			{
				string[] last6 = new string[] { user.Last6, "\r\n", user.Last5, "\r\n", user.Last4, "\r\n", user.Last3, "\r\n", user.Last2, "\r\n", user.Last1 };
				return string.Concat(last6);
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

		public static int level
		{
			get
			{
				return user.data["response"]["level"];
			}
			set
			{
				user.data["response"]["level"] = value;
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

		public static string sig
		{
			get
			{
				MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
				Encoding aSCII = Encoding.ASCII;
				object[] startTime = new object[] { user.score, user.start_time, user.id, "bauchu" };
				byte[] numArray = mD5CryptoServiceProvider.ComputeHash(aSCII.GetBytes(string.Concat(startTime)));
				string str = "";
				byte[] numArray1 = numArray;
				for (int i = 0; i < (int)numArray1.Length; i++)
				{
					byte num = numArray1[i];
					str = string.Concat(str, num.ToString("x2"));
				}
				return str;
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

		public static int start_time
		{
			get
			{
				int startData;
				try
				{
					startData = Convert.ToInt32(user.StartData["response"]["start_time"]);
				}
				catch
				{
					startData = 0;
				}
				return startData;
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

		public static string Version
		{
			get
			{
				return string.Concat("V", Assembly.GetExecutingAssembly().GetName().Version);
			}
		}

		public static int xp
		{
			get
            {
                return Convert.ToInt32(user.data["response"]["xp"]);
			}
			set
			{
				user.data["response"]["xp"] = value;
			}
		}

		static user()
		{
			user.teammate_index = -1;
			user.Loop_USE_TEAMMTE = false;
			user.Get_Report = true;
			user.current_season = 1;
			user.Last1 = string.Empty;
			user.Last2 = string.Empty;
			user.Last3 = string.Empty;
			user.Last4 = string.Empty;
			user.Last5 = string.Empty;
			user.Last6 = string.Empty;
			user.isAcceptGift = false;
			user.Log_Report = true;
			user.Get_Energy2 = true;
			user.Log_Energy2 = true;
			user.Get_Energy1 = true;
			user.Log_Energy1 = true;
			user.Get_Card = true;
			user.Log_Card = true;
			user.isRunning = false;
			user.card_count = 0;
			user.isAutoPlay = false;
			user.pet_xp = new Dictionary<string, int>();
			
			Dictionary<int, string> nums = new Dictionary<int, string>()
			{
				{ 1, "ROSA WOLF死亡之謎" },
				{ 2, "陳屍花園中" },
				{ 3, "兇殘屠夫犯罪現場" },
				{ 4, "船廠兇案犯罪現場" },
				{ 5, "俄國問題" },
				{ 6, "好警察，沒命的警察" },
				{ 7, "十字架之刑" },
				{ 8, "美麗已是過去式" },
				{ 9, "熱火煉獄" },
				{ 10, "刀鋒下的秘密" },
				{ 11, "龍潭虎穴" },
				{ 12, "交易所血案" },
				{ 13, "Grimsborough炸彈警告" },
				{ 14, "時尚的犧牲者" },
				{ 15, "家族血緣" },
				{ 16, "死亡之吻" },
				{ 17, "最後的晚餐" },
				{ 18, "暗夜殺手" },
				{ 19, "無辜的迷途羔羊" },
				{ 20, "致命遊戲" },
				{ 21, "秘密實驗" },
				{ 22, "求生或求死" },
				{ 23, "最後的旅程" },
				{ 24, "兇手剖析" },
				{ 25, "Grimsborough 的亡魂" },
				{ 26, "召喚儀式" },
				{ 27, "湖泊的新娘" },
				{ 28, "鬧鬼的榆木莊園" },
				{ 29, "無火不起煙" },
				{ 30, "Wollcrafts 的怪物" },
				{ 31, "狗咬狗" },
				{ 32, "校園兇殺案" },
				{ 33, "致命溫柔" },
				{ 34, "死亡比賽" },
				{ 35, "走投無路" },
				{ 36, "惡魔的遊樂場" },
				{ 37, "死神與怪人" },
				{ 38, "春假慘案" },
				{ 39, "死亡標記" },
				{ 40, "小學兇殺" },
				{ 41, "墨跡死神" },
				{ 42, "血與榮耀" },
				{ 43, "怪奇水域" },
				{ 44, "死亡氣息" },
				{ 45, "美人命薄" },
				{ 46, "亡命揮桿" },
				{ 47, "婚禮與葬禮" },
				{ 48, "紅顏多薄命" },
				{ 49, "飛來橫禍" },
				{ 50, "舞台春秋" },
				{ 51, "一切到此為止" },
				{ 52, "勇氣新世界" },
				{ 53, "掩埋殺意" },
				{ 54, "渲染事實" },
				{ 55, "塵歸塵" },
				{ 56, "腥風血雨即將興起" },
				{ 201, "鯊魚攻擊" },
				{ 202, "絕命飛輪" },
				{ 203, "水下殺機" },
				{ 204, "玩命對抗" },
				{ 205, "寒冰女王" },
				{ 206, "BAYOU 之血" },
				{ 207, "囊中之物" },
				{ 208, "萬惡之源" },
				{ 209, "在空想中死亡" },
				{ 210, "扭曲的真相" },
				{ 211, "無心的屍體" },
				{ 212, "報應" },
				{ 213, "東方的承諾" },
				{ 214, "懦弱無能" },
				{ 215, "死亡迴旋" },
				{ 216, "殺人時刻" },
				{ 217, "秘密" },
				{ 218, "風暴過後" },
				{ 219, "烏雲密布引殺機" },
				{ 220, "開放性傷口" },
				{ 221, "Thunderdome體育館中的秘密" },
				{ 222, "老鼠與人" },
				{ 223, "暴風眼" },
				{ 224, "命懸一線" }
			};
			user.case_name = nums;
			user.count = 0;
			user.stickers_pack_count = 0;
			user._case_id = 1;
			user._scene_id = 0;
			user._score = 0;
			user._time_spent = 10;
			user.stage = new Dictionary<int, user.Stage>();
			user.lockMe = new object();
			user.FriendList = new List<Friends>();
			user.GiftFriendList = new List<Friends>();
			user.logincookie = new CookieContainer();
		}

		public static void AiteLog(string sErrMsg)
		{
			lock (user.lockMe)
			{
				using (StreamWriter streamWriter = new StreamWriter("Aite.log", true))
				{
					DateTime now = DateTime.Now;
					streamWriter.WriteLine(string.Concat(now.ToString(), " : ", sErrMsg));
					Console.WriteLine(sErrMsg);
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
					object[] str = new object[] { DateTime.Now.ToString(), " : [", null, null, null };
					int cardCount = user.card_count + 1;
					user.card_count = cardCount;
					str[2] = cardCount;
					str[3] = "]";
					str[4] = sErrMsg;
					streamWriter.WriteLine(string.Concat(str));
					user.Last_Message = sErrMsg;
					Console.WriteLine(sErrMsg);
					streamWriter.Close();
				}
			}
		}

		public static bool CheckisElite(int case_id)
		{
            try
            {
                foreach (JProperty stage in user.data["response"]["elite_cases_launched"])
                {
                    int stageNum = Convert.ToInt32(stage);
                    if (stageNum == case_id)
                        return true;
                }
            }
            catch { }
			return false;
		}

		public static void Clear_FetchCase_Info()
		{
			for (int i = 0; i < 9; i++)
			{
				user.stage[user.get_stage_id(i)].case_stars = 0;
				user.stage[user.get_stage_id(i)].high_score = 0;
			}
		}

		public static int Elite_Medal(int case_id)
		{
			int str;
			try
			{
				str = Convert.ToInt32(user.data["response"]["elite_medals"][case_id.ToString()]);
			}
			catch
			{
				str = 0;
			}
			return str;
		}

		public static string get_case_name(int case_id)
		{
			string str;
			try
			{
				str = string.Concat(case_id, " - ", user.case_name[case_id]);
			}
			catch
			{
				str = string.Concat(case_id, " - 名字暫時不支援");
			}
			return str;
		}

		public static string getPetName(string pet_id)
		{
			string petName;
			try
			{
                petName = Global.Pets[pet_id];
			}
			catch
			{
                petName = string.Concat("寵物編號:", pet_id);
			}
			return petName;
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
			if (index < 6 || index > 8)
			{
				return 1;
			}
			return index + 1025;
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
			if (!(id >= 1021 & id <= 1033))
			{
				return 1011;
			}
			return id - 1025;
		}

		public static bool isCollectMode(int case_id)
		{
			bool flag;
			try
			{
				flag = Convert.ToInt32(user.data["response"]["replay_cases"][case_id.ToString()]) != 1 ? false : true;
			}
			catch { flag = false; }
			return flag;
		}

		public static int Medal(int case_id)
		{
            int medalType = 0;
			try
			{
                medalType = Convert.ToInt32(user.data["response"]["medals"][case_id.ToString()]);
			}
			catch{ medalType = 0;} 
			return medalType;
		}

		public static void Notification(string msg)
		{
			user.Last_Message = msg;
		}

		public static void PetLog(string sErrMsg)
		{
			lock (user.lockMe)
			{
				using (StreamWriter streamWriter = new StreamWriter("pet.log", true))
				{
					DateTime now = DateTime.Now;
					streamWriter.WriteLine(string.Concat(now.ToString(), " : ", sErrMsg));
					Console.WriteLine(sErrMsg);
					user.Last_Message = sErrMsg;
					streamWriter.Close();
				}
			}
		}

		public static void RewardLog(string sErrMsg)
		{
			lock (user.lockMe)
			{
				using (StreamWriter streamWriter = new StreamWriter("share.log", true))
				{
					DateTime now = DateTime.Now;
					streamWriter.WriteLine(string.Concat(now.ToString(), " : ", sErrMsg));
					Console.WriteLine(sErrMsg);
					streamWriter.Close();
				}
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

		public static void WriteLog(string sErrMsg)
		{
			lock (user.lockMe)
			{
				using (StreamWriter streamWriter = new StreamWriter("criminal.log", true))
				{
					DateTime now = DateTime.Now;
					streamWriter.WriteLine(string.Concat(now.ToString(), " : ", sErrMsg));
					Console.WriteLine(sErrMsg);
					user.Last_Message = sErrMsg;
					streamWriter.Close();
				}
			}
		}

		public class Stage
		{
			public int case_stars;

			public int high_score;

			public int is_Elite;

			public int MaxScore
			{
				get
				{
					int num = 1120000;
					if (user.isCaseElite)
					{
						num = 1310000;
						if (user.stage_id == 1023)
						{
							num = 1330000;
						}
						else if (user.stage_id == 1033)
						{
							num = 1400000;
						}
					}
					else if (user.stage_id == 1023)
					{
						num = 1100000;
					}
					else if (user.stage_id == 1033)
					{
						num = 1200000;
					}
					return num;
				}
			}

			public Stage()
			{
			}
		}
	}
}