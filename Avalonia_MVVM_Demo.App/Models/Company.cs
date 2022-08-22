using System.Text.Json.Serialization;
using ReactiveUI;

namespace Avalonia_MVVM_Demo.App.Models;

public class Company : ReactiveObject
{
    private string? _name;
    [JsonPropertyName("name")]
    public string? Name
    {
        get => _name; 
        set => this.RaiseAndSetIfChanged(ref _name, value);
    }

    private string? _phrase;
    [JsonPropertyName("catchPhrase")]
    public string? CatchPhrase
    {
        get => _phrase; 
        set => this.RaiseAndSetIfChanged(ref _phrase, value);
    }

    private string? _bs;

    [JsonPropertyName("bs")]
    public string? Bs
    {
        get => _bs; 
        set => this.RaiseAndSetIfChanged(ref _bs, value);
    }
}