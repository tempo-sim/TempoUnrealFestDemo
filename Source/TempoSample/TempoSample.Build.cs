// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class TempoSample : ModuleRules
{
	public TempoSample(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
	
		PublicDependencyModuleNames.AddRange(new string[]
		{
			// Unreal
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			// Tempo
			"TempoCore",
		});

		PrivateDependencyModuleNames.AddRange(new string[] {  });
	}
}
