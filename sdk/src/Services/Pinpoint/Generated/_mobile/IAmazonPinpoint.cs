/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Pinpoint.Model;

namespace Amazon.Pinpoint
{
    /// <summary>
    /// Interface for accessing Pinpoint
    ///
    /// Doc Engage API - Amazon Pinpoint API
    /// </summary>
    public partial interface IAmazonPinpoint : IAmazonService, IDisposable
    {
                
        #region  CreateApp



        /// <summary>
        /// Creates an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApp service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateApp service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        Task<CreateAppResponse> CreateAppAsync(CreateAppRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateCampaign



        /// <summary>
        /// Creates a new campaign for an application or updates the settings of an existing campaign
        /// for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCampaign service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCampaign service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        Task<CreateCampaignResponse> CreateCampaignAsync(CreateCampaignRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateEmailTemplate



        /// <summary>
        /// Creates a message template that you can use in messages that are sent through the
        /// email channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEmailTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateEmailTemplate service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        Task<CreateEmailTemplateResponse> CreateEmailTemplateAsync(CreateEmailTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateExportJob



        /// <summary>
        /// Creates an export job for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateExportJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateExportJob service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        Task<CreateExportJobResponse> CreateExportJobAsync(CreateExportJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateImportJob



        /// <summary>
        /// Creates an import job for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateImportJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateImportJob service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        Task<CreateImportJobResponse> CreateImportJobAsync(CreateImportJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateJourney



        /// <summary>
        /// Creates a journey for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateJourney service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateJourney service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        Task<CreateJourneyResponse> CreateJourneyAsync(CreateJourneyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreatePushTemplate



        /// <summary>
        /// Creates a message template that you can use in messages that are sent through a push
        /// notification channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePushTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePushTemplate service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        Task<CreatePushTemplateResponse> CreatePushTemplateAsync(CreatePushTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateSegment



        /// <summary>
        /// Creates a new segment for an application or updates the configuration, dimension,
        /// and other settings for an existing segment that's associated with an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSegment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSegment service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        Task<CreateSegmentResponse> CreateSegmentAsync(CreateSegmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateSmsTemplate



        /// <summary>
        /// Creates a message template that you can use in messages that are sent through the
        /// SMS channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSmsTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSmsTemplate service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        Task<CreateSmsTemplateResponse> CreateSmsTemplateAsync(CreateSmsTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateVoiceTemplate



        /// <summary>
        /// Creates a message template that you can use in messages that are sent through the
        /// voice channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVoiceTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateVoiceTemplate service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        Task<CreateVoiceTemplateResponse> CreateVoiceTemplateAsync(CreateVoiceTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteAdmChannel



        /// <summary>
        /// Disables the ADM channel for an application and deletes any existing settings for
        /// the channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAdmChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAdmChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        Task<DeleteAdmChannelResponse> DeleteAdmChannelAsync(DeleteAdmChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteApnsChannel



        /// <summary>
        /// Disables the APNs channel for an application and deletes any existing settings for
        /// the channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApnsChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteApnsChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        Task<DeleteApnsChannelResponse> DeleteApnsChannelAsync(DeleteApnsChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteApnsSandboxChannel



        /// <summary>
        /// Disables the APNs sandbox channel for an application and deletes any existing settings
        /// for the channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApnsSandboxChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteApnsSandboxChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        Task<DeleteApnsSandboxChannelResponse> DeleteApnsSandboxChannelAsync(DeleteApnsSandboxChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteApnsVoipChannel



        /// <summary>
        /// Disables the APNs VoIP channel for an application and deletes any existing settings
        /// for the channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApnsVoipChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteApnsVoipChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        Task<DeleteApnsVoipChannelResponse> DeleteApnsVoipChannelAsync(DeleteApnsVoipChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteApnsVoipSandboxChannel



        /// <summary>
        /// Disables the APNs VoIP sandbox channel for an application and deletes any existing
        /// settings for the channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApnsVoipSandboxChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteApnsVoipSandboxChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        Task<DeleteApnsVoipSandboxChannelResponse> DeleteApnsVoipSandboxChannelAsync(DeleteApnsVoipSandboxChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteApp



        /// <summary>
        /// Deletes an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApp service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteApp service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        Task<DeleteAppResponse> DeleteAppAsync(DeleteAppRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteBaiduChannel



