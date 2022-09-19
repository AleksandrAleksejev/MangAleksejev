using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangAleksejev
{
    class Tegelane : IUksus//наследует от IUksus
    {
        List<Ese> esesList = new List<Ese>();//Klassis on privaatsed isendiväljad järgmise info jaoks: nimi (String) ja esemete nimekiri (List<Ese>).


        double summary;
        string nimi;
    
        public Tegelane(string nimi) // Klassis peab olema ühe parameetriga konstruktor, mille abil saab määrata nime.
        {
            this.nimi = nimi;
        }
        public int ListEse(int item ) //Äsjaloodud tegelasel ei ole ühtegi eset. Eseme lisamiseks peab olema meetod lisaEse, mis jätab argumendiks antud eseme meelde.
        {
            return item;
        }
        public int punktudearv() //Meetod info tagastab tegelase info tekstina, näidates tegelase nime, esemete arvu ja punktidearvu.
        {
            int i = 0;
            foreach (Ese item in esesList) { i += item.punktudearv(); }
            return i;
        }
        
        public string info()
        {
            Console.WriteLine($"Nimi: {nimi}");
            foreach (string line in File.ReadLines(@"..\..\..\esemedFail.txt"))
            {
                string[] row = line.Split(';');
                summary += Double.Parse(row[1]);
                Ese ese = new Ese(row[0], Int32.Parse(row[1]));
                esesList.Add(ese);
                Console.WriteLine($"Nimetus: {row[0]}, Punktide arv: {row[1]}");
            }
            Console.WriteLine($"Esemete arv: {esesList.Count}, Summa: {summary}");
            return $"{nimi}";
        }
        public void väljastaEsemed()//Klassis peab olema ka meetod väljastaEsemed, kus väljastatakse ekraanile tegelase esemed nii,et iga ese on eraldi real.
        {
            foreach(Ese item in esesList)
            {
                Console.WriteLine(item);
            }
        }
         public int CompareTo(Tegelane? other)
         {
            if (other == null) return 1;
            return m_value.CompareTo(other.m_value);
         }




    }
}
