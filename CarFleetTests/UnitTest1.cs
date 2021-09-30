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
        List<Car> testCars = new List<Car>();
        Driver driver;
        Car car;
        Fleet fleet;

        [SetUp]
        public void Setup()
        {

            for(int i = 1; i<=10; i++)
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
            Assert.Pass();
        }

        [Test]
        public void Car_Distance_Success()
        {
            //given
            int expectedDistance = 0;
            //When
            int actualDistance = testCars[0].Distance();

            //Then
            Assert.AreEqual(expectedDistance, actualDistance);
        }
        [Test]
        public void Car_getCurrentMileage_Success()
        {
            //given
            int expectedMileage = 1;
            //when
            int actualMileage = testCars[0].CurrentMileage;
            //then
            Assert.AreEqual(expectedMileage, actualMileage);
        }
        [Test]
        public void Car_setCurrentMileage_Success()
        {
            //given
            int expectedMileage = 10;
            //when
            testCars[0].CurrentMileage = expectedMileage;
            //then
            Assert.AreEqual(expectedMileage, testCars[0].CurrentMileage);
        }
    }
}
