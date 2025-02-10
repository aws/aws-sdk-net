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
 * Do not modify this file. This file is generated from the grafana-2020-08-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ManagedGrafana.Model;
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
namespace Amazon.ManagedGrafana.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListWorkspaceServiceAccountTokens Request Marshaller
    /// </summary>       
    public class ListWorkspaceServiceAccountTokensRequestMarshaller : IMarshaller<IRequest, ListWorkspaceServiceAccountTokensRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListWorkspaceServiceAccountTokensRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListWorkspaceServiceAccountTokensRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ManagedGrafana");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-08-18";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetServiceAccountId())
                throw new AmazonManagedGrafanaException("Request object does not have required field ServiceAccountId set");
            request.AddPathResource("{serviceAccountId}", StringUtils.FromString(publicRequest.ServiceAccountId));
            if (!publicRequest.IsSetWorkspaceId())
                throw new AmazonManagedGrafanaException("Request object does not have required field WorkspaceId set");
            request.AddPathResource("{workspaceId}", StringUtils.FromString(publicRequest.WorkspaceId));
            
            if (publicRequest.IsSetMaxResults())
                request.Parameters.Add("maxResults", StringUtils.FromInt(publicRequest.MaxResults));
            
            if (publicRequest.IsSetNextToken())
                request.Parameters.Add("nextToken", StringUtils.FromString(publicRequest.NextToken));
            request.ResourcePath = "/workspaces/{workspaceId}/serviceaccounts/{serviceAccountId}/tokens";
            request.UseQueryString = true;

            return request;
        }
        private static ListWorkspaceServiceAccountTokensRequestMarshaller _instance = new ListWorkspaceServiceAccountTokensRequestMarshaller();        

        internal static ListWorkspaceServiceAccountTokensRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListWorkspaceServiceAccountTokensRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}