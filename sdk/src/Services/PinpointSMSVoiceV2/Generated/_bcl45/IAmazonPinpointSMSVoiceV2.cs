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
 * Do not modify this file. This file is generated from the pinpoint-sms-voice-v2-2022-03-31.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.PinpointSMSVoiceV2.Model;

namespace Amazon.PinpointSMSVoiceV2
{
    /// <summary>
    /// Interface for accessing PinpointSMSVoiceV2
    ///
    /// Welcome to the <i>Amazon Pinpoint SMS and Voice, version 2 API Reference</i>. This
    /// guide provides information about Amazon Pinpoint SMS and Voice, version 2 API resources,
    /// including supported HTTP methods, parameters, and schemas.
    /// 
    ///  
    /// <para>
    /// Amazon Pinpoint is an Amazon Web Services service that you can use to engage with
    /// your recipients across multiple messaging channels. The Amazon Pinpoint SMS and Voice,
    /// version 2 API provides programmatic access to options that are unique to the SMS and
    /// voice channels and supplements the resources provided by the Amazon Pinpoint API.
    /// </para>
    ///  
    /// <para>
    /// If you're new to Amazon Pinpoint, it's also helpful to review the <a href="https://docs.aws.amazon.com/pinpoint/latest/developerguide/welcome.html">
    /// Amazon Pinpoint Developer Guide</a>. The <i>Amazon Pinpoint Developer Guide</i> provides
    /// tutorials, code samples, and procedures that demonstrate how to use Amazon Pinpoint
    /// features programmatically and how to integrate Amazon Pinpoint functionality into
    /// mobile apps and other types of applications. The guide also provides key information,
    /// such as Amazon Pinpoint integration with other Amazon Web Services services, and the
    /// quotas that apply to use of the service.
    /// </para>
    /// </summary>
    public partial interface IAmazonPinpointSMSVoiceV2 : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        IPinpointSMSVoiceV2PaginatorFactory Paginators { get; }

        
        #region  AssociateOriginationIdentity


        /// <summary>
        /// Associates the specified origination identity with a pool.
        /// 
        ///  
        /// <para>
        /// If the origination identity is a phone number and is already associated with another
        /// pool, an Error is returned. A sender ID can be associated with multiple pools.
        /// </para>
        ///  
        /// <para>
        /// If the origination identity configuration doesn't match the pool's configuration,
        /// an Error is returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateOriginationIdentity service method.</param>
        /// 
        /// <returns>The response from the AssociateOriginationIdentity service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time or it could be that
        /// the requested action isn't valid for the current state or configuration of the resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/AssociateOriginationIdentity">REST API Reference for AssociateOriginationIdentity Operation</seealso>
        AssociateOriginationIdentityResponse AssociateOriginationIdentity(AssociateOriginationIdentityRequest request);



