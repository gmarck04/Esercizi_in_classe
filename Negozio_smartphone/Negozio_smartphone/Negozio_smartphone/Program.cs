/*Dopo aver acquisito da tastiera una serie di prezzi relativi ai cellulari in vendita in un negozio,
 * scrivere il codice di un programma(OOP) in C# che visualizzi i prezzi maggiori di 100€. */

using System;

namespace Negozio_smartphone
{
    class telefono
    {
        string[] nome_telefono = new string[0];
        float[] prezzo_telefono = new float[0];

        string[] nome_telefono_alto = new string[0];
        float[] prezzo_telefono_alto = new float[0];

        //metodi
        public void Inserisci_nome(string nome)
        {
            Array.Resize(ref nome_telefono, nome_telefono.Length + 1);
            nome_telefono[nome_telefono.Length - 1] = nome;
        }
        public void Inserisci_prezzo(float prezzo)
        {
            Array.Resize(ref prezzo_telefono, prezzo_telefono.Length + 1);
            prezzo_telefono[prezzo_telefono.Length - 1] = prezzo;
            Guarda_prezzo();
        }
        public void Guarda_prezzo()
        {
            if (prezzo_telefono[prezzo_telefono.Length - 1] > 100)
            {
                Array.Resize(ref prezzo_telefono_alto, prezzo_telefono_alto.Length + 1);
                prezzo_telefono_alto[prezzo_telefono_alto.Length - 1] = prezzo_telefono[prezzo_telefono.Length - 1];

                Array.Resize(ref nome_telefono_alto, nome_telefono_alto.Length + 1);
                nome_telefono_alto[nome_telefono_alto.Length - 1] = nome_telefono[nome_telefono.Length - 1];
            }
        }
        public void ToString()
        {
            int cont = 0;
            for (int i = 0; i < prezzo_telefono_alto.Length; i++)
            {                
                Console.WriteLine("Nome: {0}", nome_telefono_alto[cont]);
                Console.WriteLine("Prezzo {0}", prezzo_telefono_alto[cont]);
                cont++;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            telefono c = new telefono();
            int valore = 1;        

            do
            {
                Console.WriteLine("Inserisci nome telefono");
                c.Inserisci_nome(Console.ReadLine());

                Console.WriteLine("Inserisci prezzo telefono");
                c.Inserisci_prezzo(float.Parse(Console.ReadLine()));
                Console.WriteLine("Vuoi continuare? Inserisci 1 per stoppare e 0 per continuare");
                valore = Int32.Parse(Console.ReadLine());
                while (valore != 0 && valore != 1)
                {
                    Console.WriteLine("Inserisci nome telefono");
                    c.Inserisci_nome(Console.ReadLine());

                    Console.WriteLine("Inserisci prezzo telefono");
                    c.Inserisci_prezzo(float.Parse(Console.ReadLine()));
                }
            } while (valore == 0);

            Console.Clear();
            c.ToString();
        }
    }
}
