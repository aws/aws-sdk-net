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
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
namespace Amazon.IoTWireless.Model
{
    /// <summary>
    /// Paginators for the IoTWireless service
    ///</summary>
    public interface IIoTWirelessPaginatorFactory
    {

        /// <summary>
        /// Paginator for ListDestinations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListDestinationsPaginator ListDestinations(ListDestinationsRequest request);

        /// <summary>
        /// Paginator for ListDeviceProfiles operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListDeviceProfilesPaginator ListDeviceProfiles(ListDeviceProfilesRequest request);

        /// <summary>
        /// Paginator for ListFuotaTasks operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListFuotaTasksPaginator ListFuotaTasks(ListFuotaTasksRequest request);

        /// <summary>
        /// Paginator for ListMulticastGroups operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListMulticastGroupsPaginator ListMulticastGroups(ListMulticastGroupsRequest request);

        /// <summary>
        /// Paginator for ListMulticastGroupsByFuotaTask operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListMulticastGroupsByFuotaTaskPaginator ListMulticastGroupsByFuotaTask(ListMulticastGroupsByFuotaTaskRequest request);

        /// <summary>
        /// Paginator for ListNetworkAnalyzerConfigurations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListNetworkAnalyzerConfigurationsPaginator ListNetworkAnalyzerConfigurations(ListNetworkAnalyzerConfigurationsRequest request);

        /// <summary>
        /// Paginator for ListPositionConfigurations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListPositionConfigurationsPaginator ListPositionConfigurations(ListPositionConfigurationsRequest request);

        /// <summary>
        /// Paginator for ListQueuedMessages operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListQueuedMessagesPaginator ListQueuedMessages(ListQueuedMessagesRequest request);

        /// <summary>
        /// Paginator for ListServiceProfiles operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListServiceProfilesPaginator ListServiceProfiles(ListServiceProfilesRequest request);

        /// <summary>
        /// Paginator for ListWirelessDevices operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListWirelessDevicesPaginator ListWirelessDevices(ListWirelessDevicesRequest request);

        /// <summary>
        /// Paginator for ListWirelessGateways operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListWirelessGatewaysPaginator ListWirelessGateways(ListWirelessGatewaysRequest request);
    }
}