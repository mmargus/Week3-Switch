using System;

namespace GraidingSwitch
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

           switch(userResult)

            {
                case 'A':
                    Console.WriteLine("Suurepärane");
                    break;
                case 'B':
                    Console.WriteLine("Väga hea.");
                    break;
                case 'C':
                    Console.WriteLine("Hea.");
                    break;
                case 'D':
                    Console.WriteLine("Rahuldav.");
                    break;
                case 'E':
                    Console.WriteLine("Kasin.");
                    break;
                case 'F':
                    Console.WriteLine("Puudulik.");
                    break;


                default:
                    Console.WriteLine($" {userResult} vale väärtus");
                    break;


            }
            Console.WriteLine("Kena päeva!");



        }
    }
}
