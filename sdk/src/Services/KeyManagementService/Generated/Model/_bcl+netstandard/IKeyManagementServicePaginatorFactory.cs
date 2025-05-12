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
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
namespace Amazon.KeyManagementService.Model
{
    /// <summary>
    /// Paginators for the KeyManagementService service
    ///</summary>
    public interface IKeyManagementServicePaginatorFactory
    {

        /// <summary>
        /// Paginator for DescribeCustomKeyStores operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "Limit",
            OutputToken = new[] { "NextMarker" }
        )]
        IDescribeCustomKeyStoresPaginator DescribeCustomKeyStores(DescribeCustomKeyStoresRequest request);

        /// <summary>
        /// Paginator for ListAliases operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "Limit",
            OutputToken = new[] { "NextMarker" }
        )]
        IListAliasesPaginator ListAliases(ListAliasesRequest request);

        /// <summary>
        /// Paginator for ListGrants operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "Limit",
            OutputToken = new[] { "NextMarker" }
        )]
        IListGrantsPaginator ListGrants(ListGrantsRequest request);

        /// <summary>
        /// Paginator for ListKeyPolicies operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "Limit",
            OutputToken = new[] { "NextMarker" }
        )]
        IListKeyPoliciesPaginator ListKeyPolicies(ListKeyPoliciesRequest request);

        /// <summary>
        /// Paginator for ListKeyRotations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "Limit",
            OutputToken = new[] { "NextMarker" }
        )]
        IListKeyRotationsPaginator ListKeyRotations(ListKeyRotationsRequest request);

        /// <summary>
        /// Paginator for ListKeys operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "Limit",
            OutputToken = new[] { "NextMarker" }
        )]
        IListKeysPaginator ListKeys(ListKeysRequest request);

        /// <summary>
        /// Paginator for ListResourceTags operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "Limit",
            OutputToken = new[] { "NextMarker" }
        )]
        IListResourceTagsPaginator ListResourceTags(ListResourceTagsRequest request);

        /// <summary>
        /// Paginator for ListRetirableGrants operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "Limit",
            OutputToken = new[] { "NextMarker" }
        )]
        IListRetirableGrantsPaginator ListRetirableGrants(ListRetirableGrantsRequest request);
    }
}