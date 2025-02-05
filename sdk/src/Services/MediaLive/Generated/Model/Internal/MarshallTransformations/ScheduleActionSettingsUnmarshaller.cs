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
    /// Response Unmarshaller for ScheduleActionSettings Object
    /// </summary>  
    public class ScheduleActionSettingsUnmarshaller : IJsonUnmarshaller<ScheduleActionSettings, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public ScheduleActionSettings Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            ScheduleActionSettings unmarshalledObject = new ScheduleActionSettings();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("hlsId3SegmentTaggingSettings", targetDepth))
                {
                    var unmarshaller = HlsId3SegmentTaggingScheduleActionSettingsUnmarshaller.Instance;
                    unmarshalledObject.HlsId3SegmentTaggingSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("hlsTimedMetadataSettings", targetDepth))
                {
                    var unmarshaller = HlsTimedMetadataScheduleActionSettingsUnmarshaller.Instance;
                    unmarshalledObject.HlsTimedMetadataSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("id3SegmentTaggingSettings", targetDepth))
                {
                    var unmarshaller = Id3SegmentTaggingScheduleActionSettingsUnmarshaller.Instance;
                    unmarshalledObject.Id3SegmentTaggingSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("inputPrepareSettings", targetDepth))
                {
                    var unmarshaller = InputPrepareScheduleActionSettingsUnmarshaller.Instance;
                    unmarshalledObject.InputPrepareSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("inputSwitchSettings", targetDepth))
                {
                    var unmarshaller = InputSwitchScheduleActionSettingsUnmarshaller.Instance;
                    unmarshalledObject.InputSwitchSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("motionGraphicsImageActivateSettings", targetDepth))
                {
                    var unmarshaller = MotionGraphicsActivateScheduleActionSettingsUnmarshaller.Instance;
                    unmarshalledObject.MotionGraphicsImageActivateSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("motionGraphicsImageDeactivateSettings", targetDepth))
                {
                    var unmarshaller = MotionGraphicsDeactivateScheduleActionSettingsUnmarshaller.Instance;
                    unmarshalledObject.MotionGraphicsImageDeactivateSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("pauseStateSettings", targetDepth))
                {
                    var unmarshaller = PauseStateScheduleActionSettingsUnmarshaller.Instance;
                    unmarshalledObject.PauseStateSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("scte35InputSettings", targetDepth))
                {
                    var unmarshaller = Scte35InputScheduleActionSettingsUnmarshaller.Instance;
                    unmarshalledObject.Scte35InputSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("scte35ReturnToNetworkSettings", targetDepth))
                {
                    var unmarshaller = Scte35ReturnToNetworkScheduleActionSettingsUnmarshaller.Instance;
                    unmarshalledObject.Scte35ReturnToNetworkSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("scte35SpliceInsertSettings", targetDepth))
                {
                    var unmarshaller = Scte35SpliceInsertScheduleActionSettingsUnmarshaller.Instance;
                    unmarshalledObject.Scte35SpliceInsertSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("scte35TimeSignalSettings", targetDepth))
                {
                    var unmarshaller = Scte35TimeSignalScheduleActionSettingsUnmarshaller.Instance;
                    unmarshalledObject.Scte35TimeSignalSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("staticImageActivateSettings", targetDepth))
                {
                    var unmarshaller = StaticImageActivateScheduleActionSettingsUnmarshaller.Instance;
                    unmarshalledObject.StaticImageActivateSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("staticImageDeactivateSettings", targetDepth))
                {
                    var unmarshaller = StaticImageDeactivateScheduleActionSettingsUnmarshaller.Instance;
                    unmarshalledObject.StaticImageDeactivateSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("staticImageOutputActivateSettings", targetDepth))
                {
                    var unmarshaller = StaticImageOutputActivateScheduleActionSettingsUnmarshaller.Instance;
                    unmarshalledObject.StaticImageOutputActivateSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("staticImageOutputDeactivateSettings", targetDepth))
                {
                    var unmarshaller = StaticImageOutputDeactivateScheduleActionSettingsUnmarshaller.Instance;
                    unmarshalledObject.StaticImageOutputDeactivateSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("timedMetadataSettings", targetDepth))
                {
                    var unmarshaller = TimedMetadataScheduleActionSettingsUnmarshaller.Instance;
                    unmarshalledObject.TimedMetadataSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ScheduleActionSettingsUnmarshaller _instance = new ScheduleActionSettingsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ScheduleActionSettingsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}