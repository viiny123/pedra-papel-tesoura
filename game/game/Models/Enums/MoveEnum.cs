using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace game.Models.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum MoveEnum
    {
        [EnumMember(Value = "Rock")]
        Rock,
        [EnumMember(Value = "Paper")]
        Paper,
        [EnumMember(Value = "Scissors")]
        Scissors,
        [EnumMember(Value = "Lizard")]
        Lizard,
        [EnumMember(Value = "Spock")]
        Spock
    }
}