        /// <summary>
        /// Disables the Baidu channel for an application and deletes any existing settings for
        /// the channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBaiduChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteBaiduChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        Task<DeleteBaiduChannelResponse> DeleteBaiduChannelAsync(DeleteBaiduChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteCampaign



        /// <summary>
        /// Deletes a campaign from an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCampaign service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCampaign service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        Task<DeleteCampaignResponse> DeleteCampaignAsync(DeleteCampaignRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteEmailChannel



        /// <summary>
        /// Disables the email channel for an application and deletes any existing settings for
        /// the channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEmailChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteEmailChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        Task<DeleteEmailChannelResponse> DeleteEmailChannelAsync(DeleteEmailChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteEmailTemplate



        /// <summary>
        /// Deletes a message template that was designed for use in messages that were sent through
        /// the email channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEmailTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteEmailTemplate service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        Task<DeleteEmailTemplateResponse> DeleteEmailTemplateAsync(DeleteEmailTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteEndpoint



        /// <summary>
        /// Deletes an endpoint from an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteEndpoint service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        Task<DeleteEndpointResponse> DeleteEndpointAsync(DeleteEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteEventStream



        /// <summary>
        /// Deletes the event stream for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventStream service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteEventStream service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        Task<DeleteEventStreamResponse> DeleteEventStreamAsync(DeleteEventStreamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteGcmChannel



        /// <summary>
        /// Disables the GCM channel for an application and deletes any existing settings for
        /// the channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGcmChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteGcmChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        Task<DeleteGcmChannelResponse> DeleteGcmChannelAsync(DeleteGcmChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteJourney



        /// <summary>
        /// Deletes a journey from an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteJourney service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteJourney service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        Task<DeleteJourneyResponse> DeleteJourneyAsync(DeleteJourneyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeletePushTemplate



        /// <summary>
        /// Deletes a message template that was designed for use in messages that were sent through
        /// a push notification channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePushTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeletePushTemplate service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        Task<DeletePushTemplateResponse> DeletePushTemplateAsync(DeletePushTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteSegment



        /// <summary>
        /// Deletes a segment from an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSegment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSegment service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        Task<DeleteSegmentResponse> DeleteSegmentAsync(DeleteSegmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteSmsChannel



        /// <summary>
        /// Disables the SMS channel for an application and deletes any existing settings for
        /// the channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSmsChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSmsChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        Task<DeleteSmsChannelResponse> DeleteSmsChannelAsync(DeleteSmsChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteSmsTemplate



        /// <summary>
        /// Deletes a message template that was designed for use in messages that were sent through
        /// the SMS channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSmsTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSmsTemplate service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        Task<DeleteSmsTemplateResponse> DeleteSmsTemplateAsync(DeleteSmsTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteUserEndpoints



        /// <summary>
        /// Deletes all the endpoints that are associated with a specific user ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserEndpoints service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteUserEndpoints service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        Task<DeleteUserEndpointsResponse> DeleteUserEndpointsAsync(DeleteUserEndpointsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteVoiceChannel



        /// <summary>
        /// Disables the voice channel for an application and deletes any existing settings for
        /// the channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVoiceChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteVoiceChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        Task<DeleteVoiceChannelResponse> DeleteVoiceChannelAsync(DeleteVoiceChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteVoiceTemplate



        /// <summary>
        /// Deletes a message template that was designed for use in messages that were sent through
        /// the voice channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVoiceTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteVoiceTemplate service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        Task<DeleteVoiceTemplateResponse> DeleteVoiceTemplateAsync(DeleteVoiceTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetAdmChannel



        /// <summary>
        /// Retrieves information about the status and settings of the ADM channel for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAdmChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAdmChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        Task<GetAdmChannelResponse> GetAdmChannelAsync(GetAdmChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetApnsChannel



        /// <summary>
        /// Retrieves information about the status and settings of the APNs channel for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApnsChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetApnsChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        Task<GetApnsChannelResponse> GetApnsChannelAsync(GetApnsChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetApnsSandboxChannel



        /// <summary>
        /// Retrieves information about the status and settings of the APNs sandbox channel for
        /// an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApnsSandboxChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetApnsSandboxChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        Task<GetApnsSandboxChannelResponse> GetApnsSandboxChannelAsync(GetApnsSandboxChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetApnsVoipChannel



        /// <summary>
        /// Retrieves information about the status and settings of the APNs VoIP channel for an
        /// application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApnsVoipChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetApnsVoipChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        Task<GetApnsVoipChannelResponse> GetApnsVoipChannelAsync(GetApnsVoipChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetApnsVoipSandboxChannel



