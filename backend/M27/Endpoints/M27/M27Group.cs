using Carter;
using Microsoft.AspNetCore.Routing;

namespace M27.Endpoints.M27;

public class M27Group : CarterModule
{
    public M27Group() : base("/m27")
    {
        WithTags(nameof(M27));
    }

    public override void AddRoutes(IEndpointRouteBuilder app)
    {
        app.AddM27Route();
    }
}