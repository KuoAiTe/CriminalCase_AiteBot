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
	public partial class SendFreeEnergy : Window
	{
		public bool SendAllFriend;

		public SendFreeEnergy()
		{
			InitializeComponent();
			if (user.GiftFriendList.Count > 0)
				foreach (Friends giftFriendList in user.GiftFriendList)
					friend.Items.Add(giftFriendList.name);
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			if (friend.SelectedIndex != -1)
			{
				int selectedIndex = friend.SelectedIndex;
				Console.WriteLine(user.GiftFriendList[selectedIndex].name);
				string item = user.GiftFriendList[selectedIndex].uid;
				string str = user.GiftFriendList[selectedIndex].name;
				int num = user.GiftFriendList[selectedIndex].level;
				if (Request.SendEnergy(item))
				{
					object[] objArray = new object[] { "寄送 2 點能量給 ", str, " ( 等級 ", num, ")" };
					user.CardLog(string.Concat(objArray));
                    try
                    {
                        user.GiftFriendList.RemoveAt(selectedIndex);
                        friend.Items.RemoveAt(selectedIndex);
                    } catch { }
				}
			}
		}

		private void Button_Click_1(object sender, RoutedEventArgs e)
		{
			if (friend.Items.Count > 0)
			{
				SendAllFriend = true;
				friend.Items.Clear();
				this.Close();
			}
		}
	}
}