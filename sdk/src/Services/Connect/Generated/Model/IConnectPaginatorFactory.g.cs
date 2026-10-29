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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Paginators for the Connect service
    /// </summary>
    public interface IConnectPaginatorFactory
    {
        /// <summary>
        /// Paginator for EvaluateDataTableValues operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IEvaluateDataTableValuesPaginator EvaluateDataTableValues(EvaluateDataTableValuesRequest request);

        /// <summary>
        /// Paginator for GetCurrentMetricData operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IGetCurrentMetricDataPaginator GetCurrentMetricData(GetCurrentMetricDataRequest request);

        /// <summary>
        /// Paginator for GetCurrentUserData operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IGetCurrentUserDataPaginator GetCurrentUserData(GetCurrentUserDataRequest request);

        /// <summary>
        /// Paginator for GetMetricData operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IGetMetricDataPaginator GetMetricData(GetMetricDataRequest request);

        /// <summary>
        /// Paginator for GetMetricDataV2 operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IGetMetricDataV2Paginator GetMetricDataV2(GetMetricDataV2Request request);

        /// <summary>
        /// Paginator for ListAgentStatuses operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListAgentStatusesPaginator ListAgentStatuses(ListAgentStatusesRequest request);

        /// <summary>
        /// Paginator for ListApprovedOrigins operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListApprovedOriginsPaginator ListApprovedOrigins(ListApprovedOriginsRequest request);

        /// <summary>
        /// Paginator for ListAttachedFilesConfigurations operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListAttachedFilesConfigurationsPaginator ListAttachedFilesConfigurations(ListAttachedFilesConfigurationsRequest request);

        /// <summary>
        /// Paginator for ListAuthenticationProfiles operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListAuthenticationProfilesPaginator ListAuthenticationProfiles(ListAuthenticationProfilesRequest request);

        /// <summary>
        /// Paginator for ListBots operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListBotsPaginator ListBots(ListBotsRequest request);

        /// <summary>
        /// Paginator for ListChildHoursOfOperations operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListChildHoursOfOperationsPaginator ListChildHoursOfOperations(ListChildHoursOfOperationsRequest request);

        /// <summary>
        /// Paginator for ListContactEvaluations operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], OutputToken = ["NextToken"])]
        IListContactEvaluationsPaginator ListContactEvaluations(ListContactEvaluationsRequest request);

        /// <summary>
        /// Paginator for ListContactFlowAliases operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListContactFlowAliasesPaginator ListContactFlowAliases(ListContactFlowAliasesRequest request);

        /// <summary>
        /// Paginator for ListContactFlowModuleAliases operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListContactFlowModuleAliasesPaginator ListContactFlowModuleAliases(ListContactFlowModuleAliasesRequest request);

        /// <summary>
        /// Paginator for ListContactFlowModuleVersions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListContactFlowModuleVersionsPaginator ListContactFlowModuleVersions(ListContactFlowModuleVersionsRequest request);

        /// <summary>
        /// Paginator for ListContactFlowModules operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListContactFlowModulesPaginator ListContactFlowModules(ListContactFlowModulesRequest request);

        /// <summary>
        /// Paginator for ListContactFlowVersions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListContactFlowVersionsPaginator ListContactFlowVersions(ListContactFlowVersionsRequest request);

        /// <summary>
        /// Paginator for ListContactFlows operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListContactFlowsPaginator ListContactFlows(ListContactFlowsRequest request);

        /// <summary>
        /// Paginator for ListContactReferences operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], OutputToken = ["NextToken"])]
        IListContactReferencesPaginator ListContactReferences(ListContactReferencesRequest request);

        /// <summary>
        /// Paginator for ListDataTableAttributes operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListDataTableAttributesPaginator ListDataTableAttributes(ListDataTableAttributesRequest request);

        /// <summary>
        /// Paginator for ListDataTablePrimaryValues operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListDataTablePrimaryValuesPaginator ListDataTablePrimaryValues(ListDataTablePrimaryValuesRequest request);

        /// <summary>
        /// Paginator for ListDataTableValues operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListDataTableValuesPaginator ListDataTableValues(ListDataTableValuesRequest request);

        /// <summary>
        /// Paginator for ListDataTables operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListDataTablesPaginator ListDataTables(ListDataTablesRequest request);

        /// <summary>
        /// Paginator for ListDefaultVocabularies operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListDefaultVocabulariesPaginator ListDefaultVocabularies(ListDefaultVocabulariesRequest request);

        /// <summary>
        /// Paginator for ListEntitySecurityProfiles operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListEntitySecurityProfilesPaginator ListEntitySecurityProfiles(ListEntitySecurityProfilesRequest request);

        /// <summary>
        /// Paginator for ListEvaluationFormAIVersions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListEvaluationFormAIVersionsPaginator ListEvaluationFormAIVersions(ListEvaluationFormAIVersionsRequest request);

        /// <summary>
        /// Paginator for ListEvaluationFormVersions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListEvaluationFormVersionsPaginator ListEvaluationFormVersions(ListEvaluationFormVersionsRequest request);

        /// <summary>
        /// Paginator for ListEvaluationForms operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListEvaluationFormsPaginator ListEvaluationForms(ListEvaluationFormsRequest request);

        /// <summary>
        /// Paginator for ListExtractionDefinitions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListExtractionDefinitionsPaginator ListExtractionDefinitions(ListExtractionDefinitionsRequest request);

        /// <summary>
        /// Paginator for ListFlowAssociations operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListFlowAssociationsPaginator ListFlowAssociations(ListFlowAssociationsRequest request);

        /// <summary>
        /// Paginator for ListHoursOfOperationOverrides operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListHoursOfOperationOverridesPaginator ListHoursOfOperationOverrides(ListHoursOfOperationOverridesRequest request);

        /// <summary>
        /// Paginator for ListHoursOfOperations operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListHoursOfOperationsPaginator ListHoursOfOperations(ListHoursOfOperationsRequest request);

        /// <summary>
        /// Paginator for ListInstanceAttributes operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListInstanceAttributesPaginator ListInstanceAttributes(ListInstanceAttributesRequest request);

        /// <summary>
        /// Paginator for ListInstanceStorageConfigs operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListInstanceStorageConfigsPaginator ListInstanceStorageConfigs(ListInstanceStorageConfigsRequest request);

        /// <summary>
        /// Paginator for ListInstances operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListInstancesPaginator ListInstances(ListInstancesRequest request);

        /// <summary>
        /// Paginator for ListIntegrationAssociations operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListIntegrationAssociationsPaginator ListIntegrationAssociations(ListIntegrationAssociationsRequest request);

        /// <summary>
        /// Paginator for ListLambdaFunctions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListLambdaFunctionsPaginator ListLambdaFunctions(ListLambdaFunctionsRequest request);

        /// <summary>
        /// Paginator for ListLexBots operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListLexBotsPaginator ListLexBots(ListLexBotsRequest request);

        /// <summary>
        /// Paginator for ListMetrics operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListMetricsPaginator ListMetrics(ListMetricsRequest request);

        /// <summary>
        /// Paginator for ListPhoneNumbers operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListPhoneNumbersPaginator ListPhoneNumbers(ListPhoneNumbersRequest request);

        /// <summary>
        /// Paginator for ListPhoneNumbersV2 operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListPhoneNumbersV2Paginator ListPhoneNumbersV2(ListPhoneNumbersV2Request request);

        /// <summary>
        /// Paginator for ListPredefinedAttributes operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListPredefinedAttributesPaginator ListPredefinedAttributes(ListPredefinedAttributesRequest request);

        /// <summary>
        /// Paginator for ListPrompts operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListPromptsPaginator ListPrompts(ListPromptsRequest request);

        /// <summary>
        /// Paginator for ListQueueQuickConnects operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListQueueQuickConnectsPaginator ListQueueQuickConnects(ListQueueQuickConnectsRequest request);

        /// <summary>
        /// Paginator for ListQueues operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListQueuesPaginator ListQueues(ListQueuesRequest request);

        /// <summary>
        /// Paginator for ListQuickConnects operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListQuickConnectsPaginator ListQuickConnects(ListQuickConnectsRequest request);

        /// <summary>
        /// Paginator for ListRealtimeContactAnalysisSegmentsV2 operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListRealtimeContactAnalysisSegmentsV2Paginator ListRealtimeContactAnalysisSegmentsV2(ListRealtimeContactAnalysisSegmentsV2Request request);

        /// <summary>
        /// Paginator for ListReplicationFindings operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListReplicationFindingsPaginator ListReplicationFindings(ListReplicationFindingsRequest request);

        /// <summary>
        /// Paginator for ListRoutingProfileManualAssignmentQueues operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListRoutingProfileManualAssignmentQueuesPaginator ListRoutingProfileManualAssignmentQueues(ListRoutingProfileManualAssignmentQueuesRequest request);

        /// <summary>
        /// Paginator for ListRoutingProfileQueues operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListRoutingProfileQueuesPaginator ListRoutingProfileQueues(ListRoutingProfileQueuesRequest request);

        /// <summary>
        /// Paginator for ListRoutingProfiles operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListRoutingProfilesPaginator ListRoutingProfiles(ListRoutingProfilesRequest request);

        /// <summary>
        /// Paginator for ListRules operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListRulesPaginator ListRules(ListRulesRequest request);

        /// <summary>
        /// Paginator for ListSecurityKeys operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListSecurityKeysPaginator ListSecurityKeys(ListSecurityKeysRequest request);

        /// <summary>
        /// Paginator for ListSecurityProfileAIAgents operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListSecurityProfileAIAgentsPaginator ListSecurityProfileAIAgents(ListSecurityProfileAIAgentsRequest request);

        /// <summary>
        /// Paginator for ListSecurityProfileApplications operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListSecurityProfileApplicationsPaginator ListSecurityProfileApplications(ListSecurityProfileApplicationsRequest request);

        /// <summary>
        /// Paginator for ListSecurityProfileFlowModules operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListSecurityProfileFlowModulesPaginator ListSecurityProfileFlowModules(ListSecurityProfileFlowModulesRequest request);

        /// <summary>
        /// Paginator for ListSecurityProfilePermissions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListSecurityProfilePermissionsPaginator ListSecurityProfilePermissions(ListSecurityProfilePermissionsRequest request);

        /// <summary>
        /// Paginator for ListSecurityProfiles operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListSecurityProfilesPaginator ListSecurityProfiles(ListSecurityProfilesRequest request);

        /// <summary>
        /// Paginator for ListTaskTemplates operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListTaskTemplatesPaginator ListTaskTemplates(ListTaskTemplatesRequest request);

        /// <summary>
        /// Paginator for ListTestCases operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListTestCasesPaginator ListTestCases(ListTestCasesRequest request);

        /// <summary>
        /// Paginator for ListTrafficDistributionGroupUsers operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListTrafficDistributionGroupUsersPaginator ListTrafficDistributionGroupUsers(ListTrafficDistributionGroupUsersRequest request);

        /// <summary>
        /// Paginator for ListTrafficDistributionGroups operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListTrafficDistributionGroupsPaginator ListTrafficDistributionGroups(ListTrafficDistributionGroupsRequest request);

        /// <summary>
        /// Paginator for ListUseCases operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListUseCasesPaginator ListUseCases(ListUseCasesRequest request);

        /// <summary>
        /// Paginator for ListUserHierarchyGroups operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListUserHierarchyGroupsPaginator ListUserHierarchyGroups(ListUserHierarchyGroupsRequest request);

        /// <summary>
        /// Paginator for ListUserProficiencies operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListUserProficienciesPaginator ListUserProficiencies(ListUserProficienciesRequest request);

        /// <summary>
        /// Paginator for ListUsers operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListUsersPaginator ListUsers(ListUsersRequest request);

        /// <summary>
        /// Paginator for ListViewVersions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListViewVersionsPaginator ListViewVersions(ListViewVersionsRequest request);

        /// <summary>
        /// Paginator for ListViews operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListViewsPaginator ListViews(ListViewsRequest request);

        /// <summary>
        /// Paginator for ListWorkspacePages operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListWorkspacePagesPaginator ListWorkspacePages(ListWorkspacePagesRequest request);

        /// <summary>
        /// Paginator for ListWorkspaces operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListWorkspacesPaginator ListWorkspaces(ListWorkspacesRequest request);

        /// <summary>
        /// Paginator for SearchAgentStatuses operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        ISearchAgentStatusesPaginator SearchAgentStatuses(SearchAgentStatusesRequest request);

        /// <summary>
        /// Paginator for SearchAvailablePhoneNumbers operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        ISearchAvailablePhoneNumbersPaginator SearchAvailablePhoneNumbers(SearchAvailablePhoneNumbersRequest request);

        /// <summary>
        /// Paginator for SearchContactFlowModules operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        ISearchContactFlowModulesPaginator SearchContactFlowModules(SearchContactFlowModulesRequest request);

        /// <summary>
        /// Paginator for SearchContactFlows operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        ISearchContactFlowsPaginator SearchContactFlows(SearchContactFlowsRequest request);

        /// <summary>
        /// Paginator for SearchContacts operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        ISearchContactsPaginator SearchContacts(SearchContactsRequest request);

        /// <summary>
        /// Paginator for SearchDataTables operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        ISearchDataTablesPaginator SearchDataTables(SearchDataTablesRequest request);

        /// <summary>
        /// Paginator for SearchHoursOfOperationOverrides operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        ISearchHoursOfOperationOverridesPaginator SearchHoursOfOperationOverrides(SearchHoursOfOperationOverridesRequest request);

        /// <summary>
        /// Paginator for SearchHoursOfOperations operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        ISearchHoursOfOperationsPaginator SearchHoursOfOperations(SearchHoursOfOperationsRequest request);

        /// <summary>
        /// Paginator for SearchMetrics operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        ISearchMetricsPaginator SearchMetrics(SearchMetricsRequest request);

        /// <summary>
        /// Paginator for SearchPredefinedAttributes operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        ISearchPredefinedAttributesPaginator SearchPredefinedAttributes(SearchPredefinedAttributesRequest request);

        /// <summary>
        /// Paginator for SearchPrompts operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        ISearchPromptsPaginator SearchPrompts(SearchPromptsRequest request);

        /// <summary>
        /// Paginator for SearchQueues operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        ISearchQueuesPaginator SearchQueues(SearchQueuesRequest request);

        /// <summary>
        /// Paginator for SearchQuickConnects operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        ISearchQuickConnectsPaginator SearchQuickConnects(SearchQuickConnectsRequest request);

        /// <summary>
        /// Paginator for SearchResourceTags operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        ISearchResourceTagsPaginator SearchResourceTags(SearchResourceTagsRequest request);

        /// <summary>
        /// Paginator for SearchRoutingProfiles operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        ISearchRoutingProfilesPaginator SearchRoutingProfiles(SearchRoutingProfilesRequest request);

        /// <summary>
        /// Paginator for SearchRules operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        ISearchRulesPaginator SearchRules(SearchRulesRequest request);

        /// <summary>
        /// Paginator for SearchSecurityProfiles operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        ISearchSecurityProfilesPaginator SearchSecurityProfiles(SearchSecurityProfilesRequest request);

        /// <summary>
        /// Paginator for SearchTestCases operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        ISearchTestCasesPaginator SearchTestCases(SearchTestCasesRequest request);

        /// <summary>
        /// Paginator for SearchUserHierarchyGroups operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        ISearchUserHierarchyGroupsPaginator SearchUserHierarchyGroups(SearchUserHierarchyGroupsRequest request);

        /// <summary>
        /// Paginator for SearchUsers operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        ISearchUsersPaginator SearchUsers(SearchUsersRequest request);

        /// <summary>
        /// Paginator for SearchViews operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        ISearchViewsPaginator SearchViews(SearchViewsRequest request);

        /// <summary>
        /// Paginator for SearchVocabularies operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        ISearchVocabulariesPaginator SearchVocabularies(SearchVocabulariesRequest request);

        /// <summary>
        /// Paginator for SearchWorkspaceAssociations operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        ISearchWorkspaceAssociationsPaginator SearchWorkspaceAssociations(SearchWorkspaceAssociationsRequest request);

        /// <summary>
        /// Paginator for SearchWorkspaces operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        ISearchWorkspacesPaginator SearchWorkspaces(SearchWorkspacesRequest request);
    }
}
