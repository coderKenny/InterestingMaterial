using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Homework 06: Calculating area sizes
//Write a program to calculate area sizes. Create two functions with same function name overloading them. One should take <float> and another should take <int> data type arguments. 



namespace HomeWork_06
{
    class Program
    {
        static void Main(string[] args)
        {
            int pituus = 4;
            int leveys = 6;
            float pituus2 = 4.6f;
            float leveys2 = 6.7f;


            //Console.WriteLine("Anna neliön sivun pituus (int) :");

            //int.TryParse(Console.ReadLine(), out squareArea);
            
            //Console.WriteLine("Anna neliön sivun pituus (float) :");

            //float.TryParse(Console.ReadLine(), out squareArea2);


            //CountAreaSize(ref squareArea);
            //CountAreaSize(ref squareArea2);

            Console.WriteLine("\nArea yksi : {0}",NewAreaSizeCalc<int>(pituus,leveys));

            Apuluokka.InsertWideLineSepatator();

            Console.WriteLine("Area kaksi : {0}",NewAreaSizeCalc<float>(pituus2,leveys2));


            Apuluokka.Pause();

        }


        internal static T NewAreaSizeCalc<T>(T x, T y)
        {
            return (dynamic)x*y;
        }


        //private static void CountAreaSize(ref float squareArea2)
        //{
            
        //    squareArea2 *= squareArea2;
        //}

        //private static void CountAreaSize(ref int squareArea)
        //{
        //    squareArea *= squareArea;
        //}
    }
}
