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
 * Do not modify this file. This file is generated from the mailmanager-2023-10-17.normal.json service model.
 */

#pragma warning disable CS0612,CS0618
namespace Amazon.MailManager.Model
{
    /// <summary>
    /// Paginators for the MailManager service
    ///</summary>
    public interface IMailManagerPaginatorFactory
    {

        /// <summary>
        /// Paginator for ListAddonInstances operation
        ///</summary>
        IListAddonInstancesPaginator ListAddonInstances(ListAddonInstancesRequest request);

        /// <summary>
        /// Paginator for ListAddonSubscriptions operation
        ///</summary>
        IListAddonSubscriptionsPaginator ListAddonSubscriptions(ListAddonSubscriptionsRequest request);

        /// <summary>
        /// Paginator for ListArchiveExports operation
        ///</summary>
        IListArchiveExportsPaginator ListArchiveExports(ListArchiveExportsRequest request);

        /// <summary>
        /// Paginator for ListArchives operation
        ///</summary>
        IListArchivesPaginator ListArchives(ListArchivesRequest request);

        /// <summary>
        /// Paginator for ListArchiveSearches operation
        ///</summary>
        IListArchiveSearchesPaginator ListArchiveSearches(ListArchiveSearchesRequest request);

        /// <summary>
        /// Paginator for ListIngressPoints operation
        ///</summary>
        IListIngressPointsPaginator ListIngressPoints(ListIngressPointsRequest request);

        /// <summary>
        /// Paginator for ListRelays operation
        ///</summary>
        IListRelaysPaginator ListRelays(ListRelaysRequest request);

        /// <summary>
        /// Paginator for ListRuleSets operation
        ///</summary>
        IListRuleSetsPaginator ListRuleSets(ListRuleSetsRequest request);

        /// <summary>
        /// Paginator for ListTrafficPolicies operation
        ///</summary>
        IListTrafficPoliciesPaginator ListTrafficPolicies(ListTrafficPoliciesRequest request);
    }
}