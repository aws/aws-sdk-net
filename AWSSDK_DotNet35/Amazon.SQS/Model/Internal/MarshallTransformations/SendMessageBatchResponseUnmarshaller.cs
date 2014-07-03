/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
namespace Amazon.SQS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for SendMessageBatch operation
    /// </summary>  
    public class SendMessageBatchResponseUnmarshaller : XmlResponseUnmarshaller
    {
        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context)
        {
            SendMessageBatchResponse response = new SendMessageBatchResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.IsStartElement)
                {                    
                    if(context.TestExpression("SendMessageBatchResult", 2))
                    {
                        UnmarshallResult(context, response);                        
                        continue;
                    }
                    
                    if (context.TestExpression("ResponseMetadata", 2))
                    {
                        response.ResponseMetadata = ResponseMetadataUnmarshaller.Instance.Unmarshall(context);
                    }
                }
            }

            return response;
        }

        private static void UnmarshallResult(XmlUnmarshallerContext context, SendMessageBatchResponse response)
        {
            
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {

                    if (context.TestExpression("BatchResultErrorEntry", targetDepth))
                    {
                        var unmarshaller = BatchResultErrorEntryUnmarshaller.Instance;
                        var item = unmarshaller.Unmarshall(context);
                        response.Failed.Add(item);
                        continue;
                    }
                    if (context.TestExpression("SendMessageBatchResultEntry", targetDepth))
                    {
                        var unmarshaller = SendMessageBatchResultEntryUnmarshaller.Instance;
                        var item = unmarshaller.Unmarshall(context);
                        response.Successful.Add(item);
                        continue;
                    }
                } 
           }

            return;
        }


        public override AmazonServiceException UnmarshallException(XmlUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            ErrorResponse errorResponse = ErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            if (errorResponse.Code != null && errorResponse.Code.Equals("AWS.SimpleQueueService.BatchEntryIdsNotDistinct"))
            {
                return new BatchEntryIdsNotDistinctException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("AWS.SimpleQueueService.BatchRequestTooLong"))
            {
                return new BatchRequestTooLongException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("AWS.SimpleQueueService.EmptyBatchRequest"))
            {
                return new EmptyBatchRequestException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("AWS.SimpleQueueService.InvalidBatchEntryId"))
            {
                return new InvalidBatchEntryIdException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("AWS.SimpleQueueService.TooManyEntriesInBatchRequest"))
            {
                return new TooManyEntriesInBatchRequestException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("AWS.SimpleQueueService.UnsupportedOperation"))
            {
                return new UnsupportedOperationException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            return new AmazonSQSException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }

        private static SendMessageBatchResponseUnmarshaller _instance = new SendMessageBatchResponseUnmarshaller();        

        internal static SendMessageBatchResponseUnmarshaller GetInstance()
        {
            return _instance;
        }
        public static SendMessageBatchResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}