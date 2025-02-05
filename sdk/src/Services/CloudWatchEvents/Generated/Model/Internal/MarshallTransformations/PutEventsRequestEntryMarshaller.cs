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
 * Do not modify this file. This file is generated from the events-2015-10-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudWatchEvents.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.CloudWatchEvents.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PutEventsRequestEntry Marshaller
    /// </summary>
    public class PutEventsRequestEntryMarshaller : IRequestMarshaller<PutEventsRequestEntry, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(PutEventsRequestEntry requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDetail())
            {
                context.Writer.WritePropertyName("Detail");
                context.Writer.WriteStringValue(requestObject.Detail);
            }

            if(requestObject.IsSetDetailType())
            {
                context.Writer.WritePropertyName("DetailType");
                context.Writer.WriteStringValue(requestObject.DetailType);
            }

            if(requestObject.IsSetEventBusName())
            {
                context.Writer.WritePropertyName("EventBusName");
                context.Writer.WriteStringValue(requestObject.EventBusName);
            }

            if(requestObject.IsSetResources())
            {
                context.Writer.WritePropertyName("Resources");
                context.Writer.WriteStartArray();
                foreach(var requestObjectResourcesListValue in requestObject.Resources)
                {
                        context.Writer.WriteStringValue(requestObjectResourcesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetSource())
            {
                context.Writer.WritePropertyName("Source");
                context.Writer.WriteStringValue(requestObject.Source);
            }

            if(requestObject.IsSetTime())
            {
                context.Writer.WritePropertyName("Time");
                context.Writer.WriteNumberValue(Convert.ToInt64(StringUtils.FromDateTimeToUnixTimestamp(requestObject.Time.Value)));
            }

            if(requestObject.IsSetTraceHeader())
            {
                context.Writer.WritePropertyName("TraceHeader");
                context.Writer.WriteStringValue(requestObject.TraceHeader);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static PutEventsRequestEntryMarshaller Instance = new PutEventsRequestEntryMarshaller();

    }
}