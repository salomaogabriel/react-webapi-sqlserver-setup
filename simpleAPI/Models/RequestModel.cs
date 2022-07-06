using System.Text.Json.Serialization;

namespace simpleAPI.Models;

public class RequestModel
{
    [JsonPropertyName("name")]
    public string Name {get; set;}
}
