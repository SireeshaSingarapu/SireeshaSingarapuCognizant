using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class secondclass
    {
        static void Main()
        {
            //2.WAP to add three numbers



            int a;
            int b;
            int c;
            Console.WriteLine("Enter three numbers to add");
            Console.WriteLine("Enter Number 1");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number 2");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number 3");
            c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Sum of three numbers {0} and {1} and {2}is {3} ", a, b, c, (a + b + c));

            // 3.WAP to print sum and average of 1st 20 natural numbers
            int n;
            int sum = 0;
            float avg;
            for (n = 1; n <= 20; n++)
            {
                sum = sum + n;

            }
            avg = (sum / 20);
            Console.WriteLine("Sum of first 20 natural numbers is " + sum);
            Console.WriteLine("Average of first 20 natural numbers is" + avg);

            // 4.WAP to print first 50 even numbers
            int i;
            Console.WriteLine(" First 50 even numbers are ");
            for (i = 2; i <= 50; i = i + 2)
            { 
           
            Console.WriteLine(i);
        }
            //5.WAP to check whether a number is prime or not
            int j;
            int k=0;
            int num;
            Console.WriteLine("Enter a number");
            num = Convert.ToInt32(Console.ReadLine());
            for(j=1;j<=num;j++)
            {
                if(num%i==0)
                {
                    k++;
                }
            }
            if(k==2)
            {
                Console.WriteLine("{0} is a Prime number",num);
            }
            else
            {
                Console.WriteLine(" {0}is not a Prime number",num);
            }

            /*6.WAP to print table of entered number in following format
            5 * 1 = 5
            5 * 2 = 10
           */
            //int i;
            //int n;
            int t;
            Console.WriteLine("Enter a number to print table:");
            n = Convert.ToInt32(Console.ReadLine());
            for(i=1;i<=20;i++)
            {
                t = n * i;
                Console.WriteLine("{0}*{1}={2}",n,i,t);

            }


            //  7.WAP to take some numbers from user..Note the difference between ToIn16, ToInt32, ToByte and other methods available

            Console.WriteLine("Enter a number to Print");
            int p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entered number is {0}", p);

            Console.WriteLine("Enter Number 1");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entered number is {0}", a);
            Console.WriteLine("Enter Number 2");
            b = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Entered number is {0}", b);
            Console.WriteLine("Enter Number 3");
            c = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Entered number is {0}", c);


            /*7.difference between ToIn16, ToInt32 , ToByte and other methods available
            The Convert.ToInt16() method returns the 16-bit integer e.g. short, the Convert.ToInt32() returns 32-bit integers e.g. int and the Convert.ToInt64() returns the 64-bit integer e.g. long. */

            /*8. What is System in the program. What are Console and Convert? What are Write, WriteLine , ReadLine and ToByte
            system  : system is a namespace, namespace is logical collection of related classes
            Console : Console is a class which is present in the namespace
            Write, WriteLine :The most common method to output something in C# is WriteLine() and Write().
                        The difference is that WriteLine() prints the output on a new line each time, while Write() prints on the same line
            Convert : this is used to convert one data type to other data type
            ReadLine : it is a input statement to take values
            ToByte : it is used to conver data into bytes */


            /*9. Is it mandatory to have a class in the project
              Yes, C# application must have at least one class with Main method, so that execution can begin from it.*/


            /*10. Why is static added to Main() method?
              A main method is static since it is available to run when the C# program starts. It is the entry point of the program and runs without even creating an instance of the class.*/


        }
    }
}