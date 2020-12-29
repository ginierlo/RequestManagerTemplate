using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace RequestManagerTests.ControllersTests
{
    [TestClass]
    public class RequestControllertests : AssemblyLoader
    {
        private const string TYPE_NAME = "requestcontroller";

        /// <summary>
        /// Vérifie si le type existe
        /// </summary>
        [TestMethod]
        public void TypeExist()
        {
            Assert.IsNotNull(base.GetType(TYPE_NAME));
        }

        /// <summary>
        /// Vérifie que le type contienne une méthode nommée create
        /// </summary>
        [TestMethod]
        public void TypeContainsMethodCreate()
        {
            Assert.IsNotNull(base.GetMethod(TYPE_NAME, "create"));
        }

        /// <summary>
        /// Vérifie que la méthode create retourne un type void
        /// </summary>
        [TestMethod]
        public void MethodCreateReturnTypeIsVoid()
        {
            Assert.IsTrue(base.GetMethod(TYPE_NAME, "create")?.ReturnType == typeof(void));
        }

        /// <summary>
        /// Vérifie que la méthode create contienne seulement 5 paramètre
        /// </summary>
        [TestMethod]
        public void MethodCreateContainsFiveParameter()
        {
            Assert.IsTrue(base.GetMethodParameters(TYPE_NAME, "create").Count == 6);
        }

        /// <summary>
        /// Vérifie que la méthode create ait les bons types de paramètres
        /// </summary>
        [TestMethod]
        public void MethodCreateHasRightParametersTypes()
        {
            bool check = true;
            var rightTypes = new List<Type>() { typeof(string), typeof(string), typeof(DateTime), typeof(DateTime), base.GetType("status"), base.GetType("priority") };
            var paramTypes = base.GetMethodParametersTypes(TYPE_NAME, "create");

            for (int i = 0; i < rightTypes.Count; i++)
            {
                if (rightTypes[i] != paramTypes[i])
                    check = false;
            }
            Assert.IsTrue(check);
        }

        /// <summary>
        /// Vérifie que le type contienne une méthode nommée getbyid
        /// </summary>
        [TestMethod]
        public void TypeContainsMethodGetById()
        {
            Assert.IsNotNull(base.GetMethod(TYPE_NAME, "getbyid"));
        }

        /// <summary>
        /// Vérifie que la méthode getbyid retourne un type request
        /// </summary>
        [TestMethod]
        public void MethodGetByIdReturnTypeIsRequest()
        {
            Assert.IsTrue(base.GetMethod(TYPE_NAME, "getbyid")?.ReturnType == base.GetType("request"));
        }

        /// <summary>
        /// Vérifie que la méthode getbyid contienne 1 paramètre
        /// </summary>
        [TestMethod]
        public void MethodGetByIdContainsOneParameter()
        {
            Assert.IsTrue(base.GetMethodParameters(TYPE_NAME, "getbyid").Count == 1);
        }

        /// <summary>
        /// Vérifie que la méthode getbyid ait les bons types de paramètres
        /// </summary>
        [TestMethod]
        public void MethodGetByIdHasRightParametersTypes()
        {
            bool check = true;
            var rightTypes = new List<Type>() { typeof(int) };
            var paramTypes = base.GetMethodParametersTypes(TYPE_NAME, "getbyid");

            for (int i = 0; i < rightTypes.Count; i++)
            {
                if (rightTypes[i] != paramTypes[i])
                    check = false;
            }
            Assert.IsTrue(check);
        }

        /// <summary>
        /// Vérifie que le type contienne une méthode nommée getbystatusorderbypriority
        /// </summary>
        [TestMethod]
        public void TypeContainsMethodGetByStatusOrderByPriority()
        {
            Assert.IsNotNull(base.GetMethod(TYPE_NAME, "getbystatusorderbypriority"));
        }

        /// <summary>
        /// Vérifie que la méthode getbystatusorderbypriority retourne un type request
        /// </summary>
        [TestMethod]
        public void MethodGetByStatusOrderByPriorityReturnTypeIsListOfBrand()
        {
            Assert.IsTrue(base.GetMethod(TYPE_NAME, "getbystatusorderbypriority")?.ReturnType.ToString().Contains($"List`1[{base.GetType("request").FullName}]") ?? false);
        }

        /// <summary>
        /// Vérifie que la méthode getbystatusorderbypriority contienne 1 paramètre
        /// </summary>
        [TestMethod]
        public void MethodGetByStatusOrderByPriorityContainsOneParameter()
        {
            Assert.IsTrue(base.GetMethodParameters(TYPE_NAME, "getbystatusorderbypriority").Count == 1);
        }

        /// <summary>
        /// Vérifie que la méthode getbystatusorderbypriority ait les bons types de paramètres
        /// </summary>
        [TestMethod]
        public void MethodGetByStatusOrderByPrioritydHasRightParametersTypes()
        {
            bool check = true;
            var rightTypes = new List<Type>() { base.GetType("status") };
            var paramTypes = base.GetMethodParametersTypes(TYPE_NAME, "getbystatusorderbypriority");

            for (int i = 0; i < rightTypes.Count; i++)
            {
                if (rightTypes[i] != paramTypes[i])
                    check = false;
            }
            Assert.IsTrue(check);
        }

        /// <summary>
        /// Vérifie que le type contienne une méthode nommée update
        /// </summary>
        [TestMethod]
        public void TypeContainsMethodUpdate()
        {
            Assert.IsNotNull(base.GetMethod(TYPE_NAME, "update"));
        }

        /// <summary>
        /// Vérifie que la méthode update retourne un type void
        /// </summary>
        [TestMethod]
        public void MethodUpdateReturnTypeIsVoid()
        {
            Assert.IsTrue(base.GetMethod(TYPE_NAME, "update")?.ReturnType == typeof(void));
        }

        /// <summary>
        /// Vérifie que la méthode update contienne seulement 7 paramètre
        /// </summary>
        [TestMethod]
        public void MethodUpdateContainsSevenParameter()
        {
            Assert.IsTrue(base.GetMethodParameters(TYPE_NAME, "update").Count == 7);
        }

        /// <summary>
        /// Vérifie que la méthode update ait les bons types de paramètres
        /// </summary>
        [TestMethod]
        public void MethodUpdateHasRightParametersTypes()
        {
            bool check = true;
            var rightTypes = new List<Type>() { typeof(int), typeof(string), typeof(string), typeof(DateTime), typeof(DateTime), base.GetType("status"), base.GetType("priority") };
            var paramTypes = base.GetMethodParametersTypes(TYPE_NAME, "update");

            for (int i = 0; i < rightTypes.Count; i++)
            {
                if (rightTypes[i] != paramTypes[i])
                    check = false;
            }
            Assert.IsTrue(check);
        }

        /// <summary>
        /// Vérifie que le type contienne une méthode nommée delete
        /// </summary>
        [TestMethod]
        public void TypeContainsMethodDelete()
        {
            Assert.IsNotNull(base.GetMethod(TYPE_NAME, "delete"));
        }

        /// <summary>
        /// Vérifie que la méthode delete retourne un type void
        /// </summary>
        [TestMethod]
        public void MethodDeleteReturnTypeIsVoid()
        {
            Assert.IsTrue(base.GetMethod(TYPE_NAME, "delete")?.ReturnType == typeof(void));
        }

        /// <summary>
        /// Vérifie que la méthode delete contienne seulement 1 paramètre
        /// </summary>
        [TestMethod]
        public void MethodDeleteContainsOneParameter()
        {
            Assert.IsTrue(base.GetMethodParameters(TYPE_NAME, "delete").Count == 1);
        }

        /// <summary>
        /// Vérifie que la méthode delete ait les bons types de paramètres
        /// </summary>
        [TestMethod]
        public void MethodDeleteHasRightParametersTypes()
        {
            bool check = true;
            var rightTypes = new List<Type>() { typeof(int) };
            var paramTypes = base.GetMethodParametersTypes(TYPE_NAME, "delete");

            for (int i = 0; i < rightTypes.Count; i++)
            {
                if (rightTypes[i] != paramTypes[i])
                    check = false;
            }
            Assert.IsTrue(check);
        }

        /// <summary>
        /// Vérifie qu'arpès l'appel de la méthode create, la liste contient 1 élément
        /// </summary>
        [TestMethod]
        public void InvokeMethodCreateShouldAddOneElementToList()
        {
            //Création d'une instance du controller
            var controller = Activator.CreateInstance(base.GetType(TYPE_NAME));

            //Appel de la méthode create
            base.GetMethod(TYPE_NAME, "create").Invoke(controller, new object[] { "test", "test", DateTime.Now, DateTime.Now, null, null });

            //récupération des valeurs de la liste
            var list = base.GetPrivateRuntimeField(TYPE_NAME, "requests").GetValue(controller);

            Assert.IsTrue(((IEnumerable<object>)list).Count() == 1);
        }

        /// <summary>
        /// Vérifie qu'arpès l'ajout de 2 éléments le 2ème ait l'id 2
        /// </summary>
        [TestMethod]
        public void Create2ElementsShouldIncrementId()
        {
            //Création d'une instance du controller
            var controller = Activator.CreateInstance(base.GetType(TYPE_NAME));

            //Appel de la méthode create
            base.GetMethod(TYPE_NAME, "create").Invoke(controller, new object[] { "test", "test", DateTime.Now, DateTime.Now, null, null });
            base.GetMethod(TYPE_NAME, "create").Invoke(controller, new object[] { "test", "test", DateTime.Now, DateTime.Now, null, null });

            //récupération des valeurs de la liste
            var list = base.GetPrivateRuntimeField(TYPE_NAME, "requests").GetValue(controller);

            //Récuipère le dernier élément de la liste
            var lastElement = ((IEnumerable<object>)list).Last();

            Assert.IsTrue((int)base.GetProperty(lastElement.GetType(), "id").GetValue(lastElement) == 2);
        }

        /// <summary>
        /// Vérifie que la supression d'un élément existant fonctionne
        /// </summary>
        [TestMethod]
        public void DeleteExistingElementShouldReturnEmptyList()
        {
            int id = 1;

            //Création d'une instance du controller
            var controller = Activator.CreateInstance(base.GetType(TYPE_NAME));

            //creattion d'une instance de liste de demandes
            var listType = typeof(List<>);
            var listRequests = listType.MakeGenericType(GetType("request"));
            var listInstance = Activator.CreateInstance(listRequests);

            //Création d'une demande
            var request = CreateTestRequest(id, "test", "test", DateTime.Now, DateTime.Now, null, null);

            //Ajout de la demande test à la liste
            ((IList)listInstance).Add(request);

            //définit les valeurs de la liste
            base.GetPrivateRuntimeField(TYPE_NAME, "requests").SetValue(controller, listInstance);

            //Appel de la méthode
            base.GetMethod(TYPE_NAME, "delete").Invoke(controller, new object[] { id });

            //récupération des valeurs de la liste
            var list = base.GetPrivateRuntimeField(TYPE_NAME, "requests").GetValue(controller);

            Assert.IsTrue(((IEnumerable<object>)list).Count() == 0);
        }

        /// <summary>
        /// Vérifie qu'une exception est lancée après l'appel de la méthode delete avec un id inexistant
        /// </summary>
        [TestMethod]
        public void DeleteNonExistingElementShouldThrowException()
        {
            int id = 1;
            //Création d'une instance du controller
            var controller = Activator.CreateInstance(base.GetType(TYPE_NAME));

            try
            {
                //Appel de la méthode
                base.GetMethod(TYPE_NAME, "delete").Invoke(controller, new object[] { id });
            }
            catch (Exception ex)
            {
                // récupère l'exception
                Assert.IsTrue(ex.InnerException.GetType() == typeof(Exception));
                return;
            }

            //pas d'exception, le test échoue
            Assert.Fail();
        }

        /// <summary>
        /// Modification de l'élément avec id existant est bien effectuée
        /// </summary>
        [TestMethod]
        public void UpdateElementWithExistingIdShouldBeEffective()
        {
            int id = 1;

            //Création d'une instance du controller
            var controller = Activator.CreateInstance(base.GetType(TYPE_NAME));

            //creattion d'une instance de liste de demandes
            var listType = typeof(List<>);
            var listRequests = listType.MakeGenericType(GetType("request"));
            var listInstance = Activator.CreateInstance(listRequests);

            //Création d'une demande
            var request = CreateTestRequest(id, "test", "test", DateTime.Now, DateTime.Now, null, null);

            //Ajout de la demande test à la liste
            ((IList)listInstance).Add(request);

            //définit les valeurs de la liste
            base.GetPrivateRuntimeField(TYPE_NAME, "requests").SetValue(controller, listInstance);

            base.GetMethod(TYPE_NAME, "update").Invoke(controller, new object[] { 1, "test2", "test2", DateTime.Now, DateTime.Now, null, null });

            //récupération des valeurs de la liste
            var list = base.GetPrivateRuntimeField(TYPE_NAME, "requests").GetValue(controller);

            var lastElement = ((IEnumerable<object>)list).Last();

            Assert.IsTrue(base.GetProperty(lastElement.GetType(), "title").GetValue(lastElement).ToString() == "test2");
        }

        /// <summary>
        /// Vérifie qu'une exception est lancée après l'appel de la méthode update avec un id inexistant
        /// </summary>
        [TestMethod]
        public void UpdateElementWithNonExistingIdShouldThrowException()
        {
            int id = 1;
            //Création d'une instance du controller
            var controller = Activator.CreateInstance(base.GetType(TYPE_NAME));

            try
            {
                //Appel de la méthode
                base.GetMethod(TYPE_NAME, "update").Invoke(controller, new object[] { id, "test2", "test2", DateTime.Now, DateTime.Now, null, null });
            }
            catch (Exception ex)
            {
                // récupère l'exception
                Assert.IsTrue(ex.InnerException.GetType() == typeof(Exception));
                return;
            }

            //pas d'exception, le test échoue
            Assert.Fail();
        }

        /// <summary>
        /// Vérifie que la méthode getbyid avec un id de demande existante retourne une demande
        /// </summary>
        [TestMethod]
        public void GetByIdShouldReturnARequest()
        {
            int id = 1;

            //Création d'une instance du controller
            var controller = Activator.CreateInstance(base.GetType(TYPE_NAME));

            //creattion d'une instance de liste de demandes
            var listType = typeof(List<>);
            var listRequests = listType.MakeGenericType(GetType("request"));
            var listInstance = Activator.CreateInstance(listRequests);

            //Création d'une demande
            var request = CreateTestRequest(id, "test", "test", DateTime.Now, DateTime.Now, null, null);

            //Ajout de la demande test à la liste
            ((IList)listInstance).Add(request);

            //définit les valeurs de la liste
            base.GetPrivateRuntimeField(TYPE_NAME, "requests").SetValue(controller, listInstance);

            //Appel de la méthode
            Assert.IsNotNull(base.GetMethod(TYPE_NAME, "getbyid").Invoke(controller, new object[] { id }));
        }

        /// <summary>
        /// Vérifie que la méthode getbyid avec un id de demande inexistant retourne null
        /// </summary>
        [TestMethod]
        public void GetByIdShouldReturnNull()
        {
            int id = 1;

            //Création d'une instance du controller
            var controller = Activator.CreateInstance(base.GetType(TYPE_NAME));

            //Appel de la méthode
            Assert.IsNull(base.GetMethod(TYPE_NAME, "getbyid").Invoke(controller, new object[] { id }));
        }

        /// <summary>
        /// Vérifie que la méthode getbystatusorderbypriority avec 0 demande dans la liste doit retourner une liste vide
        /// </summary>
        [TestMethod]
        public void GetBystatusOrderByPriorityShouldReturnAnEmptyList()
        {
            var status = base.GetType("status").GetEnumValues().GetValue(0);

            //Création d'une instance du controller
            var controller = Activator.CreateInstance(base.GetType(TYPE_NAME));

            //Appel de la méthode
            var list = base.GetMethod(TYPE_NAME, "getbystatusorderbypriority").Invoke(controller, new object[] { status });

            Assert.IsTrue(((IEnumerable<object>)list).Count() == 0);
        }

        /// <summary>
        /// Vérifie que la méthode getbystatusorderbypriority avec 2 demandes qui ont un statut différent doit retourner une liste contenant 1 éléments
        /// </summary>
        [TestMethod]
        public void GetBystatusOrderByPriorityShouldReturnAListWithOneElement()
        {
            var status = base.GetType("status").GetEnumValues().GetValue(0);
            var status2 = base.GetType("status").GetEnumValues().GetValue(1);

            //Création d'une instance du controller
            var controller = Activator.CreateInstance(base.GetType(TYPE_NAME));

            //creattion d'une instance de liste de demandes
            var listType = typeof(List<>);
            var listRequests = listType.MakeGenericType(GetType("request"));
            var listInstance = Activator.CreateInstance(listRequests);

            //Création de 2 demandes avec statuts différents
            var request = CreateTestRequest(1, "test", "test", DateTime.Now, DateTime.Now, status, null);
            var request2 = CreateTestRequest(1, "test", "test", DateTime.Now, DateTime.Now, status2, null);

            //Ajout des demandes test à la liste
            ((IList)listInstance).Add(request);
            ((IList)listInstance).Add(request2);

            //définit les valeurs de la liste
            base.GetPrivateRuntimeField(TYPE_NAME, "requests").SetValue(controller, listInstance);

            //Appel de la méthode
            var list = base.GetMethod(TYPE_NAME, "getbystatusorderbypriority").Invoke(controller, new object[] { status });

            Assert.IsTrue(((IEnumerable<object>)list).Count() == 1);
        }

        /// <summary>
        /// Vérifie que la méthode getbystatusorderbypriority avec 2 demandes qui ont le même statut doit retourner une liste contenant 2 éléments et ordrer par priorités (du plus prioritaire au moins prioritaire)
        /// </summary>
        [TestMethod]
        public void GetBystatusOrderByPriorityShouldReturnAListWithTwoElementsOrdered()
        {
            var status = base.GetType("status").GetEnumValues().GetValue(0);

            var priorityLow = base.GetType("priority").GetEnumValues().GetValue(0);
            var priorityHigh = base.GetType("priority").GetEnumValues().GetValue(2);

            //Création d'une instance du controller
            var controller = Activator.CreateInstance(base.GetType(TYPE_NAME));

            //creattion d'une instance de liste de demandes
            var listType = typeof(List<>);
            var listRequests = listType.MakeGenericType(GetType("request"));
            var listInstance = Activator.CreateInstance(listRequests);

            //Création de 2 demandes avec même statut
            var request = CreateTestRequest(1, "test", "test", DateTime.Now, DateTime.Now, status, priorityLow);
            var request2 = CreateTestRequest(1, "test", "test", DateTime.Now, DateTime.Now, status, priorityHigh);

            //Ajout des demandes test à la liste
            ((IList)listInstance).Add(request);
            ((IList)listInstance).Add(request2);

            //définit les valeurs de la liste
            base.GetPrivateRuntimeField(TYPE_NAME, "requests").SetValue(controller, listInstance);

            //Appel de la méthode
            var list = base.GetMethod(TYPE_NAME, "getbystatusorderbypriority").Invoke(controller, new object[] { status });

            var firstElement = ((IEnumerable<object>)list).First();
            var lastElement = ((IEnumerable<object>)list).Last();

            Assert.IsTrue(((IEnumerable<object>)list).Count() == 2);
            Assert.IsTrue(base.GetProperty(firstElement.GetType(), "priority").GetValue(firstElement).ToString() == priorityHigh.ToString());
            Assert.IsTrue(base.GetProperty(lastElement.GetType(), "priority").GetValue(lastElement).ToString() == priorityLow.ToString());
        }

        /// <summary>
        /// Création d'une demande test
        /// </summary>
        /// <param name="parameters">Tableau des valeur de la demande</param>
        /// <returns>Une demande</returns>
        private object CreateTestRequest(params object[] parameters)
        {
            return base.GetConstructorByTypes("request", new List<Type>() { typeof(int), typeof(string), typeof(string), typeof(DateTime), typeof(DateTime), base.GetType("status"), base.GetType("priority") })
                .Invoke(new object[] { parameters[0], parameters[1], parameters[2], parameters[3], parameters[4], parameters[5], parameters[6] });
        }
    }
}
