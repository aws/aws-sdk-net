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
 * Do not modify this file. This file is generated from the chime-sdk-voice-2022-08-03.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.ChimeSDKVoice.Model;

namespace Amazon.ChimeSDKVoice
{
    /// <summary>
    /// Interface for accessing ChimeSDKVoice
    ///
    /// The Amazon Chime SDK telephony APIs in this section enable developers to create PSTN
    /// calling solutions that use Amazon Chime SDK Voice Connectors, and Amazon Chime SDK
    /// SIP media applications. Developers can also order and manage phone numbers, create
    /// and manage Voice Connectors and SIP media applications, and run voice analytics.
    /// </summary>
    public partial interface IAmazonChimeSDKVoice : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IChimeSDKVoicePaginatorFactory Paginators { get; }
#endif
                
        #region  AssociatePhoneNumbersWithVoiceConnector



        /// <summary>
        /// Associates phone numbers with the specified Amazon Chime SDK Voice Connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociatePhoneNumbersWithVoiceConnector service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociatePhoneNumbersWithVoiceConnector service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.AccessDeniedException">
        /// You don't have the permissions needed to run this action.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/AssociatePhoneNumbersWithVoiceConnector">REST API Reference for AssociatePhoneNumbersWithVoiceConnector Operation</seealso>
        Task<AssociatePhoneNumbersWithVoiceConnectorResponse> AssociatePhoneNumbersWithVoiceConnectorAsync(AssociatePhoneNumbersWithVoiceConnectorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AssociatePhoneNumbersWithVoiceConnectorGroup



        /// <summary>
        /// Associates phone numbers with the specified Amazon Chime SDK Voice Connector group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociatePhoneNumbersWithVoiceConnectorGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociatePhoneNumbersWithVoiceConnectorGroup service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.AccessDeniedException">
        /// You don't have the permissions needed to run this action.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/AssociatePhoneNumbersWithVoiceConnectorGroup">REST API Reference for AssociatePhoneNumbersWithVoiceConnectorGroup Operation</seealso>
        Task<AssociatePhoneNumbersWithVoiceConnectorGroupResponse> AssociatePhoneNumbersWithVoiceConnectorGroupAsync(AssociatePhoneNumbersWithVoiceConnectorGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  BatchDeletePhoneNumber



        /// <summary>
        /// Moves phone numbers into the <b>Deletion queue</b>. Phone numbers must be disassociated
        /// from any users or Amazon Chime SDK Voice Connectors before they can be deleted. 
        /// 
        ///  
        /// <para>
        ///  Phone numbers remain in the <b>Deletion queue</b> for 7 days before they are deleted
        /// permanently. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeletePhoneNumber service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchDeletePhoneNumber service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/BatchDeletePhoneNumber">REST API Reference for BatchDeletePhoneNumber Operation</seealso>
        Task<BatchDeletePhoneNumberResponse> BatchDeletePhoneNumberAsync(BatchDeletePhoneNumberRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  BatchUpdatePhoneNumber



        /// <summary>
        /// Updates one or more phone numbers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdatePhoneNumber service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchUpdatePhoneNumber service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/BatchUpdatePhoneNumber">REST API Reference for BatchUpdatePhoneNumber Operation</seealso>
        Task<BatchUpdatePhoneNumberResponse> BatchUpdatePhoneNumberAsync(BatchUpdatePhoneNumberRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreatePhoneNumberOrder



        /// <summary>
        /// Creates an order for phone numbers to be provisioned. For numbers outside the U.S.,
        /// you must use the Amazon Chime SDK SIP media application dial-in product type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePhoneNumberOrder service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePhoneNumberOrder service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.AccessDeniedException">
        /// You don't have the permissions needed to run this action.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/CreatePhoneNumberOrder">REST API Reference for CreatePhoneNumberOrder Operation</seealso>
        Task<CreatePhoneNumberOrderResponse> CreatePhoneNumberOrderAsync(CreatePhoneNumberOrderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateProxySession



        /// <summary>
        /// Creates a proxy session for the specified Amazon Chime SDK Voice Connector for the
        /// specified participant phone numbers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProxySession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateProxySession service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/CreateProxySession">REST API Reference for CreateProxySession Operation</seealso>
        Task<CreateProxySessionResponse> CreateProxySessionAsync(CreateProxySessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateSipMediaApplication



        /// <summary>
        /// Creates a SIP media application. For more information about SIP media applications,
        /// see <a href="https://docs.aws.amazon.com/chime-sdk/latest/ag/manage-sip-applications.html">Managing
        /// SIP media applications and rules</a> in the <i>Amazon Chime SDK Administrator Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSipMediaApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSipMediaApplication service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.AccessDeniedException">
        /// You don't have the permissions needed to run this action.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ConflictException">
        /// Multiple instances of the same request were made simultaneously.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/CreateSipMediaApplication">REST API Reference for CreateSipMediaApplication Operation</seealso>
        Task<CreateSipMediaApplicationResponse> CreateSipMediaApplicationAsync(CreateSipMediaApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateSipMediaApplicationCall



        /// <summary>
        /// Creates an outbound call to a phone number from the phone number specified in the
        /// request, and it invokes the endpoint of the specified <code>sipMediaApplicationId</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSipMediaApplicationCall service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSipMediaApplicationCall service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.AccessDeniedException">
        /// You don't have the permissions needed to run this action.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/CreateSipMediaApplicationCall">REST API Reference for CreateSipMediaApplicationCall Operation</seealso>
        Task<CreateSipMediaApplicationCallResponse> CreateSipMediaApplicationCallAsync(CreateSipMediaApplicationCallRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateSipRule



        /// <summary>
        /// Creates a SIP rule, which can be used to run a SIP media application as a target for
        /// a specific trigger type. For more information about SIP rules, see <a href="https://docs.aws.amazon.com/chime-sdk/latest/ag/manage-sip-applications.html">Managing
        /// SIP media applications and rules</a> in the <i>Amazon Chime SDK Administrator Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSipRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSipRule service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.AccessDeniedException">
        /// You don't have the permissions needed to run this action.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ConflictException">
        /// Multiple instances of the same request were made simultaneously.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/CreateSipRule">REST API Reference for CreateSipRule Operation</seealso>
        Task<CreateSipRuleResponse> CreateSipRuleAsync(CreateSipRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateVoiceConnector



        /// <summary>
        /// Creates an Amazon Chime SDK Voice Connector. For more information about Voice Connectors,
        /// see <a href="https://docs.aws.amazon.com/chime-sdk/latest/ag/voice-connector-groups.html">Managing
        /// Amazon Chime SDK Voice Connector groups</a> in the <i>Amazon Chime SDK Administrator
        /// Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVoiceConnector service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateVoiceConnector service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.AccessDeniedException">
        /// You don't have the permissions needed to run this action.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/CreateVoiceConnector">REST API Reference for CreateVoiceConnector Operation</seealso>
        Task<CreateVoiceConnectorResponse> CreateVoiceConnectorAsync(CreateVoiceConnectorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateVoiceConnectorGroup



        /// <summary>
        /// Creates an Amazon Chime SDK Voice Connector group under the administrator's AWS account.
        /// You can associate Amazon Chime SDK Voice Connectors with the Voice Connector group
        /// by including <code>VoiceConnectorItems</code> in the request. 
        /// 
        ///  
        /// <para>
        /// You can include Voice Connectors from different AWS Regions in your group. This creates
        /// a fault tolerant mechanism for fallback in case of availability events.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVoiceConnectorGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateVoiceConnectorGroup service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.AccessDeniedException">
        /// You don't have the permissions needed to run this action.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/CreateVoiceConnectorGroup">REST API Reference for CreateVoiceConnectorGroup Operation</seealso>
        Task<CreateVoiceConnectorGroupResponse> CreateVoiceConnectorGroupAsync(CreateVoiceConnectorGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateVoiceProfile



        /// <summary>
        /// Creates a voice profile, which consists of an enrolled user and their latest voice
        /// print.
        /// 
        ///  <important> 
        /// <para>
        /// Before creating any voice profiles, you must provide all notices and obtain all consents
        /// from the speaker as required under applicable privacy and biometrics laws, and as
        /// required under the <a href="https://aws.amazon.com/service-terms/">AWS service terms</a>
        /// for the Amazon Chime SDK.
        /// </para>
        ///  </important> 
        /// <para>
        /// For more information about voice profiles and voice analytics, see <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/pstn-voice-analytics.html">Using
        /// Amazon Chime SDK Voice Analytics</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVoiceProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateVoiceProfile service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.AccessDeniedException">
        /// You don't have the permissions needed to run this action.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ConflictException">
        /// Multiple instances of the same request were made simultaneously.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.GoneException">
        /// Access to the target resource is no longer available at the origin server. This condition
        /// is likely to be permanent.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/CreateVoiceProfile">REST API Reference for CreateVoiceProfile Operation</seealso>
        Task<CreateVoiceProfileResponse> CreateVoiceProfileAsync(CreateVoiceProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateVoiceProfileDomain



        /// <summary>
        /// Creates a voice profile domain, a collection of voice profiles, their voice prints,
        /// and encrypted enrollment audio.
        /// 
        ///  <important> 
        /// <para>
        /// Before creating any voice profiles, you must provide all notices and obtain all consents
        /// from the speaker as required under applicable privacy and biometrics laws, and as
        /// required under the <a href="https://aws.amazon.com/service-terms/">AWS service terms</a>
        /// for the Amazon Chime SDK.
        /// </para>
        ///  </important> 
        /// <para>
        /// For more information about voice profile domains, see <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/pstn-voice-analytics.html">Using
        /// Amazon Chime SDK Voice Analytics</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVoiceProfileDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateVoiceProfileDomain service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.AccessDeniedException">
        /// You don't have the permissions needed to run this action.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ConflictException">
        /// Multiple instances of the same request were made simultaneously.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/CreateVoiceProfileDomain">REST API Reference for CreateVoiceProfileDomain Operation</seealso>
        Task<CreateVoiceProfileDomainResponse> CreateVoiceProfileDomainAsync(CreateVoiceProfileDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeletePhoneNumber



        /// <summary>
        /// Moves the specified phone number into the <b>Deletion queue</b>. A phone number must
        /// be disassociated from any users or Amazon Chime SDK Voice Connectors before it can
        /// be deleted.
        /// 
        ///  
        /// <para>
        /// Deleted phone numbers remain in the <b>Deletion queue</b> queue for 7 days before
        /// they are deleted permanently.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePhoneNumber service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeletePhoneNumber service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/DeletePhoneNumber">REST API Reference for DeletePhoneNumber Operation</seealso>
        Task<DeletePhoneNumberResponse> DeletePhoneNumberAsync(DeletePhoneNumberRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteProxySession



        /// <summary>
        /// Deletes the specified proxy session from the specified Amazon Chime SDK Voice Connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProxySession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteProxySession service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/DeleteProxySession">REST API Reference for DeleteProxySession Operation</seealso>
        Task<DeleteProxySessionResponse> DeleteProxySessionAsync(DeleteProxySessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteSipMediaApplication



        /// <summary>
        /// Deletes a SIP media application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSipMediaApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSipMediaApplication service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ConflictException">
        /// Multiple instances of the same request were made simultaneously.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/DeleteSipMediaApplication">REST API Reference for DeleteSipMediaApplication Operation</seealso>
        Task<DeleteSipMediaApplicationResponse> DeleteSipMediaApplicationAsync(DeleteSipMediaApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteSipRule



        /// <summary>
        /// Deletes a SIP rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSipRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSipRule service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ConflictException">
        /// Multiple instances of the same request were made simultaneously.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/DeleteSipRule">REST API Reference for DeleteSipRule Operation</seealso>
        Task<DeleteSipRuleResponse> DeleteSipRuleAsync(DeleteSipRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteVoiceConnector



        /// <summary>
        /// Deletes an Amazon Chime SDK Voice Connector. Any phone numbers associated with the
        /// Amazon Chime SDK Voice Connector must be disassociated from it before it can be deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVoiceConnector service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteVoiceConnector service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ConflictException">
        /// Multiple instances of the same request were made simultaneously.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/DeleteVoiceConnector">REST API Reference for DeleteVoiceConnector Operation</seealso>
        Task<DeleteVoiceConnectorResponse> DeleteVoiceConnectorAsync(DeleteVoiceConnectorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteVoiceConnectorEmergencyCallingConfiguration



        /// <summary>
        /// Deletes the emergency calling details from the specified Amazon Chime SDK Voice Connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVoiceConnectorEmergencyCallingConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteVoiceConnectorEmergencyCallingConfiguration service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/DeleteVoiceConnectorEmergencyCallingConfiguration">REST API Reference for DeleteVoiceConnectorEmergencyCallingConfiguration Operation</seealso>
        Task<DeleteVoiceConnectorEmergencyCallingConfigurationResponse> DeleteVoiceConnectorEmergencyCallingConfigurationAsync(DeleteVoiceConnectorEmergencyCallingConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteVoiceConnectorGroup



        /// <summary>
        /// Deletes an Amazon Chime SDK Voice Connector group. Any <code>VoiceConnectorItems</code>
        /// and phone numbers associated with the group must be removed before it can be deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVoiceConnectorGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteVoiceConnectorGroup service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ConflictException">
        /// Multiple instances of the same request were made simultaneously.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/DeleteVoiceConnectorGroup">REST API Reference for DeleteVoiceConnectorGroup Operation</seealso>
        Task<DeleteVoiceConnectorGroupResponse> DeleteVoiceConnectorGroupAsync(DeleteVoiceConnectorGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteVoiceConnectorOrigination



        /// <summary>
        /// Deletes the origination settings for the specified Amazon Chime SDK Voice Connector.
        /// 
        /// 
        ///  <note> 
        /// <para>
        /// If emergency calling is configured for the Voice Connector, it must be deleted prior
        /// to deleting the origination settings.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVoiceConnectorOrigination service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteVoiceConnectorOrigination service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/DeleteVoiceConnectorOrigination">REST API Reference for DeleteVoiceConnectorOrigination Operation</seealso>
        Task<DeleteVoiceConnectorOriginationResponse> DeleteVoiceConnectorOriginationAsync(DeleteVoiceConnectorOriginationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteVoiceConnectorProxy



        /// <summary>
        /// Deletes the proxy configuration from the specified Amazon Chime SDK Voice Connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVoiceConnectorProxy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteVoiceConnectorProxy service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/DeleteVoiceConnectorProxy">REST API Reference for DeleteVoiceConnectorProxy Operation</seealso>
        Task<DeleteVoiceConnectorProxyResponse> DeleteVoiceConnectorProxyAsync(DeleteVoiceConnectorProxyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteVoiceConnectorStreamingConfiguration



        /// <summary>
        /// Deletes a Voice Connector's streaming configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVoiceConnectorStreamingConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteVoiceConnectorStreamingConfiguration service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/DeleteVoiceConnectorStreamingConfiguration">REST API Reference for DeleteVoiceConnectorStreamingConfiguration Operation</seealso>
        Task<DeleteVoiceConnectorStreamingConfigurationResponse> DeleteVoiceConnectorStreamingConfigurationAsync(DeleteVoiceConnectorStreamingConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteVoiceConnectorTermination



        /// <summary>
        /// Deletes the termination settings for the specified Amazon Chime SDK Voice Connector.
        /// 
        ///  <note> 
        /// <para>
        /// If emergency calling is configured for the Voice Connector, it must be deleted prior
        /// to deleting the termination settings.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVoiceConnectorTermination service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteVoiceConnectorTermination service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/DeleteVoiceConnectorTermination">REST API Reference for DeleteVoiceConnectorTermination Operation</seealso>
        Task<DeleteVoiceConnectorTerminationResponse> DeleteVoiceConnectorTerminationAsync(DeleteVoiceConnectorTerminationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteVoiceConnectorTerminationCredentials



        /// <summary>
        /// Deletes the specified SIP credentials used by your equipment to authenticate during
        /// call termination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVoiceConnectorTerminationCredentials service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteVoiceConnectorTerminationCredentials service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/DeleteVoiceConnectorTerminationCredentials">REST API Reference for DeleteVoiceConnectorTerminationCredentials Operation</seealso>
        Task<DeleteVoiceConnectorTerminationCredentialsResponse> DeleteVoiceConnectorTerminationCredentialsAsync(DeleteVoiceConnectorTerminationCredentialsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteVoiceProfile



        /// <summary>
        /// Deletes a voice profile, including its voice print and enrollment data. WARNING: This
        /// action is not reversible.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVoiceProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteVoiceProfile service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.AccessDeniedException">
        /// You don't have the permissions needed to run this action.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ConflictException">
        /// Multiple instances of the same request were made simultaneously.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/DeleteVoiceProfile">REST API Reference for DeleteVoiceProfile Operation</seealso>
        Task<DeleteVoiceProfileResponse> DeleteVoiceProfileAsync(DeleteVoiceProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteVoiceProfileDomain



        /// <summary>
        /// Deletes all voice profiles in the domain. WARNING: This action is not reversible.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVoiceProfileDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteVoiceProfileDomain service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.AccessDeniedException">
        /// You don't have the permissions needed to run this action.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ConflictException">
        /// Multiple instances of the same request were made simultaneously.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/DeleteVoiceProfileDomain">REST API Reference for DeleteVoiceProfileDomain Operation</seealso>
        Task<DeleteVoiceProfileDomainResponse> DeleteVoiceProfileDomainAsync(DeleteVoiceProfileDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisassociatePhoneNumbersFromVoiceConnector



        /// <summary>
        /// Disassociates the specified phone numbers from the specified Amazon Chime SDK Voice
        /// Connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociatePhoneNumbersFromVoiceConnector service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociatePhoneNumbersFromVoiceConnector service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/DisassociatePhoneNumbersFromVoiceConnector">REST API Reference for DisassociatePhoneNumbersFromVoiceConnector Operation</seealso>
        Task<DisassociatePhoneNumbersFromVoiceConnectorResponse> DisassociatePhoneNumbersFromVoiceConnectorAsync(DisassociatePhoneNumbersFromVoiceConnectorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisassociatePhoneNumbersFromVoiceConnectorGroup



        /// <summary>
        /// Disassociates the specified phone numbers from the specified Amazon Chime SDK Voice
        /// Connector group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociatePhoneNumbersFromVoiceConnectorGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociatePhoneNumbersFromVoiceConnectorGroup service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/DisassociatePhoneNumbersFromVoiceConnectorGroup">REST API Reference for DisassociatePhoneNumbersFromVoiceConnectorGroup Operation</seealso>
        Task<DisassociatePhoneNumbersFromVoiceConnectorGroupResponse> DisassociatePhoneNumbersFromVoiceConnectorGroupAsync(DisassociatePhoneNumbersFromVoiceConnectorGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetGlobalSettings



        /// <summary>
        /// Retrieves the global settings for the Amazon Chime SDK Voice Connectors in an AWS
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGlobalSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetGlobalSettings service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetGlobalSettings">REST API Reference for GetGlobalSettings Operation</seealso>
        Task<GetGlobalSettingsResponse> GetGlobalSettingsAsync(GetGlobalSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetPhoneNumber



        /// <summary>
        /// Retrieves details for the specified phone number ID, such as associations, capabilities,
        /// and product type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPhoneNumber service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPhoneNumber service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetPhoneNumber">REST API Reference for GetPhoneNumber Operation</seealso>
        Task<GetPhoneNumberResponse> GetPhoneNumberAsync(GetPhoneNumberRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetPhoneNumberOrder



        /// <summary>
        /// Retrieves details for the specified phone number order, such as the order creation
        /// timestamp, phone numbers in E.164 format, product type, and order status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPhoneNumberOrder service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPhoneNumberOrder service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetPhoneNumberOrder">REST API Reference for GetPhoneNumberOrder Operation</seealso>
        Task<GetPhoneNumberOrderResponse> GetPhoneNumberOrderAsync(GetPhoneNumberOrderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetPhoneNumberSettings



        /// <summary>
        /// Retrieves the phone number settings for the administrator's AWS account, such as the
        /// default outbound calling name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPhoneNumberSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPhoneNumberSettings service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetPhoneNumberSettings">REST API Reference for GetPhoneNumberSettings Operation</seealso>
        Task<GetPhoneNumberSettingsResponse> GetPhoneNumberSettingsAsync(GetPhoneNumberSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetProxySession



        /// <summary>
        /// Retrieves the specified proxy session details for the specified Amazon Chime SDK Voice
        /// Connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProxySession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetProxySession service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetProxySession">REST API Reference for GetProxySession Operation</seealso>
        Task<GetProxySessionResponse> GetProxySessionAsync(GetProxySessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetSipMediaApplication



        /// <summary>
        /// Retrieves the information for a SIP media application, including name, AWS Region,
        /// and endpoints.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSipMediaApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSipMediaApplication service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetSipMediaApplication">REST API Reference for GetSipMediaApplication Operation</seealso>
        Task<GetSipMediaApplicationResponse> GetSipMediaApplicationAsync(GetSipMediaApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetSipMediaApplicationAlexaSkillConfiguration



        /// <summary>
        /// Gets the Alexa Skill configuration for the SIP media application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSipMediaApplicationAlexaSkillConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSipMediaApplicationAlexaSkillConfiguration service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetSipMediaApplicationAlexaSkillConfiguration">REST API Reference for GetSipMediaApplicationAlexaSkillConfiguration Operation</seealso>
        Task<GetSipMediaApplicationAlexaSkillConfigurationResponse> GetSipMediaApplicationAlexaSkillConfigurationAsync(GetSipMediaApplicationAlexaSkillConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetSipMediaApplicationLoggingConfiguration



        /// <summary>
        /// Retrieves the logging configuration for the specified SIP media application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSipMediaApplicationLoggingConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSipMediaApplicationLoggingConfiguration service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetSipMediaApplicationLoggingConfiguration">REST API Reference for GetSipMediaApplicationLoggingConfiguration Operation</seealso>
        Task<GetSipMediaApplicationLoggingConfigurationResponse> GetSipMediaApplicationLoggingConfigurationAsync(GetSipMediaApplicationLoggingConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetSipRule



        /// <summary>
        /// Retrieves the details of a SIP rule, such as the rule ID, name, triggers, and target
        /// endpoints.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSipRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSipRule service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetSipRule">REST API Reference for GetSipRule Operation</seealso>
        Task<GetSipRuleResponse> GetSipRuleAsync(GetSipRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetSpeakerSearchTask



        /// <summary>
        /// Retrieves the details of the specified speaker search task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSpeakerSearchTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSpeakerSearchTask service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.AccessDeniedException">
        /// You don't have the permissions needed to run this action.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ConflictException">
        /// Multiple instances of the same request were made simultaneously.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetSpeakerSearchTask">REST API Reference for GetSpeakerSearchTask Operation</seealso>
        Task<GetSpeakerSearchTaskResponse> GetSpeakerSearchTaskAsync(GetSpeakerSearchTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetVoiceConnector



        /// <summary>
        /// Retrieves details for the specified Amazon Chime SDK Voice Connector, such as timestamps,name,
        /// outbound host, and encryption requirements.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceConnector service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetVoiceConnector service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetVoiceConnector">REST API Reference for GetVoiceConnector Operation</seealso>
        Task<GetVoiceConnectorResponse> GetVoiceConnectorAsync(GetVoiceConnectorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetVoiceConnectorEmergencyCallingConfiguration



        /// <summary>
        /// Retrieves the emergency calling configuration details for the specified Voice Connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceConnectorEmergencyCallingConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetVoiceConnectorEmergencyCallingConfiguration service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetVoiceConnectorEmergencyCallingConfiguration">REST API Reference for GetVoiceConnectorEmergencyCallingConfiguration Operation</seealso>
        Task<GetVoiceConnectorEmergencyCallingConfigurationResponse> GetVoiceConnectorEmergencyCallingConfigurationAsync(GetVoiceConnectorEmergencyCallingConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetVoiceConnectorGroup



        /// <summary>
        /// Retrieves details for the specified Amazon Chime SDK Voice Connector group, such as
        /// timestamps,name, and associated <code>VoiceConnectorItems</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceConnectorGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetVoiceConnectorGroup service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetVoiceConnectorGroup">REST API Reference for GetVoiceConnectorGroup Operation</seealso>
        Task<GetVoiceConnectorGroupResponse> GetVoiceConnectorGroupAsync(GetVoiceConnectorGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetVoiceConnectorLoggingConfiguration



        /// <summary>
        /// Retrieves the logging configuration settings for the specified Voice Connector. Shows
        /// whether SIP message logs are enabled for sending to Amazon CloudWatch Logs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceConnectorLoggingConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetVoiceConnectorLoggingConfiguration service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetVoiceConnectorLoggingConfiguration">REST API Reference for GetVoiceConnectorLoggingConfiguration Operation</seealso>
        Task<GetVoiceConnectorLoggingConfigurationResponse> GetVoiceConnectorLoggingConfigurationAsync(GetVoiceConnectorLoggingConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetVoiceConnectorOrigination



        /// <summary>
        /// Retrieves the origination settings for the specified Voice Connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceConnectorOrigination service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetVoiceConnectorOrigination service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetVoiceConnectorOrigination">REST API Reference for GetVoiceConnectorOrigination Operation</seealso>
        Task<GetVoiceConnectorOriginationResponse> GetVoiceConnectorOriginationAsync(GetVoiceConnectorOriginationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetVoiceConnectorProxy



        /// <summary>
        /// Retrieves the proxy configuration details for the specified Amazon Chime SDK Voice
        /// Connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceConnectorProxy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetVoiceConnectorProxy service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetVoiceConnectorProxy">REST API Reference for GetVoiceConnectorProxy Operation</seealso>
        Task<GetVoiceConnectorProxyResponse> GetVoiceConnectorProxyAsync(GetVoiceConnectorProxyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetVoiceConnectorStreamingConfiguration



        /// <summary>
        /// Retrieves the streaming configuration details for the specified Amazon Chime SDK Voice
        /// Connector. Shows whether media streaming is enabled for sending to Amazon Kinesis.
        /// It also shows the retention period, in hours, for the Amazon Kinesis data.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceConnectorStreamingConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetVoiceConnectorStreamingConfiguration service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetVoiceConnectorStreamingConfiguration">REST API Reference for GetVoiceConnectorStreamingConfiguration Operation</seealso>
        Task<GetVoiceConnectorStreamingConfigurationResponse> GetVoiceConnectorStreamingConfigurationAsync(GetVoiceConnectorStreamingConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetVoiceConnectorTermination



        /// <summary>
        /// Retrieves the termination setting details for the specified Voice Connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceConnectorTermination service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetVoiceConnectorTermination service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetVoiceConnectorTermination">REST API Reference for GetVoiceConnectorTermination Operation</seealso>
        Task<GetVoiceConnectorTerminationResponse> GetVoiceConnectorTerminationAsync(GetVoiceConnectorTerminationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetVoiceConnectorTerminationHealth



        /// <summary>
        /// Retrieves information about the last time a <code>SIP OPTIONS</code> ping was received
        /// from your SIP infrastructure for the specified Amazon Chime SDK Voice Connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceConnectorTerminationHealth service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetVoiceConnectorTerminationHealth service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetVoiceConnectorTerminationHealth">REST API Reference for GetVoiceConnectorTerminationHealth Operation</seealso>
        Task<GetVoiceConnectorTerminationHealthResponse> GetVoiceConnectorTerminationHealthAsync(GetVoiceConnectorTerminationHealthRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetVoiceProfile



        /// <summary>
        /// Retrieves the details of the specified voice profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetVoiceProfile service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.AccessDeniedException">
        /// You don't have the permissions needed to run this action.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetVoiceProfile">REST API Reference for GetVoiceProfile Operation</seealso>
        Task<GetVoiceProfileResponse> GetVoiceProfileAsync(GetVoiceProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetVoiceProfileDomain



        /// <summary>
        /// Retrieves the details of the specified voice profile domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceProfileDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetVoiceProfileDomain service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.AccessDeniedException">
        /// You don't have the permissions needed to run this action.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetVoiceProfileDomain">REST API Reference for GetVoiceProfileDomain Operation</seealso>
        Task<GetVoiceProfileDomainResponse> GetVoiceProfileDomainAsync(GetVoiceProfileDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetVoiceToneAnalysisTask



        /// <summary>
        /// Retrieves the details of a voice tone analysis task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceToneAnalysisTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetVoiceToneAnalysisTask service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.AccessDeniedException">
        /// You don't have the permissions needed to run this action.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ConflictException">
        /// Multiple instances of the same request were made simultaneously.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetVoiceToneAnalysisTask">REST API Reference for GetVoiceToneAnalysisTask Operation</seealso>
        Task<GetVoiceToneAnalysisTaskResponse> GetVoiceToneAnalysisTaskAsync(GetVoiceToneAnalysisTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListAvailableVoiceConnectorRegions



        /// <summary>
        /// Lists the available AWS Regions in which you can create an Amazon Chime SDK Voice
        /// Connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAvailableVoiceConnectorRegions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAvailableVoiceConnectorRegions service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/ListAvailableVoiceConnectorRegions">REST API Reference for ListAvailableVoiceConnectorRegions Operation</seealso>
        Task<ListAvailableVoiceConnectorRegionsResponse> ListAvailableVoiceConnectorRegionsAsync(ListAvailableVoiceConnectorRegionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListPhoneNumberOrders



        /// <summary>
        /// Lists the phone numbers for an administrator's Amazon Chime SDK account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPhoneNumberOrders service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPhoneNumberOrders service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/ListPhoneNumberOrders">REST API Reference for ListPhoneNumberOrders Operation</seealso>
        Task<ListPhoneNumberOrdersResponse> ListPhoneNumberOrdersAsync(ListPhoneNumberOrdersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListPhoneNumbers



        /// <summary>
        /// Lists the phone numbers for the specified Amazon Chime SDK account, Amazon Chime SDK
        /// user, Amazon Chime SDK Voice Connector, or Amazon Chime SDK Voice Connector group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPhoneNumbers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPhoneNumbers service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/ListPhoneNumbers">REST API Reference for ListPhoneNumbers Operation</seealso>
        Task<ListPhoneNumbersResponse> ListPhoneNumbersAsync(ListPhoneNumbersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListProxySessions



        /// <summary>
        /// Lists the proxy sessions for the specified Amazon Chime SDK Voice Connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProxySessions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListProxySessions service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/ListProxySessions">REST API Reference for ListProxySessions Operation</seealso>
        Task<ListProxySessionsResponse> ListProxySessionsAsync(ListProxySessionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListSipMediaApplications



        /// <summary>
        /// Lists the SIP media applications under the administrator's AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSipMediaApplications service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSipMediaApplications service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/ListSipMediaApplications">REST API Reference for ListSipMediaApplications Operation</seealso>
        Task<ListSipMediaApplicationsResponse> ListSipMediaApplicationsAsync(ListSipMediaApplicationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListSipRules



        /// <summary>
        /// Lists the SIP rules under the administrator's AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSipRules service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSipRules service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/ListSipRules">REST API Reference for ListSipRules Operation</seealso>
        Task<ListSipRulesResponse> ListSipRulesAsync(ListSipRulesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListSupportedPhoneNumberCountries



        /// <summary>
        /// Lists the countries that you can order phone numbers from.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSupportedPhoneNumberCountries service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSupportedPhoneNumberCountries service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.AccessDeniedException">
        /// You don't have the permissions needed to run this action.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/ListSupportedPhoneNumberCountries">REST API Reference for ListSupportedPhoneNumberCountries Operation</seealso>
        Task<ListSupportedPhoneNumberCountriesResponse> ListSupportedPhoneNumberCountriesAsync(ListSupportedPhoneNumberCountriesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource



        /// <summary>
        /// Returns a list of the tags in a given resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListVoiceConnectorGroups



        /// <summary>
        /// Lists the Amazon Chime SDK Voice Connector groups in the administrator's AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVoiceConnectorGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListVoiceConnectorGroups service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/ListVoiceConnectorGroups">REST API Reference for ListVoiceConnectorGroups Operation</seealso>
        Task<ListVoiceConnectorGroupsResponse> ListVoiceConnectorGroupsAsync(ListVoiceConnectorGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListVoiceConnectors



        /// <summary>
        /// Lists the Amazon Chime SDK Voice Connectors in the administrators AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVoiceConnectors service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListVoiceConnectors service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/ListVoiceConnectors">REST API Reference for ListVoiceConnectors Operation</seealso>
        Task<ListVoiceConnectorsResponse> ListVoiceConnectorsAsync(ListVoiceConnectorsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListVoiceConnectorTerminationCredentials



        /// <summary>
        /// Lists the SIP credentials for the specified Amazon Chime SDK Voice Connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVoiceConnectorTerminationCredentials service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListVoiceConnectorTerminationCredentials service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/ListVoiceConnectorTerminationCredentials">REST API Reference for ListVoiceConnectorTerminationCredentials Operation</seealso>
        Task<ListVoiceConnectorTerminationCredentialsResponse> ListVoiceConnectorTerminationCredentialsAsync(ListVoiceConnectorTerminationCredentialsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListVoiceProfileDomains



        /// <summary>
        /// Lists the specified voice profile domains in the administrator's AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVoiceProfileDomains service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListVoiceProfileDomains service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/ListVoiceProfileDomains">REST API Reference for ListVoiceProfileDomains Operation</seealso>
        Task<ListVoiceProfileDomainsResponse> ListVoiceProfileDomainsAsync(ListVoiceProfileDomainsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListVoiceProfiles



        /// <summary>
        /// Lists the voice profiles in a voice profile domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVoiceProfiles service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListVoiceProfiles service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/ListVoiceProfiles">REST API Reference for ListVoiceProfiles Operation</seealso>
        Task<ListVoiceProfilesResponse> ListVoiceProfilesAsync(ListVoiceProfilesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutSipMediaApplicationAlexaSkillConfiguration



        /// <summary>
        /// Updates the Alexa Skill configuration for the SIP media application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutSipMediaApplicationAlexaSkillConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutSipMediaApplicationAlexaSkillConfiguration service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/PutSipMediaApplicationAlexaSkillConfiguration">REST API Reference for PutSipMediaApplicationAlexaSkillConfiguration Operation</seealso>
        Task<PutSipMediaApplicationAlexaSkillConfigurationResponse> PutSipMediaApplicationAlexaSkillConfigurationAsync(PutSipMediaApplicationAlexaSkillConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutSipMediaApplicationLoggingConfiguration



        /// <summary>
        /// Updates the logging configuration for the specified SIP media application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutSipMediaApplicationLoggingConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutSipMediaApplicationLoggingConfiguration service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/PutSipMediaApplicationLoggingConfiguration">REST API Reference for PutSipMediaApplicationLoggingConfiguration Operation</seealso>
        Task<PutSipMediaApplicationLoggingConfigurationResponse> PutSipMediaApplicationLoggingConfigurationAsync(PutSipMediaApplicationLoggingConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutVoiceConnectorEmergencyCallingConfiguration



        /// <summary>
        /// Updates a Voice Connector's emergency calling configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutVoiceConnectorEmergencyCallingConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutVoiceConnectorEmergencyCallingConfiguration service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/PutVoiceConnectorEmergencyCallingConfiguration">REST API Reference for PutVoiceConnectorEmergencyCallingConfiguration Operation</seealso>
        Task<PutVoiceConnectorEmergencyCallingConfigurationResponse> PutVoiceConnectorEmergencyCallingConfigurationAsync(PutVoiceConnectorEmergencyCallingConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutVoiceConnectorLoggingConfiguration



        /// <summary>
        /// Updates a Voice Connector's logging configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutVoiceConnectorLoggingConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutVoiceConnectorLoggingConfiguration service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/PutVoiceConnectorLoggingConfiguration">REST API Reference for PutVoiceConnectorLoggingConfiguration Operation</seealso>
        Task<PutVoiceConnectorLoggingConfigurationResponse> PutVoiceConnectorLoggingConfigurationAsync(PutVoiceConnectorLoggingConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutVoiceConnectorOrigination



        /// <summary>
        /// Updates a Voice Connector's origination settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutVoiceConnectorOrigination service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutVoiceConnectorOrigination service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/PutVoiceConnectorOrigination">REST API Reference for PutVoiceConnectorOrigination Operation</seealso>
        Task<PutVoiceConnectorOriginationResponse> PutVoiceConnectorOriginationAsync(PutVoiceConnectorOriginationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutVoiceConnectorProxy



        /// <summary>
        /// Puts the specified proxy configuration to the specified Amazon Chime SDK Voice Connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutVoiceConnectorProxy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutVoiceConnectorProxy service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.AccessDeniedException">
        /// You don't have the permissions needed to run this action.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/PutVoiceConnectorProxy">REST API Reference for PutVoiceConnectorProxy Operation</seealso>
        Task<PutVoiceConnectorProxyResponse> PutVoiceConnectorProxyAsync(PutVoiceConnectorProxyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutVoiceConnectorStreamingConfiguration



        /// <summary>
        /// Updates a Voice Connector's streaming configuration settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutVoiceConnectorStreamingConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutVoiceConnectorStreamingConfiguration service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/PutVoiceConnectorStreamingConfiguration">REST API Reference for PutVoiceConnectorStreamingConfiguration Operation</seealso>
        Task<PutVoiceConnectorStreamingConfigurationResponse> PutVoiceConnectorStreamingConfigurationAsync(PutVoiceConnectorStreamingConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutVoiceConnectorTermination



        /// <summary>
        /// Updates a Voice Connector's termination settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutVoiceConnectorTermination service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutVoiceConnectorTermination service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.AccessDeniedException">
        /// You don't have the permissions needed to run this action.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/PutVoiceConnectorTermination">REST API Reference for PutVoiceConnectorTermination Operation</seealso>
        Task<PutVoiceConnectorTerminationResponse> PutVoiceConnectorTerminationAsync(PutVoiceConnectorTerminationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutVoiceConnectorTerminationCredentials



        /// <summary>
        /// Updates a Voice Connector's termination credentials.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutVoiceConnectorTerminationCredentials service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutVoiceConnectorTerminationCredentials service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/PutVoiceConnectorTerminationCredentials">REST API Reference for PutVoiceConnectorTerminationCredentials Operation</seealso>
        Task<PutVoiceConnectorTerminationCredentialsResponse> PutVoiceConnectorTerminationCredentialsAsync(PutVoiceConnectorTerminationCredentialsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RestorePhoneNumber



        /// <summary>
        /// Restores a deleted phone number.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestorePhoneNumber service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RestorePhoneNumber service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/RestorePhoneNumber">REST API Reference for RestorePhoneNumber Operation</seealso>
        Task<RestorePhoneNumberResponse> RestorePhoneNumberAsync(RestorePhoneNumberRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SearchAvailablePhoneNumbers



        /// <summary>
        /// Searches the provisioned phone numbers in an organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchAvailablePhoneNumbers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchAvailablePhoneNumbers service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.AccessDeniedException">
        /// You don't have the permissions needed to run this action.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/SearchAvailablePhoneNumbers">REST API Reference for SearchAvailablePhoneNumbers Operation</seealso>
        Task<SearchAvailablePhoneNumbersResponse> SearchAvailablePhoneNumbersAsync(SearchAvailablePhoneNumbersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartSpeakerSearchTask



        /// <summary>
        /// Starts a speaker search task.
        /// 
        ///  <important> 
        /// <para>
        /// Before starting any speaker search tasks, you must provide all notices and obtain
        /// all consents from the speaker as required under applicable privacy and biometrics
        /// laws, and as required under the <a href="https://aws.amazon.com/service-terms/">AWS
        /// service terms</a> for the Amazon Chime SDK.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartSpeakerSearchTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartSpeakerSearchTask service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.AccessDeniedException">
        /// You don't have the permissions needed to run this action.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ConflictException">
        /// Multiple instances of the same request were made simultaneously.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.GoneException">
        /// Access to the target resource is no longer available at the origin server. This condition
        /// is likely to be permanent.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnprocessableEntityException">
        /// A well-formed request couldn't be followed due to semantic errors.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/StartSpeakerSearchTask">REST API Reference for StartSpeakerSearchTask Operation</seealso>
        Task<StartSpeakerSearchTaskResponse> StartSpeakerSearchTaskAsync(StartSpeakerSearchTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartVoiceToneAnalysisTask



        /// <summary>
        /// Starts a voice tone analysis task. For more information about voice tone analysis,
        /// see <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/pstn-voice-analytics.html">Using
        /// Amazon Chime SDK voice analytics</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// 
        ///  <important> 
        /// <para>
        /// Before starting any voice tone analysis tasks, you must provide all notices and obtain
        /// all consents from the speaker as required under applicable privacy and biometrics
        /// laws, and as required under the <a href="https://aws.amazon.com/service-terms/">AWS
        /// service terms</a> for the Amazon Chime SDK.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartVoiceToneAnalysisTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartVoiceToneAnalysisTask service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.AccessDeniedException">
        /// You don't have the permissions needed to run this action.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ConflictException">
        /// Multiple instances of the same request were made simultaneously.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.GoneException">
        /// Access to the target resource is no longer available at the origin server. This condition
        /// is likely to be permanent.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnprocessableEntityException">
        /// A well-formed request couldn't be followed due to semantic errors.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/StartVoiceToneAnalysisTask">REST API Reference for StartVoiceToneAnalysisTask Operation</seealso>
        Task<StartVoiceToneAnalysisTaskResponse> StartVoiceToneAnalysisTaskAsync(StartVoiceToneAnalysisTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StopSpeakerSearchTask



        /// <summary>
        /// Stops a speaker search task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopSpeakerSearchTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopSpeakerSearchTask service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.AccessDeniedException">
        /// You don't have the permissions needed to run this action.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ConflictException">
        /// Multiple instances of the same request were made simultaneously.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnprocessableEntityException">
        /// A well-formed request couldn't be followed due to semantic errors.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/StopSpeakerSearchTask">REST API Reference for StopSpeakerSearchTask Operation</seealso>
        Task<StopSpeakerSearchTaskResponse> StopSpeakerSearchTaskAsync(StopSpeakerSearchTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StopVoiceToneAnalysisTask



        /// <summary>
        /// Stops a voice tone analysis task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopVoiceToneAnalysisTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopVoiceToneAnalysisTask service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.AccessDeniedException">
        /// You don't have the permissions needed to run this action.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ConflictException">
        /// Multiple instances of the same request were made simultaneously.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnprocessableEntityException">
        /// A well-formed request couldn't be followed due to semantic errors.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/StopVoiceToneAnalysisTask">REST API Reference for StopVoiceToneAnalysisTask Operation</seealso>
        Task<StopVoiceToneAnalysisTaskResponse> StopVoiceToneAnalysisTaskAsync(StopVoiceToneAnalysisTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource



        /// <summary>
        /// Adds a tag to the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource



        /// <summary>
        /// Removes tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateGlobalSettings



        /// <summary>
        /// Updates global settings for the Amazon Chime SDK Voice Connectors in an AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGlobalSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateGlobalSettings service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/UpdateGlobalSettings">REST API Reference for UpdateGlobalSettings Operation</seealso>
        Task<UpdateGlobalSettingsResponse> UpdateGlobalSettingsAsync(UpdateGlobalSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdatePhoneNumber



        /// <summary>
        /// Updates phone number details, such as product type or calling name, for the specified
        /// phone number ID. You can update one phone number detail at a time. For example, you
        /// can update either the product type or the calling name in one action.
        /// 
        ///  
        /// <para>
        /// For numbers outside the U.S., you must use the Amazon Chime SDK SIP Media Application
        /// Dial-In product type.
        /// </para>
        ///  
        /// <para>
        /// Updates to outbound calling names can take 72 hours to complete. Pending updates to
        /// outbound calling names must be complete before you can request another update.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePhoneNumber service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdatePhoneNumber service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ConflictException">
        /// Multiple instances of the same request were made simultaneously.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/UpdatePhoneNumber">REST API Reference for UpdatePhoneNumber Operation</seealso>
        Task<UpdatePhoneNumberResponse> UpdatePhoneNumberAsync(UpdatePhoneNumberRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdatePhoneNumberSettings



        /// <summary>
        /// Updates the phone number settings for the administrator's AWS account, such as the
        /// default outbound calling name. You can update the default outbound calling name once
        /// every seven days. Outbound calling names can take up to 72 hours to update.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePhoneNumberSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdatePhoneNumberSettings service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/UpdatePhoneNumberSettings">REST API Reference for UpdatePhoneNumberSettings Operation</seealso>
        Task<UpdatePhoneNumberSettingsResponse> UpdatePhoneNumberSettingsAsync(UpdatePhoneNumberSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateProxySession



        /// <summary>
        /// Updates the specified proxy session details, such as voice or SMS capabilities.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProxySession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateProxySession service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/UpdateProxySession">REST API Reference for UpdateProxySession Operation</seealso>
        Task<UpdateProxySessionResponse> UpdateProxySessionAsync(UpdateProxySessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateSipMediaApplication



        /// <summary>
        /// Updates the details of the specified SIP media application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSipMediaApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSipMediaApplication service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ConflictException">
        /// Multiple instances of the same request were made simultaneously.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/UpdateSipMediaApplication">REST API Reference for UpdateSipMediaApplication Operation</seealso>
        Task<UpdateSipMediaApplicationResponse> UpdateSipMediaApplicationAsync(UpdateSipMediaApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateSipMediaApplicationCall



        /// <summary>
        /// Invokes the AWS Lambda function associated with the SIP media application and transaction
        /// ID in an update request. The Lambda function can then return a new set of actions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSipMediaApplicationCall service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSipMediaApplicationCall service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/UpdateSipMediaApplicationCall">REST API Reference for UpdateSipMediaApplicationCall Operation</seealso>
        Task<UpdateSipMediaApplicationCallResponse> UpdateSipMediaApplicationCallAsync(UpdateSipMediaApplicationCallRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateSipRule



        /// <summary>
        /// Updates the details of the specified SIP rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSipRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSipRule service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ConflictException">
        /// Multiple instances of the same request were made simultaneously.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/UpdateSipRule">REST API Reference for UpdateSipRule Operation</seealso>
        Task<UpdateSipRuleResponse> UpdateSipRuleAsync(UpdateSipRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateVoiceConnector



        /// <summary>
        /// Updates the details for the specified Amazon Chime SDK Voice Connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateVoiceConnector service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateVoiceConnector service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/UpdateVoiceConnector">REST API Reference for UpdateVoiceConnector Operation</seealso>
        Task<UpdateVoiceConnectorResponse> UpdateVoiceConnectorAsync(UpdateVoiceConnectorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateVoiceConnectorGroup



        /// <summary>
        /// Updates the settings for the specified Amazon Chime SDK Voice Connector group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateVoiceConnectorGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateVoiceConnectorGroup service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ConflictException">
        /// Multiple instances of the same request were made simultaneously.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/UpdateVoiceConnectorGroup">REST API Reference for UpdateVoiceConnectorGroup Operation</seealso>
        Task<UpdateVoiceConnectorGroupResponse> UpdateVoiceConnectorGroupAsync(UpdateVoiceConnectorGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateVoiceProfile



        /// <summary>
        /// Updates the specified voice profile’s voice print and refreshes its expiration timestamp.
        /// 
        ///  <important> 
        /// <para>
        /// As a condition of using this feature, you acknowledge that the collection, use, storage,
        /// and retention of your caller’s biometric identifiers and biometric information (“biometric
        /// data”) in the form of a digital voiceprint requires the caller’s informed consent
        /// via a written release. Such consent is required under various state laws, including
        /// biometrics laws in Illinois, Texas, Washington and other state privacy laws.
        /// </para>
        ///  
        /// <para>
        /// You must provide a written release to each caller through a process that clearly reflects
        /// each caller’s informed consent before using Amazon Chime SDK Voice Insights service,
        /// as required under the terms of your agreement with AWS governing your use of the service.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateVoiceProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateVoiceProfile service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.AccessDeniedException">
        /// You don't have the permissions needed to run this action.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ConflictException">
        /// Multiple instances of the same request were made simultaneously.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.GoneException">
        /// Access to the target resource is no longer available at the origin server. This condition
        /// is likely to be permanent.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/UpdateVoiceProfile">REST API Reference for UpdateVoiceProfile Operation</seealso>
        Task<UpdateVoiceProfileResponse> UpdateVoiceProfileAsync(UpdateVoiceProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateVoiceProfileDomain



        /// <summary>
        /// Updates the settings for the specified voice profile domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateVoiceProfileDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateVoiceProfileDomain service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.AccessDeniedException">
        /// You don't have the permissions needed to run this action.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/UpdateVoiceProfileDomain">REST API Reference for UpdateVoiceProfileDomain Operation</seealso>
        Task<UpdateVoiceProfileDomainResponse> UpdateVoiceProfileDomainAsync(UpdateVoiceProfileDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ValidateE911Address



        /// <summary>
        /// Validates an address to be used for 911 calls made with Amazon Chime SDK Voice Connectors.
        /// You can use validated addresses in a Presence Information Data Format Location Object
        /// file that you include in SIP requests. That helps ensure that addresses are routed
        /// to the appropriate Public Safety Answering Point.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ValidateE911Address service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ValidateE911Address service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/ValidateE911Address">REST API Reference for ValidateE911Address Operation</seealso>
        Task<ValidateE911AddressResponse> ValidateE911AddressAsync(ValidateE911AddressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}