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
    /// Response Unmarshaller for NodeFabricLogPublishingConfiguration Object
    /// </summary>  
    public class NodeFabricLogPublishingConfigurationUnmarshaller : IUnmarshaller<NodeFabricLogPublishingConfiguration, XmlUnmarshallerContext>, IUnmarshaller<NodeFabricLogPublishingConfiguration, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        NodeFabricLogPublishingConfiguration IUnmarshaller<NodeFabricLogPublishingConfiguration, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public NodeFabricLogPublishingConfiguration Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            NodeFabricLogPublishingConfiguration unmarshalledObject = new NodeFabricLogPublishingConfiguration();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("ChaincodeLogs", targetDepth))
                {
                    var unmarshaller = LogConfigurationsUnmarshaller.Instance;
                    unmarshalledObject.ChaincodeLogs = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PeerLogs", targetDepth))
                {
                    var unmarshaller = LogConfigurationsUnmarshaller.Instance;
                    unmarshalledObject.PeerLogs = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static NodeFabricLogPublishingConfigurationUnmarshaller _instance = new NodeFabricLogPublishingConfigurationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static NodeFabricLogPublishingConfigurationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}