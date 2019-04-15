using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PhoneBook2;

namespace Phonebook2.Unittests
{
    [TestClass]
    public class adressBooktests
    {

        public void adressBookHasNoEntriesAtStart()
        {
            AdressBook  adressBook = new AdressBook();
            Assert.AreEqual(0, adressBook.GetNumberOfEntries(), "No entries ");
        }
        [TestMethod]
        public void AddEntry()
        {
            AdressBook adressbook = new AdressBook();
            adressbook.Add(user.personalid,user);
        }
        
        /*[TestMethod]
        public void UserAlreadyExists()
        {
            AdressBook adressBook = new AdressBook();
            Assert.ThrowsException(() => adressBook.Add(personalid,User.Equals));
        }

        [TestMethod]
        public void Adduser_UserAlreadyExists_ThrowException()
        {
            //Arrange
        var adressBook = new AdressBook();
        //Act
        adressBook.Add(new User();
        //Assert
        Assert.ThrowsException<ArgumentNullException>(() => adressBook.personalid));
        }
        [TestMethod]
        public void AddedEntryMaintainsValue()
        {
            AdressBook adressBook = new AdressBook();
            adressBook.Add("1", "Mary Peter");
            string number = adressBook.GetNumberFor("Mary peter");
            Assert.AreEqual("555", number, "Saved number is returned correctly.");
        }*/


    }
}
