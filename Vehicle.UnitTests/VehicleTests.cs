using System.Collections.Generic;
namespace Vehicle.UnitTests
{
    public class VehicleTests
    {
        [Fact]
        public void WhenCreated_HasCorrectProperties()
        {
            Vehicle megansCar = new Vehicle(4, "Green");

            Assert.Equal(4, megansCar.NumberOfWheels);
            Assert.Equal("Green", megansCar.Color);
            Assert.Equal(0, megansCar.MilesDriven);
        }

        // This test needs some work!
        [Fact]
        public void Summary_ReturnsInfoAboutVehicle()
        {
            Vehicle andysBike = new Vehicle(2, "Blue");
            andysBike.Summary();
            Assert.Equal(2, andysBike.NumberOfWheels);
            Assert.Equal("Blue", andysBike.Color);
            Assert.Equal(0, andysBike.MilesDriven);

            var expected = "This Blue vehicle has 2 wheels and has driven 0 miles";


        }
        [Fact]
        public void DoesMethod_CalcualateMilesDriven()
        {
            Vehicle zaysCar = new Vehicle(4, "Silver");
            zaysCar.Drive();
            Assert.Equal(5, zaysCar.MilesDriven);
        }

        [Fact]
        public void DoesMethod_ChangeColorOfCar()
        {
            Vehicle zayCar = new Vehicle(4, "Silver");

            Assert.Equal("Silver", zayCar.Color);
            zayCar.Paint("Black");
        }

        // Add more tests here!
    }
}