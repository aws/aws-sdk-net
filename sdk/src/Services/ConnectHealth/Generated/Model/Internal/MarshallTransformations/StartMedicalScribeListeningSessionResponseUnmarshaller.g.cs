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

using Amazon.ConnectHealth.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Globalization;
using Amazon.Util;
#pragma warning disable CS0612,CS0618

namespace Amazon.ConnectHealth.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for StartMedicalScribeListeningSession operation.
    /// </summary>
    public partial class StartMedicalScribeListeningSessionResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            var unmarshalledObject = new StartMedicalScribeListeningSessionResponse();
            unmarshalledObject.ResponseStream = new MedicalScribeOutputStream(context.Stream);
            if (context.ResponseData.IsHeaderPresent("x-amzn-medscribe-domain-id"))
            {
                unmarshalledObject.DomainId = context.ResponseData.GetHeaderValue("x-amzn-medscribe-domain-id");
            }
            if (context.ResponseData.IsHeaderPresent("x-amzn-medscribe-language-code"))
            {
                unmarshalledObject.LanguageCode = context.ResponseData.GetHeaderValue("x-amzn-medscribe-language-code");
            }
            if (context.ResponseData.IsHeaderPresent("x-amzn-medscribe-media-encoding"))
            {
                unmarshalledObject.MediaEncoding = context.ResponseData.GetHeaderValue("x-amzn-medscribe-media-encoding");
            }
            if (context.ResponseData.IsHeaderPresent("x-amzn-medscribe-sample-rate"))
            {
                unmarshalledObject.MediaSampleRateHertz = int.Parse(context.ResponseData.GetHeaderValue("x-amzn-medscribe-sample-rate"), CultureInfo.InvariantCulture);
            }
            if (context.ResponseData.IsHeaderPresent("x-amzn-request-id"))
            {
                unmarshalledObject.RequestId = context.ResponseData.GetHeaderValue("x-amzn-request-id");
            }
            if (context.ResponseData.IsHeaderPresent("x-amzn-medscribe-session-id"))
            {
                unmarshalledObject.SessionId = context.ResponseData.GetHeaderValue("x-amzn-medscribe-session-id");
            }
            if (context.ResponseData.IsHeaderPresent("x-amzn-medscribe-subscription-id"))
            {
                unmarshalledObject.SubscriptionId = context.ResponseData.GetHeaderValue("x-amzn-medscribe-subscription-id");
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
            }
            return new AmazonConnectHealthException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        /// <summary>
        /// Overriden to return true indicating the response contains streaming data.
        /// </summary>
        public override bool HasStreamingProperty => true;

        /// <summary>
        /// Return false for reading the entire response
        /// </summary>
        protected override bool ShouldReadEntireResponse(IWebResponseData response, bool readEntireResponse) => false;

        private static StartMedicalScribeListeningSessionResponseUnmarshaller _instance = new StartMedicalScribeListeningSessionResponseUnmarshaller();

        internal static StartMedicalScribeListeningSessionResponseUnmarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static StartMedicalScribeListeningSessionResponseUnmarshaller Instance => _instance;
    }
}
