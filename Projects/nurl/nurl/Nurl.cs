using System;

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
			return "<h1>hello</h1>";
		}
		
		public void saveContent(string URL)
		{
			
		}
		
		public void showContent(string URL)
		{
			
		}
		
		
		public void Get(string[] args)
		{
			return;
		}
		
		public float getLoadTime(string URL)
		{
			return 0;
		}
		
		public void executeCommand(Command command)
		{
			
		}
	}
}
