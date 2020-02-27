using System;

namespace CalcolaLibrary
{
    public static class Calcola
    {
        public static double Raddoppia(double num)
        {
            double resp = num * 2;
            return resp;
        }
        public static double SommaMonete(double[] monete)
        {
            double resp = 0;
            for(int i = 0; i < monete.Length; i++)
            {
                resp = resp + monete[i];
            }
            return resp;
        }
    }
}
