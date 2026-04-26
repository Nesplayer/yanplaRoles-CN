using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;
using MiraAPI.GameOptions.OptionTypes;
using UnityEngine;
using yanplaRoles.Modifiers.Guesser;

namespace yanplaRoles.Options.Modifiers;

public class GuesserOptions : AbstractOptionGroup<Guesser>
{ 
    public override string GroupName => "赌怪";
    public override Color GroupColor => Palette.ImpostorRed;

    [ModdedNumberOption("赌怪数量", min: 0, max: 5, 1f)]
    public float NumberOfGuessers { get; set; } = 1f;

    [ModdedNumberOption("可以猜测次数", min: 1, max: 15, 1f)]
    public float PossibleGuesses { get; set; } = 15f;

    [ModdedToggleOption("可以猜测船员")]
    public bool GuessCrewmate { get; set; } = false;

    [ModdedToggleOption("可以猜测多次")]
    public bool GuessMultiple { get; set; } = false;

    [ModdedToggleOption("投票后可以猜测")]
    public bool GuessAfterVoting { get; set; } = true;
}