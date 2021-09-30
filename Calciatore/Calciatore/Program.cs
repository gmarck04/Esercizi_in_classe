/*Tramite la programmazione ad oggetti scrivere il codice di un programma, che dopo aver costruito
 *la classe Calciatore visualizzi l'output: il nome del calciatore, il ruolo, la squadra ed i gol
 *segnati (i dati vengono assegnati all'interno del codice). */

using System; /*Istruzione per l'utilizzo della libreria system, che permette di usare alcune classi
               *console e i metodi write e readline. */

namespace Calciatore //Parola chiave per dichiarare un ambito, che contiene un set di oggetti correlati.
                      
{
    class Calciatore //definizione della classe pagina 20 libro.
    {
        //Attributi
        string nome;
        string squadra;
        string ruolo;
        int golsegnati;

        //Metodo di default: costruttore
        public Calciatore(string nome, string squadra, string ruolo)
        {
            this.nome = nome; //La parola "this" serve per inizializzare i campi membro (attributi)
            this.squadra = squadra;
            this.ruolo = ruolo;
            golsegnati = 0;
        }

        //Metodi
        public void aggiornaGolSegnati(int gol)
        {
            golsegnati += gol;
        }

        public void visualizzaGol()
        {
            Console.WriteLine("{0} - {2} -gol seganti: {1}, {3}", nome, golsegnati, ruolo, squadra);
        }

        static void Main(string[] args)
        {
            Calciatore c = new Calciatore("Filippo Inzaghi", "Milan", "Attaccante");
            c.visualizzaGol();
            c.aggiornaGolSegnati(10);
            c.visualizzaGol();
        }
    }
}