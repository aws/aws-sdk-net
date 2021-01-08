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
 * Do not modify this file. This file is generated from the codeartifact-2018-09-22.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CodeArtifact.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CodeArtifact.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PutRepositoryPermissionsPolicy Request Marshaller
    /// </summary>       
    public class PutRepositoryPermissionsPolicyRequestMarshaller : IMarshaller<IRequest, PutRepositoryPermissionsPolicyRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutRepositoryPermissionsPolicyRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutRepositoryPermissionsPolicyRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CodeArtifact");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-09-22";            
            request.HttpMethod = "PUT";

            
            if (publicRequest.IsSetDomain())
                request.Parameters.Add("domain", StringUtils.FromString(publicRequest.Domain));
            
            if (publicRequest.IsSetDomainOwner())
                request.Parameters.Add("domain-owner", StringUtils.FromString(publicRequest.DomainOwner));
            
            if (publicRequest.IsSetRepository())
                request.Parameters.Add("repository", StringUtils.FromString(publicRequest.Repository));
            request.ResourcePath = "/v1/repository/permissions/policy";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetPolicyDocument())
                {
                    context.Writer.WritePropertyName("policyDocument");
                    context.Writer.Write(publicRequest.PolicyDocument);
                }

                if(publicRequest.IsSetPolicyRevision())
                {
                    context.Writer.WritePropertyName("policyRevision");
                    context.Writer.Write(publicRequest.PolicyRevision);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }

            request.UseQueryString = true;

            return request;
        }
        private static PutRepositoryPermissionsPolicyRequestMarshaller _instance = new PutRepositoryPermissionsPolicyRequestMarshaller();        

        internal static PutRepositoryPermissionsPolicyRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutRepositoryPermissionsPolicyRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}