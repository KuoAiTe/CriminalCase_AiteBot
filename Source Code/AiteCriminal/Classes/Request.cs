using Microsoft.CSharp.RuntimeBinder;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;

namespace AiteCriminal
{
	public static class Request
	{
		public static int Abandon_CASEID;

		public static int Abandon_STAGEID;

		static Request()
		{
		}

		public static void Abandon()
		{
			object[] abandonCASEID = new object[] { "query={\"action\":\"abandonStage\",\"signature\":\"", user.signature, "\",\"id\":2,\"params\":{\"user\":\"", user.id, "\",\"case_id\":", Request.Abandon_CASEID, ",\"revision\":\"44\",\"stage_id\":", Request.Abandon_STAGEID, "}}" };
			string str = string.Concat(abandonCASEID);
			if (!(new CCRequest()).Get(str))
			{
				return;
			}
			object[] objArray = new object[] { "放棄關卡:", Request.Abandon_CASEID, " - ", Request.Abandon_STAGEID };
			user.WriteLog(string.Concat(objArray));
			Request.Abandon_CASEID = 0;
			Request.Abandon_STAGEID = 0;
		}

		public static void AcceptGift()
		{
			user.isAcceptGift = true;
			CCRequest cCRequest = new CCRequest();
			if (cCRequest.GetMessage())
			{
				foreach (JToken item in JToken.Parse(cCRequest.result)["list"])
				{
					if (item["level"] == null)
					{
						continue;
					}
					string empty = string.Empty;
					string str = (string)item["name"];
					string item1 = (string)item["type"];
					string str1 = (string)item["id"];
					string empty1 = string.Empty;
					int num = (int)item["level"];
					if (item1 == "report" && user.Get_Report)
					{
						empty = string.Concat("action=reports-accept&friend_id[]=", str1);
						if (user.Log_Report)
						{
							empty1 = string.Concat("寄送給 ", str, " 解鎖報告");
						}
					}
					else if (item1 == "gift" && (int)item["gift_id"] == 0 && user.Get_Energy2)
					{
						string item2 = (string)item["key"];
						empty = string.Concat("action=gifts-accept&gift_key[]=", item2);
						if (user.Log_Energy2)
						{
							object[] objArray = new object[] { str, " (等級 ", num, ")送給您 2 點額外的能量！" };
							empty1 = string.Concat(objArray);
						}
					}
					else if (item1 == "compensation" && (int)item["compensation_id"] == 10 && user.Get_Energy1)
					{
						string str2 = (string)item["key"];
						empty = string.Concat("action=compensations-accept&friend_id=", str1, "&compensation_key[]=", str2);
						if (user.Log_Energy1)
						{
							object[] objArray1 = new object[] { str, " (等級 ", num, ")感謝您送的禮物！請接受這些額外的能量 1 回禮" };
							empty1 = string.Concat(objArray1);
						}
					}
					else if (item1 == "compensation" && (int)item["compensation_id"] == 0 && user.Get_Card)
					{
						string item3 = (string)item["key"];
						empty = string.Concat("action=compensations-accept&friend_id=", str1, "&compensation_key[]=", item3);
						if (user.Log_Card)
						{
							object[] objArray2 = new object[] { str, " (等級 ", num, ")您真是位很棒的夥伴！請收下這張撲克牌。" };
							empty1 = string.Concat(objArray2);
						}
					}
					if (empty.Length <= 0)
					{
						continue;
					}
					string str3 = empty;
					string[] strArrays = new string[] { str3, "&user_id=", user.id, "&signature=", user.signature };
					empty = string.Concat(strArrays);
					Console.WriteLine(empty);
					cCRequest = new CCRequest();
					cCRequest.SendGift(empty);
					if (empty1.Length <= 0)
					{
						continue;
					}
					user.CardLog(empty1);
				}
			}
			user.isAcceptGift = false;
		}

