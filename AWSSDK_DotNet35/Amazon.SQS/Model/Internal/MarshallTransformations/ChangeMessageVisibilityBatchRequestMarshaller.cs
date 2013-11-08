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
    /// Change Message Visibility Batch Request Marshaller
    /// </summary>       
    public class ChangeMessageVisibilityBatchRequestMarshaller : IMarshaller<IRequest, ChangeMessageVisibilityBatchRequest>
    {
        public IRequest Marshall(ChangeMessageVisibilityBatchRequest changeMessageVisibilityBatchRequest)
        {
            IRequest request = new DefaultRequest(changeMessageVisibilityBatchRequest, "AmazonSQS");
            request.Parameters.Add("Action", "ChangeMessageVisibilityBatch");
            request.Parameters.Add("Version", "2012-11-05");
            if (changeMessageVisibilityBatchRequest != null && changeMessageVisibilityBatchRequest.IsSetQueueUrl())
            {
                request.Parameters.Add("QueueUrl", StringUtils.FromString(changeMessageVisibilityBatchRequest.QueueUrl));
            }

            if (changeMessageVisibilityBatchRequest != null)
            {
                List<ChangeMessageVisibilityBatchRequestEntry> entriesList = changeMessageVisibilityBatchRequest.Entries;
                int entriesListIndex = 1;
                foreach (ChangeMessageVisibilityBatchRequestEntry entriesListValue in entriesList)
                {
                    if (entriesListValue != null && entriesListValue.IsSetId())
                    {
                        request.Parameters.Add("ChangeMessageVisibilityBatchRequestEntry." + entriesListIndex + ".Id", StringUtils.FromString(entriesListValue.Id));
                    }
                    if (entriesListValue != null && entriesListValue.IsSetReceiptHandle())
                    {
                        request.Parameters.Add("ChangeMessageVisibilityBatchRequestEntry." + entriesListIndex + ".ReceiptHandle", StringUtils.FromString(entriesListValue.ReceiptHandle));
                    }
                    if (entriesListValue != null && entriesListValue.IsSetVisibilityTimeout())
                    {
                        request.Parameters.Add("ChangeMessageVisibilityBatchRequestEntry." + entriesListIndex + ".VisibilityTimeout", StringUtils.FromInt(entriesListValue.VisibilityTimeout));
                    }

                    entriesListIndex++;
                }
            }

            return request;
        }
    }
}
