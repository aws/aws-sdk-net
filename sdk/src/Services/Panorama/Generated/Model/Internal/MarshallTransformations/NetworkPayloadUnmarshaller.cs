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
 * Do not modify this file. This file is generated from the panorama-2019-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Panorama.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Panorama.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for NetworkPayload Object
    /// </summary>  
    public class NetworkPayloadUnmarshaller : IUnmarshaller<NetworkPayload, XmlUnmarshallerContext>, IUnmarshaller<NetworkPayload, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        NetworkPayload IUnmarshaller<NetworkPayload, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public NetworkPayload Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            NetworkPayload unmarshalledObject = new NetworkPayload();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Ethernet0", targetDepth))
                {
                    var unmarshaller = EthernetPayloadUnmarshaller.Instance;
                    unmarshalledObject.Ethernet0 = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Ethernet1", targetDepth))
                {
                    var unmarshaller = EthernetPayloadUnmarshaller.Instance;
                    unmarshalledObject.Ethernet1 = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Ntp", targetDepth))
                {
                    var unmarshaller = NtpPayloadUnmarshaller.Instance;
                    unmarshalledObject.Ntp = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static NetworkPayloadUnmarshaller _instance = new NetworkPayloadUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static NetworkPayloadUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}