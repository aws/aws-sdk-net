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
 * Do not modify this file. This file is generated from the socialmessaging-2024-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SocialMessaging.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.SocialMessaging.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateWhatsAppMessageTemplate Request Marshaller
    /// </summary>       
    public class UpdateWhatsAppMessageTemplateRequestMarshaller : IMarshaller<IRequest, UpdateWhatsAppMessageTemplateRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateWhatsAppMessageTemplateRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateWhatsAppMessageTemplateRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SocialMessaging");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2024-01-01";
            request.HttpMethod = "POST";

            request.ResourcePath = "/v1/whatsapp/template";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetCtaUrlLinkTrackingOptedOut())
                {
                    context.Writer.WritePropertyName("ctaUrlLinkTrackingOptedOut");
                    context.Writer.Write(publicRequest.CtaUrlLinkTrackingOptedOut);
                }

                if(publicRequest.IsSetId())
                {
                    context.Writer.WritePropertyName("id");
                    context.Writer.Write(publicRequest.Id);
                }

                if(publicRequest.IsSetMetaTemplateId())
                {
                    context.Writer.WritePropertyName("metaTemplateId");
                    context.Writer.Write(publicRequest.MetaTemplateId);
                }

                if(publicRequest.IsSetParameterFormat())
                {
                    context.Writer.WritePropertyName("parameterFormat");
                    context.Writer.Write(publicRequest.ParameterFormat);
                }

                if(publicRequest.IsSetTemplateCategory())
                {
                    context.Writer.WritePropertyName("templateCategory");
                    context.Writer.Write(publicRequest.TemplateCategory);
                }

                if(publicRequest.IsSetTemplateComponents())
                {
                    context.Writer.WritePropertyName("templateComponents");
                    context.Writer.Write(StringUtils.FromMemoryStream(publicRequest.TemplateComponents));
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateWhatsAppMessageTemplateRequestMarshaller _instance = new UpdateWhatsAppMessageTemplateRequestMarshaller();        

        internal static UpdateWhatsAppMessageTemplateRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateWhatsAppMessageTemplateRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}