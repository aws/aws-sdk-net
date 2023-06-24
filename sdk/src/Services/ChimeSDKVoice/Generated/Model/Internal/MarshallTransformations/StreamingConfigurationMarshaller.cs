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
 * Do not modify this file. This file is generated from the chime-sdk-voice-2022-08-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ChimeSDKVoice.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ChimeSDKVoice.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StreamingConfiguration Marshaller
    /// </summary>
    public class StreamingConfigurationMarshaller : IRequestMarshaller<StreamingConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(StreamingConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetDataRetentionInHours())
            {
                context.Writer.WritePropertyName("DataRetentionInHours");
                context.Writer.Write(requestObject.DataRetentionInHours);
            }

            if(requestObject.IsSetDisabled())
            {
                context.Writer.WritePropertyName("Disabled");
                context.Writer.Write(requestObject.Disabled);
            }

            if(requestObject.IsSetMediaInsightsConfiguration())
            {
                context.Writer.WritePropertyName("MediaInsightsConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = MediaInsightsConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.MediaInsightsConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetStreamingNotificationTargets())
            {
                context.Writer.WritePropertyName("StreamingNotificationTargets");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectStreamingNotificationTargetsListValue in requestObject.StreamingNotificationTargets)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = StreamingNotificationTargetMarshaller.Instance;
                    marshaller.Marshall(requestObjectStreamingNotificationTargetsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static StreamingConfigurationMarshaller Instance = new StreamingConfigurationMarshaller();

    }
}