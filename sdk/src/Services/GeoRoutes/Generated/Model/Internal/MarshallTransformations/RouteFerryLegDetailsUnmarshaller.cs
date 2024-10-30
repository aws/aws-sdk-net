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
    /// Response Unmarshaller for RouteFerryLegDetails Object
    /// </summary>  
    public class RouteFerryLegDetailsUnmarshaller : IUnmarshaller<RouteFerryLegDetails, XmlUnmarshallerContext>, IUnmarshaller<RouteFerryLegDetails, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        RouteFerryLegDetails IUnmarshaller<RouteFerryLegDetails, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public RouteFerryLegDetails Unmarshall(JsonUnmarshallerContext context)
        {
            RouteFerryLegDetails unmarshalledObject = new RouteFerryLegDetails();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AfterTravelSteps", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<RouteFerryAfterTravelStep, RouteFerryAfterTravelStepUnmarshaller>(RouteFerryAfterTravelStepUnmarshaller.Instance);
                    unmarshalledObject.AfterTravelSteps = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Arrival", targetDepth))
                {
                    var unmarshaller = RouteFerryArrivalUnmarshaller.Instance;
                    unmarshalledObject.Arrival = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("BeforeTravelSteps", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<RouteFerryBeforeTravelStep, RouteFerryBeforeTravelStepUnmarshaller>(RouteFerryBeforeTravelStepUnmarshaller.Instance);
                    unmarshalledObject.BeforeTravelSteps = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Departure", targetDepth))
                {
                    var unmarshaller = RouteFerryDepartureUnmarshaller.Instance;
                    unmarshalledObject.Departure = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Notices", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<RouteFerryNotice, RouteFerryNoticeUnmarshaller>(RouteFerryNoticeUnmarshaller.Instance);
                    unmarshalledObject.Notices = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PassThroughWaypoints", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<RoutePassThroughWaypoint, RoutePassThroughWaypointUnmarshaller>(RoutePassThroughWaypointUnmarshaller.Instance);
                    unmarshalledObject.PassThroughWaypoints = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RouteName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RouteName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Spans", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<RouteFerrySpan, RouteFerrySpanUnmarshaller>(RouteFerrySpanUnmarshaller.Instance);
                    unmarshalledObject.Spans = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Summary", targetDepth))
                {
                    var unmarshaller = RouteFerrySummaryUnmarshaller.Instance;
                    unmarshalledObject.Summary = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TravelSteps", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<RouteFerryTravelStep, RouteFerryTravelStepUnmarshaller>(RouteFerryTravelStepUnmarshaller.Instance);
                    unmarshalledObject.TravelSteps = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static RouteFerryLegDetailsUnmarshaller _instance = new RouteFerryLegDetailsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RouteFerryLegDetailsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}