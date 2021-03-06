using System;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Domain.Entities.Auditing;

namespace Lion.AbpProNuget.BusinessLines.Aggregates;

/// <summary>
/// 业务线项目
/// </summary>
public class BusinessProject : CreationAuditedEntity
{
    public Guid BusinessProjectId { get; private set; }

    /// <summary>
    /// 业务线id
    /// </summary>
    public Guid BusinessLineId { get; private set; }

 
    /// <summary>
    /// 项目名称
    /// </summary>
    [Required]
    [MaxLength(256)]
    public string Name { get; private set; }
    
    /// <summary>
    /// 描述
    /// </summary>
    [MaxLength(512)]
    public string Description { get; private set; }

    protected BusinessProject()
    {
        
    }
    
    
    public override object[] GetKeys()
    {
        return new object[] { BusinessLineId, BusinessProjectId };
    }
}