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
        /// Paginator for ListBots operation
        ///</summary>
        public IListBotsPaginator ListBots(ListBotsRequest request) 
        {
            return new ListBotsPaginator(this.client, request);
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
        /// Paginator for ListUsers operation
        ///</summary>
        public IListUsersPaginator ListUsers(ListUsersRequest request) 
        {
            return new ListUsersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for SearchAvailablePhoneNumbers operation
        ///</summary>
        public ISearchAvailablePhoneNumbersPaginator SearchAvailablePhoneNumbers(SearchAvailablePhoneNumbersRequest request) 
        {
            return new SearchAvailablePhoneNumbersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for SearchQueues operation
        ///</summary>
        public ISearchQueuesPaginator SearchQueues(SearchQueuesRequest request) 
        {
            return new SearchQueuesPaginator(this.client, request);
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