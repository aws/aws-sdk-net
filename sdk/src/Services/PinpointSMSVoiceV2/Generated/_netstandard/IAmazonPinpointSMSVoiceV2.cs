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

#pragma warning disable CS1570
namespace Amazon.PinpointSMSVoiceV2
{
    /// <summary>
    /// <para>Interface for accessing PinpointSMSVoiceV2</para>
    ///
    /// Welcome to the <i>AWS End User Messaging SMS and Voice, version 2 API Reference</i>.
    /// This guide provides information about AWS End User Messaging SMS and Voice, version
    /// 2 API resources, including supported HTTP methods, parameters, and schemas.
    /// 
    ///  
    /// <para>
    /// Amazon Pinpoint is an Amazon Web Services service that you can use to engage with
    /// your recipients across multiple messaging channels. The AWS End User Messaging SMS
    /// and Voice, version 2 API provides programmatic access to options that are unique to
    /// the SMS and voice channels. AWS End User Messaging SMS and Voice, version 2 resources
    /// such as phone numbers, sender IDs, and opt-out lists can be used by the Amazon Pinpoint
    /// API.
    /// </para>
    ///  
    /// <para>
    /// If you're new to AWS End User Messaging SMS and Voice, it's also helpful to review
    /// the <a href="https://docs.aws.amazon.com/sms-voice/latest/userguide/what-is-service.html">
    /// AWS End User Messaging SMS User Guide</a>. The <i>AWS End User Messaging SMS User
    /// Guide </i> provides tutorials, code samples, and procedures that demonstrate how to
    /// use AWS End User Messaging SMS and Voice features programmatically and how to integrate
    /// functionality into mobile apps and other types of applications. The guide also provides
    /// key information, such as AWS End User Messaging SMS and Voice integration with other
    /// Amazon Web Services services, and the quotas that apply to use of the service.
    /// </para>
    ///  
    /// <para>
    ///  <b>Regional availability</b> 
    /// </para>
    ///  
    /// <para>
    /// The <i>AWS End User Messaging SMS and Voice version 2 API Reference</i> is available
    /// in several Amazon Web Services Regions and it provides an endpoint for each of these
    /// Regions. For a list of all the Regions and endpoints where the API is currently available,
    /// see <a href="https://docs.aws.amazon.com/general/latest/gr/rande.html#pinpoint_region">Amazon
    /// Web Services Service Endpoints</a> and <a href="https://docs.aws.amazon.com/general/latest/gr/pinpoint.html">Amazon
    /// Pinpoint endpoints and quotas</a> in the Amazon Web Services General Reference. To
    /// learn more about Amazon Web Services Regions, see <a href="https://docs.aws.amazon.com/general/latest/gr/rande-manage.html">Managing
    /// Amazon Web Services Regions</a> in the Amazon Web Services General Reference.
    /// </para>
    ///  
    /// <para>
    /// In each Region, Amazon Web Services maintains multiple Availability Zones. These Availability
    /// Zones are physically isolated from each other, but are united by private, low-latency,
    /// high-throughput, and highly redundant network connections. These Availability Zones
    /// enable us to provide very high levels of availability and redundancy, while also minimizing
    /// latency. To learn more about the number of Availability Zones that are available in
    /// each Region, see <a href="https://aws.amazon.com/about-aws/global-infrastructure/">Amazon
    /// Web Services Global Infrastructure.</a> 
    /// </para>
    /// </summary>
    public partial interface IAmazonPinpointSMSVoiceV2 : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IPinpointSMSVoiceV2PaginatorFactory Paginators { get; }
#endif
                
        #region  AssociateOriginationIdentity



