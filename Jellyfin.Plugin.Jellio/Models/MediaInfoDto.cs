using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Jellyfin.Plugin.Jellio.Models;

public class MediaInfoDto
{
    [JsonPropertyName("filename")]
    public required string Filename { get; set; }

    [JsonPropertyName("container")]
    public required string Container { get; set; }

    [JsonPropertyName("size")]
    public required long Size { get; set; }

    [JsonPropertyName("duration")]
    public required double Duration { get; set; }

    [JsonPropertyName("tracks")]
    public required List<TrackDto> Tracks { get; set; }

    [JsonPropertyName("bitrate")]
    public long? Bitrate { get; set; }

    [JsonPropertyName("chapters")]
    public List<ChapterDto>? Chapters { get; set; }
}
