// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.IO;

public class TempoUnrealFestDemo : ModuleRules
{
	public TempoUnrealFestDemo(ReadOnlyTargetRules Target) : base(Target)
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
			"TempoSensors",
			"TempoSensorsShared",
			"TempoCamera",
			"TempoGeographic",
		});

        // This path is incorrect for non-Windows platforms in GeoReferencing.Build.cs. Copy it correctly here.
        if (Target.Platform != UnrealTargetPlatform.Win64)
        {
            string GeoReferencingPluginPath = Path.Combine(EngineDirectory, "Plugins/Runtime/GeoReferencing");
            RuntimeDependencies.Add(Path.Combine(GeoReferencingPluginPath, "Resources/PROJ/*"), StagedFileType.UFS);
        }

		PrivateDependencyModuleNames.AddRange(new string[] {  });
	}
}
