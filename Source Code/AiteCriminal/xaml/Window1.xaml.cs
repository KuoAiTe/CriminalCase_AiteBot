using Microsoft.CSharp.RuntimeBinder;
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Threading;
using Newtonsoft.Json.Linq;

namespace AiteCriminal
{
	public partial class Window1 : Window
	{
		private Window1.SceneButton[] scene = new Window1.SceneButton[9];

		private Window1.CaseButton[] caseButtons = new Window1.CaseButton[60];

		private Timer threadTimer ;

		private Timer giftTimer;

		private Timer EatingTimer0;

		private Timer EatingTimer1;

		private Timer EatingTimer2;

		private Timer updateTimer;

		private Thread Report_Thread;

		private Timer OpenPackTimer;

		public Window1()
		{
			InitializeComponent();
            threadTimer = new Timer(new TimerCallback(AutoPetFeeding_Callback), null, 0, 5000);
			Width = 480;
		    Height = 485;
			ResizeMode = System.Windows.ResizeMode.CanMinimize;
            
			for (int i = 0; i < 6; i++)
			{
				for (int j = 0; j < 10; j++)
				{
					int num = i * 10 + j;
					caseButtons[num] = new CaseButton();
					caseButtons[num].Width = 45;
					caseButtons[num].Height = 45;
					caseButtons[num].Margin = new Thickness((double)(5 + j * 46), (double)(5 + i * 46), 0, 0);
					caseButtons[num].VerticalAlignment = System.Windows.VerticalAlignment.Top;
					caseButtons[num].HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
					caseButtons[num].HorizontalContentAlignment = System.Windows.HorizontalAlignment.Center;
					caseButtons[num].Background = Brushes.DimGray;
					caseButtons[num].Click += new RoutedEventHandler(case_select);
					caseButtons[num].Content = num + 1;
					caseButtons[num].Tag = num + 1;
				    caseButtons[num].Style = (Style)FindResource("MyButton");
					caseButtons[num].IsEnabled = false;
					Cases_Grid.Children.Add(caseButtons[num]);
				}
			}
			updateUI();
			Case_Name.Visibility = System.Windows.Visibility.Hidden;
			Scene_Grid.Visibility = System.Windows.Visibility.Hidden;
			for (int k = 0; k < 9; k++)
			{
				scene[k] = new SceneButton();
				scene[k].Width = 127;
				scene[k].Height = 88;
				scene[k].Margin = new Thickness((double)(65 + k % 3 * 132), (double)(k / 3 * 93), 0, 0);
				scene[k].VerticalAlignment = System.Windows.VerticalAlignment.Top;
				scene[k].HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
				scene[k].HorizontalContentAlignment = System.Windows.HorizontalAlignment.Center;
				scene[k].Click += new RoutedEventHandler(scene_select);
				scene[k].Tag = k + 1;
				scene[k].Style = (Style)FindResource("SceneButton");
				Scene_Grid.Children.Add(scene[k]);
			}
            user.Last_Message = string.Concat("歡迎使用 ", user.id);
			updateTimer = new Timer(new TimerCallback(update_dashboard), null, 0, 500);
        }

        private void AutoStart()
		{
			user.isRunning = true;
			object[] caseName = new object[] { "[開始] ", user.get_case_name(user.case_id), " 第 ", user.scene_id, " 場景" };
			user.Notification(string.Concat(caseName));
			do
			{
				if (!Request.startGame())
				{
					try
					{
						if (((dynamic)user.StartData).error.type == "energy")
						{
							Console.WriteLine("No Energy!");
							user.isAutoPlay = false;
							user.energy = (int)((dynamic)user.StartData).error.sync.energy;
							user.coins = (int)((dynamic)user.StartData).error.sync.coins;
						}
						Request.GetUserData();
						if (Request.Abandon_CASEID != 0 && Request.Abandon_STAGEID != 0)
						{
							Request.Abandon();
						}
					}
					catch (Exception exception)
					{
						user.WriteLog(string.Concat("1b2b4c6643b5c96a07abdf16fb2220fe|", exception.Message));
					}
				}
				else
				{
					Request.EndGame();
				}
			}
			while (user.isAutoPlay);
			user.isRunning = false;
			user.Loop_USE_TEAMMTE = false;
			object[] objArray = new object[] { "[結束] ", user.get_case_name(user.case_id), " 第 ", user.scene_id, " 場景" };
			user.Notification(string.Concat(objArray));
			user.scene_id = 0;
		}

