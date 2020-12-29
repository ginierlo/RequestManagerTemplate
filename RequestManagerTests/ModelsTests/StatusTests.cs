using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace RequestManagerTests.ModelsTests
{
    [TestClass]
    public class StatusTests : AssemblyLoader
    {
        private const string TYPE_NAME = "status";

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
        /// Vérifie si'il contient au moins 4 valeurs
        /// </summary>
        [TestMethod]
        public void ContainsAtLeast4Values()
        {
            Assert.IsTrue(base.GetType(TYPE_NAME)?.GetEnumNames()?.Length >= 4);
        }

        /// <summary>
        /// Vérifie que la première valeur soit todo
        /// </summary>
        [TestMethod]
        public void FirstValueShouldBeLow()
        {
            Assert.IsTrue(base.GetType(TYPE_NAME)?.GetEnumNames()[0].ToLower() == "todo");
        }

        /// <summary>
        /// Vérifie que la deuxième valeur soit inprogress
        /// </summary>
        [TestMethod]
        public void SecondValueShouldBeInProgress()
        {
            Assert.IsTrue(base.GetType(TYPE_NAME)?.GetEnumNames()[1].ToLower() == "inprogress");
        }

        /// <summary>
        /// Vérifie que la troisième valeur soit done
        /// </summary>
        [TestMethod]
        public void SecondValueShouldBeDone()
        {
            Assert.IsTrue(base.GetType(TYPE_NAME)?.GetEnumNames()[2].ToLower() == "done");
        }

        /// <summary>
        /// Vérifie que la quatrième valeur soit archive
        /// </summary>
        [TestMethod]
        public void SecondValueShouldBeArchive()
        {
            Assert.IsTrue(base.GetType(TYPE_NAME)?.GetEnumNames()[3].ToLower() == "archive");
        }
    }
}
