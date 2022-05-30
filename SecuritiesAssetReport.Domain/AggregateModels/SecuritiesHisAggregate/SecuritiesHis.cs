namespace FPTS.FIT.BACK.SecuritiesAssetReport.Service.SecuritiesAssetReport.Domain.AggregateModels.SecuritiesHisAggregate
{
    public class SecuritiesHis : BaseEntity, IAggregateRoot
    {
        public string ClientCode { get; private set; }
        public string StockCode { get; private set; }
        public decimal? TradingReadyAvailableTotal { get; private set; }
        public decimal? MatchedBuyintraday { get; private set; }
        public decimal? ReceivableSecuritiesT1 { get; private set; }
        public decimal? ReceivableSecuritiesT2 { get; private set; }
        public decimal? WaitingReceiveRightSecurities { get; private set; }
        public decimal? MortgageAtBank { get; private set; }
        public decimal? TransferRestricted { get; private set; }
        public decimal? TotalAmount { get; private set; }
        public float? MarketPrice { get; private set; }
        public decimal? MarketValue { get; private set; }
        public float? AveragePrice { get; private set; }
        public decimal? RootValue { get; private set; }
        public decimal? ProfitLossValue { get; private set; }
        public decimal? ProfitLossRate { get; private set; }
        public decimal? CapitalStructure { get; private set; }
        public decimal? PortfolioRate { get; private set; }
        public DateTime? Date { get; private set; }
        public DateTime? DateTime { get; private set; }

        public SecuritiesHis(string clientCode, string stockCode, decimal? tradingReadyAvailableTotal, decimal? matchedBuyintraday, decimal? receivableSecuritiesT1, decimal? receivableSecuritiesT2, decimal? waitingReceiveRightSecurities, decimal? mortgageAtBank, decimal? transferRestricted, decimal? totalAmount, float? marketPrice, decimal? marketValue, float? averagePrice, decimal? rootValue, decimal? profitLossValue, decimal? profitLossRate, decimal? capitalStructure, decimal? portfolioRate, DateTime? date, DateTime? dateTime)
        {
            ClientCode = clientCode;
            StockCode = stockCode;
            TradingReadyAvailableTotal = tradingReadyAvailableTotal;
            MatchedBuyintraday = matchedBuyintraday;
            ReceivableSecuritiesT1 = receivableSecuritiesT1;
            ReceivableSecuritiesT2 = receivableSecuritiesT2;
            WaitingReceiveRightSecurities = waitingReceiveRightSecurities;
            MortgageAtBank = mortgageAtBank;
            TransferRestricted = transferRestricted;
            TotalAmount = totalAmount;
            MarketPrice = marketPrice;
            MarketValue = marketValue;
            AveragePrice = averagePrice;
            RootValue = rootValue;
            ProfitLossValue = profitLossValue;
            ProfitLossRate = profitLossRate;
            CapitalStructure = capitalStructure;
            PortfolioRate = portfolioRate;
            Date = date;
            DateTime = dateTime;
        }
    }
}
