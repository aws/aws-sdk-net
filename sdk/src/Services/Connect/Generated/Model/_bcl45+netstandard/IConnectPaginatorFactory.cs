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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
 */
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
namespace Amazon.Connect.Model
{
    /// <summary>
    /// Paginators for the Connect service
    ///</summary>
    public interface IConnectPaginatorFactory
    {

        /// <summary>
        /// Paginator for GetCurrentMetricData operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IGetCurrentMetricDataPaginator GetCurrentMetricData(GetCurrentMetricDataRequest request);

        /// <summary>
        /// Paginator for GetCurrentUserData operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IGetCurrentUserDataPaginator GetCurrentUserData(GetCurrentUserDataRequest request);

        /// <summary>
        /// Paginator for GetMetricData operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IGetMetricDataPaginator GetMetricData(GetMetricDataRequest request);

        /// <summary>
        /// Paginator for GetMetricDataV2 operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IGetMetricDataV2Paginator GetMetricDataV2(GetMetricDataV2Request request);

        /// <summary>
        /// Paginator for ListAgentStatuses operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListAgentStatusesPaginator ListAgentStatuses(ListAgentStatusesRequest request);

        /// <summary>
        /// Paginator for ListApprovedOrigins operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListApprovedOriginsPaginator ListApprovedOrigins(ListApprovedOriginsRequest request);

        /// <summary>
        /// Paginator for ListAuthenticationProfiles operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListAuthenticationProfilesPaginator ListAuthenticationProfiles(ListAuthenticationProfilesRequest request);

        /// <summary>
        /// Paginator for ListBots operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListBotsPaginator ListBots(ListBotsRequest request);

