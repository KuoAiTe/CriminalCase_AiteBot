using System;
using System.IO;
using System.Net;
using System.Text;

namespace AiteCriminal
{
	public class CCRequest
	{
		public string result;

		private HttpWebRequest request;

		public CCRequest()
		{
			this.request = (HttpWebRequest)WebRequest.Create("https://imabigfanof.criminalcasegame.com/bridge.php");
			this.request.ContentType = "application/x-www-form-urlencoded";
			this.request.KeepAlive = true;
			this.request.CookieContainer = user.logincookie;
			this.request.UserAgent = "Mozilla/5.0 (Windows; U; Windows NT 6.1; ru; rv:1.9.2.3) Gecko/20100401 Firefox/4.0 (.NET CLR 3.5.30729)";
			this.request.Method = "POST";
		}

		public bool SendGift(string data)
		{
			this.request = (HttpWebRequest)WebRequest.Create("https://imabigfanof.criminalcasegame.com/api.php");
			this.request.ContentType = "application/x-www-form-urlencoded";
			this.request.KeepAlive = false;
			this.request.UserAgent = "Mozilla/5.0 (Windows; U; Windows NT 6.1; ru; rv:1.9.2.3) Gecko/20100401 Firefox/4.0 (.NET CLR 3.5.30729)";
			this.request.Method = "POST";
			bool flag;
			try
			{
				byte[] bytes = new UTF8Encoding().GetBytes(data);
				this.request.ContentLength = (long)bytes.Length;
				using (Stream requestStream = this.request.GetRequestStream())
				{
					requestStream.Write(bytes, 0, bytes.Length);
				}
				using (HttpWebResponse httpWebResponse = (HttpWebResponse)this.request.GetResponse())
				{
					using (Stream responseStream = httpWebResponse.GetResponseStream())
					{
						using (StreamReader streamReader = new StreamReader(responseStream))
						{
							this.result = streamReader.ReadToEnd();
							flag = true;
						}
					}
				}
			}
			catch (Exception)
			{
				flag = false;
			}
			return flag;
		}

		public bool GetMessage()
		{
			this.request = (HttpWebRequest)WebRequest.Create("https://imabigfanof.criminalcasegame.com/api.php?action=messages-list&user_id=" + user.id + "&signature=" + user.signature);
			this.request.ContentType = "application/x-www-form-urlencoded";
			this.request.KeepAlive = false;
			this.request.UserAgent = "Mozilla/5.0 (Windows; U; Windows NT 6.1; ru; rv:1.9.2.3) Gecko/20100401 Firefox/4.0 (.NET CLR 3.5.30729)";
			this.request.Method = "GET";
			bool flag;
			try
			{
				using (HttpWebResponse httpWebResponse = (HttpWebResponse)this.request.GetResponse())
				{
					using (Stream responseStream = httpWebResponse.GetResponseStream())
					{
						using (StreamReader streamReader = new StreamReader(responseStream))
						{
							this.result = streamReader.ReadToEnd();
						}
					}
				}
				flag = true;
			}
			catch (Exception)
			{
				flag = false;
			}
			return flag;
		}

		public bool Get(string data)
		{
			bool flag;
			try
			{
				byte[] bytes = new UTF8Encoding().GetBytes(data);
				this.request.ContentLength = (long)bytes.Length;
				using (Stream requestStream = this.request.GetRequestStream())
				{
					requestStream.Write(bytes, 0, bytes.Length);
				}
				using (HttpWebResponse httpWebResponse = (HttpWebResponse)this.request.GetResponse())
				{
					user.logincookie.Add(httpWebResponse.Cookies);
					using (Stream responseStream = httpWebResponse.GetResponseStream())
					{
						using (StreamReader streamReader = new StreamReader(responseStream))
						{
							this.result = streamReader.ReadToEnd();
						}
					}
				}
				flag = true;
			}
			catch (Exception)
			{
				flag = false;
			}
			return flag;
		}
	}
}
