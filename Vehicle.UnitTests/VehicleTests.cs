namespace Vehicle.UnitTests
{
    public class VehicleTests
    {
        public object Summary { get; private set; }
        //This is a commet

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

            string expected = "This Blue vehicle has 2 wheels and has driven 0 miles";
            //Console.WriteLine.Add(Summary);
            Assert.Equal(Summary, expected);


        }

        // Add more tests here!
        [Fact]

        public void Miles_ThatCarHasBeen_Driven() 
        
       {
        
        }
        [Fact]

        public void New_PaintColor()
        {
            var Color = new Color();
            Console.WriteLine(newColor);
            Assert.Equal(Color, newColor);
        }
    }
}