using Microsoft.CSharp.RuntimeBinder;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq.Expressions;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;

namespace AiteCriminal
{
	public static class Request
	{
		public class DinoComparer : IComparer<friends>
		{
			public int Compare(friends x, friends y)
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

		[CompilerGenerated]
		private static class <GetUserData>o__SiteContainer0
		{
			public static CallSite<Func<CallSite, object, bool>> <>p__Site1;

			public static CallSite<Func<CallSite, object, object, object>> <>p__Site2;

			public static CallSite<Func<CallSite, object, object>> <>p__Site3;

			public static CallSite<Action<CallSite, Type, object>> <>p__Site4;

			public static CallSite<Func<CallSite, string, object, object>> <>p__Site5;

			public static CallSite<Func<CallSite, object, object>> <>p__Site6;

			public static CallSite<Func<CallSite, object, bool>> <>p__Site7;

			public static CallSite<Func<CallSite, object, object, object>> <>p__Site8;

			public static CallSite<Func<CallSite, object, string, object>> <>p__Site9;

			public static CallSite<Func<CallSite, object, object>> <>p__Sitea;

			public static CallSite<Func<CallSite, object, int>> <>p__Siteb;

			public static CallSite<Func<CallSite, object, object>> <>p__Sitec;

			public static CallSite<Func<CallSite, object, object>> <>p__Sited;

			public static CallSite<Func<CallSite, object, object>> <>p__Sitee;

			public static CallSite<Func<CallSite, object, int>> <>p__Sitef;

			public static CallSite<Func<CallSite, object, object>> <>p__Site10;

			public static CallSite<Func<CallSite, object, object>> <>p__Site11;

			public static CallSite<Func<CallSite, object, object>> <>p__Site12;

			public static CallSite<Func<CallSite, object, IEnumerable>> <>p__Site13;

			public static CallSite<Func<CallSite, object, object>> <>p__Site14;

			public static CallSite<Func<CallSite, object, object>> <>p__Site15;

			public static CallSite<Func<CallSite, object, object>> <>p__Site16;

			public static CallSite<Func<CallSite, object, int>> <>p__Site17;
		}

		[CompilerGenerated]
		private static class <FeedPet>o__SiteContainer18
		{
			public static CallSite<Func<CallSite, object, string, JToken, object>> <>p__Site19;

			public static CallSite<Func<CallSite, object, string, object>> <>p__Site1a;

			public static CallSite<Func<CallSite, object, string, object>> <>p__Site1b;

			public static CallSite<Func<CallSite, object, string, int, object>> <>p__Site1c;

			public static CallSite<Func<CallSite, object, string, object>> <>p__Site1d;

			public static CallSite<Func<CallSite, object, string, object>> <>p__Site1e;

			public static CallSite<Func<CallSite, object, string, object>> <>p__Site1f;

			public static CallSite<Func<CallSite, object, string, object>> <>p__Site20;

			public static CallSite<Func<CallSite, object, string, object, object>> <>p__Site21;

			public static CallSite<Func<CallSite, object, string, object>> <>p__Site22;

			public static CallSite<Func<CallSite, object, string, object>> <>p__Site23;

			public static CallSite<Func<CallSite, object, string, object>> <>p__Site24;

			public static CallSite<Func<CallSite, object, string, object>> <>p__Site25;

			public static CallSite<Func<CallSite, object, int, object>> <>p__Site26;

			public static CallSite<Func<CallSite, object, string, object>> <>p__Site27;

			public static CallSite<Func<CallSite, object, string, object>> <>p__Site28;

			public static CallSite<Func<CallSite, object, string, object>> <>p__Site29;

			public static CallSite<Func<CallSite, object, string, object>> <>p__Site2a;

			public static CallSite<Func<CallSite, object, string, object>> <>p__Site2b;

			public static CallSite<Func<CallSite, object, string>> <>p__Site2c;

			public static CallSite<Func<CallSite, object, object, object>> <>p__Site2d;

			public static CallSite<Func<CallSite, object, string, object>> <>p__Site2e;

			public static CallSite<Func<CallSite, object, int, object>> <>p__Site2f;

			public static CallSite<Func<CallSite, object, string, object>> <>p__Site30;

			public static CallSite<Func<CallSite, string, object, object>> <>p__Site31;

			public static CallSite<Func<CallSite, object, string, object>> <>p__Site32;

			public static CallSite<Func<CallSite, object, string, object>> <>p__Site33;

			public static CallSite<Func<CallSite, object, string, object>> <>p__Site34;

			public static CallSite<Func<CallSite, object, string, object>> <>p__Site35;

			public static CallSite<Func<CallSite, object, string, object>> <>p__Site36;

			public static CallSite<Func<CallSite, object, string, object>> <>p__Site37;

			public static CallSite<Func<CallSite, object, string, object>> <>p__Site38;

			public static CallSite<Func<CallSite, object, string, object>> <>p__Site39;

			public static CallSite<Func<CallSite, object, string, object>> <>p__Site3a;

			public static CallSite<Func<CallSite, object, string, object>> <>p__Site3b;
		}

		[CompilerGenerated]
		private static class <startGame>o__SiteContainer3c
		{
			public static CallSite<Func<CallSite, object, bool>> <>p__Site3d;

			public static CallSite<Func<CallSite, object, object, object>> <>p__Site3e;

			public static CallSite<Func<CallSite, object, string, object>> <>p__Site3f;

			public static CallSite<Action<CallSite, Type, object>> <>p__Site40;
		}

		[CompilerGenerated]
		private static class <EndGame>o__SiteContainer41
		{
			public static CallSite<Func<CallSite, object, bool>> <>p__Site42;

			public static CallSite<Func<CallSite, object, object, object>> <>p__Site43;

			public static CallSite<Func<CallSite, object, string, object>> <>p__Site44;

			public static CallSite<Func<CallSite, object, int>> <>p__Site45;

			public static CallSite<Func<CallSite, object, object>> <>p__Site46;

			public static CallSite<Func<CallSite, object, object>> <>p__Site47;

			public static CallSite<Func<CallSite, object, int>> <>p__Site48;

			public static CallSite<Func<CallSite, object, object>> <>p__Site49;

			public static CallSite<Func<CallSite, object, object>> <>p__Site4a;

			public static CallSite<Func<CallSite, object, bool>> <>p__Site4b;

			public static CallSite<Func<CallSite, object, object, object>> <>p__Site4c;

			public static CallSite<Func<CallSite, object, string, object>> <>p__Site4d;

			public static CallSite<Func<CallSite, object, string, object>> <>p__Site4e;

			public static CallSite<Action<CallSite, Type, object>> <>p__Site4f;

			public static CallSite<Func<CallSite, object, string, object>> <>p__Site50;

			public static CallSite<Func<CallSite, object, string, object>> <>p__Site51;

			public static CallSite<Func<CallSite, object, string>> <>p__Site52;

			public static CallSite<Func<CallSite, object, object>> <>p__Site53;

			public static CallSite<Func<CallSite, object, object>> <>p__Site54;

			public static CallSite<Func<CallSite, object, bool>> <>p__Site55;

			public static CallSite<Func<CallSite, object, object, object>> <>p__Site56;

			public static CallSite<Func<CallSite, object, string, object>> <>p__Site57;

			public static CallSite<Func<CallSite, object, string, object>> <>p__Site58;

			public static CallSite<Func<CallSite, object, IEnumerable>> <>p__Site59;

			public static CallSite<Func<CallSite, object, string, object>> <>p__Site5a;

			public static CallSite<Func<CallSite, object, string, object>> <>p__Site5b;

			public static CallSite<Func<CallSite, object, bool>> <>p__Site5c;

			public static CallSite<Func<CallSite, object, object, object>> <>p__Site5d;

			public static CallSite<Func<CallSite, object, object>> <>p__Site5e;

			public static CallSite<Func<CallSite, object, string>> <>p__Site5f;

			public static CallSite<Func<CallSite, object, string, object>> <>p__Site60;

			public static CallSite<Func<CallSite, object, string, object>> <>p__Site61;

			public static CallSite<Func<CallSite, string, object, object>> <>p__Site62;

			public static CallSite<Func<CallSite, object, object>> <>p__Site63;

			public static CallSite<Func<CallSite, object, bool>> <>p__Site64;

			public static CallSite<Func<CallSite, object, string, object>> <>p__Site65;

			public static CallSite<Func<CallSite, object, object>> <>p__Site66;

			public static CallSite<Func<CallSite, object, int>> <>p__Site67;

			public static CallSite<Func<CallSite, object, object>> <>p__Site68;

			public static CallSite<Func<CallSite, object, int>> <>p__Site69;

			public static CallSite<Func<CallSite, object, object>> <>p__Site6a;

			public static CallSite<Func<CallSite, object, string>> <>p__Site6b;

			public static CallSite<Func<CallSite, string, object, object>> <>p__Site6c;
		}

		public static int Abandon_CASEID;

		public static int Abandon_STAGEID;

