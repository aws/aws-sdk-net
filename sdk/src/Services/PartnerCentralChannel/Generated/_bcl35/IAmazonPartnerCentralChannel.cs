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
 * Do not modify this file. This file is generated from the partnercentral-channel-2024-03-18.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.PartnerCentralChannel.Model;

#pragma warning disable CS1570
namespace Amazon.PartnerCentralChannel
{
    /// <summary>
    /// <para>Interface for accessing PartnerCentralChannel</para>
    ///
    /// AWS Partner Central Channel service for managing partner relationships, handshakes,
    /// and program management accounts.
    /// </summary>
    public partial interface IAmazonPartnerCentralChannel : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IPartnerCentralChannelPaginatorFactory Paginators { get; }
#endif


        
        #region  AcceptChannelHandshake


        /// <summary>
        /// Accepts a pending channel handshake request from another AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptChannelHandshake service method.</param>
        /// 
        /// <returns>The response from the AcceptChannelHandshake service method, as returned by PartnerCentralChannel.</returns>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.InternalServerException">
        /// An internal server error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ValidationException">
        /// The request failed validation due to invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/AcceptChannelHandshake">REST API Reference for AcceptChannelHandshake Operation</seealso>
        AcceptChannelHandshakeResponse AcceptChannelHandshake(AcceptChannelHandshakeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AcceptChannelHandshake operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AcceptChannelHandshake operation on AmazonPartnerCentralChannelClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAcceptChannelHandshake
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/AcceptChannelHandshake">REST API Reference for AcceptChannelHandshake Operation</seealso>
        IAsyncResult BeginAcceptChannelHandshake(AcceptChannelHandshakeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AcceptChannelHandshake operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAcceptChannelHandshake.</param>
        /// 
        /// <returns>Returns a  AcceptChannelHandshakeResult from PartnerCentralChannel.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/AcceptChannelHandshake">REST API Reference for AcceptChannelHandshake Operation</seealso>
        AcceptChannelHandshakeResponse EndAcceptChannelHandshake(IAsyncResult asyncResult);

        #endregion
        
        #region  CancelChannelHandshake


        /// <summary>
        /// Cancels a pending channel handshake request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelChannelHandshake service method.</param>
        /// 
        /// <returns>The response from the CancelChannelHandshake service method, as returned by PartnerCentralChannel.</returns>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.InternalServerException">
        /// An internal server error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ValidationException">
        /// The request failed validation due to invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/CancelChannelHandshake">REST API Reference for CancelChannelHandshake Operation</seealso>
        CancelChannelHandshakeResponse CancelChannelHandshake(CancelChannelHandshakeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CancelChannelHandshake operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelChannelHandshake operation on AmazonPartnerCentralChannelClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelChannelHandshake
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/CancelChannelHandshake">REST API Reference for CancelChannelHandshake Operation</seealso>
        IAsyncResult BeginCancelChannelHandshake(CancelChannelHandshakeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CancelChannelHandshake operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelChannelHandshake.</param>
        /// 
        /// <returns>Returns a  CancelChannelHandshakeResult from PartnerCentralChannel.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/CancelChannelHandshake">REST API Reference for CancelChannelHandshake Operation</seealso>
        CancelChannelHandshakeResponse EndCancelChannelHandshake(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateChannelHandshake


        /// <summary>
        /// Creates a new channel handshake request to establish a partnership with another AWS
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateChannelHandshake service method.</param>
        /// 
        /// <returns>The response from the CreateChannelHandshake service method, as returned by PartnerCentralChannel.</returns>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.InternalServerException">
        /// An internal server error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota limit.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ValidationException">
        /// The request failed validation due to invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/CreateChannelHandshake">REST API Reference for CreateChannelHandshake Operation</seealso>
        CreateChannelHandshakeResponse CreateChannelHandshake(CreateChannelHandshakeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateChannelHandshake operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateChannelHandshake operation on AmazonPartnerCentralChannelClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateChannelHandshake
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/CreateChannelHandshake">REST API Reference for CreateChannelHandshake Operation</seealso>
        IAsyncResult BeginCreateChannelHandshake(CreateChannelHandshakeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateChannelHandshake operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateChannelHandshake.</param>
        /// 
        /// <returns>Returns a  CreateChannelHandshakeResult from PartnerCentralChannel.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/CreateChannelHandshake">REST API Reference for CreateChannelHandshake Operation</seealso>
        CreateChannelHandshakeResponse EndCreateChannelHandshake(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateProgramManagementAccount


        /// <summary>
        /// Creates a new program management account for managing partner relationships.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProgramManagementAccount service method.</param>
        /// 
        /// <returns>The response from the CreateProgramManagementAccount service method, as returned by PartnerCentralChannel.</returns>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.InternalServerException">
        /// An internal server error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota limit.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ValidationException">
        /// The request failed validation due to invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/CreateProgramManagementAccount">REST API Reference for CreateProgramManagementAccount Operation</seealso>
        CreateProgramManagementAccountResponse CreateProgramManagementAccount(CreateProgramManagementAccountRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateProgramManagementAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateProgramManagementAccount operation on AmazonPartnerCentralChannelClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateProgramManagementAccount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/CreateProgramManagementAccount">REST API Reference for CreateProgramManagementAccount Operation</seealso>
        IAsyncResult BeginCreateProgramManagementAccount(CreateProgramManagementAccountRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateProgramManagementAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateProgramManagementAccount.</param>
        /// 
        /// <returns>Returns a  CreateProgramManagementAccountResult from PartnerCentralChannel.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/CreateProgramManagementAccount">REST API Reference for CreateProgramManagementAccount Operation</seealso>
        CreateProgramManagementAccountResponse EndCreateProgramManagementAccount(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateRelationship


        /// <summary>
        /// Creates a new partner relationship between accounts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRelationship service method.</param>
        /// 
        /// <returns>The response from the CreateRelationship service method, as returned by PartnerCentralChannel.</returns>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.InternalServerException">
        /// An internal server error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota limit.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ValidationException">
        /// The request failed validation due to invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/CreateRelationship">REST API Reference for CreateRelationship Operation</seealso>
        CreateRelationshipResponse CreateRelationship(CreateRelationshipRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRelationship operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRelationship operation on AmazonPartnerCentralChannelClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateRelationship
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/CreateRelationship">REST API Reference for CreateRelationship Operation</seealso>
        IAsyncResult BeginCreateRelationship(CreateRelationshipRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateRelationship operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRelationship.</param>
        /// 
        /// <returns>Returns a  CreateRelationshipResult from PartnerCentralChannel.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/CreateRelationship">REST API Reference for CreateRelationship Operation</seealso>
        CreateRelationshipResponse EndCreateRelationship(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteProgramManagementAccount


        /// <summary>
        /// Deletes a program management account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProgramManagementAccount service method.</param>
        /// 
        /// <returns>The response from the DeleteProgramManagementAccount service method, as returned by PartnerCentralChannel.</returns>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.InternalServerException">
        /// An internal server error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ValidationException">
        /// The request failed validation due to invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/DeleteProgramManagementAccount">REST API Reference for DeleteProgramManagementAccount Operation</seealso>
        DeleteProgramManagementAccountResponse DeleteProgramManagementAccount(DeleteProgramManagementAccountRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteProgramManagementAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteProgramManagementAccount operation on AmazonPartnerCentralChannelClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteProgramManagementAccount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/DeleteProgramManagementAccount">REST API Reference for DeleteProgramManagementAccount Operation</seealso>
        IAsyncResult BeginDeleteProgramManagementAccount(DeleteProgramManagementAccountRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteProgramManagementAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteProgramManagementAccount.</param>
        /// 
        /// <returns>Returns a  DeleteProgramManagementAccountResult from PartnerCentralChannel.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/DeleteProgramManagementAccount">REST API Reference for DeleteProgramManagementAccount Operation</seealso>
        DeleteProgramManagementAccountResponse EndDeleteProgramManagementAccount(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteRelationship


        /// <summary>
        /// Deletes a partner relationship.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRelationship service method.</param>
        /// 
        /// <returns>The response from the DeleteRelationship service method, as returned by PartnerCentralChannel.</returns>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.InternalServerException">
        /// An internal server error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ValidationException">
        /// The request failed validation due to invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/DeleteRelationship">REST API Reference for DeleteRelationship Operation</seealso>
        DeleteRelationshipResponse DeleteRelationship(DeleteRelationshipRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRelationship operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRelationship operation on AmazonPartnerCentralChannelClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRelationship
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/DeleteRelationship">REST API Reference for DeleteRelationship Operation</seealso>
        IAsyncResult BeginDeleteRelationship(DeleteRelationshipRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRelationship operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRelationship.</param>
        /// 
        /// <returns>Returns a  DeleteRelationshipResult from PartnerCentralChannel.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/DeleteRelationship">REST API Reference for DeleteRelationship Operation</seealso>
        DeleteRelationshipResponse EndDeleteRelationship(IAsyncResult asyncResult);

        #endregion
        
        #region  GetRelationship


        /// <summary>
        /// Retrieves details of a specific partner relationship.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRelationship service method.</param>
        /// 
        /// <returns>The response from the GetRelationship service method, as returned by PartnerCentralChannel.</returns>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.InternalServerException">
        /// An internal server error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ValidationException">
        /// The request failed validation due to invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/GetRelationship">REST API Reference for GetRelationship Operation</seealso>
        GetRelationshipResponse GetRelationship(GetRelationshipRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetRelationship operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRelationship operation on AmazonPartnerCentralChannelClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRelationship
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/GetRelationship">REST API Reference for GetRelationship Operation</seealso>
        IAsyncResult BeginGetRelationship(GetRelationshipRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetRelationship operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRelationship.</param>
        /// 
        /// <returns>Returns a  GetRelationshipResult from PartnerCentralChannel.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/GetRelationship">REST API Reference for GetRelationship Operation</seealso>
        GetRelationshipResponse EndGetRelationship(IAsyncResult asyncResult);

        #endregion
        
        #region  ListChannelHandshakes


        /// <summary>
        /// Lists channel handshakes based on specified criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListChannelHandshakes service method.</param>
        /// 
        /// <returns>The response from the ListChannelHandshakes service method, as returned by PartnerCentralChannel.</returns>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.InternalServerException">
        /// An internal server error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ValidationException">
        /// The request failed validation due to invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/ListChannelHandshakes">REST API Reference for ListChannelHandshakes Operation</seealso>
        ListChannelHandshakesResponse ListChannelHandshakes(ListChannelHandshakesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListChannelHandshakes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListChannelHandshakes operation on AmazonPartnerCentralChannelClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListChannelHandshakes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/ListChannelHandshakes">REST API Reference for ListChannelHandshakes Operation</seealso>
        IAsyncResult BeginListChannelHandshakes(ListChannelHandshakesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListChannelHandshakes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListChannelHandshakes.</param>
        /// 
        /// <returns>Returns a  ListChannelHandshakesResult from PartnerCentralChannel.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/ListChannelHandshakes">REST API Reference for ListChannelHandshakes Operation</seealso>
        ListChannelHandshakesResponse EndListChannelHandshakes(IAsyncResult asyncResult);

        #endregion
        
        #region  ListProgramManagementAccounts


        /// <summary>
        /// Lists program management accounts based on specified criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProgramManagementAccounts service method.</param>
        /// 
        /// <returns>The response from the ListProgramManagementAccounts service method, as returned by PartnerCentralChannel.</returns>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.InternalServerException">
        /// An internal server error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ValidationException">
        /// The request failed validation due to invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/ListProgramManagementAccounts">REST API Reference for ListProgramManagementAccounts Operation</seealso>
        ListProgramManagementAccountsResponse ListProgramManagementAccounts(ListProgramManagementAccountsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListProgramManagementAccounts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListProgramManagementAccounts operation on AmazonPartnerCentralChannelClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListProgramManagementAccounts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/ListProgramManagementAccounts">REST API Reference for ListProgramManagementAccounts Operation</seealso>
        IAsyncResult BeginListProgramManagementAccounts(ListProgramManagementAccountsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListProgramManagementAccounts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListProgramManagementAccounts.</param>
        /// 
        /// <returns>Returns a  ListProgramManagementAccountsResult from PartnerCentralChannel.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/ListProgramManagementAccounts">REST API Reference for ListProgramManagementAccounts Operation</seealso>
        ListProgramManagementAccountsResponse EndListProgramManagementAccounts(IAsyncResult asyncResult);

        #endregion
        
        #region  ListRelationships


        /// <summary>
        /// Lists partner relationships based on specified criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRelationships service method.</param>
        /// 
        /// <returns>The response from the ListRelationships service method, as returned by PartnerCentralChannel.</returns>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.InternalServerException">
        /// An internal server error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ValidationException">
        /// The request failed validation due to invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/ListRelationships">REST API Reference for ListRelationships Operation</seealso>
        ListRelationshipsResponse ListRelationships(ListRelationshipsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListRelationships operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRelationships operation on AmazonPartnerCentralChannelClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRelationships
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/ListRelationships">REST API Reference for ListRelationships Operation</seealso>
        IAsyncResult BeginListRelationships(ListRelationshipsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListRelationships operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRelationships.</param>
        /// 
        /// <returns>Returns a  ListRelationshipsResult from PartnerCentralChannel.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/ListRelationships">REST API Reference for ListRelationships Operation</seealso>
        ListRelationshipsResponse EndListRelationships(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists tags associated with a specific resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by PartnerCentralChannel.</returns>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.InternalServerException">
        /// An internal server error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ValidationException">
        /// The request failed validation due to invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonPartnerCentralChannelClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from PartnerCentralChannel.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  RejectChannelHandshake


        /// <summary>
        /// Rejects a pending channel handshake request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RejectChannelHandshake service method.</param>
        /// 
        /// <returns>The response from the RejectChannelHandshake service method, as returned by PartnerCentralChannel.</returns>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.InternalServerException">
        /// An internal server error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ValidationException">
        /// The request failed validation due to invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/RejectChannelHandshake">REST API Reference for RejectChannelHandshake Operation</seealso>
        RejectChannelHandshakeResponse RejectChannelHandshake(RejectChannelHandshakeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RejectChannelHandshake operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RejectChannelHandshake operation on AmazonPartnerCentralChannelClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRejectChannelHandshake
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/RejectChannelHandshake">REST API Reference for RejectChannelHandshake Operation</seealso>
        IAsyncResult BeginRejectChannelHandshake(RejectChannelHandshakeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RejectChannelHandshake operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRejectChannelHandshake.</param>
        /// 
        /// <returns>Returns a  RejectChannelHandshakeResult from PartnerCentralChannel.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/RejectChannelHandshake">REST API Reference for RejectChannelHandshake Operation</seealso>
        RejectChannelHandshakeResponse EndRejectChannelHandshake(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds or updates tags for a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by PartnerCentralChannel.</returns>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.InternalServerException">
        /// An internal server error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ValidationException">
        /// The request failed validation due to invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonPartnerCentralChannelClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from PartnerCentralChannel.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes tags from a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by PartnerCentralChannel.</returns>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.InternalServerException">
        /// An internal server error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ValidationException">
        /// The request failed validation due to invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonPartnerCentralChannelClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from PartnerCentralChannel.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateProgramManagementAccount


        /// <summary>
        /// Updates the properties of a program management account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProgramManagementAccount service method.</param>
        /// 
        /// <returns>The response from the UpdateProgramManagementAccount service method, as returned by PartnerCentralChannel.</returns>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.InternalServerException">
        /// An internal server error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ValidationException">
        /// The request failed validation due to invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/UpdateProgramManagementAccount">REST API Reference for UpdateProgramManagementAccount Operation</seealso>
        UpdateProgramManagementAccountResponse UpdateProgramManagementAccount(UpdateProgramManagementAccountRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateProgramManagementAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateProgramManagementAccount operation on AmazonPartnerCentralChannelClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateProgramManagementAccount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/UpdateProgramManagementAccount">REST API Reference for UpdateProgramManagementAccount Operation</seealso>
        IAsyncResult BeginUpdateProgramManagementAccount(UpdateProgramManagementAccountRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateProgramManagementAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateProgramManagementAccount.</param>
        /// 
        /// <returns>Returns a  UpdateProgramManagementAccountResult from PartnerCentralChannel.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/UpdateProgramManagementAccount">REST API Reference for UpdateProgramManagementAccount Operation</seealso>
        UpdateProgramManagementAccountResponse EndUpdateProgramManagementAccount(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateRelationship


        /// <summary>
        /// Updates the properties of a partner relationship.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRelationship service method.</param>
        /// 
        /// <returns>The response from the UpdateRelationship service method, as returned by PartnerCentralChannel.</returns>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.InternalServerException">
        /// An internal server error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ValidationException">
        /// The request failed validation due to invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/UpdateRelationship">REST API Reference for UpdateRelationship Operation</seealso>
        UpdateRelationshipResponse UpdateRelationship(UpdateRelationshipRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRelationship operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRelationship operation on AmazonPartnerCentralChannelClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateRelationship
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/UpdateRelationship">REST API Reference for UpdateRelationship Operation</seealso>
        IAsyncResult BeginUpdateRelationship(UpdateRelationshipRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRelationship operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRelationship.</param>
        /// 
        /// <returns>Returns a  UpdateRelationshipResult from PartnerCentralChannel.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/UpdateRelationship">REST API Reference for UpdateRelationship Operation</seealso>
        UpdateRelationshipResponse EndUpdateRelationship(IAsyncResult asyncResult);

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