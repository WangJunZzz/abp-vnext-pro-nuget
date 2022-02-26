using System;
using Lion.AbpProNuget.BusinessLines.Aggregates;
using Volo.Abp.Domain.Repositories;

namespace Lion.AbpProNuget.BusinessLines;

public interface IBusinessLineRepository : IRepository<BusinessLine, Guid>
{
}