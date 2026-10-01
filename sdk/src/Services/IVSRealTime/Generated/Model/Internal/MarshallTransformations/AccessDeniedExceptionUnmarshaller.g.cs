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

/*
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.IVSRealTime.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using Amazon.Util;
#pragma warning disable CS0612,CS0618

namespace Amazon.IVSRealTime.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Exception Unmarshaller for AccessDeniedException
    /// </summary>
    public partial class AccessDeniedExceptionUnmarshaller : IJsonErrorResponseUnmarshaller<AccessDeniedException, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the exception from the service to the appropriate exception class
        /// </summary>
        public AccessDeniedException Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            return this.Unmarshall(context, new Amazon.Runtime.Internal.ErrorResponse(), ref reader);
        }

        /// <summary>
        /// Unmarshall the exception from the service to the appropriate exception class
        /// </summary>
        public AccessDeniedException Unmarshall(JsonUnmarshallerContext context, Amazon.Runtime.Internal.ErrorResponse errorResponse, ref StreamingUtf8JsonReader reader)
        {
            var unmarshalledObject = new AccessDeniedException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);

            if (context.Stream.Length > 0)
            {
                context.Read(ref reader);
                int targetDepth = context.CurrentDepth;
                while (context.ReadAtDepth(targetDepth, ref reader))
                {
                    if (context.TestExpression("exceptionMessage", targetDepth, ref reader))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ExceptionMessage = unmarshaller.Unmarshall(context, ref reader);
                        continue;
                    }
                }
            }
            if (context.ResponseData.IsHeaderPresent("Access-Control-Allow-Origin"))
            {
                unmarshalledObject.AccessControlAllowOrigin = context.ResponseData.GetHeaderValue("Access-Control-Allow-Origin");
            }
            if (context.ResponseData.IsHeaderPresent("Access-Control-Expose-Headers"))
            {
                unmarshalledObject.AccessControlExposeHeaders = context.ResponseData.GetHeaderValue("Access-Control-Expose-Headers");
            }
            if (context.ResponseData.IsHeaderPresent("Cache-Control"))
            {
                unmarshalledObject.CacheControl = context.ResponseData.GetHeaderValue("Cache-Control");
            }
            if (context.ResponseData.IsHeaderPresent("Content-Security-Policy"))
            {
                unmarshalledObject.ContentSecurityPolicy = context.ResponseData.GetHeaderValue("Content-Security-Policy");
            }
            if (context.ResponseData.IsHeaderPresent("Strict-Transport-Security"))
            {
                unmarshalledObject.StrictTransportSecurity = context.ResponseData.GetHeaderValue("Strict-Transport-Security");
            }
            if (context.ResponseData.IsHeaderPresent("x-amzn-ErrorType"))
            {
                unmarshalledObject.XAmznErrorType = context.ResponseData.GetHeaderValue("x-amzn-ErrorType");
            }
            if (context.ResponseData.IsHeaderPresent("X-Content-Type-Options"))
            {
                unmarshalledObject.XContentTypeOptions = context.ResponseData.GetHeaderValue("X-Content-Type-Options");
            }
            if (context.ResponseData.IsHeaderPresent("X-Frame-Options"))
            {
                unmarshalledObject.XFrameOptions = context.ResponseData.GetHeaderValue("X-Frame-Options");
            }

            return unmarshalledObject;
        }

        private static AccessDeniedExceptionUnmarshaller _instance = new AccessDeniedExceptionUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static AccessDeniedExceptionUnmarshaller Instance => _instance;
    }
}
