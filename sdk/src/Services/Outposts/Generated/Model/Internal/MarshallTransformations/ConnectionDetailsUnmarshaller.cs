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
 * Do not modify this file. This file is generated from the outposts-2019-12-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Outposts.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Outposts.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ConnectionDetails Object
    /// </summary>  
    public class ConnectionDetailsUnmarshaller : IUnmarshaller<ConnectionDetails, XmlUnmarshallerContext>, IUnmarshaller<ConnectionDetails, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ConnectionDetails IUnmarshaller<ConnectionDetails, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public ConnectionDetails Unmarshall(JsonUnmarshallerContext context)
        {
            ConnectionDetails unmarshalledObject = new ConnectionDetails();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AllowedIps", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.AllowedIps = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ClientPublicKey", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ClientPublicKey = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ClientTunnelAddress", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ClientTunnelAddress = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ServerEndpoint", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ServerEndpoint = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ServerPublicKey", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ServerPublicKey = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ServerTunnelAddress", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ServerTunnelAddress = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ConnectionDetailsUnmarshaller _instance = new ConnectionDetailsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ConnectionDetailsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}