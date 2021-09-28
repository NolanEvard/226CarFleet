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
        public Car(string registration, string brand, string model, string chassisNumber, int initialMileage, Driver driver)
        {

        }
        #endregion constructor
        #region properties
        public int CurrentMileage
        {
            get
            {
                return currentMileage;
            }
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
    }
}
