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
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using Amazon.Runtime;
using Amazon.ConnectCampaignsV2.Model;

#pragma warning disable CS1570

namespace Amazon.ConnectCampaignsV2
{
    /// <summary>
    /// <para>Interface for accessing ConnectCampaignsV2</para>
    ///
    /// Provide APIs to create and manage Amazon Connect Campaigns.
    /// </summary>
    public partial interface IAmazonConnectCampaignsV2 : IAmazonService, IDisposable
    {
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IConnectCampaignsV2PaginatorFactory Paginators { get; }

#if NETFRAMEWORK
        /// <summary>
        /// Creates a campaign for the specified Amazon Connect account. This API is idempotent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCampaign service method.</param>
        /// <returns>The response from the CreateCampaign service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/CreateCampaign">REST API Reference for CreateCampaign Operation</seealso>
        CreateCampaignResponse CreateCampaign(CreateCampaignRequest request);
#endif

        /// <summary>
        /// Creates a campaign for the specified Amazon Connect account. This API is idempotent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCampaign service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateCampaign service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/CreateCampaign">REST API Reference for CreateCampaign Operation</seealso>
        Task<CreateCampaignResponse> CreateCampaignAsync(CreateCampaignRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Deletes a campaign from the specified Amazon Connect account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCampaign service method.</param>
        /// <returns>The response from the DeleteCampaign service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/DeleteCampaign">REST API Reference for DeleteCampaign Operation</seealso>
        DeleteCampaignResponse DeleteCampaign(DeleteCampaignRequest request);
#endif

        /// <summary>
        /// Deletes a campaign from the specified Amazon Connect account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCampaign service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteCampaign service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/DeleteCampaign">REST API Reference for DeleteCampaign Operation</seealso>
        Task<DeleteCampaignResponse> DeleteCampaignAsync(DeleteCampaignRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Deletes the channel subtype config of a campaign. This API is idempotent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCampaignChannelSubtypeConfig service method.</param>
        /// <returns>The response from the DeleteCampaignChannelSubtypeConfig service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/DeleteCampaignChannelSubtypeConfig">REST API Reference for DeleteCampaignChannelSubtypeConfig Operation</seealso>
        DeleteCampaignChannelSubtypeConfigResponse DeleteCampaignChannelSubtypeConfig(DeleteCampaignChannelSubtypeConfigRequest request);
#endif

        /// <summary>
        /// Deletes the channel subtype config of a campaign. This API is idempotent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCampaignChannelSubtypeConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteCampaignChannelSubtypeConfig service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/DeleteCampaignChannelSubtypeConfig">REST API Reference for DeleteCampaignChannelSubtypeConfig Operation</seealso>
        Task<DeleteCampaignChannelSubtypeConfigResponse> DeleteCampaignChannelSubtypeConfigAsync(DeleteCampaignChannelSubtypeConfigRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Deletes the communication limits config for a campaign. This API is idempotent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCampaignCommunicationLimits service method.</param>
        /// <returns>The response from the DeleteCampaignCommunicationLimits service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InvalidCampaignStateException">
        /// The request could not be processed because of conflict in the current state of the
        /// campaign.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/DeleteCampaignCommunicationLimits">REST API Reference for DeleteCampaignCommunicationLimits Operation</seealso>
        DeleteCampaignCommunicationLimitsResponse DeleteCampaignCommunicationLimits(DeleteCampaignCommunicationLimitsRequest request);
#endif

        /// <summary>
        /// Deletes the communication limits config for a campaign. This API is idempotent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCampaignCommunicationLimits service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteCampaignCommunicationLimits service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InvalidCampaignStateException">
        /// The request could not be processed because of conflict in the current state of the
        /// campaign.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/DeleteCampaignCommunicationLimits">REST API Reference for DeleteCampaignCommunicationLimits Operation</seealso>
        Task<DeleteCampaignCommunicationLimitsResponse> DeleteCampaignCommunicationLimitsAsync(DeleteCampaignCommunicationLimitsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Deletes the communication time config for a campaign. This API is idempotent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCampaignCommunicationTime service method.</param>
        /// <returns>The response from the DeleteCampaignCommunicationTime service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InvalidCampaignStateException">
        /// The request could not be processed because of conflict in the current state of the
        /// campaign.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/DeleteCampaignCommunicationTime">REST API Reference for DeleteCampaignCommunicationTime Operation</seealso>
        DeleteCampaignCommunicationTimeResponse DeleteCampaignCommunicationTime(DeleteCampaignCommunicationTimeRequest request);
#endif

        /// <summary>
        /// Deletes the communication time config for a campaign. This API is idempotent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCampaignCommunicationTime service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteCampaignCommunicationTime service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InvalidCampaignStateException">
        /// The request could not be processed because of conflict in the current state of the
        /// campaign.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/DeleteCampaignCommunicationTime">REST API Reference for DeleteCampaignCommunicationTime Operation</seealso>
        Task<DeleteCampaignCommunicationTimeResponse> DeleteCampaignCommunicationTimeAsync(DeleteCampaignCommunicationTimeRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Deletes the entry limits config for a campaign. This API is idempotent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCampaignEntryLimits service method.</param>
        /// <returns>The response from the DeleteCampaignEntryLimits service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InvalidCampaignStateException">
        /// The request could not be processed because of conflict in the current state of the
        /// campaign.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/DeleteCampaignEntryLimits">REST API Reference for DeleteCampaignEntryLimits Operation</seealso>
        DeleteCampaignEntryLimitsResponse DeleteCampaignEntryLimits(DeleteCampaignEntryLimitsRequest request);
#endif

        /// <summary>
        /// Deletes the entry limits config for a campaign. This API is idempotent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCampaignEntryLimits service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteCampaignEntryLimits service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InvalidCampaignStateException">
        /// The request could not be processed because of conflict in the current state of the
        /// campaign.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/DeleteCampaignEntryLimits">REST API Reference for DeleteCampaignEntryLimits Operation</seealso>
        Task<DeleteCampaignEntryLimitsResponse> DeleteCampaignEntryLimitsAsync(DeleteCampaignEntryLimitsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Deletes a connect instance config from the specified AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnectInstanceConfig service method.</param>
        /// <returns>The response from the DeleteConnectInstanceConfig service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InvalidStateException">
        /// The request could not be processed because of conflict in the current state.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/DeleteConnectInstanceConfig">REST API Reference for DeleteConnectInstanceConfig Operation</seealso>
        DeleteConnectInstanceConfigResponse DeleteConnectInstanceConfig(DeleteConnectInstanceConfigRequest request);
#endif

        /// <summary>
        /// Deletes a connect instance config from the specified AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnectInstanceConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteConnectInstanceConfig service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InvalidStateException">
        /// The request could not be processed because of conflict in the current state.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/DeleteConnectInstanceConfig">REST API Reference for DeleteConnectInstanceConfig Operation</seealso>
        Task<DeleteConnectInstanceConfigResponse> DeleteConnectInstanceConfigAsync(DeleteConnectInstanceConfigRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Delete the integration for the specified Amazon Connect instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnectInstanceIntegration service method.</param>
        /// <returns>The response from the DeleteConnectInstanceIntegration service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/DeleteConnectInstanceIntegration">REST API Reference for DeleteConnectInstanceIntegration Operation</seealso>
        DeleteConnectInstanceIntegrationResponse DeleteConnectInstanceIntegration(DeleteConnectInstanceIntegrationRequest request);
#endif

        /// <summary>
        /// Delete the integration for the specified Amazon Connect instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnectInstanceIntegration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteConnectInstanceIntegration service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/DeleteConnectInstanceIntegration">REST API Reference for DeleteConnectInstanceIntegration Operation</seealso>
        Task<DeleteConnectInstanceIntegrationResponse> DeleteConnectInstanceIntegrationAsync(DeleteConnectInstanceIntegrationRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Delete the Connect Campaigns onboarding job for the specified Amazon Connect instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInstanceOnboardingJob service method.</param>
        /// <returns>The response from the DeleteInstanceOnboardingJob service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InvalidStateException">
        /// The request could not be processed because of conflict in the current state.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/DeleteInstanceOnboardingJob">REST API Reference for DeleteInstanceOnboardingJob Operation</seealso>
        DeleteInstanceOnboardingJobResponse DeleteInstanceOnboardingJob(DeleteInstanceOnboardingJobRequest request);
#endif

        /// <summary>
        /// Delete the Connect Campaigns onboarding job for the specified Amazon Connect instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInstanceOnboardingJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteInstanceOnboardingJob service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InvalidStateException">
        /// The request could not be processed because of conflict in the current state.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/DeleteInstanceOnboardingJob">REST API Reference for DeleteInstanceOnboardingJob Operation</seealso>
        Task<DeleteInstanceOnboardingJobResponse> DeleteInstanceOnboardingJobAsync(DeleteInstanceOnboardingJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Describes the specific campaign.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCampaign service method.</param>
        /// <returns>The response from the DescribeCampaign service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/DescribeCampaign">REST API Reference for DescribeCampaign Operation</seealso>
        DescribeCampaignResponse DescribeCampaign(DescribeCampaignRequest request);
#endif

        /// <summary>
        /// Describes the specific campaign.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCampaign service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DescribeCampaign service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/DescribeCampaign">REST API Reference for DescribeCampaign Operation</seealso>
        Task<DescribeCampaignResponse> DescribeCampaignAsync(DescribeCampaignRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Get state of a campaign for the specified Amazon Connect account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCampaignState service method.</param>
        /// <returns>The response from the GetCampaignState service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/GetCampaignState">REST API Reference for GetCampaignState Operation</seealso>
        GetCampaignStateResponse GetCampaignState(GetCampaignStateRequest request);
#endif

        /// <summary>
        /// Get state of a campaign for the specified Amazon Connect account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCampaignState service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetCampaignState service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/GetCampaignState">REST API Reference for GetCampaignState Operation</seealso>
        Task<GetCampaignStateResponse> GetCampaignStateAsync(GetCampaignStateRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Get state of campaigns for the specified Amazon Connect account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCampaignStateBatch service method.</param>
        /// <returns>The response from the GetCampaignStateBatch service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/GetCampaignStateBatch">REST API Reference for GetCampaignStateBatch Operation</seealso>
        GetCampaignStateBatchResponse GetCampaignStateBatch(GetCampaignStateBatchRequest request);
#endif

        /// <summary>
        /// Get state of campaigns for the specified Amazon Connect account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCampaignStateBatch service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetCampaignStateBatch service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/GetCampaignStateBatch">REST API Reference for GetCampaignStateBatch Operation</seealso>
        Task<GetCampaignStateBatchResponse> GetCampaignStateBatchAsync(GetCampaignStateBatchRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Get the specific Connect instance config.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConnectInstanceConfig service method.</param>
        /// <returns>The response from the GetConnectInstanceConfig service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/GetConnectInstanceConfig">REST API Reference for GetConnectInstanceConfig Operation</seealso>
        GetConnectInstanceConfigResponse GetConnectInstanceConfig(GetConnectInstanceConfigRequest request);
#endif

        /// <summary>
        /// Get the specific Connect instance config.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConnectInstanceConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetConnectInstanceConfig service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/GetConnectInstanceConfig">REST API Reference for GetConnectInstanceConfig Operation</seealso>
        Task<GetConnectInstanceConfigResponse> GetConnectInstanceConfigAsync(GetConnectInstanceConfigRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Get the instance communication limits.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInstanceCommunicationLimits service method.</param>
        /// <returns>The response from the GetInstanceCommunicationLimits service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/GetInstanceCommunicationLimits">REST API Reference for GetInstanceCommunicationLimits Operation</seealso>
        GetInstanceCommunicationLimitsResponse GetInstanceCommunicationLimits(GetInstanceCommunicationLimitsRequest request);
#endif

        /// <summary>
        /// Get the instance communication limits.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInstanceCommunicationLimits service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetInstanceCommunicationLimits service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/GetInstanceCommunicationLimits">REST API Reference for GetInstanceCommunicationLimits Operation</seealso>
        Task<GetInstanceCommunicationLimitsResponse> GetInstanceCommunicationLimitsAsync(GetInstanceCommunicationLimitsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Get the specific instance onboarding job status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInstanceOnboardingJobStatus service method.</param>
        /// <returns>The response from the GetInstanceOnboardingJobStatus service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/GetInstanceOnboardingJobStatus">REST API Reference for GetInstanceOnboardingJobStatus Operation</seealso>
        GetInstanceOnboardingJobStatusResponse GetInstanceOnboardingJobStatus(GetInstanceOnboardingJobStatusRequest request);
#endif

        /// <summary>
        /// Get the specific instance onboarding job status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInstanceOnboardingJobStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetInstanceOnboardingJobStatus service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/GetInstanceOnboardingJobStatus">REST API Reference for GetInstanceOnboardingJobStatus Operation</seealso>
        Task<GetInstanceOnboardingJobStatusResponse> GetInstanceOnboardingJobStatusAsync(GetInstanceOnboardingJobStatusRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Provides summary information about the campaigns under the specified Amazon Connect
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCampaigns service method.</param>
        /// <returns>The response from the ListCampaigns service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/ListCampaigns">REST API Reference for ListCampaigns Operation</seealso>
        ListCampaignsResponse ListCampaigns(ListCampaignsRequest request);
#endif

        /// <summary>
        /// Provides summary information about the campaigns under the specified Amazon Connect
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCampaigns service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListCampaigns service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/ListCampaigns">REST API Reference for ListCampaigns Operation</seealso>
        Task<ListCampaignsResponse> ListCampaignsAsync(ListCampaignsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Provides summary information about the integration under the specified Connect instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConnectInstanceIntegrations service method.</param>
        /// <returns>The response from the ListConnectInstanceIntegrations service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/ListConnectInstanceIntegrations">REST API Reference for ListConnectInstanceIntegrations Operation</seealso>
        ListConnectInstanceIntegrationsResponse ListConnectInstanceIntegrations(ListConnectInstanceIntegrationsRequest request);
#endif

        /// <summary>
        /// Provides summary information about the integration under the specified Connect instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConnectInstanceIntegrations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListConnectInstanceIntegrations service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/ListConnectInstanceIntegrations">REST API Reference for ListConnectInstanceIntegrations Operation</seealso>
        Task<ListConnectInstanceIntegrationsResponse> ListConnectInstanceIntegrationsAsync(ListConnectInstanceIntegrationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// List tags for a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <returns>The response from the ListTagsForResource service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);
#endif

        /// <summary>
        /// List tags for a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListTagsForResource service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Pauses a campaign for the specified Amazon Connect account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PauseCampaign service method.</param>
        /// <returns>The response from the PauseCampaign service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InvalidCampaignStateException">
        /// The request could not be processed because of conflict in the current state of the
        /// campaign.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/PauseCampaign">REST API Reference for PauseCampaign Operation</seealso>
        PauseCampaignResponse PauseCampaign(PauseCampaignRequest request);
#endif

        /// <summary>
        /// Pauses a campaign for the specified Amazon Connect account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PauseCampaign service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the PauseCampaign service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InvalidCampaignStateException">
        /// The request could not be processed because of conflict in the current state of the
        /// campaign.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/PauseCampaign">REST API Reference for PauseCampaign Operation</seealso>
        Task<PauseCampaignResponse> PauseCampaignAsync(PauseCampaignRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Put or update the integration for the specified Amazon Connect instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutConnectInstanceIntegration service method.</param>
        /// <returns>The response from the PutConnectInstanceIntegration service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/PutConnectInstanceIntegration">REST API Reference for PutConnectInstanceIntegration Operation</seealso>
        PutConnectInstanceIntegrationResponse PutConnectInstanceIntegration(PutConnectInstanceIntegrationRequest request);
#endif

        /// <summary>
        /// Put or update the integration for the specified Amazon Connect instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutConnectInstanceIntegration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the PutConnectInstanceIntegration service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/PutConnectInstanceIntegration">REST API Reference for PutConnectInstanceIntegration Operation</seealso>
        Task<PutConnectInstanceIntegrationResponse> PutConnectInstanceIntegrationAsync(PutConnectInstanceIntegrationRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Put the instance communication limits. This API is idempotent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutInstanceCommunicationLimits service method.</param>
        /// <returns>The response from the PutInstanceCommunicationLimits service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/PutInstanceCommunicationLimits">REST API Reference for PutInstanceCommunicationLimits Operation</seealso>
        PutInstanceCommunicationLimitsResponse PutInstanceCommunicationLimits(PutInstanceCommunicationLimitsRequest request);
#endif

        /// <summary>
        /// Put the instance communication limits. This API is idempotent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutInstanceCommunicationLimits service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the PutInstanceCommunicationLimits service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/PutInstanceCommunicationLimits">REST API Reference for PutInstanceCommunicationLimits Operation</seealso>
        Task<PutInstanceCommunicationLimitsResponse> PutInstanceCommunicationLimitsAsync(PutInstanceCommunicationLimitsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Creates outbound requests for the specified campaign Amazon Connect account. This
        /// API is idempotent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutOutboundRequestBatch service method.</param>
        /// <returns>The response from the PutOutboundRequestBatch service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InvalidCampaignStateException">
        /// The request could not be processed because of conflict in the current state of the
        /// campaign.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/PutOutboundRequestBatch">REST API Reference for PutOutboundRequestBatch Operation</seealso>
        PutOutboundRequestBatchResponse PutOutboundRequestBatch(PutOutboundRequestBatchRequest request);
#endif

        /// <summary>
        /// Creates outbound requests for the specified campaign Amazon Connect account. This
        /// API is idempotent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutOutboundRequestBatch service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the PutOutboundRequestBatch service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InvalidCampaignStateException">
        /// The request could not be processed because of conflict in the current state of the
        /// campaign.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/PutOutboundRequestBatch">REST API Reference for PutOutboundRequestBatch Operation</seealso>
        Task<PutOutboundRequestBatchResponse> PutOutboundRequestBatchAsync(PutOutboundRequestBatchRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Takes in a list of profile outbound requests to be placed as part of an outbound campaign.
        /// This API is idempotent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutProfileOutboundRequestBatch service method.</param>
        /// <returns>The response from the PutProfileOutboundRequestBatch service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InvalidCampaignStateException">
        /// The request could not be processed because of conflict in the current state of the
        /// campaign.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/PutProfileOutboundRequestBatch">REST API Reference for PutProfileOutboundRequestBatch Operation</seealso>
        PutProfileOutboundRequestBatchResponse PutProfileOutboundRequestBatch(PutProfileOutboundRequestBatchRequest request);
#endif

        /// <summary>
        /// Takes in a list of profile outbound requests to be placed as part of an outbound campaign.
        /// This API is idempotent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutProfileOutboundRequestBatch service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the PutProfileOutboundRequestBatch service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InvalidCampaignStateException">
        /// The request could not be processed because of conflict in the current state of the
        /// campaign.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/PutProfileOutboundRequestBatch">REST API Reference for PutProfileOutboundRequestBatch Operation</seealso>
        Task<PutProfileOutboundRequestBatchResponse> PutProfileOutboundRequestBatchAsync(PutProfileOutboundRequestBatchRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Stops a campaign for the specified Amazon Connect account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResumeCampaign service method.</param>
        /// <returns>The response from the ResumeCampaign service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InvalidCampaignStateException">
        /// The request could not be processed because of conflict in the current state of the
        /// campaign.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/ResumeCampaign">REST API Reference for ResumeCampaign Operation</seealso>
        ResumeCampaignResponse ResumeCampaign(ResumeCampaignRequest request);
#endif

        /// <summary>
        /// Stops a campaign for the specified Amazon Connect account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResumeCampaign service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ResumeCampaign service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InvalidCampaignStateException">
        /// The request could not be processed because of conflict in the current state of the
        /// campaign.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/ResumeCampaign">REST API Reference for ResumeCampaign Operation</seealso>
        Task<ResumeCampaignResponse> ResumeCampaignAsync(ResumeCampaignRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Starts a campaign for the specified Amazon Connect account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartCampaign service method.</param>
        /// <returns>The response from the StartCampaign service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InvalidCampaignStateException">
        /// The request could not be processed because of conflict in the current state of the
        /// campaign.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/StartCampaign">REST API Reference for StartCampaign Operation</seealso>
        StartCampaignResponse StartCampaign(StartCampaignRequest request);
#endif

        /// <summary>
        /// Starts a campaign for the specified Amazon Connect account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartCampaign service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the StartCampaign service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InvalidCampaignStateException">
        /// The request could not be processed because of conflict in the current state of the
        /// campaign.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/StartCampaign">REST API Reference for StartCampaign Operation</seealso>
        Task<StartCampaignResponse> StartCampaignAsync(StartCampaignRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Onboard the specific Amazon Connect instance to Connect Campaigns.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartInstanceOnboardingJob service method.</param>
        /// <returns>The response from the StartInstanceOnboardingJob service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/StartInstanceOnboardingJob">REST API Reference for StartInstanceOnboardingJob Operation</seealso>
        StartInstanceOnboardingJobResponse StartInstanceOnboardingJob(StartInstanceOnboardingJobRequest request);
#endif

        /// <summary>
        /// Onboard the specific Amazon Connect instance to Connect Campaigns.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartInstanceOnboardingJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the StartInstanceOnboardingJob service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/StartInstanceOnboardingJob">REST API Reference for StartInstanceOnboardingJob Operation</seealso>
        Task<StartInstanceOnboardingJobResponse> StartInstanceOnboardingJobAsync(StartInstanceOnboardingJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Stops a campaign for the specified Amazon Connect account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopCampaign service method.</param>
        /// <returns>The response from the StopCampaign service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InvalidCampaignStateException">
        /// The request could not be processed because of conflict in the current state of the
        /// campaign.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/StopCampaign">REST API Reference for StopCampaign Operation</seealso>
        StopCampaignResponse StopCampaign(StopCampaignRequest request);
#endif

        /// <summary>
        /// Stops a campaign for the specified Amazon Connect account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopCampaign service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the StopCampaign service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InvalidCampaignStateException">
        /// The request could not be processed because of conflict in the current state of the
        /// campaign.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/StopCampaign">REST API Reference for StopCampaign Operation</seealso>
        Task<StopCampaignResponse> StopCampaignAsync(StopCampaignRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Tag a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <returns>The response from the TagResource service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);
#endif

        /// <summary>
        /// Tag a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the TagResource service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Untag a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <returns>The response from the UntagResource service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);
#endif

        /// <summary>
        /// Untag a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UntagResource service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Updates the channel subtype config of a campaign. This API is idempotent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCampaignChannelSubtypeConfig service method.</param>
        /// <returns>The response from the UpdateCampaignChannelSubtypeConfig service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/UpdateCampaignChannelSubtypeConfig">REST API Reference for UpdateCampaignChannelSubtypeConfig Operation</seealso>
        UpdateCampaignChannelSubtypeConfigResponse UpdateCampaignChannelSubtypeConfig(UpdateCampaignChannelSubtypeConfigRequest request);
#endif

        /// <summary>
        /// Updates the channel subtype config of a campaign. This API is idempotent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCampaignChannelSubtypeConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateCampaignChannelSubtypeConfig service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/UpdateCampaignChannelSubtypeConfig">REST API Reference for UpdateCampaignChannelSubtypeConfig Operation</seealso>
        Task<UpdateCampaignChannelSubtypeConfigResponse> UpdateCampaignChannelSubtypeConfigAsync(UpdateCampaignChannelSubtypeConfigRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Updates the communication limits config for a campaign. This API is idempotent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCampaignCommunicationLimits service method.</param>
        /// <returns>The response from the UpdateCampaignCommunicationLimits service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InvalidCampaignStateException">
        /// The request could not be processed because of conflict in the current state of the
        /// campaign.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/UpdateCampaignCommunicationLimits">REST API Reference for UpdateCampaignCommunicationLimits Operation</seealso>
        UpdateCampaignCommunicationLimitsResponse UpdateCampaignCommunicationLimits(UpdateCampaignCommunicationLimitsRequest request);
#endif

        /// <summary>
        /// Updates the communication limits config for a campaign. This API is idempotent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCampaignCommunicationLimits service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateCampaignCommunicationLimits service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InvalidCampaignStateException">
        /// The request could not be processed because of conflict in the current state of the
        /// campaign.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/UpdateCampaignCommunicationLimits">REST API Reference for UpdateCampaignCommunicationLimits Operation</seealso>
        Task<UpdateCampaignCommunicationLimitsResponse> UpdateCampaignCommunicationLimitsAsync(UpdateCampaignCommunicationLimitsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Updates the communication time config for a campaign. This API is idempotent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCampaignCommunicationTime service method.</param>
        /// <returns>The response from the UpdateCampaignCommunicationTime service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InvalidCampaignStateException">
        /// The request could not be processed because of conflict in the current state of the
        /// campaign.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/UpdateCampaignCommunicationTime">REST API Reference for UpdateCampaignCommunicationTime Operation</seealso>
        UpdateCampaignCommunicationTimeResponse UpdateCampaignCommunicationTime(UpdateCampaignCommunicationTimeRequest request);
#endif

        /// <summary>
        /// Updates the communication time config for a campaign. This API is idempotent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCampaignCommunicationTime service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateCampaignCommunicationTime service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InvalidCampaignStateException">
        /// The request could not be processed because of conflict in the current state of the
        /// campaign.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/UpdateCampaignCommunicationTime">REST API Reference for UpdateCampaignCommunicationTime Operation</seealso>
        Task<UpdateCampaignCommunicationTimeResponse> UpdateCampaignCommunicationTimeAsync(UpdateCampaignCommunicationTimeRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Updates the entry limits config for a campaign. This API is idempotent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCampaignEntryLimits service method.</param>
        /// <returns>The response from the UpdateCampaignEntryLimits service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InvalidCampaignStateException">
        /// The request could not be processed because of conflict in the current state of the
        /// campaign.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/UpdateCampaignEntryLimits">REST API Reference for UpdateCampaignEntryLimits Operation</seealso>
        UpdateCampaignEntryLimitsResponse UpdateCampaignEntryLimits(UpdateCampaignEntryLimitsRequest request);
#endif

        /// <summary>
        /// Updates the entry limits config for a campaign. This API is idempotent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCampaignEntryLimits service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateCampaignEntryLimits service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InvalidCampaignStateException">
        /// The request could not be processed because of conflict in the current state of the
        /// campaign.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/UpdateCampaignEntryLimits">REST API Reference for UpdateCampaignEntryLimits Operation</seealso>
        Task<UpdateCampaignEntryLimitsResponse> UpdateCampaignEntryLimitsAsync(UpdateCampaignEntryLimitsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Updates the campaign flow associated with a campaign. This API is idempotent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCampaignFlowAssociation service method.</param>
        /// <returns>The response from the UpdateCampaignFlowAssociation service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InvalidCampaignStateException">
        /// The request could not be processed because of conflict in the current state of the
        /// campaign.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/UpdateCampaignFlowAssociation">REST API Reference for UpdateCampaignFlowAssociation Operation</seealso>
        UpdateCampaignFlowAssociationResponse UpdateCampaignFlowAssociation(UpdateCampaignFlowAssociationRequest request);
#endif

        /// <summary>
        /// Updates the campaign flow associated with a campaign. This API is idempotent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCampaignFlowAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateCampaignFlowAssociation service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InvalidCampaignStateException">
        /// The request could not be processed because of conflict in the current state of the
        /// campaign.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/UpdateCampaignFlowAssociation">REST API Reference for UpdateCampaignFlowAssociation Operation</seealso>
        Task<UpdateCampaignFlowAssociationResponse> UpdateCampaignFlowAssociationAsync(UpdateCampaignFlowAssociationRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Updates the name of a campaign. This API is idempotent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCampaignName service method.</param>
        /// <returns>The response from the UpdateCampaignName service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/UpdateCampaignName">REST API Reference for UpdateCampaignName Operation</seealso>
        UpdateCampaignNameResponse UpdateCampaignName(UpdateCampaignNameRequest request);
#endif

        /// <summary>
        /// Updates the name of a campaign. This API is idempotent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCampaignName service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateCampaignName service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/UpdateCampaignName">REST API Reference for UpdateCampaignName Operation</seealso>
        Task<UpdateCampaignNameResponse> UpdateCampaignNameAsync(UpdateCampaignNameRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Updates the schedule for a campaign. This API is idempotent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCampaignSchedule service method.</param>
        /// <returns>The response from the UpdateCampaignSchedule service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InvalidCampaignStateException">
        /// The request could not be processed because of conflict in the current state of the
        /// campaign.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/UpdateCampaignSchedule">REST API Reference for UpdateCampaignSchedule Operation</seealso>
        UpdateCampaignScheduleResponse UpdateCampaignSchedule(UpdateCampaignScheduleRequest request);
#endif

        /// <summary>
        /// Updates the schedule for a campaign. This API is idempotent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCampaignSchedule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateCampaignSchedule service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InvalidCampaignStateException">
        /// The request could not be processed because of conflict in the current state of the
        /// campaign.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/UpdateCampaignSchedule">REST API Reference for UpdateCampaignSchedule Operation</seealso>
        Task<UpdateCampaignScheduleResponse> UpdateCampaignScheduleAsync(UpdateCampaignScheduleRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Updates the campaign source with a campaign. This API is idempotent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCampaignSource service method.</param>
        /// <returns>The response from the UpdateCampaignSource service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InvalidCampaignStateException">
        /// The request could not be processed because of conflict in the current state of the
        /// campaign.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/UpdateCampaignSource">REST API Reference for UpdateCampaignSource Operation</seealso>
        UpdateCampaignSourceResponse UpdateCampaignSource(UpdateCampaignSourceRequest request);
#endif

        /// <summary>
        /// Updates the campaign source with a campaign. This API is idempotent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCampaignSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateCampaignSource service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InvalidCampaignStateException">
        /// The request could not be processed because of conflict in the current state of the
        /// campaign.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/UpdateCampaignSource">REST API Reference for UpdateCampaignSource Operation</seealso>
        Task<UpdateCampaignSourceResponse> UpdateCampaignSourceAsync(UpdateCampaignSourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);

#if NET8_0_OR_GREATER
        // Warning CA1033 is issued when the child types can not call the method defined in parent types.
        // In this use case the intended caller is only meant to be the interface as a factory
        // method to create the child types. Given the SDK use case the warning can be ignored.
#pragma warning disable CA1033
        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonConnectCampaignsV2Config))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonConnectCampaignsV2Config();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
            Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonConnectCampaignsV2Config;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonConnectCampaignsV2Config to create AmazonConnectCampaignsV2Client");
            }

            return awsCredentials == null ?
                    new AmazonConnectCampaignsV2Client(serviceClientConfig) :
                    new AmazonConnectCampaignsV2Client(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
    }
}
