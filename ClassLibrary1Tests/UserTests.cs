using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Tests
{
    [TestClass()]
    public class UserTests
    {
        [TestMethod()]
        public void UserTest()
        {
            int a=1, b=0, x=0;
            User target = new User(a, b, x);
            Assert.IsTrue(target != null);
        }

        [TestMethod()]
        public void UserTest1()
        {
            int a = -1, b = 0, x = 2;
            User target = new User(a, b, x);
            Assert.IsTrue(target != null);
        }

        [TestMethod()]
        public void UserTest2()
        {
            int a =2, b = 1, x = 2;
            User target = new User(a, b, x);
            Assert.IsTrue(target != null);
        }
        [TestMethod()]
        public void UserTest3()
        {
            int a = 2, b = 0, x = 4;
            User target = new User(a, b, x);
            Assert.IsTrue(target != null);
        }

    }
}