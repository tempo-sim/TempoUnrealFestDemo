// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class TempoUnrealFestDemoEditorTarget : TargetRules
{
	public TempoUnrealFestDemoEditorTarget( TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V5;
		IncludeOrderVersion = EngineIncludeOrderVersion.Unreal5_4;
		ExtraModuleNames.Add("TempoUnrealFestDemo");

                if (Platform == UnrealTargetPlatform.Win64)
                {
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
