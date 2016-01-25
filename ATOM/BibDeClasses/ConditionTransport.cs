using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibDeClasses
{
    public enum ConditionTransport : byte
    {
       
        Air = 1,
        Oxygene = 2,
        Couveuse = 4 ,
        Isolement = 8,
        Contact = 16,

    }
}
