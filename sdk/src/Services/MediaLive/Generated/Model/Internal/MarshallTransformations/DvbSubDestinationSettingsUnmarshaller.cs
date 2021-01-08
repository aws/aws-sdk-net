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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaLive.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.MediaLive.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DvbSubDestinationSettings Object
    /// </summary>  
    public class DvbSubDestinationSettingsUnmarshaller : IUnmarshaller<DvbSubDestinationSettings, XmlUnmarshallerContext>, IUnmarshaller<DvbSubDestinationSettings, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        DvbSubDestinationSettings IUnmarshaller<DvbSubDestinationSettings, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public DvbSubDestinationSettings Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            DvbSubDestinationSettings unmarshalledObject = new DvbSubDestinationSettings();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("alignment", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Alignment = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("backgroundColor", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.BackgroundColor = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("backgroundOpacity", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.BackgroundOpacity = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("font", targetDepth))
                {
                    var unmarshaller = InputLocationUnmarshaller.Instance;
                    unmarshalledObject.Font = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("fontColor", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FontColor = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("fontOpacity", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.FontOpacity = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("fontResolution", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.FontResolution = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("fontSize", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FontSize = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("outlineColor", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.OutlineColor = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("outlineSize", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.OutlineSize = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("shadowColor", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ShadowColor = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("shadowOpacity", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.ShadowOpacity = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("shadowXOffset", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.ShadowXOffset = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("shadowYOffset", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.ShadowYOffset = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("teletextGridControl", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TeletextGridControl = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("xPosition", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.XPosition = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("yPosition", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.YPosition = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static DvbSubDestinationSettingsUnmarshaller _instance = new DvbSubDestinationSettingsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DvbSubDestinationSettingsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}