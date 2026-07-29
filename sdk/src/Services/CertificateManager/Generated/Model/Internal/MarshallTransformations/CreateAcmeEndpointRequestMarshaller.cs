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
 * Do not modify this file. This file is generated from the acm-2015-12-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CertificateManager.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618
namespace Amazon.CertificateManager.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateAcmeEndpoint Request Marshaller
    /// </summary>       
    public class CreateAcmeEndpointRequestMarshaller : IMarshaller<IRequest, CreateAcmeEndpointRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateAcmeEndpointRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateAcmeEndpointRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CertificateManager");
            string target = "CertificateManager.CreateAcmeEndpoint";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-12-08";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAuthorizationBehavior())
            {
                context.Writer.WritePropertyName("AuthorizationBehavior");
                context.Writer.WriteStringValue(publicRequest.AuthorizationBehavior);
            }

            if(publicRequest.IsSetCertificateAuthority())
            {
                context.Writer.WritePropertyName("CertificateAuthority");
                context.Writer.WriteStartObject();

                var marshaller = CertificateAuthorityMarshaller.Instance;
                marshaller.Marshall(publicRequest.CertificateAuthority, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetCertificateTags())
            {
                context.Writer.WritePropertyName("CertificateTags");
                context.Writer.WriteStartArray();
                foreach(var publicRequestCertificateTagsListValue in publicRequest.CertificateTags)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = TagMarshaller.Instance;
                    marshaller.Marshall(publicRequestCertificateTagsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetContact())
            {
                context.Writer.WritePropertyName("Contact");
                context.Writer.WriteStringValue(publicRequest.Contact);
            }

            if(publicRequest.IsSetIdempotencyToken())
            {
                context.Writer.WritePropertyName("IdempotencyToken");
                context.Writer.WriteStringValue(publicRequest.IdempotencyToken);
            }

            else if(!(publicRequest.IsSetIdempotencyToken()))
            {
                context.Writer.WritePropertyName("IdempotencyToken");
                context.Writer.WriteStringValue(Guid.NewGuid().ToString());
            }
            if(publicRequest.IsSetTags())
            {
                context.Writer.WritePropertyName("Tags");
                context.Writer.WriteStartArray();
                foreach(var publicRequestTagsListValue in publicRequest.Tags)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = TagMarshaller.Instance;
                    marshaller.Marshall(publicRequestTagsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif
            


            return request;
        }
        private static CreateAcmeEndpointRequestMarshaller _instance = new CreateAcmeEndpointRequestMarshaller();        

        internal static CreateAcmeEndpointRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateAcmeEndpointRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}