using yanplaRoles.Roles.Crewmate;
using MiraAPI.GameOptions;
using MiraAPI.Utilities;
using System;
using MiraAPI.GameOptions.Attributes;
using MiraAPI.GameOptions.OptionTypes;
using UnityEngine;

namespace yanplaRoles.Options.Roles;

public class SheriffOptions : AbstractOptionGroup<Sheriff>
{ 
    public override string GroupName => "警长";
    public override Color GroupColor => Color.yellow;

    [ModdedNumberOption("执法冷却", 5, 60, 2.5f, MiraNumberSuffixes.Seconds)]
    public float ShootCooldown { get; set; } = 30;
}