using System;
using NUnit.Framework;
using Solutions;

namespace Tests
{
	[TestFixture]
	public class TestClass
	{
		[Test]
		public void TestGreedRedDigits()
		{
			var s = new GreenRedElementsSolution();

			Assert.AreEqual(4, s.solution(5, new int[] {5, 5, 1, 7, 2, 3, 5}));
			Assert.AreEqual(4, s.solution(5, new int[] {5, 5, Int32.MinValue, Int32.MaxValue, 2, Int32.MaxValue, 5}));
			Assert.AreEqual(6, s.solution(7, new[] {6, 5, 4, 3, 2, 1}));
			Assert.AreEqual(5, s.solution(5, new int[] {-5, 5, 4, -4321, 2, 1}));
			Assert.AreEqual(5, s.solution(5, new int[] {-5, 5, 4, Int32.MinValue, Int32.MaxValue, 1}));
		}
	}
}