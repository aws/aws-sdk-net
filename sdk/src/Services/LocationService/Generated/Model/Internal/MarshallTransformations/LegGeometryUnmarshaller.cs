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
 * Do not modify this file. This file is generated from the location-2020-11-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.LocationService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.LocationService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for LegGeometry Object
    /// </summary>  
    public class LegGeometryUnmarshaller : IUnmarshaller<LegGeometry, XmlUnmarshallerContext>, IUnmarshaller<LegGeometry, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        LegGeometry IUnmarshaller<LegGeometry, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public LegGeometry Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            LegGeometry unmarshalledObject = new LegGeometry();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("LineString", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<List<double>, ListUnmarshaller<double, DoubleUnmarshaller>>(new ListUnmarshaller<double, DoubleUnmarshaller>(DoubleUnmarshaller.Instance));
                    unmarshalledObject.LineString = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static LegGeometryUnmarshaller _instance = new LegGeometryUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static LegGeometryUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}