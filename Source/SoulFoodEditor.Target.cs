// Copyright 2019 hianhianhian

using UnrealBuildTool;
using System.Collections.Generic;

public class SoulFoodEditorTarget : TargetRules
{
	public SoulFoodEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;

		ExtraModuleNames.AddRange( new string[] { "SoulFood" } );
	}
}
