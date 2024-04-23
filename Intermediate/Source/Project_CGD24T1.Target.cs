using UnrealBuildTool;

public class Project_CGD24T1Target : TargetRules
{
	public Project_CGD24T1Target(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("Project_CGD24T1");
	}
}
