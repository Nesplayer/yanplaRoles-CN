using yanplaRoles.Roles.Neutral;
using MiraAPI.GameOptions;
using System;
using MiraAPI.GameOptions.OptionTypes;
using UnityEngine;
using MiraAPI.GameOptions.Attributes;
using MiraAPI.Utilities;

namespace yanplaRoles.Options.Roles;

public class AmnesiacOptions : AbstractOptionGroup<Amnesiac>
{ 
    public override string GroupName => "失忆者";
    public override Color GroupColor => new Color(0.5f, 0.7f, 1f, 1f);

    [ModdedNumberOption("箭头出现延迟", 0, 30, 1f, MiraNumberSuffixes.Seconds)]
    public float ArrowAppearDelay { get; set; } = 5f;
}