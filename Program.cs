// See https://aka.ms/new-console-template for more information

using System.Globalization;

{
    Console.WriteLine("Är det fint väder?");
    string response = Console.ReadLine();
    if (response == "j" || response =="J"){
            Console.WriteLine("Vi går på picknick!");}

        else if (response == "n" || response == "N"){
            Console.WriteLine("Vi stannar inne och läser en bok!");
           }
        else{
        Console.WriteLine("Jag förstår inte");}
          }  
