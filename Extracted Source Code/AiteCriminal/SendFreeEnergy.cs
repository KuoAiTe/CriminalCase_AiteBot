using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace AiteCriminal
{
	public class SendFreeEnergy : Window, IComponentConnector
	{
		public bool SendAllFriend;

		internal ListBox friend;

		private bool _contentLoaded;

		public SendFreeEnergy()
		{
			this.InitializeComponent();
			if (user.GiftFriendList.Count > 0)
			{
				foreach (friends current in user.GiftFriendList)
				{
					this.friend.Items.Add(current.name);
				}
			}
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			if (this.friend.SelectedIndex != -1)
			{
				int selectedIndex = this.friend.SelectedIndex;
				Console.WriteLine(user.GiftFriendList[selectedIndex].name);
				string uid = user.GiftFriendList[selectedIndex].uid;
				string name = user.GiftFriendList[selectedIndex].name;
				int level = user.GiftFriendList[selectedIndex].level;
				if (Request.SendEnergy(uid))
				{
					user.CardLog(string.Concat(new object[]
					{
						"寄送 2 點能量給 ",
						name,
						" ( 等級 ",
						level,
						")"
					}));
					try
					{
						user.GiftFriendList.RemoveAt(selectedIndex);
						this.friend.Items.RemoveAt(selectedIndex);
					}
					catch
					{
					}
				}
			}
		}

		private void Button_Click_1(object sender, RoutedEventArgs e)
		{
			if (this.friend.Items.Count > 0)
			{
				this.SendAllFriend = true;
				this.friend.Items.Clear();
				base.Close();
			}
		}

		[GeneratedCode("PresentationBuildTasks", "4.0.0.0"), DebuggerNonUserCode]
		public void InitializeComponent()
		{
			if (this._contentLoaded)
			{
				return;
			}
			this._contentLoaded = true;
			Uri resourceLocator = new Uri("/AiteCriminal;component/sendfreeenergy.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		[GeneratedCode("PresentationBuildTasks", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Never), DebuggerNonUserCode]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				this.friend = (ListBox)target;
				return;
			case 2:
				((Button)target).Click += new RoutedEventHandler(this.Button_Click);
				return;
			case 3:
				((Button)target).Click += new RoutedEventHandler(this.Button_Click_1);
				return;
			default:
				this._contentLoaded = true;
				return;
			}
		}
	}
}
