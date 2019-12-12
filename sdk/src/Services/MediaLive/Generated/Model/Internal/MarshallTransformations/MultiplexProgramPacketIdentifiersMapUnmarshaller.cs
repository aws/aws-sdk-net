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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaLive.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.MediaLive.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for MultiplexProgramPacketIdentifiersMap Object
    /// </summary>  
    public class MultiplexProgramPacketIdentifiersMapUnmarshaller : IUnmarshaller<MultiplexProgramPacketIdentifiersMap, XmlUnmarshallerContext>, IUnmarshaller<MultiplexProgramPacketIdentifiersMap, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        MultiplexProgramPacketIdentifiersMap IUnmarshaller<MultiplexProgramPacketIdentifiersMap, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public MultiplexProgramPacketIdentifiersMap Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            MultiplexProgramPacketIdentifiersMap unmarshalledObject = new MultiplexProgramPacketIdentifiersMap();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("audioPids", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<int, IntUnmarshaller>(IntUnmarshaller.Instance);
                    unmarshalledObject.AudioPids = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("dvbSubPids", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<int, IntUnmarshaller>(IntUnmarshaller.Instance);
                    unmarshalledObject.DvbSubPids = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("dvbTeletextPid", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.DvbTeletextPid = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("etvPlatformPid", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.EtvPlatformPid = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("etvSignalPid", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.EtvSignalPid = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("klvDataPids", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<int, IntUnmarshaller>(IntUnmarshaller.Instance);
                    unmarshalledObject.KlvDataPids = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("pcrPid", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.PcrPid = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("pmtPid", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.PmtPid = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("privateMetadataPid", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.PrivateMetadataPid = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("scte27Pids", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<int, IntUnmarshaller>(IntUnmarshaller.Instance);
                    unmarshalledObject.Scte27Pids = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("scte35Pid", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.Scte35Pid = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("timedMetadataPid", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.TimedMetadataPid = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("videoPid", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.VideoPid = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static MultiplexProgramPacketIdentifiersMapUnmarshaller _instance = new MultiplexProgramPacketIdentifiersMapUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static MultiplexProgramPacketIdentifiersMapUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}