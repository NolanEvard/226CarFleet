using System;

namespace CarFleetLib
{
    public class Car
    {
        #region private attributes
        private string _registration;
        private string _brand;
        private string _model;
        private string _chassisNumber;
        private int mileage;
        private Driver driver;
        #endregion private attributes
        #region constructor
        public Car(string registration, string brand, string model, string chassisNumber, int mileage, Driver driver)
        {

        }
        #endregion constructor
    }
}
