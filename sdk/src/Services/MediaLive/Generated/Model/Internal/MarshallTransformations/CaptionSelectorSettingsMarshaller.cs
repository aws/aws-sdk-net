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
    /// CaptionSelectorSettings Marshaller
    /// </summary>       
    public class CaptionSelectorSettingsMarshaller : IRequestMarshaller<CaptionSelectorSettings, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CaptionSelectorSettings requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAribSourceSettings())
            {
                context.Writer.WritePropertyName("aribSourceSettings");
                context.Writer.WriteObjectStart();

                var marshaller = AribSourceSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.AribSourceSettings, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetDvbSubSourceSettings())
            {
                context.Writer.WritePropertyName("dvbSubSourceSettings");
                context.Writer.WriteObjectStart();

                var marshaller = DvbSubSourceSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.DvbSubSourceSettings, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetEmbeddedSourceSettings())
            {
                context.Writer.WritePropertyName("embeddedSourceSettings");
                context.Writer.WriteObjectStart();

                var marshaller = EmbeddedSourceSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.EmbeddedSourceSettings, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetScte20SourceSettings())
            {
                context.Writer.WritePropertyName("scte20SourceSettings");
                context.Writer.WriteObjectStart();

                var marshaller = Scte20SourceSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.Scte20SourceSettings, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetScte27SourceSettings())
            {
                context.Writer.WritePropertyName("scte27SourceSettings");
                context.Writer.WriteObjectStart();

                var marshaller = Scte27SourceSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.Scte27SourceSettings, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetTeletextSourceSettings())
            {
                context.Writer.WritePropertyName("teletextSourceSettings");
                context.Writer.WriteObjectStart();

                var marshaller = TeletextSourceSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.TeletextSourceSettings, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static CaptionSelectorSettingsMarshaller Instance = new CaptionSelectorSettingsMarshaller();

    }
}