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
    /// Response Unmarshaller for FailoverConditionSettings Object
    /// </summary>  
    public class FailoverConditionSettingsUnmarshaller : IUnmarshaller<FailoverConditionSettings, XmlUnmarshallerContext>, IUnmarshaller<FailoverConditionSettings, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        FailoverConditionSettings IUnmarshaller<FailoverConditionSettings, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public FailoverConditionSettings Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            FailoverConditionSettings unmarshalledObject = new FailoverConditionSettings();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("audioSilenceSettings", targetDepth))
                {
                    var unmarshaller = AudioSilenceFailoverSettingsUnmarshaller.Instance;
                    unmarshalledObject.AudioSilenceSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("inputLossSettings", targetDepth))
                {
                    var unmarshaller = InputLossFailoverSettingsUnmarshaller.Instance;
                    unmarshalledObject.InputLossSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("videoBlackSettings", targetDepth))
                {
                    var unmarshaller = VideoBlackFailoverSettingsUnmarshaller.Instance;
                    unmarshalledObject.VideoBlackSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static FailoverConditionSettingsUnmarshaller _instance = new FailoverConditionSettingsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static FailoverConditionSettingsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}