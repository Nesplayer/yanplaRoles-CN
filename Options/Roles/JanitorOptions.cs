using yanplaRoles.Roles.Impostor;
using MiraAPI.GameOptions;
using System;
using MiraAPI.GameOptions.OptionTypes;
using UnityEngine;

namespace yanplaRoles.Options.Roles;

public class JanitorOptions : AbstractOptionGroup<Janitor>
{ 
    public override string GroupName => "清洁工";
    public override Color GroupColor => Palette.ImpostorRed;

    public ModdedToggleOption JanitorCanVent { get; } = new("可以使用管道", true);
}