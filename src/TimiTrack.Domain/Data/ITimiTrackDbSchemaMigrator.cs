using System.Threading.Tasks;

namespace TimiTrack.Data;

public interface ITimiTrackDbSchemaMigrator
{
    Task MigrateAsync();
}
