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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.EKS.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618

namespace Amazon.EKS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for RemoteNetworkConfigResponse Object
    /// </summary>
    public partial class RemoteNetworkConfigResponseUnmarshaller : IJsonUnmarshaller<RemoteNetworkConfigResponse, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public RemoteNetworkConfigResponse Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            var unmarshalledObject = new RemoteNetworkConfigResponse();
            if (context.IsEmptyResponse) return null;

            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("remoteNodeNetworks", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<RemoteNodeNetwork, RemoteNodeNetworkUnmarshaller>(RemoteNodeNetworkUnmarshaller.Instance);
                    unmarshalledObject.RemoteNodeNetworks = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("remotePodNetworks", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<RemotePodNetwork, RemotePodNetworkUnmarshaller>(RemotePodNetworkUnmarshaller.Instance);
                    unmarshalledObject.RemotePodNetworks = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }

        private static RemoteNetworkConfigResponseUnmarshaller _instance = new RemoteNetworkConfigResponseUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static RemoteNetworkConfigResponseUnmarshaller Instance => _instance;
    }
}
