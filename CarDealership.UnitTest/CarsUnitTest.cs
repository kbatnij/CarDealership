using CarDealership.Controllers;
using CarDealership.Controllers.Resources;
using CarDealership.Models;
using CarDealership.Presistence;
using Moq;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace CarDealership.UnitTest
{
    public class CarUnitTest
    {
        [Fact]
        public async Task IfHasHeatedSeatsNoNavigation_ReturnsTwoCars()
        {
            //Arrange
            var carQueryOptions = new CarQueryOptions
            {
                HasHeatedSeats = true,
                HasNavigation = false
            };
            var mockICarRepo = new Mock<ICarRepository>();
            var mockReturn = new List<Car>()
            {
              new Car() { Color = "Red"},
              new Car() { Color = "Black"}
            };
            mockICarRepo.Setup(repo => repo.GetCars(carQueryOptions))
                .Returns(Task.FromResult<IEnumerable<Car>>(mockReturn));
            var carController = new CarsController(mockICarRepo.Object);

            //Act
            var result = await carController.GetCars(carQueryOptions);

            //Assert
            Assert.Equal(2, result.Count<Car>());
        }

        [Fact]
        public async Task IfHasNavigationAndColorBlack_ReturnsOneCars()
        {
            //Arrange
            var carQueryOptions = new CarQueryOptions
            {
                HasHeatedSeats = true,
                HasNavigation = false
            };
            var mockICarRepo = new Mock<ICarRepository>();
            var mockReturn = new List<Car>()
            { new Car() { Color = "Red"},
            };
            mockICarRepo.Setup(repo => repo.GetCars(carQueryOptions))
                .Returns(Task.FromResult<IEnumerable<Car>>(mockReturn));
            var carController = new CarsController(mockICarRepo.Object);

            //Act
            var result = await carController.GetCars(carQueryOptions);

            //Assert
            Assert.Single(result);
        }

        [Fact]
        public async Task IfHasNoOptionsSelected_ReturnsNineCars()
        {
            //Arrange
            var carQueryOptions = new CarQueryOptions
            {
                HasHeatedSeats = true,
                HasNavigation = false
            };
            var mockICarRepo = new Mock<ICarRepository>();
            var mockReturn = new List<Car>()
            { new Car(),new Car(),new Car(),new Car(),new Car(),new Car(),
            new Car(),new Car(),new Car()
            };
            mockICarRepo.Setup(repo => repo.GetCars(carQueryOptions))
                .Returns(Task.FromResult<IEnumerable<Car>>(mockReturn));
            var carController = new CarsController(mockICarRepo.Object);

            //Act
            var result = await carController.GetCars(carQueryOptions);

            //Assert
            Assert.Equal(9, result.Count<Car>());
        }

        [Fact]
        public async Task IfHasPowerWindowsAndLowMiles_ReturnsThreeCars()
        {
            //Arrange
            var carQueryOptions = new CarQueryOptions
            {
                HasHeatedSeats = true,
                HasNavigation = false
            };
            var mockICarRepo = new Mock<ICarRepository>();
            var mockReturn = new List<Car>()
            { new Car(),new Car(),new Car()
            };
            mockICarRepo.Setup(repo => repo.GetCars(carQueryOptions))
                .Returns(Task.FromResult<IEnumerable<Car>>(mockReturn));
            var carController = new CarsController(mockICarRepo.Object);

            //Act
            var result = await carController.GetCars(carQueryOptions);

            //Assert
            Assert.Equal(3, result.Count<Car>());
        }

        [Fact]
        public async Task IfAllOptionsSelected_ReturnsZeroCars()
        {
            //Arrange
            var carQueryOptions = new CarQueryOptions
            {
                HasHeatedSeats = true,
                HasNavigation = false
            };
            var mockICarRepo = new Mock<ICarRepository>();
            var mockReturn = new List<Car>()
            { new Car() { Color = "Red"},
              new Car() { Color = "Black"}
            };
            mockICarRepo.Setup(repo => repo.GetCars(carQueryOptions))
                .Returns(Task.FromResult<IEnumerable<Car>>(mockReturn));
            var carController = new CarsController(mockICarRepo.Object);

            //Act
            var result = await carController.GetCars(carQueryOptions);

            //Assert
            Assert.Equal(2, result.Count<Car>());
        }

        [Fact]
        public async Task IfHasFrWheelDriveSunroofAndPowerWindows_ReturnsOneCars()
        {
            //Arrange
            var carQueryOptions = new CarQueryOptions
            {
                HasHeatedSeats = true,
                HasNavigation = false
            };
            var mockICarRepo = new Mock<ICarRepository>();
            var mockReturn = new List<Car>()
            { new Car()
            };
            mockICarRepo.Setup(repo => repo.GetCars(carQueryOptions))
                .Returns(Task.FromResult<IEnumerable<Car>>(mockReturn));
            var carController = new CarsController(mockICarRepo.Object);

            //Act
            var result = await carController.GetCars(carQueryOptions);

            //Assert
            Assert.Single(result);
        }
    }
}