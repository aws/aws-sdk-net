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
    /// DeleteDocument Request Marshaller
    /// </summary>       
    public class DeleteDocumentRequestMarshaller : IMarshaller<IRequest, DeleteDocumentRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeleteDocumentRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DeleteDocumentRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.WorkDocs");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-05-01";            
            request.HttpMethod = "DELETE";

            if (!publicRequest.IsSetDocumentId())
                throw new AmazonWorkDocsException("Request object does not have required field DocumentId set");
            request.AddPathResource("{DocumentId}", StringUtils.FromString(publicRequest.DocumentId));
            request.ResourcePath = "/api/v1/documents/{DocumentId}";
            request.MarshallerVersion = 2;
        
            if(publicRequest.IsSetAuthenticationToken())
                request.Headers["Authentication"] = publicRequest.AuthenticationToken;

            return request;
        }
        private static DeleteDocumentRequestMarshaller _instance = new DeleteDocumentRequestMarshaller();        

        internal static DeleteDocumentRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DeleteDocumentRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}