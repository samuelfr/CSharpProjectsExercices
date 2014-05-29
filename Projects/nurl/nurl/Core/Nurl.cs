using System;
using System.Net;

namespace nurl
{
	/// <summary>
	/// Description of Nurl.
	/// </summary>
	public class Nurl
	{
		public Nurl()
		{
		}
		
		
		public static Boolean isURL(string URL)
		{
			Uri uri = null;
			if (!Uri.TryCreate(URL, UriKind.Absolute, out uri) || null == uri)
			{
			    return false;
			}else{
				return true;
			}
		}
		
		public string getContent(string URL)
		{
			string content = "";
			
			if(Nurl.isURL(URL)){
				var webClient = new System.Net.WebClient();
				content = webClient.DownloadString(URL);
				//Suppression du retour à la ligne '\n'
				content = content.Remove(content.Length-1);
			}
			
			return content;
		}
		
		public void saveContent(string URL)
		{
			
		}
		
		public void showContent(string URL)
		{
			Console.WriteLine(this.getContent(URL));
		}
		
		
		public void Get(string[] args)
		{
			return;
		}
		
		public float getLoadTime(string URL)
		{
			float loadTime = 0;
			if(Nurl.isURL(URL)){				
                var timeBefore = DateTime.Now;
                getContent(URL);
                var timeAfter = DateTime.Now;
				loadTime = (timeAfter - timeBefore).Milliseconds;
			}
			return loadTime;
		}
		
		public void executeCommand(Command command)
		{
			
		}
	}
}
