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
 * Do not modify this file. This file is generated from the synthetics-2017-10-11.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.Synthetics.Model
{
    /// <summary>
    /// Paginators for the Synthetics service
    ///</summary>
    public class SyntheticsPaginatorFactory : ISyntheticsPaginatorFactory
    {
        private readonly IAmazonSynthetics client;

        internal SyntheticsPaginatorFactory(IAmazonSynthetics client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for DescribeCanaries operation
        ///</summary>
        public IDescribeCanariesPaginator DescribeCanaries(DescribeCanariesRequest request) 
        {
            return new DescribeCanariesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeCanariesLastRun operation
        ///</summary>
        public IDescribeCanariesLastRunPaginator DescribeCanariesLastRun(DescribeCanariesLastRunRequest request) 
        {
            return new DescribeCanariesLastRunPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeRuntimeVersions operation
        ///</summary>
        public IDescribeRuntimeVersionsPaginator DescribeRuntimeVersions(DescribeRuntimeVersionsRequest request) 
        {
            return new DescribeRuntimeVersionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetCanaryRuns operation
        ///</summary>
        public IGetCanaryRunsPaginator GetCanaryRuns(GetCanaryRunsRequest request) 
        {
            return new GetCanaryRunsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAssociatedGroups operation
        ///</summary>
        public IListAssociatedGroupsPaginator ListAssociatedGroups(ListAssociatedGroupsRequest request) 
        {
            return new ListAssociatedGroupsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListGroupResources operation
        ///</summary>
        public IListGroupResourcesPaginator ListGroupResources(ListGroupResourcesRequest request) 
        {
            return new ListGroupResourcesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListGroups operation
        ///</summary>
        public IListGroupsPaginator ListGroups(ListGroupsRequest request) 
        {
            return new ListGroupsPaginator(this.client, request);
        }
    }
}