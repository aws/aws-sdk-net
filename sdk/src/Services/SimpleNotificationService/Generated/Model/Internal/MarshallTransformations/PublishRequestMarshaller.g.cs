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
    /// Publish Request Marshaller
    /// </summary>
    public partial class PublishRequestMarshaller : IMarshaller<IRequest, PublishRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PublishRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(PublishRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SimpleNotificationService");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "Publish");
            request.Parameters.Add("Version", "2010-03-31");

            if (publicRequest.IsSetMessage())
            {
                request.Parameters.Add("Message", StringUtils.FromString(publicRequest.Message));
            }
            if (publicRequest.IsSetMessageAttributes())
            {
                int index0 = 1;
                foreach (var kvp0 in publicRequest.MessageAttributes)
                {
                    request.Parameters.Add("MessageAttributes" + ".entry" + "." + index0 + ".Name", StringUtils.FromString(kvp0.Key));
                    if (kvp0.Value.IsSetBinaryValue())
                    {
                        request.Parameters.Add("MessageAttributes" + ".entry" + "." + index0 + ".Value" + ".BinaryValue", StringUtils.FromMemoryStream(kvp0.Value.BinaryValue));
                    }
                    if (kvp0.Value.IsSetDataType())
                    {
                        request.Parameters.Add("MessageAttributes" + ".entry" + "." + index0 + ".Value" + ".DataType", StringUtils.FromString(kvp0.Value.DataType));
                    }
                    if (kvp0.Value.IsSetStringValue())
                    {
                        request.Parameters.Add("MessageAttributes" + ".entry" + "." + index0 + ".Value" + ".StringValue", StringUtils.FromString(kvp0.Value.StringValue));
                    }
                    index0++;
                }
            }
            if (publicRequest.IsSetMessageDeduplicationId())
            {
                request.Parameters.Add("MessageDeduplicationId", StringUtils.FromString(publicRequest.MessageDeduplicationId));
            }
            if (publicRequest.IsSetMessageGroupId())
            {
                request.Parameters.Add("MessageGroupId", StringUtils.FromString(publicRequest.MessageGroupId));
            }
            if (publicRequest.IsSetMessageStructure())
            {
                request.Parameters.Add("MessageStructure", StringUtils.FromString(publicRequest.MessageStructure));
            }
            if (publicRequest.IsSetPhoneNumber())
            {
                request.Parameters.Add("PhoneNumber", StringUtils.FromString(publicRequest.PhoneNumber));
            }
            if (publicRequest.IsSetSubject())
            {
                request.Parameters.Add("Subject", StringUtils.FromString(publicRequest.Subject));
            }
            if (publicRequest.IsSetTargetArn())
            {
                request.Parameters.Add("TargetArn", StringUtils.FromString(publicRequest.TargetArn));
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

        private static readonly PublishRequestMarshaller _instance = new();

        internal static PublishRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static PublishRequestMarshaller Instance => _instance;
    }
}
