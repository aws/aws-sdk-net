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
    /// Response Unmarshaller for WaypointOptimizationTimeBreakdown Object
    /// </summary>  
    public class WaypointOptimizationTimeBreakdownUnmarshaller : IUnmarshaller<WaypointOptimizationTimeBreakdown, XmlUnmarshallerContext>, IUnmarshaller<WaypointOptimizationTimeBreakdown, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        WaypointOptimizationTimeBreakdown IUnmarshaller<WaypointOptimizationTimeBreakdown, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public WaypointOptimizationTimeBreakdown Unmarshall(JsonUnmarshallerContext context)
        {
            WaypointOptimizationTimeBreakdown unmarshalledObject = new WaypointOptimizationTimeBreakdown();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("RestDuration", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.RestDuration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ServiceDuration", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.ServiceDuration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TravelDuration", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.TravelDuration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("WaitDuration", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.WaitDuration = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static WaypointOptimizationTimeBreakdownUnmarshaller _instance = new WaypointOptimizationTimeBreakdownUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static WaypointOptimizationTimeBreakdownUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}