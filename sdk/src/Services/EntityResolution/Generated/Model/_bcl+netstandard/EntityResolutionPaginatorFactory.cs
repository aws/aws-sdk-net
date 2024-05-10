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
 * Do not modify this file. This file is generated from the entityresolution-2018-05-10.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.EntityResolution.Model
{
    /// <summary>
    /// Paginators for the EntityResolution service
    ///</summary>
    public class EntityResolutionPaginatorFactory : IEntityResolutionPaginatorFactory
    {
        private readonly IAmazonEntityResolution client;

        internal EntityResolutionPaginatorFactory(IAmazonEntityResolution client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListIdMappingJobs operation
        ///</summary>
        public IListIdMappingJobsPaginator ListIdMappingJobs(ListIdMappingJobsRequest request) 
        {
            return new ListIdMappingJobsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListIdMappingWorkflows operation
        ///</summary>
        public IListIdMappingWorkflowsPaginator ListIdMappingWorkflows(ListIdMappingWorkflowsRequest request) 
        {
            return new ListIdMappingWorkflowsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListIdNamespaces operation
        ///</summary>
        public IListIdNamespacesPaginator ListIdNamespaces(ListIdNamespacesRequest request) 
        {
            return new ListIdNamespacesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListMatchingJobs operation
        ///</summary>
        public IListMatchingJobsPaginator ListMatchingJobs(ListMatchingJobsRequest request) 
        {
            return new ListMatchingJobsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListMatchingWorkflows operation
        ///</summary>
        public IListMatchingWorkflowsPaginator ListMatchingWorkflows(ListMatchingWorkflowsRequest request) 
        {
            return new ListMatchingWorkflowsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListProviderServices operation
        ///</summary>
        public IListProviderServicesPaginator ListProviderServices(ListProviderServicesRequest request) 
        {
            return new ListProviderServicesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSchemaMappings operation
        ///</summary>
        public IListSchemaMappingsPaginator ListSchemaMappings(ListSchemaMappingsRequest request) 
        {
            return new ListSchemaMappingsPaginator(this.client, request);
        }
    }
}