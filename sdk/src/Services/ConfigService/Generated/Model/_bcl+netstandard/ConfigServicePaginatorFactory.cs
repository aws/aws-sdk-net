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

using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Paginators for the ConfigService service
    ///</summary>
    public class ConfigServicePaginatorFactory : IConfigServicePaginatorFactory
    {
        private readonly IAmazonConfigService client;

        internal ConfigServicePaginatorFactory(IAmazonConfigService client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for DescribeAggregateComplianceByConfigRules operation
        ///</summary>
        public IDescribeAggregateComplianceByConfigRulesPaginator DescribeAggregateComplianceByConfigRules(DescribeAggregateComplianceByConfigRulesRequest request) 
        {
            return new DescribeAggregateComplianceByConfigRulesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeAggregateComplianceByConformancePacks operation
        ///</summary>
        public IDescribeAggregateComplianceByConformancePacksPaginator DescribeAggregateComplianceByConformancePacks(DescribeAggregateComplianceByConformancePacksRequest request) 
        {
            return new DescribeAggregateComplianceByConformancePacksPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeAggregationAuthorizations operation
        ///</summary>
        public IDescribeAggregationAuthorizationsPaginator DescribeAggregationAuthorizations(DescribeAggregationAuthorizationsRequest request) 
        {
            return new DescribeAggregationAuthorizationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeComplianceByConfigRule operation
        ///</summary>
        public IDescribeComplianceByConfigRulePaginator DescribeComplianceByConfigRule(DescribeComplianceByConfigRuleRequest request) 
        {
            return new DescribeComplianceByConfigRulePaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeComplianceByResource operation
        ///</summary>
        public IDescribeComplianceByResourcePaginator DescribeComplianceByResource(DescribeComplianceByResourceRequest request) 
        {
            return new DescribeComplianceByResourcePaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeConfigRuleEvaluationStatus operation
        ///</summary>
        public IDescribeConfigRuleEvaluationStatusPaginator DescribeConfigRuleEvaluationStatus(DescribeConfigRuleEvaluationStatusRequest request) 
        {
            return new DescribeConfigRuleEvaluationStatusPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeConfigRules operation
        ///</summary>
        public IDescribeConfigRulesPaginator DescribeConfigRules(DescribeConfigRulesRequest request) 
        {
            return new DescribeConfigRulesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeConfigurationAggregators operation
        ///</summary>
        public IDescribeConfigurationAggregatorsPaginator DescribeConfigurationAggregators(DescribeConfigurationAggregatorsRequest request) 
        {
            return new DescribeConfigurationAggregatorsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeConfigurationAggregatorSourcesStatus operation
        ///</summary>
        public IDescribeConfigurationAggregatorSourcesStatusPaginator DescribeConfigurationAggregatorSourcesStatus(DescribeConfigurationAggregatorSourcesStatusRequest request) 
        {
            return new DescribeConfigurationAggregatorSourcesStatusPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeConformancePackCompliance operation
        ///</summary>
        public IDescribeConformancePackCompliancePaginator DescribeConformancePackCompliance(DescribeConformancePackComplianceRequest request) 
        {
            return new DescribeConformancePackCompliancePaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeConformancePacks operation
        ///</summary>
        public IDescribeConformancePacksPaginator DescribeConformancePacks(DescribeConformancePacksRequest request) 
        {
            return new DescribeConformancePacksPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeConformancePackStatus operation
        ///</summary>
        public IDescribeConformancePackStatusPaginator DescribeConformancePackStatus(DescribeConformancePackStatusRequest request) 
        {
            return new DescribeConformancePackStatusPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeOrganizationConfigRules operation
        ///</summary>
        public IDescribeOrganizationConfigRulesPaginator DescribeOrganizationConfigRules(DescribeOrganizationConfigRulesRequest request) 
        {
            return new DescribeOrganizationConfigRulesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeOrganizationConfigRuleStatuses operation
        ///</summary>
        public IDescribeOrganizationConfigRuleStatusesPaginator DescribeOrganizationConfigRuleStatuses(DescribeOrganizationConfigRuleStatusesRequest request) 
        {
            return new DescribeOrganizationConfigRuleStatusesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeOrganizationConformancePacks operation
        ///</summary>
        public IDescribeOrganizationConformancePacksPaginator DescribeOrganizationConformancePacks(DescribeOrganizationConformancePacksRequest request) 
        {
            return new DescribeOrganizationConformancePacksPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeOrganizationConformancePackStatuses operation
        ///</summary>
        public IDescribeOrganizationConformancePackStatusesPaginator DescribeOrganizationConformancePackStatuses(DescribeOrganizationConformancePackStatusesRequest request) 
        {
            return new DescribeOrganizationConformancePackStatusesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribePendingAggregationRequests operation
        ///</summary>
        public IDescribePendingAggregationRequestsPaginator DescribePendingAggregationRequests(DescribePendingAggregationRequestsRequest request) 
        {
            return new DescribePendingAggregationRequestsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeRemediationExceptions operation
        ///</summary>
        public IDescribeRemediationExceptionsPaginator DescribeRemediationExceptions(DescribeRemediationExceptionsRequest request) 
        {
            return new DescribeRemediationExceptionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeRemediationExecutionStatus operation
        ///</summary>
        public IDescribeRemediationExecutionStatusPaginator DescribeRemediationExecutionStatus(DescribeRemediationExecutionStatusRequest request) 
        {
            return new DescribeRemediationExecutionStatusPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeRetentionConfigurations operation
        ///</summary>
        public IDescribeRetentionConfigurationsPaginator DescribeRetentionConfigurations(DescribeRetentionConfigurationsRequest request) 
        {
            return new DescribeRetentionConfigurationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetAggregateComplianceDetailsByConfigRule operation
        ///</summary>
        public IGetAggregateComplianceDetailsByConfigRulePaginator GetAggregateComplianceDetailsByConfigRule(GetAggregateComplianceDetailsByConfigRuleRequest request) 
        {
            return new GetAggregateComplianceDetailsByConfigRulePaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetAggregateConfigRuleComplianceSummary operation
        ///</summary>
        public IGetAggregateConfigRuleComplianceSummaryPaginator GetAggregateConfigRuleComplianceSummary(GetAggregateConfigRuleComplianceSummaryRequest request) 
        {
            return new GetAggregateConfigRuleComplianceSummaryPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetAggregateConformancePackComplianceSummary operation
        ///</summary>
        public IGetAggregateConformancePackComplianceSummaryPaginator GetAggregateConformancePackComplianceSummary(GetAggregateConformancePackComplianceSummaryRequest request) 
        {
            return new GetAggregateConformancePackComplianceSummaryPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetAggregateDiscoveredResourceCounts operation
        ///</summary>
        public IGetAggregateDiscoveredResourceCountsPaginator GetAggregateDiscoveredResourceCounts(GetAggregateDiscoveredResourceCountsRequest request) 
        {
            return new GetAggregateDiscoveredResourceCountsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetComplianceDetailsByConfigRule operation
        ///</summary>
        public IGetComplianceDetailsByConfigRulePaginator GetComplianceDetailsByConfigRule(GetComplianceDetailsByConfigRuleRequest request) 
        {
            return new GetComplianceDetailsByConfigRulePaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetComplianceDetailsByResource operation
        ///</summary>
        public IGetComplianceDetailsByResourcePaginator GetComplianceDetailsByResource(GetComplianceDetailsByResourceRequest request) 
        {
            return new GetComplianceDetailsByResourcePaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetConformancePackComplianceDetails operation
        ///</summary>
        public IGetConformancePackComplianceDetailsPaginator GetConformancePackComplianceDetails(GetConformancePackComplianceDetailsRequest request) 
        {
            return new GetConformancePackComplianceDetailsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetConformancePackComplianceSummary operation
        ///</summary>
        public IGetConformancePackComplianceSummaryPaginator GetConformancePackComplianceSummary(GetConformancePackComplianceSummaryRequest request) 
        {
            return new GetConformancePackComplianceSummaryPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetDiscoveredResourceCounts operation
        ///</summary>
        public IGetDiscoveredResourceCountsPaginator GetDiscoveredResourceCounts(GetDiscoveredResourceCountsRequest request) 
        {
            return new GetDiscoveredResourceCountsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetOrganizationConfigRuleDetailedStatus operation
        ///</summary>
        public IGetOrganizationConfigRuleDetailedStatusPaginator GetOrganizationConfigRuleDetailedStatus(GetOrganizationConfigRuleDetailedStatusRequest request) 
        {
            return new GetOrganizationConfigRuleDetailedStatusPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetOrganizationConformancePackDetailedStatus operation
        ///</summary>
        public IGetOrganizationConformancePackDetailedStatusPaginator GetOrganizationConformancePackDetailedStatus(GetOrganizationConformancePackDetailedStatusRequest request) 
        {
            return new GetOrganizationConformancePackDetailedStatusPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetResourceConfigHistory operation
        ///</summary>
        public IGetResourceConfigHistoryPaginator GetResourceConfigHistory(GetResourceConfigHistoryRequest request) 
        {
            return new GetResourceConfigHistoryPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAggregateDiscoveredResources operation
        ///</summary>
        public IListAggregateDiscoveredResourcesPaginator ListAggregateDiscoveredResources(ListAggregateDiscoveredResourcesRequest request) 
        {
            return new ListAggregateDiscoveredResourcesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListConformancePackComplianceScores operation
        ///</summary>
        public IListConformancePackComplianceScoresPaginator ListConformancePackComplianceScores(ListConformancePackComplianceScoresRequest request) 
        {
            return new ListConformancePackComplianceScoresPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDiscoveredResources operation
        ///</summary>
        public IListDiscoveredResourcesPaginator ListDiscoveredResources(ListDiscoveredResourcesRequest request) 
        {
            return new ListDiscoveredResourcesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListResourceEvaluations operation
        ///</summary>
        public IListResourceEvaluationsPaginator ListResourceEvaluations(ListResourceEvaluationsRequest request) 
        {
            return new ListResourceEvaluationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListStoredQueries operation
        ///</summary>
        public IListStoredQueriesPaginator ListStoredQueries(ListStoredQueriesRequest request) 
        {
            return new ListStoredQueriesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTagsForResource operation
        ///</summary>
        public IListTagsForResourcePaginator ListTagsForResource(ListTagsForResourceRequest request) 
        {
            return new ListTagsForResourcePaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for SelectAggregateResourceConfig operation
        ///</summary>
        public ISelectAggregateResourceConfigPaginator SelectAggregateResourceConfig(SelectAggregateResourceConfigRequest request) 
        {
            return new SelectAggregateResourceConfigPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for SelectResourceConfig operation
        ///</summary>
        public ISelectResourceConfigPaginator SelectResourceConfig(SelectResourceConfigRequest request) 
        {
            return new SelectResourceConfigPaginator(this.client, request);
        }
    }
}