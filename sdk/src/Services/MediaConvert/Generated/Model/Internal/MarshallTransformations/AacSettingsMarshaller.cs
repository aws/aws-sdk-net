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
    /// AacSettings Marshaller
    /// </summary>
    public class AacSettingsMarshaller : IRequestMarshaller<AacSettings, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AacSettings requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAudioDescriptionBroadcasterMix())
            {
                context.Writer.WritePropertyName("audioDescriptionBroadcasterMix");
                context.Writer.WriteStringValue(requestObject.AudioDescriptionBroadcasterMix);
            }

            if(requestObject.IsSetBitrate())
            {
                context.Writer.WritePropertyName("bitrate");
                context.Writer.WriteNumberValue(requestObject.Bitrate.Value);
            }

            if(requestObject.IsSetCodecProfile())
            {
                context.Writer.WritePropertyName("codecProfile");
                context.Writer.WriteStringValue(requestObject.CodecProfile);
            }

            if(requestObject.IsSetCodingMode())
            {
                context.Writer.WritePropertyName("codingMode");
                context.Writer.WriteStringValue(requestObject.CodingMode);
            }

            if(requestObject.IsSetLoudnessMeasurementMode())
            {
                context.Writer.WritePropertyName("loudnessMeasurementMode");
                context.Writer.WriteStringValue(requestObject.LoudnessMeasurementMode);
            }

            if(requestObject.IsSetRapInterval())
            {
                context.Writer.WritePropertyName("rapInterval");
                context.Writer.WriteNumberValue(requestObject.RapInterval.Value);
            }

            if(requestObject.IsSetRateControlMode())
            {
                context.Writer.WritePropertyName("rateControlMode");
                context.Writer.WriteStringValue(requestObject.RateControlMode);
            }

            if(requestObject.IsSetRawFormat())
            {
                context.Writer.WritePropertyName("rawFormat");
                context.Writer.WriteStringValue(requestObject.RawFormat);
            }

            if(requestObject.IsSetSampleRate())
            {
                context.Writer.WritePropertyName("sampleRate");
                context.Writer.WriteNumberValue(requestObject.SampleRate.Value);
            }

            if(requestObject.IsSetSpecification())
            {
                context.Writer.WritePropertyName("specification");
                context.Writer.WriteStringValue(requestObject.Specification);
            }

            if(requestObject.IsSetTargetLoudnessRange())
            {
                context.Writer.WritePropertyName("targetLoudnessRange");
                context.Writer.WriteNumberValue(requestObject.TargetLoudnessRange.Value);
            }

            if(requestObject.IsSetVbrQuality())
            {
                context.Writer.WritePropertyName("vbrQuality");
                context.Writer.WriteStringValue(requestObject.VbrQuality);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AacSettingsMarshaller Instance = new AacSettingsMarshaller();

    }
}