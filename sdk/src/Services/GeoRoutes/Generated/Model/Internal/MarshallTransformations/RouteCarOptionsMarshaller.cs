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
    /// RouteCarOptions Marshaller
    /// </summary>
    public class RouteCarOptionsMarshaller : IRequestMarshaller<RouteCarOptions, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(RouteCarOptions requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetEngineType())
            {
                context.Writer.WritePropertyName("EngineType");
                context.Writer.Write(requestObject.EngineType);
            }

            if(requestObject.IsSetLicensePlate())
            {
                context.Writer.WritePropertyName("LicensePlate");
                context.Writer.WriteObjectStart();

                var marshaller = RouteVehicleLicensePlateMarshaller.Instance;
                marshaller.Marshall(requestObject.LicensePlate, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetMaxSpeed())
            {
                context.Writer.WritePropertyName("MaxSpeed");
                if(StringUtils.IsSpecialDoubleValue(requestObject.MaxSpeed))
                {
                    context.Writer.Write(StringUtils.FromSpecialDoubleValue(requestObject.MaxSpeed));
                }
                else
                {
                    context.Writer.Write(requestObject.MaxSpeed);
                }
            }

            if(requestObject.IsSetOccupancy())
            {
                context.Writer.WritePropertyName("Occupancy");
                context.Writer.Write(requestObject.Occupancy);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static RouteCarOptionsMarshaller Instance = new RouteCarOptionsMarshaller();

    }
}