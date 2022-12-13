using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    internal class Evento
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
        public int PrenotaPosti(int PostiDaAggiungere)
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
            return PostiSomma;
        } 
        public int RimuoviPostiPrenotati(int PostiDaRimuovere)
        {
            if (this.data < DateTime.Now)
            {
                throw new Exception("l evento è gia passato");
            }
            if (PostiDaRimuovere - numeroPostiPrenotati < 0)
            {
                throw new Exception(" non ci sono cosi tanti posti da rimuovere");
            }
            int PostiFinali = numeroPostiPrenotati - PostiDaRimuovere;
            return PostiFinali;
        }
        public override string ToString()
        {
            return this.GetTitolo() + " - " + GetData(); 
        }
    }
}
