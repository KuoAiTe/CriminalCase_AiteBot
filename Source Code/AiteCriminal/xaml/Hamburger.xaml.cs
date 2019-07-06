using Microsoft.CSharp.RuntimeBinder;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace AiteCriminal
{
	public partial class Hamburger : Window
	{
		public bool ButtonClicked;

		public int BuyStarBurger_Index = 1;

		public Hamburger()
		{
			this.InitializeComponent();
			base.ResizeMode = System.Windows.ResizeMode.NoResize;
			this.count1.Content = "兌換 " + ((dynamic)user.StageData)["response"]["available_stars"] / 1 + " 個柳橙汁";
			this.count2.Content = "兌換 " + ((dynamic)user.StageData)["response"]["available_stars"] / 2 + " 個洋芋片";
			this.count3.Content = "兌換 " + ((dynamic)user.StageData)["response"]["available_stars"] / 3 + " 個漢堡";
			this.count7.Content = "兌換 " + ((dynamic)user.StageData)["response"]["available_stars"] * 20 + " 能量";
			int stageData = (int)(((dynamic)user.StageData)["response"]["available_stars"] * 5000);
			if (stageData > 99999999)
			{
				stageData = 99999999;
			}
			stageData = (user.coins <= 99999999 ? 99999999 - user.coins : 0);
			this.count8.Content = string.Concat("兌換 ", stageData, " 枚金幣");
			this.count9.Content = "兌換 " + ((dynamic)user.StageData)["response"]["available_stars"] / 3 + " 個貼紙包";
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			this.BuyStarBurger_Index = Convert.ToInt32(((Button)sender).Tag);
			this.ButtonClicked = true;
			base.Close();
		}
	}
}