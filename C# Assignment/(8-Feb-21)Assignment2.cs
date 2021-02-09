using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    class secclass
    {
        
        static void Main()
        {
            //1.print sum and average of elements of an array

             int[] num = new int[10];
            int sum = 0;
            float avg;
            Console.WriteLine("enter numbers");
            for (int i = 0; i < 10; i++)
            {
                num[i] = Convert.ToInt16(Console.ReadLine());
                sum += num[i];
            }

            avg = (float)sum / 10;
            Console.WriteLine("sum is " + sum);

            Console.WriteLine("average is " + avg);

            //2.wap to display sum of 3 by 3 matrices

            int[,] num1 = new int[3, 3];
            int sum1 = 0;

            Console.WriteLine("enter numbers");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    num1[i, j] = Convert.ToInt16(Console.ReadLine());
                    sum1 = sum1 + num1[i, j];
                }
            }
            Console.WriteLine("numbers are");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                Console.Write(num1[i, j] + "\t");
                    
                }


                Console.WriteLine();
                }

           Console.WriteLine("Sum of 3 by 3 matrix is" + sum1);

            
            //3. WAP to find the maximum element of an integer Array
            int[] arr = new int[6];
            int max = arr[0];
            int a;
            Console.WriteLine("Enter numbers in array to get the maximum element of an integer Array ");
            for (a = 0; a < arr.Length - 1; a++)
            {
                arr[a] = Convert.ToInt32(Console.ReadLine());

            }
            for (a = 1; a <= arr.Length - 1; a++)
            {
                if (max < arr[a])
                {
                    max = arr[a];
                }
            }

            Console.WriteLine("Maximum element in array is {0} ", max);



            //4. WAP to print column wise sum of elements of 2 D Array
            int[] c_sum = new int[2];
            int[,] num2 = new int[2,2];
            Console.WriteLine("Enter Numbers to print column wise sum of elements of 2D Array ");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    num2[i, j] = Convert.ToInt16(Console.ReadLine());

                }
            }
            Console.WriteLine("Entered 2D array is ");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(num2[i, j] + "\t");
                }
                Console.WriteLine();

            }
            Console.WriteLine("Sum of columns of the 2D matrix are");
            for (int i = 0; i < 2; i++)
            {
                c_sum[i] = 0;
                for (int j = 0; j < 2; j++)
                    c_sum[i] = c_sum[i] + num2[j, i];
            }

            for (int j = 0; j < 2; j++)
            {
                Console.Write("{0} ", c_sum[j]);
            }



            //5. WAP to print row wise sum of elements of 2 D Array
            Console.WriteLine("\n");
            int[] r_sum = new int[2];
            Console.WriteLine("Sum of rows of the 2D matrix are");
            for (int i = 0; i < 2; i++)
            {
                r_sum[i] = 0;
                for (int j = 0; j < 2; j++)
                    r_sum[i] = r_sum[i] + num2[i, j];
            }
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                    Console.Write("{0}    ", num2[i, j]);
                Console.Write("{0}    ", r_sum[i]);
                Console.Write("\n");
            }


        }
    }


}