        /// <summary>
        /// Retrieves information about the status and settings of the APNs VoIP sandbox channel
        /// for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApnsVoipSandboxChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetApnsVoipSandboxChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        Task<GetApnsVoipSandboxChannelResponse> GetApnsVoipSandboxChannelAsync(GetApnsVoipSandboxChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetApp



        /// <summary>
        /// Retrieves information about an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApp service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetApp service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        Task<GetAppResponse> GetAppAsync(GetAppRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetApplicationDateRangeKpi



        /// <summary>
        /// Retrieves (queries) pre-aggregated data for a standard metric that applies to an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApplicationDateRangeKpi service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetApplicationDateRangeKpi service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        Task<GetApplicationDateRangeKpiResponse> GetApplicationDateRangeKpiAsync(GetApplicationDateRangeKpiRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetApplicationSettings



        /// <summary>
        /// Retrieves information about the settings for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApplicationSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetApplicationSettings service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        Task<GetApplicationSettingsResponse> GetApplicationSettingsAsync(GetApplicationSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetApps



        /// <summary>
        /// Retrieves information about all of your applications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApps service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetApps service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        Task<GetAppsResponse> GetAppsAsync(GetAppsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetBaiduChannel



        /// <summary>
        /// Retrieves information about the status and settings of the Baidu channel for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBaiduChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBaiduChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        Task<GetBaiduChannelResponse> GetBaiduChannelAsync(GetBaiduChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetCampaign



        /// <summary>
        /// Retrieves information about the status, configuration, and other settings for a campaign.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCampaign service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCampaign service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        Task<GetCampaignResponse> GetCampaignAsync(GetCampaignRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetCampaignActivities



        /// <summary>
        /// Retrieves information about all the activities for a campaign.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCampaignActivities service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCampaignActivities service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        Task<GetCampaignActivitiesResponse> GetCampaignActivitiesAsync(GetCampaignActivitiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetCampaignDateRangeKpi



        /// <summary>
        /// Retrieves (queries) pre-aggregated data for a standard metric that applies to a campaign.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCampaignDateRangeKpi service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCampaignDateRangeKpi service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        Task<GetCampaignDateRangeKpiResponse> GetCampaignDateRangeKpiAsync(GetCampaignDateRangeKpiRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetCampaigns



        /// <summary>
        /// Retrieves information about the status, configuration, and other settings for all
        /// the campaigns that are associated with an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCampaigns service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCampaigns service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        Task<GetCampaignsResponse> GetCampaignsAsync(GetCampaignsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetCampaignVersion



        /// <summary>
        /// Retrieves information about the status, configuration, and other settings for a specific
        /// version of a campaign.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCampaignVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCampaignVersion service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        Task<GetCampaignVersionResponse> GetCampaignVersionAsync(GetCampaignVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetCampaignVersions



        /// <summary>
        /// Retrieves information about the status, configuration, and other settings for all
        /// versions of a campaign.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCampaignVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCampaignVersions service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        Task<GetCampaignVersionsResponse> GetCampaignVersionsAsync(GetCampaignVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetChannels



        /// <summary>
        /// Retrieves information about the history and status of each channel for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetChannels service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetChannels service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        Task<GetChannelsResponse> GetChannelsAsync(GetChannelsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetEmailChannel



        /// <summary>
        /// Retrieves information about the status and settings of the email channel for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEmailChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEmailChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        Task<GetEmailChannelResponse> GetEmailChannelAsync(GetEmailChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetEmailTemplate



        /// <summary>
        /// Retrieves the content and settings for a message template that you can use in messages
        /// that are sent through the email channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEmailTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEmailTemplate service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        Task<GetEmailTemplateResponse> GetEmailTemplateAsync(GetEmailTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetEndpoint



        /// <summary>
        /// Retrieves information about the settings and attributes of a specific endpoint for
        /// an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEndpoint service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        Task<GetEndpointResponse> GetEndpointAsync(GetEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetEventStream



        /// <summary>
        /// Retrieves information about the event stream settings for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEventStream service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEventStream service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        Task<GetEventStreamResponse> GetEventStreamAsync(GetEventStreamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetExportJob



        /// <summary>
        /// Retrieves information about the status and settings of a specific export job for an
        /// application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetExportJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetExportJob service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        Task<GetExportJobResponse> GetExportJobAsync(GetExportJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetExportJobs



        /// <summary>
        /// Retrieves information about the status and settings of all the export jobs for an
        /// application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetExportJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetExportJobs service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        Task<GetExportJobsResponse> GetExportJobsAsync(GetExportJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetGcmChannel



