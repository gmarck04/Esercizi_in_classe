/*Dopo aver acquisito da tastiera una serie di dati relativi alla misurazione della temperatura di una
 *certa città, scrivere il codice di un programma(OOP) in C# che determini e visualizzi la temperatura
 *più bassa e quella più alta. */

using System;

namespace Temperatura_di_una_citta
{
    class temperatura
    {
        //attributi
        string nome_citta;
        float[] temp = new float[0];
        float min, max;
        //costruttore
        public temperatura(string nome_citta)
        {
            this.nome_citta = nome_citta;
        }
        //metodi
        public void calcola_min_max()
        {
            Array.Sort(temp);
            min = temp[0];
            max = temp[temp.Length - 1];
        }
        public void inserisci_temp(float t)
        {
            Array.Resize(ref temp, temp.Length + 1);
            temp[temp.Length - 1] = t;
            calcola_min_max();
        }
        public string ToString()
        {
            return $"Nella citta {nome_citta} la temperatura minima e' {min} e la temperatura massima e' {max}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int valore = 1;            
            Console.WriteLine("Inserisci il nome della citta");
            string citta = Console.ReadLine();
            temperatura c = new temperatura(citta);
            do
            {
                Console.WriteLine("Inserisci la temperatura");
                c.inserisci_temp(float.Parse(Console.ReadLine()));
                Console.WriteLine("Vuoi continuare? Inserisci 1 per stoppare e 0 per continuare");
                valore = Int32.Parse(Console.ReadLine());
                while (valore != 0 && valore != 1)
                {
                    Console.WriteLine("reiserisci i dati");
                    c.inserisci_temp(float.Parse(Console.ReadLine()));
                }
            } while (valore == 0);
            
            Console.WriteLine(c.ToString());
        }
    }
}
