using MiraAPI.Roles;
using UnityEngine;

namespace yanplaRoles.Roles.Crewmate;

public class Sheriff : CrewmateRole, ICustomRole
{
    public string RoleName => "警长";
    public string RoleDescription => "击杀伪装者";
    public string RoleLongDescription => RoleDescription;
    public Color RoleColor => Color.yellow;
    public ModdedRoleTeams Team => ModdedRoleTeams.Crewmate;

    public CustomRoleConfiguration Configuration => new CustomRoleConfiguration(this)
    {
        CanUseVent = false,
        OptionsScreenshot = Assets.SheriffBanner,
    };
}