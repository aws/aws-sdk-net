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
    /// Response Unmarshaller for RoutePedestrianTravelStep Object
    /// </summary>  
    public class RoutePedestrianTravelStepUnmarshaller : IUnmarshaller<RoutePedestrianTravelStep, XmlUnmarshallerContext>, IUnmarshaller<RoutePedestrianTravelStep, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        RoutePedestrianTravelStep IUnmarshaller<RoutePedestrianTravelStep, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public RoutePedestrianTravelStep Unmarshall(JsonUnmarshallerContext context)
        {
            RoutePedestrianTravelStep unmarshalledObject = new RoutePedestrianTravelStep();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("ContinueStepDetails", targetDepth))
                {
                    var unmarshaller = RouteContinueStepDetailsUnmarshaller.Instance;
                    unmarshalledObject.ContinueStepDetails = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CurrentRoad", targetDepth))
                {
                    var unmarshaller = RouteRoadUnmarshaller.Instance;
                    unmarshalledObject.CurrentRoad = unmarshaller.Unmarshall(context);
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
                if (context.TestExpression("ExitNumber", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<LocalizedString, LocalizedStringUnmarshaller>(LocalizedStringUnmarshaller.Instance);
                    unmarshalledObject.ExitNumber = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("GeometryOffset", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.GeometryOffset = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Instruction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Instruction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("KeepStepDetails", targetDepth))
                {
                    var unmarshaller = RouteKeepStepDetailsUnmarshaller.Instance;
                    unmarshalledObject.KeepStepDetails = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NextRoad", targetDepth))
                {
                    var unmarshaller = RouteRoadUnmarshaller.Instance;
                    unmarshalledObject.NextRoad = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RoundaboutEnterStepDetails", targetDepth))
                {
                    var unmarshaller = RouteRoundaboutEnterStepDetailsUnmarshaller.Instance;
                    unmarshalledObject.RoundaboutEnterStepDetails = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RoundaboutExitStepDetails", targetDepth))
                {
                    var unmarshaller = RouteRoundaboutExitStepDetailsUnmarshaller.Instance;
                    unmarshalledObject.RoundaboutExitStepDetails = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RoundaboutPassStepDetails", targetDepth))
                {
                    var unmarshaller = RouteRoundaboutPassStepDetailsUnmarshaller.Instance;
                    unmarshalledObject.RoundaboutPassStepDetails = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Signpost", targetDepth))
                {
                    var unmarshaller = RouteSignpostUnmarshaller.Instance;
                    unmarshalledObject.Signpost = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TurnStepDetails", targetDepth))
                {
                    var unmarshaller = RouteTurnStepDetailsUnmarshaller.Instance;
                    unmarshalledObject.TurnStepDetails = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Type", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Type = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static RoutePedestrianTravelStepUnmarshaller _instance = new RoutePedestrianTravelStepUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RoutePedestrianTravelStepUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}