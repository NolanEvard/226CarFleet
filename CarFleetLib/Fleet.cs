using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFleetLib
{
    public class Fleet
    {
        #region private attributes
        private string name;
        private string address;
        private string city;
        private string phoneNumber;
        private string email;
        private List<Car> cars;
        #endregion private attributes
        #region constructor
        public Fleet(string Name, string Address, string City, string PhoneNumber, string Email, List<Car> Cars = null)
        {
            name = Name;
            address = Address;
            city = City;
            phoneNumber = PhoneNumber;
            email = Email;
            cars = Cars;
        }
        #endregion constructor
        #region public methods
        public int DistanceAverageByDriver(int Cars)
        {
            int sumDist = 0;
            if (cars != null)
            {
                foreach (Car car in cars)
                {
                    sumDist += car.Distance();
                }
                 sumDist /= Cars;
            }
            return sumDist;
        }
        public List<string> GetDriversEmails()
        {
            List<string> listOfEmails = new List<string>();
            foreach (Car car in cars)
            {
                listOfEmails.Add(car.Driver.Mail);
            }
            return listOfEmails;
            //throw new NotImplementedException();
        }
        #endregion public methods
    }
}
