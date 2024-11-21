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
 * Do not modify this file. This file is generated from the notifications-2018-05-10.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Notifications.Model;

#pragma warning disable CS1570
namespace Amazon.Notifications
{
    /// <summary>
    /// <para>Interface for accessing Notifications</para>
    ///
    /// The <i>AWS User Notifications API Reference</i> provides descriptions, API request
    /// parameters, and the JSON response for each of the User Notification API actions.
    /// 
    ///  
    /// <para>
    /// User Notification control APIs are currently available in US East (Virginia) - <c>us-east-1</c>.
    /// </para>
    ///  
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/notifications/latest/APIReference/API_GetNotificationEvent.html">GetNotificationEvent</a>
    /// and <a href="https://docs.aws.amazon.com/notifications/latest/APIReference/API_ListNotificationEvents.html">ListNotificationEvents</a>
    /// APIs are currently available in <a href="https://docs.aws.amazon.com/notifications/latest/userguide/supported-regions.html">commercial
    /// partition Regions</a> and only return notifications stored in the same Region in which
    /// they're called.
    /// </para>
    ///  
    /// <para>
    /// The User Notifications console can only be used in US East (Virginia). Your data however,
    /// is stored in each Region chosen as a <a href="https://docs.aws.amazon.com/notifications/latest/userguide/notification-hubs.html&gt;">notification
    /// hub</a> in addition to US East (Virginia).
    /// </para>
    /// </summary>
    public partial interface IAmazonNotifications : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        INotificationsPaginatorFactory Paginators { get; }

        
        #region  AssociateChannel


        /// <summary>
        /// Associates a delivery <a href="https://docs.aws.amazon.com/notifications/latest/userguide/managing-delivery-channels.html">Channel</a>
        /// with a particular NotificationConfiguration. Supported Channels include AWS Chatbot,
        /// the AWS Console Mobile Application, and emails (notifications-contacts).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateChannel service method.</param>
        /// 
        /// <returns>The response from the AssociateChannel service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/AssociateChannel">REST API Reference for AssociateChannel Operation</seealso>
        AssociateChannelResponse AssociateChannel(AssociateChannelRequest request);



