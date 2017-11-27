/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
            if(requestObject.IsSetAudioDescriptionBroadcasterMix())
            {
                context.Writer.WritePropertyName("audioDescriptionBroadcasterMix");
                context.Writer.Write(requestObject.AudioDescriptionBroadcasterMix);
            }

            if(requestObject.IsSetBitrate())
            {
                context.Writer.WritePropertyName("bitrate");
                context.Writer.Write(requestObject.Bitrate);
            }

            if(requestObject.IsSetCodecProfile())
            {
                context.Writer.WritePropertyName("codecProfile");
                context.Writer.Write(requestObject.CodecProfile);
            }

            if(requestObject.IsSetCodingMode())
            {
                context.Writer.WritePropertyName("codingMode");
                context.Writer.Write(requestObject.CodingMode);
            }

            if(requestObject.IsSetRateControlMode())
            {
                context.Writer.WritePropertyName("rateControlMode");
                context.Writer.Write(requestObject.RateControlMode);
            }

            if(requestObject.IsSetRawFormat())
            {
                context.Writer.WritePropertyName("rawFormat");
                context.Writer.Write(requestObject.RawFormat);
            }

            if(requestObject.IsSetSampleRate())
            {
                context.Writer.WritePropertyName("sampleRate");
                context.Writer.Write(requestObject.SampleRate);
            }

            if(requestObject.IsSetSpecification())
            {
                context.Writer.WritePropertyName("specification");
                context.Writer.Write(requestObject.Specification);
            }

            if(requestObject.IsSetVbrQuality())
            {
                context.Writer.WritePropertyName("vbrQuality");
                context.Writer.Write(requestObject.VbrQuality);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static AacSettingsMarshaller Instance = new AacSettingsMarshaller();

    }
}