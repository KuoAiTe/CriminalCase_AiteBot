using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace AiteCriminal
{
	public class Window2 : Window, IComponentConnector
	{
		private const long perSecond = 1000L;

		public bool ButtonClick;

		private static long last_update;

		internal Slider ScoreSlider;

		internal Label score;

		internal ListBox friend;

		private bool _contentLoaded;

		public Window2()
		{
			this.InitializeComponent();
			long num = DateTime.Now.Ticks / 10000L;
			if ((num - Window2.last_update) / 1000L > 300L)
			{
				Window2.last_update = num;
				Request.GetFriendList();
			}
			if (user.FriendList.Count > 0)
			{
				foreach (friends current in user.FriendList)
				{
					this.friend.Items.Add(string.Concat(new object[]
					{
						current.name,
						" ( ",
						current.hints,
						" )"
					}));
				}
			}
			base.ResizeMode = ResizeMode.NoResize;
			int num2 = 0;
			int current_star = user.current_star;
			if (user.isCaseElite)
			{
				if (current_star == 0)
				{
					num2 = 6500;
				}
				else if (current_star == 1)
				{
					num2 = 7500;
				}
				else if (current_star == 2)
				{
					num2 = 8500;
				}
				else if (current_star == 3)
				{
					num2 = 9500;
				}
				else if (current_star == 4)
				{
					num2 = 10500;
				}
				else if (current_star == 5)
				{
					num2 = 11500;
				}
			}
			else if (current_star == 0)
			{
				num2 = 5500;
			}
			else if (current_star == 1)
			{
				num2 = 6000;
			}
			else if (current_star == 2)
			{
				num2 = 6500;
			}
			else if (current_star == 3)
			{
				num2 = 7500;
			}
			else if (current_star == 4)
			{
				num2 = 8500;
			}
			else if (current_star == 5)
			{
				num2 = 9500;
			}
			if (user.isCaseElite)
			{
				this.ScoreSlider.Minimum = (double)(user.items_found * 300);
			}
			else
			{
				this.ScoreSlider.Minimum = (double)(user.items_found * 250);
			}
			if (user.scene_id == 6)
			{
				this.ScoreSlider.Minimum = 3300.0;
			}
			this.ScoreSlider.Maximum = (double)num2;
			this.ScoreSlider.Value = (this.ScoreSlider.Minimum + this.ScoreSlider.Maximum) / 2.0;
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

		private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
		{
			try
			{
				int value = Convert.ToInt32(this.ScoreSlider.Value) * 100;
				this.score.Content = Convert.ToString(value);
			}
			catch
			{
			}
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

		[GeneratedCode("PresentationBuildTasks", "4.0.0.0"), DebuggerNonUserCode]
		public void InitializeComponent()
		{
			if (this._contentLoaded)
			{
				return;
			}
			this._contentLoaded = true;
			Uri resourceLocator = new Uri("/AiteCriminal;component/window2.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		[GeneratedCode("PresentationBuildTasks", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Never), DebuggerNonUserCode]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				((Button)target).Click += new RoutedEventHandler(this.Button_Click);
				return;
			case 2:
				((Button)target).Click += new RoutedEventHandler(this.Button_Click_1);
				return;
			case 3:
				((Button)target).Click += new RoutedEventHandler(this.Button_Click_2);
				return;
			case 4:
				this.ScoreSlider = (Slider)target;
				this.ScoreSlider.ValueChanged += new RoutedPropertyChangedEventHandler<double>(this.Slider_ValueChanged);
				return;
			case 5:
				this.score = (Label)target;
				return;
			case 6:
				this.friend = (ListBox)target;
				return;
			default:
				this._contentLoaded = true;
				return;
			}
		}
	}
}
