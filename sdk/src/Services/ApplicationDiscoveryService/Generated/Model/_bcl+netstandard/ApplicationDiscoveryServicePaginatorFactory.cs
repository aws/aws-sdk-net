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
 * Do not modify this file. This file is generated from the discovery-2015-11-01.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.ApplicationDiscoveryService.Model
{
    /// <summary>
    /// Paginators for the ApplicationDiscoveryService service
    ///</summary>
    public class ApplicationDiscoveryServicePaginatorFactory : IApplicationDiscoveryServicePaginatorFactory
    {
        private readonly IAmazonApplicationDiscoveryService client;

        internal ApplicationDiscoveryServicePaginatorFactory(IAmazonApplicationDiscoveryService client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for DescribeAgents operation
        ///</summary>
        public IDescribeAgentsPaginator DescribeAgents(DescribeAgentsRequest request) 
        {
            return new DescribeAgentsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeContinuousExports operation
        ///</summary>
        public IDescribeContinuousExportsPaginator DescribeContinuousExports(DescribeContinuousExportsRequest request) 
        {
            return new DescribeContinuousExportsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeExportConfigurations operation
        ///</summary>
        public IDescribeExportConfigurationsPaginator DescribeExportConfigurations(DescribeExportConfigurationsRequest request) 
        {
            return new DescribeExportConfigurationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeExportTasks operation
        ///</summary>
        public IDescribeExportTasksPaginator DescribeExportTasks(DescribeExportTasksRequest request) 
        {
            return new DescribeExportTasksPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeImportTasks operation
        ///</summary>
        public IDescribeImportTasksPaginator DescribeImportTasks(DescribeImportTasksRequest request) 
        {
            return new DescribeImportTasksPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeTags operation
        ///</summary>
        public IDescribeTagsPaginator DescribeTags(DescribeTagsRequest request) 
        {
            return new DescribeTagsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListConfigurations operation
        ///</summary>
        public IListConfigurationsPaginator ListConfigurations(ListConfigurationsRequest request) 
        {
            return new ListConfigurationsPaginator(this.client, request);
        }
    }
}