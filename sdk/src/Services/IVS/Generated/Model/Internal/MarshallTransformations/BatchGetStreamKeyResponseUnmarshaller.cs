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
 * Do not modify this file. This file is generated from the ivs-2020-07-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.IVS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using Amazon.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.IVS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for BatchGetStreamKey operation
    /// </summary>  
    public class BatchGetStreamKeyResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            BatchGetStreamKeyResponse response = new BatchGetStreamKeyResponse();
            StreamingUtf8JsonReader reader = new StreamingUtf8JsonReader(context.Stream);
            context.Read(ref reader);
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("errors", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<BatchError, BatchErrorUnmarshaller>(BatchErrorUnmarshaller.Instance);
                    response.Errors = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("streamKeys", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<StreamKey, StreamKeyUnmarshaller>(StreamKeyUnmarshaller.Instance);
                    response.StreamKeys = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            if (context.ResponseData.IsHeaderPresent("Access-Control-Allow-Origin"))
                response.AccessControlAllowOrigin = context.ResponseData.GetHeaderValue("Access-Control-Allow-Origin");
            if (context.ResponseData.IsHeaderPresent("Access-Control-Expose-Headers"))
                response.AccessControlExposeHeaders = context.ResponseData.GetHeaderValue("Access-Control-Expose-Headers");
            if (context.ResponseData.IsHeaderPresent("Cache-Control"))
                response.CacheControl = context.ResponseData.GetHeaderValue("Cache-Control");
            if (context.ResponseData.IsHeaderPresent("Content-Security-Policy"))
                response.ContentSecurityPolicy = context.ResponseData.GetHeaderValue("Content-Security-Policy");
            if (context.ResponseData.IsHeaderPresent("Strict-Transport-Security"))
                response.StrictTransportSecurity = context.ResponseData.GetHeaderValue("Strict-Transport-Security");
            if (context.ResponseData.IsHeaderPresent("X-Content-Type-Options"))
                response.XContentTypeOptions = context.ResponseData.GetHeaderValue("X-Content-Type-Options");
            if (context.ResponseData.IsHeaderPresent("X-Frame-Options"))
                response.XFrameOptions = context.ResponseData.GetHeaderValue("X-Frame-Options");

            return response;
        }

        /// <summary>
        /// Unmarshaller error response to exception.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="innerException"></param>
        /// <param name="statusCode"></param>
        /// <returns></returns>
        public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            StreamingUtf8JsonReader reader = new StreamingUtf8JsonReader(context.Stream);
            var errorResponse = JsonErrorResponseUnmarshaller.GetInstance().Unmarshall(context, ref reader);
            errorResponse.InnerException = innerException;
            errorResponse.StatusCode = statusCode;

            var responseBodyBytes = context.GetResponseBodyBytes();

            using (var streamCopy = new MemoryStream(responseBodyBytes))
            using (var contextCopy = new JsonUnmarshallerContext(streamCopy, false, context.ResponseData))
            {
                StreamingUtf8JsonReader readerCopy = new StreamingUtf8JsonReader(streamCopy);
                if (errorResponse.Code != null && errorResponse.Code.Equals("AccessDeniedException"))
                {
                    return AccessDeniedExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ServiceUnavailable"))
                {
                    return ServiceUnavailableExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ValidationException"))
                {
                    return ValidationExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
            }
            return new AmazonIVSException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static BatchGetStreamKeyResponseUnmarshaller _instance = new BatchGetStreamKeyResponseUnmarshaller();        

        internal static BatchGetStreamKeyResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static BatchGetStreamKeyResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}