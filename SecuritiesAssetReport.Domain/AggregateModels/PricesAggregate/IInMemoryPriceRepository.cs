namespace FPTS.FIT.BACK.SecuritiesAssetReport.Service.SecuritiesAssetReport.Domain.AggregateModels.PricesAggregate
{
    public interface IInMemoryPriceRepository : IKeyValuePairRepository<Price, string>
    {
    }
}
