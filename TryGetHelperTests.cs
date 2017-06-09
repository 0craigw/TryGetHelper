using System;
using LIC.Services.Reproduction.Datastore.Db2;
using LIC.Services.Reproduction.WebApi.IntegrationTests.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LIC.Services.Reproduction.WebApi.IntegrationTests.UnitTests
{
	[TestClass]
	public class TryGetHelperTests
	{
		[TestMethod]
		public void ToString_ShouldBeTrue()
		{
			var x = 1;
			string result;
			var actual = TryGetHelper.TryGet(() => x.ToString(), out result);
			Assert.IsTrue(actual);
			Assert.AreEqual("1", result);
		}

		[TestMethod]
		public void DivideByZero_ShouldBeFalse()
		{
			var x = 1;
			int result;
			var actual = TryGetHelper.TryGet(() => x / 0, out result);
			Assert.IsFalse(actual);
			Assert.AreEqual(0, result);
		}


		[TestMethod]
		public void ComplexType_ShouldBeFalse()
		{
			FemaleReproductiveStatus result;
			var actual = TryGetHelper.TryGet(() =>
			{
				throw new Exception();
			}, out result);
			Assert.IsFalse(actual);
			Assert.AreEqual(null, result);
		}
	}
}
