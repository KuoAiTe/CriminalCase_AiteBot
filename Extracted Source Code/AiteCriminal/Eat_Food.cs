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
	public class Eat_Food : Window, IComponentConnector
	{
		public bool ButtonClicked;

		public int Food_Count;

		public bool repeat;

		internal Image pic;

		private bool _contentLoaded;

		public Eat_Food(int food_id)
		{
			this.InitializeComponent();
			if (food_id == 0)
			{
				this.pic.Source = new BitmapImage(new Uri("reward_0.png", UriKind.RelativeOrAbsolute));
				return;
			}
			if (food_id == 1)
			{
				this.pic.Source = new BitmapImage(new Uri("reward_1.png", UriKind.RelativeOrAbsolute));
				return;
			}
			if (food_id == 2)
			{
				this.pic.Source = new BitmapImage(new Uri("reward_2.png", UriKind.RelativeOrAbsolute));
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

		[GeneratedCode("PresentationBuildTasks", "4.0.0.0"), DebuggerNonUserCode]
		public void InitializeComponent()
		{
			if (this._contentLoaded)
			{
				return;
			}
			this._contentLoaded = true;
			Uri resourceLocator = new Uri("/AiteCriminal;component/eat_food.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		[GeneratedCode("PresentationBuildTasks", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Never), DebuggerNonUserCode]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				this.pic = (Image)target;
				return;
			case 2:
				((Button)target).Click += new RoutedEventHandler(this.Button_Click);
				return;
			case 3:
				((Button)target).Click += new RoutedEventHandler(this.Button2_Click);
				return;
			default:
				this._contentLoaded = true;
				return;
			}
		}
	}
}
