using TimiTrack.MongoDB;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace TimiTrack.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(TimiTrackMongoDbModule),
    typeof(TimiTrackApplicationContractsModule)
    )]
public class TimiTrackDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
