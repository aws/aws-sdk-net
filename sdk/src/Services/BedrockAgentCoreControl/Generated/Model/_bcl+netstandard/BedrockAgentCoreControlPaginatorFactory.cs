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
 * Do not modify this file. This file is generated from the bedrock-agentcore-control-2023-06-05.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// Paginators for the BedrockAgentCoreControl service
    ///</summary>
    public class BedrockAgentCoreControlPaginatorFactory : IBedrockAgentCoreControlPaginatorFactory
    {
        private readonly IAmazonBedrockAgentCoreControl client;

        internal BedrockAgentCoreControlPaginatorFactory(IAmazonBedrockAgentCoreControl client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListAgentRuntimeEndpoints operation
        ///</summary>
        public IListAgentRuntimeEndpointsPaginator ListAgentRuntimeEndpoints(ListAgentRuntimeEndpointsRequest request) 
        {
            return new ListAgentRuntimeEndpointsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAgentRuntimes operation
        ///</summary>
        public IListAgentRuntimesPaginator ListAgentRuntimes(ListAgentRuntimesRequest request) 
        {
            return new ListAgentRuntimesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAgentRuntimeVersions operation
        ///</summary>
        public IListAgentRuntimeVersionsPaginator ListAgentRuntimeVersions(ListAgentRuntimeVersionsRequest request) 
        {
            return new ListAgentRuntimeVersionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListApiKeyCredentialProviders operation
        ///</summary>
        public IListApiKeyCredentialProvidersPaginator ListApiKeyCredentialProviders(ListApiKeyCredentialProvidersRequest request) 
        {
            return new ListApiKeyCredentialProvidersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListBrowsers operation
        ///</summary>
        public IListBrowsersPaginator ListBrowsers(ListBrowsersRequest request) 
        {
            return new ListBrowsersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListCodeInterpreters operation
        ///</summary>
        public IListCodeInterpretersPaginator ListCodeInterpreters(ListCodeInterpretersRequest request) 
        {
            return new ListCodeInterpretersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListGateways operation
        ///</summary>
        public IListGatewaysPaginator ListGateways(ListGatewaysRequest request) 
        {
            return new ListGatewaysPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListGatewayTargets operation
        ///</summary>
        public IListGatewayTargetsPaginator ListGatewayTargets(ListGatewayTargetsRequest request) 
        {
            return new ListGatewayTargetsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListMemories operation
        ///</summary>
        public IListMemoriesPaginator ListMemories(ListMemoriesRequest request) 
        {
            return new ListMemoriesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListOauth2CredentialProviders operation
        ///</summary>
        public IListOauth2CredentialProvidersPaginator ListOauth2CredentialProviders(ListOauth2CredentialProvidersRequest request) 
        {
            return new ListOauth2CredentialProvidersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListWorkloadIdentities operation
        ///</summary>
        public IListWorkloadIdentitiesPaginator ListWorkloadIdentities(ListWorkloadIdentitiesRequest request) 
        {
            return new ListWorkloadIdentitiesPaginator(this.client, request);
        }
    }
}