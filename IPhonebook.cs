using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace PhoneBook2
{
    interface IPhonebook
    {
       
        void Add( User user);
        void RemoveUser(User user);
        User RetrieveByPersonalId(User user);
        string ToString();
        void UpdateUser(User user);

    }
}
