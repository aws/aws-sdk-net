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
 * Do not modify this file. This file is generated from the ssm-contacts-2021-05-03.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.SSMContacts.Model;

namespace Amazon.SSMContacts
{
    /// <summary>
    /// Interface for accessing SSMContacts
    ///
    /// AWS Systems Manager Incident Manager is an incident management console designed to
    /// help users mitigate and recover from incidents affecting their AWS-hosted applications.
    /// An incident is any unplanned interruption or reduction in quality of services. 
    /// 
    ///  
    /// <para>
    /// Incident Manager increases incident resolution by notifying responders of impact,
    /// highlighting relevant troubleshooting data, and providing collaboration tools to get
    /// services back up and running. To achieve the primary goal of reducing the time-to-resolution
    /// of critical incidents, Incident Manager automates response plans and enables responder
    /// team escalation. 
    /// </para>
    /// </summary>
    public partial interface IAmazonSSMContacts : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        ISSMContactsPaginatorFactory Paginators { get; }
#endif


        
        #region  AcceptPage


        /// <summary>
        /// Used to acknowledge an engagement to a contact channel during an incident.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptPage service method.</param>
        /// 
        /// <returns>The response from the AcceptPage service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.InternalServerException">
        /// Unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ResourceNotFoundException">
        /// Request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/AcceptPage">REST API Reference for AcceptPage Operation</seealso>
        AcceptPageResponse AcceptPage(AcceptPageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AcceptPage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AcceptPage operation on AmazonSSMContactsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAcceptPage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/AcceptPage">REST API Reference for AcceptPage Operation</seealso>
        IAsyncResult BeginAcceptPage(AcceptPageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AcceptPage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAcceptPage.</param>
        /// 
        /// <returns>Returns a  AcceptPageResult from SSMContacts.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/AcceptPage">REST API Reference for AcceptPage Operation</seealso>
        AcceptPageResponse EndAcceptPage(IAsyncResult asyncResult);

        #endregion
        
        #region  ActivateContactChannel


        /// <summary>
        /// Activates a contact's contact channel. Incident Manager can't engage a contact until
        /// the contact channel has been activated.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ActivateContactChannel service method.</param>
        /// 
        /// <returns>The response from the ActivateContactChannel service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.InternalServerException">
        /// Unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ResourceNotFoundException">
        /// Request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/ActivateContactChannel">REST API Reference for ActivateContactChannel Operation</seealso>
        ActivateContactChannelResponse ActivateContactChannel(ActivateContactChannelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ActivateContactChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ActivateContactChannel operation on AmazonSSMContactsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndActivateContactChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/ActivateContactChannel">REST API Reference for ActivateContactChannel Operation</seealso>
        IAsyncResult BeginActivateContactChannel(ActivateContactChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ActivateContactChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginActivateContactChannel.</param>
        /// 
        /// <returns>Returns a  ActivateContactChannelResult from SSMContacts.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/ActivateContactChannel">REST API Reference for ActivateContactChannel Operation</seealso>
        ActivateContactChannelResponse EndActivateContactChannel(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateContact


        /// <summary>
        /// Contacts are either the contacts that Incident Manager engages during an incident
        /// or the escalation plans that Incident Manager uses to engage contacts in phases during
        /// an incident.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateContact service method.</param>
        /// 
        /// <returns>The response from the CreateContact service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ConflictException">
        /// Updating or deleting a resource causes an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.DataEncryptionException">
        /// The action failed to due an encryption key error.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.InternalServerException">
        /// Unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/CreateContact">REST API Reference for CreateContact Operation</seealso>
        CreateContactResponse CreateContact(CreateContactRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateContact operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateContact operation on AmazonSSMContactsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateContact
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/CreateContact">REST API Reference for CreateContact Operation</seealso>
        IAsyncResult BeginCreateContact(CreateContactRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateContact operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateContact.</param>
        /// 
        /// <returns>Returns a  CreateContactResult from SSMContacts.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/CreateContact">REST API Reference for CreateContact Operation</seealso>
        CreateContactResponse EndCreateContact(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateContactChannel


        /// <summary>
        /// A contact channel is the method that Incident Manager uses to engage your contact.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateContactChannel service method.</param>
        /// 
        /// <returns>The response from the CreateContactChannel service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ConflictException">
        /// Updating or deleting a resource causes an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.DataEncryptionException">
        /// The action failed to due an encryption key error.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.InternalServerException">
        /// Unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/CreateContactChannel">REST API Reference for CreateContactChannel Operation</seealso>
        CreateContactChannelResponse CreateContactChannel(CreateContactChannelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateContactChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateContactChannel operation on AmazonSSMContactsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateContactChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/CreateContactChannel">REST API Reference for CreateContactChannel Operation</seealso>
        IAsyncResult BeginCreateContactChannel(CreateContactChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateContactChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateContactChannel.</param>
        /// 
        /// <returns>Returns a  CreateContactChannelResult from SSMContacts.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/CreateContactChannel">REST API Reference for CreateContactChannel Operation</seealso>
        CreateContactChannelResponse EndCreateContactChannel(IAsyncResult asyncResult);

        #endregion
        
        #region  DeactivateContactChannel


        /// <summary>
        /// To no longer receive Incident Manager engagements to a contact channel, you can deactivate
        /// the channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeactivateContactChannel service method.</param>
        /// 
        /// <returns>The response from the DeactivateContactChannel service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.InternalServerException">
        /// Unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ResourceNotFoundException">
        /// Request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/DeactivateContactChannel">REST API Reference for DeactivateContactChannel Operation</seealso>
        DeactivateContactChannelResponse DeactivateContactChannel(DeactivateContactChannelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeactivateContactChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeactivateContactChannel operation on AmazonSSMContactsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeactivateContactChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/DeactivateContactChannel">REST API Reference for DeactivateContactChannel Operation</seealso>
        IAsyncResult BeginDeactivateContactChannel(DeactivateContactChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeactivateContactChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeactivateContactChannel.</param>
        /// 
        /// <returns>Returns a  DeactivateContactChannelResult from SSMContacts.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/DeactivateContactChannel">REST API Reference for DeactivateContactChannel Operation</seealso>
        DeactivateContactChannelResponse EndDeactivateContactChannel(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteContact


        /// <summary>
        /// To remove a contact from Incident Manager, you can delete the contact. Deleting a
        /// contact removes them from all escalation plans and related response plans. Deleting
        /// an escalation plan removes it from all related response plans. You will have to recreate
        /// the contact and its contact channels before you can use it again.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteContact service method.</param>
        /// 
        /// <returns>The response from the DeleteContact service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.InternalServerException">
        /// Unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ResourceNotFoundException">
        /// Request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/DeleteContact">REST API Reference for DeleteContact Operation</seealso>
        DeleteContactResponse DeleteContact(DeleteContactRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteContact operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteContact operation on AmazonSSMContactsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteContact
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/DeleteContact">REST API Reference for DeleteContact Operation</seealso>
        IAsyncResult BeginDeleteContact(DeleteContactRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteContact operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteContact.</param>
        /// 
        /// <returns>Returns a  DeleteContactResult from SSMContacts.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/DeleteContact">REST API Reference for DeleteContact Operation</seealso>
        DeleteContactResponse EndDeleteContact(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteContactChannel


        /// <summary>
        /// To no longer receive engagements on a contact channel, you can delete the channel
        /// from a contact. Deleting the contact channel removes it from the contact's engagement
        /// plan. If you delete the only contact channel for a contact, you won't be able to engage
        /// that contact during an incident.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteContactChannel service method.</param>
        /// 
        /// <returns>The response from the DeleteContactChannel service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.InternalServerException">
        /// Unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ResourceNotFoundException">
        /// Request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/DeleteContactChannel">REST API Reference for DeleteContactChannel Operation</seealso>
        DeleteContactChannelResponse DeleteContactChannel(DeleteContactChannelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteContactChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteContactChannel operation on AmazonSSMContactsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteContactChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/DeleteContactChannel">REST API Reference for DeleteContactChannel Operation</seealso>
        IAsyncResult BeginDeleteContactChannel(DeleteContactChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteContactChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteContactChannel.</param>
        /// 
        /// <returns>Returns a  DeleteContactChannelResult from SSMContacts.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/DeleteContactChannel">REST API Reference for DeleteContactChannel Operation</seealso>
        DeleteContactChannelResponse EndDeleteContactChannel(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeEngagement


        /// <summary>
        /// Incident Manager uses engagements to engage contacts and escalation plans during an
        /// incident. Use this command to describe the engagement that occurred during an incident.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEngagement service method.</param>
        /// 
        /// <returns>The response from the DescribeEngagement service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.DataEncryptionException">
        /// The action failed to due an encryption key error.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.InternalServerException">
        /// Unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ResourceNotFoundException">
        /// Request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/DescribeEngagement">REST API Reference for DescribeEngagement Operation</seealso>
        DescribeEngagementResponse DescribeEngagement(DescribeEngagementRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEngagement operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEngagement operation on AmazonSSMContactsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEngagement
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/DescribeEngagement">REST API Reference for DescribeEngagement Operation</seealso>
        IAsyncResult BeginDescribeEngagement(DescribeEngagementRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEngagement operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEngagement.</param>
        /// 
        /// <returns>Returns a  DescribeEngagementResult from SSMContacts.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/DescribeEngagement">REST API Reference for DescribeEngagement Operation</seealso>
        DescribeEngagementResponse EndDescribeEngagement(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribePage


        /// <summary>
        /// Lists details of the engagement to a contact channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePage service method.</param>
        /// 
        /// <returns>The response from the DescribePage service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.DataEncryptionException">
        /// The action failed to due an encryption key error.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.InternalServerException">
        /// Unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ResourceNotFoundException">
        /// Request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/DescribePage">REST API Reference for DescribePage Operation</seealso>
        DescribePageResponse DescribePage(DescribePageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribePage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePage operation on AmazonSSMContactsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribePage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/DescribePage">REST API Reference for DescribePage Operation</seealso>
        IAsyncResult BeginDescribePage(DescribePageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribePage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribePage.</param>
        /// 
        /// <returns>Returns a  DescribePageResult from SSMContacts.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/DescribePage">REST API Reference for DescribePage Operation</seealso>
        DescribePageResponse EndDescribePage(IAsyncResult asyncResult);

        #endregion
        
        #region  GetContact


        /// <summary>
        /// Retrieves information about the specified contact or escalation plan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetContact service method.</param>
        /// 
        /// <returns>The response from the GetContact service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.DataEncryptionException">
        /// The action failed to due an encryption key error.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.InternalServerException">
        /// Unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ResourceNotFoundException">
        /// Request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/GetContact">REST API Reference for GetContact Operation</seealso>
        GetContactResponse GetContact(GetContactRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetContact operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetContact operation on AmazonSSMContactsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetContact
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/GetContact">REST API Reference for GetContact Operation</seealso>
        IAsyncResult BeginGetContact(GetContactRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetContact operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetContact.</param>
        /// 
        /// <returns>Returns a  GetContactResult from SSMContacts.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/GetContact">REST API Reference for GetContact Operation</seealso>
        GetContactResponse EndGetContact(IAsyncResult asyncResult);

        #endregion
        
        #region  GetContactChannel


        /// <summary>
        /// List details about a specific contact channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetContactChannel service method.</param>
        /// 
        /// <returns>The response from the GetContactChannel service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.DataEncryptionException">
        /// The action failed to due an encryption key error.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.InternalServerException">
        /// Unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ResourceNotFoundException">
        /// Request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/GetContactChannel">REST API Reference for GetContactChannel Operation</seealso>
        GetContactChannelResponse GetContactChannel(GetContactChannelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetContactChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetContactChannel operation on AmazonSSMContactsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetContactChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/GetContactChannel">REST API Reference for GetContactChannel Operation</seealso>
        IAsyncResult BeginGetContactChannel(GetContactChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetContactChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetContactChannel.</param>
        /// 
        /// <returns>Returns a  GetContactChannelResult from SSMContacts.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/GetContactChannel">REST API Reference for GetContactChannel Operation</seealso>
        GetContactChannelResponse EndGetContactChannel(IAsyncResult asyncResult);

        #endregion
        
        #region  GetContactPolicy


        /// <summary>
        /// Retrieves the resource policies attached to the specified contact or escalation plan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetContactPolicy service method.</param>
        /// 
        /// <returns>The response from the GetContactPolicy service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.InternalServerException">
        /// Unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ResourceNotFoundException">
        /// Request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/GetContactPolicy">REST API Reference for GetContactPolicy Operation</seealso>
        GetContactPolicyResponse GetContactPolicy(GetContactPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetContactPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetContactPolicy operation on AmazonSSMContactsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetContactPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/GetContactPolicy">REST API Reference for GetContactPolicy Operation</seealso>
        IAsyncResult BeginGetContactPolicy(GetContactPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetContactPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetContactPolicy.</param>
        /// 
        /// <returns>Returns a  GetContactPolicyResult from SSMContacts.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/GetContactPolicy">REST API Reference for GetContactPolicy Operation</seealso>
        GetContactPolicyResponse EndGetContactPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  ListContactChannels


        /// <summary>
        /// Lists all contact channels for the specified contact.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListContactChannels service method.</param>
        /// 
        /// <returns>The response from the ListContactChannels service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.DataEncryptionException">
        /// The action failed to due an encryption key error.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.InternalServerException">
        /// Unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ResourceNotFoundException">
        /// Request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/ListContactChannels">REST API Reference for ListContactChannels Operation</seealso>
        ListContactChannelsResponse ListContactChannels(ListContactChannelsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListContactChannels operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListContactChannels operation on AmazonSSMContactsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListContactChannels
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/ListContactChannels">REST API Reference for ListContactChannels Operation</seealso>
        IAsyncResult BeginListContactChannels(ListContactChannelsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListContactChannels operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListContactChannels.</param>
        /// 
        /// <returns>Returns a  ListContactChannelsResult from SSMContacts.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/ListContactChannels">REST API Reference for ListContactChannels Operation</seealso>
        ListContactChannelsResponse EndListContactChannels(IAsyncResult asyncResult);

        #endregion
        
        #region  ListContacts


        /// <summary>
        /// Lists all contacts and escalation plans in Incident Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListContacts service method.</param>
        /// 
        /// <returns>The response from the ListContacts service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.InternalServerException">
        /// Unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/ListContacts">REST API Reference for ListContacts Operation</seealso>
        ListContactsResponse ListContacts(ListContactsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListContacts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListContacts operation on AmazonSSMContactsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListContacts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/ListContacts">REST API Reference for ListContacts Operation</seealso>
        IAsyncResult BeginListContacts(ListContactsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListContacts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListContacts.</param>
        /// 
        /// <returns>Returns a  ListContactsResult from SSMContacts.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/ListContacts">REST API Reference for ListContacts Operation</seealso>
        ListContactsResponse EndListContacts(IAsyncResult asyncResult);

        #endregion
        
        #region  ListEngagements


        /// <summary>
        /// Lists all engagements that have happened in an incident.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEngagements service method.</param>
        /// 
        /// <returns>The response from the ListEngagements service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.InternalServerException">
        /// Unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/ListEngagements">REST API Reference for ListEngagements Operation</seealso>
        ListEngagementsResponse ListEngagements(ListEngagementsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListEngagements operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEngagements operation on AmazonSSMContactsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListEngagements
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/ListEngagements">REST API Reference for ListEngagements Operation</seealso>
        IAsyncResult BeginListEngagements(ListEngagementsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListEngagements operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEngagements.</param>
        /// 
        /// <returns>Returns a  ListEngagementsResult from SSMContacts.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/ListEngagements">REST API Reference for ListEngagements Operation</seealso>
        ListEngagementsResponse EndListEngagements(IAsyncResult asyncResult);

        #endregion
        
        #region  ListPageReceipts


        /// <summary>
        /// Lists all of the engagements to contact channels that have been acknowledged.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPageReceipts service method.</param>
        /// 
        /// <returns>The response from the ListPageReceipts service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.InternalServerException">
        /// Unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ResourceNotFoundException">
        /// Request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/ListPageReceipts">REST API Reference for ListPageReceipts Operation</seealso>
        ListPageReceiptsResponse ListPageReceipts(ListPageReceiptsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListPageReceipts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPageReceipts operation on AmazonSSMContactsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPageReceipts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/ListPageReceipts">REST API Reference for ListPageReceipts Operation</seealso>
        IAsyncResult BeginListPageReceipts(ListPageReceiptsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListPageReceipts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPageReceipts.</param>
        /// 
        /// <returns>Returns a  ListPageReceiptsResult from SSMContacts.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/ListPageReceipts">REST API Reference for ListPageReceipts Operation</seealso>
        ListPageReceiptsResponse EndListPageReceipts(IAsyncResult asyncResult);

        #endregion
        
        #region  ListPagesByContact


        /// <summary>
        /// Lists the engagements to a contact's contact channels.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPagesByContact service method.</param>
        /// 
        /// <returns>The response from the ListPagesByContact service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.InternalServerException">
        /// Unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ResourceNotFoundException">
        /// Request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/ListPagesByContact">REST API Reference for ListPagesByContact Operation</seealso>
        ListPagesByContactResponse ListPagesByContact(ListPagesByContactRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListPagesByContact operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPagesByContact operation on AmazonSSMContactsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPagesByContact
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/ListPagesByContact">REST API Reference for ListPagesByContact Operation</seealso>
        IAsyncResult BeginListPagesByContact(ListPagesByContactRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListPagesByContact operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPagesByContact.</param>
        /// 
        /// <returns>Returns a  ListPagesByContactResult from SSMContacts.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/ListPagesByContact">REST API Reference for ListPagesByContact Operation</seealso>
        ListPagesByContactResponse EndListPagesByContact(IAsyncResult asyncResult);

        #endregion
        
        #region  ListPagesByEngagement


        /// <summary>
        /// Lists the engagements to contact channels that occurred by engaging a contact.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPagesByEngagement service method.</param>
        /// 
        /// <returns>The response from the ListPagesByEngagement service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.InternalServerException">
        /// Unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ResourceNotFoundException">
        /// Request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/ListPagesByEngagement">REST API Reference for ListPagesByEngagement Operation</seealso>
        ListPagesByEngagementResponse ListPagesByEngagement(ListPagesByEngagementRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListPagesByEngagement operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPagesByEngagement operation on AmazonSSMContactsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPagesByEngagement
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/ListPagesByEngagement">REST API Reference for ListPagesByEngagement Operation</seealso>
        IAsyncResult BeginListPagesByEngagement(ListPagesByEngagementRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListPagesByEngagement operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPagesByEngagement.</param>
        /// 
        /// <returns>Returns a  ListPagesByEngagementResult from SSMContacts.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/ListPagesByEngagement">REST API Reference for ListPagesByEngagement Operation</seealso>
        ListPagesByEngagementResponse EndListPagesByEngagement(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists the tags of an escalation plan or contact.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.InternalServerException">
        /// Unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ResourceNotFoundException">
        /// Request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonSSMContactsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from SSMContacts.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  PutContactPolicy


        /// <summary>
        /// Adds a resource to the specified contact or escalation plan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutContactPolicy service method.</param>
        /// 
        /// <returns>The response from the PutContactPolicy service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ConflictException">
        /// Updating or deleting a resource causes an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.InternalServerException">
        /// Unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ResourceNotFoundException">
        /// Request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/PutContactPolicy">REST API Reference for PutContactPolicy Operation</seealso>
        PutContactPolicyResponse PutContactPolicy(PutContactPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutContactPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutContactPolicy operation on AmazonSSMContactsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutContactPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/PutContactPolicy">REST API Reference for PutContactPolicy Operation</seealso>
        IAsyncResult BeginPutContactPolicy(PutContactPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutContactPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutContactPolicy.</param>
        /// 
        /// <returns>Returns a  PutContactPolicyResult from SSMContacts.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/PutContactPolicy">REST API Reference for PutContactPolicy Operation</seealso>
        PutContactPolicyResponse EndPutContactPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  SendActivationCode


        /// <summary>
        /// Sends an activation code to a contact channel. The contact can use this code to activate
        /// the contact channel in the console or with the <code>ActivateChannel</code> action.
        /// Incident Manager can't engage a contact channel until it has been activated.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendActivationCode service method.</param>
        /// 
        /// <returns>The response from the SendActivationCode service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.DataEncryptionException">
        /// The action failed to due an encryption key error.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.InternalServerException">
        /// Unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ResourceNotFoundException">
        /// Request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/SendActivationCode">REST API Reference for SendActivationCode Operation</seealso>
        SendActivationCodeResponse SendActivationCode(SendActivationCodeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SendActivationCode operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SendActivationCode operation on AmazonSSMContactsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSendActivationCode
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/SendActivationCode">REST API Reference for SendActivationCode Operation</seealso>
        IAsyncResult BeginSendActivationCode(SendActivationCodeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SendActivationCode operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSendActivationCode.</param>
        /// 
        /// <returns>Returns a  SendActivationCodeResult from SSMContacts.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/SendActivationCode">REST API Reference for SendActivationCode Operation</seealso>
        SendActivationCodeResponse EndSendActivationCode(IAsyncResult asyncResult);

        #endregion
        
        #region  StartEngagement


        /// <summary>
        /// Starts an engagement to a contact or escalation plan. The engagement engages each
        /// contact specified in the incident.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartEngagement service method.</param>
        /// 
        /// <returns>The response from the StartEngagement service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.DataEncryptionException">
        /// The action failed to due an encryption key error.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.InternalServerException">
        /// Unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ResourceNotFoundException">
        /// Request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/StartEngagement">REST API Reference for StartEngagement Operation</seealso>
        StartEngagementResponse StartEngagement(StartEngagementRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartEngagement operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartEngagement operation on AmazonSSMContactsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartEngagement
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/StartEngagement">REST API Reference for StartEngagement Operation</seealso>
        IAsyncResult BeginStartEngagement(StartEngagementRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartEngagement operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartEngagement.</param>
        /// 
        /// <returns>Returns a  StartEngagementResult from SSMContacts.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/StartEngagement">REST API Reference for StartEngagement Operation</seealso>
        StartEngagementResponse EndStartEngagement(IAsyncResult asyncResult);

        #endregion
        
        #region  StopEngagement


        /// <summary>
        /// Stops an engagement before it finishes the final stage of the escalation plan or engagement
        /// plan. Further contacts aren't engaged.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopEngagement service method.</param>
        /// 
        /// <returns>The response from the StopEngagement service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.InternalServerException">
        /// Unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ResourceNotFoundException">
        /// Request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/StopEngagement">REST API Reference for StopEngagement Operation</seealso>
        StopEngagementResponse StopEngagement(StopEngagementRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StopEngagement operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopEngagement operation on AmazonSSMContactsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopEngagement
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/StopEngagement">REST API Reference for StopEngagement Operation</seealso>
        IAsyncResult BeginStopEngagement(StopEngagementRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopEngagement operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopEngagement.</param>
        /// 
        /// <returns>Returns a  StopEngagementResult from SSMContacts.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/StopEngagement">REST API Reference for StopEngagement Operation</seealso>
        StopEngagementResponse EndStopEngagement(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Tags a contact or escalation plan. You can tag only contacts and escalation plans
        /// in the first region of your replication set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.InternalServerException">
        /// Unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ResourceNotFoundException">
        /// Request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonSSMContactsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from SSMContacts.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes tags from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.InternalServerException">
        /// Unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ResourceNotFoundException">
        /// Request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonSSMContactsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from SSMContacts.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateContact


        /// <summary>
        /// Updates the contact or escalation plan specified.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateContact service method.</param>
        /// 
        /// <returns>The response from the UpdateContact service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.DataEncryptionException">
        /// The action failed to due an encryption key error.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.InternalServerException">
        /// Unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ResourceNotFoundException">
        /// Request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/UpdateContact">REST API Reference for UpdateContact Operation</seealso>
        UpdateContactResponse UpdateContact(UpdateContactRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateContact operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateContact operation on AmazonSSMContactsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateContact
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/UpdateContact">REST API Reference for UpdateContact Operation</seealso>
        IAsyncResult BeginUpdateContact(UpdateContactRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateContact operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateContact.</param>
        /// 
        /// <returns>Returns a  UpdateContactResult from SSMContacts.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/UpdateContact">REST API Reference for UpdateContact Operation</seealso>
        UpdateContactResponse EndUpdateContact(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateContactChannel


        /// <summary>
        /// Updates a contact's contact channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateContactChannel service method.</param>
        /// 
        /// <returns>The response from the UpdateContactChannel service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ConflictException">
        /// Updating or deleting a resource causes an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.DataEncryptionException">
        /// The action failed to due an encryption key error.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.InternalServerException">
        /// Unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ResourceNotFoundException">
        /// Request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/UpdateContactChannel">REST API Reference for UpdateContactChannel Operation</seealso>
        UpdateContactChannelResponse UpdateContactChannel(UpdateContactChannelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateContactChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateContactChannel operation on AmazonSSMContactsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateContactChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/UpdateContactChannel">REST API Reference for UpdateContactChannel Operation</seealso>
        IAsyncResult BeginUpdateContactChannel(UpdateContactChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateContactChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateContactChannel.</param>
        /// 
        /// <returns>Returns a  UpdateContactChannelResult from SSMContacts.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/UpdateContactChannel">REST API Reference for UpdateContactChannel Operation</seealso>
        UpdateContactChannelResponse EndUpdateContactChannel(IAsyncResult asyncResult);

        #endregion
        
    }
}