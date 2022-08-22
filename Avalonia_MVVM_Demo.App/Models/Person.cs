using System.Text.Json.Serialization;
using ReactiveUI;

namespace Avalonia_MVVM_Demo.App.Models;

public class Person : ReactiveObject
{
    private int _id;
    [JsonPropertyName("id")]
    public int Id
    {
        get => _id;
        set => this.RaiseAndSetIfChanged(ref _id, value);
    }

    private string? _name;
    [JsonPropertyName("name")]
    public string? Name
    {
        get => _name; 
        set => this.RaiseAndSetIfChanged(ref _name, value);
    }

    private string? _user;
    [JsonPropertyName("username")]
    public string? Username
    {
        get => _user; 
        set => this.RaiseAndSetIfChanged(ref _user, value);
    }

    private string? _email;
    [JsonPropertyName("email")]
    public string? Email
    {
        get => _email; 
        set => this.RaiseAndSetIfChanged(ref _email, value);
    }

    private Address? _address;
    [JsonPropertyName("address")]
    public Address? Address
    {
        get => _address; 
        set => this.RaiseAndSetIfChanged(ref _address, value);
    }

    private string? _phone;
    [JsonPropertyName("phone")]
    public string? Phone
    {
        get => _phone; 
        set => this.RaiseAndSetIfChanged(ref _phone, value);
    }

    private string? _web;
    [JsonPropertyName("website")]
    public string? Website
    {
        get => _web; 
        set => this.RaiseAndSetIfChanged(ref _web, value);
    }

    private Company? _company;
    [JsonPropertyName("company")]
    public Company? Company
    {
        get => _company;
        set => this.RaiseAndSetIfChanged(ref _company, value);
    }
}