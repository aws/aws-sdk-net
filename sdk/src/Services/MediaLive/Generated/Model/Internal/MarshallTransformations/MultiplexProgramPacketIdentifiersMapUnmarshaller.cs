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
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.MediaLive.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for MultiplexProgramPacketIdentifiersMap Object
    /// </summary>  
    public class MultiplexProgramPacketIdentifiersMapUnmarshaller : IJsonUnmarshaller<MultiplexProgramPacketIdentifiersMap, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public MultiplexProgramPacketIdentifiersMap Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            MultiplexProgramPacketIdentifiersMap unmarshalledObject = new MultiplexProgramPacketIdentifiersMap();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("aribCaptionsPid", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.AribCaptionsPid = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("audioPids", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<int, IntUnmarshaller>(IntUnmarshaller.Instance);
                    unmarshalledObject.AudioPids = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("dvbSubPids", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<int, IntUnmarshaller>(IntUnmarshaller.Instance);
                    unmarshalledObject.DvbSubPids = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("dvbTeletextPid", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.DvbTeletextPid = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("dvbTeletextPids", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<int, IntUnmarshaller>(IntUnmarshaller.Instance);
                    unmarshalledObject.DvbTeletextPids = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ecmPid", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.EcmPid = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("etvPlatformPid", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.EtvPlatformPid = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("etvSignalPid", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.EtvSignalPid = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("klvDataPids", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<int, IntUnmarshaller>(IntUnmarshaller.Instance);
                    unmarshalledObject.KlvDataPids = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("pcrPid", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.PcrPid = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("pmtPid", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.PmtPid = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("privateMetadataPid", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.PrivateMetadataPid = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("scte27Pids", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<int, IntUnmarshaller>(IntUnmarshaller.Instance);
                    unmarshalledObject.Scte27Pids = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("scte35Pid", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.Scte35Pid = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("smpte2038Pid", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.Smpte2038Pid = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("timedMetadataPid", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.TimedMetadataPid = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("videoPid", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.VideoPid = unmarshaller.Unmarshall(context, ref reader);
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