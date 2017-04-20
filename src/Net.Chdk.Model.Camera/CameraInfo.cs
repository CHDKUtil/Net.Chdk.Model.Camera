namespace Net.Chdk.Model.Camera
{
    public sealed class CameraInfo
    {
        public string Version { get; set; }
        public BaseInfo Base { get; set; }
        public CanonInfo Canon { get; set; }
    }
}