        /// <summary>
        /// Paginator for ListContactEvaluations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            
            OutputToken = new[] { "NextToken" }
        )]
        IListContactEvaluationsPaginator ListContactEvaluations(ListContactEvaluationsRequest request);

        /// <summary>
        /// Paginator for ListContactFlowModules operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListContactFlowModulesPaginator ListContactFlowModules(ListContactFlowModulesRequest request);

        /// <summary>
        /// Paginator for ListContactFlows operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListContactFlowsPaginator ListContactFlows(ListContactFlowsRequest request);

        /// <summary>
        /// Paginator for ListContactFlowVersions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListContactFlowVersionsPaginator ListContactFlowVersions(ListContactFlowVersionsRequest request);

        /// <summary>
        /// Paginator for ListContactReferences operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            
            OutputToken = new[] { "NextToken" }
        )]
        IListContactReferencesPaginator ListContactReferences(ListContactReferencesRequest request);

        /// <summary>
        /// Paginator for ListDefaultVocabularies operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListDefaultVocabulariesPaginator ListDefaultVocabularies(ListDefaultVocabulariesRequest request);

        /// <summary>
        /// Paginator for ListEvaluationForms operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListEvaluationFormsPaginator ListEvaluationForms(ListEvaluationFormsRequest request);

        /// <summary>
        /// Paginator for ListEvaluationFormVersions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListEvaluationFormVersionsPaginator ListEvaluationFormVersions(ListEvaluationFormVersionsRequest request);

        /// <summary>
        /// Paginator for ListFlowAssociations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListFlowAssociationsPaginator ListFlowAssociations(ListFlowAssociationsRequest request);

        /// <summary>
        /// Paginator for ListHoursOfOperationOverrides operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListHoursOfOperationOverridesPaginator ListHoursOfOperationOverrides(ListHoursOfOperationOverridesRequest request);

        /// <summary>
        /// Paginator for ListHoursOfOperations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListHoursOfOperationsPaginator ListHoursOfOperations(ListHoursOfOperationsRequest request);

        /// <summary>
        /// Paginator for ListInstanceAttributes operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListInstanceAttributesPaginator ListInstanceAttributes(ListInstanceAttributesRequest request);

        /// <summary>
        /// Paginator for ListInstances operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListInstancesPaginator ListInstances(ListInstancesRequest request);

        /// <summary>
        /// Paginator for ListInstanceStorageConfigs operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListInstanceStorageConfigsPaginator ListInstanceStorageConfigs(ListInstanceStorageConfigsRequest request);

        /// <summary>
        /// Paginator for ListIntegrationAssociations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListIntegrationAssociationsPaginator ListIntegrationAssociations(ListIntegrationAssociationsRequest request);

        /// <summary>
        /// Paginator for ListLambdaFunctions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListLambdaFunctionsPaginator ListLambdaFunctions(ListLambdaFunctionsRequest request);

        /// <summary>
        /// Paginator for ListLexBots operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListLexBotsPaginator ListLexBots(ListLexBotsRequest request);

        /// <summary>
        /// Paginator for ListPhoneNumbers operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListPhoneNumbersPaginator ListPhoneNumbers(ListPhoneNumbersRequest request);

        /// <summary>
        /// Paginator for ListPhoneNumbersV2 operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListPhoneNumbersV2Paginator ListPhoneNumbersV2(ListPhoneNumbersV2Request request);

        /// <summary>
        /// Paginator for ListPredefinedAttributes operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListPredefinedAttributesPaginator ListPredefinedAttributes(ListPredefinedAttributesRequest request);

        /// <summary>
        /// Paginator for ListPrompts operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListPromptsPaginator ListPrompts(ListPromptsRequest request);

        /// <summary>
        /// Paginator for ListQueueQuickConnects operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListQueueQuickConnectsPaginator ListQueueQuickConnects(ListQueueQuickConnectsRequest request);

        /// <summary>
        /// Paginator for ListQueues operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListQueuesPaginator ListQueues(ListQueuesRequest request);

        /// <summary>
        /// Paginator for ListQuickConnects operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListQuickConnectsPaginator ListQuickConnects(ListQuickConnectsRequest request);

        /// <summary>
        /// Paginator for ListRealtimeContactAnalysisSegmentsV2 operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListRealtimeContactAnalysisSegmentsV2Paginator ListRealtimeContactAnalysisSegmentsV2(ListRealtimeContactAnalysisSegmentsV2Request request);

        /// <summary>
        /// Paginator for ListRoutingProfileManualAssignmentQueues operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListRoutingProfileManualAssignmentQueuesPaginator ListRoutingProfileManualAssignmentQueues(ListRoutingProfileManualAssignmentQueuesRequest request);

        /// <summary>
        /// Paginator for ListRoutingProfileQueues operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListRoutingProfileQueuesPaginator ListRoutingProfileQueues(ListRoutingProfileQueuesRequest request);

        /// <summary>
        /// Paginator for ListRoutingProfiles operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListRoutingProfilesPaginator ListRoutingProfiles(ListRoutingProfilesRequest request);

        /// <summary>
        /// Paginator for ListRules operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListRulesPaginator ListRules(ListRulesRequest request);

        /// <summary>
        /// Paginator for ListSecurityKeys operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListSecurityKeysPaginator ListSecurityKeys(ListSecurityKeysRequest request);

        /// <summary>
        /// Paginator for ListSecurityProfileApplications operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListSecurityProfileApplicationsPaginator ListSecurityProfileApplications(ListSecurityProfileApplicationsRequest request);

        /// <summary>
        /// Paginator for ListSecurityProfilePermissions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListSecurityProfilePermissionsPaginator ListSecurityProfilePermissions(ListSecurityProfilePermissionsRequest request);

        /// <summary>
        /// Paginator for ListSecurityProfiles operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListSecurityProfilesPaginator ListSecurityProfiles(ListSecurityProfilesRequest request);

        /// <summary>
        /// Paginator for ListTaskTemplates operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListTaskTemplatesPaginator ListTaskTemplates(ListTaskTemplatesRequest request);

        /// <summary>
        /// Paginator for ListTrafficDistributionGroups operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListTrafficDistributionGroupsPaginator ListTrafficDistributionGroups(ListTrafficDistributionGroupsRequest request);

        /// <summary>
        /// Paginator for ListTrafficDistributionGroupUsers operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListTrafficDistributionGroupUsersPaginator ListTrafficDistributionGroupUsers(ListTrafficDistributionGroupUsersRequest request);

        /// <summary>
        /// Paginator for ListUseCases operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListUseCasesPaginator ListUseCases(ListUseCasesRequest request);

        /// <summary>
        /// Paginator for ListUserHierarchyGroups operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListUserHierarchyGroupsPaginator ListUserHierarchyGroups(ListUserHierarchyGroupsRequest request);

        /// <summary>
        /// Paginator for ListUserProficiencies operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListUserProficienciesPaginator ListUserProficiencies(ListUserProficienciesRequest request);

        /// <summary>
        /// Paginator for ListUsers operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListUsersPaginator ListUsers(ListUsersRequest request);

        /// <summary>
        /// Paginator for ListViews operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListViewsPaginator ListViews(ListViewsRequest request);

        /// <summary>
        /// Paginator for ListViewVersions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListViewVersionsPaginator ListViewVersions(ListViewVersionsRequest request);

        /// <summary>
        /// Paginator for SearchAgentStatuses operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        ISearchAgentStatusesPaginator SearchAgentStatuses(SearchAgentStatusesRequest request);

        /// <summary>
        /// Paginator for SearchAvailablePhoneNumbers operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        ISearchAvailablePhoneNumbersPaginator SearchAvailablePhoneNumbers(SearchAvailablePhoneNumbersRequest request);

        /// <summary>
        /// Paginator for SearchContactFlowModules operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        ISearchContactFlowModulesPaginator SearchContactFlowModules(SearchContactFlowModulesRequest request);

        /// <summary>
        /// Paginator for SearchContactFlows operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        ISearchContactFlowsPaginator SearchContactFlows(SearchContactFlowsRequest request);

        /// <summary>
        /// Paginator for SearchContacts operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        ISearchContactsPaginator SearchContacts(SearchContactsRequest request);

        /// <summary>
        /// Paginator for SearchHoursOfOperationOverrides operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        ISearchHoursOfOperationOverridesPaginator SearchHoursOfOperationOverrides(SearchHoursOfOperationOverridesRequest request);

        /// <summary>
        /// Paginator for SearchHoursOfOperations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        ISearchHoursOfOperationsPaginator SearchHoursOfOperations(SearchHoursOfOperationsRequest request);

        /// <summary>
        /// Paginator for SearchPredefinedAttributes operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        ISearchPredefinedAttributesPaginator SearchPredefinedAttributes(SearchPredefinedAttributesRequest request);

        /// <summary>
        /// Paginator for SearchPrompts operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        ISearchPromptsPaginator SearchPrompts(SearchPromptsRequest request);

        /// <summary>
        /// Paginator for SearchQueues operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        ISearchQueuesPaginator SearchQueues(SearchQueuesRequest request);

        /// <summary>
        /// Paginator for SearchQuickConnects operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        ISearchQuickConnectsPaginator SearchQuickConnects(SearchQuickConnectsRequest request);

        /// <summary>
        /// Paginator for SearchResourceTags operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        ISearchResourceTagsPaginator SearchResourceTags(SearchResourceTagsRequest request);

        /// <summary>
        /// Paginator for SearchRoutingProfiles operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        ISearchRoutingProfilesPaginator SearchRoutingProfiles(SearchRoutingProfilesRequest request);

        /// <summary>
        /// Paginator for SearchSecurityProfiles operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        ISearchSecurityProfilesPaginator SearchSecurityProfiles(SearchSecurityProfilesRequest request);

        /// <summary>
        /// Paginator for SearchUserHierarchyGroups operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        ISearchUserHierarchyGroupsPaginator SearchUserHierarchyGroups(SearchUserHierarchyGroupsRequest request);

        /// <summary>
        /// Paginator for SearchUsers operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        ISearchUsersPaginator SearchUsers(SearchUsersRequest request);

        /// <summary>
        /// Paginator for SearchVocabularies operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        ISearchVocabulariesPaginator SearchVocabularies(SearchVocabulariesRequest request);
    }
}