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
 * Do not modify this file. This file is generated from the license-manager-linux-subscriptions-2018-05-10.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.LicenseManagerLinuxSubscriptions.Model
{
    /// <summary>
    /// Paginators for the LicenseManagerLinuxSubscriptions service
    ///</summary>
    public class LicenseManagerLinuxSubscriptionsPaginatorFactory : ILicenseManagerLinuxSubscriptionsPaginatorFactory
    {
        private readonly IAmazonLicenseManagerLinuxSubscriptions client;

        internal LicenseManagerLinuxSubscriptionsPaginatorFactory(IAmazonLicenseManagerLinuxSubscriptions client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListLinuxSubscriptionInstances operation
        ///</summary>
        public IListLinuxSubscriptionInstancesPaginator ListLinuxSubscriptionInstances(ListLinuxSubscriptionInstancesRequest request) 
        {
            return new ListLinuxSubscriptionInstancesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListLinuxSubscriptions operation
        ///</summary>
        public IListLinuxSubscriptionsPaginator ListLinuxSubscriptions(ListLinuxSubscriptionsRequest request) 
        {
            return new ListLinuxSubscriptionsPaginator(this.client, request);
        }
    }
}