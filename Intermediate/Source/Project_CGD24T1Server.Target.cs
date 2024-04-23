using UnrealBuildTool;

public class Project_CGD24T1ServerTarget : TargetRules
{
	public Project_CGD24T1ServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("Project_CGD24T1");
	}
}
