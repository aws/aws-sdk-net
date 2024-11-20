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
    /// RouteAvoidanceOptions Marshaller
    /// </summary>
    public class RouteAvoidanceOptionsMarshaller : IRequestMarshaller<RouteAvoidanceOptions, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(RouteAvoidanceOptions requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAreas())
            {
                context.Writer.WritePropertyName("Areas");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectAreasListValue in requestObject.Areas)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = RouteAvoidanceAreaMarshaller.Instance;
                    marshaller.Marshall(requestObjectAreasListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetCarShuttleTrains())
            {
                context.Writer.WritePropertyName("CarShuttleTrains");
                context.Writer.Write(requestObject.CarShuttleTrains);
            }

            if(requestObject.IsSetControlledAccessHighways())
            {
                context.Writer.WritePropertyName("ControlledAccessHighways");
                context.Writer.Write(requestObject.ControlledAccessHighways);
            }

            if(requestObject.IsSetDirtRoads())
            {
                context.Writer.WritePropertyName("DirtRoads");
                context.Writer.Write(requestObject.DirtRoads);
            }

            if(requestObject.IsSetFerries())
            {
                context.Writer.WritePropertyName("Ferries");
                context.Writer.Write(requestObject.Ferries);
            }

            if(requestObject.IsSetSeasonalClosure())
            {
                context.Writer.WritePropertyName("SeasonalClosure");
                context.Writer.Write(requestObject.SeasonalClosure);
            }

            if(requestObject.IsSetTollRoads())
            {
                context.Writer.WritePropertyName("TollRoads");
                context.Writer.Write(requestObject.TollRoads);
            }

            if(requestObject.IsSetTollTransponders())
            {
                context.Writer.WritePropertyName("TollTransponders");
                context.Writer.Write(requestObject.TollTransponders);
            }

            if(requestObject.IsSetTruckRoadTypes())
            {
                context.Writer.WritePropertyName("TruckRoadTypes");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectTruckRoadTypesListValue in requestObject.TruckRoadTypes)
                {
                        context.Writer.Write(requestObjectTruckRoadTypesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetTunnels())
            {
                context.Writer.WritePropertyName("Tunnels");
                context.Writer.Write(requestObject.Tunnels);
            }

            if(requestObject.IsSetUTurns())
            {
                context.Writer.WritePropertyName("UTurns");
                context.Writer.Write(requestObject.UTurns);
            }

            if(requestObject.IsSetZoneCategories())
            {
                context.Writer.WritePropertyName("ZoneCategories");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectZoneCategoriesListValue in requestObject.ZoneCategories)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = RouteAvoidanceZoneCategoryMarshaller.Instance;
                    marshaller.Marshall(requestObjectZoneCategoriesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static RouteAvoidanceOptionsMarshaller Instance = new RouteAvoidanceOptionsMarshaller();

    }
}