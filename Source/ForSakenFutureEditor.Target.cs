// (C) StoryTimeStudio 2020

using UnrealBuildTool;
using System.Collections.Generic;

public class ForSakenFutureEditorTarget : TargetRules
{
	public ForSakenFutureEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		bUsesSteam =true;
		DefaultBuildSettings = BuildSettingsVersion.V2;
     
		ExtraModuleNames.AddRange( new string[] { "ForSakenFuture" } );
	}
}
