using Volo.Abp.Settings;

namespace TimiTrack.Settings;

public class TimiTrackSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(TimiTrackSettings.MySetting1));
    }
}
