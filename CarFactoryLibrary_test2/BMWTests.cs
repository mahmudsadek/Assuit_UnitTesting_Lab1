using CarFactoryLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactoryLibrary_test2
{
    public class BMWTests
    {
        [Fact]
        public void IsStopped_velocity0_true()
        {
            // Arrange
            BMW BMW = new BMW();
            BMW.velocity = 0;

            // Act
            bool result = BMW.IsStopped();

            // Boolean Asserts
            Assert.True(result);
        }

        [Fact]
        public void IncreaseVelocity_valocity10Add20_30()
        {
            // Arrange
            BMW bmw = new BMW();
            bmw.velocity = 10;
            double AddedVelocitoy = 20;

            // Act
            bmw.IncreaseVelocity(AddedVelocitoy);

            // Equality Assert
            Assert.Equal(30, bmw.velocity);
            Assert.NotEqual(10, bmw.velocity);

            // Numeric Asserts
            Assert.False(bmw.velocity < 10);

            Assert.InRange(bmw.velocity, 20, 30);
            Assert.NotInRange(bmw.velocity, 10, 20);
        }

        [Fact]
        public void GetDirection_Backward_Backward()
        {
            //Arrange 
            Toyota toyota = new Toyota();
            toyota.drivingMode = DrivingMode.Backward;

            //Act
            string Direction = toyota.GetDirection();

            //Assert
            //1
            Assert.StartsWith("B", Direction);
            //2
            Assert.EndsWith("d", Direction);
            //3
            Assert.Contains("c", Direction);
            //4
            Assert.DoesNotContain("r", Direction);


        }
    }
}
