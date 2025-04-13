using Amazon.Runtime;

namespace AWSSDK.Extensions.NETCore.Setup
{
    /// <summary>
    ///
    /// </summary>
    public interface IAWSCredentialsFactory
    {
        /// <summary>
        /// Creates AWSCredentials
        /// </summary>
        AWSCredentials Create();
    }
}