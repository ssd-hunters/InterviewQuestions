using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewQuestions
{
    class CadMakerQuestions
    {
        //What is the Accessiblity of the following access modifiers

        //public -
        //private - 
        //protected -
        //internal -

            
        //Create an application to reverse a string
        public static string ReverseString()
        {
            string input = "hello there";


            return new string("");
        }

        //Using linq, write a program that will take an list of strings, and return only the strings that are of the given length. Order the results alphabetically and remove duplicates
        public static IEnumerable<string> SortList(int length)
        {
            List<string> input = new List<string>() {"John", "walked", "to", "the", "lake", "and", "sat" };



            return input;
        }

        //Using linq, write a the code necessary to return only odd numbers from a list of ints
        public static IEnumerable<int> ReturnOdds()
        {
            List<int> input = new List<int>() {1, 2, 3, 4, 5 };



            return input;
        }

        //What is an extension method?

        //What is a transactional query?

        //What are some differences between an array and a LinkedList?

        //In your opinion, what is the most import principle of OOP?

        //What are the differences between an abstract method and an interface?

    }
}
