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
 * Do not modify this file. This file is generated from the workdocs-2016-05-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.WorkDocs.Model;
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
namespace Amazon.WorkDocs.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateComment Request Marshaller
    /// </summary>       
    public class CreateCommentRequestMarshaller : IMarshaller<IRequest, CreateCommentRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateCommentRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateCommentRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.WorkDocs");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-05-01";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetDocumentId())
                throw new AmazonWorkDocsException("Request object does not have required field DocumentId set");
            request.AddPathResource("{DocumentId}", StringUtils.FromString(publicRequest.DocumentId));
            if (!publicRequest.IsSetVersionId())
                throw new AmazonWorkDocsException("Request object does not have required field VersionId set");
            request.AddPathResource("{VersionId}", StringUtils.FromString(publicRequest.VersionId));
            request.ResourcePath = "/api/v1/documents/{DocumentId}/versions/{VersionId}/comment";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetNotifyCollaborators())
            {
                context.Writer.WritePropertyName("NotifyCollaborators");
                context.Writer.WriteBooleanValue(publicRequest.NotifyCollaborators.Value);
            }

            if(publicRequest.IsSetParentId())
            {
                context.Writer.WritePropertyName("ParentId");
                context.Writer.WriteStringValue(publicRequest.ParentId);
            }

            if(publicRequest.IsSetText())
            {
                context.Writer.WritePropertyName("Text");
                context.Writer.WriteStringValue(publicRequest.Text);
            }

            if(publicRequest.IsSetThreadId())
            {
                context.Writer.WritePropertyName("ThreadId");
                context.Writer.WriteStringValue(publicRequest.ThreadId);
            }

            if(publicRequest.IsSetVisibility())
            {
                context.Writer.WritePropertyName("Visibility");
                context.Writer.WriteStringValue(publicRequest.Visibility);
            }

            writer.WriteEndObject();
            writer.Flush();
            // ToArray() must be called here because aspects of sigv4 signing require a byte array
#if !NETFRAMEWORK
            request.Content = arrayPoolBufferWriter.WrittenMemory.ToArray();
#else
            request.Content = memoryStream.ToArray();
#endif
            

        
            if (publicRequest.IsSetAuthenticationToken()) 
            {
                request.Headers["Authentication"] = publicRequest.AuthenticationToken;
            }

            return request;
        }
        private static CreateCommentRequestMarshaller _instance = new CreateCommentRequestMarshaller();        

        internal static CreateCommentRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateCommentRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}