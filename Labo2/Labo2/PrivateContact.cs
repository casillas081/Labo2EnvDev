using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo2
{
    public class PrivateContact : Person
    {
        private int numTelPrivate;

        public int NumTelPrivate { get => numTelPrivate; set => numTelPrivate = value; }

        private string mailPrivate;

        public string MailPrivate
        {
            get { return mailPrivate; }
            set { mailPrivate = value; }
        }

        private DateTime birthday;

        public DateTime Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }


        public PrivateContact(string name, string firstName, int numTelPrivate, string mailPrivate, DateTime birthday) : base(name, firstName)
        {
            NumTelPrivate = numTelPrivate;
            MailPrivate = mailPrivate;
            Birthday = birthday;
        }

        public PrivateContact(string name, string firstName, int numTelPrivate, string mailPrivate) : base (name, firstName)
        {
            NumTelPrivate = numTelPrivate;
            MailPrivate = mailPrivate;
        }

        public override string ToString()
        {
            string output = base.ToString() + "( " + NumTelPrivate + " )\n" + MailPrivate;
            if (HasHisBirthday())
            {
                output += " Bon anniversaire !";
            }
            return output;
        }

        public override bool HasHisBirthday()
        {
            if(Birthday.Month == DateTime.Today.Month && Birthday.Day == DateTime.Today.Day)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
