using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;
using MiraAPI.GameOptions.OptionTypes;
using UnityEngine;

namespace yanplaRoles.Options;

public class GameOptions : AbstractOptionGroup
{ 
    public override string GroupName => "游戏";
    public override Color GroupColor => Color.white;

    [ModdedToggleOption("在雾中隐藏通风动画")]
    public bool HideVentInFog { get; set; } = false;
}