using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace AiteCriminal
{
	public class card_w : Window, IComponentConnector
	{
		public bool ButtonClicked;

		internal CheckBox Get_Report;

		internal CheckBox Log_Report;

		internal CheckBox Get_Energy2;

		internal CheckBox Log_Energy2;

		internal CheckBox Get_Energy1;

		internal CheckBox Log_Energy1;

		internal CheckBox Get_Card;

		internal CheckBox Log_Card;

		private bool _contentLoaded;

		public card_w()
		{
			this.InitializeComponent();
			this.Get_Card.IsChecked = new bool?(user.Get_Card);
			this.Log_Card.IsChecked = new bool?(user.Log_Card);
			this.Get_Energy2.IsChecked = new bool?(user.Get_Energy2);
			this.Log_Energy2.IsChecked = new bool?(user.Log_Energy2);
			this.Get_Energy1.IsChecked = new bool?(user.Get_Energy1);
			this.Log_Energy1.IsChecked = new bool?(user.Log_Energy1);
			this.Get_Report.IsChecked = new bool?(user.Get_Report);
			this.Log_Report.IsChecked = new bool?(user.Log_Report);
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			base.Close();
			this.ButtonClicked = true;
			user.Get_Card = this.Get_Card.IsChecked.Value;
			user.Log_Card = this.Log_Card.IsChecked.Value;
			user.Get_Energy2 = this.Get_Energy2.IsChecked.Value;
			user.Log_Energy2 = this.Log_Energy2.IsChecked.Value;
			user.Get_Energy1 = this.Get_Energy1.IsChecked.Value;
			user.Log_Energy1 = this.Log_Energy1.IsChecked.Value;
			user.Get_Report = this.Get_Report.IsChecked.Value;
			user.Log_Report = this.Log_Report.IsChecked.Value;
		}

		[GeneratedCode("PresentationBuildTasks", "4.0.0.0"), DebuggerNonUserCode]
		public void InitializeComponent()
		{
			if (this._contentLoaded)
			{
				return;
			}
			this._contentLoaded = true;
			Uri resourceLocator = new Uri("/AiteCriminal;component/card_w.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		[GeneratedCode("PresentationBuildTasks", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Never), DebuggerNonUserCode]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				this.Get_Report = (CheckBox)target;
				return;
			case 2:
				this.Log_Report = (CheckBox)target;
				return;
			case 3:
				this.Get_Energy2 = (CheckBox)target;
				return;
			case 4:
				this.Log_Energy2 = (CheckBox)target;
				return;
			case 5:
				this.Get_Energy1 = (CheckBox)target;
				return;
			case 6:
				this.Log_Energy1 = (CheckBox)target;
				return;
			case 7:
				this.Get_Card = (CheckBox)target;
				return;
			case 8:
				this.Log_Card = (CheckBox)target;
				return;
			case 9:
				((Button)target).Click += new RoutedEventHandler(this.Button_Click);
				return;
			default:
				this._contentLoaded = true;
				return;
			}
		}
	}
}
