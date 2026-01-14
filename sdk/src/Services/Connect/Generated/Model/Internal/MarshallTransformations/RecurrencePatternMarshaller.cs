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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Connect.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Connect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RecurrencePattern Marshaller
    /// </summary>
    public class RecurrencePatternMarshaller : IRequestMarshaller<RecurrencePattern, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(RecurrencePattern requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetByMonth())
            {
                context.Writer.WritePropertyName("ByMonth");
                context.Writer.WriteStartArray();
                foreach(var requestObjectByMonthListValue in requestObject.ByMonth)
                {
                        context.Writer.WriteNumberValue(requestObjectByMonthListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetByMonthDay())
            {
                context.Writer.WritePropertyName("ByMonthDay");
                context.Writer.WriteStartArray();
                foreach(var requestObjectByMonthDayListValue in requestObject.ByMonthDay)
                {
                        context.Writer.WriteNumberValue(requestObjectByMonthDayListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetByWeekdayOccurrence())
            {
                context.Writer.WritePropertyName("ByWeekdayOccurrence");
                context.Writer.WriteStartArray();
                foreach(var requestObjectByWeekdayOccurrenceListValue in requestObject.ByWeekdayOccurrence)
                {
                        context.Writer.WriteNumberValue(requestObjectByWeekdayOccurrenceListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetFrequency())
            {
                context.Writer.WritePropertyName("Frequency");
                context.Writer.WriteStringValue(requestObject.Frequency);
            }

            if(requestObject.IsSetInterval())
            {
                context.Writer.WritePropertyName("Interval");
                context.Writer.WriteNumberValue(requestObject.Interval.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static RecurrencePatternMarshaller Instance = new RecurrencePatternMarshaller();

    }
}