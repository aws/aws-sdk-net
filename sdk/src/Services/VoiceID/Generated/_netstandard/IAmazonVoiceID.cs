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
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.VoiceID.Model;

#pragma warning disable CS1570
namespace Amazon.VoiceID
{
    /// <summary>
    /// <para>Interface for accessing VoiceID</para>
    ///
    /// Amazon Connect Voice ID provides real-time caller authentication and fraud risk detection,
    /// which make voice interactions in contact centers more secure and efficient.
    /// </summary>
    public partial interface IAmazonVoiceID : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateFraudster service method, as returned by VoiceID.</returns>
        /// <exception cref="Amazon.VoiceID.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action. Check the error message
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ConflictException">
        /// The request failed due to a conflict. Check the <c>ConflictType</c> and error message
        /// for more details.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.InternalServerException">
        /// The request failed due to an unknown error on the server side.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the <c>ResourceType</c> and error message
        /// for more details.
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
        Task<AssociateFraudsterResponse> AssociateFraudsterAsync(AssociateFraudsterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateDomain



        /// <summary>
        /// Creates a domain that contains all Amazon Connect Voice ID data, such as speakers,
        /// fraudsters, customer audio, and voiceprints. Every domain is created with a default
        /// watchlist that fraudsters can be a part of.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDomain service method, as returned by VoiceID.</returns>
        /// <exception cref="Amazon.VoiceID.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action. Check the error message
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ConflictException">
        /// The request failed due to a conflict. Check the <c>ConflictType</c> and error message
        /// for more details.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.InternalServerException">
        /// The request failed due to an unknown error on the server side.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the <c>ResourceType</c> and error message
        /// for more details.
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
        Task<CreateDomainResponse> CreateDomainAsync(CreateDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateWatchlist



        /// <summary>
        /// Creates a watchlist that fraudsters can be a part of.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWatchlist service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateWatchlist service method, as returned by VoiceID.</returns>
        /// <exception cref="Amazon.VoiceID.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action. Check the error message
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ConflictException">
        /// The request failed due to a conflict. Check the <c>ConflictType</c> and error message
        /// for more details.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.InternalServerException">
        /// The request failed due to an unknown error on the server side.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the <c>ResourceType</c> and error message
        /// for more details.
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
        Task<CreateWatchlistResponse> CreateWatchlistAsync(CreateWatchlistRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteDomain



        /// <summary>
        /// Deletes the specified domain from Voice ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDomain service method, as returned by VoiceID.</returns>
        /// <exception cref="Amazon.VoiceID.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action. Check the error message
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ConflictException">
        /// The request failed due to a conflict. Check the <c>ConflictType</c> and error message
        /// for more details.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.InternalServerException">
        /// The request failed due to an unknown error on the server side.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the <c>ResourceType</c> and error message
        /// for more details.
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
        Task<DeleteDomainResponse> DeleteDomainAsync(DeleteDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteFraudster



        /// <summary>
        /// Deletes the specified fraudster from Voice ID. This action disassociates the fraudster
        /// from any watchlists it is a part of.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFraudster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteFraudster service method, as returned by VoiceID.</returns>
        /// <exception cref="Amazon.VoiceID.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action. Check the error message
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ConflictException">
        /// The request failed due to a conflict. Check the <c>ConflictType</c> and error message
        /// for more details.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.InternalServerException">
        /// The request failed due to an unknown error on the server side.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the <c>ResourceType</c> and error message
        /// for more details.
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
        Task<DeleteFraudsterResponse> DeleteFraudsterAsync(DeleteFraudsterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteSpeaker



        /// <summary>
        /// Deletes the specified speaker from Voice ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSpeaker service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSpeaker service method, as returned by VoiceID.</returns>
        /// <exception cref="Amazon.VoiceID.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action. Check the error message
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ConflictException">
        /// The request failed due to a conflict. Check the <c>ConflictType</c> and error message
        /// for more details.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.InternalServerException">
        /// The request failed due to an unknown error on the server side.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the <c>ResourceType</c> and error message
        /// for more details.
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
        Task<DeleteSpeakerResponse> DeleteSpeakerAsync(DeleteSpeakerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteWatchlist



        /// <summary>
        /// Deletes the specified watchlist from Voice ID. This API throws an exception when there
        /// are fraudsters in the watchlist that you are trying to delete. You must delete the
        /// fraudsters, and then delete the watchlist. Every domain has a default watchlist which
        /// cannot be deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWatchlist service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteWatchlist service method, as returned by VoiceID.</returns>
        /// <exception cref="Amazon.VoiceID.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action. Check the error message
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ConflictException">
        /// The request failed due to a conflict. Check the <c>ConflictType</c> and error message
        /// for more details.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.InternalServerException">
        /// The request failed due to an unknown error on the server side.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the <c>ResourceType</c> and error message
        /// for more details.
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
        Task<DeleteWatchlistResponse> DeleteWatchlistAsync(DeleteWatchlistRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeDomain



        /// <summary>
        /// Describes the specified domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// The specified resource cannot be found. Check the <c>ResourceType</c> and error message
        /// for more details.
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
        Task<DescribeDomainResponse> DescribeDomainAsync(DescribeDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeFraudster



        /// <summary>
        /// Describes the specified fraudster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFraudster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// The specified resource cannot be found. Check the <c>ResourceType</c> and error message
        /// for more details.
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
        Task<DescribeFraudsterResponse> DescribeFraudsterAsync(DescribeFraudsterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeFraudsterRegistrationJob



        /// <summary>
        /// Describes the specified fraudster registration job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFraudsterRegistrationJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// The specified resource cannot be found. Check the <c>ResourceType</c> and error message
        /// for more details.
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
        Task<DescribeFraudsterRegistrationJobResponse> DescribeFraudsterRegistrationJobAsync(DescribeFraudsterRegistrationJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeSpeaker



        /// <summary>
        /// Describes the specified speaker.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSpeaker service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// The specified resource cannot be found. Check the <c>ResourceType</c> and error message
        /// for more details.
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
        Task<DescribeSpeakerResponse> DescribeSpeakerAsync(DescribeSpeakerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeSpeakerEnrollmentJob



        /// <summary>
        /// Describes the specified speaker enrollment job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSpeakerEnrollmentJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// The specified resource cannot be found. Check the <c>ResourceType</c> and error message
        /// for more details.
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
        Task<DescribeSpeakerEnrollmentJobResponse> DescribeSpeakerEnrollmentJobAsync(DescribeSpeakerEnrollmentJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeWatchlist



        /// <summary>
        /// Describes the specified watchlist.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeWatchlist service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// The specified resource cannot be found. Check the <c>ResourceType</c> and error message
        /// for more details.
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
        Task<DescribeWatchlistResponse> DescribeWatchlistAsync(DescribeWatchlistRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisassociateFraudster



        /// <summary>
        /// Disassociates the fraudsters from the watchlist specified. Voice ID always expects
        /// a fraudster to be a part of at least one watchlist. If you try to disassociate a fraudster
        /// from its only watchlist, a <c>ValidationException</c> is thrown.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateFraudster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateFraudster service method, as returned by VoiceID.</returns>
        /// <exception cref="Amazon.VoiceID.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action. Check the error message
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ConflictException">
        /// The request failed due to a conflict. Check the <c>ConflictType</c> and error message
        /// for more details.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.InternalServerException">
        /// The request failed due to an unknown error on the server side.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the <c>ResourceType</c> and error message
        /// for more details.
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
        Task<DisassociateFraudsterResponse> DisassociateFraudsterAsync(DisassociateFraudsterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  EvaluateSession



        /// <summary>
        /// Evaluates a specified session based on audio data accumulated during a streaming Amazon
        /// Connect Voice ID call.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EvaluateSession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EvaluateSession service method, as returned by VoiceID.</returns>
        /// <exception cref="Amazon.VoiceID.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action. Check the error message
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ConflictException">
        /// The request failed due to a conflict. Check the <c>ConflictType</c> and error message
        /// for more details.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.InternalServerException">
        /// The request failed due to an unknown error on the server side.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the <c>ResourceType</c> and error message
        /// for more details.
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
        Task<EvaluateSessionResponse> EvaluateSessionAsync(EvaluateSessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListDomains



        /// <summary>
        /// Lists all the domains in the Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDomains service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListDomainsResponse> ListDomainsAsync(ListDomainsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListFraudsterRegistrationJobs



        /// <summary>
        /// Lists all the fraudster registration jobs in the domain with the given <c>JobStatus</c>.
        /// If <c>JobStatus</c> is not provided, this lists all fraudster registration jobs in
        /// the given domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFraudsterRegistrationJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// The specified resource cannot be found. Check the <c>ResourceType</c> and error message
        /// for more details.
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
        Task<ListFraudsterRegistrationJobsResponse> ListFraudsterRegistrationJobsAsync(ListFraudsterRegistrationJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListFraudsters



        /// <summary>
        /// Lists all fraudsters in a specified watchlist or domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFraudsters service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// The specified resource cannot be found. Check the <c>ResourceType</c> and error message
        /// for more details.
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
        Task<ListFraudstersResponse> ListFraudstersAsync(ListFraudstersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListSpeakerEnrollmentJobs



        /// <summary>
        /// Lists all the speaker enrollment jobs in the domain with the specified <c>JobStatus</c>.
        /// If <c>JobStatus</c> is not provided, this lists all jobs with all possible speaker
        /// enrollment job statuses.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSpeakerEnrollmentJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// The specified resource cannot be found. Check the <c>ResourceType</c> and error message
        /// for more details.
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
        Task<ListSpeakerEnrollmentJobsResponse> ListSpeakerEnrollmentJobsAsync(ListSpeakerEnrollmentJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListSpeakers



        /// <summary>
        /// Lists all speakers in a specified domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSpeakers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// The specified resource cannot be found. Check the <c>ResourceType</c> and error message
        /// for more details.
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
        Task<ListSpeakersResponse> ListSpeakersAsync(ListSpeakersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource



        /// <summary>
        /// Lists all tags associated with a specified Voice ID resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// The specified resource cannot be found. Check the <c>ResourceType</c> and error message
        /// for more details.
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
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListWatchlists



        /// <summary>
        /// Lists all watchlists in a specified domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWatchlists service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// The specified resource cannot be found. Check the <c>ResourceType</c> and error message
        /// for more details.
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
        Task<ListWatchlistsResponse> ListWatchlistsAsync(ListWatchlistsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the OptOutSpeaker service method, as returned by VoiceID.</returns>
        /// <exception cref="Amazon.VoiceID.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action. Check the error message
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ConflictException">
        /// The request failed due to a conflict. Check the <c>ConflictType</c> and error message
        /// for more details.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.InternalServerException">
        /// The request failed due to an unknown error on the server side.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the <c>ResourceType</c> and error message
        /// for more details.
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
        Task<OptOutSpeakerResponse> OptOutSpeakerAsync(OptOutSpeakerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartFraudsterRegistrationJob



        /// <summary>
        /// Starts a new batch fraudster registration job using provided details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartFraudsterRegistrationJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartFraudsterRegistrationJob service method, as returned by VoiceID.</returns>
        /// <exception cref="Amazon.VoiceID.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action. Check the error message
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ConflictException">
        /// The request failed due to a conflict. Check the <c>ConflictType</c> and error message
        /// for more details.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.InternalServerException">
        /// The request failed due to an unknown error on the server side.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the <c>ResourceType</c> and error message
        /// for more details.
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
        Task<StartFraudsterRegistrationJobResponse> StartFraudsterRegistrationJobAsync(StartFraudsterRegistrationJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartSpeakerEnrollmentJob



        /// <summary>
        /// Starts a new batch speaker enrollment job using specified details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartSpeakerEnrollmentJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartSpeakerEnrollmentJob service method, as returned by VoiceID.</returns>
        /// <exception cref="Amazon.VoiceID.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action. Check the error message
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ConflictException">
        /// The request failed due to a conflict. Check the <c>ConflictType</c> and error message
        /// for more details.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.InternalServerException">
        /// The request failed due to an unknown error on the server side.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the <c>ResourceType</c> and error message
        /// for more details.
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
        Task<StartSpeakerEnrollmentJobResponse> StartSpeakerEnrollmentJobAsync(StartSpeakerEnrollmentJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource



        /// <summary>
        /// Tags a Voice ID resource with the provided list of tags.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by VoiceID.</returns>
        /// <exception cref="Amazon.VoiceID.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action. Check the error message
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ConflictException">
        /// The request failed due to a conflict. Check the <c>ConflictType</c> and error message
        /// for more details.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.InternalServerException">
        /// The request failed due to an unknown error on the server side.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the <c>ResourceType</c> and error message
        /// for more details.
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
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource



        /// <summary>
        /// Removes specified tags from a specified Amazon Connect Voice ID resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by VoiceID.</returns>
        /// <exception cref="Amazon.VoiceID.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action. Check the error message
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ConflictException">
        /// The request failed due to a conflict. Check the <c>ConflictType</c> and error message
        /// for more details.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.InternalServerException">
        /// The request failed due to an unknown error on the server side.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the <c>ResourceType</c> and error message
        /// for more details.
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
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateDomain



        /// <summary>
        /// Updates the specified domain. This API has clobber behavior, and clears and replaces
        /// all attributes. If an optional field, such as 'Description' is not provided, it is
        /// removed from the domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDomain service method, as returned by VoiceID.</returns>
        /// <exception cref="Amazon.VoiceID.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action. Check the error message
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ConflictException">
        /// The request failed due to a conflict. Check the <c>ConflictType</c> and error message
        /// for more details.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.InternalServerException">
        /// The request failed due to an unknown error on the server side.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the <c>ResourceType</c> and error message
        /// for more details.
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
        Task<UpdateDomainResponse> UpdateDomainAsync(UpdateDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateWatchlist



        /// <summary>
        /// Updates the specified watchlist. Every domain has a default watchlist which cannot
        /// be updated.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWatchlist service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateWatchlist service method, as returned by VoiceID.</returns>
        /// <exception cref="Amazon.VoiceID.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action. Check the error message
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ConflictException">
        /// The request failed due to a conflict. Check the <c>ConflictType</c> and error message
        /// for more details.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.InternalServerException">
        /// The request failed due to an unknown error on the server side.
        /// </exception>
        /// <exception cref="Amazon.VoiceID.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the <c>ResourceType</c> and error message
        /// for more details.
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
        Task<UpdateWatchlistResponse> UpdateWatchlistAsync(UpdateWatchlistRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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