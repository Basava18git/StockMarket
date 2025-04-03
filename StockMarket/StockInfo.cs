using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarket
{
    class StockInfo
    {
        #region Properties

        #region StockPrice
        public string price { get; set; }
        public string lastprice { get; set; }
        public string symbol { get; set; }
        #endregion

        #region CashFlow

        public string dateEnding { get; set; }

        public string reportedcurrency { get; set; }

        public string netincome { get; set; }


        #endregion

        #endregion
    }
}
