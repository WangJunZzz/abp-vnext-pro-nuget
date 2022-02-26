using System;
using System.Linq;
using System.Threading.Tasks;
using Lion.AbpProNuget.BusinessLines;
using Lion.AbpProNuget.BusinessLines.Aggregates;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Lion.AbpProNuget.EntityFrameworkCore.BusinessLines;

public class EfCoreBusinessLineRepository: EfCoreRepository<IAbpProNugetDbContext, BusinessLine, Guid>, IBusinessLineRepository
{
    public EfCoreBusinessLineRepository(IDbContextProvider<IAbpProNugetDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }
    
    
    public override async Task<IQueryable<BusinessLine>> WithDetailsAsync()
    {
        return (await GetQueryableAsync()).IncludeDetails();
    }
}