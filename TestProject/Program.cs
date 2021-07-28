using System;
using System.Text;

namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program started");
            OrderProcessor orderProcessor = new OrderProcessor();
            orderProcessor.ProcessData();
        }

    }

    public class OrderProcessor
    {
        public void ProcessData()
        {
            string input = GetUserInput();
            string message = ValidateInput(input);
            if (message == "Succcess")
            {
                string[] split = input.Split(',');
                int totalCost = CalucalteTotalCost(split);
                Console.WriteLine(GenerateDisplayMessage(split, totalCost));
            }


        }

        public string GetUserInput()
        {
            string input;
            Console.WriteLine("Please Enter data:-");
            input = Console.ReadLine();
            return input;

            //return "2,12-12-2012,Peter,Bat,1500,3,Ball,10,10,Stump,20,20";


        }

        public int CalucalteTotalCost(string[] split)
        {


            int totalCost = 0;
            for (int i = 4; i < split.Length; i += 3)
                totalCost += Calculate(Convert.ToInt32(split[i]), Convert.ToInt32(split[i + 1]));


            return totalCost;
        }

        public string GenerateDisplayMessage(string[] split, int totalCost)
        {
            StringBuilder sb = new StringBuilder();
            AppendData(sb, split[0], ": purchase id");
            AppendData(sb, split[2], ": UserName");
            AppendData(sb, Convert.ToString(totalCost), ": Total Cost");
            return sb.ToString();
        }

        public int Calculate(int qty, int rate)
        {
            return qty * rate;
        }

        public void AppendData(StringBuilder sb, string value, string name)
        {
            sb.AppendLine(value + name);
        }

        public string ValidateInput(string input)
        {

            if (string.IsNullOrEmpty(input))
                return "Invalid Data";

            if (!input.Contains(','))
                return "Invalid Data";

            string[] split = input.Split(',');

            if (split.Length < 6)
                return "Invalid Data";

            if (split.Length % 3 != 0)
                return "Invalid Data";

            for (int i = 4; i < split.Length; i += 3)
            {
                if (!(int.TryParse(split[i], out _) && int.TryParse(split[i + 1], out _)))
                    return "Invalid Data";
            }

            return "Succcess";


        }
    }
}



