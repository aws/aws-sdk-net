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
 * Do not modify this file. This file is generated from the geo-places-2020-11-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.GeoPlaces.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.GeoPlaces.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for OpeningHours Object
    /// </summary>  
    public class OpeningHoursUnmarshaller : IJsonUnmarshaller<OpeningHours, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public OpeningHours Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            OpeningHours unmarshalledObject = new OpeningHours();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("Categories", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<Category, CategoryUnmarshaller>(CategoryUnmarshaller.Instance);
                    unmarshalledObject.Categories = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Components", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<OpeningHoursComponents, OpeningHoursComponentsUnmarshaller>(OpeningHoursComponentsUnmarshaller.Instance);
                    unmarshalledObject.Components = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Display", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.Display = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("OpenNow", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.OpenNow = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static OpeningHoursUnmarshaller _instance = new OpeningHoursUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static OpeningHoursUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}