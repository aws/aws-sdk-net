
namespace Amazon.Util.Internal.PlatformServices
{
    public interface IEnvironmentInfo
    {
        string Platform { get; }
        string Model { get; }
        string Make { get; }
        string PlatformVersion { get; }
        string Locale { get; }
    }
}
