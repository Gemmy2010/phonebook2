using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace PhoneBook2
{
    class Program
    {
        static void Main(string[] args)
        {

          
            Hashtable adressBook = new Hashtable();
            adressBook.Add(1, "Vilma michael,uppsala,0754563254");
            adressBook.Add(2, "Sara Mimki, Mälmo, 0754546788");
            adressBook.Add(3, "Ivy Toto, Stockholm, 0754987653");


            

            //Delete User
            adressBook.Remove("Vilma michael,uppsala,0754563254");
           

            // print the number of entries in a hashtable
            Console.WriteLine("The total number of entries:" + adressBook.Count);
            //searches
            Console.WriteLine(adressBook.Contains(1));


            IDictionaryEnumerator denum = adressBook.GetEnumerator();
            DictionaryEntry dentry;
            

            Console.WriteLine();
            Console.WriteLine("    PersonalId       Users");
            Console.WriteLine("    -----------------------------");
                while (denum.MoveNext())
                {
                    dentry = (DictionaryEntry)denum.Current;
                    Console.WriteLine("    {0,-17}{1}", dentry.Key, dentry.Value);

                    Console.WriteLine();
                    Console.ReadLine();


                }



        }
        

    }

    
}
/* IndividualUser indivUser = new IndividualUser();
            indivUser.PersonalId = 1;
            indivUser.FirstName = "jemima";
            indivUser.LastName = "Osoro";
            indivUser.Adress = "stockholm";
            indivUser.PhoneNumber = "073456786";

            Console.WriteLine(indivUser);
            Console.ReadLine();
*/