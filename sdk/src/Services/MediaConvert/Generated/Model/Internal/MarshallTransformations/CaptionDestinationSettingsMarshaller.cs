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
    /// CaptionDestinationSettings Marshaller
    /// </summary>       
    public class CaptionDestinationSettingsMarshaller : IRequestMarshaller<CaptionDestinationSettings, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CaptionDestinationSettings requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetBurninDestinationSettings())
            {
                context.Writer.WritePropertyName("burninDestinationSettings");
                context.Writer.WriteObjectStart();

                var marshaller = BurninDestinationSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.BurninDestinationSettings, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetDestinationType())
            {
                context.Writer.WritePropertyName("destinationType");
                context.Writer.Write(requestObject.DestinationType);
            }

            if(requestObject.IsSetDvbSubDestinationSettings())
            {
                context.Writer.WritePropertyName("dvbSubDestinationSettings");
                context.Writer.WriteObjectStart();

                var marshaller = DvbSubDestinationSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.DvbSubDestinationSettings, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSccDestinationSettings())
            {
                context.Writer.WritePropertyName("sccDestinationSettings");
                context.Writer.WriteObjectStart();

                var marshaller = SccDestinationSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.SccDestinationSettings, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetTeletextDestinationSettings())
            {
                context.Writer.WritePropertyName("teletextDestinationSettings");
                context.Writer.WriteObjectStart();

                var marshaller = TeletextDestinationSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.TeletextDestinationSettings, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetTtmlDestinationSettings())
            {
                context.Writer.WritePropertyName("ttmlDestinationSettings");
                context.Writer.WriteObjectStart();

                var marshaller = TtmlDestinationSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.TtmlDestinationSettings, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static CaptionDestinationSettingsMarshaller Instance = new CaptionDestinationSettingsMarshaller();

    }
}