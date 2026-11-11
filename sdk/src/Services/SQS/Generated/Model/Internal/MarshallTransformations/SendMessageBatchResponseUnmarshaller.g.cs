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

using Amazon.SQS.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Globalization;
using Amazon.Util;
#pragma warning disable CS0612,CS0618

namespace Amazon.SQS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for SendMessageBatch operation.
    /// </summary>
    public partial class SendMessageBatchResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            var unmarshalledObject = new SendMessageBatchResponse();
            var reader = new StreamingUtf8JsonReader(context.Stream, AWSConfigs.StreamingUtf8JsonReaderBufferSize ?? 4096, context.JsonMaxDepth);

            context.Read(ref reader);
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("Failed", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<BatchResultErrorEntry, BatchResultErrorEntryUnmarshaller>(BatchResultErrorEntryUnmarshaller.Instance);
                    unmarshalledObject.Failed = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("Successful", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<SendMessageBatchResultEntry, SendMessageBatchResultEntryUnmarshaller>(SendMessageBatchResultEntryUnmarshaller.Instance);
                    unmarshalledObject.Successful = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
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
                using (var contextCopy = new JsonUnmarshallerContext(streamCopy, true, context.ResponseData))
                {
                    var readerCopy = new StreamingUtf8JsonReader(streamCopy, AWSConfigs.StreamingUtf8JsonReaderBufferSize ?? 4096, context.JsonMaxDepth);
                    var errorTypeName = errorResponse.Code;
                    Amazon.Runtime.Internal.Transform.AwsQueryCompatibleErrorHandler.ApplyQueryErrorHeader(errorResponse, context.ResponseData);
                    if (errorTypeName != null && errorTypeName.Equals("BatchEntryIdsNotDistinct"))
                    {
                        return BatchEntryIdsNotDistinctExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                    }
                    if (errorTypeName != null && errorTypeName.Equals("BatchRequestTooLong"))
                    {
                        return BatchRequestTooLongExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                    }
                    if (errorTypeName != null && errorTypeName.Equals("EmptyBatchRequest"))
                    {
                        return EmptyBatchRequestExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                    }
                    if (errorTypeName != null && errorTypeName.Equals("InvalidAddress"))
                    {
                        return InvalidAddressExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                    }
                    if (errorTypeName != null && errorTypeName.Equals("InvalidBatchEntryId"))
                    {
                        return InvalidBatchEntryIdExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                    }
                    if (errorTypeName != null && errorTypeName.Equals("InvalidSecurity"))
                    {
                        return InvalidSecurityExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                    }
                    if (errorTypeName != null && errorTypeName.Equals("KmsAccessDenied"))
                    {
                        return KmsAccessDeniedExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                    }
                    if (errorTypeName != null && errorTypeName.Equals("KmsDisabled"))
                    {
                        return KmsDisabledExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                    }
                    if (errorTypeName != null && errorTypeName.Equals("KmsInvalidKeyUsage"))
                    {
                        return KmsInvalidKeyUsageExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                    }
                    if (errorTypeName != null && errorTypeName.Equals("KmsInvalidState"))
                    {
                        return KmsInvalidStateExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                    }
                    if (errorTypeName != null && errorTypeName.Equals("KmsNotFound"))
                    {
                        return KmsNotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                    }
                    if (errorTypeName != null && errorTypeName.Equals("KmsOptInRequired"))
                    {
                        return KmsOptInRequiredExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                    }
                    if (errorTypeName != null && errorTypeName.Equals("KmsThrottled"))
                    {
                        return KmsThrottledExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                    }
                    if (errorTypeName != null && errorTypeName.Equals("QueueDoesNotExist"))
                    {
                        return QueueDoesNotExistExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                    }
                    if (errorTypeName != null && errorTypeName.Equals("RequestThrottled"))
                    {
                        return RequestThrottledExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                    }
                    if (errorTypeName != null && errorTypeName.Equals("TooManyEntriesInBatchRequest"))
                    {
                        return TooManyEntriesInBatchRequestExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                    }
                    if (errorTypeName != null && errorTypeName.Equals("UnsupportedOperation"))
                    {
                        return UnsupportedOperationExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                    }
                }
            }
            return new AmazonSQSException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static SendMessageBatchResponseUnmarshaller _instance = new SendMessageBatchResponseUnmarshaller();

        internal static SendMessageBatchResponseUnmarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static SendMessageBatchResponseUnmarshaller Instance => _instance;
    }
}
