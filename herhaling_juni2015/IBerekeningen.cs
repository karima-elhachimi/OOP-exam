using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herhaling_juni2015
{
    interface IBerekeningen: IComparable
    {
        decimal BerekenTotaal();
        decimal BerekenBelastingen();
    }
}