		private void Back_Click(object sender, RoutedEventArgs e)
		{
			user.isAutoPlay = false;
			updateUI();
			Scene_Grid.Visibility = System.Windows.Visibility.Hidden;
			Cases_Grid.Visibility = System.Windows.Visibility.Visible;
			Season.Visibility = System.Windows.Visibility.Visible;
			Season_Left.Visibility = System.Windows.Visibility.Visible;
			Season_Right.Visibility = System.Windows.Visibility.Visible;
			Case_Name.Visibility = System.Windows.Visibility.Hidden;
		}

		private void Button_Click_1(object sender, RoutedEventArgs e)
		{
			if (user.isAutoPlay)
			{
				user.isAutoPlay = false;
				return;
			}
			(new Thread(new ThreadStart(FullAutoStart))).Start();
			user.isAutoPlay = true;
		}

		private void Button_Click_3(object sender, RoutedEventArgs e)
		{
			if (user.isAutoPlay)
			{
				user.isAutoPlay = false;
				return;
			}
			(new Thread(new ThreadStart(SuperStart))).Start();
			user.isAutoPlay = true;
		}

		private void case_select(object sender, RoutedEventArgs e)
		{
			int num;
			user.scene_id = 0;
			user.case_id = Convert.ToInt32(((Button)sender).Tag);
			if (Request.FetchCase())
			{
				int num1 = 0;
				Cases_Grid.Visibility = System.Windows.Visibility.Hidden;
				Scene_Grid.Visibility = System.Windows.Visibility.Visible;
				Season.Visibility = System.Windows.Visibility.Hidden;
				Season_Left.Visibility = System.Windows.Visibility.Hidden;
				Season_Right.Visibility = System.Windows.Visibility.Hidden;
				Case_Name.Visibility = System.Windows.Visibility.Visible;
				if (user.case_id == 1)
				{
					num = 3;
				}
				else
				{
					num = (user.case_id == 2 ? 6 : 9);
				}
				int num2 = num;
				for (int i = 0; i < num2; i++)
				{
					scene[i].Content = user.star(0);
					user.stage[user.get_stage_id(i)].case_stars = 0;
					user.stage[user.get_stage_id(i)].high_score = 0;
					scene[i].Visibility = System.Windows.Visibility.Visible;
				}
				for (int j = num2; j < 9; j++)
				{
					user.stage[user.get_stage_id(j)].case_stars = 5;
					scene[j].Visibility = System.Windows.Visibility.Hidden;
				}
				foreach (JObject stageDatum in user.StageData["response"]["nodes"])
				{
					int num3 = Convert.ToInt32(stageDatum["id"]);
					if (num3 < 1011 || num3 > 1033)
					{
						continue;
					}
					int num4 = 0;
					try
					{
						user.Stage item = user.stage[num3];
						int num5 = Convert.ToInt32(stageDatum["current_star"]);
						num4 = num5;
						item.case_stars = num5;
						user.stage[num3].high_score = Convert.ToInt32(stageDatum["high_score"]);
					}
					catch
					{
						user.stage[num3].case_stars = 0;
						user.stage[num3].high_score = 0;
					}
					num1 += num4;
				}
				if (user.Elite_Medal(user.case_id) == 6 || user.Elite_Medal(user.case_id) == 0 && user.Medal(user.case_id) == 3)
				{
                    int avaialbeStars = Convert.ToInt32(user.StageData["response"]["available_stars"]);
					if (avaialbeStars > 2 && !user.isCurrent_case)
					{
						Hamburger hamburger = new Hamburger()
						{
							Top = this.Top + 150,
							Left = this.Left + 105
						};
						hamburger.ShowDialog();
						if (hamburger.ButtonClicked)
						{
							if (!Request.BuyAllStarBurners(hamburger.BuyStarBurger_Index))
							{
								user.WriteLog("兌換失敗");
							}
							else
							{
								if (hamburger.BuyStarBurger_Index == 1)
								{
									user.food_0 = user.food_0 + avaialbeStars;
									user.WriteLog(string.Concat("兌換柳橙汁成功 - ", avaialbeStars, " 個"));
									return;
								}
								if (hamburger.BuyStarBurger_Index == 2)
								{
									user.WriteLog(string.Concat("兌換洋芋片成功 - ", avaialbeStars / 2, " 個"));
									user.food_1 = user.food_1 + avaialbeStars / 2;
									return;
								}
								if (hamburger.BuyStarBurger_Index == 3)
								{
									user.WriteLog(string.Concat("兌換漢堡成功 - ", avaialbeStars / 3, " 個"));
									user.food_2 = user.food_2 + avaialbeStars / 3;
									return;
								}
								if (hamburger.BuyStarBurger_Index == 7)
								{
									user.WriteLog(string.Concat("兌換能量成功 - ", avaialbeStars * 20, " 點"));
									user.energy = user.energy + avaialbeStars * 20;
									return;
								}
								if (hamburger.BuyStarBurger_Index == 8)
								{
									int num6 = avaialbeStars * 5000;
									if (num6 > 99999999)
									{
										num6 = 99999999;
									}
									num6 = (user.coins <= 99999999 ? 99999999 - user.coins : 0);
									user.WriteLog(string.Concat("兌換金幣成功 - ", num6, " 枚"));
									user.coins = user.coins + num6;
									return;
								}
								if (hamburger.BuyStarBurger_Index == 9)
								{
									user.WriteLog(string.Concat("兌換貼紙包成功 - ", avaialbeStars / 3, " 點"));
									user.stickers_pack_count = user.stickers_pack_count + avaialbeStars / 3;
									return;
								}
							}
						}
					}
				}
			}
		}

