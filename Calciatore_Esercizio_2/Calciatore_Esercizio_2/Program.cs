//Ripetere l’esercizio 1 leggendo i dati in input dei seguenti attributi: calciatore, ruolo, squadra e golsegnati.

using System;

namespace Calciatore_Esercizio_2
{
    class Calciatore
    {
        string nome;
        string squadra;
        string ruolo;
        int golsegnati;

        public Calciatore(string nome, string squadra, string ruolo)
        {
            this.nome = nome;
            this.squadra = squadra;
            this.ruolo = ruolo;
            golsegnati = 0;
        }
        public void aggiungiGol(int gol)
        {
            golsegnati += gol;
        }
        public void visualizzaGolAsseganti()
        {
            Console.WriteLine("Nome: {0}, Squadra: {1}, ruolo: {2}, gol segnati: {3}", nome, squadra, ruolo, golsegnati);
        }

        static void Main(string[] args)
        {
            string nome, squadra, ruolo;
            int gol;
            Console.WriteLine("Inserici nome calciatore: ");
            nome = Console.ReadLine();
            Console.WriteLine("Inserici squadra calciatore: ");
            squadra = Console.ReadLine(); 
            Console.WriteLine("Inserici ruolo calciatore: ");
            ruolo = Console.ReadLine();
            Console.WriteLine("Inserici gol nuovi calciatore: ");
            gol = Convert.ToInt32(Console.ReadLine());

            Calciatore c = new Calciatore(nome, squadra, ruolo);
            c.aggiungiGol(gol);
            c.visualizzaGolAsseganti();
        }
    }
}
