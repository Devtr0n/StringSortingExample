using System;
using System.Linq;
using System.Text;

/*************************************************************************
 *
 * Description:
 * This file contains a simple string sorting example, which makes use of LINQ.
 * 
 * Author:
 * Richard Hollon - 4/27/2015
 *
 *************************************************************************/
 
namespace StringSortExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "0011001101010101011111110000000111111000101010101010101010";    //input
            char[] list = input.ToCharArray();                                              //data structure
            var sb = new StringBuilder();                                                   //output

            foreach (var item in list.OrderBy(x=>x)) //order ascending
            {
                sb.Append(item); //concat output string
            }

            Console.WriteLine(sb.ToString()); //display output
	    Console.ReadKey(); //pause window 
        }
    }
}
