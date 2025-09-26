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

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.Connect.Model
{
    /// <summary>
    /// Paginators for the Connect service
    ///</summary>
    public class ConnectPaginatorFactory : IConnectPaginatorFactory
    {
        private readonly IAmazonConnect client;

        internal ConnectPaginatorFactory(IAmazonConnect client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for GetCurrentMetricData operation
        ///</summary>
        public IGetCurrentMetricDataPaginator GetCurrentMetricData(GetCurrentMetricDataRequest request) 
        {
            return new GetCurrentMetricDataPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetCurrentUserData operation
        ///</summary>
        public IGetCurrentUserDataPaginator GetCurrentUserData(GetCurrentUserDataRequest request) 
        {
            return new GetCurrentUserDataPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetMetricData operation
        ///</summary>
        public IGetMetricDataPaginator GetMetricData(GetMetricDataRequest request) 
        {
            return new GetMetricDataPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetMetricDataV2 operation
        ///</summary>
        public IGetMetricDataV2Paginator GetMetricDataV2(GetMetricDataV2Request request) 
        {
            return new GetMetricDataV2Paginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAgentStatuses operation
        ///</summary>
        public IListAgentStatusesPaginator ListAgentStatuses(ListAgentStatusesRequest request) 
        {
            return new ListAgentStatusesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListApprovedOrigins operation
        ///</summary>
        public IListApprovedOriginsPaginator ListApprovedOrigins(ListApprovedOriginsRequest request) 
        {
            return new ListApprovedOriginsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAuthenticationProfiles operation
        ///</summary>
        public IListAuthenticationProfilesPaginator ListAuthenticationProfiles(ListAuthenticationProfilesRequest request) 
        {
            return new ListAuthenticationProfilesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListBots operation
        ///</summary>
        public IListBotsPaginator ListBots(ListBotsRequest request) 
        {
            return new ListBotsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListContactEvaluations operation
        ///</summary>
        public IListContactEvaluationsPaginator ListContactEvaluations(ListContactEvaluationsRequest request) 
        {
            return new ListContactEvaluationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListContactFlowModules operation
        ///</summary>
        public IListContactFlowModulesPaginator ListContactFlowModules(ListContactFlowModulesRequest request) 
        {
            return new ListContactFlowModulesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListContactFlows operation
        ///</summary>
        public IListContactFlowsPaginator ListContactFlows(ListContactFlowsRequest request) 
        {
            return new ListContactFlowsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListContactFlowVersions operation
        ///</summary>
        public IListContactFlowVersionsPaginator ListContactFlowVersions(ListContactFlowVersionsRequest request) 
        {
            return new ListContactFlowVersionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListContactReferences operation
        ///</summary>
        public IListContactReferencesPaginator ListContactReferences(ListContactReferencesRequest request) 
        {
            return new ListContactReferencesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDefaultVocabularies operation
        ///</summary>
        public IListDefaultVocabulariesPaginator ListDefaultVocabularies(ListDefaultVocabulariesRequest request) 
        {
            return new ListDefaultVocabulariesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListEvaluationForms operation
        ///</summary>
        public IListEvaluationFormsPaginator ListEvaluationForms(ListEvaluationFormsRequest request) 
        {
            return new ListEvaluationFormsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListEvaluationFormVersions operation
        ///</summary>
        public IListEvaluationFormVersionsPaginator ListEvaluationFormVersions(ListEvaluationFormVersionsRequest request) 
        {
            return new ListEvaluationFormVersionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListFlowAssociations operation
        ///</summary>
        public IListFlowAssociationsPaginator ListFlowAssociations(ListFlowAssociationsRequest request) 
        {
            return new ListFlowAssociationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListHoursOfOperationOverrides operation
        ///</summary>
        public IListHoursOfOperationOverridesPaginator ListHoursOfOperationOverrides(ListHoursOfOperationOverridesRequest request) 
        {
            return new ListHoursOfOperationOverridesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListHoursOfOperations operation
        ///</summary>
        public IListHoursOfOperationsPaginator ListHoursOfOperations(ListHoursOfOperationsRequest request) 
        {
            return new ListHoursOfOperationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListInstanceAttributes operation
        ///</summary>
        public IListInstanceAttributesPaginator ListInstanceAttributes(ListInstanceAttributesRequest request) 
        {
            return new ListInstanceAttributesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListInstances operation
        ///</summary>
        public IListInstancesPaginator ListInstances(ListInstancesRequest request) 
        {
            return new ListInstancesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListInstanceStorageConfigs operation
        ///</summary>
        public IListInstanceStorageConfigsPaginator ListInstanceStorageConfigs(ListInstanceStorageConfigsRequest request) 
        {
            return new ListInstanceStorageConfigsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListIntegrationAssociations operation
        ///</summary>
        public IListIntegrationAssociationsPaginator ListIntegrationAssociations(ListIntegrationAssociationsRequest request) 
        {
            return new ListIntegrationAssociationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListLambdaFunctions operation
        ///</summary>
        public IListLambdaFunctionsPaginator ListLambdaFunctions(ListLambdaFunctionsRequest request) 
        {
            return new ListLambdaFunctionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListLexBots operation
        ///</summary>
        public IListLexBotsPaginator ListLexBots(ListLexBotsRequest request) 
        {
            return new ListLexBotsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPhoneNumbers operation
        ///</summary>
        public IListPhoneNumbersPaginator ListPhoneNumbers(ListPhoneNumbersRequest request) 
        {
            return new ListPhoneNumbersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPhoneNumbersV2 operation
        ///</summary>
        public IListPhoneNumbersV2Paginator ListPhoneNumbersV2(ListPhoneNumbersV2Request request) 
        {
            return new ListPhoneNumbersV2Paginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPredefinedAttributes operation
        ///</summary>
        public IListPredefinedAttributesPaginator ListPredefinedAttributes(ListPredefinedAttributesRequest request) 
        {
            return new ListPredefinedAttributesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPrompts operation
        ///</summary>
        public IListPromptsPaginator ListPrompts(ListPromptsRequest request) 
        {
            return new ListPromptsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListQueueQuickConnects operation
        ///</summary>
        public IListQueueQuickConnectsPaginator ListQueueQuickConnects(ListQueueQuickConnectsRequest request) 
        {
            return new ListQueueQuickConnectsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListQueues operation
        ///</summary>
        public IListQueuesPaginator ListQueues(ListQueuesRequest request) 
        {
            return new ListQueuesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListQuickConnects operation
        ///</summary>
        public IListQuickConnectsPaginator ListQuickConnects(ListQuickConnectsRequest request) 
        {
            return new ListQuickConnectsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListRealtimeContactAnalysisSegmentsV2 operation
        ///</summary>
        public IListRealtimeContactAnalysisSegmentsV2Paginator ListRealtimeContactAnalysisSegmentsV2(ListRealtimeContactAnalysisSegmentsV2Request request) 
        {
            return new ListRealtimeContactAnalysisSegmentsV2Paginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListRoutingProfileManualAssignmentQueues operation
        ///</summary>
        public IListRoutingProfileManualAssignmentQueuesPaginator ListRoutingProfileManualAssignmentQueues(ListRoutingProfileManualAssignmentQueuesRequest request) 
        {
            return new ListRoutingProfileManualAssignmentQueuesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListRoutingProfileQueues operation
        ///</summary>
        public IListRoutingProfileQueuesPaginator ListRoutingProfileQueues(ListRoutingProfileQueuesRequest request) 
        {
            return new ListRoutingProfileQueuesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListRoutingProfiles operation
        ///</summary>
        public IListRoutingProfilesPaginator ListRoutingProfiles(ListRoutingProfilesRequest request) 
        {
            return new ListRoutingProfilesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListRules operation
        ///</summary>
        public IListRulesPaginator ListRules(ListRulesRequest request) 
        {
            return new ListRulesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSecurityKeys operation
        ///</summary>
        public IListSecurityKeysPaginator ListSecurityKeys(ListSecurityKeysRequest request) 
        {
            return new ListSecurityKeysPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSecurityProfileApplications operation
        ///</summary>
        public IListSecurityProfileApplicationsPaginator ListSecurityProfileApplications(ListSecurityProfileApplicationsRequest request) 
        {
            return new ListSecurityProfileApplicationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSecurityProfilePermissions operation
        ///</summary>
        public IListSecurityProfilePermissionsPaginator ListSecurityProfilePermissions(ListSecurityProfilePermissionsRequest request) 
        {
            return new ListSecurityProfilePermissionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSecurityProfiles operation
        ///</summary>
        public IListSecurityProfilesPaginator ListSecurityProfiles(ListSecurityProfilesRequest request) 
        {
            return new ListSecurityProfilesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTaskTemplates operation
        ///</summary>
        public IListTaskTemplatesPaginator ListTaskTemplates(ListTaskTemplatesRequest request) 
        {
            return new ListTaskTemplatesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTrafficDistributionGroups operation
        ///</summary>
        public IListTrafficDistributionGroupsPaginator ListTrafficDistributionGroups(ListTrafficDistributionGroupsRequest request) 
        {
            return new ListTrafficDistributionGroupsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTrafficDistributionGroupUsers operation
        ///</summary>
        public IListTrafficDistributionGroupUsersPaginator ListTrafficDistributionGroupUsers(ListTrafficDistributionGroupUsersRequest request) 
        {
            return new ListTrafficDistributionGroupUsersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListUseCases operation
        ///</summary>
        public IListUseCasesPaginator ListUseCases(ListUseCasesRequest request) 
        {
            return new ListUseCasesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListUserHierarchyGroups operation
        ///</summary>
        public IListUserHierarchyGroupsPaginator ListUserHierarchyGroups(ListUserHierarchyGroupsRequest request) 
        {
            return new ListUserHierarchyGroupsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListUserProficiencies operation
        ///</summary>
        public IListUserProficienciesPaginator ListUserProficiencies(ListUserProficienciesRequest request) 
        {
            return new ListUserProficienciesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListUsers operation
        ///</summary>
        public IListUsersPaginator ListUsers(ListUsersRequest request) 
        {
            return new ListUsersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListViews operation
        ///</summary>
        public IListViewsPaginator ListViews(ListViewsRequest request) 
        {
            return new ListViewsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListViewVersions operation
        ///</summary>
        public IListViewVersionsPaginator ListViewVersions(ListViewVersionsRequest request) 
        {
            return new ListViewVersionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for SearchAgentStatuses operation
        ///</summary>
        public ISearchAgentStatusesPaginator SearchAgentStatuses(SearchAgentStatusesRequest request) 
        {
            return new SearchAgentStatusesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for SearchAvailablePhoneNumbers operation
        ///</summary>
        public ISearchAvailablePhoneNumbersPaginator SearchAvailablePhoneNumbers(SearchAvailablePhoneNumbersRequest request) 
        {
            return new SearchAvailablePhoneNumbersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for SearchContactFlowModules operation
        ///</summary>
        public ISearchContactFlowModulesPaginator SearchContactFlowModules(SearchContactFlowModulesRequest request) 
        {
            return new SearchContactFlowModulesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for SearchContactFlows operation
        ///</summary>
        public ISearchContactFlowsPaginator SearchContactFlows(SearchContactFlowsRequest request) 
        {
            return new SearchContactFlowsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for SearchContacts operation
        ///</summary>
        public ISearchContactsPaginator SearchContacts(SearchContactsRequest request) 
        {
            return new SearchContactsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for SearchHoursOfOperationOverrides operation
        ///</summary>
        public ISearchHoursOfOperationOverridesPaginator SearchHoursOfOperationOverrides(SearchHoursOfOperationOverridesRequest request) 
        {
            return new SearchHoursOfOperationOverridesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for SearchHoursOfOperations operation
        ///</summary>
        public ISearchHoursOfOperationsPaginator SearchHoursOfOperations(SearchHoursOfOperationsRequest request) 
        {
            return new SearchHoursOfOperationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for SearchPredefinedAttributes operation
        ///</summary>
        public ISearchPredefinedAttributesPaginator SearchPredefinedAttributes(SearchPredefinedAttributesRequest request) 
        {
            return new SearchPredefinedAttributesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for SearchPrompts operation
        ///</summary>
        public ISearchPromptsPaginator SearchPrompts(SearchPromptsRequest request) 
        {
            return new SearchPromptsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for SearchQueues operation
        ///</summary>
        public ISearchQueuesPaginator SearchQueues(SearchQueuesRequest request) 
        {
            return new SearchQueuesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for SearchQuickConnects operation
        ///</summary>
        public ISearchQuickConnectsPaginator SearchQuickConnects(SearchQuickConnectsRequest request) 
        {
            return new SearchQuickConnectsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for SearchResourceTags operation
        ///</summary>
        public ISearchResourceTagsPaginator SearchResourceTags(SearchResourceTagsRequest request) 
        {
            return new SearchResourceTagsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for SearchRoutingProfiles operation
        ///</summary>
        public ISearchRoutingProfilesPaginator SearchRoutingProfiles(SearchRoutingProfilesRequest request) 
        {
            return new SearchRoutingProfilesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for SearchSecurityProfiles operation
        ///</summary>
        public ISearchSecurityProfilesPaginator SearchSecurityProfiles(SearchSecurityProfilesRequest request) 
        {
            return new SearchSecurityProfilesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for SearchUserHierarchyGroups operation
        ///</summary>
        public ISearchUserHierarchyGroupsPaginator SearchUserHierarchyGroups(SearchUserHierarchyGroupsRequest request) 
        {
            return new SearchUserHierarchyGroupsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for SearchUsers operation
        ///</summary>
        public ISearchUsersPaginator SearchUsers(SearchUsersRequest request) 
        {
            return new SearchUsersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for SearchVocabularies operation
        ///</summary>
        public ISearchVocabulariesPaginator SearchVocabularies(SearchVocabulariesRequest request) 
        {
            return new SearchVocabulariesPaginator(this.client, request);
        }
    }
}