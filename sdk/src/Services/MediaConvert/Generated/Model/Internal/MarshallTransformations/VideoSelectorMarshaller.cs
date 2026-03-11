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
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaConvert.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.MediaConvert.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// VideoSelector Marshaller
    /// </summary>
    public class VideoSelectorMarshaller : IRequestMarshaller<VideoSelector, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(VideoSelector requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAlphaBehavior())
            {
                context.Writer.WritePropertyName("alphaBehavior");
                context.Writer.WriteStringValue(requestObject.AlphaBehavior);
            }

            if(requestObject.IsSetColorSpace())
            {
                context.Writer.WritePropertyName("colorSpace");
                context.Writer.WriteStringValue(requestObject.ColorSpace);
            }

            if(requestObject.IsSetColorSpaceUsage())
            {
                context.Writer.WritePropertyName("colorSpaceUsage");
                context.Writer.WriteStringValue(requestObject.ColorSpaceUsage);
            }

            if(requestObject.IsSetEmbeddedTimecodeOverride())
            {
                context.Writer.WritePropertyName("embeddedTimecodeOverride");
                context.Writer.WriteStringValue(requestObject.EmbeddedTimecodeOverride);
            }

            if(requestObject.IsSetHdr10Metadata())
            {
                context.Writer.WritePropertyName("hdr10Metadata");
                context.Writer.WriteStartObject();

                var marshaller = Hdr10MetadataMarshaller.Instance;
                marshaller.Marshall(requestObject.Hdr10Metadata, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMaxLuminance())
            {
                context.Writer.WritePropertyName("maxLuminance");
                context.Writer.WriteNumberValue(requestObject.MaxLuminance.Value);
            }

            if(requestObject.IsSetPadVideo())
            {
                context.Writer.WritePropertyName("padVideo");
                context.Writer.WriteStringValue(requestObject.PadVideo);
            }

            if(requestObject.IsSetPid())
            {
                context.Writer.WritePropertyName("pid");
                context.Writer.WriteNumberValue(requestObject.Pid.Value);
            }

            if(requestObject.IsSetProgramNumber())
            {
                context.Writer.WritePropertyName("programNumber");
                context.Writer.WriteNumberValue(requestObject.ProgramNumber.Value);
            }

            if(requestObject.IsSetRotate())
            {
                context.Writer.WritePropertyName("rotate");
                context.Writer.WriteStringValue(requestObject.Rotate);
            }

            if(requestObject.IsSetSampleRange())
            {
                context.Writer.WritePropertyName("sampleRange");
                context.Writer.WriteStringValue(requestObject.SampleRange);
            }

            if(requestObject.IsSetSelectorType())
            {
                context.Writer.WritePropertyName("selectorType");
                context.Writer.WriteStringValue(requestObject.SelectorType);
            }

            if(requestObject.IsSetStreams())
            {
                context.Writer.WritePropertyName("streams");
                context.Writer.WriteStartArray();
                foreach(var requestObjectStreamsListValue in requestObject.Streams)
                {
                        context.Writer.WriteNumberValue(requestObjectStreamsListValue);
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static VideoSelectorMarshaller Instance = new VideoSelectorMarshaller();

    }
}