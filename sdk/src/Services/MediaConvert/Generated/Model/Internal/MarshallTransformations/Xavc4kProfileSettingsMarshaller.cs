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
    /// Xavc4kProfileSettings Marshaller
    /// </summary>
    public class Xavc4kProfileSettingsMarshaller : IRequestMarshaller<Xavc4kProfileSettings, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Xavc4kProfileSettings requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetBitrateClass())
            {
                context.Writer.WritePropertyName("bitrateClass");
                context.Writer.WriteStringValue(requestObject.BitrateClass);
            }

            if(requestObject.IsSetCodecProfile())
            {
                context.Writer.WritePropertyName("codecProfile");
                context.Writer.WriteStringValue(requestObject.CodecProfile);
            }

            if(requestObject.IsSetFlickerAdaptiveQuantization())
            {
                context.Writer.WritePropertyName("flickerAdaptiveQuantization");
                context.Writer.WriteStringValue(requestObject.FlickerAdaptiveQuantization);
            }

            if(requestObject.IsSetGopBReference())
            {
                context.Writer.WritePropertyName("gopBReference");
                context.Writer.WriteStringValue(requestObject.GopBReference);
            }

            if(requestObject.IsSetGopClosedCadence())
            {
                context.Writer.WritePropertyName("gopClosedCadence");
                context.Writer.WriteNumberValue(requestObject.GopClosedCadence.Value);
            }

            if(requestObject.IsSetHrdBufferSize())
            {
                context.Writer.WritePropertyName("hrdBufferSize");
                context.Writer.WriteNumberValue(requestObject.HrdBufferSize.Value);
            }

            if(requestObject.IsSetQualityTuningLevel())
            {
                context.Writer.WritePropertyName("qualityTuningLevel");
                context.Writer.WriteStringValue(requestObject.QualityTuningLevel);
            }

            if(requestObject.IsSetSlices())
            {
                context.Writer.WritePropertyName("slices");
                context.Writer.WriteNumberValue(requestObject.Slices.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static Xavc4kProfileSettingsMarshaller Instance = new Xavc4kProfileSettingsMarshaller();

    }
}