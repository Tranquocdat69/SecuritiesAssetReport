namespace FPTS.FIT.BACK.SecuritiesAssetReport.Service.SecuritiesAssetReport.Domain.AggregateModels.SecuritiesTransactionLogAggregate
{
    public class SecuritiesTransactionLog : BaseEntity, IAggregateRoot
    {
        public DateTime? DateTime { get; private set; }
        public string RefID { get; private set; }
        public string ClientCode { get; private set; }
        public string StockCode { get; private set; }
        public string BuySell { get; private set; }
        public decimal? Quantity { get; private set; }
        public float? Price { get; private set; }
        public decimal? TradedAmount { get; private set; }
        public float? AveragePrice { get; private set; }
        public decimal? RootValue { get; private set; }
        public decimal? ProfitLossValue { get; private set; }
        public decimal? ProfitLossRate { get; private set; }
        public string Type { get; private set; }
        public string Desc { get; private set; }
        public int? Averaged { get; private set; }

        public SecuritiesTransactionLog(DateTime? dateTime, string refID, string clientCode, string stockCode, string buySell, decimal? quantity, float? price, decimal? tradedAmount, float? averagePrice, decimal? rootValue, decimal? profitLossValue, decimal? profitLossRate, string type, string desc, int? averaged)
        {
            DateTime = dateTime;
            RefID = refID;
            ClientCode = clientCode;
            StockCode = stockCode;
            BuySell = buySell;
            Quantity = quantity;
            Price = price;
            TradedAmount = tradedAmount;
            AveragePrice = averagePrice;
            RootValue = rootValue;
            ProfitLossValue = profitLossValue;
            ProfitLossRate = profitLossRate;
            Type = type;
            Desc = desc;
            Averaged = averaged;
        }
    }
}
