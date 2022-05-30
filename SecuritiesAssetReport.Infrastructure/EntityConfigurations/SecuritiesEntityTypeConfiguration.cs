namespace FPTS.FIT.BACK.SecuritiesAssetReport.Service.SecuritiesAssetReport.Infrastructure.EntityConfigurations
{
    public class SecuritiesEntityTypeConfiguration : IEntityTypeConfiguration<Securities>
    {
        public void Configure(EntityTypeBuilder<Securities> entityTypeBuilder)
        {
            entityTypeBuilder.ToTable(SecuritiesAssetReportDbContext.TableStockAll);

            entityTypeBuilder.Ignore(c => c.Id);
            entityTypeBuilder.Ignore(c => c.DomainEvents);

            entityTypeBuilder.HasKey(x => x.ClientCode).HasName("ACLIENTCODE");
            entityTypeBuilder.Property(o => o.ClientCode).UsePropertyAccessMode(PropertyAccessMode.Field).HasColumnName("ACLIENTCODE").HasColumnType("VARCHAR2(10 CHAR)");
            entityTypeBuilder.Property(o => o.StockCode).UsePropertyAccessMode(PropertyAccessMode.Field).HasColumnName("ASTOCKCODE").HasColumnType("VARCHAR2(20 CHAR)");
            entityTypeBuilder.Property(o => o.AvailableOrderSecurities).UsePropertyAccessMode(PropertyAccessMode.Field).HasColumnName("AAVAL_ORDER").HasColumnType("NUMBER");
            entityTypeBuilder.Property(o => o.AvailableOrderSecuritiesMar).UsePropertyAccessMode(PropertyAccessMode.Field).HasColumnName("AAVAL_ORDER_MAR").HasColumnType("NUMBER");
            entityTypeBuilder.Property(o => o.AvailableOrderSecuritiesTotal).UsePropertyAccessMode(PropertyAccessMode.Field).HasColumnName("AAVAL_ORDER_TOTAL").HasColumnType("NUMBER");
            entityTypeBuilder.Property(o => o.PendingSellintraday).UsePropertyAccessMode(PropertyAccessMode.Field).HasColumnName("APEND_SELL").HasColumnType("NUMBER");
            entityTypeBuilder.Property(o => o.PendingSellintradayMar).UsePropertyAccessMode(PropertyAccessMode.Field).HasColumnName("APEND_SELL_MAR").HasColumnType("NUMBER");
            entityTypeBuilder.Property(o => o.PendingSellintradayTotal).UsePropertyAccessMode(PropertyAccessMode.Field).HasColumnName("APEND_SELL_TOTAL").HasColumnType("NUMBER");
            entityTypeBuilder.Property(o => o.MarketPrice).UsePropertyAccessMode(PropertyAccessMode.Field).HasColumnName("AMARKET_PRICE").HasColumnType("NUMBER");
            entityTypeBuilder.Property(o => o.MarketValue).UsePropertyAccessMode(PropertyAccessMode.Field).HasColumnName("AMARKET_VALUE").HasColumnType("NUMBER");
            entityTypeBuilder.Property(o => o.AveragePrice).UsePropertyAccessMode(PropertyAccessMode.Field).HasColumnName("AAVG_PRICE").HasColumnType("NUMBER");
            entityTypeBuilder.Property(o => o.OldAveragePrice).UsePropertyAccessMode(PropertyAccessMode.Field).HasColumnName("AOLDAVG_PRICE").HasColumnType("NUMBER");
            entityTypeBuilder.Property(o => o.TotalAmount).UsePropertyAccessMode(PropertyAccessMode.Field).HasColumnName("ATOTAL_AMOUNT").HasColumnType("NUMBER");
            entityTypeBuilder.Property(o => o.RootValue).UsePropertyAccessMode(PropertyAccessMode.Field).HasColumnName("AROOT_VALUE").HasColumnType("NUMBER");
            entityTypeBuilder.Property(o => o.TradingReadyAvailable).UsePropertyAccessMode(PropertyAccessMode.Field).HasColumnName("ATRADING_READY").HasColumnType("NUMBER");
            entityTypeBuilder.Property(o => o.TradingReadyAvailableMarMor).UsePropertyAccessMode(PropertyAccessMode.Field).HasColumnName("ATRADING_READY_MAR").HasColumnType("NUMBER");
            entityTypeBuilder.Property(o => o.TradingReadyAvailableTotal).UsePropertyAccessMode(PropertyAccessMode.Field).HasColumnName("ATRADING_READY_TOTAL").HasColumnType("NUMBER");
            entityTypeBuilder.Property(o => o.MatchedSellintraday).UsePropertyAccessMode(PropertyAccessMode.Field).HasColumnName("ASELL_INTRADAY").HasColumnType("NUMBER");
            entityTypeBuilder.Property(o => o.MatchedSellintradayMar).UsePropertyAccessMode(PropertyAccessMode.Field).HasColumnName("ASELL_INTRADAYMAR").HasColumnType("NUMBER");
            entityTypeBuilder.Property(o => o.MatchedSellintradayTotal).UsePropertyAccessMode(PropertyAccessMode.Field).HasColumnName("ASELL_INTRADAYTOTAL").HasColumnType("NUMBER");
            entityTypeBuilder.Property(o => o.MatchedBuyintraday).UsePropertyAccessMode(PropertyAccessMode.Field).HasColumnName("ABUY_INTRADAY").HasColumnType("NUMBER");
            entityTypeBuilder.Property(o => o.ReceivableSecuritiesT1).UsePropertyAccessMode(PropertyAccessMode.Field).HasColumnName("AT1").HasColumnType("NUMBER");
            entityTypeBuilder.Property(o => o.ReceivableSecuritiesT2).UsePropertyAccessMode(PropertyAccessMode.Field).HasColumnName("AT2").HasColumnType("NUMBER");
            entityTypeBuilder.Property(o => o.WaitingReceiveRightSecurities).UsePropertyAccessMode(PropertyAccessMode.Field).HasColumnName("AWAIT_REC_RIGHT").HasColumnType("NUMBER");
            entityTypeBuilder.Property(o => o.MortgageAtBank).UsePropertyAccessMode(PropertyAccessMode.Field).HasColumnName("AMORTGATE_BANK").HasColumnType("NUMBER");
            entityTypeBuilder.Property(o => o.TransferRestricted).UsePropertyAccessMode(PropertyAccessMode.Field).HasColumnName("ATRANSFER_RESTRICTED").HasColumnType("NUMBER");
            entityTypeBuilder.Property(o => o.LimitAmount).UsePropertyAccessMode(PropertyAccessMode.Field).HasColumnName("ALIMIT_AMOUNT").HasColumnType("NUMBER");
            entityTypeBuilder.Property(o => o.DividendBonusShare).UsePropertyAccessMode(PropertyAccessMode.Field).HasColumnName("ADIVIDENS_BONUS").HasColumnType("NUMBER");
        }
    }
}
