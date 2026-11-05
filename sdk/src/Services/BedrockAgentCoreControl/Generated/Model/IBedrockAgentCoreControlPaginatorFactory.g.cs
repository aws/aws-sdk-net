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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618

namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// Paginators for the BedrockAgentCoreControl service
    /// </summary>
    public interface IBedrockAgentCoreControlPaginatorFactory
    {
        /// <summary>
        /// Paginator for ListAgentRuntimeEndpoints operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListAgentRuntimeEndpointsPaginator ListAgentRuntimeEndpoints(ListAgentRuntimeEndpointsRequest request);

        /// <summary>
        /// Paginator for ListAgentRuntimeVersions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListAgentRuntimeVersionsPaginator ListAgentRuntimeVersions(ListAgentRuntimeVersionsRequest request);

        /// <summary>
        /// Paginator for ListAgentRuntimeVersionsByCapacityProvider operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListAgentRuntimeVersionsByCapacityProviderPaginator ListAgentRuntimeVersionsByCapacityProvider(ListAgentRuntimeVersionsByCapacityProviderRequest request);

        /// <summary>
        /// Paginator for ListAgentRuntimes operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListAgentRuntimesPaginator ListAgentRuntimes(ListAgentRuntimesRequest request);

        /// <summary>
        /// Paginator for ListApiKeyCredentialProviders operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListApiKeyCredentialProvidersPaginator ListApiKeyCredentialProviders(ListApiKeyCredentialProvidersRequest request);

        /// <summary>
        /// Paginator for ListBrowserProfiles operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListBrowserProfilesPaginator ListBrowserProfiles(ListBrowserProfilesRequest request);

        /// <summary>
        /// Paginator for ListBrowsers operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListBrowsersPaginator ListBrowsers(ListBrowsersRequest request);

        /// <summary>
        /// Paginator for ListCapacityProviders operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListCapacityProvidersPaginator ListCapacityProviders(ListCapacityProvidersRequest request);

        /// <summary>
        /// Paginator for ListCodeInterpreters operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListCodeInterpretersPaginator ListCodeInterpreters(ListCodeInterpretersRequest request);

        /// <summary>
        /// Paginator for ListConfigurationBundleVersions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListConfigurationBundleVersionsPaginator ListConfigurationBundleVersions(ListConfigurationBundleVersionsRequest request);

        /// <summary>
        /// Paginator for ListConfigurationBundles operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListConfigurationBundlesPaginator ListConfigurationBundles(ListConfigurationBundlesRequest request);

        /// <summary>
        /// Paginator for ListConsentPortals operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListConsentPortalsPaginator ListConsentPortals(ListConsentPortalsRequest request);

        /// <summary>
        /// Paginator for ListDatasetExamples operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListDatasetExamplesPaginator ListDatasetExamples(ListDatasetExamplesRequest request);

        /// <summary>
        /// Paginator for ListDatasetVersions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListDatasetVersionsPaginator ListDatasetVersions(ListDatasetVersionsRequest request);

        /// <summary>
        /// Paginator for ListDatasets operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListDatasetsPaginator ListDatasets(ListDatasetsRequest request);

        /// <summary>
        /// Paginator for ListEvaluators operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListEvaluatorsPaginator ListEvaluators(ListEvaluatorsRequest request);

        /// <summary>
        /// Paginator for ListGatewayRateLimits operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListGatewayRateLimitsPaginator ListGatewayRateLimits(ListGatewayRateLimitsRequest request);

        /// <summary>
        /// Paginator for ListGatewayRules operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListGatewayRulesPaginator ListGatewayRules(ListGatewayRulesRequest request);

        /// <summary>
        /// Paginator for ListGatewayTargets operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListGatewayTargetsPaginator ListGatewayTargets(ListGatewayTargetsRequest request);

        /// <summary>
        /// Paginator for ListGateways operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListGatewaysPaginator ListGateways(ListGatewaysRequest request);

        /// <summary>
        /// Paginator for ListHarnessEndpoints operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListHarnessEndpointsPaginator ListHarnessEndpoints(ListHarnessEndpointsRequest request);

        /// <summary>
        /// Paginator for ListHarnessVersions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListHarnessVersionsPaginator ListHarnessVersions(ListHarnessVersionsRequest request);

        /// <summary>
        /// Paginator for ListHarnesses operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListHarnessesPaginator ListHarnesses(ListHarnessesRequest request);

        /// <summary>
        /// Paginator for ListMemories operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListMemoriesPaginator ListMemories(ListMemoriesRequest request);

        /// <summary>
        /// Paginator for ListOauth2CredentialProviders operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListOauth2CredentialProvidersPaginator ListOauth2CredentialProviders(ListOauth2CredentialProvidersRequest request);

        /// <summary>
        /// Paginator for ListOnlineEvaluationConfigs operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListOnlineEvaluationConfigsPaginator ListOnlineEvaluationConfigs(ListOnlineEvaluationConfigsRequest request);

        /// <summary>
        /// Paginator for ListPaymentConnectors operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListPaymentConnectorsPaginator ListPaymentConnectors(ListPaymentConnectorsRequest request);

        /// <summary>
        /// Paginator for ListPaymentCredentialProviders operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListPaymentCredentialProvidersPaginator ListPaymentCredentialProviders(ListPaymentCredentialProvidersRequest request);

        /// <summary>
        /// Paginator for ListPaymentManagers operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListPaymentManagersPaginator ListPaymentManagers(ListPaymentManagersRequest request);

        /// <summary>
        /// Paginator for ListPolicies operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListPoliciesPaginator ListPolicies(ListPoliciesRequest request);

        /// <summary>
        /// Paginator for ListPolicyEngineSummaries operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListPolicyEngineSummariesPaginator ListPolicyEngineSummaries(ListPolicyEngineSummariesRequest request);

        /// <summary>
        /// Paginator for ListPolicyEngines operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListPolicyEnginesPaginator ListPolicyEngines(ListPolicyEnginesRequest request);

        /// <summary>
        /// Paginator for ListPolicyGenerationAssets operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListPolicyGenerationAssetsPaginator ListPolicyGenerationAssets(ListPolicyGenerationAssetsRequest request);

        /// <summary>
        /// Paginator for ListPolicyGenerationSummaries operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListPolicyGenerationSummariesPaginator ListPolicyGenerationSummaries(ListPolicyGenerationSummariesRequest request);

        /// <summary>
        /// Paginator for ListPolicyGenerations operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListPolicyGenerationsPaginator ListPolicyGenerations(ListPolicyGenerationsRequest request);

        /// <summary>
        /// Paginator for ListPolicySummaries operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListPolicySummariesPaginator ListPolicySummaries(ListPolicySummariesRequest request);

        /// <summary>
        /// Paginator for ListRegistries operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListRegistriesPaginator ListRegistries(ListRegistriesRequest request);

        /// <summary>
        /// Paginator for ListRegistryRecords operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListRegistryRecordsPaginator ListRegistryRecords(ListRegistryRecordsRequest request);

        /// <summary>
        /// Paginator for ListWorkloadIdentities operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListWorkloadIdentitiesPaginator ListWorkloadIdentities(ListWorkloadIdentitiesRequest request);
    }
}
