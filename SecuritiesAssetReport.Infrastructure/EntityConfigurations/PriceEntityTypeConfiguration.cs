namespace FPTS.FIT.BACK.SecuritiesAssetReport.Service.SecuritiesAssetReport.Infrastructure.EntityConfigurations
{
    public class PriceEntityTypeConfiguration : IEntityTypeConfiguration<Price>
    {
        public void Configure(EntityTypeBuilder<Price> entityTypeBuilder)
        {
            entityTypeBuilder.ToView(SecuritiesAssetReportDbContext.ViewPrice);

            entityTypeBuilder.Ignore(c => c.Id);
            entityTypeBuilder.Ignore(c => c.DomainEvents);

            entityTypeBuilder.HasKey(x => x.StockCode).HasName("SYMBOL");
            entityTypeBuilder.Property(o => o.StockCode).UsePropertyAccessMode(PropertyAccessMode.Field).HasColumnName("SYMBOL").HasColumnType("VARCHAR2(24 CHAR)");
            entityTypeBuilder.Property(o => o.ClosePrice).UsePropertyAccessMode(PropertyAccessMode.Field).HasColumnName("LAST").HasColumnType("NUMBER");
        }
    }
}
