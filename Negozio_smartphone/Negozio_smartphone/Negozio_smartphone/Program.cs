/* Nickname: @gmarck04
 * Data: 07/10/2021
 * Consegna: Dopo aver acquisito da tastiera una serie di prezzi relativi ai cellulari in vendita in un negozio,
 * scrivere il codice di un programma(OOP) in C# che visualizzi i prezzi maggiori di 100€. */

using System;

namespace Negozio_smartphone
{
    class telefono //Classe che mi registra tutti i telefoni e i loro prezzi e mi restituisce i telefoni con prezzo maggiore di 100€.
    {
        //Attributi
        protected string[] nome_telefono = new string[0];
        protected float[] prezzo_telefono = new float[0];

        public string[] nome_telefono_alto = new string[0];
        public float[] prezzo_telefono_alto = new float[0];

        //Metodi
        public void Inserisci_nome(string nome) //Metodo che inserisce i nomi nell'array nome_telefono
        {
            Array.Resize(ref nome_telefono, nome_telefono.Length + 1);
            nome_telefono[nome_telefono.Length - 1] = nome;
        }
        public void Inserisci_prezzo(float prezzo) //Metodo che inserisce i prezzi nell'array prezzi_telefono
        {
            Array.Resize(ref prezzo_telefono, prezzo_telefono.Length + 1);
            prezzo_telefono[prezzo_telefono.Length - 1] = prezzo;
            Guarda_prezzo();
        }
        protected void Guarda_prezzo() /*Metodo che guarda i telefoni con prezzo superiore a 100€ e inserisce i prezzi e in nomi 
                                        * negli array prezzi_telefono_alto e nome_telefono_alto. */
        {
            if (prezzo_telefono[prezzo_telefono.Length - 1] > 100)
            {
                Array.Resize(ref prezzo_telefono_alto, prezzo_telefono_alto.Length + 1);
                prezzo_telefono_alto[prezzo_telefono_alto.Length - 1] = prezzo_telefono[prezzo_telefono.Length - 1];

                Array.Resize(ref nome_telefono_alto, nome_telefono_alto.Length + 1);
                nome_telefono_alto[nome_telefono_alto.Length - 1] = nome_telefono[nome_telefono.Length - 1];
            }
        }
    }
    class Program
    {
        static void Main(string[] args) /* Mi richiede il prezzo e il nome del telefono, li invia alla classe telefono, che me li restituirà, 
                                         * se maggiori di 100€ e che scriverò con la Console. */
        {
            telefono c = new telefono();
            int valore = 1;        

            do
            {
                Console.WriteLine("Inserisci nome telefono");
                c.Inserisci_nome(Console.ReadLine()); //Invio nome telefono.

                Console.WriteLine("Inserisci prezzo telefono");
                c.Inserisci_prezzo(float.Parse(Console.ReadLine())); //Invio prezzo telefono.
                Console.WriteLine("Vuoi continuare? Inserisci 1 per stoppare e 0 per continuare");
                valore = Int32.Parse(Console.ReadLine()); 
                while (valore != 0 && valore != 1)
                {
                    Console.WriteLine("Errato: se vuoi continuare? Inserisci 1 per stoppare e 0 per continuare");
                    valore = Int32.Parse(Console.ReadLine());
                }
            } while (valore == 0);

            Console.Clear();

            //Stampa a schermo i valori inseriti negli array nome_telefono_alto e prezzo_telefono_alto della classe telefono.
            int cont = 0;
            for (int i = 0; i < c.prezzo_telefono_alto.Length; i++)
            {
                Console.WriteLine("Nome: {0}", c.nome_telefono_alto[cont]);
                Console.WriteLine("Prezzo {0}", c.prezzo_telefono_alto[cont]);
                cont++;
            }
        }
    }
}
