using MiraAPI.Roles;
using UnityEngine;


namespace yanplaRoles.Roles.Neutral;


public class NeutralGhostRole : CrewmateGhostRole, ICustomRole 
{
    public string RoleName => "中立鬼魂";
    public string RoleDescription => "你死了，享受来世吧";
    public string RoleLongDescription => RoleDescription;
    public Color RoleColor => Color.gray;
    public ModdedRoleTeams Team => ModdedRoleTeams.Custom;

    public CustomRoleConfiguration Configuration => new CustomRoleConfiguration(this)
    {
        HideSettings = true,
        TasksCountForProgress = false,
    };

    public override void SpawnTaskHeader(PlayerControl playerControl)
    {

    }

    public override bool DidWin(GameOverReason gameOverReason)
    {
        return false;
    }

    public NeutralGhostRole()
    {
        this.SetCanDoTasks(false);
    }
}