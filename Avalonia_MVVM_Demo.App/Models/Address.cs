using System.Text.Json.Serialization;
using ReactiveUI;

namespace Avalonia_MVVM_Demo.App.Models;

public class Address : ReactiveObject
{
    private string? _street;

    [JsonPropertyName("street")]
    public string? Street
    {
        get => _street; 
        set => this.RaiseAndSetIfChanged(ref _street, value);
    }

    private string? _suite;
    [JsonPropertyName("suite")]
    public string? Suite
    {
        get => _suite; 
        set => this.RaiseAndSetIfChanged(ref _suite, value);
    }

    private string? _city;
    [JsonPropertyName("city")]
    public string? City
    {
        get => _city; 
        set => this.RaiseAndSetIfChanged(ref _city, value);
    }

    private string? _zipcode;
    [JsonPropertyName("zipcode")]
    public string? Zipcode
    {
        get => _zipcode; 
        set => this.RaiseAndSetIfChanged(ref _zipcode, value);
    }

    private Geo? _geo;
    [JsonPropertyName("geo")]
    public Geo? Geo
    {
        get => _geo; 
        set => this.RaiseAndSetIfChanged(ref _geo, value);
    }
}
