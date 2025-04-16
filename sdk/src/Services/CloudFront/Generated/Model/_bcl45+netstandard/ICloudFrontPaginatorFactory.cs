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
 * Do not modify this file. This file is generated from the cloudfront-2020-05-31.normal.json service model.
 */
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// Paginators for the CloudFront service
    ///</summary>
    public interface ICloudFrontPaginatorFactory
    {

        /// <summary>
        /// Paginator for ListCloudFrontOriginAccessIdentities operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxItems",
            OutputToken = new[] { "CloudFrontOriginAccessIdentityList.NextMarker" }
        )]
        IListCloudFrontOriginAccessIdentitiesPaginator ListCloudFrontOriginAccessIdentities(ListCloudFrontOriginAccessIdentitiesRequest request);

        /// <summary>
        /// Paginator for ListDistributions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxItems",
            OutputToken = new[] { "DistributionList.NextMarker" }
        )]
        IListDistributionsPaginator ListDistributions(ListDistributionsRequest request);

        /// <summary>
        /// Paginator for ListInvalidations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxItems",
            OutputToken = new[] { "InvalidationList.NextMarker" }
        )]
        IListInvalidationsPaginator ListInvalidations(ListInvalidationsRequest request);

        /// <summary>
        /// Paginator for ListKeyValueStores operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxItems",
            OutputToken = new[] { "KeyValueStoreList.NextMarker" }
        )]
        IListKeyValueStoresPaginator ListKeyValueStores(ListKeyValueStoresRequest request);

        /// <summary>
        /// Paginator for ListPublicKeys operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxItems",
            OutputToken = new[] { "PublicKeyList.NextMarker" }
        )]
        IListPublicKeysPaginator ListPublicKeys(ListPublicKeysRequest request);

        /// <summary>
        /// Paginator for ListStreamingDistributions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxItems",
            OutputToken = new[] { "StreamingDistributionList.NextMarker" }
        )]
        IListStreamingDistributionsPaginator ListStreamingDistributions(ListStreamingDistributionsRequest request);
    }
}