
using System;
using System.Collections.Generic;

namespace nurl
{
	/// <summary>
	/// Description of Command.
	/// </summary>
	public class Command
	{
		enum Type { Undefined, Test, Get };
		
		private string[] args;
		private Type type;
		private Dictionary<string,string> options;
		
		
		public Command(string[] _args)
		{
			args = _args;
			type = Command.Type.Undefined;
			options = new Dictionary<string,string>();
		}
		
		public Boolean parse()
		{
			if(args == null || args.Length < 3)
				return false;
			
			if(args[0].ToLower().Equals("get")){
				type = Command.Type.Get;
			}else if(args[0].ToLower().Equals("test")){
				type = Command.Type.Test;
			}else{
				return false;
			}
			
			int i=1;
			while(i<args.Length){
				
				
				
				i++;
			}
			
			
			
			return true;
		}
		
		public static Boolean IsNameOption(string str)
		{
			
			return true;
		}
	}
}
