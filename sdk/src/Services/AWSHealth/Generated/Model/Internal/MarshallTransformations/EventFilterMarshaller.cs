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
 * Do not modify this file. This file is generated from the health-2016-08-04.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AWSHealth.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.AWSHealth.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// EventFilter Marshaller
    /// </summary>
    public class EventFilterMarshaller : IRequestMarshaller<EventFilter, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(EventFilter requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAvailabilityZones())
            {
                context.Writer.WritePropertyName("availabilityZones");
                context.Writer.WriteStartArray();
                foreach(var requestObjectAvailabilityZonesListValue in requestObject.AvailabilityZones)
                {
                        context.Writer.WriteStringValue(requestObjectAvailabilityZonesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetEndTimes())
            {
                context.Writer.WritePropertyName("endTimes");
                context.Writer.WriteStartArray();
                foreach(var requestObjectEndTimesListValue in requestObject.EndTimes)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = DateTimeRangeMarshaller.Instance;
                    marshaller.Marshall(requestObjectEndTimesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetEntityArns())
            {
                context.Writer.WritePropertyName("entityArns");
                context.Writer.WriteStartArray();
                foreach(var requestObjectEntityArnsListValue in requestObject.EntityArns)
                {
                        context.Writer.WriteStringValue(requestObjectEntityArnsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetEntityValues())
            {
                context.Writer.WritePropertyName("entityValues");
                context.Writer.WriteStartArray();
                foreach(var requestObjectEntityValuesListValue in requestObject.EntityValues)
                {
                        context.Writer.WriteStringValue(requestObjectEntityValuesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetEventArns())
            {
                context.Writer.WritePropertyName("eventArns");
                context.Writer.WriteStartArray();
                foreach(var requestObjectEventArnsListValue in requestObject.EventArns)
                {
                        context.Writer.WriteStringValue(requestObjectEventArnsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetEventStatusCodes())
            {
                context.Writer.WritePropertyName("eventStatusCodes");
                context.Writer.WriteStartArray();
                foreach(var requestObjectEventStatusCodesListValue in requestObject.EventStatusCodes)
                {
                        context.Writer.WriteStringValue(requestObjectEventStatusCodesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetEventTypeCategories())
            {
                context.Writer.WritePropertyName("eventTypeCategories");
                context.Writer.WriteStartArray();
                foreach(var requestObjectEventTypeCategoriesListValue in requestObject.EventTypeCategories)
                {
                        context.Writer.WriteStringValue(requestObjectEventTypeCategoriesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetEventTypeCodes())
            {
                context.Writer.WritePropertyName("eventTypeCodes");
                context.Writer.WriteStartArray();
                foreach(var requestObjectEventTypeCodesListValue in requestObject.EventTypeCodes)
                {
                        context.Writer.WriteStringValue(requestObjectEventTypeCodesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetLastUpdatedTimes())
            {
                context.Writer.WritePropertyName("lastUpdatedTimes");
                context.Writer.WriteStartArray();
                foreach(var requestObjectLastUpdatedTimesListValue in requestObject.LastUpdatedTimes)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = DateTimeRangeMarshaller.Instance;
                    marshaller.Marshall(requestObjectLastUpdatedTimesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetRegions())
            {
                context.Writer.WritePropertyName("regions");
                context.Writer.WriteStartArray();
                foreach(var requestObjectRegionsListValue in requestObject.Regions)
                {
                        context.Writer.WriteStringValue(requestObjectRegionsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetServices())
            {
                context.Writer.WritePropertyName("services");
                context.Writer.WriteStartArray();
                foreach(var requestObjectServicesListValue in requestObject.Services)
                {
                        context.Writer.WriteStringValue(requestObjectServicesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetStartTimes())
            {
                context.Writer.WritePropertyName("startTimes");
                context.Writer.WriteStartArray();
                foreach(var requestObjectStartTimesListValue in requestObject.StartTimes)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = DateTimeRangeMarshaller.Instance;
                    marshaller.Marshall(requestObjectStartTimesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetTags())
            {
                context.Writer.WritePropertyName("tags");
                context.Writer.WriteStartArray();
                foreach(var requestObjectTagsListValue in requestObject.Tags)
                {
                    context.Writer.WriteStartObject();
                    foreach (var requestObjectTagsListValueKvp in requestObjectTagsListValue)
                    {
                        context.Writer.WritePropertyName(requestObjectTagsListValueKvp.Key);
                        var requestObjectTagsListValueValue = requestObjectTagsListValueKvp.Value;

                            context.Writer.WriteStringValue(requestObjectTagsListValueValue);
                    }
                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static EventFilterMarshaller Instance = new EventFilterMarshaller();

    }
}