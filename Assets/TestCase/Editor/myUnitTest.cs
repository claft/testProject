using System;
using System.Threading;
using NUnit.Framework;

namespace MyUnityTest
{
	class FizzBuzzTest
	{
		private const string FIZZ = "Fizz";
		private const string BUZZ = "Buzz";
		private const string FIZZBUZZ = "FizzBuzz";

		[TestCase(1)]
		[TestCase(2)]
		public void other(int num)
		{
			Fizzbuzz fizzbuzz = new Fizzbuzz();
			Assert.AreEqual (num.ToString (), fizzbuzz.fb (num));
		}

		[TestCase(3)]
		public void fizz(int num)
		{
			Fizzbuzz fizzbuzz = new Fizzbuzz();
			Assert.AreEqual (FIZZ, fizzbuzz.fb (num));
		}

		[TestCase(5)]
		public void buzz(int num)
		{
			Fizzbuzz fizzbuzz = new Fizzbuzz();
			Assert.AreEqual (BUZZ, fizzbuzz.fb (num));
		}

		[TestCase(15)]
		public void fizzbuzz(int num)
		{
			Fizzbuzz fizzbuzz = new Fizzbuzz();
			Assert.AreEqual (FIZZBUZZ, fizzbuzz.fb (num));
		}
	}
}
