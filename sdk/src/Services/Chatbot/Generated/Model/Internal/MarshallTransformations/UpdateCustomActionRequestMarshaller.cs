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
 * Do not modify this file. This file is generated from the chatbot-2017-10-11.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Chatbot.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Chatbot.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateCustomAction Request Marshaller
    /// </summary>       
    public class UpdateCustomActionRequestMarshaller : IMarshaller<IRequest, UpdateCustomActionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateCustomActionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateCustomActionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Chatbot");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-10-11";
            request.HttpMethod = "POST";

            request.ResourcePath = "/update-custom-action";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAliasName())
                {
                    context.Writer.WritePropertyName("AliasName");
                    context.Writer.Write(publicRequest.AliasName);
                }

                if(publicRequest.IsSetAttachments())
                {
                    context.Writer.WritePropertyName("Attachments");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestAttachmentsListValue in publicRequest.Attachments)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = CustomActionAttachmentMarshaller.Instance;
                        marshaller.Marshall(publicRequestAttachmentsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetCustomActionArn())
                {
                    context.Writer.WritePropertyName("CustomActionArn");
                    context.Writer.Write(publicRequest.CustomActionArn);
                }

                if(publicRequest.IsSetDefinition())
                {
                    context.Writer.WritePropertyName("Definition");
                    context.Writer.WriteObjectStart();

                    var marshaller = CustomActionDefinitionMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Definition, context);

                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateCustomActionRequestMarshaller _instance = new UpdateCustomActionRequestMarshaller();        

        internal static UpdateCustomActionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateCustomActionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}