using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace PhoneBook2
{
    public class AdressBook:User,IPhonebook
    {
        public Hashtable adressBook = new Hashtable();
        public int GetNumberOfEntries()
        {
            return adressBook.Count;
        }


        public void Add( User user)
        {
            if (!adressBook.Contains(user.PersonalId))
                //Console.WriteLine("This personalid already exists!");
                adressBook.Add(user.PersonalId, user);
            Console.WriteLine("User {0} added succesfully: " + user);

        }


        public User RetrieveByPersonalId(User user)
        {
            if (!adressBook.Contains(user.PersonalId))
                Console.WriteLine("This user doesn't exist!");
            Console.WriteLine(user);
            return (user);
        }
        public void UpdateUser(User user)
        {
            if (!adressBook.Contains(user.PersonalId))
                Console.WriteLine("This user already exists!");
            Console.WriteLine("user {1} has been updated" + user.PersonalId);
        }
        public void RemoveUser(User user)
        {
            if (!adressBook.Contains(user.PersonalId))
                Console.WriteLine("This user does not exist!");
            adressBook.Remove(user.PersonalId);
            Console.WriteLine("user {1} has been deleted" + user.PersonalId);
        }

        public List<User> SearchByPersonalId(User user)
        {
            List<User> userList = new List<User>();
            foreach (User u in adressBook.Values)
            {
                if (user.PersonalId == u.PersonalId)
                    userList.Add(u);
            }
            return userList;
        }
        // getting access to Enumerator
        public interface IEnumerable
        {
            IEnumerator GetEnumerator();
        }        public interface IEnumerator
        {

            object Current { get; }
            bool MoveNext();
            bool IsDone();
            void Reset();
        }


    }
}
