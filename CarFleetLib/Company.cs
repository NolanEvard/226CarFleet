using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFleetLib
{
    public class Company
    {
        #region private attributes
        private string name;
        private string address;
        private string city;
        private string phoneNumber;
        private string email;
        private List<Car> cars;
        private List<Driver> drivers;
        #endregion private attributes
        #region constructor
        public Company(string name, string address, string city, string phoneNumber, string email, List<Car> cars = null, List<Driver> drivers = null)
        {

        }
        #endregion constructor
    }
}
