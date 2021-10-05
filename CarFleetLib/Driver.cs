using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFleetLib
{
    public class Driver
    {
        #region private attributes
        private string firstname;
        private string lastname;
        private string phoneNumber;
        private string mail;
        private string language;
        private string workingArea;
        #endregion private attributes
        #region constructor
        public Driver(string Firstname, string Lastname, string PhoneNumber, string Mail, string Language = "", string WorkingArea = "")
        {
            firstname = Firstname;
            lastname = Lastname;
            phoneNumber = PhoneNumber;
            mail = Mail;
            language = Language;
            workingArea = WorkingArea;
        }
        #endregion constructor
        #region properties
        public string Mail
        {
            get
            {
                return mail;
            }
        }
        #endregion properties
    }
}
