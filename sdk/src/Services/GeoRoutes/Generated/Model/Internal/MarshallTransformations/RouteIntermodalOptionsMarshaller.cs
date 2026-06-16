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
    /// RouteIntermodalOptions Marshaller
    /// </summary>
    public class RouteIntermodalOptionsMarshaller : IRequestMarshaller<RouteIntermodalOptions, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(RouteIntermodalOptions requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAccessibilityAttributes())
            {
                context.Writer.WritePropertyName("AccessibilityAttributes");
                context.Writer.WriteStartArray();
                foreach(var requestObjectAccessibilityAttributesListValue in requestObject.AccessibilityAttributes)
                {
                        context.Writer.WriteStringValue(requestObjectAccessibilityAttributesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetMaxTransfers())
            {
                context.Writer.WritePropertyName("MaxTransfers");
                context.Writer.WriteNumberValue(requestObject.MaxTransfers.Value);
            }

            if(requestObject.IsSetPedestrian())
            {
                context.Writer.WritePropertyName("Pedestrian");
                context.Writer.WriteStartObject();

                var marshaller = RouteIntermodalPedestrianOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.Pedestrian, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRental())
            {
                context.Writer.WritePropertyName("Rental");
                context.Writer.WriteStartObject();

                var marshaller = RouteIntermodalRentalOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.Rental, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTaxi())
            {
                context.Writer.WritePropertyName("Taxi");
                context.Writer.WriteStartObject();

                var marshaller = RouteIntermodalTaxiOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.Taxi, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTransit())
            {
                context.Writer.WritePropertyName("Transit");
                context.Writer.WriteStartObject();

                var marshaller = RouteIntermodalTransitOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.Transit, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetVehicle())
            {
                context.Writer.WritePropertyName("Vehicle");
                context.Writer.WriteStartObject();

                var marshaller = RouteIntermodalVehicleOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.Vehicle, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static RouteIntermodalOptionsMarshaller Instance = new RouteIntermodalOptionsMarshaller();

    }
}