        /// <summary>
        /// Retrieves information about the status and settings of the GCM channel for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGcmChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetGcmChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        Task<GetGcmChannelResponse> GetGcmChannelAsync(GetGcmChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetImportJob



        /// <summary>
        /// Retrieves information about the status and settings of a specific import job for an
        /// application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetImportJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetImportJob service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        Task<GetImportJobResponse> GetImportJobAsync(GetImportJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetImportJobs



        /// <summary>
        /// Retrieves information about the status and settings of all the import jobs for an
        /// application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetImportJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetImportJobs service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        Task<GetImportJobsResponse> GetImportJobsAsync(GetImportJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetJourney



        /// <summary>
        /// Retrieves information about the status, configuration, and other settings for a journey.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetJourney service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetJourney service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        Task<GetJourneyResponse> GetJourneyAsync(GetJourneyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetJourneyDateRangeKpi



        /// <summary>
        /// Retrieves (queries) pre-aggregated data for a standard engagement metric that applies
        /// to a journey.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetJourneyDateRangeKpi service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetJourneyDateRangeKpi service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        Task<GetJourneyDateRangeKpiResponse> GetJourneyDateRangeKpiAsync(GetJourneyDateRangeKpiRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetJourneyExecutionActivityMetrics



        /// <summary>
        /// Retrieves (queries) pre-aggregated data for a standard execution metric that applies
        /// to a journey activity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetJourneyExecutionActivityMetrics service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetJourneyExecutionActivityMetrics service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        Task<GetJourneyExecutionActivityMetricsResponse> GetJourneyExecutionActivityMetricsAsync(GetJourneyExecutionActivityMetricsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetJourneyExecutionMetrics



        /// <summary>
        /// Retrieves (queries) pre-aggregated data for a standard execution metric that applies
        /// to a journey.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetJourneyExecutionMetrics service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetJourneyExecutionMetrics service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        Task<GetJourneyExecutionMetricsResponse> GetJourneyExecutionMetricsAsync(GetJourneyExecutionMetricsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetPushTemplate



        /// <summary>
        /// Retrieves the content and settings for a message template that you can use in messages
        /// that are sent through a push notification channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPushTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPushTemplate service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        Task<GetPushTemplateResponse> GetPushTemplateAsync(GetPushTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetSegment



        /// <summary>
        /// Retrieves information about the configuration, dimension, and other settings for a
        /// specific segment that's associated with an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSegment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSegment service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        Task<GetSegmentResponse> GetSegmentAsync(GetSegmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetSegmentExportJobs



        /// <summary>
        /// Retrieves information about the status and settings of the export jobs for a segment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSegmentExportJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSegmentExportJobs service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        Task<GetSegmentExportJobsResponse> GetSegmentExportJobsAsync(GetSegmentExportJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetSegmentImportJobs



        /// <summary>
        /// Retrieves information about the status and settings of the import jobs for a segment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSegmentImportJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSegmentImportJobs service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        Task<GetSegmentImportJobsResponse> GetSegmentImportJobsAsync(GetSegmentImportJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetSegments



        /// <summary>
        /// Retrieves information about the configuration, dimension, and other settings for all
        /// the segments that are associated with an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSegments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSegments service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        Task<GetSegmentsResponse> GetSegmentsAsync(GetSegmentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetSegmentVersion



        /// <summary>
        /// Retrieves information about the configuration, dimension, and other settings for a
        /// specific version of a segment that's associated with an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSegmentVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSegmentVersion service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        Task<GetSegmentVersionResponse> GetSegmentVersionAsync(GetSegmentVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetSegmentVersions



        /// <summary>
        /// Retrieves information about the configuration, dimension, and other settings for all
        /// versions of a specific segment that's associated with an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSegmentVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSegmentVersions service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        Task<GetSegmentVersionsResponse> GetSegmentVersionsAsync(GetSegmentVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetSmsChannel



        /// <summary>
        /// Retrieves information about the status and settings of the SMS channel for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSmsChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSmsChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        Task<GetSmsChannelResponse> GetSmsChannelAsync(GetSmsChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetSmsTemplate



        /// <summary>
        /// Retrieves the content and settings for a message template that you can use in messages
        /// that are sent through the SMS channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSmsTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSmsTemplate service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        Task<GetSmsTemplateResponse> GetSmsTemplateAsync(GetSmsTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetUserEndpoints



