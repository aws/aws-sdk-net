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
    /// DeleteWorkspaceServiceAccount Request Marshaller
    /// </summary>       
    public class DeleteWorkspaceServiceAccountRequestMarshaller : IMarshaller<IRequest, DeleteWorkspaceServiceAccountRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeleteWorkspaceServiceAccountRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DeleteWorkspaceServiceAccountRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ManagedGrafana");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-08-18";
            request.HttpMethod = "DELETE";

            if (!publicRequest.IsSetServiceAccountId())
                throw new AmazonManagedGrafanaException("Request object does not have required field ServiceAccountId set");
            request.AddPathResource("{serviceAccountId}", StringUtils.FromString(publicRequest.ServiceAccountId));
            if (!publicRequest.IsSetWorkspaceId())
                throw new AmazonManagedGrafanaException("Request object does not have required field WorkspaceId set");
            request.AddPathResource("{workspaceId}", StringUtils.FromString(publicRequest.WorkspaceId));
            request.ResourcePath = "/workspaces/{workspaceId}/serviceaccounts/{serviceAccountId}";

            return request;
        }
        private static DeleteWorkspaceServiceAccountRequestMarshaller _instance = new DeleteWorkspaceServiceAccountRequestMarshaller();        

        internal static DeleteWorkspaceServiceAccountRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DeleteWorkspaceServiceAccountRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}