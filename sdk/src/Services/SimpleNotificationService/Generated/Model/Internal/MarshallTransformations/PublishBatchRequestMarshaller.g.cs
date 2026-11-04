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
using System.Globalization;
using System.IO;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

using Amazon.SimpleNotificationService.Model;
#pragma warning disable CS0612,CS0618

namespace Amazon.SimpleNotificationService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PublishBatch Request Marshaller
    /// </summary>
    public partial class PublishBatchRequestMarshaller : IMarshaller<IRequest, PublishBatchRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PublishBatchRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(PublishBatchRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SimpleNotificationService");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "PublishBatch");
            request.Parameters.Add("Version", "2010-03-31");

            if (publicRequest.IsSetPublishBatchRequestEntries())
            {
                if (publicRequest.PublishBatchRequestEntries.Count == 0)
                {
                    request.Parameters.Add("PublishBatchRequestEntries", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.PublishBatchRequestEntries)
                    {
                        if (item0.IsSetId())
                        {
                            request.Parameters.Add("PublishBatchRequestEntries" + ".member" + "." + index0 + ".Id", StringUtils.FromString(item0.Id));
                        }
                        if (item0.IsSetMessage())
                        {
                            request.Parameters.Add("PublishBatchRequestEntries" + ".member" + "." + index0 + ".Message", StringUtils.FromString(item0.Message));
                        }
                        if (item0.IsSetMessageAttributes())
                        {
                            int index1 = 1;
                            foreach (var kvp1 in item0.MessageAttributes)
                            {
                                request.Parameters.Add("PublishBatchRequestEntries" + ".member" + "." + index0 + ".MessageAttributes" + ".entry" + "." + index1 + ".Name", StringUtils.FromString(kvp1.Key));
                                if (kvp1.Value.IsSetBinaryValue())
                                {
                                    request.Parameters.Add("PublishBatchRequestEntries" + ".member" + "." + index0 + ".MessageAttributes" + ".entry" + "." + index1 + ".Value" + ".BinaryValue", StringUtils.FromMemoryStream(kvp1.Value.BinaryValue));
                                }
                                if (kvp1.Value.IsSetDataType())
                                {
                                    request.Parameters.Add("PublishBatchRequestEntries" + ".member" + "." + index0 + ".MessageAttributes" + ".entry" + "." + index1 + ".Value" + ".DataType", StringUtils.FromString(kvp1.Value.DataType));
                                }
                                if (kvp1.Value.IsSetStringValue())
                                {
                                    request.Parameters.Add("PublishBatchRequestEntries" + ".member" + "." + index0 + ".MessageAttributes" + ".entry" + "." + index1 + ".Value" + ".StringValue", StringUtils.FromString(kvp1.Value.StringValue));
                                }
                                index1++;
                            }
                        }
                        if (item0.IsSetMessageDeduplicationId())
                        {
                            request.Parameters.Add("PublishBatchRequestEntries" + ".member" + "." + index0 + ".MessageDeduplicationId", StringUtils.FromString(item0.MessageDeduplicationId));
                        }
                        if (item0.IsSetMessageGroupId())
                        {
                            request.Parameters.Add("PublishBatchRequestEntries" + ".member" + "." + index0 + ".MessageGroupId", StringUtils.FromString(item0.MessageGroupId));
                        }
                        if (item0.IsSetMessageStructure())
                        {
                            request.Parameters.Add("PublishBatchRequestEntries" + ".member" + "." + index0 + ".MessageStructure", StringUtils.FromString(item0.MessageStructure));
                        }
                        if (item0.IsSetSubject())
                        {
                            request.Parameters.Add("PublishBatchRequestEntries" + ".member" + "." + index0 + ".Subject", StringUtils.FromString(item0.Subject));
                        }
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetTopicArn())
            {
                request.Parameters.Add("TopicArn", StringUtils.FromString(publicRequest.TopicArn));
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly PublishBatchRequestMarshaller _instance = new();

        internal static PublishBatchRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static PublishBatchRequestMarshaller Instance => _instance;
    }
}