        /// <summary>
        /// Associates the specified origination identity with a pool.
        /// 
        ///  
        /// <para>
        /// If the origination identity is a phone number and is already associated with another
        /// pool, an error is returned. A sender ID can be associated with multiple pools.
        /// </para>
        ///  
        /// <para>
        /// If the origination identity configuration doesn't match the pool's configuration,
        /// an error is returned.
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
        Task<AssociateOriginationIdentityResponse> AssociateOriginationIdentityAsync(AssociateOriginationIdentityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AssociateProtectConfiguration



        /// <summary>
        /// Associate a protect configuration with a configuration set. This replaces the configuration
        /// sets current protect configuration. A configuration set can only be associated with
        /// one protect configuration at a time. A protect configuration can be associated with
        /// multiple configuration sets.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateProtectConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateProtectConfiguration service method, as returned by PinpointSMSVoiceV2.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/AssociateProtectConfiguration">REST API Reference for AssociateProtectConfiguration Operation</seealso>
        Task<AssociateProtectConfigurationResponse> AssociateProtectConfigurationAsync(AssociateProtectConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        Task<CreateConfigurationSetResponse> CreateConfigurationSetAsync(CreateConfigurationSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateEventDestination



        /// <summary>
        /// Creates a new event destination in a configuration set.
        /// 
        ///  
        /// <para>
        /// An event destination is a location where you send message events. The event options
        /// are Amazon CloudWatch, Amazon Data Firehose, or Amazon SNS. For example, when a message
        /// is delivered successfully, you can send information about that event to an event destination,
        /// or send notifications to endpoints that are subscribed to an Amazon SNS topic. 
        /// </para>
        ///  
        /// <para>
        /// You can only create one event destination at a time. You must provide a value for
        /// a single event destination using either <c>CloudWatchLogsDestination</c>, <c>KinesisFirehoseDestination</c>
        /// or <c>SnsDestination</c>. If an event destination isn't provided then an exception
        /// is returned.
        /// </para>
        ///  
        /// <para>
        /// Each configuration set can contain between 0 and 5 event destinations. Each event
        /// destination can contain a reference to a single destination, such as a CloudWatch
        /// or Firehose destination.
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
        Task<CreateEventDestinationResponse> CreateEventDestinationAsync(CreateEventDestinationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateOptOutList



        /// <summary>
        /// Creates a new opt-out list.
        /// 
        ///  
        /// <para>
        /// If the opt-out list name already exists, an error is returned.
        /// </para>
        ///  
        /// <para>
        /// An opt-out list is a list of phone numbers that are opted out, meaning you can't send
        /// SMS or voice messages to them. If end user replies with the keyword "STOP," an entry
        /// for the phone number is added to the opt-out list. In addition to STOP, your recipients
        /// can use any supported opt-out keyword, such as CANCEL or OPTOUT. For a list of supported
        /// opt-out keywords, see <a href="https://docs.aws.amazon.com/pinpoint/latest/userguide/channels-sms-manage.html#channels-sms-manage-optout">
        /// SMS opt out </a> in the <i>AWS End User Messaging SMS User Guide</i>.
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
        Task<CreateOptOutListResponse> CreateOptOutListAsync(CreateOptOutListRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// pool, an error is returned. A sender ID can be associated with multiple pools.
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
        Task<CreatePoolResponse> CreatePoolAsync(CreatePoolRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateProtectConfiguration



        /// <summary>
        /// Create a new protect configuration. By default all country rule sets for each capability
        /// are set to <c>ALLOW</c>. Update the country rule sets using <c>UpdateProtectConfigurationCountryRuleSet</c>.
        /// A protect configurations name is stored as a Tag with the key set to <c>Name</c> and
        /// value as the name of the protect configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProtectConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateProtectConfiguration service method, as returned by PinpointSMSVoiceV2.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/CreateProtectConfiguration">REST API Reference for CreateProtectConfiguration Operation</seealso>
        Task<CreateProtectConfigurationResponse> CreateProtectConfigurationAsync(CreateProtectConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateRegistration



        /// <summary>
        /// Creates a new registration based on the <b>RegistrationType</b> field.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRegistration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRegistration service method, as returned by PinpointSMSVoiceV2.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/CreateRegistration">REST API Reference for CreateRegistration Operation</seealso>
        Task<CreateRegistrationResponse> CreateRegistrationAsync(CreateRegistrationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateRegistrationAssociation



        /// <summary>
        /// Associate the registration with an origination identity such as a phone number or
        /// sender ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRegistrationAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRegistrationAssociation service method, as returned by PinpointSMSVoiceV2.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/CreateRegistrationAssociation">REST API Reference for CreateRegistrationAssociation Operation</seealso>
        Task<CreateRegistrationAssociationResponse> CreateRegistrationAssociationAsync(CreateRegistrationAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateRegistrationAttachment



        /// <summary>
        /// Create a new registration attachment to use for uploading a file or a URL to a file.
        /// The maximum file size is 500KB and valid file extensions are PDF, JPEG and PNG. For
        /// example, many sender ID registrations require a signed “letter of authorization” (LOA)
        /// to be submitted.
        /// 
        ///  
        /// <para>
        /// Use either <c>AttachmentUrl</c> or <c>AttachmentBody</c> to upload your attachment.
        /// If both are specified then an exception is returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRegistrationAttachment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRegistrationAttachment service method, as returned by PinpointSMSVoiceV2.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/CreateRegistrationAttachment">REST API Reference for CreateRegistrationAttachment Operation</seealso>
        Task<CreateRegistrationAttachmentResponse> CreateRegistrationAttachmentAsync(CreateRegistrationAttachmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateRegistrationVersion



        /// <summary>
        /// Create a new version of the registration and increase the <b>VersionNumber</b>. The
        /// previous version of the registration becomes read-only.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRegistrationVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRegistrationVersion service method, as returned by PinpointSMSVoiceV2.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/CreateRegistrationVersion">REST API Reference for CreateRegistrationVersion Operation</seealso>
        Task<CreateRegistrationVersionResponse> CreateRegistrationVersionAsync(CreateRegistrationVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateVerifiedDestinationNumber



        /// <summary>
        /// You can only send messages to verified destination numbers when your account is in
        /// the sandbox. You can add up to 10 verified destination numbers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVerifiedDestinationNumber service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateVerifiedDestinationNumber service method, as returned by PinpointSMSVoiceV2.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/CreateVerifiedDestinationNumber">REST API Reference for CreateVerifiedDestinationNumber Operation</seealso>
        Task<CreateVerifiedDestinationNumberResponse> CreateVerifiedDestinationNumberAsync(CreateVerifiedDestinationNumberRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteAccountDefaultProtectConfiguration



        /// <summary>
        /// Removes the current account default protect configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccountDefaultProtectConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAccountDefaultProtectConfiguration service method, as returned by PinpointSMSVoiceV2.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DeleteAccountDefaultProtectConfiguration">REST API Reference for DeleteAccountDefaultProtectConfiguration Operation</seealso>
        Task<DeleteAccountDefaultProtectConfigurationResponse> DeleteAccountDefaultProtectConfigurationAsync(DeleteAccountDefaultProtectConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        Task<DeleteConfigurationSetResponse> DeleteConfigurationSetAsync(DeleteConfigurationSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        Task<DeleteDefaultMessageTypeResponse> DeleteDefaultMessageTypeAsync(DeleteDefaultMessageTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        Task<DeleteDefaultSenderIdResponse> DeleteDefaultSenderIdAsync(DeleteDefaultSenderIdRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        Task<DeleteEventDestinationResponse> DeleteEventDestinationAsync(DeleteEventDestinationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// receives a message that begins with a keyword, AWS End User Messaging SMS and Voice
        /// responds with a customizable message.
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
        Task<DeleteKeywordResponse> DeleteKeywordAsync(DeleteKeywordRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteMediaMessageSpendLimitOverride



        /// <summary>
        /// Deletes an account-level monthly spending limit override for sending multimedia messages
        /// (MMS). Deleting a spend limit override will set the <c>EnforcedLimit</c> to equal
        /// the <c>MaxLimit</c>, which is controlled by Amazon Web Services. For more information
        /// on spend limits (quotas) see <a href="https://docs.aws.amazon.com/sms-voice/latest/userguide/quotas.html">Quotas
        /// for Server Migration Service</a> in the <i>Server Migration Service User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMediaMessageSpendLimitOverride service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteMediaMessageSpendLimitOverride service method, as returned by PinpointSMSVoiceV2.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DeleteMediaMessageSpendLimitOverride">REST API Reference for DeleteMediaMessageSpendLimitOverride Operation</seealso>
        Task<DeleteMediaMessageSpendLimitOverrideResponse> DeleteMediaMessageSpendLimitOverrideAsync(DeleteMediaMessageSpendLimitOverrideRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// exist, an error is returned.
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
        Task<DeleteOptedOutNumberResponse> DeleteOptedOutNumberAsync(DeleteOptedOutNumberRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteOptOutList



        /// <summary>
        /// Deletes an existing opt-out list. All opted out phone numbers in the opt-out list
        /// are deleted.
        /// 
        ///  
        /// <para>
        /// If the specified opt-out list name doesn't exist or is in-use by an origination phone
        /// number or pool, an error is returned.
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
        Task<DeleteOptOutListResponse> DeleteOptOutListAsync(DeleteOptOutListRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeletePool



        /// <summary>
        /// Deletes an existing pool. Deleting a pool disassociates all origination identities
        /// from that pool.
        /// 
        ///  
        /// <para>
        /// If the pool status isn't active or if deletion protection is enabled, an error is
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
        Task<DeletePoolResponse> DeletePoolAsync(DeletePoolRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteProtectConfiguration



        /// <summary>
        /// Permanently delete the protect configuration. The protect configuration must have
        /// deletion protection disabled and must not be associated as the account default protect
        /// configuration or associated with a configuration set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProtectConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteProtectConfiguration service method, as returned by PinpointSMSVoiceV2.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DeleteProtectConfiguration">REST API Reference for DeleteProtectConfiguration Operation</seealso>
        Task<DeleteProtectConfigurationResponse> DeleteProtectConfigurationAsync(DeleteProtectConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteProtectConfigurationRuleSetNumberOverride



        /// <summary>
        /// Permanently delete the protect configuration rule set number override.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProtectConfigurationRuleSetNumberOverride service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteProtectConfigurationRuleSetNumberOverride service method, as returned by PinpointSMSVoiceV2.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DeleteProtectConfigurationRuleSetNumberOverride">REST API Reference for DeleteProtectConfigurationRuleSetNumberOverride Operation</seealso>
        Task<DeleteProtectConfigurationRuleSetNumberOverrideResponse> DeleteProtectConfigurationRuleSetNumberOverrideAsync(DeleteProtectConfigurationRuleSetNumberOverrideRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteRegistration



        /// <summary>
        /// Permanently delete an existing registration from your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRegistration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRegistration service method, as returned by PinpointSMSVoiceV2.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DeleteRegistration">REST API Reference for DeleteRegistration Operation</seealso>
        Task<DeleteRegistrationResponse> DeleteRegistrationAsync(DeleteRegistrationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteRegistrationAttachment



        /// <summary>
        /// Permanently delete the specified registration attachment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRegistrationAttachment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRegistrationAttachment service method, as returned by PinpointSMSVoiceV2.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DeleteRegistrationAttachment">REST API Reference for DeleteRegistrationAttachment Operation</seealso>
        Task<DeleteRegistrationAttachmentResponse> DeleteRegistrationAttachmentAsync(DeleteRegistrationAttachmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteRegistrationFieldValue



        /// <summary>
        /// Delete the value in a registration form field.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRegistrationFieldValue service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRegistrationFieldValue service method, as returned by PinpointSMSVoiceV2.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DeleteRegistrationFieldValue">REST API Reference for DeleteRegistrationFieldValue Operation</seealso>
        Task<DeleteRegistrationFieldValueResponse> DeleteRegistrationFieldValueAsync(DeleteRegistrationFieldValueRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteResourcePolicy



        /// <summary>
        /// Deletes the resource-based policy document attached to the AWS End User Messaging
        /// SMS and Voice resource. A shared resource can be a Pool, Opt-out list, Sender Id,
        /// or Phone number.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourcePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteResourcePolicy service method, as returned by PinpointSMSVoiceV2.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DeleteResourcePolicy">REST API Reference for DeleteResourcePolicy Operation</seealso>
        Task<DeleteResourcePolicyResponse> DeleteResourcePolicyAsync(DeleteResourcePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteTextMessageSpendLimitOverride



        /// <summary>
        /// Deletes an account-level monthly spending limit override for sending text messages.
        /// Deleting a spend limit override will set the <c>EnforcedLimit</c> to equal the <c>MaxLimit</c>,
        /// which is controlled by Amazon Web Services. For more information on spend limits (quotas)
        /// see <a href="https://docs.aws.amazon.com/sms-voice/latest/userguide/quotas.html">Quotas
        /// </a> in the <i>AWS End User Messaging SMS User Guide</i>.
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
        Task<DeleteTextMessageSpendLimitOverrideResponse> DeleteTextMessageSpendLimitOverrideAsync(DeleteTextMessageSpendLimitOverrideRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteVerifiedDestinationNumber



        /// <summary>
        /// Delete a verified destination phone number.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVerifiedDestinationNumber service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteVerifiedDestinationNumber service method, as returned by PinpointSMSVoiceV2.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DeleteVerifiedDestinationNumber">REST API Reference for DeleteVerifiedDestinationNumber Operation</seealso>
        Task<DeleteVerifiedDestinationNumberResponse> DeleteVerifiedDestinationNumberAsync(DeleteVerifiedDestinationNumberRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteVoiceMessageSpendLimitOverride



        /// <summary>
        /// Deletes an account level monthly spend limit override for sending voice messages.
        /// Deleting a spend limit override sets the <c>EnforcedLimit</c> equal to the <c>MaxLimit</c>,
        /// which is controlled by Amazon Web Services. For more information on spending limits
        /// (quotas) see <a href="https://docs.aws.amazon.com/sms-voice/latest/userguide/quotas.html">Quotas
        /// </a> in the <i>AWS End User Messaging SMS User Guide</i>.
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
        Task<DeleteVoiceMessageSpendLimitOverrideResponse> DeleteVoiceMessageSpendLimitOverrideAsync(DeleteVoiceMessageSpendLimitOverrideRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// New accounts are placed into an SMS or voice sandbox. The sandbox protects both Amazon
        /// Web Services end recipients and SMS or voice recipients from fraud and abuse. 
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
        Task<DescribeAccountAttributesResponse> DescribeAccountAttributesAsync(DescribeAccountAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeAccountLimits



        /// <summary>
        /// Describes the current AWS End User Messaging SMS and Voice SMS Voice V2 resource quotas
        /// for your account. The description for a quota includes the quota name, current usage
        /// toward that quota, and the quota's maximum value.
        /// 
        ///  
        /// <para>
        /// When you establish an Amazon Web Services account, the account has initial quotas
        /// on the maximum number of configuration sets, opt-out lists, phone numbers, and pools
        /// that you can create in a given Region. For more information see <a href="https://docs.aws.amazon.com/sms-voice/latest/userguide/quotas.html">Quotas
        /// </a> in the <i>AWS End User Messaging SMS User Guide</i>.
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
        Task<DescribeAccountLimitsResponse> DescribeAccountLimitsAsync(DescribeAccountLimitsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        Task<DescribeConfigurationSetsResponse> DescribeConfigurationSetsAsync(DescribeConfigurationSetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// receives a message that begins with a keyword, AWS End User Messaging SMS and Voice
        /// responds with a customizable message.
        /// </para>
        ///  
        /// <para>
        /// If you specify a keyword that isn't valid, an error is returned.
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
        Task<DescribeKeywordsResponse> DescribeKeywordsAsync(DescribeKeywordsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// If you specify an opted out number that isn't valid, an exception is returned.
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
        Task<DescribeOptedOutNumbersResponse> DescribeOptedOutNumbersAsync(DescribeOptedOutNumbersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// If you specify an opt-out list name that isn't valid, an error is returned.
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
        Task<DescribeOptOutListsResponse> DescribeOptOutListsAsync(DescribeOptOutListsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// If you specify a phone number ID that isn't valid, an error is returned.
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
        Task<DescribePhoneNumbersResponse> DescribePhoneNumbersAsync(DescribePhoneNumbersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// If you specify a pool ID that isn't valid, an error is returned.
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
        Task<DescribePoolsResponse> DescribePoolsAsync(DescribePoolsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeProtectConfigurations



        /// <summary>
        /// Retrieves the protect configurations that match any of filters. If a filter isn’t
        /// provided then all protect configurations are returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeProtectConfigurations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeProtectConfigurations service method, as returned by PinpointSMSVoiceV2.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DescribeProtectConfigurations">REST API Reference for DescribeProtectConfigurations Operation</seealso>
        Task<DescribeProtectConfigurationsResponse> DescribeProtectConfigurationsAsync(DescribeProtectConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeRegistrationAttachments



        /// <summary>
        /// Retrieves the specified registration attachments or all registration attachments associated
        /// with your Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRegistrationAttachments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeRegistrationAttachments service method, as returned by PinpointSMSVoiceV2.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DescribeRegistrationAttachments">REST API Reference for DescribeRegistrationAttachments Operation</seealso>
        Task<DescribeRegistrationAttachmentsResponse> DescribeRegistrationAttachmentsAsync(DescribeRegistrationAttachmentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeRegistrationFieldDefinitions



        /// <summary>
        /// Retrieves the specified registration type field definitions. You can use DescribeRegistrationFieldDefinitions
        /// to view the requirements for creating, filling out, and submitting each registration
        /// type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRegistrationFieldDefinitions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeRegistrationFieldDefinitions service method, as returned by PinpointSMSVoiceV2.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DescribeRegistrationFieldDefinitions">REST API Reference for DescribeRegistrationFieldDefinitions Operation</seealso>
        Task<DescribeRegistrationFieldDefinitionsResponse> DescribeRegistrationFieldDefinitionsAsync(DescribeRegistrationFieldDefinitionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeRegistrationFieldValues



        /// <summary>
        /// Retrieves the specified registration field values.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRegistrationFieldValues service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeRegistrationFieldValues service method, as returned by PinpointSMSVoiceV2.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DescribeRegistrationFieldValues">REST API Reference for DescribeRegistrationFieldValues Operation</seealso>
        Task<DescribeRegistrationFieldValuesResponse> DescribeRegistrationFieldValuesAsync(DescribeRegistrationFieldValuesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeRegistrations



        /// <summary>
        /// Retrieves the specified registrations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRegistrations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeRegistrations service method, as returned by PinpointSMSVoiceV2.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DescribeRegistrations">REST API Reference for DescribeRegistrations Operation</seealso>
        Task<DescribeRegistrationsResponse> DescribeRegistrationsAsync(DescribeRegistrationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeRegistrationSectionDefinitions



        /// <summary>
        /// Retrieves the specified registration section definitions. You can use DescribeRegistrationSectionDefinitions
        /// to view the requirements for creating, filling out, and submitting each registration
        /// type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRegistrationSectionDefinitions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeRegistrationSectionDefinitions service method, as returned by PinpointSMSVoiceV2.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DescribeRegistrationSectionDefinitions">REST API Reference for DescribeRegistrationSectionDefinitions Operation</seealso>
        Task<DescribeRegistrationSectionDefinitionsResponse> DescribeRegistrationSectionDefinitionsAsync(DescribeRegistrationSectionDefinitionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeRegistrationTypeDefinitions



        /// <summary>
        /// Retrieves the specified registration type definitions. You can use DescribeRegistrationTypeDefinitions
        /// to view the requirements for creating, filling out, and submitting each registration
        /// type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRegistrationTypeDefinitions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeRegistrationTypeDefinitions service method, as returned by PinpointSMSVoiceV2.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DescribeRegistrationTypeDefinitions">REST API Reference for DescribeRegistrationTypeDefinitions Operation</seealso>
        Task<DescribeRegistrationTypeDefinitionsResponse> DescribeRegistrationTypeDefinitionsAsync(DescribeRegistrationTypeDefinitionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeRegistrationVersions



        /// <summary>
        /// Retrieves the specified registration version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRegistrationVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeRegistrationVersions service method, as returned by PinpointSMSVoiceV2.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DescribeRegistrationVersions">REST API Reference for DescribeRegistrationVersions Operation</seealso>
        Task<DescribeRegistrationVersionsResponse> DescribeRegistrationVersionsAsync(DescribeRegistrationVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// f you specify a sender ID that isn't valid, an error is returned.
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
        Task<DescribeSenderIdsResponse> DescribeSenderIdsAsync(DescribeSenderIdsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeSpendLimits



        /// <summary>
        /// Describes the current monthly spend limits for sending voice and text messages.
        /// 
        ///  
        /// <para>
        /// When you establish an Amazon Web Services account, the account has initial monthly
        /// spend limit in a given Region. For more information on increasing your monthly spend
        /// limit, see <a href="https://docs.aws.amazon.com/sms-voice/latest/userguide/awssupport-spend-threshold.html">
        /// Requesting increases to your monthly SMS, MMS, or Voice spending quota </a> in the
        /// <i>AWS End User Messaging SMS User Guide</i>.
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
        Task<DescribeSpendLimitsResponse> DescribeSpendLimitsAsync(DescribeSpendLimitsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeVerifiedDestinationNumbers



        /// <summary>
        /// Retrieves the specified verified destination numbers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVerifiedDestinationNumbers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeVerifiedDestinationNumbers service method, as returned by PinpointSMSVoiceV2.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DescribeVerifiedDestinationNumbers">REST API Reference for DescribeVerifiedDestinationNumbers Operation</seealso>
        Task<DescribeVerifiedDestinationNumbersResponse> DescribeVerifiedDestinationNumbersAsync(DescribeVerifiedDestinationNumbersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisassociateOriginationIdentity



        /// <summary>
        /// Removes the specified origination identity from an existing pool.
        /// 
        ///  
        /// <para>
        /// If the origination identity isn't associated with the specified pool, an error is
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
        Task<DisassociateOriginationIdentityResponse> DisassociateOriginationIdentityAsync(DisassociateOriginationIdentityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisassociateProtectConfiguration



        /// <summary>
        /// Disassociate a protect configuration from a configuration set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateProtectConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateProtectConfiguration service method, as returned by PinpointSMSVoiceV2.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DisassociateProtectConfiguration">REST API Reference for DisassociateProtectConfiguration Operation</seealso>
        Task<DisassociateProtectConfigurationResponse> DisassociateProtectConfigurationAsync(DisassociateProtectConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DiscardRegistrationVersion



        /// <summary>
        /// Discard the current version of the registration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DiscardRegistrationVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DiscardRegistrationVersion service method, as returned by PinpointSMSVoiceV2.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DiscardRegistrationVersion">REST API Reference for DiscardRegistrationVersion Operation</seealso>
        Task<DiscardRegistrationVersionResponse> DiscardRegistrationVersionAsync(DiscardRegistrationVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetProtectConfigurationCountryRuleSet



        /// <summary>
        /// Retrieve the CountryRuleSet for the specified NumberCapability from a protect configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProtectConfigurationCountryRuleSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetProtectConfigurationCountryRuleSet service method, as returned by PinpointSMSVoiceV2.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/GetProtectConfigurationCountryRuleSet">REST API Reference for GetProtectConfigurationCountryRuleSet Operation</seealso>
        Task<GetProtectConfigurationCountryRuleSetResponse> GetProtectConfigurationCountryRuleSetAsync(GetProtectConfigurationCountryRuleSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetResourcePolicy



        /// <summary>
        /// Retrieves the JSON text of the resource-based policy document attached to the AWS
        /// End User Messaging SMS and Voice resource. A shared resource can be a Pool, Opt-out
        /// list, Sender Id, or Phone number.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetResourcePolicy service method, as returned by PinpointSMSVoiceV2.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/GetResourcePolicy">REST API Reference for GetResourcePolicy Operation</seealso>
        Task<GetResourcePolicyResponse> GetResourcePolicyAsync(GetResourcePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        Task<ListPoolOriginationIdentitiesResponse> ListPoolOriginationIdentitiesAsync(ListPoolOriginationIdentitiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListProtectConfigurationRuleSetNumberOverrides



        /// <summary>
        /// Retrieve all of the protect configuration rule set number overrides that match the
        /// filters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProtectConfigurationRuleSetNumberOverrides service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListProtectConfigurationRuleSetNumberOverrides service method, as returned by PinpointSMSVoiceV2.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/ListProtectConfigurationRuleSetNumberOverrides">REST API Reference for ListProtectConfigurationRuleSetNumberOverrides Operation</seealso>
        Task<ListProtectConfigurationRuleSetNumberOverridesResponse> ListProtectConfigurationRuleSetNumberOverridesAsync(ListProtectConfigurationRuleSetNumberOverridesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListRegistrationAssociations



        /// <summary>
        /// Retrieve all of the origination identities that are associated with a registration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRegistrationAssociations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRegistrationAssociations service method, as returned by PinpointSMSVoiceV2.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/ListRegistrationAssociations">REST API Reference for ListRegistrationAssociations Operation</seealso>
        Task<ListRegistrationAssociationsResponse> ListRegistrationAssociationsAsync(ListRegistrationAssociationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource



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
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// receives a message that begins with a keyword, AWS End User Messaging SMS and Voice
        /// responds with a customizable message.
        /// </para>
        ///  
        /// <para>
        /// If you specify a keyword that isn't valid, an error is returned.
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
        Task<PutKeywordResponse> PutKeywordAsync(PutKeywordRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutMessageFeedback



        /// <summary>
        /// Set the MessageFeedbackStatus as <c>RECEIVED</c> or <c>FAILED</c> for the passed in
        /// MessageId. 
        /// 
        ///  
        /// <para>
        /// If you use message feedback then you must update message feedback record. When you
        /// receive a signal that a user has received the message you must use <c>PutMessageFeedback</c>
        /// to set the message feedback record as <c>RECEIVED</c>; Otherwise, an hour after the
        /// message feedback record is set to <c>FAILED</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutMessageFeedback service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutMessageFeedback service method, as returned by PinpointSMSVoiceV2.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/PutMessageFeedback">REST API Reference for PutMessageFeedback Operation</seealso>
        Task<PutMessageFeedbackResponse> PutMessageFeedbackAsync(PutMessageFeedbackRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutOptedOutNumber



        /// <summary>
        /// Creates an opted out destination phone number in the opt-out list.
        /// 
        ///  
        /// <para>
        /// If the destination phone number isn't valid or if the specified opt-out list doesn't
        /// exist, an error is returned.
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
        Task<PutOptedOutNumberResponse> PutOptedOutNumberAsync(PutOptedOutNumberRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutProtectConfigurationRuleSetNumberOverride



        /// <summary>
        /// Create or update a phone number rule override and associate it with a protect configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutProtectConfigurationRuleSetNumberOverride service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutProtectConfigurationRuleSetNumberOverride service method, as returned by PinpointSMSVoiceV2.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/PutProtectConfigurationRuleSetNumberOverride">REST API Reference for PutProtectConfigurationRuleSetNumberOverride Operation</seealso>
        Task<PutProtectConfigurationRuleSetNumberOverrideResponse> PutProtectConfigurationRuleSetNumberOverrideAsync(PutProtectConfigurationRuleSetNumberOverrideRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutRegistrationFieldValue



        /// <summary>
        /// Creates or updates a field value for a registration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutRegistrationFieldValue service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutRegistrationFieldValue service method, as returned by PinpointSMSVoiceV2.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/PutRegistrationFieldValue">REST API Reference for PutRegistrationFieldValue Operation</seealso>
        Task<PutRegistrationFieldValueResponse> PutRegistrationFieldValueAsync(PutRegistrationFieldValueRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutResourcePolicy



        /// <summary>
        /// Attaches a resource-based policy to a AWS End User Messaging SMS and Voice resource(phone
        /// number, sender Id, phone poll, or opt-out list) that is used for sharing the resource.
        /// A shared resource can be a Pool, Opt-out list, Sender Id, or Phone number. For more
        /// information about resource-based policies, see <a href="https://docs.aws.amazon.com/sms-voice/latest/userguide/shared-resources.html">Working
        /// with shared resources</a> in the <i>AWS End User Messaging SMS User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutResourcePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutResourcePolicy service method, as returned by PinpointSMSVoiceV2.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
        Task<PutResourcePolicyResponse> PutResourcePolicyAsync(PutResourcePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ReleasePhoneNumber



        /// <summary>
        /// Releases an existing origination phone number in your account. Once released, a phone
        /// number is no longer available for sending messages.
        /// 
        ///  
        /// <para>
        /// If the origination phone number has deletion protection enabled or is associated with
        /// a pool, an error is returned.
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
        Task<ReleasePhoneNumberResponse> ReleasePhoneNumberAsync(ReleasePhoneNumberRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ReleaseSenderId



        /// <summary>
        /// Releases an existing sender ID in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReleaseSenderId service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ReleaseSenderId service method, as returned by PinpointSMSVoiceV2.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/ReleaseSenderId">REST API Reference for ReleaseSenderId Operation</seealso>
        Task<ReleaseSenderIdResponse> ReleaseSenderIdAsync(ReleaseSenderIdRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RequestPhoneNumber



        /// <summary>
        /// Request an origination phone number for use in your account. For more information
        /// on phone number request see <a href="https://docs.aws.amazon.com/sms-voice/latest/userguide/phone-numbers-request.html">Request
        /// a phone number</a> in the <i>AWS End User Messaging SMS User Guide</i>.
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
        Task<RequestPhoneNumberResponse> RequestPhoneNumberAsync(RequestPhoneNumberRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RequestSenderId



        /// <summary>
        /// Request a new sender ID that doesn't require registration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RequestSenderId service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RequestSenderId service method, as returned by PinpointSMSVoiceV2.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/RequestSenderId">REST API Reference for RequestSenderId Operation</seealso>
        Task<RequestSenderIdResponse> RequestSenderIdAsync(RequestSenderIdRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SendDestinationNumberVerificationCode



        /// <summary>
        /// Before you can send test messages to a verified destination phone number you need
        /// to opt-in the verified destination phone number. Creates a new text message with a
        /// verification code and send it to a verified destination phone number. Once you have
        /// the verification code use <a>VerifyDestinationNumber</a> to opt-in the verified destination
        /// phone number to receive messages.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendDestinationNumberVerificationCode service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SendDestinationNumberVerificationCode service method, as returned by PinpointSMSVoiceV2.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/SendDestinationNumberVerificationCode">REST API Reference for SendDestinationNumberVerificationCode Operation</seealso>
        Task<SendDestinationNumberVerificationCodeResponse> SendDestinationNumberVerificationCodeAsync(SendDestinationNumberVerificationCodeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SendMediaMessage



        /// <summary>
        /// Creates a new multimedia message (MMS) and sends it to a recipient's phone number.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendMediaMessage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SendMediaMessage service method, as returned by PinpointSMSVoiceV2.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/SendMediaMessage">REST API Reference for SendMediaMessage Operation</seealso>
        Task<SendMediaMessageResponse> SendMediaMessageAsync(SendMediaMessageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SendTextMessage



        /// <summary>
        /// Creates a new text message and sends it to a recipient's phone number. SendTextMessage
        /// only sends an SMS message to one recipient each time it is invoked.
        /// 
        ///  
        /// <para>
        /// SMS throughput limits are measured in Message Parts per Second (MPS). Your MPS limit
        /// depends on the destination country of your messages, as well as the type of phone
        /// number (origination number) that you use to send the message. For more information
        /// about MPS, see <a href="https://docs.aws.amazon.com/sms-voice/latest/userguide/sms-limitations-mps.html">Message
        /// Parts per Second (MPS) limits</a> in the <i>AWS End User Messaging SMS User Guide</i>.
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
        Task<SendTextMessageResponse> SendTextMessageAsync(SendTextMessageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SendVoiceMessage



        /// <summary>
        /// Allows you to send a request that sends a voice message. This operation uses <a href="http://aws.amazon.com/polly/">Amazon
        /// Polly</a> to convert a text script into a voice message.
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
        Task<SendVoiceMessageResponse> SendVoiceMessageAsync(SendVoiceMessageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SetAccountDefaultProtectConfiguration



        /// <summary>
        /// Set a protect configuration as your account default. You can only have one account
        /// default protect configuration at a time. The current account default protect configuration
        /// is replaced with the provided protect configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetAccountDefaultProtectConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SetAccountDefaultProtectConfiguration service method, as returned by PinpointSMSVoiceV2.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/SetAccountDefaultProtectConfiguration">REST API Reference for SetAccountDefaultProtectConfiguration Operation</seealso>
        Task<SetAccountDefaultProtectConfigurationResponse> SetAccountDefaultProtectConfigurationAsync(SetAccountDefaultProtectConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SetDefaultMessageFeedbackEnabled



        /// <summary>
        /// Sets a configuration set's default for message feedback.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetDefaultMessageFeedbackEnabled service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SetDefaultMessageFeedbackEnabled service method, as returned by PinpointSMSVoiceV2.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/SetDefaultMessageFeedbackEnabled">REST API Reference for SetDefaultMessageFeedbackEnabled Operation</seealso>
        Task<SetDefaultMessageFeedbackEnabledResponse> SetDefaultMessageFeedbackEnabledAsync(SetDefaultMessageFeedbackEnabledRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        Task<SetDefaultMessageTypeResponse> SetDefaultMessageTypeAsync(SetDefaultMessageTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        Task<SetDefaultSenderIdResponse> SetDefaultSenderIdAsync(SetDefaultSenderIdRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SetMediaMessageSpendLimitOverride



        /// <summary>
        /// Sets an account level monthly spend limit override for sending MMS messages. The requested
        /// spend limit must be less than or equal to the <c>MaxLimit</c>, which is set by Amazon
        /// Web Services.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetMediaMessageSpendLimitOverride service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SetMediaMessageSpendLimitOverride service method, as returned by PinpointSMSVoiceV2.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/SetMediaMessageSpendLimitOverride">REST API Reference for SetMediaMessageSpendLimitOverride Operation</seealso>
        Task<SetMediaMessageSpendLimitOverrideResponse> SetMediaMessageSpendLimitOverrideAsync(SetMediaMessageSpendLimitOverrideRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SetTextMessageSpendLimitOverride



        /// <summary>
        /// Sets an account level monthly spend limit override for sending text messages. The
        /// requested spend limit must be less than or equal to the <c>MaxLimit</c>, which is
        /// set by Amazon Web Services.
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
        Task<SetTextMessageSpendLimitOverrideResponse> SetTextMessageSpendLimitOverrideAsync(SetTextMessageSpendLimitOverrideRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SetVoiceMessageSpendLimitOverride



        /// <summary>
        /// Sets an account level monthly spend limit override for sending voice messages. The
        /// requested spend limit must be less than or equal to the <c>MaxLimit</c>, which is
        /// set by Amazon Web Services.
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
        Task<SetVoiceMessageSpendLimitOverrideResponse> SetVoiceMessageSpendLimitOverrideAsync(SetVoiceMessageSpendLimitOverrideRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SubmitRegistrationVersion



        /// <summary>
        /// Submit the specified registration for review and approval.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SubmitRegistrationVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SubmitRegistrationVersion service method, as returned by PinpointSMSVoiceV2.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/SubmitRegistrationVersion">REST API Reference for SubmitRegistrationVersion Operation</seealso>
        Task<SubmitRegistrationVersionResponse> SubmitRegistrationVersionAsync(SubmitRegistrationVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource



        /// <summary>
        /// Adds or overwrites only the specified tags for the specified resource. When you specify
        /// an existing tag key, the value is overwritten with the new value. Each tag consists
        /// of a key and an optional value. Tag keys must be unique per resource. For more information
        /// about tags, see <a href="https://docs.aws.amazon.com/sms-voice/latest/userguide/phone-numbers-tags.html">Tags
        /// </a> in the <i>AWS End User Messaging SMS User Guide</i>.
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
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource



        /// <summary>
        /// Removes the association of the specified tags from a resource. For more information
        /// on tags see <a href="https://docs.aws.amazon.com/sms-voice/latest/userguide/phone-numbers-tags.html">Tags
        /// </a> in the <i>AWS End User Messaging SMS User Guide</i>.
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
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateEventDestination



        /// <summary>
        /// Updates an existing event destination in a configuration set. You can update the IAM
        /// role ARN for CloudWatch Logs and Firehose. You can also enable or disable the event
        /// destination.
        /// 
        ///  
        /// <para>
        /// You may want to update an event destination to change its matching event types or
        /// updating the destination resource ARN. You can't change an event destination's type
        /// between CloudWatch Logs, Firehose, and Amazon SNS.
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
        Task<UpdateEventDestinationResponse> UpdateEventDestinationAsync(UpdateEventDestinationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdatePhoneNumber



        /// <summary>
        /// Updates the configuration of an existing origination phone number. You can update
        /// the opt-out list, enable or disable two-way messaging, change the TwoWayChannelArn,
        /// enable or disable self-managed opt-outs, and enable or disable deletion protection.
        /// 
        ///  
        /// <para>
        /// If the origination phone number is associated with a pool, an error is returned.
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
        Task<UpdatePhoneNumberResponse> UpdatePhoneNumberAsync(UpdatePhoneNumberRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdatePool



        /// <summary>
        /// Updates the configuration of an existing pool. You can update the opt-out list, enable
        /// or disable two-way messaging, change the <c>TwoWayChannelArn</c>, enable or disable
        /// self-managed opt-outs, enable or disable deletion protection, and enable or disable
        /// shared routes.
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
        Task<UpdatePoolResponse> UpdatePoolAsync(UpdatePoolRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateProtectConfiguration



        /// <summary>
        /// Update the setting for an existing protect configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProtectConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateProtectConfiguration service method, as returned by PinpointSMSVoiceV2.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/UpdateProtectConfiguration">REST API Reference for UpdateProtectConfiguration Operation</seealso>
        Task<UpdateProtectConfigurationResponse> UpdateProtectConfigurationAsync(UpdateProtectConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateProtectConfigurationCountryRuleSet



        /// <summary>
        /// Update a country rule set to <c>ALLOW</c>, <c>BLOCK</c>, <c>MONITOR</c>, or <c>FILTER</c>
        /// messages to be sent to the specified destination counties. You can update one or multiple
        /// countries at a time. The updates are only applied to the specified NumberCapability
        /// type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProtectConfigurationCountryRuleSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateProtectConfigurationCountryRuleSet service method, as returned by PinpointSMSVoiceV2.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/UpdateProtectConfigurationCountryRuleSet">REST API Reference for UpdateProtectConfigurationCountryRuleSet Operation</seealso>
        Task<UpdateProtectConfigurationCountryRuleSetResponse> UpdateProtectConfigurationCountryRuleSetAsync(UpdateProtectConfigurationCountryRuleSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateSenderId



        /// <summary>
        /// Updates the configuration of an existing sender ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSenderId service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSenderId service method, as returned by PinpointSMSVoiceV2.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/UpdateSenderId">REST API Reference for UpdateSenderId Operation</seealso>
        Task<UpdateSenderIdResponse> UpdateSenderIdAsync(UpdateSenderIdRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  VerifyDestinationNumber



        /// <summary>
        /// Use the verification code that was received by the verified destination phone number
        /// to opt-in the verified destination phone number to receive more messages.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the VerifyDestinationNumber service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the VerifyDestinationNumber service method, as returned by PinpointSMSVoiceV2.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/VerifyDestinationNumber">REST API Reference for VerifyDestinationNumber Operation</seealso>
        Task<VerifyDestinationNumberResponse> VerifyDestinationNumberAsync(VerifyDestinationNumberRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonPinpointSMSVoiceV2Config))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonPinpointSMSVoiceV2Config();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
    Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonPinpointSMSVoiceV2Config;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonPinpointSMSVoiceV2Config to create AmazonPinpointSMSVoiceV2Client");
            }

            return awsCredentials == null ? 
                    new AmazonPinpointSMSVoiceV2Client(serviceClientConfig) :
                    new AmazonPinpointSMSVoiceV2Client(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
        #endregion
    }
}