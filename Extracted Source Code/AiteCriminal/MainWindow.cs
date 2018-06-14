using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace AiteCriminal
{
	public class MainWindow : Window, IComponentConnector
	{
		private Timer update_thread;

		internal Grid hey;

		internal TextBox user_id;

		internal TextBox user_signature;

		private bool _contentLoaded;

		public MainWindow()
		{
			this.InitializeComponent();
			user.stage.Add(1011, new user.Stage());
			user.stage.Add(1012, new user.Stage());
			user.stage.Add(1013, new user.Stage());
			user.stage.Add(1021, new user.Stage());
			user.stage.Add(1022, new user.Stage());
			user.stage.Add(1023, new user.Stage());
			user.stage.Add(1031, new user.Stage());
			user.stage.Add(1032, new user.Stage());
			user.stage.Add(1033, new user.Stage());
			base.Title = user.Version + " - Login";
			base.ResizeMode = ResizeMode.CanMinimize;
			ServicePointManager.DefaultConnectionLimit = 65535;
			try
			{
				string[] array = File.ReadAllLines("aite.ini");
				this.user_id.Text = array[0];
				this.user_signature.Text = array[1];
			}
			catch
			{
				this.user_id.Text = "USER ID";
				this.user_signature.Text = "USER SIGNATURE";
			}
		}

		public void FooClosed(object sender, EventArgs e)
		{
			base.Close();
			Environment.Exit(Environment.ExitCode);
		}

		private void UpdateInfo(object state)
		{
			Request.GetUserData();
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			user.id = this.user_id.Text;
			user.signature = this.user_signature.Text;
			if (Request.GetUserData())
			{
				this.update_thread = new Timer(new TimerCallback(this.UpdateInfo), null, 0, 30000);
				Request.CollectDailyBonus();
				Window1 window = new Window1();
				window.Show();
				window.Closed += new EventHandler(this.FooClosed);
				base.Hide();
				string[] array = new string[]
				{
					user.id,
					user.signature
				};
				using (StreamWriter streamWriter = new StreamWriter("aite.ini"))
				{
					string[] array2 = array;
					for (int i = 0; i < array2.Length; i++)
					{
						string value = array2[i];
						streamWriter.WriteLine(value);
					}
					return;
				}
			}
			MessageBox.Show("帳號密碼錯誤");
		}

		[GeneratedCode("PresentationBuildTasks", "4.0.0.0"), DebuggerNonUserCode]
		public void InitializeComponent()
		{
			if (this._contentLoaded)
			{
				return;
			}
			this._contentLoaded = true;
			Uri resourceLocator = new Uri("/AiteCriminal;component/mainwindow.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		[GeneratedCode("PresentationBuildTasks", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Never), DebuggerNonUserCode]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				this.hey = (Grid)target;
				return;
			case 2:
				((Button)target).Click += new RoutedEventHandler(this.Button_Click);
				return;
			case 3:
				this.user_id = (TextBox)target;
				return;
			case 4:
				this.user_signature = (TextBox)target;
				return;
			default:
				this._contentLoaded = true;
				return;
			}
		}
	}
}
