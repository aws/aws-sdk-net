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
 * Do not modify this file. This file is generated from the ce-2017-10-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CostExplorer.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.CostExplorer.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AnomalySubscription Marshaller
    /// </summary>
    public class AnomalySubscriptionMarshaller : IRequestMarshaller<AnomalySubscription, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AnomalySubscription requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAccountId())
            {
                context.Writer.WritePropertyName("AccountId");
                context.Writer.WriteStringValue(requestObject.AccountId);
            }

            if(requestObject.IsSetFrequency())
            {
                context.Writer.WritePropertyName("Frequency");
                context.Writer.WriteStringValue(requestObject.Frequency);
            }

            if(requestObject.IsSetMonitorArnList())
            {
                context.Writer.WritePropertyName("MonitorArnList");
                context.Writer.WriteStartArray();
                foreach(var requestObjectMonitorArnListListValue in requestObject.MonitorArnList)
                {
                        context.Writer.WriteStringValue(requestObjectMonitorArnListListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetSubscribers())
            {
                context.Writer.WritePropertyName("Subscribers");
                context.Writer.WriteStartArray();
                foreach(var requestObjectSubscribersListValue in requestObject.Subscribers)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = SubscriberMarshaller.Instance;
                    marshaller.Marshall(requestObjectSubscribersListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetSubscriptionArn())
            {
                context.Writer.WritePropertyName("SubscriptionArn");
                context.Writer.WriteStringValue(requestObject.SubscriptionArn);
            }

            if(requestObject.IsSetSubscriptionName())
            {
                context.Writer.WritePropertyName("SubscriptionName");
                context.Writer.WriteStringValue(requestObject.SubscriptionName);
            }

            if(requestObject.IsSetThreshold())
            {
                context.Writer.WritePropertyName("Threshold");
                if(StringUtils.IsSpecialDoubleValue(requestObject.Threshold.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.Threshold.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.Threshold.Value);
                }
            }

            if(requestObject.IsSetThresholdExpression())
            {
                context.Writer.WritePropertyName("ThresholdExpression");
                context.Writer.WriteStartObject();

                var marshaller = ExpressionMarshaller.Instance;
                marshaller.Marshall(requestObject.ThresholdExpression, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AnomalySubscriptionMarshaller Instance = new AnomalySubscriptionMarshaller();

    }
}