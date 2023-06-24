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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
 */

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Paginators for the ConfigService service
    ///</summary>
    public interface IConfigServicePaginatorFactory
    {

        /// <summary>
        /// Paginator for DescribeAggregateComplianceByConfigRules operation
        ///</summary>
        IDescribeAggregateComplianceByConfigRulesPaginator DescribeAggregateComplianceByConfigRules(DescribeAggregateComplianceByConfigRulesRequest request);

        /// <summary>
        /// Paginator for DescribeAggregateComplianceByConformancePacks operation
        ///</summary>
        IDescribeAggregateComplianceByConformancePacksPaginator DescribeAggregateComplianceByConformancePacks(DescribeAggregateComplianceByConformancePacksRequest request);

        /// <summary>
        /// Paginator for DescribeAggregationAuthorizations operation
        ///</summary>
        IDescribeAggregationAuthorizationsPaginator DescribeAggregationAuthorizations(DescribeAggregationAuthorizationsRequest request);

        /// <summary>
        /// Paginator for DescribeComplianceByConfigRule operation
        ///</summary>
        IDescribeComplianceByConfigRulePaginator DescribeComplianceByConfigRule(DescribeComplianceByConfigRuleRequest request);

        /// <summary>
        /// Paginator for DescribeComplianceByResource operation
        ///</summary>
        IDescribeComplianceByResourcePaginator DescribeComplianceByResource(DescribeComplianceByResourceRequest request);

        /// <summary>
        /// Paginator for DescribeConfigRuleEvaluationStatus operation
        ///</summary>
        IDescribeConfigRuleEvaluationStatusPaginator DescribeConfigRuleEvaluationStatus(DescribeConfigRuleEvaluationStatusRequest request);

        /// <summary>
        /// Paginator for DescribeConfigRules operation
        ///</summary>
        IDescribeConfigRulesPaginator DescribeConfigRules(DescribeConfigRulesRequest request);

        /// <summary>
        /// Paginator for DescribeConfigurationAggregators operation
        ///</summary>
        IDescribeConfigurationAggregatorsPaginator DescribeConfigurationAggregators(DescribeConfigurationAggregatorsRequest request);

        /// <summary>
        /// Paginator for DescribeConfigurationAggregatorSourcesStatus operation
        ///</summary>
        IDescribeConfigurationAggregatorSourcesStatusPaginator DescribeConfigurationAggregatorSourcesStatus(DescribeConfigurationAggregatorSourcesStatusRequest request);

        /// <summary>
        /// Paginator for DescribeConformancePackCompliance operation
        ///</summary>
        IDescribeConformancePackCompliancePaginator DescribeConformancePackCompliance(DescribeConformancePackComplianceRequest request);

        /// <summary>
        /// Paginator for DescribeConformancePacks operation
        ///</summary>
        IDescribeConformancePacksPaginator DescribeConformancePacks(DescribeConformancePacksRequest request);

        /// <summary>
        /// Paginator for DescribeConformancePackStatus operation
        ///</summary>
        IDescribeConformancePackStatusPaginator DescribeConformancePackStatus(DescribeConformancePackStatusRequest request);

        /// <summary>
        /// Paginator for DescribeOrganizationConfigRules operation
        ///</summary>
        IDescribeOrganizationConfigRulesPaginator DescribeOrganizationConfigRules(DescribeOrganizationConfigRulesRequest request);

        /// <summary>
        /// Paginator for DescribeOrganizationConfigRuleStatuses operation
        ///</summary>
        IDescribeOrganizationConfigRuleStatusesPaginator DescribeOrganizationConfigRuleStatuses(DescribeOrganizationConfigRuleStatusesRequest request);

        /// <summary>
        /// Paginator for DescribeOrganizationConformancePacks operation
        ///</summary>
        IDescribeOrganizationConformancePacksPaginator DescribeOrganizationConformancePacks(DescribeOrganizationConformancePacksRequest request);

        /// <summary>
        /// Paginator for DescribeOrganizationConformancePackStatuses operation
        ///</summary>
        IDescribeOrganizationConformancePackStatusesPaginator DescribeOrganizationConformancePackStatuses(DescribeOrganizationConformancePackStatusesRequest request);

        /// <summary>
        /// Paginator for DescribePendingAggregationRequests operation
        ///</summary>
        IDescribePendingAggregationRequestsPaginator DescribePendingAggregationRequests(DescribePendingAggregationRequestsRequest request);

        /// <summary>
        /// Paginator for DescribeRemediationExceptions operation
        ///</summary>
        IDescribeRemediationExceptionsPaginator DescribeRemediationExceptions(DescribeRemediationExceptionsRequest request);

        /// <summary>
        /// Paginator for DescribeRemediationExecutionStatus operation
        ///</summary>
        IDescribeRemediationExecutionStatusPaginator DescribeRemediationExecutionStatus(DescribeRemediationExecutionStatusRequest request);

        /// <summary>
        /// Paginator for DescribeRetentionConfigurations operation
        ///</summary>
        IDescribeRetentionConfigurationsPaginator DescribeRetentionConfigurations(DescribeRetentionConfigurationsRequest request);

        /// <summary>
        /// Paginator for GetAggregateComplianceDetailsByConfigRule operation
        ///</summary>
        IGetAggregateComplianceDetailsByConfigRulePaginator GetAggregateComplianceDetailsByConfigRule(GetAggregateComplianceDetailsByConfigRuleRequest request);

        /// <summary>
        /// Paginator for GetAggregateConfigRuleComplianceSummary operation
        ///</summary>
        IGetAggregateConfigRuleComplianceSummaryPaginator GetAggregateConfigRuleComplianceSummary(GetAggregateConfigRuleComplianceSummaryRequest request);

        /// <summary>
        /// Paginator for GetAggregateConformancePackComplianceSummary operation
        ///</summary>
        IGetAggregateConformancePackComplianceSummaryPaginator GetAggregateConformancePackComplianceSummary(GetAggregateConformancePackComplianceSummaryRequest request);

        /// <summary>
        /// Paginator for GetAggregateDiscoveredResourceCounts operation
        ///</summary>
        IGetAggregateDiscoveredResourceCountsPaginator GetAggregateDiscoveredResourceCounts(GetAggregateDiscoveredResourceCountsRequest request);

        /// <summary>
        /// Paginator for GetComplianceDetailsByConfigRule operation
        ///</summary>
        IGetComplianceDetailsByConfigRulePaginator GetComplianceDetailsByConfigRule(GetComplianceDetailsByConfigRuleRequest request);

        /// <summary>
        /// Paginator for GetComplianceDetailsByResource operation
        ///</summary>
        IGetComplianceDetailsByResourcePaginator GetComplianceDetailsByResource(GetComplianceDetailsByResourceRequest request);

        /// <summary>
        /// Paginator for GetConformancePackComplianceDetails operation
        ///</summary>
        IGetConformancePackComplianceDetailsPaginator GetConformancePackComplianceDetails(GetConformancePackComplianceDetailsRequest request);

        /// <summary>
        /// Paginator for GetConformancePackComplianceSummary operation
        ///</summary>
        IGetConformancePackComplianceSummaryPaginator GetConformancePackComplianceSummary(GetConformancePackComplianceSummaryRequest request);

        /// <summary>
        /// Paginator for GetDiscoveredResourceCounts operation
        ///</summary>
        IGetDiscoveredResourceCountsPaginator GetDiscoveredResourceCounts(GetDiscoveredResourceCountsRequest request);

        /// <summary>
        /// Paginator for GetOrganizationConfigRuleDetailedStatus operation
        ///</summary>
        IGetOrganizationConfigRuleDetailedStatusPaginator GetOrganizationConfigRuleDetailedStatus(GetOrganizationConfigRuleDetailedStatusRequest request);

        /// <summary>
        /// Paginator for GetOrganizationConformancePackDetailedStatus operation
        ///</summary>
        IGetOrganizationConformancePackDetailedStatusPaginator GetOrganizationConformancePackDetailedStatus(GetOrganizationConformancePackDetailedStatusRequest request);

        /// <summary>
        /// Paginator for GetResourceConfigHistory operation
        ///</summary>
        IGetResourceConfigHistoryPaginator GetResourceConfigHistory(GetResourceConfigHistoryRequest request);

        /// <summary>
        /// Paginator for ListAggregateDiscoveredResources operation
        ///</summary>
        IListAggregateDiscoveredResourcesPaginator ListAggregateDiscoveredResources(ListAggregateDiscoveredResourcesRequest request);

        /// <summary>
        /// Paginator for ListConformancePackComplianceScores operation
        ///</summary>
        IListConformancePackComplianceScoresPaginator ListConformancePackComplianceScores(ListConformancePackComplianceScoresRequest request);

        /// <summary>
        /// Paginator for ListDiscoveredResources operation
        ///</summary>
        IListDiscoveredResourcesPaginator ListDiscoveredResources(ListDiscoveredResourcesRequest request);

        /// <summary>
        /// Paginator for ListResourceEvaluations operation
        ///</summary>
        IListResourceEvaluationsPaginator ListResourceEvaluations(ListResourceEvaluationsRequest request);

        /// <summary>
        /// Paginator for ListStoredQueries operation
        ///</summary>
        IListStoredQueriesPaginator ListStoredQueries(ListStoredQueriesRequest request);

        /// <summary>
        /// Paginator for ListTagsForResource operation
        ///</summary>
        IListTagsForResourcePaginator ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Paginator for SelectAggregateResourceConfig operation
        ///</summary>
        ISelectAggregateResourceConfigPaginator SelectAggregateResourceConfig(SelectAggregateResourceConfigRequest request);

        /// <summary>
        /// Paginator for SelectResourceConfig operation
        ///</summary>
        ISelectResourceConfigPaginator SelectResourceConfig(SelectResourceConfigRequest request);
    }
}