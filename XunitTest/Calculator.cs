using System;
using TestProject;
using Xunit;
namespace XunitTest
{

    public class Calculator
    {
        [Fact]
        public void CalcaluateSingle()
        {
            OrderProcessor orderProcessor = new OrderProcessor();
            Assert.Equal(100, orderProcessor.Calculate(10, 10));
            
        }
        [Fact]
        public void CalulateTotal()
        {
            OrderProcessor orderProcessor = new OrderProcessor();
            string input = "2,12 - 12 - 2012,Peter,Bat,1500,3,Ball,10,10";
            Assert.Equal(4600, orderProcessor.CalucalteTotalCost(input.Split(',')));

            input = "2,12 - 12 - 2012,Peter,Bat,1500,3,Ball,10,10,Stump,20,20";
            Assert.Equal(5000, orderProcessor.CalucalteTotalCost(input.Split(',')));
           
        }

    }
}