		public static void AcceptGift()
		{
			user.isAcceptGift = true;
			CCRequest cCRequest = new CCRequest();
			if (cCRequest.GetMessage())
			{
				JToken jToken = JToken.Parse(cCRequest.result);
				foreach (JToken current in jToken.get_Item("list"))
				{
					if (current.get_Item("level") != null)
					{
						string text = string.Empty;
						string text2 = (string)current.get_Item("name");
						string a = (string)current.get_Item("type");
						string str = (string)current.get_Item("id");
						string text3 = string.Empty;
						int num = (int)current.get_Item("level");
						if (a == "report" && user.Get_Report)
						{
							text = "action=reports-accept&friend_id[]=" + str;
							if (user.Log_Report)
							{
								text3 = "寄送給 " + text2 + " 解鎖報告";
							}
						}
						else if (a == "gift" && (int)current.get_Item("gift_id") == 0 && user.Get_Energy2)
						{
							string str2 = (string)current.get_Item("key");
							text = "action=gifts-accept&gift_key[]=" + str2;
							if (user.Log_Energy2)
							{
								text3 = string.Concat(new object[]
								{
									text2,
									" (等級 ",
									num,
									")送給您 2 點額外的能量！"
								});
							}
						}
						else if (a == "compensation" && (int)current.get_Item("compensation_id") == 10 && user.Get_Energy1)
						{
							string str3 = (string)current.get_Item("key");
							text = "action=compensations-accept&friend_id=" + str + "&compensation_key[]=" + str3;
							if (user.Log_Energy1)
							{
								text3 = string.Concat(new object[]
								{
									text2,
									" (等級 ",
									num,
									")感謝您送的禮物！請接受這些額外的能量 1 回禮"
								});
							}
						}
						else if (a == "compensation" && (int)current.get_Item("compensation_id") == 0 && user.Get_Card)
						{
							string str4 = (string)current.get_Item("key");
							text = "action=compensations-accept&friend_id=" + str + "&compensation_key[]=" + str4;
							if (user.Log_Card)
							{
								text3 = string.Concat(new object[]
								{
									text2,
									" (等級 ",
									num,
									")您真是位很棒的夥伴！請收下這張撲克牌。"
								});
							}
						}
						if (text.Length > 0)
						{
							string text4 = text;
							text = string.Concat(new string[]
							{
								text4,
								"&user_id=",
								user.id,
								"&signature=",
								user.signature
							});
							Console.WriteLine(text);
							cCRequest = new CCRequest();
							cCRequest.SendGift(text);
							if (text3.Length > 0)
							{
								user.CardLog(text3);
							}
						}
					}
				}
			}
			user.isAcceptGift = false;
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

		public static bool SendReportRuest(string uid, string signature)
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(string.Concat(new string[]
			{
				"https://imabigfanof.criminalcasegame.com/update_requests.php?to[]=",
				uid,
				"&data=report&sender=",
				user.id,
				"&signature=",
				user.signature
			}));
			httpWebRequest.ContentType = "application/x-www-form-urlencoded";
			httpWebRequest.KeepAlive = false;
			httpWebRequest.UserAgent = "Mozilla/5.0 (Windows; U; Windows NT 6.1; ru; rv:1.9.2.3) Gecko/20100401 Firefox/4.0 (.NET CLR 3.5.30729)";
			httpWebRequest.Method = "GET";
			bool result;
			try
			{
				using (HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse())
				{
					using (Stream responseStream = httpWebResponse.GetResponseStream())
					{
						using (StreamReader streamReader = new StreamReader(responseStream))
						{
							streamReader.ReadToEnd();
							string data = string.Concat(new string[]
							{
								"action=reports-accept&friend_id[]=",
								user.id,
								"&user_id=",
								uid,
								"&signature=",
								signature
							});
							CCRequest cCRequest = new CCRequest();
							if (cCRequest.SendGift(data))
							{
								result = true;
							}
							else
							{
								result = false;
							}
						}
					}
				}
			}
			catch (Exception)
			{
				result = false;
			}
			return result;
		}

		public static bool CollectDailyBonus()
		{
			string data = string.Concat(new string[]
			{
				"query={\"id\":1,\"params\":{\"user\":\"",
				user.id,
				"\",\"revision\":\"44\"},\"action\":\"collectDailyBonus\",\"signature\":\"",
				user.signature,
				"\"}"
			});
			CCRequest cCRequest = new CCRequest();
			if (!cCRequest.Get(data))
			{
				return false;
			}
			JToken jToken = JToken.Parse(cCRequest.result).get_Item("response");
			if (jToken != null)
			{
				Console.WriteLine("領取當日紅利");
			}
			return true;
		}

		public static bool OpenNextPack()
		{
			string data = string.Concat(new string[]
			{
				"query={\"id\":1,\"params\":{\"user\":\"",
				user.id,
				"\",\"revision\":\"44\"},\"action\":\"openNextPack\",\"signature\":\"",
				user.signature,
				"\"}"
			});
			CCRequest cCRequest = new CCRequest();
			return cCRequest.Get(data) && JToken.Parse(cCRequest.result).get_Item("response") != null;
		}

		public static bool GetFriendList()
		{
			string data = string.Concat(new string[]
			{
				"query={\"action\":\"getFriendList\",\"signature\":\"",
				user.signature,
				"\",\"id\":1,\"params\":{\"user\":\"",
				user.id,
				"\",\"revision\":\"44\"}}"
			});
			CCRequest cCRequest = new CCRequest();
			if (!cCRequest.Get(data))
			{
				return false;
			}
			JToken jToken = JToken.Parse(cCRequest.result).get_Item("response").get_Item("friends");
			user.FriendList.Clear();
			user.GiftFriendList.Clear();
			foreach (JToken current in jToken)
			{
				friends friends = new friends();
				friends.uid = (string)current.get_Item("uid");
				friends.name = (string)current.get_Item("name");
				friends.level = (int)current.get_Item("level");
				friends.rank = (int)current.get_Item("rank");
				friends.hints = (int)current.get_Item("hints");
				if (current.get_Item("cooldown") != null)
				{
					friends.cooldown = (int)current.get_Item("cooldown");
				}
				if ((int)current.get_Item("hints") != 1)
				{
					if (!(bool)current.get_Item("gift_sent"))
					{
						user.GiftFriendList.Add(friends);
					}
					if (current.get_Item("cooldown") == null)
					{
						user.FriendList.Add(friends);
					}
				}
			}
			Request.DinoComparer comparer = new Request.DinoComparer();
			user.FriendList.Sort(comparer);
			foreach (friends current2 in user.FriendList)
			{
				Console.WriteLine(string.Concat(new object[]
				{
					current2.name,
					"|",
					current2.level,
					"hints:",
					current2.hints
				}));
			}
			return true;
		}

		public static bool ExamClue()
		{
			string.Concat(new string[]
			{
				"query={\"action\":\"getFriendList\",\"signature\":\"",
				user.signature,
				"\",\"id\":1,\"params\":{\"user\":\"",
				user.id,
				"\",\"revision\":\"44\"}}"
			});
			byte[] array = new MD5CryptoServiceProvider().ComputeHash(Encoding.ASCII.GetBytes(user.id + "bauchu"));
			string text = "";
			byte[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				byte b = array2[i];
				text += b.ToString("x2");
			}
			Console.WriteLine(text);
			return true;
		}

