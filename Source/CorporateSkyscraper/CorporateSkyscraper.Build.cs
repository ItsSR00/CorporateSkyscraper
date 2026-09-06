// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class CorporateSkyscraper : ModuleRules
{
	public CorporateSkyscraper(ReadOnlyTargetRules Target) : base(Target)
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
			"CorporateSkyscraper",
			"CorporateSkyscraper/Variant_Platforming",
			"CorporateSkyscraper/Variant_Platforming/Animation",
			"CorporateSkyscraper/Variant_Combat",
			"CorporateSkyscraper/Variant_Combat/AI",
			"CorporateSkyscraper/Variant_Combat/Animation",
			"CorporateSkyscraper/Variant_Combat/Gameplay",
			"CorporateSkyscraper/Variant_Combat/Interfaces",
			"CorporateSkyscraper/Variant_Combat/UI",
			"CorporateSkyscraper/Variant_SideScrolling",
			"CorporateSkyscraper/Variant_SideScrolling/AI",
			"CorporateSkyscraper/Variant_SideScrolling/Gameplay",
			"CorporateSkyscraper/Variant_SideScrolling/Interfaces",
			"CorporateSkyscraper/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
