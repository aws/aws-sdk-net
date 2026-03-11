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
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Util;
using System;
using System.Collections.Generic;
using System.Formats.Cbor;
using System.IO;
using System.Net;

namespace Amazon.Extensions.CborProtocol.Internal.Transform
{
    /// <summary>
    /// Class for unmarshalling CBOR service responses.
    /// </summary>
    public class CborErrorResponseUnmarshaller : ICborUnmarshaller<ErrorResponse, CborUnmarshallerContext>
    {
        /// <summary>
        /// Build an ErrorResponse from Cbor 
        /// </summary>
        /// <param name="context">The Cbor parsing context. 
        /// Usually an <c>Amazon.Runtime.Internal.CborUnmarshallerContext</c>.</param>
        /// <returns>An <c>ErrorResponse</c> object.</returns>
        public ErrorResponse Unmarshall(CborUnmarshallerContext context)
        {
            var errorType = ErrorType.Unknown;

            if (context.ResponseData.StatusCode == HttpStatusCode.BadRequest)
            {
                errorType = ErrorType.Sender;
            }
            else if (context.ResponseData.StatusCode == HttpStatusCode.InternalServerError)
            {
                errorType = ErrorType.Receiver;
            }

            var response = new ErrorResponse
            {
                Type = errorType,
                StatusCode = context.ResponseData.StatusCode,
            };

            var reader = context.Reader;
            reader.ReadStartMap();
            while (reader.PeekState() != CborReaderState.EndMap)
            {
                string propertyName = reader.ReadTextString().ToLowerInvariant();
                switch (propertyName)
                {
                    case "__type":
                        {
                            context.AddPathSegment("__type");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            var type = unmarshaller.Unmarshall(context);
                            response.Code = SanitizeErrorType(type);
                            context.PopPathSegment();
                            break;
                        }
                    case "message":
                        {
                            context.AddPathSegment("message");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            response.Message = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    default:
                        reader.SkipValue();
                        break;
                }
            }

            if (context.ResponseData.IsHeaderPresent(HeaderKeys.RequestIdHeader))
            {
                response.RequestId = context.ResponseData.GetHeaderValue(HeaderKeys.RequestIdHeader);
            }

            return response;
        }

        /// <summary>
        /// Extracts the error type from a Smithy shape identifier string.
        /// The input is expected to be in the format "namespace#ErrorType[:additionalInfo]".
        /// Returns the error type portion (e.g., "ErrorType").
        /// </summary>
        private string SanitizeErrorType(string type)
        {
            int start = type.IndexOf('#');
            start = start == -1 ? 0 : start + 1;

            int end = type.IndexOf(':', start);
            end = end == -1 ? type.Length : end;

            return type.Substring(start, end - start).Trim();
        }

        private static CborErrorResponseUnmarshaller instance;

        /// <summary>
        /// Return an instance of CborErrorResponseUnmarshaller.
        /// </summary>
        /// <returns></returns>
        public static CborErrorResponseUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new CborErrorResponseUnmarshaller();

            return instance;
        }
    }
}
