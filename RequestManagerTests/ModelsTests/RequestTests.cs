using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace RequestManagerTests.ModelsTests
{
    /// <summary>
    /// Tests de la classe modèle request
    /// </summary>
    [TestClass]
    public class RequestTests : AssemblyLoader
    {
        /// <summary>
        /// Nom de la classe
        /// </summary>
        private const string TYPE_NAME = "request";

        /// <summary>
        /// Liste des types de paramètres du constructeur
        /// </summary>
        private List<Type> _constructorTypes;

        public RequestTests()
        {
            _constructorTypes = new List<Type>() { typeof(int), typeof(string), typeof(string), typeof(DateTime), typeof(DateTime), base.GetType("status"), base.GetType("priority") };
        }

        /// <summary>
        /// Vérifie si le type existe
        /// </summary>
        [TestMethod]
        public void TypeExist()
        {
            Assert.IsNotNull(base.GetType(TYPE_NAME));
        }

        /// <summary>
        /// Vérifie si le constructeur existe avec les bon paramètres
        /// </summary>
        [TestMethod]
        public void ConstructorExist()
        {
            Assert.IsNotNull(base.GetConstructorByTypes(TYPE_NAME, _constructorTypes));
        }

        /// <summary>
        /// Vérifie si la propriété id existe
        /// </summary>
        [TestMethod]
        public void PropertyIdExist()
        {
            Assert.IsNotNull(base.GetProperty(TYPE_NAME, "id"));
        }

        /// <summary>
        /// Vérifie si la propriété id est de type int
        /// </summary>
        [TestMethod]
        public void PropertyIdIsTypeInt()
        {
            Assert.IsTrue(base.GetPropertyType(TYPE_NAME, "id") == typeof(int));
        }

        /// <summary>
        /// Vérifie si la propriété title existe
        /// </summary>
        [TestMethod]
        public void PropertyNameExist()
        {
            Assert.IsNotNull(base.GetProperty(TYPE_NAME, "title"));
        }

        /// <summary>
        /// Vérifie si la propriété title est de type string
        /// </summary>
        [TestMethod]
        public void PropertyNameIsTypeString()
        {
            Assert.IsTrue(base.GetPropertyType(TYPE_NAME, "title") == typeof(string));
        }

        /// <summary>
        /// Vérifie si la propriété description existe
        /// </summary>
        [TestMethod]
        public void PropertyDescriptionExist()
        {
            Assert.IsNotNull(base.GetProperty(TYPE_NAME, "description"));
        }

        /// <summary>
        /// Vérifie si la propriété description est de type string
        /// </summary>
        [TestMethod]
        public void PropertyDescriptionIsTypeString()
        {
            Assert.IsTrue(base.GetPropertyType(TYPE_NAME, "description") == typeof(string));
        }

        /// <summary>
        /// Vérifie si la propriété createdon existe
        /// </summary>
        [TestMethod]
        public void PropertyCreatedOnExist()
        {
            Assert.IsNotNull(base.GetProperty(TYPE_NAME, "createdon"));
        }

        /// <summary>
        /// Vérifie si la propriété createdon est de type string
        /// </summary>
        [TestMethod]
        public void PropertyCreatedOnIsTypeString()
        {
            Assert.IsTrue(base.GetPropertyType(TYPE_NAME, "createdon") == typeof(DateTime));
        }

        /// <summary>
        /// Vérifie si la propriété updatedon existe
        /// </summary>
        [TestMethod]
        public void PropertyUpdatedOnExist()
        {
            Assert.IsNotNull(base.GetProperty(TYPE_NAME, "updatedon"));
        }

        /// <summary>
        /// Vérifie si la propriété updatedon est de type string
        /// </summary>
        [TestMethod]
        public void PropertyUpdatedOnIsTypeString()
        {
            Assert.IsTrue(base.GetPropertyType(TYPE_NAME, "updatedon") == typeof(DateTime));
        }

        /// <summary>
        /// Vérifie si la propriété status existe
        /// </summary>
        [TestMethod]
        public void PropertyStatusExist()
        {
            Assert.IsNotNull(base.GetProperty(TYPE_NAME, "status"));
        }

        /// <summary>
        /// Vérifie si la propriété status est de type status
        /// </summary>
        [TestMethod]
        public void PropertyStatusIsTypeStatus()
        {
            Assert.IsTrue(base.GetPropertyType(TYPE_NAME, "status") == base.GetType("status"));
        }

        /// <summary>
        /// Vérifie si la propriété priority existe
        /// </summary>
        [TestMethod]
        public void PropertyPriorityExist()
        {
            Assert.IsNotNull(base.GetProperty(TYPE_NAME, "priority"));
        }

        /// <summary>
        /// Vérifie si la propriété priority est de type priority
        /// </summary>
        [TestMethod]
        public void PropertyPriorityIsTypePriority()
        {
            Assert.IsTrue(base.GetPropertyType(TYPE_NAME, "priority") == base.GetType("priority"));
        }

        /// <summary>
        /// Vérifie si la propriété id est correctement initialisée
        /// </summary>
        [TestMethod]
        public void PropertyIdCorrectlyInitialized()
        {
            int id = 1;
            var obj = base.GetConstructorByTypes(TYPE_NAME, _constructorTypes).Invoke(new object[] { id, "test", "test", DateTime.Now, DateTime.Now, null, null });
            Assert.IsTrue((int)GetPropertyValue(TYPE_NAME, "id", obj) == id);
        }

        /// <summary>
        /// Vérifie si la propriété title est correctement initialisée
        /// </summary>
        [TestMethod]
        public void PropertyTitleCorrectlyInitialized()
        {
            string title = "title";
            var obj = base.GetConstructorByTypes(TYPE_NAME, _constructorTypes).Invoke(new object[] { 1, title, "test", DateTime.Now, DateTime.Now, null, null });
            Assert.IsTrue(GetPropertyValue(TYPE_NAME, "title", obj).ToString() == title);
        }

        /// <summary>
        /// Vérifie si la propriété description est correctement initialisée
        /// </summary>
        [TestMethod]
        public void PropertyDescriptionCorrectlyInitialized()
        {
            string description = "description";
            var obj = base.GetConstructorByTypes(TYPE_NAME, _constructorTypes).Invoke(new object[] { 1, "test", description, DateTime.Now, DateTime.Now, null, null });
            Assert.IsTrue(GetPropertyValue(TYPE_NAME, "description", obj).ToString() == description);
        }

        /// <summary>
        /// Vérifie si la propriété createdon est correctement initialisée
        /// </summary>
        [TestMethod]
        public void PropertyCreatedOnCorrectlyInitialized()
        {
            DateTime createdOn = new DateTime(2020,12,18);
            var obj = base.GetConstructorByTypes(TYPE_NAME, _constructorTypes).Invoke(new object[] { 1, "test", "test", createdOn, DateTime.Now, null, null });
            Assert.IsTrue((DateTime)GetPropertyValue(TYPE_NAME, "createdon", obj) == createdOn);
        }

        /// <summary>
        /// Vérifie si la propriété updatedon est correctement initialisée
        /// </summary>
        [TestMethod]
        public void PropertyUpdatedOnCorrectlyInitialized()
        {
            DateTime updateOon = new DateTime(2020, 12, 18);
            var obj = base.GetConstructorByTypes(TYPE_NAME, _constructorTypes).Invoke(new object[] { 1, "test", "test", DateTime.Now, updateOon, null, null });
            Assert.IsTrue((DateTime)GetPropertyValue(TYPE_NAME, "updatedon", obj) == updateOon);
        }

        /// <summary>
        /// Vérifie si la propriété status est correctement initialisée
        /// </summary>
        [TestMethod]
        public void PropertyStatusCorrectlyInitialized()
        {
            var status = base.GetType("status").GetEnumValues().GetValue(0);
            var obj = base.GetConstructorByTypes(TYPE_NAME, _constructorTypes).Invoke(new object[] { 1, "test", "test", DateTime.Now, DateTime.Now, status, null });
            Assert.IsTrue(GetPropertyValue(TYPE_NAME, "status", obj).ToString() == status.ToString());
        }

        /// <summary>
        /// Vérifie si la propriété priority est correctement initialisée
        /// </summary>
        [TestMethod]
        public void PropertyPriorityCorrectlyInitialized()
        {
            var priority = base.GetType("priority").GetEnumValues().GetValue(0);
            var obj = base.GetConstructorByTypes(TYPE_NAME, _constructorTypes).Invoke(new object[] { 1, "test", "test", DateTime.Now, DateTime.Now, null, priority });
            Assert.IsTrue(GetPropertyValue(TYPE_NAME, "priority", obj).ToString() == priority.ToString());
        }
    }
}