        /// <summary>
        /// Retrieves information about all the endpoints that are associated with a specific
        /// user ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUserEndpoints service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetUserEndpoints service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        Task<GetUserEndpointsResponse> GetUserEndpointsAsync(GetUserEndpointsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetVoiceChannel



        /// <summary>
        /// Retrieves information about the status and settings of the voice channel for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetVoiceChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        Task<GetVoiceChannelResponse> GetVoiceChannelAsync(GetVoiceChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetVoiceTemplate



        /// <summary>
        /// Retrieves the content and settings for a message template that you can use in messages
        /// that are sent through the voice channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetVoiceTemplate service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        Task<GetVoiceTemplateResponse> GetVoiceTemplateAsync(GetVoiceTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListJourneys



        /// <summary>
        /// Retrieves information about the status, configuration, and other settings for all
        /// the journeys that are associated with an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListJourneys service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListJourneys service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        Task<ListJourneysResponse> ListJourneysAsync(ListJourneysRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource



        /// <summary>
        /// Retrieves all the tags (keys and values) that are associated with an application,
        /// campaign, journey, message template, or segment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Pinpoint.</returns>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTemplates



        /// <summary>
        /// Retrieves information about all the message templates that are associated with your
        /// Amazon Pinpoint account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTemplates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTemplates service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        Task<ListTemplatesResponse> ListTemplatesAsync(ListTemplatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PhoneNumberValidate



        /// <summary>
        /// Retrieves information about a phone number.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PhoneNumberValidate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PhoneNumberValidate service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        Task<PhoneNumberValidateResponse> PhoneNumberValidateAsync(PhoneNumberValidateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutEvents



        /// <summary>
        /// Creates a new event to record for endpoints, or creates or updates endpoint data that
        /// existing events are associated with.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutEvents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutEvents service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        Task<PutEventsResponse> PutEventsAsync(PutEventsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutEventStream



        /// <summary>
        /// Creates a new event stream for an application or updates the settings of an existing
        /// event stream for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutEventStream service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutEventStream service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        Task<PutEventStreamResponse> PutEventStreamAsync(PutEventStreamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RemoveAttributes



        /// <summary>
        /// Removes one or more attributes, of the same attribute type, from all the endpoints
        /// that are associated with an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RemoveAttributes service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        Task<RemoveAttributesResponse> RemoveAttributesAsync(RemoveAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SendMessages



        /// <summary>
        /// Creates and sends a direct message.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendMessages service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SendMessages service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        Task<SendMessagesResponse> SendMessagesAsync(SendMessagesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SendUsersMessages



        /// <summary>
        /// Creates and sends a message to a list of users.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendUsersMessages service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SendUsersMessages service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        Task<SendUsersMessagesResponse> SendUsersMessagesAsync(SendUsersMessagesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource



        /// <summary>
        /// Adds one or more tags (keys and values) to an application, campaign, journey, message
        /// template, or segment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Pinpoint.</returns>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource



        /// <summary>
        /// Removes one or more tags (keys and values) from an application, campaign, journey,
        /// message template, or segment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Pinpoint.</returns>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateAdmChannel



        /// <summary>
        /// Enables the ADM channel for an application or updates the status and settings of the
        /// ADM channel for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAdmChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAdmChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        Task<UpdateAdmChannelResponse> UpdateAdmChannelAsync(UpdateAdmChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateApnsChannel



        /// <summary>
        /// Enables the APNs channel for an application or updates the status and settings of
        /// the APNs channel for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApnsChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateApnsChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        Task<UpdateApnsChannelResponse> UpdateApnsChannelAsync(UpdateApnsChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateApnsSandboxChannel



        /// <summary>
        /// Enables the APNs sandbox channel for an application or updates the status and settings
        /// of the APNs sandbox channel for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApnsSandboxChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateApnsSandboxChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        Task<UpdateApnsSandboxChannelResponse> UpdateApnsSandboxChannelAsync(UpdateApnsSandboxChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateApnsVoipChannel



        /// <summary>
        /// Enables the APNs VoIP channel for an application or updates the status and settings
        /// of the APNs VoIP channel for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApnsVoipChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateApnsVoipChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        Task<UpdateApnsVoipChannelResponse> UpdateApnsVoipChannelAsync(UpdateApnsVoipChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateApnsVoipSandboxChannel



        /// <summary>
        /// Enables the APNs VoIP sandbox channel for an application or updates the status and
        /// settings of the APNs VoIP sandbox channel for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApnsVoipSandboxChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateApnsVoipSandboxChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        Task<UpdateApnsVoipSandboxChannelResponse> UpdateApnsVoipSandboxChannelAsync(UpdateApnsVoipSandboxChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateApplicationSettings



