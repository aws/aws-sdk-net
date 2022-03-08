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
    /// Response Unmarshaller for NetworkStatus Object
    /// </summary>  
    public class NetworkStatusUnmarshaller : IUnmarshaller<NetworkStatus, XmlUnmarshallerContext>, IUnmarshaller<NetworkStatus, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        NetworkStatus IUnmarshaller<NetworkStatus, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public NetworkStatus Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            NetworkStatus unmarshalledObject = new NetworkStatus();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Ethernet0Status", targetDepth))
                {
                    var unmarshaller = EthernetStatusUnmarshaller.Instance;
                    unmarshalledObject.Ethernet0Status = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Ethernet1Status", targetDepth))
                {
                    var unmarshaller = EthernetStatusUnmarshaller.Instance;
                    unmarshalledObject.Ethernet1Status = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LastUpdatedTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.LastUpdatedTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NtpStatus", targetDepth))
                {
                    var unmarshaller = NtpStatusUnmarshaller.Instance;
                    unmarshalledObject.NtpStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static NetworkStatusUnmarshaller _instance = new NetworkStatusUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static NetworkStatusUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}