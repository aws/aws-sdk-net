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
 * Do not modify this file. This file is generated from the voice-id-2021-09-27.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.VoiceID.Model;

namespace Amazon.VoiceID
{
    /// <summary>
    /// Interface for accessing VoiceID
    ///
    /// Amazon Connect Voice ID provides real-time caller authentication and fraud risk detection,
    /// which make voice interactions in contact centers more secure and efficient.
    /// </summary>
    public partial interface IAmazonVoiceID : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IVoiceIDPaginatorFactory Paginators { get; }
#endif


        
        #region  AssociateFraudster


        /// <summary>
        /// Associates the fraudsters with the watchlist specified in the same domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateFraudster service method.</param>
        /// 
        /// <returns>The response from the AssociateFraudster service method, as returned by VoiceID.</returns>
        /// <exception cref="Amazon.VoiceID.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action. Check the error message
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ConflictException">
        /// The request failed due to a conflict. Check the <code>ConflictType</code> and error
        /// message for more details.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.InternalServerException">
        /// The request failed due to an unknown error on the server side.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the <code>ResourceType</code> and error
        /// message for more details.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ServiceQuotaExceededException">
        /// The request exceeded the service quota. Refer to <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html#voiceid-quotas">Voice
        /// ID Service Quotas</a> and try your request again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please slow down your request rate.
        /// Refer to <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html##voiceid-api-quotas">
        /// Amazon Connect Voice ID Service API throttling quotas </a> and try your request again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ValidationException">
        /// The request failed one or more validations; check the error message for more details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/AssociateFraudster">REST API Reference for AssociateFraudster Operation</seealso>
        AssociateFraudsterResponse AssociateFraudster(AssociateFraudsterRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateFraudster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateFraudster operation on AmazonVoiceIDClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateFraudster
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/AssociateFraudster">REST API Reference for AssociateFraudster Operation</seealso>
        IAsyncResult BeginAssociateFraudster(AssociateFraudsterRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateFraudster operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateFraudster.</param>
        /// 
        /// <returns>Returns a  AssociateFraudsterResult from VoiceID.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/AssociateFraudster">REST API Reference for AssociateFraudster Operation</seealso>
        AssociateFraudsterResponse EndAssociateFraudster(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateDomain


        /// <summary>
        /// Creates a domain that contains all Amazon Connect Voice ID data, such as speakers,
        /// fraudsters, customer audio, and voiceprints. Every domain is created with a default
        /// watchlist that fraudsters can be a part of.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDomain service method.</param>
        /// 
        /// <returns>The response from the CreateDomain service method, as returned by VoiceID.</returns>
        /// <exception cref="Amazon.VoiceID.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action. Check the error message
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ConflictException">
        /// The request failed due to a conflict. Check the <code>ConflictType</code> and error
        /// message for more details.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.InternalServerException">
        /// The request failed due to an unknown error on the server side.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the <code>ResourceType</code> and error
        /// message for more details.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ServiceQuotaExceededException">
        /// The request exceeded the service quota. Refer to <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html#voiceid-quotas">Voice
        /// ID Service Quotas</a> and try your request again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please slow down your request rate.
        /// Refer to <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html##voiceid-api-quotas">
        /// Amazon Connect Voice ID Service API throttling quotas </a> and try your request again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ValidationException">
        /// The request failed one or more validations; check the error message for more details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/CreateDomain">REST API Reference for CreateDomain Operation</seealso>
        CreateDomainResponse CreateDomain(CreateDomainRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDomain operation on AmazonVoiceIDClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDomain
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/CreateDomain">REST API Reference for CreateDomain Operation</seealso>
        IAsyncResult BeginCreateDomain(CreateDomainRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDomain operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDomain.</param>
        /// 
        /// <returns>Returns a  CreateDomainResult from VoiceID.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/CreateDomain">REST API Reference for CreateDomain Operation</seealso>
        CreateDomainResponse EndCreateDomain(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateWatchlist


        /// <summary>
        /// Creates a watchlist that fraudsters can be a part of.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWatchlist service method.</param>
        /// 
        /// <returns>The response from the CreateWatchlist service method, as returned by VoiceID.</returns>
        /// <exception cref="Amazon.VoiceID.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action. Check the error message
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ConflictException">
        /// The request failed due to a conflict. Check the <code>ConflictType</code> and error
        /// message for more details.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.InternalServerException">
        /// The request failed due to an unknown error on the server side.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the <code>ResourceType</code> and error
        /// message for more details.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ServiceQuotaExceededException">
        /// The request exceeded the service quota. Refer to <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html#voiceid-quotas">Voice
        /// ID Service Quotas</a> and try your request again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please slow down your request rate.
        /// Refer to <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html##voiceid-api-quotas">
        /// Amazon Connect Voice ID Service API throttling quotas </a> and try your request again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ValidationException">
        /// The request failed one or more validations; check the error message for more details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/CreateWatchlist">REST API Reference for CreateWatchlist Operation</seealso>
        CreateWatchlistResponse CreateWatchlist(CreateWatchlistRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateWatchlist operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateWatchlist operation on AmazonVoiceIDClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateWatchlist
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/CreateWatchlist">REST API Reference for CreateWatchlist Operation</seealso>
        IAsyncResult BeginCreateWatchlist(CreateWatchlistRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateWatchlist operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateWatchlist.</param>
        /// 
        /// <returns>Returns a  CreateWatchlistResult from VoiceID.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/CreateWatchlist">REST API Reference for CreateWatchlist Operation</seealso>
        CreateWatchlistResponse EndCreateWatchlist(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteDomain


        /// <summary>
        /// Deletes the specified domain from Voice ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomain service method.</param>
        /// 
        /// <returns>The response from the DeleteDomain service method, as returned by VoiceID.</returns>
        /// <exception cref="Amazon.VoiceID.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action. Check the error message
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ConflictException">
        /// The request failed due to a conflict. Check the <code>ConflictType</code> and error
        /// message for more details.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.InternalServerException">
        /// The request failed due to an unknown error on the server side.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the <code>ResourceType</code> and error
        /// message for more details.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please slow down your request rate.
        /// Refer to <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html##voiceid-api-quotas">
        /// Amazon Connect Voice ID Service API throttling quotas </a> and try your request again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ValidationException">
        /// The request failed one or more validations; check the error message for more details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/DeleteDomain">REST API Reference for DeleteDomain Operation</seealso>
        DeleteDomainResponse DeleteDomain(DeleteDomainRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomain operation on AmazonVoiceIDClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDomain
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/DeleteDomain">REST API Reference for DeleteDomain Operation</seealso>
        IAsyncResult BeginDeleteDomain(DeleteDomainRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDomain operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDomain.</param>
        /// 
        /// <returns>Returns a  DeleteDomainResult from VoiceID.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/DeleteDomain">REST API Reference for DeleteDomain Operation</seealso>
        DeleteDomainResponse EndDeleteDomain(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteFraudster


        /// <summary>
        /// Deletes the specified fraudster from Voice ID. This action disassociates the fraudster
        /// from any watchlists it is a part of.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFraudster service method.</param>
        /// 
        /// <returns>The response from the DeleteFraudster service method, as returned by VoiceID.</returns>
        /// <exception cref="Amazon.VoiceID.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action. Check the error message
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ConflictException">
        /// The request failed due to a conflict. Check the <code>ConflictType</code> and error
        /// message for more details.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.InternalServerException">
        /// The request failed due to an unknown error on the server side.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the <code>ResourceType</code> and error
        /// message for more details.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please slow down your request rate.
        /// Refer to <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html##voiceid-api-quotas">
        /// Amazon Connect Voice ID Service API throttling quotas </a> and try your request again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ValidationException">
        /// The request failed one or more validations; check the error message for more details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/DeleteFraudster">REST API Reference for DeleteFraudster Operation</seealso>
        DeleteFraudsterResponse DeleteFraudster(DeleteFraudsterRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteFraudster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFraudster operation on AmazonVoiceIDClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteFraudster
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/DeleteFraudster">REST API Reference for DeleteFraudster Operation</seealso>
        IAsyncResult BeginDeleteFraudster(DeleteFraudsterRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteFraudster operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteFraudster.</param>
        /// 
        /// <returns>Returns a  DeleteFraudsterResult from VoiceID.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/DeleteFraudster">REST API Reference for DeleteFraudster Operation</seealso>
        DeleteFraudsterResponse EndDeleteFraudster(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteSpeaker


        /// <summary>
        /// Deletes the specified speaker from Voice ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSpeaker service method.</param>
        /// 
        /// <returns>The response from the DeleteSpeaker service method, as returned by VoiceID.</returns>
        /// <exception cref="Amazon.VoiceID.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action. Check the error message
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ConflictException">
        /// The request failed due to a conflict. Check the <code>ConflictType</code> and error
        /// message for more details.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.InternalServerException">
        /// The request failed due to an unknown error on the server side.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the <code>ResourceType</code> and error
        /// message for more details.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please slow down your request rate.
        /// Refer to <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html##voiceid-api-quotas">
        /// Amazon Connect Voice ID Service API throttling quotas </a> and try your request again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ValidationException">
        /// The request failed one or more validations; check the error message for more details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/DeleteSpeaker">REST API Reference for DeleteSpeaker Operation</seealso>
        DeleteSpeakerResponse DeleteSpeaker(DeleteSpeakerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSpeaker operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSpeaker operation on AmazonVoiceIDClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSpeaker
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/DeleteSpeaker">REST API Reference for DeleteSpeaker Operation</seealso>
        IAsyncResult BeginDeleteSpeaker(DeleteSpeakerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSpeaker operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSpeaker.</param>
        /// 
        /// <returns>Returns a  DeleteSpeakerResult from VoiceID.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/DeleteSpeaker">REST API Reference for DeleteSpeaker Operation</seealso>
        DeleteSpeakerResponse EndDeleteSpeaker(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteWatchlist


        /// <summary>
        /// Deletes the specified watchlist from Voice ID. This API throws an exception when there
        /// are fraudsters in the watchlist that you are trying to delete. You must delete the
        /// fraudsters, and then delete the watchlist. Every domain has a default watchlist which
        /// cannot be deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWatchlist service method.</param>
        /// 
        /// <returns>The response from the DeleteWatchlist service method, as returned by VoiceID.</returns>
        /// <exception cref="Amazon.VoiceID.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action. Check the error message
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ConflictException">
        /// The request failed due to a conflict. Check the <code>ConflictType</code> and error
        /// message for more details.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.InternalServerException">
        /// The request failed due to an unknown error on the server side.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the <code>ResourceType</code> and error
        /// message for more details.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please slow down your request rate.
        /// Refer to <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html##voiceid-api-quotas">
        /// Amazon Connect Voice ID Service API throttling quotas </a> and try your request again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ValidationException">
        /// The request failed one or more validations; check the error message for more details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/DeleteWatchlist">REST API Reference for DeleteWatchlist Operation</seealso>
        DeleteWatchlistResponse DeleteWatchlist(DeleteWatchlistRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteWatchlist operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteWatchlist operation on AmazonVoiceIDClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteWatchlist
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/DeleteWatchlist">REST API Reference for DeleteWatchlist Operation</seealso>
        IAsyncResult BeginDeleteWatchlist(DeleteWatchlistRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteWatchlist operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteWatchlist.</param>
        /// 
        /// <returns>Returns a  DeleteWatchlistResult from VoiceID.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/DeleteWatchlist">REST API Reference for DeleteWatchlist Operation</seealso>
        DeleteWatchlistResponse EndDeleteWatchlist(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeDomain


        /// <summary>
        /// Describes the specified domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDomain service method.</param>
        /// 
        /// <returns>The response from the DescribeDomain service method, as returned by VoiceID.</returns>
        /// <exception cref="Amazon.VoiceID.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action. Check the error message
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.InternalServerException">
        /// The request failed due to an unknown error on the server side.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the <code>ResourceType</code> and error
        /// message for more details.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please slow down your request rate.
        /// Refer to <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html##voiceid-api-quotas">
        /// Amazon Connect Voice ID Service API throttling quotas </a> and try your request again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ValidationException">
        /// The request failed one or more validations; check the error message for more details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/DescribeDomain">REST API Reference for DescribeDomain Operation</seealso>
        DescribeDomainResponse DescribeDomain(DescribeDomainRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDomain operation on AmazonVoiceIDClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDomain
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/DescribeDomain">REST API Reference for DescribeDomain Operation</seealso>
        IAsyncResult BeginDescribeDomain(DescribeDomainRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDomain operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDomain.</param>
        /// 
        /// <returns>Returns a  DescribeDomainResult from VoiceID.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/DescribeDomain">REST API Reference for DescribeDomain Operation</seealso>
        DescribeDomainResponse EndDescribeDomain(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeFraudster


        /// <summary>
        /// Describes the specified fraudster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFraudster service method.</param>
        /// 
        /// <returns>The response from the DescribeFraudster service method, as returned by VoiceID.</returns>
        /// <exception cref="Amazon.VoiceID.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action. Check the error message
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.InternalServerException">
        /// The request failed due to an unknown error on the server side.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the <code>ResourceType</code> and error
        /// message for more details.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please slow down your request rate.
        /// Refer to <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html##voiceid-api-quotas">
        /// Amazon Connect Voice ID Service API throttling quotas </a> and try your request again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ValidationException">
        /// The request failed one or more validations; check the error message for more details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/DescribeFraudster">REST API Reference for DescribeFraudster Operation</seealso>
        DescribeFraudsterResponse DescribeFraudster(DescribeFraudsterRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeFraudster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeFraudster operation on AmazonVoiceIDClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeFraudster
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/DescribeFraudster">REST API Reference for DescribeFraudster Operation</seealso>
        IAsyncResult BeginDescribeFraudster(DescribeFraudsterRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeFraudster operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeFraudster.</param>
        /// 
        /// <returns>Returns a  DescribeFraudsterResult from VoiceID.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/DescribeFraudster">REST API Reference for DescribeFraudster Operation</seealso>
        DescribeFraudsterResponse EndDescribeFraudster(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeFraudsterRegistrationJob


        /// <summary>
        /// Describes the specified fraudster registration job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFraudsterRegistrationJob service method.</param>
        /// 
        /// <returns>The response from the DescribeFraudsterRegistrationJob service method, as returned by VoiceID.</returns>
        /// <exception cref="Amazon.VoiceID.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action. Check the error message
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.InternalServerException">
        /// The request failed due to an unknown error on the server side.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the <code>ResourceType</code> and error
        /// message for more details.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please slow down your request rate.
        /// Refer to <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html##voiceid-api-quotas">
        /// Amazon Connect Voice ID Service API throttling quotas </a> and try your request again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ValidationException">
        /// The request failed one or more validations; check the error message for more details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/DescribeFraudsterRegistrationJob">REST API Reference for DescribeFraudsterRegistrationJob Operation</seealso>
        DescribeFraudsterRegistrationJobResponse DescribeFraudsterRegistrationJob(DescribeFraudsterRegistrationJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeFraudsterRegistrationJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeFraudsterRegistrationJob operation on AmazonVoiceIDClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeFraudsterRegistrationJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/DescribeFraudsterRegistrationJob">REST API Reference for DescribeFraudsterRegistrationJob Operation</seealso>
        IAsyncResult BeginDescribeFraudsterRegistrationJob(DescribeFraudsterRegistrationJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeFraudsterRegistrationJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeFraudsterRegistrationJob.</param>
        /// 
        /// <returns>Returns a  DescribeFraudsterRegistrationJobResult from VoiceID.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/DescribeFraudsterRegistrationJob">REST API Reference for DescribeFraudsterRegistrationJob Operation</seealso>
        DescribeFraudsterRegistrationJobResponse EndDescribeFraudsterRegistrationJob(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeSpeaker


        /// <summary>
        /// Describes the specified speaker.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSpeaker service method.</param>
        /// 
        /// <returns>The response from the DescribeSpeaker service method, as returned by VoiceID.</returns>
        /// <exception cref="Amazon.VoiceID.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action. Check the error message
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.InternalServerException">
        /// The request failed due to an unknown error on the server side.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the <code>ResourceType</code> and error
        /// message for more details.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please slow down your request rate.
        /// Refer to <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html##voiceid-api-quotas">
        /// Amazon Connect Voice ID Service API throttling quotas </a> and try your request again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ValidationException">
        /// The request failed one or more validations; check the error message for more details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/DescribeSpeaker">REST API Reference for DescribeSpeaker Operation</seealso>
        DescribeSpeakerResponse DescribeSpeaker(DescribeSpeakerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSpeaker operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSpeaker operation on AmazonVoiceIDClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeSpeaker
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/DescribeSpeaker">REST API Reference for DescribeSpeaker Operation</seealso>
        IAsyncResult BeginDescribeSpeaker(DescribeSpeakerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSpeaker operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSpeaker.</param>
        /// 
        /// <returns>Returns a  DescribeSpeakerResult from VoiceID.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/DescribeSpeaker">REST API Reference for DescribeSpeaker Operation</seealso>
        DescribeSpeakerResponse EndDescribeSpeaker(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeSpeakerEnrollmentJob


        /// <summary>
        /// Describes the specified speaker enrollment job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSpeakerEnrollmentJob service method.</param>
        /// 
        /// <returns>The response from the DescribeSpeakerEnrollmentJob service method, as returned by VoiceID.</returns>
        /// <exception cref="Amazon.VoiceID.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action. Check the error message
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.InternalServerException">
        /// The request failed due to an unknown error on the server side.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the <code>ResourceType</code> and error
        /// message for more details.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please slow down your request rate.
        /// Refer to <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html##voiceid-api-quotas">
        /// Amazon Connect Voice ID Service API throttling quotas </a> and try your request again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ValidationException">
        /// The request failed one or more validations; check the error message for more details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/DescribeSpeakerEnrollmentJob">REST API Reference for DescribeSpeakerEnrollmentJob Operation</seealso>
        DescribeSpeakerEnrollmentJobResponse DescribeSpeakerEnrollmentJob(DescribeSpeakerEnrollmentJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSpeakerEnrollmentJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSpeakerEnrollmentJob operation on AmazonVoiceIDClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeSpeakerEnrollmentJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/DescribeSpeakerEnrollmentJob">REST API Reference for DescribeSpeakerEnrollmentJob Operation</seealso>
        IAsyncResult BeginDescribeSpeakerEnrollmentJob(DescribeSpeakerEnrollmentJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSpeakerEnrollmentJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSpeakerEnrollmentJob.</param>
        /// 
        /// <returns>Returns a  DescribeSpeakerEnrollmentJobResult from VoiceID.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/DescribeSpeakerEnrollmentJob">REST API Reference for DescribeSpeakerEnrollmentJob Operation</seealso>
        DescribeSpeakerEnrollmentJobResponse EndDescribeSpeakerEnrollmentJob(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeWatchlist


        /// <summary>
        /// Describes the specified watchlist.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeWatchlist service method.</param>
        /// 
        /// <returns>The response from the DescribeWatchlist service method, as returned by VoiceID.</returns>
        /// <exception cref="Amazon.VoiceID.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action. Check the error message
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.InternalServerException">
        /// The request failed due to an unknown error on the server side.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the <code>ResourceType</code> and error
        /// message for more details.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please slow down your request rate.
        /// Refer to <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html##voiceid-api-quotas">
        /// Amazon Connect Voice ID Service API throttling quotas </a> and try your request again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ValidationException">
        /// The request failed one or more validations; check the error message for more details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/DescribeWatchlist">REST API Reference for DescribeWatchlist Operation</seealso>
        DescribeWatchlistResponse DescribeWatchlist(DescribeWatchlistRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeWatchlist operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeWatchlist operation on AmazonVoiceIDClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeWatchlist
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/DescribeWatchlist">REST API Reference for DescribeWatchlist Operation</seealso>
        IAsyncResult BeginDescribeWatchlist(DescribeWatchlistRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeWatchlist operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeWatchlist.</param>
        /// 
        /// <returns>Returns a  DescribeWatchlistResult from VoiceID.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/DescribeWatchlist">REST API Reference for DescribeWatchlist Operation</seealso>
        DescribeWatchlistResponse EndDescribeWatchlist(IAsyncResult asyncResult);

        #endregion
        
        #region  DisassociateFraudster


        /// <summary>
        /// Disassociates the fraudsters from the watchlist specified. Voice ID always expects
        /// a fraudster to be a part of at least one watchlist. If you try to disassociate a fraudster
        /// from its only watchlist, a <code>ValidationException</code> is thrown.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateFraudster service method.</param>
        /// 
        /// <returns>The response from the DisassociateFraudster service method, as returned by VoiceID.</returns>
        /// <exception cref="Amazon.VoiceID.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action. Check the error message
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ConflictException">
        /// The request failed due to a conflict. Check the <code>ConflictType</code> and error
        /// message for more details.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.InternalServerException">
        /// The request failed due to an unknown error on the server side.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the <code>ResourceType</code> and error
        /// message for more details.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please slow down your request rate.
        /// Refer to <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html##voiceid-api-quotas">
        /// Amazon Connect Voice ID Service API throttling quotas </a> and try your request again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ValidationException">
        /// The request failed one or more validations; check the error message for more details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/DisassociateFraudster">REST API Reference for DisassociateFraudster Operation</seealso>
        DisassociateFraudsterResponse DisassociateFraudster(DisassociateFraudsterRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateFraudster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateFraudster operation on AmazonVoiceIDClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateFraudster
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/DisassociateFraudster">REST API Reference for DisassociateFraudster Operation</seealso>
        IAsyncResult BeginDisassociateFraudster(DisassociateFraudsterRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateFraudster operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateFraudster.</param>
        /// 
        /// <returns>Returns a  DisassociateFraudsterResult from VoiceID.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/DisassociateFraudster">REST API Reference for DisassociateFraudster Operation</seealso>
        DisassociateFraudsterResponse EndDisassociateFraudster(IAsyncResult asyncResult);

        #endregion
        
        #region  EvaluateSession


        /// <summary>
        /// Evaluates a specified session based on audio data accumulated during a streaming Amazon
        /// Connect Voice ID call.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EvaluateSession service method.</param>
        /// 
        /// <returns>The response from the EvaluateSession service method, as returned by VoiceID.</returns>
        /// <exception cref="Amazon.VoiceID.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action. Check the error message
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ConflictException">
        /// The request failed due to a conflict. Check the <code>ConflictType</code> and error
        /// message for more details.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.InternalServerException">
        /// The request failed due to an unknown error on the server side.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the <code>ResourceType</code> and error
        /// message for more details.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please slow down your request rate.
        /// Refer to <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html##voiceid-api-quotas">
        /// Amazon Connect Voice ID Service API throttling quotas </a> and try your request again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ValidationException">
        /// The request failed one or more validations; check the error message for more details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/EvaluateSession">REST API Reference for EvaluateSession Operation</seealso>
        EvaluateSessionResponse EvaluateSession(EvaluateSessionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the EvaluateSession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EvaluateSession operation on AmazonVoiceIDClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEvaluateSession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/EvaluateSession">REST API Reference for EvaluateSession Operation</seealso>
        IAsyncResult BeginEvaluateSession(EvaluateSessionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  EvaluateSession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEvaluateSession.</param>
        /// 
        /// <returns>Returns a  EvaluateSessionResult from VoiceID.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/EvaluateSession">REST API Reference for EvaluateSession Operation</seealso>
        EvaluateSessionResponse EndEvaluateSession(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDomains


        /// <summary>
        /// Lists all the domains in the Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDomains service method.</param>
        /// 
        /// <returns>The response from the ListDomains service method, as returned by VoiceID.</returns>
        /// <exception cref="Amazon.VoiceID.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action. Check the error message
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.InternalServerException">
        /// The request failed due to an unknown error on the server side.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please slow down your request rate.
        /// Refer to <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html##voiceid-api-quotas">
        /// Amazon Connect Voice ID Service API throttling quotas </a> and try your request again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ValidationException">
        /// The request failed one or more validations; check the error message for more details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/ListDomains">REST API Reference for ListDomains Operation</seealso>
        ListDomainsResponse ListDomains(ListDomainsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDomains operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDomains operation on AmazonVoiceIDClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDomains
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/ListDomains">REST API Reference for ListDomains Operation</seealso>
        IAsyncResult BeginListDomains(ListDomainsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDomains operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDomains.</param>
        /// 
        /// <returns>Returns a  ListDomainsResult from VoiceID.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/ListDomains">REST API Reference for ListDomains Operation</seealso>
        ListDomainsResponse EndListDomains(IAsyncResult asyncResult);

        #endregion
        
        #region  ListFraudsterRegistrationJobs


        /// <summary>
        /// Lists all the fraudster registration jobs in the domain with the given <code>JobStatus</code>.
        /// If <code>JobStatus</code> is not provided, this lists all fraudster registration jobs
        /// in the given domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFraudsterRegistrationJobs service method.</param>
        /// 
        /// <returns>The response from the ListFraudsterRegistrationJobs service method, as returned by VoiceID.</returns>
        /// <exception cref="Amazon.VoiceID.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action. Check the error message
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.InternalServerException">
        /// The request failed due to an unknown error on the server side.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the <code>ResourceType</code> and error
        /// message for more details.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please slow down your request rate.
        /// Refer to <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html##voiceid-api-quotas">
        /// Amazon Connect Voice ID Service API throttling quotas </a> and try your request again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ValidationException">
        /// The request failed one or more validations; check the error message for more details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/ListFraudsterRegistrationJobs">REST API Reference for ListFraudsterRegistrationJobs Operation</seealso>
        ListFraudsterRegistrationJobsResponse ListFraudsterRegistrationJobs(ListFraudsterRegistrationJobsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListFraudsterRegistrationJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFraudsterRegistrationJobs operation on AmazonVoiceIDClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListFraudsterRegistrationJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/ListFraudsterRegistrationJobs">REST API Reference for ListFraudsterRegistrationJobs Operation</seealso>
        IAsyncResult BeginListFraudsterRegistrationJobs(ListFraudsterRegistrationJobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListFraudsterRegistrationJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListFraudsterRegistrationJobs.</param>
        /// 
        /// <returns>Returns a  ListFraudsterRegistrationJobsResult from VoiceID.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/ListFraudsterRegistrationJobs">REST API Reference for ListFraudsterRegistrationJobs Operation</seealso>
        ListFraudsterRegistrationJobsResponse EndListFraudsterRegistrationJobs(IAsyncResult asyncResult);

        #endregion
        
        #region  ListFraudsters


        /// <summary>
        /// Lists all fraudsters in a specified watchlist or domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFraudsters service method.</param>
        /// 
        /// <returns>The response from the ListFraudsters service method, as returned by VoiceID.</returns>
        /// <exception cref="Amazon.VoiceID.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action. Check the error message
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.InternalServerException">
        /// The request failed due to an unknown error on the server side.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the <code>ResourceType</code> and error
        /// message for more details.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please slow down your request rate.
        /// Refer to <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html##voiceid-api-quotas">
        /// Amazon Connect Voice ID Service API throttling quotas </a> and try your request again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ValidationException">
        /// The request failed one or more validations; check the error message for more details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/ListFraudsters">REST API Reference for ListFraudsters Operation</seealso>
        ListFraudstersResponse ListFraudsters(ListFraudstersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListFraudsters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFraudsters operation on AmazonVoiceIDClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListFraudsters
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/ListFraudsters">REST API Reference for ListFraudsters Operation</seealso>
        IAsyncResult BeginListFraudsters(ListFraudstersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListFraudsters operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListFraudsters.</param>
        /// 
        /// <returns>Returns a  ListFraudstersResult from VoiceID.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/ListFraudsters">REST API Reference for ListFraudsters Operation</seealso>
        ListFraudstersResponse EndListFraudsters(IAsyncResult asyncResult);

        #endregion
        
        #region  ListSpeakerEnrollmentJobs


        /// <summary>
        /// Lists all the speaker enrollment jobs in the domain with the specified <code>JobStatus</code>.
        /// If <code>JobStatus</code> is not provided, this lists all jobs with all possible speaker
        /// enrollment job statuses.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSpeakerEnrollmentJobs service method.</param>
        /// 
        /// <returns>The response from the ListSpeakerEnrollmentJobs service method, as returned by VoiceID.</returns>
        /// <exception cref="Amazon.VoiceID.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action. Check the error message
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.InternalServerException">
        /// The request failed due to an unknown error on the server side.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the <code>ResourceType</code> and error
        /// message for more details.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please slow down your request rate.
        /// Refer to <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html##voiceid-api-quotas">
        /// Amazon Connect Voice ID Service API throttling quotas </a> and try your request again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ValidationException">
        /// The request failed one or more validations; check the error message for more details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/ListSpeakerEnrollmentJobs">REST API Reference for ListSpeakerEnrollmentJobs Operation</seealso>
        ListSpeakerEnrollmentJobsResponse ListSpeakerEnrollmentJobs(ListSpeakerEnrollmentJobsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListSpeakerEnrollmentJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSpeakerEnrollmentJobs operation on AmazonVoiceIDClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSpeakerEnrollmentJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/ListSpeakerEnrollmentJobs">REST API Reference for ListSpeakerEnrollmentJobs Operation</seealso>
        IAsyncResult BeginListSpeakerEnrollmentJobs(ListSpeakerEnrollmentJobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListSpeakerEnrollmentJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSpeakerEnrollmentJobs.</param>
        /// 
        /// <returns>Returns a  ListSpeakerEnrollmentJobsResult from VoiceID.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/ListSpeakerEnrollmentJobs">REST API Reference for ListSpeakerEnrollmentJobs Operation</seealso>
        ListSpeakerEnrollmentJobsResponse EndListSpeakerEnrollmentJobs(IAsyncResult asyncResult);

        #endregion
        
        #region  ListSpeakers


        /// <summary>
        /// Lists all speakers in a specified domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSpeakers service method.</param>
        /// 
        /// <returns>The response from the ListSpeakers service method, as returned by VoiceID.</returns>
        /// <exception cref="Amazon.VoiceID.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action. Check the error message
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.InternalServerException">
        /// The request failed due to an unknown error on the server side.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the <code>ResourceType</code> and error
        /// message for more details.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please slow down your request rate.
        /// Refer to <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html##voiceid-api-quotas">
        /// Amazon Connect Voice ID Service API throttling quotas </a> and try your request again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ValidationException">
        /// The request failed one or more validations; check the error message for more details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/ListSpeakers">REST API Reference for ListSpeakers Operation</seealso>
        ListSpeakersResponse ListSpeakers(ListSpeakersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListSpeakers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSpeakers operation on AmazonVoiceIDClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSpeakers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/ListSpeakers">REST API Reference for ListSpeakers Operation</seealso>
        IAsyncResult BeginListSpeakers(ListSpeakersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListSpeakers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSpeakers.</param>
        /// 
        /// <returns>Returns a  ListSpeakersResult from VoiceID.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/ListSpeakers">REST API Reference for ListSpeakers Operation</seealso>
        ListSpeakersResponse EndListSpeakers(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists all tags associated with a specified Voice ID resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by VoiceID.</returns>
        /// <exception cref="Amazon.VoiceID.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action. Check the error message
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.InternalServerException">
        /// The request failed due to an unknown error on the server side.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the <code>ResourceType</code> and error
        /// message for more details.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please slow down your request rate.
        /// Refer to <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html##voiceid-api-quotas">
        /// Amazon Connect Voice ID Service API throttling quotas </a> and try your request again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ValidationException">
        /// The request failed one or more validations; check the error message for more details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonVoiceIDClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from VoiceID.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  ListWatchlists


        /// <summary>
        /// Lists all watchlists in a specified domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWatchlists service method.</param>
        /// 
        /// <returns>The response from the ListWatchlists service method, as returned by VoiceID.</returns>
        /// <exception cref="Amazon.VoiceID.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action. Check the error message
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.InternalServerException">
        /// The request failed due to an unknown error on the server side.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the <code>ResourceType</code> and error
        /// message for more details.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please slow down your request rate.
        /// Refer to <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html##voiceid-api-quotas">
        /// Amazon Connect Voice ID Service API throttling quotas </a> and try your request again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ValidationException">
        /// The request failed one or more validations; check the error message for more details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/ListWatchlists">REST API Reference for ListWatchlists Operation</seealso>
        ListWatchlistsResponse ListWatchlists(ListWatchlistsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListWatchlists operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListWatchlists operation on AmazonVoiceIDClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListWatchlists
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/ListWatchlists">REST API Reference for ListWatchlists Operation</seealso>
        IAsyncResult BeginListWatchlists(ListWatchlistsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListWatchlists operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListWatchlists.</param>
        /// 
        /// <returns>Returns a  ListWatchlistsResult from VoiceID.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/ListWatchlists">REST API Reference for ListWatchlists Operation</seealso>
        ListWatchlistsResponse EndListWatchlists(IAsyncResult asyncResult);

        #endregion
        
        #region  OptOutSpeaker


        /// <summary>
        /// Opts out a speaker from Voice ID. A speaker can be opted out regardless of whether
        /// or not they already exist in Voice ID. If they don't yet exist, a new speaker is created
        /// in an opted out state. If they already exist, their existing status is overridden
        /// and they are opted out. Enrollment and evaluation authentication requests are rejected
        /// for opted out speakers, and opted out speakers have no voice embeddings stored in
        /// Voice ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the OptOutSpeaker service method.</param>
        /// 
        /// <returns>The response from the OptOutSpeaker service method, as returned by VoiceID.</returns>
        /// <exception cref="Amazon.VoiceID.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action. Check the error message
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ConflictException">
        /// The request failed due to a conflict. Check the <code>ConflictType</code> and error
        /// message for more details.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.InternalServerException">
        /// The request failed due to an unknown error on the server side.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the <code>ResourceType</code> and error
        /// message for more details.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ServiceQuotaExceededException">
        /// The request exceeded the service quota. Refer to <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html#voiceid-quotas">Voice
        /// ID Service Quotas</a> and try your request again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please slow down your request rate.
        /// Refer to <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html##voiceid-api-quotas">
        /// Amazon Connect Voice ID Service API throttling quotas </a> and try your request again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ValidationException">
        /// The request failed one or more validations; check the error message for more details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/OptOutSpeaker">REST API Reference for OptOutSpeaker Operation</seealso>
        OptOutSpeakerResponse OptOutSpeaker(OptOutSpeakerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the OptOutSpeaker operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the OptOutSpeaker operation on AmazonVoiceIDClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndOptOutSpeaker
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/OptOutSpeaker">REST API Reference for OptOutSpeaker Operation</seealso>
        IAsyncResult BeginOptOutSpeaker(OptOutSpeakerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  OptOutSpeaker operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginOptOutSpeaker.</param>
        /// 
        /// <returns>Returns a  OptOutSpeakerResult from VoiceID.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/OptOutSpeaker">REST API Reference for OptOutSpeaker Operation</seealso>
        OptOutSpeakerResponse EndOptOutSpeaker(IAsyncResult asyncResult);

        #endregion
        
        #region  StartFraudsterRegistrationJob


        /// <summary>
        /// Starts a new batch fraudster registration job using provided details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartFraudsterRegistrationJob service method.</param>
        /// 
        /// <returns>The response from the StartFraudsterRegistrationJob service method, as returned by VoiceID.</returns>
        /// <exception cref="Amazon.VoiceID.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action. Check the error message
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ConflictException">
        /// The request failed due to a conflict. Check the <code>ConflictType</code> and error
        /// message for more details.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.InternalServerException">
        /// The request failed due to an unknown error on the server side.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the <code>ResourceType</code> and error
        /// message for more details.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ServiceQuotaExceededException">
        /// The request exceeded the service quota. Refer to <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html#voiceid-quotas">Voice
        /// ID Service Quotas</a> and try your request again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please slow down your request rate.
        /// Refer to <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html##voiceid-api-quotas">
        /// Amazon Connect Voice ID Service API throttling quotas </a> and try your request again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ValidationException">
        /// The request failed one or more validations; check the error message for more details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/StartFraudsterRegistrationJob">REST API Reference for StartFraudsterRegistrationJob Operation</seealso>
        StartFraudsterRegistrationJobResponse StartFraudsterRegistrationJob(StartFraudsterRegistrationJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartFraudsterRegistrationJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartFraudsterRegistrationJob operation on AmazonVoiceIDClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartFraudsterRegistrationJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/StartFraudsterRegistrationJob">REST API Reference for StartFraudsterRegistrationJob Operation</seealso>
        IAsyncResult BeginStartFraudsterRegistrationJob(StartFraudsterRegistrationJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartFraudsterRegistrationJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartFraudsterRegistrationJob.</param>
        /// 
        /// <returns>Returns a  StartFraudsterRegistrationJobResult from VoiceID.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/StartFraudsterRegistrationJob">REST API Reference for StartFraudsterRegistrationJob Operation</seealso>
        StartFraudsterRegistrationJobResponse EndStartFraudsterRegistrationJob(IAsyncResult asyncResult);

        #endregion
        
        #region  StartSpeakerEnrollmentJob


        /// <summary>
        /// Starts a new batch speaker enrollment job using specified details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartSpeakerEnrollmentJob service method.</param>
        /// 
        /// <returns>The response from the StartSpeakerEnrollmentJob service method, as returned by VoiceID.</returns>
        /// <exception cref="Amazon.VoiceID.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action. Check the error message
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ConflictException">
        /// The request failed due to a conflict. Check the <code>ConflictType</code> and error
        /// message for more details.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.InternalServerException">
        /// The request failed due to an unknown error on the server side.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the <code>ResourceType</code> and error
        /// message for more details.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ServiceQuotaExceededException">
        /// The request exceeded the service quota. Refer to <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html#voiceid-quotas">Voice
        /// ID Service Quotas</a> and try your request again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please slow down your request rate.
        /// Refer to <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html##voiceid-api-quotas">
        /// Amazon Connect Voice ID Service API throttling quotas </a> and try your request again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ValidationException">
        /// The request failed one or more validations; check the error message for more details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/StartSpeakerEnrollmentJob">REST API Reference for StartSpeakerEnrollmentJob Operation</seealso>
        StartSpeakerEnrollmentJobResponse StartSpeakerEnrollmentJob(StartSpeakerEnrollmentJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartSpeakerEnrollmentJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartSpeakerEnrollmentJob operation on AmazonVoiceIDClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartSpeakerEnrollmentJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/StartSpeakerEnrollmentJob">REST API Reference for StartSpeakerEnrollmentJob Operation</seealso>
        IAsyncResult BeginStartSpeakerEnrollmentJob(StartSpeakerEnrollmentJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartSpeakerEnrollmentJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartSpeakerEnrollmentJob.</param>
        /// 
        /// <returns>Returns a  StartSpeakerEnrollmentJobResult from VoiceID.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/StartSpeakerEnrollmentJob">REST API Reference for StartSpeakerEnrollmentJob Operation</seealso>
        StartSpeakerEnrollmentJobResponse EndStartSpeakerEnrollmentJob(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Tags a Voice ID resource with the provided list of tags.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by VoiceID.</returns>
        /// <exception cref="Amazon.VoiceID.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action. Check the error message
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ConflictException">
        /// The request failed due to a conflict. Check the <code>ConflictType</code> and error
        /// message for more details.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.InternalServerException">
        /// The request failed due to an unknown error on the server side.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the <code>ResourceType</code> and error
        /// message for more details.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please slow down your request rate.
        /// Refer to <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html##voiceid-api-quotas">
        /// Amazon Connect Voice ID Service API throttling quotas </a> and try your request again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ValidationException">
        /// The request failed one or more validations; check the error message for more details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonVoiceIDClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from VoiceID.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes specified tags from a specified Amazon Connect Voice ID resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by VoiceID.</returns>
        /// <exception cref="Amazon.VoiceID.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action. Check the error message
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ConflictException">
        /// The request failed due to a conflict. Check the <code>ConflictType</code> and error
        /// message for more details.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.InternalServerException">
        /// The request failed due to an unknown error on the server side.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the <code>ResourceType</code> and error
        /// message for more details.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please slow down your request rate.
        /// Refer to <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html##voiceid-api-quotas">
        /// Amazon Connect Voice ID Service API throttling quotas </a> and try your request again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ValidationException">
        /// The request failed one or more validations; check the error message for more details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonVoiceIDClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from VoiceID.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateDomain


        /// <summary>
        /// Updates the specified domain. This API has clobber behavior, and clears and replaces
        /// all attributes. If an optional field, such as 'Description' is not provided, it is
        /// removed from the domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomain service method.</param>
        /// 
        /// <returns>The response from the UpdateDomain service method, as returned by VoiceID.</returns>
        /// <exception cref="Amazon.VoiceID.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action. Check the error message
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ConflictException">
        /// The request failed due to a conflict. Check the <code>ConflictType</code> and error
        /// message for more details.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.InternalServerException">
        /// The request failed due to an unknown error on the server side.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the <code>ResourceType</code> and error
        /// message for more details.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please slow down your request rate.
        /// Refer to <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html##voiceid-api-quotas">
        /// Amazon Connect Voice ID Service API throttling quotas </a> and try your request again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ValidationException">
        /// The request failed one or more validations; check the error message for more details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/UpdateDomain">REST API Reference for UpdateDomain Operation</seealso>
        UpdateDomainResponse UpdateDomain(UpdateDomainRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomain operation on AmazonVoiceIDClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDomain
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/UpdateDomain">REST API Reference for UpdateDomain Operation</seealso>
        IAsyncResult BeginUpdateDomain(UpdateDomainRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDomain operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDomain.</param>
        /// 
        /// <returns>Returns a  UpdateDomainResult from VoiceID.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/UpdateDomain">REST API Reference for UpdateDomain Operation</seealso>
        UpdateDomainResponse EndUpdateDomain(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateWatchlist


        /// <summary>
        /// Updates the specified watchlist. Every domain has a default watchlist which cannot
        /// be updated.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWatchlist service method.</param>
        /// 
        /// <returns>The response from the UpdateWatchlist service method, as returned by VoiceID.</returns>
        /// <exception cref="Amazon.VoiceID.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action. Check the error message
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ConflictException">
        /// The request failed due to a conflict. Check the <code>ConflictType</code> and error
        /// message for more details.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.InternalServerException">
        /// The request failed due to an unknown error on the server side.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the <code>ResourceType</code> and error
        /// message for more details.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please slow down your request rate.
        /// Refer to <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html##voiceid-api-quotas">
        /// Amazon Connect Voice ID Service API throttling quotas </a> and try your request again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ValidationException">
        /// The request failed one or more validations; check the error message for more details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/UpdateWatchlist">REST API Reference for UpdateWatchlist Operation</seealso>
        UpdateWatchlistResponse UpdateWatchlist(UpdateWatchlistRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateWatchlist operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateWatchlist operation on AmazonVoiceIDClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateWatchlist
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/UpdateWatchlist">REST API Reference for UpdateWatchlist Operation</seealso>
        IAsyncResult BeginUpdateWatchlist(UpdateWatchlistRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateWatchlist operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateWatchlist.</param>
        /// 
        /// <returns>Returns a  UpdateWatchlistResult from VoiceID.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/voice-id-2021-09-27/UpdateWatchlist">REST API Reference for UpdateWatchlist Operation</seealso>
        UpdateWatchlistResponse EndUpdateWatchlist(IAsyncResult asyncResult);

        #endregion
        
    }
}