		public static bool BuyAllStarBurners(int BuyAllStarBurners)
		{
			bool flag;
			string empty = string.Empty;
			if (!user.isCaseElite)
			{
				object[] caseId = new object[] { "query={\"signature\":\"", user.signature, "\",\"id\":1,\"action\":\"buyAllStarBurners\",\"params\":{\"case_id\":", user.case_id, ",\"revision\":\"44\",\"user\":\"", user.id, "\",\"star_burner_id_list\":[", BuyAllStarBurners, "]}}" };
				empty = string.Concat(caseId);
			}
			else
			{
				object[] objArray = new object[] { "query={\"signature\":\"", user.signature, "\",\"id\":1,\"action\":\"buyAllStarBurners\",\"params\":{\"case_id\":", user.case_id, ",\"elite\":1,\"revision\":\"44\",\"star_burner_id_list\":[", BuyAllStarBurners, "],\"user\":\"", user.id, "\"}}" };
				empty = string.Concat(objArray);
			}
			Console.WriteLine(empty);
			CCRequest cCRequest = new CCRequest();
			if (!cCRequest.Get(empty))
			{
				return false;
			}
			JToken jToken = JToken.Parse(cCRequest.result);
			try
			{
				flag = (!(bool)jToken["response"]["success"] ? false : true);
			}
			catch
			{
				flag = false;
			}
			return flag;
		}

		public static bool CollectDailyBonus()
		{
			string[] strArrays = new string[] { "query={\"id\":1,\"params\":{\"user\":\"", user.id, "\",\"revision\":\"44\"},\"action\":\"collectDailyBonus\",\"signature\":\"", user.signature, "\"}" };
			string str = string.Concat(strArrays);
			CCRequest cCRequest = new CCRequest();
			if (!cCRequest.Get(str))
			{
				return false;
			}
			if (JToken.Parse(cCRequest.result)["response"] != null)
			{
				Console.WriteLine("領取當日紅利");
			}
			return true;
		}

		public static bool Eat(int food_id)
		{
			bool flag;
			object[] foodId = new object[] { "query={\"signature\":\"", user.signature, "\",\"id\":2,\"action\":\"useFood\",\"params\":{\"food_id\":\"food_", food_id, "\",\"revision\":\"44\",\"user\":\"", user.id, "\"}}" };
			string str = string.Concat(foodId);
			CCRequest cCRequest = new CCRequest();
			if (!cCRequest.Get(str))
			{
				return false;
			}
			JToken jToken = JToken.Parse(cCRequest.result);
			if (jToken["error"] == null)
			{
				if (food_id == 2)
				{
					user.energy = (int)jToken["response"]["energy"];
					user.food_2 = user.food_2 - 1;
				}
				else if (food_id == 1)
				{
					user.energy = (int)jToken["response"]["energy"];
					user.food_1 = user.food_1 - 1;
				}
				else if (food_id == 0)
				{
					user.energy = (int)jToken["response"]["energy"];
					user.food_0 = user.food_0 - 1;
				}
				return true;
			}
			try
			{
				user.energy = (int)jToken["error"]["sync"]["energy"];
				user.food_0 = (int)jToken["error"]["sync"]["inventory"]["food_0"];
				user.food_1 = (int)jToken["error"]["sync"]["inventory"]["food_1"];
				user.food_2 = (int)jToken["error"]["sync"]["inventory"]["food_2"];
				flag = true;
			}
			catch
			{
				flag = false;
			}
			return flag;
		}

