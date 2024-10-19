// See https://aka.ms/new-console-template for more information
using System;
using System.Threading.Channels;
using System.IO;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Security.Cryptography;
using System.Collections.Generic;
using exercises;
using System.Diagnostics;
using System.Collections;
using System.Threading;
namespace exercises
{
    public class Exercises
    {


        public static void Main(string[] args)
        {
            var petesCard = new PaymentCard(2);
            Console.WriteLine(petesCard);

            PaymentTerminal lunchCafeteria = new PaymentTerminal();
            Console.WriteLine(lunchCafeteria);
            decimal change = lunchCafeteria.DrinkCoffee(10);
            Console.WriteLine($"remaining change : {change}");

            change = lunchCafeteria.DrinkCoffee(5);
            Console.WriteLine($"remaining change : {change}");
            change = lunchCafeteria.EatLunch(20);
            Console.WriteLine($"remaining change : {change}");

            Console.WriteLine(lunchCafeteria);

            bool wasSuccesfull = lunchCafeteria.EatLunch(petesCard);
            Console.WriteLine($" there was enough money : {wasSuccesfull}");
            lunchCafeteria.AddMoneyToCard(petesCard, 100m);

            wasSuccesfull = lunchCafeteria.EatLunch(petesCard);
            Console.WriteLine($" there was enough money : {wasSuccesfull}");

            wasSuccesfull = lunchCafeteria.DrinkCoffee(petesCard);
            Console.WriteLine($" there was enough money : {wasSuccesfull}");

            Console.WriteLine(petesCard);
            Console.WriteLine(lunchCafeteria);






        }

    }  

      
        

        




    
    

   

        /* again:
             Console.WriteLine("enter number how many times u want to print statement\n");
             int num = Convert.ToInt32(Console.ReadLine());
         Print(num);
         repeat:
             Console.WriteLine("Play again? (Y/N)");
             string ans = Console.ReadLine();
             switch (ans.ToUpper())
             {
                 case "Y": goto again; break;
                 case "N": break; //continue
                 default: goto repeat; break;
             }*/
    
}
   

    