// ============================================================
//  DEXTMTRES — .NET Core Web API
//  Project ID : DEXTMTRES-2026
//  Build Tag  : DEXTMTRES-BUILD-2026-FINAL
// ============================================================

using DEXTMTRES.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddSingleton<DextmtresService>();

var app = builder.Build();

app.MapGet("/", () => new
{
    Project = "DEXTMTRES",
    Message = "Welcome to DEXTMTRES .NET Core API",
    BuildTag = DextmtresService.BUILD_TAG,
    Version = "1.0.0"
});

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
