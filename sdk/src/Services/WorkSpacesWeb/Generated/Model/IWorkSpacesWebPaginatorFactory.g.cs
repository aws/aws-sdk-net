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

namespace Amazon.WorkSpacesWeb.Model
{
    /// <summary>
    /// Paginators for the WorkSpacesWeb service
    /// </summary>
    public interface IWorkSpacesWebPaginatorFactory
    {
        /// <summary>
        /// Paginator for ListBrowserSettings operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListBrowserSettingsPaginator ListBrowserSettings(ListBrowserSettingsRequest request);

        /// <summary>
        /// Paginator for ListDataProtectionSettings operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListDataProtectionSettingsPaginator ListDataProtectionSettings(ListDataProtectionSettingsRequest request);

        /// <summary>
        /// Paginator for ListIdentityProviders operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListIdentityProvidersPaginator ListIdentityProviders(ListIdentityProvidersRequest request);

        /// <summary>
        /// Paginator for ListIpAccessSettings operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListIpAccessSettingsPaginator ListIpAccessSettings(ListIpAccessSettingsRequest request);

        /// <summary>
        /// Paginator for ListNetworkSettings operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListNetworkSettingsPaginator ListNetworkSettings(ListNetworkSettingsRequest request);

        /// <summary>
        /// Paginator for ListPortals operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListPortalsPaginator ListPortals(ListPortalsRequest request);

        /// <summary>
        /// Paginator for ListSessionLoggers operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListSessionLoggersPaginator ListSessionLoggers(ListSessionLoggersRequest request);

        /// <summary>
        /// Paginator for ListSessions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListSessionsPaginator ListSessions(ListSessionsRequest request);

        /// <summary>
        /// Paginator for ListTrustStoreCertificates operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListTrustStoreCertificatesPaginator ListTrustStoreCertificates(ListTrustStoreCertificatesRequest request);

        /// <summary>
        /// Paginator for ListTrustStores operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListTrustStoresPaginator ListTrustStores(ListTrustStoresRequest request);

        /// <summary>
        /// Paginator for ListUserAccessLoggingSettings operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListUserAccessLoggingSettingsPaginator ListUserAccessLoggingSettings(ListUserAccessLoggingSettingsRequest request);

        /// <summary>
        /// Paginator for ListUserSettings operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListUserSettingsPaginator ListUserSettings(ListUserSettingsRequest request);
    }
}
