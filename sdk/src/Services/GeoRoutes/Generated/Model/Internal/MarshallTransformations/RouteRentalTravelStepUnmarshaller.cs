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
    /// Response Unmarshaller for RouteRentalTravelStep Object
    /// </summary>  
    public class RouteRentalTravelStepUnmarshaller : IJsonUnmarshaller<RouteRentalTravelStep, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public RouteRentalTravelStep Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            RouteRentalTravelStep unmarshalledObject = new RouteRentalTravelStep();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("ContinueStepDetails", targetDepth, ref reader))
                {
                    var unmarshaller = RouteContinueStepDetailsUnmarshaller.Instance;
                    unmarshalledObject.ContinueStepDetails = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Distance", targetDepth, ref reader))
                {
                    var unmarshaller = NullableLongUnmarshaller.Instance;
                    unmarshalledObject.Distance = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Duration", targetDepth, ref reader))
                {
                    var unmarshaller = NullableLongUnmarshaller.Instance;
                    unmarshalledObject.Duration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ExitStepDetails", targetDepth, ref reader))
                {
                    var unmarshaller = RouteExitStepDetailsUnmarshaller.Instance;
                    unmarshalledObject.ExitStepDetails = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("GeometryOffset", targetDepth, ref reader))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.GeometryOffset = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Instruction", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Instruction = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("KeepStepDetails", targetDepth, ref reader))
                {
                    var unmarshaller = RouteKeepStepDetailsUnmarshaller.Instance;
                    unmarshalledObject.KeepStepDetails = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("RampStepDetails", targetDepth, ref reader))
                {
                    var unmarshaller = RouteRampStepDetailsUnmarshaller.Instance;
                    unmarshalledObject.RampStepDetails = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("RoundaboutEnterStepDetails", targetDepth, ref reader))
                {
                    var unmarshaller = RouteRoundaboutEnterStepDetailsUnmarshaller.Instance;
                    unmarshalledObject.RoundaboutEnterStepDetails = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("RoundaboutExitStepDetails", targetDepth, ref reader))
                {
                    var unmarshaller = RouteRoundaboutExitStepDetailsUnmarshaller.Instance;
                    unmarshalledObject.RoundaboutExitStepDetails = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("RoundaboutPassStepDetails", targetDepth, ref reader))
                {
                    var unmarshaller = RouteRoundaboutPassStepDetailsUnmarshaller.Instance;
                    unmarshalledObject.RoundaboutPassStepDetails = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("TurnStepDetails", targetDepth, ref reader))
                {
                    var unmarshaller = RouteTurnStepDetailsUnmarshaller.Instance;
                    unmarshalledObject.TurnStepDetails = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Type", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Type = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("UTurnStepDetails", targetDepth, ref reader))
                {
                    var unmarshaller = RouteUTurnStepDetailsUnmarshaller.Instance;
                    unmarshalledObject.UTurnStepDetails = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static RouteRentalTravelStepUnmarshaller _instance = new RouteRentalTravelStepUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RouteRentalTravelStepUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}