using Microsoft.CSharp.RuntimeBinder;
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Media;

namespace AiteCriminal
{
	public class Window1 : Window, IComponentConnector
	{
		private class Case_Button : Button
		{
		}

		private class Scene_Button : Button
		{
			public int current_star;

			public int high_score;

			public int available_stars;

			public int current_score;
		}

		[CompilerGenerated]
		private static class <ThreadMethod>o__SiteContainer0
		{
			public static CallSite<Func<CallSite, object, bool>> <>p__Site1;

			public static CallSite<Func<CallSite, object, object, object>> <>p__Site2;

			public static CallSite<Func<CallSite, object, string, object>> <>p__Site3;

			public static CallSite<Func<CallSite, object, string, object>> <>p__Site4;

			public static CallSite<Func<CallSite, object, IEnumerable>> <>p__Site5;

			public static CallSite<Func<CallSite, object, string, object>> <>p__Site6;

			public static CallSite<Func<CallSite, object, string, object>> <>p__Site7;

			public static CallSite<Func<CallSite, object, string, object>> <>p__Site8;

			public static CallSite<Func<CallSite, object, string>> <>p__Site9;

			public static CallSite<Func<CallSite, object, object>> <>p__Sitea;

			public static CallSite<Func<CallSite, object, int>> <>p__Siteb;

			public static CallSite<Func<CallSite, object, object>> <>p__Sitec;

			public static CallSite<Func<CallSite, object, object>> <>p__Sited;

			public static CallSite<Func<CallSite, object, int>> <>p__Sitee;

			public static CallSite<Func<CallSite, object, object>> <>p__Sitef;

			public static CallSite<Func<CallSite, object, object>> <>p__Site10;

			public static CallSite<Func<CallSite, object, int>> <>p__Site11;

			public static CallSite<Func<CallSite, object, int, object>> <>p__Site12;

			public static CallSite<Func<CallSite, object, object>> <>p__Site13;

			public static CallSite<Func<CallSite, object, object>> <>p__Site14;

			public static CallSite<Func<CallSite, object, int, object>> <>p__Site15;

			public static CallSite<Func<CallSite, object, object>> <>p__Site16;
		}

		[CompilerGenerated]
		private static class <UPDATE_CASES_DISPLAY>o__SiteContainer17
		{
			public static CallSite<Func<CallSite, object, IEnumerable>> <>p__Site18;

			public static CallSite<Func<CallSite, object, string, object>> <>p__Site19;

			public static CallSite<Func<CallSite, object, string, object>> <>p__Site1a;

			public static CallSite<Func<CallSite, object, int>> <>p__Site1b;

			public static CallSite<Func<CallSite, Type, object, object>> <>p__Site1c;

			public static CallSite<Func<CallSite, object, object>> <>p__Site1d;
		}

		[CompilerGenerated]
		private static class <case_select>o__SiteContainer1f
		{
			public static CallSite<Func<CallSite, object, IEnumerable>> <>p__Site20;

			public static CallSite<Func<CallSite, object, string, object>> <>p__Site21;

			public static CallSite<Func<CallSite, object, string, object>> <>p__Site22;

			public static CallSite<Func<CallSite, object, int>> <>p__Site23;

			public static CallSite<Func<CallSite, object, string, object>> <>p__Site24;

			public static CallSite<Func<CallSite, object, int>> <>p__Site25;

			public static CallSite<Func<CallSite, object, string, object>> <>p__Site26;

			public static CallSite<Func<CallSite, object, int>> <>p__Site27;

			public static CallSite<Func<CallSite, object, string, object>> <>p__Site28;

			public static CallSite<Func<CallSite, object, int>> <>p__Site29;

			public static CallSite<Func<CallSite, object, string, object>> <>p__Site2a;

			public static CallSite<Func<CallSite, object, string, object>> <>p__Site2b;

			public static CallSite<Func<CallSite, object, int>> <>p__Site2c;

			public static CallSite<Func<CallSite, object, string, object>> <>p__Site2d;

			public static CallSite<Func<CallSite, object, string, object>> <>p__Site2e;
		}

		[CompilerGenerated]
		private static class <SuperStart>o__SiteContainer2f
		{
			public static CallSite<Func<CallSite, object, bool>> <>p__Site30;

			public static CallSite<Func<CallSite, object, string, object>> <>p__Site31;

			public static CallSite<Func<CallSite, object, object>> <>p__Site32;

			public static CallSite<Func<CallSite, object, object>> <>p__Site33;

			public static CallSite<Func<CallSite, object, int>> <>p__Site34;

			public static CallSite<Func<CallSite, object, object>> <>p__Site35;

			public static CallSite<Func<CallSite, object, object>> <>p__Site36;

			public static CallSite<Func<CallSite, object, object>> <>p__Site37;

			public static CallSite<Func<CallSite, object, int>> <>p__Site38;

			public static CallSite<Func<CallSite, object, object>> <>p__Site39;

			public static CallSite<Func<CallSite, object, object>> <>p__Site3a;

			public static CallSite<Func<CallSite, object, object>> <>p__Site3b;
		}

		[CompilerGenerated]
		private static class <FullAutoStart>o__SiteContainer3c
		{
			public static CallSite<Func<CallSite, object, bool>> <>p__Site3d;

			public static CallSite<Func<CallSite, object, string, object>> <>p__Site3e;

			public static CallSite<Func<CallSite, object, object>> <>p__Site3f;

			public static CallSite<Func<CallSite, object, object>> <>p__Site40;

			public static CallSite<Func<CallSite, object, int>> <>p__Site41;

			public static CallSite<Func<CallSite, object, object>> <>p__Site42;

			public static CallSite<Func<CallSite, object, object>> <>p__Site43;

			public static CallSite<Func<CallSite, object, object>> <>p__Site44;

			public static CallSite<Func<CallSite, object, int>> <>p__Site45;

			public static CallSite<Func<CallSite, object, object>> <>p__Site46;

			public static CallSite<Func<CallSite, object, object>> <>p__Site47;

			public static CallSite<Func<CallSite, object, object>> <>p__Site48;
		}

		[CompilerGenerated]
		private static class <AutoStart>o__SiteContainer49
		{
			public static CallSite<Func<CallSite, object, bool>> <>p__Site4a;

			public static CallSite<Func<CallSite, object, string, object>> <>p__Site4b;

			public static CallSite<Func<CallSite, object, object>> <>p__Site4c;

			public static CallSite<Func<CallSite, object, object>> <>p__Site4d;

			public static CallSite<Func<CallSite, object, int>> <>p__Site4e;

			public static CallSite<Func<CallSite, object, object>> <>p__Site4f;

			public static CallSite<Func<CallSite, object, object>> <>p__Site50;

			public static CallSite<Func<CallSite, object, object>> <>p__Site51;

			public static CallSite<Func<CallSite, object, int>> <>p__Site52;

			public static CallSite<Func<CallSite, object, object>> <>p__Site53;

			public static CallSite<Func<CallSite, object, object>> <>p__Site54;

			public static CallSite<Func<CallSite, object, object>> <>p__Site55;
		}

		private Window1.Scene_Button[] scene = new Window1.Scene_Button[9];

		private Window1.Case_Button[] Cases_Button = new Window1.Case_Button[60];

		private Timer threadTimer;

		private Timer giftTimer;

		private Timer EatingTimer0;

		private Timer EatingTimer1;

		private Timer EatingTimer2;

		private Timer updateTimer;

		private Thread Report_Thread;

		private Timer OpenPackTimer;

		internal Grid Main;

		internal Label Case_Name;

		internal Label Season;

		internal Button Season_Left;

		internal Button Season_Right;

		internal Grid Cases_Grid;

		internal Grid Scene_Grid;

		internal Button ClearStage;

		internal Button Donate;

		internal Label userID;

		internal Label Label_Level;

		internal Label Label_XP;

		internal Label Label_Coins;

		internal Label Label_Energy;

		private bool _contentLoaded;

		public void GiftMethod(object state)
		{
			if (!user.isAcceptGift)
			{
				Request.AcceptGift();
			}
		}

