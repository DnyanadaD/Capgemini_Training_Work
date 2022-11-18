using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Assignment_8_Nov
{
    internal class Program
    {
        #region Assignment 1.3 Method
        //public static void calculate(int[] array)
        //{
        //    int sum = 0;
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        sum = sum + array[i];
        //    }
        //    Console.WriteLine("\nSum of array elements is : " + sum + "\n");
        //}
        #endregion



        #region Assignment 1.4 Method

        //public void FuncSwap(ref int num1, ref int num2)
        //{
        //    int ThirdVar = num1;
        //    num1 = num2;
        //    num2 = ThirdVar;
        //}
        #endregion
        static void Main(string[] args)
        {
            #region Assignment 1.1
            //        Console.WriteLine("***** Calculator *****\n");

            //        Console.WriteLine("Enter 1st Number");
            //        int Num_1 = Convert.ToInt32(Console.ReadLine());
            //        Console.WriteLine("Enter 2nd Number");
            //        int Num_2 = Convert.ToInt32(Console.ReadLine());
            //        int result = 0;

            //        Console.WriteLine(" 1 for Addition");
            //        Console.WriteLine(" 2 for Subtraction");
            //        Console.WriteLine(" 3 for Multiplication");
            //        Console.WriteLine(" 4 for Division \n");
            //        int cal = Convert.ToInt32(Console.ReadLine());
            //        switch (cal)
            //        {
            //            case 1:
            //                {
            //                    result = Addition(Num_1 , Num_2);
            //                    break;
            //                }
            //            case 2:
            //                {
            //                    result = Subtraction(Num_1, Num_2);
            //                    break;
            //                }
            //            case 3:
            //                {
            //                    result = Multiplication(Num_1, Num_2);
            //                    break;
            //                }
            //            case 4:
            //                {
            //                    result = Division(Num_1, Num_2);
            //                    break;
            //                }
            //            default:
            //                Console.WriteLine("Invalid Case");
            //                break;
            //        }
            //        Console.WriteLine("The result is {0}", result);
            //        Console.ReadKey();
            //    }
            //    //Addition  
            //    public static int Addition(int Num_1, int  Num_2)
            //    {
            //        int result = Num_1+ Num_2;
            //        return result;
            //    }
            //    //Substraction  
            //    public static int Subtraction(int Num_1, int Num_2)
            //    {
            //        int result =  Num_1 - Num_2;
            //        return result;
            //    }
            //    //Multiplication  
            //    public static int Multiplication(int Num_1, int Num_2)
            //    {
            //        int result = Num_1 * Num_2;
            //        return result;
            //    }
            //    //Division  
            //    public static int Division(int Num_1, int Num_2)
            //    {
            //        int result = Num_1 / Num_2;
            //        //int rem = (Num_2 * result) - Num_1;
            //        //Console.WriteLine("Remainder is ", rem);
            //        return result;

            #endregion



            #region Assignment 1.2
            //Console.WriteLine("***** Students Marks *****\n");

            //int  marks1, marks2, marks3, marks4, marks5,total;
            //float percentage;
            //string n;

            //Console.WriteLine("Enter Student Name :");
            //n = Console.ReadLine();


            //Console.WriteLine("Enter Subject-1 Marks : ");
            //marks1 = Convert.ToInt32(Console.ReadLine());


            //Console.WriteLine("Enter Subject-2 Marks : ");
            //marks2 = Convert.ToInt32(Console.ReadLine());


            //Console.WriteLine("Enter Subject-3 Marks :");
            //marks3 = Convert.ToInt32(Console.ReadLine());


            //Console.WriteLine("Enter Subject-4 Marks :");
            //marks4 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter Subject-5 Marks :");
            //marks5 = Convert.ToInt32(Console.ReadLine());

            //// Calculate total marks
            //total = marks1 + marks2 + marks3 + marks4 + marks5;

            //// Calculate percentage
            //percentage = total / 5.0f;

            //// Display the final result
            //Console.WriteLine("Final result of {0} is:", n);
            //Console.WriteLine("Total Marks : " + total);
            //Console.WriteLine("Percentage : " + percentage);

            //// Calculate grades
            //if (percentage <= 35)
            //{
            //    Console.WriteLine("Grade is F");
            //}
            //else if (percentage >= 34 && percentage <= 39)
            //{
            //    Console.WriteLine("Grade is D");
            //}
            //else if (percentage >= 40 && percentage <= 59)
            //{
            //    Console.WriteLine("Grade is C");
            //}
            //else if (percentage >= 60 && percentage <= 69)
            //{
            //    Console.WriteLine("Grade is B");
            //}
            //else if (percentage >= 70 && percentage <= 79)
            //{
            //    Console.WriteLine("Grade is B+");
            //}
            //else if (percentage >= 80 && percentage <= 90)
            //{
            //    Console.WriteLine("Grade is A");
            //}
            //else if (percentage >= 91)
            //{
            //    Console.WriteLine("Grade is A+");
            //}


            //int ArraySize;
            //double big = 0;
            //Console.WriteLine("Enter Size of array");
            //ArraySize = Convert.ToInt32(Console.ReadLine());
            //double[] marks = new double[ArraySize];
            //Console.WriteLine("Please enter the Marks in the array");
            //for (int i = 0; i < ArraySize; i++)
            //{
            //    marks[i] = Convert.ToDouble(Console.ReadLine());
            //}
            //for (int i = 0; i < ArraySize; i++)
            //{
            //    if (marks[i] >= big)
            //        big = marks[i];
            //}
            //Console.WriteLine("\nHighest marks achived are : " + big);

            #endregion



            #region Assignment 1.3 Main
            //int ArraySize;
            //Console.WriteLine("Enter Size of array");
            //ArraySize = Convert.ToInt32(Console.ReadLine());
            //int[] integers = new int[ArraySize];
            //Console.WriteLine("\nPlease enter the integers in the array");
            //for (int i = 0; i < ArraySize; i++)
            //{
            //    integers[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //calculate(integers);
            #endregion



            #region Assignment 1.4

            //int num1, num2;
            //Console.WriteLine("Enter two numbers to be swapped");
            //Console.Write("num1= ");
            //num1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("num2= ");
            //num2 = Convert.ToInt32(Console.ReadLine());
            //Program p = new Program();
            //p.FuncSwap(ref num1, ref num2);

            //Console.WriteLine("After Swapping num1= " + num1 + "  num2= " + num2);
            #endregion



            #region Assignment 1.5
            //public void circle(double radius, ref double area, ref double circumference)
            //{
            //    area = 3.14 * radius * radius;
            //    circumference = 2 * 3.14 * radius;
            //}
            //static void Main(string[] args)
            //{
            //    double radius, area = 0, circumference = 0;
            //    Console.WriteLine("Enter radius of circle");
            //    radius = Convert.ToDouble(Console.ReadLine());
            //    Program p = new Program();
            //    p.circle(radius, ref area, ref circumference);
            //    Console.WriteLine("\nArea of Circle is ={0}\ncircumference of Circle is = {1}\n ", area, circumference);

            //}
            #endregion



            #region Assignment 1.6

            //public struct Book
            //{
            //    public int bookId; public string title; public double price;public string bookType;
            //    //public enum bookType
            //    //{
            //    //    Magazine = 1,
            //    //    Novel,
            //    //    ReferenceBook,
            //    //    Miscellaneous
            //    //};
            //}

            //static void Main(string[] args)
            //{
            //    int n;
            //    Console.WriteLine("Enter number of books");
            //    n = Convert.ToInt32(Console.ReadLine());

            //    Book[] book = new Book[n];
            //    Console.WriteLine("\nEnter book details");
            //    for (int i = 0; i < n; i++)
            //    {

            //        Console.Write("Book ID= ");
            //        book[i].bookId = Convert.ToInt32(Console.ReadLine());
            //        Console.Write("Book title= ");
            //        book[i].title = Console.ReadLine();
            //        Console.Write("Book price= ");
            //        book[i].price = Convert.ToDouble(Console.ReadLine());
            //        Console.Write("Book Type (1 for Magazine\nSelect 2 for Novel\nSelect 3 for ReferenceBook,\nSelect 4 for Miscellaneous) = \n");
            //        book[i].bookType = Console.ReadLine();

            //    }
            //    Console.WriteLine("\nDetails of books are as follows");
            //    for (int i = 0; i < n; i++)
            //    {

            //        Console.WriteLine("\nBook ID is " + book[i].bookId);
            //        Console.WriteLine("Book title is " + book[i].title);
            //        Console.WriteLine("Book price is " + book[i].price );
            //        Console.WriteLine("Book price is " + book[i].bookType + "\n");
            //    }
            //}
            #endregion

        }
    }
}
   

