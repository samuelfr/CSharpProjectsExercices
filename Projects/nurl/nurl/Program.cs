
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
			Nurl nurl = new Nurl();
			
			if(command.parse()){
				nurl.executeCommand(command);
			}
		}
		
	}
}
