using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
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
	public partial class MainWindow : Window
	{
		private Timer update_thread;

		public MainWindow()
		{
			InitializeComponent();
			user.stage.Add(1011, new user.Stage());
			user.stage.Add(1012, new user.Stage());
			user.stage.Add(1013, new user.Stage());
			user.stage.Add(1021, new user.Stage());
			user.stage.Add(1022, new user.Stage());
			user.stage.Add(1023, new user.Stage());
			user.stage.Add(1031, new user.Stage());
			user.stage.Add(1032, new user.Stage());
			user.stage.Add(1033, new user.Stage());
			this.Title = string.Concat(user.Version, " - Login");
			this.ResizeMode = System.Windows.ResizeMode.CanMinimize;
			ServicePointManager.DefaultConnectionLimit = 65535;
			try
			{
				string[] strArrays = File.ReadAllLines("aite.ini");
				user_id.Text = strArrays[0];
				user_signature.Text = strArrays[1];
			}
			catch
			{
				user_id.Text = "USER ID";
				user_signature.Text = "USER SIGNATURE";
			}
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			user.id = user_id.Text;
			user.signature = user_signature.Text;
			if (!Request.GetUserData())
			{
				MessageBox.Show("帳號密碼錯誤");
			}
			else
			{
				update_thread = new Timer(new TimerCallback(UpdateInfo), null, 0, 30000);
				Request.CollectDailyBonus();
				Window1 window1 = new Window1();
				window1.Show();
				window1.Closed += new EventHandler(FooClosed);
				this.Hide();
				string[] strArrays = new string[] { user.id, user.signature };
				using (StreamWriter streamWriter = new StreamWriter("aite.ini"))
				{
					string[] strArrays1 = strArrays;
					for (int i = 0; i < (int)strArrays1.Length; i++)
					{
						streamWriter.WriteLine(strArrays1[i]);
					}
				}
			}
		}

		public void FooClosed(object sender, EventArgs e)
		{
			this.Close();
			Environment.Exit(Environment.ExitCode);
		}

		private void UpdateInfo(object state)
		{
			Request.GetUserData();
		}
	}
}