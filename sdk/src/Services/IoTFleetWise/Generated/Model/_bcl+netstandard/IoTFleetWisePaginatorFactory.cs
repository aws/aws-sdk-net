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

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.IoTFleetWise.Model
{
    /// <summary>
    /// Paginators for the IoTFleetWise service
    ///</summary>
    public class IoTFleetWisePaginatorFactory : IIoTFleetWisePaginatorFactory
    {
        private readonly IAmazonIoTFleetWise client;

        internal IoTFleetWisePaginatorFactory(IAmazonIoTFleetWise client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for GetVehicleStatus operation
        ///</summary>
        public IGetVehicleStatusPaginator GetVehicleStatus(GetVehicleStatusRequest request) 
        {
            return new GetVehicleStatusPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListCampaigns operation
        ///</summary>
        public IListCampaignsPaginator ListCampaigns(ListCampaignsRequest request) 
        {
            return new ListCampaignsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDecoderManifestNetworkInterfaces operation
        ///</summary>
        public IListDecoderManifestNetworkInterfacesPaginator ListDecoderManifestNetworkInterfaces(ListDecoderManifestNetworkInterfacesRequest request) 
        {
            return new ListDecoderManifestNetworkInterfacesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDecoderManifests operation
        ///</summary>
        public IListDecoderManifestsPaginator ListDecoderManifests(ListDecoderManifestsRequest request) 
        {
            return new ListDecoderManifestsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDecoderManifestSignals operation
        ///</summary>
        public IListDecoderManifestSignalsPaginator ListDecoderManifestSignals(ListDecoderManifestSignalsRequest request) 
        {
            return new ListDecoderManifestSignalsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListFleets operation
        ///</summary>
        public IListFleetsPaginator ListFleets(ListFleetsRequest request) 
        {
            return new ListFleetsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListFleetsForVehicle operation
        ///</summary>
        public IListFleetsForVehiclePaginator ListFleetsForVehicle(ListFleetsForVehicleRequest request) 
        {
            return new ListFleetsForVehiclePaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListModelManifestNodes operation
        ///</summary>
        public IListModelManifestNodesPaginator ListModelManifestNodes(ListModelManifestNodesRequest request) 
        {
            return new ListModelManifestNodesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListModelManifests operation
        ///</summary>
        public IListModelManifestsPaginator ListModelManifests(ListModelManifestsRequest request) 
        {
            return new ListModelManifestsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSignalCatalogNodes operation
        ///</summary>
        public IListSignalCatalogNodesPaginator ListSignalCatalogNodes(ListSignalCatalogNodesRequest request) 
        {
            return new ListSignalCatalogNodesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSignalCatalogs operation
        ///</summary>
        public IListSignalCatalogsPaginator ListSignalCatalogs(ListSignalCatalogsRequest request) 
        {
            return new ListSignalCatalogsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListStateTemplates operation
        ///</summary>
        public IListStateTemplatesPaginator ListStateTemplates(ListStateTemplatesRequest request) 
        {
            return new ListStateTemplatesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListVehicles operation
        ///</summary>
        public IListVehiclesPaginator ListVehicles(ListVehiclesRequest request) 
        {
            return new ListVehiclesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListVehiclesInFleet operation
        ///</summary>
        public IListVehiclesInFleetPaginator ListVehiclesInFleet(ListVehiclesInFleetRequest request) 
        {
            return new ListVehiclesInFleetPaginator(this.client, request);
        }
    }
}