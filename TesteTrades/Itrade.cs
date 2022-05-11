using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteITrades
{
    //interface relates to Trade class
    public interface Itrade
    {

        double Value { get; set; }
        string ClientSector { get; set; }
       
    }
}
