using TimiTrack.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace TimiTrack.Permissions;

public class TimiTrackPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(TimiTrackPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(TimiTrackPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<TimiTrackResource>(name);
    }
}