        /// <summary>
        /// Associates a delivery <a href="https://docs.aws.amazon.com/notifications/latest/userguide/managing-delivery-channels.html">Channel</a>
        /// with a particular NotificationConfiguration. Supported Channels include AWS Chatbot,
        /// the AWS Console Mobile Application, and emails (notifications-contacts).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateChannel service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/AssociateChannel">REST API Reference for AssociateChannel Operation</seealso>
        Task<AssociateChannelResponse> AssociateChannelAsync(AssociateChannelRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateEventRule


        /// <summary>
        /// Creates an <a href="https://docs.aws.amazon.com/notifications/latest/userguide/glossary.html">EventRule</a>
        /// that is associated with a specified Notification Configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEventRule service method.</param>
        /// 
        /// <returns>The response from the CreateEventRule service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/CreateEventRule">REST API Reference for CreateEventRule Operation</seealso>
        CreateEventRuleResponse CreateEventRule(CreateEventRuleRequest request);



        /// <summary>
        /// Creates an <a href="https://docs.aws.amazon.com/notifications/latest/userguide/glossary.html">EventRule</a>
        /// that is associated with a specified Notification Configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEventRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateEventRule service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/CreateEventRule">REST API Reference for CreateEventRule Operation</seealso>
        Task<CreateEventRuleResponse> CreateEventRuleAsync(CreateEventRuleRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateNotificationConfiguration


        /// <summary>
        /// Creates a new NotificationConfiguration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNotificationConfiguration service method.</param>
        /// 
        /// <returns>The response from the CreateNotificationConfiguration service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/CreateNotificationConfiguration">REST API Reference for CreateNotificationConfiguration Operation</seealso>
        CreateNotificationConfigurationResponse CreateNotificationConfiguration(CreateNotificationConfigurationRequest request);



        /// <summary>
        /// Creates a new NotificationConfiguration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNotificationConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateNotificationConfiguration service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/CreateNotificationConfiguration">REST API Reference for CreateNotificationConfiguration Operation</seealso>
        Task<CreateNotificationConfigurationResponse> CreateNotificationConfigurationAsync(CreateNotificationConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteEventRule


        /// <summary>
        /// Deletes an EventRule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventRule service method.</param>
        /// 
        /// <returns>The response from the DeleteEventRule service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/DeleteEventRule">REST API Reference for DeleteEventRule Operation</seealso>
        DeleteEventRuleResponse DeleteEventRule(DeleteEventRuleRequest request);



        /// <summary>
        /// Deletes an EventRule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteEventRule service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/DeleteEventRule">REST API Reference for DeleteEventRule Operation</seealso>
        Task<DeleteEventRuleResponse> DeleteEventRuleAsync(DeleteEventRuleRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteNotificationConfiguration


        /// <summary>
        /// Deletes a NotificationConfiguration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNotificationConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteNotificationConfiguration service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/DeleteNotificationConfiguration">REST API Reference for DeleteNotificationConfiguration Operation</seealso>
        DeleteNotificationConfigurationResponse DeleteNotificationConfiguration(DeleteNotificationConfigurationRequest request);



        /// <summary>
        /// Deletes a NotificationConfiguration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNotificationConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteNotificationConfiguration service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/DeleteNotificationConfiguration">REST API Reference for DeleteNotificationConfiguration Operation</seealso>
        Task<DeleteNotificationConfigurationResponse> DeleteNotificationConfigurationAsync(DeleteNotificationConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeregisterNotificationHub


        /// <summary>
        /// Deregisters a NotificationHub in the specified Region.
        /// 
        ///  <note> 
        /// <para>
        /// You can't deregister the last NotificationHub in the account. NotificationEvents stored
        /// in the deregistered NotificationHub are no longer be visible. Recreating a new NotificationHub
        /// in the same Region restores access to those NotificationEvents.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterNotificationHub service method.</param>
        /// 
        /// <returns>The response from the DeregisterNotificationHub service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/DeregisterNotificationHub">REST API Reference for DeregisterNotificationHub Operation</seealso>
        DeregisterNotificationHubResponse DeregisterNotificationHub(DeregisterNotificationHubRequest request);



        /// <summary>
        /// Deregisters a NotificationHub in the specified Region.
        /// 
        ///  <note> 
        /// <para>
        /// You can't deregister the last NotificationHub in the account. NotificationEvents stored
        /// in the deregistered NotificationHub are no longer be visible. Recreating a new NotificationHub
        /// in the same Region restores access to those NotificationEvents.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterNotificationHub service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeregisterNotificationHub service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/DeregisterNotificationHub">REST API Reference for DeregisterNotificationHub Operation</seealso>
        Task<DeregisterNotificationHubResponse> DeregisterNotificationHubAsync(DeregisterNotificationHubRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DisassociateChannel


        /// <summary>
        /// Disassociates a Channel from a specified NotificationConfiguration. Supported Channels
        /// include AWS Chatbot, the AWS Console Mobile Application, and emails (notifications-contacts).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateChannel service method.</param>
        /// 
        /// <returns>The response from the DisassociateChannel service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/DisassociateChannel">REST API Reference for DisassociateChannel Operation</seealso>
        DisassociateChannelResponse DisassociateChannel(DisassociateChannelRequest request);



        /// <summary>
        /// Disassociates a Channel from a specified NotificationConfiguration. Supported Channels
        /// include AWS Chatbot, the AWS Console Mobile Application, and emails (notifications-contacts).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateChannel service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/DisassociateChannel">REST API Reference for DisassociateChannel Operation</seealso>
        Task<DisassociateChannelResponse> DisassociateChannelAsync(DisassociateChannelRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetEventRule


        /// <summary>
        /// Returns a specified EventRule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEventRule service method.</param>
        /// 
        /// <returns>The response from the GetEventRule service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/GetEventRule">REST API Reference for GetEventRule Operation</seealso>
        GetEventRuleResponse GetEventRule(GetEventRuleRequest request);



        /// <summary>
        /// Returns a specified EventRule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEventRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEventRule service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/GetEventRule">REST API Reference for GetEventRule Operation</seealso>
        Task<GetEventRuleResponse> GetEventRuleAsync(GetEventRuleRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetNotificationConfiguration


        /// <summary>
        /// Returns a specified NotificationConfiguration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetNotificationConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetNotificationConfiguration service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/GetNotificationConfiguration">REST API Reference for GetNotificationConfiguration Operation</seealso>
        GetNotificationConfigurationResponse GetNotificationConfiguration(GetNotificationConfigurationRequest request);



        /// <summary>
        /// Returns a specified NotificationConfiguration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetNotificationConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetNotificationConfiguration service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/GetNotificationConfiguration">REST API Reference for GetNotificationConfiguration Operation</seealso>
        Task<GetNotificationConfigurationResponse> GetNotificationConfigurationAsync(GetNotificationConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetNotificationEvent


        /// <summary>
        /// Returns a specified NotificationEvent.
        /// 
        ///  <important> 
        /// <para>
        /// User Notifications stores notifications in the individual Regions you register as
        /// notification hubs and the Region of the source event rule. GetNotificationEvent only
        /// returns notifications stored in the same Region in which the action is called. User
        /// Notifications doesn't backfill notifications to new Regions selected as notification
        /// hubs. For this reason, we recommend that you make calls in your oldest registered
        /// notification hub. For more information, see <a href="https://docs.aws.amazon.com/notifications/latest/userguide/notification-hubs.html">Notification
        /// hubs</a> in the <i>AWS User Notifications User Guide</i>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetNotificationEvent service method.</param>
        /// 
        /// <returns>The response from the GetNotificationEvent service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/GetNotificationEvent">REST API Reference for GetNotificationEvent Operation</seealso>
        GetNotificationEventResponse GetNotificationEvent(GetNotificationEventRequest request);



        /// <summary>
        /// Returns a specified NotificationEvent.
        /// 
        ///  <important> 
        /// <para>
        /// User Notifications stores notifications in the individual Regions you register as
        /// notification hubs and the Region of the source event rule. GetNotificationEvent only
        /// returns notifications stored in the same Region in which the action is called. User
        /// Notifications doesn't backfill notifications to new Regions selected as notification
        /// hubs. For this reason, we recommend that you make calls in your oldest registered
        /// notification hub. For more information, see <a href="https://docs.aws.amazon.com/notifications/latest/userguide/notification-hubs.html">Notification
        /// hubs</a> in the <i>AWS User Notifications User Guide</i>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetNotificationEvent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetNotificationEvent service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/GetNotificationEvent">REST API Reference for GetNotificationEvent Operation</seealso>
        Task<GetNotificationEventResponse> GetNotificationEventAsync(GetNotificationEventRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListChannels


        /// <summary>
        /// Returns a list of Channels for a NotificationConfiguration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListChannels service method.</param>
        /// 
        /// <returns>The response from the ListChannels service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/ListChannels">REST API Reference for ListChannels Operation</seealso>
        ListChannelsResponse ListChannels(ListChannelsRequest request);



        /// <summary>
        /// Returns a list of Channels for a NotificationConfiguration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListChannels service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListChannels service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/ListChannels">REST API Reference for ListChannels Operation</seealso>
        Task<ListChannelsResponse> ListChannelsAsync(ListChannelsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListEventRules


        /// <summary>
        /// Returns a list of EventRules according to specified filters, in reverse chronological
        /// order (newest first).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEventRules service method.</param>
        /// 
        /// <returns>The response from the ListEventRules service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/ListEventRules">REST API Reference for ListEventRules Operation</seealso>
        ListEventRulesResponse ListEventRules(ListEventRulesRequest request);



        /// <summary>
        /// Returns a list of EventRules according to specified filters, in reverse chronological
        /// order (newest first).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEventRules service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEventRules service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/ListEventRules">REST API Reference for ListEventRules Operation</seealso>
        Task<ListEventRulesResponse> ListEventRulesAsync(ListEventRulesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListNotificationConfigurations


        /// <summary>
        /// Returns a list of abbreviated NotificationConfigurations according to specified filters,
        /// in reverse chronological order (newest first).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNotificationConfigurations service method.</param>
        /// 
        /// <returns>The response from the ListNotificationConfigurations service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/ListNotificationConfigurations">REST API Reference for ListNotificationConfigurations Operation</seealso>
        ListNotificationConfigurationsResponse ListNotificationConfigurations(ListNotificationConfigurationsRequest request);



        /// <summary>
        /// Returns a list of abbreviated NotificationConfigurations according to specified filters,
        /// in reverse chronological order (newest first).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNotificationConfigurations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListNotificationConfigurations service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/ListNotificationConfigurations">REST API Reference for ListNotificationConfigurations Operation</seealso>
        Task<ListNotificationConfigurationsResponse> ListNotificationConfigurationsAsync(ListNotificationConfigurationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListNotificationEvents


        /// <summary>
        /// Returns a list of NotificationEvents according to specified filters, in reverse chronological
        /// order (newest first).
        /// 
        ///  <important> 
        /// <para>
        /// User Notifications stores notifications in the individual Regions you register as
        /// notification hubs and the Region of the source event rule. ListNotificationEvents
        /// only returns notifications stored in the same Region in which the action is called.
        /// User Notifications doesn't backfill notifications to new Regions selected as notification
        /// hubs. For this reason, we recommend that you make calls in your oldest registered
        /// notification hub. For more information, see <a href="https://docs.aws.amazon.com/notifications/latest/userguide/notification-hubs.html">Notification
        /// hubs</a> in the <i>AWS User Notifications User Guide</i>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNotificationEvents service method.</param>
        /// 
        /// <returns>The response from the ListNotificationEvents service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/ListNotificationEvents">REST API Reference for ListNotificationEvents Operation</seealso>
        ListNotificationEventsResponse ListNotificationEvents(ListNotificationEventsRequest request);



        /// <summary>
        /// Returns a list of NotificationEvents according to specified filters, in reverse chronological
        /// order (newest first).
        /// 
        ///  <important> 
        /// <para>
        /// User Notifications stores notifications in the individual Regions you register as
        /// notification hubs and the Region of the source event rule. ListNotificationEvents
        /// only returns notifications stored in the same Region in which the action is called.
        /// User Notifications doesn't backfill notifications to new Regions selected as notification
        /// hubs. For this reason, we recommend that you make calls in your oldest registered
        /// notification hub. For more information, see <a href="https://docs.aws.amazon.com/notifications/latest/userguide/notification-hubs.html">Notification
        /// hubs</a> in the <i>AWS User Notifications User Guide</i>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNotificationEvents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListNotificationEvents service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/ListNotificationEvents">REST API Reference for ListNotificationEvents Operation</seealso>
        Task<ListNotificationEventsResponse> ListNotificationEventsAsync(ListNotificationEventsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListNotificationHubs


        /// <summary>
        /// Returns a list of NotificationHubs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNotificationHubs service method.</param>
        /// 
        /// <returns>The response from the ListNotificationHubs service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/ListNotificationHubs">REST API Reference for ListNotificationHubs Operation</seealso>
        ListNotificationHubsResponse ListNotificationHubs(ListNotificationHubsRequest request);



        /// <summary>
        /// Returns a list of NotificationHubs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNotificationHubs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListNotificationHubs service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/ListNotificationHubs">REST API Reference for ListNotificationHubs Operation</seealso>
        Task<ListNotificationHubsResponse> ListNotificationHubsAsync(ListNotificationHubsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Returns a list of tags for a specified Amazon Resource Name (ARN).
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/tag-editor/latest/userguide/tagging.html">Tagging
        /// your AWS resources</a> in the <i>Tagging AWS Resources User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This is only supported for NotificationConfigurations.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);



        /// <summary>
        /// Returns a list of tags for a specified Amazon Resource Name (ARN).
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/tag-editor/latest/userguide/tagging.html">Tagging
        /// your AWS resources</a> in the <i>Tagging AWS Resources User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This is only supported for NotificationConfigurations.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RegisterNotificationHub


        /// <summary>
        /// Registers a NotificationHub in the specified Region.
        /// 
        ///  
        /// <para>
        /// There is a maximum of one NotificationHub per Region. You can have a maximum of 3
        /// NotificationHubs at a time.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterNotificationHub service method.</param>
        /// 
        /// <returns>The response from the RegisterNotificationHub service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/RegisterNotificationHub">REST API Reference for RegisterNotificationHub Operation</seealso>
        RegisterNotificationHubResponse RegisterNotificationHub(RegisterNotificationHubRequest request);



        /// <summary>
        /// Registers a NotificationHub in the specified Region.
        /// 
        ///  
        /// <para>
        /// There is a maximum of one NotificationHub per Region. You can have a maximum of 3
        /// NotificationHubs at a time.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterNotificationHub service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RegisterNotificationHub service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/RegisterNotificationHub">REST API Reference for RegisterNotificationHub Operation</seealso>
        Task<RegisterNotificationHubResponse> RegisterNotificationHubAsync(RegisterNotificationHubRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Tags the resource with a tag key and value.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/tag-editor/latest/userguide/tagging.html">Tagging
        /// your AWS resources</a> in the <i>Tagging AWS Resources User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This is only supported for NotificationConfigurations.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);



        /// <summary>
        /// Tags the resource with a tag key and value.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/tag-editor/latest/userguide/tagging.html">Tagging
        /// your AWS resources</a> in the <i>Tagging AWS Resources User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This is only supported for NotificationConfigurations.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Untags a resource with a specified Amazon Resource Name (ARN).
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/tag-editor/latest/userguide/tagging.html">Tagging
        /// your AWS resources</a> in the <i>Tagging AWS Resources User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);



        /// <summary>
        /// Untags a resource with a specified Amazon Resource Name (ARN).
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/tag-editor/latest/userguide/tagging.html">Tagging
        /// your AWS resources</a> in the <i>Tagging AWS Resources User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateEventRule


        /// <summary>
        /// Updates an existing EventRule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEventRule service method.</param>
        /// 
        /// <returns>The response from the UpdateEventRule service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/UpdateEventRule">REST API Reference for UpdateEventRule Operation</seealso>
        UpdateEventRuleResponse UpdateEventRule(UpdateEventRuleRequest request);



        /// <summary>
        /// Updates an existing EventRule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEventRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateEventRule service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/UpdateEventRule">REST API Reference for UpdateEventRule Operation</seealso>
        Task<UpdateEventRuleResponse> UpdateEventRuleAsync(UpdateEventRuleRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateNotificationConfiguration


        /// <summary>
        /// Updates a NotificationConfiguration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateNotificationConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateNotificationConfiguration service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/UpdateNotificationConfiguration">REST API Reference for UpdateNotificationConfiguration Operation</seealso>
        UpdateNotificationConfigurationResponse UpdateNotificationConfiguration(UpdateNotificationConfigurationRequest request);



        /// <summary>
        /// Updates a NotificationConfiguration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateNotificationConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateNotificationConfiguration service method, as returned by Notifications.</returns>
        /// <exception cref="Amazon.Notifications.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Notifications.Model.ValidationException">
        /// This exception is thrown when the notification event fails validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/UpdateNotificationConfiguration">REST API Reference for UpdateNotificationConfiguration Operation</seealso>
        Task<UpdateNotificationConfigurationResponse> UpdateNotificationConfigurationAsync(UpdateNotificationConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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