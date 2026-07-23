using System.Text.Json.Serialization;

namespace Jellyfin.Plugin.Jellio.Models;

public class ChapterDto
{
    [JsonPropertyName("id")]
    public long? Id { get; set; }

    [JsonPropertyName("start_time")]
    public double? StartTime { get; set; }

    [JsonPropertyName("end_time")]
    public double? EndTime { get; set; }

    [JsonPropertyName("title")]
    public string? Title { get; set; }
}
