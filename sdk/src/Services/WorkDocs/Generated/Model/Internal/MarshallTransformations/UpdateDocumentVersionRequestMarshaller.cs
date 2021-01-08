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
using ThirdParty.Json.LitJson;

namespace Amazon.WorkDocs.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateDocumentVersion Request Marshaller
    /// </summary>       
    public class UpdateDocumentVersionRequestMarshaller : IMarshaller<IRequest, UpdateDocumentVersionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateDocumentVersionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateDocumentVersionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.WorkDocs");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-05-01";            
            request.HttpMethod = "PATCH";

            if (!publicRequest.IsSetDocumentId())
                throw new AmazonWorkDocsException("Request object does not have required field DocumentId set");
            request.AddPathResource("{DocumentId}", StringUtils.FromString(publicRequest.DocumentId));
            if (!publicRequest.IsSetVersionId())
                throw new AmazonWorkDocsException("Request object does not have required field VersionId set");
            request.AddPathResource("{VersionId}", StringUtils.FromString(publicRequest.VersionId));
            request.ResourcePath = "/api/v1/documents/{DocumentId}/versions/{VersionId}";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetVersionStatus())
                {
                    context.Writer.WritePropertyName("VersionStatus");
                    context.Writer.Write(publicRequest.VersionStatus);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }

        
            if(publicRequest.IsSetAuthenticationToken())
                request.Headers["Authentication"] = publicRequest.AuthenticationToken;

            return request;
        }
        private static UpdateDocumentVersionRequestMarshaller _instance = new UpdateDocumentVersionRequestMarshaller();        

        internal static UpdateDocumentVersionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateDocumentVersionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}