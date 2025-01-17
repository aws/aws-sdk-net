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
 * Do not modify this file. This file is generated from the sqs-2012-11-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SQS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using Amazon.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.SQS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DeleteQueue operation
    /// </summary>  
    public class DeleteQueueResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            DeleteQueueResponse response = new DeleteQueueResponse();

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
            using (var contextCopy = new JsonUnmarshallerContext(streamCopy, true, context.ResponseData))
            {
                StreamingUtf8JsonReader readerCopy = new StreamingUtf8JsonReader(streamCopy);
                if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidAddress"))
                {
                    return InvalidAddressExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidSecurity"))
                {
                    return InvalidSecurityExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("QueueDoesNotExist"))
                {
                    return QueueDoesNotExistExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("RequestThrottled"))
                {
                    return RequestThrottledExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("UnsupportedOperation"))
                {
                    return UnsupportedOperationExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
            }
            var errorCode = errorResponse.Code;
            var errorType = errorResponse.Type;
            var queryHeaderKey = Amazon.Util.HeaderKeys.XAmzQueryError;
            if (context.ResponseData.IsHeaderPresent(queryHeaderKey))
            {
                var queryError = context.ResponseData.GetHeaderValue(queryHeaderKey);
                if (!string.IsNullOrEmpty(queryError) && queryError.Contains(";"))
                {
                    var queryErrorParts = queryError.Split(';');
                    if (queryErrorParts.Length == 2)
                    {
                        errorCode = queryErrorParts[0];
                        var errorTypeString = queryErrorParts[1];
                        if (Enum.IsDefined(typeof(ErrorType), errorTypeString))
                        {
                            errorType = (ErrorType) Enum.Parse(typeof(ErrorType), errorTypeString);
                        }
                    }
                }
            }
            return new AmazonSQSException(errorResponse.Message, errorResponse.InnerException, errorType, errorCode, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static DeleteQueueResponseUnmarshaller _instance = new DeleteQueueResponseUnmarshaller();        

        internal static DeleteQueueResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DeleteQueueResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}