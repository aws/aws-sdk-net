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

using Amazon.Runtime;
using Amazon.WorkSpacesWeb.Model;

#pragma warning disable CS1570
namespace Amazon.WorkSpacesWeb
{
    /// <summary>
    /// <para>Interface for accessing WorkSpacesWeb</para>
    ///
    /// Amazon WorkSpaces Secure Browser is a low cost, fully managed WorkSpace built specifically
    /// to facilitate secure, web-based workloads. WorkSpaces Secure Browser makes it easy
    /// for customers to safely provide their employees with access to internal websites and
    /// SaaS web applications without the administrative burden of appliances or specialized
    /// client software. WorkSpaces Secure Browser provides simple policy tools tailored for
    /// user interactions, while offloading common tasks like capacity management, scaling,
    /// and maintaining browser images.
    /// </summary>
    public partial interface IAmazonWorkSpacesWeb : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IWorkSpacesWebPaginatorFactory Paginators { get; }
#endif


        
        #region  AssociateBrowserSettings


        /// <summary>
        /// Associates a browser settings resource with a web portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateBrowserSettings service method.</param>
        /// 
        /// <returns>The response from the AssociateBrowserSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/AssociateBrowserSettings">REST API Reference for AssociateBrowserSettings Operation</seealso>
        AssociateBrowserSettingsResponse AssociateBrowserSettings(AssociateBrowserSettingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateBrowserSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateBrowserSettings operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateBrowserSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/AssociateBrowserSettings">REST API Reference for AssociateBrowserSettings Operation</seealso>
        IAsyncResult BeginAssociateBrowserSettings(AssociateBrowserSettingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateBrowserSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateBrowserSettings.</param>
        /// 
        /// <returns>Returns a  AssociateBrowserSettingsResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/AssociateBrowserSettings">REST API Reference for AssociateBrowserSettings Operation</seealso>
        AssociateBrowserSettingsResponse EndAssociateBrowserSettings(IAsyncResult asyncResult);

        #endregion
        
        #region  AssociateDataProtectionSettings


        /// <summary>
        /// Associates a data protection settings resource with a web portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateDataProtectionSettings service method.</param>
        /// 
        /// <returns>The response from the AssociateDataProtectionSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/AssociateDataProtectionSettings">REST API Reference for AssociateDataProtectionSettings Operation</seealso>
        AssociateDataProtectionSettingsResponse AssociateDataProtectionSettings(AssociateDataProtectionSettingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateDataProtectionSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateDataProtectionSettings operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateDataProtectionSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/AssociateDataProtectionSettings">REST API Reference for AssociateDataProtectionSettings Operation</seealso>
        IAsyncResult BeginAssociateDataProtectionSettings(AssociateDataProtectionSettingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateDataProtectionSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateDataProtectionSettings.</param>
        /// 
        /// <returns>Returns a  AssociateDataProtectionSettingsResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/AssociateDataProtectionSettings">REST API Reference for AssociateDataProtectionSettings Operation</seealso>
        AssociateDataProtectionSettingsResponse EndAssociateDataProtectionSettings(IAsyncResult asyncResult);

        #endregion
        
        #region  AssociateIpAccessSettings


        /// <summary>
        /// Associates an IP access settings resource with a web portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateIpAccessSettings service method.</param>
        /// 
        /// <returns>The response from the AssociateIpAccessSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/AssociateIpAccessSettings">REST API Reference for AssociateIpAccessSettings Operation</seealso>
        AssociateIpAccessSettingsResponse AssociateIpAccessSettings(AssociateIpAccessSettingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateIpAccessSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateIpAccessSettings operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateIpAccessSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/AssociateIpAccessSettings">REST API Reference for AssociateIpAccessSettings Operation</seealso>
        IAsyncResult BeginAssociateIpAccessSettings(AssociateIpAccessSettingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateIpAccessSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateIpAccessSettings.</param>
        /// 
        /// <returns>Returns a  AssociateIpAccessSettingsResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/AssociateIpAccessSettings">REST API Reference for AssociateIpAccessSettings Operation</seealso>
        AssociateIpAccessSettingsResponse EndAssociateIpAccessSettings(IAsyncResult asyncResult);

        #endregion
        
        #region  AssociateNetworkSettings


        /// <summary>
        /// Associates a network settings resource with a web portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateNetworkSettings service method.</param>
        /// 
        /// <returns>The response from the AssociateNetworkSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/AssociateNetworkSettings">REST API Reference for AssociateNetworkSettings Operation</seealso>
        AssociateNetworkSettingsResponse AssociateNetworkSettings(AssociateNetworkSettingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateNetworkSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateNetworkSettings operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateNetworkSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/AssociateNetworkSettings">REST API Reference for AssociateNetworkSettings Operation</seealso>
        IAsyncResult BeginAssociateNetworkSettings(AssociateNetworkSettingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateNetworkSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateNetworkSettings.</param>
        /// 
        /// <returns>Returns a  AssociateNetworkSettingsResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/AssociateNetworkSettings">REST API Reference for AssociateNetworkSettings Operation</seealso>
        AssociateNetworkSettingsResponse EndAssociateNetworkSettings(IAsyncResult asyncResult);

        #endregion
        
        #region  AssociateSessionLogger


        /// <summary>
        /// Associates a session logger with a portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateSessionLogger service method.</param>
        /// 
        /// <returns>The response from the AssociateSessionLogger service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/AssociateSessionLogger">REST API Reference for AssociateSessionLogger Operation</seealso>
        AssociateSessionLoggerResponse AssociateSessionLogger(AssociateSessionLoggerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateSessionLogger operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateSessionLogger operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateSessionLogger
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/AssociateSessionLogger">REST API Reference for AssociateSessionLogger Operation</seealso>
        IAsyncResult BeginAssociateSessionLogger(AssociateSessionLoggerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateSessionLogger operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateSessionLogger.</param>
        /// 
        /// <returns>Returns a  AssociateSessionLoggerResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/AssociateSessionLogger">REST API Reference for AssociateSessionLogger Operation</seealso>
        AssociateSessionLoggerResponse EndAssociateSessionLogger(IAsyncResult asyncResult);

        #endregion
        
        #region  AssociateTrustStore


        /// <summary>
        /// Associates a trust store with a web portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateTrustStore service method.</param>
        /// 
        /// <returns>The response from the AssociateTrustStore service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/AssociateTrustStore">REST API Reference for AssociateTrustStore Operation</seealso>
        AssociateTrustStoreResponse AssociateTrustStore(AssociateTrustStoreRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateTrustStore operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateTrustStore operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateTrustStore
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/AssociateTrustStore">REST API Reference for AssociateTrustStore Operation</seealso>
        IAsyncResult BeginAssociateTrustStore(AssociateTrustStoreRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateTrustStore operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateTrustStore.</param>
        /// 
        /// <returns>Returns a  AssociateTrustStoreResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/AssociateTrustStore">REST API Reference for AssociateTrustStore Operation</seealso>
        AssociateTrustStoreResponse EndAssociateTrustStore(IAsyncResult asyncResult);

        #endregion
        
        #region  AssociateUserAccessLoggingSettings


        /// <summary>
        /// Associates a user access logging settings resource with a web portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateUserAccessLoggingSettings service method.</param>
        /// 
        /// <returns>The response from the AssociateUserAccessLoggingSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/AssociateUserAccessLoggingSettings">REST API Reference for AssociateUserAccessLoggingSettings Operation</seealso>
        AssociateUserAccessLoggingSettingsResponse AssociateUserAccessLoggingSettings(AssociateUserAccessLoggingSettingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateUserAccessLoggingSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateUserAccessLoggingSettings operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateUserAccessLoggingSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/AssociateUserAccessLoggingSettings">REST API Reference for AssociateUserAccessLoggingSettings Operation</seealso>
        IAsyncResult BeginAssociateUserAccessLoggingSettings(AssociateUserAccessLoggingSettingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateUserAccessLoggingSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateUserAccessLoggingSettings.</param>
        /// 
        /// <returns>Returns a  AssociateUserAccessLoggingSettingsResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/AssociateUserAccessLoggingSettings">REST API Reference for AssociateUserAccessLoggingSettings Operation</seealso>
        AssociateUserAccessLoggingSettingsResponse EndAssociateUserAccessLoggingSettings(IAsyncResult asyncResult);

        #endregion
        
        #region  AssociateUserSettings


        /// <summary>
        /// Associates a user settings resource with a web portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateUserSettings service method.</param>
        /// 
        /// <returns>The response from the AssociateUserSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/AssociateUserSettings">REST API Reference for AssociateUserSettings Operation</seealso>
        AssociateUserSettingsResponse AssociateUserSettings(AssociateUserSettingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateUserSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateUserSettings operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateUserSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/AssociateUserSettings">REST API Reference for AssociateUserSettings Operation</seealso>
        IAsyncResult BeginAssociateUserSettings(AssociateUserSettingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateUserSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateUserSettings.</param>
        /// 
        /// <returns>Returns a  AssociateUserSettingsResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/AssociateUserSettings">REST API Reference for AssociateUserSettings Operation</seealso>
        AssociateUserSettingsResponse EndAssociateUserSettings(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateBrowserSettings


        /// <summary>
        /// Creates a browser settings resource that can be associated with a web portal. Once
        /// associated with a web portal, browser settings control how the browser will behave
        /// once a user starts a streaming session for the web portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBrowserSettings service method.</param>
        /// 
        /// <returns>The response from the CreateBrowserSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/CreateBrowserSettings">REST API Reference for CreateBrowserSettings Operation</seealso>
        CreateBrowserSettingsResponse CreateBrowserSettings(CreateBrowserSettingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateBrowserSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateBrowserSettings operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateBrowserSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/CreateBrowserSettings">REST API Reference for CreateBrowserSettings Operation</seealso>
        IAsyncResult BeginCreateBrowserSettings(CreateBrowserSettingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateBrowserSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateBrowserSettings.</param>
        /// 
        /// <returns>Returns a  CreateBrowserSettingsResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/CreateBrowserSettings">REST API Reference for CreateBrowserSettings Operation</seealso>
        CreateBrowserSettingsResponse EndCreateBrowserSettings(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateDataProtectionSettings


        /// <summary>
        /// Creates a data protection settings resource that can be associated with a web portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataProtectionSettings service method.</param>
        /// 
        /// <returns>The response from the CreateDataProtectionSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/CreateDataProtectionSettings">REST API Reference for CreateDataProtectionSettings Operation</seealso>
        CreateDataProtectionSettingsResponse CreateDataProtectionSettings(CreateDataProtectionSettingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDataProtectionSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDataProtectionSettings operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDataProtectionSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/CreateDataProtectionSettings">REST API Reference for CreateDataProtectionSettings Operation</seealso>
        IAsyncResult BeginCreateDataProtectionSettings(CreateDataProtectionSettingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDataProtectionSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDataProtectionSettings.</param>
        /// 
        /// <returns>Returns a  CreateDataProtectionSettingsResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/CreateDataProtectionSettings">REST API Reference for CreateDataProtectionSettings Operation</seealso>
        CreateDataProtectionSettingsResponse EndCreateDataProtectionSettings(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateIdentityProvider


        /// <summary>
        /// Creates an identity provider resource that is then associated with a web portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIdentityProvider service method.</param>
        /// 
        /// <returns>The response from the CreateIdentityProvider service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/CreateIdentityProvider">REST API Reference for CreateIdentityProvider Operation</seealso>
        CreateIdentityProviderResponse CreateIdentityProvider(CreateIdentityProviderRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateIdentityProvider operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateIdentityProvider operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateIdentityProvider
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/CreateIdentityProvider">REST API Reference for CreateIdentityProvider Operation</seealso>
        IAsyncResult BeginCreateIdentityProvider(CreateIdentityProviderRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateIdentityProvider operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateIdentityProvider.</param>
        /// 
        /// <returns>Returns a  CreateIdentityProviderResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/CreateIdentityProvider">REST API Reference for CreateIdentityProvider Operation</seealso>
        CreateIdentityProviderResponse EndCreateIdentityProvider(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateIpAccessSettings


        /// <summary>
        /// Creates an IP access settings resource that can be associated with a web portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIpAccessSettings service method.</param>
        /// 
        /// <returns>The response from the CreateIpAccessSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/CreateIpAccessSettings">REST API Reference for CreateIpAccessSettings Operation</seealso>
        CreateIpAccessSettingsResponse CreateIpAccessSettings(CreateIpAccessSettingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateIpAccessSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateIpAccessSettings operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateIpAccessSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/CreateIpAccessSettings">REST API Reference for CreateIpAccessSettings Operation</seealso>
        IAsyncResult BeginCreateIpAccessSettings(CreateIpAccessSettingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateIpAccessSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateIpAccessSettings.</param>
        /// 
        /// <returns>Returns a  CreateIpAccessSettingsResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/CreateIpAccessSettings">REST API Reference for CreateIpAccessSettings Operation</seealso>
        CreateIpAccessSettingsResponse EndCreateIpAccessSettings(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateNetworkSettings


        /// <summary>
        /// Creates a network settings resource that can be associated with a web portal. Once
        /// associated with a web portal, network settings define how streaming instances will
        /// connect with your specified VPC.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNetworkSettings service method.</param>
        /// 
        /// <returns>The response from the CreateNetworkSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/CreateNetworkSettings">REST API Reference for CreateNetworkSettings Operation</seealso>
        CreateNetworkSettingsResponse CreateNetworkSettings(CreateNetworkSettingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateNetworkSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateNetworkSettings operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateNetworkSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/CreateNetworkSettings">REST API Reference for CreateNetworkSettings Operation</seealso>
        IAsyncResult BeginCreateNetworkSettings(CreateNetworkSettingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateNetworkSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateNetworkSettings.</param>
        /// 
        /// <returns>Returns a  CreateNetworkSettingsResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/CreateNetworkSettings">REST API Reference for CreateNetworkSettings Operation</seealso>
        CreateNetworkSettingsResponse EndCreateNetworkSettings(IAsyncResult asyncResult);

        #endregion
        
        #region  CreatePortal


        /// <summary>
        /// Creates a web portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePortal service method.</param>
        /// 
        /// <returns>The response from the CreatePortal service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/CreatePortal">REST API Reference for CreatePortal Operation</seealso>
        CreatePortalResponse CreatePortal(CreatePortalRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePortal operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePortal operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePortal
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/CreatePortal">REST API Reference for CreatePortal Operation</seealso>
        IAsyncResult BeginCreatePortal(CreatePortalRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePortal operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePortal.</param>
        /// 
        /// <returns>Returns a  CreatePortalResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/CreatePortal">REST API Reference for CreatePortal Operation</seealso>
        CreatePortalResponse EndCreatePortal(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateSessionLogger


        /// <summary>
        /// Creates a session logger.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSessionLogger service method.</param>
        /// 
        /// <returns>The response from the CreateSessionLogger service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/CreateSessionLogger">REST API Reference for CreateSessionLogger Operation</seealso>
        CreateSessionLoggerResponse CreateSessionLogger(CreateSessionLoggerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSessionLogger operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSessionLogger operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSessionLogger
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/CreateSessionLogger">REST API Reference for CreateSessionLogger Operation</seealso>
        IAsyncResult BeginCreateSessionLogger(CreateSessionLoggerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSessionLogger operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSessionLogger.</param>
        /// 
        /// <returns>Returns a  CreateSessionLoggerResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/CreateSessionLogger">REST API Reference for CreateSessionLogger Operation</seealso>
        CreateSessionLoggerResponse EndCreateSessionLogger(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateTrustStore


        /// <summary>
        /// Creates a trust store that can be associated with a web portal. A trust store contains
        /// certificate authority (CA) certificates. Once associated with a web portal, the browser
        /// in a streaming session will recognize certificates that have been issued using any
        /// of the CAs in the trust store. If your organization has internal websites that use
        /// certificates issued by private CAs, you should add the private CA certificate to the
        /// trust store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTrustStore service method.</param>
        /// 
        /// <returns>The response from the CreateTrustStore service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/CreateTrustStore">REST API Reference for CreateTrustStore Operation</seealso>
        CreateTrustStoreResponse CreateTrustStore(CreateTrustStoreRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTrustStore operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTrustStore operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateTrustStore
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/CreateTrustStore">REST API Reference for CreateTrustStore Operation</seealso>
        IAsyncResult BeginCreateTrustStore(CreateTrustStoreRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateTrustStore operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTrustStore.</param>
        /// 
        /// <returns>Returns a  CreateTrustStoreResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/CreateTrustStore">REST API Reference for CreateTrustStore Operation</seealso>
        CreateTrustStoreResponse EndCreateTrustStore(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateUserAccessLoggingSettings


        /// <summary>
        /// Creates a user access logging settings resource that can be associated with a web
        /// portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUserAccessLoggingSettings service method.</param>
        /// 
        /// <returns>The response from the CreateUserAccessLoggingSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/CreateUserAccessLoggingSettings">REST API Reference for CreateUserAccessLoggingSettings Operation</seealso>
        CreateUserAccessLoggingSettingsResponse CreateUserAccessLoggingSettings(CreateUserAccessLoggingSettingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateUserAccessLoggingSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateUserAccessLoggingSettings operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateUserAccessLoggingSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/CreateUserAccessLoggingSettings">REST API Reference for CreateUserAccessLoggingSettings Operation</seealso>
        IAsyncResult BeginCreateUserAccessLoggingSettings(CreateUserAccessLoggingSettingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateUserAccessLoggingSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateUserAccessLoggingSettings.</param>
        /// 
        /// <returns>Returns a  CreateUserAccessLoggingSettingsResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/CreateUserAccessLoggingSettings">REST API Reference for CreateUserAccessLoggingSettings Operation</seealso>
        CreateUserAccessLoggingSettingsResponse EndCreateUserAccessLoggingSettings(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateUserSettings


        /// <summary>
        /// Creates a user settings resource that can be associated with a web portal. Once associated
        /// with a web portal, user settings control how users can transfer data between a streaming
        /// session and the their local devices.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUserSettings service method.</param>
        /// 
        /// <returns>The response from the CreateUserSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/CreateUserSettings">REST API Reference for CreateUserSettings Operation</seealso>
        CreateUserSettingsResponse CreateUserSettings(CreateUserSettingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateUserSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateUserSettings operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateUserSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/CreateUserSettings">REST API Reference for CreateUserSettings Operation</seealso>
        IAsyncResult BeginCreateUserSettings(CreateUserSettingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateUserSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateUserSettings.</param>
        /// 
        /// <returns>Returns a  CreateUserSettingsResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/CreateUserSettings">REST API Reference for CreateUserSettings Operation</seealso>
        CreateUserSettingsResponse EndCreateUserSettings(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteBrowserSettings


        /// <summary>
        /// Deletes browser settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBrowserSettings service method.</param>
        /// 
        /// <returns>The response from the DeleteBrowserSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DeleteBrowserSettings">REST API Reference for DeleteBrowserSettings Operation</seealso>
        DeleteBrowserSettingsResponse DeleteBrowserSettings(DeleteBrowserSettingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBrowserSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBrowserSettings operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteBrowserSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DeleteBrowserSettings">REST API Reference for DeleteBrowserSettings Operation</seealso>
        IAsyncResult BeginDeleteBrowserSettings(DeleteBrowserSettingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteBrowserSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBrowserSettings.</param>
        /// 
        /// <returns>Returns a  DeleteBrowserSettingsResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DeleteBrowserSettings">REST API Reference for DeleteBrowserSettings Operation</seealso>
        DeleteBrowserSettingsResponse EndDeleteBrowserSettings(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteDataProtectionSettings


        /// <summary>
        /// Deletes data protection settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataProtectionSettings service method.</param>
        /// 
        /// <returns>The response from the DeleteDataProtectionSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DeleteDataProtectionSettings">REST API Reference for DeleteDataProtectionSettings Operation</seealso>
        DeleteDataProtectionSettingsResponse DeleteDataProtectionSettings(DeleteDataProtectionSettingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDataProtectionSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataProtectionSettings operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDataProtectionSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DeleteDataProtectionSettings">REST API Reference for DeleteDataProtectionSettings Operation</seealso>
        IAsyncResult BeginDeleteDataProtectionSettings(DeleteDataProtectionSettingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDataProtectionSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDataProtectionSettings.</param>
        /// 
        /// <returns>Returns a  DeleteDataProtectionSettingsResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DeleteDataProtectionSettings">REST API Reference for DeleteDataProtectionSettings Operation</seealso>
        DeleteDataProtectionSettingsResponse EndDeleteDataProtectionSettings(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteIdentityProvider


        /// <summary>
        /// Deletes the identity provider.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIdentityProvider service method.</param>
        /// 
        /// <returns>The response from the DeleteIdentityProvider service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DeleteIdentityProvider">REST API Reference for DeleteIdentityProvider Operation</seealso>
        DeleteIdentityProviderResponse DeleteIdentityProvider(DeleteIdentityProviderRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteIdentityProvider operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteIdentityProvider operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteIdentityProvider
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DeleteIdentityProvider">REST API Reference for DeleteIdentityProvider Operation</seealso>
        IAsyncResult BeginDeleteIdentityProvider(DeleteIdentityProviderRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteIdentityProvider operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteIdentityProvider.</param>
        /// 
        /// <returns>Returns a  DeleteIdentityProviderResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DeleteIdentityProvider">REST API Reference for DeleteIdentityProvider Operation</seealso>
        DeleteIdentityProviderResponse EndDeleteIdentityProvider(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteIpAccessSettings


        /// <summary>
        /// Deletes IP access settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIpAccessSettings service method.</param>
        /// 
        /// <returns>The response from the DeleteIpAccessSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DeleteIpAccessSettings">REST API Reference for DeleteIpAccessSettings Operation</seealso>
        DeleteIpAccessSettingsResponse DeleteIpAccessSettings(DeleteIpAccessSettingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteIpAccessSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteIpAccessSettings operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteIpAccessSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DeleteIpAccessSettings">REST API Reference for DeleteIpAccessSettings Operation</seealso>
        IAsyncResult BeginDeleteIpAccessSettings(DeleteIpAccessSettingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteIpAccessSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteIpAccessSettings.</param>
        /// 
        /// <returns>Returns a  DeleteIpAccessSettingsResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DeleteIpAccessSettings">REST API Reference for DeleteIpAccessSettings Operation</seealso>
        DeleteIpAccessSettingsResponse EndDeleteIpAccessSettings(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteNetworkSettings


        /// <summary>
        /// Deletes network settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNetworkSettings service method.</param>
        /// 
        /// <returns>The response from the DeleteNetworkSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DeleteNetworkSettings">REST API Reference for DeleteNetworkSettings Operation</seealso>
        DeleteNetworkSettingsResponse DeleteNetworkSettings(DeleteNetworkSettingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteNetworkSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteNetworkSettings operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteNetworkSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DeleteNetworkSettings">REST API Reference for DeleteNetworkSettings Operation</seealso>
        IAsyncResult BeginDeleteNetworkSettings(DeleteNetworkSettingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteNetworkSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteNetworkSettings.</param>
        /// 
        /// <returns>Returns a  DeleteNetworkSettingsResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DeleteNetworkSettings">REST API Reference for DeleteNetworkSettings Operation</seealso>
        DeleteNetworkSettingsResponse EndDeleteNetworkSettings(IAsyncResult asyncResult);

        #endregion
        
        #region  DeletePortal


        /// <summary>
        /// Deletes a web portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePortal service method.</param>
        /// 
        /// <returns>The response from the DeletePortal service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DeletePortal">REST API Reference for DeletePortal Operation</seealso>
        DeletePortalResponse DeletePortal(DeletePortalRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePortal operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePortal operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePortal
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DeletePortal">REST API Reference for DeletePortal Operation</seealso>
        IAsyncResult BeginDeletePortal(DeletePortalRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePortal operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePortal.</param>
        /// 
        /// <returns>Returns a  DeletePortalResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DeletePortal">REST API Reference for DeletePortal Operation</seealso>
        DeletePortalResponse EndDeletePortal(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteSessionLogger


        /// <summary>
        /// Deletes a session logger resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSessionLogger service method.</param>
        /// 
        /// <returns>The response from the DeleteSessionLogger service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DeleteSessionLogger">REST API Reference for DeleteSessionLogger Operation</seealso>
        DeleteSessionLoggerResponse DeleteSessionLogger(DeleteSessionLoggerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSessionLogger operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSessionLogger operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSessionLogger
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DeleteSessionLogger">REST API Reference for DeleteSessionLogger Operation</seealso>
        IAsyncResult BeginDeleteSessionLogger(DeleteSessionLoggerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSessionLogger operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSessionLogger.</param>
        /// 
        /// <returns>Returns a  DeleteSessionLoggerResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DeleteSessionLogger">REST API Reference for DeleteSessionLogger Operation</seealso>
        DeleteSessionLoggerResponse EndDeleteSessionLogger(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteTrustStore


        /// <summary>
        /// Deletes the trust store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTrustStore service method.</param>
        /// 
        /// <returns>The response from the DeleteTrustStore service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DeleteTrustStore">REST API Reference for DeleteTrustStore Operation</seealso>
        DeleteTrustStoreResponse DeleteTrustStore(DeleteTrustStoreRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTrustStore operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTrustStore operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTrustStore
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DeleteTrustStore">REST API Reference for DeleteTrustStore Operation</seealso>
        IAsyncResult BeginDeleteTrustStore(DeleteTrustStoreRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTrustStore operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTrustStore.</param>
        /// 
        /// <returns>Returns a  DeleteTrustStoreResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DeleteTrustStore">REST API Reference for DeleteTrustStore Operation</seealso>
        DeleteTrustStoreResponse EndDeleteTrustStore(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteUserAccessLoggingSettings


        /// <summary>
        /// Deletes user access logging settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserAccessLoggingSettings service method.</param>
        /// 
        /// <returns>The response from the DeleteUserAccessLoggingSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DeleteUserAccessLoggingSettings">REST API Reference for DeleteUserAccessLoggingSettings Operation</seealso>
        DeleteUserAccessLoggingSettingsResponse DeleteUserAccessLoggingSettings(DeleteUserAccessLoggingSettingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUserAccessLoggingSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserAccessLoggingSettings operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteUserAccessLoggingSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DeleteUserAccessLoggingSettings">REST API Reference for DeleteUserAccessLoggingSettings Operation</seealso>
        IAsyncResult BeginDeleteUserAccessLoggingSettings(DeleteUserAccessLoggingSettingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteUserAccessLoggingSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteUserAccessLoggingSettings.</param>
        /// 
        /// <returns>Returns a  DeleteUserAccessLoggingSettingsResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DeleteUserAccessLoggingSettings">REST API Reference for DeleteUserAccessLoggingSettings Operation</seealso>
        DeleteUserAccessLoggingSettingsResponse EndDeleteUserAccessLoggingSettings(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteUserSettings


        /// <summary>
        /// Deletes user settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserSettings service method.</param>
        /// 
        /// <returns>The response from the DeleteUserSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DeleteUserSettings">REST API Reference for DeleteUserSettings Operation</seealso>
        DeleteUserSettingsResponse DeleteUserSettings(DeleteUserSettingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUserSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserSettings operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteUserSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DeleteUserSettings">REST API Reference for DeleteUserSettings Operation</seealso>
        IAsyncResult BeginDeleteUserSettings(DeleteUserSettingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteUserSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteUserSettings.</param>
        /// 
        /// <returns>Returns a  DeleteUserSettingsResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DeleteUserSettings">REST API Reference for DeleteUserSettings Operation</seealso>
        DeleteUserSettingsResponse EndDeleteUserSettings(IAsyncResult asyncResult);

        #endregion
        
        #region  DisassociateBrowserSettings


        /// <summary>
        /// Disassociates browser settings from a web portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateBrowserSettings service method.</param>
        /// 
        /// <returns>The response from the DisassociateBrowserSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DisassociateBrowserSettings">REST API Reference for DisassociateBrowserSettings Operation</seealso>
        DisassociateBrowserSettingsResponse DisassociateBrowserSettings(DisassociateBrowserSettingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateBrowserSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateBrowserSettings operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateBrowserSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DisassociateBrowserSettings">REST API Reference for DisassociateBrowserSettings Operation</seealso>
        IAsyncResult BeginDisassociateBrowserSettings(DisassociateBrowserSettingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateBrowserSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateBrowserSettings.</param>
        /// 
        /// <returns>Returns a  DisassociateBrowserSettingsResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DisassociateBrowserSettings">REST API Reference for DisassociateBrowserSettings Operation</seealso>
        DisassociateBrowserSettingsResponse EndDisassociateBrowserSettings(IAsyncResult asyncResult);

        #endregion
        
        #region  DisassociateDataProtectionSettings


        /// <summary>
        /// Disassociates data protection settings from a web portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateDataProtectionSettings service method.</param>
        /// 
        /// <returns>The response from the DisassociateDataProtectionSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DisassociateDataProtectionSettings">REST API Reference for DisassociateDataProtectionSettings Operation</seealso>
        DisassociateDataProtectionSettingsResponse DisassociateDataProtectionSettings(DisassociateDataProtectionSettingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateDataProtectionSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateDataProtectionSettings operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateDataProtectionSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DisassociateDataProtectionSettings">REST API Reference for DisassociateDataProtectionSettings Operation</seealso>
        IAsyncResult BeginDisassociateDataProtectionSettings(DisassociateDataProtectionSettingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateDataProtectionSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateDataProtectionSettings.</param>
        /// 
        /// <returns>Returns a  DisassociateDataProtectionSettingsResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DisassociateDataProtectionSettings">REST API Reference for DisassociateDataProtectionSettings Operation</seealso>
        DisassociateDataProtectionSettingsResponse EndDisassociateDataProtectionSettings(IAsyncResult asyncResult);

        #endregion
        
        #region  DisassociateIpAccessSettings


        /// <summary>
        /// Disassociates IP access settings from a web portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateIpAccessSettings service method.</param>
        /// 
        /// <returns>The response from the DisassociateIpAccessSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DisassociateIpAccessSettings">REST API Reference for DisassociateIpAccessSettings Operation</seealso>
        DisassociateIpAccessSettingsResponse DisassociateIpAccessSettings(DisassociateIpAccessSettingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateIpAccessSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateIpAccessSettings operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateIpAccessSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DisassociateIpAccessSettings">REST API Reference for DisassociateIpAccessSettings Operation</seealso>
        IAsyncResult BeginDisassociateIpAccessSettings(DisassociateIpAccessSettingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateIpAccessSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateIpAccessSettings.</param>
        /// 
        /// <returns>Returns a  DisassociateIpAccessSettingsResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DisassociateIpAccessSettings">REST API Reference for DisassociateIpAccessSettings Operation</seealso>
        DisassociateIpAccessSettingsResponse EndDisassociateIpAccessSettings(IAsyncResult asyncResult);

        #endregion
        
        #region  DisassociateNetworkSettings


        /// <summary>
        /// Disassociates network settings from a web portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateNetworkSettings service method.</param>
        /// 
        /// <returns>The response from the DisassociateNetworkSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DisassociateNetworkSettings">REST API Reference for DisassociateNetworkSettings Operation</seealso>
        DisassociateNetworkSettingsResponse DisassociateNetworkSettings(DisassociateNetworkSettingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateNetworkSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateNetworkSettings operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateNetworkSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DisassociateNetworkSettings">REST API Reference for DisassociateNetworkSettings Operation</seealso>
        IAsyncResult BeginDisassociateNetworkSettings(DisassociateNetworkSettingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateNetworkSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateNetworkSettings.</param>
        /// 
        /// <returns>Returns a  DisassociateNetworkSettingsResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DisassociateNetworkSettings">REST API Reference for DisassociateNetworkSettings Operation</seealso>
        DisassociateNetworkSettingsResponse EndDisassociateNetworkSettings(IAsyncResult asyncResult);

        #endregion
        
        #region  DisassociateSessionLogger


        /// <summary>
        /// Disassociates a session logger from a portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateSessionLogger service method.</param>
        /// 
        /// <returns>The response from the DisassociateSessionLogger service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DisassociateSessionLogger">REST API Reference for DisassociateSessionLogger Operation</seealso>
        DisassociateSessionLoggerResponse DisassociateSessionLogger(DisassociateSessionLoggerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateSessionLogger operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateSessionLogger operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateSessionLogger
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DisassociateSessionLogger">REST API Reference for DisassociateSessionLogger Operation</seealso>
        IAsyncResult BeginDisassociateSessionLogger(DisassociateSessionLoggerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateSessionLogger operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateSessionLogger.</param>
        /// 
        /// <returns>Returns a  DisassociateSessionLoggerResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DisassociateSessionLogger">REST API Reference for DisassociateSessionLogger Operation</seealso>
        DisassociateSessionLoggerResponse EndDisassociateSessionLogger(IAsyncResult asyncResult);

        #endregion
        
        #region  DisassociateTrustStore


        /// <summary>
        /// Disassociates a trust store from a web portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateTrustStore service method.</param>
        /// 
        /// <returns>The response from the DisassociateTrustStore service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DisassociateTrustStore">REST API Reference for DisassociateTrustStore Operation</seealso>
        DisassociateTrustStoreResponse DisassociateTrustStore(DisassociateTrustStoreRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateTrustStore operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateTrustStore operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateTrustStore
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DisassociateTrustStore">REST API Reference for DisassociateTrustStore Operation</seealso>
        IAsyncResult BeginDisassociateTrustStore(DisassociateTrustStoreRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateTrustStore operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateTrustStore.</param>
        /// 
        /// <returns>Returns a  DisassociateTrustStoreResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DisassociateTrustStore">REST API Reference for DisassociateTrustStore Operation</seealso>
        DisassociateTrustStoreResponse EndDisassociateTrustStore(IAsyncResult asyncResult);

        #endregion
        
        #region  DisassociateUserAccessLoggingSettings


        /// <summary>
        /// Disassociates user access logging settings from a web portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateUserAccessLoggingSettings service method.</param>
        /// 
        /// <returns>The response from the DisassociateUserAccessLoggingSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DisassociateUserAccessLoggingSettings">REST API Reference for DisassociateUserAccessLoggingSettings Operation</seealso>
        DisassociateUserAccessLoggingSettingsResponse DisassociateUserAccessLoggingSettings(DisassociateUserAccessLoggingSettingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateUserAccessLoggingSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateUserAccessLoggingSettings operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateUserAccessLoggingSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DisassociateUserAccessLoggingSettings">REST API Reference for DisassociateUserAccessLoggingSettings Operation</seealso>
        IAsyncResult BeginDisassociateUserAccessLoggingSettings(DisassociateUserAccessLoggingSettingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateUserAccessLoggingSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateUserAccessLoggingSettings.</param>
        /// 
        /// <returns>Returns a  DisassociateUserAccessLoggingSettingsResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DisassociateUserAccessLoggingSettings">REST API Reference for DisassociateUserAccessLoggingSettings Operation</seealso>
        DisassociateUserAccessLoggingSettingsResponse EndDisassociateUserAccessLoggingSettings(IAsyncResult asyncResult);

        #endregion
        
        #region  DisassociateUserSettings


        /// <summary>
        /// Disassociates user settings from a web portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateUserSettings service method.</param>
        /// 
        /// <returns>The response from the DisassociateUserSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DisassociateUserSettings">REST API Reference for DisassociateUserSettings Operation</seealso>
        DisassociateUserSettingsResponse DisassociateUserSettings(DisassociateUserSettingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateUserSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateUserSettings operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateUserSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DisassociateUserSettings">REST API Reference for DisassociateUserSettings Operation</seealso>
        IAsyncResult BeginDisassociateUserSettings(DisassociateUserSettingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateUserSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateUserSettings.</param>
        /// 
        /// <returns>Returns a  DisassociateUserSettingsResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DisassociateUserSettings">REST API Reference for DisassociateUserSettings Operation</seealso>
        DisassociateUserSettingsResponse EndDisassociateUserSettings(IAsyncResult asyncResult);

        #endregion
        
        #region  ExpireSession


        /// <summary>
        /// Expires an active secure browser session.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExpireSession service method.</param>
        /// 
        /// <returns>The response from the ExpireSession service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ExpireSession">REST API Reference for ExpireSession Operation</seealso>
        ExpireSessionResponse ExpireSession(ExpireSessionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ExpireSession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ExpireSession operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndExpireSession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ExpireSession">REST API Reference for ExpireSession Operation</seealso>
        IAsyncResult BeginExpireSession(ExpireSessionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ExpireSession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginExpireSession.</param>
        /// 
        /// <returns>Returns a  ExpireSessionResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ExpireSession">REST API Reference for ExpireSession Operation</seealso>
        ExpireSessionResponse EndExpireSession(IAsyncResult asyncResult);

        #endregion
        
        #region  GetBrowserSettings


        /// <summary>
        /// Gets browser settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBrowserSettings service method.</param>
        /// 
        /// <returns>The response from the GetBrowserSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/GetBrowserSettings">REST API Reference for GetBrowserSettings Operation</seealso>
        GetBrowserSettingsResponse GetBrowserSettings(GetBrowserSettingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetBrowserSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBrowserSettings operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBrowserSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/GetBrowserSettings">REST API Reference for GetBrowserSettings Operation</seealso>
        IAsyncResult BeginGetBrowserSettings(GetBrowserSettingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetBrowserSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBrowserSettings.</param>
        /// 
        /// <returns>Returns a  GetBrowserSettingsResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/GetBrowserSettings">REST API Reference for GetBrowserSettings Operation</seealso>
        GetBrowserSettingsResponse EndGetBrowserSettings(IAsyncResult asyncResult);

        #endregion
        
        #region  GetDataProtectionSettings


        /// <summary>
        /// Gets the data protection settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataProtectionSettings service method.</param>
        /// 
        /// <returns>The response from the GetDataProtectionSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/GetDataProtectionSettings">REST API Reference for GetDataProtectionSettings Operation</seealso>
        GetDataProtectionSettingsResponse GetDataProtectionSettings(GetDataProtectionSettingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetDataProtectionSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDataProtectionSettings operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDataProtectionSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/GetDataProtectionSettings">REST API Reference for GetDataProtectionSettings Operation</seealso>
        IAsyncResult BeginGetDataProtectionSettings(GetDataProtectionSettingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDataProtectionSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDataProtectionSettings.</param>
        /// 
        /// <returns>Returns a  GetDataProtectionSettingsResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/GetDataProtectionSettings">REST API Reference for GetDataProtectionSettings Operation</seealso>
        GetDataProtectionSettingsResponse EndGetDataProtectionSettings(IAsyncResult asyncResult);

        #endregion
        
        #region  GetIdentityProvider


        /// <summary>
        /// Gets the identity provider.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIdentityProvider service method.</param>
        /// 
        /// <returns>The response from the GetIdentityProvider service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/GetIdentityProvider">REST API Reference for GetIdentityProvider Operation</seealso>
        GetIdentityProviderResponse GetIdentityProvider(GetIdentityProviderRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetIdentityProvider operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetIdentityProvider operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetIdentityProvider
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/GetIdentityProvider">REST API Reference for GetIdentityProvider Operation</seealso>
        IAsyncResult BeginGetIdentityProvider(GetIdentityProviderRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetIdentityProvider operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetIdentityProvider.</param>
        /// 
        /// <returns>Returns a  GetIdentityProviderResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/GetIdentityProvider">REST API Reference for GetIdentityProvider Operation</seealso>
        GetIdentityProviderResponse EndGetIdentityProvider(IAsyncResult asyncResult);

        #endregion
        
        #region  GetIpAccessSettings


        /// <summary>
        /// Gets the IP access settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIpAccessSettings service method.</param>
        /// 
        /// <returns>The response from the GetIpAccessSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/GetIpAccessSettings">REST API Reference for GetIpAccessSettings Operation</seealso>
        GetIpAccessSettingsResponse GetIpAccessSettings(GetIpAccessSettingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetIpAccessSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetIpAccessSettings operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetIpAccessSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/GetIpAccessSettings">REST API Reference for GetIpAccessSettings Operation</seealso>
        IAsyncResult BeginGetIpAccessSettings(GetIpAccessSettingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetIpAccessSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetIpAccessSettings.</param>
        /// 
        /// <returns>Returns a  GetIpAccessSettingsResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/GetIpAccessSettings">REST API Reference for GetIpAccessSettings Operation</seealso>
        GetIpAccessSettingsResponse EndGetIpAccessSettings(IAsyncResult asyncResult);

        #endregion
        
        #region  GetNetworkSettings


        /// <summary>
        /// Gets the network settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetNetworkSettings service method.</param>
        /// 
        /// <returns>The response from the GetNetworkSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/GetNetworkSettings">REST API Reference for GetNetworkSettings Operation</seealso>
        GetNetworkSettingsResponse GetNetworkSettings(GetNetworkSettingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetNetworkSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetNetworkSettings operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetNetworkSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/GetNetworkSettings">REST API Reference for GetNetworkSettings Operation</seealso>
        IAsyncResult BeginGetNetworkSettings(GetNetworkSettingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetNetworkSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetNetworkSettings.</param>
        /// 
        /// <returns>Returns a  GetNetworkSettingsResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/GetNetworkSettings">REST API Reference for GetNetworkSettings Operation</seealso>
        GetNetworkSettingsResponse EndGetNetworkSettings(IAsyncResult asyncResult);

        #endregion
        
        #region  GetPortal


        /// <summary>
        /// Gets the web portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPortal service method.</param>
        /// 
        /// <returns>The response from the GetPortal service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/GetPortal">REST API Reference for GetPortal Operation</seealso>
        GetPortalResponse GetPortal(GetPortalRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetPortal operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPortal operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPortal
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/GetPortal">REST API Reference for GetPortal Operation</seealso>
        IAsyncResult BeginGetPortal(GetPortalRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetPortal operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPortal.</param>
        /// 
        /// <returns>Returns a  GetPortalResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/GetPortal">REST API Reference for GetPortal Operation</seealso>
        GetPortalResponse EndGetPortal(IAsyncResult asyncResult);

        #endregion
        
        #region  GetPortalServiceProviderMetadata


        /// <summary>
        /// Gets the service provider metadata.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPortalServiceProviderMetadata service method.</param>
        /// 
        /// <returns>The response from the GetPortalServiceProviderMetadata service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/GetPortalServiceProviderMetadata">REST API Reference for GetPortalServiceProviderMetadata Operation</seealso>
        GetPortalServiceProviderMetadataResponse GetPortalServiceProviderMetadata(GetPortalServiceProviderMetadataRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetPortalServiceProviderMetadata operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPortalServiceProviderMetadata operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPortalServiceProviderMetadata
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/GetPortalServiceProviderMetadata">REST API Reference for GetPortalServiceProviderMetadata Operation</seealso>
        IAsyncResult BeginGetPortalServiceProviderMetadata(GetPortalServiceProviderMetadataRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetPortalServiceProviderMetadata operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPortalServiceProviderMetadata.</param>
        /// 
        /// <returns>Returns a  GetPortalServiceProviderMetadataResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/GetPortalServiceProviderMetadata">REST API Reference for GetPortalServiceProviderMetadata Operation</seealso>
        GetPortalServiceProviderMetadataResponse EndGetPortalServiceProviderMetadata(IAsyncResult asyncResult);

        #endregion
        
        #region  GetSession


        /// <summary>
        /// Gets information for a secure browser session.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSession service method.</param>
        /// 
        /// <returns>The response from the GetSession service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/GetSession">REST API Reference for GetSession Operation</seealso>
        GetSessionResponse GetSession(GetSessionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetSession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSession operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/GetSession">REST API Reference for GetSession Operation</seealso>
        IAsyncResult BeginGetSession(GetSessionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSession.</param>
        /// 
        /// <returns>Returns a  GetSessionResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/GetSession">REST API Reference for GetSession Operation</seealso>
        GetSessionResponse EndGetSession(IAsyncResult asyncResult);

        #endregion
        
        #region  GetSessionLogger


        /// <summary>
        /// Gets details about a specific session logger resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSessionLogger service method.</param>
        /// 
        /// <returns>The response from the GetSessionLogger service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/GetSessionLogger">REST API Reference for GetSessionLogger Operation</seealso>
        GetSessionLoggerResponse GetSessionLogger(GetSessionLoggerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetSessionLogger operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSessionLogger operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSessionLogger
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/GetSessionLogger">REST API Reference for GetSessionLogger Operation</seealso>
        IAsyncResult BeginGetSessionLogger(GetSessionLoggerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSessionLogger operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSessionLogger.</param>
        /// 
        /// <returns>Returns a  GetSessionLoggerResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/GetSessionLogger">REST API Reference for GetSessionLogger Operation</seealso>
        GetSessionLoggerResponse EndGetSessionLogger(IAsyncResult asyncResult);

        #endregion
        
        #region  GetTrustStore


        /// <summary>
        /// Gets the trust store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTrustStore service method.</param>
        /// 
        /// <returns>The response from the GetTrustStore service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/GetTrustStore">REST API Reference for GetTrustStore Operation</seealso>
        GetTrustStoreResponse GetTrustStore(GetTrustStoreRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetTrustStore operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTrustStore operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTrustStore
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/GetTrustStore">REST API Reference for GetTrustStore Operation</seealso>
        IAsyncResult BeginGetTrustStore(GetTrustStoreRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetTrustStore operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTrustStore.</param>
        /// 
        /// <returns>Returns a  GetTrustStoreResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/GetTrustStore">REST API Reference for GetTrustStore Operation</seealso>
        GetTrustStoreResponse EndGetTrustStore(IAsyncResult asyncResult);

        #endregion
        
        #region  GetTrustStoreCertificate


        /// <summary>
        /// Gets the trust store certificate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTrustStoreCertificate service method.</param>
        /// 
        /// <returns>The response from the GetTrustStoreCertificate service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/GetTrustStoreCertificate">REST API Reference for GetTrustStoreCertificate Operation</seealso>
        GetTrustStoreCertificateResponse GetTrustStoreCertificate(GetTrustStoreCertificateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetTrustStoreCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTrustStoreCertificate operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTrustStoreCertificate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/GetTrustStoreCertificate">REST API Reference for GetTrustStoreCertificate Operation</seealso>
        IAsyncResult BeginGetTrustStoreCertificate(GetTrustStoreCertificateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetTrustStoreCertificate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTrustStoreCertificate.</param>
        /// 
        /// <returns>Returns a  GetTrustStoreCertificateResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/GetTrustStoreCertificate">REST API Reference for GetTrustStoreCertificate Operation</seealso>
        GetTrustStoreCertificateResponse EndGetTrustStoreCertificate(IAsyncResult asyncResult);

        #endregion
        
        #region  GetUserAccessLoggingSettings


        /// <summary>
        /// Gets user access logging settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUserAccessLoggingSettings service method.</param>
        /// 
        /// <returns>The response from the GetUserAccessLoggingSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/GetUserAccessLoggingSettings">REST API Reference for GetUserAccessLoggingSettings Operation</seealso>
        GetUserAccessLoggingSettingsResponse GetUserAccessLoggingSettings(GetUserAccessLoggingSettingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetUserAccessLoggingSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUserAccessLoggingSettings operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetUserAccessLoggingSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/GetUserAccessLoggingSettings">REST API Reference for GetUserAccessLoggingSettings Operation</seealso>
        IAsyncResult BeginGetUserAccessLoggingSettings(GetUserAccessLoggingSettingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetUserAccessLoggingSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetUserAccessLoggingSettings.</param>
        /// 
        /// <returns>Returns a  GetUserAccessLoggingSettingsResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/GetUserAccessLoggingSettings">REST API Reference for GetUserAccessLoggingSettings Operation</seealso>
        GetUserAccessLoggingSettingsResponse EndGetUserAccessLoggingSettings(IAsyncResult asyncResult);

        #endregion
        
        #region  GetUserSettings


        /// <summary>
        /// Gets user settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUserSettings service method.</param>
        /// 
        /// <returns>The response from the GetUserSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/GetUserSettings">REST API Reference for GetUserSettings Operation</seealso>
        GetUserSettingsResponse GetUserSettings(GetUserSettingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetUserSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUserSettings operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetUserSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/GetUserSettings">REST API Reference for GetUserSettings Operation</seealso>
        IAsyncResult BeginGetUserSettings(GetUserSettingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetUserSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetUserSettings.</param>
        /// 
        /// <returns>Returns a  GetUserSettingsResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/GetUserSettings">REST API Reference for GetUserSettings Operation</seealso>
        GetUserSettingsResponse EndGetUserSettings(IAsyncResult asyncResult);

        #endregion
        
        #region  ListBrowserSettings


        /// <summary>
        /// Retrieves a list of browser settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBrowserSettings service method.</param>
        /// 
        /// <returns>The response from the ListBrowserSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ListBrowserSettings">REST API Reference for ListBrowserSettings Operation</seealso>
        ListBrowserSettingsResponse ListBrowserSettings(ListBrowserSettingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListBrowserSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBrowserSettings operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListBrowserSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ListBrowserSettings">REST API Reference for ListBrowserSettings Operation</seealso>
        IAsyncResult BeginListBrowserSettings(ListBrowserSettingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListBrowserSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListBrowserSettings.</param>
        /// 
        /// <returns>Returns a  ListBrowserSettingsResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ListBrowserSettings">REST API Reference for ListBrowserSettings Operation</seealso>
        ListBrowserSettingsResponse EndListBrowserSettings(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDataProtectionSettings


        /// <summary>
        /// Retrieves a list of data protection settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataProtectionSettings service method.</param>
        /// 
        /// <returns>The response from the ListDataProtectionSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ListDataProtectionSettings">REST API Reference for ListDataProtectionSettings Operation</seealso>
        ListDataProtectionSettingsResponse ListDataProtectionSettings(ListDataProtectionSettingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDataProtectionSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDataProtectionSettings operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDataProtectionSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ListDataProtectionSettings">REST API Reference for ListDataProtectionSettings Operation</seealso>
        IAsyncResult BeginListDataProtectionSettings(ListDataProtectionSettingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDataProtectionSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDataProtectionSettings.</param>
        /// 
        /// <returns>Returns a  ListDataProtectionSettingsResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ListDataProtectionSettings">REST API Reference for ListDataProtectionSettings Operation</seealso>
        ListDataProtectionSettingsResponse EndListDataProtectionSettings(IAsyncResult asyncResult);

        #endregion
        
        #region  ListIdentityProviders


        /// <summary>
        /// Retrieves a list of identity providers for a specific web portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIdentityProviders service method.</param>
        /// 
        /// <returns>The response from the ListIdentityProviders service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ListIdentityProviders">REST API Reference for ListIdentityProviders Operation</seealso>
        ListIdentityProvidersResponse ListIdentityProviders(ListIdentityProvidersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListIdentityProviders operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListIdentityProviders operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListIdentityProviders
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ListIdentityProviders">REST API Reference for ListIdentityProviders Operation</seealso>
        IAsyncResult BeginListIdentityProviders(ListIdentityProvidersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListIdentityProviders operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListIdentityProviders.</param>
        /// 
        /// <returns>Returns a  ListIdentityProvidersResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ListIdentityProviders">REST API Reference for ListIdentityProviders Operation</seealso>
        ListIdentityProvidersResponse EndListIdentityProviders(IAsyncResult asyncResult);

        #endregion
        
        #region  ListIpAccessSettings


        /// <summary>
        /// Retrieves a list of IP access settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIpAccessSettings service method.</param>
        /// 
        /// <returns>The response from the ListIpAccessSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ListIpAccessSettings">REST API Reference for ListIpAccessSettings Operation</seealso>
        ListIpAccessSettingsResponse ListIpAccessSettings(ListIpAccessSettingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListIpAccessSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListIpAccessSettings operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListIpAccessSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ListIpAccessSettings">REST API Reference for ListIpAccessSettings Operation</seealso>
        IAsyncResult BeginListIpAccessSettings(ListIpAccessSettingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListIpAccessSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListIpAccessSettings.</param>
        /// 
        /// <returns>Returns a  ListIpAccessSettingsResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ListIpAccessSettings">REST API Reference for ListIpAccessSettings Operation</seealso>
        ListIpAccessSettingsResponse EndListIpAccessSettings(IAsyncResult asyncResult);

        #endregion
        
        #region  ListNetworkSettings


        /// <summary>
        /// Retrieves a list of network settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNetworkSettings service method.</param>
        /// 
        /// <returns>The response from the ListNetworkSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ListNetworkSettings">REST API Reference for ListNetworkSettings Operation</seealso>
        ListNetworkSettingsResponse ListNetworkSettings(ListNetworkSettingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListNetworkSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListNetworkSettings operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListNetworkSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ListNetworkSettings">REST API Reference for ListNetworkSettings Operation</seealso>
        IAsyncResult BeginListNetworkSettings(ListNetworkSettingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListNetworkSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListNetworkSettings.</param>
        /// 
        /// <returns>Returns a  ListNetworkSettingsResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ListNetworkSettings">REST API Reference for ListNetworkSettings Operation</seealso>
        ListNetworkSettingsResponse EndListNetworkSettings(IAsyncResult asyncResult);

        #endregion
        
        #region  ListPortals


        /// <summary>
        /// Retrieves a list or web portals.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPortals service method.</param>
        /// 
        /// <returns>The response from the ListPortals service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ListPortals">REST API Reference for ListPortals Operation</seealso>
        ListPortalsResponse ListPortals(ListPortalsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListPortals operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPortals operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPortals
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ListPortals">REST API Reference for ListPortals Operation</seealso>
        IAsyncResult BeginListPortals(ListPortalsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListPortals operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPortals.</param>
        /// 
        /// <returns>Returns a  ListPortalsResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ListPortals">REST API Reference for ListPortals Operation</seealso>
        ListPortalsResponse EndListPortals(IAsyncResult asyncResult);

        #endregion
        
        #region  ListSessionLoggers


        /// <summary>
        /// Lists all available session logger resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSessionLoggers service method.</param>
        /// 
        /// <returns>The response from the ListSessionLoggers service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ListSessionLoggers">REST API Reference for ListSessionLoggers Operation</seealso>
        ListSessionLoggersResponse ListSessionLoggers(ListSessionLoggersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListSessionLoggers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSessionLoggers operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSessionLoggers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ListSessionLoggers">REST API Reference for ListSessionLoggers Operation</seealso>
        IAsyncResult BeginListSessionLoggers(ListSessionLoggersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListSessionLoggers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSessionLoggers.</param>
        /// 
        /// <returns>Returns a  ListSessionLoggersResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ListSessionLoggers">REST API Reference for ListSessionLoggers Operation</seealso>
        ListSessionLoggersResponse EndListSessionLoggers(IAsyncResult asyncResult);

        #endregion
        
        #region  ListSessions


        /// <summary>
        /// Lists information for multiple secure browser sessions from a specific portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSessions service method.</param>
        /// 
        /// <returns>The response from the ListSessions service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ListSessions">REST API Reference for ListSessions Operation</seealso>
        ListSessionsResponse ListSessions(ListSessionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListSessions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSessions operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSessions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ListSessions">REST API Reference for ListSessions Operation</seealso>
        IAsyncResult BeginListSessions(ListSessionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListSessions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSessions.</param>
        /// 
        /// <returns>Returns a  ListSessionsResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ListSessions">REST API Reference for ListSessions Operation</seealso>
        ListSessionsResponse EndListSessions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Retrieves a list of tags for a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTrustStoreCertificates


        /// <summary>
        /// Retrieves a list of trust store certificates.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTrustStoreCertificates service method.</param>
        /// 
        /// <returns>The response from the ListTrustStoreCertificates service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ListTrustStoreCertificates">REST API Reference for ListTrustStoreCertificates Operation</seealso>
        ListTrustStoreCertificatesResponse ListTrustStoreCertificates(ListTrustStoreCertificatesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTrustStoreCertificates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTrustStoreCertificates operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTrustStoreCertificates
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ListTrustStoreCertificates">REST API Reference for ListTrustStoreCertificates Operation</seealso>
        IAsyncResult BeginListTrustStoreCertificates(ListTrustStoreCertificatesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTrustStoreCertificates operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTrustStoreCertificates.</param>
        /// 
        /// <returns>Returns a  ListTrustStoreCertificatesResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ListTrustStoreCertificates">REST API Reference for ListTrustStoreCertificates Operation</seealso>
        ListTrustStoreCertificatesResponse EndListTrustStoreCertificates(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTrustStores


        /// <summary>
        /// Retrieves a list of trust stores.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTrustStores service method.</param>
        /// 
        /// <returns>The response from the ListTrustStores service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ListTrustStores">REST API Reference for ListTrustStores Operation</seealso>
        ListTrustStoresResponse ListTrustStores(ListTrustStoresRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTrustStores operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTrustStores operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTrustStores
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ListTrustStores">REST API Reference for ListTrustStores Operation</seealso>
        IAsyncResult BeginListTrustStores(ListTrustStoresRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTrustStores operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTrustStores.</param>
        /// 
        /// <returns>Returns a  ListTrustStoresResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ListTrustStores">REST API Reference for ListTrustStores Operation</seealso>
        ListTrustStoresResponse EndListTrustStores(IAsyncResult asyncResult);

        #endregion
        
        #region  ListUserAccessLoggingSettings


        /// <summary>
        /// Retrieves a list of user access logging settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUserAccessLoggingSettings service method.</param>
        /// 
        /// <returns>The response from the ListUserAccessLoggingSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ListUserAccessLoggingSettings">REST API Reference for ListUserAccessLoggingSettings Operation</seealso>
        ListUserAccessLoggingSettingsResponse ListUserAccessLoggingSettings(ListUserAccessLoggingSettingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListUserAccessLoggingSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListUserAccessLoggingSettings operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListUserAccessLoggingSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ListUserAccessLoggingSettings">REST API Reference for ListUserAccessLoggingSettings Operation</seealso>
        IAsyncResult BeginListUserAccessLoggingSettings(ListUserAccessLoggingSettingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListUserAccessLoggingSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListUserAccessLoggingSettings.</param>
        /// 
        /// <returns>Returns a  ListUserAccessLoggingSettingsResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ListUserAccessLoggingSettings">REST API Reference for ListUserAccessLoggingSettings Operation</seealso>
        ListUserAccessLoggingSettingsResponse EndListUserAccessLoggingSettings(IAsyncResult asyncResult);

        #endregion
        
        #region  ListUserSettings


        /// <summary>
        /// Retrieves a list of user settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUserSettings service method.</param>
        /// 
        /// <returns>The response from the ListUserSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ListUserSettings">REST API Reference for ListUserSettings Operation</seealso>
        ListUserSettingsResponse ListUserSettings(ListUserSettingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListUserSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListUserSettings operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListUserSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ListUserSettings">REST API Reference for ListUserSettings Operation</seealso>
        IAsyncResult BeginListUserSettings(ListUserSettingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListUserSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListUserSettings.</param>
        /// 
        /// <returns>Returns a  ListUserSettingsResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ListUserSettings">REST API Reference for ListUserSettings Operation</seealso>
        ListUserSettingsResponse EndListUserSettings(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds or overwrites one or more tags for the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.TooManyTagsException">
        /// There are too many tags.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes one or more tags from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateBrowserSettings


        /// <summary>
        /// Updates browser settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBrowserSettings service method.</param>
        /// 
        /// <returns>The response from the UpdateBrowserSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/UpdateBrowserSettings">REST API Reference for UpdateBrowserSettings Operation</seealso>
        UpdateBrowserSettingsResponse UpdateBrowserSettings(UpdateBrowserSettingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateBrowserSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateBrowserSettings operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateBrowserSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/UpdateBrowserSettings">REST API Reference for UpdateBrowserSettings Operation</seealso>
        IAsyncResult BeginUpdateBrowserSettings(UpdateBrowserSettingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateBrowserSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateBrowserSettings.</param>
        /// 
        /// <returns>Returns a  UpdateBrowserSettingsResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/UpdateBrowserSettings">REST API Reference for UpdateBrowserSettings Operation</seealso>
        UpdateBrowserSettingsResponse EndUpdateBrowserSettings(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateDataProtectionSettings


        /// <summary>
        /// Updates data protection settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataProtectionSettings service method.</param>
        /// 
        /// <returns>The response from the UpdateDataProtectionSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/UpdateDataProtectionSettings">REST API Reference for UpdateDataProtectionSettings Operation</seealso>
        UpdateDataProtectionSettingsResponse UpdateDataProtectionSettings(UpdateDataProtectionSettingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDataProtectionSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataProtectionSettings operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDataProtectionSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/UpdateDataProtectionSettings">REST API Reference for UpdateDataProtectionSettings Operation</seealso>
        IAsyncResult BeginUpdateDataProtectionSettings(UpdateDataProtectionSettingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDataProtectionSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDataProtectionSettings.</param>
        /// 
        /// <returns>Returns a  UpdateDataProtectionSettingsResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/UpdateDataProtectionSettings">REST API Reference for UpdateDataProtectionSettings Operation</seealso>
        UpdateDataProtectionSettingsResponse EndUpdateDataProtectionSettings(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateIdentityProvider


        /// <summary>
        /// Updates the identity provider.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIdentityProvider service method.</param>
        /// 
        /// <returns>The response from the UpdateIdentityProvider service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/UpdateIdentityProvider">REST API Reference for UpdateIdentityProvider Operation</seealso>
        UpdateIdentityProviderResponse UpdateIdentityProvider(UpdateIdentityProviderRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateIdentityProvider operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateIdentityProvider operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateIdentityProvider
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/UpdateIdentityProvider">REST API Reference for UpdateIdentityProvider Operation</seealso>
        IAsyncResult BeginUpdateIdentityProvider(UpdateIdentityProviderRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateIdentityProvider operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateIdentityProvider.</param>
        /// 
        /// <returns>Returns a  UpdateIdentityProviderResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/UpdateIdentityProvider">REST API Reference for UpdateIdentityProvider Operation</seealso>
        UpdateIdentityProviderResponse EndUpdateIdentityProvider(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateIpAccessSettings


        /// <summary>
        /// Updates IP access settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIpAccessSettings service method.</param>
        /// 
        /// <returns>The response from the UpdateIpAccessSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/UpdateIpAccessSettings">REST API Reference for UpdateIpAccessSettings Operation</seealso>
        UpdateIpAccessSettingsResponse UpdateIpAccessSettings(UpdateIpAccessSettingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateIpAccessSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateIpAccessSettings operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateIpAccessSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/UpdateIpAccessSettings">REST API Reference for UpdateIpAccessSettings Operation</seealso>
        IAsyncResult BeginUpdateIpAccessSettings(UpdateIpAccessSettingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateIpAccessSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateIpAccessSettings.</param>
        /// 
        /// <returns>Returns a  UpdateIpAccessSettingsResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/UpdateIpAccessSettings">REST API Reference for UpdateIpAccessSettings Operation</seealso>
        UpdateIpAccessSettingsResponse EndUpdateIpAccessSettings(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateNetworkSettings


        /// <summary>
        /// Updates network settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateNetworkSettings service method.</param>
        /// 
        /// <returns>The response from the UpdateNetworkSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/UpdateNetworkSettings">REST API Reference for UpdateNetworkSettings Operation</seealso>
        UpdateNetworkSettingsResponse UpdateNetworkSettings(UpdateNetworkSettingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateNetworkSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateNetworkSettings operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateNetworkSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/UpdateNetworkSettings">REST API Reference for UpdateNetworkSettings Operation</seealso>
        IAsyncResult BeginUpdateNetworkSettings(UpdateNetworkSettingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateNetworkSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateNetworkSettings.</param>
        /// 
        /// <returns>Returns a  UpdateNetworkSettingsResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/UpdateNetworkSettings">REST API Reference for UpdateNetworkSettings Operation</seealso>
        UpdateNetworkSettingsResponse EndUpdateNetworkSettings(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdatePortal


        /// <summary>
        /// Updates a web portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePortal service method.</param>
        /// 
        /// <returns>The response from the UpdatePortal service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/UpdatePortal">REST API Reference for UpdatePortal Operation</seealso>
        UpdatePortalResponse UpdatePortal(UpdatePortalRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePortal operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePortal operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdatePortal
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/UpdatePortal">REST API Reference for UpdatePortal Operation</seealso>
        IAsyncResult BeginUpdatePortal(UpdatePortalRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdatePortal operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdatePortal.</param>
        /// 
        /// <returns>Returns a  UpdatePortalResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/UpdatePortal">REST API Reference for UpdatePortal Operation</seealso>
        UpdatePortalResponse EndUpdatePortal(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateSessionLogger


        /// <summary>
        /// Updates the details of a session logger.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSessionLogger service method.</param>
        /// 
        /// <returns>The response from the UpdateSessionLogger service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/UpdateSessionLogger">REST API Reference for UpdateSessionLogger Operation</seealso>
        UpdateSessionLoggerResponse UpdateSessionLogger(UpdateSessionLoggerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSessionLogger operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSessionLogger operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSessionLogger
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/UpdateSessionLogger">REST API Reference for UpdateSessionLogger Operation</seealso>
        IAsyncResult BeginUpdateSessionLogger(UpdateSessionLoggerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSessionLogger operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSessionLogger.</param>
        /// 
        /// <returns>Returns a  UpdateSessionLoggerResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/UpdateSessionLogger">REST API Reference for UpdateSessionLogger Operation</seealso>
        UpdateSessionLoggerResponse EndUpdateSessionLogger(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateTrustStore


        /// <summary>
        /// Updates the trust store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTrustStore service method.</param>
        /// 
        /// <returns>The response from the UpdateTrustStore service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/UpdateTrustStore">REST API Reference for UpdateTrustStore Operation</seealso>
        UpdateTrustStoreResponse UpdateTrustStore(UpdateTrustStoreRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTrustStore operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTrustStore operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateTrustStore
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/UpdateTrustStore">REST API Reference for UpdateTrustStore Operation</seealso>
        IAsyncResult BeginUpdateTrustStore(UpdateTrustStoreRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateTrustStore operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateTrustStore.</param>
        /// 
        /// <returns>Returns a  UpdateTrustStoreResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/UpdateTrustStore">REST API Reference for UpdateTrustStore Operation</seealso>
        UpdateTrustStoreResponse EndUpdateTrustStore(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateUserAccessLoggingSettings


        /// <summary>
        /// Updates the user access logging settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserAccessLoggingSettings service method.</param>
        /// 
        /// <returns>The response from the UpdateUserAccessLoggingSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/UpdateUserAccessLoggingSettings">REST API Reference for UpdateUserAccessLoggingSettings Operation</seealso>
        UpdateUserAccessLoggingSettingsResponse UpdateUserAccessLoggingSettings(UpdateUserAccessLoggingSettingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateUserAccessLoggingSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserAccessLoggingSettings operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateUserAccessLoggingSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/UpdateUserAccessLoggingSettings">REST API Reference for UpdateUserAccessLoggingSettings Operation</seealso>
        IAsyncResult BeginUpdateUserAccessLoggingSettings(UpdateUserAccessLoggingSettingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateUserAccessLoggingSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateUserAccessLoggingSettings.</param>
        /// 
        /// <returns>Returns a  UpdateUserAccessLoggingSettingsResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/UpdateUserAccessLoggingSettings">REST API Reference for UpdateUserAccessLoggingSettings Operation</seealso>
        UpdateUserAccessLoggingSettingsResponse EndUpdateUserAccessLoggingSettings(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateUserSettings


        /// <summary>
        /// Updates the user settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserSettings service method.</param>
        /// 
        /// <returns>The response from the UpdateUserSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/UpdateUserSettings">REST API Reference for UpdateUserSettings Operation</seealso>
        UpdateUserSettingsResponse UpdateUserSettings(UpdateUserSettingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateUserSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserSettings operation on AmazonWorkSpacesWebClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateUserSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/UpdateUserSettings">REST API Reference for UpdateUserSettings Operation</seealso>
        IAsyncResult BeginUpdateUserSettings(UpdateUserSettingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateUserSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateUserSettings.</param>
        /// 
        /// <returns>Returns a  UpdateUserSettingsResult from WorkSpacesWeb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/UpdateUserSettings">REST API Reference for UpdateUserSettings Operation</seealso>
        UpdateUserSettingsResponse EndUpdateUserSettings(IAsyncResult asyncResult);

        #endregion
                
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);
        
        #endregion

    }
}