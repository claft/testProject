using System;
using System.Threading;
using NUnit.Framework;

namespace MyBasicTest
{
	class BasicTest
	{
		[TestCase("title", "name")]
		public void constractorTest (string title, string name)
		{
			Basic basic = new Basic (title, name);
			Assert.AreEqual ("title", basic.Title);
			Assert.AreEqual ("name", basic.Name);
		}
	}
}

