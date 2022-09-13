using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangAleksejev
{
    interface IUksus
    {
        int punktidearv()//Klassis on privaatsed isendiväljad järgmise info jaoks: nimetus (String) ja punktide arv (int).
        {
            throw new NotImplementedException();
        }
        string info()
        {
            throw new NotSupportedException();
        }
    }


    
}
//1.Liides Üksus sisaldab
//1. int-tüüpi parameetriteta meetodit punktideArv;
//2.String - tüüpi parameetriteta meetodit info.
