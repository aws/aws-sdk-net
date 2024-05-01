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
 * Do not modify this file. This file is generated from the emr-containers-2020-10-01.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.EMRContainers.Model
{
    /// <summary>
    /// Paginators for the EMRContainers service
    ///</summary>
    public class EMRContainersPaginatorFactory : IEMRContainersPaginatorFactory
    {
        private readonly IAmazonEMRContainers client;

        internal EMRContainersPaginatorFactory(IAmazonEMRContainers client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListJobRuns operation
        ///</summary>
        public IListJobRunsPaginator ListJobRuns(ListJobRunsRequest request) 
        {
            return new ListJobRunsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListJobTemplates operation
        ///</summary>
        public IListJobTemplatesPaginator ListJobTemplates(ListJobTemplatesRequest request) 
        {
            return new ListJobTemplatesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListManagedEndpoints operation
        ///</summary>
        public IListManagedEndpointsPaginator ListManagedEndpoints(ListManagedEndpointsRequest request) 
        {
            return new ListManagedEndpointsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSecurityConfigurations operation
        ///</summary>
        public IListSecurityConfigurationsPaginator ListSecurityConfigurations(ListSecurityConfigurationsRequest request) 
        {
            return new ListSecurityConfigurationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListVirtualClusters operation
        ///</summary>
        public IListVirtualClustersPaginator ListVirtualClusters(ListVirtualClustersRequest request) 
        {
            return new ListVirtualClustersPaginator(this.client, request);
        }
    }
}