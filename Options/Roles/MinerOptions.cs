using MiraAPI.GameOptions;
using MiraAPI.Utilities;
using System;
using MiraAPI.GameOptions.Attributes;
using MiraAPI.GameOptions.OptionTypes;
using UnityEngine;
using yanplaRoles.Roles.Impostor;

namespace yanplaRoles.Options.Roles;

public class MinerOptions : AbstractOptionGroup<Miner>
{ 
    public override string GroupName => "矿工";
    public override Color GroupColor => Palette.ImpostorRed;

    [ModdedNumberOption("挖矿冷却", 5, 60, 2.5f, MiraNumberSuffixes.Seconds)]
    public float MineCooldown { get; set; } = 30;

    [ModdedNumberOption("最大挖洞数量", 0, 10)]
    public float MaxVents { get; set; } = 3f;
}