using Microsoft.AspNetCore.Mvc;

namespace DEXTMTRES.Controllers;

/// <summary>
/// DEXTMTRES — Unique Project Controller
/// Project ID: DEXTMTRES-2026
/// </summary>
[ApiController]
[Route("api/[controller]")]
public class DextmtresController : ControllerBase
{
    private static readonly string ProjectId = "DEXTMTRES-2026";
    private static readonly DateTime CreatedAt = new DateTime(2026, 4, 24);

    [HttpGet]
    public IActionResult GetProjectInfo()
    {
        return Ok(new
        {
            ProjectName = "DEXTMTRES",
            ProjectId = ProjectId,
            Description = "DEXTMTRES is a uniquely identified .NET Core project build.",
            Version = "1.0.0",
            CreatedAt = CreatedAt.ToString("yyyy-MM-dd"),
            Author = "DEXTMTRES Team",
            Status = "Active"
        });
    }

    [HttpGet("signature")]
    public IActionResult GetSignature()
    {
        return Ok(new
        {
            Signature = "DEXTMTRES::CORE::2026::UNIQUE",
            Hash = "DXT-9F3A-MTRE-7B2C-S001",
            Timestamp = DateTime.UtcNow
        });
    }

    [HttpGet("ping")]
    public IActionResult Ping()
    {
        return Ok(new { Message = "DEXTMTRES is alive!", Time = DateTime.UtcNow });
    }
}
