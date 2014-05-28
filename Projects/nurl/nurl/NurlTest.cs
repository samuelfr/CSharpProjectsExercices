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
			Assert.AreEqual(result, expected, "Erreur testGetContent");
		}
		
		[Test]
		[TestCase("wrongURL", 0)]
		public void testGetLoadTime(string url, float expected)
		{
			var nurl = new Nurl();
			var result = nurl.getLoadTime(url); 
			Assert.AreEqual(result, expected, "Erreur testGetLoadTime");
		}
		
		
		[Test]
		[TestCase("http://fake.com", true)]
		[TestCase("wrongAdress", false)]
		[TestCase("https://fake.com", true)]
		public void testIsURL(string URL, Boolean expected)
		{
			var result = Nurl.isURL(URL); 
			Assert.AreEqual(result, expected, "Erreur testIsURL");
		}
		
	}
}
