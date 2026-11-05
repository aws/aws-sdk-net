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

namespace Amazon.Notifications.Model
{
    /// <summary>
    /// Paginators for the Notifications service
    /// </summary>
    public interface INotificationsPaginatorFactory
    {
        /// <summary>
        /// Paginator for ListChannels operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListChannelsPaginator ListChannels(ListChannelsRequest request);

        /// <summary>
        /// Paginator for ListEventRules operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListEventRulesPaginator ListEventRules(ListEventRulesRequest request);

        /// <summary>
        /// Paginator for ListManagedNotificationChannelAssociations operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListManagedNotificationChannelAssociationsPaginator ListManagedNotificationChannelAssociations(ListManagedNotificationChannelAssociationsRequest request);

        /// <summary>
        /// Paginator for ListManagedNotificationChildEvents operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListManagedNotificationChildEventsPaginator ListManagedNotificationChildEvents(ListManagedNotificationChildEventsRequest request);

        /// <summary>
        /// Paginator for ListManagedNotificationConfigurations operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListManagedNotificationConfigurationsPaginator ListManagedNotificationConfigurations(ListManagedNotificationConfigurationsRequest request);

        /// <summary>
        /// Paginator for ListManagedNotificationEvents operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListManagedNotificationEventsPaginator ListManagedNotificationEvents(ListManagedNotificationEventsRequest request);

        /// <summary>
        /// Paginator for ListMemberAccounts operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListMemberAccountsPaginator ListMemberAccounts(ListMemberAccountsRequest request);

        /// <summary>
        /// Paginator for ListNotificationConfigurations operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListNotificationConfigurationsPaginator ListNotificationConfigurations(ListNotificationConfigurationsRequest request);

        /// <summary>
        /// Paginator for ListNotificationEvents operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListNotificationEventsPaginator ListNotificationEvents(ListNotificationEventsRequest request);

        /// <summary>
        /// Paginator for ListNotificationHubs operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListNotificationHubsPaginator ListNotificationHubs(ListNotificationHubsRequest request);

        /// <summary>
        /// Paginator for ListOrganizationalUnits operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListOrganizationalUnitsPaginator ListOrganizationalUnits(ListOrganizationalUnitsRequest request);
    }
}
