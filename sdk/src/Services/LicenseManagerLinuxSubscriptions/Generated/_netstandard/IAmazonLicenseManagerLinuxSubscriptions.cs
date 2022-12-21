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
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.LicenseManagerLinuxSubscriptions.Model;

namespace Amazon.LicenseManagerLinuxSubscriptions
{
    /// <summary>
    /// Interface for accessing LicenseManagerLinuxSubscriptions
    ///
    /// With License Manager, you can discover and track your commercial Linux subscriptions
    /// on running Amazon EC2 instances.
    /// </summary>
    public partial interface IAmazonLicenseManagerLinuxSubscriptions : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        ILicenseManagerLinuxSubscriptionsPaginatorFactory Paginators { get; }
#endif
                
        #region  GetServiceSettings



        /// <summary>
        /// Lists the Linux subscriptions service settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServiceSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetServiceSettings service method, as returned by LicenseManagerLinuxSubscriptions.</returns>
        /// <exception cref="Amazon.LicenseManagerLinuxSubscriptions.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerLinuxSubscriptions.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerLinuxSubscriptions.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-linux-subscriptions-2018-05-10/GetServiceSettings">REST API Reference for GetServiceSettings Operation</seealso>
        Task<GetServiceSettingsResponse> GetServiceSettingsAsync(GetServiceSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListLinuxSubscriptionInstances



        /// <summary>
        /// Lists the running Amazon EC2 instances that were discovered with commercial Linux
        /// subscriptions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLinuxSubscriptionInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListLinuxSubscriptionInstances service method, as returned by LicenseManagerLinuxSubscriptions.</returns>
        /// <exception cref="Amazon.LicenseManagerLinuxSubscriptions.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerLinuxSubscriptions.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerLinuxSubscriptions.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-linux-subscriptions-2018-05-10/ListLinuxSubscriptionInstances">REST API Reference for ListLinuxSubscriptionInstances Operation</seealso>
        Task<ListLinuxSubscriptionInstancesResponse> ListLinuxSubscriptionInstancesAsync(ListLinuxSubscriptionInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListLinuxSubscriptions



        /// <summary>
        /// Lists the Linux subscriptions that have been discovered. If you have linked your organization,
        /// the returned results will include data aggregated across your accounts in Organizations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLinuxSubscriptions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListLinuxSubscriptions service method, as returned by LicenseManagerLinuxSubscriptions.</returns>
        /// <exception cref="Amazon.LicenseManagerLinuxSubscriptions.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerLinuxSubscriptions.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerLinuxSubscriptions.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-linux-subscriptions-2018-05-10/ListLinuxSubscriptions">REST API Reference for ListLinuxSubscriptions Operation</seealso>
        Task<ListLinuxSubscriptionsResponse> ListLinuxSubscriptionsAsync(ListLinuxSubscriptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateServiceSettings



        /// <summary>
        /// Updates the service settings for Linux subscriptions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateServiceSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateServiceSettings service method, as returned by LicenseManagerLinuxSubscriptions.</returns>
        /// <exception cref="Amazon.LicenseManagerLinuxSubscriptions.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerLinuxSubscriptions.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerLinuxSubscriptions.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-linux-subscriptions-2018-05-10/UpdateServiceSettings">REST API Reference for UpdateServiceSettings Operation</seealso>
        Task<UpdateServiceSettingsResponse> UpdateServiceSettingsAsync(UpdateServiceSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}