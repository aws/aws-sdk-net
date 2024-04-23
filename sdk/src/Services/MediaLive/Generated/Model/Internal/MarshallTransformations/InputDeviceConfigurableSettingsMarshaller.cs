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
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.MediaLive.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// InputDeviceConfigurableSettings Marshaller
    /// </summary>
    public class InputDeviceConfigurableSettingsMarshaller : IRequestMarshaller<InputDeviceConfigurableSettings, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(InputDeviceConfigurableSettings requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAudioChannelPairs())
            {
                context.Writer.WritePropertyName("audioChannelPairs");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectAudioChannelPairsListValue in requestObject.AudioChannelPairs)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = InputDeviceConfigurableAudioChannelPairConfigMarshaller.Instance;
                    marshaller.Marshall(requestObjectAudioChannelPairsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetCodec())
            {
                context.Writer.WritePropertyName("codec");
                context.Writer.Write(requestObject.Codec);
            }

            if(requestObject.IsSetConfiguredInput())
            {
                context.Writer.WritePropertyName("configuredInput");
                context.Writer.Write(requestObject.ConfiguredInput);
            }

            if(requestObject.IsSetLatencyMs())
            {
                context.Writer.WritePropertyName("latencyMs");
                context.Writer.Write(requestObject.LatencyMs);
            }

            if(requestObject.IsSetMaxBitrate())
            {
                context.Writer.WritePropertyName("maxBitrate");
                context.Writer.Write(requestObject.MaxBitrate);
            }

            if(requestObject.IsSetMediaconnectSettings())
            {
                context.Writer.WritePropertyName("mediaconnectSettings");
                context.Writer.WriteObjectStart();

                var marshaller = InputDeviceMediaConnectConfigurableSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.MediaconnectSettings, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static InputDeviceConfigurableSettingsMarshaller Instance = new InputDeviceConfigurableSettingsMarshaller();

    }
}
#pragma warning restore CS0612,CS0618