        /// <summary>
        /// Updates the settings for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplicationSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateApplicationSettings service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        Task<UpdateApplicationSettingsResponse> UpdateApplicationSettingsAsync(UpdateApplicationSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateBaiduChannel



        /// <summary>
        /// Enables the Baidu channel for an application or updates the status and settings of
        /// the Baidu channel for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBaiduChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateBaiduChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        Task<UpdateBaiduChannelResponse> UpdateBaiduChannelAsync(UpdateBaiduChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateCampaign



        /// <summary>
        /// Updates the configuration and other settings for a campaign.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCampaign service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateCampaign service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        Task<UpdateCampaignResponse> UpdateCampaignAsync(UpdateCampaignRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateEmailChannel



        /// <summary>
        /// Enables the email channel for an application or updates the status and settings of
        /// the email channel for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEmailChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateEmailChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        Task<UpdateEmailChannelResponse> UpdateEmailChannelAsync(UpdateEmailChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateEmailTemplate



        /// <summary>
        /// Updates an existing message template that you can use in messages that are sent through
        /// the email channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEmailTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateEmailTemplate service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        Task<UpdateEmailTemplateResponse> UpdateEmailTemplateAsync(UpdateEmailTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateEndpoint



        /// <summary>
        /// Creates a new endpoint for an application or updates the settings and attributes of
        /// an existing endpoint for an application. You can also use this operation to define
        /// custom attributes (Attributes, Metrics, and UserAttributes properties) for an endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateEndpoint service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        Task<UpdateEndpointResponse> UpdateEndpointAsync(UpdateEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateEndpointsBatch



        /// <summary>
        /// Creates a new batch of endpoints for an application or updates the settings and attributes
        /// of a batch of existing endpoints for an application. You can also use this operation
        /// to define custom attributes (Attributes, Metrics, and UserAttributes properties) for
        /// a batch of endpoints.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEndpointsBatch service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateEndpointsBatch service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        Task<UpdateEndpointsBatchResponse> UpdateEndpointsBatchAsync(UpdateEndpointsBatchRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateGcmChannel



        /// <summary>
        /// Enables the GCM channel for an application or updates the status and settings of the
        /// GCM channel for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGcmChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateGcmChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        Task<UpdateGcmChannelResponse> UpdateGcmChannelAsync(UpdateGcmChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateJourney



        /// <summary>
        /// Updates the configuration and other settings for a journey.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateJourney service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateJourney service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        Task<UpdateJourneyResponse> UpdateJourneyAsync(UpdateJourneyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateJourneyState



        /// <summary>
        /// Cancels an active journey.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateJourneyState service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateJourneyState service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        Task<UpdateJourneyStateResponse> UpdateJourneyStateAsync(UpdateJourneyStateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdatePushTemplate



        /// <summary>
        /// Updates an existing message template that you can use in messages that are sent through
        /// a push notification channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePushTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdatePushTemplate service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        Task<UpdatePushTemplateResponse> UpdatePushTemplateAsync(UpdatePushTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateSegment



        /// <summary>
        /// Creates a new segment for an application or updates the configuration, dimension,
        /// and other settings for an existing segment that's associated with an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSegment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSegment service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        Task<UpdateSegmentResponse> UpdateSegmentAsync(UpdateSegmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateSmsChannel



        /// <summary>
        /// Enables the SMS channel for an application or updates the status and settings of the
        /// SMS channel for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSmsChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSmsChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        Task<UpdateSmsChannelResponse> UpdateSmsChannelAsync(UpdateSmsChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateSmsTemplate



        /// <summary>
        /// Updates an existing message template that you can use in messages that are sent through
        /// the SMS channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSmsTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSmsTemplate service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        Task<UpdateSmsTemplateResponse> UpdateSmsTemplateAsync(UpdateSmsTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateVoiceChannel



        /// <summary>
        /// Enables the voice channel for an application or updates the status and settings of
        /// the voice channel for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateVoiceChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateVoiceChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        Task<UpdateVoiceChannelResponse> UpdateVoiceChannelAsync(UpdateVoiceChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateVoiceTemplate



        /// <summary>
        /// Updates an existing message template that you can use in messages that are sent through
        /// the voice channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateVoiceTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateVoiceTemplate service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        Task<UpdateVoiceTemplateResponse> UpdateVoiceTemplateAsync(UpdateVoiceTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}