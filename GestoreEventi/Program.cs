// See https://aka.ms/new-console-template for more information

using GestoreEventi;

Console.WriteLine("inserisci il titolo evento");
string titolo = Console.ReadLine();

Console.WriteLine("inserisci la data dell'evento");
string data = Console.ReadLine();

Console.WriteLine("inserisci il numero massimo di posti disponibili");
int capienzaMassima = int.Parse(Console.ReadLine());

Evento eventoFiera = new Evento (titolo, data, capienzaMassima,0);
Console.WriteLine(eventoFiera.GetTitolo() + " " + eventoFiera.GetData() + " " + eventoFiera.GetCapienzaMassima() + "" + eventoFiera.GetNumeroPostiPrenotati());

Console.WriteLine("vuoi prenotare dei posti? rispondi con si o no");
string ControlloPrenotazioni = Console.ReadLine().ToLower();
 
while (ControlloPrenotazioni != "si" && ControlloPrenotazioni != "no")
{
    Console.WriteLine("non puoi inserire qualcosa diverso da si o no");
    ControlloPrenotazioni = Console.ReadLine().ToLower();
}

if (ControlloPrenotazioni == "si")
{
    Console.WriteLine("quanti posti vuoi prenotare?");
    int postiPrenotati = int.Parse(Console.ReadLine());
    eventoFiera.PrenotaPosti(postiPrenotati);
}

int PostiAncoraDisponibili = eventoFiera.GetCapienzaMassima() - eventoFiera.GetNumeroPostiPrenotati();

Console.WriteLine("il totale dei posti prenotati è: " + eventoFiera.GetNumeroPostiPrenotati());
Console.WriteLine("il totale dei posti disponibili è: " + PostiAncoraDisponibili);

Console.WriteLine("vuoi disdire dei posti? rispondi con si o no");
string ControlloPostiDaDisdire = Console.ReadLine().ToLower();
while (ControlloPostiDaDisdire != "si" && ControlloPostiDaDisdire != "no")
{
    Console.WriteLine("non puoi inserire qualcosa diverso da si o no");
    ControlloPostiDaDisdire = Console.ReadLine().ToLower();
}

while (ControlloPostiDaDisdire == "si")
{
    Console.WriteLine("quanti posti vuoi disdire?");
    int PostiDaRimuovere = int.Parse(Console.ReadLine());
    eventoFiera.RimuoviPostiPrenotati(PostiDaRimuovere);
    Console.WriteLine("il totale dei posti prenotati è: " + eventoFiera.GetNumeroPostiPrenotati());
    PostiAncoraDisponibili = eventoFiera.GetCapienzaMassima() - eventoFiera.GetNumeroPostiPrenotati();
    Console.WriteLine("il totale dei posti disponibili è: " + PostiAncoraDisponibili);
    Console.WriteLine("desideri ripetere l'operazione? rispondi con si o no");
    ControlloPostiDaDisdire = Console.ReadLine().ToLower();


}