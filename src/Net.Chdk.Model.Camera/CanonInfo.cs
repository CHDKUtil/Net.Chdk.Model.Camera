using Net.Chdk.Json;
using Newtonsoft.Json;

namespace Net.Chdk.Model.Camera
{
    public sealed class CanonInfo
    {
        [JsonProperty("modelId")]
        [JsonConverter(typeof(HexStringJsonConverter))]
        public uint ModelId { get; set; }

        [JsonProperty("firmwareRevision")]
        [JsonConverter(typeof(HexStringJsonConverter))]
        public uint FirmwareRevision { get; set; }
    }
}
