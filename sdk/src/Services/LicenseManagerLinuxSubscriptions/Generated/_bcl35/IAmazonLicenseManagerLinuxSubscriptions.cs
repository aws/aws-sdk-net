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


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
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
        GetServiceSettingsResponse GetServiceSettings(GetServiceSettingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetServiceSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetServiceSettings operation on AmazonLicenseManagerLinuxSubscriptionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetServiceSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-linux-subscriptions-2018-05-10/GetServiceSettings">REST API Reference for GetServiceSettings Operation</seealso>
        IAsyncResult BeginGetServiceSettings(GetServiceSettingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetServiceSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetServiceSettings.</param>
        /// 
        /// <returns>Returns a  GetServiceSettingsResult from LicenseManagerLinuxSubscriptions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-linux-subscriptions-2018-05-10/GetServiceSettings">REST API Reference for GetServiceSettings Operation</seealso>
        GetServiceSettingsResponse EndGetServiceSettings(IAsyncResult asyncResult);

        #endregion
        
        #region  ListLinuxSubscriptionInstances


        /// <summary>
        /// Lists the running Amazon EC2 instances that were discovered with commercial Linux
        /// subscriptions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLinuxSubscriptionInstances service method.</param>
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
        ListLinuxSubscriptionInstancesResponse ListLinuxSubscriptionInstances(ListLinuxSubscriptionInstancesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListLinuxSubscriptionInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListLinuxSubscriptionInstances operation on AmazonLicenseManagerLinuxSubscriptionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListLinuxSubscriptionInstances
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-linux-subscriptions-2018-05-10/ListLinuxSubscriptionInstances">REST API Reference for ListLinuxSubscriptionInstances Operation</seealso>
        IAsyncResult BeginListLinuxSubscriptionInstances(ListLinuxSubscriptionInstancesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListLinuxSubscriptionInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListLinuxSubscriptionInstances.</param>
        /// 
        /// <returns>Returns a  ListLinuxSubscriptionInstancesResult from LicenseManagerLinuxSubscriptions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-linux-subscriptions-2018-05-10/ListLinuxSubscriptionInstances">REST API Reference for ListLinuxSubscriptionInstances Operation</seealso>
        ListLinuxSubscriptionInstancesResponse EndListLinuxSubscriptionInstances(IAsyncResult asyncResult);

        #endregion
        
        #region  ListLinuxSubscriptions


        /// <summary>
        /// Lists the Linux subscriptions that have been discovered. If you have linked your organization,
        /// the returned results will include data aggregated across your accounts in Organizations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLinuxSubscriptions service method.</param>
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
        ListLinuxSubscriptionsResponse ListLinuxSubscriptions(ListLinuxSubscriptionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListLinuxSubscriptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListLinuxSubscriptions operation on AmazonLicenseManagerLinuxSubscriptionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListLinuxSubscriptions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-linux-subscriptions-2018-05-10/ListLinuxSubscriptions">REST API Reference for ListLinuxSubscriptions Operation</seealso>
        IAsyncResult BeginListLinuxSubscriptions(ListLinuxSubscriptionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListLinuxSubscriptions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListLinuxSubscriptions.</param>
        /// 
        /// <returns>Returns a  ListLinuxSubscriptionsResult from LicenseManagerLinuxSubscriptions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-linux-subscriptions-2018-05-10/ListLinuxSubscriptions">REST API Reference for ListLinuxSubscriptions Operation</seealso>
        ListLinuxSubscriptionsResponse EndListLinuxSubscriptions(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateServiceSettings


        /// <summary>
        /// Updates the service settings for Linux subscriptions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateServiceSettings service method.</param>
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
        UpdateServiceSettingsResponse UpdateServiceSettings(UpdateServiceSettingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateServiceSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateServiceSettings operation on AmazonLicenseManagerLinuxSubscriptionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateServiceSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-linux-subscriptions-2018-05-10/UpdateServiceSettings">REST API Reference for UpdateServiceSettings Operation</seealso>
        IAsyncResult BeginUpdateServiceSettings(UpdateServiceSettingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateServiceSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateServiceSettings.</param>
        /// 
        /// <returns>Returns a  UpdateServiceSettingsResult from LicenseManagerLinuxSubscriptions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-linux-subscriptions-2018-05-10/UpdateServiceSettings">REST API Reference for UpdateServiceSettings Operation</seealso>
        UpdateServiceSettingsResponse EndUpdateServiceSettings(IAsyncResult asyncResult);

        #endregion
        
    }
}