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
    /// Response Unmarshaller for RouteRoundaboutExitStepDetails Object
    /// </summary>  
    public class RouteRoundaboutExitStepDetailsUnmarshaller : IUnmarshaller<RouteRoundaboutExitStepDetails, XmlUnmarshallerContext>, IUnmarshaller<RouteRoundaboutExitStepDetails, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        RouteRoundaboutExitStepDetails IUnmarshaller<RouteRoundaboutExitStepDetails, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public RouteRoundaboutExitStepDetails Unmarshall(JsonUnmarshallerContext context)
        {
            RouteRoundaboutExitStepDetails unmarshalledObject = new RouteRoundaboutExitStepDetails();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Intersection", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<LocalizedString, LocalizedStringUnmarshaller>(LocalizedStringUnmarshaller.Instance);
                    unmarshalledObject.Intersection = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RelativeExit", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.RelativeExit = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RoundaboutAngle", targetDepth))
                {
                    var unmarshaller = DoubleUnmarshaller.Instance;
                    unmarshalledObject.RoundaboutAngle = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SteeringDirection", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SteeringDirection = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static RouteRoundaboutExitStepDetailsUnmarshaller _instance = new RouteRoundaboutExitStepDetailsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RouteRoundaboutExitStepDetailsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}