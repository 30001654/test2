using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    class Program
    {
        static void Main( string[] args )
        {

            while (true)
            {
                Console.WriteLine("Enter the number of the question to view or type 'exit' to close");
                var menu = Console.ReadLine();

                if ( menu == "1" )
                {
                    Q1();
                } else if (menu == "2")
                {
                    Q2();
                }
                else if (menu == "3")
                {
                    Q3();
                }
                else if (menu == "4")
                {
                    Q4();
                }
                else if (menu == "5")
                {
                    Q5.q5();
                }
                else if (menu == "6")
                {
                    Q6.q6();
                }
                else if (menu == "7")
                {
                    Q7.q7();
                }
                else if (menu == "exit")
                {
                    break;
                }
                else
                {
                    Console.WriteLine( "Error code: 666" );
                }

            }
       
        }

        public static void Q1()
        {
            Console.WriteLine("Hello World");
            Console.ReadLine(); // Q1
        }

        public static void Q2 ()
        {
            int num1 = 74;
            int num2 = 36;
            int num3 = num1 + num2;
            Console.WriteLine("74 + 36 = " + num3);
            Console.ReadLine(); // Q2
        }

        public static void Q3()
        {
            Console.WriteLine( "Enter number 1" );
            int unum1 = int.Parse(Console.ReadLine());
            Console.WriteLine( "Enter number 2" );
            int unum2 = int.Parse(Console.ReadLine());
            int unum3 = unum1 * unum2;

            Console.WriteLine(unum1 + " x " + unum2 + " = " + unum3);
            Console.ReadLine(); // Q3
        }

        public static void Q4()
        {
            Console.WriteLine("Enter your first name:");
            var firstName = Console.ReadLine();

            Console.WriteLine("Enter your last name:");
            var lastName = Console.ReadLine();

            Console.WriteLine("Hello " + firstName + " " + lastName);
            Console.ReadLine(); // Q4
        }
    }

    public class Q5
    {
        public static void q5()
        {
            Console.WriteLine("Enter a number to see the times tables of.");
            int unum1 = int.Parse(Console.ReadLine());

            for (int i = 0; i <= 10; i++)
            {
                int mult = unum1 * i;
                Console.WriteLine(unum1 + " x " + i + " = " + mult);
            }

            Console.ReadLine(); // Q5
        }
    }

    public class Q6
    {
        public static void q6()
        {
            Console.WriteLine("Enter Num 1:");
            int input1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Num 2:");
            int input2 = int.Parse(Console.ReadLine());

            int swap = input1;
            input1 = input2;
            input2 = swap;

            Console.WriteLine("Number 1: " + input1);
            Console.WriteLine("Number 2: " + input2);

            Console.ReadLine(); // Q6
        }
    }

    public class Q7
    {
        public static void q7()
        {
            Console.WriteLine("Enter number 1:");
            int input1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number 2:");
            int input2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number 3:");
            int input3 = int.Parse(Console.ReadLine());

            int temp = 0;

            if ( input1 >= input2)
            {
                temp = input1;
            }
            else
            {
                temp = input2;
            }

            if ( temp >= input3 )
            {
                Console.WriteLine( "The biggest number is " + temp );
            }
            else
            {
                Console.WriteLine( "The biggest number is " + input3 );
            }
        }
    }

    public class Q8
    {
        public static void q8()
        {
            Console.WriteLine( "Enter your grade(%)" );
            int grade = int.Parse(Console.ReadLine());
            if ( grade >= 50)
            {
                Console.WriteLine( "You have passed." );
            }
            else
            {
                Console.WriteLine( "You have failed." );
            }
        }

    }

    public class Q9
    {
        public static void q9()
        {
            string[] names = { };
        }
    }
}
