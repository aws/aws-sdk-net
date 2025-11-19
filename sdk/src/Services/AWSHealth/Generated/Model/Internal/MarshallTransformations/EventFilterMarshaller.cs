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
using ThirdParty.Json.LitJson;

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
            if(requestObject.IsSetActionabilities())
            {
                context.Writer.WritePropertyName("actionabilities");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectActionabilitiesListValue in requestObject.Actionabilities)
                {
                        context.Writer.Write(requestObjectActionabilitiesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetAvailabilityZones())
            {
                context.Writer.WritePropertyName("availabilityZones");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectAvailabilityZonesListValue in requestObject.AvailabilityZones)
                {
                        context.Writer.Write(requestObjectAvailabilityZonesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetEndTimes())
            {
                context.Writer.WritePropertyName("endTimes");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectEndTimesListValue in requestObject.EndTimes)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = DateTimeRangeMarshaller.Instance;
                    marshaller.Marshall(requestObjectEndTimesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetEntityArns())
            {
                context.Writer.WritePropertyName("entityArns");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectEntityArnsListValue in requestObject.EntityArns)
                {
                        context.Writer.Write(requestObjectEntityArnsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetEntityValues())
            {
                context.Writer.WritePropertyName("entityValues");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectEntityValuesListValue in requestObject.EntityValues)
                {
                        context.Writer.Write(requestObjectEntityValuesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetEventArns())
            {
                context.Writer.WritePropertyName("eventArns");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectEventArnsListValue in requestObject.EventArns)
                {
                        context.Writer.Write(requestObjectEventArnsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetEventStatusCodes())
            {
                context.Writer.WritePropertyName("eventStatusCodes");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectEventStatusCodesListValue in requestObject.EventStatusCodes)
                {
                        context.Writer.Write(requestObjectEventStatusCodesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetEventTypeCategories())
            {
                context.Writer.WritePropertyName("eventTypeCategories");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectEventTypeCategoriesListValue in requestObject.EventTypeCategories)
                {
                        context.Writer.Write(requestObjectEventTypeCategoriesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetEventTypeCodes())
            {
                context.Writer.WritePropertyName("eventTypeCodes");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectEventTypeCodesListValue in requestObject.EventTypeCodes)
                {
                        context.Writer.Write(requestObjectEventTypeCodesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetLastUpdatedTimes())
            {
                context.Writer.WritePropertyName("lastUpdatedTimes");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectLastUpdatedTimesListValue in requestObject.LastUpdatedTimes)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = DateTimeRangeMarshaller.Instance;
                    marshaller.Marshall(requestObjectLastUpdatedTimesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetPersonas())
            {
                context.Writer.WritePropertyName("personas");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectPersonasListValue in requestObject.Personas)
                {
                        context.Writer.Write(requestObjectPersonasListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetRegions())
            {
                context.Writer.WritePropertyName("regions");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectRegionsListValue in requestObject.Regions)
                {
                        context.Writer.Write(requestObjectRegionsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetServices())
            {
                context.Writer.WritePropertyName("services");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectServicesListValue in requestObject.Services)
                {
                        context.Writer.Write(requestObjectServicesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetStartTimes())
            {
                context.Writer.WritePropertyName("startTimes");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectStartTimesListValue in requestObject.StartTimes)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = DateTimeRangeMarshaller.Instance;
                    marshaller.Marshall(requestObjectStartTimesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetTags())
            {
                context.Writer.WritePropertyName("tags");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectTagsListValue in requestObject.Tags)
                {
                    context.Writer.WriteObjectStart();
                    foreach (var requestObjectTagsListValueKvp in requestObjectTagsListValue)
                    {
                        context.Writer.WritePropertyName(requestObjectTagsListValueKvp.Key);
                        var requestObjectTagsListValueValue = requestObjectTagsListValueKvp.Value;

                            context.Writer.Write(requestObjectTagsListValueValue);
                    }
                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static EventFilterMarshaller Instance = new EventFilterMarshaller();

    }
}