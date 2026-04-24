namespace DEXTMTRES.Services;

/// <summary>
/// Core service for DEXTMTRES project identity and operations.
/// </summary>
public class DextmtresService
{
    public const string PROJECT_CODE = "DEXTMTRES";
    public const string BUILD_TAG = "DEXTMTRES-BUILD-2026-FINAL";

    public string GetBuildTag() => BUILD_TAG;

    public Dictionary<string, string> GetProjectMeta() => new()
    {
        ["ProjectCode"] = PROJECT_CODE,
        ["BuildTag"] = BUILD_TAG,
        ["Framework"] = ".NET 8.0",
        ["Type"] = "ASP.NET Core Web API",
        ["UniqueId"] = "DXT-9F3A-MTRE-7B2C-S001"
    };
}
