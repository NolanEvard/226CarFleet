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
        public Driver(string firstname, string lastname, string phoneNumber, string mail, string language = "", string workingArea = "")
        {

        }
        #endregion constructor
    }
}
