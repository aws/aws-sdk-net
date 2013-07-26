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
    /// Send Message Request Marshaller
    /// </summary>       
    public class SendMessageRequestMarshaller : IMarshaller<IRequest, SendMessageRequest>
    {
        public IRequest Marshall(SendMessageRequest sendMessageRequest)
        {
            IRequest request = new DefaultRequest(sendMessageRequest, "AmazonSQS");
            request.Parameters.Add("Action", "SendMessage");
            request.Parameters.Add("Version", "2012-11-05");
            if (sendMessageRequest != null && sendMessageRequest.IsSetQueueUrl())
            {
                request.Parameters.Add("QueueUrl", StringUtils.FromString(sendMessageRequest.QueueUrl));
            }
            if (sendMessageRequest != null && sendMessageRequest.IsSetMessageBody())
            {
                request.Parameters.Add("MessageBody", StringUtils.FromString(sendMessageRequest.MessageBody));
            }
            if (sendMessageRequest != null && sendMessageRequest.IsSetDelaySeconds())
            {
                request.Parameters.Add("DelaySeconds", StringUtils.FromInt(sendMessageRequest.DelaySeconds));
            }

            return request;
        }
    }
}
