using System;

namespace CarFleetLib
{
    public class Car
    {
        #region private attributes
        private string registration;
        private string brand;
        private string model;
        private string chassisNumber;
        private int currentMileage;
        private int initialMileage;
        private Driver driver;
        #endregion private attributes
        #region constructor
        public Car(string Registration, string Brand, string Model, string ChassisNumber, int InitialMileage, Driver Driver = null)
        {
            initialMileage = InitialMileage;
            currentMileage = initialMileage;
            driver = Driver;
            registration = Registration;
            brand = Brand;
            model = Model;
            chassisNumber = ChassisNumber;
        }
        #endregion constructor
        #region properties
        public int CurrentMileage
        {
            set
            {
                currentMileage = value;
            }
        }
        public Driver Driver
        {
            get
            {
                return driver;
            }
            set
            {
                driver = value;
            }
        }
        #endregion properties
        #region public methods
        public int Distance()
        {
            return initialMileage - currentMileage;
        }
        #endregion public methods
    }
}
