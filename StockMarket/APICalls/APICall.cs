using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace StockMarket.APICalls
{
    class APICall
    {
        #region APIRequest
        public async Task<StockInfo> GetStockPrice(String symbol)
        {
            string apiKey = "U2U2W992LP02GP0C";
            string url = $"https://www.alphavantage.co/query?function=GLOBAL_QUOTE&symbol={symbol}&apikey={apiKey}";
            using (HttpClient http = new HttpClient())
            {
                HttpResponseMessage responseMessage = await http.GetAsync(url);
                if (responseMessage.IsSuccessStatusCode)
                {
                    var data = await responseMessage.Content.ReadAsStringAsync();
                    JObject jsonData = JObject.Parse(data);
                    return new StockInfo
                    {
                        price = (string)jsonData["Global Quote"]["05. price"],
                        lastprice = (string)jsonData["Global Quote"]["08. previous close"],
                        symbol = (string)jsonData["Global Quote"]["01. symbol"]
                    };
                }
                else
                {
                    return null;
                }

            }        
        }
        #endregion

    }
}
