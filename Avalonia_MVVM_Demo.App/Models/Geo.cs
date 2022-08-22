using System.Text.Json.Serialization;
using ReactiveUI;

namespace Avalonia_MVVM_Demo.App.Models;

public class Geo : ReactiveObject
{
    private string? _lat;
    [JsonPropertyName("lat")]
    public string? Lat
    {
        get => _lat;
        set => this.RaiseAndSetIfChanged(ref _lat, value);
    }

    private string? _lng;
    [JsonPropertyName("lng")]
    public string? Lng
    {
        get => _lng;
        set => this.RaiseAndSetIfChanged(ref _lng, value);
    }
}