using System;

namespace Net.Chdk.Model.Camera
{
    public sealed class CameraInfo
    {
        public Version Version { get; set; }
        public BaseInfo Base { get; set; }
        public CanonInfo Canon { get; set; }
    }
}
