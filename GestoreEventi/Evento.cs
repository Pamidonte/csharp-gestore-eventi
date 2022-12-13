using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    public class Evento
    {
       private string titolo;
       public DateTime data;
       public  int capienzaMassima;
       public int numeroPostiPrenotati;

        // setters
        public void SetTitolo(string titolo)
        {
          if (string.IsNullOrEmpty(titolo))
            {
                throw new Exception("il titolo dell evento non puo essere vuoto");
            }
          this.titolo = titolo;
        }
        public void SetData(string data)
        {
            if (string.IsNullOrEmpty(data))
            {
                throw new Exception("la data non è stata inserita");
            }
            DateTime dataOraAttuale = DateTime.Now;
            DateTime dataInserita = DateTime.Parse(data);

            if (dataInserita <= dataOraAttuale)
            {
                Console.WriteLine("La data inserita si trova nel passato");

            }
            this.data = dataInserita;

        }
        // getters
        public string GetTitolo()
        { return this.titolo; }

        public DateTime GetData()
        { return this.data; }

        public int GetCapienzaMassima()
        { return this.capienzaMassima; }

        public int GetNumeroPostiPrenotati()
        { return this.numeroPostiPrenotati; }

        // costruttore
        public Evento(string titolo, string data, int capienzaMassima, int numeroPostiPrenotati)
        {
            SetTitolo(titolo);
            SetData(data);
            this.capienzaMassima = capienzaMassima;
            this.numeroPostiPrenotati = numeroPostiPrenotati;
        }

        // metodi 
        public void PrenotaPosti(int PostiDaAggiungere)
        {
            if ( this.data < DateTime.Now)
            {
                throw new Exception("l evento è gia passato");
            }
            if (PostiDaAggiungere <= 0)
            {
                throw new Exception("il numero inserito non è valido");
            }
            int PostiSomma = PostiDaAggiungere + this.numeroPostiPrenotati;
            if (PostiSomma > this.capienzaMassima) 
            {
                throw new Exception("non ci sono piu posti prenotabili");
            }
            this.numeroPostiPrenotati = PostiSomma;
        } 
        public void RimuoviPostiPrenotati(int PostiDaRimuovere)
        {
            if (this.data < DateTime.Now)
            {
                throw new Exception("l evento è gia passato");
            }
            if (numeroPostiPrenotati - PostiDaRimuovere < 0)
            {
                throw new Exception(" non ci sono cosi tanti posti da rimuovere");
            }

            this.numeroPostiPrenotati = numeroPostiPrenotati - PostiDaRimuovere;          
        }
        public override string ToString()
        {
            return this.GetTitolo() + " - " + GetData(); 
        }
    }
}
