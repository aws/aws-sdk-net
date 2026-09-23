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
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.IVSRealTime.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Globalization;
using Amazon.Util;
#pragma warning disable CS0612,CS0618

namespace Amazon.IVSRealTime.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for CreateIngestConfiguration operation.
    /// </summary>
    public partial class CreateIngestConfigurationResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            var unmarshalledObject = new CreateIngestConfigurationResponse();
            var reader = new StreamingUtf8JsonReader(context.Stream, AWSConfigs.StreamingUtf8JsonReaderBufferSize ?? 4096, context.JsonMaxDepth);

            context.Read(ref reader);
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("ingestConfiguration", targetDepth, ref reader))
                {
                    var unmarshaller = IngestConfigurationUnmarshaller.Instance;
                    unmarshalledObject.IngestConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
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

        /// <summary>
        /// Unmarshall error response to exception.
        /// </summary>
        public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            var reader = new StreamingUtf8JsonReader(context.Stream, AWSConfigs.StreamingUtf8JsonReaderBufferSize ?? 4096, context.JsonMaxDepth);
            var errorResponse = JsonErrorResponseUnmarshaller.GetInstance().Unmarshall(context, ref reader);

            errorResponse.InnerException = innerException;
            errorResponse.StatusCode = statusCode;

            var responseBodyBytes = context.GetResponseBodyBytes();

            using (var streamCopy = new MemoryStream(responseBodyBytes))
            {
                using (var contextCopy = new JsonUnmarshallerContext(streamCopy, false, context.ResponseData))
                {
                    var readerCopy = new StreamingUtf8JsonReader(streamCopy, AWSConfigs.StreamingUtf8JsonReaderBufferSize ?? 4096, context.JsonMaxDepth);
                    if (errorResponse.Code != null && errorResponse.Code.Equals("AccessDeniedException"))
                    {
                        return AccessDeniedExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                    }
                    if (errorResponse.Code != null && errorResponse.Code.Equals("PendingVerification"))
                    {
                        return PendingVerificationExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                    }
                    if (errorResponse.Code != null && errorResponse.Code.Equals("ServiceQuotaExceededException"))
                    {
                        return ServiceQuotaExceededExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                    }
                    if (errorResponse.Code != null && errorResponse.Code.Equals("ValidationException"))
                    {
                        return ValidationExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                    }
                }
            }
            return new AmazonIVSRealTimeException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static CreateIngestConfigurationResponseUnmarshaller _instance = new CreateIngestConfigurationResponseUnmarshaller();

        internal static CreateIngestConfigurationResponseUnmarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateIngestConfigurationResponseUnmarshaller Instance => _instance;
    }
}
