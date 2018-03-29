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
using ThirdParty.Json.LitJson;

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
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.HttpMethod = "POST";

            string uriResourcePath = "/api/v1/documents/{DocumentId}/versions/{VersionId}/comment";
            if (!publicRequest.IsSetDocumentId())
                throw new AmazonWorkDocsException("Request object does not have required field DocumentId set");
            uriResourcePath = uriResourcePath.Replace("{DocumentId}", StringUtils.FromString(publicRequest.DocumentId));
            if (!publicRequest.IsSetVersionId())
                throw new AmazonWorkDocsException("Request object does not have required field VersionId set");
            uriResourcePath = uriResourcePath.Replace("{VersionId}", StringUtils.FromString(publicRequest.VersionId));
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetNotifyCollaborators())
                {
                    context.Writer.WritePropertyName("NotifyCollaborators");
                    context.Writer.Write(publicRequest.NotifyCollaborators);
                }

                if(publicRequest.IsSetParentId())
                {
                    context.Writer.WritePropertyName("ParentId");
                    context.Writer.Write(publicRequest.ParentId);
                }

                if(publicRequest.IsSetText())
                {
                    context.Writer.WritePropertyName("Text");
                    context.Writer.Write(publicRequest.Text);
                }

                if(publicRequest.IsSetThreadId())
                {
                    context.Writer.WritePropertyName("ThreadId");
                    context.Writer.Write(publicRequest.ThreadId);
                }

                if(publicRequest.IsSetVisibility())
                {
                    context.Writer.WritePropertyName("Visibility");
                    context.Writer.Write(publicRequest.Visibility);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }

        
            if(publicRequest.IsSetAuthenticationToken())
                request.Headers["Authentication"] = publicRequest.AuthenticationToken;

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