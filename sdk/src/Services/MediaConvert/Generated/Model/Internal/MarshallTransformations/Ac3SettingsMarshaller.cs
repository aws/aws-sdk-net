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
    /// Ac3Settings Marshaller
    /// </summary>
    public class Ac3SettingsMarshaller : IRequestMarshaller<Ac3Settings, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Ac3Settings requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetBitrate())
            {
                context.Writer.WritePropertyName("bitrate");
                context.Writer.WriteNumberValue(requestObject.Bitrate.Value);
            }

            if(requestObject.IsSetBitstreamMode())
            {
                context.Writer.WritePropertyName("bitstreamMode");
                context.Writer.WriteStringValue(requestObject.BitstreamMode);
            }

            if(requestObject.IsSetCodingMode())
            {
                context.Writer.WritePropertyName("codingMode");
                context.Writer.WriteStringValue(requestObject.CodingMode);
            }

            if(requestObject.IsSetDialnorm())
            {
                context.Writer.WritePropertyName("dialnorm");
                context.Writer.WriteNumberValue(requestObject.Dialnorm.Value);
            }

            if(requestObject.IsSetDynamicRangeCompressionLine())
            {
                context.Writer.WritePropertyName("dynamicRangeCompressionLine");
                context.Writer.WriteStringValue(requestObject.DynamicRangeCompressionLine);
            }

            if(requestObject.IsSetDynamicRangeCompressionProfile())
            {
                context.Writer.WritePropertyName("dynamicRangeCompressionProfile");
                context.Writer.WriteStringValue(requestObject.DynamicRangeCompressionProfile);
            }

            if(requestObject.IsSetDynamicRangeCompressionRf())
            {
                context.Writer.WritePropertyName("dynamicRangeCompressionRf");
                context.Writer.WriteStringValue(requestObject.DynamicRangeCompressionRf);
            }

            if(requestObject.IsSetLfeFilter())
            {
                context.Writer.WritePropertyName("lfeFilter");
                context.Writer.WriteStringValue(requestObject.LfeFilter);
            }

            if(requestObject.IsSetMetadataControl())
            {
                context.Writer.WritePropertyName("metadataControl");
                context.Writer.WriteStringValue(requestObject.MetadataControl);
            }

            if(requestObject.IsSetSampleRate())
            {
                context.Writer.WritePropertyName("sampleRate");
                context.Writer.WriteNumberValue(requestObject.SampleRate.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static Ac3SettingsMarshaller Instance = new Ac3SettingsMarshaller();

    }
}