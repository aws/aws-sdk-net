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
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Util;
using Amazon.Util;
using Aws.Crt.Http;
using System;
using System.Collections.Generic;
using System.IO;

namespace AWSSDK.Extensions.CrtIntegration
{
    /// <summary>
    /// Utility functions for converting between the SDK and CRT HTTP Request objects
    /// </summary>
    public class CrtHttpRequestConverter
    {
        // CRT calculates and sets these headers when signing, the SDK must not pass them in
        // See s_forbidden_headers in aws_signing.c
        private static readonly HashSet<string> CrtForbiddenHeaders = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
        {
            HeaderKeys.XAmzContentSha256Header,
            HeaderKeys.XAmzDateHeader,
            HeaderKeys.AuthorizationHeader,
            HeaderKeys.XAmzRegionSetHeader,
            HeaderKeys.XAmzSecurityTokenHeader
        };

        // CRT calculates and sets these query params when signing, the SDK must not pass them in
        // See s_forbidden_params in aws_signing.c
        private static readonly HashSet<string> CrtForbiddenQueryParams = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
        {
            HeaderKeys.XAmzSignature,
            HeaderKeys.XAmzDateHeader,
            HeaderKeys.XAmzCredential,
            HeaderKeys.XAmzAlgorithm,
            HeaderKeys.XAmzSignedHeadersHeader,
            HeaderKeys.XAmzSecurityTokenHeader,
            HeaderKeys.XAmzExpires
        };

        /// <summary>
        /// Converts the SDK's IRequest to the CRT's HttpRequest Object
        /// </summary>
        /// <param name="request">SDK request</param>
        /// <returns>CRT request</returns>
        public static Aws.Crt.Http.HttpRequest ConvertToCrtRequest(IRequest request)
        {
            // Remove any query params that CRT will set
            if (request.ParameterCollection != null && request.ParameterCollection.Count > 0)
            {
                foreach (var queryParam in request.ParameterCollection.GetSortedParametersList())
                {
                    if (CrtForbiddenQueryParams.Contains(queryParam.Key))
                    {
                        request.ParameterCollection.Remove(queryParam.Key);
                    }
                }
            }

            var crtRequest = new Aws.Crt.Http.HttpRequest
            {
                // Using OriginalString here because ComposeUrl -> ResolveResourcePath -> 
                // JoinResourcePathSegments -> UrlEncode will escape some sequeneces (e.g. Ä -> %C3%84)
                // but initializing that as a Uri will convert it back to Ä
                Uri = AmazonServiceClient.ComposeUrl(request, false).OriginalString,
                Method = request.HttpMethod
            };

            if (request.ContentStream != null)
            {
                if (request.ContentStream.CanSeek)
                {
                    crtRequest.BodyStream = request.ContentStream;
                }
                else if (request.ContentStream is WrapperStream wrappedStream)
                {
                    crtRequest.BodyStream = wrappedStream.GetSeekableBaseStream();
                }
                else
                {
                    throw new AWSCommonRuntimeException("Unable to pass an HTTP request with a non-seekable content stream to CRT.");
                }
            }
            else if (request.Content != null)
            {
                crtRequest.BodyStream = new MemoryStream(request.Content);
            }

            var headerList = new List<HttpHeader>(request.Headers.Count);
            foreach (var header in request.Headers)
            {
                // Skip CRT-calculated headers
                if (!CrtForbiddenHeaders.Contains(header.Key))
                {
                    headerList.Add(new HttpHeader(header.Key, header.Value));
                }
            }
            crtRequest.Headers = headerList.ToArray();

            return crtRequest;
        }

        /// <summary>
        /// Copies the headers from a CRT requst back to an existing SDK request
        /// </summary>
        /// <param name="request">SDK request</param>
        /// <param name="crtRequest">CRT request</param>
        public static void CopyHeadersFromCrtRequest(IRequest request, Aws.Crt.Http.HttpRequest crtRequest)
        {
            // Replace all of the SDK request's headers with the CRT headers (i.e. may now include signing-related headers)
            request.Headers.Clear();
            foreach (var header in crtRequest.Headers)
            {
                request.Headers.Add(header.Name, header.Value);
            }
        }

        /// <summary>
        /// Extracts the list of signed headers from the 'Authorization' header set by CRT
        /// </summary>
        /// <param name="crtRequest">Signed CRT HTTPRequest</param>
        /// <returns>semicolon-delimited list of signed headers</returns>
        public static string ExtractSignedHeaders(Aws.Crt.Http.HttpRequest crtRequest)
        {
            const string startOfSignedHeadersPiece = "SignedHeaders=";

            foreach (var header in crtRequest.Headers)
            {
                if (header.Name == HeaderKeys.AuthorizationHeader)
                {
                    foreach (var piece in header.Value.Split(' '))
                    {
                        if (piece.StartsWith(startOfSignedHeadersPiece))
                        {
                            var signedHeaders = piece.Substring(startOfSignedHeadersPiece.Length);
                            signedHeaders = signedHeaders.TrimEnd(',');     // Remove trailing , separating SignedHeaders from Signature
                            return signedHeaders;
                        }
                    }
                }
            }
            return "";
        }
    }
}
