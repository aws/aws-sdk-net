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
 * Do not modify this file. This file is generated from the simspaceweaver-2022-10-28.normal.json service model.
 */

namespace Amazon.SimSpaceWeaver.Model
{
    /// <summary>
    /// Paginators for the SimSpaceWeaver service
    ///</summary>
    public interface ISimSpaceWeaverPaginatorFactory
    {

        /// <summary>
        /// Paginator for ListApps operation
        ///</summary>
        IListAppsPaginator ListApps(ListAppsRequest request);

        /// <summary>
        /// Paginator for ListSimulations operation
        ///</summary>
        IListSimulationsPaginator ListSimulations(ListSimulationsRequest request);
    }
}