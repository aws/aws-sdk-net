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

using Amazon.Runtime.Internal.Transform;
using Amazon.Util;
using AWSSDK.Runtime.Internal.Util;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;

namespace Amazon.Runtime.Internal.Util
{
    /// <summary>
    /// Utilities for working with the checksums used to validate request/response integrity
    /// </summary>
    public static class ChecksumUtils
    {
        private const string _checksumHeaderPrefix = "x-amz-checksum-";
        private readonly static List<CoreChecksumAlgorithm> _responseChecksumsInPriorityOrder =
            // TODO: Disabling CRT algorithms since we're still seeing issues with native dependencies in customer environments.
            //ChecksumCRTWrapper.IsCrtAvailable() ?
            //new List<CoreChecksumAlgorithm>
            //{
            //    CoreChecksumAlgorithm.CRC64NVME,
            //    CoreChecksumAlgorithm.CRC32C,
            //    CoreChecksumAlgorithm.CRC32,
            //    CoreChecksumAlgorithm.SHA1,
            //    CoreChecksumAlgorithm.SHA256
            //} :
            new List<CoreChecksumAlgorithm>
            {
                CoreChecksumAlgorithm.CRC32,
                CoreChecksumAlgorithm.SHA1,
                CoreChecksumAlgorithm.SHA256
            };

        /// <summary>
        /// Returns the current default checksum algorithm used by the SDK.
        /// </summary>
        public static CoreChecksumAlgorithm DefaultAlgorithm => CoreChecksumAlgorithm.CRC32;

        /// <summary>
        /// Generates the name of the header key to use for a given checksum algorithm
        /// </summary>
        /// <param name="checksumAlgorithm">Checksum algorithm</param>
        /// <returns>Name of the HTTP header key for the given algorithm</returns>
        internal static string GetChecksumHeaderKey(CoreChecksumAlgorithm checksumAlgorithm)
        {
            return $"{_checksumHeaderPrefix}{checksumAlgorithm.ToString().ToLower()}";
        }

        /// <summary>
        /// Attempts to select and then calculate the checksum for a request.
        /// </summary>
        /// <param name="request">Request to calculate the checksum for</param>
        /// <param name="clientConfig">Client configuration data encompassing the service call</param>
        public static void SetRequestChecksumV2(IRequest request, IClientConfig clientConfig)
        {
            if (request == null)
            {
                throw new ArgumentNullException("request");
            }

            if (request.ChecksumData == null)
            {
                throw new ArgumentException("Request checksum data cannot be null", "request");
            }

            // If a pre-calculated value was specified, we won't attempt to calculate it again.
            if (request.Headers.Any(h => h.Key.StartsWith(_checksumHeaderPrefix, StringComparison.OrdinalIgnoreCase)))
            {
                return;
            }

            var coreChecksumAlgoritm = ConvertToCoreChecksumAlgorithm(request.ChecksumData.SelectedChecksum);
            if (coreChecksumAlgoritm == CoreChecksumAlgorithm.NONE)
            {
                var fallbackToMD5 = request.ChecksumData.FallbackToMD5 ?? false;
                if (fallbackToMD5)
                {
                    SetRequestChecksumMD5(request);
                    return;
                }

                // If no algorithm was specified for the request, use the best available option.
                coreChecksumAlgoritm = DefaultAlgorithm;
            }

            // If client config is null, this method was called from older service packages.
            if (clientConfig == null)
            {
                return;
            }

            // Check the value of the "RequestChecksumCalculation" property to determine whether the checksum should be calculated.
            if (clientConfig.RequestChecksumCalculation == RequestChecksumCalculation.WHEN_REQUIRED && !request.ChecksumData.IsRequestChecksumRequired)
            {
                return;
            }

            var checksumHeaderKey = GetChecksumHeaderKey(coreChecksumAlgoritm);
            request.SelectedChecksum = coreChecksumAlgoritm;

            if (request.UseChunkEncoding || (request.DisablePayloadSigning ?? false))
            {
                // Add the checksum key to the trailing headers, but not the value
                // because we won't know it until the wrapper stream is fully read,
                // and we only want to read the wrapper stream once.
                //
                // The header key is required upfront for calculating the total length of
                // the wrapper stream, which we need to send as the Content-Length header
                // before the wrapper stream is transmitted.
                request.TrailingHeaders[checksumHeaderKey] = string.Empty;
            }
            else // calculate and set the checksum in the request headers
            {
                request.Headers[checksumHeaderKey] = CalculateChecksumForRequest(CryptoUtilFactory.GetChecksumInstance(coreChecksumAlgoritm), request);
            }

            // If the service model specifies a header with the algorithm used to calculate the checksum should be included, we'll add it here.
            // We also only add it if the header is not populated already (which will be the case when customers set a checksum explicitly;
            // in that case, the header will be set during by the marshaller that runs prior to this step).
            var headerName = request.ChecksumData.HeaderName;
            if (string.IsNullOrEmpty(headerName) || request.Headers.TryGetValue(headerName, out var _))
            {
                return;
            }

            request.Headers[headerName] = coreChecksumAlgoritm.ToString();
        }

