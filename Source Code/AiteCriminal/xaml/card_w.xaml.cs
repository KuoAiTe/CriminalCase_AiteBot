using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Markup;

namespace AiteCriminal
{
	public partial class card_w : Window
	{
		public bool ButtonClicked;

		public card_w()
		{
			InitializeComponent();
			Get_Card.IsChecked = new bool?(user.Get_Card);
			Log_Card.IsChecked = new bool?(user.Log_Card);
			Get_Energy2.IsChecked = new bool?(user.Get_Energy2);
			Log_Energy2.IsChecked = new bool?(user.Log_Energy2);
			Get_Energy1.IsChecked = new bool?(user.Get_Energy1);
			Log_Energy1.IsChecked = new bool?(user.Log_Energy1);
			Get_Report.IsChecked = new bool?(user.Get_Report);
			Log_Report.IsChecked = new bool?(user.Log_Report);
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			this.Close();
			ButtonClicked = true;
			user.Get_Card = Get_Card.IsChecked.Value;
			user.Log_Card = Log_Card.IsChecked.Value;
			user.Get_Energy2 = Get_Energy2.IsChecked.Value;
			user.Log_Energy2 = Log_Energy2.IsChecked.Value;
			user.Get_Energy1 = Get_Energy1.IsChecked.Value;
			user.Log_Energy1 = Log_Energy1.IsChecked.Value;
			user.Get_Report = Get_Report.IsChecked.Value;
			user.Log_Report = Log_Report.IsChecked.Value;
		}
	}
}