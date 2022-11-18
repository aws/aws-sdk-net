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
 * Do not modify this file. This file is generated from the chime-sdk-voice-2022-08-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ChimeSDKVoice.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ChimeSDKVoice.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for PhoneNumberCapabilities Object
    /// </summary>  
    public class PhoneNumberCapabilitiesUnmarshaller : IUnmarshaller<PhoneNumberCapabilities, XmlUnmarshallerContext>, IUnmarshaller<PhoneNumberCapabilities, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        PhoneNumberCapabilities IUnmarshaller<PhoneNumberCapabilities, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public PhoneNumberCapabilities Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            PhoneNumberCapabilities unmarshalledObject = new PhoneNumberCapabilities();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("InboundCall", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.InboundCall = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InboundMMS", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.InboundMMS = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InboundSMS", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.InboundSMS = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OutboundCall", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.OutboundCall = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OutboundMMS", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.OutboundMMS = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OutboundSMS", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.OutboundSMS = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static PhoneNumberCapabilitiesUnmarshaller _instance = new PhoneNumberCapabilitiesUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PhoneNumberCapabilitiesUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}