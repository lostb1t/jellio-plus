using System.Text.Json.Serialization;

namespace Jellyfin.Plugin.Jellio.Models;

[JsonPolymorphic(TypeDiscriminatorPropertyName = "kind")]
[JsonDerivedType(typeof(VideoTrackDto), "video")]
[JsonDerivedType(typeof(AudioTrackDto), "audio")]
[JsonDerivedType(typeof(SubtitleTrackDto), "subtitle")]
public abstract class TrackDto
{
    [JsonPropertyName("idx")]
    public required int Idx { get; set; }
}

public class VideoTrackDto : TrackDto
{
    [JsonPropertyName("codec")]
    public required string Codec { get; set; }

    [JsonPropertyName("width")]
    public required int Width { get; set; }

    [JsonPropertyName("height")]
    public required int Height { get; set; }

    [JsonPropertyName("aspect_ratio")]
    public string? AspectRatio { get; set; }

    [JsonPropertyName("bit_depth")]
    public int? BitDepth { get; set; }

    [JsonPropertyName("bitrate")]
    public long? Bitrate { get; set; }

    [JsonPropertyName("color_space")]
    public string? ColorSpace { get; set; }

    [JsonPropertyName("color_transfer")]
    public string? ColorTransfer { get; set; }

    [JsonPropertyName("color_primaries")]
    public string? ColorPrimaries { get; set; }

    [JsonPropertyName("color_range")]
    public string? ColorRange { get; set; }

    [JsonPropertyName("fps")]
    public float? Fps { get; set; }

    [JsonPropertyName("interlacing")]
    public bool? Interlacing { get; set; }

    [JsonPropertyName("pixel_format")]
    public string? PixelFormat { get; set; }

    [JsonPropertyName("profile")]
    public string? Profile { get; set; }

    [JsonPropertyName("reference_frames")]
    public int? ReferenceFrames { get; set; }
}

public class AudioTrackDto : TrackDto
{
    [JsonPropertyName("codec")]
    public required string Codec { get; set; }

    [JsonPropertyName("channels")]
    public required int Channels { get; set; }

    [JsonPropertyName("sample_rate")]
    public required int SampleRate { get; set; }

    [JsonPropertyName("bit_depth")]
    public int? BitDepth { get; set; }

    [JsonPropertyName("bitrate")]
    public long? Bitrate { get; set; }

    [JsonPropertyName("channel_layout")]
    public string? ChannelLayout { get; set; }

    [JsonPropertyName("codec_tag")]
    public string? CodecTag { get; set; }

    [JsonPropertyName("language")]
    public string? Language { get; set; }

    [JsonPropertyName("profile")]
    public string? Profile { get; set; }

    [JsonPropertyName("title")]
    public string? Title { get; set; }

    [JsonPropertyName("default")]
    public bool? Default { get; set; }

    [JsonPropertyName("forced")]
    public bool? Forced { get; set; }

    [JsonPropertyName("external")]
    public bool? External { get; set; }
}

public class SubtitleTrackDto : TrackDto
{
    [JsonPropertyName("codec")]
    public string? Codec { get; set; }

    [JsonPropertyName("language")]
    public string? Language { get; set; }

    [JsonPropertyName("title")]
    public string? Title { get; set; }

    [JsonPropertyName("default")]
    public bool? Default { get; set; }

    [JsonPropertyName("forced")]
    public bool? Forced { get; set; }

    [JsonPropertyName("hearing_impaired")]
    public bool? HearingImpaired { get; set; }

    [JsonPropertyName("external")]
    public bool? External { get; set; }
}
