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
 * Do not modify this file. This file is generated from the cloud9-2017-09-23.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.Cloud9.Model
{
    /// <summary>
    /// Paginators for the Cloud9 service
    ///</summary>
    public class Cloud9PaginatorFactory : ICloud9PaginatorFactory
    {
        private readonly IAmazonCloud9 client;

        internal Cloud9PaginatorFactory(IAmazonCloud9 client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for DescribeEnvironmentMemberships operation
        ///</summary>
        public IDescribeEnvironmentMembershipsPaginator DescribeEnvironmentMemberships(DescribeEnvironmentMembershipsRequest request) 
        {
            return new DescribeEnvironmentMembershipsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListEnvironments operation
        ///</summary>
        public IListEnvironmentsPaginator ListEnvironments(ListEnvironmentsRequest request) 
        {
            return new ListEnvironmentsPaginator(this.client, request);
        }
    }
}