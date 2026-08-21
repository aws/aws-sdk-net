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

namespace Amazon.Runtime.Internal.Transform
{
    /// <summary>
    /// Shared helper for services that opt into the AwsQueryCompatible trait when migrating away from
    /// the query protocol. Such services return an x-amzn-query-error header containing a semicolon
    /// delimited Code and Type pair (for example: "AWS.SimpleQueueService.NonExistentQueue;Sender").
    /// When present, that header takes precedence over the error code/type parsed from the response body.
    /// Centralizing this here keeps the logic out of every generated service unmarshaller.
    /// </summary>
    public static class AwsQueryCompatibleErrorHandler
    {
        /// <summary>
        /// Overlays the Code and Type from the x-amzn-query-error header onto the supplied
        /// <see cref="ErrorResponse"/> when the header is present and well-formed. Otherwise the
        /// error response is left unchanged.
        /// </summary>
        /// <param name="errorResponse">The error response to update.</param>
        /// <param name="responseData">The response data to read the header from.</param>
        public static void ApplyQueryErrorHeader(ErrorResponse errorResponse, IWebResponseData responseData)
        {
            var key = Amazon.Util.HeaderKeys.XAmzQueryError;
            if (!responseData.IsHeaderPresent(key))
            {
                return;
            }
            
            var queryError = responseData.GetHeaderValue(key);
            if (string.IsNullOrEmpty(queryError) || !queryError.Contains(";"))
            {
                return;
            }
            
            var parts = queryError.Split(';');
            if (parts.Length != 2)
            {
                return;
            }

            errorResponse.Code = parts[0];
            if (Enum.IsDefined(typeof(ErrorType), parts[1]))
            {
                errorResponse.Type = (ErrorType)Enum.Parse(typeof(ErrorType), parts[1]);
            }
        }
    }
}
