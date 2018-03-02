using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Reduce;

namespace ReduceTest
{
        [TestClass]
        public class UnitTest
        {
            [TestMethod]
            public void TestReduce()
            {
                int[] valores = new int[] { 1, 3, 5, 7 };
                Assert.AreEqual(Program.ReduceInt(valores, 0, (acumulador, valor) => acumulador + valor), 16);
            }

            [TestMethod]
            public void TestGenerico()
            {
                string[] valores = new string[] { "paseando", "a", "mi", "perro" };
                Assert.AreEqual(Program.Reduce<string, int>(valores, 0, (acumulador, valor) => acumulador + valor.Length), 16);
            }
        }
    }