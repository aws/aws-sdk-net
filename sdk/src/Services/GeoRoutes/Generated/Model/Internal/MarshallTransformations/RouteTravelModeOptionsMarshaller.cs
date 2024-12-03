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
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.GeoRoutes.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RouteTravelModeOptions Marshaller
    /// </summary>
    public class RouteTravelModeOptionsMarshaller : IRequestMarshaller<RouteTravelModeOptions, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(RouteTravelModeOptions requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCar())
            {
                context.Writer.WritePropertyName("Car");
                context.Writer.WriteObjectStart();

                var marshaller = RouteCarOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.Car, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetPedestrian())
            {
                context.Writer.WritePropertyName("Pedestrian");
                context.Writer.WriteObjectStart();

                var marshaller = RoutePedestrianOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.Pedestrian, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetScooter())
            {
                context.Writer.WritePropertyName("Scooter");
                context.Writer.WriteObjectStart();

                var marshaller = RouteScooterOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.Scooter, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetTruck())
            {
                context.Writer.WritePropertyName("Truck");
                context.Writer.WriteObjectStart();

                var marshaller = RouteTruckOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.Truck, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static RouteTravelModeOptionsMarshaller Instance = new RouteTravelModeOptionsMarshaller();

    }
}