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
    /// MonitoringConfig Marshaller
    /// </summary>
    public class MonitoringConfigMarshaller : IRequestMarshaller<MonitoringConfig, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(MonitoringConfig requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAudioMonitoringSettings())
            {
                context.Writer.WritePropertyName("audioMonitoringSettings");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectAudioMonitoringSettingsListValue in requestObject.AudioMonitoringSettings)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AudioMonitoringSettingMarshaller.Instance;
                    marshaller.Marshall(requestObjectAudioMonitoringSettingsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetContentQualityAnalysisState())
            {
                context.Writer.WritePropertyName("contentQualityAnalysisState");
                context.Writer.Write(requestObject.ContentQualityAnalysisState);
            }

            if(requestObject.IsSetThumbnailState())
            {
                context.Writer.WritePropertyName("thumbnailState");
                context.Writer.Write(requestObject.ThumbnailState);
            }

            if(requestObject.IsSetVideoMonitoringSettings())
            {
                context.Writer.WritePropertyName("videoMonitoringSettings");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectVideoMonitoringSettingsListValue in requestObject.VideoMonitoringSettings)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = VideoMonitoringSettingMarshaller.Instance;
                    marshaller.Marshall(requestObjectVideoMonitoringSettingsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static MonitoringConfigMarshaller Instance = new MonitoringConfigMarshaller();

    }
}