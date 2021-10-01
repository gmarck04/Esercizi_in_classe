/*Tramite la programmazione ad oggetti scrivere un programma in C# che dopo aver letto in input 3 età, di 3 persone diverse,
 *calcoli e visualizzi in output la loro media.*/

using System;

namespace Persone
{
    class Persone
    {
        string nome1, nome2, nome3;
        int eta1, eta2, eta3;
        float media;

        public Persone(string nome1, string nome2, string nome3)
        {
            this.nome1 = nome1;
            this.nome2 = nome2;
            this.nome3 = nome3;
            eta1 = 0;
            eta2 = 0;
            eta3 = 0;
            media = 0;
        }
        public void prendiEta(int etaaggiungi1, int etaaggiungi2, int etaaggiungi3)
        {
            eta1 += etaaggiungi1;
            eta2 += etaaggiungi2;
            eta3 += etaaggiungi3;
        }
        public void calcolaMedia()
        {
            media = (eta1 + eta2 + eta3) / 3;
            Console.WriteLine("media: ", media);

        }
        public void visualizzaEtaENome()
        {
            Console.WriteLine("Nome persona: {0}, eta': {1}", nome1, eta1);
            Console.WriteLine("Nome persona: {0}, eta': {1}", nome2, eta2);
            Console.WriteLine("Nome persona: {0}, eta': {1}", nome3, eta3);
        }

        static void Main(string[] args)
        {
            string nome1, nome2, nome3;
            int eta1, eta2, eta3;

            Console.WriteLine("Inserici nome 1: ");
            nome1 = Console.ReadLine();
            Console.WriteLine("Inserici eta 1: ");
            eta1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Inserici nome 2: ");
            nome2 = Console.ReadLine();
            Console.WriteLine("Inserici eta 2: ");
            eta2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Inserici nome 3: ");
            nome3 = Console.ReadLine();
            Console.WriteLine("Inserici eta 3: ");
            eta3 = Convert.ToInt32(Console.ReadLine());

            Persone c = new Persone(nome1, nome2, nome3);
            c.prendiEta(eta1, eta2, eta3);
            c.visualizzaEtaENome();
            c.calcolaMedia();
        }
    }
}