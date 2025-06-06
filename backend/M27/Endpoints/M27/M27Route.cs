using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using M27.Services;

namespace M27.Endpoints.M27;

public static class M27Route
{
    public static RouteHandlerBuilder AddM27Route(this IEndpointRouteBuilder app)
    {
        return app.MapGet("/", (string name, IM27Service m27Service) => new GetM27Response($"Hello, {m27Service.GetObfuscatedName(name)}!"));
    }
}