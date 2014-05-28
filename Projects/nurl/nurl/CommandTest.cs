using System;
using NUnit.Framework;

namespace nurl
{
	[TestFixture]
	public class CommandTest
	{		
		[Test]
		[TestCase(new string[] {"get","-url","htt:\\url.com"}, true)]
		[TestCase(new string[] {"get","-url"}, false)]
		[TestCase(new string[] {"wrongCommand"}, false)]
		[TestCase(new string[] {"wrongCommand","-url","htt:\\url.com"}, false)]
		[TestCase(new string[] {"test","-url","htt:\\url.com"}, true)]
		public void testParse(string[] args, Boolean expected)
		{		
			var command = new Command(args);
			var result = command.parse();
			Assert.AreEqual(result, expected, "Erreur testParse");
		}
		
		[Test]
		[TestCase("-url", true)]
		[TestCase("wrongOption", true)]
		public void testIsNameOption(string stringGiven, Boolean expected){
			Assert.AreEqual(Command.IsNameOption(stringGiven), expected, "Erreur testParse");
		}
		
		
		
		
	}
}
