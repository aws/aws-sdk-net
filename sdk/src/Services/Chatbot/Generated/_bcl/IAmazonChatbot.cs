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
 * Do not modify this file. This file is generated from the chatbot-2017-10-11.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Chatbot.Model;

namespace Amazon.Chatbot
{
    /// <summary>
    /// <para>Interface for accessing Chatbot</para>
    ///
    /// AWS Chatbot API
    /// </summary>
    public partial interface IAmazonChatbot : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        IChatbotPaginatorFactory Paginators { get; }

        
        #region  CreateChimeWebhookConfiguration


        /// <summary>
        /// Creates Chime Webhook Configuration
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateChimeWebhookConfiguration service method.</param>
        /// 
        /// <returns>The response from the CreateChimeWebhookConfiguration service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.ConflictException">
        /// There was an issue processing your request.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.CreateChimeWebhookConfigurationException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.LimitExceededException">
        /// You have exceeded a service limit for AWS Chatbot.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/CreateChimeWebhookConfiguration">REST API Reference for CreateChimeWebhookConfiguration Operation</seealso>
        CreateChimeWebhookConfigurationResponse CreateChimeWebhookConfiguration(CreateChimeWebhookConfigurationRequest request);



        /// <summary>
        /// Creates Chime Webhook Configuration
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateChimeWebhookConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateChimeWebhookConfiguration service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.ConflictException">
        /// There was an issue processing your request.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.CreateChimeWebhookConfigurationException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.LimitExceededException">
        /// You have exceeded a service limit for AWS Chatbot.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/CreateChimeWebhookConfiguration">REST API Reference for CreateChimeWebhookConfiguration Operation</seealso>
        Task<CreateChimeWebhookConfigurationResponse> CreateChimeWebhookConfigurationAsync(CreateChimeWebhookConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateMicrosoftTeamsChannelConfiguration


        /// <summary>
        /// Creates MS Teams Channel Configuration
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMicrosoftTeamsChannelConfiguration service method.</param>
        /// 
        /// <returns>The response from the CreateMicrosoftTeamsChannelConfiguration service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.ConflictException">
        /// There was an issue processing your request.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.CreateTeamsChannelConfigurationException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.LimitExceededException">
        /// You have exceeded a service limit for AWS Chatbot.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/CreateMicrosoftTeamsChannelConfiguration">REST API Reference for CreateMicrosoftTeamsChannelConfiguration Operation</seealso>
        CreateMicrosoftTeamsChannelConfigurationResponse CreateMicrosoftTeamsChannelConfiguration(CreateMicrosoftTeamsChannelConfigurationRequest request);



        /// <summary>
        /// Creates MS Teams Channel Configuration
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMicrosoftTeamsChannelConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateMicrosoftTeamsChannelConfiguration service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.ConflictException">
        /// There was an issue processing your request.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.CreateTeamsChannelConfigurationException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.LimitExceededException">
        /// You have exceeded a service limit for AWS Chatbot.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/CreateMicrosoftTeamsChannelConfiguration">REST API Reference for CreateMicrosoftTeamsChannelConfiguration Operation</seealso>
        Task<CreateMicrosoftTeamsChannelConfigurationResponse> CreateMicrosoftTeamsChannelConfigurationAsync(CreateMicrosoftTeamsChannelConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateSlackChannelConfiguration


        /// <summary>
        /// Creates Slack Channel Configuration
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSlackChannelConfiguration service method.</param>
        /// 
        /// <returns>The response from the CreateSlackChannelConfiguration service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.ConflictException">
        /// There was an issue processing your request.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.CreateSlackChannelConfigurationException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.LimitExceededException">
        /// You have exceeded a service limit for AWS Chatbot.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/CreateSlackChannelConfiguration">REST API Reference for CreateSlackChannelConfiguration Operation</seealso>
        CreateSlackChannelConfigurationResponse CreateSlackChannelConfiguration(CreateSlackChannelConfigurationRequest request);



        /// <summary>
        /// Creates Slack Channel Configuration
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSlackChannelConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSlackChannelConfiguration service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.ConflictException">
        /// There was an issue processing your request.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.CreateSlackChannelConfigurationException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.LimitExceededException">
        /// You have exceeded a service limit for AWS Chatbot.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/CreateSlackChannelConfiguration">REST API Reference for CreateSlackChannelConfiguration Operation</seealso>
        Task<CreateSlackChannelConfigurationResponse> CreateSlackChannelConfigurationAsync(CreateSlackChannelConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteChimeWebhookConfiguration


        /// <summary>
        /// Deletes a Chime Webhook Configuration
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteChimeWebhookConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteChimeWebhookConfiguration service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.DeleteChimeWebhookConfigurationException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.ResourceNotFoundException">
        /// We were not able to find the resource for your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/DeleteChimeWebhookConfiguration">REST API Reference for DeleteChimeWebhookConfiguration Operation</seealso>
        DeleteChimeWebhookConfigurationResponse DeleteChimeWebhookConfiguration(DeleteChimeWebhookConfigurationRequest request);



        /// <summary>
        /// Deletes a Chime Webhook Configuration
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteChimeWebhookConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteChimeWebhookConfiguration service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.DeleteChimeWebhookConfigurationException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.ResourceNotFoundException">
        /// We were not able to find the resource for your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/DeleteChimeWebhookConfiguration">REST API Reference for DeleteChimeWebhookConfiguration Operation</seealso>
        Task<DeleteChimeWebhookConfigurationResponse> DeleteChimeWebhookConfigurationAsync(DeleteChimeWebhookConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteMicrosoftTeamsChannelConfiguration


        /// <summary>
        /// Deletes MS Teams Channel Configuration
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMicrosoftTeamsChannelConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteMicrosoftTeamsChannelConfiguration service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.DeleteTeamsChannelConfigurationException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.ResourceNotFoundException">
        /// We were not able to find the resource for your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/DeleteMicrosoftTeamsChannelConfiguration">REST API Reference for DeleteMicrosoftTeamsChannelConfiguration Operation</seealso>
        DeleteMicrosoftTeamsChannelConfigurationResponse DeleteMicrosoftTeamsChannelConfiguration(DeleteMicrosoftTeamsChannelConfigurationRequest request);



        /// <summary>
        /// Deletes MS Teams Channel Configuration
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMicrosoftTeamsChannelConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteMicrosoftTeamsChannelConfiguration service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.DeleteTeamsChannelConfigurationException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.ResourceNotFoundException">
        /// We were not able to find the resource for your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/DeleteMicrosoftTeamsChannelConfiguration">REST API Reference for DeleteMicrosoftTeamsChannelConfiguration Operation</seealso>
        Task<DeleteMicrosoftTeamsChannelConfigurationResponse> DeleteMicrosoftTeamsChannelConfigurationAsync(DeleteMicrosoftTeamsChannelConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteMicrosoftTeamsConfiguredTeam


        /// <summary>
        /// Deletes the Microsoft Teams team authorization allowing for channels to be configured
        /// in that Microsoft Teams team. Note that the Microsoft Teams team must have no channels
        /// configured to remove it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMicrosoftTeamsConfiguredTeam service method.</param>
        /// 
        /// <returns>The response from the DeleteMicrosoftTeamsConfiguredTeam service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.DeleteTeamsConfiguredTeamException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/DeleteMicrosoftTeamsConfiguredTeam">REST API Reference for DeleteMicrosoftTeamsConfiguredTeam Operation</seealso>
        DeleteMicrosoftTeamsConfiguredTeamResponse DeleteMicrosoftTeamsConfiguredTeam(DeleteMicrosoftTeamsConfiguredTeamRequest request);



        /// <summary>
        /// Deletes the Microsoft Teams team authorization allowing for channels to be configured
        /// in that Microsoft Teams team. Note that the Microsoft Teams team must have no channels
        /// configured to remove it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMicrosoftTeamsConfiguredTeam service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteMicrosoftTeamsConfiguredTeam service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.DeleteTeamsConfiguredTeamException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/DeleteMicrosoftTeamsConfiguredTeam">REST API Reference for DeleteMicrosoftTeamsConfiguredTeam Operation</seealso>
        Task<DeleteMicrosoftTeamsConfiguredTeamResponse> DeleteMicrosoftTeamsConfiguredTeamAsync(DeleteMicrosoftTeamsConfiguredTeamRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteMicrosoftTeamsUserIdentity


        /// <summary>
        /// Deletes a Teams user identity
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMicrosoftTeamsUserIdentity service method.</param>
        /// 
        /// <returns>The response from the DeleteMicrosoftTeamsUserIdentity service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.DeleteMicrosoftTeamsUserIdentityException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.ResourceNotFoundException">
        /// We were not able to find the resource for your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/DeleteMicrosoftTeamsUserIdentity">REST API Reference for DeleteMicrosoftTeamsUserIdentity Operation</seealso>
        DeleteMicrosoftTeamsUserIdentityResponse DeleteMicrosoftTeamsUserIdentity(DeleteMicrosoftTeamsUserIdentityRequest request);



        /// <summary>
        /// Deletes a Teams user identity
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMicrosoftTeamsUserIdentity service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteMicrosoftTeamsUserIdentity service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.DeleteMicrosoftTeamsUserIdentityException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.ResourceNotFoundException">
        /// We were not able to find the resource for your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/DeleteMicrosoftTeamsUserIdentity">REST API Reference for DeleteMicrosoftTeamsUserIdentity Operation</seealso>
        Task<DeleteMicrosoftTeamsUserIdentityResponse> DeleteMicrosoftTeamsUserIdentityAsync(DeleteMicrosoftTeamsUserIdentityRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteSlackChannelConfiguration


        /// <summary>
        /// Deletes Slack Channel Configuration
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSlackChannelConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteSlackChannelConfiguration service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.DeleteSlackChannelConfigurationException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.ResourceNotFoundException">
        /// We were not able to find the resource for your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/DeleteSlackChannelConfiguration">REST API Reference for DeleteSlackChannelConfiguration Operation</seealso>
        DeleteSlackChannelConfigurationResponse DeleteSlackChannelConfiguration(DeleteSlackChannelConfigurationRequest request);



        /// <summary>
        /// Deletes Slack Channel Configuration
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSlackChannelConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSlackChannelConfiguration service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.DeleteSlackChannelConfigurationException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.ResourceNotFoundException">
        /// We were not able to find the resource for your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/DeleteSlackChannelConfiguration">REST API Reference for DeleteSlackChannelConfiguration Operation</seealso>
        Task<DeleteSlackChannelConfigurationResponse> DeleteSlackChannelConfigurationAsync(DeleteSlackChannelConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteSlackUserIdentity


        /// <summary>
        /// Deletes a Slack user identity
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSlackUserIdentity service method.</param>
        /// 
        /// <returns>The response from the DeleteSlackUserIdentity service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.DeleteSlackUserIdentityException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.ResourceNotFoundException">
        /// We were not able to find the resource for your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/DeleteSlackUserIdentity">REST API Reference for DeleteSlackUserIdentity Operation</seealso>
        DeleteSlackUserIdentityResponse DeleteSlackUserIdentity(DeleteSlackUserIdentityRequest request);



        /// <summary>
        /// Deletes a Slack user identity
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSlackUserIdentity service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSlackUserIdentity service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.DeleteSlackUserIdentityException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.ResourceNotFoundException">
        /// We were not able to find the resource for your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/DeleteSlackUserIdentity">REST API Reference for DeleteSlackUserIdentity Operation</seealso>
        Task<DeleteSlackUserIdentityResponse> DeleteSlackUserIdentityAsync(DeleteSlackUserIdentityRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteSlackWorkspaceAuthorization


        /// <summary>
        /// Deletes the Slack workspace authorization that allows channels to be configured in
        /// that workspace. This requires all configured channels in the workspace to be deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSlackWorkspaceAuthorization service method.</param>
        /// 
        /// <returns>The response from the DeleteSlackWorkspaceAuthorization service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.DeleteSlackWorkspaceAuthorizationException">
        /// There was an issue deleting your Slack workspace.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/DeleteSlackWorkspaceAuthorization">REST API Reference for DeleteSlackWorkspaceAuthorization Operation</seealso>
        DeleteSlackWorkspaceAuthorizationResponse DeleteSlackWorkspaceAuthorization(DeleteSlackWorkspaceAuthorizationRequest request);



        /// <summary>
        /// Deletes the Slack workspace authorization that allows channels to be configured in
        /// that workspace. This requires all configured channels in the workspace to be deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSlackWorkspaceAuthorization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSlackWorkspaceAuthorization service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.DeleteSlackWorkspaceAuthorizationException">
        /// There was an issue deleting your Slack workspace.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/DeleteSlackWorkspaceAuthorization">REST API Reference for DeleteSlackWorkspaceAuthorization Operation</seealso>
        Task<DeleteSlackWorkspaceAuthorizationResponse> DeleteSlackWorkspaceAuthorizationAsync(DeleteSlackWorkspaceAuthorizationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeChimeWebhookConfigurations


        /// <summary>
        /// Lists Chime Webhook Configurations optionally filtered by ChatConfigurationArn
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeChimeWebhookConfigurations service method.</param>
        /// 
        /// <returns>The response from the DescribeChimeWebhookConfigurations service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.DescribeChimeWebhookConfigurationsException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/DescribeChimeWebhookConfigurations">REST API Reference for DescribeChimeWebhookConfigurations Operation</seealso>
        DescribeChimeWebhookConfigurationsResponse DescribeChimeWebhookConfigurations(DescribeChimeWebhookConfigurationsRequest request);



        /// <summary>
        /// Lists Chime Webhook Configurations optionally filtered by ChatConfigurationArn
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeChimeWebhookConfigurations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeChimeWebhookConfigurations service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.DescribeChimeWebhookConfigurationsException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/DescribeChimeWebhookConfigurations">REST API Reference for DescribeChimeWebhookConfigurations Operation</seealso>
        Task<DescribeChimeWebhookConfigurationsResponse> DescribeChimeWebhookConfigurationsAsync(DescribeChimeWebhookConfigurationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeSlackChannelConfigurations


        /// <summary>
        /// Lists Slack Channel Configurations optionally filtered by ChatConfigurationArn
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSlackChannelConfigurations service method.</param>
        /// 
        /// <returns>The response from the DescribeSlackChannelConfigurations service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.DescribeSlackChannelConfigurationsException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/DescribeSlackChannelConfigurations">REST API Reference for DescribeSlackChannelConfigurations Operation</seealso>
        DescribeSlackChannelConfigurationsResponse DescribeSlackChannelConfigurations(DescribeSlackChannelConfigurationsRequest request);



        /// <summary>
        /// Lists Slack Channel Configurations optionally filtered by ChatConfigurationArn
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSlackChannelConfigurations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSlackChannelConfigurations service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.DescribeSlackChannelConfigurationsException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/DescribeSlackChannelConfigurations">REST API Reference for DescribeSlackChannelConfigurations Operation</seealso>
        Task<DescribeSlackChannelConfigurationsResponse> DescribeSlackChannelConfigurationsAsync(DescribeSlackChannelConfigurationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeSlackUserIdentities


        /// <summary>
        /// Lists all Slack user identities with a mapped role.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSlackUserIdentities service method.</param>
        /// 
        /// <returns>The response from the DescribeSlackUserIdentities service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.DescribeSlackUserIdentitiesException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/DescribeSlackUserIdentities">REST API Reference for DescribeSlackUserIdentities Operation</seealso>
        DescribeSlackUserIdentitiesResponse DescribeSlackUserIdentities(DescribeSlackUserIdentitiesRequest request);



        /// <summary>
        /// Lists all Slack user identities with a mapped role.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSlackUserIdentities service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSlackUserIdentities service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.DescribeSlackUserIdentitiesException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/DescribeSlackUserIdentities">REST API Reference for DescribeSlackUserIdentities Operation</seealso>
        Task<DescribeSlackUserIdentitiesResponse> DescribeSlackUserIdentitiesAsync(DescribeSlackUserIdentitiesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeSlackWorkspaces


        /// <summary>
        /// Lists all authorized Slack Workspaces for AWS Account
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSlackWorkspaces service method.</param>
        /// 
        /// <returns>The response from the DescribeSlackWorkspaces service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.DescribeSlackWorkspacesException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/DescribeSlackWorkspaces">REST API Reference for DescribeSlackWorkspaces Operation</seealso>
        DescribeSlackWorkspacesResponse DescribeSlackWorkspaces(DescribeSlackWorkspacesRequest request);



        /// <summary>
        /// Lists all authorized Slack Workspaces for AWS Account
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSlackWorkspaces service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSlackWorkspaces service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.DescribeSlackWorkspacesException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/DescribeSlackWorkspaces">REST API Reference for DescribeSlackWorkspaces Operation</seealso>
        Task<DescribeSlackWorkspacesResponse> DescribeSlackWorkspacesAsync(DescribeSlackWorkspacesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetAccountPreferences


        /// <summary>
        /// Get Chatbot account level preferences
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccountPreferences service method.</param>
        /// 
        /// <returns>The response from the GetAccountPreferences service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.GetAccountPreferencesException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/GetAccountPreferences">REST API Reference for GetAccountPreferences Operation</seealso>
        GetAccountPreferencesResponse GetAccountPreferences(GetAccountPreferencesRequest request);



        /// <summary>
        /// Get Chatbot account level preferences
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccountPreferences service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAccountPreferences service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.GetAccountPreferencesException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/GetAccountPreferences">REST API Reference for GetAccountPreferences Operation</seealso>
        Task<GetAccountPreferencesResponse> GetAccountPreferencesAsync(GetAccountPreferencesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetMicrosoftTeamsChannelConfiguration


        /// <summary>
        /// Get a single MS Teams Channel Configurations
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMicrosoftTeamsChannelConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetMicrosoftTeamsChannelConfiguration service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.GetTeamsChannelConfigurationException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/GetMicrosoftTeamsChannelConfiguration">REST API Reference for GetMicrosoftTeamsChannelConfiguration Operation</seealso>
        GetMicrosoftTeamsChannelConfigurationResponse GetMicrosoftTeamsChannelConfiguration(GetMicrosoftTeamsChannelConfigurationRequest request);



        /// <summary>
        /// Get a single MS Teams Channel Configurations
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMicrosoftTeamsChannelConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMicrosoftTeamsChannelConfiguration service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.GetTeamsChannelConfigurationException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/GetMicrosoftTeamsChannelConfiguration">REST API Reference for GetMicrosoftTeamsChannelConfiguration Operation</seealso>
        Task<GetMicrosoftTeamsChannelConfigurationResponse> GetMicrosoftTeamsChannelConfigurationAsync(GetMicrosoftTeamsChannelConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListMicrosoftTeamsChannelConfigurations


        /// <summary>
        /// Lists MS Teams Channel Configurations optionally filtered by TeamId
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMicrosoftTeamsChannelConfigurations service method.</param>
        /// 
        /// <returns>The response from the ListMicrosoftTeamsChannelConfigurations service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.ListTeamsChannelConfigurationsException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/ListMicrosoftTeamsChannelConfigurations">REST API Reference for ListMicrosoftTeamsChannelConfigurations Operation</seealso>
        ListMicrosoftTeamsChannelConfigurationsResponse ListMicrosoftTeamsChannelConfigurations(ListMicrosoftTeamsChannelConfigurationsRequest request);



        /// <summary>
        /// Lists MS Teams Channel Configurations optionally filtered by TeamId
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMicrosoftTeamsChannelConfigurations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMicrosoftTeamsChannelConfigurations service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.ListTeamsChannelConfigurationsException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/ListMicrosoftTeamsChannelConfigurations">REST API Reference for ListMicrosoftTeamsChannelConfigurations Operation</seealso>
        Task<ListMicrosoftTeamsChannelConfigurationsResponse> ListMicrosoftTeamsChannelConfigurationsAsync(ListMicrosoftTeamsChannelConfigurationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListMicrosoftTeamsConfiguredTeams


        /// <summary>
        /// Lists all authorized MS teams for AWS Account
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMicrosoftTeamsConfiguredTeams service method.</param>
        /// 
        /// <returns>The response from the ListMicrosoftTeamsConfiguredTeams service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.ListMicrosoftTeamsConfiguredTeamsException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/ListMicrosoftTeamsConfiguredTeams">REST API Reference for ListMicrosoftTeamsConfiguredTeams Operation</seealso>
        ListMicrosoftTeamsConfiguredTeamsResponse ListMicrosoftTeamsConfiguredTeams(ListMicrosoftTeamsConfiguredTeamsRequest request);



        /// <summary>
        /// Lists all authorized MS teams for AWS Account
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMicrosoftTeamsConfiguredTeams service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMicrosoftTeamsConfiguredTeams service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.ListMicrosoftTeamsConfiguredTeamsException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/ListMicrosoftTeamsConfiguredTeams">REST API Reference for ListMicrosoftTeamsConfiguredTeams Operation</seealso>
        Task<ListMicrosoftTeamsConfiguredTeamsResponse> ListMicrosoftTeamsConfiguredTeamsAsync(ListMicrosoftTeamsConfiguredTeamsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListMicrosoftTeamsUserIdentities


        /// <summary>
        /// Lists all Microsoft Teams user identities with a mapped role.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMicrosoftTeamsUserIdentities service method.</param>
        /// 
        /// <returns>The response from the ListMicrosoftTeamsUserIdentities service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.ListMicrosoftTeamsUserIdentitiesException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/ListMicrosoftTeamsUserIdentities">REST API Reference for ListMicrosoftTeamsUserIdentities Operation</seealso>
        ListMicrosoftTeamsUserIdentitiesResponse ListMicrosoftTeamsUserIdentities(ListMicrosoftTeamsUserIdentitiesRequest request);



        /// <summary>
        /// Lists all Microsoft Teams user identities with a mapped role.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMicrosoftTeamsUserIdentities service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMicrosoftTeamsUserIdentities service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.ListMicrosoftTeamsUserIdentitiesException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/ListMicrosoftTeamsUserIdentities">REST API Reference for ListMicrosoftTeamsUserIdentities Operation</seealso>
        Task<ListMicrosoftTeamsUserIdentitiesResponse> ListMicrosoftTeamsUserIdentitiesAsync(ListMicrosoftTeamsUserIdentitiesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateAccountPreferences


        /// <summary>
        /// Update Chatbot account level preferences
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccountPreferences service method.</param>
        /// 
        /// <returns>The response from the UpdateAccountPreferences service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.UpdateAccountPreferencesException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/UpdateAccountPreferences">REST API Reference for UpdateAccountPreferences Operation</seealso>
        UpdateAccountPreferencesResponse UpdateAccountPreferences(UpdateAccountPreferencesRequest request);



        /// <summary>
        /// Update Chatbot account level preferences
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccountPreferences service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAccountPreferences service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.UpdateAccountPreferencesException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/UpdateAccountPreferences">REST API Reference for UpdateAccountPreferences Operation</seealso>
        Task<UpdateAccountPreferencesResponse> UpdateAccountPreferencesAsync(UpdateAccountPreferencesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateChimeWebhookConfiguration


        /// <summary>
        /// Updates a Chime Webhook Configuration
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateChimeWebhookConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateChimeWebhookConfiguration service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.ResourceNotFoundException">
        /// We were not able to find the resource for your request.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.UpdateChimeWebhookConfigurationException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/UpdateChimeWebhookConfiguration">REST API Reference for UpdateChimeWebhookConfiguration Operation</seealso>
        UpdateChimeWebhookConfigurationResponse UpdateChimeWebhookConfiguration(UpdateChimeWebhookConfigurationRequest request);



        /// <summary>
        /// Updates a Chime Webhook Configuration
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateChimeWebhookConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateChimeWebhookConfiguration service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.ResourceNotFoundException">
        /// We were not able to find the resource for your request.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.UpdateChimeWebhookConfigurationException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/UpdateChimeWebhookConfiguration">REST API Reference for UpdateChimeWebhookConfiguration Operation</seealso>
        Task<UpdateChimeWebhookConfigurationResponse> UpdateChimeWebhookConfigurationAsync(UpdateChimeWebhookConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateMicrosoftTeamsChannelConfiguration


        /// <summary>
        /// Updates MS Teams Channel Configuration
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMicrosoftTeamsChannelConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateMicrosoftTeamsChannelConfiguration service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.ResourceNotFoundException">
        /// We were not able to find the resource for your request.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.UpdateTeamsChannelConfigurationException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/UpdateMicrosoftTeamsChannelConfiguration">REST API Reference for UpdateMicrosoftTeamsChannelConfiguration Operation</seealso>
        UpdateMicrosoftTeamsChannelConfigurationResponse UpdateMicrosoftTeamsChannelConfiguration(UpdateMicrosoftTeamsChannelConfigurationRequest request);



        /// <summary>
        /// Updates MS Teams Channel Configuration
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMicrosoftTeamsChannelConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateMicrosoftTeamsChannelConfiguration service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.ResourceNotFoundException">
        /// We were not able to find the resource for your request.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.UpdateTeamsChannelConfigurationException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/UpdateMicrosoftTeamsChannelConfiguration">REST API Reference for UpdateMicrosoftTeamsChannelConfiguration Operation</seealso>
        Task<UpdateMicrosoftTeamsChannelConfigurationResponse> UpdateMicrosoftTeamsChannelConfigurationAsync(UpdateMicrosoftTeamsChannelConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateSlackChannelConfiguration


        /// <summary>
        /// Updates Slack Channel Configuration
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSlackChannelConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateSlackChannelConfiguration service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.ResourceNotFoundException">
        /// We were not able to find the resource for your request.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.UpdateSlackChannelConfigurationException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/UpdateSlackChannelConfiguration">REST API Reference for UpdateSlackChannelConfiguration Operation</seealso>
        UpdateSlackChannelConfigurationResponse UpdateSlackChannelConfiguration(UpdateSlackChannelConfigurationRequest request);



        /// <summary>
        /// Updates Slack Channel Configuration
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSlackChannelConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSlackChannelConfiguration service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.ResourceNotFoundException">
        /// We were not able to find the resource for your request.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.UpdateSlackChannelConfigurationException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/UpdateSlackChannelConfiguration">REST API Reference for UpdateSlackChannelConfiguration Operation</seealso>
        Task<UpdateSlackChannelConfigurationResponse> UpdateSlackChannelConfigurationAsync(UpdateSlackChannelConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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