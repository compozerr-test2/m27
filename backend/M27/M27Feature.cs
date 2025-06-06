using Core.Feature;
using Microsoft.Extensions.DependencyInjection;
using M27.Services;

namespace M27;

public class M27Feature : IFeature
{

    void IFeature.ConfigureServices(IServiceCollection services)
    {
        services.AddSingleton<IM27Service, M27Service>();
    }
}