/* Nickname: @gmarck04
 * Data: 01/10/2021
 * Tramite la programmazione ad oggetti scrivere un programma in C#, che dopo aver letto in input il raggio di una 
 *circonferenza, calcoli e visualizzi in output la misura del diametro (2*raggio), della circonferenza (2*raggio*pi greco)
 *e la sua area (r^2*pi greco). Utilizzare la funzione Math.PI .*/

using System;

namespace Circonferenza_calcoli
{
    class Circonferenza //Restituisce il diametro, la circonferenza e l'area.
    {
        //Attributi
        double raggio;
        double diametro { get; set; }
        double circonferenza { get; set; }
        double area { get; set; }
        //Costruttore
        public Circonferenza(double raggio)
        {
            this.raggio = raggio;
            calcola();
        }
        //Metodi
        public void calcola() //esegue i calcoli del diametro, della circonferenza e dell'area.
        {
            diametro = raggio * 2;
            circonferenza = 2 * raggio * Math.PI;
            area = raggio * raggio * Math.PI;
        }

        public string ToString() //Restituisce la frase contenente il diametro, la circonferenza e l'area.
        {
            return $"Il diametro vale: {diametro} \nLa circonferenza vale: {circonferenza} \nL'area vale: {area}";
        }        
    }

    class Program
    {
        public static double raggio_valore() //Richiede il valore del raggio.
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
        static void Main(string[] args) //Invia il valore del raggio e restituisce il Metodo ToString della classe Circonferenza.
        {
            Circonferenza c = new Circonferenza(raggio_valore()); //Invio al costruttore della variabile restituita dalla funzione raggio_valore.
            Console.WriteLine(c.ToString()); //Stampa il valore restituito del Metodo ToString della classe Circonferenza.
        }
    }
}
