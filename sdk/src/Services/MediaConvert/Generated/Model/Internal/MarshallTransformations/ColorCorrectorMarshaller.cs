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
using ThirdParty.Json.LitJson;

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
            if(requestObject.IsSetBrightness())
            {
                context.Writer.WritePropertyName("brightness");
                context.Writer.Write(requestObject.Brightness);
            }

            if(requestObject.IsSetClipLimits())
            {
                context.Writer.WritePropertyName("clipLimits");
                context.Writer.WriteObjectStart();

                var marshaller = ClipLimitsMarshaller.Instance;
                marshaller.Marshall(requestObject.ClipLimits, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetColorSpaceConversion())
            {
                context.Writer.WritePropertyName("colorSpaceConversion");
                context.Writer.Write(requestObject.ColorSpaceConversion);
            }

            if(requestObject.IsSetContrast())
            {
                context.Writer.WritePropertyName("contrast");
                context.Writer.Write(requestObject.Contrast);
            }

            if(requestObject.IsSetHdr10Metadata())
            {
                context.Writer.WritePropertyName("hdr10Metadata");
                context.Writer.WriteObjectStart();

                var marshaller = Hdr10MetadataMarshaller.Instance;
                marshaller.Marshall(requestObject.Hdr10Metadata, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetHue())
            {
                context.Writer.WritePropertyName("hue");
                context.Writer.Write(requestObject.Hue);
            }

            if(requestObject.IsSetSampleRangeConversion())
            {
                context.Writer.WritePropertyName("sampleRangeConversion");
                context.Writer.Write(requestObject.SampleRangeConversion);
            }

            if(requestObject.IsSetSaturation())
            {
                context.Writer.WritePropertyName("saturation");
                context.Writer.Write(requestObject.Saturation);
            }

            if(requestObject.IsSetSdrReferenceWhiteLevel())
            {
                context.Writer.WritePropertyName("sdrReferenceWhiteLevel");
                context.Writer.Write(requestObject.SdrReferenceWhiteLevel);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ColorCorrectorMarshaller Instance = new ColorCorrectorMarshaller();

    }
}