using System;
using System.Collections.Generic;
using System.Text;
using TimiTrack.Localization;
using Volo.Abp.Application.Services;

namespace TimiTrack;

/* Inherit your application services from this class.
 */
public abstract class TimiTrackAppService : ApplicationService
{
    protected TimiTrackAppService()
    {
        LocalizationResource = typeof(TimiTrackResource);
    }
}
