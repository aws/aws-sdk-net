/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Xml.Serialization;
using System.Text;

using Amazon.SQS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.SQS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Receive Message Request Marshaller
    /// </summary>       
    public class ReceiveMessageRequestMarshaller : IMarshaller<IRequest, ReceiveMessageRequest>
    {
        public IRequest Marshall(ReceiveMessageRequest receiveMessageRequest)
        {
            IRequest request = new DefaultRequest(receiveMessageRequest, "AmazonSQS");
            request.Parameters.Add("Action", "ReceiveMessage");
            request.Parameters.Add("Version", "2012-11-05");
            if (receiveMessageRequest != null && receiveMessageRequest.IsSetQueueUrl())
            {
                request.Parameters.Add("QueueUrl", StringUtils.FromString(receiveMessageRequest.QueueUrl));
            }
            if (receiveMessageRequest != null)
            {
                List<string> attributeNamesList = receiveMessageRequest.AttributeNames;

                int attributeNamesListIndex = 1;
                foreach (string attributeNamesListValue in attributeNamesList)
                { 
                    request.Parameters.Add("AttributeName." + attributeNamesListIndex, StringUtils.FromString(attributeNamesListValue));
                    attributeNamesListIndex++;
                }
            }
            if (receiveMessageRequest != null && receiveMessageRequest.IsSetMaxNumberOfMessages())
            {
                request.Parameters.Add("MaxNumberOfMessages", StringUtils.FromInt(receiveMessageRequest.MaxNumberOfMessages));
            }
            if (receiveMessageRequest != null && receiveMessageRequest.IsSetVisibilityTimeout())
            {
                request.Parameters.Add("VisibilityTimeout", StringUtils.FromInt(receiveMessageRequest.VisibilityTimeout));
            }
            if (receiveMessageRequest != null && receiveMessageRequest.IsSetWaitTimeSeconds())
            {
                request.Parameters.Add("WaitTimeSeconds", StringUtils.FromInt(receiveMessageRequest.WaitTimeSeconds));
            }

            return request;
        }
    }
}
