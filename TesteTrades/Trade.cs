using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteITrades;
using TradesClientSectorKeys;
using TradesParameterValueKeys;
using TradesParameterRiskKeys;

namespace TestTrades
{

    //main class
    //Itrade interface heritage
    public class Trade : Itrade
    {

        public double Value { get; set; }
        public string ClientSector { get; set; }

        //override onstructor for method call
        public Trade()
        {


        }
        //consttuctor for value setting
        public Trade(double value, string clientSector)
        {
            Value = value;
            ClientSector = clientSector;
        }


        //bussiness method for identify the trade risk
        public List<string> RiskAnalysis (List<Trade> portfolio)
        {

            ClientSectorKeys clientSectorKeys = new ClientSectorKeys();
            ParameterValueKeys parameterValueKeys = new ParameterValueKeys();
            ParameterRiskKeys parameterRiskKeys = new ParameterRiskKeys();  
            

            List<string> tradeCategories = new List<string>();

            foreach (var trade in portfolio)
            {
                if (trade.ClientSector == clientSectorKeys.ClientSectorPublic & trade.Value > parameterValueKeys.Value)
                {

                    tradeCategories.Add(parameterRiskKeys.MediumRisk);
                }
                else if (trade.ClientSector == clientSectorKeys.ClientSectorPrivate & trade.Value > parameterValueKeys.Value)
                {

                    tradeCategories.Add(parameterRiskKeys.HighRisk);
                }
                else
                {
                    tradeCategories.Add(parameterRiskKeys.LowRisk);

                }

            }            

            return tradeCategories;

        }

    }
}
