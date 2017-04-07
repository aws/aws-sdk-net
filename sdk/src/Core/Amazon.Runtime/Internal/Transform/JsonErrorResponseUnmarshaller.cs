/*
 * Copyright 2010-2017 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using Amazon.Util;
using System.Xml;


namespace Amazon.Runtime.Internal.Transform
{
    /// <summary>
    ///    Response Unmarshaller for all Errors
    /// </summary>
    public class JsonErrorResponseUnmarshaller : IUnmarshaller<ErrorResponse, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Build an ErrorResponse from json 
        /// </summary>
        /// <param name="context">The json parsing context. 
        /// Usually an <c>Amazon.Runtime.Internal.JsonUnmarshallerContext</c>.</param>
        /// <returns>An <c>ErrorResponse</c> object.</returns>
        public ErrorResponse Unmarshall(JsonUnmarshallerContext context)
        {
            ErrorResponse response;

            if (context.Peek() == 60) //starts with '<' so assuming XML.
            {
                ErrorResponseUnmarshaller xmlUnmarshaller = new ErrorResponseUnmarshaller();
                XmlUnmarshallerContext xmlContext = new XmlUnmarshallerContext(context.Stream, false, null);
                response = xmlUnmarshaller.Unmarshall(xmlContext);
            }
            else
            {
                string type = null;
                string message = null;
                string code = null;

                while (context.Read())
                {
                    if (context.TestExpression("__type"))
                    {
                        type = StringUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("message"))
                    {
                        message = StringUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("code"))
                    {
                        code = StringUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                }
                
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
                        var index = errorType.IndexOf(":", StringComparison.Ordinal);
                        if(index != -1)
                        {
                            errorType = errorType.Substring(0, index);
                        }
                        type = errorType;
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
                type = type.Substring(type.LastIndexOf("#", StringComparison.Ordinal) + 1);

                response = new ErrorResponse
                {
                    Code = type,
                    Message = message,
                    // type is not applicable to JSON services, setting to Unknown
                    Type = ErrorType.Unknown
                };
            }
            
            return response;
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
