using System.Text.Json.Serialization;

namespace Jellyfin.Plugin.Jellio.Models;

public class BehaviorHintsDto
{
    [JsonPropertyName("videoSize")]
    public long? VideoSize { get; set; }

    [JsonPropertyName("filename")]
    public string? Filename { get; set; }
}
