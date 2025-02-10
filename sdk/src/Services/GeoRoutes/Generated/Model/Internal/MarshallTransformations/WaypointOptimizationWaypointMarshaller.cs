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
 * Do not modify this file. This file is generated from the geo-routes-2020-11-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.GeoRoutes.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.GeoRoutes.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// WaypointOptimizationWaypoint Marshaller
    /// </summary>
    public class WaypointOptimizationWaypointMarshaller : IRequestMarshaller<WaypointOptimizationWaypoint, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(WaypointOptimizationWaypoint requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAccessHours())
            {
                context.Writer.WritePropertyName("AccessHours");
                context.Writer.WriteStartObject();

                var marshaller = WaypointOptimizationAccessHoursMarshaller.Instance;
                marshaller.Marshall(requestObject.AccessHours, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAppointmentTime())
            {
                context.Writer.WritePropertyName("AppointmentTime");
                context.Writer.WriteStringValue(requestObject.AppointmentTime);
            }

            if(requestObject.IsSetBefore())
            {
                context.Writer.WritePropertyName("Before");
                context.Writer.WriteStartArray();
                foreach(var requestObjectBeforeListValue in requestObject.Before)
                {
                        context.Writer.WriteNumberValue(requestObjectBeforeListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetHeading())
            {
                context.Writer.WritePropertyName("Heading");
                if(StringUtils.IsSpecialDoubleValue(requestObject.Heading.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.Heading.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.Heading.Value);
                }
            }

            if(requestObject.IsSetId())
            {
                context.Writer.WritePropertyName("Id");
                context.Writer.WriteStringValue(requestObject.Id);
            }

            if(requestObject.IsSetPosition())
            {
                context.Writer.WritePropertyName("Position");
                context.Writer.WriteStartArray();
                foreach(var requestObjectPositionListValue in requestObject.Position)
                {
                        context.Writer.WriteNumberValue(requestObjectPositionListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetServiceDuration())
            {
                context.Writer.WritePropertyName("ServiceDuration");
                context.Writer.WriteNumberValue(requestObject.ServiceDuration.Value);
            }

            if(requestObject.IsSetSideOfStreet())
            {
                context.Writer.WritePropertyName("SideOfStreet");
                context.Writer.WriteStartObject();

                var marshaller = WaypointOptimizationSideOfStreetOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.SideOfStreet, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static WaypointOptimizationWaypointMarshaller Instance = new WaypointOptimizationWaypointMarshaller();

    }
}