		public static bool GetUserData()
		{
			string data = string.Concat(new string[]
			{
				"query={\"action\":\"getUserData\",\"signature\":\"",
				user.signature,
				"\",\"id\":0,\"params\":{\"user\":\"",
				user.id,
				"\",\"revision\":\"44\"}}"
			});
			CCRequest cCRequest = new CCRequest();
			if (!cCRequest.Get(data))
			{
				return false;
			}
			if (cCRequest.result.Length == 0)
			{
				return false;
			}
			user.data = JToken.Parse(cCRequest.result);
			if (Request.<GetUserData>o__SiteContainer0.<>p__Site1 == null)
			{
				Request.<GetUserData>o__SiteContainer0.<>p__Site1 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Request), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			Func<CallSite, object, bool> arg_160_0 = Request.<GetUserData>o__SiteContainer0.<>p__Site1.Target;
			CallSite arg_160_1 = Request.<GetUserData>o__SiteContainer0.<>p__Site1;
			if (Request.<GetUserData>o__SiteContainer0.<>p__Site2 == null)
			{
				Request.<GetUserData>o__SiteContainer0.<>p__Site2 = CallSite<Func<CallSite, object, object, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.NotEqual, typeof(Request), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, object, object> arg_15B_0 = Request.<GetUserData>o__SiteContainer0.<>p__Site2.Target;
			CallSite arg_15B_1 = Request.<GetUserData>o__SiteContainer0.<>p__Site2;
			if (Request.<GetUserData>o__SiteContainer0.<>p__Site3 == null)
			{
				Request.<GetUserData>o__SiteContainer0.<>p__Site3 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "error", typeof(Request), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			if (arg_160_0(arg_160_1, arg_15B_0(arg_15B_1, Request.<GetUserData>o__SiteContainer0.<>p__Site3.Target(Request.<GetUserData>o__SiteContainer0.<>p__Site3, user.data), null)))
			{
				if (Request.<GetUserData>o__SiteContainer0.<>p__Site4 == null)
				{
					Request.<GetUserData>o__SiteContainer0.<>p__Site4 = CallSite<Action<CallSite, Type, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "WriteLog", null, typeof(Request), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Action<CallSite, Type, object> arg_2B5_0 = Request.<GetUserData>o__SiteContainer0.<>p__Site4.Target;
				CallSite arg_2B5_1 = Request.<GetUserData>o__SiteContainer0.<>p__Site4;
				Type arg_2B5_2 = typeof(user);
				if (Request.<GetUserData>o__SiteContainer0.<>p__Site5 == null)
				{
					Request.<GetUserData>o__SiteContainer0.<>p__Site5 = CallSite<Func<CallSite, string, object, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Add, typeof(Request), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, string, object, object> arg_2B0_0 = Request.<GetUserData>o__SiteContainer0.<>p__Site5.Target;
				CallSite arg_2B0_1 = Request.<GetUserData>o__SiteContainer0.<>p__Site5;
				string arg_2B0_2 = string.Concat(new string[]
				{
					"Error: Login failed\r\nID = ",
					user.id,
					"\r\nSignature :",
					user.signature,
					"\r\nERROR:"
				});
				if (Request.<GetUserData>o__SiteContainer0.<>p__Site6 == null)
				{
					Request.<GetUserData>o__SiteContainer0.<>p__Site6 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "error", typeof(Request), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				arg_2B5_0(arg_2B5_1, arg_2B5_2, arg_2B0_0(arg_2B0_1, arg_2B0_2, Request.<GetUserData>o__SiteContainer0.<>p__Site6.Target(Request.<GetUserData>o__SiteContainer0.<>p__Site6, user.data)));
				return false;
			}
			if (Request.<GetUserData>o__SiteContainer0.<>p__Site7 == null)
			{
				Request.<GetUserData>o__SiteContainer0.<>p__Site7 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Request), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			Func<CallSite, object, bool> arg_40A_0 = Request.<GetUserData>o__SiteContainer0.<>p__Site7.Target;
			CallSite arg_40A_1 = Request.<GetUserData>o__SiteContainer0.<>p__Site7;
			if (Request.<GetUserData>o__SiteContainer0.<>p__Site8 == null)
			{
				Request.<GetUserData>o__SiteContainer0.<>p__Site8 = CallSite<Func<CallSite, object, object, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.NotEqual, typeof(Request), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, object, object> arg_405_0 = Request.<GetUserData>o__SiteContainer0.<>p__Site8.Target;
			CallSite arg_405_1 = Request.<GetUserData>o__SiteContainer0.<>p__Site8;
			if (Request.<GetUserData>o__SiteContainer0.<>p__Site9 == null)
			{
				Request.<GetUserData>o__SiteContainer0.<>p__Site9 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Request), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, string, object> arg_3FF_0 = Request.<GetUserData>o__SiteContainer0.<>p__Site9.Target;
			CallSite arg_3FF_1 = Request.<GetUserData>o__SiteContainer0.<>p__Site9;
			if (Request.<GetUserData>o__SiteContainer0.<>p__Sitea == null)
			{
				Request.<GetUserData>o__SiteContainer0.<>p__Sitea = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.ResultIndexed, "response", typeof(Request), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			if (arg_40A_0(arg_40A_1, arg_405_0(arg_405_1, arg_3FF_0(arg_3FF_1, Request.<GetUserData>o__SiteContainer0.<>p__Sitea.Target(Request.<GetUserData>o__SiteContainer0.<>p__Sitea, user.data), "resume_stage"), null)))
			{
				if (Request.<GetUserData>o__SiteContainer0.<>p__Siteb == null)
				{
					Request.<GetUserData>o__SiteContainer0.<>p__Siteb = CallSite<Func<CallSite, object, int>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(int), typeof(Request)));
				}
				Func<CallSite, object, int> arg_540_0 = Request.<GetUserData>o__SiteContainer0.<>p__Siteb.Target;
				CallSite arg_540_1 = Request.<GetUserData>o__SiteContainer0.<>p__Siteb;
				if (Request.<GetUserData>o__SiteContainer0.<>p__Sitec == null)
				{
					Request.<GetUserData>o__SiteContainer0.<>p__Sitec = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "case_id", typeof(Request), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, object, object> arg_53B_0 = Request.<GetUserData>o__SiteContainer0.<>p__Sitec.Target;
				CallSite arg_53B_1 = Request.<GetUserData>o__SiteContainer0.<>p__Sitec;
				if (Request.<GetUserData>o__SiteContainer0.<>p__Sited == null)
				{
					Request.<GetUserData>o__SiteContainer0.<>p__Sited = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "resume_stage", typeof(Request), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, object, object> arg_536_0 = Request.<GetUserData>o__SiteContainer0.<>p__Sited.Target;
				CallSite arg_536_1 = Request.<GetUserData>o__SiteContainer0.<>p__Sited;
				if (Request.<GetUserData>o__SiteContainer0.<>p__Sitee == null)
				{
					Request.<GetUserData>o__SiteContainer0.<>p__Sitee = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "response", typeof(Request), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Request.Abandon_CASEID = arg_540_0(arg_540_1, arg_53B_0(arg_53B_1, arg_536_0(arg_536_1, Request.<GetUserData>o__SiteContainer0.<>p__Sitee.Target(Request.<GetUserData>o__SiteContainer0.<>p__Sitee, user.data))));
				if (Request.<GetUserData>o__SiteContainer0.<>p__Sitef == null)
				{
					Request.<GetUserData>o__SiteContainer0.<>p__Sitef = CallSite<Func<CallSite, object, int>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(int), typeof(Request)));
				}
				Func<CallSite, object, int> arg_676_0 = Request.<GetUserData>o__SiteContainer0.<>p__Sitef.Target;
				CallSite arg_676_1 = Request.<GetUserData>o__SiteContainer0.<>p__Sitef;
				if (Request.<GetUserData>o__SiteContainer0.<>p__Site10 == null)
				{
					Request.<GetUserData>o__SiteContainer0.<>p__Site10 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "stage_id", typeof(Request), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, object, object> arg_671_0 = Request.<GetUserData>o__SiteContainer0.<>p__Site10.Target;
				CallSite arg_671_1 = Request.<GetUserData>o__SiteContainer0.<>p__Site10;
				if (Request.<GetUserData>o__SiteContainer0.<>p__Site11 == null)
				{
					Request.<GetUserData>o__SiteContainer0.<>p__Site11 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "resume_stage", typeof(Request), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, object, object> arg_66C_0 = Request.<GetUserData>o__SiteContainer0.<>p__Site11.Target;
				CallSite arg_66C_1 = Request.<GetUserData>o__SiteContainer0.<>p__Site11;
				if (Request.<GetUserData>o__SiteContainer0.<>p__Site12 == null)
				{
					Request.<GetUserData>o__SiteContainer0.<>p__Site12 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "response", typeof(Request), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Request.Abandon_STAGEID = arg_676_0(arg_676_1, arg_671_0(arg_671_1, arg_66C_0(arg_66C_1, Request.<GetUserData>o__SiteContainer0.<>p__Site12.Target(Request.<GetUserData>o__SiteContainer0.<>p__Site12, user.data))));
			}
			int num = 0;
			try
			{
				if (Request.<GetUserData>o__SiteContainer0.<>p__Site13 == null)
				{
					Request.<GetUserData>o__SiteContainer0.<>p__Site13 = CallSite<Func<CallSite, object, IEnumerable>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(IEnumerable), typeof(Request)));
				}
				Func<CallSite, object, IEnumerable> arg_7AE_0 = Request.<GetUserData>o__SiteContainer0.<>p__Site13.Target;
				CallSite arg_7AE_1 = Request.<GetUserData>o__SiteContainer0.<>p__Site13;
				if (Request.<GetUserData>o__SiteContainer0.<>p__Site14 == null)
				{
					Request.<GetUserData>o__SiteContainer0.<>p__Site14 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "win", typeof(Request), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, object, object> arg_7A9_0 = Request.<GetUserData>o__SiteContainer0.<>p__Site14.Target;
				CallSite arg_7A9_1 = Request.<GetUserData>o__SiteContainer0.<>p__Site14;
				if (Request.<GetUserData>o__SiteContainer0.<>p__Site15 == null)
				{
					Request.<GetUserData>o__SiteContainer0.<>p__Site15 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "stickers_pack", typeof(Request), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, object, object> arg_7A4_0 = Request.<GetUserData>o__SiteContainer0.<>p__Site15.Target;
				CallSite arg_7A4_1 = Request.<GetUserData>o__SiteContainer0.<>p__Site15;
				if (Request.<GetUserData>o__SiteContainer0.<>p__Site16 == null)
				{
					Request.<GetUserData>o__SiteContainer0.<>p__Site16 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "response", typeof(Request), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				using (IEnumerator enumerator = arg_7AE_0(arg_7AE_1, arg_7A9_0(arg_7A9_1, arg_7A4_0(arg_7A4_1, Request.<GetUserData>o__SiteContainer0.<>p__Site16.Target(Request.<GetUserData>o__SiteContainer0.<>p__Site16, user.data)))).GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (Request.<GetUserData>o__SiteContainer0.<>p__Site17 == null)
						{
							Request.<GetUserData>o__SiteContainer0.<>p__Site17 = CallSite<Func<CallSite, object, int>>.Create(Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(int), typeof(Request)));
						}
						int num2 = Request.<GetUserData>o__SiteContainer0.<>p__Site17.Target(Request.<GetUserData>o__SiteContainer0.<>p__Site17, enumerator.Current);
						num += num2;
					}
				}
				user.stickers_pack_count = num;
			}
			catch
			{
				user.stickers_pack_count = 0;
			}
			return true;
		}

		public static bool Eat(int food_id)
		{
			string data = string.Concat(new object[]
			{
				"query={\"signature\":\"",
				user.signature,
				"\",\"id\":2,\"action\":\"useFood\",\"params\":{\"food_id\":\"food_",
				food_id,
				"\",\"revision\":\"44\",\"user\":\"",
				user.id,
				"\"}}"
			});
			CCRequest cCRequest = new CCRequest();
			if (!cCRequest.Get(data))
			{
				return false;
			}
			JToken jToken = JToken.Parse(cCRequest.result);
			if (jToken.get_Item("error") != null)
			{
				try
				{
					user.energy = (int)jToken.get_Item("error").get_Item("sync").get_Item("energy");
					user.food_0 = (int)jToken.get_Item("error").get_Item("sync").get_Item("inventory").get_Item("food_0");
					user.food_1 = (int)jToken.get_Item("error").get_Item("sync").get_Item("inventory").get_Item("food_1");
					user.food_2 = (int)jToken.get_Item("error").get_Item("sync").get_Item("inventory").get_Item("food_2");
					bool result = true;
					return result;
				}
				catch
				{
					bool result = false;
					return result;
				}
			}
			if (food_id == 2)
			{
				user.energy = (int)jToken.get_Item("response").get_Item("energy");
				user.food_2--;
			}
			else if (food_id == 1)
			{
				user.energy = (int)jToken.get_Item("response").get_Item("energy");
				user.food_1--;
			}
			else if (food_id == 0)
			{
				user.energy = (int)jToken.get_Item("response").get_Item("energy");
				user.food_0--;
			}
			return true;
		}

		public static bool FetchCase()
		{
			string text = string.Empty;
			if (user.isCaseElite)
			{
				text = string.Concat(new object[]
				{
					"query={\"signature\":\"",
					user.signature,
					"\",\"id\":1,\"action\":\"startCase\",\"params\":{\"case_id\":",
					user.case_id,
					",\"elite\":1,\"revision\":\"44\",\"user\":\"",
					user.id,
					"\"}}"
				});
			}
			else
			{
				text = string.Concat(new object[]
				{
					"query={\"signature\":\"",
					user.signature,
					"\",\"id\":1,\"action\":\"startCase\",\"params\":{\"case_id\":",
					user.case_id,
					",\"revision\":\"44\",\"user\":\"",
					user.id,
					"\"}}"
				});
			}
			Console.WriteLine(text);
			CCRequest cCRequest = new CCRequest();
			if (!cCRequest.Get(text))
			{
				return false;
			}
			user.StageData = JToken.Parse(cCRequest.result);
			return true;
		}

		public static bool SendAllFriendEnergy()
		{
			while (user.GiftFriendList.Count > 0)
			{
				string uid = user.GiftFriendList[0].uid;
				string name = user.GiftFriendList[0].name;
				int level = user.GiftFriendList[0].level;
				if (Request.SendEnergy(uid))
				{
					user.CardLog(string.Concat(new object[]
					{
						"寄送 2 點能量給 ",
						name,
						" ( 等級 ",
						level,
						")"
					}));
					user.GiftFriendList.RemoveAt(0);
				}
			}
			return true;
		}

		public static bool SendEnergy(string uid)
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(string.Concat(new string[]
			{
				"https://imabigfanof.criminalcasegame.com/update_requests.php?to=",
				uid,
				"&data=gift&sender=",
				user.id,
				"&signature=",
				user.signature,
				"&gift=0"
			}));
			httpWebRequest.ContentType = "application/x-www-form-urlencoded";
			httpWebRequest.KeepAlive = false;
			httpWebRequest.UserAgent = "Mozilla/5.0 (Windows; U; Windows NT 6.1; ru; rv:1.9.2.3) Gecko/20100401 Firefox/4.0 (.NET CLR 3.5.30729)";
			httpWebRequest.Method = "GET";
			bool result;
			try
			{
				using (HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse())
				{
					using (Stream responseStream = httpWebResponse.GetResponseStream())
					{
						using (StreamReader streamReader = new StreamReader(responseStream))
						{
							string value = streamReader.ReadToEnd();
							Console.WriteLine(value);
						}
					}
				}
				result = true;
			}
			catch (Exception)
			{
				result = false;
			}
			return result;
		}

		public static bool SendCard(string uid, string key)
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(string.Concat(new string[]
			{
				"https://imabigfanof.criminalcasegame.com/update_requests.php?to=",
				uid,
				"&data=",
				key,
				"&sender=",
				user.id,
				"&signature=",
				user.signature,
				"&type=send_card"
			}));
			httpWebRequest.ContentType = "application/x-www-form-urlencoded";
			httpWebRequest.KeepAlive = false;
			httpWebRequest.UserAgent = "Mozilla/5.0 (Windows; U; Windows NT 6.1; ru; rv:1.9.2.3) Gecko/20100401 Firefox/4.0 (.NET CLR 3.5.30729)";
			httpWebRequest.Method = "GET";
			bool result;
			try
			{
				using (HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse())
				{
					using (Stream responseStream = httpWebResponse.GetResponseStream())
					{
						using (StreamReader streamReader = new StreamReader(responseStream))
						{
							string value = streamReader.ReadToEnd();
							Console.WriteLine(value);
						}
					}
				}
				result = true;
			}
			catch (Exception)
			{
				result = false;
			}
			return result;
		}

		public static bool BuyAllStarBurners(int BuyAllStarBurners)
		{
			string text = string.Empty;
			if (user.isCaseElite)
			{
				text = string.Concat(new object[]
				{
					"query={\"signature\":\"",
					user.signature,
					"\",\"id\":1,\"action\":\"buyAllStarBurners\",\"params\":{\"case_id\":",
					user.case_id,
					",\"elite\":1,\"revision\":\"44\",\"star_burner_id_list\":[",
					BuyAllStarBurners,
					"],\"user\":\"",
					user.id,
					"\"}}"
				});
			}
			else
			{
				text = string.Concat(new object[]
				{
					"query={\"signature\":\"",
					user.signature,
					"\",\"id\":1,\"action\":\"buyAllStarBurners\",\"params\":{\"case_id\":",
					user.case_id,
					",\"revision\":\"44\",\"user\":\"",
					user.id,
					"\",\"star_burner_id_list\":[",
					BuyAllStarBurners,
					"]}}"
				});
			}
			Console.WriteLine(text);
			CCRequest cCRequest = new CCRequest();
			if (!cCRequest.Get(text))
			{
				return false;
			}
			JToken jToken = JToken.Parse(cCRequest.result);
			bool result;
			try
			{
				if ((bool)jToken.get_Item("response").get_Item("success"))
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

		public static void FeedPet(string pet_id)
		{
			string data = string.Concat(new object[]
			{
				"query={\"action\":\"feedPet\",\"signature\":\"",
				user.signature,
				"\",\"id\":2,\"params\":{\"user\":\"",
				user.id,
				"\",\"foods\":[{\"food\":1,\"pet\":",
				pet_id,
				"}],\"revision\":\"44\",\"stage_id\":",
				Request.Abandon_STAGEID,
				"}}"
			});
			string sErrMsg = string.Empty;
			CCRequest cCRequest = new CCRequest();
			if (!cCRequest.Get(data))
			{
				return;
			}
			JToken jToken = JToken.Parse(cCRequest.result);
			if (jToken.get_Item("error") != null)
			{
				sErrMsg = "餵食Error:\r\n" + jToken + "\r\n";
				try
				{
					if (Request.<FeedPet>o__SiteContainer18.<>p__Site19 == null)
					{
						Request.<FeedPet>o__SiteContainer18.<>p__Site19 = CallSite<Func<CallSite, object, string, JToken, object>>.Create(Binder.SetIndex(CSharpBinderFlags.None, typeof(Request), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
						}));
					}
					Func<CallSite, object, string, JToken, object> arg_1E8_0 = Request.<FeedPet>o__SiteContainer18.<>p__Site19.Target;
					CallSite arg_1E8_1 = Request.<FeedPet>o__SiteContainer18.<>p__Site19;
					if (Request.<FeedPet>o__SiteContainer18.<>p__Site1a == null)
					{
						Request.<FeedPet>o__SiteContainer18.<>p__Site1a = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Request), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					Func<CallSite, object, string, object> arg_1B5_0 = Request.<FeedPet>o__SiteContainer18.<>p__Site1a.Target;
					CallSite arg_1B5_1 = Request.<FeedPet>o__SiteContainer18.<>p__Site1a;
					if (Request.<FeedPet>o__SiteContainer18.<>p__Site1b == null)
					{
						Request.<FeedPet>o__SiteContainer18.<>p__Site1b = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Request), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					arg_1E8_0(arg_1E8_1, arg_1B5_0(arg_1B5_1, Request.<FeedPet>o__SiteContainer18.<>p__Site1b.Target(Request.<FeedPet>o__SiteContainer18.<>p__Site1b, user.data, "response"), "pets"), "adopted", jToken.get_Item("error").get_Item("sync").get_Item("pets").get_Item("adopted"));
					user.coins = Convert.ToInt32(jToken.get_Item("error").get_Item("sync").get_Item("coins"));
					return;
				}
				catch
				{
					return;
				}
			}
			if (Request.<FeedPet>o__SiteContainer18.<>p__Site1c == null)
			{
				Request.<FeedPet>o__SiteContainer18.<>p__Site1c = CallSite<Func<CallSite, object, string, int, object>>.Create(Binder.SetIndex(CSharpBinderFlags.None, typeof(Request), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, string, int, object> arg_3F0_0 = Request.<FeedPet>o__SiteContainer18.<>p__Site1c.Target;
			CallSite arg_3F0_1 = Request.<FeedPet>o__SiteContainer18.<>p__Site1c;
			if (Request.<FeedPet>o__SiteContainer18.<>p__Site1d == null)
			{
				Request.<FeedPet>o__SiteContainer18.<>p__Site1d = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Request), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
				}));
			}
			Func<CallSite, object, string, object> arg_3E1_0 = Request.<FeedPet>o__SiteContainer18.<>p__Site1d.Target;
			CallSite arg_3E1_1 = Request.<FeedPet>o__SiteContainer18.<>p__Site1d;
			if (Request.<FeedPet>o__SiteContainer18.<>p__Site1e == null)
			{
				Request.<FeedPet>o__SiteContainer18.<>p__Site1e = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Request), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, string, object> arg_3DB_0 = Request.<FeedPet>o__SiteContainer18.<>p__Site1e.Target;
			CallSite arg_3DB_1 = Request.<FeedPet>o__SiteContainer18.<>p__Site1e;
			if (Request.<FeedPet>o__SiteContainer18.<>p__Site1f == null)
			{
				Request.<FeedPet>o__SiteContainer18.<>p__Site1f = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Request), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, string, object> arg_3D1_0 = Request.<FeedPet>o__SiteContainer18.<>p__Site1f.Target;
			CallSite arg_3D1_1 = Request.<FeedPet>o__SiteContainer18.<>p__Site1f;
			if (Request.<FeedPet>o__SiteContainer18.<>p__Site20 == null)
			{
				Request.<FeedPet>o__SiteContainer18.<>p__Site20 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Request), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			arg_3F0_0(arg_3F0_1, arg_3E1_0(arg_3E1_1, arg_3DB_0(arg_3DB_1, arg_3D1_0(arg_3D1_1, Request.<FeedPet>o__SiteContainer18.<>p__Site20.Target(Request.<FeedPet>o__SiteContainer18.<>p__Site20, user.data, "response"), "pets"), "adopted"), pet_id), "cooldown", 300);
			if (Request.<FeedPet>o__SiteContainer18.<>p__Site21 == null)
			{
				Request.<FeedPet>o__SiteContainer18.<>p__Site21 = CallSite<Func<CallSite, object, string, object, object>>.Create(Binder.SetIndex(CSharpBinderFlags.None, typeof(Request), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			Func<CallSite, object, string, object, object> arg_7D9_0 = Request.<FeedPet>o__SiteContainer18.<>p__Site21.Target;
			CallSite arg_7D9_1 = Request.<FeedPet>o__SiteContainer18.<>p__Site21;
			if (Request.<FeedPet>o__SiteContainer18.<>p__Site22 == null)
			{
				Request.<FeedPet>o__SiteContainer18.<>p__Site22 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Request), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
				}));
			}
			Func<CallSite, object, string, object> arg_5B5_0 = Request.<FeedPet>o__SiteContainer18.<>p__Site22.Target;
			CallSite arg_5B5_1 = Request.<FeedPet>o__SiteContainer18.<>p__Site22;
			if (Request.<FeedPet>o__SiteContainer18.<>p__Site23 == null)
			{
				Request.<FeedPet>o__SiteContainer18.<>p__Site23 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Request), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, string, object> arg_5AF_0 = Request.<FeedPet>o__SiteContainer18.<>p__Site23.Target;
			CallSite arg_5AF_1 = Request.<FeedPet>o__SiteContainer18.<>p__Site23;
			if (Request.<FeedPet>o__SiteContainer18.<>p__Site24 == null)
			{
				Request.<FeedPet>o__SiteContainer18.<>p__Site24 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Request), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, string, object> arg_5A5_0 = Request.<FeedPet>o__SiteContainer18.<>p__Site24.Target;
			CallSite arg_5A5_1 = Request.<FeedPet>o__SiteContainer18.<>p__Site24;
			if (Request.<FeedPet>o__SiteContainer18.<>p__Site25 == null)
			{
				Request.<FeedPet>o__SiteContainer18.<>p__Site25 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Request), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			object arg_7D9_2 = arg_5B5_0(arg_5B5_1, arg_5AF_0(arg_5AF_1, arg_5A5_0(arg_5A5_1, Request.<FeedPet>o__SiteContainer18.<>p__Site25.Target(Request.<FeedPet>o__SiteContainer18.<>p__Site25, user.data, "response"), "pets"), "adopted"), pet_id);
			string arg_7D9_3 = "loyalty";
			if (Request.<FeedPet>o__SiteContainer18.<>p__Site26 == null)
			{
				Request.<FeedPet>o__SiteContainer18.<>p__Site26 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Add, typeof(Request), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, int, object> arg_7D4_0 = Request.<FeedPet>o__SiteContainer18.<>p__Site26.Target;
			CallSite arg_7D4_1 = Request.<FeedPet>o__SiteContainer18.<>p__Site26;
			if (Request.<FeedPet>o__SiteContainer18.<>p__Site27 == null)
			{
				Request.<FeedPet>o__SiteContainer18.<>p__Site27 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Request), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, string, object> arg_7CE_0 = Request.<FeedPet>o__SiteContainer18.<>p__Site27.Target;
			CallSite arg_7CE_1 = Request.<FeedPet>o__SiteContainer18.<>p__Site27;
			if (Request.<FeedPet>o__SiteContainer18.<>p__Site28 == null)
			{
				Request.<FeedPet>o__SiteContainer18.<>p__Site28 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Request), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
				}));
			}
			Func<CallSite, object, string, object> arg_7C4_0 = Request.<FeedPet>o__SiteContainer18.<>p__Site28.Target;
			CallSite arg_7C4_1 = Request.<FeedPet>o__SiteContainer18.<>p__Site28;
			if (Request.<FeedPet>o__SiteContainer18.<>p__Site29 == null)
			{
				Request.<FeedPet>o__SiteContainer18.<>p__Site29 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Request), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, string, object> arg_7BE_0 = Request.<FeedPet>o__SiteContainer18.<>p__Site29.Target;
			CallSite arg_7BE_1 = Request.<FeedPet>o__SiteContainer18.<>p__Site29;
			if (Request.<FeedPet>o__SiteContainer18.<>p__Site2a == null)
			{
				Request.<FeedPet>o__SiteContainer18.<>p__Site2a = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Request), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, string, object> arg_7B4_0 = Request.<FeedPet>o__SiteContainer18.<>p__Site2a.Target;
			CallSite arg_7B4_1 = Request.<FeedPet>o__SiteContainer18.<>p__Site2a;
			if (Request.<FeedPet>o__SiteContainer18.<>p__Site2b == null)
			{
				Request.<FeedPet>o__SiteContainer18.<>p__Site2b = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Request), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			arg_7D9_0(arg_7D9_1, arg_7D9_2, arg_7D9_3, arg_7D4_0(arg_7D4_1, arg_7CE_0(arg_7CE_1, arg_7C4_0(arg_7C4_1, arg_7BE_0(arg_7BE_1, arg_7B4_0(arg_7B4_1, Request.<FeedPet>o__SiteContainer18.<>p__Site2b.Target(Request.<FeedPet>o__SiteContainer18.<>p__Site2b, user.data, "response"), "pets"), "adopted"), pet_id), "loyalty"), 1));
			try
			{
				Dictionary<string, int> pet_xp;
				(pet_xp = user.pet_xp)[pet_id] = pet_xp[pet_id] + 1;
			}
			catch
			{
				user.pet_xp[pet_id] = 1;
			}
			if (Request.<FeedPet>o__SiteContainer18.<>p__Site2c == null)
			{
				Request.<FeedPet>o__SiteContainer18.<>p__Site2c = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(Request)));
			}
			Func<CallSite, object, string> arg_DA4_0 = Request.<FeedPet>o__SiteContainer18.<>p__Site2c.Target;
			CallSite arg_DA4_1 = Request.<FeedPet>o__SiteContainer18.<>p__Site2c;
			if (Request.<FeedPet>o__SiteContainer18.<>p__Site2d == null)
			{
				Request.<FeedPet>o__SiteContainer18.<>p__Site2d = CallSite<Func<CallSite, object, object, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Add, typeof(Request), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			Func<CallSite, object, object, object> arg_D9F_0 = Request.<FeedPet>o__SiteContainer18.<>p__Site2d.Target;
			CallSite arg_D9F_1 = Request.<FeedPet>o__SiteContainer18.<>p__Site2d;
			if (Request.<FeedPet>o__SiteContainer18.<>p__Site2e == null)
			{
				Request.<FeedPet>o__SiteContainer18.<>p__Site2e = CallSite<Func<CallSite, object, string, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Add, typeof(Request), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, string, object> arg_BD7_0 = Request.<FeedPet>o__SiteContainer18.<>p__Site2e.Target;
			CallSite arg_BD7_1 = Request.<FeedPet>o__SiteContainer18.<>p__Site2e;
			if (Request.<FeedPet>o__SiteContainer18.<>p__Site2f == null)
			{
				Request.<FeedPet>o__SiteContainer18.<>p__Site2f = CallSite<Func<CallSite, object, int, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Add, typeof(Request), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
				}));
			}
			Func<CallSite, object, int, object> arg_BCD_0 = Request.<FeedPet>o__SiteContainer18.<>p__Site2f.Target;
			CallSite arg_BCD_1 = Request.<FeedPet>o__SiteContainer18.<>p__Site2f;
			if (Request.<FeedPet>o__SiteContainer18.<>p__Site30 == null)
			{
				Request.<FeedPet>o__SiteContainer18.<>p__Site30 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Add, typeof(Request), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, string, object> arg_BBD_0 = Request.<FeedPet>o__SiteContainer18.<>p__Site30.Target;
			CallSite arg_BBD_1 = Request.<FeedPet>o__SiteContainer18.<>p__Site30;
			if (Request.<FeedPet>o__SiteContainer18.<>p__Site31 == null)
			{
				Request.<FeedPet>o__SiteContainer18.<>p__Site31 = CallSite<Func<CallSite, string, object, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Add, typeof(Request), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			Func<CallSite, string, object, object> arg_BB3_0 = Request.<FeedPet>o__SiteContainer18.<>p__Site31.Target;
			CallSite arg_BB3_1 = Request.<FeedPet>o__SiteContainer18.<>p__Site31;
			string arg_BB3_2 = "[" + user.get_pet_name(pet_id) + "]Lv:";
			if (Request.<FeedPet>o__SiteContainer18.<>p__Site32 == null)
			{
				Request.<FeedPet>o__SiteContainer18.<>p__Site32 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Request), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, string, object> arg_BAE_0 = Request.<FeedPet>o__SiteContainer18.<>p__Site32.Target;
			CallSite arg_BAE_1 = Request.<FeedPet>o__SiteContainer18.<>p__Site32;
			if (Request.<FeedPet>o__SiteContainer18.<>p__Site33 == null)
			{
				Request.<FeedPet>o__SiteContainer18.<>p__Site33 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Request), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
				}));
			}
			Func<CallSite, object, string, object> arg_BA4_0 = Request.<FeedPet>o__SiteContainer18.<>p__Site33.Target;
			CallSite arg_BA4_1 = Request.<FeedPet>o__SiteContainer18.<>p__Site33;
			if (Request.<FeedPet>o__SiteContainer18.<>p__Site34 == null)
			{
				Request.<FeedPet>o__SiteContainer18.<>p__Site34 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Request), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, string, object> arg_B9E_0 = Request.<FeedPet>o__SiteContainer18.<>p__Site34.Target;
			CallSite arg_B9E_1 = Request.<FeedPet>o__SiteContainer18.<>p__Site34;
			if (Request.<FeedPet>o__SiteContainer18.<>p__Site35 == null)
			{
				Request.<FeedPet>o__SiteContainer18.<>p__Site35 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Request), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, string, object> arg_B94_0 = Request.<FeedPet>o__SiteContainer18.<>p__Site35.Target;
			CallSite arg_B94_1 = Request.<FeedPet>o__SiteContainer18.<>p__Site35;
			if (Request.<FeedPet>o__SiteContainer18.<>p__Site36 == null)
			{
				Request.<FeedPet>o__SiteContainer18.<>p__Site36 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Request), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			object arg_D9F_2 = arg_BD7_0(arg_BD7_1, arg_BCD_0(arg_BCD_1, arg_BBD_0(arg_BBD_1, arg_BB3_0(arg_BB3_1, arg_BB3_2, arg_BAE_0(arg_BAE_1, arg_BA4_0(arg_BA4_1, arg_B9E_0(arg_B9E_1, arg_B94_0(arg_B94_1, Request.<FeedPet>o__SiteContainer18.<>p__Site36.Target(Request.<FeedPet>o__SiteContainer18.<>p__Site36, user.data, "response"), "pets"), "adopted"), pet_id), "level")), "XP:"), user.pet_xp[pet_id]), "Loyalty:");
			if (Request.<FeedPet>o__SiteContainer18.<>p__Site37 == null)
			{
				Request.<FeedPet>o__SiteContainer18.<>p__Site37 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Request), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, string, object> arg_D9A_0 = Request.<FeedPet>o__SiteContainer18.<>p__Site37.Target;
			CallSite arg_D9A_1 = Request.<FeedPet>o__SiteContainer18.<>p__Site37;
			if (Request.<FeedPet>o__SiteContainer18.<>p__Site38 == null)
			{
				Request.<FeedPet>o__SiteContainer18.<>p__Site38 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Request), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
				}));
			}
			Func<CallSite, object, string, object> arg_D90_0 = Request.<FeedPet>o__SiteContainer18.<>p__Site38.Target;
			CallSite arg_D90_1 = Request.<FeedPet>o__SiteContainer18.<>p__Site38;
			if (Request.<FeedPet>o__SiteContainer18.<>p__Site39 == null)
			{
				Request.<FeedPet>o__SiteContainer18.<>p__Site39 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Request), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, string, object> arg_D8A_0 = Request.<FeedPet>o__SiteContainer18.<>p__Site39.Target;
			CallSite arg_D8A_1 = Request.<FeedPet>o__SiteContainer18.<>p__Site39;
			if (Request.<FeedPet>o__SiteContainer18.<>p__Site3a == null)
			{
				Request.<FeedPet>o__SiteContainer18.<>p__Site3a = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Request), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, string, object> arg_D80_0 = Request.<FeedPet>o__SiteContainer18.<>p__Site3a.Target;
			CallSite arg_D80_1 = Request.<FeedPet>o__SiteContainer18.<>p__Site3a;
			if (Request.<FeedPet>o__SiteContainer18.<>p__Site3b == null)
			{
				Request.<FeedPet>o__SiteContainer18.<>p__Site3b = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Request), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			sErrMsg = arg_DA4_0(arg_DA4_1, arg_D9F_0(arg_D9F_1, arg_D9F_2, arg_D9A_0(arg_D9A_1, arg_D90_0(arg_D90_1, arg_D8A_0(arg_D8A_1, arg_D80_0(arg_D80_1, Request.<FeedPet>o__SiteContainer18.<>p__Site3b.Target(Request.<FeedPet>o__SiteContainer18.<>p__Site3b, user.data, "response"), "pets"), "adopted"), pet_id), "loyalty")));
			user.PetLog(sErrMsg);
		}

		public static void Abandon()
		{
			string data = string.Concat(new object[]
			{
				"query={\"action\":\"abandonStage\",\"signature\":\"",
				user.signature,
				"\",\"id\":2,\"params\":{\"user\":\"",
				user.id,
				"\",\"case_id\":",
				Request.Abandon_CASEID,
				",\"revision\":\"44\",\"stage_id\":",
				Request.Abandon_STAGEID,
				"}}"
			});
			CCRequest cCRequest = new CCRequest();
			if (!cCRequest.Get(data))
			{
				return;
			}
			user.WriteLog(string.Concat(new object[]
			{
				"放棄關卡:",
				Request.Abandon_CASEID,
				" - ",
				Request.Abandon_STAGEID
			}));
			Request.Abandon_CASEID = 0;
			Request.Abandon_STAGEID = 0;
		}

		public static bool startGame()
		{
			string text = string.Empty;
			string text2 = "0";
			if (user.teammate_index >= 0 && user.teammate_index < user.FriendList.Count)
			{
				text2 = user.FriendList[user.teammate_index].uid;
			}
			else if (user.Loop_USE_TEAMMTE)
			{
				if (user.FriendList.Count > 0)
				{
					text2 = user.FriendList[0].uid;
					user.teammate_index = 0;
				}
				else
				{
					user.isAutoPlay = false;
				}
			}
			if (user.isCaseElite)
			{
				text = string.Concat(new object[]
				{
					"query={\"signature\":\"",
					user.signature,
					"\",\"id\":1,\"action\":\"startStage\",\"params\":{\"revision\":\"44\",\"case_id\":",
					user.case_id,
					",\"stage_id\":",
					user.stage_id,
					",\"elite\":\"1\",\"teammate_id\":\"",
					text2,
					"\",\"apply_special_event\":false,\"user\":\"",
					user.id,
					"\"}}"
				});
			}
			else
			{
				text = string.Concat(new object[]
				{
					"query={\"signature\":\"",
					user.signature,
					"\",\"id\":1,\"action\":\"startStage\",\"params\":{\"revision\":\"44\",\"case_id\":",
					user.case_id,
					",\"stage_id\":",
					user.stage_id,
					",\"teammate_id\":\"",
					text2,
					"\",\"apply_special_event\":false,\"user\":\"",
					user.id,
					"\"}}"
				});
			}
			CCRequest cCRequest = new CCRequest();
			if (!cCRequest.Get(text))
			{
				return false;
			}
			user.StartData = JToken.Parse(cCRequest.result);
			if (Request.<startGame>o__SiteContainer3c.<>p__Site3d == null)
			{
				Request.<startGame>o__SiteContainer3c.<>p__Site3d = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Request), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			Func<CallSite, object, bool> arg_282_0 = Request.<startGame>o__SiteContainer3c.<>p__Site3d.Target;
			CallSite arg_282_1 = Request.<startGame>o__SiteContainer3c.<>p__Site3d;
			if (Request.<startGame>o__SiteContainer3c.<>p__Site3e == null)
			{
				Request.<startGame>o__SiteContainer3c.<>p__Site3e = CallSite<Func<CallSite, object, object, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.NotEqual, typeof(Request), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, object, object> arg_27D_0 = Request.<startGame>o__SiteContainer3c.<>p__Site3e.Target;
			CallSite arg_27D_1 = Request.<startGame>o__SiteContainer3c.<>p__Site3e;
			if (Request.<startGame>o__SiteContainer3c.<>p__Site3f == null)
			{
				Request.<startGame>o__SiteContainer3c.<>p__Site3f = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Request), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			if (arg_282_0(arg_282_1, arg_27D_0(arg_27D_1, Request.<startGame>o__SiteContainer3c.<>p__Site3f.Target(Request.<startGame>o__SiteContainer3c.<>p__Site3f, user.StartData, "error"), null)))
			{
				Console.WriteLine("StartStage出錯");
				Console.WriteLine(text);
				if (Request.<startGame>o__SiteContainer3c.<>p__Site40 == null)
				{
					Request.<startGame>o__SiteContainer3c.<>p__Site40 = CallSite<Action<CallSite, Type, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "WriteLine", null, typeof(Request), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Request.<startGame>o__SiteContainer3c.<>p__Site40.Target(Request.<startGame>o__SiteContainer3c.<>p__Site40, typeof(Console), user.StartData);
				return false;
			}
			return true;
		}

		public static bool EndGame()
		{
			string data = string.Empty;
			string text = string.Empty;
			if (user.isCaseElite)
			{
				data = string.Concat(new object[]
				{
					"query={\"signature\":\"",
					user.signature,
					"\",\"id\":1,\"action\":\"endStage\",\"params\":{\"user\":\"",
					user.id,
					"\",\"revision\":\"44\",\"ho_items_found\":",
					user.items_found,
					",\"case_id\":",
					user.case_id,
					",\"time_spent\":",
					user.time_spent,
					",\"score\":",
					user.score,
					",\"stage_id\":",
					user.stage_id,
					",\"sig\":\"",
					user.sig,
					"\",\"elite\":\"1\",\"apply_special_event\":false,\"six_items_time\":10,\"hints_used\":0}}"
				});
			}
			else
			{
				data = string.Concat(new object[]
				{
					"query={\"signature\":\"",
					user.signature,
					"\",\"id\":1,\"action\":\"endStage\",\"params\":{\"user\":\"",
					user.id,
					"\",\"revision\":\"44\",\"ho_items_found\":",
					user.items_found,
					",\"case_id\":",
					user.case_id,
					",\"time_spent\":",
					user.time_spent,
					",\"score\":",
					user.score,
					",\"stage_id\":",
					user.stage_id,
					",\"sig\":\"",
					user.sig,
					"\",\"apply_special_event\":false,\"six_items_time\":10,\"hints_used\":0}}"
				});
			}
			CCRequest cCRequest = new CCRequest();
			if (!cCRequest.Get(data))
			{
				return false;
			}
			user.EndData = JToken.Parse(cCRequest.result);
			if (Request.<EndGame>o__SiteContainer41.<>p__Site42 == null)
			{
				Request.<EndGame>o__SiteContainer41.<>p__Site42 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Request), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			Func<CallSite, object, bool> arg_2C6_0 = Request.<EndGame>o__SiteContainer41.<>p__Site42.Target;
			CallSite arg_2C6_1 = Request.<EndGame>o__SiteContainer41.<>p__Site42;
			if (Request.<EndGame>o__SiteContainer41.<>p__Site43 == null)
			{
				Request.<EndGame>o__SiteContainer41.<>p__Site43 = CallSite<Func<CallSite, object, object, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.NotEqual, typeof(Request), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, object, object> arg_2C1_0 = Request.<EndGame>o__SiteContainer41.<>p__Site43.Target;
			CallSite arg_2C1_1 = Request.<EndGame>o__SiteContainer41.<>p__Site43;
			if (Request.<EndGame>o__SiteContainer41.<>p__Site44 == null)
			{
				Request.<EndGame>o__SiteContainer41.<>p__Site44 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Request), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			if (arg_2C6_0(arg_2C6_1, arg_2C1_0(arg_2C1_1, Request.<EndGame>o__SiteContainer41.<>p__Site44.Target(Request.<EndGame>o__SiteContainer41.<>p__Site44, user.EndData, "response"), null)))
			{
				user.count++;
				int teammate_index = user.teammate_index;
				if (Request.<EndGame>o__SiteContainer41.<>p__Site45 == null)
				{
					Request.<EndGame>o__SiteContainer41.<>p__Site45 = CallSite<Func<CallSite, object, int>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(int), typeof(Request)));
				}
				Func<CallSite, object, int> arg_3BF_0 = Request.<EndGame>o__SiteContainer41.<>p__Site45.Target;
				CallSite arg_3BF_1 = Request.<EndGame>o__SiteContainer41.<>p__Site45;
				if (Request.<EndGame>o__SiteContainer41.<>p__Site46 == null)
				{
					Request.<EndGame>o__SiteContainer41.<>p__Site46 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "xp_won", typeof(Request), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, object, object> arg_3BA_0 = Request.<EndGame>o__SiteContainer41.<>p__Site46.Target;
				CallSite arg_3BA_1 = Request.<EndGame>o__SiteContainer41.<>p__Site46;
				if (Request.<EndGame>o__SiteContainer41.<>p__Site47 == null)
				{
					Request.<EndGame>o__SiteContainer41.<>p__Site47 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "response", typeof(Request), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				int num = arg_3BF_0(arg_3BF_1, arg_3BA_0(arg_3BA_1, Request.<EndGame>o__SiteContainer41.<>p__Site47.Target(Request.<EndGame>o__SiteContainer41.<>p__Site47, user.EndData)));
				if (Request.<EndGame>o__SiteContainer41.<>p__Site48 == null)
				{
					Request.<EndGame>o__SiteContainer41.<>p__Site48 = CallSite<Func<CallSite, object, int>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(int), typeof(Request)));
				}
				Func<CallSite, object, int> arg_4A3_0 = Request.<EndGame>o__SiteContainer41.<>p__Site48.Target;
				CallSite arg_4A3_1 = Request.<EndGame>o__SiteContainer41.<>p__Site48;
				if (Request.<EndGame>o__SiteContainer41.<>p__Site49 == null)
				{
					Request.<EndGame>o__SiteContainer41.<>p__Site49 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "coins_won", typeof(Request), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, object, object> arg_49E_0 = Request.<EndGame>o__SiteContainer41.<>p__Site49.Target;
				CallSite arg_49E_1 = Request.<EndGame>o__SiteContainer41.<>p__Site49;
				if (Request.<EndGame>o__SiteContainer41.<>p__Site4a == null)
				{
					Request.<EndGame>o__SiteContainer41.<>p__Site4a = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "response", typeof(Request), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				int num2 = arg_4A3_0(arg_4A3_1, arg_49E_0(arg_49E_1, Request.<EndGame>o__SiteContainer41.<>p__Site4a.Target(Request.<EndGame>o__SiteContainer41.<>p__Site4a, user.EndData)));
				object obj = text;
				text = string.Concat(new object[]
				{
					obj,
					"[",
					user.count,
					"] [",
					user.get_case_name(user.case_id),
					"][第 ",
					user.scene_id,
					" 場景] - ",
					user.score
				});
				if (Request.<EndGame>o__SiteContainer41.<>p__Site4b == null)
				{
					Request.<EndGame>o__SiteContainer41.<>p__Site4b = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Request), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, object, bool> arg_673_0 = Request.<EndGame>o__SiteContainer41.<>p__Site4b.Target;
				CallSite arg_673_1 = Request.<EndGame>o__SiteContainer41.<>p__Site4b;
				if (Request.<EndGame>o__SiteContainer41.<>p__Site4c == null)
				{
					Request.<EndGame>o__SiteContainer41.<>p__Site4c = CallSite<Func<CallSite, object, object, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.NotEqual, typeof(Request), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				Func<CallSite, object, object, object> arg_66E_0 = Request.<EndGame>o__SiteContainer41.<>p__Site4c.Target;
				CallSite arg_66E_1 = Request.<EndGame>o__SiteContainer41.<>p__Site4c;
				if (Request.<EndGame>o__SiteContainer41.<>p__Site4d == null)
				{
					Request.<EndGame>o__SiteContainer41.<>p__Site4d = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Request), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				Func<CallSite, object, string, object> arg_668_0 = Request.<EndGame>o__SiteContainer41.<>p__Site4d.Target;
				CallSite arg_668_1 = Request.<EndGame>o__SiteContainer41.<>p__Site4d;
				if (Request.<EndGame>o__SiteContainer41.<>p__Site4e == null)
				{
					Request.<EndGame>o__SiteContainer41.<>p__Site4e = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Request), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				if (arg_673_0(arg_673_1, arg_66E_0(arg_66E_1, arg_668_0(arg_668_1, Request.<EndGame>o__SiteContainer41.<>p__Site4e.Target(Request.<EndGame>o__SiteContainer41.<>p__Site4e, user.EndData, "response"), "compensation_key"), null)))
				{
					if (Request.<EndGame>o__SiteContainer41.<>p__Site4f == null)
					{
						Request.<EndGame>o__SiteContainer41.<>p__Site4f = CallSite<Action<CallSite, Type, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "WriteLine", null, typeof(Request), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					Action<CallSite, Type, object> arg_79B_0 = Request.<EndGame>o__SiteContainer41.<>p__Site4f.Target;
					CallSite arg_79B_1 = Request.<EndGame>o__SiteContainer41.<>p__Site4f;
					Type arg_79B_2 = typeof(Console);
					if (Request.<EndGame>o__SiteContainer41.<>p__Site50 == null)
					{
						Request.<EndGame>o__SiteContainer41.<>p__Site50 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Request), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					Func<CallSite, object, string, object> arg_796_0 = Request.<EndGame>o__SiteContainer41.<>p__Site50.Target;
					CallSite arg_796_1 = Request.<EndGame>o__SiteContainer41.<>p__Site50;
					if (Request.<EndGame>o__SiteContainer41.<>p__Site51 == null)
					{
						Request.<EndGame>o__SiteContainer41.<>p__Site51 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Request), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					arg_79B_0(arg_79B_1, arg_79B_2, arg_796_0(arg_796_1, Request.<EndGame>o__SiteContainer41.<>p__Site51.Target(Request.<EndGame>o__SiteContainer41.<>p__Site51, user.EndData, "response"), "compensation_key"));
					if (teammate_index >= 0 && teammate_index < user.FriendList.Count)
					{
						string uid = user.FriendList[teammate_index].uid;
						string name = user.FriendList[teammate_index].name;
						if (Request.<EndGame>o__SiteContainer41.<>p__Site52 == null)
						{
							Request.<EndGame>o__SiteContainer41.<>p__Site52 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(Request)));
						}
						Func<CallSite, object, string> arg_8B8_0 = Request.<EndGame>o__SiteContainer41.<>p__Site52.Target;
						CallSite arg_8B8_1 = Request.<EndGame>o__SiteContainer41.<>p__Site52;
						if (Request.<EndGame>o__SiteContainer41.<>p__Site53 == null)
						{
							Request.<EndGame>o__SiteContainer41.<>p__Site53 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "compensation_key", typeof(Request), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						Func<CallSite, object, object> arg_8B3_0 = Request.<EndGame>o__SiteContainer41.<>p__Site53.Target;
						CallSite arg_8B3_1 = Request.<EndGame>o__SiteContainer41.<>p__Site53;
						if (Request.<EndGame>o__SiteContainer41.<>p__Site54 == null)
						{
							Request.<EndGame>o__SiteContainer41.<>p__Site54 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "response", typeof(Request), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						string key = arg_8B8_0(arg_8B8_1, arg_8B3_0(arg_8B3_1, Request.<EndGame>o__SiteContainer41.<>p__Site54.Target(Request.<EndGame>o__SiteContainer41.<>p__Site54, user.EndData)));
						int level = user.FriendList[teammate_index].level;
						text = text + "[隊友 " + name + "]";
						if (Request.SendCard(uid, key))
						{
							user.CardLog(string.Concat(new object[]
							{
								"寄送撲克牌給隊友 ",
								name,
								"(等級 ",
								level,
								")"
							}));
							user.FriendList.RemoveAt(teammate_index);
						}
					}
				}
				user.teammate_index = -1;
				user.xp += num;
				user.coins += num2;
				user.current_star = (user.stage[user.stage_id].case_stars = num - 11);
				int num3 = Convert.ToInt32(user.score);
				if (num3 > user.high_score)
				{
					user.high_score = num3;
				}
				user.energy -= 20;
				if (user.current_star > 4)
				{
					user.current_star = (user.stage[user.stage_id].case_stars = 5);
					user.energy += 15;
				}
				try
				{
					if (Request.<EndGame>o__SiteContainer41.<>p__Site55 == null)
					{
						Request.<EndGame>o__SiteContainer41.<>p__Site55 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Request), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					Func<CallSite, object, bool> arg_B32_0 = Request.<EndGame>o__SiteContainer41.<>p__Site55.Target;
					CallSite arg_B32_1 = Request.<EndGame>o__SiteContainer41.<>p__Site55;
					if (Request.<EndGame>o__SiteContainer41.<>p__Site56 == null)
					{
						Request.<EndGame>o__SiteContainer41.<>p__Site56 = CallSite<Func<CallSite, object, object, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.NotEqual, typeof(Request), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					Func<CallSite, object, object, object> arg_B2D_0 = Request.<EndGame>o__SiteContainer41.<>p__Site56.Target;
					CallSite arg_B2D_1 = Request.<EndGame>o__SiteContainer41.<>p__Site56;
					if (Request.<EndGame>o__SiteContainer41.<>p__Site57 == null)
					{
						Request.<EndGame>o__SiteContainer41.<>p__Site57 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Request), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					Func<CallSite, object, string, object> arg_B27_0 = Request.<EndGame>o__SiteContainer41.<>p__Site57.Target;
					CallSite arg_B27_1 = Request.<EndGame>o__SiteContainer41.<>p__Site57;
					if (Request.<EndGame>o__SiteContainer41.<>p__Site58 == null)
					{
						Request.<EndGame>o__SiteContainer41.<>p__Site58 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Request), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					if (arg_B32_0(arg_B32_1, arg_B2D_0(arg_B2D_1, arg_B27_0(arg_B27_1, Request.<EndGame>o__SiteContainer41.<>p__Site58.Target(Request.<EndGame>o__SiteContainer41.<>p__Site58, user.EndData, "response"), "events"), null)))
					{
						if (Request.<EndGame>o__SiteContainer41.<>p__Site59 == null)
						{
							Request.<EndGame>o__SiteContainer41.<>p__Site59 = CallSite<Func<CallSite, object, IEnumerable>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(IEnumerable), typeof(Request)));
						}
						Func<CallSite, object, IEnumerable> arg_C2F_0 = Request.<EndGame>o__SiteContainer41.<>p__Site59.Target;
						CallSite arg_C2F_1 = Request.<EndGame>o__SiteContainer41.<>p__Site59;
						if (Request.<EndGame>o__SiteContainer41.<>p__Site5a == null)
						{
							Request.<EndGame>o__SiteContainer41.<>p__Site5a = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Request), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
							}));
						}
						Func<CallSite, object, string, object> arg_C2A_0 = Request.<EndGame>o__SiteContainer41.<>p__Site5a.Target;
						CallSite arg_C2A_1 = Request.<EndGame>o__SiteContainer41.<>p__Site5a;
						if (Request.<EndGame>o__SiteContainer41.<>p__Site5b == null)
						{
							Request.<EndGame>o__SiteContainer41.<>p__Site5b = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Request), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
							}));
						}
						foreach (object current in arg_C2F_0(arg_C2F_1, arg_C2A_0(arg_C2A_1, Request.<EndGame>o__SiteContainer41.<>p__Site5b.Target(Request.<EndGame>o__SiteContainer41.<>p__Site5b, user.EndData, "response"), "events")))
						{
							if (Request.<EndGame>o__SiteContainer41.<>p__Site5c == null)
							{
								Request.<EndGame>o__SiteContainer41.<>p__Site5c = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Request), new CSharpArgumentInfo[]
								{
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
								}));
							}
							Func<CallSite, object, bool> arg_D39_0 = Request.<EndGame>o__SiteContainer41.<>p__Site5c.Target;
							CallSite arg_D39_1 = Request.<EndGame>o__SiteContainer41.<>p__Site5c;
							if (Request.<EndGame>o__SiteContainer41.<>p__Site5d == null)
							{
								Request.<EndGame>o__SiteContainer41.<>p__Site5d = CallSite<Func<CallSite, object, object, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.NotEqual, typeof(Request), new CSharpArgumentInfo[]
								{
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.Constant, null)
								}));
							}
							Func<CallSite, object, object, object> arg_D34_0 = Request.<EndGame>o__SiteContainer41.<>p__Site5d.Target;
							CallSite arg_D34_1 = Request.<EndGame>o__SiteContainer41.<>p__Site5d;
							if (Request.<EndGame>o__SiteContainer41.<>p__Site5e == null)
							{
								Request.<EndGame>o__SiteContainer41.<>p__Site5e = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "reward_key", typeof(Request), new CSharpArgumentInfo[]
								{
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
								}));
							}
							if (arg_D39_0(arg_D39_1, arg_D34_0(arg_D34_1, Request.<EndGame>o__SiteContainer41.<>p__Site5e.Target(Request.<EndGame>o__SiteContainer41.<>p__Site5e, current), null)))
							{
								user.RewardLog(cCRequest.result);
								if (Request.<EndGame>o__SiteContainer41.<>p__Site5f == null)
								{
									Request.<EndGame>o__SiteContainer41.<>p__Site5f = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(Request)));
								}
								Func<CallSite, object, string> arg_EEA_0 = Request.<EndGame>o__SiteContainer41.<>p__Site5f.Target;
								CallSite arg_EEA_1 = Request.<EndGame>o__SiteContainer41.<>p__Site5f;
								if (Request.<EndGame>o__SiteContainer41.<>p__Site60 == null)
								{
									Request.<EndGame>o__SiteContainer41.<>p__Site60 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Add, typeof(Request), new CSharpArgumentInfo[]
									{
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
									}));
								}
								Func<CallSite, object, string, object> arg_EE5_0 = Request.<EndGame>o__SiteContainer41.<>p__Site60.Target;
								CallSite arg_EE5_1 = Request.<EndGame>o__SiteContainer41.<>p__Site60;
								if (Request.<EndGame>o__SiteContainer41.<>p__Site61 == null)
								{
									Request.<EndGame>o__SiteContainer41.<>p__Site61 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Add, typeof(Request), new CSharpArgumentInfo[]
									{
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
									}));
								}
								Func<CallSite, object, string, object> arg_EDB_0 = Request.<EndGame>o__SiteContainer41.<>p__Site61.Target;
								CallSite arg_EDB_1 = Request.<EndGame>o__SiteContainer41.<>p__Site61;
								if (Request.<EndGame>o__SiteContainer41.<>p__Site62 == null)
								{
									Request.<EndGame>o__SiteContainer41.<>p__Site62 = CallSite<Func<CallSite, string, object, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Add, typeof(Request), new CSharpArgumentInfo[]
									{
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null),
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
									}));
								}
								Func<CallSite, string, object, object> arg_ED1_0 = Request.<EndGame>o__SiteContainer41.<>p__Site62.Target;
								CallSite arg_ED1_1 = Request.<EndGame>o__SiteContainer41.<>p__Site62;
								string arg_ED1_2 = "https://apps.facebook.com/criminalcase/reward.php?reward_key=";
								if (Request.<EndGame>o__SiteContainer41.<>p__Site63 == null)
								{
									Request.<EndGame>o__SiteContainer41.<>p__Site63 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "reward_key", typeof(Request), new CSharpArgumentInfo[]
									{
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
									}));
								}
								string text2 = arg_EEA_0(arg_EEA_1, arg_EE5_0(arg_EE5_1, arg_EDB_0(arg_EDB_1, arg_ED1_0(arg_ED1_1, arg_ED1_2, Request.<EndGame>o__SiteContainer41.<>p__Site63.Target(Request.<EndGame>o__SiteContainer41.<>p__Site63, current)), "&sender="), user.id));
								if (Request.<EndGame>o__SiteContainer41.<>p__Site64 == null)
								{
									Request.<EndGame>o__SiteContainer41.<>p__Site64 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Request), new CSharpArgumentInfo[]
									{
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
									}));
								}
								Func<CallSite, object, bool> arg_FE5_0 = Request.<EndGame>o__SiteContainer41.<>p__Site64.Target;
								CallSite arg_FE5_1 = Request.<EndGame>o__SiteContainer41.<>p__Site64;
								if (Request.<EndGame>o__SiteContainer41.<>p__Site65 == null)
								{
									Request.<EndGame>o__SiteContainer41.<>p__Site65 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Equal, typeof(Request), new CSharpArgumentInfo[]
									{
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
									}));
								}
								Func<CallSite, object, string, object> arg_FE0_0 = Request.<EndGame>o__SiteContainer41.<>p__Site65.Target;
								CallSite arg_FE0_1 = Request.<EndGame>o__SiteContainer41.<>p__Site65;
								if (Request.<EndGame>o__SiteContainer41.<>p__Site66 == null)
								{
									Request.<EndGame>o__SiteContainer41.<>p__Site66 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "type", typeof(Request), new CSharpArgumentInfo[]
									{
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
									}));
								}
								if (arg_FE5_0(arg_FE5_1, arg_FE0_0(arg_FE0_1, Request.<EndGame>o__SiteContainer41.<>p__Site66.Target(Request.<EndGame>o__SiteContainer41.<>p__Site66, current), "level_up")))
								{
									text2 += "&reward_type=0";
									if (Request.<EndGame>o__SiteContainer41.<>p__Site67 == null)
									{
										Request.<EndGame>o__SiteContainer41.<>p__Site67 = CallSite<Func<CallSite, object, int>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(int), typeof(Request)));
									}
									Func<CallSite, object, int> arg_1088_0 = Request.<EndGame>o__SiteContainer41.<>p__Site67.Target;
									CallSite arg_1088_1 = Request.<EndGame>o__SiteContainer41.<>p__Site67;
									if (Request.<EndGame>o__SiteContainer41.<>p__Site68 == null)
									{
										Request.<EndGame>o__SiteContainer41.<>p__Site68 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "level", typeof(Request), new CSharpArgumentInfo[]
										{
											CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
										}));
									}
									user.level = arg_1088_0(arg_1088_1, Request.<EndGame>o__SiteContainer41.<>p__Site68.Target(Request.<EndGame>o__SiteContainer41.<>p__Site68, current));
									if (Request.<EndGame>o__SiteContainer41.<>p__Site69 == null)
									{
										Request.<EndGame>o__SiteContainer41.<>p__Site69 = CallSite<Func<CallSite, object, int>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(int), typeof(Request)));
									}
									Func<CallSite, object, int> arg_111D_0 = Request.<EndGame>o__SiteContainer41.<>p__Site69.Target;
									CallSite arg_111D_1 = Request.<EndGame>o__SiteContainer41.<>p__Site69;
									if (Request.<EndGame>o__SiteContainer41.<>p__Site6a == null)
									{
										Request.<EndGame>o__SiteContainer41.<>p__Site6a = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "xp", typeof(Request), new CSharpArgumentInfo[]
										{
											CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
										}));
									}
									user.xp = arg_111D_0(arg_111D_1, Request.<EndGame>o__SiteContainer41.<>p__Site6a.Target(Request.<EndGame>o__SiteContainer41.<>p__Site6a, current));
									user.energy = user.energy;
									user.RewardLog(string.Concat(new object[]
									{
										"[升級獎勵]  (等級",
										user.level,
										")  分享地址：",
										text2
									}));
								}
								else
								{
									text2 += "&reward_type=1";
									user.RewardLog(string.Concat(new object[]
									{
										"[升階獎勵]  (等級",
										user.level,
										")  分享地址：",
										text2
									}));
								}
							}
						}
					}
				}
				catch
				{
				}
				user.WriteLog(text);
				return true;
			}
			if (Request.<EndGame>o__SiteContainer41.<>p__Site6b == null)
			{
				Request.<EndGame>o__SiteContainer41.<>p__Site6b = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(Request)));
			}
			Func<CallSite, object, string> arg_127F_0 = Request.<EndGame>o__SiteContainer41.<>p__Site6b.Target;
			CallSite arg_127F_1 = Request.<EndGame>o__SiteContainer41.<>p__Site6b;
			if (Request.<EndGame>o__SiteContainer41.<>p__Site6c == null)
			{
				Request.<EndGame>o__SiteContainer41.<>p__Site6c = CallSite<Func<CallSite, string, object, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Add, typeof(Request), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			text = arg_127F_0(arg_127F_1, Request.<EndGame>o__SiteContainer41.<>p__Site6c.Target(Request.<EndGame>o__SiteContainer41.<>p__Site6c, "fail user.Endata", user.EndData));
			Console.WriteLine("EndStage出錯;");
			return false;
		}
	}
}
