// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class TempoUnrealFestDemoTarget : TargetRules
{
	public TempoUnrealFestDemoTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V5;
		IncludeOrderVersion = EngineIncludeOrderVersion.Unreal5_4;
		ExtraModuleNames.Add("TempoUnrealFestDemo");

        if (Platform == UnrealTargetPlatform.Win64)
        {
		// Not sure why this is necessary on Windows in this project. It isn't in our other projects.
		AdditionalLinkerArguments = "/FORCE:MULTIPLE";
		bOverrideBuildEnvironment = true;
                ToolChainName = "TempoVCToolChain";
        }
        else if (Platform == UnrealTargetPlatform.Mac)
        {
                ToolChainName = "TempoMacToolChain";
        }
        else if (Platform == UnrealTargetPlatform.Linux)
        {
                ToolChainName = "TempoLinuxToolChain";
        }
	}
}
