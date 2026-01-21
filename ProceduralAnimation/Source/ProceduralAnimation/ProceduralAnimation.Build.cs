// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class ProceduralAnimation : ModuleRules
{
	public ProceduralAnimation(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"ProceduralAnimation",
			"ProceduralAnimation/Variant_Platforming",
			"ProceduralAnimation/Variant_Platforming/Animation",
			"ProceduralAnimation/Variant_Combat",
			"ProceduralAnimation/Variant_Combat/AI",
			"ProceduralAnimation/Variant_Combat/Animation",
			"ProceduralAnimation/Variant_Combat/Gameplay",
			"ProceduralAnimation/Variant_Combat/Interfaces",
			"ProceduralAnimation/Variant_Combat/UI",
			"ProceduralAnimation/Variant_SideScrolling",
			"ProceduralAnimation/Variant_SideScrolling/AI",
			"ProceduralAnimation/Variant_SideScrolling/Gameplay",
			"ProceduralAnimation/Variant_SideScrolling/Interfaces",
			"ProceduralAnimation/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
