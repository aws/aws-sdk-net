using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ServiceClientGenerator.DefaultConfiguration
{
    /// <summary>
    /// Model representing the default configuration modes as built
    /// from the sdk-default-configurations.json file. 
    /// </summary>
    public class DefaultConfigurationModel
    {
        public List<DefaultConfigurationMode> Modes { get; set; } 
            = new List<DefaultConfigurationMode>();

        /// <summary>
        /// Provides documentation on each configuration option, ie
        /// <see cref="DefaultConfigurationMode.S3UsEast1RegionalEndpoint"/>.
        /// <para />
        /// Key is a Property in <see cref="DefaultConfigurationMode"/>, value is the
        /// Documentation describing the configuration option that Property represents.
        /// </summary>
        public Dictionary<string, string> ConfigurationOptionDocumentation { get; set; }
            = new Dictionary<string, string>();
    }

    [DebuggerDisplay("{"+ nameof(Name) + "}")]
    public class DefaultConfigurationMode
    {
        /// <summary>
        /// Identifies a specific configuration mode. Example mobile, cross-region, etc
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Description of this Configuration Mode
        /// </summary>
        public string Documentation { get; set; }
        /// <summary>
        /// A retry mode specifies how the SDK attempts retries.
        /// See https://docs.aws.amazon.com/sdkref/latest/guide/feature-retry-behavior.html
        /// </summary>
        public RequestRetryMode RetryMode { get; set; }
        /// <summary>
        /// Specifies how the SDK determines the AWS service endpoint that it uses to talk to the Amazon S3 for the us-east-1 region
        /// </summary>
        public S3UsEast1RegionalEndpointValue S3UsEast1RegionalEndpoint { get; set; }
        /// <summary>
        /// The amount of time after making an initial connect attempt on a socket, where if the client does not
        /// receive a completion of the connect handshake, the client gives up and fails the operation.
        /// </summary>
        public TimeSpan? ConnectTimeout { get; set; }
        /// <summary>
        /// The maximum amount of time that a TLS handshake is allowed to take from the time the CLIENT HELLO message is sent to
        /// the client and server have fully negotiated ciphers and exchanged keys
        /// </summary>
        public TimeSpan? TlsNegotiationTimeout { get; set; }
        /// <summary>
        /// How long an application will attempt to read the first byte over an established,
        /// open connection after write request before timing out.
        /// </summary>
        public TimeSpan? TimeToFirstByteTimeout { get; set; }
        /// <summary>
        /// This timeout measures the time between when the first byte is sent over an established,
        /// open connection and when the last byte is received from the service.
        /// If the response is not received by the timeout, then the request is considered timed out.
        /// </summary>
        public TimeSpan? HttpRequestTimeout { get; set; }
    }

    /// <summary>
    /// RetryMode determines which request retry mode is used for requests that do 
    /// not complete successfully.
    /// </summary>
    /// <remarks>This is a copy of Amazon.Runtime.RequestRetryMode</remarks>
    public enum RequestRetryMode
    {
        /// <summary>
        /// Standardized request retry strategy that is consistent across all SDKs.
        /// </summary>
        Standard,
        /// <summary>
        /// An experimental request retry strategy that builds on the Standard strategy
        /// and introduces congestion control through client side rate limiting.
        /// </summary>
        Adaptive
    }

    /// <summary>
    /// S3 US East 1 endpoint value determines whether or not
    /// to send the us-east-1 s3 requests to the regional endpoint or to
    /// the legacy global endpoint
    /// </summary>
    /// <remarks>This is a copy of Amazon.Runtime.S3UsEast1RegionalEndpointValue</remarks>
    public enum S3UsEast1RegionalEndpointValue
    {
        /// <summary>
        /// Sends the requests to the legacy global s3 endpoint for us-east-1
        /// </summary>
        Legacy,
        /// <summary>
        /// Sends the request to the regional s3 endpoint for us-east-1
        /// </summary>
        Regional
    }
}