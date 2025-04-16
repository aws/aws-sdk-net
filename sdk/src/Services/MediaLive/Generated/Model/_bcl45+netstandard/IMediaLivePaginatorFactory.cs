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
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Paginators for the MediaLive service
    ///</summary>
    public interface IMediaLivePaginatorFactory
    {

        /// <summary>
        /// Paginator for DescribeSchedule operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeSchedulePaginator DescribeSchedule(DescribeScheduleRequest request);

        /// <summary>
        /// Paginator for ListChannelPlacementGroups operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListChannelPlacementGroupsPaginator ListChannelPlacementGroups(ListChannelPlacementGroupsRequest request);

        /// <summary>
        /// Paginator for ListChannels operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListChannelsPaginator ListChannels(ListChannelsRequest request);

        /// <summary>
        /// Paginator for ListCloudWatchAlarmTemplateGroups operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListCloudWatchAlarmTemplateGroupsPaginator ListCloudWatchAlarmTemplateGroups(ListCloudWatchAlarmTemplateGroupsRequest request);

        /// <summary>
        /// Paginator for ListCloudWatchAlarmTemplates operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListCloudWatchAlarmTemplatesPaginator ListCloudWatchAlarmTemplates(ListCloudWatchAlarmTemplatesRequest request);

        /// <summary>
        /// Paginator for ListClusters operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListClustersPaginator ListClusters(ListClustersRequest request);

        /// <summary>
        /// Paginator for ListEventBridgeRuleTemplateGroups operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListEventBridgeRuleTemplateGroupsPaginator ListEventBridgeRuleTemplateGroups(ListEventBridgeRuleTemplateGroupsRequest request);

        /// <summary>
        /// Paginator for ListEventBridgeRuleTemplates operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListEventBridgeRuleTemplatesPaginator ListEventBridgeRuleTemplates(ListEventBridgeRuleTemplatesRequest request);

        /// <summary>
        /// Paginator for ListInputDevices operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListInputDevicesPaginator ListInputDevices(ListInputDevicesRequest request);

        /// <summary>
        /// Paginator for ListInputDeviceTransfers operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListInputDeviceTransfersPaginator ListInputDeviceTransfers(ListInputDeviceTransfersRequest request);

        /// <summary>
        /// Paginator for ListInputs operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListInputsPaginator ListInputs(ListInputsRequest request);

        /// <summary>
        /// Paginator for ListInputSecurityGroups operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListInputSecurityGroupsPaginator ListInputSecurityGroups(ListInputSecurityGroupsRequest request);

        /// <summary>
        /// Paginator for ListMultiplexes operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListMultiplexesPaginator ListMultiplexes(ListMultiplexesRequest request);

        /// <summary>
        /// Paginator for ListMultiplexPrograms operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListMultiplexProgramsPaginator ListMultiplexPrograms(ListMultiplexProgramsRequest request);

        /// <summary>
        /// Paginator for ListNetworks operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListNetworksPaginator ListNetworks(ListNetworksRequest request);

        /// <summary>
        /// Paginator for ListNodes operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListNodesPaginator ListNodes(ListNodesRequest request);

        /// <summary>
        /// Paginator for ListOfferings operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListOfferingsPaginator ListOfferings(ListOfferingsRequest request);

        /// <summary>
        /// Paginator for ListReservations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListReservationsPaginator ListReservations(ListReservationsRequest request);

        /// <summary>
        /// Paginator for ListSdiSources operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListSdiSourcesPaginator ListSdiSources(ListSdiSourcesRequest request);

        /// <summary>
        /// Paginator for ListSignalMaps operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListSignalMapsPaginator ListSignalMaps(ListSignalMapsRequest request);
    }
}