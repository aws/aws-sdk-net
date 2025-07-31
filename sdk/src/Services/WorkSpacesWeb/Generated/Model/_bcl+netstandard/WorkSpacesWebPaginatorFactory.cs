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

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.WorkSpacesWeb.Model
{
    /// <summary>
    /// Paginators for the WorkSpacesWeb service
    ///</summary>
    public class WorkSpacesWebPaginatorFactory : IWorkSpacesWebPaginatorFactory
    {
        private readonly IAmazonWorkSpacesWeb client;

        internal WorkSpacesWebPaginatorFactory(IAmazonWorkSpacesWeb client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListBrowserSettings operation
        ///</summary>
        public IListBrowserSettingsPaginator ListBrowserSettings(ListBrowserSettingsRequest request) 
        {
            return new ListBrowserSettingsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDataProtectionSettings operation
        ///</summary>
        public IListDataProtectionSettingsPaginator ListDataProtectionSettings(ListDataProtectionSettingsRequest request) 
        {
            return new ListDataProtectionSettingsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListIdentityProviders operation
        ///</summary>
        public IListIdentityProvidersPaginator ListIdentityProviders(ListIdentityProvidersRequest request) 
        {
            return new ListIdentityProvidersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListIpAccessSettings operation
        ///</summary>
        public IListIpAccessSettingsPaginator ListIpAccessSettings(ListIpAccessSettingsRequest request) 
        {
            return new ListIpAccessSettingsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListNetworkSettings operation
        ///</summary>
        public IListNetworkSettingsPaginator ListNetworkSettings(ListNetworkSettingsRequest request) 
        {
            return new ListNetworkSettingsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPortals operation
        ///</summary>
        public IListPortalsPaginator ListPortals(ListPortalsRequest request) 
        {
            return new ListPortalsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSessionLoggers operation
        ///</summary>
        public IListSessionLoggersPaginator ListSessionLoggers(ListSessionLoggersRequest request) 
        {
            return new ListSessionLoggersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSessions operation
        ///</summary>
        public IListSessionsPaginator ListSessions(ListSessionsRequest request) 
        {
            return new ListSessionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTrustStoreCertificates operation
        ///</summary>
        public IListTrustStoreCertificatesPaginator ListTrustStoreCertificates(ListTrustStoreCertificatesRequest request) 
        {
            return new ListTrustStoreCertificatesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTrustStores operation
        ///</summary>
        public IListTrustStoresPaginator ListTrustStores(ListTrustStoresRequest request) 
        {
            return new ListTrustStoresPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListUserAccessLoggingSettings operation
        ///</summary>
        public IListUserAccessLoggingSettingsPaginator ListUserAccessLoggingSettings(ListUserAccessLoggingSettingsRequest request) 
        {
            return new ListUserAccessLoggingSettingsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListUserSettings operation
        ///</summary>
        public IListUserSettingsPaginator ListUserSettings(ListUserSettingsRequest request) 
        {
            return new ListUserSettingsPaginator(this.client, request);
        }
    }
}