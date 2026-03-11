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
 * Do not modify this file. This file is generated from the notifications-2018-05-10.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.Notifications.Model
{
    /// <summary>
    /// Paginators for the Notifications service
    ///</summary>
    public class NotificationsPaginatorFactory : INotificationsPaginatorFactory
    {
        private readonly IAmazonNotifications client;

        internal NotificationsPaginatorFactory(IAmazonNotifications client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListChannels operation
        ///</summary>
        public IListChannelsPaginator ListChannels(ListChannelsRequest request) 
        {
            return new ListChannelsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListEventRules operation
        ///</summary>
        public IListEventRulesPaginator ListEventRules(ListEventRulesRequest request) 
        {
            return new ListEventRulesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListManagedNotificationChannelAssociations operation
        ///</summary>
        public IListManagedNotificationChannelAssociationsPaginator ListManagedNotificationChannelAssociations(ListManagedNotificationChannelAssociationsRequest request) 
        {
            return new ListManagedNotificationChannelAssociationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListManagedNotificationChildEvents operation
        ///</summary>
        public IListManagedNotificationChildEventsPaginator ListManagedNotificationChildEvents(ListManagedNotificationChildEventsRequest request) 
        {
            return new ListManagedNotificationChildEventsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListManagedNotificationConfigurations operation
        ///</summary>
        public IListManagedNotificationConfigurationsPaginator ListManagedNotificationConfigurations(ListManagedNotificationConfigurationsRequest request) 
        {
            return new ListManagedNotificationConfigurationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListManagedNotificationEvents operation
        ///</summary>
        public IListManagedNotificationEventsPaginator ListManagedNotificationEvents(ListManagedNotificationEventsRequest request) 
        {
            return new ListManagedNotificationEventsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListMemberAccounts operation
        ///</summary>
        public IListMemberAccountsPaginator ListMemberAccounts(ListMemberAccountsRequest request) 
        {
            return new ListMemberAccountsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListNotificationConfigurations operation
        ///</summary>
        public IListNotificationConfigurationsPaginator ListNotificationConfigurations(ListNotificationConfigurationsRequest request) 
        {
            return new ListNotificationConfigurationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListNotificationEvents operation
        ///</summary>
        public IListNotificationEventsPaginator ListNotificationEvents(ListNotificationEventsRequest request) 
        {
            return new ListNotificationEventsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListNotificationHubs operation
        ///</summary>
        public IListNotificationHubsPaginator ListNotificationHubs(ListNotificationHubsRequest request) 
        {
            return new ListNotificationHubsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListOrganizationalUnits operation
        ///</summary>
        public IListOrganizationalUnitsPaginator ListOrganizationalUnits(ListOrganizationalUnitsRequest request) 
        {
            return new ListOrganizationalUnitsPaginator(this.client, request);
        }
    }
}