		private void Donate_Click(object sender, RoutedEventArgs e)
		{
			string str = "";
			string str1 = "robinsa87@gmail.com";
			string str2 = "Donation";
			string str3 = "TW";
			string str4 = "TWD";
			string str5 = str;
			string[] strArrays = new string[] { str5, "https://www.paypal.com/cgi-bin/webscr?cmd=_donations&business=", str1, "&lc=", str3, "&item_name=", str2, "&currency_code=", str4, "&bn=PP%2dDonationsBF" };
			Process.Start(string.Concat(strArrays));
		}

		public void EatFood0(object state)
		{
			if (user.food_0 > 0)
			{
				Request.Eat(0);
				return;
			}
            try
            {
                EatingTimer0.Dispose();
                EatingTimer0 = null;
            }
            catch { }
		}

		public void EatFood1(object state)
		{
			if (user.food_1 > 1)
			{
				Request.Eat(1);
				return;
			}
            try
            {
                Console.WriteLine("拋棄");
                EatingTimer1.Dispose();
                EatingTimer1 = null;
            } catch { }
		}

		public void EatFood2(object state)
		{
			if (user.food_2 > 2)
			{
				Request.Eat(2);
				return;
			}
			try
			{
				EatingTimer2.Dispose();
				EatingTimer2 = null;
			} catch { }
		}

		private void Food_0_Click(object sender, RoutedEventArgs e)
		{
			if (user.food_0 == 0)
			{
				MessageBox.Show("無柳橙汁");
			}
			else
			{
				if (EatingTimer0 != null)
				{
					EatingTimer0.Dispose();
					EatingTimer0 = null;
					MessageBox.Show("停止喝柳橙汁");
					return;
				}
				Eat_Food eatFood = new Eat_Food(0)
				{
					Top = this.Top + 65,
					Left = this.Left + 135
				};
				eatFood.ShowDialog();
				if (eatFood.ButtonClicked)
				{
					if (!eatFood.repeat)
					{
						Request.Eat(0);
						return;
					}
					EatingTimer0 = new Timer(new TimerCallback(EatFood0), null, 0, 20);
					return;
				}
			}
		}

		private void Food_1_Click(object sender, RoutedEventArgs e)
		{
			if (user.food_1 == 0)
			{
				MessageBox.Show("無洋芋片");
			}
			else
			{
				if (EatingTimer1 != null)
				{
					EatingTimer1.Dispose();
					EatingTimer1 = null;
					MessageBox.Show("停止吃洋芋片");
					return;
				}
				Eat_Food eatFood = new Eat_Food(1)
				{
					Top = this.Top + 65,
					Left = this.Left + 135
				};
				eatFood.ShowDialog();
				if (eatFood.ButtonClicked)
				{
					if (!eatFood.repeat)
					{
						Request.Eat(1);
						return;
					}
					EatingTimer1 = new Timer(new TimerCallback(EatFood1), null, 0, 20);
					return;
				}
			}
		}

