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
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaConvert.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.MediaConvert.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for M2tsSettings Object
    /// </summary>  
    public class M2tsSettingsUnmarshaller : IUnmarshaller<M2tsSettings, XmlUnmarshallerContext>, IUnmarshaller<M2tsSettings, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        M2tsSettings IUnmarshaller<M2tsSettings, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public M2tsSettings Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            M2tsSettings unmarshalledObject = new M2tsSettings();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("audioBufferModel", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AudioBufferModel = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("audioFramesPerPes", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.AudioFramesPerPes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("audioPids", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<int, IntUnmarshaller>(IntUnmarshaller.Instance);
                    unmarshalledObject.AudioPids = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("bitrate", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.Bitrate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("bufferModel", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.BufferModel = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("dvbNitSettings", targetDepth))
                {
                    var unmarshaller = DvbNitSettingsUnmarshaller.Instance;
                    unmarshalledObject.DvbNitSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("dvbSdtSettings", targetDepth))
                {
                    var unmarshaller = DvbSdtSettingsUnmarshaller.Instance;
                    unmarshalledObject.DvbSdtSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("dvbSubPids", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<int, IntUnmarshaller>(IntUnmarshaller.Instance);
                    unmarshalledObject.DvbSubPids = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("dvbTdtSettings", targetDepth))
                {
                    var unmarshaller = DvbTdtSettingsUnmarshaller.Instance;
                    unmarshalledObject.DvbTdtSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("dvbTeletextPid", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.DvbTeletextPid = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ebpAudioInterval", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EbpAudioInterval = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ebpPlacement", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EbpPlacement = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("esRateInPes", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EsRateInPes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("fragmentTime", targetDepth))
                {
                    var unmarshaller = DoubleUnmarshaller.Instance;
                    unmarshalledObject.FragmentTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("maxPcrInterval", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.MaxPcrInterval = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("minEbpInterval", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.MinEbpInterval = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("nielsenId3", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.NielsenId3 = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("nullPacketBitrate", targetDepth))
                {
                    var unmarshaller = DoubleUnmarshaller.Instance;
                    unmarshalledObject.NullPacketBitrate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("patInterval", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.PatInterval = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("pcrControl", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PcrControl = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("pcrPid", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.PcrPid = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("pmtInterval", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.PmtInterval = unmarshaller.Unmarshall(context);
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
                if (context.TestExpression("programNumber", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.ProgramNumber = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("rateMode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RateMode = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("scte35Pid", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.Scte35Pid = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("scte35Source", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Scte35Source = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("segmentationMarkers", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SegmentationMarkers = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("segmentationStyle", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SegmentationStyle = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("segmentationTime", targetDepth))
                {
                    var unmarshaller = DoubleUnmarshaller.Instance;
                    unmarshalledObject.SegmentationTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("timedMetadataPid", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.TimedMetadataPid = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("transportStreamId", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.TransportStreamId = unmarshaller.Unmarshall(context);
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