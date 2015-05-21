using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eve_Reaction_Calculator;

namespace Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tuple<PriceData, PriceData> data = EveCentralAPI.GetPriceData(34);

            object[] sqlResults = SQLConnector.RunQuery("SELECT typeID,typeName FROM [Mosaic].[dbo].[invTypes] WHERE typeID=34");
            Console.Write(sqlResults[0]);
            Console.Write(" ");
            Console.WriteLine(sqlResults[1]);

            Console.ReadLine();
        }
    }
}
