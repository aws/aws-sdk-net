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
    /// Response Unmarshaller for M2tsSettings Object
    /// </summary>  
    public class M2tsSettingsUnmarshaller : IJsonUnmarshaller<M2tsSettings, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public M2tsSettings Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            M2tsSettings unmarshalledObject = new M2tsSettings();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("absentInputAudioBehavior", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AbsentInputAudioBehavior = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("arib", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Arib = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("aribCaptionsPid", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AribCaptionsPid = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("aribCaptionsPidControl", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AribCaptionsPidControl = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("audioBufferModel", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AudioBufferModel = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("audioFramesPerPes", targetDepth, ref reader))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.AudioFramesPerPes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("audioPids", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AudioPids = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("audioStreamType", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AudioStreamType = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("bitrate", targetDepth, ref reader))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.Bitrate = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("bufferModel", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.BufferModel = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ccDescriptor", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CcDescriptor = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("dvbNitSettings", targetDepth, ref reader))
                {
                    var unmarshaller = DvbNitSettingsUnmarshaller.Instance;
                    unmarshalledObject.DvbNitSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("dvbSdtSettings", targetDepth, ref reader))
                {
                    var unmarshaller = DvbSdtSettingsUnmarshaller.Instance;
                    unmarshalledObject.DvbSdtSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("dvbSubPids", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DvbSubPids = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("dvbTdtSettings", targetDepth, ref reader))
                {
                    var unmarshaller = DvbTdtSettingsUnmarshaller.Instance;
                    unmarshalledObject.DvbTdtSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("dvbTeletextPid", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DvbTeletextPid = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ebif", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Ebif = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ebpAudioInterval", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EbpAudioInterval = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ebpLookaheadMs", targetDepth, ref reader))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.EbpLookaheadMs = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ebpPlacement", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EbpPlacement = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ecmPid", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EcmPid = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("esRateInPes", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EsRateInPes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("etvPlatformPid", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EtvPlatformPid = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("etvSignalPid", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EtvSignalPid = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("fragmentTime", targetDepth, ref reader))
                {
                    var unmarshaller = NullableDoubleUnmarshaller.Instance;
                    unmarshalledObject.FragmentTime = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("klv", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Klv = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("klvDataPids", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.KlvDataPids = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("nielsenId3Behavior", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.NielsenId3Behavior = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("nullPacketBitrate", targetDepth, ref reader))
                {
                    var unmarshaller = NullableDoubleUnmarshaller.Instance;
                    unmarshalledObject.NullPacketBitrate = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("patInterval", targetDepth, ref reader))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.PatInterval = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("pcrControl", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PcrControl = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("pcrPeriod", targetDepth, ref reader))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.PcrPeriod = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("pcrPid", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PcrPid = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("pmtInterval", targetDepth, ref reader))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.PmtInterval = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("pmtPid", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PmtPid = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("programNum", targetDepth, ref reader))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.ProgramNum = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("rateMode", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RateMode = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("scte27Pids", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Scte27Pids = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("scte35Control", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Scte35Control = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("scte35Pid", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Scte35Pid = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("scte35PrerollPullupMilliseconds", targetDepth, ref reader))
                {
                    var unmarshaller = NullableDoubleUnmarshaller.Instance;
                    unmarshalledObject.Scte35PrerollPullupMilliseconds = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("segmentationMarkers", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SegmentationMarkers = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("segmentationStyle", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SegmentationStyle = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("segmentationTime", targetDepth, ref reader))
                {
                    var unmarshaller = NullableDoubleUnmarshaller.Instance;
                    unmarshalledObject.SegmentationTime = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("timedMetadataBehavior", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TimedMetadataBehavior = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("timedMetadataPid", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TimedMetadataPid = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("transportStreamId", targetDepth, ref reader))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.TransportStreamId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("videoPid", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.VideoPid = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static M2tsSettingsUnmarshaller _instance = new M2tsSettingsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static M2tsSettingsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}