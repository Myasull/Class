using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasy
{
    class Diary
    {
        public Diary()
        {
            ratings = new List<float>();
        }

        //Stan (zmienne - pola)
        List<float> ratings;

        public static float MinGrade = 0;
        public static float MaxGrade = 6;

        //Zachowania
        public void AddRaiting(float rating)
        {
            ratings.Add(rating);
        }

        //public float CalculateAverage()
        //{
        //    float sum = 0, avg = 0;

        //    foreach (var rating in ratings)
        //    {
        //        sum += rating;
        //    }

        //    avg = sum / ratings.Count();

        //    return avg;
        //}

        //public float GiveMaxRating()
        //{
        //    return ratings.Max();
        //}

        //public float GiveMinRating()
        //{
        //    return ratings.Min();
        //}

        internal DiaryStatiscitcs ComputeStatistics()
        {
            DiaryStatiscitcs stats = new DiaryStatiscitcs();

            float sum = 0f;

            foreach (var rating in ratings)
            {
                sum += rating;
            }

            stats.AverageGrade = sum / ratings.Count();
            stats.MaxGrade = ratings.Max();
            stats.MinGrade = ratings.Min();

            return stats;
        }
    }
}
