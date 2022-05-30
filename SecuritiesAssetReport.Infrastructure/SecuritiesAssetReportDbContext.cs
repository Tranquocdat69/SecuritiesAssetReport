namespace FPTS.FIT.BACK.SecuritiesAssetReport.Service.SecuritiesAsset.Infrastructure
{
    public class SecuritiesAssetReportDbContext : DbContext, IUnitOfWork
    {
        public const string TableStockDaily = "TBCTS_STOCK_DAILY";
        public const string ViewPrice = "VPRICE_STOCKLIVEPRICE";
        public const string TableStockAll = "TBCTS_STOCK_ALL";
        public DbSet<Securities> Securities { get; set; }

        public SecuritiesAssetReportDbContext(DbContextOptions options) : base(options)
        {
        }

        public Task<bool> SaveEntitiesAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<BaseEntity>();
            modelBuilder.Ignore<BaseDomainEvent>();
        }
    }
}
