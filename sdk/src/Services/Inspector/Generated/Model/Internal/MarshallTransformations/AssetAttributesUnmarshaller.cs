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
 * Do not modify this file. This file is generated from the inspector-2016-02-16.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Inspector.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Inspector.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AssetAttributes Object
    /// </summary>  
    public class AssetAttributesUnmarshaller : IUnmarshaller<AssetAttributes, XmlUnmarshallerContext>, IUnmarshaller<AssetAttributes, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        AssetAttributes IUnmarshaller<AssetAttributes, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public AssetAttributes Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            AssetAttributes unmarshalledObject = new AssetAttributes();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("agentId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AgentId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("amiId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AmiId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("autoScalingGroup", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AutoScalingGroup = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("hostname", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Hostname = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ipv4Addresses", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.Ipv4Addresses = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("networkInterfaces", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<NetworkInterface, NetworkInterfaceUnmarshaller>(NetworkInterfaceUnmarshaller.Instance);
                    unmarshalledObject.NetworkInterfaces = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("schemaVersion", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.SchemaVersion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("tags", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Tag, TagUnmarshaller>(TagUnmarshaller.Instance);
                    unmarshalledObject.Tags = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static AssetAttributesUnmarshaller _instance = new AssetAttributesUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AssetAttributesUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}