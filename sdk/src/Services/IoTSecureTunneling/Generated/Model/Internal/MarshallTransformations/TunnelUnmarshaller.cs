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
 * Do not modify this file. This file is generated from the iotsecuretunneling-2018-10-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTSecureTunneling.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.IoTSecureTunneling.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Tunnel Object
    /// </summary>  
    public class TunnelUnmarshaller : IUnmarshaller<Tunnel, XmlUnmarshallerContext>, IUnmarshaller<Tunnel, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        Tunnel IUnmarshaller<Tunnel, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public Tunnel Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            Tunnel unmarshalledObject = new Tunnel();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("createdAt", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreatedAt = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("description", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Description = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("destinationConfig", targetDepth))
                {
                    var unmarshaller = DestinationConfigUnmarshaller.Instance;
                    unmarshalledObject.DestinationConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("destinationConnectionState", targetDepth))
                {
                    var unmarshaller = ConnectionStateUnmarshaller.Instance;
                    unmarshalledObject.DestinationConnectionState = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("lastUpdatedAt", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.LastUpdatedAt = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("sourceConnectionState", targetDepth))
                {
                    var unmarshaller = ConnectionStateUnmarshaller.Instance;
                    unmarshalledObject.SourceConnectionState = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("status", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Status = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("tags", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Tag, TagUnmarshaller>(TagUnmarshaller.Instance);
                    unmarshalledObject.Tags = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("timeoutConfig", targetDepth))
                {
                    var unmarshaller = TimeoutConfigUnmarshaller.Instance;
                    unmarshalledObject.TimeoutConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("tunnelArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TunnelArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("tunnelId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TunnelId = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static TunnelUnmarshaller _instance = new TunnelUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static TunnelUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}