using System;
using CykelLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CykelTest
{
    [TestClass]
    public class UnitTest1
    {
        private Cykel cykel = new Cykel(1, "grøn", 0.0, 0);

        [TestMethod]
        public void ConstructorTest()
        {
            Cykel cykel = new Cykel(1, "grøn", 0.0, 0);

            Assert.AreEqual(1, cykel.Id);
            Assert.AreEqual("grøn", cykel.Color);
            Assert.AreEqual(0.0, cykel.Price);
            Assert.AreEqual(0, cykel.Gear);
        }

        /// <summary>
        /// Tests to see if exceptions are thrown according to the Set constraints
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestColor()
        {
            cykel.Color = "";
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void PriceTest()
        {
            cykel.Price = 0.0;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GearTest()
        {
            cykel.Gear = 1;
        }
    }
}
