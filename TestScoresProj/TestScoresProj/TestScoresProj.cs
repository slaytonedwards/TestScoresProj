/* TestScoresProj.cs Author: Slayton Edwards 
 * Date: 6/10/19
 * Calculates the average test scores of five tests
 */

using System;
using static System.Console;

namespace TestScoresProj
{
    class TestScoresProj
    {
        static void Main(string[] args)
        {

            /* The intergers of the five tests */
            int test1;
            int test2;
            int test3;
            int test4;
            int test5;
            double average;

            /* Insert score of tests with these codes */
            Console.Write("The score for test 1 is: ");
            test1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("The score for test 2 is: ");
            test2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("The score for test 3 is: ");
            test3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("The score for test 4 is: ");
            test4 = Convert.ToInt32(Console.ReadLine());
            Console.Write("The score for test 5 is: ");
            test5 = Convert.ToInt32(Console.ReadLine());

            /* The average of the test score is all the tests added together divided by 5 */
            average = (test1 + test2 + test3 + test4 + test5) / 5;

            /* The average score for the tests will show here */
            Console.Write("The Average score is " + "{0:N2}", average);

            /* Read out every command */
            Console.ReadKey();
        }
    }
}
