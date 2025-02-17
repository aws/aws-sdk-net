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
    /// Response Unmarshaller for RouteViolatedConstraints Object
    /// </summary>  
    public class RouteViolatedConstraintsUnmarshaller : IUnmarshaller<RouteViolatedConstraints, XmlUnmarshallerContext>, IUnmarshaller<RouteViolatedConstraints, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        RouteViolatedConstraints IUnmarshaller<RouteViolatedConstraints, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public RouteViolatedConstraints Unmarshall(JsonUnmarshallerContext context)
        {
            RouteViolatedConstraints unmarshalledObject = new RouteViolatedConstraints();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AllHazardsRestricted", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.AllHazardsRestricted = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AxleCount", targetDepth))
                {
                    var unmarshaller = RouteNoticeDetailRangeUnmarshaller.Instance;
                    unmarshalledObject.AxleCount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("HazardousCargos", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.HazardousCargos = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MaxHeight", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.MaxHeight = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MaxKpraLength", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.MaxKpraLength = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MaxLength", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.MaxLength = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MaxPayloadCapacity", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.MaxPayloadCapacity = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MaxWeight", targetDepth))
                {
                    var unmarshaller = RouteWeightConstraintUnmarshaller.Instance;
                    unmarshalledObject.MaxWeight = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MaxWeightPerAxle", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.MaxWeightPerAxle = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MaxWeightPerAxleGroup", targetDepth))
                {
                    var unmarshaller = WeightPerAxleGroupUnmarshaller.Instance;
                    unmarshalledObject.MaxWeightPerAxleGroup = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MaxWidth", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.MaxWidth = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Occupancy", targetDepth))
                {
                    var unmarshaller = RouteNoticeDetailRangeUnmarshaller.Instance;
                    unmarshalledObject.Occupancy = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RestrictedTimes", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RestrictedTimes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TimeDependent", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.TimeDependent = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TrailerCount", targetDepth))
                {
                    var unmarshaller = RouteNoticeDetailRangeUnmarshaller.Instance;
                    unmarshalledObject.TrailerCount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TravelMode", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.TravelMode = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TruckRoadType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TruckRoadType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TruckType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TruckType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TunnelRestrictionCode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TunnelRestrictionCode = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static RouteViolatedConstraintsUnmarshaller _instance = new RouteViolatedConstraintsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RouteViolatedConstraintsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}