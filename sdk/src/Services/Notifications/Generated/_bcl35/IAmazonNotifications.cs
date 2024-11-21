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


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        INotificationsPaginatorFactory Paginators { get; }
#endif


        
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
        /// Initiates the asynchronous execution of the AssociateChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateChannel operation on AmazonNotificationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/AssociateChannel">REST API Reference for AssociateChannel Operation</seealso>
        IAsyncResult BeginAssociateChannel(AssociateChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateChannel.</param>
        /// 
        /// <returns>Returns a  AssociateChannelResult from Notifications.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/AssociateChannel">REST API Reference for AssociateChannel Operation</seealso>
        AssociateChannelResponse EndAssociateChannel(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the CreateEventRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEventRule operation on AmazonNotificationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateEventRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/CreateEventRule">REST API Reference for CreateEventRule Operation</seealso>
        IAsyncResult BeginCreateEventRule(CreateEventRuleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateEventRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateEventRule.</param>
        /// 
        /// <returns>Returns a  CreateEventRuleResult from Notifications.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/CreateEventRule">REST API Reference for CreateEventRule Operation</seealso>
        CreateEventRuleResponse EndCreateEventRule(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the CreateNotificationConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateNotificationConfiguration operation on AmazonNotificationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateNotificationConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/CreateNotificationConfiguration">REST API Reference for CreateNotificationConfiguration Operation</seealso>
        IAsyncResult BeginCreateNotificationConfiguration(CreateNotificationConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateNotificationConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateNotificationConfiguration.</param>
        /// 
        /// <returns>Returns a  CreateNotificationConfigurationResult from Notifications.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/CreateNotificationConfiguration">REST API Reference for CreateNotificationConfiguration Operation</seealso>
        CreateNotificationConfigurationResponse EndCreateNotificationConfiguration(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the DeleteEventRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventRule operation on AmazonNotificationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteEventRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/DeleteEventRule">REST API Reference for DeleteEventRule Operation</seealso>
        IAsyncResult BeginDeleteEventRule(DeleteEventRuleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEventRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEventRule.</param>
        /// 
        /// <returns>Returns a  DeleteEventRuleResult from Notifications.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/DeleteEventRule">REST API Reference for DeleteEventRule Operation</seealso>
        DeleteEventRuleResponse EndDeleteEventRule(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the DeleteNotificationConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteNotificationConfiguration operation on AmazonNotificationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteNotificationConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/DeleteNotificationConfiguration">REST API Reference for DeleteNotificationConfiguration Operation</seealso>
        IAsyncResult BeginDeleteNotificationConfiguration(DeleteNotificationConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteNotificationConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteNotificationConfiguration.</param>
        /// 
        /// <returns>Returns a  DeleteNotificationConfigurationResult from Notifications.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/DeleteNotificationConfiguration">REST API Reference for DeleteNotificationConfiguration Operation</seealso>
        DeleteNotificationConfigurationResponse EndDeleteNotificationConfiguration(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the DeregisterNotificationHub operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterNotificationHub operation on AmazonNotificationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeregisterNotificationHub
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/DeregisterNotificationHub">REST API Reference for DeregisterNotificationHub Operation</seealso>
        IAsyncResult BeginDeregisterNotificationHub(DeregisterNotificationHubRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeregisterNotificationHub operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeregisterNotificationHub.</param>
        /// 
        /// <returns>Returns a  DeregisterNotificationHubResult from Notifications.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/DeregisterNotificationHub">REST API Reference for DeregisterNotificationHub Operation</seealso>
        DeregisterNotificationHubResponse EndDeregisterNotificationHub(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the DisassociateChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateChannel operation on AmazonNotificationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/DisassociateChannel">REST API Reference for DisassociateChannel Operation</seealso>
        IAsyncResult BeginDisassociateChannel(DisassociateChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateChannel.</param>
        /// 
        /// <returns>Returns a  DisassociateChannelResult from Notifications.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/DisassociateChannel">REST API Reference for DisassociateChannel Operation</seealso>
        DisassociateChannelResponse EndDisassociateChannel(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the GetEventRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEventRule operation on AmazonNotificationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetEventRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/GetEventRule">REST API Reference for GetEventRule Operation</seealso>
        IAsyncResult BeginGetEventRule(GetEventRuleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetEventRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEventRule.</param>
        /// 
        /// <returns>Returns a  GetEventRuleResult from Notifications.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/GetEventRule">REST API Reference for GetEventRule Operation</seealso>
        GetEventRuleResponse EndGetEventRule(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the GetNotificationConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetNotificationConfiguration operation on AmazonNotificationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetNotificationConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/GetNotificationConfiguration">REST API Reference for GetNotificationConfiguration Operation</seealso>
        IAsyncResult BeginGetNotificationConfiguration(GetNotificationConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetNotificationConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetNotificationConfiguration.</param>
        /// 
        /// <returns>Returns a  GetNotificationConfigurationResult from Notifications.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/GetNotificationConfiguration">REST API Reference for GetNotificationConfiguration Operation</seealso>
        GetNotificationConfigurationResponse EndGetNotificationConfiguration(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the GetNotificationEvent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetNotificationEvent operation on AmazonNotificationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetNotificationEvent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/GetNotificationEvent">REST API Reference for GetNotificationEvent Operation</seealso>
        IAsyncResult BeginGetNotificationEvent(GetNotificationEventRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetNotificationEvent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetNotificationEvent.</param>
        /// 
        /// <returns>Returns a  GetNotificationEventResult from Notifications.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/GetNotificationEvent">REST API Reference for GetNotificationEvent Operation</seealso>
        GetNotificationEventResponse EndGetNotificationEvent(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListChannels operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListChannels operation on AmazonNotificationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListChannels
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/ListChannels">REST API Reference for ListChannels Operation</seealso>
        IAsyncResult BeginListChannels(ListChannelsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListChannels operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListChannels.</param>
        /// 
        /// <returns>Returns a  ListChannelsResult from Notifications.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/ListChannels">REST API Reference for ListChannels Operation</seealso>
        ListChannelsResponse EndListChannels(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListEventRules operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEventRules operation on AmazonNotificationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListEventRules
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/ListEventRules">REST API Reference for ListEventRules Operation</seealso>
        IAsyncResult BeginListEventRules(ListEventRulesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListEventRules operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEventRules.</param>
        /// 
        /// <returns>Returns a  ListEventRulesResult from Notifications.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/ListEventRules">REST API Reference for ListEventRules Operation</seealso>
        ListEventRulesResponse EndListEventRules(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListNotificationConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListNotificationConfigurations operation on AmazonNotificationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListNotificationConfigurations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/ListNotificationConfigurations">REST API Reference for ListNotificationConfigurations Operation</seealso>
        IAsyncResult BeginListNotificationConfigurations(ListNotificationConfigurationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListNotificationConfigurations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListNotificationConfigurations.</param>
        /// 
        /// <returns>Returns a  ListNotificationConfigurationsResult from Notifications.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/ListNotificationConfigurations">REST API Reference for ListNotificationConfigurations Operation</seealso>
        ListNotificationConfigurationsResponse EndListNotificationConfigurations(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListNotificationEvents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListNotificationEvents operation on AmazonNotificationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListNotificationEvents
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/ListNotificationEvents">REST API Reference for ListNotificationEvents Operation</seealso>
        IAsyncResult BeginListNotificationEvents(ListNotificationEventsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListNotificationEvents operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListNotificationEvents.</param>
        /// 
        /// <returns>Returns a  ListNotificationEventsResult from Notifications.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/ListNotificationEvents">REST API Reference for ListNotificationEvents Operation</seealso>
        ListNotificationEventsResponse EndListNotificationEvents(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListNotificationHubs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListNotificationHubs operation on AmazonNotificationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListNotificationHubs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/ListNotificationHubs">REST API Reference for ListNotificationHubs Operation</seealso>
        IAsyncResult BeginListNotificationHubs(ListNotificationHubsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListNotificationHubs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListNotificationHubs.</param>
        /// 
        /// <returns>Returns a  ListNotificationHubsResult from Notifications.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/ListNotificationHubs">REST API Reference for ListNotificationHubs Operation</seealso>
        ListNotificationHubsResponse EndListNotificationHubs(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonNotificationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from Notifications.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the RegisterNotificationHub operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterNotificationHub operation on AmazonNotificationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRegisterNotificationHub
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/RegisterNotificationHub">REST API Reference for RegisterNotificationHub Operation</seealso>
        IAsyncResult BeginRegisterNotificationHub(RegisterNotificationHubRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RegisterNotificationHub operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterNotificationHub.</param>
        /// 
        /// <returns>Returns a  RegisterNotificationHubResult from Notifications.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/RegisterNotificationHub">REST API Reference for RegisterNotificationHub Operation</seealso>
        RegisterNotificationHubResponse EndRegisterNotificationHub(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonNotificationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from Notifications.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonNotificationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from Notifications.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the UpdateEventRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateEventRule operation on AmazonNotificationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateEventRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/UpdateEventRule">REST API Reference for UpdateEventRule Operation</seealso>
        IAsyncResult BeginUpdateEventRule(UpdateEventRuleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateEventRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateEventRule.</param>
        /// 
        /// <returns>Returns a  UpdateEventRuleResult from Notifications.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/UpdateEventRule">REST API Reference for UpdateEventRule Operation</seealso>
        UpdateEventRuleResponse EndUpdateEventRule(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the UpdateNotificationConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateNotificationConfiguration operation on AmazonNotificationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateNotificationConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/UpdateNotificationConfiguration">REST API Reference for UpdateNotificationConfiguration Operation</seealso>
        IAsyncResult BeginUpdateNotificationConfiguration(UpdateNotificationConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateNotificationConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateNotificationConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateNotificationConfigurationResult from Notifications.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notifications-2018-05-10/UpdateNotificationConfiguration">REST API Reference for UpdateNotificationConfiguration Operation</seealso>
        UpdateNotificationConfigurationResponse EndUpdateNotificationConfiguration(IAsyncResult asyncResult);

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