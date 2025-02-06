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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AwsSnsTopicDetails Marshaller
    /// </summary>
    public class AwsSnsTopicDetailsMarshaller : IRequestMarshaller<AwsSnsTopicDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsSnsTopicDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetApplicationSuccessFeedbackRoleArn())
            {
                context.Writer.WritePropertyName("ApplicationSuccessFeedbackRoleArn");
                context.Writer.WriteStringValue(requestObject.ApplicationSuccessFeedbackRoleArn);
            }

            if(requestObject.IsSetFirehoseFailureFeedbackRoleArn())
            {
                context.Writer.WritePropertyName("FirehoseFailureFeedbackRoleArn");
                context.Writer.WriteStringValue(requestObject.FirehoseFailureFeedbackRoleArn);
            }

            if(requestObject.IsSetFirehoseSuccessFeedbackRoleArn())
            {
                context.Writer.WritePropertyName("FirehoseSuccessFeedbackRoleArn");
                context.Writer.WriteStringValue(requestObject.FirehoseSuccessFeedbackRoleArn);
            }

            if(requestObject.IsSetHttpFailureFeedbackRoleArn())
            {
                context.Writer.WritePropertyName("HttpFailureFeedbackRoleArn");
                context.Writer.WriteStringValue(requestObject.HttpFailureFeedbackRoleArn);
            }

            if(requestObject.IsSetHttpSuccessFeedbackRoleArn())
            {
                context.Writer.WritePropertyName("HttpSuccessFeedbackRoleArn");
                context.Writer.WriteStringValue(requestObject.HttpSuccessFeedbackRoleArn);
            }

            if(requestObject.IsSetKmsMasterKeyId())
            {
                context.Writer.WritePropertyName("KmsMasterKeyId");
                context.Writer.WriteStringValue(requestObject.KmsMasterKeyId);
            }

            if(requestObject.IsSetOwner())
            {
                context.Writer.WritePropertyName("Owner");
                context.Writer.WriteStringValue(requestObject.Owner);
            }

            if(requestObject.IsSetSqsFailureFeedbackRoleArn())
            {
                context.Writer.WritePropertyName("SqsFailureFeedbackRoleArn");
                context.Writer.WriteStringValue(requestObject.SqsFailureFeedbackRoleArn);
            }

            if(requestObject.IsSetSqsSuccessFeedbackRoleArn())
            {
                context.Writer.WritePropertyName("SqsSuccessFeedbackRoleArn");
                context.Writer.WriteStringValue(requestObject.SqsSuccessFeedbackRoleArn);
            }

            if(requestObject.IsSetSubscription())
            {
                context.Writer.WritePropertyName("Subscription");
                context.Writer.WriteStartArray();
                foreach(var requestObjectSubscriptionListValue in requestObject.Subscription)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AwsSnsTopicSubscriptionMarshaller.Instance;
                    marshaller.Marshall(requestObjectSubscriptionListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetTopicName())
            {
                context.Writer.WritePropertyName("TopicName");
                context.Writer.WriteStringValue(requestObject.TopicName);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AwsSnsTopicDetailsMarshaller Instance = new AwsSnsTopicDetailsMarshaller();

    }
}