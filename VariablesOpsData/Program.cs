using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesOpsData
{
    class Program
    {
        static void Main(string[] args)
        {

            //int age = 65;
            //string why = "because i said so";
            //char firstInitial = 'L';

            ////floating point types
            //float floatNumber= 2.164403304897294849383961032f;
            //Console.WriteLine(floatNumber);

            //double doubleNumber = 2.164403304897294849383961032d;
            //Console.WriteLine(doubleNumber);

            //decimal decimalNumber = 2.164403304897294849383961032m;
            //Console.WriteLine(decimalNumber);



            ////initializing birthmonth variable
            //int birthMonth = 12;
            ////printing the value of birthmonth to the console
            //Console.WriteLine(birthMonth);


            ////Jessica is 23 years old
            ////Sam is 47
            ////Jessica is younger than Sam
            //int jessicaAge = 23;
            //int samAge = 47;
            //Console.WriteLine(jessicaAge < samAge);

            //Console.WriteLine("What is the the name on the reservation?");
            //string reserveName = Console.ReadLine();

            //Console.WriteLine("How many people are in your party?");
            //int numberOfPeople = int.Parse(Console.ReadLine());

            //double totalBill;

            //double amountEach = 13.53d;
            //Console.WriteLine(totalBill = numberOfPeople * amountEach);
            //Console.WriteLine(totalBill);

            //Console.WriteLine("Reservation: " + reserveName);
            //Console.WriteLine("Total Due: $" + totalBill);


            //int costPerPackage = 8;
            //int totalAmount = 40;
            //int totalPackages = (totalAmount / costPerPackage);
            //Console.WriteLine("Packages you can buy: " + totalPackages);

            //int totalAmount = 12;
            //int perBox = 3;
            //int totalBoxes = (totalAmount / perBox);

            //Console.WriteLine("Total number of boxes of envelopes: " + totalBoxes);

            //int juliaMiles = 47;
            //int milesMoreThan = 30;
            //int pernavMiles = (juliaMiles - milesMoreThan);
            //Console.WriteLine("Pernav ran " + pernavMiles + " miles more than Julia");

            Console.WriteLine("What is your Name?");
            string nameOfDonor = (Console.ReadLine());
            Console.WriteLine("What is your address?");
            string donorAddress = (Console.ReadLine());
            Console.WriteLine("What is you email address?");
            string donorEmail = (Console.ReadLine());
            Console.WriteLine("For which fiscal year?");
            string fiscalYear = (Console.ReadLine());



            Console.WriteLine("How much do you want to donate?");
            Console.WriteLine("How many ones?");
            int numberOfOnes = int.Parse(Console.ReadLine());
            Console.WriteLine("How many fives?");
            int numberOfFives = int.Parse(Console.ReadLine());
            Console.WriteLine("How many tens?");
            int numberOfTens = int.Parse(Console.ReadLine());
            Console.WriteLine("How many twenties?");
            int numberOfTwenties = int.Parse(Console.ReadLine());
            Console.WriteLine("How many fifties?");
            int numberOfFifties = int.Parse(Console.ReadLine());
            Console.WriteLine("How many hundreds?");
            int numberOfHundreds = int.Parse(Console.ReadLine());
            Console.WriteLine("How many quarters?");
            double numberOfQuarters = int.Parse(Console.ReadLine());

            double totalDonationAmount = (numberOfOnes + (numberOfFives * 5) + 
                (numberOfTens * 10) + (numberOfTwenties * 20) + (numberOfFifties * 50) +
                (numberOfHundreds * 100) + (numberOfQuarters * .25));

            Console.WriteLine("Total amount of donations: $ " + totalDonationAmount);
            Console.WriteLine("Donor Name: " + nameOfDonor);
            Console.WriteLine("Donor Address: " + donorAddress);
            Console.WriteLine("Donor Email address: " + donorEmail);







        }
    }
}
