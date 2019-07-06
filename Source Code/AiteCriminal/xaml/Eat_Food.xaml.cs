using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Media.Imaging;

namespace AiteCriminal
{
	public partial class Eat_Food : Window
	{
		public bool ButtonClicked;

		public int Food_Count;

		public bool repeat;

		public Eat_Food(int food_id)
		{
			this.InitializeComponent();
			if (food_id == 0)
			{
				this.pic.Source = new BitmapImage(new Uri("/AiteCriminal;component/AiteCriminal/Resources/reward_0.png", UriKind.RelativeOrAbsolute));
				return;
			}
			if (food_id == 1)
			{
				this.pic.Source = new BitmapImage(new Uri("/AiteCriminal;component/AiteCriminal/Resources/reward_1.png", UriKind.RelativeOrAbsolute));
				return;
			}
			if (food_id == 2)
			{
				this.pic.Source = new BitmapImage(new Uri("/AiteCriminal;component/AiteCriminal/Resources/reward_2.png", UriKind.RelativeOrAbsolute));
			}
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			this.ButtonClicked = true;
			this.repeat = false;
			base.Close();
		}

		private void Button2_Click(object sender, RoutedEventArgs e)
		{
			this.ButtonClicked = true;
			this.repeat = true;
			base.Close();
		}
	}
}