		private void Food_2_Click(object sender, RoutedEventArgs e)
		{
			if (user.food_2 == 0)
			{
				MessageBox.Show("無漢堡");
			}
			else
			{
				if (EatingTimer2 != null)
				{
					EatingTimer2.Dispose();
					EatingTimer2 = null;
					MessageBox.Show("停止吃漢堡");
					return;
				}
				Eat_Food eatFood = new Eat_Food(2)
				{
					Top = this.Top + 65,
					Left = this.Left + 135
				};
				eatFood.ShowDialog();
				if (eatFood.ButtonClicked)
				{
					if (!eatFood.repeat)
					{
						Request.Eat(2);
						return;
					}
					EatingTimer2 = new Timer(new TimerCallback(EatFood2), null, 0, 20);
					return;
				}
			}
		}

		private void FullAutoStart()
		{
			user.isRunning = true;
			user.Notification(string.Concat("[開始] ", user.get_case_name(user.case_id), " 第 1-9 場景"));
			int num = 1;
			do
			{
			Label0:
				if (num > 9)
				{
					break;
				}
				user.scene_id = num;
				if (user.case_id == 1 && num > 3 || user.case_id == 2 && num > 6)
				{
					break;
				}
				if (user.current_star != 5)
				{
					Random random = new Random(Guid.NewGuid().GetHashCode());
					int num1 = 0;
					if (user.current_star == 0)
					{
						num1 = 2000;
					}
					else if (user.current_star == 1)
					{
						num1 = 3000;
					}
					else if (user.current_star == 2)
					{
						num1 = 4000;
					}
					else if (user.current_star == 3)
					{
						num1 = 5000;
					}
					else if (user.current_star == 4)
					{
						num1 = 6000;
					}
					else if (user.current_star == 5)
					{
						num1 = 7000;
					}
					int num2 = random.Next(num1, num1 + 2000) * 100;
					user.score = num2.ToString();
					if (!Request.startGame())
					{
						try
						{
							if (((dynamic)user.StartData).error.type == "energy")
							{
								Console.WriteLine("No Energy!");
								user.isAutoPlay = false;
								user.energy = (int)((dynamic)user.StartData).error.sync.energy;
								user.coins = (int)((dynamic)user.StartData).error.sync.coins;
							}
							Request.GetUserData();
							if (Request.Abandon_CASEID != 0 && Request.Abandon_STAGEID != 0)
							{
								Request.Abandon();
							}
						}
						catch (Exception exception)
						{
							user.WriteLog(string.Concat("1b2b4c6643b5c96a07abdf16fb2220fe|", exception.Message));
						}
					}
					else
					{
						Request.EndGame();
					}
				}
				else
				{
					num++;
					goto Label0;
				}
			}
			while (user.isAutoPlay);
			user.isRunning = false;
			user.Loop_USE_TEAMMTE = false;
			user.Notification(string.Concat("[結束] ", user.get_case_name(user.case_id), " 第 1-9 場景"));
			user.scene_id = 0;
		}

		private void GetReport()
		{
			Request.GetReport();
		}

		private void Gift_Click(object sender, RoutedEventArgs e)
		{
			if (giftTimer != null)
			{
				giftTimer.Dispose();
				giftTimer = null;
				((Button)sender).Background = null;
			}
			else
			{
				card_w cardW = new card_w()
				{
					Top = this.Top + 25,
					Left = this.Left + 25
				};
				cardW.ShowDialog();
				if (cardW.ButtonClicked)
				{
					giftTimer = new Timer(new TimerCallback(GiftMethod), null, 0, 30000);
					((Button)sender).Background = Brushes.LightSalmon;
					return;
				}
			}
		}

		public void GiftMethod(object state)
		{
			if (!user.isAcceptGift)
			{
				Request.AcceptGift();
			}
		}

		private void OpenPack(object state)
		{
			if (user.stickers_pack_count >= 0)
			{
				if (Request.OpenNextPack())
				{
					user.stickers_pack_count--;
					return;
				}
				if (OpenPackTimer != null)
				{
					OpenPackTimer.Dispose();
					OpenPackTimer = null;
				}
			}
		}

