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
 * Do not modify this file. This file is generated from the iotfleetwise-2021-06-17.normal.json service model.
 */
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
namespace Amazon.IoTFleetWise.Model
{
    /// <summary>
    /// Paginators for the IoTFleetWise service
    ///</summary>
    public interface IIoTFleetWisePaginatorFactory
    {

        /// <summary>
        /// Paginator for GetVehicleStatus operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IGetVehicleStatusPaginator GetVehicleStatus(GetVehicleStatusRequest request);

        /// <summary>
        /// Paginator for ListCampaigns operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListCampaignsPaginator ListCampaigns(ListCampaignsRequest request);

        /// <summary>
        /// Paginator for ListDecoderManifestNetworkInterfaces operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListDecoderManifestNetworkInterfacesPaginator ListDecoderManifestNetworkInterfaces(ListDecoderManifestNetworkInterfacesRequest request);

        /// <summary>
        /// Paginator for ListDecoderManifests operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListDecoderManifestsPaginator ListDecoderManifests(ListDecoderManifestsRequest request);

        /// <summary>
        /// Paginator for ListDecoderManifestSignals operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListDecoderManifestSignalsPaginator ListDecoderManifestSignals(ListDecoderManifestSignalsRequest request);

        /// <summary>
        /// Paginator for ListFleets operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListFleetsPaginator ListFleets(ListFleetsRequest request);

        /// <summary>
        /// Paginator for ListFleetsForVehicle operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListFleetsForVehiclePaginator ListFleetsForVehicle(ListFleetsForVehicleRequest request);

        /// <summary>
        /// Paginator for ListModelManifestNodes operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListModelManifestNodesPaginator ListModelManifestNodes(ListModelManifestNodesRequest request);

        /// <summary>
        /// Paginator for ListModelManifests operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListModelManifestsPaginator ListModelManifests(ListModelManifestsRequest request);

        /// <summary>
        /// Paginator for ListSignalCatalogNodes operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListSignalCatalogNodesPaginator ListSignalCatalogNodes(ListSignalCatalogNodesRequest request);

        /// <summary>
        /// Paginator for ListSignalCatalogs operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListSignalCatalogsPaginator ListSignalCatalogs(ListSignalCatalogsRequest request);

        /// <summary>
        /// Paginator for ListStateTemplates operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListStateTemplatesPaginator ListStateTemplates(ListStateTemplatesRequest request);

        /// <summary>
        /// Paginator for ListVehicles operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListVehiclesPaginator ListVehicles(ListVehiclesRequest request);

        /// <summary>
        /// Paginator for ListVehiclesInFleet operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListVehiclesInFleetPaginator ListVehiclesInFleet(ListVehiclesInFleetRequest request);
    }
}