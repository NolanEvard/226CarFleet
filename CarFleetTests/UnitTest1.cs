using NUnit.Framework;
using CarFleetLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFleetTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            List<Car> testCars = new List<Car>();
            for(int i = 0; i<=10; i++)
            {
                Driver driver = new Driver("firstname" + i.ToString(), "lastname" + i.ToString(), "phoneNumber" + i.ToString(), "mail" + i.ToString());
                Car car = new Car("vd" + i.ToString(), "brand" +i.ToString(), "model" + i.ToString(), "chassisNumber" + i.ToString(), i, driver);
                testCars.Add(car);
            }
            Fleet fleet = new Fleet("testFleet", "testAddress", "testCity", "+41454565654", "test.email@example.com");
        }

        [Test]
        public void Fleet_TestAverageDistanceByDriver_Success()
        {
            
        }
    }
}