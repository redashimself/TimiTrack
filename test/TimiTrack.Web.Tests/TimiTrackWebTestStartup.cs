using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Volo.Abp;

namespace TimiTrack;

public class TimiTrackWebTestStartup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddApplication<TimiTrackWebTestModule>();
    }

    public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
    {
        app.InitializeApplication();
    }
}
