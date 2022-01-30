using System;
using System.IO;
using System.Collections.Generic;
using Helper_Classes;



namespace Main
{
    class Program
    {
        //Function to initialise the list of questions
        public static void Init_Qs(List<Question> l1)
        {
            Question q1 = new Question("Dummy Question 1?");
            Question q2 = new Question("Dummy Question 2?");
            Question q3 = new Question("Dummy Question 3?");
            Question q4 = new Question("Dummy Question 4?");
            Question q5 = new Question("Dummy Question 5?");
            Question q6 = new Question("Dummy Question 6?");
            Question q7 = new Question("Dummy Question 7?");


            l1.Add(q1);
            l1.Add(q2);
            l1.Add(q3);
            l1.Add(q4);
            l1.Add(q5);
            l1.Add(q6);
            l1.Add(q7);


        }

        public static void Main()
        {
            //List Containing All the questions to be asked
            List<Question> Questions = new List<Question>();

            //Initialises Questions in list
            Init_Qs(Questions);


            


            Console.ReadKey();
        }
    }
}