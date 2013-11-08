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
    /// Send Message Batch Request Marshaller
    /// </summary>       
    public class SendMessageBatchRequestMarshaller : IMarshaller<IRequest, SendMessageBatchRequest>
    {
        public IRequest Marshall(SendMessageBatchRequest sendMessageBatchRequest)
        {
            IRequest request = new DefaultRequest(sendMessageBatchRequest, "AmazonSQS");
            request.Parameters.Add("Action", "SendMessageBatch");
            request.Parameters.Add("Version", "2012-11-05");
            if (sendMessageBatchRequest != null && sendMessageBatchRequest.IsSetQueueUrl())
            {
                request.Parameters.Add("QueueUrl", StringUtils.FromString(sendMessageBatchRequest.QueueUrl));
            }

            if (sendMessageBatchRequest != null)
            {
                List<SendMessageBatchRequestEntry> entriesList = sendMessageBatchRequest.Entries;
                int entriesListIndex = 1;
                foreach (SendMessageBatchRequestEntry entriesListValue in entriesList)
                {
                    if (entriesListValue != null && entriesListValue.IsSetId())
                    {
                        request.Parameters.Add("SendMessageBatchRequestEntry." + entriesListIndex + ".Id", StringUtils.FromString(entriesListValue.Id));
                    }
                    if (entriesListValue != null && entriesListValue.IsSetMessageBody())
                    {
                        request.Parameters.Add("SendMessageBatchRequestEntry." + entriesListIndex + ".MessageBody", StringUtils.FromString(entriesListValue.MessageBody));
                    }
                    if (entriesListValue != null && entriesListValue.IsSetDelaySeconds())
                    {
                        request.Parameters.Add("SendMessageBatchRequestEntry." + entriesListIndex + ".DelaySeconds", StringUtils.FromInt(entriesListValue.DelaySeconds));
                    }

                    entriesListIndex++;
                }
            }

            return request;
        }
    }
}
