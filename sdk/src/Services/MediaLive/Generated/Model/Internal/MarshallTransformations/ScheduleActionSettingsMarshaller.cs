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
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaLive.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.MediaLive.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ScheduleActionSettings Marshaller
    /// </summary>
    public class ScheduleActionSettingsMarshaller : IRequestMarshaller<ScheduleActionSettings, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ScheduleActionSettings requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetHlsId3SegmentTaggingSettings())
            {
                context.Writer.WritePropertyName("hlsId3SegmentTaggingSettings");
                context.Writer.WriteStartObject();

                var marshaller = HlsId3SegmentTaggingScheduleActionSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.HlsId3SegmentTaggingSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetHlsTimedMetadataSettings())
            {
                context.Writer.WritePropertyName("hlsTimedMetadataSettings");
                context.Writer.WriteStartObject();

                var marshaller = HlsTimedMetadataScheduleActionSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.HlsTimedMetadataSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetId3SegmentTaggingSettings())
            {
                context.Writer.WritePropertyName("id3SegmentTaggingSettings");
                context.Writer.WriteStartObject();

                var marshaller = Id3SegmentTaggingScheduleActionSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.Id3SegmentTaggingSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetInputPrepareSettings())
            {
                context.Writer.WritePropertyName("inputPrepareSettings");
                context.Writer.WriteStartObject();

                var marshaller = InputPrepareScheduleActionSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.InputPrepareSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetInputSwitchSettings())
            {
                context.Writer.WritePropertyName("inputSwitchSettings");
                context.Writer.WriteStartObject();

                var marshaller = InputSwitchScheduleActionSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.InputSwitchSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMotionGraphicsImageActivateSettings())
            {
                context.Writer.WritePropertyName("motionGraphicsImageActivateSettings");
                context.Writer.WriteStartObject();

                var marshaller = MotionGraphicsActivateScheduleActionSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.MotionGraphicsImageActivateSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMotionGraphicsImageDeactivateSettings())
            {
                context.Writer.WritePropertyName("motionGraphicsImageDeactivateSettings");
                context.Writer.WriteStartObject();

                var marshaller = MotionGraphicsDeactivateScheduleActionSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.MotionGraphicsImageDeactivateSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetPauseStateSettings())
            {
                context.Writer.WritePropertyName("pauseStateSettings");
                context.Writer.WriteStartObject();

                var marshaller = PauseStateScheduleActionSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.PauseStateSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetScte35InputSettings())
            {
                context.Writer.WritePropertyName("scte35InputSettings");
                context.Writer.WriteStartObject();

                var marshaller = Scte35InputScheduleActionSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.Scte35InputSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetScte35ReturnToNetworkSettings())
            {
                context.Writer.WritePropertyName("scte35ReturnToNetworkSettings");
                context.Writer.WriteStartObject();

                var marshaller = Scte35ReturnToNetworkScheduleActionSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.Scte35ReturnToNetworkSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetScte35SpliceInsertSettings())
            {
                context.Writer.WritePropertyName("scte35SpliceInsertSettings");
                context.Writer.WriteStartObject();

                var marshaller = Scte35SpliceInsertScheduleActionSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.Scte35SpliceInsertSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetScte35TimeSignalSettings())
            {
                context.Writer.WritePropertyName("scte35TimeSignalSettings");
                context.Writer.WriteStartObject();

                var marshaller = Scte35TimeSignalScheduleActionSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.Scte35TimeSignalSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetStaticImageActivateSettings())
            {
                context.Writer.WritePropertyName("staticImageActivateSettings");
                context.Writer.WriteStartObject();

                var marshaller = StaticImageActivateScheduleActionSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.StaticImageActivateSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetStaticImageDeactivateSettings())
            {
                context.Writer.WritePropertyName("staticImageDeactivateSettings");
                context.Writer.WriteStartObject();

                var marshaller = StaticImageDeactivateScheduleActionSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.StaticImageDeactivateSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetStaticImageOutputActivateSettings())
            {
                context.Writer.WritePropertyName("staticImageOutputActivateSettings");
                context.Writer.WriteStartObject();

                var marshaller = StaticImageOutputActivateScheduleActionSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.StaticImageOutputActivateSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetStaticImageOutputDeactivateSettings())
            {
                context.Writer.WritePropertyName("staticImageOutputDeactivateSettings");
                context.Writer.WriteStartObject();

                var marshaller = StaticImageOutputDeactivateScheduleActionSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.StaticImageOutputDeactivateSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTimedMetadataSettings())
            {
                context.Writer.WritePropertyName("timedMetadataSettings");
                context.Writer.WriteStartObject();

                var marshaller = TimedMetadataScheduleActionSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.TimedMetadataSettings, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ScheduleActionSettingsMarshaller Instance = new ScheduleActionSettingsMarshaller();

    }
}