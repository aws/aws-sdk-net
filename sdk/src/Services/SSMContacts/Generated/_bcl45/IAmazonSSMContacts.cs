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
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.SSMContacts.Model;

namespace Amazon.SSMContacts
{
    /// <summary>
    /// Interface for accessing SSMContacts
    ///
    /// Systems Manager Incident Manager is an incident management console designed to help
    /// users mitigate and recover from incidents affecting their Amazon Web Services-hosted
    /// applications. An incident is any unplanned interruption or reduction in quality of
    /// services.
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

        /// <summary>
        /// Paginators for the service
        /// </summary>
        ISSMContactsPaginatorFactory Paginators { get; }

        
        #region  AcceptPage


        /// <summary>
        /// Used to acknowledge an engagement to a contact channel during an incident.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptPage service method.</param>
        /// 
        /// <returns>The response from the AcceptPage service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
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
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/AcceptPage">REST API Reference for AcceptPage Operation</seealso>
        AcceptPageResponse AcceptPage(AcceptPageRequest request);



        /// <summary>
        /// Used to acknowledge an engagement to a contact channel during an incident.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptPage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AcceptPage service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
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
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/AcceptPage">REST API Reference for AcceptPage Operation</seealso>
        Task<AcceptPageResponse> AcceptPageAsync(AcceptPageRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// You don't have sufficient access to perform this operation.
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
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/ActivateContactChannel">REST API Reference for ActivateContactChannel Operation</seealso>
        ActivateContactChannelResponse ActivateContactChannel(ActivateContactChannelRequest request);



        /// <summary>
        /// Activates a contact's contact channel. Incident Manager can't engage a contact until
        /// the contact channel has been activated.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ActivateContactChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ActivateContactChannel service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
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
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/ActivateContactChannel">REST API Reference for ActivateContactChannel Operation</seealso>
        Task<ActivateContactChannelResponse> ActivateContactChannelAsync(ActivateContactChannelRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ConflictException">
        /// Updating or deleting a resource causes an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.DataEncryptionException">
        /// The operation failed to due an encryption key error.
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
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/CreateContact">REST API Reference for CreateContact Operation</seealso>
        CreateContactResponse CreateContact(CreateContactRequest request);



        /// <summary>
        /// Contacts are either the contacts that Incident Manager engages during an incident
        /// or the escalation plans that Incident Manager uses to engage contacts in phases during
        /// an incident.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateContact service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateContact service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ConflictException">
        /// Updating or deleting a resource causes an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.DataEncryptionException">
        /// The operation failed to due an encryption key error.
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
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/CreateContact">REST API Reference for CreateContact Operation</seealso>
        Task<CreateContactResponse> CreateContactAsync(CreateContactRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateContactChannel


        /// <summary>
        /// A contact channel is the method that Incident Manager uses to engage your contact.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateContactChannel service method.</param>
        /// 
        /// <returns>The response from the CreateContactChannel service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ConflictException">
        /// Updating or deleting a resource causes an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.DataEncryptionException">
        /// The operation failed to due an encryption key error.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.InternalServerException">
        /// Unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/CreateContactChannel">REST API Reference for CreateContactChannel Operation</seealso>
        CreateContactChannelResponse CreateContactChannel(CreateContactChannelRequest request);



        /// <summary>
        /// A contact channel is the method that Incident Manager uses to engage your contact.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateContactChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateContactChannel service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ConflictException">
        /// Updating or deleting a resource causes an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.DataEncryptionException">
        /// The operation failed to due an encryption key error.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.InternalServerException">
        /// Unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/CreateContactChannel">REST API Reference for CreateContactChannel Operation</seealso>
        Task<CreateContactChannelResponse> CreateContactChannelAsync(CreateContactChannelRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateRotation


        /// <summary>
        /// Creates a rotation in an on-call schedule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRotation service method.</param>
        /// 
        /// <returns>The response from the CreateRotation service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
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
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/CreateRotation">REST API Reference for CreateRotation Operation</seealso>
        CreateRotationResponse CreateRotation(CreateRotationRequest request);



        /// <summary>
        /// Creates a rotation in an on-call schedule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRotation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRotation service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
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
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/CreateRotation">REST API Reference for CreateRotation Operation</seealso>
        Task<CreateRotationResponse> CreateRotationAsync(CreateRotationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateRotationOverride


        /// <summary>
        /// Creates an override for a rotation in an on-call schedule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRotationOverride service method.</param>
        /// 
        /// <returns>The response from the CreateRotationOverride service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
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
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/CreateRotationOverride">REST API Reference for CreateRotationOverride Operation</seealso>
        CreateRotationOverrideResponse CreateRotationOverride(CreateRotationOverrideRequest request);



        /// <summary>
        /// Creates an override for a rotation in an on-call schedule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRotationOverride service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRotationOverride service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
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
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/CreateRotationOverride">REST API Reference for CreateRotationOverride Operation</seealso>
        Task<CreateRotationOverrideResponse> CreateRotationOverrideAsync(CreateRotationOverrideRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// You don't have sufficient access to perform this operation.
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
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/DeactivateContactChannel">REST API Reference for DeactivateContactChannel Operation</seealso>
        DeactivateContactChannelResponse DeactivateContactChannel(DeactivateContactChannelRequest request);



        /// <summary>
        /// To no longer receive Incident Manager engagements to a contact channel, you can deactivate
        /// the channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeactivateContactChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeactivateContactChannel service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
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
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/DeactivateContactChannel">REST API Reference for DeactivateContactChannel Operation</seealso>
        Task<DeactivateContactChannelResponse> DeactivateContactChannelAsync(DeactivateContactChannelRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// You don't have sufficient access to perform this operation.
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
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/DeleteContact">REST API Reference for DeleteContact Operation</seealso>
        DeleteContactResponse DeleteContact(DeleteContactRequest request);



        /// <summary>
        /// To remove a contact from Incident Manager, you can delete the contact. Deleting a
        /// contact removes them from all escalation plans and related response plans. Deleting
        /// an escalation plan removes it from all related response plans. You will have to recreate
        /// the contact and its contact channels before you can use it again.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteContact service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteContact service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
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
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/DeleteContact">REST API Reference for DeleteContact Operation</seealso>
        Task<DeleteContactResponse> DeleteContactAsync(DeleteContactRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// You don't have sufficient access to perform this operation.
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
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/DeleteContactChannel">REST API Reference for DeleteContactChannel Operation</seealso>
        DeleteContactChannelResponse DeleteContactChannel(DeleteContactChannelRequest request);



        /// <summary>
        /// To no longer receive engagements on a contact channel, you can delete the channel
        /// from a contact. Deleting the contact channel removes it from the contact's engagement
        /// plan. If you delete the only contact channel for a contact, you won't be able to engage
        /// that contact during an incident.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteContactChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteContactChannel service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
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
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/DeleteContactChannel">REST API Reference for DeleteContactChannel Operation</seealso>
        Task<DeleteContactChannelResponse> DeleteContactChannelAsync(DeleteContactChannelRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteRotation


        /// <summary>
        /// Deletes a rotation from the system. If a rotation belongs to more than one on-call
        /// schedule, this operation deletes it from all of them.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRotation service method.</param>
        /// 
        /// <returns>The response from the DeleteRotation service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
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
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/DeleteRotation">REST API Reference for DeleteRotation Operation</seealso>
        DeleteRotationResponse DeleteRotation(DeleteRotationRequest request);



        /// <summary>
        /// Deletes a rotation from the system. If a rotation belongs to more than one on-call
        /// schedule, this operation deletes it from all of them.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRotation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRotation service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
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
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/DeleteRotation">REST API Reference for DeleteRotation Operation</seealso>
        Task<DeleteRotationResponse> DeleteRotationAsync(DeleteRotationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteRotationOverride


        /// <summary>
        /// Deletes an existing override for an on-call rotation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRotationOverride service method.</param>
        /// 
        /// <returns>The response from the DeleteRotationOverride service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
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
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/DeleteRotationOverride">REST API Reference for DeleteRotationOverride Operation</seealso>
        DeleteRotationOverrideResponse DeleteRotationOverride(DeleteRotationOverrideRequest request);



        /// <summary>
        /// Deletes an existing override for an on-call rotation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRotationOverride service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRotationOverride service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
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
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/DeleteRotationOverride">REST API Reference for DeleteRotationOverride Operation</seealso>
        Task<DeleteRotationOverrideResponse> DeleteRotationOverrideAsync(DeleteRotationOverrideRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.DataEncryptionException">
        /// The operation failed to due an encryption key error.
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
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/DescribeEngagement">REST API Reference for DescribeEngagement Operation</seealso>
        DescribeEngagementResponse DescribeEngagement(DescribeEngagementRequest request);



        /// <summary>
        /// Incident Manager uses engagements to engage contacts and escalation plans during an
        /// incident. Use this command to describe the engagement that occurred during an incident.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEngagement service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEngagement service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.DataEncryptionException">
        /// The operation failed to due an encryption key error.
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
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/DescribeEngagement">REST API Reference for DescribeEngagement Operation</seealso>
        Task<DescribeEngagementResponse> DescribeEngagementAsync(DescribeEngagementRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribePage


        /// <summary>
        /// Lists details of the engagement to a contact channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePage service method.</param>
        /// 
        /// <returns>The response from the DescribePage service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.DataEncryptionException">
        /// The operation failed to due an encryption key error.
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
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/DescribePage">REST API Reference for DescribePage Operation</seealso>
        DescribePageResponse DescribePage(DescribePageRequest request);



        /// <summary>
        /// Lists details of the engagement to a contact channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribePage service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.DataEncryptionException">
        /// The operation failed to due an encryption key error.
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
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/DescribePage">REST API Reference for DescribePage Operation</seealso>
        Task<DescribePageResponse> DescribePageAsync(DescribePageRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetContact


        /// <summary>
        /// Retrieves information about the specified contact or escalation plan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetContact service method.</param>
        /// 
        /// <returns>The response from the GetContact service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.DataEncryptionException">
        /// The operation failed to due an encryption key error.
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
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/GetContact">REST API Reference for GetContact Operation</seealso>
        GetContactResponse GetContact(GetContactRequest request);



        /// <summary>
        /// Retrieves information about the specified contact or escalation plan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetContact service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetContact service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.DataEncryptionException">
        /// The operation failed to due an encryption key error.
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
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/GetContact">REST API Reference for GetContact Operation</seealso>
        Task<GetContactResponse> GetContactAsync(GetContactRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetContactChannel


        /// <summary>
        /// List details about a specific contact channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetContactChannel service method.</param>
        /// 
        /// <returns>The response from the GetContactChannel service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.DataEncryptionException">
        /// The operation failed to due an encryption key error.
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
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/GetContactChannel">REST API Reference for GetContactChannel Operation</seealso>
        GetContactChannelResponse GetContactChannel(GetContactChannelRequest request);



        /// <summary>
        /// List details about a specific contact channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetContactChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetContactChannel service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.DataEncryptionException">
        /// The operation failed to due an encryption key error.
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
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/GetContactChannel">REST API Reference for GetContactChannel Operation</seealso>
        Task<GetContactChannelResponse> GetContactChannelAsync(GetContactChannelRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetContactPolicy


        /// <summary>
        /// Retrieves the resource policies attached to the specified contact or escalation plan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetContactPolicy service method.</param>
        /// 
        /// <returns>The response from the GetContactPolicy service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
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
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/GetContactPolicy">REST API Reference for GetContactPolicy Operation</seealso>
        GetContactPolicyResponse GetContactPolicy(GetContactPolicyRequest request);



        /// <summary>
        /// Retrieves the resource policies attached to the specified contact or escalation plan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetContactPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetContactPolicy service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
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
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/GetContactPolicy">REST API Reference for GetContactPolicy Operation</seealso>
        Task<GetContactPolicyResponse> GetContactPolicyAsync(GetContactPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetRotation


        /// <summary>
        /// Retrieves information about an on-call rotation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRotation service method.</param>
        /// 
        /// <returns>The response from the GetRotation service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
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
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/GetRotation">REST API Reference for GetRotation Operation</seealso>
        GetRotationResponse GetRotation(GetRotationRequest request);



        /// <summary>
        /// Retrieves information about an on-call rotation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRotation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRotation service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
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
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/GetRotation">REST API Reference for GetRotation Operation</seealso>
        Task<GetRotationResponse> GetRotationAsync(GetRotationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetRotationOverride


        /// <summary>
        /// Retrieves information about an override to an on-call rotation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRotationOverride service method.</param>
        /// 
        /// <returns>The response from the GetRotationOverride service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
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
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/GetRotationOverride">REST API Reference for GetRotationOverride Operation</seealso>
        GetRotationOverrideResponse GetRotationOverride(GetRotationOverrideRequest request);



        /// <summary>
        /// Retrieves information about an override to an on-call rotation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRotationOverride service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRotationOverride service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
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
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/GetRotationOverride">REST API Reference for GetRotationOverride Operation</seealso>
        Task<GetRotationOverrideResponse> GetRotationOverrideAsync(GetRotationOverrideRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListContactChannels


        /// <summary>
        /// Lists all contact channels for the specified contact.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListContactChannels service method.</param>
        /// 
        /// <returns>The response from the ListContactChannels service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.DataEncryptionException">
        /// The operation failed to due an encryption key error.
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
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/ListContactChannels">REST API Reference for ListContactChannels Operation</seealso>
        ListContactChannelsResponse ListContactChannels(ListContactChannelsRequest request);



        /// <summary>
        /// Lists all contact channels for the specified contact.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListContactChannels service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListContactChannels service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.DataEncryptionException">
        /// The operation failed to due an encryption key error.
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
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/ListContactChannels">REST API Reference for ListContactChannels Operation</seealso>
        Task<ListContactChannelsResponse> ListContactChannelsAsync(ListContactChannelsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListContacts


        /// <summary>
        /// Lists all contacts and escalation plans in Incident Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListContacts service method.</param>
        /// 
        /// <returns>The response from the ListContacts service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.InternalServerException">
        /// Unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/ListContacts">REST API Reference for ListContacts Operation</seealso>
        ListContactsResponse ListContacts(ListContactsRequest request);



        /// <summary>
        /// Lists all contacts and escalation plans in Incident Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListContacts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListContacts service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.InternalServerException">
        /// Unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/ListContacts">REST API Reference for ListContacts Operation</seealso>
        Task<ListContactsResponse> ListContactsAsync(ListContactsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListEngagements


        /// <summary>
        /// Lists all engagements that have happened in an incident.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEngagements service method.</param>
        /// 
        /// <returns>The response from the ListEngagements service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.InternalServerException">
        /// Unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/ListEngagements">REST API Reference for ListEngagements Operation</seealso>
        ListEngagementsResponse ListEngagements(ListEngagementsRequest request);



        /// <summary>
        /// Lists all engagements that have happened in an incident.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEngagements service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEngagements service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.InternalServerException">
        /// Unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/ListEngagements">REST API Reference for ListEngagements Operation</seealso>
        Task<ListEngagementsResponse> ListEngagementsAsync(ListEngagementsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListPageReceipts


        /// <summary>
        /// Lists all of the engagements to contact channels that have been acknowledged.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPageReceipts service method.</param>
        /// 
        /// <returns>The response from the ListPageReceipts service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
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
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/ListPageReceipts">REST API Reference for ListPageReceipts Operation</seealso>
        ListPageReceiptsResponse ListPageReceipts(ListPageReceiptsRequest request);



        /// <summary>
        /// Lists all of the engagements to contact channels that have been acknowledged.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPageReceipts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPageReceipts service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
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
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/ListPageReceipts">REST API Reference for ListPageReceipts Operation</seealso>
        Task<ListPageReceiptsResponse> ListPageReceiptsAsync(ListPageReceiptsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListPageResolutions


        /// <summary>
        /// Returns the resolution path of an engagement. For example, the escalation plan engaged
        /// in an incident might target an on-call schedule that includes several contacts in
        /// a rotation, but just one contact on-call when the incident starts. The resolution
        /// path indicates the hierarchy of <i>escalation plan &gt; on-call schedule &gt; contact</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPageResolutions service method.</param>
        /// 
        /// <returns>The response from the ListPageResolutions service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
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
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/ListPageResolutions">REST API Reference for ListPageResolutions Operation</seealso>
        ListPageResolutionsResponse ListPageResolutions(ListPageResolutionsRequest request);



        /// <summary>
        /// Returns the resolution path of an engagement. For example, the escalation plan engaged
        /// in an incident might target an on-call schedule that includes several contacts in
        /// a rotation, but just one contact on-call when the incident starts. The resolution
        /// path indicates the hierarchy of <i>escalation plan &gt; on-call schedule &gt; contact</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPageResolutions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPageResolutions service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
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
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/ListPageResolutions">REST API Reference for ListPageResolutions Operation</seealso>
        Task<ListPageResolutionsResponse> ListPageResolutionsAsync(ListPageResolutionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListPagesByContact


        /// <summary>
        /// Lists the engagements to a contact's contact channels.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPagesByContact service method.</param>
        /// 
        /// <returns>The response from the ListPagesByContact service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
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
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/ListPagesByContact">REST API Reference for ListPagesByContact Operation</seealso>
        ListPagesByContactResponse ListPagesByContact(ListPagesByContactRequest request);



        /// <summary>
        /// Lists the engagements to a contact's contact channels.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPagesByContact service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPagesByContact service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
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
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/ListPagesByContact">REST API Reference for ListPagesByContact Operation</seealso>
        Task<ListPagesByContactResponse> ListPagesByContactAsync(ListPagesByContactRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListPagesByEngagement


        /// <summary>
        /// Lists the engagements to contact channels that occurred by engaging a contact.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPagesByEngagement service method.</param>
        /// 
        /// <returns>The response from the ListPagesByEngagement service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
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
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/ListPagesByEngagement">REST API Reference for ListPagesByEngagement Operation</seealso>
        ListPagesByEngagementResponse ListPagesByEngagement(ListPagesByEngagementRequest request);



        /// <summary>
        /// Lists the engagements to contact channels that occurred by engaging a contact.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPagesByEngagement service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPagesByEngagement service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
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
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/ListPagesByEngagement">REST API Reference for ListPagesByEngagement Operation</seealso>
        Task<ListPagesByEngagementResponse> ListPagesByEngagementAsync(ListPagesByEngagementRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListPreviewRotationShifts


        /// <summary>
        /// Returns a list of shifts based on rotation configuration parameters.
        /// 
        ///  <note> 
        /// <para>
        /// The Incident Manager primarily uses this operation to populate the <b>Preview</b>
        /// calendar. It is not typically run by end users.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPreviewRotationShifts service method.</param>
        /// 
        /// <returns>The response from the ListPreviewRotationShifts service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.InternalServerException">
        /// Unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/ListPreviewRotationShifts">REST API Reference for ListPreviewRotationShifts Operation</seealso>
        ListPreviewRotationShiftsResponse ListPreviewRotationShifts(ListPreviewRotationShiftsRequest request);



        /// <summary>
        /// Returns a list of shifts based on rotation configuration parameters.
        /// 
        ///  <note> 
        /// <para>
        /// The Incident Manager primarily uses this operation to populate the <b>Preview</b>
        /// calendar. It is not typically run by end users.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPreviewRotationShifts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPreviewRotationShifts service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.InternalServerException">
        /// Unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/ListPreviewRotationShifts">REST API Reference for ListPreviewRotationShifts Operation</seealso>
        Task<ListPreviewRotationShiftsResponse> ListPreviewRotationShiftsAsync(ListPreviewRotationShiftsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListRotationOverrides


        /// <summary>
        /// Retrieves a list of overrides currently specified for an on-call rotation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRotationOverrides service method.</param>
        /// 
        /// <returns>The response from the ListRotationOverrides service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
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
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/ListRotationOverrides">REST API Reference for ListRotationOverrides Operation</seealso>
        ListRotationOverridesResponse ListRotationOverrides(ListRotationOverridesRequest request);



        /// <summary>
        /// Retrieves a list of overrides currently specified for an on-call rotation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRotationOverrides service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRotationOverrides service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
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
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/ListRotationOverrides">REST API Reference for ListRotationOverrides Operation</seealso>
        Task<ListRotationOverridesResponse> ListRotationOverridesAsync(ListRotationOverridesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListRotations


        /// <summary>
        /// Retrieves a list of on-call rotations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRotations service method.</param>
        /// 
        /// <returns>The response from the ListRotations service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
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
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/ListRotations">REST API Reference for ListRotations Operation</seealso>
        ListRotationsResponse ListRotations(ListRotationsRequest request);



        /// <summary>
        /// Retrieves a list of on-call rotations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRotations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRotations service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
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
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/ListRotations">REST API Reference for ListRotations Operation</seealso>
        Task<ListRotationsResponse> ListRotationsAsync(ListRotationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListRotationShifts


        /// <summary>
        /// Returns a list of shifts generated by an existing rotation in the system.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRotationShifts service method.</param>
        /// 
        /// <returns>The response from the ListRotationShifts service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
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
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/ListRotationShifts">REST API Reference for ListRotationShifts Operation</seealso>
        ListRotationShiftsResponse ListRotationShifts(ListRotationShiftsRequest request);



        /// <summary>
        /// Returns a list of shifts generated by an existing rotation in the system.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRotationShifts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRotationShifts service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
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
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/ListRotationShifts">REST API Reference for ListRotationShifts Operation</seealso>
        Task<ListRotationShiftsResponse> ListRotationShiftsAsync(ListRotationShiftsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists the tags of an escalation plan or contact.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
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
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);



        /// <summary>
        /// Lists the tags of an escalation plan or contact.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
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
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutContactPolicy


        /// <summary>
        /// Adds a resource policy to the specified contact or escalation plan. The resource policy
        /// is used to share the contact or escalation plan using Resource Access Manager (RAM).
        /// For more information about cross-account sharing, see <a href="https://docs.aws.amazon.com/incident-manager/latest/userguide/xa.html">Setting
        /// up cross-account functionality</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutContactPolicy service method.</param>
        /// 
        /// <returns>The response from the PutContactPolicy service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
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
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/PutContactPolicy">REST API Reference for PutContactPolicy Operation</seealso>
        PutContactPolicyResponse PutContactPolicy(PutContactPolicyRequest request);



        /// <summary>
        /// Adds a resource policy to the specified contact or escalation plan. The resource policy
        /// is used to share the contact or escalation plan using Resource Access Manager (RAM).
        /// For more information about cross-account sharing, see <a href="https://docs.aws.amazon.com/incident-manager/latest/userguide/xa.html">Setting
        /// up cross-account functionality</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutContactPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutContactPolicy service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
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
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/PutContactPolicy">REST API Reference for PutContactPolicy Operation</seealso>
        Task<PutContactPolicyResponse> PutContactPolicyAsync(PutContactPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SendActivationCode


        /// <summary>
        /// Sends an activation code to a contact channel. The contact can use this code to activate
        /// the contact channel in the console or with the <code>ActivateChannel</code> operation.
        /// Incident Manager can't engage a contact channel until it has been activated.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendActivationCode service method.</param>
        /// 
        /// <returns>The response from the SendActivationCode service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.DataEncryptionException">
        /// The operation failed to due an encryption key error.
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
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/SendActivationCode">REST API Reference for SendActivationCode Operation</seealso>
        SendActivationCodeResponse SendActivationCode(SendActivationCodeRequest request);



        /// <summary>
        /// Sends an activation code to a contact channel. The contact can use this code to activate
        /// the contact channel in the console or with the <code>ActivateChannel</code> operation.
        /// Incident Manager can't engage a contact channel until it has been activated.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendActivationCode service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SendActivationCode service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.DataEncryptionException">
        /// The operation failed to due an encryption key error.
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
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/SendActivationCode">REST API Reference for SendActivationCode Operation</seealso>
        Task<SendActivationCodeResponse> SendActivationCodeAsync(SendActivationCodeRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.DataEncryptionException">
        /// The operation failed to due an encryption key error.
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
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/StartEngagement">REST API Reference for StartEngagement Operation</seealso>
        StartEngagementResponse StartEngagement(StartEngagementRequest request);



        /// <summary>
        /// Starts an engagement to a contact or escalation plan. The engagement engages each
        /// contact specified in the incident.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartEngagement service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartEngagement service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.DataEncryptionException">
        /// The operation failed to due an encryption key error.
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
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/StartEngagement">REST API Reference for StartEngagement Operation</seealso>
        Task<StartEngagementResponse> StartEngagementAsync(StartEngagementRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// You don't have sufficient access to perform this operation.
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
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/StopEngagement">REST API Reference for StopEngagement Operation</seealso>
        StopEngagementResponse StopEngagement(StopEngagementRequest request);



        /// <summary>
        /// Stops an engagement before it finishes the final stage of the escalation plan or engagement
        /// plan. Further contacts aren't engaged.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopEngagement service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopEngagement service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
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
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/StopEngagement">REST API Reference for StopEngagement Operation</seealso>
        Task<StopEngagementResponse> StopEngagementAsync(StopEngagementRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// You don't have sufficient access to perform this operation.
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
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);



        /// <summary>
        /// Tags a contact or escalation plan. You can tag only contacts and escalation plans
        /// in the first region of your replication set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
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
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes tags from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
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
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);



        /// <summary>
        /// Removes tags from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
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
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateContact


        /// <summary>
        /// Updates the contact or escalation plan specified.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateContact service method.</param>
        /// 
        /// <returns>The response from the UpdateContact service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.DataEncryptionException">
        /// The operation failed to due an encryption key error.
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
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/UpdateContact">REST API Reference for UpdateContact Operation</seealso>
        UpdateContactResponse UpdateContact(UpdateContactRequest request);



        /// <summary>
        /// Updates the contact or escalation plan specified.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateContact service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateContact service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.DataEncryptionException">
        /// The operation failed to due an encryption key error.
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
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/UpdateContact">REST API Reference for UpdateContact Operation</seealso>
        Task<UpdateContactResponse> UpdateContactAsync(UpdateContactRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateContactChannel


        /// <summary>
        /// Updates a contact's contact channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateContactChannel service method.</param>
        /// 
        /// <returns>The response from the UpdateContactChannel service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ConflictException">
        /// Updating or deleting a resource causes an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.DataEncryptionException">
        /// The operation failed to due an encryption key error.
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
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/UpdateContactChannel">REST API Reference for UpdateContactChannel Operation</seealso>
        UpdateContactChannelResponse UpdateContactChannel(UpdateContactChannelRequest request);



        /// <summary>
        /// Updates a contact's contact channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateContactChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateContactChannel service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.ConflictException">
        /// Updating or deleting a resource causes an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.SSMContacts.Model.DataEncryptionException">
        /// The operation failed to due an encryption key error.
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
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/UpdateContactChannel">REST API Reference for UpdateContactChannel Operation</seealso>
        Task<UpdateContactChannelResponse> UpdateContactChannelAsync(UpdateContactChannelRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateRotation


        /// <summary>
        /// Updates the information specified for an on-call rotation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRotation service method.</param>
        /// 
        /// <returns>The response from the UpdateRotation service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
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
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/UpdateRotation">REST API Reference for UpdateRotation Operation</seealso>
        UpdateRotationResponse UpdateRotation(UpdateRotationRequest request);



        /// <summary>
        /// Updates the information specified for an on-call rotation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRotation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateRotation service method, as returned by SSMContacts.</returns>
        /// <exception cref="Amazon.SSMContacts.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
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
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-contacts-2021-05-03/UpdateRotation">REST API Reference for UpdateRotation Operation</seealso>
        Task<UpdateRotationResponse> UpdateRotationAsync(UpdateRotationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}