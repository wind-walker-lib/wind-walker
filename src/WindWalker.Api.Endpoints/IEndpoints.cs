using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace WindWalker.Api.Endpoints;

public interface IEndpoints
{
#pragma warning disable CA2252
    public static abstract void AddServices(IServiceCollection services, IConfiguration configuration);
    public static abstract void DefineEndpoints(IEndpointRouteBuilder app);
#pragma warning restore CA2252
}