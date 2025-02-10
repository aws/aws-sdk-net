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

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.MailManager.Model
{
    /// <summary>
    /// Paginators for the MailManager service
    ///</summary>
    public class MailManagerPaginatorFactory : IMailManagerPaginatorFactory
    {
        private readonly IAmazonMailManager client;

        internal MailManagerPaginatorFactory(IAmazonMailManager client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListAddonInstances operation
        ///</summary>
        public IListAddonInstancesPaginator ListAddonInstances(ListAddonInstancesRequest request) 
        {
            return new ListAddonInstancesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAddonSubscriptions operation
        ///</summary>
        public IListAddonSubscriptionsPaginator ListAddonSubscriptions(ListAddonSubscriptionsRequest request) 
        {
            return new ListAddonSubscriptionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAddressListImportJobs operation
        ///</summary>
        public IListAddressListImportJobsPaginator ListAddressListImportJobs(ListAddressListImportJobsRequest request) 
        {
            return new ListAddressListImportJobsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAddressLists operation
        ///</summary>
        public IListAddressListsPaginator ListAddressLists(ListAddressListsRequest request) 
        {
            return new ListAddressListsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListArchiveExports operation
        ///</summary>
        public IListArchiveExportsPaginator ListArchiveExports(ListArchiveExportsRequest request) 
        {
            return new ListArchiveExportsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListArchives operation
        ///</summary>
        public IListArchivesPaginator ListArchives(ListArchivesRequest request) 
        {
            return new ListArchivesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListArchiveSearches operation
        ///</summary>
        public IListArchiveSearchesPaginator ListArchiveSearches(ListArchiveSearchesRequest request) 
        {
            return new ListArchiveSearchesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListIngressPoints operation
        ///</summary>
        public IListIngressPointsPaginator ListIngressPoints(ListIngressPointsRequest request) 
        {
            return new ListIngressPointsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListMembersOfAddressList operation
        ///</summary>
        public IListMembersOfAddressListPaginator ListMembersOfAddressList(ListMembersOfAddressListRequest request) 
        {
            return new ListMembersOfAddressListPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListRelays operation
        ///</summary>
        public IListRelaysPaginator ListRelays(ListRelaysRequest request) 
        {
            return new ListRelaysPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListRuleSets operation
        ///</summary>
        public IListRuleSetsPaginator ListRuleSets(ListRuleSetsRequest request) 
        {
            return new ListRuleSetsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTrafficPolicies operation
        ///</summary>
        public IListTrafficPoliciesPaginator ListTrafficPolicies(ListTrafficPoliciesRequest request) 
        {
            return new ListTrafficPoliciesPaginator(this.client, request);
        }
    }
}