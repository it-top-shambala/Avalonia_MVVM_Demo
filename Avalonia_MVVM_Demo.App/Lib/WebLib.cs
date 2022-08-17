using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text.Json;
using Avalonia_MVVM_Demo.App.Models;

namespace Avalonia_MVVM_Demo.App.Lib;

public static class WebLib
{
    public static IEnumerable<Person> GetPersons()
    {
        var request = WebRequest.Create("https://jsonplaceholder.typicode.com/users");
        using var stream = new StreamReader(request.GetResponse().GetResponseStream());
        var json = stream.ReadToEnd();
        var persons = JsonSerializer.Deserialize<IEnumerable<Person>>(json);
        return persons;
    }
}