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
 * Do not modify this file. This file is generated from the batch-2016-08-10.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.Batch.Model
{
    /// <summary>
    /// Paginators for the Batch service
    ///</summary>
    public class BatchPaginatorFactory : IBatchPaginatorFactory
    {
        private readonly IAmazonBatch client;

        internal BatchPaginatorFactory(IAmazonBatch client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for DescribeComputeEnvironments operation
        ///</summary>
        public IDescribeComputeEnvironmentsPaginator DescribeComputeEnvironments(DescribeComputeEnvironmentsRequest request) 
        {
            return new DescribeComputeEnvironmentsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeJobDefinitions operation
        ///</summary>
        public IDescribeJobDefinitionsPaginator DescribeJobDefinitions(DescribeJobDefinitionsRequest request) 
        {
            return new DescribeJobDefinitionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeJobQueues operation
        ///</summary>
        public IDescribeJobQueuesPaginator DescribeJobQueues(DescribeJobQueuesRequest request) 
        {
            return new DescribeJobQueuesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeServiceEnvironments operation
        ///</summary>
        public IDescribeServiceEnvironmentsPaginator DescribeServiceEnvironments(DescribeServiceEnvironmentsRequest request) 
        {
            return new DescribeServiceEnvironmentsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListConsumableResources operation
        ///</summary>
        public IListConsumableResourcesPaginator ListConsumableResources(ListConsumableResourcesRequest request) 
        {
            return new ListConsumableResourcesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListJobs operation
        ///</summary>
        public IListJobsPaginator ListJobs(ListJobsRequest request) 
        {
            return new ListJobsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListJobsByConsumableResource operation
        ///</summary>
        public IListJobsByConsumableResourcePaginator ListJobsByConsumableResource(ListJobsByConsumableResourceRequest request) 
        {
            return new ListJobsByConsumableResourcePaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSchedulingPolicies operation
        ///</summary>
        public IListSchedulingPoliciesPaginator ListSchedulingPolicies(ListSchedulingPoliciesRequest request) 
        {
            return new ListSchedulingPoliciesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListServiceJobs operation
        ///</summary>
        public IListServiceJobsPaginator ListServiceJobs(ListServiceJobsRequest request) 
        {
            return new ListServiceJobsPaginator(this.client, request);
        }
    }
}