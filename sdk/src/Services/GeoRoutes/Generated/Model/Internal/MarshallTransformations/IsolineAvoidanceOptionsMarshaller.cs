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
    /// IsolineAvoidanceOptions Marshaller
    /// </summary>
    public class IsolineAvoidanceOptionsMarshaller : IRequestMarshaller<IsolineAvoidanceOptions, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(IsolineAvoidanceOptions requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAreas())
            {
                context.Writer.WritePropertyName("Areas");
                context.Writer.WriteStartArray();
                foreach(var requestObjectAreasListValue in requestObject.Areas)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = IsolineAvoidanceAreaMarshaller.Instance;
                    marshaller.Marshall(requestObjectAreasListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetCarShuttleTrains())
            {
                context.Writer.WritePropertyName("CarShuttleTrains");
                context.Writer.WriteBooleanValue(requestObject.CarShuttleTrains.Value);
            }

            if(requestObject.IsSetControlledAccessHighways())
            {
                context.Writer.WritePropertyName("ControlledAccessHighways");
                context.Writer.WriteBooleanValue(requestObject.ControlledAccessHighways.Value);
            }

            if(requestObject.IsSetDirtRoads())
            {
                context.Writer.WritePropertyName("DirtRoads");
                context.Writer.WriteBooleanValue(requestObject.DirtRoads.Value);
            }

            if(requestObject.IsSetFerries())
            {
                context.Writer.WritePropertyName("Ferries");
                context.Writer.WriteBooleanValue(requestObject.Ferries.Value);
            }

            if(requestObject.IsSetSeasonalClosure())
            {
                context.Writer.WritePropertyName("SeasonalClosure");
                context.Writer.WriteBooleanValue(requestObject.SeasonalClosure.Value);
            }

            if(requestObject.IsSetTollRoads())
            {
                context.Writer.WritePropertyName("TollRoads");
                context.Writer.WriteBooleanValue(requestObject.TollRoads.Value);
            }

            if(requestObject.IsSetTollTransponders())
            {
                context.Writer.WritePropertyName("TollTransponders");
                context.Writer.WriteBooleanValue(requestObject.TollTransponders.Value);
            }

            if(requestObject.IsSetTruckRoadTypes())
            {
                context.Writer.WritePropertyName("TruckRoadTypes");
                context.Writer.WriteStartArray();
                foreach(var requestObjectTruckRoadTypesListValue in requestObject.TruckRoadTypes)
                {
                        context.Writer.WriteStringValue(requestObjectTruckRoadTypesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetTunnels())
            {
                context.Writer.WritePropertyName("Tunnels");
                context.Writer.WriteBooleanValue(requestObject.Tunnels.Value);
            }

            if(requestObject.IsSetUTurns())
            {
                context.Writer.WritePropertyName("UTurns");
                context.Writer.WriteBooleanValue(requestObject.UTurns.Value);
            }

            if(requestObject.IsSetZoneCategories())
            {
                context.Writer.WritePropertyName("ZoneCategories");
                context.Writer.WriteStartArray();
                foreach(var requestObjectZoneCategoriesListValue in requestObject.ZoneCategories)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = IsolineAvoidanceZoneCategoryMarshaller.Instance;
                    marshaller.Marshall(requestObjectZoneCategoriesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static IsolineAvoidanceOptionsMarshaller Instance = new IsolineAvoidanceOptionsMarshaller();

    }
}