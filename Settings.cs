using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Vosk.WebApi;

[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)]
public sealed class Settings
{
    public const string SectionName = "VoskSettings";

    [Required]
    public string WebSocketUrl { get; init; } = null!;
    [Required]
    public int ResultChunkSize { get; init; }
    [Required]
    public int WavSamplingRateHz { get; init; }
    [Required]
    public int WavBitRate { get; init; }
}