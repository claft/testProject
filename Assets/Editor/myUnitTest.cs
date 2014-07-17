using System;
using System.Threading;
using NUnit.Framework;

namespace MyUnityTest
{
	class SampleTests
	{
		[TestCase("fizz")]
		public void constructor(string test)
		{
			Fizzbuzz fb = new Fizzbuzz (test);
			Assert.AreEqual (fb.Ret, test);
		}
	}
}
