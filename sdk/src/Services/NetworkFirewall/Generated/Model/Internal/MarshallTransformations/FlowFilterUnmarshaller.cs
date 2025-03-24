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

#pragma warning disable CS0612,CS0618
namespace Amazon.NetworkFirewall.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for FlowFilter Object
    /// </summary>  
    public class FlowFilterUnmarshaller : IUnmarshaller<FlowFilter, XmlUnmarshallerContext>, IUnmarshaller<FlowFilter, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        FlowFilter IUnmarshaller<FlowFilter, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public FlowFilter Unmarshall(JsonUnmarshallerContext context)
        {
            FlowFilter unmarshalledObject = new FlowFilter();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("DestinationAddress", targetDepth))
                {
                    var unmarshaller = AddressUnmarshaller.Instance;
                    unmarshalledObject.DestinationAddress = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DestinationPort", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DestinationPort = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Protocols", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.Protocols = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SourceAddress", targetDepth))
                {
                    var unmarshaller = AddressUnmarshaller.Instance;
                    unmarshalledObject.SourceAddress = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SourcePort", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SourcePort = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static FlowFilterUnmarshaller _instance = new FlowFilterUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static FlowFilterUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}