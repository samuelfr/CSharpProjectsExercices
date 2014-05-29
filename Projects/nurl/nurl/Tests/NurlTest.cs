using System;
using NUnit.Framework;

namespace nurl
{
	[TestFixture]
	public class NurlTest
	{
		[Test]
		[TestCase(@"http://samuelfr.github.io/CSharpProjectsExercices/fake.html", @"<html><h1>test page loading</h1></html>")]
		public void testGetContent(string url, string expected)
		{
			var nurl = new Nurl();
			var result = nurl.getContent(url); 
			Assert.AreEqual(result, expected, "Erreur testGetContent");
		}
		
		[Test]
		[TestCase("wrongURL", 0)]
		public void testGetLoadTimeWithWrongURL(string url, float expected)
		{
			var nurl = new Nurl();
			var result = nurl.getLoadTime(url); 
			Assert.AreEqual(result, expected, "Erreur testGetLoadTimeWithWrongURL");
		}
		
		
		[Test]
		[TestCase(@"http://samuelfr.github.io/CSharpProjectsExercices/fake.html")]
		public void testGetLoadTimeWithCorrectURL(string url)
		{
			var nurl = new Nurl();
			var result = nurl.getLoadTime(url); 
			Assert.IsTrue(result > 0 , "Erreur testGetLoadTimeWithCorrectURL");
		}
		
		[Test]
		[TestCase("http://fake.com", true)]
		[TestCase("wrongAddress", false)]
		[TestCase("https://fake.com", true)]		
		public void testIsURL(string URL, Boolean expected)
		{
			var result = Nurl.isURL(URL); 
			Assert.AreEqual(result, expected, "Erreur testIsURL");
		}
		
	}
}