		private void OpenPack_Click(object sender, RoutedEventArgs e)
		{
			if (OpenPackTimer != null)
			{
				OpenPackTimer.Dispose();
				OpenPackTimer = null;
				((Button)sender).Background = null;
				return;
			}
			OpenPackTimer = new Timer(new TimerCallback(OpenPack), null, 0, 20);
			((Button)sender).Background = Brushes.LightSalmon;
		}

		private void Report_Click(object sender, RoutedEventArgs e)
		{
			if (Report_Thread != null)
			{
				Report_Thread.Abort();
				Report_Thread = null;
				return;
			}
			Report_Thread = new Thread(new ThreadStart(GetReport));
			Report_Thread.Start();
		}

		private void scene_select(object sender, RoutedEventArgs e)
		{
			if (user.isRunning)
			{
				user.isAutoPlay = false;
			}
			else
			{
				user.scene_id = Convert.ToInt32(((Window1.SceneButton)sender).Tag);
				Window2 window2 = new Window2()
				{
					Top = this.Top + 145,
					Left = this.Left + 175
				};
				window2.ShowDialog();
				if (window2.ButtonClick)
				{
					(new Thread(new ThreadStart(AutoStart))).Start();
					return;
				}
			}
		}

		private void Season_Afterwards_Click(object sender, RoutedEventArgs e)
		{
			if (user.current_season < Global.maxSeason)
			{
				user.current_season++;
			}
			Season.Content = string.Concat("第 ", user.current_season, " 季");
			updateUI();
		}

		private void Season_Backwards_Click(object sender, RoutedEventArgs e)
		{
			if (user.current_season > Global.minSeason)
			{
				user.current_season--;
			}
			Season.Content = string.Concat("第 ", user.current_season, " 季");
			updateUI();
		}

		private void SendAllFriendEnergy()
		{
			Request.SendAllFriendEnergy();
		}

		private void SendEnergy_Click(object sender, RoutedEventArgs e)
		{
			SendFreeEnergy sendFreeEnergy = new SendFreeEnergy()
			{
				Top = this.Top + 25,
				Left = this.Left + 25
			};
			sendFreeEnergy.ShowDialog();
			if (sendFreeEnergy.SendAllFriend)
			{
				(new Thread(new ThreadStart(SendAllFriendEnergy))).Start();
			}
		}

		private void SuperStart()
		{
			user.isRunning = true;
			user.Notification(string.Concat("[開始] ", user.get_case_name(user.case_id), " 第 1-9 場景"));
			int num = 1;
			do
			{
			Label0:
				if (num > 9)
				{
					break;
				}
				object[] caseId = new object[] { "Case_ID:", user.case_id, "Secene:", user.scene_id };
				Console.WriteLine(string.Concat(caseId));
				user.scene_id = num;
				if (user.case_id == 1 && num > 3 || user.case_id == 2 && num > 6)
				{
					break;
				}
				if (user.current_star != 5 || user.high_score < user.stage[user.stage_id].MaxScore)
				{
					Random random = new Random(Guid.NewGuid().GetHashCode());
					int num1 = 0;
					if (user.current_star == 0)
					{
						num1 = 2000;
					}
					else if (user.current_star == 1)
					{
						num1 = 3000;
					}
					else if (user.current_star == 2)
					{
						num1 = 4000;
					}
					else if (user.current_star == 3)
					{
						num1 = 5000;
					}
					else if (user.current_star == 4)
					{
						num1 = 6000;
					}
					else if (user.current_star == 5)
					{
						num1 = 7000;
					}
					int num2 = random.Next(num1, num1 + 2000) * 100;
					user.score = num2.ToString();
					if (!Request.startGame())
					{
						try
						{
							if (((dynamic)user.StartData).error.type == "energy")
							{
								Console.WriteLine("No Energy!");
								user.isAutoPlay = false;
								user.energy = (int)((dynamic)user.StartData).error.sync.energy;
								user.coins = (int)((dynamic)user.StartData).error.sync.coins;
							}
							Request.GetUserData();
							if (Request.Abandon_CASEID != 0 && Request.Abandon_STAGEID != 0)
							{
								Request.Abandon();
							}
						}
						catch (Exception exception)
						{
							user.WriteLog(string.Concat("1b2b4c6643b5c96a07abdf16fb2220fe|", exception.Message));
						}
					}
					else
					{
						Request.EndGame();
					}
				}
				else
				{
					object[] objArray = new object[] { "Case_ID:", user.case_id, "Secene:", user.scene_id, "highscore:", user.high_score, "/", user.stage[user.stage_id].MaxScore };
					Console.WriteLine(string.Concat(objArray));
					num++;
					goto Label0;
				}
			}
			while (user.isAutoPlay);
			user.isRunning = false;
			user.Loop_USE_TEAMMTE = false;
			user.Notification(string.Concat("[結束] ", user.get_case_name(user.case_id), " 第 1-9 場景"));
			user.scene_id = 0;
		}

