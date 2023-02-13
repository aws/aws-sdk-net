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
 * Do not modify this file. This file is generated from the account-2021-02-01.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Account.Model;

namespace Amazon.Account
{
    /// <summary>
    /// Interface for accessing Account
    ///
    /// Operations for Amazon Web Services Account Management
    /// </summary>
    public partial interface IAmazonAccount : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IAccountPaginatorFactory Paginators { get; }
#endif


        
        #region  DeleteAlternateContact


        /// <summary>
        /// Deletes the specified alternate contact from an Amazon Web Services account.
        /// 
        ///  
        /// <para>
        /// For complete details about how to use the alternate contact operations, see <a href="https://docs.aws.amazon.com/accounts/latest/reference/manage-acct-update-contact.html">Access
        /// or updating the alternate contacts</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Before you can update the alternate contact information for an Amazon Web Services
        /// account that is managed by Organizations, you must first enable integration between
        /// Amazon Web Services Account Management and Organizations. For more information, see
        /// <a href="https://docs.aws.amazon.com/accounts/latest/reference/using-orgs-trusted-access.html">Enabling
        /// trusted access for Amazon Web Services Account Management</a>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAlternateContact service method.</param>
        /// 
        /// <returns>The response from the DeleteAlternateContact service method, as returned by Account.</returns>
        /// <exception cref="Amazon.Account.Model.AccessDeniedException">
        /// The operation failed because the calling identity doesn't have the minimum required
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.InternalServerException">
        /// The operation failed because of an error internal to Amazon Web Services. Try your
        /// operation again later.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.ResourceNotFoundException">
        /// The operation failed because it specified a resource that can't be found.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.TooManyRequestsException">
        /// The operation failed because it was called too frequently and exceeded a throttle
        /// limit.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.ValidationException">
        /// The operation failed because one of the input parameters was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/account-2021-02-01/DeleteAlternateContact">REST API Reference for DeleteAlternateContact Operation</seealso>
        DeleteAlternateContactResponse DeleteAlternateContact(DeleteAlternateContactRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAlternateContact operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAlternateContact operation on AmazonAccountClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAlternateContact
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/account-2021-02-01/DeleteAlternateContact">REST API Reference for DeleteAlternateContact Operation</seealso>
        IAsyncResult BeginDeleteAlternateContact(DeleteAlternateContactRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAlternateContact operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAlternateContact.</param>
        /// 
        /// <returns>Returns a  DeleteAlternateContactResult from Account.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/account-2021-02-01/DeleteAlternateContact">REST API Reference for DeleteAlternateContact Operation</seealso>
        DeleteAlternateContactResponse EndDeleteAlternateContact(IAsyncResult asyncResult);

        #endregion
        
        #region  DisableRegion


        /// <summary>
        /// Disables (opts-out) a particular Region for an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableRegion service method.</param>
        /// 
        /// <returns>The response from the DisableRegion service method, as returned by Account.</returns>
        /// <exception cref="Amazon.Account.Model.AccessDeniedException">
        /// The operation failed because the calling identity doesn't have the minimum required
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.ConflictException">
        /// The request could not be processed because of a conflict in the current status of
        /// the resource. For example, this happens if you try to enable a Region that is currently
        /// being disabled (in a status of DISABLING).
        /// </exception>
        /// <exception cref="Amazon.Account.Model.InternalServerException">
        /// The operation failed because of an error internal to Amazon Web Services. Try your
        /// operation again later.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.TooManyRequestsException">
        /// The operation failed because it was called too frequently and exceeded a throttle
        /// limit.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.ValidationException">
        /// The operation failed because one of the input parameters was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/account-2021-02-01/DisableRegion">REST API Reference for DisableRegion Operation</seealso>
        DisableRegionResponse DisableRegion(DisableRegionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisableRegion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableRegion operation on AmazonAccountClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisableRegion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/account-2021-02-01/DisableRegion">REST API Reference for DisableRegion Operation</seealso>
        IAsyncResult BeginDisableRegion(DisableRegionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisableRegion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisableRegion.</param>
        /// 
        /// <returns>Returns a  DisableRegionResult from Account.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/account-2021-02-01/DisableRegion">REST API Reference for DisableRegion Operation</seealso>
        DisableRegionResponse EndDisableRegion(IAsyncResult asyncResult);

        #endregion
        
        #region  EnableRegion


        /// <summary>
        /// Enables (opts-in) a particular Region for an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableRegion service method.</param>
        /// 
        /// <returns>The response from the EnableRegion service method, as returned by Account.</returns>
        /// <exception cref="Amazon.Account.Model.AccessDeniedException">
        /// The operation failed because the calling identity doesn't have the minimum required
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.ConflictException">
        /// The request could not be processed because of a conflict in the current status of
        /// the resource. For example, this happens if you try to enable a Region that is currently
        /// being disabled (in a status of DISABLING).
        /// </exception>
        /// <exception cref="Amazon.Account.Model.InternalServerException">
        /// The operation failed because of an error internal to Amazon Web Services. Try your
        /// operation again later.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.TooManyRequestsException">
        /// The operation failed because it was called too frequently and exceeded a throttle
        /// limit.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.ValidationException">
        /// The operation failed because one of the input parameters was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/account-2021-02-01/EnableRegion">REST API Reference for EnableRegion Operation</seealso>
        EnableRegionResponse EnableRegion(EnableRegionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the EnableRegion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableRegion operation on AmazonAccountClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEnableRegion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/account-2021-02-01/EnableRegion">REST API Reference for EnableRegion Operation</seealso>
        IAsyncResult BeginEnableRegion(EnableRegionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  EnableRegion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEnableRegion.</param>
        /// 
        /// <returns>Returns a  EnableRegionResult from Account.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/account-2021-02-01/EnableRegion">REST API Reference for EnableRegion Operation</seealso>
        EnableRegionResponse EndEnableRegion(IAsyncResult asyncResult);

        #endregion
        
        #region  GetAlternateContact


        /// <summary>
        /// Retrieves the specified alternate contact attached to an Amazon Web Services account.
        /// 
        ///  
        /// <para>
        /// For complete details about how to use the alternate contact operations, see <a href="https://docs.aws.amazon.com/accounts/latest/reference/manage-acct-update-contact.html">Access
        /// or updating the alternate contacts</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Before you can update the alternate contact information for an Amazon Web Services
        /// account that is managed by Organizations, you must first enable integration between
        /// Amazon Web Services Account Management and Organizations. For more information, see
        /// <a href="https://docs.aws.amazon.com/accounts/latest/reference/using-orgs-trusted-access.html">Enabling
        /// trusted access for Amazon Web Services Account Management</a>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAlternateContact service method.</param>
        /// 
        /// <returns>The response from the GetAlternateContact service method, as returned by Account.</returns>
        /// <exception cref="Amazon.Account.Model.AccessDeniedException">
        /// The operation failed because the calling identity doesn't have the minimum required
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.InternalServerException">
        /// The operation failed because of an error internal to Amazon Web Services. Try your
        /// operation again later.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.ResourceNotFoundException">
        /// The operation failed because it specified a resource that can't be found.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.TooManyRequestsException">
        /// The operation failed because it was called too frequently and exceeded a throttle
        /// limit.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.ValidationException">
        /// The operation failed because one of the input parameters was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/account-2021-02-01/GetAlternateContact">REST API Reference for GetAlternateContact Operation</seealso>
        GetAlternateContactResponse GetAlternateContact(GetAlternateContactRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetAlternateContact operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAlternateContact operation on AmazonAccountClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAlternateContact
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/account-2021-02-01/GetAlternateContact">REST API Reference for GetAlternateContact Operation</seealso>
        IAsyncResult BeginGetAlternateContact(GetAlternateContactRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAlternateContact operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAlternateContact.</param>
        /// 
        /// <returns>Returns a  GetAlternateContactResult from Account.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/account-2021-02-01/GetAlternateContact">REST API Reference for GetAlternateContact Operation</seealso>
        GetAlternateContactResponse EndGetAlternateContact(IAsyncResult asyncResult);

        #endregion
        
        #region  GetContactInformation


        /// <summary>
        /// Retrieves the primary contact information of an Amazon Web Services account.
        /// 
        ///  
        /// <para>
        /// For complete details about how to use the primary contact operations, see <a href="https://docs.aws.amazon.com/accounts/latest/reference/manage-acct-update-contact.html">Update
        /// the primary and alternate contact information</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetContactInformation service method.</param>
        /// 
        /// <returns>The response from the GetContactInformation service method, as returned by Account.</returns>
        /// <exception cref="Amazon.Account.Model.AccessDeniedException">
        /// The operation failed because the calling identity doesn't have the minimum required
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.InternalServerException">
        /// The operation failed because of an error internal to Amazon Web Services. Try your
        /// operation again later.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.ResourceNotFoundException">
        /// The operation failed because it specified a resource that can't be found.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.TooManyRequestsException">
        /// The operation failed because it was called too frequently and exceeded a throttle
        /// limit.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.ValidationException">
        /// The operation failed because one of the input parameters was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/account-2021-02-01/GetContactInformation">REST API Reference for GetContactInformation Operation</seealso>
        GetContactInformationResponse GetContactInformation(GetContactInformationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetContactInformation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetContactInformation operation on AmazonAccountClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetContactInformation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/account-2021-02-01/GetContactInformation">REST API Reference for GetContactInformation Operation</seealso>
        IAsyncResult BeginGetContactInformation(GetContactInformationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetContactInformation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetContactInformation.</param>
        /// 
        /// <returns>Returns a  GetContactInformationResult from Account.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/account-2021-02-01/GetContactInformation">REST API Reference for GetContactInformation Operation</seealso>
        GetContactInformationResponse EndGetContactInformation(IAsyncResult asyncResult);

        #endregion
        
        #region  GetRegionOptStatus


        /// <summary>
        /// Retrieves the opt-in status of a particular Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRegionOptStatus service method.</param>
        /// 
        /// <returns>The response from the GetRegionOptStatus service method, as returned by Account.</returns>
        /// <exception cref="Amazon.Account.Model.AccessDeniedException">
        /// The operation failed because the calling identity doesn't have the minimum required
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.InternalServerException">
        /// The operation failed because of an error internal to Amazon Web Services. Try your
        /// operation again later.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.TooManyRequestsException">
        /// The operation failed because it was called too frequently and exceeded a throttle
        /// limit.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.ValidationException">
        /// The operation failed because one of the input parameters was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/account-2021-02-01/GetRegionOptStatus">REST API Reference for GetRegionOptStatus Operation</seealso>
        GetRegionOptStatusResponse GetRegionOptStatus(GetRegionOptStatusRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetRegionOptStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRegionOptStatus operation on AmazonAccountClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRegionOptStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/account-2021-02-01/GetRegionOptStatus">REST API Reference for GetRegionOptStatus Operation</seealso>
        IAsyncResult BeginGetRegionOptStatus(GetRegionOptStatusRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetRegionOptStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRegionOptStatus.</param>
        /// 
        /// <returns>Returns a  GetRegionOptStatusResult from Account.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/account-2021-02-01/GetRegionOptStatus">REST API Reference for GetRegionOptStatus Operation</seealso>
        GetRegionOptStatusResponse EndGetRegionOptStatus(IAsyncResult asyncResult);

        #endregion
        
        #region  ListRegions


        /// <summary>
        /// Lists all the Regions for a given account and their respective opt-in statuses. Optionally,
        /// this list can be filtered by the <code>region-opt-status-contains</code> parameter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRegions service method.</param>
        /// 
        /// <returns>The response from the ListRegions service method, as returned by Account.</returns>
        /// <exception cref="Amazon.Account.Model.AccessDeniedException">
        /// The operation failed because the calling identity doesn't have the minimum required
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.InternalServerException">
        /// The operation failed because of an error internal to Amazon Web Services. Try your
        /// operation again later.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.TooManyRequestsException">
        /// The operation failed because it was called too frequently and exceeded a throttle
        /// limit.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.ValidationException">
        /// The operation failed because one of the input parameters was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/account-2021-02-01/ListRegions">REST API Reference for ListRegions Operation</seealso>
        ListRegionsResponse ListRegions(ListRegionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListRegions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRegions operation on AmazonAccountClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRegions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/account-2021-02-01/ListRegions">REST API Reference for ListRegions Operation</seealso>
        IAsyncResult BeginListRegions(ListRegionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListRegions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRegions.</param>
        /// 
        /// <returns>Returns a  ListRegionsResult from Account.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/account-2021-02-01/ListRegions">REST API Reference for ListRegions Operation</seealso>
        ListRegionsResponse EndListRegions(IAsyncResult asyncResult);

        #endregion
        
        #region  PutAlternateContact


        /// <summary>
        /// Modifies the specified alternate contact attached to an Amazon Web Services account.
        /// 
        ///  
        /// <para>
        /// For complete details about how to use the alternate contact operations, see <a href="https://docs.aws.amazon.com/accounts/latest/reference/manage-acct-update-contact.html">Access
        /// or updating the alternate contacts</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Before you can update the alternate contact information for an Amazon Web Services
        /// account that is managed by Organizations, you must first enable integration between
        /// Amazon Web Services Account Management and Organizations. For more information, see
        /// <a href="https://docs.aws.amazon.com/accounts/latest/reference/using-orgs-trusted-access.html">Enabling
        /// trusted access for Amazon Web Services Account Management</a>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAlternateContact service method.</param>
        /// 
        /// <returns>The response from the PutAlternateContact service method, as returned by Account.</returns>
        /// <exception cref="Amazon.Account.Model.AccessDeniedException">
        /// The operation failed because the calling identity doesn't have the minimum required
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.InternalServerException">
        /// The operation failed because of an error internal to Amazon Web Services. Try your
        /// operation again later.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.TooManyRequestsException">
        /// The operation failed because it was called too frequently and exceeded a throttle
        /// limit.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.ValidationException">
        /// The operation failed because one of the input parameters was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/account-2021-02-01/PutAlternateContact">REST API Reference for PutAlternateContact Operation</seealso>
        PutAlternateContactResponse PutAlternateContact(PutAlternateContactRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutAlternateContact operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutAlternateContact operation on AmazonAccountClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutAlternateContact
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/account-2021-02-01/PutAlternateContact">REST API Reference for PutAlternateContact Operation</seealso>
        IAsyncResult BeginPutAlternateContact(PutAlternateContactRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutAlternateContact operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutAlternateContact.</param>
        /// 
        /// <returns>Returns a  PutAlternateContactResult from Account.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/account-2021-02-01/PutAlternateContact">REST API Reference for PutAlternateContact Operation</seealso>
        PutAlternateContactResponse EndPutAlternateContact(IAsyncResult asyncResult);

        #endregion
        
        #region  PutContactInformation


        /// <summary>
        /// Updates the primary contact information of an Amazon Web Services account.
        /// 
        ///  
        /// <para>
        /// For complete details about how to use the primary contact operations, see <a href="https://docs.aws.amazon.com/accounts/latest/reference/manage-acct-update-contact.html">Update
        /// the primary and alternate contact information</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutContactInformation service method.</param>
        /// 
        /// <returns>The response from the PutContactInformation service method, as returned by Account.</returns>
        /// <exception cref="Amazon.Account.Model.AccessDeniedException">
        /// The operation failed because the calling identity doesn't have the minimum required
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.InternalServerException">
        /// The operation failed because of an error internal to Amazon Web Services. Try your
        /// operation again later.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.TooManyRequestsException">
        /// The operation failed because it was called too frequently and exceeded a throttle
        /// limit.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.ValidationException">
        /// The operation failed because one of the input parameters was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/account-2021-02-01/PutContactInformation">REST API Reference for PutContactInformation Operation</seealso>
        PutContactInformationResponse PutContactInformation(PutContactInformationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutContactInformation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutContactInformation operation on AmazonAccountClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutContactInformation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/account-2021-02-01/PutContactInformation">REST API Reference for PutContactInformation Operation</seealso>
        IAsyncResult BeginPutContactInformation(PutContactInformationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutContactInformation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutContactInformation.</param>
        /// 
        /// <returns>Returns a  PutContactInformationResult from Account.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/account-2021-02-01/PutContactInformation">REST API Reference for PutContactInformation Operation</seealso>
        PutContactInformationResponse EndPutContactInformation(IAsyncResult asyncResult);

        #endregion
        
    }
}