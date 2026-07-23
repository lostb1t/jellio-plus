using System.Text.Json.Serialization;

namespace Jellyfin.Plugin.Jellio.Models;

public class BehaviorHintsDto
{
    [JsonPropertyName("videoSize")]
    public long? VideoSize { get; set; }

    [JsonPropertyName("filename")]
    public string? Filename { get; set; }

    [JsonPropertyName("other")]
    public BehaviorHintsOtherDto? Other { get; set; }
}

public class BehaviorHintsOtherDto
{
    [JsonPropertyName("mediaInfo")]
    public MediaInfoDto? MediaInfo { get; set; }
}
