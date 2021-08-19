using System;

namespace ErrorHandlingExamples
{
    class Program
    {
        //a->b->c->d->e
        static void Main(string[] args)
        {
            try
            {
                var country = MyUtil.InputACountryName();
                Console.WriteLine("Your country is " + country + " is accepted!");
            }
            catch (NotValidCountryNameException ex)
            {
                Console.WriteLine("Invalid country name sorry");
                Console.WriteLine(ex.Message);    
            }

            //int[] myNumbers = new int[] { 1, 5, 9, 58, 88, 14 };

            //try
            //{
            //    var index = MyUtil.UserInputToInt();
            //    var number = myNumbers[index];
            //    Console.WriteLine("Your number is: " + number);
            //}
            //catch (FormatException ex1)
            //{
            //    Console.WriteLine("The index is not integer!");
              
            //}
            //catch(IndexOutOfRangeException ex2)
            //{
            //    Console.WriteLine("Your index is too big or less than 0");
            //    Console.WriteLine("The max is: " + (myNumbers.Length-1));
            //}catch(Exception ex3)
            //{
            //    Console.WriteLine("Some error which is not expected");
            //    Console.WriteLine(ex3.Message);
            //}
            

            //try
            //{
            //    Console.WriteLine("Enter a number: ");
            //    var n1 = Convert.ToInt32(Console.ReadLine());
            //    if (n1 % 2 == 1)
            //    {
            //        Console.WriteLine("This is the Odd number!");
            //    }
            //    else
            //    {
            //        Console.WriteLine("This is the Even number");
            //    }
            //}catch(FormatException ex)
            //{
            //    Console.WriteLine("You entered not a number!");
            //    Console.WriteLine(ex.Message);
            //}
            //catch(OverflowException ov)
            //{
            //    Console.WriteLine("You entered a  too big or too small number");
            //}              
            //catch (Exception ex2)
            //{
            //    Console.WriteLine("The programe has some unexpected bug. Sorry!");
            //}
            //finally
            //{
            //    Console.WriteLine("Thank you and see you again!");
            //}

            Console.ReadLine();
        }
    }
}
