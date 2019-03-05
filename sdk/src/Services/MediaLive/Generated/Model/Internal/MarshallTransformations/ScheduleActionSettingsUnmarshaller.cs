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
    /// Response Unmarshaller for ScheduleActionSettings Object
    /// </summary>  
    public class ScheduleActionSettingsUnmarshaller : IUnmarshaller<ScheduleActionSettings, XmlUnmarshallerContext>, IUnmarshaller<ScheduleActionSettings, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ScheduleActionSettings IUnmarshaller<ScheduleActionSettings, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ScheduleActionSettings Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            ScheduleActionSettings unmarshalledObject = new ScheduleActionSettings();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("hlsTimedMetadataSettings", targetDepth))
                {
                    var unmarshaller = HlsTimedMetadataScheduleActionSettingsUnmarshaller.Instance;
                    unmarshalledObject.HlsTimedMetadataSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("inputSwitchSettings", targetDepth))
                {
                    var unmarshaller = InputSwitchScheduleActionSettingsUnmarshaller.Instance;
                    unmarshalledObject.InputSwitchSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("pauseStateSettings", targetDepth))
                {
                    var unmarshaller = PauseStateScheduleActionSettingsUnmarshaller.Instance;
                    unmarshalledObject.PauseStateSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("scte35ReturnToNetworkSettings", targetDepth))
                {
                    var unmarshaller = Scte35ReturnToNetworkScheduleActionSettingsUnmarshaller.Instance;
                    unmarshalledObject.Scte35ReturnToNetworkSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("scte35SpliceInsertSettings", targetDepth))
                {
                    var unmarshaller = Scte35SpliceInsertScheduleActionSettingsUnmarshaller.Instance;
                    unmarshalledObject.Scte35SpliceInsertSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("scte35TimeSignalSettings", targetDepth))
                {
                    var unmarshaller = Scte35TimeSignalScheduleActionSettingsUnmarshaller.Instance;
                    unmarshalledObject.Scte35TimeSignalSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("staticImageActivateSettings", targetDepth))
                {
                    var unmarshaller = StaticImageActivateScheduleActionSettingsUnmarshaller.Instance;
                    unmarshalledObject.StaticImageActivateSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("staticImageDeactivateSettings", targetDepth))
                {
                    var unmarshaller = StaticImageDeactivateScheduleActionSettingsUnmarshaller.Instance;
                    unmarshalledObject.StaticImageDeactivateSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static ScheduleActionSettingsUnmarshaller _instance = new ScheduleActionSettingsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ScheduleActionSettingsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}