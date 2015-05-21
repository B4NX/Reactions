using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.IO;
using System.Net;

namespace Eve_Reaction_Calculator
{
    public static class EveCentralAPI
    {
        static WebClient client;
        static EveCentralAPI()
        {
            client = new WebClient();
        }

        const string BASEURI = "http://api.eve-central.com/api/marketstat?usesystem=30000142";
        public static Tuple<PriceData, PriceData> GetPriceData(int itemID)
        {
            string request = BASEURI + String.Format("&typeid={0}", itemID);

            WebClient client = new WebClient();
            Stream thing = client.OpenRead(request);

            XDocument doc = XDocument.Load(thing);

            XElement itemData = doc.Root.Element("marketstat").Element("type");

            XElement buyData = itemData.Element("buy");
            float buyAvg = float.Parse(buyData.Element("avg").Value);
            float buyMin = float.Parse(buyData.Element("min").Value);
            float buyMax = float.Parse(buyData.Element("max").Value);
            PriceData buyPrice = new PriceData("Buy", buyAvg, buyMin, buyMax);

            XElement sellData = itemData.Element("sell");
            float sellAvg = float.Parse(sellData.Element("avg").Value);
            float sellMin = float.Parse(sellData.Element("min").Value);
            float sellMax = float.Parse(sellData.Element("max").Value);
            PriceData sellPrice = new PriceData("Sell", sellAvg, sellMin, sellMax);

            return new Tuple<PriceData, PriceData>(buyPrice, sellPrice);
        } 
    }

    public struct PriceData
    {
        string type;
        float avgPrice;
        float minPrice;
        float maxPrice;

        public PriceData(string _type, float _avg, float _min, float _max)
        {
            this.type = _type;
            this.avgPrice = _avg;
            this.minPrice = _min;
            this.maxPrice = _max;
        }
        public PriceData(string _type, string _avg, string _min, string _max)
        {
            this.type = _type;
            this.avgPrice = float.Parse(_avg);
            this.minPrice = float.Parse(_min);
            this.maxPrice = float.Parse(_max);
        }
        public string Type
        {
            get
            {
                return this.type;
            }
        }
        public float AveragePrice
        {
            get
            {
                return this.avgPrice;
            }
        }
        public float MinimumPrice
        {
            get
            {
                return this.minPrice;
            }
        }
        public float MaximumPrice
        {
            get
            {
                return this.maxPrice;
            }
        }
    }
}
