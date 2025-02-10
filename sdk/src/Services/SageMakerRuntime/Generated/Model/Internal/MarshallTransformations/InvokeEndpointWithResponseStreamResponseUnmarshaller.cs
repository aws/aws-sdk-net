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
 * Do not modify this file. This file is generated from the runtime.sagemaker-2017-05-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SageMakerRuntime.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using Amazon.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.SageMakerRuntime.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for InvokeEndpointWithResponseStream operation
    /// </summary>  
    public class InvokeEndpointWithResponseStreamResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            InvokeEndpointWithResponseStreamResponse response = new InvokeEndpointWithResponseStreamResponse();
            response.Body = new ResponseStream(context.Stream);
            if (context.ResponseData.IsHeaderPresent("X-Amzn-SageMaker-Content-Type"))
                response.ContentType = context.ResponseData.GetHeaderValue("X-Amzn-SageMaker-Content-Type");
            if (context.ResponseData.IsHeaderPresent("X-Amzn-SageMaker-Custom-Attributes"))
                response.CustomAttributes = context.ResponseData.GetHeaderValue("X-Amzn-SageMaker-Custom-Attributes");
            if (context.ResponseData.IsHeaderPresent("x-Amzn-Invoked-Production-Variant"))
                response.InvokedProductionVariant = context.ResponseData.GetHeaderValue("x-Amzn-Invoked-Production-Variant");

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
                if (errorResponse.Code != null && errorResponse.Code.Equals("InternalFailure"))
                {
                    return InternalFailureExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("InternalStreamFailure"))
                {
                    return InternalStreamFailureExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ModelError"))
                {
                    return ModelErrorExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ModelStreamError"))
                {
                    return ModelStreamErrorExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ServiceUnavailable"))
                {
                    return ServiceUnavailableExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ValidationError"))
                {
                    return ValidationErrorExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
            }
            return new AmazonSageMakerRuntimeException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static InvokeEndpointWithResponseStreamResponseUnmarshaller _instance = new InvokeEndpointWithResponseStreamResponseUnmarshaller();        

        internal static InvokeEndpointWithResponseStreamResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static InvokeEndpointWithResponseStreamResponseUnmarshaller Instance
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