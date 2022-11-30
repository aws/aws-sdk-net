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
 * Do not modify this file. This file is generated from the sagemaker-geospatial-2020-05-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SageMakerGeospatial.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SageMakerGeospatial.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Property Object
    /// </summary>  
    public class PropertyUnmarshaller : IUnmarshaller<Property, XmlUnmarshallerContext>, IUnmarshaller<Property, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        Property IUnmarshaller<Property, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public Property Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            Property unmarshalledObject = new Property();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("EoCloudCover", targetDepth))
                {
                    var unmarshaller = EoCloudCoverInputUnmarshaller.Instance;
                    unmarshalledObject.EoCloudCover = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LandsatCloudCoverLand", targetDepth))
                {
                    var unmarshaller = LandsatCloudCoverLandInputUnmarshaller.Instance;
                    unmarshalledObject.LandsatCloudCoverLand = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Platform", targetDepth))
                {
                    var unmarshaller = PlatformInputUnmarshaller.Instance;
                    unmarshalledObject.Platform = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ViewOffNadir", targetDepth))
                {
                    var unmarshaller = ViewOffNadirInputUnmarshaller.Instance;
                    unmarshalledObject.ViewOffNadir = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ViewSunAzimuth", targetDepth))
                {
                    var unmarshaller = ViewSunAzimuthInputUnmarshaller.Instance;
                    unmarshalledObject.ViewSunAzimuth = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ViewSunElevation", targetDepth))
                {
                    var unmarshaller = ViewSunElevationInputUnmarshaller.Instance;
                    unmarshalledObject.ViewSunElevation = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static PropertyUnmarshaller _instance = new PropertyUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PropertyUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}