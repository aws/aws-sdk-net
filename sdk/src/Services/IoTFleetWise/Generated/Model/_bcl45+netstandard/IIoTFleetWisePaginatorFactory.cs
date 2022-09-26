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
        IGetVehicleStatusPaginator GetVehicleStatus(GetVehicleStatusRequest request);

        /// <summary>
        /// Paginator for ListCampaigns operation
        ///</summary>
        IListCampaignsPaginator ListCampaigns(ListCampaignsRequest request);

        /// <summary>
        /// Paginator for ListDecoderManifestNetworkInterfaces operation
        ///</summary>
        IListDecoderManifestNetworkInterfacesPaginator ListDecoderManifestNetworkInterfaces(ListDecoderManifestNetworkInterfacesRequest request);

        /// <summary>
        /// Paginator for ListDecoderManifests operation
        ///</summary>
        IListDecoderManifestsPaginator ListDecoderManifests(ListDecoderManifestsRequest request);

        /// <summary>
        /// Paginator for ListDecoderManifestSignals operation
        ///</summary>
        IListDecoderManifestSignalsPaginator ListDecoderManifestSignals(ListDecoderManifestSignalsRequest request);

        /// <summary>
        /// Paginator for ListFleets operation
        ///</summary>
        IListFleetsPaginator ListFleets(ListFleetsRequest request);

        /// <summary>
        /// Paginator for ListFleetsForVehicle operation
        ///</summary>
        IListFleetsForVehiclePaginator ListFleetsForVehicle(ListFleetsForVehicleRequest request);

        /// <summary>
        /// Paginator for ListModelManifestNodes operation
        ///</summary>
        IListModelManifestNodesPaginator ListModelManifestNodes(ListModelManifestNodesRequest request);

        /// <summary>
        /// Paginator for ListModelManifests operation
        ///</summary>
        IListModelManifestsPaginator ListModelManifests(ListModelManifestsRequest request);

        /// <summary>
        /// Paginator for ListSignalCatalogNodes operation
        ///</summary>
        IListSignalCatalogNodesPaginator ListSignalCatalogNodes(ListSignalCatalogNodesRequest request);

        /// <summary>
        /// Paginator for ListSignalCatalogs operation
        ///</summary>
        IListSignalCatalogsPaginator ListSignalCatalogs(ListSignalCatalogsRequest request);

        /// <summary>
        /// Paginator for ListVehicles operation
        ///</summary>
        IListVehiclesPaginator ListVehicles(ListVehiclesRequest request);

        /// <summary>
        /// Paginator for ListVehiclesInFleet operation
        ///</summary>
        IListVehiclesInFleetPaginator ListVehiclesInFleet(ListVehiclesInFleetRequest request);
    }
}