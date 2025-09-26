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
 * Do not modify this file. This file is generated from the bedrock-data-automation-2023-07-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.BedrockDataAutomation.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.BedrockDataAutomation.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// TranscriptConfiguration Marshaller
    /// </summary>
    public class TranscriptConfigurationMarshaller : IRequestMarshaller<TranscriptConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(TranscriptConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetChannelLabeling())
            {
                context.Writer.WritePropertyName("channelLabeling");
                context.Writer.WriteStartObject();

                var marshaller = ChannelLabelingConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.ChannelLabeling, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSpeakerLabeling())
            {
                context.Writer.WritePropertyName("speakerLabeling");
                context.Writer.WriteStartObject();

                var marshaller = SpeakerLabelingConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.SpeakerLabeling, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static TranscriptConfigurationMarshaller Instance = new TranscriptConfigurationMarshaller();

    }
}