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
    /// Response Unmarshaller for CaptionDestinationSettings Object
    /// </summary>  
    public class CaptionDestinationSettingsUnmarshaller : IUnmarshaller<CaptionDestinationSettings, XmlUnmarshallerContext>, IUnmarshaller<CaptionDestinationSettings, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        CaptionDestinationSettings IUnmarshaller<CaptionDestinationSettings, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public CaptionDestinationSettings Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            CaptionDestinationSettings unmarshalledObject = new CaptionDestinationSettings();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("burninDestinationSettings", targetDepth))
                {
                    var unmarshaller = BurninDestinationSettingsUnmarshaller.Instance;
                    unmarshalledObject.BurninDestinationSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("destinationType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DestinationType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("dvbSubDestinationSettings", targetDepth))
                {
                    var unmarshaller = DvbSubDestinationSettingsUnmarshaller.Instance;
                    unmarshalledObject.DvbSubDestinationSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("embeddedDestinationSettings", targetDepth))
                {
                    var unmarshaller = EmbeddedDestinationSettingsUnmarshaller.Instance;
                    unmarshalledObject.EmbeddedDestinationSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("imscDestinationSettings", targetDepth))
                {
                    var unmarshaller = ImscDestinationSettingsUnmarshaller.Instance;
                    unmarshalledObject.ImscDestinationSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("sccDestinationSettings", targetDepth))
                {
                    var unmarshaller = SccDestinationSettingsUnmarshaller.Instance;
                    unmarshalledObject.SccDestinationSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("teletextDestinationSettings", targetDepth))
                {
                    var unmarshaller = TeletextDestinationSettingsUnmarshaller.Instance;
                    unmarshalledObject.TeletextDestinationSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ttmlDestinationSettings", targetDepth))
                {
                    var unmarshaller = TtmlDestinationSettingsUnmarshaller.Instance;
                    unmarshalledObject.TtmlDestinationSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static CaptionDestinationSettingsUnmarshaller _instance = new CaptionDestinationSettingsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CaptionDestinationSettingsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}