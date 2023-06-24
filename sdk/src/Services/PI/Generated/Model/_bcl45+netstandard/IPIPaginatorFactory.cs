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
 * Do not modify this file. This file is generated from the pi-2018-02-27.normal.json service model.
 */

namespace Amazon.PI.Model
{
    /// <summary>
    /// Paginators for the PI service
    ///</summary>
    public interface IPIPaginatorFactory
    {

        /// <summary>
        /// Paginator for DescribeDimensionKeys operation
        ///</summary>
        IDescribeDimensionKeysPaginator DescribeDimensionKeys(DescribeDimensionKeysRequest request);

        /// <summary>
        /// Paginator for GetResourceMetrics operation
        ///</summary>
        IGetResourceMetricsPaginator GetResourceMetrics(GetResourceMetricsRequest request);

        /// <summary>
        /// Paginator for ListAvailableResourceDimensions operation
        ///</summary>
        IListAvailableResourceDimensionsPaginator ListAvailableResourceDimensions(ListAvailableResourceDimensionsRequest request);

        /// <summary>
        /// Paginator for ListAvailableResourceMetrics operation
        ///</summary>
        IListAvailableResourceMetricsPaginator ListAvailableResourceMetrics(ListAvailableResourceMetricsRequest request);
    }
}