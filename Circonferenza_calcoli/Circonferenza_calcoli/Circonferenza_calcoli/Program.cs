/*Tramite la programmazione ad oggetti scrivere un programma in C#, che dopo aver letto in input il raggio di una 
 *circonferenza, calcoli e visualizzi in output la misura del diametro (2*raggio), della circonferenza (2*raggio*pi greco)
 *e la sua area (r^2*pi greco). Utilizzare la funzione Math.PI .*/

using System;

namespace Circonferenza_calcoli
{
    class Circonferenza
    {
        double raggio;
        double diametro { get; set; }
        double circonferenza { get; set; }
        double area { get; set; }

        public Circonferenza(double raggio)
        {
            this.raggio = raggio;
            calcola();
        }
        public void calcola()
        {
            diametro = raggio * 2;
            circonferenza = 2 * raggio * Math.PI;
            area = raggio * raggio * Math.PI;
        }

        public void Mostra_misure()
        {
            Console.WriteLine("Il diametro vale: {0}", diametro);
            Console.WriteLine("la circonferenza vale: {0}", circonferenza);
            Console.WriteLine("l'area vale: {0}", area);
        }        
    }

    class Program
    {
        public static double raggio_valore()
        {
            double raggio;
            Console.WriteLine("Inserisci il raggio:");
            raggio = double.Parse(Console.ReadLine());
            while (raggio < 0)
            {
                Console.WriteLine("Inserisci un raggio maggiore di 0:");
                raggio = double.Parse(Console.ReadLine());
            }
            return raggio;
        }
        static void Main(string[] args)
        {
            Circonferenza c = new Circonferenza(raggio_valore());
            c.Mostra_misure();
        }
    }
}
