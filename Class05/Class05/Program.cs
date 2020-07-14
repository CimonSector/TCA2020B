﻿using System;

namespace newtype
{
    class Program
    {
        static void Main(string[] args)
        {


            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine("オプション:" + args);

            }
            CalculateBMI();
        }

        static void CalculateBMI()
        {
            float height = GetInputAndParse("身長を入力してください(m)");

            float weight = GetInputAndParse("体重を入力してください(kg)");

            float bmi = CalculateBMI(weight, height);

            Console.WriteLine("BMI:" + bmi);

        }
        static float GetInputAndParse(string guideText)
        {
            float parseResult = 0f;
            bool parseSuccess = false;
            while (!parseSuccess)
            {
                Console.WriteLine(guideText);
                string input = Console.ReadLine();
                parseSuccess = float.TryParse(input, out parseResult);
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
