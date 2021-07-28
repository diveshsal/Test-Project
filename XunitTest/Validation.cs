using System;
using System.Text;
using TestProject;
using Xunit;

namespace XunitTest
{
    public class Validation
    {
        [Fact]
        public void Check()
        {
            OrderProcessor orderProcessor = new OrderProcessor();
            string input = "";
            Assert.Equal("Invalid Data", orderProcessor.ValidateInput(input));

            input = "Test Data";
            Assert.Equal("Invalid Data", orderProcessor.ValidateInput(input));

            input = "2,12-12-2012,Peter,Bat,1500,3,Ball,60,8,Stump";
            Assert.Equal("Invalid Data", orderProcessor.ValidateInput(input));

            input = "2,12-12-2012,Peter,Bat,15Test00,3,Ball,60,8,Stump";
            Assert.Equal("Invalid Data", orderProcessor.ValidateInput(input));

            input = "2,12-12-2012,Peter,Bat,,3,Ball,60,8,Stump";
            Assert.Equal("Invalid Data", orderProcessor.ValidateInput(input));

            input = "2,12-12-2012,Peter,Bat,1500,3";
            Assert.Equal("Succcess", orderProcessor.ValidateInput(input));

            input = "2,12-12-2012,Peter,Bat,1500,3,Ball,60,8,Stump,340,12";
            Assert.Equal("Succcess", orderProcessor.ValidateInput(input));


        }

       
    }
}
