using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PostSharp.Patterns.Contracts;

namespace ContractsExample
{
    [TestClass]
    public class AfterTests
    {
        [TestMethod]
        public void TestGetFullNameValid()
        {
            var firstName = "Joe";
            var lastName = "Bloggs";
            var result = GetFullName(firstName, lastName);
            Assert.AreEqual(result, "Joe Bloggs");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestGetFullNameWithNullFirstName()
        {
            var lastName = "Bloggs";
            GetFullName(null, lastName);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestGetFullNameWithNullLastName()
        {
            var firstName = "Joe";
            GetFullName(firstName, null);
        }

        public string GetFullName([NotNull] string firstName,[NotNull] string lastName)
        {
            return firstName + " " + lastName;
        }
    }
}
