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

#pragma warning disable CS0612,CS0618
namespace Amazon.ControlTower.Model
{
    /// <summary>
    /// Paginators for the ControlTower service
    ///</summary>
    public interface IControlTowerPaginatorFactory
    {

        /// <summary>
        /// Paginator for ListBaselines operation
        ///</summary>
        IListBaselinesPaginator ListBaselines(ListBaselinesRequest request);

        /// <summary>
        /// Paginator for ListEnabledBaselines operation
        ///</summary>
        IListEnabledBaselinesPaginator ListEnabledBaselines(ListEnabledBaselinesRequest request);

        /// <summary>
        /// Paginator for ListEnabledControls operation
        ///</summary>
        IListEnabledControlsPaginator ListEnabledControls(ListEnabledControlsRequest request);

        /// <summary>
        /// Paginator for ListLandingZones operation
        ///</summary>
        IListLandingZonesPaginator ListLandingZones(ListLandingZonesRequest request);
    }
}