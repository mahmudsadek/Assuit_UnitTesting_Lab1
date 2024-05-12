using CarFactoryLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactoryLibrary_test2
{
    public class CarFactoryTests
    {
        [Fact]
        public void When_NewCar_CarTypeAudi_null()
        {
            // Arrange
            BMW BMW = new BMW();

            // Act
            Car car = BMW.GetMyCar();

            // Assert
            Assert.NotNull(car);
        }

        [Fact]
        public void NewCar_CarTypeBMW_BMW()
        {
            // Arrange

            // Act
            Car? car = CarFactory.NewCar(CarTypes.BMW);

            // Reference Asserts
            Assert.NotNull(car);

            // Type Asserts
            Assert.IsType<BMW>(car);
            Assert.IsAssignableFrom<Car>(new BMW());
        }

        [Fact]
        public void NewCar_CarTypeBMW_Exception()
        {
            // Arrange



            // Assert
            Assert.Throws<NotImplementedException>(() =>
            {
                // Act
                Car? result = CarFactory.NewCar(CarTypes.BMW);
            });
        }

    }
}
