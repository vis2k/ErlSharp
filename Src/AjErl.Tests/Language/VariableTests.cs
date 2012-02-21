﻿using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AjErl.Language;

namespace AjErl.Tests.Language
{
    [TestClass]
    public class VariableTests
    {
        [TestMethod]
        public void CreateSimpleVariable()
        {
            Variable variable = new Variable("X");

            Assert.AreEqual("X", variable.Name);
        }
    }
}
