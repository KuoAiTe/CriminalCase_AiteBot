using Microsoft.CSharp.RuntimeBinder;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace AiteCriminal
{
	public class Hamburger : Window, IComponentConnector
	{
		[CompilerGenerated]
		private static class ctor>o__SiteContainer0
		{
			public static CallSite<Func<CallSite, object, string, object>> <>p__Site1;

			public static CallSite<Func<CallSite, string, object, object>> <>p__Site2;

			public static CallSite<Func<CallSite, object, int, object>> <>p__Site3;

			public static CallSite<Func<CallSite, object, string, object>> <>p__Site4;

			public static CallSite<Func<CallSite, object, string, object>> <>p__Site5;

			public static CallSite<Func<CallSite, object, string, object>> <>p__Site6;

			public static CallSite<Func<CallSite, string, object, object>> <>p__Site7;

			public static CallSite<Func<CallSite, object, int, object>> <>p__Site8;

			public static CallSite<Func<CallSite, object, string, object>> <>p__Site9;

			public static CallSite<Func<CallSite, object, string, object>> <>p__Sitea;

			public static CallSite<Func<CallSite, object, string, object>> <>p__Siteb;

			public static CallSite<Func<CallSite, string, object, object>> <>p__Sitec;

			public static CallSite<Func<CallSite, object, int, object>> <>p__Sited;

			public static CallSite<Func<CallSite, object, string, object>> <>p__Sitee;

			public static CallSite<Func<CallSite, object, string, object>> <>p__Sitef;

			public static CallSite<Func<CallSite, object, string, object>> <>p__Site10;

			public static CallSite<Func<CallSite, string, object, object>> <>p__Site11;

			public static CallSite<Func<CallSite, object, int, object>> <>p__Site12;

			public static CallSite<Func<CallSite, object, string, object>> <>p__Site13;

			public static CallSite<Func<CallSite, object, string, object>> <>p__Site14;

			public static CallSite<Func<CallSite, object, int>> <>p__Site15;

			public static CallSite<Func<CallSite, object, int, object>> <>p__Site16;

			public static CallSite<Func<CallSite, object, string, object>> <>p__Site17;

			public static CallSite<Func<CallSite, object, string, object>> <>p__Site18;

			public static CallSite<Func<CallSite, object, string, object>> <>p__Site19;

			public static CallSite<Func<CallSite, string, object, object>> <>p__Site1a;

			public static CallSite<Func<CallSite, object, int, object>> <>p__Site1b;

			public static CallSite<Func<CallSite, object, string, object>> <>p__Site1c;

			public static CallSite<Func<CallSite, object, string, object>> <>p__Site1d;
		}

		public bool ButtonClicked;

		public int BuyStarBurger_Index = 1;

		internal Button count1;

		internal Button count2;

		internal Button count3;

		internal Button count7;

		internal Button count8;

		internal Button count9;

		private bool _contentLoaded;

		public Hamburger()
		{
			this.InitializeComponent();
			base.ResizeMode = ResizeMode.NoResize;
			ContentControl arg_1DB_0 = this.count1;
			if (Hamburger.ctor>o__SiteContainer0.<>p__Site1 == null)
			{
				Hamburger.ctor>o__SiteContainer0.<>p__Site1 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Add, typeof(Hamburger), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, string, object> arg_1D6_0 = Hamburger.ctor>o__SiteContainer0.<>p__Site1.Target;
			CallSite arg_1D6_1 = Hamburger.ctor>o__SiteContainer0.<>p__Site1;
			if (Hamburger.ctor>o__SiteContainer0.<>p__Site2 == null)
			{
				Hamburger.ctor>o__SiteContainer0.<>p__Site2 = CallSite<Func<CallSite, string, object, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Add, typeof(Hamburger), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			Func<CallSite, string, object, object> arg_1CC_0 = Hamburger.ctor>o__SiteContainer0.<>p__Site2.Target;
			CallSite arg_1CC_1 = Hamburger.ctor>o__SiteContainer0.<>p__Site2;
			string arg_1CC_2 = "兌換 ";
			if (Hamburger.ctor>o__SiteContainer0.<>p__Site3 == null)
			{
				Hamburger.ctor>o__SiteContainer0.<>p__Site3 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Divide, typeof(Hamburger), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, int, object> arg_1C7_0 = Hamburger.ctor>o__SiteContainer0.<>p__Site3.Target;
			CallSite arg_1C7_1 = Hamburger.ctor>o__SiteContainer0.<>p__Site3;
			if (Hamburger.ctor>o__SiteContainer0.<>p__Site4 == null)
			{
				Hamburger.ctor>o__SiteContainer0.<>p__Site4 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Hamburger), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, string, object> arg_1C1_0 = Hamburger.ctor>o__SiteContainer0.<>p__Site4.Target;
			CallSite arg_1C1_1 = Hamburger.ctor>o__SiteContainer0.<>p__Site4;
			if (Hamburger.ctor>o__SiteContainer0.<>p__Site5 == null)
			{
				Hamburger.ctor>o__SiteContainer0.<>p__Site5 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Hamburger), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			arg_1DB_0.Content = arg_1D6_0(arg_1D6_1, arg_1CC_0(arg_1CC_1, arg_1CC_2, arg_1C7_0(arg_1C7_1, arg_1C1_0(arg_1C1_1, Hamburger.ctor>o__SiteContainer0.<>p__Site5.Target(Hamburger.ctor>o__SiteContainer0.<>p__Site5, user.StageData, "response"), "available_stars"), 1)), " 個柳橙汁");
			ContentControl arg_3AD_0 = this.count2;
			if (Hamburger.ctor>o__SiteContainer0.<>p__Site6 == null)
			{
				Hamburger.ctor>o__SiteContainer0.<>p__Site6 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Add, typeof(Hamburger), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, string, object> arg_3A8_0 = Hamburger.ctor>o__SiteContainer0.<>p__Site6.Target;
			CallSite arg_3A8_1 = Hamburger.ctor>o__SiteContainer0.<>p__Site6;
			if (Hamburger.ctor>o__SiteContainer0.<>p__Site7 == null)
			{
				Hamburger.ctor>o__SiteContainer0.<>p__Site7 = CallSite<Func<CallSite, string, object, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Add, typeof(Hamburger), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			Func<CallSite, string, object, object> arg_39E_0 = Hamburger.ctor>o__SiteContainer0.<>p__Site7.Target;
			CallSite arg_39E_1 = Hamburger.ctor>o__SiteContainer0.<>p__Site7;
			string arg_39E_2 = "兌換 ";
			if (Hamburger.ctor>o__SiteContainer0.<>p__Site8 == null)
			{
				Hamburger.ctor>o__SiteContainer0.<>p__Site8 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Divide, typeof(Hamburger), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, int, object> arg_399_0 = Hamburger.ctor>o__SiteContainer0.<>p__Site8.Target;
			CallSite arg_399_1 = Hamburger.ctor>o__SiteContainer0.<>p__Site8;
			if (Hamburger.ctor>o__SiteContainer0.<>p__Site9 == null)
			{
				Hamburger.ctor>o__SiteContainer0.<>p__Site9 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Hamburger), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, string, object> arg_393_0 = Hamburger.ctor>o__SiteContainer0.<>p__Site9.Target;
			CallSite arg_393_1 = Hamburger.ctor>o__SiteContainer0.<>p__Site9;
			if (Hamburger.ctor>o__SiteContainer0.<>p__Sitea == null)
			{
				Hamburger.ctor>o__SiteContainer0.<>p__Sitea = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Hamburger), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			arg_3AD_0.Content = arg_3A8_0(arg_3A8_1, arg_39E_0(arg_39E_1, arg_39E_2, arg_399_0(arg_399_1, arg_393_0(arg_393_1, Hamburger.ctor>o__SiteContainer0.<>p__Sitea.Target(Hamburger.ctor>o__SiteContainer0.<>p__Sitea, user.StageData, "response"), "available_stars"), 2)), " 個洋芋片");
			ContentControl arg_57F_0 = this.count3;
			if (Hamburger.ctor>o__SiteContainer0.<>p__Siteb == null)
			{
				Hamburger.ctor>o__SiteContainer0.<>p__Siteb = CallSite<Func<CallSite, object, string, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Add, typeof(Hamburger), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, string, object> arg_57A_0 = Hamburger.ctor>o__SiteContainer0.<>p__Siteb.Target;
			CallSite arg_57A_1 = Hamburger.ctor>o__SiteContainer0.<>p__Siteb;
			if (Hamburger.ctor>o__SiteContainer0.<>p__Sitec == null)
			{
				Hamburger.ctor>o__SiteContainer0.<>p__Sitec = CallSite<Func<CallSite, string, object, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Add, typeof(Hamburger), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			Func<CallSite, string, object, object> arg_570_0 = Hamburger.ctor>o__SiteContainer0.<>p__Sitec.Target;
			CallSite arg_570_1 = Hamburger.ctor>o__SiteContainer0.<>p__Sitec;
			string arg_570_2 = "兌換 ";
			if (Hamburger.ctor>o__SiteContainer0.<>p__Sited == null)
			{
				Hamburger.ctor>o__SiteContainer0.<>p__Sited = CallSite<Func<CallSite, object, int, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Divide, typeof(Hamburger), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, int, object> arg_56B_0 = Hamburger.ctor>o__SiteContainer0.<>p__Sited.Target;
			CallSite arg_56B_1 = Hamburger.ctor>o__SiteContainer0.<>p__Sited;
			if (Hamburger.ctor>o__SiteContainer0.<>p__Sitee == null)
			{
				Hamburger.ctor>o__SiteContainer0.<>p__Sitee = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Hamburger), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, string, object> arg_565_0 = Hamburger.ctor>o__SiteContainer0.<>p__Sitee.Target;
			CallSite arg_565_1 = Hamburger.ctor>o__SiteContainer0.<>p__Sitee;
			if (Hamburger.ctor>o__SiteContainer0.<>p__Sitef == null)
			{
				Hamburger.ctor>o__SiteContainer0.<>p__Sitef = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Hamburger), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			arg_57F_0.Content = arg_57A_0(arg_57A_1, arg_570_0(arg_570_1, arg_570_2, arg_56B_0(arg_56B_1, arg_565_0(arg_565_1, Hamburger.ctor>o__SiteContainer0.<>p__Sitef.Target(Hamburger.ctor>o__SiteContainer0.<>p__Sitef, user.StageData, "response"), "available_stars"), 3)), " 個漢堡");
			ContentControl arg_752_0 = this.count7;
			if (Hamburger.ctor>o__SiteContainer0.<>p__Site10 == null)
			{
				Hamburger.ctor>o__SiteContainer0.<>p__Site10 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Add, typeof(Hamburger), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, string, object> arg_74D_0 = Hamburger.ctor>o__SiteContainer0.<>p__Site10.Target;
			CallSite arg_74D_1 = Hamburger.ctor>o__SiteContainer0.<>p__Site10;
			if (Hamburger.ctor>o__SiteContainer0.<>p__Site11 == null)
			{
				Hamburger.ctor>o__SiteContainer0.<>p__Site11 = CallSite<Func<CallSite, string, object, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Add, typeof(Hamburger), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			Func<CallSite, string, object, object> arg_743_0 = Hamburger.ctor>o__SiteContainer0.<>p__Site11.Target;
			CallSite arg_743_1 = Hamburger.ctor>o__SiteContainer0.<>p__Site11;
			string arg_743_2 = "兌換 ";
			if (Hamburger.ctor>o__SiteContainer0.<>p__Site12 == null)
			{
				Hamburger.ctor>o__SiteContainer0.<>p__Site12 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Multiply, typeof(Hamburger), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, int, object> arg_73E_0 = Hamburger.ctor>o__SiteContainer0.<>p__Site12.Target;
			CallSite arg_73E_1 = Hamburger.ctor>o__SiteContainer0.<>p__Site12;
			if (Hamburger.ctor>o__SiteContainer0.<>p__Site13 == null)
			{
				Hamburger.ctor>o__SiteContainer0.<>p__Site13 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Hamburger), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, string, object> arg_737_0 = Hamburger.ctor>o__SiteContainer0.<>p__Site13.Target;
			CallSite arg_737_1 = Hamburger.ctor>o__SiteContainer0.<>p__Site13;
			if (Hamburger.ctor>o__SiteContainer0.<>p__Site14 == null)
			{
				Hamburger.ctor>o__SiteContainer0.<>p__Site14 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Hamburger), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			arg_752_0.Content = arg_74D_0(arg_74D_1, arg_743_0(arg_743_1, arg_743_2, arg_73E_0(arg_73E_1, arg_737_0(arg_737_1, Hamburger.ctor>o__SiteContainer0.<>p__Site14.Target(Hamburger.ctor>o__SiteContainer0.<>p__Site14, user.StageData, "response"), "available_stars"), 20)), " 能量");
			if (Hamburger.ctor>o__SiteContainer0.<>p__Site15 == null)
			{
				Hamburger.ctor>o__SiteContainer0.<>p__Site15 = CallSite<Func<CallSite, object, int>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(int), typeof(Hamburger)));
			}
			Func<CallSite, object, int> arg_8A6_0 = Hamburger.ctor>o__SiteContainer0.<>p__Site15.Target;
			CallSite arg_8A6_1 = Hamburger.ctor>o__SiteContainer0.<>p__Site15;
			if (Hamburger.ctor>o__SiteContainer0.<>p__Site16 == null)
			{
				Hamburger.ctor>o__SiteContainer0.<>p__Site16 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Multiply, typeof(Hamburger), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, int, object> arg_8A1_0 = Hamburger.ctor>o__SiteContainer0.<>p__Site16.Target;
			CallSite arg_8A1_1 = Hamburger.ctor>o__SiteContainer0.<>p__Site16;
			if (Hamburger.ctor>o__SiteContainer0.<>p__Site17 == null)
			{
				Hamburger.ctor>o__SiteContainer0.<>p__Site17 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Hamburger), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, string, object> arg_897_0 = Hamburger.ctor>o__SiteContainer0.<>p__Site17.Target;
			CallSite arg_897_1 = Hamburger.ctor>o__SiteContainer0.<>p__Site17;
			if (Hamburger.ctor>o__SiteContainer0.<>p__Site18 == null)
			{
				Hamburger.ctor>o__SiteContainer0.<>p__Site18 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Hamburger), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			int num = arg_8A6_0(arg_8A6_1, arg_8A1_0(arg_8A1_1, arg_897_0(arg_897_1, Hamburger.ctor>o__SiteContainer0.<>p__Site18.Target(Hamburger.ctor>o__SiteContainer0.<>p__Site18, user.StageData, "response"), "available_stars"), 5000));
			if (num > 99999999)
			{
			}
			if (user.coins > 99999999)
			{
				num = 0;
			}
			else
			{
				num = 99999999 - user.coins;
			}
			this.count8.Content = "兌換 " + num + " 枚金幣";
			ContentControl arg_AC3_0 = this.count9;
			if (Hamburger.ctor>o__SiteContainer0.<>p__Site19 == null)
			{
				Hamburger.ctor>o__SiteContainer0.<>p__Site19 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Add, typeof(Hamburger), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, string, object> arg_ABE_0 = Hamburger.ctor>o__SiteContainer0.<>p__Site19.Target;
			CallSite arg_ABE_1 = Hamburger.ctor>o__SiteContainer0.<>p__Site19;
			if (Hamburger.ctor>o__SiteContainer0.<>p__Site1a == null)
			{
				Hamburger.ctor>o__SiteContainer0.<>p__Site1a = CallSite<Func<CallSite, string, object, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Add, typeof(Hamburger), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			Func<CallSite, string, object, object> arg_AB4_0 = Hamburger.ctor>o__SiteContainer0.<>p__Site1a.Target;
			CallSite arg_AB4_1 = Hamburger.ctor>o__SiteContainer0.<>p__Site1a;
			string arg_AB4_2 = "兌換 ";
			if (Hamburger.ctor>o__SiteContainer0.<>p__Site1b == null)
			{
				Hamburger.ctor>o__SiteContainer0.<>p__Site1b = CallSite<Func<CallSite, object, int, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Divide, typeof(Hamburger), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, int, object> arg_AAF_0 = Hamburger.ctor>o__SiteContainer0.<>p__Site1b.Target;
			CallSite arg_AAF_1 = Hamburger.ctor>o__SiteContainer0.<>p__Site1b;
			if (Hamburger.ctor>o__SiteContainer0.<>p__Site1c == null)
			{
				Hamburger.ctor>o__SiteContainer0.<>p__Site1c = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Hamburger), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, string, object> arg_AA9_0 = Hamburger.ctor>o__SiteContainer0.<>p__Site1c.Target;
			CallSite arg_AA9_1 = Hamburger.ctor>o__SiteContainer0.<>p__Site1c;
			if (Hamburger.ctor>o__SiteContainer0.<>p__Site1d == null)
			{
				Hamburger.ctor>o__SiteContainer0.<>p__Site1d = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Hamburger), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			arg_AC3_0.Content = arg_ABE_0(arg_ABE_1, arg_AB4_0(arg_AB4_1, arg_AB4_2, arg_AAF_0(arg_AAF_1, arg_AA9_0(arg_AA9_1, Hamburger.ctor>o__SiteContainer0.<>p__Site1d.Target(Hamburger.ctor>o__SiteContainer0.<>p__Site1d, user.StageData, "response"), "available_stars"), 3)), " 個貼紙包");
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			int buyStarBurger_Index = Convert.ToInt32(((Button)sender).Tag);
			this.BuyStarBurger_Index = buyStarBurger_Index;
			this.ButtonClicked = true;
			base.Close();
		}

		[GeneratedCode("PresentationBuildTasks", "4.0.0.0"), DebuggerNonUserCode]
		public void InitializeComponent()
		{
			if (this._contentLoaded)
			{
				return;
			}
			this._contentLoaded = true;
			Uri resourceLocator = new Uri("/AiteCriminal;component/hamburger.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		[GeneratedCode("PresentationBuildTasks", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Never), DebuggerNonUserCode]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				this.count1 = (Button)target;
				this.count1.Click += new RoutedEventHandler(this.Button_Click);
				return;
			case 2:
				this.count2 = (Button)target;
				this.count2.Click += new RoutedEventHandler(this.Button_Click);
				return;
			case 3:
				this.count3 = (Button)target;
				this.count3.Click += new RoutedEventHandler(this.Button_Click);
				return;
			case 4:
				this.count7 = (Button)target;
				this.count7.Click += new RoutedEventHandler(this.Button_Click);
				return;
			case 5:
				this.count8 = (Button)target;
				this.count8.Click += new RoutedEventHandler(this.Button_Click);
				return;
			case 6:
				this.count9 = (Button)target;
				this.count9.Click += new RoutedEventHandler(this.Button_Click);
				return;
			default:
				this._contentLoaded = true;
				return;
			}
		}
	}
}
