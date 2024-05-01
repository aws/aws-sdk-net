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
 * Do not modify this file. This file is generated from the iotwireless-2020-11-22.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.IoTWireless.Model
{
    /// <summary>
    /// Paginators for the IoTWireless service
    ///</summary>
    public class IoTWirelessPaginatorFactory : IIoTWirelessPaginatorFactory
    {
        private readonly IAmazonIoTWireless client;

        internal IoTWirelessPaginatorFactory(IAmazonIoTWireless client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListDestinations operation
        ///</summary>
        public IListDestinationsPaginator ListDestinations(ListDestinationsRequest request) 
        {
            return new ListDestinationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDeviceProfiles operation
        ///</summary>
        public IListDeviceProfilesPaginator ListDeviceProfiles(ListDeviceProfilesRequest request) 
        {
            return new ListDeviceProfilesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListFuotaTasks operation
        ///</summary>
        public IListFuotaTasksPaginator ListFuotaTasks(ListFuotaTasksRequest request) 
        {
            return new ListFuotaTasksPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListMulticastGroups operation
        ///</summary>
        public IListMulticastGroupsPaginator ListMulticastGroups(ListMulticastGroupsRequest request) 
        {
            return new ListMulticastGroupsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListMulticastGroupsByFuotaTask operation
        ///</summary>
        public IListMulticastGroupsByFuotaTaskPaginator ListMulticastGroupsByFuotaTask(ListMulticastGroupsByFuotaTaskRequest request) 
        {
            return new ListMulticastGroupsByFuotaTaskPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListNetworkAnalyzerConfigurations operation
        ///</summary>
        public IListNetworkAnalyzerConfigurationsPaginator ListNetworkAnalyzerConfigurations(ListNetworkAnalyzerConfigurationsRequest request) 
        {
            return new ListNetworkAnalyzerConfigurationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPositionConfigurations operation
        ///</summary>
        public IListPositionConfigurationsPaginator ListPositionConfigurations(ListPositionConfigurationsRequest request) 
        {
            return new ListPositionConfigurationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListQueuedMessages operation
        ///</summary>
        public IListQueuedMessagesPaginator ListQueuedMessages(ListQueuedMessagesRequest request) 
        {
            return new ListQueuedMessagesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListServiceProfiles operation
        ///</summary>
        public IListServiceProfilesPaginator ListServiceProfiles(ListServiceProfilesRequest request) 
        {
            return new ListServiceProfilesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListWirelessDevices operation
        ///</summary>
        public IListWirelessDevicesPaginator ListWirelessDevices(ListWirelessDevicesRequest request) 
        {
            return new ListWirelessDevicesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListWirelessGateways operation
        ///</summary>
        public IListWirelessGatewaysPaginator ListWirelessGateways(ListWirelessGatewaysRequest request) 
        {
            return new ListWirelessGatewaysPaginator(this.client, request);
        }
    }
}