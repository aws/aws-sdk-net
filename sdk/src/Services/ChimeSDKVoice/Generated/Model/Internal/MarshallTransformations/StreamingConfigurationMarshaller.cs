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
#pragma warning disable CS0612,CS0618
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
            if(requestObject == null)
                return;
            if(requestObject.IsSetDataRetentionInHours())
            {
                context.Writer.WritePropertyName("DataRetentionInHours");
                context.Writer.WriteNumberValue(requestObject.DataRetentionInHours.Value);
            }

            if(requestObject.IsSetDisabled())
            {
                context.Writer.WritePropertyName("Disabled");
                context.Writer.WriteBooleanValue(requestObject.Disabled.Value);
            }

            if(requestObject.IsSetMediaInsightsConfiguration())
            {
                context.Writer.WritePropertyName("MediaInsightsConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = MediaInsightsConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.MediaInsightsConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetStreamingNotificationTargets())
            {
                context.Writer.WritePropertyName("StreamingNotificationTargets");
                context.Writer.WriteStartArray();
                foreach(var requestObjectStreamingNotificationTargetsListValue in requestObject.StreamingNotificationTargets)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StreamingNotificationTargetMarshaller.Instance;
                    marshaller.Marshall(requestObjectStreamingNotificationTargetsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static StreamingConfigurationMarshaller Instance = new StreamingConfigurationMarshaller();

    }
}