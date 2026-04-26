using System.Collections.Generic;
using MiraAPI.Roles;
using UnityEngine;

namespace yanplaRoles.Roles.Impostor;

public class Miner : ImpostorRole, ICustomRole
{
    public string RoleName => "矿工";
    public string RoleDescription => "在地图上放置通风管道";
    public string RoleLongDescription => RoleDescription;
    public Color RoleColor => Palette.ImpostorRed;
    public ModdedRoleTeams Team => ModdedRoleTeams.Impostor;

    public readonly List<Vent> Vents = new List<Vent>();

    public CustomRoleConfiguration Configuration => new CustomRoleConfiguration(this)
    {
    };

    public string GetCustomEjectionMessage(NetworkedPlayerInfo player)
    {
        if (ExileController.Instance.initData.confirmImpostor) return $"Oops! {player.PlayerName} dug their own grave!";
        return DestroyableSingleton<TranslationController>.Instance.GetString(StringNames.ExileTextNonConfirm, (Il2CppInterop.Runtime.InteropTypes.Arrays.Il2CppReferenceArray<Il2CppSystem.Object>)System.Array.Empty<object>());
    }
}