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
using System.Text.Json;
using System.Buffers;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618
namespace Amazon.CodeArtifact.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListPackageVersions Request Marshaller
    /// </summary>       
    public class ListPackageVersionsRequestMarshaller : IMarshaller<IRequest, ListPackageVersionsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListPackageVersionsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListPackageVersionsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CodeArtifact");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-09-22";
            request.HttpMethod = "POST";

            
            if (publicRequest.IsSetDomain())
                request.Parameters.Add("domain", StringUtils.FromString(publicRequest.Domain));
            
            if (publicRequest.IsSetDomainOwner())
                request.Parameters.Add("domain-owner", StringUtils.FromString(publicRequest.DomainOwner));
            
            if (publicRequest.IsSetFormat())
                request.Parameters.Add("format", StringUtils.FromString(publicRequest.Format));
            
            if (publicRequest.IsSetMaxResults())
                request.Parameters.Add("max-results", StringUtils.FromInt(publicRequest.MaxResults));
            
            if (publicRequest.IsSetNamespace())
                request.Parameters.Add("namespace", StringUtils.FromString(publicRequest.Namespace));
            
            if (publicRequest.IsSetNextToken())
                request.Parameters.Add("next-token", StringUtils.FromString(publicRequest.NextToken));
            
            if (publicRequest.IsSetOriginType())
                request.Parameters.Add("originType", StringUtils.FromString(publicRequest.OriginType));
            
            if (publicRequest.IsSetPackage())
                request.Parameters.Add("package", StringUtils.FromString(publicRequest.Package));
            
            if (publicRequest.IsSetRepository())
                request.Parameters.Add("repository", StringUtils.FromString(publicRequest.Repository));
            
            if (publicRequest.IsSetSortBy())
                request.Parameters.Add("sortBy", StringUtils.FromString(publicRequest.SortBy));
            
            if (publicRequest.IsSetStatus())
                request.Parameters.Add("status", StringUtils.FromString(publicRequest.Status));
            request.ResourcePath = "/v1/package/versions";
            request.UseQueryString = true;

            return request;
        }
        private static ListPackageVersionsRequestMarshaller _instance = new ListPackageVersionsRequestMarshaller();        

        internal static ListPackageVersionsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListPackageVersionsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}