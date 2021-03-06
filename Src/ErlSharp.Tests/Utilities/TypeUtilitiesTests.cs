﻿namespace ErlSharp.Tests.Utilities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Text;
    using ErlSharp.Compiler;
    using ErlSharp.Tests.Classes;
    using ErlSharp.Utilities;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class TypeUtilitiesTests
    {
        [TestMethod]
        public void GetTypeByName()
        {
            Type type = TypeUtilities.GetType("System.Int32");

            Assert.IsNotNull(type);
            Assert.AreEqual(typeof(int), type);
        }

        [TestMethod]
        public void GetLibraryTypeByName()
        {
            Type type = TypeUtilities.GetType("ErlSharp.Context");

            Assert.IsNotNull(type);
            Assert.AreEqual(typeof(Context), type);
        }

        [TestMethod]
        public void GetConsoleTypeByName()
        {
            Type type = TypeUtilities.GetType("ErlSharp.Console.Program");

            Assert.IsNotNull(type);
            Assert.IsNotInstanceOfType(type, typeof(ErlSharp.Console.Program));
            Assert.AreEqual("ErlSharp.Console.Program", type.FullName);
        }
    }
}
