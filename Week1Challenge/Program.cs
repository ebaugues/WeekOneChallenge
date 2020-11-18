using System;
using System.Collections.Generic;

namespace Week1Challenge
{
    class Program
    {

       static void Main(string[] args)
        {
            string FirstName = "Erik";
            String LastName = "Baugues";

            // Save today's date.
            DateTime today = DateTime.Now;
            DateTime birthDate = new DateTime(1977, 01, 07);


            int age = today.Year - birthDate.Year;

            if (today.Month < birthDate.Month || (today.Month == birthDate.Month && today.Day < birthDate.Day))
                age--;

            Console.WriteLine("First Name: " + FirstName);
            Console.WriteLine("Last Name: " + LastName);
            Console.WriteLine("Age: " + age);

            string[] Movies = new string[] {"Borat", "Rocky", "American Beauty"};

            foreach (var item in Movies)
            {

                Console.WriteLine(item + "\n");
            }

            DateTime[] Dates = new DateTime[] { new DateTime(2000, 01, 01), new DateTime(1995, 11, 01), new DateTime(2000, 06, 17) };
            Console.WriteLine("Age + 7: " + (age + 7));

            int Kids = 4;
            bool Class = true;
            int JobHours = 70;
            int hoursofSleep;

            //Inialize hoursofSleep to 10
            hoursofSleep = 10;


            //Evaluate kids
            switch (Kids)
            {

                case 0:
                    hoursofSleep = hoursofSleep - 0;
                    break;

                case 1: 
                    hoursofSleep = hoursofSleep - 1;
                    break;

                case 2:
                    hoursofSleep = hoursofSleep - 2;
                    break;

                case 3:
                    hoursofSleep = hoursofSleep - 3;
                    break;

                default:
                    hoursofSleep = hoursofSleep - 4;
                    break;

            }


            if ((JobHours >= 40) & (JobHours < 60))
            {
                hoursofSleep = hoursofSleep - 1;


            }

            if ((JobHours >= 60) & (JobHours < 80))
            {
                hoursofSleep = hoursofSleep - 2;

            }

            if (JobHours >= 80)
            {
                hoursofSleep = hoursofSleep - 3;
            }

            if (Class)
            {
                hoursofSleep = hoursofSleep - 2;
            }

          


            Console.WriteLine("Hours of Sleep " + hoursofSleep);
            //string typeofDay = "Bad";  'Testing


            Console.WriteLine("How was your day?");

            Console.WriteLine("1. Great");
            Console.WriteLine("2. Good");
            Console.WriteLine("1. Okay");
            Console.WriteLine("1. Bad");
            string Response = Console.ReadLine().ToUpper();

            switch (Response)
            {
                case "GREAT":
                    Console.WriteLine("That is fantastic. Did you take your prozac?");
                    break;

                case "GOOD":
                    Console.WriteLine("Awesome");
                    break;
                case "OKAY":
                    Console.WriteLine("Hopefully it gets better!");
                    break;
                case "BAD":
                    Console.WriteLine("You must of been accused of plagiarism!");
                    break;
                default:
                    Console.WriteLine("Enter an acceptable value, man!");
                    break;

            }





            }
        }

    

}


