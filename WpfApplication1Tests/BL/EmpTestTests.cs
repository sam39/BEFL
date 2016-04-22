using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit;
using NUnit.Framework;
using WpfApplication1.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1.BL.Tests
{
    [TestClass()]
    public class EmpTestTests
    {
        [TestMethod()]
        public void Test1Test()
        {
            //Assert.Fail();
        }
    }

    [TestFixture]
    public class EmpTest
    {
        [Test]
        public void Test1()
        {
            NUnit.Framework.Assert.AreEqual(2, 2);

        }


    }


}