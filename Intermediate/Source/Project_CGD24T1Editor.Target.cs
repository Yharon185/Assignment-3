using UnrealBuildTool;

public class Project_CGD24T1EditorTarget : TargetRules
{
	public Project_CGD24T1EditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("Project_CGD24T1");
	}
}
