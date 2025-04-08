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
    /// Smpte2110ReceiverGroupSdpSettings Marshaller
    /// </summary>
    public class Smpte2110ReceiverGroupSdpSettingsMarshaller : IRequestMarshaller<Smpte2110ReceiverGroupSdpSettings, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Smpte2110ReceiverGroupSdpSettings requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAncillarySdps())
            {
                context.Writer.WritePropertyName("ancillarySdps");
                context.Writer.WriteStartArray();
                foreach(var requestObjectAncillarySdpsListValue in requestObject.AncillarySdps)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = InputSdpLocationMarshaller.Instance;
                    marshaller.Marshall(requestObjectAncillarySdpsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetAudioSdps())
            {
                context.Writer.WritePropertyName("audioSdps");
                context.Writer.WriteStartArray();
                foreach(var requestObjectAudioSdpsListValue in requestObject.AudioSdps)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = InputSdpLocationMarshaller.Instance;
                    marshaller.Marshall(requestObjectAudioSdpsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetVideoSdp())
            {
                context.Writer.WritePropertyName("videoSdp");
                context.Writer.WriteStartObject();

                var marshaller = InputSdpLocationMarshaller.Instance;
                marshaller.Marshall(requestObject.VideoSdp, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static Smpte2110ReceiverGroupSdpSettingsMarshaller Instance = new Smpte2110ReceiverGroupSdpSettingsMarshaller();

    }
}