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

namespace Amazon.WorkLink.Model
{
    /// <summary>
    /// Paginators for the WorkLink service
    ///</summary>
    public interface IWorkLinkPaginatorFactory
    {

        /// <summary>
        /// Paginator for ListDevices operation
        ///</summary>
        IListDevicesPaginator ListDevices(ListDevicesRequest request);

        /// <summary>
        /// Paginator for ListDomains operation
        ///</summary>
        IListDomainsPaginator ListDomains(ListDomainsRequest request);

        /// <summary>
        /// Paginator for ListFleets operation
        ///</summary>
        IListFleetsPaginator ListFleets(ListFleetsRequest request);

        /// <summary>
        /// Paginator for ListWebsiteAuthorizationProviders operation
        ///</summary>
        IListWebsiteAuthorizationProvidersPaginator ListWebsiteAuthorizationProviders(ListWebsiteAuthorizationProvidersRequest request);

        /// <summary>
        /// Paginator for ListWebsiteCertificateAuthorities operation
        ///</summary>
        IListWebsiteCertificateAuthoritiesPaginator ListWebsiteCertificateAuthorities(ListWebsiteCertificateAuthoritiesRequest request);
    }
}