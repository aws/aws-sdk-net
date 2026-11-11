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

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Paginators for the ConfigService service
    /// </summary>
    public interface IConfigServicePaginatorFactory
    {
        /// <summary>
        /// Paginator for DescribeAggregateComplianceByConfigRules operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "Limit", OutputToken = ["NextToken"])]
        IDescribeAggregateComplianceByConfigRulesPaginator DescribeAggregateComplianceByConfigRules(DescribeAggregateComplianceByConfigRulesRequest request);

        /// <summary>
        /// Paginator for DescribeAggregateComplianceByConformancePacks operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "Limit", OutputToken = ["NextToken"])]
        IDescribeAggregateComplianceByConformancePacksPaginator DescribeAggregateComplianceByConformancePacks(DescribeAggregateComplianceByConformancePacksRequest request);

        /// <summary>
        /// Paginator for DescribeAggregationAuthorizations operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "Limit", OutputToken = ["NextToken"])]
        IDescribeAggregationAuthorizationsPaginator DescribeAggregationAuthorizations(DescribeAggregationAuthorizationsRequest request);

        /// <summary>
        /// Paginator for DescribeComplianceByConfigRule operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], OutputToken = ["NextToken"])]
        IDescribeComplianceByConfigRulePaginator DescribeComplianceByConfigRule(DescribeComplianceByConfigRuleRequest request);

        /// <summary>
        /// Paginator for DescribeComplianceByResource operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "Limit", OutputToken = ["NextToken"])]
        IDescribeComplianceByResourcePaginator DescribeComplianceByResource(DescribeComplianceByResourceRequest request);

        /// <summary>
        /// Paginator for DescribeConfigRuleEvaluationStatus operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "Limit", OutputToken = ["NextToken"])]
        IDescribeConfigRuleEvaluationStatusPaginator DescribeConfigRuleEvaluationStatus(DescribeConfigRuleEvaluationStatusRequest request);

        /// <summary>
        /// Paginator for DescribeConfigRules operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], OutputToken = ["NextToken"])]
        IDescribeConfigRulesPaginator DescribeConfigRules(DescribeConfigRulesRequest request);

        /// <summary>
        /// Paginator for DescribeConfigurationAggregatorSourcesStatus operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "Limit", OutputToken = ["NextToken"])]
        IDescribeConfigurationAggregatorSourcesStatusPaginator DescribeConfigurationAggregatorSourcesStatus(DescribeConfigurationAggregatorSourcesStatusRequest request);

        /// <summary>
        /// Paginator for DescribeConfigurationAggregators operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "Limit", OutputToken = ["NextToken"])]
        IDescribeConfigurationAggregatorsPaginator DescribeConfigurationAggregators(DescribeConfigurationAggregatorsRequest request);

        /// <summary>
        /// Paginator for DescribeConformancePackCompliance operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "Limit", OutputToken = ["NextToken"])]
        IDescribeConformancePackCompliancePaginator DescribeConformancePackCompliance(DescribeConformancePackComplianceRequest request);

        /// <summary>
        /// Paginator for DescribeConformancePackStatus operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "Limit", OutputToken = ["NextToken"])]
        IDescribeConformancePackStatusPaginator DescribeConformancePackStatus(DescribeConformancePackStatusRequest request);

        /// <summary>
        /// Paginator for DescribeConformancePacks operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "Limit", OutputToken = ["NextToken"])]
        IDescribeConformancePacksPaginator DescribeConformancePacks(DescribeConformancePacksRequest request);

        /// <summary>
        /// Paginator for DescribeOrganizationConfigRuleStatuses operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "Limit", OutputToken = ["NextToken"])]
        IDescribeOrganizationConfigRuleStatusesPaginator DescribeOrganizationConfigRuleStatuses(DescribeOrganizationConfigRuleStatusesRequest request);

        /// <summary>
        /// Paginator for DescribeOrganizationConfigRules operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "Limit", OutputToken = ["NextToken"])]
        IDescribeOrganizationConfigRulesPaginator DescribeOrganizationConfigRules(DescribeOrganizationConfigRulesRequest request);

        /// <summary>
        /// Paginator for DescribeOrganizationConformancePackStatuses operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "Limit", OutputToken = ["NextToken"])]
        IDescribeOrganizationConformancePackStatusesPaginator DescribeOrganizationConformancePackStatuses(DescribeOrganizationConformancePackStatusesRequest request);

        /// <summary>
        /// Paginator for DescribeOrganizationConformancePacks operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "Limit", OutputToken = ["NextToken"])]
        IDescribeOrganizationConformancePacksPaginator DescribeOrganizationConformancePacks(DescribeOrganizationConformancePacksRequest request);

        /// <summary>
        /// Paginator for DescribePendingAggregationRequests operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "Limit", OutputToken = ["NextToken"])]
        IDescribePendingAggregationRequestsPaginator DescribePendingAggregationRequests(DescribePendingAggregationRequestsRequest request);

        /// <summary>
        /// Paginator for DescribeRemediationExceptions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "Limit", OutputToken = ["NextToken"])]
        IDescribeRemediationExceptionsPaginator DescribeRemediationExceptions(DescribeRemediationExceptionsRequest request);

        /// <summary>
        /// Paginator for DescribeRemediationExecutionStatus operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "Limit", OutputToken = ["NextToken"])]
        IDescribeRemediationExecutionStatusPaginator DescribeRemediationExecutionStatus(DescribeRemediationExecutionStatusRequest request);

        /// <summary>
        /// Paginator for DescribeRetentionConfigurations operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], OutputToken = ["NextToken"])]
        IDescribeRetentionConfigurationsPaginator DescribeRetentionConfigurations(DescribeRetentionConfigurationsRequest request);

        /// <summary>
        /// Paginator for GetAggregateComplianceDetailsByConfigRule operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "Limit", OutputToken = ["NextToken"])]
        IGetAggregateComplianceDetailsByConfigRulePaginator GetAggregateComplianceDetailsByConfigRule(GetAggregateComplianceDetailsByConfigRuleRequest request);

        /// <summary>
        /// Paginator for GetAggregateConfigRuleComplianceSummary operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "Limit", OutputToken = ["NextToken"])]
        IGetAggregateConfigRuleComplianceSummaryPaginator GetAggregateConfigRuleComplianceSummary(GetAggregateConfigRuleComplianceSummaryRequest request);

        /// <summary>
        /// Paginator for GetAggregateConformancePackComplianceSummary operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "Limit", OutputToken = ["NextToken"])]
        IGetAggregateConformancePackComplianceSummaryPaginator GetAggregateConformancePackComplianceSummary(GetAggregateConformancePackComplianceSummaryRequest request);

        /// <summary>
        /// Paginator for GetAggregateDiscoveredResourceCounts operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "Limit", OutputToken = ["NextToken"])]
        IGetAggregateDiscoveredResourceCountsPaginator GetAggregateDiscoveredResourceCounts(GetAggregateDiscoveredResourceCountsRequest request);

        /// <summary>
        /// Paginator for GetComplianceDetailsByConfigRule operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "Limit", OutputToken = ["NextToken"])]
        IGetComplianceDetailsByConfigRulePaginator GetComplianceDetailsByConfigRule(GetComplianceDetailsByConfigRuleRequest request);

        /// <summary>
        /// Paginator for GetComplianceDetailsByResource operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], OutputToken = ["NextToken"])]
        IGetComplianceDetailsByResourcePaginator GetComplianceDetailsByResource(GetComplianceDetailsByResourceRequest request);

        /// <summary>
        /// Paginator for GetConformancePackComplianceDetails operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "Limit", OutputToken = ["NextToken"])]
        IGetConformancePackComplianceDetailsPaginator GetConformancePackComplianceDetails(GetConformancePackComplianceDetailsRequest request);

        /// <summary>
        /// Paginator for GetConformancePackComplianceSummary operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "Limit", OutputToken = ["NextToken"])]
        IGetConformancePackComplianceSummaryPaginator GetConformancePackComplianceSummary(GetConformancePackComplianceSummaryRequest request);

        /// <summary>
        /// Paginator for GetDiscoveredResourceCounts operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "Limit", OutputToken = ["NextToken"])]
        IGetDiscoveredResourceCountsPaginator GetDiscoveredResourceCounts(GetDiscoveredResourceCountsRequest request);

        /// <summary>
        /// Paginator for GetOrganizationConfigRuleDetailedStatus operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "Limit", OutputToken = ["NextToken"])]
        IGetOrganizationConfigRuleDetailedStatusPaginator GetOrganizationConfigRuleDetailedStatus(GetOrganizationConfigRuleDetailedStatusRequest request);

        /// <summary>
        /// Paginator for GetOrganizationConformancePackDetailedStatus operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "Limit", OutputToken = ["NextToken"])]
        IGetOrganizationConformancePackDetailedStatusPaginator GetOrganizationConformancePackDetailedStatus(GetOrganizationConformancePackDetailedStatusRequest request);

        /// <summary>
        /// Paginator for GetResourceConfigHistory operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "Limit", OutputToken = ["NextToken"])]
        IGetResourceConfigHistoryPaginator GetResourceConfigHistory(GetResourceConfigHistoryRequest request);

        /// <summary>
        /// Paginator for ListAggregateDiscoveredResources operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "Limit", OutputToken = ["NextToken"])]
        IListAggregateDiscoveredResourcesPaginator ListAggregateDiscoveredResources(ListAggregateDiscoveredResourcesRequest request);

        /// <summary>
        /// Paginator for ListConfigurationRecorders operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListConfigurationRecordersPaginator ListConfigurationRecorders(ListConfigurationRecordersRequest request);

        /// <summary>
        /// Paginator for ListConformancePackComplianceScores operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "Limit", OutputToken = ["NextToken"])]
        IListConformancePackComplianceScoresPaginator ListConformancePackComplianceScores(ListConformancePackComplianceScoresRequest request);

        /// <summary>
        /// Paginator for ListConnectors operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListConnectorsPaginator ListConnectors(ListConnectorsRequest request);

        /// <summary>
        /// Paginator for ListDiscoveredResources operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "Limit", OutputToken = ["NextToken"])]
        IListDiscoveredResourcesPaginator ListDiscoveredResources(ListDiscoveredResourcesRequest request);

        /// <summary>
        /// Paginator for ListResourceEvaluations operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "Limit", OutputToken = ["NextToken"])]
        IListResourceEvaluationsPaginator ListResourceEvaluations(ListResourceEvaluationsRequest request);

        /// <summary>
        /// Paginator for ListStoredQueries operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListStoredQueriesPaginator ListStoredQueries(ListStoredQueriesRequest request);

        /// <summary>
        /// Paginator for ListTagsForResource operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "Limit", OutputToken = ["NextToken"])]
        IListTagsForResourcePaginator ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Paginator for SelectAggregateResourceConfig operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "Limit", OutputToken = ["NextToken"])]
        ISelectAggregateResourceConfigPaginator SelectAggregateResourceConfig(SelectAggregateResourceConfigRequest request);

        /// <summary>
        /// Paginator for SelectResourceConfig operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "Limit", OutputToken = ["NextToken"])]
        ISelectResourceConfigPaginator SelectResourceConfig(SelectResourceConfigRequest request);
    }
}
