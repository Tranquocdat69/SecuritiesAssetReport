namespace FPTS.FIT.BACK.SecuritiesAssetReport.Service.SecuritiesAssetReport.Domain.AggregateModels.PricesAggregate
{
    public class Prices
    {
        public DateTime? DateTime { get; private set; }
        public string StockCode { get; private set; }
        public float? ClosePrice { get; private set; }

        public Prices(DateTime? dateTime, string stockCode, float? closePrice)
        {
            DateTime = dateTime;
            StockCode = stockCode;
            ClosePrice = closePrice;
        }
    }
}