		public static bool EndGame()
		{
			string empty = string.Empty;
			string endData = string.Empty;
			if (!user.isCaseElite)
			{
				object[] itemsFound = new object[] { "query={\"signature\":\"", user.signature, "\",\"id\":1,\"action\":\"endStage\",\"params\":{\"user\":\"", user.id, "\",\"revision\":\"44\",\"ho_items_found\":", user.items_found, ",\"case_id\":", user.case_id, ",\"time_spent\":", user.time_spent, ",\"score\":", user.score, ",\"stage_id\":", user.stage_id, ",\"sig\":\"", user.sig, "\",\"apply_special_event\":false,\"six_items_time\":10,\"hints_used\":0}}" };
				empty = string.Concat(itemsFound);
			}
			else
			{
				object[] objArray = new object[] { "query={\"signature\":\"", user.signature, "\",\"id\":1,\"action\":\"endStage\",\"params\":{\"user\":\"", user.id, "\",\"revision\":\"44\",\"ho_items_found\":", user.items_found, ",\"case_id\":", user.case_id, ",\"time_spent\":", user.time_spent, ",\"score\":", user.score, ",\"stage_id\":", user.stage_id, ",\"sig\":\"", user.sig, "\",\"elite\":\"1\",\"apply_special_event\":false,\"six_items_time\":10,\"hints_used\":0}}" };
				empty = string.Concat(objArray);
			}
			CCRequest cCRequest = new CCRequest();
			if (!cCRequest.Get(empty))
			{
				return false;
			}
			user.EndData = JToken.Parse(cCRequest.result);
			if (((dynamic)user.EndData)["response"] == (dynamic)null)
			{
				endData = (string)("fail user.Endata" + (dynamic)user.EndData);
				Console.WriteLine("EndStage出錯;");
				return false;
			}
			user.count++;
			int teammateIndex = user.teammate_index;
			int num = (int)((dynamic)user.EndData).response.xp_won;
			int endData1 = (int)((dynamic)user.EndData).response.coins_won;
			object obj = endData;
			object[] caseName = new object[] { obj, "[", user.count, "] [", user.get_case_name(user.case_id), "][第 ", user.scene_id, " 場景] - ", user.score };
			endData = string.Concat(caseName);
			if (((dynamic)user.EndData)["response"]["compensation_key"] != (dynamic)null)
			{
				Console.WriteLine(((dynamic)user.EndData)["response"]["compensation_key"]);
				if (teammateIndex >= 0 && teammateIndex < user.FriendList.Count)
				{
					string item = user.FriendList[teammateIndex].uid;
					string str = user.FriendList[teammateIndex].name;
					string str1 = (string)((dynamic)user.EndData).response.compensation_key;
					int item1 = user.FriendList[teammateIndex].level;
					endData = string.Concat(endData, "[隊友 ", str, "]");
					if (Request.SendCard(item, str1))
					{
						object[] objArray1 = new object[] { "寄送撲克牌給隊友 ", str, "(等級 ", item1, ")" };
						user.CardLog(string.Concat(objArray1));
						user.FriendList.RemoveAt(teammateIndex);
					}
				}
			}
			user.teammate_index = -1;
			user.xp = user.xp + num;
			user.coins = user.coins + endData1;
			int num1 = num - 11;
			int num2 = num1;
			user.stage[user.stage_id].case_stars = num1;
			user.current_star = num2;
			int num3 = Convert.ToInt32(user.score);
			if (num3 > user.high_score)
			{
				user.high_score = num3;
			}
			user.energy = user.energy - 20;
			if (user.current_star > 4)
			{
				int num4 = 5;
				int num5 = num4;
				user.stage[user.stage_id].case_stars = num4;
				user.current_star = num5;
				user.energy = user.energy + 15;
			}
			try
			{
				if (user.EndData["response"]["events"] != null)
				{
					foreach (dynamic endDatum in user.EndData["response"]["events"])
					{
						if (endDatum.reward_key == null)
						{
							continue;
						}
						user.RewardLog(cCRequest.result);
						string str2 = (string)("https://apps.facebook.com/criminalcase/reward.php?reward_key=" + endDatum.reward_key + "&sender=" + user.id);
						if (endDatum.type != "level_up")
						{
							str2 = string.Concat(str2, "&reward_type=1");
							object[] objArray2 = new object[] { "[升階獎勵]  (等級", user.level, ")  分享地址：", str2 };
							user.RewardLog(string.Concat(objArray2));
						}
						else
						{
							str2 = string.Concat(str2, "&reward_type=0");
							user.level = (int)endDatum.level;
							user.xp = (int)endDatum.xp;
							user.energy = user.energy;
							object[] objArray3 = new object[] { "[升級獎勵]  (等級", user.level, ")  分享地址：", str2 };
							user.RewardLog(string.Concat(objArray3));
						}
					}
				}
			}
			catch
			{
			}
			user.WriteLog(endData);
			return true;
		}

