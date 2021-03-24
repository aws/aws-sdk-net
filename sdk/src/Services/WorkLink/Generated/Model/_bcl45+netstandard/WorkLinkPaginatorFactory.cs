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
 * Do not modify this file. This file is generated from the worklink-2018-09-25.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.WorkLink.Model
{
    /// <summary>
    /// Paginators for the WorkLink service
    ///</summary>
    public class WorkLinkPaginatorFactory : IWorkLinkPaginatorFactory
    {
        private readonly IAmazonWorkLink client;

        internal WorkLinkPaginatorFactory(IAmazonWorkLink client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListDevices operation
        ///</summary>
        public IListDevicesPaginator ListDevices(ListDevicesRequest request) 
        {
            return new ListDevicesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDomains operation
        ///</summary>
        public IListDomainsPaginator ListDomains(ListDomainsRequest request) 
        {
            return new ListDomainsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListFleets operation
        ///</summary>
        public IListFleetsPaginator ListFleets(ListFleetsRequest request) 
        {
            return new ListFleetsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListWebsiteAuthorizationProviders operation
        ///</summary>
        public IListWebsiteAuthorizationProvidersPaginator ListWebsiteAuthorizationProviders(ListWebsiteAuthorizationProvidersRequest request) 
        {
            return new ListWebsiteAuthorizationProvidersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListWebsiteCertificateAuthorities operation
        ///</summary>
        public IListWebsiteCertificateAuthoritiesPaginator ListWebsiteCertificateAuthorities(ListWebsiteCertificateAuthoritiesRequest request) 
        {
            return new ListWebsiteCertificateAuthoritiesPaginator(this.client, request);
        }
    }
}