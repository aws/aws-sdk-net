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
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618
namespace Amazon.AWSHealth.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// EventFilter Marshaller
    /// </summary>
    public class EventFilterMarshaller : IRequestMarshaller<EventFilter, CborMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(EventFilter requestObject, CborMarshallerContext context)
        {
            if (requestObject == null)
                return;

            if (requestObject.IsSetActionabilities())
            {
                context.Writer.WriteTextString("actionabilities");
                context.Writer.WriteStartArray(requestObject.Actionabilities.Count);
                foreach(var requestObjectActionabilitiesListValue in requestObject.Actionabilities)
                {
                        context.Writer.WriteTextString(requestObjectActionabilitiesListValue);
                }
                context.Writer.WriteEndArray();
            }
            if (requestObject.IsSetAvailabilityZones())
            {
                context.Writer.WriteTextString("availabilityZones");
                context.Writer.WriteStartArray(requestObject.AvailabilityZones.Count);
                foreach(var requestObjectAvailabilityZonesListValue in requestObject.AvailabilityZones)
                {
                        context.Writer.WriteTextString(requestObjectAvailabilityZonesListValue);
                }
                context.Writer.WriteEndArray();
            }
            if (requestObject.IsSetEndTimes())
            {
                context.Writer.WriteTextString("endTimes");
                context.Writer.WriteStartArray(requestObject.EndTimes.Count);
                foreach(var requestObjectEndTimesListValue in requestObject.EndTimes)
                {
                    context.Writer.WriteStartMap(null);

                    var marshaller = DateTimeRangeMarshaller.Instance;
                    marshaller.Marshall(requestObjectEndTimesListValue, context);

                    context.Writer.WriteEndMap();
                }
                context.Writer.WriteEndArray();
            }
            if (requestObject.IsSetEntityArns())
            {
                context.Writer.WriteTextString("entityArns");
                context.Writer.WriteStartArray(requestObject.EntityArns.Count);
                foreach(var requestObjectEntityArnsListValue in requestObject.EntityArns)
                {
                        context.Writer.WriteTextString(requestObjectEntityArnsListValue);
                }
                context.Writer.WriteEndArray();
            }
            if (requestObject.IsSetEntityValues())
            {
                context.Writer.WriteTextString("entityValues");
                context.Writer.WriteStartArray(requestObject.EntityValues.Count);
                foreach(var requestObjectEntityValuesListValue in requestObject.EntityValues)
                {
                        context.Writer.WriteTextString(requestObjectEntityValuesListValue);
                }
                context.Writer.WriteEndArray();
            }
            if (requestObject.IsSetEventArns())
            {
                context.Writer.WriteTextString("eventArns");
                context.Writer.WriteStartArray(requestObject.EventArns.Count);
                foreach(var requestObjectEventArnsListValue in requestObject.EventArns)
                {
                        context.Writer.WriteTextString(requestObjectEventArnsListValue);
                }
                context.Writer.WriteEndArray();
            }
            if (requestObject.IsSetEventStatusCodes())
            {
                context.Writer.WriteTextString("eventStatusCodes");
                context.Writer.WriteStartArray(requestObject.EventStatusCodes.Count);
                foreach(var requestObjectEventStatusCodesListValue in requestObject.EventStatusCodes)
                {
                        context.Writer.WriteTextString(requestObjectEventStatusCodesListValue);
                }
                context.Writer.WriteEndArray();
            }
            if (requestObject.IsSetEventTypeCategories())
            {
                context.Writer.WriteTextString("eventTypeCategories");
                context.Writer.WriteStartArray(requestObject.EventTypeCategories.Count);
                foreach(var requestObjectEventTypeCategoriesListValue in requestObject.EventTypeCategories)
                {
                        context.Writer.WriteTextString(requestObjectEventTypeCategoriesListValue);
                }
                context.Writer.WriteEndArray();
            }
            if (requestObject.IsSetEventTypeCodes())
            {
                context.Writer.WriteTextString("eventTypeCodes");
                context.Writer.WriteStartArray(requestObject.EventTypeCodes.Count);
                foreach(var requestObjectEventTypeCodesListValue in requestObject.EventTypeCodes)
                {
                        context.Writer.WriteTextString(requestObjectEventTypeCodesListValue);
                }
                context.Writer.WriteEndArray();
            }
            if (requestObject.IsSetLastUpdatedTimes())
            {
                context.Writer.WriteTextString("lastUpdatedTimes");
                context.Writer.WriteStartArray(requestObject.LastUpdatedTimes.Count);
                foreach(var requestObjectLastUpdatedTimesListValue in requestObject.LastUpdatedTimes)
                {
                    context.Writer.WriteStartMap(null);

                    var marshaller = DateTimeRangeMarshaller.Instance;
                    marshaller.Marshall(requestObjectLastUpdatedTimesListValue, context);

                    context.Writer.WriteEndMap();
                }
                context.Writer.WriteEndArray();
            }
            if (requestObject.IsSetPersonas())
            {
                context.Writer.WriteTextString("personas");
                context.Writer.WriteStartArray(requestObject.Personas.Count);
                foreach(var requestObjectPersonasListValue in requestObject.Personas)
                {
                        context.Writer.WriteTextString(requestObjectPersonasListValue);
                }
                context.Writer.WriteEndArray();
            }
            if (requestObject.IsSetRegions())
            {
                context.Writer.WriteTextString("regions");
                context.Writer.WriteStartArray(requestObject.Regions.Count);
                foreach(var requestObjectRegionsListValue in requestObject.Regions)
                {
                        context.Writer.WriteTextString(requestObjectRegionsListValue);
                }
                context.Writer.WriteEndArray();
            }
            if (requestObject.IsSetServices())
            {
                context.Writer.WriteTextString("services");
                context.Writer.WriteStartArray(requestObject.Services.Count);
                foreach(var requestObjectServicesListValue in requestObject.Services)
                {
                        context.Writer.WriteTextString(requestObjectServicesListValue);
                }
                context.Writer.WriteEndArray();
            }
            if (requestObject.IsSetStartTimes())
            {
                context.Writer.WriteTextString("startTimes");
                context.Writer.WriteStartArray(requestObject.StartTimes.Count);
                foreach(var requestObjectStartTimesListValue in requestObject.StartTimes)
                {
                    context.Writer.WriteStartMap(null);

                    var marshaller = DateTimeRangeMarshaller.Instance;
                    marshaller.Marshall(requestObjectStartTimesListValue, context);

                    context.Writer.WriteEndMap();
                }
                context.Writer.WriteEndArray();
            }
            if (requestObject.IsSetTags())
            {
                context.Writer.WriteTextString("tags");
                context.Writer.WriteStartArray(requestObject.Tags.Count);
                foreach(var requestObjectTagsListValue in requestObject.Tags)
                {
                    context.Writer.WriteStartMap(null);
                    foreach (var requestObjectTagsListValueKvp in requestObjectTagsListValue)
                    {
                        context.Writer.WriteTextString(requestObjectTagsListValueKvp.Key);
                        var requestObjectTagsListValueValue = requestObjectTagsListValueKvp.Value;

                            context.Writer.WriteTextString(requestObjectTagsListValueValue);
                    }
                    context.Writer.WriteEndMap();
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