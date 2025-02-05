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
 * Do not modify this file. This file is generated from the sms-2016-10-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ServerMigrationService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.ServerMigrationService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Server Object
    /// </summary>  
    public class ServerUnmarshaller : IJsonUnmarshaller<Server, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public Server Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            Server unmarshalledObject = new Server();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("replicationJobId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ReplicationJobId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("replicationJobTerminated", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.ReplicationJobTerminated = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("serverId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ServerId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("serverType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ServerType = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("vmServer", targetDepth))
                {
                    var unmarshaller = VmServerUnmarshaller.Instance;
                    unmarshalledObject.VmServer = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ServerUnmarshaller _instance = new ServerUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ServerUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}