        /// <summary>
        /// Associates the specified origination identity with a pool.
        /// 
        ///  
        /// <para>
        /// If the origination identity is a phone number and is already associated with another
        /// pool, an Error is returned. A sender ID can be associated with multiple pools.
        /// </para>
        ///  
        /// <para>
        /// If the origination identity configuration doesn't match the pool's configuration,
        /// an Error is returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateOriginationIdentity service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateOriginationIdentity service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time or it could be that
        /// the requested action isn't valid for the current state or configuration of the resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/AssociateOriginationIdentity">REST API Reference for AssociateOriginationIdentity Operation</seealso>
        Task<AssociateOriginationIdentityResponse> AssociateOriginationIdentityAsync(AssociateOriginationIdentityRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateConfigurationSet


        /// <summary>
        /// Creates a new configuration set. After you create the configuration set, you can add
        /// one or more event destinations to it.
        /// 
        ///  
        /// <para>
        /// A configuration set is a set of rules that you apply to the SMS and voice messages
        /// that you send.
        /// </para>
        ///  
        /// <para>
        /// When you send a message, you can optionally specify a single configuration set.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConfigurationSet service method.</param>
        /// 
        /// <returns>The response from the CreateConfigurationSet service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time or it could be that
        /// the requested action isn't valid for the current state or configuration of the resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/CreateConfigurationSet">REST API Reference for CreateConfigurationSet Operation</seealso>
        CreateConfigurationSetResponse CreateConfigurationSet(CreateConfigurationSetRequest request);



        /// <summary>
        /// Creates a new configuration set. After you create the configuration set, you can add
        /// one or more event destinations to it.
        /// 
        ///  
        /// <para>
        /// A configuration set is a set of rules that you apply to the SMS and voice messages
        /// that you send.
        /// </para>
        ///  
        /// <para>
        /// When you send a message, you can optionally specify a single configuration set.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConfigurationSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateConfigurationSet service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time or it could be that
        /// the requested action isn't valid for the current state or configuration of the resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/CreateConfigurationSet">REST API Reference for CreateConfigurationSet Operation</seealso>
        Task<CreateConfigurationSetResponse> CreateConfigurationSetAsync(CreateConfigurationSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateEventDestination


        /// <summary>
        /// Creates a new event destination in a configuration set.
        /// 
        ///  
        /// <para>
        /// An event destination is a location where you send message events. The event options
        /// are Amazon CloudWatch, Amazon Kinesis Data Firehose, or Amazon SNS. For example, when
        /// a message is delivered successfully, you can send information about that event to
        /// an event destination, or send notifications to endpoints that are subscribed to an
        /// Amazon SNS topic.
        /// </para>
        ///  
        /// <para>
        /// Each configuration set can contain between 0 and 5 event destinations. Each event
        /// destination can contain a reference to a single destination, such as a CloudWatch
        /// or Kinesis Data Firehose destination.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEventDestination service method.</param>
        /// 
        /// <returns>The response from the CreateEventDestination service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time or it could be that
        /// the requested action isn't valid for the current state or configuration of the resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/CreateEventDestination">REST API Reference for CreateEventDestination Operation</seealso>
        CreateEventDestinationResponse CreateEventDestination(CreateEventDestinationRequest request);



        /// <summary>
        /// Creates a new event destination in a configuration set.
        /// 
        ///  
        /// <para>
        /// An event destination is a location where you send message events. The event options
        /// are Amazon CloudWatch, Amazon Kinesis Data Firehose, or Amazon SNS. For example, when
        /// a message is delivered successfully, you can send information about that event to
        /// an event destination, or send notifications to endpoints that are subscribed to an
        /// Amazon SNS topic.
        /// </para>
        ///  
        /// <para>
        /// Each configuration set can contain between 0 and 5 event destinations. Each event
        /// destination can contain a reference to a single destination, such as a CloudWatch
        /// or Kinesis Data Firehose destination.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEventDestination service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateEventDestination service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time or it could be that
        /// the requested action isn't valid for the current state or configuration of the resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/CreateEventDestination">REST API Reference for CreateEventDestination Operation</seealso>
        Task<CreateEventDestinationResponse> CreateEventDestinationAsync(CreateEventDestinationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateOptOutList


        /// <summary>
        /// Creates a new opt-out list.
        /// 
        ///  
        /// <para>
        /// If the opt-out list name already exists, an Error is returned.
        /// </para>
        ///  
        /// <para>
        /// An opt-out list is a list of phone numbers that are opted out, meaning you can't send
        /// SMS or voice messages to them. If end user replies with the keyword "STOP," an entry
        /// for the phone number is added to the opt-out list. In addition to STOP, your recipients
        /// can use any supported opt-out keyword, such as CANCEL or OPTOUT. For a list of supported
        /// opt-out keywords, see <a href="https://docs.aws.amazon.com/pinpoint/latest/userguide/channels-sms-manage.html#channels-sms-manage-optout">
        /// SMS opt out </a> in the <i>Amazon Pinpoint User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateOptOutList service method.</param>
        /// 
        /// <returns>The response from the CreateOptOutList service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time or it could be that
        /// the requested action isn't valid for the current state or configuration of the resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/CreateOptOutList">REST API Reference for CreateOptOutList Operation</seealso>
        CreateOptOutListResponse CreateOptOutList(CreateOptOutListRequest request);



        /// <summary>
        /// Creates a new opt-out list.
        /// 
        ///  
        /// <para>
        /// If the opt-out list name already exists, an Error is returned.
        /// </para>
        ///  
        /// <para>
        /// An opt-out list is a list of phone numbers that are opted out, meaning you can't send
        /// SMS or voice messages to them. If end user replies with the keyword "STOP," an entry
        /// for the phone number is added to the opt-out list. In addition to STOP, your recipients
        /// can use any supported opt-out keyword, such as CANCEL or OPTOUT. For a list of supported
        /// opt-out keywords, see <a href="https://docs.aws.amazon.com/pinpoint/latest/userguide/channels-sms-manage.html#channels-sms-manage-optout">
        /// SMS opt out </a> in the <i>Amazon Pinpoint User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateOptOutList service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateOptOutList service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time or it could be that
        /// the requested action isn't valid for the current state or configuration of the resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/CreateOptOutList">REST API Reference for CreateOptOutList Operation</seealso>
        Task<CreateOptOutListResponse> CreateOptOutListAsync(CreateOptOutListRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreatePool


        /// <summary>
        /// Creates a new pool and associates the specified origination identity to the pool.
        /// A pool can include one or more phone numbers and SenderIds that are associated with
        /// your Amazon Web Services account.
        /// 
        ///  
        /// <para>
        /// The new pool inherits its configuration from the specified origination identity. This
        /// includes keywords, message type, opt-out list, two-way configuration, and self-managed
        /// opt-out configuration. Deletion protection isn't inherited from the origination identity
        /// and defaults to false.
        /// </para>
        ///  
        /// <para>
        /// If the origination identity is a phone number and is already associated with another
        /// pool, an Error is returned. A sender ID can be associated with multiple pools.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePool service method.</param>
        /// 
        /// <returns>The response from the CreatePool service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time or it could be that
        /// the requested action isn't valid for the current state or configuration of the resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/CreatePool">REST API Reference for CreatePool Operation</seealso>
        CreatePoolResponse CreatePool(CreatePoolRequest request);



        /// <summary>
        /// Creates a new pool and associates the specified origination identity to the pool.
        /// A pool can include one or more phone numbers and SenderIds that are associated with
        /// your Amazon Web Services account.
        /// 
        ///  
        /// <para>
        /// The new pool inherits its configuration from the specified origination identity. This
        /// includes keywords, message type, opt-out list, two-way configuration, and self-managed
        /// opt-out configuration. Deletion protection isn't inherited from the origination identity
        /// and defaults to false.
        /// </para>
        ///  
        /// <para>
        /// If the origination identity is a phone number and is already associated with another
        /// pool, an Error is returned. A sender ID can be associated with multiple pools.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePool service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePool service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time or it could be that
        /// the requested action isn't valid for the current state or configuration of the resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/CreatePool">REST API Reference for CreatePool Operation</seealso>
        Task<CreatePoolResponse> CreatePoolAsync(CreatePoolRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteConfigurationSet


        /// <summary>
        /// Deletes an existing configuration set.
        /// 
        ///  
        /// <para>
        /// A configuration set is a set of rules that you apply to voice and SMS messages that
        /// you send. In a configuration set, you can specify a destination for specific types
        /// of events related to voice and SMS messages. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfigurationSet service method.</param>
        /// 
        /// <returns>The response from the DeleteConfigurationSet service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DeleteConfigurationSet">REST API Reference for DeleteConfigurationSet Operation</seealso>
        DeleteConfigurationSetResponse DeleteConfigurationSet(DeleteConfigurationSetRequest request);



        /// <summary>
        /// Deletes an existing configuration set.
        /// 
        ///  
        /// <para>
        /// A configuration set is a set of rules that you apply to voice and SMS messages that
        /// you send. In a configuration set, you can specify a destination for specific types
        /// of events related to voice and SMS messages. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfigurationSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteConfigurationSet service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DeleteConfigurationSet">REST API Reference for DeleteConfigurationSet Operation</seealso>
        Task<DeleteConfigurationSetResponse> DeleteConfigurationSetAsync(DeleteConfigurationSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteDefaultMessageType


        /// <summary>
        /// Deletes an existing default message type on a configuration set.
        /// 
        ///  
        /// <para>
        ///  A message type is a type of messages that you plan to send. If you send account-related
        /// messages or time-sensitive messages such as one-time passcodes, choose <b>Transactional</b>.
        /// If you plan to send messages that contain marketing material or other promotional
        /// content, choose <b>Promotional</b>. This setting applies to your entire Amazon Web
        /// Services account. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDefaultMessageType service method.</param>
        /// 
        /// <returns>The response from the DeleteDefaultMessageType service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DeleteDefaultMessageType">REST API Reference for DeleteDefaultMessageType Operation</seealso>
        DeleteDefaultMessageTypeResponse DeleteDefaultMessageType(DeleteDefaultMessageTypeRequest request);



        /// <summary>
        /// Deletes an existing default message type on a configuration set.
        /// 
        ///  
        /// <para>
        ///  A message type is a type of messages that you plan to send. If you send account-related
        /// messages or time-sensitive messages such as one-time passcodes, choose <b>Transactional</b>.
        /// If you plan to send messages that contain marketing material or other promotional
        /// content, choose <b>Promotional</b>. This setting applies to your entire Amazon Web
        /// Services account. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDefaultMessageType service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDefaultMessageType service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DeleteDefaultMessageType">REST API Reference for DeleteDefaultMessageType Operation</seealso>
        Task<DeleteDefaultMessageTypeResponse> DeleteDefaultMessageTypeAsync(DeleteDefaultMessageTypeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteDefaultSenderId


        /// <summary>
        /// Deletes an existing default sender ID on a configuration set.
        /// 
        ///  
        /// <para>
        /// A default sender ID is the identity that appears on recipients' devices when they
        /// receive SMS messages. Support for sender ID capabilities varies by country or region.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDefaultSenderId service method.</param>
        /// 
        /// <returns>The response from the DeleteDefaultSenderId service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DeleteDefaultSenderId">REST API Reference for DeleteDefaultSenderId Operation</seealso>
        DeleteDefaultSenderIdResponse DeleteDefaultSenderId(DeleteDefaultSenderIdRequest request);



        /// <summary>
        /// Deletes an existing default sender ID on a configuration set.
        /// 
        ///  
        /// <para>
        /// A default sender ID is the identity that appears on recipients' devices when they
        /// receive SMS messages. Support for sender ID capabilities varies by country or region.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDefaultSenderId service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDefaultSenderId service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DeleteDefaultSenderId">REST API Reference for DeleteDefaultSenderId Operation</seealso>
        Task<DeleteDefaultSenderIdResponse> DeleteDefaultSenderIdAsync(DeleteDefaultSenderIdRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteEventDestination


        /// <summary>
        /// Deletes an existing event destination.
        /// 
        ///  
        /// <para>
        /// An event destination is a location where you send response information about the messages
        /// that you send. For example, when a message is delivered successfully, you can send
        /// information about that event to an Amazon CloudWatch destination, or send notifications
        /// to endpoints that are subscribed to an Amazon SNS topic.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventDestination service method.</param>
        /// 
        /// <returns>The response from the DeleteEventDestination service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DeleteEventDestination">REST API Reference for DeleteEventDestination Operation</seealso>
        DeleteEventDestinationResponse DeleteEventDestination(DeleteEventDestinationRequest request);



        /// <summary>
        /// Deletes an existing event destination.
        /// 
        ///  
        /// <para>
        /// An event destination is a location where you send response information about the messages
        /// that you send. For example, when a message is delivered successfully, you can send
        /// information about that event to an Amazon CloudWatch destination, or send notifications
        /// to endpoints that are subscribed to an Amazon SNS topic.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventDestination service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteEventDestination service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DeleteEventDestination">REST API Reference for DeleteEventDestination Operation</seealso>
        Task<DeleteEventDestinationResponse> DeleteEventDestinationAsync(DeleteEventDestinationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteKeyword


        /// <summary>
        /// Deletes an existing keyword from an origination phone number or pool.
        /// 
        ///  
        /// <para>
        /// A keyword is a word that you can search for on a particular phone number or pool.
        /// It is also a specific word or phrase that an end user can send to your number to elicit
        /// a response, such as an informational message or a special offer. When your number
        /// receives a message that begins with a keyword, Amazon Pinpoint responds with a customizable
        /// message.
        /// </para>
        ///  
        /// <para>
        /// Keywords "HELP" and "STOP" can't be deleted or modified.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteKeyword service method.</param>
        /// 
        /// <returns>The response from the DeleteKeyword service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time or it could be that
        /// the requested action isn't valid for the current state or configuration of the resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DeleteKeyword">REST API Reference for DeleteKeyword Operation</seealso>
        DeleteKeywordResponse DeleteKeyword(DeleteKeywordRequest request);



        /// <summary>
        /// Deletes an existing keyword from an origination phone number or pool.
        /// 
        ///  
        /// <para>
        /// A keyword is a word that you can search for on a particular phone number or pool.
        /// It is also a specific word or phrase that an end user can send to your number to elicit
        /// a response, such as an informational message or a special offer. When your number
        /// receives a message that begins with a keyword, Amazon Pinpoint responds with a customizable
        /// message.
        /// </para>
        ///  
        /// <para>
        /// Keywords "HELP" and "STOP" can't be deleted or modified.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteKeyword service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteKeyword service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time or it could be that
        /// the requested action isn't valid for the current state or configuration of the resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DeleteKeyword">REST API Reference for DeleteKeyword Operation</seealso>
        Task<DeleteKeywordResponse> DeleteKeywordAsync(DeleteKeywordRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteOptedOutNumber


        /// <summary>
        /// Deletes an existing opted out destination phone number from the specified opt-out
        /// list.
        /// 
        ///  
        /// <para>
        /// Each destination phone number can only be deleted once every 30 days.
        /// </para>
        ///  
        /// <para>
        /// If the specified destination phone number doesn't exist or if the opt-out list doesn't
        /// exist, an Error is returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteOptedOutNumber service method.</param>
        /// 
        /// <returns>The response from the DeleteOptedOutNumber service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time or it could be that
        /// the requested action isn't valid for the current state or configuration of the resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DeleteOptedOutNumber">REST API Reference for DeleteOptedOutNumber Operation</seealso>
        DeleteOptedOutNumberResponse DeleteOptedOutNumber(DeleteOptedOutNumberRequest request);



        /// <summary>
        /// Deletes an existing opted out destination phone number from the specified opt-out
        /// list.
        /// 
        ///  
        /// <para>
        /// Each destination phone number can only be deleted once every 30 days.
        /// </para>
        ///  
        /// <para>
        /// If the specified destination phone number doesn't exist or if the opt-out list doesn't
        /// exist, an Error is returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteOptedOutNumber service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteOptedOutNumber service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time or it could be that
        /// the requested action isn't valid for the current state or configuration of the resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DeleteOptedOutNumber">REST API Reference for DeleteOptedOutNumber Operation</seealso>
        Task<DeleteOptedOutNumberResponse> DeleteOptedOutNumberAsync(DeleteOptedOutNumberRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteOptOutList


        /// <summary>
        /// Deletes an existing opt-out list. All opted out phone numbers in the opt-out list
        /// are deleted.
        /// 
        ///  
        /// <para>
        /// If the specified opt-out list name doesn't exist or is in-use by an origination phone
        /// number or pool, an Error is returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteOptOutList service method.</param>
        /// 
        /// <returns>The response from the DeleteOptOutList service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time or it could be that
        /// the requested action isn't valid for the current state or configuration of the resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DeleteOptOutList">REST API Reference for DeleteOptOutList Operation</seealso>
        DeleteOptOutListResponse DeleteOptOutList(DeleteOptOutListRequest request);



        /// <summary>
        /// Deletes an existing opt-out list. All opted out phone numbers in the opt-out list
        /// are deleted.
        /// 
        ///  
        /// <para>
        /// If the specified opt-out list name doesn't exist or is in-use by an origination phone
        /// number or pool, an Error is returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteOptOutList service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteOptOutList service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time or it could be that
        /// the requested action isn't valid for the current state or configuration of the resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DeleteOptOutList">REST API Reference for DeleteOptOutList Operation</seealso>
        Task<DeleteOptOutListResponse> DeleteOptOutListAsync(DeleteOptOutListRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeletePool


        /// <summary>
        /// Deletes an existing pool. Deleting a pool disassociates all origination identities
        /// from that pool.
        /// 
        ///  
        /// <para>
        /// If the pool status isn't active or if deletion protection is enabled, an Error is
        /// returned.
        /// </para>
        ///  
        /// <para>
        /// A pool is a collection of phone numbers and SenderIds. A pool can include one or more
        /// phone numbers and SenderIds that are associated with your Amazon Web Services account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePool service method.</param>
        /// 
        /// <returns>The response from the DeletePool service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time or it could be that
        /// the requested action isn't valid for the current state or configuration of the resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DeletePool">REST API Reference for DeletePool Operation</seealso>
        DeletePoolResponse DeletePool(DeletePoolRequest request);



        /// <summary>
        /// Deletes an existing pool. Deleting a pool disassociates all origination identities
        /// from that pool.
        /// 
        ///  
        /// <para>
        /// If the pool status isn't active or if deletion protection is enabled, an Error is
        /// returned.
        /// </para>
        ///  
        /// <para>
        /// A pool is a collection of phone numbers and SenderIds. A pool can include one or more
        /// phone numbers and SenderIds that are associated with your Amazon Web Services account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePool service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeletePool service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time or it could be that
        /// the requested action isn't valid for the current state or configuration of the resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DeletePool">REST API Reference for DeletePool Operation</seealso>
        Task<DeletePoolResponse> DeletePoolAsync(DeletePoolRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteTextMessageSpendLimitOverride


        /// <summary>
        /// Deletes an account-level monthly spending limit override for sending text messages.
        /// Deleting a spend limit override will set the <code>EnforcedLimit</code> to equal the
        /// <code>MaxLimit</code>, which is controlled by Amazon Web Services. For more information
        /// on spend limits (quotas) see <a href="https://docs.aws.amazon.com/pinpoint/latest/developerguide/quotas.html">Amazon
        /// Pinpoint quotas </a> in the <i>Amazon Pinpoint Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTextMessageSpendLimitOverride service method.</param>
        /// 
        /// <returns>The response from the DeleteTextMessageSpendLimitOverride service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DeleteTextMessageSpendLimitOverride">REST API Reference for DeleteTextMessageSpendLimitOverride Operation</seealso>
        DeleteTextMessageSpendLimitOverrideResponse DeleteTextMessageSpendLimitOverride(DeleteTextMessageSpendLimitOverrideRequest request);



        /// <summary>
        /// Deletes an account-level monthly spending limit override for sending text messages.
        /// Deleting a spend limit override will set the <code>EnforcedLimit</code> to equal the
        /// <code>MaxLimit</code>, which is controlled by Amazon Web Services. For more information
        /// on spend limits (quotas) see <a href="https://docs.aws.amazon.com/pinpoint/latest/developerguide/quotas.html">Amazon
        /// Pinpoint quotas </a> in the <i>Amazon Pinpoint Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTextMessageSpendLimitOverride service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTextMessageSpendLimitOverride service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DeleteTextMessageSpendLimitOverride">REST API Reference for DeleteTextMessageSpendLimitOverride Operation</seealso>
        Task<DeleteTextMessageSpendLimitOverrideResponse> DeleteTextMessageSpendLimitOverrideAsync(DeleteTextMessageSpendLimitOverrideRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteVoiceMessageSpendLimitOverride


        /// <summary>
        /// Deletes an account level monthly spend limit override for sending voice messages.
        /// Deleting a spend limit override sets the <code>EnforcedLimit</code> equal to the <code>MaxLimit</code>,
        /// which is controlled by Amazon Web Services. For more information on spending limits
        /// (quotas) see <a href="https://docs.aws.amazon.com/pinpoint/latest/developerguide/quotas.html">Amazon
        /// Pinpoint quotas</a> in the <i>Amazon Pinpoint Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVoiceMessageSpendLimitOverride service method.</param>
        /// 
        /// <returns>The response from the DeleteVoiceMessageSpendLimitOverride service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DeleteVoiceMessageSpendLimitOverride">REST API Reference for DeleteVoiceMessageSpendLimitOverride Operation</seealso>
        DeleteVoiceMessageSpendLimitOverrideResponse DeleteVoiceMessageSpendLimitOverride(DeleteVoiceMessageSpendLimitOverrideRequest request);



        /// <summary>
        /// Deletes an account level monthly spend limit override for sending voice messages.
        /// Deleting a spend limit override sets the <code>EnforcedLimit</code> equal to the <code>MaxLimit</code>,
        /// which is controlled by Amazon Web Services. For more information on spending limits
        /// (quotas) see <a href="https://docs.aws.amazon.com/pinpoint/latest/developerguide/quotas.html">Amazon
        /// Pinpoint quotas</a> in the <i>Amazon Pinpoint Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVoiceMessageSpendLimitOverride service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteVoiceMessageSpendLimitOverride service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DeleteVoiceMessageSpendLimitOverride">REST API Reference for DeleteVoiceMessageSpendLimitOverride Operation</seealso>
        Task<DeleteVoiceMessageSpendLimitOverrideResponse> DeleteVoiceMessageSpendLimitOverrideAsync(DeleteVoiceMessageSpendLimitOverrideRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeAccountAttributes


        /// <summary>
        /// Describes attributes of your Amazon Web Services account. The supported account attributes
        /// include account tier, which indicates whether your account is in the sandbox or production
        /// environment. When you're ready to move your account out of the sandbox, create an
        /// Amazon Web Services Support case for a service limit increase request.
        /// 
        ///  
        /// <para>
        /// New Amazon Pinpoint accounts are placed into an SMS or voice sandbox. The sandbox
        /// protects both Amazon Web Services end recipients and SMS or voice recipients from
        /// fraud and abuse. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountAttributes service method.</param>
        /// 
        /// <returns>The response from the DescribeAccountAttributes service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DescribeAccountAttributes">REST API Reference for DescribeAccountAttributes Operation</seealso>
        DescribeAccountAttributesResponse DescribeAccountAttributes(DescribeAccountAttributesRequest request);



        /// <summary>
        /// Describes attributes of your Amazon Web Services account. The supported account attributes
        /// include account tier, which indicates whether your account is in the sandbox or production
        /// environment. When you're ready to move your account out of the sandbox, create an
        /// Amazon Web Services Support case for a service limit increase request.
        /// 
        ///  
        /// <para>
        /// New Amazon Pinpoint accounts are placed into an SMS or voice sandbox. The sandbox
        /// protects both Amazon Web Services end recipients and SMS or voice recipients from
        /// fraud and abuse. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAccountAttributes service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DescribeAccountAttributes">REST API Reference for DescribeAccountAttributes Operation</seealso>
        Task<DescribeAccountAttributesResponse> DescribeAccountAttributesAsync(DescribeAccountAttributesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeAccountLimits


        /// <summary>
        /// Describes the current Amazon Pinpoint SMS Voice V2 resource quotas for your account.
        /// The description for a quota includes the quota name, current usage toward that quota,
        /// and the quota's maximum value.
        /// 
        ///  
        /// <para>
        /// When you establish an Amazon Web Services account, the account has initial quotas
        /// on the maximum number of configuration sets, opt-out lists, phone numbers, and pools
        /// that you can create in a given Region. For more information see <a href="https://docs.aws.amazon.com/pinpoint/latest/developerguide/quotas.html">
        /// Amazon Pinpoint quotas </a> in the <i>Amazon Pinpoint Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountLimits service method.</param>
        /// 
        /// <returns>The response from the DescribeAccountLimits service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DescribeAccountLimits">REST API Reference for DescribeAccountLimits Operation</seealso>
        DescribeAccountLimitsResponse DescribeAccountLimits(DescribeAccountLimitsRequest request);



        /// <summary>
        /// Describes the current Amazon Pinpoint SMS Voice V2 resource quotas for your account.
        /// The description for a quota includes the quota name, current usage toward that quota,
        /// and the quota's maximum value.
        /// 
        ///  
        /// <para>
        /// When you establish an Amazon Web Services account, the account has initial quotas
        /// on the maximum number of configuration sets, opt-out lists, phone numbers, and pools
        /// that you can create in a given Region. For more information see <a href="https://docs.aws.amazon.com/pinpoint/latest/developerguide/quotas.html">
        /// Amazon Pinpoint quotas </a> in the <i>Amazon Pinpoint Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountLimits service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAccountLimits service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DescribeAccountLimits">REST API Reference for DescribeAccountLimits Operation</seealso>
        Task<DescribeAccountLimitsResponse> DescribeAccountLimitsAsync(DescribeAccountLimitsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeConfigurationSets


        /// <summary>
        /// Describes the specified configuration sets or all in your account.
        /// 
        ///  
        /// <para>
        /// If you specify configuration set names, the output includes information for only the
        /// specified configuration sets. If you specify filters, the output includes information
        /// for only those configuration sets that meet the filter criteria. If you don't specify
        /// configuration set names or filters, the output includes information for all configuration
        /// sets.
        /// </para>
        ///  
        /// <para>
        /// If you specify a configuration set name that isn't valid, an error is returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConfigurationSets service method.</param>
        /// 
        /// <returns>The response from the DescribeConfigurationSets service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DescribeConfigurationSets">REST API Reference for DescribeConfigurationSets Operation</seealso>
        DescribeConfigurationSetsResponse DescribeConfigurationSets(DescribeConfigurationSetsRequest request);



        /// <summary>
        /// Describes the specified configuration sets or all in your account.
        /// 
        ///  
        /// <para>
        /// If you specify configuration set names, the output includes information for only the
        /// specified configuration sets. If you specify filters, the output includes information
        /// for only those configuration sets that meet the filter criteria. If you don't specify
        /// configuration set names or filters, the output includes information for all configuration
        /// sets.
        /// </para>
        ///  
        /// <para>
        /// If you specify a configuration set name that isn't valid, an error is returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConfigurationSets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeConfigurationSets service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DescribeConfigurationSets">REST API Reference for DescribeConfigurationSets Operation</seealso>
        Task<DescribeConfigurationSetsResponse> DescribeConfigurationSetsAsync(DescribeConfigurationSetsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeKeywords


        /// <summary>
        /// Describes the specified keywords or all keywords on your origination phone number
        /// or pool.
        /// 
        ///  
        /// <para>
        /// A keyword is a word that you can search for on a particular phone number or pool.
        /// It is also a specific word or phrase that an end user can send to your number to elicit
        /// a response, such as an informational message or a special offer. When your number
        /// receives a message that begins with a keyword, Amazon Pinpoint responds with a customizable
        /// message.
        /// </para>
        ///  
        /// <para>
        /// If you specify a keyword that isn't valid, an Error is returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeKeywords service method.</param>
        /// 
        /// <returns>The response from the DescribeKeywords service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DescribeKeywords">REST API Reference for DescribeKeywords Operation</seealso>
        DescribeKeywordsResponse DescribeKeywords(DescribeKeywordsRequest request);



        /// <summary>
        /// Describes the specified keywords or all keywords on your origination phone number
        /// or pool.
        /// 
        ///  
        /// <para>
        /// A keyword is a word that you can search for on a particular phone number or pool.
        /// It is also a specific word or phrase that an end user can send to your number to elicit
        /// a response, such as an informational message or a special offer. When your number
        /// receives a message that begins with a keyword, Amazon Pinpoint responds with a customizable
        /// message.
        /// </para>
        ///  
        /// <para>
        /// If you specify a keyword that isn't valid, an Error is returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeKeywords service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeKeywords service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DescribeKeywords">REST API Reference for DescribeKeywords Operation</seealso>
        Task<DescribeKeywordsResponse> DescribeKeywordsAsync(DescribeKeywordsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeOptedOutNumbers


        /// <summary>
        /// Describes the specified opted out destination numbers or all opted out destination
        /// numbers in an opt-out list.
        /// 
        ///  
        /// <para>
        /// If you specify opted out numbers, the output includes information for only the specified
        /// opted out numbers. If you specify filters, the output includes information for only
        /// those opted out numbers that meet the filter criteria. If you don't specify opted
        /// out numbers or filters, the output includes information for all opted out destination
        /// numbers in your opt-out list.
        /// </para>
        ///  
        /// <para>
        /// If you specify an opted out number that isn't valid, an Error is returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeOptedOutNumbers service method.</param>
        /// 
        /// <returns>The response from the DescribeOptedOutNumbers service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DescribeOptedOutNumbers">REST API Reference for DescribeOptedOutNumbers Operation</seealso>
        DescribeOptedOutNumbersResponse DescribeOptedOutNumbers(DescribeOptedOutNumbersRequest request);



        /// <summary>
        /// Describes the specified opted out destination numbers or all opted out destination
        /// numbers in an opt-out list.
        /// 
        ///  
        /// <para>
        /// If you specify opted out numbers, the output includes information for only the specified
        /// opted out numbers. If you specify filters, the output includes information for only
        /// those opted out numbers that meet the filter criteria. If you don't specify opted
        /// out numbers or filters, the output includes information for all opted out destination
        /// numbers in your opt-out list.
        /// </para>
        ///  
        /// <para>
        /// If you specify an opted out number that isn't valid, an Error is returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeOptedOutNumbers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeOptedOutNumbers service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DescribeOptedOutNumbers">REST API Reference for DescribeOptedOutNumbers Operation</seealso>
        Task<DescribeOptedOutNumbersResponse> DescribeOptedOutNumbersAsync(DescribeOptedOutNumbersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeOptOutLists


        /// <summary>
        /// Describes the specified opt-out list or all opt-out lists in your account.
        /// 
        ///  
        /// <para>
        /// If you specify opt-out list names, the output includes information for only the specified
        /// opt-out lists. Opt-out lists include only those that meet the filter criteria. If
        /// you don't specify opt-out list names or filters, the output includes information for
        /// all opt-out lists.
        /// </para>
        ///  
        /// <para>
        /// If you specify an opt-out list name that isn't valid, an Error is returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeOptOutLists service method.</param>
        /// 
        /// <returns>The response from the DescribeOptOutLists service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DescribeOptOutLists">REST API Reference for DescribeOptOutLists Operation</seealso>
        DescribeOptOutListsResponse DescribeOptOutLists(DescribeOptOutListsRequest request);



        /// <summary>
        /// Describes the specified opt-out list or all opt-out lists in your account.
        /// 
        ///  
        /// <para>
        /// If you specify opt-out list names, the output includes information for only the specified
        /// opt-out lists. Opt-out lists include only those that meet the filter criteria. If
        /// you don't specify opt-out list names or filters, the output includes information for
        /// all opt-out lists.
        /// </para>
        ///  
        /// <para>
        /// If you specify an opt-out list name that isn't valid, an Error is returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeOptOutLists service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeOptOutLists service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DescribeOptOutLists">REST API Reference for DescribeOptOutLists Operation</seealso>
        Task<DescribeOptOutListsResponse> DescribeOptOutListsAsync(DescribeOptOutListsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribePhoneNumbers


        /// <summary>
        /// Describes the specified origination phone number, or all the phone numbers in your
        /// account.
        /// 
        ///  
        /// <para>
        /// If you specify phone number IDs, the output includes information for only the specified
        /// phone numbers. If you specify filters, the output includes information for only those
        /// phone numbers that meet the filter criteria. If you don't specify phone number IDs
        /// or filters, the output includes information for all phone numbers.
        /// </para>
        ///  
        /// <para>
        /// If you specify a phone number ID that isn't valid, an Error is returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePhoneNumbers service method.</param>
        /// 
        /// <returns>The response from the DescribePhoneNumbers service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DescribePhoneNumbers">REST API Reference for DescribePhoneNumbers Operation</seealso>
        DescribePhoneNumbersResponse DescribePhoneNumbers(DescribePhoneNumbersRequest request);



        /// <summary>
        /// Describes the specified origination phone number, or all the phone numbers in your
        /// account.
        /// 
        ///  
        /// <para>
        /// If you specify phone number IDs, the output includes information for only the specified
        /// phone numbers. If you specify filters, the output includes information for only those
        /// phone numbers that meet the filter criteria. If you don't specify phone number IDs
        /// or filters, the output includes information for all phone numbers.
        /// </para>
        ///  
        /// <para>
        /// If you specify a phone number ID that isn't valid, an Error is returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePhoneNumbers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribePhoneNumbers service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DescribePhoneNumbers">REST API Reference for DescribePhoneNumbers Operation</seealso>
        Task<DescribePhoneNumbersResponse> DescribePhoneNumbersAsync(DescribePhoneNumbersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribePools


        /// <summary>
        /// Retrieves the specified pools or all pools associated with your Amazon Web Services
        /// account.
        /// 
        ///  
        /// <para>
        /// If you specify pool IDs, the output includes information for only the specified pools.
        /// If you specify filters, the output includes information for only those pools that
        /// meet the filter criteria. If you don't specify pool IDs or filters, the output includes
        /// information for all pools.
        /// </para>
        ///  
        /// <para>
        /// If you specify a pool ID that isn't valid, an Error is returned.
        /// </para>
        ///  
        /// <para>
        /// A pool is a collection of phone numbers and SenderIds. A pool can include one or more
        /// phone numbers and SenderIds that are associated with your Amazon Web Services account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePools service method.</param>
        /// 
        /// <returns>The response from the DescribePools service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DescribePools">REST API Reference for DescribePools Operation</seealso>
        DescribePoolsResponse DescribePools(DescribePoolsRequest request);



        /// <summary>
        /// Retrieves the specified pools or all pools associated with your Amazon Web Services
        /// account.
        /// 
        ///  
        /// <para>
        /// If you specify pool IDs, the output includes information for only the specified pools.
        /// If you specify filters, the output includes information for only those pools that
        /// meet the filter criteria. If you don't specify pool IDs or filters, the output includes
        /// information for all pools.
        /// </para>
        ///  
        /// <para>
        /// If you specify a pool ID that isn't valid, an Error is returned.
        /// </para>
        ///  
        /// <para>
        /// A pool is a collection of phone numbers and SenderIds. A pool can include one or more
        /// phone numbers and SenderIds that are associated with your Amazon Web Services account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePools service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribePools service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DescribePools">REST API Reference for DescribePools Operation</seealso>
        Task<DescribePoolsResponse> DescribePoolsAsync(DescribePoolsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeSenderIds


        /// <summary>
        /// Describes the specified SenderIds or all SenderIds associated with your Amazon Web
        /// Services account.
        /// 
        ///  
        /// <para>
        /// If you specify SenderIds, the output includes information for only the specified SenderIds.
        /// If you specify filters, the output includes information for only those SenderIds that
        /// meet the filter criteria. If you don't specify SenderIds or filters, the output includes
        /// information for all SenderIds.
        /// </para>
        ///  
        /// <para>
        /// f you specify a sender ID that isn't valid, an Error is returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSenderIds service method.</param>
        /// 
        /// <returns>The response from the DescribeSenderIds service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DescribeSenderIds">REST API Reference for DescribeSenderIds Operation</seealso>
        DescribeSenderIdsResponse DescribeSenderIds(DescribeSenderIdsRequest request);



        /// <summary>
        /// Describes the specified SenderIds or all SenderIds associated with your Amazon Web
        /// Services account.
        /// 
        ///  
        /// <para>
        /// If you specify SenderIds, the output includes information for only the specified SenderIds.
        /// If you specify filters, the output includes information for only those SenderIds that
        /// meet the filter criteria. If you don't specify SenderIds or filters, the output includes
        /// information for all SenderIds.
        /// </para>
        ///  
        /// <para>
        /// f you specify a sender ID that isn't valid, an Error is returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSenderIds service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSenderIds service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DescribeSenderIds">REST API Reference for DescribeSenderIds Operation</seealso>
        Task<DescribeSenderIdsResponse> DescribeSenderIdsAsync(DescribeSenderIdsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeSpendLimits


        /// <summary>
        /// Describes the current Amazon Pinpoint monthly spend limits for sending voice and text
        /// messages.
        /// 
        ///  
        /// <para>
        /// When you establish an Amazon Web Services account, the account has initial monthly
        /// spend limit in a given Region. For more information on increasing your monthly spend
        /// limit, see <a href="https://docs.aws.amazon.com/pinpoint/latest/userguide/channels-sms-awssupport-spend-threshold.html">
        /// Requesting increases to your monthly SMS spending quota for Amazon Pinpoint </a> in
        /// the <i>Amazon Pinpoint User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSpendLimits service method.</param>
        /// 
        /// <returns>The response from the DescribeSpendLimits service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DescribeSpendLimits">REST API Reference for DescribeSpendLimits Operation</seealso>
        DescribeSpendLimitsResponse DescribeSpendLimits(DescribeSpendLimitsRequest request);



        /// <summary>
        /// Describes the current Amazon Pinpoint monthly spend limits for sending voice and text
        /// messages.
        /// 
        ///  
        /// <para>
        /// When you establish an Amazon Web Services account, the account has initial monthly
        /// spend limit in a given Region. For more information on increasing your monthly spend
        /// limit, see <a href="https://docs.aws.amazon.com/pinpoint/latest/userguide/channels-sms-awssupport-spend-threshold.html">
        /// Requesting increases to your monthly SMS spending quota for Amazon Pinpoint </a> in
        /// the <i>Amazon Pinpoint User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSpendLimits service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSpendLimits service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DescribeSpendLimits">REST API Reference for DescribeSpendLimits Operation</seealso>
        Task<DescribeSpendLimitsResponse> DescribeSpendLimitsAsync(DescribeSpendLimitsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DisassociateOriginationIdentity


        /// <summary>
        /// Removes the specified origination identity from an existing pool.
        /// 
        ///  
        /// <para>
        /// If the origination identity isn't associated with the specified pool, an Error is
        /// returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateOriginationIdentity service method.</param>
        /// 
        /// <returns>The response from the DisassociateOriginationIdentity service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time or it could be that
        /// the requested action isn't valid for the current state or configuration of the resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DisassociateOriginationIdentity">REST API Reference for DisassociateOriginationIdentity Operation</seealso>
        DisassociateOriginationIdentityResponse DisassociateOriginationIdentity(DisassociateOriginationIdentityRequest request);



        /// <summary>
        /// Removes the specified origination identity from an existing pool.
        /// 
        ///  
        /// <para>
        /// If the origination identity isn't associated with the specified pool, an Error is
        /// returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateOriginationIdentity service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateOriginationIdentity service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time or it could be that
        /// the requested action isn't valid for the current state or configuration of the resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DisassociateOriginationIdentity">REST API Reference for DisassociateOriginationIdentity Operation</seealso>
        Task<DisassociateOriginationIdentityResponse> DisassociateOriginationIdentityAsync(DisassociateOriginationIdentityRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListPoolOriginationIdentities


        /// <summary>
        /// Lists all associated origination identities in your pool.
        /// 
        ///  
        /// <para>
        /// If you specify filters, the output includes information for only those origination
        /// identities that meet the filter criteria.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPoolOriginationIdentities service method.</param>
        /// 
        /// <returns>The response from the ListPoolOriginationIdentities service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/ListPoolOriginationIdentities">REST API Reference for ListPoolOriginationIdentities Operation</seealso>
        ListPoolOriginationIdentitiesResponse ListPoolOriginationIdentities(ListPoolOriginationIdentitiesRequest request);



        /// <summary>
        /// Lists all associated origination identities in your pool.
        /// 
        ///  
        /// <para>
        /// If you specify filters, the output includes information for only those origination
        /// identities that meet the filter criteria.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPoolOriginationIdentities service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPoolOriginationIdentities service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/ListPoolOriginationIdentities">REST API Reference for ListPoolOriginationIdentities Operation</seealso>
        Task<ListPoolOriginationIdentitiesResponse> ListPoolOriginationIdentitiesAsync(ListPoolOriginationIdentitiesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// List all tags associated with a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);



        /// <summary>
        /// List all tags associated with a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutKeyword


        /// <summary>
        /// Creates or updates a keyword configuration on an origination phone number or pool.
        /// 
        ///  
        /// <para>
        ///  A keyword is a word that you can search for on a particular phone number or pool.
        /// It is also a specific word or phrase that an end user can send to your number to elicit
        /// a response, such as an informational message or a special offer. When your number
        /// receives a message that begins with a keyword, Amazon Pinpoint responds with a customizable
        /// message.
        /// </para>
        ///  
        /// <para>
        /// If you specify a keyword that isn't valid, an Error is returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutKeyword service method.</param>
        /// 
        /// <returns>The response from the PutKeyword service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time or it could be that
        /// the requested action isn't valid for the current state or configuration of the resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/PutKeyword">REST API Reference for PutKeyword Operation</seealso>
        PutKeywordResponse PutKeyword(PutKeywordRequest request);



        /// <summary>
        /// Creates or updates a keyword configuration on an origination phone number or pool.
        /// 
        ///  
        /// <para>
        ///  A keyword is a word that you can search for on a particular phone number or pool.
        /// It is also a specific word or phrase that an end user can send to your number to elicit
        /// a response, such as an informational message or a special offer. When your number
        /// receives a message that begins with a keyword, Amazon Pinpoint responds with a customizable
        /// message.
        /// </para>
        ///  
        /// <para>
        /// If you specify a keyword that isn't valid, an Error is returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutKeyword service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutKeyword service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time or it could be that
        /// the requested action isn't valid for the current state or configuration of the resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/PutKeyword">REST API Reference for PutKeyword Operation</seealso>
        Task<PutKeywordResponse> PutKeywordAsync(PutKeywordRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutOptedOutNumber


        /// <summary>
        /// Creates an opted out destination phone number in the opt-out list.
        /// 
        ///  
        /// <para>
        /// If the destination phone number isn't valid or if the specified opt-out list doesn't
        /// exist, an Error is returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutOptedOutNumber service method.</param>
        /// 
        /// <returns>The response from the PutOptedOutNumber service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/PutOptedOutNumber">REST API Reference for PutOptedOutNumber Operation</seealso>
        PutOptedOutNumberResponse PutOptedOutNumber(PutOptedOutNumberRequest request);



        /// <summary>
        /// Creates an opted out destination phone number in the opt-out list.
        /// 
        ///  
        /// <para>
        /// If the destination phone number isn't valid or if the specified opt-out list doesn't
        /// exist, an Error is returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutOptedOutNumber service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutOptedOutNumber service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/PutOptedOutNumber">REST API Reference for PutOptedOutNumber Operation</seealso>
        Task<PutOptedOutNumberResponse> PutOptedOutNumberAsync(PutOptedOutNumberRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ReleasePhoneNumber


        /// <summary>
        /// Releases an existing origination phone number in your account. Once released, a phone
        /// number is no longer available for sending messages.
        /// 
        ///  
        /// <para>
        /// If the origination phone number has deletion protection enabled or is associated with
        /// a pool, an Error is returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReleasePhoneNumber service method.</param>
        /// 
        /// <returns>The response from the ReleasePhoneNumber service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time or it could be that
        /// the requested action isn't valid for the current state or configuration of the resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/ReleasePhoneNumber">REST API Reference for ReleasePhoneNumber Operation</seealso>
        ReleasePhoneNumberResponse ReleasePhoneNumber(ReleasePhoneNumberRequest request);



        /// <summary>
        /// Releases an existing origination phone number in your account. Once released, a phone
        /// number is no longer available for sending messages.
        /// 
        ///  
        /// <para>
        /// If the origination phone number has deletion protection enabled or is associated with
        /// a pool, an Error is returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReleasePhoneNumber service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ReleasePhoneNumber service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time or it could be that
        /// the requested action isn't valid for the current state or configuration of the resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/ReleasePhoneNumber">REST API Reference for ReleasePhoneNumber Operation</seealso>
        Task<ReleasePhoneNumberResponse> ReleasePhoneNumberAsync(ReleasePhoneNumberRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RequestPhoneNumber


        /// <summary>
        /// Request an origination phone number for use in your account. For more information
        /// on phone number request see <a href="https://docs.aws.amazon.com/pinpoint/latest/userguide/settings-sms-request-number.html">
        /// Requesting a number </a> in the <i>Amazon Pinpoint User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RequestPhoneNumber service method.</param>
        /// 
        /// <returns>The response from the RequestPhoneNumber service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time or it could be that
        /// the requested action isn't valid for the current state or configuration of the resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/RequestPhoneNumber">REST API Reference for RequestPhoneNumber Operation</seealso>
        RequestPhoneNumberResponse RequestPhoneNumber(RequestPhoneNumberRequest request);



        /// <summary>
        /// Request an origination phone number for use in your account. For more information
        /// on phone number request see <a href="https://docs.aws.amazon.com/pinpoint/latest/userguide/settings-sms-request-number.html">
        /// Requesting a number </a> in the <i>Amazon Pinpoint User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RequestPhoneNumber service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RequestPhoneNumber service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time or it could be that
        /// the requested action isn't valid for the current state or configuration of the resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/RequestPhoneNumber">REST API Reference for RequestPhoneNumber Operation</seealso>
        Task<RequestPhoneNumberResponse> RequestPhoneNumberAsync(RequestPhoneNumberRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SendTextMessage


        /// <summary>
        /// Creates a new text message and sends it to a recipient's phone number.
        /// 
        ///  
        /// <para>
        /// SMS throughput limits are measured in Message Parts per Second (MPS). Your MPS limit
        /// depends on the destination country of your messages, as well as the type of phone
        /// number (origination number) that you use to send the message. For more information,
        /// see <a href="https://docs.aws.amazon.com/pinpoint/latest/userguide/channels-sms-limitations-mps.html">Message
        /// Parts per Second (MPS) limits</a> in the <i>Amazon Pinpoint User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendTextMessage service method.</param>
        /// 
        /// <returns>The response from the SendTextMessage service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time or it could be that
        /// the requested action isn't valid for the current state or configuration of the resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/SendTextMessage">REST API Reference for SendTextMessage Operation</seealso>
        SendTextMessageResponse SendTextMessage(SendTextMessageRequest request);



        /// <summary>
        /// Creates a new text message and sends it to a recipient's phone number.
        /// 
        ///  
        /// <para>
        /// SMS throughput limits are measured in Message Parts per Second (MPS). Your MPS limit
        /// depends on the destination country of your messages, as well as the type of phone
        /// number (origination number) that you use to send the message. For more information,
        /// see <a href="https://docs.aws.amazon.com/pinpoint/latest/userguide/channels-sms-limitations-mps.html">Message
        /// Parts per Second (MPS) limits</a> in the <i>Amazon Pinpoint User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendTextMessage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SendTextMessage service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time or it could be that
        /// the requested action isn't valid for the current state or configuration of the resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/SendTextMessage">REST API Reference for SendTextMessage Operation</seealso>
        Task<SendTextMessageResponse> SendTextMessageAsync(SendTextMessageRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SendVoiceMessage


        /// <summary>
        /// Allows you to send a request that sends a text message through Amazon Pinpoint. This
        /// operation uses <a href="http://aws.amazon.com/polly/">Amazon Polly</a> to convert
        /// a text script into a voice message.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendVoiceMessage service method.</param>
        /// 
        /// <returns>The response from the SendVoiceMessage service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time or it could be that
        /// the requested action isn't valid for the current state or configuration of the resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/SendVoiceMessage">REST API Reference for SendVoiceMessage Operation</seealso>
        SendVoiceMessageResponse SendVoiceMessage(SendVoiceMessageRequest request);



        /// <summary>
        /// Allows you to send a request that sends a text message through Amazon Pinpoint. This
        /// operation uses <a href="http://aws.amazon.com/polly/">Amazon Polly</a> to convert
        /// a text script into a voice message.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendVoiceMessage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SendVoiceMessage service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time or it could be that
        /// the requested action isn't valid for the current state or configuration of the resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/SendVoiceMessage">REST API Reference for SendVoiceMessage Operation</seealso>
        Task<SendVoiceMessageResponse> SendVoiceMessageAsync(SendVoiceMessageRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SetDefaultMessageType


        /// <summary>
        /// Sets the default message type on a configuration set.
        /// 
        ///  
        /// <para>
        /// Choose the category of SMS messages that you plan to send from this account. If you
        /// send account-related messages or time-sensitive messages such as one-time passcodes,
        /// choose <b>Transactional</b>. If you plan to send messages that contain marketing material
        /// or other promotional content, choose <b>Promotional</b>. This setting applies to your
        /// entire Amazon Web Services account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetDefaultMessageType service method.</param>
        /// 
        /// <returns>The response from the SetDefaultMessageType service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/SetDefaultMessageType">REST API Reference for SetDefaultMessageType Operation</seealso>
        SetDefaultMessageTypeResponse SetDefaultMessageType(SetDefaultMessageTypeRequest request);



        /// <summary>
        /// Sets the default message type on a configuration set.
        /// 
        ///  
        /// <para>
        /// Choose the category of SMS messages that you plan to send from this account. If you
        /// send account-related messages or time-sensitive messages such as one-time passcodes,
        /// choose <b>Transactional</b>. If you plan to send messages that contain marketing material
        /// or other promotional content, choose <b>Promotional</b>. This setting applies to your
        /// entire Amazon Web Services account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetDefaultMessageType service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SetDefaultMessageType service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/SetDefaultMessageType">REST API Reference for SetDefaultMessageType Operation</seealso>
        Task<SetDefaultMessageTypeResponse> SetDefaultMessageTypeAsync(SetDefaultMessageTypeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SetDefaultSenderId


        /// <summary>
        /// Sets default sender ID on a configuration set.
        /// 
        ///  
        /// <para>
        /// When sending a text message to a destination country that supports sender IDs, the
        /// default sender ID on the configuration set specified will be used if no dedicated
        /// origination phone numbers or registered sender IDs are available in your account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetDefaultSenderId service method.</param>
        /// 
        /// <returns>The response from the SetDefaultSenderId service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/SetDefaultSenderId">REST API Reference for SetDefaultSenderId Operation</seealso>
        SetDefaultSenderIdResponse SetDefaultSenderId(SetDefaultSenderIdRequest request);



        /// <summary>
        /// Sets default sender ID on a configuration set.
        /// 
        ///  
        /// <para>
        /// When sending a text message to a destination country that supports sender IDs, the
        /// default sender ID on the configuration set specified will be used if no dedicated
        /// origination phone numbers or registered sender IDs are available in your account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetDefaultSenderId service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SetDefaultSenderId service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/SetDefaultSenderId">REST API Reference for SetDefaultSenderId Operation</seealso>
        Task<SetDefaultSenderIdResponse> SetDefaultSenderIdAsync(SetDefaultSenderIdRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SetTextMessageSpendLimitOverride


        /// <summary>
        /// Sets an account level monthly spend limit override for sending text messages. The
        /// requested spend limit must be less than or equal to the <code>MaxLimit</code>, which
        /// is set by Amazon Web Services.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetTextMessageSpendLimitOverride service method.</param>
        /// 
        /// <returns>The response from the SetTextMessageSpendLimitOverride service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/SetTextMessageSpendLimitOverride">REST API Reference for SetTextMessageSpendLimitOverride Operation</seealso>
        SetTextMessageSpendLimitOverrideResponse SetTextMessageSpendLimitOverride(SetTextMessageSpendLimitOverrideRequest request);



        /// <summary>
        /// Sets an account level monthly spend limit override for sending text messages. The
        /// requested spend limit must be less than or equal to the <code>MaxLimit</code>, which
        /// is set by Amazon Web Services.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetTextMessageSpendLimitOverride service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SetTextMessageSpendLimitOverride service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/SetTextMessageSpendLimitOverride">REST API Reference for SetTextMessageSpendLimitOverride Operation</seealso>
        Task<SetTextMessageSpendLimitOverrideResponse> SetTextMessageSpendLimitOverrideAsync(SetTextMessageSpendLimitOverrideRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SetVoiceMessageSpendLimitOverride


        /// <summary>
        /// Sets an account level monthly spend limit override for sending voice messages. The
        /// requested spend limit must be less than or equal to the <code>MaxLimit</code>, which
        /// is set by Amazon Web Services.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetVoiceMessageSpendLimitOverride service method.</param>
        /// 
        /// <returns>The response from the SetVoiceMessageSpendLimitOverride service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/SetVoiceMessageSpendLimitOverride">REST API Reference for SetVoiceMessageSpendLimitOverride Operation</seealso>
        SetVoiceMessageSpendLimitOverrideResponse SetVoiceMessageSpendLimitOverride(SetVoiceMessageSpendLimitOverrideRequest request);



        /// <summary>
        /// Sets an account level monthly spend limit override for sending voice messages. The
        /// requested spend limit must be less than or equal to the <code>MaxLimit</code>, which
        /// is set by Amazon Web Services.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetVoiceMessageSpendLimitOverride service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SetVoiceMessageSpendLimitOverride service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/SetVoiceMessageSpendLimitOverride">REST API Reference for SetVoiceMessageSpendLimitOverride Operation</seealso>
        Task<SetVoiceMessageSpendLimitOverrideResponse> SetVoiceMessageSpendLimitOverrideAsync(SetVoiceMessageSpendLimitOverrideRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds or overwrites only the specified tags for the specified Amazon Pinpoint SMS Voice,
        /// version 2 resource. When you specify an existing tag key, the value is overwritten
        /// with the new value. Each resource can have a maximum of 50 tags. Each tag consists
        /// of a key and an optional value. Tag keys must be unique per resource. For more information
        /// about tags, see <a href="https://docs.aws.amazon.com/pinpoint/latest/developerguide/tagging-resources.html">
        /// Tagging Amazon Pinpoint resources</a> in the <i>Amazon Pinpoint Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);



        /// <summary>
        /// Adds or overwrites only the specified tags for the specified Amazon Pinpoint SMS Voice,
        /// version 2 resource. When you specify an existing tag key, the value is overwritten
        /// with the new value. Each resource can have a maximum of 50 tags. Each tag consists
        /// of a key and an optional value. Tag keys must be unique per resource. For more information
        /// about tags, see <a href="https://docs.aws.amazon.com/pinpoint/latest/developerguide/tagging-resources.html">
        /// Tagging Amazon Pinpoint resources</a> in the <i>Amazon Pinpoint Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes the association of the specified tags from an Amazon Pinpoint SMS Voice V2
        /// resource. For more information on tags see <a href="https://docs.aws.amazon.com/pinpoint/latest/developerguide/tagging-resources.html">
        /// Tagging Amazon Pinpoint resources</a> in the <i>Amazon Pinpoint Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);



        /// <summary>
        /// Removes the association of the specified tags from an Amazon Pinpoint SMS Voice V2
        /// resource. For more information on tags see <a href="https://docs.aws.amazon.com/pinpoint/latest/developerguide/tagging-resources.html">
        /// Tagging Amazon Pinpoint resources</a> in the <i>Amazon Pinpoint Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateEventDestination


        /// <summary>
        /// Updates an existing event destination in a configuration set. You can update the IAM
        /// role ARN for CloudWatch Logs and Kinesis Data Firehose. You can also enable or disable
        /// the event destination.
        /// 
        ///  
        /// <para>
        /// You may want to update an event destination to change its matching event types or
        /// updating the destination resource ARN. You can't change an event destination's type
        /// between CloudWatch Logs, Kinesis Data Firehose, and Amazon SNS.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEventDestination service method.</param>
        /// 
        /// <returns>The response from the UpdateEventDestination service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time or it could be that
        /// the requested action isn't valid for the current state or configuration of the resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/UpdateEventDestination">REST API Reference for UpdateEventDestination Operation</seealso>
        UpdateEventDestinationResponse UpdateEventDestination(UpdateEventDestinationRequest request);



        /// <summary>
        /// Updates an existing event destination in a configuration set. You can update the IAM
        /// role ARN for CloudWatch Logs and Kinesis Data Firehose. You can also enable or disable
        /// the event destination.
        /// 
        ///  
        /// <para>
        /// You may want to update an event destination to change its matching event types or
        /// updating the destination resource ARN. You can't change an event destination's type
        /// between CloudWatch Logs, Kinesis Data Firehose, and Amazon SNS.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEventDestination service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateEventDestination service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time or it could be that
        /// the requested action isn't valid for the current state or configuration of the resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/UpdateEventDestination">REST API Reference for UpdateEventDestination Operation</seealso>
        Task<UpdateEventDestinationResponse> UpdateEventDestinationAsync(UpdateEventDestinationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdatePhoneNumber


        /// <summary>
        /// Updates the configuration of an existing origination phone number. You can update
        /// the opt-out list, enable or disable two-way messaging, change the TwoWayChannelArn,
        /// enable or disable self-managed opt-outs, and enable or disable deletion protection.
        /// 
        ///  
        /// <para>
        /// If the origination phone number is associated with a pool, an Error is returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePhoneNumber service method.</param>
        /// 
        /// <returns>The response from the UpdatePhoneNumber service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time or it could be that
        /// the requested action isn't valid for the current state or configuration of the resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/UpdatePhoneNumber">REST API Reference for UpdatePhoneNumber Operation</seealso>
        UpdatePhoneNumberResponse UpdatePhoneNumber(UpdatePhoneNumberRequest request);



        /// <summary>
        /// Updates the configuration of an existing origination phone number. You can update
        /// the opt-out list, enable or disable two-way messaging, change the TwoWayChannelArn,
        /// enable or disable self-managed opt-outs, and enable or disable deletion protection.
        /// 
        ///  
        /// <para>
        /// If the origination phone number is associated with a pool, an Error is returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePhoneNumber service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdatePhoneNumber service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time or it could be that
        /// the requested action isn't valid for the current state or configuration of the resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/UpdatePhoneNumber">REST API Reference for UpdatePhoneNumber Operation</seealso>
        Task<UpdatePhoneNumberResponse> UpdatePhoneNumberAsync(UpdatePhoneNumberRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdatePool


        /// <summary>
        /// Updates the configuration of an existing pool. You can update the opt-out list, enable
        /// or disable two-way messaging, change the <code>TwoWayChannelArn</code>, enable or
        /// disable self-managed opt-outs, enable or disable deletion protection, and enable or
        /// disable shared routes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePool service method.</param>
        /// 
        /// <returns>The response from the UpdatePool service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time or it could be that
        /// the requested action isn't valid for the current state or configuration of the resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/UpdatePool">REST API Reference for UpdatePool Operation</seealso>
        UpdatePoolResponse UpdatePool(UpdatePoolRequest request);



        /// <summary>
        /// Updates the configuration of an existing pool. You can update the opt-out list, enable
        /// or disable two-way messaging, change the <code>TwoWayChannelArn</code>, enable or
        /// disable self-managed opt-outs, enable or disable deletion protection, and enable or
        /// disable shared routes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePool service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdatePool service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time or it could be that
        /// the requested action isn't valid for the current state or configuration of the resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/UpdatePool">REST API Reference for UpdatePool Operation</seealso>
        Task<UpdatePoolResponse> UpdatePoolAsync(UpdatePoolRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}