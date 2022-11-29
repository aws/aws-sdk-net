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

namespace Amazon.OpenSearchServerless.Model
{
    /// <summary>
    /// Paginators for the OpenSearchServerless service
    ///</summary>
    public interface IOpenSearchServerlessPaginatorFactory
    {

        /// <summary>
        /// Paginator for ListAccessPolicies operation
        ///</summary>
        IListAccessPoliciesPaginator ListAccessPolicies(ListAccessPoliciesRequest request);

        /// <summary>
        /// Paginator for ListCollections operation
        ///</summary>
        IListCollectionsPaginator ListCollections(ListCollectionsRequest request);

        /// <summary>
        /// Paginator for ListSecurityConfigs operation
        ///</summary>
        IListSecurityConfigsPaginator ListSecurityConfigs(ListSecurityConfigsRequest request);

        /// <summary>
        /// Paginator for ListSecurityPolicies operation
        ///</summary>
        IListSecurityPoliciesPaginator ListSecurityPolicies(ListSecurityPoliciesRequest request);

        /// <summary>
        /// Paginator for ListVpcEndpoints operation
        ///</summary>
        IListVpcEndpointsPaginator ListVpcEndpoints(ListVpcEndpointsRequest request);
    }
}