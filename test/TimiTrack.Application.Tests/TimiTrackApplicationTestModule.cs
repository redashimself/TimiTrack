using Volo.Abp.Modularity;

namespace TimiTrack;

[DependsOn(
    typeof(TimiTrackApplicationModule),
    typeof(TimiTrackDomainTestModule)
    )]
public class TimiTrackApplicationTestModule : AbpModule
{

}
