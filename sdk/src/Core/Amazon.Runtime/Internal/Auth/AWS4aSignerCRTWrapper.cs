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
using Amazon.Runtime.Internal.Util;
using Amazon.Runtime.SharedInterfaces;
using Amazon.Util.Internal;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace Amazon.Runtime.Internal.Auth
{
    /// <summary>
    /// Asymmetric SigV4 signer using a the AWS Common Runtime implementation of SigV4a via AWSSDK.Extensions.CrtIntegration 
    /// </summary>
    public class AWS4aSignerCRTWrapper : AbstractAWSSigner
    {
        private const string CRT_WRAPPER_ASSEMBLY_NAME = "AWSSDK.Extensions.CrtIntegration";
        private const string CRT_WRAPPER_NUGET_PACKGE_NAME = "AWSSDK.Extensions.CrtIntegration";
        private const string CRT_WRAPPER_CLASS_NAME = "Amazon.Extensions.CrtIntegration.CrtAWS4aSigner";

        private static IAWSSigV4aProvider _awsSigV4AProvider;
        private static object _lock = new object();

        /// <summary>
        /// Instantiates an SigV4a signer using CRT's SigV4a implementation
        /// </summary>
        public AWS4aSignerCRTWrapper() : this(true)
        {
        }

        /// <summary>
        /// Instantiates an SigV4a signer using CRT's SigV4a implementation
        /// </summary>
        /// <param name="signPayload">Whether to sign the request's payload</param>
        public AWS4aSignerCRTWrapper(bool signPayload)
        {
            if (_awsSigV4AProvider == null)
            {
                lock(_lock)
                {
                    if (_awsSigV4AProvider == null)
                    {
                        try
                        {
                            var crtWrapperTypeInfo = ServiceClientHelpers.LoadTypeFromAssembly(CRT_WRAPPER_ASSEMBLY_NAME, CRT_WRAPPER_CLASS_NAME);
                            var constructor = crtWrapperTypeInfo.GetConstructor(new ITypeInfo[]
                            {
                                TypeFactory.GetTypeInfo(typeof(bool))
                            });

                            _awsSigV4AProvider = constructor.Invoke(new object[] { signPayload }) as IAWSSigV4aProvider;
                        }
                        catch (FileNotFoundException)
                        {
                            throw new AWSCommonRuntimeException
                            (
                                string.Format(CultureInfo.InvariantCulture, "Attempting to make a request that requires an implementation of AWS Signature V4a. " +
                                $"Add a reference to the {CRT_WRAPPER_NUGET_PACKGE_NAME} NuGet package to your project to include the AWS Signature V4a signer.")
                            );
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Protocol for the requests being signed
        /// </summary>
        public override ClientProtocol Protocol
        {
            get { return _awsSigV4AProvider.Protocol; }
        }

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
        public override void Sign(IRequest request, IClientConfig clientConfig, RequestMetrics metrics, ImmutableCredentials credentials)
        {
            _awsSigV4AProvider.Sign(request, clientConfig, metrics, credentials);
        }

        public override void Sign(IRequest request, IClientConfig clientConfig, RequestMetrics metrics, string awsAccessKeyId, string awsSecretAccessKey)
        {
            throw new AWSCommonRuntimeException("SigV4a signing with only an access key and secret is not supported. Call the Sign override with ImmutableCredentials instead.");
        }

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
        public AWS4aSigningResult SignRequest(IRequest request,
                                     IClientConfig clientConfig,
                                     RequestMetrics metrics,
                                     ImmutableCredentials credentials)
        {
            return _awsSigV4AProvider.SignRequest(request, clientConfig, metrics, credentials);
        }

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
        public AWS4aSigningResult Presign4a(IRequest request,
                                    IClientConfig clientConfig,
                                    RequestMetrics metrics,
                                    ImmutableCredentials credentials,
                                    string service,
                                    string overrideSigningRegion)
        {
            return _awsSigV4AProvider.Presign4a(request, clientConfig, metrics, credentials, service, overrideSigningRegion);
        }

        /// <summary>
        /// Calculates the signature for a single chunk of a chunked SigV4a request
        /// </summary>
        /// <param name="chunkBody">Content of the current chunk</param>
        /// <param name="previousSignature">Signature of the previous chunk</param>
        /// <param name="headerSigningResult">Signing result of the request's header</param>
        /// <returns>Unpadded SigV4a signature of the given chunk</returns>
        public string SignChunk(Stream chunkBody, string previousSignature, AWS4aSigningResult headerSigningResult)
        {
            return _awsSigV4AProvider.SignChunk(chunkBody, previousSignature, headerSigningResult);
        }

        /// <summary>
        /// Signs the final chunk containing trailing headers
        /// </summary>
        /// <param name="trailingHeaders">Trailing header keys and values</param>
        /// <param name="previousSignature">Signature of the previously signed chunk</param>
        /// <param name="headerSigningResult">Signing result for the "seed" signature consisting of headers</param>
        /// <returns>Signature of the trailing header chunk</returns>
        public string SignTrailingHeaderChunk(IDictionary<string, string> trailingHeaders, string previousSignature, AWS4aSigningResult headerSigningResult)
        {
            return _awsSigV4AProvider.SignTrailingHeaderChunk(trailingHeaders, previousSignature, headerSigningResult);
        }
    }
}
