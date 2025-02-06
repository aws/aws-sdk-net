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
 * Do not modify this file. This file is generated from the personalize-events-2018-03-22.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.PersonalizeEvents.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.PersonalizeEvents.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Event Marshaller
    /// </summary>
    public class EventMarshaller : IRequestMarshaller<Event, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Event requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetEventId())
            {
                context.Writer.WritePropertyName("eventId");
                context.Writer.WriteStringValue(requestObject.EventId);
            }

            if(requestObject.IsSetEventType())
            {
                context.Writer.WritePropertyName("eventType");
                context.Writer.WriteStringValue(requestObject.EventType);
            }

            if(requestObject.IsSetEventValue())
            {
                context.Writer.WritePropertyName("eventValue");
                if(StringUtils.IsSpecialFloatValue(requestObject.EventValue.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialFloatValue(requestObject.EventValue.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.EventValue.Value);
                }
            }

            if(requestObject.IsSetImpression())
            {
                context.Writer.WritePropertyName("impression");
                context.Writer.WriteStartArray();
                foreach(var requestObjectImpressionListValue in requestObject.Impression)
                {
                        context.Writer.WriteStringValue(requestObjectImpressionListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetItemId())
            {
                context.Writer.WritePropertyName("itemId");
                context.Writer.WriteStringValue(requestObject.ItemId);
            }

            if(requestObject.IsSetMetricAttribution())
            {
                context.Writer.WritePropertyName("metricAttribution");
                context.Writer.WriteStartObject();

                var marshaller = MetricAttributionMarshaller.Instance;
                marshaller.Marshall(requestObject.MetricAttribution, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetProperties())
            {
                context.Writer.WritePropertyName("properties");
                context.Writer.WriteStringValue(requestObject.Properties);
            }

            if(requestObject.IsSetRecommendationId())
            {
                context.Writer.WritePropertyName("recommendationId");
                context.Writer.WriteStringValue(requestObject.RecommendationId);
            }

            if(requestObject.IsSetSentAt())
            {
                context.Writer.WritePropertyName("sentAt");
                context.Writer.WriteNumberValue(Convert.ToInt64(StringUtils.FromDateTimeToUnixTimestamp(requestObject.SentAt.Value)));
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static EventMarshaller Instance = new EventMarshaller();

    }
}