		public static bool ExamClue()
		{
			string[] strArrays = new string[] { "query={\"action\":\"getFriendList\",\"signature\":\"", user.signature, "\",\"id\":1,\"params\":{\"user\":\"", user.id, "\",\"revision\":\"44\"}}" };
			string.Concat(strArrays);
			byte[] numArray = (new MD5CryptoServiceProvider()).ComputeHash(Encoding.ASCII.GetBytes(string.Concat(user.id, "bauchu")));
			string str = "";
			byte[] numArray1 = numArray;
			for (int i = 0; i < (int)numArray1.Length; i++)
			{
				byte num = numArray1[i];
				str = string.Concat(str, num.ToString("x2"));
			}
			Console.WriteLine(str);
			return true;
		}

		public static bool FeedPet(string pet_id)
		{
			object[] petId = new object[] { "query={\"action\":\"feedPet\",\"signature\":\"", user.signature, "\",\"id\":2,\"params\":{\"user\":\"", user.id, "\",\"foods\":[{\"food\":1,\"pet\":", pet_id, "}],\"revision\":\"44\",\"stage_id\":", Request.Abandon_STAGEID, "}}" };
			string str = string.Concat(petId);
			string empty = string.Empty;
			CCRequest cCRequest = new CCRequest();
			if (!cCRequest.Get(str))
			{
				return false;
			}
			JToken jToken = JToken.Parse(cCRequest.result);
			if (jToken["error"] == null)
			{
				((dynamic)user.data)["response"]["pets"]["adopted"][pet_id]["cooldown"] = 300;
				((dynamic)user.data)["response"]["pets"]["adopted"][pet_id]["loyalty"] = ((dynamic)user.data)["response"]["pets"]["adopted"][pet_id]["loyalty"] + 1;
				try
				{
					Dictionary<string, int> petXp = user.pet_xp;
					Dictionary<string, int> strs = petXp;
					string petId1 = pet_id;
					petXp[petId1] = strs[petId1] + 1;
				}
				catch
				{
					user.pet_xp[pet_id] = 1;
                    return false;
				}
				empty = (string)(string.Concat("[", user.get_pet_name(pet_id), "]Lv:") + ((dynamic)user.data)["response"]["pets"]["adopted"][pet_id]["level"] + "XP:" + user.pet_xp[pet_id] + "Loyalty:" + ((dynamic)user.data)["response"]["pets"]["adopted"][pet_id]["loyalty"]);
				user.PetLog(empty);
			}
			else
			{
				empty = string.Concat((object)"餵食Error:\r\n", jToken, (object)"\r\n");
				try
				{
					((dynamic)user.data)["response"]["pets"]["adopted"] = jToken["error"]["sync"]["pets"]["adopted"];
					user.coins = Convert.ToInt32(jToken["error"]["sync"]["coins"]);
				}
				catch
				{
                    return false;
				}
			}
            return true;
		}

