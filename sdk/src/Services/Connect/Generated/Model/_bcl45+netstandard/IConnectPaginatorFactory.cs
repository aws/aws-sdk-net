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
        IGetCurrentMetricDataPaginator GetCurrentMetricData(GetCurrentMetricDataRequest request);

        /// <summary>
        /// Paginator for GetCurrentUserData operation
        ///</summary>
        IGetCurrentUserDataPaginator GetCurrentUserData(GetCurrentUserDataRequest request);

        /// <summary>
        /// Paginator for GetMetricData operation
        ///</summary>
        IGetMetricDataPaginator GetMetricData(GetMetricDataRequest request);

        /// <summary>
        /// Paginator for GetMetricDataV2 operation
        ///</summary>
        IGetMetricDataV2Paginator GetMetricDataV2(GetMetricDataV2Request request);

        /// <summary>
        /// Paginator for ListAgentStatuses operation
        ///</summary>
        IListAgentStatusesPaginator ListAgentStatuses(ListAgentStatusesRequest request);

        /// <summary>
        /// Paginator for ListApprovedOrigins operation
        ///</summary>
        IListApprovedOriginsPaginator ListApprovedOrigins(ListApprovedOriginsRequest request);

        /// <summary>
        /// Paginator for ListBots operation
        ///</summary>
        IListBotsPaginator ListBots(ListBotsRequest request);

        /// <summary>
        /// Paginator for ListContactFlowModules operation
        ///</summary>
        IListContactFlowModulesPaginator ListContactFlowModules(ListContactFlowModulesRequest request);

        /// <summary>
        /// Paginator for ListContactFlows operation
        ///</summary>
        IListContactFlowsPaginator ListContactFlows(ListContactFlowsRequest request);

        /// <summary>
        /// Paginator for ListContactReferences operation
        ///</summary>
        IListContactReferencesPaginator ListContactReferences(ListContactReferencesRequest request);

        /// <summary>
        /// Paginator for ListDefaultVocabularies operation
        ///</summary>
        IListDefaultVocabulariesPaginator ListDefaultVocabularies(ListDefaultVocabulariesRequest request);

        /// <summary>
        /// Paginator for ListHoursOfOperations operation
        ///</summary>
        IListHoursOfOperationsPaginator ListHoursOfOperations(ListHoursOfOperationsRequest request);

        /// <summary>
        /// Paginator for ListInstanceAttributes operation
        ///</summary>
        IListInstanceAttributesPaginator ListInstanceAttributes(ListInstanceAttributesRequest request);

        /// <summary>
        /// Paginator for ListInstances operation
        ///</summary>
        IListInstancesPaginator ListInstances(ListInstancesRequest request);

        /// <summary>
        /// Paginator for ListInstanceStorageConfigs operation
        ///</summary>
        IListInstanceStorageConfigsPaginator ListInstanceStorageConfigs(ListInstanceStorageConfigsRequest request);

        /// <summary>
        /// Paginator for ListIntegrationAssociations operation
        ///</summary>
        IListIntegrationAssociationsPaginator ListIntegrationAssociations(ListIntegrationAssociationsRequest request);

        /// <summary>
        /// Paginator for ListLambdaFunctions operation
        ///</summary>
        IListLambdaFunctionsPaginator ListLambdaFunctions(ListLambdaFunctionsRequest request);

        /// <summary>
        /// Paginator for ListLexBots operation
        ///</summary>
        IListLexBotsPaginator ListLexBots(ListLexBotsRequest request);

        /// <summary>
        /// Paginator for ListPhoneNumbers operation
        ///</summary>
        IListPhoneNumbersPaginator ListPhoneNumbers(ListPhoneNumbersRequest request);

        /// <summary>
        /// Paginator for ListPhoneNumbersV2 operation
        ///</summary>
        IListPhoneNumbersV2Paginator ListPhoneNumbersV2(ListPhoneNumbersV2Request request);

        /// <summary>
        /// Paginator for ListPrompts operation
        ///</summary>
        IListPromptsPaginator ListPrompts(ListPromptsRequest request);

        /// <summary>
        /// Paginator for ListQueueQuickConnects operation
        ///</summary>
        IListQueueQuickConnectsPaginator ListQueueQuickConnects(ListQueueQuickConnectsRequest request);

        /// <summary>
        /// Paginator for ListQueues operation
        ///</summary>
        IListQueuesPaginator ListQueues(ListQueuesRequest request);

        /// <summary>
        /// Paginator for ListQuickConnects operation
        ///</summary>
        IListQuickConnectsPaginator ListQuickConnects(ListQuickConnectsRequest request);

        /// <summary>
        /// Paginator for ListRoutingProfileQueues operation
        ///</summary>
        IListRoutingProfileQueuesPaginator ListRoutingProfileQueues(ListRoutingProfileQueuesRequest request);

        /// <summary>
        /// Paginator for ListRoutingProfiles operation
        ///</summary>
        IListRoutingProfilesPaginator ListRoutingProfiles(ListRoutingProfilesRequest request);

        /// <summary>
        /// Paginator for ListRules operation
        ///</summary>
        IListRulesPaginator ListRules(ListRulesRequest request);

        /// <summary>
        /// Paginator for ListSecurityKeys operation
        ///</summary>
        IListSecurityKeysPaginator ListSecurityKeys(ListSecurityKeysRequest request);

        /// <summary>
        /// Paginator for ListSecurityProfilePermissions operation
        ///</summary>
        IListSecurityProfilePermissionsPaginator ListSecurityProfilePermissions(ListSecurityProfilePermissionsRequest request);

        /// <summary>
        /// Paginator for ListSecurityProfiles operation
        ///</summary>
        IListSecurityProfilesPaginator ListSecurityProfiles(ListSecurityProfilesRequest request);

        /// <summary>
        /// Paginator for ListTaskTemplates operation
        ///</summary>
        IListTaskTemplatesPaginator ListTaskTemplates(ListTaskTemplatesRequest request);

        /// <summary>
        /// Paginator for ListTrafficDistributionGroups operation
        ///</summary>
        IListTrafficDistributionGroupsPaginator ListTrafficDistributionGroups(ListTrafficDistributionGroupsRequest request);

        /// <summary>
        /// Paginator for ListUseCases operation
        ///</summary>
        IListUseCasesPaginator ListUseCases(ListUseCasesRequest request);

        /// <summary>
        /// Paginator for ListUserHierarchyGroups operation
        ///</summary>
        IListUserHierarchyGroupsPaginator ListUserHierarchyGroups(ListUserHierarchyGroupsRequest request);

        /// <summary>
        /// Paginator for ListUsers operation
        ///</summary>
        IListUsersPaginator ListUsers(ListUsersRequest request);

        /// <summary>
        /// Paginator for SearchAvailablePhoneNumbers operation
        ///</summary>
        ISearchAvailablePhoneNumbersPaginator SearchAvailablePhoneNumbers(SearchAvailablePhoneNumbersRequest request);

        /// <summary>
        /// Paginator for SearchQueues operation
        ///</summary>
        ISearchQueuesPaginator SearchQueues(SearchQueuesRequest request);

        /// <summary>
        /// Paginator for SearchRoutingProfiles operation
        ///</summary>
        ISearchRoutingProfilesPaginator SearchRoutingProfiles(SearchRoutingProfilesRequest request);

        /// <summary>
        /// Paginator for SearchSecurityProfiles operation
        ///</summary>
        ISearchSecurityProfilesPaginator SearchSecurityProfiles(SearchSecurityProfilesRequest request);

        /// <summary>
        /// Paginator for SearchUsers operation
        ///</summary>
        ISearchUsersPaginator SearchUsers(SearchUsersRequest request);

        /// <summary>
        /// Paginator for SearchVocabularies operation
        ///</summary>
        ISearchVocabulariesPaginator SearchVocabularies(SearchVocabulariesRequest request);
    }
}