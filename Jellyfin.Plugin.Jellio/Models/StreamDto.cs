using System.Text.Json.Serialization;

namespace Jellyfin.Plugin.Jellio.Models;

public class StreamDto
{
    [JsonPropertyName("url")]
    public required string Url { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("behaviorHints")]
    public required BehaviorHintsDto BehaviorHints { get; set; }

    [JsonPropertyName("mediaInfo")]
    public MediaInfoDto? MediaInfo { get; set; }
}
