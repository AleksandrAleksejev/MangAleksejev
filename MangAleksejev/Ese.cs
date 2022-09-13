using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangAleksejev
{

    abstract class Ese : IUksus
    {
        public string nimetus;
        public int punktidearv;
    

        public Ese(string nimetus, int punktudearv)//Klassis peab olema kahe parameetriga konstruktor, mille abil saab määrata nimetuse ja punktidearvu
        {
            this.nimetus = nimetus;
            this.punktidearv = punktudearv;

        }
        public int punktudearv() //Meetod punktideArv tagastab punktide arvu.
        {
            return punktidearv;
        }
        public string info()//Meetod info tagastab selle eseme nimetuse.
        {
            return nimetus;
        }
    }
}   

