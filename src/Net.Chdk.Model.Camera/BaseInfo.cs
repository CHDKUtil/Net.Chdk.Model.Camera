using Newtonsoft.Json;

namespace Net.Chdk.Model.Camera
{
    public sealed class BaseInfo
    {
        [JsonProperty("make")]
        public string Make { get; set; }

        [JsonProperty("model")]
        public string Model { get; set; }
    }
}
