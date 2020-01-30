// (C) StoryTimeStudio 2020

using UnrealBuildTool;
using System.Collections.Generic;

public class ForSakenFutureTarget : TargetRules
{
	public ForSakenFutureTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		bUsesSteam =true;
		DefaultBuildSettings = BuildSettingsVersion.V2;

		ExtraModuleNames.AddRange( new string[] { "ForSakenFuture" } );
	}
}
