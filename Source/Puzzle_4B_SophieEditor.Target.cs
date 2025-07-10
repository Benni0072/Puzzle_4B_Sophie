// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class Puzzle_4B_SophieEditorTarget : TargetRules
{
	public Puzzle_4B_SophieEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V5;

		ExtraModuleNames.AddRange( new string[] { "Puzzle_4B_Sophie" } );
	}
}
