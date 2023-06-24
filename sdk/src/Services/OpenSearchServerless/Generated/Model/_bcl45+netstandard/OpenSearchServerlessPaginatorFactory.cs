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
 * Do not modify this file. This file is generated from the opensearchserverless-2021-11-01.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.OpenSearchServerless.Model
{
    /// <summary>
    /// Paginators for the OpenSearchServerless service
    ///</summary>
    public class OpenSearchServerlessPaginatorFactory : IOpenSearchServerlessPaginatorFactory
    {
        private readonly IAmazonOpenSearchServerless client;

        internal OpenSearchServerlessPaginatorFactory(IAmazonOpenSearchServerless client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListAccessPolicies operation
        ///</summary>
        public IListAccessPoliciesPaginator ListAccessPolicies(ListAccessPoliciesRequest request) 
        {
            return new ListAccessPoliciesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListCollections operation
        ///</summary>
        public IListCollectionsPaginator ListCollections(ListCollectionsRequest request) 
        {
            return new ListCollectionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSecurityConfigs operation
        ///</summary>
        public IListSecurityConfigsPaginator ListSecurityConfigs(ListSecurityConfigsRequest request) 
        {
            return new ListSecurityConfigsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSecurityPolicies operation
        ///</summary>
        public IListSecurityPoliciesPaginator ListSecurityPolicies(ListSecurityPoliciesRequest request) 
        {
            return new ListSecurityPoliciesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListVpcEndpoints operation
        ///</summary>
        public IListVpcEndpointsPaginator ListVpcEndpoints(ListVpcEndpointsRequest request) 
        {
            return new ListVpcEndpointsPaginator(this.client, request);
        }
    }
}