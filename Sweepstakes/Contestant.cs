using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Contestant
    {
        public string firstName;
        public string lastName;
        public string name;
        private string email;
        private string registrationNumber;

        public Contestant( string firstName, string lastName, string email, string registrationNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.registrationNumber = registrationNumber;
        }

        public void AddContestant()
        {
            Dictionary<int, Contestant> SweepstakesList = new Dictionary<int, Contestant>();
        }


        public void Name()
        {
            string name = firstName + " " + lastName;
        }


        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }

        }

        //public int RegistrationNumber
        public string RegistrationNumber
        {
            get
            {
                return registrationNumber;
            }
            set
            {
                registrationNumber = value;
            }
        }

        

   
    }
}
