﻿using System;

namespace GradingIF
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib, mis hinde kasutaja ais
            //kui kasutaja sai "A", konsool uvab "Suurepärane"
            //B, konsool kuvab "Väga hea"
            //C, konsool kuvab "Hea"
            //D, konsool kuvab "Rahuldav"
            //E, konsool kuvab "Kasin"
            //F, konsool kuvab "Puudulik"
            //kui kasutaja sisestab midagi muud, siis konsool kuvab "vale väärtus"

            Console.WriteLine("Mis hinde kasutaja sai,");
            Console.WriteLine("sisesta oma tulemus:");
            //char - character
            char userResult = Convert.ToChar(Console.ReadLine().ToUpper());
            


            if (userResult == 'A')
            {
                Console.WriteLine("Suurepärane.");
            }

            else if (userResult == 'B')

            { 
                Console.WriteLine("Väga hea."); 

            }
            else if(userResult == 'C')
            { Console.WriteLine("Hea"); }
            else if(userResult == 'D')
            { Console.WriteLine("Rahuldav"); }
            else if (userResult == 'E')
            { Console.WriteLine("Kasin"); }
            else if(userResult == 'F')
            { Console.WriteLine("Puudulik"); }

           else
            { Console.WriteLine($"{userResult} vale väärtus"); }

      
            Console.WriteLine("Kena päeva!");

                    
                        
                       
           







        }
        }
}