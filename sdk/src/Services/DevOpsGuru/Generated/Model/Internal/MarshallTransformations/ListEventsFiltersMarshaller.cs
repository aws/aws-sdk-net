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
 * Do not modify this file. This file is generated from the devops-guru-2020-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DevOpsGuru.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.DevOpsGuru.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListEventsFilters Marshaller
    /// </summary>
    public class ListEventsFiltersMarshaller : IRequestMarshaller<ListEventsFilters, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ListEventsFilters requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDataSource())
            {
                context.Writer.WritePropertyName("DataSource");
                context.Writer.WriteStringValue(requestObject.DataSource);
            }

            if(requestObject.IsSetEventClass())
            {
                context.Writer.WritePropertyName("EventClass");
                context.Writer.WriteStringValue(requestObject.EventClass);
            }

            if(requestObject.IsSetEventSource())
            {
                context.Writer.WritePropertyName("EventSource");
                context.Writer.WriteStringValue(requestObject.EventSource);
            }

            if(requestObject.IsSetEventTimeRange())
            {
                context.Writer.WritePropertyName("EventTimeRange");
                context.Writer.WriteStartObject();

                var marshaller = EventTimeRangeMarshaller.Instance;
                marshaller.Marshall(requestObject.EventTimeRange, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetInsightId())
            {
                context.Writer.WritePropertyName("InsightId");
                context.Writer.WriteStringValue(requestObject.InsightId);
            }

            if(requestObject.IsSetResourceCollection())
            {
                context.Writer.WritePropertyName("ResourceCollection");
                context.Writer.WriteStartObject();

                var marshaller = ResourceCollectionMarshaller.Instance;
                marshaller.Marshall(requestObject.ResourceCollection, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ListEventsFiltersMarshaller Instance = new ListEventsFiltersMarshaller();

    }
}