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

namespace Amazon.MediaLive.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// EmbeddedSourceSettings Marshaller
    /// </summary>       
    public class EmbeddedSourceSettingsMarshaller : IRequestMarshaller<EmbeddedSourceSettings, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(EmbeddedSourceSettings requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetConvert608To708())
            {
                context.Writer.WritePropertyName("convert608To708");
                context.Writer.Write(requestObject.Convert608To708);
            }

            if(requestObject.IsSetScte20Detection())
            {
                context.Writer.WritePropertyName("scte20Detection");
                context.Writer.Write(requestObject.Scte20Detection);
            }

            if(requestObject.IsSetSource608ChannelNumber())
            {
                context.Writer.WritePropertyName("source608ChannelNumber");
                context.Writer.Write(requestObject.Source608ChannelNumber);
            }

            if(requestObject.IsSetSource608TrackNumber())
            {
                context.Writer.WritePropertyName("source608TrackNumber");
                context.Writer.Write(requestObject.Source608TrackNumber);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static EmbeddedSourceSettingsMarshaller Instance = new EmbeddedSourceSettingsMarshaller();

    }
}