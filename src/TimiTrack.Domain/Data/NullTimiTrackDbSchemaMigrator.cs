using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace TimiTrack.Data;

/* This is used if database provider does't define
 * ITimiTrackDbSchemaMigrator implementation.
 */
public class NullTimiTrackDbSchemaMigrator : ITimiTrackDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
