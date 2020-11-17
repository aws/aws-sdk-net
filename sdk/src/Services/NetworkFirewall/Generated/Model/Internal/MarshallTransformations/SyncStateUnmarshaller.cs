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
 * Do not modify this file. This file is generated from the network-firewall-2020-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.NetworkFirewall.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.NetworkFirewall.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for SyncState Object
    /// </summary>  
    public class SyncStateUnmarshaller : IUnmarshaller<SyncState, XmlUnmarshallerContext>, IUnmarshaller<SyncState, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        SyncState IUnmarshaller<SyncState, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public SyncState Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            SyncState unmarshalledObject = new SyncState();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Attachment", targetDepth))
                {
                    var unmarshaller = AttachmentUnmarshaller.Instance;
                    unmarshalledObject.Attachment = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Config", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, PerObjectStatus, StringUnmarshaller, PerObjectStatusUnmarshaller>(StringUnmarshaller.Instance, PerObjectStatusUnmarshaller.Instance);
                    unmarshalledObject.Config = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static SyncStateUnmarshaller _instance = new SyncStateUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SyncStateUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}