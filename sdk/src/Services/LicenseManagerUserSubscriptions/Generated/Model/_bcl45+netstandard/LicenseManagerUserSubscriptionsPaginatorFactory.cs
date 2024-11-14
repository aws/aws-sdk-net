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
 * Do not modify this file. This file is generated from the license-manager-user-subscriptions-2018-05-10.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.LicenseManagerUserSubscriptions.Model
{
    /// <summary>
    /// Paginators for the LicenseManagerUserSubscriptions service
    ///</summary>
    public class LicenseManagerUserSubscriptionsPaginatorFactory : ILicenseManagerUserSubscriptionsPaginatorFactory
    {
        private readonly IAmazonLicenseManagerUserSubscriptions client;

        internal LicenseManagerUserSubscriptionsPaginatorFactory(IAmazonLicenseManagerUserSubscriptions client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListIdentityProviders operation
        ///</summary>
        public IListIdentityProvidersPaginator ListIdentityProviders(ListIdentityProvidersRequest request) 
        {
            return new ListIdentityProvidersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListInstances operation
        ///</summary>
        public IListInstancesPaginator ListInstances(ListInstancesRequest request) 
        {
            return new ListInstancesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListLicenseServerEndpoints operation
        ///</summary>
        public IListLicenseServerEndpointsPaginator ListLicenseServerEndpoints(ListLicenseServerEndpointsRequest request) 
        {
            return new ListLicenseServerEndpointsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListProductSubscriptions operation
        ///</summary>
        public IListProductSubscriptionsPaginator ListProductSubscriptions(ListProductSubscriptionsRequest request) 
        {
            return new ListProductSubscriptionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListUserAssociations operation
        ///</summary>
        public IListUserAssociationsPaginator ListUserAssociations(ListUserAssociationsRequest request) 
        {
            return new ListUserAssociationsPaginator(this.client, request);
        }
    }
}