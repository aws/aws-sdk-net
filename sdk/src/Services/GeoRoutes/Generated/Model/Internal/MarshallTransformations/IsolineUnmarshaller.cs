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
    /// Response Unmarshaller for Isoline Object
    /// </summary>  
    public class IsolineUnmarshaller : IUnmarshaller<Isoline, XmlUnmarshallerContext>, IUnmarshaller<Isoline, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        Isoline IUnmarshaller<Isoline, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public Isoline Unmarshall(JsonUnmarshallerContext context)
        {
            Isoline unmarshalledObject = new Isoline();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Connections", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<IsolineConnection, IsolineConnectionUnmarshaller>(IsolineConnectionUnmarshaller.Instance);
                    unmarshalledObject.Connections = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DistanceThreshold", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.DistanceThreshold = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Geometries", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<IsolineShapeGeometry, IsolineShapeGeometryUnmarshaller>(IsolineShapeGeometryUnmarshaller.Instance);
                    unmarshalledObject.Geometries = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TimeThreshold", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.TimeThreshold = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static IsolineUnmarshaller _instance = new IsolineUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static IsolineUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}