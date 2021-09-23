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
    /// Response Unmarshaller for DashIsoImageBasedTrickPlaySettings Object
    /// </summary>  
    public class DashIsoImageBasedTrickPlaySettingsUnmarshaller : IUnmarshaller<DashIsoImageBasedTrickPlaySettings, XmlUnmarshallerContext>, IUnmarshaller<DashIsoImageBasedTrickPlaySettings, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        DashIsoImageBasedTrickPlaySettings IUnmarshaller<DashIsoImageBasedTrickPlaySettings, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public DashIsoImageBasedTrickPlaySettings Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            DashIsoImageBasedTrickPlaySettings unmarshalledObject = new DashIsoImageBasedTrickPlaySettings();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("intervalCadence", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.IntervalCadence = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("thumbnailHeight", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.ThumbnailHeight = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("thumbnailInterval", targetDepth))
                {
                    var unmarshaller = DoubleUnmarshaller.Instance;
                    unmarshalledObject.ThumbnailInterval = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("thumbnailWidth", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.ThumbnailWidth = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("tileHeight", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.TileHeight = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("tileWidth", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.TileWidth = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static DashIsoImageBasedTrickPlaySettingsUnmarshaller _instance = new DashIsoImageBasedTrickPlaySettingsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DashIsoImageBasedTrickPlaySettingsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}