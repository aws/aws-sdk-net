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

#pragma warning disable CS0612,CS0618
namespace Amazon.Notifications.Model
{
    /// <summary>
    /// Paginators for the Notifications service
    ///</summary>
    public interface INotificationsPaginatorFactory
    {

        /// <summary>
        /// Paginator for ListChannels operation
        ///</summary>
        IListChannelsPaginator ListChannels(ListChannelsRequest request);

        /// <summary>
        /// Paginator for ListEventRules operation
        ///</summary>
        IListEventRulesPaginator ListEventRules(ListEventRulesRequest request);

        /// <summary>
        /// Paginator for ListManagedNotificationChannelAssociations operation
        ///</summary>
        IListManagedNotificationChannelAssociationsPaginator ListManagedNotificationChannelAssociations(ListManagedNotificationChannelAssociationsRequest request);

        /// <summary>
        /// Paginator for ListManagedNotificationChildEvents operation
        ///</summary>
        IListManagedNotificationChildEventsPaginator ListManagedNotificationChildEvents(ListManagedNotificationChildEventsRequest request);

        /// <summary>
        /// Paginator for ListManagedNotificationConfigurations operation
        ///</summary>
        IListManagedNotificationConfigurationsPaginator ListManagedNotificationConfigurations(ListManagedNotificationConfigurationsRequest request);

        /// <summary>
        /// Paginator for ListManagedNotificationEvents operation
        ///</summary>
        IListManagedNotificationEventsPaginator ListManagedNotificationEvents(ListManagedNotificationEventsRequest request);

        /// <summary>
        /// Paginator for ListNotificationConfigurations operation
        ///</summary>
        IListNotificationConfigurationsPaginator ListNotificationConfigurations(ListNotificationConfigurationsRequest request);

        /// <summary>
        /// Paginator for ListNotificationEvents operation
        ///</summary>
        IListNotificationEventsPaginator ListNotificationEvents(ListNotificationEventsRequest request);

        /// <summary>
        /// Paginator for ListNotificationHubs operation
        ///</summary>
        IListNotificationHubsPaginator ListNotificationHubs(ListNotificationHubsRequest request);
    }
}