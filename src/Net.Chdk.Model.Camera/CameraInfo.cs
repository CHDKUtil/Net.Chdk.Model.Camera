using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace Net.Chdk.Model.Camera
{
    public sealed class CameraInfo
    {
        [JsonConverter(typeof(VersionConverter))]
        public Version Version { get; set; }

        public BaseInfo Base { get; set; }
        public CanonInfo Canon { get; set; }
    }
}
