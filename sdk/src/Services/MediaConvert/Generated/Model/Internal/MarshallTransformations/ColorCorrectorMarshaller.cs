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
    /// ColorCorrector Marshaller
    /// </summary>
    public class ColorCorrectorMarshaller : IRequestMarshaller<ColorCorrector, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ColorCorrector requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetBrightness())
            {
                context.Writer.WritePropertyName("brightness");
                context.Writer.WriteNumberValue(requestObject.Brightness.Value);
            }

            if(requestObject.IsSetClipLimits())
            {
                context.Writer.WritePropertyName("clipLimits");
                context.Writer.WriteStartObject();

                var marshaller = ClipLimitsMarshaller.Instance;
                marshaller.Marshall(requestObject.ClipLimits, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetColorSpaceConversion())
            {
                context.Writer.WritePropertyName("colorSpaceConversion");
                context.Writer.WriteStringValue(requestObject.ColorSpaceConversion);
            }

            if(requestObject.IsSetContrast())
            {
                context.Writer.WritePropertyName("contrast");
                context.Writer.WriteNumberValue(requestObject.Contrast.Value);
            }

            if(requestObject.IsSetHdr10Metadata())
            {
                context.Writer.WritePropertyName("hdr10Metadata");
                context.Writer.WriteStartObject();

                var marshaller = Hdr10MetadataMarshaller.Instance;
                marshaller.Marshall(requestObject.Hdr10Metadata, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetHdrToSdrToneMapper())
            {
                context.Writer.WritePropertyName("hdrToSdrToneMapper");
                context.Writer.WriteStringValue(requestObject.HdrToSdrToneMapper);
            }

            if(requestObject.IsSetHue())
            {
                context.Writer.WritePropertyName("hue");
                context.Writer.WriteNumberValue(requestObject.Hue.Value);
            }

            if(requestObject.IsSetMaxLuminance())
            {
                context.Writer.WritePropertyName("maxLuminance");
                context.Writer.WriteNumberValue(requestObject.MaxLuminance.Value);
            }

            if(requestObject.IsSetSampleRangeConversion())
            {
                context.Writer.WritePropertyName("sampleRangeConversion");
                context.Writer.WriteStringValue(requestObject.SampleRangeConversion);
            }

            if(requestObject.IsSetSaturation())
            {
                context.Writer.WritePropertyName("saturation");
                context.Writer.WriteNumberValue(requestObject.Saturation.Value);
            }

            if(requestObject.IsSetSdrReferenceWhiteLevel())
            {
                context.Writer.WritePropertyName("sdrReferenceWhiteLevel");
                context.Writer.WriteNumberValue(requestObject.SdrReferenceWhiteLevel.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ColorCorrectorMarshaller Instance = new ColorCorrectorMarshaller();

    }
}