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
    /// HlsCdnSettings Marshaller
    /// </summary>       
    public class HlsCdnSettingsMarshaller : IRequestMarshaller<HlsCdnSettings, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(HlsCdnSettings requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetHlsAkamaiSettings())
            {
                context.Writer.WritePropertyName("hlsAkamaiSettings");
                context.Writer.WriteObjectStart();

                var marshaller = HlsAkamaiSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.HlsAkamaiSettings, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetHlsBasicPutSettings())
            {
                context.Writer.WritePropertyName("hlsBasicPutSettings");
                context.Writer.WriteObjectStart();

                var marshaller = HlsBasicPutSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.HlsBasicPutSettings, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetHlsMediaStoreSettings())
            {
                context.Writer.WritePropertyName("hlsMediaStoreSettings");
                context.Writer.WriteObjectStart();

                var marshaller = HlsMediaStoreSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.HlsMediaStoreSettings, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetHlsWebdavSettings())
            {
                context.Writer.WritePropertyName("hlsWebdavSettings");
                context.Writer.WriteObjectStart();

                var marshaller = HlsWebdavSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.HlsWebdavSettings, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static HlsCdnSettingsMarshaller Instance = new HlsCdnSettingsMarshaller();

    }
}