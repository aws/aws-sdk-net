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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Pinpoint.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Pinpoint.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Message Marshaller
    /// </summary>
    public class MessageMarshaller : IRequestMarshaller<Message, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Message requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAction())
            {
                context.Writer.WritePropertyName("Action");
                context.Writer.WriteStringValue(requestObject.Action);
            }

            if(requestObject.IsSetBody())
            {
                context.Writer.WritePropertyName("Body");
                context.Writer.WriteStringValue(requestObject.Body);
            }

            if(requestObject.IsSetImageIconUrl())
            {
                context.Writer.WritePropertyName("ImageIconUrl");
                context.Writer.WriteStringValue(requestObject.ImageIconUrl);
            }

            if(requestObject.IsSetImageSmallIconUrl())
            {
                context.Writer.WritePropertyName("ImageSmallIconUrl");
                context.Writer.WriteStringValue(requestObject.ImageSmallIconUrl);
            }

            if(requestObject.IsSetImageUrl())
            {
                context.Writer.WritePropertyName("ImageUrl");
                context.Writer.WriteStringValue(requestObject.ImageUrl);
            }

            if(requestObject.IsSetJsonBody())
            {
                context.Writer.WritePropertyName("JsonBody");
                context.Writer.WriteStringValue(requestObject.JsonBody);
            }

            if(requestObject.IsSetMediaUrl())
            {
                context.Writer.WritePropertyName("MediaUrl");
                context.Writer.WriteStringValue(requestObject.MediaUrl);
            }

            if(requestObject.IsSetRawContent())
            {
                context.Writer.WritePropertyName("RawContent");
                context.Writer.WriteStringValue(requestObject.RawContent);
            }

            if(requestObject.IsSetSilentPush())
            {
                context.Writer.WritePropertyName("SilentPush");
                context.Writer.WriteBooleanValue(requestObject.SilentPush.Value);
            }

            if(requestObject.IsSetTimeToLive())
            {
                context.Writer.WritePropertyName("TimeToLive");
                context.Writer.WriteNumberValue(requestObject.TimeToLive.Value);
            }

            if(requestObject.IsSetTitle())
            {
                context.Writer.WritePropertyName("Title");
                context.Writer.WriteStringValue(requestObject.Title);
            }

            if(requestObject.IsSetUrl())
            {
                context.Writer.WritePropertyName("Url");
                context.Writer.WriteStringValue(requestObject.Url);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static MessageMarshaller Instance = new MessageMarshaller();

    }
}