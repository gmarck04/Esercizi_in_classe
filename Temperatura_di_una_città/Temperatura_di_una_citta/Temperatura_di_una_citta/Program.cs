/* Nickname: @gmarck04
 * Data: 07/10/2021
 * Consegna: Dopo aver acquisito da tastiera una serie di dati relativi alla misurazione della temperatura di una
 * certa città, scrivere il codice di un programma(OOP) in C# che determini e visualizzi la temperatura più bassa e quella più alta. */

using System;

namespace Temperatura_di_una_citta
{
    class temperatura //Restituisce la temperatura minima, massima e il nome della città, prendendo i dati dal Main.
    {
        //Attributi
        string nome_citta;
        float[] temp = new float[0];
        float min, max;
        //Costruttore
        public temperatura(string nome_citta)
        {
            this.nome_citta = nome_citta;
        }
        //Metodi
        public void calcola_min_max() //Calcola la temperatura massima e la temperatura minima.
        {
            Array.Sort(temp);
            min = temp[0];
            max = temp[temp.Length - 1];
        }
        public void inserisci_temp(float t) //Inserisce la temperatura nell'array temp da un valore preso dal Main.
        {
            Array.Resize(ref temp, temp.Length + 1);
            temp[temp.Length - 1] = t;
            calcola_min_max();
        }
        public string ToString() //Restituisce la frase contenente il nome della citta, la temperatura massima e la temperatura minima.
        {
            return $"Nella citta {nome_citta} la temperatura minima e' {min} e la temperatura massima e' {max}";
        }
    }
    class Program
    {
        static void Main(string[] args) //Invia il nome e la temperatura della città e restituisce il Metodo ToString della classe temperatura.
        {
            int valore = 1;            
            Console.WriteLine("Inserisci il nome della citta");
            string citta = Console.ReadLine();
            temperatura c = new temperatura(citta); //Invio al costruttore della stringa citta.
            do
            {
                Console.WriteLine("Inserisci la temperatura");
                c.inserisci_temp(float.Parse(Console.ReadLine())); //Invio temperatura.
                Console.WriteLine("Vuoi continuare? Inserisci 1 per stoppare e 0 per continuare");
                valore = Int32.Parse(Console.ReadLine());
                while (valore != 0 && valore != 1)
                {
                    Console.WriteLine("reiserisci i dati");
                    c.inserisci_temp(float.Parse(Console.ReadLine())); //Invio temperatura.
                }
            } while (valore == 0);
            
            Console.WriteLine(c.ToString()); //Stampa il valore restituito del Metodo ToString della classe temperatura.
        }
    }
}
