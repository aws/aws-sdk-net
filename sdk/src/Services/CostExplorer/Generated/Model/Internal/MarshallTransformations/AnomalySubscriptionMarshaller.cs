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
using ThirdParty.Json.LitJson;

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
            if(requestObject.IsSetAccountId())
            {
                context.Writer.WritePropertyName("AccountId");
                context.Writer.Write(requestObject.AccountId);
            }

            if(requestObject.IsSetFrequency())
            {
                context.Writer.WritePropertyName("Frequency");
                context.Writer.Write(requestObject.Frequency);
            }

            if(requestObject.IsSetMonitorArnList())
            {
                context.Writer.WritePropertyName("MonitorArnList");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectMonitorArnListListValue in requestObject.MonitorArnList)
                {
                        context.Writer.Write(requestObjectMonitorArnListListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetSubscribers())
            {
                context.Writer.WritePropertyName("Subscribers");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectSubscribersListValue in requestObject.Subscribers)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = SubscriberMarshaller.Instance;
                    marshaller.Marshall(requestObjectSubscribersListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetSubscriptionArn())
            {
                context.Writer.WritePropertyName("SubscriptionArn");
                context.Writer.Write(requestObject.SubscriptionArn);
            }

            if(requestObject.IsSetSubscriptionName())
            {
                context.Writer.WritePropertyName("SubscriptionName");
                context.Writer.Write(requestObject.SubscriptionName);
            }

            if(requestObject.IsSetThreshold())
            {
                context.Writer.WritePropertyName("Threshold");
                context.Writer.Write(requestObject.Threshold);
            }

            if(requestObject.IsSetThresholdExpression())
            {
                context.Writer.WritePropertyName("ThresholdExpression");
                context.Writer.WriteObjectStart();

                var marshaller = ExpressionMarshaller.Instance;
                marshaller.Marshall(requestObject.ThresholdExpression, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AnomalySubscriptionMarshaller Instance = new AnomalySubscriptionMarshaller();

    }
}