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
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaConvert.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.MediaConvert.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for NoiseReducer Object
    /// </summary>  
    public class NoiseReducerUnmarshaller : IUnmarshaller<NoiseReducer, XmlUnmarshallerContext>, IUnmarshaller<NoiseReducer, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        NoiseReducer IUnmarshaller<NoiseReducer, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public NoiseReducer Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            NoiseReducer unmarshalledObject = new NoiseReducer();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("filter", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Filter = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("filterSettings", targetDepth))
                {
                    var unmarshaller = NoiseReducerFilterSettingsUnmarshaller.Instance;
                    unmarshalledObject.FilterSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("spatialFilterSettings", targetDepth))
                {
                    var unmarshaller = NoiseReducerSpatialFilterSettingsUnmarshaller.Instance;
                    unmarshalledObject.SpatialFilterSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("temporalFilterSettings", targetDepth))
                {
                    var unmarshaller = NoiseReducerTemporalFilterSettingsUnmarshaller.Instance;
                    unmarshalledObject.TemporalFilterSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static NoiseReducerUnmarshaller _instance = new NoiseReducerUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static NoiseReducerUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}