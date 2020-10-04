using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculate_your_age
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user to input the year of  his born

            Console.Write(" Inter your year of born : ");
            string stringage = Console.ReadLine();
            Console.WriteLine();

            // Convert this value to number ! 


            int age = 0;
            //double age = 0;

            try
            {
                age = Convert.ToInt16(stringage);
            }




            catch
            {


                Console.WriteLine(" WARNING : Plase Input an Integer Numerical Value ");

                //Console.WriteLine(" WARNING : Plase Input a Numerical Value ");

                Console.WriteLine();
                Console.WriteLine(" Press any key to exit ....");
                Console.ReadKey();
                return;
            }


            //____________________________________________________________________________________________________________________________________________

            // Displaying a bunch of computations with this value


            DateTime now1 = DateTime.Now;


            if (age <= 0)
            {
                Console.WriteLine(" The Value Can't To Be Zero or Negative");
                Console.WriteLine();
            }

            else if (age == 0.0)
            {
                Console.WriteLine(" The Age Should Be 4 Digits and no Decimal Number ");

                Console.WriteLine();


            }


            //____________________________________________________________________________________________________________________________________________________


            else if (age >= now1.Year - 100 && age <= now1.Year - 2)                                                              //Calc information >>
            {
                DateTime now = DateTime.Now;

                int result1 = now.Year - age;                                               //in years
                int result2 = result1 * 365;                                                // in days
                int result3 = result2 * 24;                                                 // in Hours

                Console.WriteLine(" You Have : " + result1 + " Years Old,");
                Console.WriteLine(" You Lived : " + result2 + " Days, and ");
                Console.WriteLine(" Passed on you : " + result3 + " Hours !");
                Console.WriteLine();
            }


            //_______________________________________________________________________________________________________________________________________________

            else if (age <= now1.Year - 100)//age for Dead peoples
            {
                Console.WriteLine(" You Are : Dead" + " ;) ");
                Console.WriteLine();



            }
            else if (age >= now1.Year - 1 && age <= now1.Year)
            {
                //Console.WriteLine(" The Age Should Be 4 Digits and no Decimal Number ");
                Console.WriteLine(" You Are : Baby" + " ;) ");
                Console.WriteLine();
            }

            else
            {

                Console.WriteLine(" You Are not here yet " + " ;) ");
                Console.WriteLine();

            }


            // Stop a program

            Console.WriteLine(" Press any key to exit ....");
            Console.ReadKey();


        }
    }
    
}
