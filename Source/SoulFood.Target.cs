// Copyright 2019 hianhianhian

using UnrealBuildTool;
using System.Collections.Generic;

public class SoulFoodTarget : TargetRules
{
	public SoulFoodTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;

		ExtraModuleNames.AddRange( new string[] { "SoulFood" } );
	}
}
