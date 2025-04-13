using Amazon.Extensions.NETCore.Setup;
using Amazon.Runtime;
using Amazon.Runtime.CredentialManagement;
using Amazon.Runtime.Credentials.Internal;
using Microsoft.Extensions.Logging;

namespace AWSSDK.Extensions.NETCore.Setup
{
    /// <summary>
    ///
    /// </summary>
    public class DefaultAWSCredentialsFactory : IAWSCredentialsFactory
    {
        private readonly AWSOptions _options;
        private readonly ILogger _logger;

        /// <summary>
        /// Creates the AWSCredentials using either the profile indicated from the AWSOptions object
        /// of the SDK fallback credentials search.
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public DefaultAWSCredentialsFactory(AWSOptions options, ILogger logger = null)
        {
            _options = options;
            _logger = logger;
        }

        /// <summary>
        /// Creates the AWSCredentials using either AWSOptions.Credentials, AWSOptions.Profile + AWSOptions.ProfilesLocation,
        /// or the SDK fallback credentials search.
        /// </summary>
        public AWSCredentials Create()
        {
            if (_options != null)
            {
                if (_options.Credentials != null)
                {
                    _logger?.LogInformation("Using AWS credentials specified with the AWSOptions.Credentials property");
                    return _options.Credentials;
                }
                if (!string.IsNullOrEmpty(_options.Profile))
                {
                    var chain = new CredentialProfileStoreChain(_options.ProfilesLocation);
                    AWSCredentials result;
                    if (chain.TryGetAWSCredentials(_options.Profile, out result))
                    {
                        _logger?.LogInformation($"Found AWS credentials for the profile {_options.Profile}");
                        return result;
                    }
                    else
                    {
                        _logger?.LogInformation($"Failed to find AWS credentials for the profile {_options.Profile}");
                    }
                }
            }

            var credentials = DefaultIdentityResolverConfiguration.ResolveDefaultIdentity<AWSCredentials>();
            if (credentials == null)
            {
                _logger?.LogError("Last effort to find AWS Credentials with AWS SDK's default credential search failed");
                throw new AmazonClientException("Failed to find AWS Credentials for constructing AWS service client");
            }
            else
            {
                _logger?.LogInformation("Found credentials using the AWS SDK's default credential search");
            }

            return credentials;
        }
    }
}