        /// <remarks> 
        /// Note, this was called directly from service packages prior to compression support
        /// being added shortly after 3.7.200. It's important to preserve the signature and functionality
        /// until the next minor version for those older 3.7.* service packages.
        /// </remarks>
        /// <summary>
        /// Attempts to select and then calculate a MD5 checksum for a request
        /// </summary>
        /// <param name="request">Request to calculate the checksum for</param>
        public static void SetRequestChecksumMD5(IRequest request)
        {
            // If the user provided a precalculated MD5 header, don't recalculate it
            if (request.Headers.TryGetValue(HeaderKeys.ContentMD5Header, out var md5HeaderValue))
            {
                if (!string.IsNullOrEmpty(md5HeaderValue))
                {
                    return;
                }
            }

            request.Headers[HeaderKeys.ContentMD5Header] = request.ContentStream != null ?
                AWSSDKUtils.GenerateMD5ChecksumForStream(request.ContentStream) :
                AWSSDKUtils.GenerateChecksumForBytes(request.Content, true);
        }

        /// <summary>
        /// Calculates the given checksum for a marshalled request
        /// </summary>
        /// <param name="algorithm">Checksum algorithm to calculate</param>
        /// <param name="request">Request whose content to calculate the checksum for</param>
        /// <returns>Calculated checksum for the given request</returns>
        private static string CalculateChecksumForRequest(HashAlgorithm algorithm, IRequest request)
        {
            if (request.ContentStream != null)
            {
                var seekableStream = WrapperStream.SearchWrappedStream(request.ContentStream, s => s.CanSeek);
                if (seekableStream != null)
                {
                    var position = seekableStream.Position;
                    var checksumBytes = algorithm.ComputeHash(seekableStream);
                    seekableStream.Seek(position, SeekOrigin.Begin);
                    return Convert.ToBase64String(checksumBytes);
                }
                else
                {
                    throw new ArgumentException("Request must have a seekable content stream to calculate checksum");
                }
            }
            else if (request.Content != null)
            {
                var checksumBytes = algorithm.ComputeHash(request.Content);
                return Convert.ToBase64String(checksumBytes);
            }
            else // request doesn't have content
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// Selects which checksum to use to validate the integrity of a response
        /// </summary>
        /// <param name="operationSupportedChecksums">List of checksums supported by the service operation</param>
        /// <param name="responseData">Response from the service, which potentially contains x-amz-checksum-* headers</param>
        /// <returns>Single checksum algorithm to use for validating the response, or NONE if checksum validation should be skipped</returns>
        public static CoreChecksumAlgorithm SelectChecksumForResponseValidation(ICollection<CoreChecksumAlgorithm> operationSupportedChecksums, IWebResponseData responseData)
        {
            if (operationSupportedChecksums == null || operationSupportedChecksums.Count == 0 || responseData == null)
            {
                return CoreChecksumAlgorithm.NONE;
            }

            foreach (var algorithm in _responseChecksumsInPriorityOrder)
            {
                if (operationSupportedChecksums.Contains(algorithm))
                {
                    var headerKey = GetChecksumHeaderKey(algorithm);
                    if (responseData.IsHeaderPresent(headerKey) && !IsChecksumValueMultipartGet(responseData.GetHeaderValue(headerKey)))
                    {
                        return algorithm;
                    }
                }
            }

            return CoreChecksumAlgorithm.NONE;
        }

        /// <summary>
        /// Determines if a checksum value is for a whole S3 multipart object, which must skip validation.
        /// These checksums end with `-#`, where # is an integer between 1 and 10000
        /// </summary>
        /// <param name="checksumValue">Base 64 checksum value</param>
        /// <returns>True if the checksum is for an S3 multipart object, false otherwise</returns>
        private static bool IsChecksumValueMultipartGet(string checksumValue)
        {
            if (string.IsNullOrEmpty(checksumValue))
            {
                return false;
            }

            var lastDashIndex = checksumValue.LastIndexOf('-');
            if (lastDashIndex == -1)
            {
                return false;
            }

            int partNumber;
            var isInteger = int.TryParse(checksumValue.Substring(lastDashIndex + 1), out partNumber);

            if (!isInteger)
            {
                return false;
            }

            if (partNumber >= 1 && partNumber <= 10000)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Translates a string representation of a flexible checksum algorithm to the
        /// corresponding  <see cref="CoreChecksumAlgorithm" /> enum value.
        /// </summary>
        /// <param name="selectedServiceChecksum">Checksum algorithm as a string</param>
        /// <returns>Enum value reprsenting the checksum algorithm</returns>
        /// <exception cref="AmazonClientException">Thrown if a matching enum value could not be found</exception>
        private static CoreChecksumAlgorithm ConvertToCoreChecksumAlgorithm(string selectedServiceChecksum)
        {
            if (string.IsNullOrEmpty(selectedServiceChecksum))
            {
                return CoreChecksumAlgorithm.NONE;
            }

            CoreChecksumAlgorithm selectedCoreChecksumAlgorithm;
            if (!Enum.TryParse(selectedServiceChecksum, true, out selectedCoreChecksumAlgorithm))
            {
                // Service checksum options should always be a subset of the core, but in case not
                throw new AmazonClientException($"Attempted to sign a request with an unknown checksum algorithm {selectedServiceChecksum}");
            }

            return selectedCoreChecksumAlgorithm;
        }

        /// <summary>
        /// Set checksum data in marshaller after compressing request payload.
        /// </summary>
        /// <param name="request">Request to calculate the checksum for</param>
        /// <param name="checksumAlgorithm">Checksum algorithm to use, specified on the request using a service-specific enum</param>
        /// <param name="fallbackToMD5">This flag controls whether or not to fallback to using a MD5 to generate a checksum</param>
        /// <param name="isRequestChecksumRequired">This flag indicates whether an operation requires a checksum in its request</param>
        public static void SetChecksumData(IRequest request, string checksumAlgorithm, bool fallbackToMD5, bool isRequestChecksumRequired)
        {
            SetChecksumData(request, checksumAlgorithm, fallbackToMD5, isRequestChecksumRequired, headerName: null);
        }

        /// <summary>
        /// Set checksum data in marshaller after compressing request payload.
        /// </summary>
        /// <param name="request">Request to calculate the checksum for</param>
        /// <param name="checksumAlgorithm">Checksum algorithm to use, specified on the request using a service-specific enum</param>
        /// <param name="fallbackToMD5">This flag controls whether or not to fallback to using a MD5 to generate a checksum</param>
        /// <param name="isRequestChecksumRequired">This flag indicates whether an operation requires a checksum in its request</param>
        /// <param name="headerName">Name of the header that indicates which algorithm was used to calculate the checksum</param>
        public static void SetChecksumData(IRequest request, string checksumAlgorithm, bool fallbackToMD5, bool isRequestChecksumRequired, string headerName)
        {
            request.ChecksumData = new ChecksumData(checksumAlgorithm, MD5Checksum: false, fallbackToMD5, isRequestChecksumRequired, headerName);
        }

        /// <summary>
        /// Set checksum data in marshaller in order to call method <see cref="SetRequestChecksumMD5"/> 
        /// after compressing request payload in <see cref="CompressionHandler"/> class
        /// </summary>
        /// <param name="request">Request to calculate the checksum for</param>
        public static void SetChecksumData(IRequest request)
        {
            request.ChecksumData = new ChecksumData(null, MD5Checksum: true, fallbackToMD5: null, isRequestChecksumRequired: true, headerName: null);
        }
    }

    /// <summary>
    /// Class containing necessary data to calculate checksum
    /// </summary>
    public class ChecksumData
    {
        /// <summary>
        /// Checksum algorithm to use, specified on the request using a service-specific enum
        /// </summary>
        public string SelectedChecksum { get; set; }

        /// <summary>
        /// Flag to check if we want to call method <see cref="ChecksumUtils.SetRequestChecksumMD5"/>
        /// </summary>
        public bool IsMD5Checksum { get; set; }

        /// <summary>
        /// This flag controls whether or not to fallback to using a MD5 to generate a checksum
        /// </summary>
        public bool? FallbackToMD5 { get; set; }

        /// <summary>
        /// Indicates whether the operation requires a request checksum to be included
        /// </summary>
        public bool IsRequestChecksumRequired { get; set; }

        /// <summary>
        /// Optional: Name of the header that indicates which algorithm was used to calculate the checksum.
        /// </summary>
        public string HeaderName { get; set; }

        public ChecksumData(string selectedChecksum, bool MD5Checksum, bool? fallbackToMD5, bool isRequestChecksumRequired, string headerName)
        {
            this.SelectedChecksum = selectedChecksum;
            this.IsMD5Checksum = MD5Checksum;
            this.FallbackToMD5 = fallbackToMD5;
            this.IsRequestChecksumRequired = isRequestChecksumRequired;
            this.HeaderName = headerName;
        }
    }
}
