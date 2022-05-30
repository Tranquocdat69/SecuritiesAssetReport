namespace FPTS.FIT.BACK.SecuritiesAssetReport.Service.SecuritiesAssetReport.Domain.AggregateModels.SecuritiesAggregate
{
    public interface IInMemorySecuritiesRepository : IKeyValuePairRepository<Securities, string>
    {
    }
}
