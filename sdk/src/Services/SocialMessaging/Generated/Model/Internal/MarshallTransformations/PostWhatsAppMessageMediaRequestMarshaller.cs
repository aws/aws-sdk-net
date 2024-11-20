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
    /// PostWhatsAppMessageMedia Request Marshaller
    /// </summary>       
    public class PostWhatsAppMessageMediaRequestMarshaller : IMarshaller<IRequest, PostWhatsAppMessageMediaRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PostWhatsAppMessageMediaRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PostWhatsAppMessageMediaRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SocialMessaging");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2024-01-01";
            request.HttpMethod = "POST";

            request.ResourcePath = "/v1/whatsapp/media";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetOriginationPhoneNumberId())
                {
                    context.Writer.WritePropertyName("originationPhoneNumberId");
                    context.Writer.Write(publicRequest.OriginationPhoneNumberId);
                }

                if(publicRequest.IsSetSourceS3File())
                {
                    context.Writer.WritePropertyName("sourceS3File");
                    context.Writer.WriteObjectStart();

                    var marshaller = S3FileMarshaller.Instance;
                    marshaller.Marshall(publicRequest.SourceS3File, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetSourceS3PresignedUrl())
                {
                    context.Writer.WritePropertyName("sourceS3PresignedUrl");
                    context.Writer.WriteObjectStart();

                    var marshaller = S3PresignedUrlMarshaller.Instance;
                    marshaller.Marshall(publicRequest.SourceS3PresignedUrl, context);

                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static PostWhatsAppMessageMediaRequestMarshaller _instance = new PostWhatsAppMessageMediaRequestMarshaller();        

        internal static PostWhatsAppMessageMediaRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PostWhatsAppMessageMediaRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}