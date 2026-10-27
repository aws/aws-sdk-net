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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.MediaLive.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618

namespace Amazon.MediaLive.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Output Marshaller
    /// </summary>
    public partial class OutputMarshaller : IRequestMarshaller<Output, JsonMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(Output requestObject, JsonMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetAudioDescriptionNames())
            {
                context.Writer.WritePropertyName("audioDescriptionNames");
                context.Writer.WriteStartArray();
                foreach (var requestObjectAudioDescriptionNamesListValue in requestObject.AudioDescriptionNames)
                {
                    context.Writer.WriteStringValue(requestObjectAudioDescriptionNamesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetCaptionDescriptionNames())
            {
                context.Writer.WritePropertyName("captionDescriptionNames");
                context.Writer.WriteStartArray();
                foreach (var requestObjectCaptionDescriptionNamesListValue in requestObject.CaptionDescriptionNames)
                {
                    context.Writer.WriteStringValue(requestObjectCaptionDescriptionNamesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetOutputName())
            {
                context.Writer.WritePropertyName("outputName");
                context.Writer.WriteStringValue(requestObject.OutputName);
            }

            if (requestObject.IsSetOutputSettings())
            {
                context.Writer.WritePropertyName("outputSettings");
                context.Writer.WriteStartObject();

                var marshaller = OutputSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.OutputSettings, context);

                context.Writer.WriteEndObject();
            }

            if (requestObject.IsSetVideoDescriptionName())
            {
                context.Writer.WritePropertyName("videoDescriptionName");
                context.Writer.WriteStringValue(requestObject.VideoDescriptionName);
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static OutputMarshaller Instance = new OutputMarshaller();
    }
}
