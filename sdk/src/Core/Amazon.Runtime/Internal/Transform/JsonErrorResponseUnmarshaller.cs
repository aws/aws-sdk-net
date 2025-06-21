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
using Amazon.Runtime.Internal.Util;
using System;
using Amazon.Util;
using System.Xml;
using System.Text;
using System.IO;
using System.Text.Json;

namespace Amazon.Runtime.Internal.Transform
{
    /// <summary>
    /// First-pass unmarshaller for all errors
    /// </summary>
    public class JsonErrorResponseUnmarshaller : IJsonUnmarshaller<ErrorResponse, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Build an ErrorResponse from json 
        /// </summary>
        /// <param name="context">The json parsing context. 
        /// <param name="reader">The Utf8JsonReader</param>
        /// Usually an <c>Amazon.Runtime.Internal.JsonUnmarshallerContext</c>.</param>
        /// <returns>An <c>ErrorResponse</c> object.</returns>
        public ErrorResponse Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            ErrorResponse response;

            // we cannot use context.Peek() because the stream used by streamreader has been read to completion by the 
            // streamingutf8jsonreader. Since responseBody will be populated, we use that instead.
            for (int i = 0; i < context.ResponseBody.Length; i++)
            {
                if (context.ResponseBody[i] == 32) // skip whitespace
                    continue;
                else
                {
                    if (context.ResponseBody[i] == 60) //starts with '<' so assuming XML.
                    {
                        XmlErrorResponseUnmarshaller xmlUnmarshaller = new XmlErrorResponseUnmarshaller();
                        using (var stream = new MemoryStream(context.GetResponseBodyBytes()))
                        {
                            XmlUnmarshallerContext xmlContext = new XmlUnmarshallerContext(stream, false, null);
                            response = xmlUnmarshaller.Unmarshall(xmlContext);
                            return response;
                        }
                    }
                    else
                        break;
                }
            }

            string type;
            string message;
            string code;
            string requestId = null;
            GetValuesFromJsonIfPossible(context, ref reader, out type, out message, out code);

            // If an error code was not found, check for the x-amzn-ErrorType header. 
            // This header is returned by rest-json services.
            if (string.IsNullOrEmpty(type) &&
                context.ResponseData.IsHeaderPresent(HeaderKeys.XAmzErrorType))
            {
                var errorType = context.ResponseData.GetHeaderValue(HeaderKeys.XAmzErrorType);
                if (!string.IsNullOrEmpty(errorType))
                {
                    // The error type can contain additional information, with ":" as a delimiter
                    // We are only interested in the initial part which is the error type
                    type = ParseType(errorType);
                }
            }

            // Check for the x-amzn-error-message header. This header is returned by rest-json services.
            // If the header is present it is preferred over any value provided in the response body.
            if (context.ResponseData.IsHeaderPresent(HeaderKeys.XAmznErrorMessage))
            {
                var errorMessage = context.ResponseData.GetHeaderValue(HeaderKeys.XAmznErrorMessage);
                if (!string.IsNullOrEmpty(errorMessage))
                    message = errorMessage;
            }

            // if both "__type" and HeaderKeys.XAmzErrorType were not specified, use "code" as type
            // this impacts Glacier
            if (string.IsNullOrEmpty(type) &&
                !string.IsNullOrEmpty(code))
            {
                type = code;
            }

            // strip extra data from type, leaving only the exception type name
            type = type == null ? null : ParseType(type.Substring(type.LastIndexOf("#", StringComparison.Ordinal) + 1));
            // if no message was found create a generic message
            if (string.IsNullOrEmpty(message))
            {
                if (string.IsNullOrEmpty(type))
                {
                    if (string.IsNullOrEmpty(context.ResponseBody))
                        message = "The service returned an error. See inner exception for details.";
                    else
                        message = "The service returned an error with HTTP Body: " + context.ResponseBody;
                }
                else
                {
                    if (string.IsNullOrEmpty(context.ResponseBody))
                        message = "The service returned an error with Error Code " + type + ".";
                    else
                        message = "The service returned an error with Error Code " + type + " and HTTP Body: " + context.ResponseBody;
                }
            }

            // Check for the x-amzn-RequestId header. This header is returned by rest-json services.
            // If the header is present it is preferred over any value provided in the response body.
            if (context.ResponseData.IsHeaderPresent(HeaderKeys.RequestIdHeader))
            {
                requestId = context.ResponseData.GetHeaderValue(HeaderKeys.RequestIdHeader);
            }

            response = new ErrorResponse
            {
                Code = type,
                Message = message,
                // type is not applicable to JSON services, setting to Unknown
                Type = ErrorType.Unknown,
                RequestId = requestId
            };
            
            
            return response;
        }

        // Parses the __type key returned in an error response by taking the first index of ":" and returning everything up to that index if it exists
        // see https://smithy.io/2.0/aws/protocols/aws-json-1_1-protocol.html#operation-error-serialization
        private static string ParseType(string type)
        {
            var index = type.IndexOf(":", StringComparison.Ordinal);
            if (index != -1)
            {
                type = type.Substring(0, index);
            }
            return type;

        }

        private static void GetValuesFromJsonIfPossible(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader,  out string type, out string message, out string code)
        {
            code = null;
            type = null;
            message = null;

            while (TryReadContext(context, ref reader))
            {
                // Do not attempt to process nested properties, as for DynamoDB the error response may contain
                // extra values that end with one of the prefixes we're looking.
                // Issue reported in: https://github.com/aws/aws-sdk-net/issues/3764
                if (context.CurrentDepth > 1)
                {
                    continue;
                }

                if (context.TestExpression("__type"))
                {
                    type = StringUnmarshaller.GetInstance().Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("message"))
                {
                    message = StringUnmarshaller.GetInstance().Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("code"))
                {
                    code = StringUnmarshaller.GetInstance().Unmarshall(context, ref reader);
                    continue;
                }
            }
        }

        private static bool TryReadContext(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            try
            {
                return context.Read(ref reader);
            }
            catch (JsonException)
            {
                return false;
            }
        }

        private static JsonErrorResponseUnmarshaller instance;

        /// <summary>
        /// Return an instance of JsonErrorResponseUnmarshaller.
        /// </summary>
        /// <returns></returns>
        public static JsonErrorResponseUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new JsonErrorResponseUnmarshaller();

            return instance;
        }
    }
}
