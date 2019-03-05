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
            if(requestObject.IsSetHlsTimedMetadataSettings())
            {
                context.Writer.WritePropertyName("hlsTimedMetadataSettings");
                context.Writer.WriteObjectStart();

                var marshaller = HlsTimedMetadataScheduleActionSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.HlsTimedMetadataSettings, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetInputSwitchSettings())
            {
                context.Writer.WritePropertyName("inputSwitchSettings");
                context.Writer.WriteObjectStart();

                var marshaller = InputSwitchScheduleActionSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.InputSwitchSettings, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetPauseStateSettings())
            {
                context.Writer.WritePropertyName("pauseStateSettings");
                context.Writer.WriteObjectStart();

                var marshaller = PauseStateScheduleActionSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.PauseStateSettings, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetScte35ReturnToNetworkSettings())
            {
                context.Writer.WritePropertyName("scte35ReturnToNetworkSettings");
                context.Writer.WriteObjectStart();

                var marshaller = Scte35ReturnToNetworkScheduleActionSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.Scte35ReturnToNetworkSettings, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetScte35SpliceInsertSettings())
            {
                context.Writer.WritePropertyName("scte35SpliceInsertSettings");
                context.Writer.WriteObjectStart();

                var marshaller = Scte35SpliceInsertScheduleActionSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.Scte35SpliceInsertSettings, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetScte35TimeSignalSettings())
            {
                context.Writer.WritePropertyName("scte35TimeSignalSettings");
                context.Writer.WriteObjectStart();

                var marshaller = Scte35TimeSignalScheduleActionSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.Scte35TimeSignalSettings, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetStaticImageActivateSettings())
            {
                context.Writer.WritePropertyName("staticImageActivateSettings");
                context.Writer.WriteObjectStart();

                var marshaller = StaticImageActivateScheduleActionSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.StaticImageActivateSettings, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetStaticImageDeactivateSettings())
            {
                context.Writer.WritePropertyName("staticImageDeactivateSettings");
                context.Writer.WriteObjectStart();

                var marshaller = StaticImageDeactivateScheduleActionSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.StaticImageDeactivateSettings, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static ScheduleActionSettingsMarshaller Instance = new ScheduleActionSettingsMarshaller();

    }
}