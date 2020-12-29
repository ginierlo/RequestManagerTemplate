using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace RequestManagerTests.ModelsTests
{
    [TestClass]
    public class PriorityTests : AssemblyLoader
    {
        private const string TYPE_NAME = "priority";

        /// <summary>
        /// Vérifie si le type existe
        /// </summary>
        [TestMethod]
        public void TypeExist()
        {
            Assert.IsNotNull(base.GetType(TYPE_NAME));
        }

        /// <summary>
        /// Vérifie si c'est un enum
        /// </summary>
        [TestMethod]
        public void TypeIsEnum()
        {
            Assert.IsTrue(base.GetType(TYPE_NAME)?.IsEnum ?? false);
        }

        /// <summary>
        /// Vérifie si'il contient au moins 3 valeurs
        /// </summary>
        [TestMethod]
        public void ContainsAtLeast3Values()
        {
            Assert.IsTrue(base.GetType(TYPE_NAME)?.GetEnumNames()?.Length >= 3);
        }

        /// <summary>
        /// Vérifie que la première valeur soit low
        /// </summary>
        [TestMethod]
        public void FirstValueShouldBeLow()
        {
            Assert.IsTrue(base.GetType(TYPE_NAME)?.GetEnumNames()[0].ToLower() == "low");
        }

        /// <summary>
        /// Vérifie que la deuxième valeur soit medium
        /// </summary>
        [TestMethod]
        public void SecondValueShouldBeInProgress()
        {
            Assert.IsTrue(base.GetType(TYPE_NAME)?.GetEnumNames()[1].ToLower() == "medium");
        }

        /// <summary>
        /// Vérifie que la troisième valeur soit high
        /// </summary>
        [TestMethod]
        public void SecondValueShouldBeDone()
        {
            Assert.IsTrue(base.GetType(TYPE_NAME)?.GetEnumNames()[2].ToLower() == "high");
        }
    }
}
