namespace Net.Chdk.Model.Camera
{
    public sealed class CameraInfo
    {
#if METADATA
        public System.Version Version { get; set; }
#endif
        public BaseInfo Base { get; set; }
        public CanonInfo Canon { get; set; }
    }
}
