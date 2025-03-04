using System;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Auth;
using Amazon.S3;

namespace NETCore.SetupTests
{
    public interface IMockService : IAmazonService
    {
#if NET8_0_OR_GREATER
#pragma warning disable CA1033
        /// <inheritdoc/>
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new MockServiceConfig();

        /// <inheritdoc/>
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as MockServiceConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type MockServiceConfig to create MockServiceClient");
            }

            return new MockServiceClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
    }

    public class MockServiceClient : AmazonServiceClient, IMockService
    {
        public MockServiceClient(AWSCredentials credentials, MockServiceConfig config)
            : base(credentials, config)
        {

        }
    }

    public class MockServiceConfig : AmazonS3Config
    {
        public enum TheEnum { First, Second };

        public TheEnum Position { get; set; }

        public TheEnum? NullablePosition { get; set; }

        public TimeSpan TimeLength { get; set; }

        public TimeSpan? NullableTimeLength { get; set; }

        public bool TheBool { get; set; }
    }
}
