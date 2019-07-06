using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Markup;

namespace AiteCriminal
{
	public partial class Window2 : Window
	{
		private const long perSecond = 1000L;

		public bool ButtonClick;

		private static long last_update;

		static Window2()
		{
		}

		public Window2()
		{
			this.InitializeComponent();
			long ticks = DateTime.Now.Ticks / (long)10000;
			if ((ticks - Window2.last_update) / (long)1000 > (long)300)
			{
				Window2.last_update = ticks;
				Request.GetFriendList();
			}
			if (user.FriendList.Count > 0)
			{
				foreach (Friends friendList in user.FriendList)
				{
					ItemCollection items = this.friend.Items;
					object[] objArray = new object[] { friendList.name, " ( ", friendList.hints, " )" };
					items.Add(string.Concat(objArray));
				}
			}
			base.ResizeMode = System.Windows.ResizeMode.NoResize;
			int num = 0;
			int currentStar = user.current_star;
			if (user.isCaseElite)
			{
				if (currentStar == 0)
				{
					num = 6500;
				}
				else if (currentStar == 1)
				{
					num = 7500;
				}
				else if (currentStar == 2)
				{
					num = 8500;
				}
				else if (currentStar == 3)
				{
					num = 9500;
				}
				else if (currentStar == 4)
				{
					num = 10500;
				}
				else if (currentStar == 5)
				{
					num = 11500;
				}
			}
			else if (currentStar == 0)
			{
				num = 5500;
			}
			else if (currentStar == 1)
			{
				num = 6000;
			}
			else if (currentStar == 2)
			{
				num = 6500;
			}
			else if (currentStar == 3)
			{
				num = 7500;
			}
			else if (currentStar == 4)
			{
				num = 8500;
			}
			else if (currentStar == 5)
			{
				num = 9500;
			}
			if (!user.isCaseElite)
			{
				this.ScoreSlider.Minimum = (double)(user.items_found * 250);
			}
			else
			{
				this.ScoreSlider.Minimum = (double)(user.items_found * 300);
			}
			if (user.scene_id == 6)
			{
				this.ScoreSlider.Minimum = 3300;
			}
			this.ScoreSlider.Maximum = (double)num;
			this.ScoreSlider.Value = (this.ScoreSlider.Minimum + this.ScoreSlider.Maximum) / 2;
			try
			{
				this.score.Content = Convert.ToString(Convert.ToInt32(this.ScoreSlider.Value) * 100);
			}
			catch
			{
			}
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			if (this.friend.SelectedIndex != -1)
			{
				user.teammate_index = this.friend.SelectedIndex;
			}
			try
			{
				user.score = Convert.ToString(Convert.ToInt32(this.ScoreSlider.Value) * 100);
			}
			catch
			{
				user.score = "1000000";
			}
			this.ButtonClick = true;
			user.isAutoPlay = false;
			base.Close();
		}

		private void Button_Click_1(object sender, RoutedEventArgs e)
		{
			try
			{
				user.score = Convert.ToString(Convert.ToInt32(this.ScoreSlider.Value) * 100);
			}
			catch
			{
				user.score = "1000000";
			}
			this.ButtonClick = true;
			user.isAutoPlay = true;
			user.Loop_USE_TEAMMTE = true;
			base.Close();
		}

		private void Button_Click_2(object sender, RoutedEventArgs e)
		{
			try
			{
				user.score = Convert.ToString(Convert.ToInt32(this.ScoreSlider.Value) * 100);
			}
			catch
			{
				user.score = "1000000";
			}
			this.ButtonClick = true;
			user.isAutoPlay = true;
			user.Loop_USE_TEAMMTE = false;
			base.Close();
		}

		private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
		{
			int num = 0;
			try
			{
				num = Convert.ToInt32(this.ScoreSlider.Value) * 100;
				this.score.Content = Convert.ToString(num);
			}
			catch
			{
			}
		}
	}
}