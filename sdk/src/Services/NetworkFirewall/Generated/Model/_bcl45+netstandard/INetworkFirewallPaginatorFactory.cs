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
 * Do not modify this file. This file is generated from the network-firewall-2020-11-12.normal.json service model.
 */

namespace Amazon.NetworkFirewall.Model
{
    /// <summary>
    /// Paginators for the NetworkFirewall service
    ///</summary>
    public interface INetworkFirewallPaginatorFactory
    {

        /// <summary>
        /// Paginator for ListFirewallPolicies operation
        ///</summary>
        IListFirewallPoliciesPaginator ListFirewallPolicies(ListFirewallPoliciesRequest request);

        /// <summary>
        /// Paginator for ListFirewalls operation
        ///</summary>
        IListFirewallsPaginator ListFirewalls(ListFirewallsRequest request);

        /// <summary>
        /// Paginator for ListRuleGroups operation
        ///</summary>
        IListRuleGroupsPaginator ListRuleGroups(ListRuleGroupsRequest request);

        /// <summary>
        /// Paginator for ListTagsForResource operation
        ///</summary>
        IListTagsForResourcePaginator ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Paginator for ListTLSInspectionConfigurations operation
        ///</summary>
        IListTLSInspectionConfigurationsPaginator ListTLSInspectionConfigurations(ListTLSInspectionConfigurationsRequest request);
    }
}