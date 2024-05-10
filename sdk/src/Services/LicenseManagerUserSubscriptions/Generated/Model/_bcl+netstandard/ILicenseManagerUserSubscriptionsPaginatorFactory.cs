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

#pragma warning disable CS0612,CS0618
namespace Amazon.LicenseManagerUserSubscriptions.Model
{
    /// <summary>
    /// Paginators for the LicenseManagerUserSubscriptions service
    ///</summary>
    public interface ILicenseManagerUserSubscriptionsPaginatorFactory
    {

        /// <summary>
        /// Paginator for ListIdentityProviders operation
        ///</summary>
        IListIdentityProvidersPaginator ListIdentityProviders(ListIdentityProvidersRequest request);

        /// <summary>
        /// Paginator for ListInstances operation
        ///</summary>
        IListInstancesPaginator ListInstances(ListInstancesRequest request);

        /// <summary>
        /// Paginator for ListProductSubscriptions operation
        ///</summary>
        IListProductSubscriptionsPaginator ListProductSubscriptions(ListProductSubscriptionsRequest request);

        /// <summary>
        /// Paginator for ListUserAssociations operation
        ///</summary>
        IListUserAssociationsPaginator ListUserAssociations(ListUserAssociationsRequest request);
    }
}