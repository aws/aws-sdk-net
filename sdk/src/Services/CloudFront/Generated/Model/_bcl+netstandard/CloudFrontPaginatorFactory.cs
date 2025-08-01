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

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// Paginators for the CloudFront service
    ///</summary>
    public class CloudFrontPaginatorFactory : ICloudFrontPaginatorFactory
    {
        private readonly IAmazonCloudFront client;

        internal CloudFrontPaginatorFactory(IAmazonCloudFront client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListCloudFrontOriginAccessIdentities operation
        ///</summary>
        public IListCloudFrontOriginAccessIdentitiesPaginator ListCloudFrontOriginAccessIdentities(ListCloudFrontOriginAccessIdentitiesRequest request) 
        {
            return new ListCloudFrontOriginAccessIdentitiesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListConnectionGroups operation
        ///</summary>
        public IListConnectionGroupsPaginator ListConnectionGroups(ListConnectionGroupsRequest request) 
        {
            return new ListConnectionGroupsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDistributions operation
        ///</summary>
        public IListDistributionsPaginator ListDistributions(ListDistributionsRequest request) 
        {
            return new ListDistributionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDistributionsByConnectionMode operation
        ///</summary>
        public IListDistributionsByConnectionModePaginator ListDistributionsByConnectionMode(ListDistributionsByConnectionModeRequest request) 
        {
            return new ListDistributionsByConnectionModePaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDistributionTenants operation
        ///</summary>
        public IListDistributionTenantsPaginator ListDistributionTenants(ListDistributionTenantsRequest request) 
        {
            return new ListDistributionTenantsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDistributionTenantsByCustomization operation
        ///</summary>
        public IListDistributionTenantsByCustomizationPaginator ListDistributionTenantsByCustomization(ListDistributionTenantsByCustomizationRequest request) 
        {
            return new ListDistributionTenantsByCustomizationPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDomainConflicts operation
        ///</summary>
        public IListDomainConflictsPaginator ListDomainConflicts(ListDomainConflictsRequest request) 
        {
            return new ListDomainConflictsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListInvalidations operation
        ///</summary>
        public IListInvalidationsPaginator ListInvalidations(ListInvalidationsRequest request) 
        {
            return new ListInvalidationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListInvalidationsForDistributionTenant operation
        ///</summary>
        public IListInvalidationsForDistributionTenantPaginator ListInvalidationsForDistributionTenant(ListInvalidationsForDistributionTenantRequest request) 
        {
            return new ListInvalidationsForDistributionTenantPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListKeyValueStores operation
        ///</summary>
        public IListKeyValueStoresPaginator ListKeyValueStores(ListKeyValueStoresRequest request) 
        {
            return new ListKeyValueStoresPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListOriginAccessControls operation
        ///</summary>
        public IListOriginAccessControlsPaginator ListOriginAccessControls(ListOriginAccessControlsRequest request) 
        {
            return new ListOriginAccessControlsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPublicKeys operation
        ///</summary>
        public IListPublicKeysPaginator ListPublicKeys(ListPublicKeysRequest request) 
        {
            return new ListPublicKeysPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListStreamingDistributions operation
        ///</summary>
        public IListStreamingDistributionsPaginator ListStreamingDistributions(ListStreamingDistributionsRequest request) 
        {
            return new ListStreamingDistributionsPaginator(this.client, request);
        }
    }
}