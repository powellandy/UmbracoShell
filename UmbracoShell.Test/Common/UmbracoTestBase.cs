using NUnit.Framework;
using Umbraco.Framework.Testing.PartialTrust;
using System;

namespace Umbraco.Web.Tests.Common
{
	[TestFixture]
    public class UmbracoTestBase 
    {

        //Tests
        [Test]
        public void TestingTheTestWithTests()
        {
            Assert.Pass("Insert tests here");
        }

	}
}