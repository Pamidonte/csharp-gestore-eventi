using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    internal class Evento
    {
       private string titolo;
       public string data;
       public  int capienzaMassima;
       public int numeroPostiPrenotati;

        // setters
        public void SetTitolo(string titolo)
        {
          if (string.IsNullOrEmpty(titolo))
            {
                throw new Exception("il titolo dell evento non puo essere vuoto");
            }
        }
        public void SetData(string data)
        {
         if (string.IsNullOrEmpty(data))
            {
                throw new Exception("la data non è stata inserita");
            }
        }



        // getters
        public string GetTitolo()
        { return this.titolo; }

        public string GetData()
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
    }
}
