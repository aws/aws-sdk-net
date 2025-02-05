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
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Lambda.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using Amazon.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Lambda.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for InvokeWithResponseStream operation
    /// </summary>  
    public class InvokeWithResponseStreamResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            InvokeWithResponseStreamResponse response = new InvokeWithResponseStreamResponse();
            response.EventStream = new InvokeWithResponseStreamResponseEvent(context.Stream);
            if (context.ResponseData.IsHeaderPresent("X-Amz-Executed-Version"))
                response.ExecutedVersion = context.ResponseData.GetHeaderValue("X-Amz-Executed-Version");
            if (context.ResponseData.IsHeaderPresent("Content-Type"))
                response.ResponseStreamContentType = context.ResponseData.GetHeaderValue("Content-Type");
            response.StatusCode = (int)context.ResponseData.StatusCode;

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
                if (errorResponse.Code != null && errorResponse.Code.Equals("EC2AccessDeniedException"))
                {
                    return EC2AccessDeniedExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("EC2ThrottledException"))
                {
                    return EC2ThrottledExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("EC2UnexpectedException"))
                {
                    return EC2UnexpectedExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("EFSIOException"))
                {
                    return EFSIOExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("EFSMountConnectivityException"))
                {
                    return EFSMountConnectivityExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("EFSMountFailureException"))
                {
                    return EFSMountFailureExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("EFSMountTimeoutException"))
                {
                    return EFSMountTimeoutExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ENILimitReachedException"))
                {
                    return ENILimitReachedExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidParameterValueException"))
                {
                    return InvalidParameterValueExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidRequestContentException"))
                {
                    return InvalidRequestContentExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidRuntimeException"))
                {
                    return InvalidRuntimeExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidSecurityGroupIDException"))
                {
                    return InvalidSecurityGroupIDExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidSubnetIDException"))
                {
                    return InvalidSubnetIDExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidZipFileException"))
                {
                    return InvalidZipFileExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("KMSAccessDeniedException"))
                {
                    return KMSAccessDeniedExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("KMSDisabledException"))
                {
                    return KMSDisabledExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("KMSInvalidStateException"))
                {
                    return KMSInvalidStateExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("KMSNotFoundException"))
                {
                    return KMSNotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("RecursiveInvocationException"))
                {
                    return RecursiveInvocationExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("RequestTooLargeException"))
                {
                    return RequestTooLargeExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ResourceConflictException"))
                {
                    return ResourceConflictExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ResourceNotFoundException"))
                {
                    return ResourceNotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ResourceNotReadyException"))
                {
                    return ResourceNotReadyExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ServiceException"))
                {
                    return ServiceExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("SnapStartException"))
                {
                    return SnapStartExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("SnapStartNotReadyException"))
                {
                    return SnapStartNotReadyExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("SnapStartTimeoutException"))
                {
                    return SnapStartTimeoutExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("SubnetIPAddressLimitReachedException"))
                {
                    return SubnetIPAddressLimitReachedExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("TooManyRequestsException"))
                {
                    return TooManyRequestsExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("UnsupportedMediaTypeException"))
                {
                    return UnsupportedMediaTypeExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
            }
            return new AmazonLambdaException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static InvokeWithResponseStreamResponseUnmarshaller _instance = new InvokeWithResponseStreamResponseUnmarshaller();        

        internal static InvokeWithResponseStreamResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static InvokeWithResponseStreamResponseUnmarshaller Instance
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