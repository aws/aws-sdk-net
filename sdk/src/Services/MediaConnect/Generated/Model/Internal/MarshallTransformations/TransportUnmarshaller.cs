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
 * Do not modify this file. This file is generated from the mediaconnect-2018-11-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaConnect.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.MediaConnect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Transport Object
    /// </summary>  
    public class TransportUnmarshaller : IUnmarshaller<Transport, XmlUnmarshallerContext>, IUnmarshaller<Transport, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        Transport IUnmarshaller<Transport, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public Transport Unmarshall(JsonUnmarshallerContext context)
        {
            Transport unmarshalledObject = new Transport();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("cidrAllowList", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.CidrAllowList = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("maxBitrate", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.MaxBitrate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("maxLatency", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.MaxLatency = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("maxSyncBuffer", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.MaxSyncBuffer = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("minLatency", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.MinLatency = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ndiProgramName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.NdiProgramName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ndiSourceSettings", targetDepth))
                {
                    var unmarshaller = NdiSourceSettingsUnmarshaller.Instance;
                    unmarshalledObject.NdiSourceSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ndiSpeedHqQuality", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.NdiSpeedHqQuality = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("protocol", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Protocol = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("remoteId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RemoteId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("senderControlPort", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.SenderControlPort = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("senderIpAddress", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SenderIpAddress = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("smoothingLatency", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.SmoothingLatency = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("sourceListenerAddress", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SourceListenerAddress = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("sourceListenerPort", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.SourceListenerPort = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("streamId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.StreamId = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static TransportUnmarshaller _instance = new TransportUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static TransportUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}