		public void ThreadMethod(object state)
		{
			if (Window1.<ThreadMethod>o__SiteContainer0.<>p__Site1 == null)
			{
				Window1.<ThreadMethod>o__SiteContainer0.<>p__Site1 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Window1), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			Func<CallSite, object, bool> arg_158_0 = Window1.<ThreadMethod>o__SiteContainer0.<>p__Site1.Target;
			CallSite arg_158_1 = Window1.<ThreadMethod>o__SiteContainer0.<>p__Site1;
			if (Window1.<ThreadMethod>o__SiteContainer0.<>p__Site2 == null)
			{
				Window1.<ThreadMethod>o__SiteContainer0.<>p__Site2 = CallSite<Func<CallSite, object, object, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.NotEqual, typeof(Window1), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, object, object> arg_153_0 = Window1.<ThreadMethod>o__SiteContainer0.<>p__Site2.Target;
			CallSite arg_153_1 = Window1.<ThreadMethod>o__SiteContainer0.<>p__Site2;
			if (Window1.<ThreadMethod>o__SiteContainer0.<>p__Site3 == null)
			{
				Window1.<ThreadMethod>o__SiteContainer0.<>p__Site3 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Window1), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, string, object> arg_14D_0 = Window1.<ThreadMethod>o__SiteContainer0.<>p__Site3.Target;
			CallSite arg_14D_1 = Window1.<ThreadMethod>o__SiteContainer0.<>p__Site3;
			if (Window1.<ThreadMethod>o__SiteContainer0.<>p__Site4 == null)
			{
				Window1.<ThreadMethod>o__SiteContainer0.<>p__Site4 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Window1), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			if (arg_158_0(arg_158_1, arg_153_0(arg_153_1, arg_14D_0(arg_14D_1, Window1.<ThreadMethod>o__SiteContainer0.<>p__Site4.Target(Window1.<ThreadMethod>o__SiteContainer0.<>p__Site4, user.data, "response"), "pets"), null)))
			{
				if (Window1.<ThreadMethod>o__SiteContainer0.<>p__Site5 == null)
				{
					Window1.<ThreadMethod>o__SiteContainer0.<>p__Site5 = CallSite<Func<CallSite, object, IEnumerable>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(IEnumerable), typeof(Window1)));
				}
				Func<CallSite, object, IEnumerable> arg_2AF_0 = Window1.<ThreadMethod>o__SiteContainer0.<>p__Site5.Target;
				CallSite arg_2AF_1 = Window1.<ThreadMethod>o__SiteContainer0.<>p__Site5;
				if (Window1.<ThreadMethod>o__SiteContainer0.<>p__Site6 == null)
				{
					Window1.<ThreadMethod>o__SiteContainer0.<>p__Site6 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Window1), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				Func<CallSite, object, string, object> arg_2AA_0 = Window1.<ThreadMethod>o__SiteContainer0.<>p__Site6.Target;
				CallSite arg_2AA_1 = Window1.<ThreadMethod>o__SiteContainer0.<>p__Site6;
				if (Window1.<ThreadMethod>o__SiteContainer0.<>p__Site7 == null)
				{
					Window1.<ThreadMethod>o__SiteContainer0.<>p__Site7 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Window1), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				Func<CallSite, object, string, object> arg_2A0_0 = Window1.<ThreadMethod>o__SiteContainer0.<>p__Site7.Target;
				CallSite arg_2A0_1 = Window1.<ThreadMethod>o__SiteContainer0.<>p__Site7;
				if (Window1.<ThreadMethod>o__SiteContainer0.<>p__Site8 == null)
				{
					Window1.<ThreadMethod>o__SiteContainer0.<>p__Site8 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Window1), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				foreach (object current in arg_2AF_0(arg_2AF_1, arg_2AA_0(arg_2AA_1, arg_2A0_0(arg_2A0_1, Window1.<ThreadMethod>o__SiteContainer0.<>p__Site8.Target(Window1.<ThreadMethod>o__SiteContainer0.<>p__Site8, user.data, "response"), "pets"), "adopted")))
				{
					if (Window1.<ThreadMethod>o__SiteContainer0.<>p__Site9 == null)
					{
						Window1.<ThreadMethod>o__SiteContainer0.<>p__Site9 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(Window1)));
					}
					Func<CallSite, object, string> arg_352_0 = Window1.<ThreadMethod>o__SiteContainer0.<>p__Site9.Target;
					CallSite arg_352_1 = Window1.<ThreadMethod>o__SiteContainer0.<>p__Site9;
					if (Window1.<ThreadMethod>o__SiteContainer0.<>p__Sitea == null)
					{
						Window1.<ThreadMethod>o__SiteContainer0.<>p__Sitea = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "Name", typeof(Window1), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					string pet_id = arg_352_0(arg_352_1, Window1.<ThreadMethod>o__SiteContainer0.<>p__Sitea.Target(Window1.<ThreadMethod>o__SiteContainer0.<>p__Sitea, current));
					if (Window1.<ThreadMethod>o__SiteContainer0.<>p__Siteb == null)
					{
						Window1.<ThreadMethod>o__SiteContainer0.<>p__Siteb = CallSite<Func<CallSite, object, int>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(int), typeof(Window1)));
					}
					Func<CallSite, object, int> arg_431_0 = Window1.<ThreadMethod>o__SiteContainer0.<>p__Siteb.Target;
					CallSite arg_431_1 = Window1.<ThreadMethod>o__SiteContainer0.<>p__Siteb;
					if (Window1.<ThreadMethod>o__SiteContainer0.<>p__Sitec == null)
					{
						Window1.<ThreadMethod>o__SiteContainer0.<>p__Sitec = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "level", typeof(Window1), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					Func<CallSite, object, object> arg_42C_0 = Window1.<ThreadMethod>o__SiteContainer0.<>p__Sitec.Target;
					CallSite arg_42C_1 = Window1.<ThreadMethod>o__SiteContainer0.<>p__Sitec;
					if (Window1.<ThreadMethod>o__SiteContainer0.<>p__Sited == null)
					{
						Window1.<ThreadMethod>o__SiteContainer0.<>p__Sited = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "First", typeof(Window1), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					int num = arg_431_0(arg_431_1, arg_42C_0(arg_42C_1, Window1.<ThreadMethod>o__SiteContainer0.<>p__Sited.Target(Window1.<ThreadMethod>o__SiteContainer0.<>p__Sited, current)));
					if (Window1.<ThreadMethod>o__SiteContainer0.<>p__Sitee == null)
					{
						Window1.<ThreadMethod>o__SiteContainer0.<>p__Sitee = CallSite<Func<CallSite, object, int>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(int), typeof(Window1)));
					}
					Func<CallSite, object, int> arg_510_0 = Window1.<ThreadMethod>o__SiteContainer0.<>p__Sitee.Target;
					CallSite arg_510_1 = Window1.<ThreadMethod>o__SiteContainer0.<>p__Sitee;
					if (Window1.<ThreadMethod>o__SiteContainer0.<>p__Sitef == null)
					{
						Window1.<ThreadMethod>o__SiteContainer0.<>p__Sitef = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "loyalty", typeof(Window1), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					Func<CallSite, object, object> arg_50B_0 = Window1.<ThreadMethod>o__SiteContainer0.<>p__Sitef.Target;
					CallSite arg_50B_1 = Window1.<ThreadMethod>o__SiteContainer0.<>p__Sitef;
					if (Window1.<ThreadMethod>o__SiteContainer0.<>p__Site10 == null)
					{
						Window1.<ThreadMethod>o__SiteContainer0.<>p__Site10 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "First", typeof(Window1), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					arg_510_0(arg_510_1, arg_50B_0(arg_50B_1, Window1.<ThreadMethod>o__SiteContainer0.<>p__Site10.Target(Window1.<ThreadMethod>o__SiteContainer0.<>p__Site10, current)));
					if (Window1.<ThreadMethod>o__SiteContainer0.<>p__Site11 == null)
					{
						Window1.<ThreadMethod>o__SiteContainer0.<>p__Site11 = CallSite<Func<CallSite, object, int>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(int), typeof(Window1)));
					}
					Func<CallSite, object, int> arg_647_0 = Window1.<ThreadMethod>o__SiteContainer0.<>p__Site11.Target;
					CallSite arg_647_1 = Window1.<ThreadMethod>o__SiteContainer0.<>p__Site11;
					if (Window1.<ThreadMethod>o__SiteContainer0.<>p__Site12 == null)
					{
						Window1.<ThreadMethod>o__SiteContainer0.<>p__Site12 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Subtract, typeof(Window1), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					Func<CallSite, object, int, object> arg_642_0 = Window1.<ThreadMethod>o__SiteContainer0.<>p__Site12.Target;
					CallSite arg_642_1 = Window1.<ThreadMethod>o__SiteContainer0.<>p__Site12;
					if (Window1.<ThreadMethod>o__SiteContainer0.<>p__Site13 == null)
					{
						Window1.<ThreadMethod>o__SiteContainer0.<>p__Site13 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "cooldown", typeof(Window1), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					Func<CallSite, object, object> arg_63C_0 = Window1.<ThreadMethod>o__SiteContainer0.<>p__Site13.Target;
					CallSite arg_63C_1 = Window1.<ThreadMethod>o__SiteContainer0.<>p__Site13;
					if (Window1.<ThreadMethod>o__SiteContainer0.<>p__Site14 == null)
					{
						Window1.<ThreadMethod>o__SiteContainer0.<>p__Site14 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "First", typeof(Window1), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					int num2 = arg_647_0(arg_647_1, arg_642_0(arg_642_1, arg_63C_0(arg_63C_1, Window1.<ThreadMethod>o__SiteContainer0.<>p__Site14.Target(Window1.<ThreadMethod>o__SiteContainer0.<>p__Site14, current)), 5));
					if (Window1.<ThreadMethod>o__SiteContainer0.<>p__Site15 == null)
					{
						Window1.<ThreadMethod>o__SiteContainer0.<>p__Site15 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.SetMember(CSharpBinderFlags.None, "cooldown", typeof(Window1), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
						}));
					}
					Func<CallSite, object, int, object> arg_6F3_0 = Window1.<ThreadMethod>o__SiteContainer0.<>p__Site15.Target;
					CallSite arg_6F3_1 = Window1.<ThreadMethod>o__SiteContainer0.<>p__Site15;
					if (Window1.<ThreadMethod>o__SiteContainer0.<>p__Site16 == null)
					{
						Window1.<ThreadMethod>o__SiteContainer0.<>p__Site16 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "First", typeof(Window1), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					arg_6F3_0(arg_6F3_1, Window1.<ThreadMethod>o__SiteContainer0.<>p__Site16.Target(Window1.<ThreadMethod>o__SiteContainer0.<>p__Site16, current), num2);
					if (num != 5 && num2 < 0)
					{
						Request.FeedPet(pet_id);
					}
				}
			}
		}

		public Window1()
		{
			this.InitializeComponent();
			this.threadTimer = new Timer(new TimerCallback(this.ThreadMethod), null, 0, 5000);
			base.Width = 480.0;
			base.Height = 485.0;
			base.ResizeMode = ResizeMode.CanMinimize;
			for (int i = 0; i < 6; i++)
			{
				for (int j = 0; j < 10; j++)
				{
					int num = i * 10 + j;
					this.Cases_Button[num] = new Window1.Case_Button();
					this.Cases_Button[num].Width = 45.0;
					this.Cases_Button[num].Height = 45.0;
					this.Cases_Button[num].Margin = new Thickness((double)(5 + j * 46), (double)(5 + i * 46), 0.0, 0.0);
					this.Cases_Button[num].VerticalAlignment = VerticalAlignment.Top;
					this.Cases_Button[num].HorizontalAlignment = HorizontalAlignment.Left;
					this.Cases_Button[num].HorizontalContentAlignment = HorizontalAlignment.Center;
					this.Cases_Button[num].Background = Brushes.DimGray;
					this.Cases_Button[num].Click += new RoutedEventHandler(this.case_select);
					this.Cases_Button[num].Content = num + 1;
					this.Cases_Button[num].Tag = num + 1;
					this.Cases_Button[num].Style = (Style)base.FindResource("MyButton");
					this.Cases_Button[num].IsEnabled = false;
					this.Cases_Grid.Children.Add(this.Cases_Button[num]);
				}
			}
			this.UPDATE_CASES_DISPLAY();
			this.Case_Name.Visibility = Visibility.Hidden;
			this.Scene_Grid.Visibility = Visibility.Hidden;
			for (int k = 0; k < 9; k++)
			{
				this.scene[k] = new Window1.Scene_Button();
				this.scene[k].Width = 127.0;
				this.scene[k].Height = 88.0;
				this.scene[k].Margin = new Thickness((double)(65 + k % 3 * 132), (double)(k / 3 * 93), 0.0, 0.0);
				this.scene[k].VerticalAlignment = VerticalAlignment.Top;
				this.scene[k].HorizontalAlignment = HorizontalAlignment.Left;
				this.scene[k].HorizontalContentAlignment = HorizontalAlignment.Center;
				this.scene[k].Click += new RoutedEventHandler(this.scene_select);
				this.scene[k].Tag = k + 1;
				this.scene[k].Style = (Style)base.FindResource("SceneButton");
				this.Scene_Grid.Children.Add(this.scene[k]);
			}
			user.Last_Message = "歡迎使用 " + user.id;
			this.updateTimer = new Timer(new TimerCallback(this.update_dashboard), null, 0, 500);
		}

		private void UPDATE_CASES_DISPLAY()
		{
			int num = 1;
			int num2 = 56;
			if (user.current_season == 2)
			{
				num = 201;
				num2 = 259;
			}
			else if (user.current_season == 3)
			{
				num = 301;
				num2 = 356;
			}
			else if (user.current_season == 4)
			{
				num = 401;
				num2 = 456;
			}
			for (int i = 1; i <= 60; i++)
			{
				int num3 = num % 100;
				int num4 = num2 % 100;
				BrushConverter brushConverter = new BrushConverter();
				this.Cases_Button[i - 1].Background = (Brush)brushConverter.ConvertFromString("#FF252525");
				this.Cases_Button[i - 1].IsEnabled = false;
				if (i >= num3 && i <= num4)
				{
					this.Cases_Button[i - 1].Visibility = Visibility.Visible;
				}
				else
				{
					this.Cases_Button[i - 1].Visibility = Visibility.Hidden;
				}
			}
			try
			{
				if (Window1.<UPDATE_CASES_DISPLAY>o__SiteContainer17.<>p__Site18 == null)
				{
					Window1.<UPDATE_CASES_DISPLAY>o__SiteContainer17.<>p__Site18 = CallSite<Func<CallSite, object, IEnumerable>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(IEnumerable), typeof(Window1)));
				}
				Func<CallSite, object, IEnumerable> arg_1B2_0 = Window1.<UPDATE_CASES_DISPLAY>o__SiteContainer17.<>p__Site18.Target;
				CallSite arg_1B2_1 = Window1.<UPDATE_CASES_DISPLAY>o__SiteContainer17.<>p__Site18;
				if (Window1.<UPDATE_CASES_DISPLAY>o__SiteContainer17.<>p__Site19 == null)
				{
					Window1.<UPDATE_CASES_DISPLAY>o__SiteContainer17.<>p__Site19 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Window1), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				Func<CallSite, object, string, object> arg_1AD_0 = Window1.<UPDATE_CASES_DISPLAY>o__SiteContainer17.<>p__Site19.Target;
				CallSite arg_1AD_1 = Window1.<UPDATE_CASES_DISPLAY>o__SiteContainer17.<>p__Site19;
				if (Window1.<UPDATE_CASES_DISPLAY>o__SiteContainer17.<>p__Site1a == null)
				{
					Window1.<UPDATE_CASES_DISPLAY>o__SiteContainer17.<>p__Site1a = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Window1), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				foreach (object current in arg_1B2_0(arg_1B2_1, arg_1AD_0(arg_1AD_1, Window1.<UPDATE_CASES_DISPLAY>o__SiteContainer17.<>p__Site1a.Target(Window1.<UPDATE_CASES_DISPLAY>o__SiteContainer17.<>p__Site1a, user.data, "response"), "cases_stars")))
				{
					if (Window1.<UPDATE_CASES_DISPLAY>o__SiteContainer17.<>p__Site1b == null)
					{
						Window1.<UPDATE_CASES_DISPLAY>o__SiteContainer17.<>p__Site1b = CallSite<Func<CallSite, object, int>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(int), typeof(Window1)));
					}
					Func<CallSite, object, int> arg_2BD_0 = Window1.<UPDATE_CASES_DISPLAY>o__SiteContainer17.<>p__Site1b.Target;
					CallSite arg_2BD_1 = Window1.<UPDATE_CASES_DISPLAY>o__SiteContainer17.<>p__Site1b;
					if (Window1.<UPDATE_CASES_DISPLAY>o__SiteContainer17.<>p__Site1c == null)
					{
						Window1.<UPDATE_CASES_DISPLAY>o__SiteContainer17.<>p__Site1c = CallSite<Func<CallSite, Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToInt32", null, typeof(Window1), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					Func<CallSite, Type, object, object> arg_2B8_0 = Window1.<UPDATE_CASES_DISPLAY>o__SiteContainer17.<>p__Site1c.Target;
					CallSite arg_2B8_1 = Window1.<UPDATE_CASES_DISPLAY>o__SiteContainer17.<>p__Site1c;
					Type arg_2B8_2 = typeof(Convert);
					if (Window1.<UPDATE_CASES_DISPLAY>o__SiteContainer17.<>p__Site1d == null)
					{
						Window1.<UPDATE_CASES_DISPLAY>o__SiteContainer17.<>p__Site1d = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "Name", typeof(Window1), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					int num5 = arg_2BD_0(arg_2BD_1, arg_2B8_0(arg_2B8_1, arg_2B8_2, Window1.<UPDATE_CASES_DISPLAY>o__SiteContainer17.<>p__Site1d.Target(Window1.<UPDATE_CASES_DISPLAY>o__SiteContainer17.<>p__Site1d, current)));
					if (num5 >= num && num5 <= num2)
					{
						int num6 = num5 - num;
						this.Cases_Button[num6].IsEnabled = true;
						this.Cases_Button[num6].Tag = num5;
						BrushConverter brushConverter2 = new BrushConverter();
						Brush background = (Brush)brushConverter2.ConvertFromString("#FFFFFF");
						if (user.isCollectMode(num5))
						{
							background = (Brush)brushConverter2.ConvertFromString("#F7665A");
						}
						else if (user.Elite_Medal(num5) == 4)
						{
							background = (Brush)brushConverter2.ConvertFromString("#EE9944");
						}
						else if (user.Elite_Medal(num5) == 5)
						{
							background = (Brush)brushConverter2.ConvertFromString("#F3F3F3");
						}
						else if (user.Elite_Medal(num5) == 6)
						{
							background = (Brush)brushConverter2.ConvertFromString("#FFFF00");
						}
						else if (user.Medal(num5) == 1)
						{
							background = (Brush)brushConverter2.ConvertFromString("#B87333");
						}
						else if (user.Medal(num5) == 2)
						{
							background = (Brush)brushConverter2.ConvertFromString("#C0C0C0");
						}
						else if (user.Medal(num5) == 3)
						{
							background = (Brush)brushConverter2.ConvertFromString("#FFD700");
						}
						this.Cases_Button[num6].Background = background;
					}
				}
			}
			catch
			{
			}
		}

		private void update_dashboard(object state)
		{
			base.Dispatcher.BeginInvoke(new Action(delegate
			{
				try
				{
					this.Label_Level.Content = Convert.ToString(user.level);
					this.Label_XP.Content = Convert.ToString(user.xp);
					this.Label_Energy.Content = Convert.ToString(user.energy);
					this.Label_Coins.Content = Convert.ToString(user.coins);
					for (int i = 0; i < 9; i++)
					{
						this.scene[i].current_star = user.stage[user.get_stage_id(i)].case_stars;
						this.scene[i].Content = user.star(this.scene[i].current_star) + "\r\n" + user.stage[user.get_stage_id(i)].high_score;
					}
					this.userID.Content = user.Last_Message;
					this.UPDATE_CASES_DISPLAY();
					if (user.isCollectMode(user.case_id))
					{
						this.Case_Name.Content = string.Concat(new object[]
						{
							"收藏模式 - 第",
							user.current_season,
							"季 第 ",
							user.case_id,
							" 關 | ★ ",
							user.available_stars
						});
					}
					else if (user.isCaseElite)
					{
						this.Case_Name.Content = string.Concat(new object[]
						{
							"菁英模式 - 第",
							user.current_season,
							"季 第 ",
							user.case_id,
							" 關 | ★ ",
							user.available_stars
						});
					}
					else
					{
						this.Case_Name.Content = string.Concat(new object[]
						{
							"普通模式 - 第",
							user.current_season,
							"季 第 ",
							user.case_id,
							" 關 | ★ ",
							user.available_stars
						});
					}
					base.Title = string.Concat(new object[]
					{
						user.Version,
						"|",
						user.food_0,
						" 柳橙汁 | ",
						user.food_1,
						" 洋芋片 | ",
						user.food_2,
						" 漢堡 | ",
						user.stickers_pack_count,
						" 貼紙包"
					});
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex.Message);
				}
			}), new object[0]);
		}

		private void case_select(object sender, RoutedEventArgs e)
		{
			user.scene_id = 0;
			user.case_id = Convert.ToInt32(((Button)sender).Tag);
			if (Request.FetchCase())
			{
				int num = 0;
				this.Cases_Grid.Visibility = Visibility.Hidden;
				this.Scene_Grid.Visibility = Visibility.Visible;
				this.Season.Visibility = Visibility.Hidden;
				this.Season_Left.Visibility = Visibility.Hidden;
				this.Season_Right.Visibility = Visibility.Hidden;
				this.Case_Name.Visibility = Visibility.Visible;
				int num2 = (user.case_id == 1) ? 3 : ((user.case_id == 2) ? 6 : 9);
				for (int i = 0; i < num2; i++)
				{
					this.scene[i].Content = user.star(0);
					user.stage[user.get_stage_id(i)].case_stars = 0;
					user.stage[user.get_stage_id(i)].high_score = 0;
					this.scene[i].Visibility = Visibility.Visible;
				}
				for (int j = num2; j < 9; j++)
				{
					user.stage[user.get_stage_id(j)].case_stars = 5;
					this.scene[j].Visibility = Visibility.Hidden;
				}
				if (Window1.<case_select>o__SiteContainer1f.<>p__Site20 == null)
				{
					Window1.<case_select>o__SiteContainer1f.<>p__Site20 = CallSite<Func<CallSite, object, IEnumerable>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(IEnumerable), typeof(Window1)));
				}
				Func<CallSite, object, IEnumerable> arg_205_0 = Window1.<case_select>o__SiteContainer1f.<>p__Site20.Target;
				CallSite arg_205_1 = Window1.<case_select>o__SiteContainer1f.<>p__Site20;
				if (Window1.<case_select>o__SiteContainer1f.<>p__Site21 == null)
				{
					Window1.<case_select>o__SiteContainer1f.<>p__Site21 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Window1), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				Func<CallSite, object, string, object> arg_200_0 = Window1.<case_select>o__SiteContainer1f.<>p__Site21.Target;
				CallSite arg_200_1 = Window1.<case_select>o__SiteContainer1f.<>p__Site21;
				if (Window1.<case_select>o__SiteContainer1f.<>p__Site22 == null)
				{
					Window1.<case_select>o__SiteContainer1f.<>p__Site22 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Window1), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				foreach (object current in arg_205_0(arg_205_1, arg_200_0(arg_200_1, Window1.<case_select>o__SiteContainer1f.<>p__Site22.Target(Window1.<case_select>o__SiteContainer1f.<>p__Site22, user.StageData, "response"), "nodes")))
				{
					if (Window1.<case_select>o__SiteContainer1f.<>p__Site23 == null)
					{
						Window1.<case_select>o__SiteContainer1f.<>p__Site23 = CallSite<Func<CallSite, object, int>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(int), typeof(Window1)));
					}
					Func<CallSite, object, int> arg_2B5_0 = Window1.<case_select>o__SiteContainer1f.<>p__Site23.Target;
					CallSite arg_2B5_1 = Window1.<case_select>o__SiteContainer1f.<>p__Site23;
					if (Window1.<case_select>o__SiteContainer1f.<>p__Site24 == null)
					{
						Window1.<case_select>o__SiteContainer1f.<>p__Site24 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Window1), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					int num3 = arg_2B5_0(arg_2B5_1, Window1.<case_select>o__SiteContainer1f.<>p__Site24.Target(Window1.<case_select>o__SiteContainer1f.<>p__Site24, current, "id"));
					if (num3 >= 1011 && num3 <= 1033)
					{
						int num4 = 0;
						try
						{
							user.Stage arg_381_0 = user.stage[num3];
							if (Window1.<case_select>o__SiteContainer1f.<>p__Site25 == null)
							{
								Window1.<case_select>o__SiteContainer1f.<>p__Site25 = CallSite<Func<CallSite, object, int>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(int), typeof(Window1)));
							}
							Func<CallSite, object, int> arg_379_0 = Window1.<case_select>o__SiteContainer1f.<>p__Site25.Target;
							CallSite arg_379_1 = Window1.<case_select>o__SiteContainer1f.<>p__Site25;
							if (Window1.<case_select>o__SiteContainer1f.<>p__Site26 == null)
							{
								Window1.<case_select>o__SiteContainer1f.<>p__Site26 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Window1), new CSharpArgumentInfo[]
								{
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
								}));
							}
							num4 = (arg_381_0.case_stars = arg_379_0(arg_379_1, Window1.<case_select>o__SiteContainer1f.<>p__Site26.Target(Window1.<case_select>o__SiteContainer1f.<>p__Site26, current, "current_star")));
							user.Stage arg_42D_0 = user.stage[num3];
							if (Window1.<case_select>o__SiteContainer1f.<>p__Site27 == null)
							{
								Window1.<case_select>o__SiteContainer1f.<>p__Site27 = CallSite<Func<CallSite, object, int>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(int), typeof(Window1)));
							}
							Func<CallSite, object, int> arg_428_0 = Window1.<case_select>o__SiteContainer1f.<>p__Site27.Target;
							CallSite arg_428_1 = Window1.<case_select>o__SiteContainer1f.<>p__Site27;
							if (Window1.<case_select>o__SiteContainer1f.<>p__Site28 == null)
							{
								Window1.<case_select>o__SiteContainer1f.<>p__Site28 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Window1), new CSharpArgumentInfo[]
								{
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
								}));
							}
							arg_42D_0.high_score = arg_428_0(arg_428_1, Window1.<case_select>o__SiteContainer1f.<>p__Site28.Target(Window1.<case_select>o__SiteContainer1f.<>p__Site28, current, "high_score"));
						}
						catch
						{
							user.stage[num3].case_stars = 0;
							user.stage[num3].high_score = 0;
						}
						num += num4;
					}
				}
				if (user.Elite_Medal(user.case_id) == 6 || (user.Elite_Medal(user.case_id) == 0 && user.Medal(user.case_id) == 3))
				{
					if (Window1.<case_select>o__SiteContainer1f.<>p__Site29 == null)
					{
						Window1.<case_select>o__SiteContainer1f.<>p__Site29 = CallSite<Func<CallSite, object, int>>.Create(Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(int), typeof(Window1)));
					}
					Func<CallSite, object, int> arg_5A3_0 = Window1.<case_select>o__SiteContainer1f.<>p__Site29.Target;
					CallSite arg_5A3_1 = Window1.<case_select>o__SiteContainer1f.<>p__Site29;
					if (Window1.<case_select>o__SiteContainer1f.<>p__Site2a == null)
					{
						Window1.<case_select>o__SiteContainer1f.<>p__Site2a = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Window1), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					Func<CallSite, object, string, object> arg_59E_0 = Window1.<case_select>o__SiteContainer1f.<>p__Site2a.Target;
					CallSite arg_59E_1 = Window1.<case_select>o__SiteContainer1f.<>p__Site2a;
					if (Window1.<case_select>o__SiteContainer1f.<>p__Site2b == null)
					{
						Window1.<case_select>o__SiteContainer1f.<>p__Site2b = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Window1), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					if (arg_5A3_0(arg_5A3_1, arg_59E_0(arg_59E_1, Window1.<case_select>o__SiteContainer1f.<>p__Site2b.Target(Window1.<case_select>o__SiteContainer1f.<>p__Site2b, user.StageData, "response"), "available_stars")) > 2 && !user.isCurrent_case)
					{
						Hamburger hamburger = new Hamburger();
						hamburger.Top = base.Top + 150.0;
						hamburger.Left = base.Left + 105.0;
						if (Window1.<case_select>o__SiteContainer1f.<>p__Site2c == null)
						{
							Window1.<case_select>o__SiteContainer1f.<>p__Site2c = CallSite<Func<CallSite, object, int>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(int), typeof(Window1)));
						}
						Func<CallSite, object, int> arg_6E0_0 = Window1.<case_select>o__SiteContainer1f.<>p__Site2c.Target;
						CallSite arg_6E0_1 = Window1.<case_select>o__SiteContainer1f.<>p__Site2c;
						if (Window1.<case_select>o__SiteContainer1f.<>p__Site2d == null)
						{
							Window1.<case_select>o__SiteContainer1f.<>p__Site2d = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Window1), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
							}));
						}
						Func<CallSite, object, string, object> arg_6DB_0 = Window1.<case_select>o__SiteContainer1f.<>p__Site2d.Target;
						CallSite arg_6DB_1 = Window1.<case_select>o__SiteContainer1f.<>p__Site2d;
						if (Window1.<case_select>o__SiteContainer1f.<>p__Site2e == null)
						{
							Window1.<case_select>o__SiteContainer1f.<>p__Site2e = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Window1), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
							}));
						}
						int num5 = arg_6E0_0(arg_6E0_1, arg_6DB_0(arg_6DB_1, Window1.<case_select>o__SiteContainer1f.<>p__Site2e.Target(Window1.<case_select>o__SiteContainer1f.<>p__Site2e, user.StageData, "response"), "available_stars"));
						hamburger.ShowDialog();
						if (hamburger.ButtonClicked)
						{
							if (Request.BuyAllStarBurners(hamburger.BuyStarBurger_Index))
							{
								if (hamburger.BuyStarBurger_Index == 1)
								{
									user.food_0 += num5;
									user.WriteLog("兌換柳橙汁成功 - " + num5 + " 個");
									return;
								}
								if (hamburger.BuyStarBurger_Index == 2)
								{
									user.WriteLog("兌換洋芋片成功 - " + num5 / 2 + " 個");
									user.food_1 += num5 / 2;
									return;
								}
								if (hamburger.BuyStarBurger_Index == 3)
								{
									user.WriteLog("兌換漢堡成功 - " + num5 / 3 + " 個");
									user.food_2 += num5 / 3;
									return;
								}
								if (hamburger.BuyStarBurger_Index == 7)
								{
									user.WriteLog("兌換能量成功 - " + num5 * 20 + " 點");
									user.energy += num5 * 20;
									return;
								}
								if (hamburger.BuyStarBurger_Index == 8)
								{
									int num6 = num5 * 5000;
									if (num6 > 99999999)
									{
									}
									if (user.coins > 99999999)
									{
										num6 = 0;
									}
									else
									{
										num6 = 99999999 - user.coins;
									}
									user.WriteLog("兌換金幣成功 - " + num6 + " 枚");
									user.coins += num6;
									return;
								}
								if (hamburger.BuyStarBurger_Index == 9)
								{
									user.WriteLog("兌換貼紙包成功 - " + num5 / 3 + " 點");
									user.stickers_pack_count += num5 / 3;
									return;
								}
							}
							else
							{
								user.WriteLog("兌換失敗");
							}
						}
					}
				}
			}
		}

		private void scene_select(object sender, RoutedEventArgs e)
		{
			if (!user.isRunning)
			{
				int scene_id = Convert.ToInt32(((Window1.Scene_Button)sender).Tag);
				user.scene_id = scene_id;
				Window2 window = new Window2();
				window.Top = base.Top + 145.0;
				window.Left = base.Left + 175.0;
				window.ShowDialog();
				if (window.ButtonClick)
				{
					Thread thread = new Thread(new ThreadStart(this.AutoStart));
					thread.Start();
					return;
				}
			}
			else
			{
				user.isAutoPlay = false;
			}
		}

		private void SuperStart()
		{
			user.isRunning = true;
			user.Notification("[開始] " + user.get_case_name(user.case_id) + " 第 1-9 場景");
			int i = 1;
			while (i <= 9)
			{
				Console.WriteLine(string.Concat(new object[]
				{
					"Case_ID:",
					user.case_id,
					"Secene:",
					user.scene_id
				}));
				user.scene_id = i;
				if ((user.case_id == 1 && i > 3) || (user.case_id == 2 && i > 6))
				{
					break;
				}
				if (user.current_star == 5 && user.high_score >= user.stage[user.stage_id].MaxScore)
				{
					Console.WriteLine(string.Concat(new object[]
					{
						"Case_ID:",
						user.case_id,
						"Secene:",
						user.scene_id,
						"highscore:",
						user.high_score,
						"/",
						user.stage[user.stage_id].MaxScore
					}));
					i++;
				}
				else
				{
					Random random = new Random(Guid.NewGuid().GetHashCode());
					int num = 0;
					if (user.current_star == 0)
					{
						num = 2000;
					}
					else if (user.current_star == 1)
					{
						num = 3000;
					}
					else if (user.current_star == 2)
					{
						num = 4000;
					}
					else if (user.current_star == 3)
					{
						num = 5000;
					}
					else if (user.current_star == 4)
					{
						num = 6000;
					}
					else if (user.current_star == 5)
					{
						num = 7000;
					}
					user.score = (random.Next(num, num + 2000) * 100).ToString();
					if (Request.startGame())
					{
						Request.EndGame();
					}
					else
					{
						try
						{
							if (Window1.<SuperStart>o__SiteContainer2f.<>p__Site30 == null)
							{
								Window1.<SuperStart>o__SiteContainer2f.<>p__Site30 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Window1), new CSharpArgumentInfo[]
								{
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
								}));
							}
							Func<CallSite, object, bool> arg_332_0 = Window1.<SuperStart>o__SiteContainer2f.<>p__Site30.Target;
							CallSite arg_332_1 = Window1.<SuperStart>o__SiteContainer2f.<>p__Site30;
							if (Window1.<SuperStart>o__SiteContainer2f.<>p__Site31 == null)
							{
								Window1.<SuperStart>o__SiteContainer2f.<>p__Site31 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Equal, typeof(Window1), new CSharpArgumentInfo[]
								{
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
								}));
							}
							Func<CallSite, object, string, object> arg_32D_0 = Window1.<SuperStart>o__SiteContainer2f.<>p__Site31.Target;
							CallSite arg_32D_1 = Window1.<SuperStart>o__SiteContainer2f.<>p__Site31;
							if (Window1.<SuperStart>o__SiteContainer2f.<>p__Site32 == null)
							{
								Window1.<SuperStart>o__SiteContainer2f.<>p__Site32 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "type", typeof(Window1), new CSharpArgumentInfo[]
								{
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
								}));
							}
							Func<CallSite, object, object> arg_323_0 = Window1.<SuperStart>o__SiteContainer2f.<>p__Site32.Target;
							CallSite arg_323_1 = Window1.<SuperStart>o__SiteContainer2f.<>p__Site32;
							if (Window1.<SuperStart>o__SiteContainer2f.<>p__Site33 == null)
							{
								Window1.<SuperStart>o__SiteContainer2f.<>p__Site33 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "error", typeof(Window1), new CSharpArgumentInfo[]
								{
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
								}));
							}
							if (arg_332_0(arg_332_1, arg_32D_0(arg_32D_1, arg_323_0(arg_323_1, Window1.<SuperStart>o__SiteContainer2f.<>p__Site33.Target(Window1.<SuperStart>o__SiteContainer2f.<>p__Site33, user.StartData)), "energy")))
							{
								Console.WriteLine("No Energy!");
								user.isAutoPlay = false;
								if (Window1.<SuperStart>o__SiteContainer2f.<>p__Site34 == null)
								{
									Window1.<SuperStart>o__SiteContainer2f.<>p__Site34 = CallSite<Func<CallSite, object, int>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(int), typeof(Window1)));
								}
								Func<CallSite, object, int> arg_478_0 = Window1.<SuperStart>o__SiteContainer2f.<>p__Site34.Target;
								CallSite arg_478_1 = Window1.<SuperStart>o__SiteContainer2f.<>p__Site34;
								if (Window1.<SuperStart>o__SiteContainer2f.<>p__Site35 == null)
								{
									Window1.<SuperStart>o__SiteContainer2f.<>p__Site35 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "energy", typeof(Window1), new CSharpArgumentInfo[]
									{
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
									}));
								}
								Func<CallSite, object, object> arg_473_0 = Window1.<SuperStart>o__SiteContainer2f.<>p__Site35.Target;
								CallSite arg_473_1 = Window1.<SuperStart>o__SiteContainer2f.<>p__Site35;
								if (Window1.<SuperStart>o__SiteContainer2f.<>p__Site36 == null)
								{
									Window1.<SuperStart>o__SiteContainer2f.<>p__Site36 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "sync", typeof(Window1), new CSharpArgumentInfo[]
									{
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
									}));
								}
								Func<CallSite, object, object> arg_46E_0 = Window1.<SuperStart>o__SiteContainer2f.<>p__Site36.Target;
								CallSite arg_46E_1 = Window1.<SuperStart>o__SiteContainer2f.<>p__Site36;
								if (Window1.<SuperStart>o__SiteContainer2f.<>p__Site37 == null)
								{
									Window1.<SuperStart>o__SiteContainer2f.<>p__Site37 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "error", typeof(Window1), new CSharpArgumentInfo[]
									{
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
									}));
								}
								user.energy = arg_478_0(arg_478_1, arg_473_0(arg_473_1, arg_46E_0(arg_46E_1, Window1.<SuperStart>o__SiteContainer2f.<>p__Site37.Target(Window1.<SuperStart>o__SiteContainer2f.<>p__Site37, user.StartData))));
								if (Window1.<SuperStart>o__SiteContainer2f.<>p__Site38 == null)
								{
									Window1.<SuperStart>o__SiteContainer2f.<>p__Site38 = CallSite<Func<CallSite, object, int>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(int), typeof(Window1)));
								}
								Func<CallSite, object, int> arg_5AE_0 = Window1.<SuperStart>o__SiteContainer2f.<>p__Site38.Target;
								CallSite arg_5AE_1 = Window1.<SuperStart>o__SiteContainer2f.<>p__Site38;
								if (Window1.<SuperStart>o__SiteContainer2f.<>p__Site39 == null)
								{
									Window1.<SuperStart>o__SiteContainer2f.<>p__Site39 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "coins", typeof(Window1), new CSharpArgumentInfo[]
									{
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
									}));
								}
								Func<CallSite, object, object> arg_5A9_0 = Window1.<SuperStart>o__SiteContainer2f.<>p__Site39.Target;
								CallSite arg_5A9_1 = Window1.<SuperStart>o__SiteContainer2f.<>p__Site39;
								if (Window1.<SuperStart>o__SiteContainer2f.<>p__Site3a == null)
								{
									Window1.<SuperStart>o__SiteContainer2f.<>p__Site3a = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "sync", typeof(Window1), new CSharpArgumentInfo[]
									{
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
									}));
								}
								Func<CallSite, object, object> arg_5A4_0 = Window1.<SuperStart>o__SiteContainer2f.<>p__Site3a.Target;
								CallSite arg_5A4_1 = Window1.<SuperStart>o__SiteContainer2f.<>p__Site3a;
								if (Window1.<SuperStart>o__SiteContainer2f.<>p__Site3b == null)
								{
									Window1.<SuperStart>o__SiteContainer2f.<>p__Site3b = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "error", typeof(Window1), new CSharpArgumentInfo[]
									{
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
									}));
								}
								user.coins = arg_5AE_0(arg_5AE_1, arg_5A9_0(arg_5A9_1, arg_5A4_0(arg_5A4_1, Window1.<SuperStart>o__SiteContainer2f.<>p__Site3b.Target(Window1.<SuperStart>o__SiteContainer2f.<>p__Site3b, user.StartData))));
							}
							Request.GetUserData();
							if (Request.Abandon_CASEID != 0 && Request.Abandon_STAGEID != 0)
							{
								Request.Abandon();
							}
						}
						catch (Exception ex)
						{
							user.WriteLog("1b2b4c6643b5c96a07abdf16fb2220fe|" + ex.Message);
						}
					}
					if (!user.isAutoPlay)
					{
						break;
					}
				}
			}
			user.isRunning = false;
			user.Loop_USE_TEAMMTE = false;
			user.Notification("[結束] " + user.get_case_name(user.case_id) + " 第 1-9 場景");
			user.scene_id = 0;
		}

		private void FullAutoStart()
		{
			user.isRunning = true;
			user.Notification("[開始] " + user.get_case_name(user.case_id) + " 第 1-9 場景");
			int i = 1;
			while (i <= 9)
			{
				user.scene_id = i;
				if ((user.case_id == 1 && i > 3) || (user.case_id == 2 && i > 6))
				{
					break;
				}
				if (user.current_star == 5)
				{
					i++;
				}
				else
				{
					Random random = new Random(Guid.NewGuid().GetHashCode());
					int num = 0;
					if (user.current_star == 0)
					{
						num = 2000;
					}
					else if (user.current_star == 1)
					{
						num = 3000;
					}
					else if (user.current_star == 2)
					{
						num = 4000;
					}
					else if (user.current_star == 3)
					{
						num = 5000;
					}
					else if (user.current_star == 4)
					{
						num = 6000;
					}
					else if (user.current_star == 5)
					{
						num = 7000;
					}
					user.score = (random.Next(num, num + 2000) * 100).ToString();
					if (Request.startGame())
					{
						Request.EndGame();
					}
					else
					{
						try
						{
							if (Window1.<FullAutoStart>o__SiteContainer3c.<>p__Site3d == null)
							{
								Window1.<FullAutoStart>o__SiteContainer3c.<>p__Site3d = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Window1), new CSharpArgumentInfo[]
								{
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
								}));
							}
							Func<CallSite, object, bool> arg_250_0 = Window1.<FullAutoStart>o__SiteContainer3c.<>p__Site3d.Target;
							CallSite arg_250_1 = Window1.<FullAutoStart>o__SiteContainer3c.<>p__Site3d;
							if (Window1.<FullAutoStart>o__SiteContainer3c.<>p__Site3e == null)
							{
								Window1.<FullAutoStart>o__SiteContainer3c.<>p__Site3e = CallSite<Func<CallSite, object, string, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Equal, typeof(Window1), new CSharpArgumentInfo[]
								{
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
								}));
							}
							Func<CallSite, object, string, object> arg_24B_0 = Window1.<FullAutoStart>o__SiteContainer3c.<>p__Site3e.Target;
							CallSite arg_24B_1 = Window1.<FullAutoStart>o__SiteContainer3c.<>p__Site3e;
							if (Window1.<FullAutoStart>o__SiteContainer3c.<>p__Site3f == null)
							{
								Window1.<FullAutoStart>o__SiteContainer3c.<>p__Site3f = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "type", typeof(Window1), new CSharpArgumentInfo[]
								{
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
								}));
							}
							Func<CallSite, object, object> arg_241_0 = Window1.<FullAutoStart>o__SiteContainer3c.<>p__Site3f.Target;
							CallSite arg_241_1 = Window1.<FullAutoStart>o__SiteContainer3c.<>p__Site3f;
							if (Window1.<FullAutoStart>o__SiteContainer3c.<>p__Site40 == null)
							{
								Window1.<FullAutoStart>o__SiteContainer3c.<>p__Site40 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "error", typeof(Window1), new CSharpArgumentInfo[]
								{
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
								}));
							}
							if (arg_250_0(arg_250_1, arg_24B_0(arg_24B_1, arg_241_0(arg_241_1, Window1.<FullAutoStart>o__SiteContainer3c.<>p__Site40.Target(Window1.<FullAutoStart>o__SiteContainer3c.<>p__Site40, user.StartData)), "energy")))
							{
								Console.WriteLine("No Energy!");
								user.isAutoPlay = false;
								if (Window1.<FullAutoStart>o__SiteContainer3c.<>p__Site41 == null)
								{
									Window1.<FullAutoStart>o__SiteContainer3c.<>p__Site41 = CallSite<Func<CallSite, object, int>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(int), typeof(Window1)));
								}
								Func<CallSite, object, int> arg_396_0 = Window1.<FullAutoStart>o__SiteContainer3c.<>p__Site41.Target;
								CallSite arg_396_1 = Window1.<FullAutoStart>o__SiteContainer3c.<>p__Site41;
								if (Window1.<FullAutoStart>o__SiteContainer3c.<>p__Site42 == null)
								{
									Window1.<FullAutoStart>o__SiteContainer3c.<>p__Site42 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "energy", typeof(Window1), new CSharpArgumentInfo[]
									{
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
									}));
								}
								Func<CallSite, object, object> arg_391_0 = Window1.<FullAutoStart>o__SiteContainer3c.<>p__Site42.Target;
								CallSite arg_391_1 = Window1.<FullAutoStart>o__SiteContainer3c.<>p__Site42;
								if (Window1.<FullAutoStart>o__SiteContainer3c.<>p__Site43 == null)
								{
									Window1.<FullAutoStart>o__SiteContainer3c.<>p__Site43 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "sync", typeof(Window1), new CSharpArgumentInfo[]
									{
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
									}));
								}
								Func<CallSite, object, object> arg_38C_0 = Window1.<FullAutoStart>o__SiteContainer3c.<>p__Site43.Target;
								CallSite arg_38C_1 = Window1.<FullAutoStart>o__SiteContainer3c.<>p__Site43;
								if (Window1.<FullAutoStart>o__SiteContainer3c.<>p__Site44 == null)
								{
									Window1.<FullAutoStart>o__SiteContainer3c.<>p__Site44 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "error", typeof(Window1), new CSharpArgumentInfo[]
									{
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
									}));
								}
								user.energy = arg_396_0(arg_396_1, arg_391_0(arg_391_1, arg_38C_0(arg_38C_1, Window1.<FullAutoStart>o__SiteContainer3c.<>p__Site44.Target(Window1.<FullAutoStart>o__SiteContainer3c.<>p__Site44, user.StartData))));
								if (Window1.<FullAutoStart>o__SiteContainer3c.<>p__Site45 == null)
								{
									Window1.<FullAutoStart>o__SiteContainer3c.<>p__Site45 = CallSite<Func<CallSite, object, int>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(int), typeof(Window1)));
								}
								Func<CallSite, object, int> arg_4CC_0 = Window1.<FullAutoStart>o__SiteContainer3c.<>p__Site45.Target;
								CallSite arg_4CC_1 = Window1.<FullAutoStart>o__SiteContainer3c.<>p__Site45;
								if (Window1.<FullAutoStart>o__SiteContainer3c.<>p__Site46 == null)
								{
									Window1.<FullAutoStart>o__SiteContainer3c.<>p__Site46 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "coins", typeof(Window1), new CSharpArgumentInfo[]
									{
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
									}));
								}
								Func<CallSite, object, object> arg_4C7_0 = Window1.<FullAutoStart>o__SiteContainer3c.<>p__Site46.Target;
								CallSite arg_4C7_1 = Window1.<FullAutoStart>o__SiteContainer3c.<>p__Site46;
								if (Window1.<FullAutoStart>o__SiteContainer3c.<>p__Site47 == null)
								{
									Window1.<FullAutoStart>o__SiteContainer3c.<>p__Site47 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "sync", typeof(Window1), new CSharpArgumentInfo[]
									{
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
									}));
								}
								Func<CallSite, object, object> arg_4C2_0 = Window1.<FullAutoStart>o__SiteContainer3c.<>p__Site47.Target;
								CallSite arg_4C2_1 = Window1.<FullAutoStart>o__SiteContainer3c.<>p__Site47;
								if (Window1.<FullAutoStart>o__SiteContainer3c.<>p__Site48 == null)
								{
									Window1.<FullAutoStart>o__SiteContainer3c.<>p__Site48 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "error", typeof(Window1), new CSharpArgumentInfo[]
									{
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
									}));
								}
								user.coins = arg_4CC_0(arg_4CC_1, arg_4C7_0(arg_4C7_1, arg_4C2_0(arg_4C2_1, Window1.<FullAutoStart>o__SiteContainer3c.<>p__Site48.Target(Window1.<FullAutoStart>o__SiteContainer3c.<>p__Site48, user.StartData))));
							}
							Request.GetUserData();
							if (Request.Abandon_CASEID != 0 && Request.Abandon_STAGEID != 0)
							{
								Request.Abandon();
							}
						}
						catch (Exception ex)
						{
							user.WriteLog("1b2b4c6643b5c96a07abdf16fb2220fe|" + ex.Message);
						}
					}
					if (!user.isAutoPlay)
					{
						break;
					}
				}
			}
			user.isRunning = false;
			user.Loop_USE_TEAMMTE = false;
			user.Notification("[結束] " + user.get_case_name(user.case_id) + " 第 1-9 場景");
			user.scene_id = 0;
		}

		private void AutoStart()
		{
			user.isRunning = true;
			user.Notification(string.Concat(new object[]
			{
				"[開始] ",
				user.get_case_name(user.case_id),
				" 第 ",
				user.scene_id,
				" 場景"
			}));
			do
			{
				if (Request.startGame())
				{
					Request.EndGame();
				}
				else
				{
					try
					{
						if (Window1.<AutoStart>o__SiteContainer49.<>p__Site4a == null)
						{
							Window1.<AutoStart>o__SiteContainer49.<>p__Site4a = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Window1), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						Func<CallSite, object, bool> arg_19B_0 = Window1.<AutoStart>o__SiteContainer49.<>p__Site4a.Target;
						CallSite arg_19B_1 = Window1.<AutoStart>o__SiteContainer49.<>p__Site4a;
						if (Window1.<AutoStart>o__SiteContainer49.<>p__Site4b == null)
						{
							Window1.<AutoStart>o__SiteContainer49.<>p__Site4b = CallSite<Func<CallSite, object, string, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Equal, typeof(Window1), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
							}));
						}
						Func<CallSite, object, string, object> arg_196_0 = Window1.<AutoStart>o__SiteContainer49.<>p__Site4b.Target;
						CallSite arg_196_1 = Window1.<AutoStart>o__SiteContainer49.<>p__Site4b;
						if (Window1.<AutoStart>o__SiteContainer49.<>p__Site4c == null)
						{
							Window1.<AutoStart>o__SiteContainer49.<>p__Site4c = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "type", typeof(Window1), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						Func<CallSite, object, object> arg_18C_0 = Window1.<AutoStart>o__SiteContainer49.<>p__Site4c.Target;
						CallSite arg_18C_1 = Window1.<AutoStart>o__SiteContainer49.<>p__Site4c;
						if (Window1.<AutoStart>o__SiteContainer49.<>p__Site4d == null)
						{
							Window1.<AutoStart>o__SiteContainer49.<>p__Site4d = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "error", typeof(Window1), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						if (arg_19B_0(arg_19B_1, arg_196_0(arg_196_1, arg_18C_0(arg_18C_1, Window1.<AutoStart>o__SiteContainer49.<>p__Site4d.Target(Window1.<AutoStart>o__SiteContainer49.<>p__Site4d, user.StartData)), "energy")))
						{
							Console.WriteLine("No Energy!");
							user.isAutoPlay = false;
							if (Window1.<AutoStart>o__SiteContainer49.<>p__Site4e == null)
							{
								Window1.<AutoStart>o__SiteContainer49.<>p__Site4e = CallSite<Func<CallSite, object, int>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(int), typeof(Window1)));
							}
							Func<CallSite, object, int> arg_2E1_0 = Window1.<AutoStart>o__SiteContainer49.<>p__Site4e.Target;
							CallSite arg_2E1_1 = Window1.<AutoStart>o__SiteContainer49.<>p__Site4e;
							if (Window1.<AutoStart>o__SiteContainer49.<>p__Site4f == null)
							{
								Window1.<AutoStart>o__SiteContainer49.<>p__Site4f = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "energy", typeof(Window1), new CSharpArgumentInfo[]
								{
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
								}));
							}
							Func<CallSite, object, object> arg_2DC_0 = Window1.<AutoStart>o__SiteContainer49.<>p__Site4f.Target;
							CallSite arg_2DC_1 = Window1.<AutoStart>o__SiteContainer49.<>p__Site4f;
							if (Window1.<AutoStart>o__SiteContainer49.<>p__Site50 == null)
							{
								Window1.<AutoStart>o__SiteContainer49.<>p__Site50 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "sync", typeof(Window1), new CSharpArgumentInfo[]
								{
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
								}));
							}
							Func<CallSite, object, object> arg_2D7_0 = Window1.<AutoStart>o__SiteContainer49.<>p__Site50.Target;
							CallSite arg_2D7_1 = Window1.<AutoStart>o__SiteContainer49.<>p__Site50;
							if (Window1.<AutoStart>o__SiteContainer49.<>p__Site51 == null)
							{
								Window1.<AutoStart>o__SiteContainer49.<>p__Site51 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "error", typeof(Window1), new CSharpArgumentInfo[]
								{
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
								}));
							}
							user.energy = arg_2E1_0(arg_2E1_1, arg_2DC_0(arg_2DC_1, arg_2D7_0(arg_2D7_1, Window1.<AutoStart>o__SiteContainer49.<>p__Site51.Target(Window1.<AutoStart>o__SiteContainer49.<>p__Site51, user.StartData))));
							if (Window1.<AutoStart>o__SiteContainer49.<>p__Site52 == null)
							{
								Window1.<AutoStart>o__SiteContainer49.<>p__Site52 = CallSite<Func<CallSite, object, int>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(int), typeof(Window1)));
							}
							Func<CallSite, object, int> arg_417_0 = Window1.<AutoStart>o__SiteContainer49.<>p__Site52.Target;
							CallSite arg_417_1 = Window1.<AutoStart>o__SiteContainer49.<>p__Site52;
							if (Window1.<AutoStart>o__SiteContainer49.<>p__Site53 == null)
							{
								Window1.<AutoStart>o__SiteContainer49.<>p__Site53 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "coins", typeof(Window1), new CSharpArgumentInfo[]
								{
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
								}));
							}
							Func<CallSite, object, object> arg_412_0 = Window1.<AutoStart>o__SiteContainer49.<>p__Site53.Target;
							CallSite arg_412_1 = Window1.<AutoStart>o__SiteContainer49.<>p__Site53;
							if (Window1.<AutoStart>o__SiteContainer49.<>p__Site54 == null)
							{
								Window1.<AutoStart>o__SiteContainer49.<>p__Site54 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "sync", typeof(Window1), new CSharpArgumentInfo[]
								{
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
								}));
							}
							Func<CallSite, object, object> arg_40D_0 = Window1.<AutoStart>o__SiteContainer49.<>p__Site54.Target;
							CallSite arg_40D_1 = Window1.<AutoStart>o__SiteContainer49.<>p__Site54;
							if (Window1.<AutoStart>o__SiteContainer49.<>p__Site55 == null)
							{
								Window1.<AutoStart>o__SiteContainer49.<>p__Site55 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "error", typeof(Window1), new CSharpArgumentInfo[]
								{
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
								}));
							}
							user.coins = arg_417_0(arg_417_1, arg_412_0(arg_412_1, arg_40D_0(arg_40D_1, Window1.<AutoStart>o__SiteContainer49.<>p__Site55.Target(Window1.<AutoStart>o__SiteContainer49.<>p__Site55, user.StartData))));
						}
						Request.GetUserData();
						if (Request.Abandon_CASEID != 0 && Request.Abandon_STAGEID != 0)
						{
							Request.Abandon();
						}
					}
					catch (Exception ex)
					{
						user.WriteLog("1b2b4c6643b5c96a07abdf16fb2220fe|" + ex.Message);
					}
				}
			}
			while (user.isAutoPlay);
			user.isRunning = false;
			user.Loop_USE_TEAMMTE = false;
			user.Notification(string.Concat(new object[]
			{
				"[結束] ",
				user.get_case_name(user.case_id),
				" 第 ",
				user.scene_id,
				" 場景"
			}));
			user.scene_id = 0;
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
				this.EatingTimer0.Dispose();
				this.EatingTimer0 = null;
			}
			catch
			{
			}
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
				this.EatingTimer1.Dispose();
				this.EatingTimer1 = null;
			}
			catch
			{
			}
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
				this.EatingTimer2.Dispose();
				this.EatingTimer2 = null;
			}
			catch
			{
			}
		}

		private void Food_2_Click(object sender, RoutedEventArgs e)
		{
			if (user.food_2 != 0)
			{
				if (this.EatingTimer2 != null)
				{
					this.EatingTimer2.Dispose();
					this.EatingTimer2 = null;
					MessageBox.Show("停止吃漢堡");
					return;
				}
				Eat_Food eat_Food = new Eat_Food(2);
				eat_Food.Top = base.Top + 65.0;
				eat_Food.Left = base.Left + 135.0;
				eat_Food.ShowDialog();
				if (eat_Food.ButtonClicked)
				{
					if (eat_Food.repeat)
					{
						this.EatingTimer2 = new Timer(new TimerCallback(this.EatFood2), null, 0, 20);
						return;
					}
					Request.Eat(2);
					return;
				}
			}
			else
			{
				MessageBox.Show("無漢堡");
			}
		}

		private void Food_1_Click(object sender, RoutedEventArgs e)
		{
			if (user.food_1 != 0)
			{
				if (this.EatingTimer1 != null)
				{
					this.EatingTimer1.Dispose();
					this.EatingTimer1 = null;
					MessageBox.Show("停止吃洋芋片");
					return;
				}
				Eat_Food eat_Food = new Eat_Food(1);
				eat_Food.Top = base.Top + 65.0;
				eat_Food.Left = base.Left + 135.0;
				eat_Food.ShowDialog();
				if (eat_Food.ButtonClicked)
				{
					if (eat_Food.repeat)
					{
						this.EatingTimer1 = new Timer(new TimerCallback(this.EatFood1), null, 0, 20);
						return;
					}
					Request.Eat(1);
					return;
				}
			}
			else
			{
				MessageBox.Show("無洋芋片");
			}
		}

		private void Food_0_Click(object sender, RoutedEventArgs e)
		{
			if (user.food_0 != 0)
			{
				if (this.EatingTimer0 != null)
				{
					this.EatingTimer0.Dispose();
					this.EatingTimer0 = null;
					MessageBox.Show("停止喝柳橙汁");
					return;
				}
				Eat_Food eat_Food = new Eat_Food(0);
				eat_Food.Top = base.Top + 65.0;
				eat_Food.Left = base.Left + 135.0;
				eat_Food.ShowDialog();
				if (eat_Food.ButtonClicked)
				{
					if (eat_Food.repeat)
					{
						this.EatingTimer0 = new Timer(new TimerCallback(this.EatFood0), null, 0, 20);
						return;
					}
					Request.Eat(0);
					return;
				}
			}
			else
			{
				MessageBox.Show("無柳橙汁");
			}
		}

		private void Back_Click(object sender, RoutedEventArgs e)
		{
			user.isAutoPlay = false;
			this.UPDATE_CASES_DISPLAY();
			this.Scene_Grid.Visibility = Visibility.Hidden;
			this.Cases_Grid.Visibility = Visibility.Visible;
			this.Season.Visibility = Visibility.Visible;
			this.Season_Left.Visibility = Visibility.Visible;
			this.Season_Right.Visibility = Visibility.Visible;
			this.Case_Name.Visibility = Visibility.Hidden;
		}

		private void Report_Click(object sender, RoutedEventArgs e)
		{
			if (this.Report_Thread == null)
			{
				this.Report_Thread = new Thread(new ThreadStart(this.GetReport));
				this.Report_Thread.Start();
				return;
			}
			this.Report_Thread.Abort();
			this.Report_Thread = null;
		}

		private void GetReport()
		{
			Request.GetReport();
		}

		private void SendEnergy_Click(object sender, RoutedEventArgs e)
		{
			SendFreeEnergy sendFreeEnergy = new SendFreeEnergy();
			sendFreeEnergy.Top = base.Top + 25.0;
			sendFreeEnergy.Left = base.Left + 25.0;
			sendFreeEnergy.ShowDialog();
			if (sendFreeEnergy.SendAllFriend)
			{
				Thread thread = new Thread(new ThreadStart(this.SendAllFriendEnergy));
				thread.Start();
			}
		}

		private void SendAllFriendEnergy()
		{
			Request.SendAllFriendEnergy();
		}

		private void Gift_Click(object sender, RoutedEventArgs e)
		{
			if (this.giftTimer == null)
			{
				card_w card_w = new card_w();
				card_w.Top = base.Top + 25.0;
				card_w.Left = base.Left + 25.0;
				card_w.ShowDialog();
				if (card_w.ButtonClicked)
				{
					this.giftTimer = new Timer(new TimerCallback(this.GiftMethod), null, 0, 30000);
					((Button)sender).Background = Brushes.LightSalmon;
					return;
				}
			}
			else
			{
				this.giftTimer.Dispose();
				this.giftTimer = null;
				((Button)sender).Background = null;
			}
		}

		private void OpenPack_Click(object sender, RoutedEventArgs e)
		{
			if (this.OpenPackTimer == null)
			{
				this.OpenPackTimer = new Timer(new TimerCallback(this.OpenPack), null, 0, 20);
				((Button)sender).Background = Brushes.LightSalmon;
				return;
			}
			this.OpenPackTimer.Dispose();
			this.OpenPackTimer = null;
			((Button)sender).Background = null;
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
				if (this.OpenPackTimer != null)
				{
					this.OpenPackTimer.Dispose();
					this.OpenPackTimer = null;
				}
			}
		}

		private void Button_Click_3(object sender, RoutedEventArgs e)
		{
			if (!user.isAutoPlay)
			{
				Thread thread = new Thread(new ThreadStart(this.SuperStart));
				thread.Start();
				user.isAutoPlay = true;
				return;
			}
			user.isAutoPlay = false;
		}

		private void Button_Click_1(object sender, RoutedEventArgs e)
		{
			if (!user.isAutoPlay)
			{
				Thread thread = new Thread(new ThreadStart(this.FullAutoStart));
				thread.Start();
				user.isAutoPlay = true;
				return;
			}
			user.isAutoPlay = false;
		}

		private void Donate_Click(object sender, RoutedEventArgs e)
		{
			string text = "";
			string text2 = "robinsa87@gmail.com";
			string text3 = "Donation";
			string text4 = "TW";
			string text5 = "TWD";
			string text6 = text;
			text = string.Concat(new string[]
			{
				text6,
				"https://www.paypal.com/cgi-bin/webscr?cmd=_donations&business=",
				text2,
				"&lc=",
				text4,
				"&item_name=",
				text3,
				"&currency_code=",
				text5,
				"&bn=PP%2dDonationsBF"
			});
			Process.Start(text);
		}

		private void Season_Backwards_Click(object sender, RoutedEventArgs e)
		{
			if (user.current_season > 1)
			{
				user.current_season--;
			}
			this.Season.Content = "第 " + user.current_season + " 季";
			this.UPDATE_CASES_DISPLAY();
		}

		private void Season_Afterwards_Click(object sender, RoutedEventArgs e)
		{
			if (user.current_season < 4)
			{
				user.current_season++;
			}
			this.Season.Content = "第 " + user.current_season + " 季";
			this.UPDATE_CASES_DISPLAY();
		}

		[GeneratedCode("PresentationBuildTasks", "4.0.0.0"), DebuggerNonUserCode]
		public void InitializeComponent()
		{
			if (this._contentLoaded)
			{
				return;
			}
			this._contentLoaded = true;
			Uri resourceLocator = new Uri("/AiteCriminal;component/window1.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		[GeneratedCode("PresentationBuildTasks", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Never), DebuggerNonUserCode]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				this.Main = (Grid)target;
				return;
			case 2:
				this.Case_Name = (Label)target;
				return;
			case 3:
				this.Season = (Label)target;
				return;
			case 4:
				this.Season_Left = (Button)target;
				this.Season_Left.Click += new RoutedEventHandler(this.Season_Backwards_Click);
				return;
			case 5:
				this.Season_Right = (Button)target;
				this.Season_Right.Click += new RoutedEventHandler(this.Season_Afterwards_Click);
				return;
			case 6:
				this.Cases_Grid = (Grid)target;
				return;
			case 7:
				this.Scene_Grid = (Grid)target;
				return;
			case 8:
				((Button)target).Click += new RoutedEventHandler(this.Back_Click);
				return;
			case 9:
				((Button)target).Click += new RoutedEventHandler(this.Button_Click_3);
				return;
			case 10:
				this.ClearStage = (Button)target;
				this.ClearStage.Click += new RoutedEventHandler(this.Button_Click_1);
				return;
			case 11:
				this.Donate = (Button)target;
				this.Donate.Click += new RoutedEventHandler(this.Donate_Click);
				return;
			case 12:
				((Button)target).Click += new RoutedEventHandler(this.Back_Click);
				return;
			case 13:
				((Button)target).Click += new RoutedEventHandler(this.Food_0_Click);
				return;
			case 14:
				((Button)target).Click += new RoutedEventHandler(this.Food_1_Click);
				return;
			case 15:
				((Button)target).Click += new RoutedEventHandler(this.Food_2_Click);
				return;
			case 16:
				((Button)target).Click += new RoutedEventHandler(this.Report_Click);
				return;
			case 17:
				((Button)target).Click += new RoutedEventHandler(this.Gift_Click);
				return;
			case 18:
				((Button)target).Click += new RoutedEventHandler(this.SendEnergy_Click);
				return;
			case 19:
				this.userID = (Label)target;
				return;
			case 20:
				((Button)target).Click += new RoutedEventHandler(this.OpenPack_Click);
				return;
			case 21:
				this.Label_Level = (Label)target;
				return;
			case 22:
				this.Label_XP = (Label)target;
				return;
			case 23:
				this.Label_Coins = (Label)target;
				return;
			case 24:
				this.Label_Energy = (Label)target;
				return;
			default:
				this._contentLoaded = true;
				return;
			}
		}
	}
}
