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

using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Util;
using System.Collections.Generic;
using System.IO;

namespace Amazon.Runtime.SharedInterfaces
{
    /// <summary>
    /// Interface for an asymmetric SigV4 (SigV4a) signer
    /// </summary>
    public interface IAWSSigV4aProvider
    {
        /// <summary>
        /// Protocol for the requests being signed
        /// </summary>
        ClientProtocol Protocol { get; }

        /// <summary>
        /// Calculates and signs the specified request using the asymmetric Sigv4 (Sigv4a) signing protocol.
        /// The resulting signature is added to the request headers as 'Authorization'. Parameters supplied in the request, either in
        /// the resource path as a query string or in the Parameters collection must not have been
        /// uri encoded. If they have, use the SignRequest method to obtain a signature.
        /// </summary>
        /// <param name="request">
        /// The request to compute the signature for. Additional headers mandated by the AWS4a protocol 
        /// ('host' and 'x-amz-date') will be added to the request before signing.
        /// </param>
        /// <param name="clientConfig">
        /// Client configuration data encompassing the service call (notably authentication
        /// region, endpoint and service name).
        /// </param>
        /// <param name="metrics">
        /// Metrics for the request
        /// </param>
        /// <param name="credentials">
        /// The AWS credentials for the account making the service call.
        /// </param>
        void Sign(IRequest request, IClientConfig clientConfig, RequestMetrics metrics, ImmutableCredentials credentials);

        /// <summary>
        /// Calculates and signs the specified request using the asymmetric Sigv4 (Sigv4a) signing protocol.
        /// The resulting signature is added to the request headers as 'Authorization'. Parameters supplied in the request, either in
        /// the resource path as a query string or in the Parameters collection must not have been
        /// uri encoded. If they have, use the SignRequest method to obtain a signature.
        /// </summary>
        /// <param name="request">
        /// The request to compute the signature for. Additional headers mandated by the AWS4a protocol 
        /// ('host' and 'x-amz-date') will be added to the request before signing.
        /// </param>
        /// <param name="clientConfig">
        /// Client configuration data encompassing the service call (notably authentication
        /// region, endpoint and service name).
        /// </param>
        /// <param name="metrics">
        /// Metrics for the request
        /// </param>
        /// <param name="credentials">
        /// The AWS credentials for the account making the service call.
        /// </param>
        /// <returns>AWS4a Signing Result</returns>
        AWS4aSigningResult SignRequest(IRequest request, IClientConfig clientConfig, RequestMetrics metrics, ImmutableCredentials credentials);

        /// <summary>
        /// Calculates the asymmetric Sigv4 (Sigv4a) signature for a presigned url.
        /// </summary>
        /// <param name="request">
        /// The request to compute the signature for.
        /// </param>
        /// <param name="clientConfig">
        /// Adding supporting data for the service call required by the signer (notably authentication
        /// region, endpoint and service name).
        /// </param>
        /// <param name="metrics">
        /// Metrics for the request
        /// </param>
        /// <param name="credentials">
        /// The AWS credentials for the account making the service call.
        /// </param>
        /// <param name="service">
        /// The service to sign for
        /// </param>
        /// <param name="overrideSigningRegion">
        /// The region to sign to, if null then the region the client is configured for will be used.
        /// </param>
        /// <returns>AWS4a Signing Result</returns>
        AWS4aSigningResult Presign4a(IRequest request,
                                    IClientConfig clientConfig,
                                    RequestMetrics metrics,
                                    ImmutableCredentials credentials,
                                    string service,
                                    string overrideSigningRegion);

        /// <summary>
        /// Calculates the signature for a single chunk of a chunked SigV4a request
        /// </summary>
        /// <param name="chunkBody">Content of the current chunk</param>
        /// <param name="previousSignature">Signature of the previous chunk</param>
        /// <param name="headerSigningResult">Signing result of the request's header</param>
        /// <returns>Unpadded SigV4a signature of the given chunk</returns>
        string SignChunk(Stream chunkBody, string previousSignature, AWS4aSigningResult headerSigningResult);

        /// <summary>
        /// Signs the final chunk containing trailing headers
        /// </summary>
        /// <param name="trailingHeaders">Trailing header keys and values</param>
        /// <param name="previousSignature">Signature of the previous chunk</param>
        /// <param name="headerSigningResult">Signing result of the request's header</param>
        /// <returns>Signature of the trailing header chunk</returns>
        string SignTrailingHeaderChunk(IDictionary<string, string> trailingHeaders, string previousSignature, AWS4aSigningResult headerSigningResult);
    }
}
