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
    /// Response Unmarshaller for RouteVehicleSpan Object
    /// </summary>  
    public class RouteVehicleSpanUnmarshaller : IUnmarshaller<RouteVehicleSpan, XmlUnmarshallerContext>, IUnmarshaller<RouteVehicleSpan, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        RouteVehicleSpan IUnmarshaller<RouteVehicleSpan, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public RouteVehicleSpan Unmarshall(JsonUnmarshallerContext context)
        {
            RouteVehicleSpan unmarshalledObject = new RouteVehicleSpan();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("BestCaseDuration", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.BestCaseDuration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CarAccess", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.CarAccess = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Country", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Country = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Distance", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.Distance = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Duration", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.Duration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DynamicSpeed", targetDepth))
                {
                    var unmarshaller = RouteSpanDynamicSpeedDetailsUnmarshaller.Instance;
                    unmarshalledObject.DynamicSpeed = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FunctionalClassification", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.FunctionalClassification = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Gate", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Gate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("GeometryOffset", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.GeometryOffset = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Incidents", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<int, IntUnmarshaller>(IntUnmarshaller.Instance);
                    unmarshalledObject.Incidents = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Names", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<LocalizedString, LocalizedStringUnmarshaller>(LocalizedStringUnmarshaller.Instance);
                    unmarshalledObject.Names = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Notices", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<int, IntUnmarshaller>(IntUnmarshaller.Instance);
                    unmarshalledObject.Notices = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RailwayCrossing", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RailwayCrossing = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Region", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Region = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RoadAttributes", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.RoadAttributes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RouteNumbers", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<RouteNumber, RouteNumberUnmarshaller>(RouteNumberUnmarshaller.Instance);
                    unmarshalledObject.RouteNumbers = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ScooterAccess", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.ScooterAccess = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SpeedLimit", targetDepth))
                {
                    var unmarshaller = RouteSpanSpeedLimitDetailsUnmarshaller.Instance;
                    unmarshalledObject.SpeedLimit = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TollSystems", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<int, IntUnmarshaller>(IntUnmarshaller.Instance);
                    unmarshalledObject.TollSystems = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TruckAccess", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.TruckAccess = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TruckRoadTypes", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<int, IntUnmarshaller>(IntUnmarshaller.Instance);
                    unmarshalledObject.TruckRoadTypes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TypicalDuration", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.TypicalDuration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Zones", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<int, IntUnmarshaller>(IntUnmarshaller.Instance);
                    unmarshalledObject.Zones = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static RouteVehicleSpanUnmarshaller _instance = new RouteVehicleSpanUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RouteVehicleSpanUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}