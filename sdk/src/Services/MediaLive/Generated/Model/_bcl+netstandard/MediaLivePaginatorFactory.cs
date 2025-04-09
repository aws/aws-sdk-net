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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Paginators for the MediaLive service
    ///</summary>
    public class MediaLivePaginatorFactory : IMediaLivePaginatorFactory
    {
        private readonly IAmazonMediaLive client;

        internal MediaLivePaginatorFactory(IAmazonMediaLive client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for DescribeSchedule operation
        ///</summary>
        public IDescribeSchedulePaginator DescribeSchedule(DescribeScheduleRequest request) 
        {
            return new DescribeSchedulePaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListChannelPlacementGroups operation
        ///</summary>
        public IListChannelPlacementGroupsPaginator ListChannelPlacementGroups(ListChannelPlacementGroupsRequest request) 
        {
            return new ListChannelPlacementGroupsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListChannels operation
        ///</summary>
        public IListChannelsPaginator ListChannels(ListChannelsRequest request) 
        {
            return new ListChannelsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListCloudWatchAlarmTemplateGroups operation
        ///</summary>
        public IListCloudWatchAlarmTemplateGroupsPaginator ListCloudWatchAlarmTemplateGroups(ListCloudWatchAlarmTemplateGroupsRequest request) 
        {
            return new ListCloudWatchAlarmTemplateGroupsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListCloudWatchAlarmTemplates operation
        ///</summary>
        public IListCloudWatchAlarmTemplatesPaginator ListCloudWatchAlarmTemplates(ListCloudWatchAlarmTemplatesRequest request) 
        {
            return new ListCloudWatchAlarmTemplatesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListClusters operation
        ///</summary>
        public IListClustersPaginator ListClusters(ListClustersRequest request) 
        {
            return new ListClustersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListEventBridgeRuleTemplateGroups operation
        ///</summary>
        public IListEventBridgeRuleTemplateGroupsPaginator ListEventBridgeRuleTemplateGroups(ListEventBridgeRuleTemplateGroupsRequest request) 
        {
            return new ListEventBridgeRuleTemplateGroupsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListEventBridgeRuleTemplates operation
        ///</summary>
        public IListEventBridgeRuleTemplatesPaginator ListEventBridgeRuleTemplates(ListEventBridgeRuleTemplatesRequest request) 
        {
            return new ListEventBridgeRuleTemplatesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListInputDevices operation
        ///</summary>
        public IListInputDevicesPaginator ListInputDevices(ListInputDevicesRequest request) 
        {
            return new ListInputDevicesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListInputDeviceTransfers operation
        ///</summary>
        public IListInputDeviceTransfersPaginator ListInputDeviceTransfers(ListInputDeviceTransfersRequest request) 
        {
            return new ListInputDeviceTransfersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListInputs operation
        ///</summary>
        public IListInputsPaginator ListInputs(ListInputsRequest request) 
        {
            return new ListInputsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListInputSecurityGroups operation
        ///</summary>
        public IListInputSecurityGroupsPaginator ListInputSecurityGroups(ListInputSecurityGroupsRequest request) 
        {
            return new ListInputSecurityGroupsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListMultiplexes operation
        ///</summary>
        public IListMultiplexesPaginator ListMultiplexes(ListMultiplexesRequest request) 
        {
            return new ListMultiplexesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListMultiplexPrograms operation
        ///</summary>
        public IListMultiplexProgramsPaginator ListMultiplexPrograms(ListMultiplexProgramsRequest request) 
        {
            return new ListMultiplexProgramsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListNetworks operation
        ///</summary>
        public IListNetworksPaginator ListNetworks(ListNetworksRequest request) 
        {
            return new ListNetworksPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListNodes operation
        ///</summary>
        public IListNodesPaginator ListNodes(ListNodesRequest request) 
        {
            return new ListNodesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListOfferings operation
        ///</summary>
        public IListOfferingsPaginator ListOfferings(ListOfferingsRequest request) 
        {
            return new ListOfferingsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListReservations operation
        ///</summary>
        public IListReservationsPaginator ListReservations(ListReservationsRequest request) 
        {
            return new ListReservationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSdiSources operation
        ///</summary>
        public IListSdiSourcesPaginator ListSdiSources(ListSdiSourcesRequest request) 
        {
            return new ListSdiSourcesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSignalMaps operation
        ///</summary>
        public IListSignalMapsPaginator ListSignalMaps(ListSignalMapsRequest request) 
        {
            return new ListSignalMapsPaginator(this.client, request);
        }
    }
}