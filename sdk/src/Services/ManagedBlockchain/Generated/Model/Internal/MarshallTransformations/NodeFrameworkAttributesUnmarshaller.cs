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
 * Do not modify this file. This file is generated from the managedblockchain-2018-09-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ManagedBlockchain.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ManagedBlockchain.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for NodeFrameworkAttributes Object
    /// </summary>  
    public class NodeFrameworkAttributesUnmarshaller : IUnmarshaller<NodeFrameworkAttributes, XmlUnmarshallerContext>, IUnmarshaller<NodeFrameworkAttributes, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        NodeFrameworkAttributes IUnmarshaller<NodeFrameworkAttributes, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public NodeFrameworkAttributes Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            NodeFrameworkAttributes unmarshalledObject = new NodeFrameworkAttributes();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Ethereum", targetDepth))
                {
                    var unmarshaller = NodeEthereumAttributesUnmarshaller.Instance;
                    unmarshalledObject.Ethereum = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Fabric", targetDepth))
                {
                    var unmarshaller = NodeFabricAttributesUnmarshaller.Instance;
                    unmarshalledObject.Fabric = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static NodeFrameworkAttributesUnmarshaller _instance = new NodeFrameworkAttributesUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static NodeFrameworkAttributesUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}