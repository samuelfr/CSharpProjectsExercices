
using System;

namespace nurl
{
	/// <summary>
	/// Description of Program.
	/// </summary>	
	class Program
	{
		public static void Main(string[] args)
		{
			Command command = new Command(args);
			
			if(command.parse()){
				Nurl nurl = new Nurl();
				nurl.executeCommand(command);
			}
		}
		
	}
}
