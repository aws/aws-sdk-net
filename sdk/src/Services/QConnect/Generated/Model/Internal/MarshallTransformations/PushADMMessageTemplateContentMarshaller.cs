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
 * Do not modify this file. This file is generated from the qconnect-2020-10-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.QConnect.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.QConnect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PushADMMessageTemplateContent Marshaller
    /// </summary>
    public class PushADMMessageTemplateContentMarshaller : IRequestMarshaller<PushADMMessageTemplateContent, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(PushADMMessageTemplateContent requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAction())
            {
                context.Writer.WritePropertyName("action");
                context.Writer.Write(requestObject.Action);
            }

            if(requestObject.IsSetBody())
            {
                context.Writer.WritePropertyName("body");
                context.Writer.WriteObjectStart();

                var marshaller = MessageTemplateBodyContentProviderMarshaller.Instance;
                marshaller.Marshall(requestObject.Body, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetImageIconUrl())
            {
                context.Writer.WritePropertyName("imageIconUrl");
                context.Writer.Write(requestObject.ImageIconUrl);
            }

            if(requestObject.IsSetImageUrl())
            {
                context.Writer.WritePropertyName("imageUrl");
                context.Writer.Write(requestObject.ImageUrl);
            }

            if(requestObject.IsSetRawContent())
            {
                context.Writer.WritePropertyName("rawContent");
                context.Writer.WriteObjectStart();

                var marshaller = MessageTemplateBodyContentProviderMarshaller.Instance;
                marshaller.Marshall(requestObject.RawContent, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSmallImageIconUrl())
            {
                context.Writer.WritePropertyName("smallImageIconUrl");
                context.Writer.Write(requestObject.SmallImageIconUrl);
            }

            if(requestObject.IsSetSound())
            {
                context.Writer.WritePropertyName("sound");
                context.Writer.Write(requestObject.Sound);
            }

            if(requestObject.IsSetTitle())
            {
                context.Writer.WritePropertyName("title");
                context.Writer.Write(requestObject.Title);
            }

            if(requestObject.IsSetUrl())
            {
                context.Writer.WritePropertyName("url");
                context.Writer.Write(requestObject.Url);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static PushADMMessageTemplateContentMarshaller Instance = new PushADMMessageTemplateContentMarshaller();

    }
}