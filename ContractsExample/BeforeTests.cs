using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ContractsExample
{
    [TestClass]
    public class BeforeTests
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

        public string GetFullName(string firstName, string lastName)
        {
            if (firstName == null)
                throw new ArgumentNullException();

            if (lastName == null)
                throw new ArgumentNullException();

            return firstName + " " + lastName;
        }
    }
}
