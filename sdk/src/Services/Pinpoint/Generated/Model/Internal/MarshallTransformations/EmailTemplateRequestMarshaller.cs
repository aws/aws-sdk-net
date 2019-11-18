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
using ThirdParty.Json.LitJson;

namespace Amazon.Pinpoint.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// EmailTemplateRequest Marshaller
    /// </summary>       
    public class EmailTemplateRequestMarshaller : IRequestMarshaller<EmailTemplateRequest, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(EmailTemplateRequest requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetDefaultSubstitutions())
            {
                context.Writer.WritePropertyName("DefaultSubstitutions");
                context.Writer.Write(requestObject.DefaultSubstitutions);
            }

            if(requestObject.IsSetHtmlPart())
            {
                context.Writer.WritePropertyName("HtmlPart");
                context.Writer.Write(requestObject.HtmlPart);
            }

            if(requestObject.IsSetSubject())
            {
                context.Writer.WritePropertyName("Subject");
                context.Writer.Write(requestObject.Subject);
            }

            if(requestObject.IsSetTags())
            {
                context.Writer.WritePropertyName("tags");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectTagsKvp in requestObject.Tags)
                {
                    context.Writer.WritePropertyName(requestObjectTagsKvp.Key);
                    var requestObjectTagsValue = requestObjectTagsKvp.Value;

                        context.Writer.Write(requestObjectTagsValue);
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetTemplateDescription())
            {
                context.Writer.WritePropertyName("TemplateDescription");
                context.Writer.Write(requestObject.TemplateDescription);
            }

            if(requestObject.IsSetTextPart())
            {
                context.Writer.WritePropertyName("TextPart");
                context.Writer.Write(requestObject.TextPart);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static EmailTemplateRequestMarshaller Instance = new EmailTemplateRequestMarshaller();

    }
}