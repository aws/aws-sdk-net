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
using System.Collections.Generic;
using System.Text;

namespace Amazon.Runtime
{
    /// <summary>
    /// The valid hashing algorithm supported by the sdk for request signing.
    /// </summary>
    public enum SigningAlgorithm 
    { 
        HmacSHA1, 
        HmacSHA256 
    };

    /// <summary>
    /// Which end of a request was responsible for a service error response.
    /// </summary>
    public enum ErrorType
    {
        /// <summary>
        /// The sender was responsible for the error, i.e. the client
        /// request failed validation or was improperly formatted.
        /// </summary>
        Sender,
        /// <summary>
        /// The error occured within the service.
        /// </summary>
        Receiver,
        /// <summary>
        /// An unrecognized error type was returned.
        /// </summary>
        Unknown
    }

    /// <summary>
    /// S3 US East 1 endpoint value determines wheter or not
    /// to send the us-east-1 s3 requests to the regional endpoint or to
    /// the legacy global endpoint
    /// </summary>
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

    /// <summary>
    /// RetryMode determines which request retry mode is used for requests that do 
    /// not complete successfully.
    /// </summary>
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
    /// EC2MetadataServiceEndpointMode determines the internet protocol version
    /// to be used for communicating with the EC2 Instance Metadata Service
    /// </summary>
    public enum EC2MetadataServiceEndpointMode
    {
        /// <summary>
        /// Internet Protocol version 4
        /// </summary>
        IPv4,
        /// <summary>
        /// Internet Protocol version 6
        /// </summary>
        IPv6
    }

    /// <summary>
    /// SignatureVersion determines which signature version is used for the request
    /// </summary>
    public enum SignatureVersion
    {
        /// <summary>
        /// Signature Version 2
        /// </summary>
        SigV2,
        /// <summary>
        /// Signature Version 4
        /// </summary>
        SigV4,
        /// <summary>
        /// Asymmetric Signature Version 4
        /// </summary>
        SigV4a
    }

    /// <summary>
    /// Algorithms for validating request and response integrity for supported operations.
    /// These are the algorithms support by the .NET SDK, a given service may 
    /// only use a subset of these.
    /// </summary>
    public enum CoreChecksumAlgorithm
    {
        NONE,
        CRC32C,
        CRC32,
        SHA256,
        SHA1,
        CRC64NVME
    }

    /// <summary>
    /// Supported algorithms for compressing request payloads.
    /// A given request payload will be compressed by one of the algorithms below.
    /// </summary>
    public enum CompressionEncodingAlgorithm
    {
        NONE,
        gzip
    }

    /// <summary>
    /// Behavior to be used for verifying the checksum of response content
    /// that may be returned by supported service operations.
    /// </summary>
    public enum CoreChecksumResponseBehavior
    {
        /// <summary>
        /// The SDK will not attempt to verify the response checksum
        /// </summary>
        DISABLED,
        /// <summary>
        /// The SDK will attempt to verify the response checksum
        /// </summary>
        ENABLED
    }

    /// <summary>
    /// Controls whether the resolved endpoint will include the account id. This allows for direct routing of traffic
    /// to the cell responsible for a given account, which avoids the additional latency of extra backend hops and reduces
    /// complexity in the routing layer.
    /// </summary>
    public enum AccountIdEndpointMode
    {
        /// <summary>
        /// The default value. The endpoint will include the account id if available.
        /// </summary>
        PREFERRED,
        /// <summary>
        /// The resolved endpoint will need to include the account id.
        /// </summary>
        REQUIRED,
        /// <summary>
        /// The resolved endpoint will not include the account id.
        /// </summary>
        DISABLED
    }

    /// <summary>
    /// RequestChecksumCalculation determines the behavior for calculating checksums for request payloads.
    /// </summary>
    public enum RequestChecksumCalculation
    {
        /// <summary>
        /// Calculate checksum for all request payloads of operations that supports checksum.
        /// </summary>
        WHEN_SUPPORTED,
        /// <summary>
        /// Calculate checksum for request payloads of operations that requires checksum.
        /// </summary>
        WHEN_REQUIRED,
    }

    /// <summary>
    /// ResponseChecksumValidation determines the behavior for validating checksums on response payloads.
    /// </summary>
    public enum ResponseChecksumValidation
    {
        /// <summary>
        /// Perform checksum validation for all response payloads of operations that supports checksum.
        /// </summary>
        WHEN_SUPPORTED,
        /// <summary>
        /// Perform checksum validation for response payloads of operations that supports checksum
        /// and request validation is set to ENABLED.
        /// </summary>
        WHEN_REQUIRED,
    }
}
