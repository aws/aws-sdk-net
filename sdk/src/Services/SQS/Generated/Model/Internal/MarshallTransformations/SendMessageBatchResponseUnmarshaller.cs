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
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.SQS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for SendMessageBatch operation
    /// </summary>  
    public class SendMessageBatchResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            SendMessageBatchResponse response = new SendMessageBatchResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Failed", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<BatchResultErrorEntry, BatchResultErrorEntryUnmarshaller>(BatchResultErrorEntryUnmarshaller.Instance);
                    response.Failed = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Successful", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<SendMessageBatchResultEntry, SendMessageBatchResultEntryUnmarshaller>(SendMessageBatchResultEntryUnmarshaller.Instance);
                    response.Successful = unmarshaller.Unmarshall(context);
                    continue;
                }
            }

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
            var errorResponse = JsonErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            errorResponse.InnerException = innerException;
            errorResponse.StatusCode = statusCode;

            var responseBodyBytes = context.GetResponseBodyBytes();

            using (var streamCopy = new MemoryStream(responseBodyBytes))
            using (var contextCopy = new JsonUnmarshallerContext(streamCopy, true, context.ResponseData))
            {
                var errorTypeName = errorResponse.Code;
                var queryHeaderKey = Amazon.Util.HeaderKeys.XAmzQueryError;
                if (context.ResponseData.IsHeaderPresent(queryHeaderKey))
                {
                    var queryError = context.ResponseData.GetHeaderValue(queryHeaderKey);
                    if (!string.IsNullOrEmpty(queryError) && queryError.Contains(";"))
                    {
                        var queryErrorParts = queryError.Split(';');
                        if (queryErrorParts.Length == 2)
                        {
                            errorResponse.Code = queryErrorParts[0];
                            var errorTypeString = queryErrorParts[1];
                            if (Enum.IsDefined(typeof(ErrorType), errorTypeString))
                            {
                                errorResponse.Type = (ErrorType) Enum.Parse(typeof(ErrorType), errorTypeString);
                            }
                        }
                    }
                }
                if (errorTypeName != null && errorTypeName.Equals("BatchEntryIdsNotDistinct"))
                {
                    return BatchEntryIdsNotDistinctExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorTypeName != null && errorTypeName.Equals("BatchRequestTooLong"))
                {
                    return BatchRequestTooLongExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorTypeName != null && errorTypeName.Equals("EmptyBatchRequest"))
                {
                    return EmptyBatchRequestExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorTypeName != null && errorTypeName.Equals("InvalidAddress"))
                {
                    return InvalidAddressExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorTypeName != null && errorTypeName.Equals("InvalidBatchEntryId"))
                {
                    return InvalidBatchEntryIdExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorTypeName != null && errorTypeName.Equals("InvalidSecurity"))
                {
                    return InvalidSecurityExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorTypeName != null && errorTypeName.Equals("KmsAccessDenied"))
                {
                    return KmsAccessDeniedExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorTypeName != null && errorTypeName.Equals("KmsDisabled"))
                {
                    return KmsDisabledExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorTypeName != null && errorTypeName.Equals("KmsInvalidKeyUsage"))
                {
                    return KmsInvalidKeyUsageExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorTypeName != null && errorTypeName.Equals("KmsInvalidState"))
                {
                    return KmsInvalidStateExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorTypeName != null && errorTypeName.Equals("KmsNotFound"))
                {
                    return KmsNotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorTypeName != null && errorTypeName.Equals("KmsOptInRequired"))
                {
                    return KmsOptInRequiredExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorTypeName != null && errorTypeName.Equals("KmsThrottled"))
                {
                    return KmsThrottledExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorTypeName != null && errorTypeName.Equals("QueueDoesNotExist"))
                {
                    return QueueDoesNotExistExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorTypeName != null && errorTypeName.Equals("RequestThrottled"))
                {
                    return RequestThrottledExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorTypeName != null && errorTypeName.Equals("TooManyEntriesInBatchRequest"))
                {
                    return TooManyEntriesInBatchRequestExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorTypeName != null && errorTypeName.Equals("UnsupportedOperation"))
                {
                    return UnsupportedOperationExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
            }
            return new AmazonSQSException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static SendMessageBatchResponseUnmarshaller _instance = new SendMessageBatchResponseUnmarshaller();        

        internal static SendMessageBatchResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SendMessageBatchResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}