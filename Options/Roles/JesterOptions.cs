using yanplaRoles.Roles.Neutral;
using MiraAPI.GameOptions;
using System;
using MiraAPI.GameOptions.OptionTypes;
using UnityEngine;

namespace yanplaRoles.Options.Roles;

public class JesterOptions : AbstractOptionGroup<Jester>
{ 
    public override string GroupName => "小丑";
    public override Color GroupColor => new Color32(236, 98, 165, byte.MaxValue);

    public ModdedToggleOption JesterCanVent { get; } = new("小丑可以使用管道", false);
    public ModdedToggleOption JesterHasImpVision { get; } = new("拥有内鬼视野", true);
}