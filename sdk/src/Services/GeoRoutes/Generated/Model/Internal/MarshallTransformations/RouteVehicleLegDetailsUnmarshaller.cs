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
using System.Net;
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
    /// Response Unmarshaller for RouteVehicleLegDetails Object
    /// </summary>  
    public class RouteVehicleLegDetailsUnmarshaller : IUnmarshaller<RouteVehicleLegDetails, XmlUnmarshallerContext>, IUnmarshaller<RouteVehicleLegDetails, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        RouteVehicleLegDetails IUnmarshaller<RouteVehicleLegDetails, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public RouteVehicleLegDetails Unmarshall(JsonUnmarshallerContext context)
        {
            RouteVehicleLegDetails unmarshalledObject = new RouteVehicleLegDetails();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Arrival", targetDepth))
                {
                    var unmarshaller = RouteVehicleArrivalUnmarshaller.Instance;
                    unmarshalledObject.Arrival = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Departure", targetDepth))
                {
                    var unmarshaller = RouteVehicleDepartureUnmarshaller.Instance;
                    unmarshalledObject.Departure = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Incidents", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<RouteVehicleIncident, RouteVehicleIncidentUnmarshaller>(RouteVehicleIncidentUnmarshaller.Instance);
                    unmarshalledObject.Incidents = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Notices", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<RouteVehicleNotice, RouteVehicleNoticeUnmarshaller>(RouteVehicleNoticeUnmarshaller.Instance);
                    unmarshalledObject.Notices = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PassThroughWaypoints", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<RoutePassThroughWaypoint, RoutePassThroughWaypointUnmarshaller>(RoutePassThroughWaypointUnmarshaller.Instance);
                    unmarshalledObject.PassThroughWaypoints = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Spans", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<RouteVehicleSpan, RouteVehicleSpanUnmarshaller>(RouteVehicleSpanUnmarshaller.Instance);
                    unmarshalledObject.Spans = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Summary", targetDepth))
                {
                    var unmarshaller = RouteVehicleSummaryUnmarshaller.Instance;
                    unmarshalledObject.Summary = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Tolls", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<RouteToll, RouteTollUnmarshaller>(RouteTollUnmarshaller.Instance);
                    unmarshalledObject.Tolls = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TollSystems", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<RouteTollSystem, RouteTollSystemUnmarshaller>(RouteTollSystemUnmarshaller.Instance);
                    unmarshalledObject.TollSystems = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TravelSteps", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<RouteVehicleTravelStep, RouteVehicleTravelStepUnmarshaller>(RouteVehicleTravelStepUnmarshaller.Instance);
                    unmarshalledObject.TravelSteps = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TruckRoadTypes", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.TruckRoadTypes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Zones", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<RouteZone, RouteZoneUnmarshaller>(RouteZoneUnmarshaller.Instance);
                    unmarshalledObject.Zones = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static RouteVehicleLegDetailsUnmarshaller _instance = new RouteVehicleLegDetailsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RouteVehicleLegDetailsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}