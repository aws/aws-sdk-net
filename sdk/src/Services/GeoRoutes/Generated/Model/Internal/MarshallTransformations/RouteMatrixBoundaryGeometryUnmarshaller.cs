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
    /// Response Unmarshaller for RouteMatrixBoundaryGeometry Object
    /// </summary>  
    public class RouteMatrixBoundaryGeometryUnmarshaller : IJsonUnmarshaller<RouteMatrixBoundaryGeometry, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public RouteMatrixBoundaryGeometry Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            RouteMatrixBoundaryGeometry unmarshalledObject = new RouteMatrixBoundaryGeometry();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("AutoCircle", targetDepth))
                {
                    var unmarshaller = RouteMatrixAutoCircleUnmarshaller.Instance;
                    unmarshalledObject.AutoCircle = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("BoundingBox", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<double, DoubleUnmarshaller>(DoubleUnmarshaller.Instance);
                    unmarshalledObject.BoundingBox = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Circle", targetDepth))
                {
                    var unmarshaller = CircleUnmarshaller.Instance;
                    unmarshalledObject.Circle = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Polygon", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<List<List<double>>, JsonListUnmarshaller<List<double>,JsonListUnmarshaller<double,DoubleUnmarshaller>>>(new JsonListUnmarshaller<List<double>, JsonListUnmarshaller<double,DoubleUnmarshaller>>(new JsonListUnmarshaller<double, DoubleUnmarshaller>(DoubleUnmarshaller.Instance)));
                    unmarshalledObject.Polygon = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static RouteMatrixBoundaryGeometryUnmarshaller _instance = new RouteMatrixBoundaryGeometryUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RouteMatrixBoundaryGeometryUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}