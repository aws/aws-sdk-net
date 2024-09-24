/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

using System;
using System.Diagnostics;

namespace Amazon.Runtime
{
    /// <summary>
    /// A defaults mode determines how certain default configuration options are resolved in the SDK. Based on the provided
    /// mode, the SDK will vend sensible default values tailored to the specific <see cref="DefaultConfigurationMode"/>.
    /// <para />
    /// All options above can be configured by users, and the overridden value will take precedence.
    /// <para />
    /// <b>Note:</b> the vended default values might change as best practices may evolve. As a result, it is encouraged to perform 
    /// testing when upgrading the SDK.
    /// <para />
    /// The defaults mode can be configured:
    /// <list type="number">
    /// <item>When constructing an <see cref="AmazonServiceClient"/> implementation by setting <see cref="ClientConfig.DefaultConfigurationMode"/>.</item>
    /// <item>Globally via the "AWS_DEFAULTS_MODE" environment variable.</item>
    /// <item>On a configuration profile via the "defaults_mode" profile file property.</item>
    /// </list>
    /// </summary>
    public interface IDefaultConfiguration
    {
        /// <summary>
        /// Identifies a specific configuration mode. Example mobile, cross-region, etc
        /// </summary>
        DefaultConfigurationMode Name { get; }
        /// <summary>
        /// A retry mode specifies how the SDK attempts retries.
        /// See https://docs.aws.amazon.com/sdkref/latest/guide/setting-global-retry_mode.html
        /// </summary>
        RequestRetryMode RetryMode { get; }
        /// <summary>
        /// Specifies how the SDK determines the AWS service endpoint that it uses to talk to the Amazon S3 for the us-east-1 region
        /// </summary>
        S3UsEast1RegionalEndpointValue S3UsEast1RegionalEndpoint { get; }
        /// <summary>
        /// The amount of time after making an initial connect attempt on a socket, where if the client does not
        /// receive a completion of the connect handshake, the client gives up and fails the operation.
        /// </summary>
        TimeSpan? ConnectTimeout { get; }
        /// <summary>
        /// The maximum amount of time that a TLS handshake is allowed to take from the time the CLIENT HELLO message is sent to
        /// the client and server have fully negotiated ciphers and exchanged keys
        /// </summary>
        TimeSpan? TlsNegotiationTimeout { get; }
        /// <summary>
        /// How long an application will attempt to read the first byte over an established,
        /// open connection after write request before timing out.
        /// </summary>
        TimeSpan? TimeToFirstByteTimeout { get; }
        /// <summary>
        /// This timeout measures the time between when the first byte is sent over an established,
        /// open connection and when the last byte is received from the service.
        /// If the response is not received by the timeout, then the request is considered timed out.
        /// </summary>
        TimeSpan? HttpRequestTimeout { get; }
    }

    /// <summary>
    /// A defaults mode determines how certain default configuration options are resolved in the SDK. Based on the provided
    /// mode, the SDK will vend sensible default values tailored to the specific <see cref="DefaultConfigurationMode"/>.
    /// <para />
    /// All options above can be configured by users, and the overridden value will take precedence.
    /// <para />
    /// <b>Note:</b> the vended default values might change as best practices may evolve. As a result, it is encouraged to perform 
    /// testing when upgrading the SDK.
    /// <para />
    /// The defaults mode can be configured:
    /// <list type="number">
    /// <item>When constructing an <see cref="AmazonServiceClient"/> implementation by setting <see cref="ClientConfig.DefaultConfigurationMode"/>.</item>
    /// <item>Globally via the "AWS_DEFAULTS_MODE" environment variable.</item>
    /// <item>On a configuration profile via the "defaults_mode" profile file property.</item>
    /// </list>
    /// </summary>
    [DebuggerDisplay("{" + nameof(Name) + "}")]
    public class DefaultConfiguration : IDefaultConfiguration
    {
        /// <inheritdoc />
        public DefaultConfigurationMode Name { get; set; }
        /// <inheritdoc />
        public RequestRetryMode RetryMode { get; set; }
        /// <inheritdoc />
        public S3UsEast1RegionalEndpointValue S3UsEast1RegionalEndpoint { get; set; }
        /// <inheritdoc />
        public TimeSpan? ConnectTimeout { get; set; }
        /// <inheritdoc />
        public TimeSpan? TlsNegotiationTimeout { get; set; }
        /// <inheritdoc />
        public TimeSpan? TimeToFirstByteTimeout { get; set; }
        /// <inheritdoc />
        public TimeSpan? HttpRequestTimeout { get; set; }
    }
}