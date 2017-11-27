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
    /// CaptionSourceSettings Marshaller
    /// </summary>       
    public class CaptionSourceSettingsMarshaller : IRequestMarshaller<CaptionSourceSettings, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CaptionSourceSettings requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAncillarySourceSettings())
            {
                context.Writer.WritePropertyName("ancillarySourceSettings");
                context.Writer.WriteObjectStart();

                var marshaller = AncillarySourceSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.AncillarySourceSettings, context);

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

            if(requestObject.IsSetFileSourceSettings())
            {
                context.Writer.WritePropertyName("fileSourceSettings");
                context.Writer.WriteObjectStart();

                var marshaller = FileSourceSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.FileSourceSettings, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSourceType())
            {
                context.Writer.WritePropertyName("sourceType");
                context.Writer.Write(requestObject.SourceType);
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
        public readonly static CaptionSourceSettingsMarshaller Instance = new CaptionSourceSettingsMarshaller();

    }
}