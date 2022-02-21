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
using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using ThirdParty.MD5;

namespace Amazon.Runtime.Internal.Util
{
    /// <summary>
    /// Utilities for working with the checksums used to validate request/response integrity
    /// </summary>
    public static class ChecksumUtils
    {
        /// <summary>
        /// Generates the name of the header key to use for a given checksum algorithm
        /// </summary>
        /// <param name="checksumAlgorithm">Checksum algorithm</param>
        /// <returns>Name of the HTTP header key for the given algorithm</returns>
        internal static string GetChecksumHeaderKey(CoreChecksumAlgorithm checksumAlgorithm)
        {
            return $"x-amz-checksum-{checksumAlgorithm.ToString().ToLower()}";
        }

        /// <summary>
        /// Attempts to select and then calculate the checksum for a request
        /// </summary>
        /// <param name="request">Request to calculate the checksum for</param>
        /// <param name="checksumAlgorithm">Checksum algorithm to use, specified on the request using a service-specific enum</param>
        /// <param name="fallbackToMD5">If checksumAlgorithm is <see cref="CoreChecksumAlgorithm.NONE"/>,
        /// this flag controls whether or not to fallback to using a MD5 to generate a checksum.
        /// </param>
        public static void SetRequestChecksum(IRequest request, string checksumAlgorithm, bool fallbackToMD5 = true)
        {
            var coreChecksumAlgoritm = ChecksumUtils.ConvertToCoreChecksumAlgorithm(checksumAlgorithm);
            if (coreChecksumAlgoritm == CoreChecksumAlgorithm.NONE)
            {
                if (fallbackToMD5)
                    SetRequestChecksumMD5(request);
                return;
            }

            var checksumHeaderKey = GetChecksumHeaderKey(coreChecksumAlgoritm);

            // If the user provided a precalculated header for this checksum, don't recalculate it
            if (request.Headers.TryGetValue(checksumHeaderKey, out var checksumHeaderValue))
            {
                if (!string.IsNullOrEmpty(checksumHeaderValue))
                {
                    return;
                }
            }

            if (request.UseChunkEncoding || (request.DisablePayloadSigning ?? false))
            {
                // Add the checksum key to the trailing headers, but not the value
                // because we won't know it until the wrapper stream is fully read,
                // and we only want to read the wrapper stream once.
                //
                // The header key is required upfront for calculating the total length of
                // the wrapper stream, which we need to send as the Content-Length header
                // before the wrapper stream is transmitted.
                request.TrailingHeaders.Add(checksumHeaderKey, string.Empty);
                request.SelectedChecksum = coreChecksumAlgoritm;
            }
            else // calculate and set the checksum in the request headers
            {
                request.Headers[checksumHeaderKey] = CalculateChecksumForRequest(CryptoUtilFactory.GetChecksumInstance(coreChecksumAlgoritm), request);
            }
        }

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

            // Checksums to use for validation in order of speed (via CRT profiling)
            CoreChecksumAlgorithm[] checksumsInPriorityOrder =
            {
                CoreChecksumAlgorithm.CRC32C,
                CoreChecksumAlgorithm.CRC32,
                CoreChecksumAlgorithm.SHA1,
                CoreChecksumAlgorithm.SHA256
            };

            foreach (var algorithm in checksumsInPriorityOrder)
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
#if BCL35
            try
            {
                selectedCoreChecksumAlgorithm = (CoreChecksumAlgorithm)Enum.Parse(typeof(CoreChecksumAlgorithm), selectedServiceChecksum, true);
            }
            catch (Exception ex)
            {
                // Service checksum options should always be a subset of the core, but in case not
                throw new AmazonClientException($"Attempted to sign a request with an unknown checksum algorithm {selectedServiceChecksum}", ex);
            }
#else
            if (!Enum.TryParse(selectedServiceChecksum, true, out selectedCoreChecksumAlgorithm))
            {
                // Service checksum options should always be a subset of the core, but in case not
                throw new AmazonClientException($"Attempted to sign a request with an unknown checksum algorithm {selectedServiceChecksum}");
            }
#endif
            return selectedCoreChecksumAlgorithm;
        }

    }
}