		public static bool FetchCase()
		{
			string empty = string.Empty;
			if (!user.isCaseElite)
			{
				object[] caseId = new object[] { "query={\"signature\":\"", user.signature, "\",\"id\":1,\"action\":\"startCase\",\"params\":{\"case_id\":", user.case_id, ",\"revision\":\"44\",\"user\":\"", user.id, "\"}}" };
				empty = string.Concat(caseId);
			}
			else
			{
				object[] objArray = new object[] { "query={\"signature\":\"", user.signature, "\",\"id\":1,\"action\":\"startCase\",\"params\":{\"case_id\":", user.case_id, ",\"elite\":1,\"revision\":\"44\",\"user\":\"", user.id, "\"}}" };
				empty = string.Concat(objArray);
			}
			Console.WriteLine(empty);
			CCRequest cCRequest = new CCRequest();
			if (!cCRequest.Get(empty))
			{
				return false;
			}
			user.StageData = JToken.Parse(cCRequest.result);
			return true;
		}

		public static bool GetFriendList()
		{
			string[] strArrays = new string[] { "query={\"action\":\"getFriendList\",\"signature\":\"", user.signature, "\",\"id\":1,\"params\":{\"user\":\"", user.id, "\",\"revision\":\"44\"}}" };
			string str = string.Concat(strArrays);
			CCRequest cCRequest = new CCRequest();
			if (!cCRequest.Get(str))
			{
				return false;
			}
			JToken item = JToken.Parse(cCRequest.result)["response"]["friends"];
			user.FriendList.Clear();
			user.GiftFriendList.Clear();
			foreach (JToken jToken in item)
			{
				Friends friend = new Friends()
				{
					uid = (string)jToken["uid"],
					name = (string)jToken["name"],
					level = (int)jToken["level"],
					rank = (int)jToken["rank"],
					hints = (int)jToken["hints"]
				};
				if (jToken["cooldown"] != null)
				{
					friend.cooldown = (int)jToken["cooldown"];
				}
				if ((int)jToken["hints"] == 1)
				{
					continue;
				}
				if (!(bool)jToken["gift_sent"])
				{
					user.GiftFriendList.Add(friend);
				}
				if (jToken["cooldown"] != null)
				{
					continue;
				}
				user.FriendList.Add(friend);
			}
			Request.DinoComparer dinoComparer = new Request.DinoComparer();
			user.FriendList.Sort(dinoComparer);
			foreach (Friends friendList in user.FriendList)
			{
				object[] objArray = new object[] { friendList.name, "|", friendList.level, "hints:", friendList.hints };
				Console.WriteLine(string.Concat(objArray));
			}
			return true;
		}

		public static void GetReport()
		{
			if (Request.SendReportRuest("100008652610301", "4bdedad29c2d2178c8eb1c2e1f58bbf7"))
			{
				user.WriteLog("領取報告 - 1");
			}
			if (Request.SendReportRuest("100008668600287", "9816590c381cebadeb31f7ca85cf87f0"))
			{
				user.WriteLog("領取報告 - 2");
			}
			if (Request.SendReportRuest("100008663771548", "5888cb905510b68e71a3d9640d9d962e"))
			{
				user.WriteLog("領取報告 - 3");
			}
			if (Request.SendReportRuest("100008704682043", "bebfbc96370ca486a3098c18e61609ad"))
			{
				user.WriteLog("領取報告 - 4");
			}
			if (Request.SendReportRuest("100008677594705", "cf121507eb437c14d22988c32927eb48"))
			{
				user.WriteLog("領取報告 - 5");
			}
		}

		public static bool GetUserData()
		{
			string[] strArrays = new string[] { "query={\"action\":\"getUserData\",\"signature\":\"", user.signature, "\",\"id\":0,\"params\":{\"user\":\"", user.id, "\",\"revision\":\"44\"}}" };
			string str = string.Concat(strArrays);
			CCRequest cCRequest = new CCRequest();
			if (!cCRequest.Get(str))
			{
				return false;
			}
			if (cCRequest.result.Length == 0)
			{
				return false;
			}
			user.data = JToken.Parse(cCRequest.result);
			if (((dynamic)user.data).error != (dynamic)null)
			{
				string[] strArrays1 = new string[] { "Error: Login failed\r\nID = ", user.id, "\r\nSignature :", user.signature, "\r\nERROR:" };
				user.WriteLog(string.Concat(strArrays1) + ((dynamic)user.data).error);
				return false;
			}
			if (((dynamic)user.data).response["resume_stage"] != (dynamic)null)
			{
				Request.Abandon_CASEID = (int)((dynamic)user.data).response.resume_stage.case_id;
				Request.Abandon_STAGEID = (int)((dynamic)user.data).response.resume_stage.stage_id;
			}
			int num = 0;
			try
			{
				foreach (object datum in (IEnumerable)((dynamic)user.data).response.stickers_pack.win)
				{
					num += (int)((dynamic)datum);
				}
				user.stickers_pack_count = num;
			}
			catch
			{
				user.stickers_pack_count = 0;
			}
			return true;
		}

