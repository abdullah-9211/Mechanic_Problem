using System;
using System.IO;
using System.Collections.Generic;
using Helper_Classes;
using static Mechanic_Problem.Utility_Functions;



namespace Mechanic_Problem
{
    class Program
    {
        public static void Main()
        {
            //Lists Containing All the questions to be asked for each service
            List<Question> Fiftyk_Questions = new List<Question>();
            List<Question> Hundredk_Questions = new List<Question>();
            List<Question> Two_Hundredk_Questions = new List<Question>();


            //Initialises Questions in list
            Init_Qs(Fiftyk_Questions, Hundredk_Questions, Two_Hundredk_Questions);

            Console.WriteLine(Fiftyk_Questions[4].Content);
            


            Console.ReadKey();
        }
    }
}