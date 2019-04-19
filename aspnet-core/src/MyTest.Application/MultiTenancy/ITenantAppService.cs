using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MyTest.MultiTenancy.Dto;

namespace MyTest.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

