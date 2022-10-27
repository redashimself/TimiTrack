using TimiTrack.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace TimiTrack.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class TimiTrackPageModel : AbpPageModel
{
    protected TimiTrackPageModel()
    {
        LocalizationResourceType = typeof(TimiTrackResource);
    }
}
