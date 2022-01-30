using System;
using System.IO;
using System.Collections.Generic;
using Helper_Classes;



namespace Main
{
    class Program
    {
        public static void Main()
        {
            List<Question> Five_Q = new List<Question>();
            Question q1 = new Question("Dummy Question 1?");
            Question q2 = new Question("Dummy Question 2?");
            Question q3 = new Question("Dummy Question 3?");
            Question q4 = new Question("Dummy Question 4?");
            Question q5 = new Question("Dummy Question 5?");
            Five_Q.Add(q1);
            Five_Q.Add(q2);
            Five_Q.Add(q3);
            Five_Q.Add(q4);
            Five_Q.Add(q5);





            Console.ReadKey();
        }
    }
}