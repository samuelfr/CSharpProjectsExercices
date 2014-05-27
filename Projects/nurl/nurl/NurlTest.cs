using System;
using NUnit.Framework;

namespace nurl
{
	[TestFixture]
	public class NurlTest
	{
		[Test]
		[TestCase("http://fake", "<h1>hello</h1>")]
		public void testGetContent(string url, string expected)
		{
			var nurl = new Nurl();
			var result = nurl.getContent(url); 
			Assert.AreEqual(result, expected);
		}
		
		
		[Test]
		[TestCase("http://fake.com", true)]
		[TestCase("wrongAdress", false)]
		public void testIsURL(string URL, Boolean expected)
		{
			var nurl = new Nurl();
			var result = nurl.isURL(URL); 
			Assert.AreEqual(result, expected);
		}
		
		[Test]
		[TestCase(new string[] {"get","-url","htt:\\url.com"}, true)]
		[TestCase(new string[] {"get","-url"}, false)]
		[TestCase(new string[] {"wrongCommand"}, false)]
		[TestCase(new string[] {"wrongCommand","-url","htt:\\url.com"}, false)]
		[TestCase(new string[] {"test","-url","htt:\\url.com"}, true)]
		public void testIsArgsCorrect(string[] args, Boolean expected)
		{
			var nurl = new Nurl();			
			var result = nurl.isArgsCorrect(args);
			Assert.AreEqual(result, expected);
		}
		
		
		
		
	}
}
