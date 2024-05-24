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

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.PI.Model
{
    /// <summary>
    /// Paginators for the PI service
    ///</summary>
    public class PIPaginatorFactory : IPIPaginatorFactory
    {
        private readonly IAmazonPI client;

        internal PIPaginatorFactory(IAmazonPI client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for DescribeDimensionKeys operation
        ///</summary>
        public IDescribeDimensionKeysPaginator DescribeDimensionKeys(DescribeDimensionKeysRequest request) 
        {
            return new DescribeDimensionKeysPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetResourceMetrics operation
        ///</summary>
        public IGetResourceMetricsPaginator GetResourceMetrics(GetResourceMetricsRequest request) 
        {
            return new GetResourceMetricsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAvailableResourceDimensions operation
        ///</summary>
        public IListAvailableResourceDimensionsPaginator ListAvailableResourceDimensions(ListAvailableResourceDimensionsRequest request) 
        {
            return new ListAvailableResourceDimensionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAvailableResourceMetrics operation
        ///</summary>
        public IListAvailableResourceMetricsPaginator ListAvailableResourceMetrics(ListAvailableResourceMetricsRequest request) 
        {
            return new ListAvailableResourceMetricsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPerformanceAnalysisReports operation
        ///</summary>
        public IListPerformanceAnalysisReportsPaginator ListPerformanceAnalysisReports(ListPerformanceAnalysisReportsRequest request) 
        {
            return new ListPerformanceAnalysisReportsPaginator(this.client, request);
        }
    }
}