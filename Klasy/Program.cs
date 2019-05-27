using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasy
{
    class Program
    {
        static void Main(string[] args)
        {
            Diary diary = new Diary();
            //diary.AddRaiting(5);
            //diary.AddRaiting(5.5f);
            //diary.AddRaiting(4.7f);

            //float avg = diary.CalculateAverage();
            //float max = diary.GiveMaxRating();
            //float min = diary.GiveMinRating();

            for(; ; )
            {
                Console.Write("Wprowadź ocenę z zakresu 1 - 6: ");

                float rating;
                bool result = float.TryParse(Console.ReadLine(), out rating);

                if (rating == 7)
                {
                    break;
                }


                if (result)
                {
                    if (rating > 0 && rating <= 6)
                    {
                        diary.AddRaiting(rating);
                    }
                    else
                    {
                        Console.WriteLine("Niepoprawna liczba, podaj liczbę z zakresu 1-6");
                    }

                }   
            }
            Console.WriteLine("średnia ocen to: " + diary.CalculateAverage());
            Console.WriteLine("Najwyższa ocena to: " + diary.GiveMaxRating());
            Console.WriteLine("Najniższa ocena to: " + diary.GiveMinRating());
            Console.ReadKey();

            Diary diary2 = new Diary();
            Diary diary3 = new Diary();
        }
    }

}
