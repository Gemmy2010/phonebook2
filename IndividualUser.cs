using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook2
{
    public class IndividualUser:User
    {
        public string BirthDate { get; set; }
        public IndividualUser() : base()
        {
            this.BirthDate = null;
        }

        public override string ToString()
        {
            return base.ToString() + "BirthDate:" + this;
        }

    }
}