		public static bool OpenNextPack()
		{
			string[] strArrays = new string[] { "query={\"id\":1,\"params\":{\"user\":\"", user.id, "\",\"revision\":\"44\"},\"action\":\"openNextPack\",\"signature\":\"", user.signature, "\"}" };
			string str = string.Concat(strArrays);
			CCRequest cCRequest = new CCRequest();
			if (!cCRequest.Get(str))
			{
				return false;
			}
            JToken jToken = JToken.Parse(cCRequest.result)["response"];
            if (jToken != null)
            {
				return true;
			}
			return false;
		}

		public static bool SendAllFriendEnergy()
		{
			while (user.GiftFriendList.Count > 0)
			{
				string item = user.GiftFriendList[0].uid;
				string str = user.GiftFriendList[0].name;
				int num = user.GiftFriendList[0].level;
				if (!Request.SendEnergy(item))
				{
					continue;
				}
				object[] objArray = new object[] { "寄送 2 點能量給 ", str, " ( 等級 ", num, ")" };
				user.CardLog(string.Concat(objArray));
				user.GiftFriendList.RemoveAt(0);
			}
			return true;
		}

		public static bool SendCard(string uid, string key)
		{
			bool flag;
			string[] strArrays = new string[] { "https://imabigfanof.criminalcasegame.com/update_requests.php?to=", uid, "&data=", key, "&sender=", user.id, "&signature=", user.signature, "&type=send_card" };
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(string.Concat(strArrays));
			httpWebRequest.ContentType = "application/x-www-form-urlencoded";
			httpWebRequest.KeepAlive = false;
			httpWebRequest.UserAgent = "Mozilla/5.0 (Windows; U; Windows NT 6.1; ru; rv:1.9.2.3) Gecko/20100401 Firefox/4.0 (.NET CLR 3.5.30729)";
			httpWebRequest.Method = "GET";
			try
			{
				using (HttpWebResponse response = (HttpWebResponse)httpWebRequest.GetResponse())
				{
					using (Stream responseStream = response.GetResponseStream())
					{
						using (StreamReader streamReader = new StreamReader(responseStream))
						{
							Console.WriteLine(streamReader.ReadToEnd());
						}
					}
				}
				flag = true;
			}
			catch
			{
				flag = false;
			}
			return flag;
		}

		public static bool SendEnergy(string uid)
		{
			bool flag;
			string[] strArrays = new string[] { "https://imabigfanof.criminalcasegame.com/update_requests.php?to=", uid, "&data=gift&sender=", user.id, "&signature=", user.signature, "&gift=0" };
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(string.Concat(strArrays));
			httpWebRequest.ContentType = "application/x-www-form-urlencoded";
			httpWebRequest.KeepAlive = false;
			httpWebRequest.UserAgent = "Mozilla/5.0 (Windows; U; Windows NT 6.1; ru; rv:1.9.2.3) Gecko/20100401 Firefox/4.0 (.NET CLR 3.5.30729)";
			httpWebRequest.Method = "GET";
			try
			{
				using (HttpWebResponse response = (HttpWebResponse)httpWebRequest.GetResponse())
				{
					using (Stream responseStream = response.GetResponseStream())
					{
						using (StreamReader streamReader = new StreamReader(responseStream))
						{
							Console.WriteLine(streamReader.ReadToEnd());
						}
					}
				}
				flag = true;
			}
			catch
			{
				flag = false;
			}
			return flag;
		}

