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

            int option = -1;

            while (option != 0)
            {
                string name, reg;
                int dist;

                //Present initial menu and Take input of user car
                Present_Menu();
                Ask_Questions(out name, out reg, out dist);

                //The current car in store
                Car current_car = new Car(name, reg, dist);

                
                option = 0;

            }


            Console.ReadKey();
        }
    }
}