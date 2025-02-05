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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaLive.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.MediaLive.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// WavSettings Marshaller
    /// </summary>
    public class WavSettingsMarshaller : IRequestMarshaller<WavSettings, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(WavSettings requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetBitDepth())
            {
                context.Writer.WritePropertyName("bitDepth");
                if(StringUtils.IsSpecialDoubleValue(requestObject.BitDepth.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.BitDepth.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.BitDepth.Value);
                }
            }

            if(requestObject.IsSetCodingMode())
            {
                context.Writer.WritePropertyName("codingMode");
                context.Writer.WriteStringValue(requestObject.CodingMode);
            }

            if(requestObject.IsSetSampleRate())
            {
                context.Writer.WritePropertyName("sampleRate");
                if(StringUtils.IsSpecialDoubleValue(requestObject.SampleRate.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.SampleRate.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.SampleRate.Value);
                }
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static WavSettingsMarshaller Instance = new WavSettingsMarshaller();

    }
}