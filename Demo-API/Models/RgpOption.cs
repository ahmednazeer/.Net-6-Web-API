using System.Text.Json.Serialization;

namespace Demo_API.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RgpOption
    {
        Knight=1,
        Mage=2,
        Cleric=3,
    }
}