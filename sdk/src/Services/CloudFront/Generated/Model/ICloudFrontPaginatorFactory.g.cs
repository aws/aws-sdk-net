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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// Paginators for the CloudFront service
    /// </summary>
    public interface ICloudFrontPaginatorFactory
    {
        /// <summary>
        /// Paginator for ListCloudFrontOriginAccessIdentities operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxItems", OutputToken = ["CloudFrontOriginAccessIdentityList.NextMarker"])]
        IListCloudFrontOriginAccessIdentitiesPaginator ListCloudFrontOriginAccessIdentities(ListCloudFrontOriginAccessIdentitiesRequest request);

        /// <summary>
        /// Paginator for ListConnectionFunctions operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxItems", OutputToken = ["NextMarker"])]
        IListConnectionFunctionsPaginator ListConnectionFunctions(ListConnectionFunctionsRequest request);

        /// <summary>
        /// Paginator for ListConnectionGroups operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxItems", OutputToken = ["NextMarker"])]
        IListConnectionGroupsPaginator ListConnectionGroups(ListConnectionGroupsRequest request);

        /// <summary>
        /// Paginator for ListDistributionTenants operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxItems", OutputToken = ["NextMarker"])]
        IListDistributionTenantsPaginator ListDistributionTenants(ListDistributionTenantsRequest request);

        /// <summary>
        /// Paginator for ListDistributionTenantsByCustomization operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxItems", OutputToken = ["NextMarker"])]
        IListDistributionTenantsByCustomizationPaginator ListDistributionTenantsByCustomization(ListDistributionTenantsByCustomizationRequest request);

        /// <summary>
        /// Paginator for ListDistributions operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxItems", OutputToken = ["DistributionList.NextMarker"])]
        IListDistributionsPaginator ListDistributions(ListDistributionsRequest request);

        /// <summary>
        /// Paginator for ListDistributionsByConnectionFunction operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxItems", OutputToken = ["DistributionList.NextMarker"])]
        IListDistributionsByConnectionFunctionPaginator ListDistributionsByConnectionFunction(ListDistributionsByConnectionFunctionRequest request);

        /// <summary>
        /// Paginator for ListDistributionsByConnectionMode operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxItems", OutputToken = ["DistributionList.NextMarker"])]
        IListDistributionsByConnectionModePaginator ListDistributionsByConnectionMode(ListDistributionsByConnectionModeRequest request);

        /// <summary>
        /// Paginator for ListDistributionsByTrustStore operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxItems", OutputToken = ["DistributionList.NextMarker"])]
        IListDistributionsByTrustStorePaginator ListDistributionsByTrustStore(ListDistributionsByTrustStoreRequest request);

        /// <summary>
        /// Paginator for ListDomainConflicts operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxItems", OutputToken = ["NextMarker"])]
        IListDomainConflictsPaginator ListDomainConflicts(ListDomainConflictsRequest request);

        /// <summary>
        /// Paginator for ListInvalidations operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxItems", OutputToken = ["InvalidationList.NextMarker"])]
        IListInvalidationsPaginator ListInvalidations(ListInvalidationsRequest request);

        /// <summary>
        /// Paginator for ListInvalidationsForDistributionTenant operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxItems", OutputToken = ["InvalidationList.NextMarker"])]
        IListInvalidationsForDistributionTenantPaginator ListInvalidationsForDistributionTenant(ListInvalidationsForDistributionTenantRequest request);

        /// <summary>
        /// Paginator for ListKeyValueStores operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxItems", OutputToken = ["KeyValueStoreList.NextMarker"])]
        IListKeyValueStoresPaginator ListKeyValueStores(ListKeyValueStoresRequest request);

        /// <summary>
        /// Paginator for ListOriginAccessControls operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxItems", OutputToken = ["OriginAccessControlList.NextMarker"])]
        IListOriginAccessControlsPaginator ListOriginAccessControls(ListOriginAccessControlsRequest request);

        /// <summary>
        /// Paginator for ListPublicKeys operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxItems", OutputToken = ["PublicKeyList.NextMarker"])]
        IListPublicKeysPaginator ListPublicKeys(ListPublicKeysRequest request);

        /// <summary>
        /// Paginator for ListStreamingDistributions operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxItems", OutputToken = ["StreamingDistributionList.NextMarker"])]
        IListStreamingDistributionsPaginator ListStreamingDistributions(ListStreamingDistributionsRequest request);

        /// <summary>
        /// Paginator for ListTrustStores operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxItems", OutputToken = ["NextMarker"])]
        IListTrustStoresPaginator ListTrustStores(ListTrustStoresRequest request);
    }
}
