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
 * Do not modify this file. This file is generated from the sesv2-2019-09-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SimpleEmailV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.SimpleEmailV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Template Marshaller
    /// </summary>
    public class TemplateMarshaller : IRequestMarshaller<Template, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Template requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAttachments())
            {
                context.Writer.WritePropertyName("Attachments");
                context.Writer.WriteStartArray();
                foreach(var requestObjectAttachmentsListValue in requestObject.Attachments)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AttachmentMarshaller.Instance;
                    marshaller.Marshall(requestObjectAttachmentsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetHeaders())
            {
                context.Writer.WritePropertyName("Headers");
                context.Writer.WriteStartArray();
                foreach(var requestObjectHeadersListValue in requestObject.Headers)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = MessageHeaderMarshaller.Instance;
                    marshaller.Marshall(requestObjectHeadersListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetTemplateArn())
            {
                context.Writer.WritePropertyName("TemplateArn");
                context.Writer.WriteStringValue(requestObject.TemplateArn);
            }

            if(requestObject.IsSetTemplateContent())
            {
                context.Writer.WritePropertyName("TemplateContent");
                context.Writer.WriteStartObject();

                var marshaller = EmailTemplateContentMarshaller.Instance;
                marshaller.Marshall(requestObject.TemplateContent, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTemplateData())
            {
                context.Writer.WritePropertyName("TemplateData");
                context.Writer.WriteStringValue(requestObject.TemplateData);
            }

            if(requestObject.IsSetTemplateName())
            {
                context.Writer.WritePropertyName("TemplateName");
                context.Writer.WriteStringValue(requestObject.TemplateName);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static TemplateMarshaller Instance = new TemplateMarshaller();

    }
}