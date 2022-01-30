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

            bool exit = false;

            while (!exit)
            {
                string name, reg;
                int dist;

                //Present initial menu and Take input of user car
                Present_Menu();
                Ask_Questions(out name, out reg, out dist);

                //The current car in store
                Car current_car = new Car(name, reg, dist);

                //Calling question list according to the odo meter of current car
                if (current_car.Distance == 50000)
                {
                    Questions_Menu(Fiftyk_Questions, current_car);
                }
                else if (current_car.Distance == 100000)
                {
                    Questions_Menu(Hundredk_Questions, current_car);
                }
                else
                {
                    Questions_Menu(Two_Hundredk_Questions, current_car);
                }

                

                exit = Check_New_Customer();

            }

            Exit_Screen();

            Console.ReadKey();
        }
    }
}