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
    /// GetDocumentVersion Request Marshaller
    /// </summary>       
    public class GetDocumentVersionRequestMarshaller : IMarshaller<IRequest, GetDocumentVersionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetDocumentVersionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetDocumentVersionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.WorkDocs");
            request.HttpMethod = "GET";

            string uriResourcePath = "/api/v1/documents/{DocumentId}/versions/{VersionId}";
            if (!publicRequest.IsSetDocumentId())
                throw new AmazonWorkDocsException("Request object does not have required field DocumentId set");
            uriResourcePath = uriResourcePath.Replace("{DocumentId}", StringUtils.FromString(publicRequest.DocumentId));
            if (!publicRequest.IsSetVersionId())
                throw new AmazonWorkDocsException("Request object does not have required field VersionId set");
            uriResourcePath = uriResourcePath.Replace("{VersionId}", StringUtils.FromString(publicRequest.VersionId));
            
            if (publicRequest.IsSetFields())
                request.Parameters.Add("fields", StringUtils.FromString(publicRequest.Fields));
            
            if (publicRequest.IsSetIncludeCustomMetadata())
                request.Parameters.Add("includeCustomMetadata", StringUtils.FromBool(publicRequest.IncludeCustomMetadata));
            request.ResourcePath = uriResourcePath;
        
            if(publicRequest.IsSetAuthenticationToken())
                request.Headers["Authentication"] = publicRequest.AuthenticationToken;
            request.UseQueryString = true;

            return request;
        }
        private static GetDocumentVersionRequestMarshaller _instance = new GetDocumentVersionRequestMarshaller();        

        internal static GetDocumentVersionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetDocumentVersionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}