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
    /// Response Unmarshaller for EsamSettings Object
    /// </summary>  
    public class EsamSettingsUnmarshaller : IUnmarshaller<EsamSettings, XmlUnmarshallerContext>, IUnmarshaller<EsamSettings, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        EsamSettings IUnmarshaller<EsamSettings, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public EsamSettings Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            EsamSettings unmarshalledObject = new EsamSettings();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("manifestConfirmConditionNotification", targetDepth))
                {
                    var unmarshaller = EsamManifestConfirmConditionNotificationUnmarshaller.Instance;
                    unmarshalledObject.ManifestConfirmConditionNotification = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("responseSignalPreroll", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.ResponseSignalPreroll = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("signalProcessingNotification", targetDepth))
                {
                    var unmarshaller = EsamSignalProcessingNotificationUnmarshaller.Instance;
                    unmarshalledObject.SignalProcessingNotification = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static EsamSettingsUnmarshaller _instance = new EsamSettingsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static EsamSettingsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}