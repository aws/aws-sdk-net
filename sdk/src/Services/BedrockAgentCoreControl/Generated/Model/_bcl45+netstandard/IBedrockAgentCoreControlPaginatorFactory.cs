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
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// Paginators for the BedrockAgentCoreControl service
    ///</summary>
    public interface IBedrockAgentCoreControlPaginatorFactory
    {

        /// <summary>
        /// Paginator for ListAgentRuntimeEndpoints operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListAgentRuntimeEndpointsPaginator ListAgentRuntimeEndpoints(ListAgentRuntimeEndpointsRequest request);

        /// <summary>
        /// Paginator for ListAgentRuntimes operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListAgentRuntimesPaginator ListAgentRuntimes(ListAgentRuntimesRequest request);

        /// <summary>
        /// Paginator for ListAgentRuntimeVersions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListAgentRuntimeVersionsPaginator ListAgentRuntimeVersions(ListAgentRuntimeVersionsRequest request);

        /// <summary>
        /// Paginator for ListApiKeyCredentialProviders operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListApiKeyCredentialProvidersPaginator ListApiKeyCredentialProviders(ListApiKeyCredentialProvidersRequest request);

        /// <summary>
        /// Paginator for ListBrowsers operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListBrowsersPaginator ListBrowsers(ListBrowsersRequest request);

        /// <summary>
        /// Paginator for ListCodeInterpreters operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListCodeInterpretersPaginator ListCodeInterpreters(ListCodeInterpretersRequest request);

        /// <summary>
        /// Paginator for ListGateways operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListGatewaysPaginator ListGateways(ListGatewaysRequest request);

        /// <summary>
        /// Paginator for ListGatewayTargets operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListGatewayTargetsPaginator ListGatewayTargets(ListGatewayTargetsRequest request);

        /// <summary>
        /// Paginator for ListMemories operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListMemoriesPaginator ListMemories(ListMemoriesRequest request);

        /// <summary>
        /// Paginator for ListOauth2CredentialProviders operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListOauth2CredentialProvidersPaginator ListOauth2CredentialProviders(ListOauth2CredentialProvidersRequest request);

        /// <summary>
        /// Paginator for ListWorkloadIdentities operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListWorkloadIdentitiesPaginator ListWorkloadIdentities(ListWorkloadIdentitiesRequest request);
    }
}