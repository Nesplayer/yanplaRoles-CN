using yanplaRoles.Roles.Neutral;
using MiraAPI.GameOptions;
using System;
using MiraAPI.GameOptions.OptionTypes;
using UnityEngine;
using MiraAPI.GameOptions.Attributes;
using MiraAPI.Utilities;

namespace yanplaRoles.Options.Roles;

public class ArsonistOptions : AbstractOptionGroup<Arsonist>
{ 
    public override string GroupName => "纵火犯";
    public override Color GroupColor => new Color(1f, 0.3f, 0f);

    [ModdedNumberOption("澆滅冷却", 5, 60, 2.5f, MiraNumberSuffixes.Seconds)]
    public float DouseCooldown { get; set; } = 30f;

    [ModdedNumberOption("澆滅最大数量", 1, 15, 1f)]
    public float MaxDousedPlayers { get; set; } = 3f;

    public ModdedToggleOption ArsonistHasImpVision { get; } = new("拥有内鬼视野", false);
}