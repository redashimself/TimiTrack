using TimiTrack.MongoDB;
using Volo.Abp.Modularity;

namespace TimiTrack;

[DependsOn(
    typeof(TimiTrackMongoDbTestModule)
    )]
public class TimiTrackDomainTestModule : AbpModule
{

}
