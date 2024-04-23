using UnrealBuildTool;

public class Project_CGD24T1ClientTarget : TargetRules
{
	public Project_CGD24T1ClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("Project_CGD24T1");
	}
}
