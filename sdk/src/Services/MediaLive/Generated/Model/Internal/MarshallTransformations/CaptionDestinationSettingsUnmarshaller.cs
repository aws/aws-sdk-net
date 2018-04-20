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
                if (context.TestExpression("aribDestinationSettings", targetDepth))
                {
                    var unmarshaller = AribDestinationSettingsUnmarshaller.Instance;
                    unmarshalledObject.AribDestinationSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("burnInDestinationSettings", targetDepth))
                {
                    var unmarshaller = BurnInDestinationSettingsUnmarshaller.Instance;
                    unmarshalledObject.BurnInDestinationSettings = unmarshaller.Unmarshall(context);
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
                if (context.TestExpression("embeddedPlusScte20DestinationSettings", targetDepth))
                {
                    var unmarshaller = EmbeddedPlusScte20DestinationSettingsUnmarshaller.Instance;
                    unmarshalledObject.EmbeddedPlusScte20DestinationSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("rtmpCaptionInfoDestinationSettings", targetDepth))
                {
                    var unmarshaller = RtmpCaptionInfoDestinationSettingsUnmarshaller.Instance;
                    unmarshalledObject.RtmpCaptionInfoDestinationSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("scte20PlusEmbeddedDestinationSettings", targetDepth))
                {
                    var unmarshaller = Scte20PlusEmbeddedDestinationSettingsUnmarshaller.Instance;
                    unmarshalledObject.Scte20PlusEmbeddedDestinationSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("scte27DestinationSettings", targetDepth))
                {
                    var unmarshaller = Scte27DestinationSettingsUnmarshaller.Instance;
                    unmarshalledObject.Scte27DestinationSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("smpteTtDestinationSettings", targetDepth))
                {
                    var unmarshaller = SmpteTtDestinationSettingsUnmarshaller.Instance;
                    unmarshalledObject.SmpteTtDestinationSettings = unmarshaller.Unmarshall(context);
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
                if (context.TestExpression("webvttDestinationSettings", targetDepth))
                {
                    var unmarshaller = WebvttDestinationSettingsUnmarshaller.Instance;
                    unmarshalledObject.WebvttDestinationSettings = unmarshaller.Unmarshall(context);
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