		public void AutoPetFeeding_Callback(object state)
		{
			if (user.data["response"]["pets"] != null)
            {
                foreach (JProperty pet in user.data["response"]["pets"]["adopted"])
                {
                    String petID = pet.Name;
                    JToken petData = pet.Value;
					int level = Convert.ToInt32(petData["level"]);
					int cooldownAfter = Convert.ToInt32(petData["cooldown"]) -5;
                    if (level == 5 || cooldownAfter >= 0)
						continue;
                    if ( Request.FeedPet(petID) )
                        petData["cooldown"] = cooldownAfter;
                }
            }
		}

		private void updateUI()
        {
            // Set all buttons to the default color and hide the stages out of range.
            for (int i = 1; i <= 60; i++)
			{
                int stagePos = i - 1;
				BrushConverter brushConverter = new BrushConverter();
                caseButtons[stagePos].Background = Global.getStageButtonBrushColor();
                caseButtons[stagePos].IsEnabled = false;
                caseButtons[stagePos].Visibility = Visibility.Hidden;
			}
            try
            {
                foreach (JProperty currentCase in user.data["response"]["cases_stars"])
                {
                    int caseNumber = Convert.ToInt32(currentCase.Name);
                    int season = caseNumber / 100;
                    if (season == 0) season = 1;
                    if (season != user.current_season)
                        continue;
                    int buttonPos = (caseNumber % 100) - 1;
                    caseButtons[buttonPos].IsEnabled = true;
                    caseButtons[buttonPos].Tag = caseNumber;
                    caseButtons[buttonPos].Background = Global.getStageButtonBrushColor(caseNumber);
                    caseButtons[buttonPos].Visibility = Visibility.Visible;
                }
            }
            catch { }
		}

		private void update_dashboard(object state)
		{
			this.Dispatcher.BeginInvoke(new Action(() => {
				try
				{
					Label_Level.Content = Convert.ToString(user.level);
					Label_XP.Content = Convert.ToString(user.xp);
					Label_Energy.Content = Convert.ToString(user.energy);
					Label_Coins.Content = Convert.ToString(user.coins);
					for (int i = 0; i < 9; i++)
					{
						scene[i].current_star = user.stage[user.get_stage_id(i)].case_stars;
						scene[i].Content = string.Concat(user.star(scene[i].current_star), "\r\n", user.stage[user.get_stage_id(i)].high_score);
					}
					userID.Content = user.Last_Message;
					updateUI();
					if (user.isCollectMode(user.case_id))
					{
						Case_Name.Content = string.Concat(new object[] { "收藏模式 - 第", user.current_season, "季 第 ", user.case_id, " 關 | ★ ", user.available_stars });
					}
					else if (!user.isCaseElite)
					{
						Case_Name.Content = string.Concat(new object[] { "普通模式 - 第", user.current_season, "季 第 ", user.case_id, " 關 | ★ ", user.available_stars });
					}
					else
					{
						Case_Name.Content = string.Concat(new object[] { "菁英模式 - 第", user.current_season, "季 第 ", user.case_id, " 關 | ★ ", user.available_stars });
					}
					this.Title = string.Concat(new object[] { user.Version, "|", user.food_0, " 柳橙汁 | ", user.food_1, " 洋芋片 | ", user.food_2, " 漢堡 | ", user.stickers_pack_count, " 貼紙包" });
				}
				catch (Exception exception)
				{
					Console.WriteLine(exception.Message);
				}
			}), new object[0]);
		}

        private class CaseButton : Button { }

		private class SceneButton : Button
		{
			public int current_star = 0;
			public int high_score = 0;
			public int available_stars = 0;
			public int current_score = 0;
		}
	}
}