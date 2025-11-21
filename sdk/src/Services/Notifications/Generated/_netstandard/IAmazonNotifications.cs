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
    /// The <i>User Notifications API Reference</i> provides descriptions, API request parameters,
    /// and the JSON response for each of the User Notifications API actions.
    /// 
    ///  
    /// <para>
    /// User Notification control plane APIs are currently available in US East (Virginia)
    /// - <c>us-east-1</c>.
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
    /// is stored in each Region chosen as a <a href="https://docs.aws.amazon.com/notifications/latest/userguide/notification-hubs.html">notification
    /// hub</a> in addition to US East (Virginia).
    /// </para>
    ///  <note> 
    /// <para>
    /// For information about descriptions, API request parameters, and the JSON response
    /// for email contact related API actions, see the <a href="https://docs.aws.amazon.com/notificationscontacts/latest/APIReference/Welcome.html">User
    /// Notifications Contacts API Reference Guide</a>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial interface IAmazonNotifications : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        INotificationsPaginatorFactory Paginators { get; }
#endif
                
        #region  AssociateChannel



        /// <summary>
        /// Associates a delivery <a href="https://docs.aws.amazon.com/notifications/latest/userguide/managing-delivery-channels.html">Channel</a>
        /// with a particular <c>NotificationConfiguration</c>. Supported Channels include Amazon
        /// Q Developer in chat applications, the Console Mobile Application, and emails (notifications-contacts).
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
        Task<AssociateChannelResponse> AssociateChannelAsync(AssociateChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AssociateManagedNotificationAccountContact



        /// <summary>
        /// Associates an Account Contact with a particular <c>ManagedNotificationConfiguration</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateManagedNotificationAccountContact service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateManagedNotificationAccountContact service method, as returned by Notifications.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/AssociateManagedNotificationAccountContact">REST API Reference for AssociateManagedNotificationAccountContact Operation</seealso>
        Task<AssociateManagedNotificationAccountContactResponse> AssociateManagedNotificationAccountContactAsync(AssociateManagedNotificationAccountContactRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AssociateManagedNotificationAdditionalChannel



        /// <summary>
        /// Associates an additional Channel with a particular <c>ManagedNotificationConfiguration</c>.
        /// 
        ///  
        /// <para>
        /// Supported Channels include Amazon Q Developer in chat applications, the Console Mobile
        /// Application, and emails (notifications-contacts).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateManagedNotificationAdditionalChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateManagedNotificationAdditionalChannel service method, as returned by Notifications.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/AssociateManagedNotificationAdditionalChannel">REST API Reference for AssociateManagedNotificationAdditionalChannel Operation</seealso>
        Task<AssociateManagedNotificationAdditionalChannelResponse> AssociateManagedNotificationAdditionalChannelAsync(AssociateManagedNotificationAdditionalChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AssociateOrganizationalUnit



        /// <summary>
        /// Associates an organizational unit with a notification configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateOrganizationalUnit service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateOrganizationalUnit service method, as returned by Notifications.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/AssociateOrganizationalUnit">REST API Reference for AssociateOrganizationalUnit Operation</seealso>
        Task<AssociateOrganizationalUnitResponse> AssociateOrganizationalUnitAsync(AssociateOrganizationalUnitRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateEventRule



        /// <summary>
        /// Creates an <a href="https://docs.aws.amazon.com/notifications/latest/userguide/glossary.html">
        /// <c>EventRule</c> </a> that is associated with a specified <c>NotificationConfiguration</c>.
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
        Task<CreateEventRuleResponse> CreateEventRuleAsync(CreateEventRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateNotificationConfiguration



        /// <summary>
        /// Creates a new <c>NotificationConfiguration</c>.
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
        Task<CreateNotificationConfigurationResponse> CreateNotificationConfigurationAsync(CreateNotificationConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteEventRule



        /// <summary>
        /// Deletes an <c>EventRule</c>.
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
        Task<DeleteEventRuleResponse> DeleteEventRuleAsync(DeleteEventRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteNotificationConfiguration



        /// <summary>
        /// Deletes a <c>NotificationConfiguration</c>.
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
        Task<DeleteNotificationConfigurationResponse> DeleteNotificationConfigurationAsync(DeleteNotificationConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeregisterNotificationHub



        /// <summary>
        /// Deregisters a <c>NotificationConfiguration</c> in the specified Region.
        /// 
        ///  <note> 
        /// <para>
        /// You can't deregister the last <c>NotificationHub</c> in the account. <c>NotificationEvents</c>
        /// stored in the deregistered <c>NotificationConfiguration</c> are no longer be visible.
        /// Recreating a new <c>NotificationConfiguration</c> in the same Region restores access
        /// to those <c>NotificationEvents</c>.
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
        Task<DeregisterNotificationHubResponse> DeregisterNotificationHubAsync(DeregisterNotificationHubRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisableNotificationsAccessForOrganization



        /// <summary>
        /// Disables service trust between User Notifications and Amazon Web Services Organizations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableNotificationsAccessForOrganization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisableNotificationsAccessForOrganization service method, as returned by Notifications.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/DisableNotificationsAccessForOrganization">REST API Reference for DisableNotificationsAccessForOrganization Operation</seealso>
        Task<DisableNotificationsAccessForOrganizationResponse> DisableNotificationsAccessForOrganizationAsync(DisableNotificationsAccessForOrganizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisassociateChannel



        /// <summary>
        /// Disassociates a Channel from a specified <c>NotificationConfiguration</c>. Supported
        /// Channels include Amazon Q Developer in chat applications, the Console Mobile Application,
        /// and emails (notifications-contacts).
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
        Task<DisassociateChannelResponse> DisassociateChannelAsync(DisassociateChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisassociateManagedNotificationAccountContact



        /// <summary>
        /// Disassociates an Account Contact with a particular <c>ManagedNotificationConfiguration</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateManagedNotificationAccountContact service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateManagedNotificationAccountContact service method, as returned by Notifications.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/DisassociateManagedNotificationAccountContact">REST API Reference for DisassociateManagedNotificationAccountContact Operation</seealso>
        Task<DisassociateManagedNotificationAccountContactResponse> DisassociateManagedNotificationAccountContactAsync(DisassociateManagedNotificationAccountContactRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisassociateManagedNotificationAdditionalChannel



        /// <summary>
        /// Disassociates an additional Channel from a particular <c>ManagedNotificationConfiguration</c>.
        /// 
        ///  
        /// <para>
        /// Supported Channels include Amazon Q Developer in chat applications, the Console Mobile
        /// Application, and emails (notifications-contacts).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateManagedNotificationAdditionalChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateManagedNotificationAdditionalChannel service method, as returned by Notifications.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/DisassociateManagedNotificationAdditionalChannel">REST API Reference for DisassociateManagedNotificationAdditionalChannel Operation</seealso>
        Task<DisassociateManagedNotificationAdditionalChannelResponse> DisassociateManagedNotificationAdditionalChannelAsync(DisassociateManagedNotificationAdditionalChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisassociateOrganizationalUnit



        /// <summary>
        /// Removes the association between an organizational unit and a notification configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateOrganizationalUnit service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateOrganizationalUnit service method, as returned by Notifications.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/DisassociateOrganizationalUnit">REST API Reference for DisassociateOrganizationalUnit Operation</seealso>
        Task<DisassociateOrganizationalUnitResponse> DisassociateOrganizationalUnitAsync(DisassociateOrganizationalUnitRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  EnableNotificationsAccessForOrganization



        /// <summary>
        /// Enables service trust between User Notifications and Amazon Web Services Organizations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableNotificationsAccessForOrganization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EnableNotificationsAccessForOrganization service method, as returned by Notifications.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/EnableNotificationsAccessForOrganization">REST API Reference for EnableNotificationsAccessForOrganization Operation</seealso>
        Task<EnableNotificationsAccessForOrganizationResponse> EnableNotificationsAccessForOrganizationAsync(EnableNotificationsAccessForOrganizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetEventRule



        /// <summary>
        /// Returns a specified <c>EventRule</c>.
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
        Task<GetEventRuleResponse> GetEventRuleAsync(GetEventRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetManagedNotificationChildEvent



        /// <summary>
        /// Returns the child event of a specific given <c>ManagedNotificationEvent</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetManagedNotificationChildEvent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetManagedNotificationChildEvent service method, as returned by Notifications.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/GetManagedNotificationChildEvent">REST API Reference for GetManagedNotificationChildEvent Operation</seealso>
        Task<GetManagedNotificationChildEventResponse> GetManagedNotificationChildEventAsync(GetManagedNotificationChildEventRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetManagedNotificationConfiguration



        /// <summary>
        /// Returns a specified <c>ManagedNotificationConfiguration</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetManagedNotificationConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetManagedNotificationConfiguration service method, as returned by Notifications.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/GetManagedNotificationConfiguration">REST API Reference for GetManagedNotificationConfiguration Operation</seealso>
        Task<GetManagedNotificationConfigurationResponse> GetManagedNotificationConfigurationAsync(GetManagedNotificationConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetManagedNotificationEvent



        /// <summary>
        /// Returns a specified <c>ManagedNotificationEvent</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetManagedNotificationEvent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetManagedNotificationEvent service method, as returned by Notifications.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/GetManagedNotificationEvent">REST API Reference for GetManagedNotificationEvent Operation</seealso>
        Task<GetManagedNotificationEventResponse> GetManagedNotificationEventAsync(GetManagedNotificationEventRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetNotificationConfiguration



        /// <summary>
        /// Returns a specified <c>NotificationConfiguration</c>.
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
        Task<GetNotificationConfigurationResponse> GetNotificationConfigurationAsync(GetNotificationConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetNotificationEvent



        /// <summary>
        /// Returns a specified <c>NotificationEvent</c>.
        /// 
        ///  <important> 
        /// <para>
        /// User Notifications stores notifications in the individual Regions you register as
        /// notification hubs and the Region of the source event rule. <c>GetNotificationEvent</c>
        /// only returns notifications stored in the same Region in which the action is called.
        /// User Notifications doesn't backfill notifications to new Regions selected as notification
        /// hubs. For this reason, we recommend that you make calls in your oldest registered
        /// notification hub. For more information, see <a href="https://docs.aws.amazon.com/notifications/latest/userguide/notification-hubs.html">Notification
        /// hubs</a> in the <i>Amazon Web Services User Notifications User Guide</i>.
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
        Task<GetNotificationEventResponse> GetNotificationEventAsync(GetNotificationEventRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetNotificationsAccessForOrganization



        /// <summary>
        /// Returns the AccessStatus of Service Trust Enablement for User Notifications and Amazon
        /// Web Services Organizations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetNotificationsAccessForOrganization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetNotificationsAccessForOrganization service method, as returned by Notifications.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/GetNotificationsAccessForOrganization">REST API Reference for GetNotificationsAccessForOrganization Operation</seealso>
        Task<GetNotificationsAccessForOrganizationResponse> GetNotificationsAccessForOrganizationAsync(GetNotificationsAccessForOrganizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListChannels



        /// <summary>
        /// Returns a list of Channels for a <c>NotificationConfiguration</c>.
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
        Task<ListChannelsResponse> ListChannelsAsync(ListChannelsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListEventRules



        /// <summary>
        /// Returns a list of <c>EventRules</c> according to specified filters, in reverse chronological
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
        Task<ListEventRulesResponse> ListEventRulesAsync(ListEventRulesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListManagedNotificationChannelAssociations



        /// <summary>
        /// Returns a list of Account contacts and Channels associated with a <c>ManagedNotificationConfiguration</c>,
        /// in paginated format.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListManagedNotificationChannelAssociations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListManagedNotificationChannelAssociations service method, as returned by Notifications.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/ListManagedNotificationChannelAssociations">REST API Reference for ListManagedNotificationChannelAssociations Operation</seealso>
        Task<ListManagedNotificationChannelAssociationsResponse> ListManagedNotificationChannelAssociationsAsync(ListManagedNotificationChannelAssociationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListManagedNotificationChildEvents



        /// <summary>
        /// Returns a list of <c>ManagedNotificationChildEvents</c> for a specified aggregate
        /// <c>ManagedNotificationEvent</c>, ordered by creation time in reverse chronological
        /// order (newest first).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListManagedNotificationChildEvents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListManagedNotificationChildEvents service method, as returned by Notifications.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/ListManagedNotificationChildEvents">REST API Reference for ListManagedNotificationChildEvents Operation</seealso>
        Task<ListManagedNotificationChildEventsResponse> ListManagedNotificationChildEventsAsync(ListManagedNotificationChildEventsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListManagedNotificationConfigurations



        /// <summary>
        /// Returns a list of Managed Notification Configurations according to specified filters,
        /// ordered by creation time in reverse chronological order (newest first).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListManagedNotificationConfigurations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListManagedNotificationConfigurations service method, as returned by Notifications.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/ListManagedNotificationConfigurations">REST API Reference for ListManagedNotificationConfigurations Operation</seealso>
        Task<ListManagedNotificationConfigurationsResponse> ListManagedNotificationConfigurationsAsync(ListManagedNotificationConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListManagedNotificationEvents



        /// <summary>
        /// Returns a list of Managed Notification Events according to specified filters, ordered
        /// by creation time in reverse chronological order (newest first).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListManagedNotificationEvents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListManagedNotificationEvents service method, as returned by Notifications.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/ListManagedNotificationEvents">REST API Reference for ListManagedNotificationEvents Operation</seealso>
        Task<ListManagedNotificationEventsResponse> ListManagedNotificationEventsAsync(ListManagedNotificationEventsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListMemberAccounts



        /// <summary>
        /// Returns a list of member accounts associated with a notification configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMemberAccounts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMemberAccounts service method, as returned by Notifications.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/ListMemberAccounts">REST API Reference for ListMemberAccounts Operation</seealso>
        Task<ListMemberAccountsResponse> ListMemberAccountsAsync(ListMemberAccountsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListNotificationConfigurations



        /// <summary>
        /// Returns a list of abbreviated <c>NotificationConfigurations</c> according to specified
        /// filters, in reverse chronological order (newest first).
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
        Task<ListNotificationConfigurationsResponse> ListNotificationConfigurationsAsync(ListNotificationConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListNotificationEvents



        /// <summary>
        /// Returns a list of <c>NotificationEvents</c> according to specified filters, in reverse
        /// chronological order (newest first).
        /// 
        ///  <important> 
        /// <para>
        /// User Notifications stores notifications in the individual Regions you register as
        /// notification hubs and the Region of the source event rule. ListNotificationEvents
        /// only returns notifications stored in the same Region in which the action is called.
        /// User Notifications doesn't backfill notifications to new Regions selected as notification
        /// hubs. For this reason, we recommend that you make calls in your oldest registered
        /// notification hub. For more information, see <a href="https://docs.aws.amazon.com/notifications/latest/userguide/notification-hubs.html">Notification
        /// hubs</a> in the <i>Amazon Web Services User Notifications User Guide</i>.
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
        Task<ListNotificationEventsResponse> ListNotificationEventsAsync(ListNotificationEventsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListNotificationHubs



        /// <summary>
        /// Returns a list of <c>NotificationHubs</c>.
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
        Task<ListNotificationHubsResponse> ListNotificationHubsAsync(ListNotificationHubsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListOrganizationalUnits



        /// <summary>
        /// Returns a list of organizational units associated with a notification configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOrganizationalUnits service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListOrganizationalUnits service method, as returned by Notifications.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/ListOrganizationalUnits">REST API Reference for ListOrganizationalUnits Operation</seealso>
        Task<ListOrganizationalUnitsResponse> ListOrganizationalUnitsAsync(ListOrganizationalUnitsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource



        /// <summary>
        /// Returns a list of tags for a specified Amazon Resource Name (ARN).
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/tag-editor/latest/userguide/tagging.html">Tagging
        /// your Amazon Web Services resources</a> in the <i>Tagging Amazon Web Services Resources
        /// User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This is only supported for <c>NotificationConfigurations</c>.
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
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RegisterNotificationHub



        /// <summary>
        /// Registers a <c>NotificationConfiguration</c> in the specified Region.
        /// 
        ///  
        /// <para>
        /// There is a maximum of one <c>NotificationConfiguration</c> per Region. You can have
        /// a maximum of 3 <c>NotificationHub</c> resources at a time.
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
        Task<RegisterNotificationHubResponse> RegisterNotificationHubAsync(RegisterNotificationHubRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource



        /// <summary>
        /// Tags the resource with a tag key and value.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/tag-editor/latest/userguide/tagging.html">Tagging
        /// your Amazon Web Services resources</a> in the <i>Tagging Amazon Web Services Resources
        /// User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This is only supported for <c>NotificationConfigurations</c>.
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
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource



        /// <summary>
        /// Untags a resource with a specified Amazon Resource Name (ARN).
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/tag-editor/latest/userguide/tagging.html">Tagging
        /// your Amazon Web Services resources</a> in the <i>Tagging Amazon Web Services Resources
        /// User Guide</i>.
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
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateEventRule



        /// <summary>
        /// Updates an existing <c>EventRule</c>.
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
        Task<UpdateEventRuleResponse> UpdateEventRuleAsync(UpdateEventRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateNotificationConfiguration



        /// <summary>
        /// Updates a <c>NotificationConfiguration</c>.
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
        Task<UpdateNotificationConfigurationResponse> UpdateNotificationConfigurationAsync(UpdateNotificationConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);
        
        #endregion

        #region Static factory interface methods
#if NET8_0_OR_GREATER
// Warning CA1033 is issued when the child types can not call the method defined in parent types.
// In this use case the intended caller is only meant to be the interface as a factory
// method to create the child types. Given the SDK use case the warning can be ignored.
#pragma warning disable CA1033
        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonNotificationsConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonNotificationsConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
    Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonNotificationsConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonNotificationsConfig to create AmazonNotificationsClient");
            }

            return awsCredentials == null ? 
                    new AmazonNotificationsClient(serviceClientConfig) :
                    new AmazonNotificationsClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
        #endregion
    }
}