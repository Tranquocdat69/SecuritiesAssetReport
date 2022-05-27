namespace FPTS.FIT.BACK.SecuritiesAssetReport.Service.SecuritiesAssetReport.Domain.AggregateModels.SecuritiesAggregate
{
    public class Securities
    {
        public string ClientCode { get; private set; }
        public string StockCode { get; private set; }
        public decimal? AvailableOrderSecurities { get; private set; }
        public decimal? AvailableOrderSecuritiesMar { get; private set; }
        public decimal? AvailableOrderSecuritiesTotal { get; private set; }
        public decimal? PendingSellintraday { get; private set; }
        public decimal? PendingSellintradayMar { get; private set; }
        public decimal? PendingSellintradayTotal { get; private set; }
        public float? MarketPrice { get; private set; }
        public decimal? MarketValue { get; private set; }
        public float? AveragePrice { get; private set; }
        public float? OldAveragePrice { get; private set; }
        public decimal? TotalAmount { get; private set; }
        public decimal? RootValue { get; private set; }
        public decimal? TradingReadyAvailable { get; private set; }
        public decimal? TradingReadyAvailableMarMor { get; private set; }
        public decimal? TradingReadyAvailableTotal { get; private set; }
        public decimal? MatchedSellintraday { get; private set; }
        public decimal? MatchedSellintradayMar { get; private set; }
        public decimal? MatchedSellintradayTotal { get; private set; }
        public decimal? MatchedBuyintraday { get; private set; }
        public decimal? ReceivableSecuritiesT1 { get; private set; }
        public decimal? ReceivableSecuritiesT2 { get; private set; }
        public decimal? WaitingReceiveRightSecurities { get; private set; }
        public decimal? MortgageAtBank { get; private set; }
        public decimal? TransferRestricted { get; private set; }
        public decimal? LimitAmount { get; private set; }
        public decimal? DividendBonusShare { get; private set; }

        public Securities(string clientCode, string stockCode, decimal? availableOrderSecurities, decimal? availableOrderSecuritiesMar, decimal? availableOrderSecuritiesTotal, decimal? pendingSellintraday, decimal? pendingSellintradayMar, decimal? pendingSellintradayTotal, float? marketPrice, decimal? marketValue, float? averagePrice, float? oldAveragePrice, decimal? totalAmount, decimal? rootValue, decimal? tradingReadyAvailable, decimal? tradingReadyAvailableMarMor, decimal? tradingReadyAvailableTotal, decimal? matchedSellintraday, decimal? matchedSellintradayMar, decimal? matchedSellintradayTotal, decimal? matchedBuyintraday, decimal? receivableSecuritiesT1, decimal? receivableSecuritiesT2, decimal? waitingReceiveRightSecurities, decimal? mortgageAtBank, decimal? transferRestricted, decimal? limitAmount, decimal? dividendBonusShare)
        {
            ClientCode = clientCode;
            StockCode = stockCode;
            AvailableOrderSecurities = availableOrderSecurities;
            AvailableOrderSecuritiesMar = availableOrderSecuritiesMar;
            AvailableOrderSecuritiesTotal = availableOrderSecuritiesTotal;
            PendingSellintraday = pendingSellintraday;
            PendingSellintradayMar = pendingSellintradayMar;
            PendingSellintradayTotal = pendingSellintradayTotal;
            MarketPrice = marketPrice;
            MarketValue = marketValue;
            AveragePrice = averagePrice;
            OldAveragePrice = oldAveragePrice;
            TotalAmount = totalAmount;
            RootValue = rootValue;
            TradingReadyAvailable = tradingReadyAvailable;
            TradingReadyAvailableMarMor = tradingReadyAvailableMarMor;
            TradingReadyAvailableTotal = tradingReadyAvailableTotal;
            MatchedSellintraday = matchedSellintraday;
            MatchedSellintradayMar = matchedSellintradayMar;
            MatchedSellintradayTotal = matchedSellintradayTotal;
            MatchedBuyintraday = matchedBuyintraday;
            ReceivableSecuritiesT1 = receivableSecuritiesT1;
            ReceivableSecuritiesT2 = receivableSecuritiesT2;
            WaitingReceiveRightSecurities = waitingReceiveRightSecurities;
            MortgageAtBank = mortgageAtBank;
            TransferRestricted = transferRestricted;
            LimitAmount = limitAmount;
            DividendBonusShare = dividendBonusShare;
        }
    }
}
