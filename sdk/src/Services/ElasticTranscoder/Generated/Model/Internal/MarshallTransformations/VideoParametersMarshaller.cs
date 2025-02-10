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
 * Do not modify this file. This file is generated from the elastictranscoder-2012-09-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ElasticTranscoder.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.ElasticTranscoder.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// VideoParameters Marshaller
    /// </summary>
    public class VideoParametersMarshaller : IRequestMarshaller<VideoParameters, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(VideoParameters requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAspectRatio())
            {
                context.Writer.WritePropertyName("AspectRatio");
                context.Writer.WriteStringValue(requestObject.AspectRatio);
            }

            if(requestObject.IsSetBitRate())
            {
                context.Writer.WritePropertyName("BitRate");
                context.Writer.WriteStringValue(requestObject.BitRate);
            }

            if(requestObject.IsSetCodec())
            {
                context.Writer.WritePropertyName("Codec");
                context.Writer.WriteStringValue(requestObject.Codec);
            }

            if(requestObject.IsSetCodecOptions())
            {
                context.Writer.WritePropertyName("CodecOptions");
                context.Writer.WriteStartObject();
                foreach (var requestObjectCodecOptionsKvp in requestObject.CodecOptions)
                {
                    context.Writer.WritePropertyName(requestObjectCodecOptionsKvp.Key);
                    var requestObjectCodecOptionsValue = requestObjectCodecOptionsKvp.Value;

                        context.Writer.WriteStringValue(requestObjectCodecOptionsValue);
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDisplayAspectRatio())
            {
                context.Writer.WritePropertyName("DisplayAspectRatio");
                context.Writer.WriteStringValue(requestObject.DisplayAspectRatio);
            }

            if(requestObject.IsSetFixedGOP())
            {
                context.Writer.WritePropertyName("FixedGOP");
                context.Writer.WriteStringValue(requestObject.FixedGOP);
            }

            if(requestObject.IsSetFrameRate())
            {
                context.Writer.WritePropertyName("FrameRate");
                context.Writer.WriteStringValue(requestObject.FrameRate);
            }

            if(requestObject.IsSetKeyframesMaxDist())
            {
                context.Writer.WritePropertyName("KeyframesMaxDist");
                context.Writer.WriteStringValue(requestObject.KeyframesMaxDist);
            }

            if(requestObject.IsSetMaxFrameRate())
            {
                context.Writer.WritePropertyName("MaxFrameRate");
                context.Writer.WriteStringValue(requestObject.MaxFrameRate);
            }

            if(requestObject.IsSetMaxHeight())
            {
                context.Writer.WritePropertyName("MaxHeight");
                context.Writer.WriteStringValue(requestObject.MaxHeight);
            }

            if(requestObject.IsSetMaxWidth())
            {
                context.Writer.WritePropertyName("MaxWidth");
                context.Writer.WriteStringValue(requestObject.MaxWidth);
            }

            if(requestObject.IsSetPaddingPolicy())
            {
                context.Writer.WritePropertyName("PaddingPolicy");
                context.Writer.WriteStringValue(requestObject.PaddingPolicy);
            }

            if(requestObject.IsSetResolution())
            {
                context.Writer.WritePropertyName("Resolution");
                context.Writer.WriteStringValue(requestObject.Resolution);
            }

            if(requestObject.IsSetSizingPolicy())
            {
                context.Writer.WritePropertyName("SizingPolicy");
                context.Writer.WriteStringValue(requestObject.SizingPolicy);
            }

            if(requestObject.IsSetWatermarks())
            {
                context.Writer.WritePropertyName("Watermarks");
                context.Writer.WriteStartArray();
                foreach(var requestObjectWatermarksListValue in requestObject.Watermarks)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = PresetWatermarkMarshaller.Instance;
                    marshaller.Marshall(requestObjectWatermarksListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static VideoParametersMarshaller Instance = new VideoParametersMarshaller();

    }
}