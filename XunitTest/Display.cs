using System;
using System.Text;
using TestProject;
using Xunit;

namespace XunitTest
{
    public class Display
    {
      

        [Fact]
        public void Append()
        {
            OrderProcessor orderProcessor = new OrderProcessor();
            StringBuilder sb = new StringBuilder();
            orderProcessor.AppendData(sb, "Test1", " Test2");
            Assert.Equal("Test1 Test2\r\n", sb.ToString() );
            orderProcessor.AppendData(sb, "Test3", " Test4");
            Assert.Equal("Test1 Test2\r\nTest3 Test4\r\n", sb.ToString());

        }
        [Fact]
        public void ApGenerateDisplayMessagepend()
        {
            OrderProcessor orderProcessor = new OrderProcessor();
            string input = "2,12-12-2012,Peter,Bat,1500,3,Ball,10,10,Stump,20,20";
            orderProcessor.GenerateDisplayMessage(input.Split(','),5000);
            Assert.Equal("2: purchase id\r\nPeter: UserName\r\n5000: Total Cost\r\n", orderProcessor.GenerateDisplayMessage(input.Split(','), 5000));
            

        }

        
    }
}
