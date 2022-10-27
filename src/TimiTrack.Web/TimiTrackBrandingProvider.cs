using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace TimiTrack.Web;

[Dependency(ReplaceServices = true)]
public class TimiTrackBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "TimiTrack";
}
