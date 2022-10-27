using TimiTrack.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace TimiTrack.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class TimiTrackController : AbpControllerBase
{
    protected TimiTrackController()
    {
        LocalizationResource = typeof(TimiTrackResource);
    }
}
