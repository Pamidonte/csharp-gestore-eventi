using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    public class ProgrammaEventi
    {
        private string titolo;
        private List<Evento> listaEventi;

        public ProgrammaEventi(string titolo)
        {
            this.titolo = titolo;
            this.listaEventi= new List<Evento>();
           
        }

        public void aggiungiEvento(Evento eventoaggiunto)
        {
            listaEventi.Add(eventoaggiunto);
        }

        public List<Evento> getEventiData(string data)
        {
            List<Evento> eventi= new List<Evento>();


            foreach (var item in listaEventi)
            {
            
                DateTime dataInserita = DateTime.Parse(data);
                if (item.GetData() == dataInserita)
                {
                    eventi.Add(item);
                }
            }
            return eventi;
        }

        public static void stampaListaEvento(List<Evento> listaStampa)
        {
            foreach(var item in listaStampa)
            {
                Console.WriteLine(item.ToString());
            }
        }
        public int numeroEventiPresenti()
        {
            return this.listaEventi.Count;
        }
        public void cancellaEventi()
        {
           this.listaEventi.Clear();
        }
        public string stampaNomeProgrammaEvento()
        {
            string risultato = string.Empty;
            foreach(var item in this.listaEventi)
            {
                risultato += "\n" + item.GetData().ToString() + " - " + item.GetTitolo();
            } 
            return risultato;
        }







    }


}
