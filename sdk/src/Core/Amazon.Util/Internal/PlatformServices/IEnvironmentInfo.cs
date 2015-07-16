
namespace Amazon.Util.Internal.PlatformServices
{
    public interface IEnvironmentInfo
    {
        string Platform { get; }
        string PlatformVersion { get; }
        string PclPlatform { get; }
        string PlatformUserAgent { get; }
        string FrameworkUserAgent { get; }
        string Model { get; }
        string Make { get; }
        string Locale { get; }
    }
}