		public static bool SendReportRuest(string uid, string signature)
		{
			bool flag;
			string[] strArrays = new string[] { "https://imabigfanof.criminalcasegame.com/update_requests.php?to[]=", uid, "&data=report&sender=", user.id, "&signature=", user.signature };
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(string.Concat(strArrays));
			httpWebRequest.ContentType = "application/x-www-form-urlencoded";
			httpWebRequest.KeepAlive = false;
			httpWebRequest.UserAgent = "Mozilla/5.0 (Windows; U; Windows NT 6.1; ru; rv:1.9.2.3) Gecko/20100401 Firefox/4.0 (.NET CLR 3.5.30729)";
			httpWebRequest.Method = "GET";
			try
			{
				using (HttpWebResponse response = (HttpWebResponse)httpWebRequest.GetResponse())
				{
					using (Stream responseStream = response.GetResponseStream())
					{
						using (StreamReader streamReader = new StreamReader(responseStream))
						{
							streamReader.ReadToEnd();
							string[] strArrays1 = new string[] { "action=reports-accept&friend_id[]=", user.id, "&user_id=", uid, "&signature=", signature };
							string str = string.Concat(strArrays1);
							flag = (!(new CCRequest()).SendGift(str) ? false : true);
						}
					}
				}
			}
			catch
			{
				flag = false;
			}
			return flag;
		}

		public static bool startGame()
		{
			string empty = string.Empty;
			string item = "0";
			if (user.teammate_index >= 0 && user.teammate_index < user.FriendList.Count)
			{
				item = user.FriendList[user.teammate_index].uid;
			}
			else if (user.Loop_USE_TEAMMTE)
			{
				if (user.FriendList.Count <= 0)
				{
					user.isAutoPlay = false;
				}
				else
				{
					item = user.FriendList[0].uid;
					user.teammate_index = 0;
				}
			}
			if (!user.isCaseElite)
			{
				object[] caseId = new object[] { "query={\"signature\":\"", user.signature, "\",\"id\":1,\"action\":\"startStage\",\"params\":{\"revision\":\"44\",\"case_id\":", user.case_id, ",\"stage_id\":", user.stage_id, ",\"teammate_id\":\"", item, "\",\"apply_special_event\":false,\"user\":\"", user.id, "\"}}" };
				empty = string.Concat(caseId);
			}
			else
			{
				object[] objArray = new object[] { "query={\"signature\":\"", user.signature, "\",\"id\":1,\"action\":\"startStage\",\"params\":{\"revision\":\"44\",\"case_id\":", user.case_id, ",\"stage_id\":", user.stage_id, ",\"elite\":\"1\",\"teammate_id\":\"", item, "\",\"apply_special_event\":false,\"user\":\"", user.id, "\"}}" };
				empty = string.Concat(objArray);
			}
			CCRequest cCRequest = new CCRequest();
			if (!cCRequest.Get(empty))
			{
				return false;
			}
			user.StartData = JToken.Parse(cCRequest.result);
			if (((dynamic)user.StartData)["error"] == (dynamic)null)
			{
				return true;
			}
			Console.WriteLine("StartStage出錯");
			Console.WriteLine(empty);
			Console.WriteLine((dynamic)user.StartData);
			return false;
		}

		public class DinoComparer : IComparer<Friends>
		{
			public DinoComparer()
			{
			}

			public int Compare(Friends x, Friends y)
			{
				if (x.hints < y.hints)
				{
					return 1;
				}
				if (x.hints != y.hints)
				{
					return -1;
				}
				if (x.level < y.level)
				{
					return 1;
				}
				if (x.level == y.level)
				{
					return 0;
				}
				return -1;
			}
		}
	}
}