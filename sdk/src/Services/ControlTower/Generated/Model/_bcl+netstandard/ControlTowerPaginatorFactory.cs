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
 * Do not modify this file. This file is generated from the controltower-2018-05-10.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.ControlTower.Model
{
    /// <summary>
    /// Paginators for the ControlTower service
    ///</summary>
    public class ControlTowerPaginatorFactory : IControlTowerPaginatorFactory
    {
        private readonly IAmazonControlTower client;

        internal ControlTowerPaginatorFactory(IAmazonControlTower client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListBaselines operation
        ///</summary>
        public IListBaselinesPaginator ListBaselines(ListBaselinesRequest request) 
        {
            return new ListBaselinesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListControlOperations operation
        ///</summary>
        public IListControlOperationsPaginator ListControlOperations(ListControlOperationsRequest request) 
        {
            return new ListControlOperationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListEnabledBaselines operation
        ///</summary>
        public IListEnabledBaselinesPaginator ListEnabledBaselines(ListEnabledBaselinesRequest request) 
        {
            return new ListEnabledBaselinesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListEnabledControls operation
        ///</summary>
        public IListEnabledControlsPaginator ListEnabledControls(ListEnabledControlsRequest request) 
        {
            return new ListEnabledControlsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListLandingZoneOperations operation
        ///</summary>
        public IListLandingZoneOperationsPaginator ListLandingZoneOperations(ListLandingZoneOperationsRequest request) 
        {
            return new ListLandingZoneOperationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListLandingZones operation
        ///</summary>
        public IListLandingZonesPaginator ListLandingZones(ListLandingZonesRequest request) 
        {
            return new ListLandingZonesPaginator(this.client, request);
        }
    }
}