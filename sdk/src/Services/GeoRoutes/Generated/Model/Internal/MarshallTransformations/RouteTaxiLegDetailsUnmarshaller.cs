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
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.GeoRoutes.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for RouteTaxiLegDetails Object
    /// </summary>  
    public class RouteTaxiLegDetailsUnmarshaller : IJsonUnmarshaller<RouteTaxiLegDetails, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public RouteTaxiLegDetails Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            RouteTaxiLegDetails unmarshalledObject = new RouteTaxiLegDetails();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("AfterTravelSteps", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<RouteTaxiAfterTravelStep, RouteTaxiAfterTravelStepUnmarshaller>(RouteTaxiAfterTravelStepUnmarshaller.Instance);
                    unmarshalledObject.AfterTravelSteps = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Agency", targetDepth, ref reader))
                {
                    var unmarshaller = RouteTaxiAgencyUnmarshaller.Instance;
                    unmarshalledObject.Agency = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Arrival", targetDepth, ref reader))
                {
                    var unmarshaller = RouteTaxiArrivalUnmarshaller.Instance;
                    unmarshalledObject.Arrival = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Attributions", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<RouteAttribution, RouteAttributionUnmarshaller>(RouteAttributionUnmarshaller.Instance);
                    unmarshalledObject.Attributions = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("BeforeTravelSteps", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<RouteTaxiBeforeTravelStep, RouteTaxiBeforeTravelStepUnmarshaller>(RouteTaxiBeforeTravelStepUnmarshaller.Instance);
                    unmarshalledObject.BeforeTravelSteps = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("BookingWebLinks", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<RouteWebLink, RouteWebLinkUnmarshaller>(RouteWebLinkUnmarshaller.Instance);
                    unmarshalledObject.BookingWebLinks = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Departure", targetDepth, ref reader))
                {
                    var unmarshaller = RouteTaxiDepartureUnmarshaller.Instance;
                    unmarshalledObject.Departure = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Notices", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<RouteTaxiNotice, RouteTaxiNoticeUnmarshaller>(RouteTaxiNoticeUnmarshaller.Instance);
                    unmarshalledObject.Notices = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Summary", targetDepth, ref reader))
                {
                    var unmarshaller = RouteTaxiSummaryUnmarshaller.Instance;
                    unmarshalledObject.Summary = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Transport", targetDepth, ref reader))
                {
                    var unmarshaller = RouteTaxiTransportModeDetailsUnmarshaller.Instance;
                    unmarshalledObject.Transport = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("TravelSteps", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<RouteTaxiTravelStep, RouteTaxiTravelStepUnmarshaller>(RouteTaxiTravelStepUnmarshaller.Instance);
                    unmarshalledObject.TravelSteps = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static RouteTaxiLegDetailsUnmarshaller _instance = new RouteTaxiLegDetailsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RouteTaxiLegDetailsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}