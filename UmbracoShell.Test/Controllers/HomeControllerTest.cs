using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using NUnit.Framework;
using Umbraco5Base;
using Umbraco5Base.Tests.Controllers;

namespace Umbraco5Base.Tests.Controllers
{
    [TestFixture]
    public class HomeControllerTest
    {
        [Test]
        public void Index()
        {
            Assert.That(1 == 1);
        }

    }
}
