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
    /// EmailMessageTemplateContent Marshaller
    /// </summary>
    public class EmailMessageTemplateContentMarshaller : IRequestMarshaller<EmailMessageTemplateContent, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(EmailMessageTemplateContent requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetBody())
            {
                context.Writer.WritePropertyName("body");
                context.Writer.WriteObjectStart();

                var marshaller = EmailMessageTemplateContentBodyMarshaller.Instance;
                marshaller.Marshall(requestObject.Body, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetHeaders())
            {
                context.Writer.WritePropertyName("headers");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectHeadersListValue in requestObject.Headers)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = EmailHeaderMarshaller.Instance;
                    marshaller.Marshall(requestObjectHeadersListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetSubject())
            {
                context.Writer.WritePropertyName("subject");
                context.Writer.Write(requestObject.Subject);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static EmailMessageTemplateContentMarshaller Instance = new EmailMessageTemplateContentMarshaller();

    }
}