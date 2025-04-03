using System.Text.Json.Serialization;

namespace OpenDoor2.Response
{
    public class ApplicantResponse
    {
        //[JsonPropertyName("id")]
        public int Id { get; set; }
        //[JsonPropertyName("name")]
        public string Name { get; set; }
        //[JsonPropertyName("date_time")]
        public DateTime DateTime { get; set; }
    }
}
