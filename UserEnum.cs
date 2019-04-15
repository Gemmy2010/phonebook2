using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace PhoneBook2
{
    public class UserEnum:User
    {
        Hashtable adressBook = new Hashtable();
        int personalId = 0;

        

        //Constructor
        public UserEnum(IEnumerable adressBook)
        {
            adressBook = null;
        }

        // Accessing the next item in the list.

        public object MoveNext
        {
            get
            {
                personalId += 1;

                if (IsDone == false)
                {
                    return adressBook[personalId];
                }
                else
                {
                    return null;
                }
            }
        }


        // Accessing the current item in the list.

        public object CurrentItem
        {
            get
            {
                return adressBook[personalId];
            }
        }


        // Reaching the end of the list.

        public bool IsDone
        {
            get
            {
                if (personalId < adressBook.Count)
                {
                    return false;
                }
                return true;
            }
        }
       

        
    }
}
