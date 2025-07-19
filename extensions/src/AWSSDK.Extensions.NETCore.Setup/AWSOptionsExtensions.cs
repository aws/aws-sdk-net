using Amazon.Extensions.NETCore.Setup;
using Amazon.Runtime;

namespace AWSSDK.Extensions.NETCore.Setup
{
    /// <summary>
    ///
    /// </summary>
    public static class AWSOptionsExtensions
    {
        /// <summary>
        /// Create a service client for the specified service interface using the options set in this instance.
        /// For example if T is set to IAmazonS3 then the AmazonS3ServiceClient which implements IAmazonS3 is created
        /// and returned.
        /// </summary>
        /// <typeparam name="T">The service interface that a service client will be created for.</typeparam>
        /// <returns>The service client that implements the service interface.</returns>
        public static T CreateServiceClient<T>(this AWSOptions options)
            where T : class, IAmazonService
        {
            var credentials = new DefaultAWSCredentials(options, null);
            var clientFactory = new ClientFactory<T>(options, credentials, null);

            return clientFactory.CreateServiceClient() as T;
        }
    }
}