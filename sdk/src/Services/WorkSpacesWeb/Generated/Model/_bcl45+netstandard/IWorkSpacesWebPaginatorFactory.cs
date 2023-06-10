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
 * Do not modify this file. This file is generated from the workspaces-web-2020-07-08.normal.json service model.
 */

namespace Amazon.WorkSpacesWeb.Model
{
    /// <summary>
    /// Paginators for the WorkSpacesWeb service
    ///</summary>
    public interface IWorkSpacesWebPaginatorFactory
    {

        /// <summary>
        /// Paginator for ListBrowserSettings operation
        ///</summary>
        IListBrowserSettingsPaginator ListBrowserSettings(ListBrowserSettingsRequest request);

        /// <summary>
        /// Paginator for ListIdentityProviders operation
        ///</summary>
        IListIdentityProvidersPaginator ListIdentityProviders(ListIdentityProvidersRequest request);

        /// <summary>
        /// Paginator for ListIpAccessSettings operation
        ///</summary>
        IListIpAccessSettingsPaginator ListIpAccessSettings(ListIpAccessSettingsRequest request);

        /// <summary>
        /// Paginator for ListNetworkSettings operation
        ///</summary>
        IListNetworkSettingsPaginator ListNetworkSettings(ListNetworkSettingsRequest request);

        /// <summary>
        /// Paginator for ListPortals operation
        ///</summary>
        IListPortalsPaginator ListPortals(ListPortalsRequest request);

        /// <summary>
        /// Paginator for ListTrustStoreCertificates operation
        ///</summary>
        IListTrustStoreCertificatesPaginator ListTrustStoreCertificates(ListTrustStoreCertificatesRequest request);

        /// <summary>
        /// Paginator for ListTrustStores operation
        ///</summary>
        IListTrustStoresPaginator ListTrustStores(ListTrustStoresRequest request);

        /// <summary>
        /// Paginator for ListUserAccessLoggingSettings operation
        ///</summary>
        IListUserAccessLoggingSettingsPaginator ListUserAccessLoggingSettings(ListUserAccessLoggingSettingsRequest request);

        /// <summary>
        /// Paginator for ListUserSettings operation
        ///</summary>
        IListUserSettingsPaginator ListUserSettings(ListUserSettingsRequest request);
    }
}