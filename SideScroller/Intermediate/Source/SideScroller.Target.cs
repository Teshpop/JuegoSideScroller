using UnrealBuildTool;

public class SideScrollerTarget : TargetRules
{
	public SideScrollerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("SideScroller");
	}
}
