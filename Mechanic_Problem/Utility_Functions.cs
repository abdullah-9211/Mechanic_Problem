using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helper_Classes;

namespace Mechanic_Problem
{
    public class Utility_Functions
    {
        //Function to Print out Menu
        public static void Present_Menu()
        {
            Console.Write("\t\t===============================WELCOME TO THE MECHANIC======================\n\n\n");
            Console.Write("Please answer the following questions:-\n\n");
        }


        //Asks user for questions and takes input
        public static void Ask_Questions(out string name, out string reg, out int dist)
        {
            Console.Write("Please enter your name: ");
            name = Console.ReadLine();
            Console.Write("\n");

            Console.Write("Please enter registration number of your car: ");
            reg = Console.ReadLine();
            Console.Write("\n");

            Console.Write("Please enter odo reading of car (50000, 100000 or 200000): ");
            dist = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");

            while (dist != 50000 && dist != 100000 && dist != 200000)
            {
                Console.WriteLine("Invalid Input!!");
                Console.Write("Please enter 50000, 100000 or 200000 only: ");
                dist = Convert.ToInt32(Console.ReadLine());
                Console.Write("\n");
            }
        }

        //Function to initialise the lists of questions
        public static void Init_Qs(List<Question> l1, List<Question> l2, List<Question> l3)
        {
            Question q1 = new Question("50k Question 1?");
            Question q2 = new Question("50k Question 2?");
            Question q3 = new Question("50k Question 3?");
            Question q4 = new Question("50k Question 4?");
            Question q5 = new Question("50k Question 5?");

            l1.Add(q1);
            l1.Add(q2);
            l1.Add(q3);
            l1.Add(q4);
            l1.Add(q5);

            q1 = new Question("100k Question 1?");
            q2 = new Question("100k Question 2?");
            q3 = new Question("100k Question 3?");
            q4 = new Question("100k Question 4?");
            q5 = new Question("100k Question 5?");
            Question q6 = new Question("100k Question 6?");

            l2.Add(q1);
            l2.Add(q2);
            l2.Add(q3);
            l2.Add(q4);
            l2.Add(q5);
            l2.Add(q6);

            q1 = new Question("200k Question 1?");
            q2 = new Question("200k Question 2?");
            q3 = new Question("200k Question 3?");
            q4 = new Question("200k Question 4?");
            q5 = new Question("200k Question 5?");
            q6 = new Question("200k Question 6?");
            Question q7 = new Question("200k Question 7?");

            l3.Add(q1);
            l3.Add(q2);
            l3.Add(q3);
            l3.Add(q4);
            l3.Add(q5);
            l3.Add(q6);
            l3.Add(q7);


        }
    }
}
