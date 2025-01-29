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
    /// VideoPreprocessor Marshaller
    /// </summary>
    public class VideoPreprocessorMarshaller : IRequestMarshaller<VideoPreprocessor, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(VideoPreprocessor requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetColorCorrector())
            {
                context.Writer.WritePropertyName("colorCorrector");
                context.Writer.WriteStartObject();

                var marshaller = ColorCorrectorMarshaller.Instance;
                marshaller.Marshall(requestObject.ColorCorrector, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDeinterlacer())
            {
                context.Writer.WritePropertyName("deinterlacer");
                context.Writer.WriteStartObject();

                var marshaller = DeinterlacerMarshaller.Instance;
                marshaller.Marshall(requestObject.Deinterlacer, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDolbyVision())
            {
                context.Writer.WritePropertyName("dolbyVision");
                context.Writer.WriteStartObject();

                var marshaller = DolbyVisionMarshaller.Instance;
                marshaller.Marshall(requestObject.DolbyVision, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetHdr10Plus())
            {
                context.Writer.WritePropertyName("hdr10Plus");
                context.Writer.WriteStartObject();

                var marshaller = Hdr10PlusMarshaller.Instance;
                marshaller.Marshall(requestObject.Hdr10Plus, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetImageInserter())
            {
                context.Writer.WritePropertyName("imageInserter");
                context.Writer.WriteStartObject();

                var marshaller = ImageInserterMarshaller.Instance;
                marshaller.Marshall(requestObject.ImageInserter, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetNoiseReducer())
            {
                context.Writer.WritePropertyName("noiseReducer");
                context.Writer.WriteStartObject();

                var marshaller = NoiseReducerMarshaller.Instance;
                marshaller.Marshall(requestObject.NoiseReducer, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetPartnerWatermarking())
            {
                context.Writer.WritePropertyName("partnerWatermarking");
                context.Writer.WriteStartObject();

                var marshaller = PartnerWatermarkingMarshaller.Instance;
                marshaller.Marshall(requestObject.PartnerWatermarking, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTimecodeBurnin())
            {
                context.Writer.WritePropertyName("timecodeBurnin");
                context.Writer.WriteStartObject();

                var marshaller = TimecodeBurninMarshaller.Instance;
                marshaller.Marshall(requestObject.TimecodeBurnin, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static VideoPreprocessorMarshaller Instance = new VideoPreprocessorMarshaller();

    }
}