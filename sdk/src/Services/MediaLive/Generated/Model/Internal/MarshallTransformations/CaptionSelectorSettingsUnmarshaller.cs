/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Response Unmarshaller for CaptionSelectorSettings Object
    /// </summary>  
    public class CaptionSelectorSettingsUnmarshaller : IUnmarshaller<CaptionSelectorSettings, XmlUnmarshallerContext>, IUnmarshaller<CaptionSelectorSettings, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        CaptionSelectorSettings IUnmarshaller<CaptionSelectorSettings, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public CaptionSelectorSettings Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            CaptionSelectorSettings unmarshalledObject = new CaptionSelectorSettings();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("aribSourceSettings", targetDepth))
                {
                    var unmarshaller = AribSourceSettingsUnmarshaller.Instance;
                    unmarshalledObject.AribSourceSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("dvbSubSourceSettings", targetDepth))
                {
                    var unmarshaller = DvbSubSourceSettingsUnmarshaller.Instance;
                    unmarshalledObject.DvbSubSourceSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("embeddedSourceSettings", targetDepth))
                {
                    var unmarshaller = EmbeddedSourceSettingsUnmarshaller.Instance;
                    unmarshalledObject.EmbeddedSourceSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("scte20SourceSettings", targetDepth))
                {
                    var unmarshaller = Scte20SourceSettingsUnmarshaller.Instance;
                    unmarshalledObject.Scte20SourceSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("scte27SourceSettings", targetDepth))
                {
                    var unmarshaller = Scte27SourceSettingsUnmarshaller.Instance;
                    unmarshalledObject.Scte27SourceSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("teletextSourceSettings", targetDepth))
                {
                    var unmarshaller = TeletextSourceSettingsUnmarshaller.Instance;
                    unmarshalledObject.TeletextSourceSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static CaptionSelectorSettingsUnmarshaller _instance = new CaptionSelectorSettingsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CaptionSelectorSettingsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}