using System;

namespace newtype
{
    class Program
    {
        static void Main(string[] args)
        {

            string inputHeight = "";
            string inputWeight = "";
            for (int i = 0; i < args.Length; i++)
            {
                if (i == 0)
                    inputHeight = args[0];
                if (i == 1)
                    inputWeight = args[1];
            }
            float height = GetInputAndParse(inputHeight, "身長を入力してください(m)");

            float weight = GetInputAndParse(inputWeight, "体重を入力してください(kg)");

            float bmi = CalculateBMI(weight, height);

            Console.WriteLine("BMI" + bmi);

        }

        
        static float GetInputAndParse(string defaultInput, string guideText)
        {
            float parseResult = 0f;
            bool parseSuccess = false;
            while (!parseSuccess)
            {
                Console.WriteLine(guideText);
                string input = Console.ReadLine();
                parseSuccess = float.TryParse(defaultInput, out parseResult);

                if (!parseSuccess)
                {
                    Console.WriteLine("入力不正");
                }
            }
            return parseResult;
        }



        static float CalculateBMI(float weight, float height)
        {
            return weight / (height * height);
        }
    }
}
