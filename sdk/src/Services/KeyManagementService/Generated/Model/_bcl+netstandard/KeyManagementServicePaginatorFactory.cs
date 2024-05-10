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
 * Do not modify this file. This file is generated from the kms-2014-11-01.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.KeyManagementService.Model
{
    /// <summary>
    /// Paginators for the KeyManagementService service
    ///</summary>
    public class KeyManagementServicePaginatorFactory : IKeyManagementServicePaginatorFactory
    {
        private readonly IAmazonKeyManagementService client;

        internal KeyManagementServicePaginatorFactory(IAmazonKeyManagementService client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for DescribeCustomKeyStores operation
        ///</summary>
        public IDescribeCustomKeyStoresPaginator DescribeCustomKeyStores(DescribeCustomKeyStoresRequest request) 
        {
            return new DescribeCustomKeyStoresPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAliases operation
        ///</summary>
        public IListAliasesPaginator ListAliases(ListAliasesRequest request) 
        {
            return new ListAliasesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListGrants operation
        ///</summary>
        public IListGrantsPaginator ListGrants(ListGrantsRequest request) 
        {
            return new ListGrantsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListKeyPolicies operation
        ///</summary>
        public IListKeyPoliciesPaginator ListKeyPolicies(ListKeyPoliciesRequest request) 
        {
            return new ListKeyPoliciesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListKeyRotations operation
        ///</summary>
        public IListKeyRotationsPaginator ListKeyRotations(ListKeyRotationsRequest request) 
        {
            return new ListKeyRotationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListKeys operation
        ///</summary>
        public IListKeysPaginator ListKeys(ListKeysRequest request) 
        {
            return new ListKeysPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListResourceTags operation
        ///</summary>
        public IListResourceTagsPaginator ListResourceTags(ListResourceTagsRequest request) 
        {
            return new ListResourceTagsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListRetirableGrants operation
        ///</summary>
        public IListRetirableGrantsPaginator ListRetirableGrants(ListRetirableGrantsRequest request) 
        {
            return new ListRetirableGrantsPaginator(this.client, request);
        }
    }
}