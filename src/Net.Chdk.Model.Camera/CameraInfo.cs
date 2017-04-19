using Newtonsoft.Json;

namespace Net.Chdk.Model.Camera
{
    public sealed class CameraInfo
    {
        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("base")]
        public BaseInfo Base { get; set; }

        [JsonProperty("canon")]
        public CanonInfo Canon { get; set; }
    }
}
