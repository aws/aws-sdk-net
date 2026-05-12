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
 * Do not modify this file. This file is generated from the connecthealth-2025-01-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ConnectHealth.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using Amazon.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.ConnectHealth.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for StartMedicalScribeListeningSession operation
    /// </summary>  
    public class StartMedicalScribeListeningSessionResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            StartMedicalScribeListeningSessionResponse response = new StartMedicalScribeListeningSessionResponse();
            response.ResponseStream = new MedicalScribeOutputStream(context.Stream);
            if (context.ResponseData.IsHeaderPresent("x-amzn-medscribe-domain-id"))
                response.DomainId = context.ResponseData.GetHeaderValue("x-amzn-medscribe-domain-id");
            if (context.ResponseData.IsHeaderPresent("x-amzn-medscribe-language-code"))
                response.LanguageCode = context.ResponseData.GetHeaderValue("x-amzn-medscribe-language-code");
            if (context.ResponseData.IsHeaderPresent("x-amzn-medscribe-media-encoding"))
                response.MediaEncoding = context.ResponseData.GetHeaderValue("x-amzn-medscribe-media-encoding");
            if (context.ResponseData.IsHeaderPresent("x-amzn-medscribe-sample-rate"))
                response.MediaSampleRateHertz = int.Parse(context.ResponseData.GetHeaderValue("x-amzn-medscribe-sample-rate"), CultureInfo.InvariantCulture);
            if (context.ResponseData.IsHeaderPresent("x-amzn-request-id"))
                response.RequestId = context.ResponseData.GetHeaderValue("x-amzn-request-id");
            if (context.ResponseData.IsHeaderPresent("x-amzn-medscribe-session-id"))
                response.SessionId = context.ResponseData.GetHeaderValue("x-amzn-medscribe-session-id");
            if (context.ResponseData.IsHeaderPresent("x-amzn-medscribe-subscription-id"))
                response.SubscriptionId = context.ResponseData.GetHeaderValue("x-amzn-medscribe-subscription-id");

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
                if (errorResponse.Code != null && errorResponse.Code.Equals("InternalServerException"))
                {
                    return InternalServerExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ResourceNotFoundException"))
                {
                    return ResourceNotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ServiceQuotaExceededException"))
                {
                    return ServiceQuotaExceededExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ThrottlingException"))
                {
                    return ThrottlingExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ValidationException"))
                {
                    return ValidationExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
            }
            return new AmazonConnectHealthException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static StartMedicalScribeListeningSessionResponseUnmarshaller _instance = new StartMedicalScribeListeningSessionResponseUnmarshaller();        

        internal static StartMedicalScribeListeningSessionResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StartMedicalScribeListeningSessionResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

        /// <summary>
        /// Return false for reading the entire response
        /// </summary>
        /// <param name="response"></param>
        /// <param name="readEntireResponse"></param>
        /// <returns></returns>
        protected override bool ShouldReadEntireResponse(IWebResponseData response, bool readEntireResponse)
        {
            return false;
        }
        /// <summary>
        /// Specifies that the response should be streamed
        /// </summary>
        public override bool HasStreamingProperty => true;
    }
}