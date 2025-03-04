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
    /// VideoDescription Marshaller
    /// </summary>
    public class VideoDescriptionMarshaller : IRequestMarshaller<VideoDescription, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(VideoDescription requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAfdSignaling())
            {
                context.Writer.WritePropertyName("afdSignaling");
                context.Writer.WriteStringValue(requestObject.AfdSignaling);
            }

            if(requestObject.IsSetAntiAlias())
            {
                context.Writer.WritePropertyName("antiAlias");
                context.Writer.WriteStringValue(requestObject.AntiAlias);
            }

            if(requestObject.IsSetChromaPositionMode())
            {
                context.Writer.WritePropertyName("chromaPositionMode");
                context.Writer.WriteStringValue(requestObject.ChromaPositionMode);
            }

            if(requestObject.IsSetCodecSettings())
            {
                context.Writer.WritePropertyName("codecSettings");
                context.Writer.WriteStartObject();

                var marshaller = VideoCodecSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.CodecSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetColorMetadata())
            {
                context.Writer.WritePropertyName("colorMetadata");
                context.Writer.WriteStringValue(requestObject.ColorMetadata);
            }

            if(requestObject.IsSetCrop())
            {
                context.Writer.WritePropertyName("crop");
                context.Writer.WriteStartObject();

                var marshaller = RectangleMarshaller.Instance;
                marshaller.Marshall(requestObject.Crop, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDropFrameTimecode())
            {
                context.Writer.WritePropertyName("dropFrameTimecode");
                context.Writer.WriteStringValue(requestObject.DropFrameTimecode);
            }

            if(requestObject.IsSetFixedAfd())
            {
                context.Writer.WritePropertyName("fixedAfd");
                context.Writer.WriteNumberValue(requestObject.FixedAfd.Value);
            }

            if(requestObject.IsSetHeight())
            {
                context.Writer.WritePropertyName("height");
                context.Writer.WriteNumberValue(requestObject.Height.Value);
            }

            if(requestObject.IsSetPosition())
            {
                context.Writer.WritePropertyName("position");
                context.Writer.WriteStartObject();

                var marshaller = RectangleMarshaller.Instance;
                marshaller.Marshall(requestObject.Position, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRespondToAfd())
            {
                context.Writer.WritePropertyName("respondToAfd");
                context.Writer.WriteStringValue(requestObject.RespondToAfd);
            }

            if(requestObject.IsSetScalingBehavior())
            {
                context.Writer.WritePropertyName("scalingBehavior");
                context.Writer.WriteStringValue(requestObject.ScalingBehavior);
            }

            if(requestObject.IsSetSharpness())
            {
                context.Writer.WritePropertyName("sharpness");
                context.Writer.WriteNumberValue(requestObject.Sharpness.Value);
            }

            if(requestObject.IsSetTimecodeInsertion())
            {
                context.Writer.WritePropertyName("timecodeInsertion");
                context.Writer.WriteStringValue(requestObject.TimecodeInsertion);
            }

            if(requestObject.IsSetTimecodeTrack())
            {
                context.Writer.WritePropertyName("timecodeTrack");
                context.Writer.WriteStringValue(requestObject.TimecodeTrack);
            }

            if(requestObject.IsSetVideoPreprocessors())
            {
                context.Writer.WritePropertyName("videoPreprocessors");
                context.Writer.WriteStartObject();

                var marshaller = VideoPreprocessorMarshaller.Instance;
                marshaller.Marshall(requestObject.VideoPreprocessors, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetWidth())
            {
                context.Writer.WritePropertyName("width");
                context.Writer.WriteNumberValue(requestObject.Width.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static VideoDescriptionMarshaller Instance = new VideoDescriptionMarshaller();

    }
}