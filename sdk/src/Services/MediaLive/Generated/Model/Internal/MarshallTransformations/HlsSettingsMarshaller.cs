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
    /// HlsSettings Marshaller
    /// </summary>
    public class HlsSettingsMarshaller : IRequestMarshaller<HlsSettings, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(HlsSettings requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAudioOnlyHlsSettings())
            {
                context.Writer.WritePropertyName("audioOnlyHlsSettings");
                context.Writer.WriteStartObject();

                var marshaller = AudioOnlyHlsSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.AudioOnlyHlsSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetFmp4HlsSettings())
            {
                context.Writer.WritePropertyName("fmp4HlsSettings");
                context.Writer.WriteStartObject();

                var marshaller = Fmp4HlsSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.Fmp4HlsSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetFrameCaptureHlsSettings())
            {
                context.Writer.WritePropertyName("frameCaptureHlsSettings");
                context.Writer.WriteStartObject();

                var marshaller = FrameCaptureHlsSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.FrameCaptureHlsSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetStandardHlsSettings())
            {
                context.Writer.WritePropertyName("standardHlsSettings");
                context.Writer.WriteStartObject();

                var marshaller = StandardHlsSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.StandardHlsSettings, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static HlsSettingsMarshaller Instance = new HlsSettingsMarshaller();

    }
}