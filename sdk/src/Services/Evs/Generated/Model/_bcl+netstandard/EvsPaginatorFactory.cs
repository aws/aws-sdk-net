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
 * Do not modify this file. This file is generated from the evs-2023-07-27.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.Evs.Model
{
    /// <summary>
    /// Paginators for the Evs service
    ///</summary>
    public class EvsPaginatorFactory : IEvsPaginatorFactory
    {
        private readonly IAmazonEvs client;

        internal EvsPaginatorFactory(IAmazonEvs client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListEnvironmentHosts operation
        ///</summary>
        public IListEnvironmentHostsPaginator ListEnvironmentHosts(ListEnvironmentHostsRequest request) 
        {
            return new ListEnvironmentHostsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListEnvironments operation
        ///</summary>
        public IListEnvironmentsPaginator ListEnvironments(ListEnvironmentsRequest request) 
        {
            return new ListEnvironmentsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListEnvironmentVlans operation
        ///</summary>
        public IListEnvironmentVlansPaginator ListEnvironmentVlans(ListEnvironmentVlansRequest request) 
        {
            return new ListEnvironmentVlansPaginator(this.client, request);
        }
    }
}