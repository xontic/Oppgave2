using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Oppgave2
{
    //    Lag et C#-program for behandling av bibliotek. I et bibliotek finnes det flere bøker. Hver bok har
    //    tittel, forfatter, pris og sidetall.
    //    a) Fyll biblioteket med minst 6 bøker.Hvis tittel eller forfatter er tomt sett verdien ″ukjent″,
    //  hvis pris eller sidetall er ugyldig, sett verdien til 100.

    //  b) Skriv ut informasjon om alle bøker.
    //    c) Finn dyreste bok.
    //  d) Sorter og skriv ut alle bøker etter stigende lengde av tittel.Sorteringen skal utføres av
    //  programmet og være slik at den virker uansett opprinnelig rekkefølge.
    //  e) Lag en metode for lagring av alle bøkene til fil.
    //  Programmet skal være brukervennlig og robust.Datatyper, filtype og struktur i programmet skal du
    //  finne selv – avhengig av behov og tilpasset til løsning.

    internal class Bibliotek
    {
        private string tittel;
        private string forfatter;
        private int sidetall;
        private int pris;
        

        public string Tittel
        {
            get => tittel; // => er en forkortet måte å skrive { get { return typebetegnnelse; } }
            set
            {
                if (tittel = string.Empty) value = "ukjent";
                else tittel = value;
            }
        }

        public string Forfatter
        {
            get => forfatter;
            set
            {
                if (forfatter = string.Empty) value = "ukjent";
                else forfatter = value;
            }
        }

        public int Sidetall
        {
            get => sidetall;
            set
            {
                if (sidetall < 0) value = 0; // skjekk for å forhindre at det er negativt antall sider 
                else if (sidetall = ) value = 100; // skjekk for viss det er ukjent sette sidetallet til 100
                else sidetall = value;
            }
        }

        public int Pris
        {
            get => pris;
            set
            {
                if (pris < 0) value = 0; // for å unngå at prisen blir negativ
                else if (pris = ) value = 100;
                else pris = value;
            }
        }

        public Bibliotek(int pris, int sidetall, string forfatter, string tittel)
        {
            Pris = pris;
            Sidetall = sidetall;
            Forfatter = forfatter;
            Tittel = tittel;
        }
       

        List<Bibliotek> bok = new List<Bibliotek>();
        
        List.Add("bok 1");
        List.Add("bok 2");
        List.Add("bok 3");
        List.Add("bok 4");
        List.Add("bok 5");
        List.Add("bok 6");


        foreach (Bibliotek b in bok)
	    {
            b.SkrivUt();
            Console.WriteLine();
	    }

    public void SkrivUt()
    {
        Console.WriteLine("Tittel: \t {0}", Tittel);
        Console.WriteLine("Forfatter: \t\t {0}", Forfatter);
        Console.WriteLine("Sidetall: \t\t\t {0}", Sidetall);
        Console.WriteLine("Pris: \t\t\t\t {0}", Pris);
    }


    // finn dyreste bok med løkke 




    // sorter bøker etter stigende lengde på tittel 

    

    StreamWriter utskrift = new StreamWriter(stream); // for å skrive til fil 
    utskrift.Write(Bibliotek); // skrive ut alle bøker i biblioteket 
    utskrift.Close();




}
}
