#if !NETSTANDARD13
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
 * Do not modify this file. This file is generated from the neptune-2014-10-31.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.Neptune.Model
{
    /// <summary>
    /// Paginators for the Neptune service
    ///</summary>
    public class NeptunePaginatorFactory : INeptunePaginatorFactory
    {
        private readonly IAmazonNeptune client;

        internal NeptunePaginatorFactory(IAmazonNeptune client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for DescribeDBClusterEndpoints operation
        ///</summary>
        public IDescribeDBClusterEndpointsPaginator DescribeDBClusterEndpoints(DescribeDBClusterEndpointsRequest request) 
        {
            return new DescribeDBClusterEndpointsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeDBEngineVersions operation
        ///</summary>
        public IDescribeDBEngineVersionsPaginator DescribeDBEngineVersions(DescribeDBEngineVersionsRequest request) 
        {
            return new DescribeDBEngineVersionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeDBInstances operation
        ///</summary>
        public IDescribeDBInstancesPaginator DescribeDBInstances(DescribeDBInstancesRequest request) 
        {
            return new DescribeDBInstancesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeDBParameterGroups operation
        ///</summary>
        public IDescribeDBParameterGroupsPaginator DescribeDBParameterGroups(DescribeDBParameterGroupsRequest request) 
        {
            return new DescribeDBParameterGroupsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeDBParameters operation
        ///</summary>
        public IDescribeDBParametersPaginator DescribeDBParameters(DescribeDBParametersRequest request) 
        {
            return new DescribeDBParametersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeDBSubnetGroups operation
        ///</summary>
        public IDescribeDBSubnetGroupsPaginator DescribeDBSubnetGroups(DescribeDBSubnetGroupsRequest request) 
        {
            return new DescribeDBSubnetGroupsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeEngineDefaultParameters operation
        ///</summary>
        public IDescribeEngineDefaultParametersPaginator DescribeEngineDefaultParameters(DescribeEngineDefaultParametersRequest request) 
        {
            return new DescribeEngineDefaultParametersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeEvents operation
        ///</summary>
        public IDescribeEventsPaginator DescribeEvents(DescribeEventsRequest request) 
        {
            return new DescribeEventsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeEventSubscriptions operation
        ///</summary>
        public IDescribeEventSubscriptionsPaginator DescribeEventSubscriptions(DescribeEventSubscriptionsRequest request) 
        {
            return new DescribeEventSubscriptionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeOrderableDBInstanceOptions operation
        ///</summary>
        public IDescribeOrderableDBInstanceOptionsPaginator DescribeOrderableDBInstanceOptions(DescribeOrderableDBInstanceOptionsRequest request) 
        {
            return new DescribeOrderableDBInstanceOptionsPaginator(this.client, request);
        }
    }
}
#endif