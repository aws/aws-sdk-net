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

namespace Amazon.MediaLive.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// OutputSettings Marshaller
    /// </summary>       
    public class OutputSettingsMarshaller : IRequestMarshaller<OutputSettings, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(OutputSettings requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetArchiveOutputSettings())
            {
                context.Writer.WritePropertyName("archiveOutputSettings");
                context.Writer.WriteObjectStart();

                var marshaller = ArchiveOutputSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.ArchiveOutputSettings, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetHlsOutputSettings())
            {
                context.Writer.WritePropertyName("hlsOutputSettings");
                context.Writer.WriteObjectStart();

                var marshaller = HlsOutputSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.HlsOutputSettings, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetMsSmoothOutputSettings())
            {
                context.Writer.WritePropertyName("msSmoothOutputSettings");
                context.Writer.WriteObjectStart();

                var marshaller = MsSmoothOutputSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.MsSmoothOutputSettings, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetRtmpOutputSettings())
            {
                context.Writer.WritePropertyName("rtmpOutputSettings");
                context.Writer.WriteObjectStart();

                var marshaller = RtmpOutputSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.RtmpOutputSettings, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetUdpOutputSettings())
            {
                context.Writer.WritePropertyName("udpOutputSettings");
                context.Writer.WriteObjectStart();

                var marshaller = UdpOutputSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.UdpOutputSettings, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static OutputSettingsMarshaller Instance = new OutputSettingsMarshaller();

    }
}