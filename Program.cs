using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_asssigment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Assigment2 Question1");
            A2Q1 a2Q1 = new A2Q1();
            a2Q1.functional();
            Console.ReadLine();


            Console.WriteLine("Assigment2 Question2");
            A2Q2 a2Q2 = new A2Q2();
            a2Q2.functional();
            Console.ReadLine();


            Console.WriteLine("Assigment2 Question3");
            A2Q3 a2Q3 = new A2Q3();
            a2Q3.ATM();
            Console.ReadLine();

            Console.WriteLine("Assigment2 Question4");
            A2Q4 a2Q4 = new A2Q4();
            a2Q4.Grade();
            Console.ReadLine();
        }
    }

    class A2Q1
    {
        private int num;
        public void functional()
        {
            double[] prices = new double[5];

            Console.WriteLine("Enter the 5 items");

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Item {i + 1}: Rs. ");
                prices[i] = Convert.ToDouble(Console.ReadLine());

            }
            double totalPrice = 0;
            foreach (double price in prices)
            {
                totalPrice += price;

            }
            Console.WriteLine(totalPrice);
            if (totalPrice > 0)
            {
                double discount = totalPrice * 0.10;
                totalPrice -= discount;
                Console.WriteLine("10% discount is apllied");
            }

            Console.WriteLine($"Total price after any discount: Rs. {totalPrice:F2}");

        }

    }

    class A2Q2
    {
        private int num;
        public void functional()
        {
            Console.WriteLine("Enter the temperture in celsius");
            double celsius = Convert.ToDouble(Console.ReadLine());
            double fahrenheit = (celsius * 9 / 5) + 32;
            if (celsius > 0)
            {
                Console.WriteLine("warning: Freezing temperatures");
            }
            Console.WriteLine($"Temperature in Fahrenheit:{fahrenheit}\n");
        }
    }

    class A2Q3
    {
        public void ATM()
        {
            double balance = 1000;
            int choice;

            do
            {
                Console.WriteLine("Check balnce press 1");
                Console.WriteLine("Deposite money press 2");
                Console.WriteLine("Withdrwa money press 3");
                Console.WriteLine("Exit press 4");
                choice=int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine($"your account balance is: RS{balance}");
                        break;
                    case 2:
                        Console.WriteLine("Enter amount to deposit:RS");

                        double depositAmount = double.Parse(Console.ReadLine());
                        if (depositAmount > 0)
                        {
                            balance += depositAmount;
                            Console.WriteLine($"RS.{depositAmount}deposit new balance is {balance}");
                        }
                        else
                        {
                            Console.WriteLine("invaild amount must be greater than zero");

                        }
                        break;
                    case 3:
                        Console.WriteLine("Enter the Withdraw amount");
                        double WithdrawAmount = double.Parse(Console.ReadLine());
                        if (WithdrawAmount > 0)
                        {
                            if (WithdrawAmount <= balance)
                            {
                                balance -= WithdrawAmount;
                                Console.WriteLine($"RS{WithdrawAmount}withdrawn new Balance RS{balance}");
                            }
                            else
                            {
                                Console.WriteLine("insuffecient Balnance");
                            }
                        }
                        else
                        {
                            Console.WriteLine("invild! Withdrwa amount greater than zero");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Thankyou for visit GoodBye!");
                        break;
                    default:
                        Console.WriteLine("please choose valid option");
                        break;
                }
            } while (choice != 4);
        }
    }

    class A2Q4
    {
        public void Grade()
        {
            float mark1, mark2, mark3, mark4, mark5, average;

            Console.WriteLine("Enter the subject1");
            mark1= float.Parse(Console.ReadLine());


            Console.WriteLine("Enter the subject2");
            mark2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter the subject3");
            mark3 = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter the subject4");
            mark4 = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter the subject5");
            mark5 = float.Parse(Console.ReadLine());


            average =(mark1+ mark2+  mark3+ mark4+ mark5)/5;

            Console.WriteLine(average);

            if (average >= 90)
            {
                Console.WriteLine("Grade:A");
            }else if (average >= 80)
            {
                Console.WriteLine("Grade:B");
            }else if(average >=70)
            {
                Console.WriteLine("Grade:C");
            }else if(average >= 60)
            {
                Console.WriteLine("Grade:D");
            }else if (average >= 50)
            {
                Console.WriteLine("Grade:E");
            }
            else
            {
                Console.WriteLine("Grade:F");
            }
        }
    }
    
} 
            
