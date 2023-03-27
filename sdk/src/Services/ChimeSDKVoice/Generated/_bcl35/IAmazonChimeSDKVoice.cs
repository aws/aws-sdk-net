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


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
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
        AssociatePhoneNumbersWithVoiceConnectorResponse AssociatePhoneNumbersWithVoiceConnector(AssociatePhoneNumbersWithVoiceConnectorRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssociatePhoneNumbersWithVoiceConnector operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociatePhoneNumbersWithVoiceConnector operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociatePhoneNumbersWithVoiceConnector
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/AssociatePhoneNumbersWithVoiceConnector">REST API Reference for AssociatePhoneNumbersWithVoiceConnector Operation</seealso>
        IAsyncResult BeginAssociatePhoneNumbersWithVoiceConnector(AssociatePhoneNumbersWithVoiceConnectorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociatePhoneNumbersWithVoiceConnector operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociatePhoneNumbersWithVoiceConnector.</param>
        /// 
        /// <returns>Returns a  AssociatePhoneNumbersWithVoiceConnectorResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/AssociatePhoneNumbersWithVoiceConnector">REST API Reference for AssociatePhoneNumbersWithVoiceConnector Operation</seealso>
        AssociatePhoneNumbersWithVoiceConnectorResponse EndAssociatePhoneNumbersWithVoiceConnector(IAsyncResult asyncResult);

        #endregion
        
        #region  AssociatePhoneNumbersWithVoiceConnectorGroup


        /// <summary>
        /// Associates phone numbers with the specified Amazon Chime SDK Voice Connector group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociatePhoneNumbersWithVoiceConnectorGroup service method.</param>
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
        AssociatePhoneNumbersWithVoiceConnectorGroupResponse AssociatePhoneNumbersWithVoiceConnectorGroup(AssociatePhoneNumbersWithVoiceConnectorGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssociatePhoneNumbersWithVoiceConnectorGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociatePhoneNumbersWithVoiceConnectorGroup operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociatePhoneNumbersWithVoiceConnectorGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/AssociatePhoneNumbersWithVoiceConnectorGroup">REST API Reference for AssociatePhoneNumbersWithVoiceConnectorGroup Operation</seealso>
        IAsyncResult BeginAssociatePhoneNumbersWithVoiceConnectorGroup(AssociatePhoneNumbersWithVoiceConnectorGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociatePhoneNumbersWithVoiceConnectorGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociatePhoneNumbersWithVoiceConnectorGroup.</param>
        /// 
        /// <returns>Returns a  AssociatePhoneNumbersWithVoiceConnectorGroupResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/AssociatePhoneNumbersWithVoiceConnectorGroup">REST API Reference for AssociatePhoneNumbersWithVoiceConnectorGroup Operation</seealso>
        AssociatePhoneNumbersWithVoiceConnectorGroupResponse EndAssociatePhoneNumbersWithVoiceConnectorGroup(IAsyncResult asyncResult);

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
        BatchDeletePhoneNumberResponse BatchDeletePhoneNumber(BatchDeletePhoneNumberRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchDeletePhoneNumber operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchDeletePhoneNumber operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchDeletePhoneNumber
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/BatchDeletePhoneNumber">REST API Reference for BatchDeletePhoneNumber Operation</seealso>
        IAsyncResult BeginBatchDeletePhoneNumber(BatchDeletePhoneNumberRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchDeletePhoneNumber operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchDeletePhoneNumber.</param>
        /// 
        /// <returns>Returns a  BatchDeletePhoneNumberResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/BatchDeletePhoneNumber">REST API Reference for BatchDeletePhoneNumber Operation</seealso>
        BatchDeletePhoneNumberResponse EndBatchDeletePhoneNumber(IAsyncResult asyncResult);

        #endregion
        
        #region  BatchUpdatePhoneNumber


        /// <summary>
        /// Updates one or more phone numbers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdatePhoneNumber service method.</param>
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
        BatchUpdatePhoneNumberResponse BatchUpdatePhoneNumber(BatchUpdatePhoneNumberRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchUpdatePhoneNumber operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdatePhoneNumber operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchUpdatePhoneNumber
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/BatchUpdatePhoneNumber">REST API Reference for BatchUpdatePhoneNumber Operation</seealso>
        IAsyncResult BeginBatchUpdatePhoneNumber(BatchUpdatePhoneNumberRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchUpdatePhoneNumber operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchUpdatePhoneNumber.</param>
        /// 
        /// <returns>Returns a  BatchUpdatePhoneNumberResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/BatchUpdatePhoneNumber">REST API Reference for BatchUpdatePhoneNumber Operation</seealso>
        BatchUpdatePhoneNumberResponse EndBatchUpdatePhoneNumber(IAsyncResult asyncResult);

        #endregion
        
        #region  CreatePhoneNumberOrder


        /// <summary>
        /// Creates an order for phone numbers to be provisioned. For numbers outside the U.S.,
        /// you must use the Amazon Chime SDK SIP media application dial-in product type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePhoneNumberOrder service method.</param>
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
        CreatePhoneNumberOrderResponse CreatePhoneNumberOrder(CreatePhoneNumberOrderRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePhoneNumberOrder operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePhoneNumberOrder operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePhoneNumberOrder
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/CreatePhoneNumberOrder">REST API Reference for CreatePhoneNumberOrder Operation</seealso>
        IAsyncResult BeginCreatePhoneNumberOrder(CreatePhoneNumberOrderRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePhoneNumberOrder operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePhoneNumberOrder.</param>
        /// 
        /// <returns>Returns a  CreatePhoneNumberOrderResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/CreatePhoneNumberOrder">REST API Reference for CreatePhoneNumberOrder Operation</seealso>
        CreatePhoneNumberOrderResponse EndCreatePhoneNumberOrder(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateProxySession


        /// <summary>
        /// Creates a proxy session for the specified Amazon Chime SDK Voice Connector for the
        /// specified participant phone numbers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProxySession service method.</param>
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
        CreateProxySessionResponse CreateProxySession(CreateProxySessionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateProxySession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateProxySession operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateProxySession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/CreateProxySession">REST API Reference for CreateProxySession Operation</seealso>
        IAsyncResult BeginCreateProxySession(CreateProxySessionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateProxySession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateProxySession.</param>
        /// 
        /// <returns>Returns a  CreateProxySessionResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/CreateProxySession">REST API Reference for CreateProxySession Operation</seealso>
        CreateProxySessionResponse EndCreateProxySession(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateSipMediaApplication


        /// <summary>
        /// Creates a SIP media application. For more information about SIP media applications,
        /// see <a href="https://docs.aws.amazon.com/chime-sdk/latest/ag/manage-sip-applications.html">Managing
        /// SIP media applications and rules</a> in the <i>Amazon Chime SDK Administrator Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSipMediaApplication service method.</param>
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
        CreateSipMediaApplicationResponse CreateSipMediaApplication(CreateSipMediaApplicationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSipMediaApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSipMediaApplication operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSipMediaApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/CreateSipMediaApplication">REST API Reference for CreateSipMediaApplication Operation</seealso>
        IAsyncResult BeginCreateSipMediaApplication(CreateSipMediaApplicationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSipMediaApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSipMediaApplication.</param>
        /// 
        /// <returns>Returns a  CreateSipMediaApplicationResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/CreateSipMediaApplication">REST API Reference for CreateSipMediaApplication Operation</seealso>
        CreateSipMediaApplicationResponse EndCreateSipMediaApplication(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateSipMediaApplicationCall


        /// <summary>
        /// Creates an outbound call to a phone number from the phone number specified in the
        /// request, and it invokes the endpoint of the specified <code>sipMediaApplicationId</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSipMediaApplicationCall service method.</param>
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
        CreateSipMediaApplicationCallResponse CreateSipMediaApplicationCall(CreateSipMediaApplicationCallRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSipMediaApplicationCall operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSipMediaApplicationCall operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSipMediaApplicationCall
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/CreateSipMediaApplicationCall">REST API Reference for CreateSipMediaApplicationCall Operation</seealso>
        IAsyncResult BeginCreateSipMediaApplicationCall(CreateSipMediaApplicationCallRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSipMediaApplicationCall operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSipMediaApplicationCall.</param>
        /// 
        /// <returns>Returns a  CreateSipMediaApplicationCallResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/CreateSipMediaApplicationCall">REST API Reference for CreateSipMediaApplicationCall Operation</seealso>
        CreateSipMediaApplicationCallResponse EndCreateSipMediaApplicationCall(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateSipRule


        /// <summary>
        /// Creates a SIP rule, which can be used to run a SIP media application as a target for
        /// a specific trigger type. For more information about SIP rules, see <a href="https://docs.aws.amazon.com/chime-sdk/latest/ag/manage-sip-applications.html">Managing
        /// SIP media applications and rules</a> in the <i>Amazon Chime SDK Administrator Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSipRule service method.</param>
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
        CreateSipRuleResponse CreateSipRule(CreateSipRuleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSipRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSipRule operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSipRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/CreateSipRule">REST API Reference for CreateSipRule Operation</seealso>
        IAsyncResult BeginCreateSipRule(CreateSipRuleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSipRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSipRule.</param>
        /// 
        /// <returns>Returns a  CreateSipRuleResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/CreateSipRule">REST API Reference for CreateSipRule Operation</seealso>
        CreateSipRuleResponse EndCreateSipRule(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateVoiceConnector


        /// <summary>
        /// Creates an Amazon Chime SDK Voice Connector. For more information about Voice Connectors,
        /// see <a href="https://docs.aws.amazon.com/chime-sdk/latest/ag/voice-connector-groups.html">Managing
        /// Amazon Chime SDK Voice Connector groups</a> in the <i>Amazon Chime SDK Administrator
        /// Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVoiceConnector service method.</param>
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
        CreateVoiceConnectorResponse CreateVoiceConnector(CreateVoiceConnectorRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateVoiceConnector operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVoiceConnector operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateVoiceConnector
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/CreateVoiceConnector">REST API Reference for CreateVoiceConnector Operation</seealso>
        IAsyncResult BeginCreateVoiceConnector(CreateVoiceConnectorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateVoiceConnector operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateVoiceConnector.</param>
        /// 
        /// <returns>Returns a  CreateVoiceConnectorResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/CreateVoiceConnector">REST API Reference for CreateVoiceConnector Operation</seealso>
        CreateVoiceConnectorResponse EndCreateVoiceConnector(IAsyncResult asyncResult);

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
        CreateVoiceConnectorGroupResponse CreateVoiceConnectorGroup(CreateVoiceConnectorGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateVoiceConnectorGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVoiceConnectorGroup operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateVoiceConnectorGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/CreateVoiceConnectorGroup">REST API Reference for CreateVoiceConnectorGroup Operation</seealso>
        IAsyncResult BeginCreateVoiceConnectorGroup(CreateVoiceConnectorGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateVoiceConnectorGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateVoiceConnectorGroup.</param>
        /// 
        /// <returns>Returns a  CreateVoiceConnectorGroupResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/CreateVoiceConnectorGroup">REST API Reference for CreateVoiceConnectorGroup Operation</seealso>
        CreateVoiceConnectorGroupResponse EndCreateVoiceConnectorGroup(IAsyncResult asyncResult);

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
        CreateVoiceProfileResponse CreateVoiceProfile(CreateVoiceProfileRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateVoiceProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVoiceProfile operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateVoiceProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/CreateVoiceProfile">REST API Reference for CreateVoiceProfile Operation</seealso>
        IAsyncResult BeginCreateVoiceProfile(CreateVoiceProfileRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateVoiceProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateVoiceProfile.</param>
        /// 
        /// <returns>Returns a  CreateVoiceProfileResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/CreateVoiceProfile">REST API Reference for CreateVoiceProfile Operation</seealso>
        CreateVoiceProfileResponse EndCreateVoiceProfile(IAsyncResult asyncResult);

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
        CreateVoiceProfileDomainResponse CreateVoiceProfileDomain(CreateVoiceProfileDomainRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateVoiceProfileDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVoiceProfileDomain operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateVoiceProfileDomain
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/CreateVoiceProfileDomain">REST API Reference for CreateVoiceProfileDomain Operation</seealso>
        IAsyncResult BeginCreateVoiceProfileDomain(CreateVoiceProfileDomainRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateVoiceProfileDomain operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateVoiceProfileDomain.</param>
        /// 
        /// <returns>Returns a  CreateVoiceProfileDomainResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/CreateVoiceProfileDomain">REST API Reference for CreateVoiceProfileDomain Operation</seealso>
        CreateVoiceProfileDomainResponse EndCreateVoiceProfileDomain(IAsyncResult asyncResult);

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
        DeletePhoneNumberResponse DeletePhoneNumber(DeletePhoneNumberRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePhoneNumber operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePhoneNumber operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePhoneNumber
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/DeletePhoneNumber">REST API Reference for DeletePhoneNumber Operation</seealso>
        IAsyncResult BeginDeletePhoneNumber(DeletePhoneNumberRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePhoneNumber operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePhoneNumber.</param>
        /// 
        /// <returns>Returns a  DeletePhoneNumberResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/DeletePhoneNumber">REST API Reference for DeletePhoneNumber Operation</seealso>
        DeletePhoneNumberResponse EndDeletePhoneNumber(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteProxySession


        /// <summary>
        /// Deletes the specified proxy session from the specified Amazon Chime SDK Voice Connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProxySession service method.</param>
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
        DeleteProxySessionResponse DeleteProxySession(DeleteProxySessionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteProxySession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteProxySession operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteProxySession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/DeleteProxySession">REST API Reference for DeleteProxySession Operation</seealso>
        IAsyncResult BeginDeleteProxySession(DeleteProxySessionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteProxySession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteProxySession.</param>
        /// 
        /// <returns>Returns a  DeleteProxySessionResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/DeleteProxySession">REST API Reference for DeleteProxySession Operation</seealso>
        DeleteProxySessionResponse EndDeleteProxySession(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteSipMediaApplication


        /// <summary>
        /// Deletes a SIP media application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSipMediaApplication service method.</param>
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
        DeleteSipMediaApplicationResponse DeleteSipMediaApplication(DeleteSipMediaApplicationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSipMediaApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSipMediaApplication operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSipMediaApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/DeleteSipMediaApplication">REST API Reference for DeleteSipMediaApplication Operation</seealso>
        IAsyncResult BeginDeleteSipMediaApplication(DeleteSipMediaApplicationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSipMediaApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSipMediaApplication.</param>
        /// 
        /// <returns>Returns a  DeleteSipMediaApplicationResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/DeleteSipMediaApplication">REST API Reference for DeleteSipMediaApplication Operation</seealso>
        DeleteSipMediaApplicationResponse EndDeleteSipMediaApplication(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteSipRule


        /// <summary>
        /// Deletes a SIP rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSipRule service method.</param>
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
        DeleteSipRuleResponse DeleteSipRule(DeleteSipRuleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSipRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSipRule operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSipRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/DeleteSipRule">REST API Reference for DeleteSipRule Operation</seealso>
        IAsyncResult BeginDeleteSipRule(DeleteSipRuleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSipRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSipRule.</param>
        /// 
        /// <returns>Returns a  DeleteSipRuleResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/DeleteSipRule">REST API Reference for DeleteSipRule Operation</seealso>
        DeleteSipRuleResponse EndDeleteSipRule(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteVoiceConnector


        /// <summary>
        /// Deletes an Amazon Chime SDK Voice Connector. Any phone numbers associated with the
        /// Amazon Chime SDK Voice Connector must be disassociated from it before it can be deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVoiceConnector service method.</param>
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
        DeleteVoiceConnectorResponse DeleteVoiceConnector(DeleteVoiceConnectorRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVoiceConnector operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVoiceConnector operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVoiceConnector
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/DeleteVoiceConnector">REST API Reference for DeleteVoiceConnector Operation</seealso>
        IAsyncResult BeginDeleteVoiceConnector(DeleteVoiceConnectorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVoiceConnector operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVoiceConnector.</param>
        /// 
        /// <returns>Returns a  DeleteVoiceConnectorResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/DeleteVoiceConnector">REST API Reference for DeleteVoiceConnector Operation</seealso>
        DeleteVoiceConnectorResponse EndDeleteVoiceConnector(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteVoiceConnectorEmergencyCallingConfiguration


        /// <summary>
        /// Deletes the emergency calling details from the specified Amazon Chime SDK Voice Connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVoiceConnectorEmergencyCallingConfiguration service method.</param>
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
        DeleteVoiceConnectorEmergencyCallingConfigurationResponse DeleteVoiceConnectorEmergencyCallingConfiguration(DeleteVoiceConnectorEmergencyCallingConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVoiceConnectorEmergencyCallingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVoiceConnectorEmergencyCallingConfiguration operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVoiceConnectorEmergencyCallingConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/DeleteVoiceConnectorEmergencyCallingConfiguration">REST API Reference for DeleteVoiceConnectorEmergencyCallingConfiguration Operation</seealso>
        IAsyncResult BeginDeleteVoiceConnectorEmergencyCallingConfiguration(DeleteVoiceConnectorEmergencyCallingConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVoiceConnectorEmergencyCallingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVoiceConnectorEmergencyCallingConfiguration.</param>
        /// 
        /// <returns>Returns a  DeleteVoiceConnectorEmergencyCallingConfigurationResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/DeleteVoiceConnectorEmergencyCallingConfiguration">REST API Reference for DeleteVoiceConnectorEmergencyCallingConfiguration Operation</seealso>
        DeleteVoiceConnectorEmergencyCallingConfigurationResponse EndDeleteVoiceConnectorEmergencyCallingConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteVoiceConnectorGroup


        /// <summary>
        /// Deletes an Amazon Chime SDK Voice Connector group. Any <code>VoiceConnectorItems</code>
        /// and phone numbers associated with the group must be removed before it can be deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVoiceConnectorGroup service method.</param>
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
        DeleteVoiceConnectorGroupResponse DeleteVoiceConnectorGroup(DeleteVoiceConnectorGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVoiceConnectorGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVoiceConnectorGroup operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVoiceConnectorGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/DeleteVoiceConnectorGroup">REST API Reference for DeleteVoiceConnectorGroup Operation</seealso>
        IAsyncResult BeginDeleteVoiceConnectorGroup(DeleteVoiceConnectorGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVoiceConnectorGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVoiceConnectorGroup.</param>
        /// 
        /// <returns>Returns a  DeleteVoiceConnectorGroupResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/DeleteVoiceConnectorGroup">REST API Reference for DeleteVoiceConnectorGroup Operation</seealso>
        DeleteVoiceConnectorGroupResponse EndDeleteVoiceConnectorGroup(IAsyncResult asyncResult);

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
        DeleteVoiceConnectorOriginationResponse DeleteVoiceConnectorOrigination(DeleteVoiceConnectorOriginationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVoiceConnectorOrigination operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVoiceConnectorOrigination operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVoiceConnectorOrigination
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/DeleteVoiceConnectorOrigination">REST API Reference for DeleteVoiceConnectorOrigination Operation</seealso>
        IAsyncResult BeginDeleteVoiceConnectorOrigination(DeleteVoiceConnectorOriginationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVoiceConnectorOrigination operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVoiceConnectorOrigination.</param>
        /// 
        /// <returns>Returns a  DeleteVoiceConnectorOriginationResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/DeleteVoiceConnectorOrigination">REST API Reference for DeleteVoiceConnectorOrigination Operation</seealso>
        DeleteVoiceConnectorOriginationResponse EndDeleteVoiceConnectorOrigination(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteVoiceConnectorProxy


        /// <summary>
        /// Deletes the proxy configuration from the specified Amazon Chime SDK Voice Connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVoiceConnectorProxy service method.</param>
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
        DeleteVoiceConnectorProxyResponse DeleteVoiceConnectorProxy(DeleteVoiceConnectorProxyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVoiceConnectorProxy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVoiceConnectorProxy operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVoiceConnectorProxy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/DeleteVoiceConnectorProxy">REST API Reference for DeleteVoiceConnectorProxy Operation</seealso>
        IAsyncResult BeginDeleteVoiceConnectorProxy(DeleteVoiceConnectorProxyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVoiceConnectorProxy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVoiceConnectorProxy.</param>
        /// 
        /// <returns>Returns a  DeleteVoiceConnectorProxyResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/DeleteVoiceConnectorProxy">REST API Reference for DeleteVoiceConnectorProxy Operation</seealso>
        DeleteVoiceConnectorProxyResponse EndDeleteVoiceConnectorProxy(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteVoiceConnectorStreamingConfiguration


        /// <summary>
        /// Deletes a Voice Connector's streaming configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVoiceConnectorStreamingConfiguration service method.</param>
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
        DeleteVoiceConnectorStreamingConfigurationResponse DeleteVoiceConnectorStreamingConfiguration(DeleteVoiceConnectorStreamingConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVoiceConnectorStreamingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVoiceConnectorStreamingConfiguration operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVoiceConnectorStreamingConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/DeleteVoiceConnectorStreamingConfiguration">REST API Reference for DeleteVoiceConnectorStreamingConfiguration Operation</seealso>
        IAsyncResult BeginDeleteVoiceConnectorStreamingConfiguration(DeleteVoiceConnectorStreamingConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVoiceConnectorStreamingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVoiceConnectorStreamingConfiguration.</param>
        /// 
        /// <returns>Returns a  DeleteVoiceConnectorStreamingConfigurationResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/DeleteVoiceConnectorStreamingConfiguration">REST API Reference for DeleteVoiceConnectorStreamingConfiguration Operation</seealso>
        DeleteVoiceConnectorStreamingConfigurationResponse EndDeleteVoiceConnectorStreamingConfiguration(IAsyncResult asyncResult);

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
        DeleteVoiceConnectorTerminationResponse DeleteVoiceConnectorTermination(DeleteVoiceConnectorTerminationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVoiceConnectorTermination operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVoiceConnectorTermination operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVoiceConnectorTermination
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/DeleteVoiceConnectorTermination">REST API Reference for DeleteVoiceConnectorTermination Operation</seealso>
        IAsyncResult BeginDeleteVoiceConnectorTermination(DeleteVoiceConnectorTerminationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVoiceConnectorTermination operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVoiceConnectorTermination.</param>
        /// 
        /// <returns>Returns a  DeleteVoiceConnectorTerminationResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/DeleteVoiceConnectorTermination">REST API Reference for DeleteVoiceConnectorTermination Operation</seealso>
        DeleteVoiceConnectorTerminationResponse EndDeleteVoiceConnectorTermination(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteVoiceConnectorTerminationCredentials


        /// <summary>
        /// Deletes the specified SIP credentials used by your equipment to authenticate during
        /// call termination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVoiceConnectorTerminationCredentials service method.</param>
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
        DeleteVoiceConnectorTerminationCredentialsResponse DeleteVoiceConnectorTerminationCredentials(DeleteVoiceConnectorTerminationCredentialsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVoiceConnectorTerminationCredentials operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVoiceConnectorTerminationCredentials operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVoiceConnectorTerminationCredentials
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/DeleteVoiceConnectorTerminationCredentials">REST API Reference for DeleteVoiceConnectorTerminationCredentials Operation</seealso>
        IAsyncResult BeginDeleteVoiceConnectorTerminationCredentials(DeleteVoiceConnectorTerminationCredentialsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVoiceConnectorTerminationCredentials operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVoiceConnectorTerminationCredentials.</param>
        /// 
        /// <returns>Returns a  DeleteVoiceConnectorTerminationCredentialsResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/DeleteVoiceConnectorTerminationCredentials">REST API Reference for DeleteVoiceConnectorTerminationCredentials Operation</seealso>
        DeleteVoiceConnectorTerminationCredentialsResponse EndDeleteVoiceConnectorTerminationCredentials(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteVoiceProfile


        /// <summary>
        /// Deletes a voice profile, including its voice print and enrollment data. WARNING: This
        /// action is not reversible.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVoiceProfile service method.</param>
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
        DeleteVoiceProfileResponse DeleteVoiceProfile(DeleteVoiceProfileRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVoiceProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVoiceProfile operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVoiceProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/DeleteVoiceProfile">REST API Reference for DeleteVoiceProfile Operation</seealso>
        IAsyncResult BeginDeleteVoiceProfile(DeleteVoiceProfileRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVoiceProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVoiceProfile.</param>
        /// 
        /// <returns>Returns a  DeleteVoiceProfileResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/DeleteVoiceProfile">REST API Reference for DeleteVoiceProfile Operation</seealso>
        DeleteVoiceProfileResponse EndDeleteVoiceProfile(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteVoiceProfileDomain


        /// <summary>
        /// Deletes all voice profiles in the domain. WARNING: This action is not reversible.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVoiceProfileDomain service method.</param>
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
        DeleteVoiceProfileDomainResponse DeleteVoiceProfileDomain(DeleteVoiceProfileDomainRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVoiceProfileDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVoiceProfileDomain operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVoiceProfileDomain
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/DeleteVoiceProfileDomain">REST API Reference for DeleteVoiceProfileDomain Operation</seealso>
        IAsyncResult BeginDeleteVoiceProfileDomain(DeleteVoiceProfileDomainRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVoiceProfileDomain operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVoiceProfileDomain.</param>
        /// 
        /// <returns>Returns a  DeleteVoiceProfileDomainResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/DeleteVoiceProfileDomain">REST API Reference for DeleteVoiceProfileDomain Operation</seealso>
        DeleteVoiceProfileDomainResponse EndDeleteVoiceProfileDomain(IAsyncResult asyncResult);

        #endregion
        
        #region  DisassociatePhoneNumbersFromVoiceConnector


        /// <summary>
        /// Disassociates the specified phone numbers from the specified Amazon Chime SDK Voice
        /// Connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociatePhoneNumbersFromVoiceConnector service method.</param>
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
        DisassociatePhoneNumbersFromVoiceConnectorResponse DisassociatePhoneNumbersFromVoiceConnector(DisassociatePhoneNumbersFromVoiceConnectorRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociatePhoneNumbersFromVoiceConnector operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociatePhoneNumbersFromVoiceConnector operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociatePhoneNumbersFromVoiceConnector
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/DisassociatePhoneNumbersFromVoiceConnector">REST API Reference for DisassociatePhoneNumbersFromVoiceConnector Operation</seealso>
        IAsyncResult BeginDisassociatePhoneNumbersFromVoiceConnector(DisassociatePhoneNumbersFromVoiceConnectorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociatePhoneNumbersFromVoiceConnector operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociatePhoneNumbersFromVoiceConnector.</param>
        /// 
        /// <returns>Returns a  DisassociatePhoneNumbersFromVoiceConnectorResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/DisassociatePhoneNumbersFromVoiceConnector">REST API Reference for DisassociatePhoneNumbersFromVoiceConnector Operation</seealso>
        DisassociatePhoneNumbersFromVoiceConnectorResponse EndDisassociatePhoneNumbersFromVoiceConnector(IAsyncResult asyncResult);

        #endregion
        
        #region  DisassociatePhoneNumbersFromVoiceConnectorGroup


        /// <summary>
        /// Disassociates the specified phone numbers from the specified Amazon Chime SDK Voice
        /// Connector group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociatePhoneNumbersFromVoiceConnectorGroup service method.</param>
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
        DisassociatePhoneNumbersFromVoiceConnectorGroupResponse DisassociatePhoneNumbersFromVoiceConnectorGroup(DisassociatePhoneNumbersFromVoiceConnectorGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociatePhoneNumbersFromVoiceConnectorGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociatePhoneNumbersFromVoiceConnectorGroup operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociatePhoneNumbersFromVoiceConnectorGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/DisassociatePhoneNumbersFromVoiceConnectorGroup">REST API Reference for DisassociatePhoneNumbersFromVoiceConnectorGroup Operation</seealso>
        IAsyncResult BeginDisassociatePhoneNumbersFromVoiceConnectorGroup(DisassociatePhoneNumbersFromVoiceConnectorGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociatePhoneNumbersFromVoiceConnectorGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociatePhoneNumbersFromVoiceConnectorGroup.</param>
        /// 
        /// <returns>Returns a  DisassociatePhoneNumbersFromVoiceConnectorGroupResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/DisassociatePhoneNumbersFromVoiceConnectorGroup">REST API Reference for DisassociatePhoneNumbersFromVoiceConnectorGroup Operation</seealso>
        DisassociatePhoneNumbersFromVoiceConnectorGroupResponse EndDisassociatePhoneNumbersFromVoiceConnectorGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  GetGlobalSettings


        /// <summary>
        /// Retrieves the global settings for the Amazon Chime SDK Voice Connectors in an AWS
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGlobalSettings service method.</param>
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
        GetGlobalSettingsResponse GetGlobalSettings(GetGlobalSettingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetGlobalSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetGlobalSettings operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetGlobalSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetGlobalSettings">REST API Reference for GetGlobalSettings Operation</seealso>
        IAsyncResult BeginGetGlobalSettings(GetGlobalSettingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetGlobalSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetGlobalSettings.</param>
        /// 
        /// <returns>Returns a  GetGlobalSettingsResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetGlobalSettings">REST API Reference for GetGlobalSettings Operation</seealso>
        GetGlobalSettingsResponse EndGetGlobalSettings(IAsyncResult asyncResult);

        #endregion
        
        #region  GetPhoneNumber


        /// <summary>
        /// Retrieves details for the specified phone number ID, such as associations, capabilities,
        /// and product type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPhoneNumber service method.</param>
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
        GetPhoneNumberResponse GetPhoneNumber(GetPhoneNumberRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetPhoneNumber operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPhoneNumber operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPhoneNumber
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetPhoneNumber">REST API Reference for GetPhoneNumber Operation</seealso>
        IAsyncResult BeginGetPhoneNumber(GetPhoneNumberRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetPhoneNumber operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPhoneNumber.</param>
        /// 
        /// <returns>Returns a  GetPhoneNumberResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetPhoneNumber">REST API Reference for GetPhoneNumber Operation</seealso>
        GetPhoneNumberResponse EndGetPhoneNumber(IAsyncResult asyncResult);

        #endregion
        
        #region  GetPhoneNumberOrder


        /// <summary>
        /// Retrieves details for the specified phone number order, such as the order creation
        /// timestamp, phone numbers in E.164 format, product type, and order status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPhoneNumberOrder service method.</param>
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
        GetPhoneNumberOrderResponse GetPhoneNumberOrder(GetPhoneNumberOrderRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetPhoneNumberOrder operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPhoneNumberOrder operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPhoneNumberOrder
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetPhoneNumberOrder">REST API Reference for GetPhoneNumberOrder Operation</seealso>
        IAsyncResult BeginGetPhoneNumberOrder(GetPhoneNumberOrderRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetPhoneNumberOrder operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPhoneNumberOrder.</param>
        /// 
        /// <returns>Returns a  GetPhoneNumberOrderResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetPhoneNumberOrder">REST API Reference for GetPhoneNumberOrder Operation</seealso>
        GetPhoneNumberOrderResponse EndGetPhoneNumberOrder(IAsyncResult asyncResult);

        #endregion
        
        #region  GetPhoneNumberSettings


        /// <summary>
        /// Retrieves the phone number settings for the administrator's AWS account, such as the
        /// default outbound calling name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPhoneNumberSettings service method.</param>
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
        GetPhoneNumberSettingsResponse GetPhoneNumberSettings(GetPhoneNumberSettingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetPhoneNumberSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPhoneNumberSettings operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPhoneNumberSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetPhoneNumberSettings">REST API Reference for GetPhoneNumberSettings Operation</seealso>
        IAsyncResult BeginGetPhoneNumberSettings(GetPhoneNumberSettingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetPhoneNumberSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPhoneNumberSettings.</param>
        /// 
        /// <returns>Returns a  GetPhoneNumberSettingsResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetPhoneNumberSettings">REST API Reference for GetPhoneNumberSettings Operation</seealso>
        GetPhoneNumberSettingsResponse EndGetPhoneNumberSettings(IAsyncResult asyncResult);

        #endregion
        
        #region  GetProxySession


        /// <summary>
        /// Retrieves the specified proxy session details for the specified Amazon Chime SDK Voice
        /// Connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProxySession service method.</param>
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
        GetProxySessionResponse GetProxySession(GetProxySessionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetProxySession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetProxySession operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetProxySession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetProxySession">REST API Reference for GetProxySession Operation</seealso>
        IAsyncResult BeginGetProxySession(GetProxySessionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetProxySession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetProxySession.</param>
        /// 
        /// <returns>Returns a  GetProxySessionResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetProxySession">REST API Reference for GetProxySession Operation</seealso>
        GetProxySessionResponse EndGetProxySession(IAsyncResult asyncResult);

        #endregion
        
        #region  GetSipMediaApplication


        /// <summary>
        /// Retrieves the information for a SIP media application, including name, AWS Region,
        /// and endpoints.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSipMediaApplication service method.</param>
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
        GetSipMediaApplicationResponse GetSipMediaApplication(GetSipMediaApplicationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetSipMediaApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSipMediaApplication operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSipMediaApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetSipMediaApplication">REST API Reference for GetSipMediaApplication Operation</seealso>
        IAsyncResult BeginGetSipMediaApplication(GetSipMediaApplicationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSipMediaApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSipMediaApplication.</param>
        /// 
        /// <returns>Returns a  GetSipMediaApplicationResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetSipMediaApplication">REST API Reference for GetSipMediaApplication Operation</seealso>
        GetSipMediaApplicationResponse EndGetSipMediaApplication(IAsyncResult asyncResult);

        #endregion
        
        #region  GetSipMediaApplicationAlexaSkillConfiguration


        /// <summary>
        /// Gets the Alexa Skill configuration for the SIP media application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSipMediaApplicationAlexaSkillConfiguration service method.</param>
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
        GetSipMediaApplicationAlexaSkillConfigurationResponse GetSipMediaApplicationAlexaSkillConfiguration(GetSipMediaApplicationAlexaSkillConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetSipMediaApplicationAlexaSkillConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSipMediaApplicationAlexaSkillConfiguration operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSipMediaApplicationAlexaSkillConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetSipMediaApplicationAlexaSkillConfiguration">REST API Reference for GetSipMediaApplicationAlexaSkillConfiguration Operation</seealso>
        IAsyncResult BeginGetSipMediaApplicationAlexaSkillConfiguration(GetSipMediaApplicationAlexaSkillConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSipMediaApplicationAlexaSkillConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSipMediaApplicationAlexaSkillConfiguration.</param>
        /// 
        /// <returns>Returns a  GetSipMediaApplicationAlexaSkillConfigurationResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetSipMediaApplicationAlexaSkillConfiguration">REST API Reference for GetSipMediaApplicationAlexaSkillConfiguration Operation</seealso>
        GetSipMediaApplicationAlexaSkillConfigurationResponse EndGetSipMediaApplicationAlexaSkillConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  GetSipMediaApplicationLoggingConfiguration


        /// <summary>
        /// Retrieves the logging configuration for the specified SIP media application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSipMediaApplicationLoggingConfiguration service method.</param>
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
        GetSipMediaApplicationLoggingConfigurationResponse GetSipMediaApplicationLoggingConfiguration(GetSipMediaApplicationLoggingConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetSipMediaApplicationLoggingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSipMediaApplicationLoggingConfiguration operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSipMediaApplicationLoggingConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetSipMediaApplicationLoggingConfiguration">REST API Reference for GetSipMediaApplicationLoggingConfiguration Operation</seealso>
        IAsyncResult BeginGetSipMediaApplicationLoggingConfiguration(GetSipMediaApplicationLoggingConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSipMediaApplicationLoggingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSipMediaApplicationLoggingConfiguration.</param>
        /// 
        /// <returns>Returns a  GetSipMediaApplicationLoggingConfigurationResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetSipMediaApplicationLoggingConfiguration">REST API Reference for GetSipMediaApplicationLoggingConfiguration Operation</seealso>
        GetSipMediaApplicationLoggingConfigurationResponse EndGetSipMediaApplicationLoggingConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  GetSipRule


        /// <summary>
        /// Retrieves the details of a SIP rule, such as the rule ID, name, triggers, and target
        /// endpoints.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSipRule service method.</param>
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
        GetSipRuleResponse GetSipRule(GetSipRuleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetSipRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSipRule operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSipRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetSipRule">REST API Reference for GetSipRule Operation</seealso>
        IAsyncResult BeginGetSipRule(GetSipRuleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSipRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSipRule.</param>
        /// 
        /// <returns>Returns a  GetSipRuleResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetSipRule">REST API Reference for GetSipRule Operation</seealso>
        GetSipRuleResponse EndGetSipRule(IAsyncResult asyncResult);

        #endregion
        
        #region  GetSpeakerSearchTask


        /// <summary>
        /// Retrieves the details of the specified speaker search task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSpeakerSearchTask service method.</param>
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
        GetSpeakerSearchTaskResponse GetSpeakerSearchTask(GetSpeakerSearchTaskRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetSpeakerSearchTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSpeakerSearchTask operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSpeakerSearchTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetSpeakerSearchTask">REST API Reference for GetSpeakerSearchTask Operation</seealso>
        IAsyncResult BeginGetSpeakerSearchTask(GetSpeakerSearchTaskRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSpeakerSearchTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSpeakerSearchTask.</param>
        /// 
        /// <returns>Returns a  GetSpeakerSearchTaskResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetSpeakerSearchTask">REST API Reference for GetSpeakerSearchTask Operation</seealso>
        GetSpeakerSearchTaskResponse EndGetSpeakerSearchTask(IAsyncResult asyncResult);

        #endregion
        
        #region  GetVoiceConnector


        /// <summary>
        /// Retrieves details for the specified Amazon Chime SDK Voice Connector, such as timestamps,name,
        /// outbound host, and encryption requirements.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceConnector service method.</param>
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
        GetVoiceConnectorResponse GetVoiceConnector(GetVoiceConnectorRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetVoiceConnector operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceConnector operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetVoiceConnector
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetVoiceConnector">REST API Reference for GetVoiceConnector Operation</seealso>
        IAsyncResult BeginGetVoiceConnector(GetVoiceConnectorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetVoiceConnector operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetVoiceConnector.</param>
        /// 
        /// <returns>Returns a  GetVoiceConnectorResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetVoiceConnector">REST API Reference for GetVoiceConnector Operation</seealso>
        GetVoiceConnectorResponse EndGetVoiceConnector(IAsyncResult asyncResult);

        #endregion
        
        #region  GetVoiceConnectorEmergencyCallingConfiguration


        /// <summary>
        /// Retrieves the emergency calling configuration details for the specified Voice Connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceConnectorEmergencyCallingConfiguration service method.</param>
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
        GetVoiceConnectorEmergencyCallingConfigurationResponse GetVoiceConnectorEmergencyCallingConfiguration(GetVoiceConnectorEmergencyCallingConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetVoiceConnectorEmergencyCallingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceConnectorEmergencyCallingConfiguration operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetVoiceConnectorEmergencyCallingConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetVoiceConnectorEmergencyCallingConfiguration">REST API Reference for GetVoiceConnectorEmergencyCallingConfiguration Operation</seealso>
        IAsyncResult BeginGetVoiceConnectorEmergencyCallingConfiguration(GetVoiceConnectorEmergencyCallingConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetVoiceConnectorEmergencyCallingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetVoiceConnectorEmergencyCallingConfiguration.</param>
        /// 
        /// <returns>Returns a  GetVoiceConnectorEmergencyCallingConfigurationResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetVoiceConnectorEmergencyCallingConfiguration">REST API Reference for GetVoiceConnectorEmergencyCallingConfiguration Operation</seealso>
        GetVoiceConnectorEmergencyCallingConfigurationResponse EndGetVoiceConnectorEmergencyCallingConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  GetVoiceConnectorGroup


        /// <summary>
        /// Retrieves details for the specified Amazon Chime SDK Voice Connector group, such as
        /// timestamps,name, and associated <code>VoiceConnectorItems</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceConnectorGroup service method.</param>
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
        GetVoiceConnectorGroupResponse GetVoiceConnectorGroup(GetVoiceConnectorGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetVoiceConnectorGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceConnectorGroup operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetVoiceConnectorGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetVoiceConnectorGroup">REST API Reference for GetVoiceConnectorGroup Operation</seealso>
        IAsyncResult BeginGetVoiceConnectorGroup(GetVoiceConnectorGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetVoiceConnectorGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetVoiceConnectorGroup.</param>
        /// 
        /// <returns>Returns a  GetVoiceConnectorGroupResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetVoiceConnectorGroup">REST API Reference for GetVoiceConnectorGroup Operation</seealso>
        GetVoiceConnectorGroupResponse EndGetVoiceConnectorGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  GetVoiceConnectorLoggingConfiguration


        /// <summary>
        /// Retrieves the logging configuration settings for the specified Voice Connector. Shows
        /// whether SIP message logs are enabled for sending to Amazon CloudWatch Logs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceConnectorLoggingConfiguration service method.</param>
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
        GetVoiceConnectorLoggingConfigurationResponse GetVoiceConnectorLoggingConfiguration(GetVoiceConnectorLoggingConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetVoiceConnectorLoggingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceConnectorLoggingConfiguration operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetVoiceConnectorLoggingConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetVoiceConnectorLoggingConfiguration">REST API Reference for GetVoiceConnectorLoggingConfiguration Operation</seealso>
        IAsyncResult BeginGetVoiceConnectorLoggingConfiguration(GetVoiceConnectorLoggingConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetVoiceConnectorLoggingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetVoiceConnectorLoggingConfiguration.</param>
        /// 
        /// <returns>Returns a  GetVoiceConnectorLoggingConfigurationResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetVoiceConnectorLoggingConfiguration">REST API Reference for GetVoiceConnectorLoggingConfiguration Operation</seealso>
        GetVoiceConnectorLoggingConfigurationResponse EndGetVoiceConnectorLoggingConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  GetVoiceConnectorOrigination


        /// <summary>
        /// Retrieves the origination settings for the specified Voice Connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceConnectorOrigination service method.</param>
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
        GetVoiceConnectorOriginationResponse GetVoiceConnectorOrigination(GetVoiceConnectorOriginationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetVoiceConnectorOrigination operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceConnectorOrigination operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetVoiceConnectorOrigination
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetVoiceConnectorOrigination">REST API Reference for GetVoiceConnectorOrigination Operation</seealso>
        IAsyncResult BeginGetVoiceConnectorOrigination(GetVoiceConnectorOriginationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetVoiceConnectorOrigination operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetVoiceConnectorOrigination.</param>
        /// 
        /// <returns>Returns a  GetVoiceConnectorOriginationResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetVoiceConnectorOrigination">REST API Reference for GetVoiceConnectorOrigination Operation</seealso>
        GetVoiceConnectorOriginationResponse EndGetVoiceConnectorOrigination(IAsyncResult asyncResult);

        #endregion
        
        #region  GetVoiceConnectorProxy


        /// <summary>
        /// Retrieves the proxy configuration details for the specified Amazon Chime SDK Voice
        /// Connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceConnectorProxy service method.</param>
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
        GetVoiceConnectorProxyResponse GetVoiceConnectorProxy(GetVoiceConnectorProxyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetVoiceConnectorProxy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceConnectorProxy operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetVoiceConnectorProxy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetVoiceConnectorProxy">REST API Reference for GetVoiceConnectorProxy Operation</seealso>
        IAsyncResult BeginGetVoiceConnectorProxy(GetVoiceConnectorProxyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetVoiceConnectorProxy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetVoiceConnectorProxy.</param>
        /// 
        /// <returns>Returns a  GetVoiceConnectorProxyResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetVoiceConnectorProxy">REST API Reference for GetVoiceConnectorProxy Operation</seealso>
        GetVoiceConnectorProxyResponse EndGetVoiceConnectorProxy(IAsyncResult asyncResult);

        #endregion
        
        #region  GetVoiceConnectorStreamingConfiguration


        /// <summary>
        /// Retrieves the streaming configuration details for the specified Amazon Chime SDK Voice
        /// Connector. Shows whether media streaming is enabled for sending to Amazon Kinesis.
        /// It also shows the retention period, in hours, for the Amazon Kinesis data.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceConnectorStreamingConfiguration service method.</param>
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
        GetVoiceConnectorStreamingConfigurationResponse GetVoiceConnectorStreamingConfiguration(GetVoiceConnectorStreamingConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetVoiceConnectorStreamingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceConnectorStreamingConfiguration operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetVoiceConnectorStreamingConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetVoiceConnectorStreamingConfiguration">REST API Reference for GetVoiceConnectorStreamingConfiguration Operation</seealso>
        IAsyncResult BeginGetVoiceConnectorStreamingConfiguration(GetVoiceConnectorStreamingConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetVoiceConnectorStreamingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetVoiceConnectorStreamingConfiguration.</param>
        /// 
        /// <returns>Returns a  GetVoiceConnectorStreamingConfigurationResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetVoiceConnectorStreamingConfiguration">REST API Reference for GetVoiceConnectorStreamingConfiguration Operation</seealso>
        GetVoiceConnectorStreamingConfigurationResponse EndGetVoiceConnectorStreamingConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  GetVoiceConnectorTermination


        /// <summary>
        /// Retrieves the termination setting details for the specified Voice Connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceConnectorTermination service method.</param>
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
        GetVoiceConnectorTerminationResponse GetVoiceConnectorTermination(GetVoiceConnectorTerminationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetVoiceConnectorTermination operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceConnectorTermination operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetVoiceConnectorTermination
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetVoiceConnectorTermination">REST API Reference for GetVoiceConnectorTermination Operation</seealso>
        IAsyncResult BeginGetVoiceConnectorTermination(GetVoiceConnectorTerminationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetVoiceConnectorTermination operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetVoiceConnectorTermination.</param>
        /// 
        /// <returns>Returns a  GetVoiceConnectorTerminationResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetVoiceConnectorTermination">REST API Reference for GetVoiceConnectorTermination Operation</seealso>
        GetVoiceConnectorTerminationResponse EndGetVoiceConnectorTermination(IAsyncResult asyncResult);

        #endregion
        
        #region  GetVoiceConnectorTerminationHealth


        /// <summary>
        /// Retrieves information about the last time a <code>SIP OPTIONS</code> ping was received
        /// from your SIP infrastructure for the specified Amazon Chime SDK Voice Connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceConnectorTerminationHealth service method.</param>
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
        GetVoiceConnectorTerminationHealthResponse GetVoiceConnectorTerminationHealth(GetVoiceConnectorTerminationHealthRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetVoiceConnectorTerminationHealth operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceConnectorTerminationHealth operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetVoiceConnectorTerminationHealth
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetVoiceConnectorTerminationHealth">REST API Reference for GetVoiceConnectorTerminationHealth Operation</seealso>
        IAsyncResult BeginGetVoiceConnectorTerminationHealth(GetVoiceConnectorTerminationHealthRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetVoiceConnectorTerminationHealth operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetVoiceConnectorTerminationHealth.</param>
        /// 
        /// <returns>Returns a  GetVoiceConnectorTerminationHealthResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetVoiceConnectorTerminationHealth">REST API Reference for GetVoiceConnectorTerminationHealth Operation</seealso>
        GetVoiceConnectorTerminationHealthResponse EndGetVoiceConnectorTerminationHealth(IAsyncResult asyncResult);

        #endregion
        
        #region  GetVoiceProfile


        /// <summary>
        /// Retrieves the details of the specified voice profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceProfile service method.</param>
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
        GetVoiceProfileResponse GetVoiceProfile(GetVoiceProfileRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetVoiceProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceProfile operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetVoiceProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetVoiceProfile">REST API Reference for GetVoiceProfile Operation</seealso>
        IAsyncResult BeginGetVoiceProfile(GetVoiceProfileRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetVoiceProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetVoiceProfile.</param>
        /// 
        /// <returns>Returns a  GetVoiceProfileResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetVoiceProfile">REST API Reference for GetVoiceProfile Operation</seealso>
        GetVoiceProfileResponse EndGetVoiceProfile(IAsyncResult asyncResult);

        #endregion
        
        #region  GetVoiceProfileDomain


        /// <summary>
        /// Retrieves the details of the specified voice profile domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceProfileDomain service method.</param>
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
        GetVoiceProfileDomainResponse GetVoiceProfileDomain(GetVoiceProfileDomainRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetVoiceProfileDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceProfileDomain operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetVoiceProfileDomain
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetVoiceProfileDomain">REST API Reference for GetVoiceProfileDomain Operation</seealso>
        IAsyncResult BeginGetVoiceProfileDomain(GetVoiceProfileDomainRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetVoiceProfileDomain operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetVoiceProfileDomain.</param>
        /// 
        /// <returns>Returns a  GetVoiceProfileDomainResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetVoiceProfileDomain">REST API Reference for GetVoiceProfileDomain Operation</seealso>
        GetVoiceProfileDomainResponse EndGetVoiceProfileDomain(IAsyncResult asyncResult);

        #endregion
        
        #region  GetVoiceToneAnalysisTask


        /// <summary>
        /// Retrieves the details of a voice tone analysis task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceToneAnalysisTask service method.</param>
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
        GetVoiceToneAnalysisTaskResponse GetVoiceToneAnalysisTask(GetVoiceToneAnalysisTaskRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetVoiceToneAnalysisTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceToneAnalysisTask operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetVoiceToneAnalysisTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetVoiceToneAnalysisTask">REST API Reference for GetVoiceToneAnalysisTask Operation</seealso>
        IAsyncResult BeginGetVoiceToneAnalysisTask(GetVoiceToneAnalysisTaskRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetVoiceToneAnalysisTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetVoiceToneAnalysisTask.</param>
        /// 
        /// <returns>Returns a  GetVoiceToneAnalysisTaskResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetVoiceToneAnalysisTask">REST API Reference for GetVoiceToneAnalysisTask Operation</seealso>
        GetVoiceToneAnalysisTaskResponse EndGetVoiceToneAnalysisTask(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAvailableVoiceConnectorRegions


        /// <summary>
        /// Lists the available AWS Regions in which you can create an Amazon Chime SDK Voice
        /// Connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAvailableVoiceConnectorRegions service method.</param>
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
        ListAvailableVoiceConnectorRegionsResponse ListAvailableVoiceConnectorRegions(ListAvailableVoiceConnectorRegionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAvailableVoiceConnectorRegions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAvailableVoiceConnectorRegions operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAvailableVoiceConnectorRegions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/ListAvailableVoiceConnectorRegions">REST API Reference for ListAvailableVoiceConnectorRegions Operation</seealso>
        IAsyncResult BeginListAvailableVoiceConnectorRegions(ListAvailableVoiceConnectorRegionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAvailableVoiceConnectorRegions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAvailableVoiceConnectorRegions.</param>
        /// 
        /// <returns>Returns a  ListAvailableVoiceConnectorRegionsResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/ListAvailableVoiceConnectorRegions">REST API Reference for ListAvailableVoiceConnectorRegions Operation</seealso>
        ListAvailableVoiceConnectorRegionsResponse EndListAvailableVoiceConnectorRegions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListPhoneNumberOrders


        /// <summary>
        /// Lists the phone numbers for an administrator's Amazon Chime SDK account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPhoneNumberOrders service method.</param>
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
        ListPhoneNumberOrdersResponse ListPhoneNumberOrders(ListPhoneNumberOrdersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListPhoneNumberOrders operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPhoneNumberOrders operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPhoneNumberOrders
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/ListPhoneNumberOrders">REST API Reference for ListPhoneNumberOrders Operation</seealso>
        IAsyncResult BeginListPhoneNumberOrders(ListPhoneNumberOrdersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListPhoneNumberOrders operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPhoneNumberOrders.</param>
        /// 
        /// <returns>Returns a  ListPhoneNumberOrdersResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/ListPhoneNumberOrders">REST API Reference for ListPhoneNumberOrders Operation</seealso>
        ListPhoneNumberOrdersResponse EndListPhoneNumberOrders(IAsyncResult asyncResult);

        #endregion
        
        #region  ListPhoneNumbers


        /// <summary>
        /// Lists the phone numbers for the specified Amazon Chime SDK account, Amazon Chime SDK
        /// user, Amazon Chime SDK Voice Connector, or Amazon Chime SDK Voice Connector group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPhoneNumbers service method.</param>
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
        ListPhoneNumbersResponse ListPhoneNumbers(ListPhoneNumbersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListPhoneNumbers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPhoneNumbers operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPhoneNumbers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/ListPhoneNumbers">REST API Reference for ListPhoneNumbers Operation</seealso>
        IAsyncResult BeginListPhoneNumbers(ListPhoneNumbersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListPhoneNumbers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPhoneNumbers.</param>
        /// 
        /// <returns>Returns a  ListPhoneNumbersResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/ListPhoneNumbers">REST API Reference for ListPhoneNumbers Operation</seealso>
        ListPhoneNumbersResponse EndListPhoneNumbers(IAsyncResult asyncResult);

        #endregion
        
        #region  ListProxySessions


        /// <summary>
        /// Lists the proxy sessions for the specified Amazon Chime SDK Voice Connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProxySessions service method.</param>
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
        ListProxySessionsResponse ListProxySessions(ListProxySessionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListProxySessions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListProxySessions operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListProxySessions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/ListProxySessions">REST API Reference for ListProxySessions Operation</seealso>
        IAsyncResult BeginListProxySessions(ListProxySessionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListProxySessions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListProxySessions.</param>
        /// 
        /// <returns>Returns a  ListProxySessionsResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/ListProxySessions">REST API Reference for ListProxySessions Operation</seealso>
        ListProxySessionsResponse EndListProxySessions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListSipMediaApplications


        /// <summary>
        /// Lists the SIP media applications under the administrator's AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSipMediaApplications service method.</param>
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
        ListSipMediaApplicationsResponse ListSipMediaApplications(ListSipMediaApplicationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListSipMediaApplications operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSipMediaApplications operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSipMediaApplications
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/ListSipMediaApplications">REST API Reference for ListSipMediaApplications Operation</seealso>
        IAsyncResult BeginListSipMediaApplications(ListSipMediaApplicationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListSipMediaApplications operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSipMediaApplications.</param>
        /// 
        /// <returns>Returns a  ListSipMediaApplicationsResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/ListSipMediaApplications">REST API Reference for ListSipMediaApplications Operation</seealso>
        ListSipMediaApplicationsResponse EndListSipMediaApplications(IAsyncResult asyncResult);

        #endregion
        
        #region  ListSipRules


        /// <summary>
        /// Lists the SIP rules under the administrator's AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSipRules service method.</param>
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
        ListSipRulesResponse ListSipRules(ListSipRulesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListSipRules operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSipRules operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSipRules
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/ListSipRules">REST API Reference for ListSipRules Operation</seealso>
        IAsyncResult BeginListSipRules(ListSipRulesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListSipRules operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSipRules.</param>
        /// 
        /// <returns>Returns a  ListSipRulesResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/ListSipRules">REST API Reference for ListSipRules Operation</seealso>
        ListSipRulesResponse EndListSipRules(IAsyncResult asyncResult);

        #endregion
        
        #region  ListSupportedPhoneNumberCountries


        /// <summary>
        /// Lists the countries that you can order phone numbers from.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSupportedPhoneNumberCountries service method.</param>
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
        ListSupportedPhoneNumberCountriesResponse ListSupportedPhoneNumberCountries(ListSupportedPhoneNumberCountriesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListSupportedPhoneNumberCountries operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSupportedPhoneNumberCountries operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSupportedPhoneNumberCountries
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/ListSupportedPhoneNumberCountries">REST API Reference for ListSupportedPhoneNumberCountries Operation</seealso>
        IAsyncResult BeginListSupportedPhoneNumberCountries(ListSupportedPhoneNumberCountriesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListSupportedPhoneNumberCountries operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSupportedPhoneNumberCountries.</param>
        /// 
        /// <returns>Returns a  ListSupportedPhoneNumberCountriesResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/ListSupportedPhoneNumberCountries">REST API Reference for ListSupportedPhoneNumberCountries Operation</seealso>
        ListSupportedPhoneNumberCountriesResponse EndListSupportedPhoneNumberCountries(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Returns a list of the tags in a given resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
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
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  ListVoiceConnectorGroups


        /// <summary>
        /// Lists the Amazon Chime SDK Voice Connector groups in the administrator's AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVoiceConnectorGroups service method.</param>
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
        ListVoiceConnectorGroupsResponse ListVoiceConnectorGroups(ListVoiceConnectorGroupsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListVoiceConnectorGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVoiceConnectorGroups operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListVoiceConnectorGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/ListVoiceConnectorGroups">REST API Reference for ListVoiceConnectorGroups Operation</seealso>
        IAsyncResult BeginListVoiceConnectorGroups(ListVoiceConnectorGroupsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListVoiceConnectorGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListVoiceConnectorGroups.</param>
        /// 
        /// <returns>Returns a  ListVoiceConnectorGroupsResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/ListVoiceConnectorGroups">REST API Reference for ListVoiceConnectorGroups Operation</seealso>
        ListVoiceConnectorGroupsResponse EndListVoiceConnectorGroups(IAsyncResult asyncResult);

        #endregion
        
        #region  ListVoiceConnectors


        /// <summary>
        /// Lists the Amazon Chime SDK Voice Connectors in the administrators AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVoiceConnectors service method.</param>
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
        ListVoiceConnectorsResponse ListVoiceConnectors(ListVoiceConnectorsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListVoiceConnectors operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVoiceConnectors operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListVoiceConnectors
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/ListVoiceConnectors">REST API Reference for ListVoiceConnectors Operation</seealso>
        IAsyncResult BeginListVoiceConnectors(ListVoiceConnectorsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListVoiceConnectors operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListVoiceConnectors.</param>
        /// 
        /// <returns>Returns a  ListVoiceConnectorsResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/ListVoiceConnectors">REST API Reference for ListVoiceConnectors Operation</seealso>
        ListVoiceConnectorsResponse EndListVoiceConnectors(IAsyncResult asyncResult);

        #endregion
        
        #region  ListVoiceConnectorTerminationCredentials


        /// <summary>
        /// Lists the SIP credentials for the specified Amazon Chime SDK Voice Connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVoiceConnectorTerminationCredentials service method.</param>
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
        ListVoiceConnectorTerminationCredentialsResponse ListVoiceConnectorTerminationCredentials(ListVoiceConnectorTerminationCredentialsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListVoiceConnectorTerminationCredentials operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVoiceConnectorTerminationCredentials operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListVoiceConnectorTerminationCredentials
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/ListVoiceConnectorTerminationCredentials">REST API Reference for ListVoiceConnectorTerminationCredentials Operation</seealso>
        IAsyncResult BeginListVoiceConnectorTerminationCredentials(ListVoiceConnectorTerminationCredentialsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListVoiceConnectorTerminationCredentials operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListVoiceConnectorTerminationCredentials.</param>
        /// 
        /// <returns>Returns a  ListVoiceConnectorTerminationCredentialsResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/ListVoiceConnectorTerminationCredentials">REST API Reference for ListVoiceConnectorTerminationCredentials Operation</seealso>
        ListVoiceConnectorTerminationCredentialsResponse EndListVoiceConnectorTerminationCredentials(IAsyncResult asyncResult);

        #endregion
        
        #region  ListVoiceProfileDomains


        /// <summary>
        /// Lists the specified voice profile domains in the administrator's AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVoiceProfileDomains service method.</param>
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
        ListVoiceProfileDomainsResponse ListVoiceProfileDomains(ListVoiceProfileDomainsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListVoiceProfileDomains operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVoiceProfileDomains operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListVoiceProfileDomains
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/ListVoiceProfileDomains">REST API Reference for ListVoiceProfileDomains Operation</seealso>
        IAsyncResult BeginListVoiceProfileDomains(ListVoiceProfileDomainsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListVoiceProfileDomains operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListVoiceProfileDomains.</param>
        /// 
        /// <returns>Returns a  ListVoiceProfileDomainsResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/ListVoiceProfileDomains">REST API Reference for ListVoiceProfileDomains Operation</seealso>
        ListVoiceProfileDomainsResponse EndListVoiceProfileDomains(IAsyncResult asyncResult);

        #endregion
        
        #region  ListVoiceProfiles


        /// <summary>
        /// Lists the voice profiles in a voice profile domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVoiceProfiles service method.</param>
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
        ListVoiceProfilesResponse ListVoiceProfiles(ListVoiceProfilesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListVoiceProfiles operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVoiceProfiles operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListVoiceProfiles
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/ListVoiceProfiles">REST API Reference for ListVoiceProfiles Operation</seealso>
        IAsyncResult BeginListVoiceProfiles(ListVoiceProfilesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListVoiceProfiles operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListVoiceProfiles.</param>
        /// 
        /// <returns>Returns a  ListVoiceProfilesResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/ListVoiceProfiles">REST API Reference for ListVoiceProfiles Operation</seealso>
        ListVoiceProfilesResponse EndListVoiceProfiles(IAsyncResult asyncResult);

        #endregion
        
        #region  PutSipMediaApplicationAlexaSkillConfiguration


        /// <summary>
        /// Updates the Alexa Skill configuration for the SIP media application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutSipMediaApplicationAlexaSkillConfiguration service method.</param>
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
        PutSipMediaApplicationAlexaSkillConfigurationResponse PutSipMediaApplicationAlexaSkillConfiguration(PutSipMediaApplicationAlexaSkillConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutSipMediaApplicationAlexaSkillConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutSipMediaApplicationAlexaSkillConfiguration operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutSipMediaApplicationAlexaSkillConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/PutSipMediaApplicationAlexaSkillConfiguration">REST API Reference for PutSipMediaApplicationAlexaSkillConfiguration Operation</seealso>
        IAsyncResult BeginPutSipMediaApplicationAlexaSkillConfiguration(PutSipMediaApplicationAlexaSkillConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutSipMediaApplicationAlexaSkillConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutSipMediaApplicationAlexaSkillConfiguration.</param>
        /// 
        /// <returns>Returns a  PutSipMediaApplicationAlexaSkillConfigurationResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/PutSipMediaApplicationAlexaSkillConfiguration">REST API Reference for PutSipMediaApplicationAlexaSkillConfiguration Operation</seealso>
        PutSipMediaApplicationAlexaSkillConfigurationResponse EndPutSipMediaApplicationAlexaSkillConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  PutSipMediaApplicationLoggingConfiguration


        /// <summary>
        /// Updates the logging configuration for the specified SIP media application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutSipMediaApplicationLoggingConfiguration service method.</param>
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
        PutSipMediaApplicationLoggingConfigurationResponse PutSipMediaApplicationLoggingConfiguration(PutSipMediaApplicationLoggingConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutSipMediaApplicationLoggingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutSipMediaApplicationLoggingConfiguration operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutSipMediaApplicationLoggingConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/PutSipMediaApplicationLoggingConfiguration">REST API Reference for PutSipMediaApplicationLoggingConfiguration Operation</seealso>
        IAsyncResult BeginPutSipMediaApplicationLoggingConfiguration(PutSipMediaApplicationLoggingConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutSipMediaApplicationLoggingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutSipMediaApplicationLoggingConfiguration.</param>
        /// 
        /// <returns>Returns a  PutSipMediaApplicationLoggingConfigurationResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/PutSipMediaApplicationLoggingConfiguration">REST API Reference for PutSipMediaApplicationLoggingConfiguration Operation</seealso>
        PutSipMediaApplicationLoggingConfigurationResponse EndPutSipMediaApplicationLoggingConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  PutVoiceConnectorEmergencyCallingConfiguration


        /// <summary>
        /// Updates a Voice Connector's emergency calling configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutVoiceConnectorEmergencyCallingConfiguration service method.</param>
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
        PutVoiceConnectorEmergencyCallingConfigurationResponse PutVoiceConnectorEmergencyCallingConfiguration(PutVoiceConnectorEmergencyCallingConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutVoiceConnectorEmergencyCallingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutVoiceConnectorEmergencyCallingConfiguration operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutVoiceConnectorEmergencyCallingConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/PutVoiceConnectorEmergencyCallingConfiguration">REST API Reference for PutVoiceConnectorEmergencyCallingConfiguration Operation</seealso>
        IAsyncResult BeginPutVoiceConnectorEmergencyCallingConfiguration(PutVoiceConnectorEmergencyCallingConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutVoiceConnectorEmergencyCallingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutVoiceConnectorEmergencyCallingConfiguration.</param>
        /// 
        /// <returns>Returns a  PutVoiceConnectorEmergencyCallingConfigurationResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/PutVoiceConnectorEmergencyCallingConfiguration">REST API Reference for PutVoiceConnectorEmergencyCallingConfiguration Operation</seealso>
        PutVoiceConnectorEmergencyCallingConfigurationResponse EndPutVoiceConnectorEmergencyCallingConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  PutVoiceConnectorLoggingConfiguration


        /// <summary>
        /// Updates a Voice Connector's logging configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutVoiceConnectorLoggingConfiguration service method.</param>
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
        PutVoiceConnectorLoggingConfigurationResponse PutVoiceConnectorLoggingConfiguration(PutVoiceConnectorLoggingConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutVoiceConnectorLoggingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutVoiceConnectorLoggingConfiguration operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutVoiceConnectorLoggingConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/PutVoiceConnectorLoggingConfiguration">REST API Reference for PutVoiceConnectorLoggingConfiguration Operation</seealso>
        IAsyncResult BeginPutVoiceConnectorLoggingConfiguration(PutVoiceConnectorLoggingConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutVoiceConnectorLoggingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutVoiceConnectorLoggingConfiguration.</param>
        /// 
        /// <returns>Returns a  PutVoiceConnectorLoggingConfigurationResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/PutVoiceConnectorLoggingConfiguration">REST API Reference for PutVoiceConnectorLoggingConfiguration Operation</seealso>
        PutVoiceConnectorLoggingConfigurationResponse EndPutVoiceConnectorLoggingConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  PutVoiceConnectorOrigination


        /// <summary>
        /// Updates a Voice Connector's origination settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutVoiceConnectorOrigination service method.</param>
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
        PutVoiceConnectorOriginationResponse PutVoiceConnectorOrigination(PutVoiceConnectorOriginationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutVoiceConnectorOrigination operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutVoiceConnectorOrigination operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutVoiceConnectorOrigination
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/PutVoiceConnectorOrigination">REST API Reference for PutVoiceConnectorOrigination Operation</seealso>
        IAsyncResult BeginPutVoiceConnectorOrigination(PutVoiceConnectorOriginationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutVoiceConnectorOrigination operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutVoiceConnectorOrigination.</param>
        /// 
        /// <returns>Returns a  PutVoiceConnectorOriginationResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/PutVoiceConnectorOrigination">REST API Reference for PutVoiceConnectorOrigination Operation</seealso>
        PutVoiceConnectorOriginationResponse EndPutVoiceConnectorOrigination(IAsyncResult asyncResult);

        #endregion
        
        #region  PutVoiceConnectorProxy


        /// <summary>
        /// Puts the specified proxy configuration to the specified Amazon Chime SDK Voice Connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutVoiceConnectorProxy service method.</param>
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
        PutVoiceConnectorProxyResponse PutVoiceConnectorProxy(PutVoiceConnectorProxyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutVoiceConnectorProxy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutVoiceConnectorProxy operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutVoiceConnectorProxy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/PutVoiceConnectorProxy">REST API Reference for PutVoiceConnectorProxy Operation</seealso>
        IAsyncResult BeginPutVoiceConnectorProxy(PutVoiceConnectorProxyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutVoiceConnectorProxy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutVoiceConnectorProxy.</param>
        /// 
        /// <returns>Returns a  PutVoiceConnectorProxyResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/PutVoiceConnectorProxy">REST API Reference for PutVoiceConnectorProxy Operation</seealso>
        PutVoiceConnectorProxyResponse EndPutVoiceConnectorProxy(IAsyncResult asyncResult);

        #endregion
        
        #region  PutVoiceConnectorStreamingConfiguration


        /// <summary>
        /// Updates a Voice Connector's streaming configuration settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutVoiceConnectorStreamingConfiguration service method.</param>
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
        PutVoiceConnectorStreamingConfigurationResponse PutVoiceConnectorStreamingConfiguration(PutVoiceConnectorStreamingConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutVoiceConnectorStreamingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutVoiceConnectorStreamingConfiguration operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutVoiceConnectorStreamingConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/PutVoiceConnectorStreamingConfiguration">REST API Reference for PutVoiceConnectorStreamingConfiguration Operation</seealso>
        IAsyncResult BeginPutVoiceConnectorStreamingConfiguration(PutVoiceConnectorStreamingConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutVoiceConnectorStreamingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutVoiceConnectorStreamingConfiguration.</param>
        /// 
        /// <returns>Returns a  PutVoiceConnectorStreamingConfigurationResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/PutVoiceConnectorStreamingConfiguration">REST API Reference for PutVoiceConnectorStreamingConfiguration Operation</seealso>
        PutVoiceConnectorStreamingConfigurationResponse EndPutVoiceConnectorStreamingConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  PutVoiceConnectorTermination


        /// <summary>
        /// Updates a Voice Connector's termination settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutVoiceConnectorTermination service method.</param>
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
        PutVoiceConnectorTerminationResponse PutVoiceConnectorTermination(PutVoiceConnectorTerminationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutVoiceConnectorTermination operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutVoiceConnectorTermination operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutVoiceConnectorTermination
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/PutVoiceConnectorTermination">REST API Reference for PutVoiceConnectorTermination Operation</seealso>
        IAsyncResult BeginPutVoiceConnectorTermination(PutVoiceConnectorTerminationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutVoiceConnectorTermination operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutVoiceConnectorTermination.</param>
        /// 
        /// <returns>Returns a  PutVoiceConnectorTerminationResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/PutVoiceConnectorTermination">REST API Reference for PutVoiceConnectorTermination Operation</seealso>
        PutVoiceConnectorTerminationResponse EndPutVoiceConnectorTermination(IAsyncResult asyncResult);

        #endregion
        
        #region  PutVoiceConnectorTerminationCredentials


        /// <summary>
        /// Updates a Voice Connector's termination credentials.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutVoiceConnectorTerminationCredentials service method.</param>
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
        PutVoiceConnectorTerminationCredentialsResponse PutVoiceConnectorTerminationCredentials(PutVoiceConnectorTerminationCredentialsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutVoiceConnectorTerminationCredentials operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutVoiceConnectorTerminationCredentials operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutVoiceConnectorTerminationCredentials
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/PutVoiceConnectorTerminationCredentials">REST API Reference for PutVoiceConnectorTerminationCredentials Operation</seealso>
        IAsyncResult BeginPutVoiceConnectorTerminationCredentials(PutVoiceConnectorTerminationCredentialsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutVoiceConnectorTerminationCredentials operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutVoiceConnectorTerminationCredentials.</param>
        /// 
        /// <returns>Returns a  PutVoiceConnectorTerminationCredentialsResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/PutVoiceConnectorTerminationCredentials">REST API Reference for PutVoiceConnectorTerminationCredentials Operation</seealso>
        PutVoiceConnectorTerminationCredentialsResponse EndPutVoiceConnectorTerminationCredentials(IAsyncResult asyncResult);

        #endregion
        
        #region  RestorePhoneNumber


        /// <summary>
        /// Restores a deleted phone number.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestorePhoneNumber service method.</param>
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
        RestorePhoneNumberResponse RestorePhoneNumber(RestorePhoneNumberRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RestorePhoneNumber operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RestorePhoneNumber operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRestorePhoneNumber
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/RestorePhoneNumber">REST API Reference for RestorePhoneNumber Operation</seealso>
        IAsyncResult BeginRestorePhoneNumber(RestorePhoneNumberRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RestorePhoneNumber operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRestorePhoneNumber.</param>
        /// 
        /// <returns>Returns a  RestorePhoneNumberResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/RestorePhoneNumber">REST API Reference for RestorePhoneNumber Operation</seealso>
        RestorePhoneNumberResponse EndRestorePhoneNumber(IAsyncResult asyncResult);

        #endregion
        
        #region  SearchAvailablePhoneNumbers


        /// <summary>
        /// Searches the provisioned phone numbers in an organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchAvailablePhoneNumbers service method.</param>
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
        SearchAvailablePhoneNumbersResponse SearchAvailablePhoneNumbers(SearchAvailablePhoneNumbersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SearchAvailablePhoneNumbers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchAvailablePhoneNumbers operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSearchAvailablePhoneNumbers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/SearchAvailablePhoneNumbers">REST API Reference for SearchAvailablePhoneNumbers Operation</seealso>
        IAsyncResult BeginSearchAvailablePhoneNumbers(SearchAvailablePhoneNumbersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SearchAvailablePhoneNumbers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSearchAvailablePhoneNumbers.</param>
        /// 
        /// <returns>Returns a  SearchAvailablePhoneNumbersResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/SearchAvailablePhoneNumbers">REST API Reference for SearchAvailablePhoneNumbers Operation</seealso>
        SearchAvailablePhoneNumbersResponse EndSearchAvailablePhoneNumbers(IAsyncResult asyncResult);

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
        StartSpeakerSearchTaskResponse StartSpeakerSearchTask(StartSpeakerSearchTaskRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartSpeakerSearchTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartSpeakerSearchTask operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartSpeakerSearchTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/StartSpeakerSearchTask">REST API Reference for StartSpeakerSearchTask Operation</seealso>
        IAsyncResult BeginStartSpeakerSearchTask(StartSpeakerSearchTaskRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartSpeakerSearchTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartSpeakerSearchTask.</param>
        /// 
        /// <returns>Returns a  StartSpeakerSearchTaskResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/StartSpeakerSearchTask">REST API Reference for StartSpeakerSearchTask Operation</seealso>
        StartSpeakerSearchTaskResponse EndStartSpeakerSearchTask(IAsyncResult asyncResult);

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
        StartVoiceToneAnalysisTaskResponse StartVoiceToneAnalysisTask(StartVoiceToneAnalysisTaskRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartVoiceToneAnalysisTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartVoiceToneAnalysisTask operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartVoiceToneAnalysisTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/StartVoiceToneAnalysisTask">REST API Reference for StartVoiceToneAnalysisTask Operation</seealso>
        IAsyncResult BeginStartVoiceToneAnalysisTask(StartVoiceToneAnalysisTaskRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartVoiceToneAnalysisTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartVoiceToneAnalysisTask.</param>
        /// 
        /// <returns>Returns a  StartVoiceToneAnalysisTaskResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/StartVoiceToneAnalysisTask">REST API Reference for StartVoiceToneAnalysisTask Operation</seealso>
        StartVoiceToneAnalysisTaskResponse EndStartVoiceToneAnalysisTask(IAsyncResult asyncResult);

        #endregion
        
        #region  StopSpeakerSearchTask


        /// <summary>
        /// Stops a speaker search task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopSpeakerSearchTask service method.</param>
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
        StopSpeakerSearchTaskResponse StopSpeakerSearchTask(StopSpeakerSearchTaskRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StopSpeakerSearchTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopSpeakerSearchTask operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopSpeakerSearchTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/StopSpeakerSearchTask">REST API Reference for StopSpeakerSearchTask Operation</seealso>
        IAsyncResult BeginStopSpeakerSearchTask(StopSpeakerSearchTaskRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopSpeakerSearchTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopSpeakerSearchTask.</param>
        /// 
        /// <returns>Returns a  StopSpeakerSearchTaskResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/StopSpeakerSearchTask">REST API Reference for StopSpeakerSearchTask Operation</seealso>
        StopSpeakerSearchTaskResponse EndStopSpeakerSearchTask(IAsyncResult asyncResult);

        #endregion
        
        #region  StopVoiceToneAnalysisTask


        /// <summary>
        /// Stops a voice tone analysis task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopVoiceToneAnalysisTask service method.</param>
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
        StopVoiceToneAnalysisTaskResponse StopVoiceToneAnalysisTask(StopVoiceToneAnalysisTaskRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StopVoiceToneAnalysisTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopVoiceToneAnalysisTask operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopVoiceToneAnalysisTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/StopVoiceToneAnalysisTask">REST API Reference for StopVoiceToneAnalysisTask Operation</seealso>
        IAsyncResult BeginStopVoiceToneAnalysisTask(StopVoiceToneAnalysisTaskRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopVoiceToneAnalysisTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopVoiceToneAnalysisTask.</param>
        /// 
        /// <returns>Returns a  StopVoiceToneAnalysisTaskResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/StopVoiceToneAnalysisTask">REST API Reference for StopVoiceToneAnalysisTask Operation</seealso>
        StopVoiceToneAnalysisTaskResponse EndStopVoiceToneAnalysisTask(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds a tag to the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
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
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
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
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateGlobalSettings


        /// <summary>
        /// Updates global settings for the Amazon Chime SDK Voice Connectors in an AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGlobalSettings service method.</param>
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
        UpdateGlobalSettingsResponse UpdateGlobalSettings(UpdateGlobalSettingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateGlobalSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateGlobalSettings operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateGlobalSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/UpdateGlobalSettings">REST API Reference for UpdateGlobalSettings Operation</seealso>
        IAsyncResult BeginUpdateGlobalSettings(UpdateGlobalSettingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateGlobalSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateGlobalSettings.</param>
        /// 
        /// <returns>Returns a  UpdateGlobalSettingsResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/UpdateGlobalSettings">REST API Reference for UpdateGlobalSettings Operation</seealso>
        UpdateGlobalSettingsResponse EndUpdateGlobalSettings(IAsyncResult asyncResult);

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
        UpdatePhoneNumberResponse UpdatePhoneNumber(UpdatePhoneNumberRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePhoneNumber operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePhoneNumber operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdatePhoneNumber
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/UpdatePhoneNumber">REST API Reference for UpdatePhoneNumber Operation</seealso>
        IAsyncResult BeginUpdatePhoneNumber(UpdatePhoneNumberRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdatePhoneNumber operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdatePhoneNumber.</param>
        /// 
        /// <returns>Returns a  UpdatePhoneNumberResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/UpdatePhoneNumber">REST API Reference for UpdatePhoneNumber Operation</seealso>
        UpdatePhoneNumberResponse EndUpdatePhoneNumber(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdatePhoneNumberSettings


        /// <summary>
        /// Updates the phone number settings for the administrator's AWS account, such as the
        /// default outbound calling name. You can update the default outbound calling name once
        /// every seven days. Outbound calling names can take up to 72 hours to update.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePhoneNumberSettings service method.</param>
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
        UpdatePhoneNumberSettingsResponse UpdatePhoneNumberSettings(UpdatePhoneNumberSettingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePhoneNumberSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePhoneNumberSettings operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdatePhoneNumberSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/UpdatePhoneNumberSettings">REST API Reference for UpdatePhoneNumberSettings Operation</seealso>
        IAsyncResult BeginUpdatePhoneNumberSettings(UpdatePhoneNumberSettingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdatePhoneNumberSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdatePhoneNumberSettings.</param>
        /// 
        /// <returns>Returns a  UpdatePhoneNumberSettingsResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/UpdatePhoneNumberSettings">REST API Reference for UpdatePhoneNumberSettings Operation</seealso>
        UpdatePhoneNumberSettingsResponse EndUpdatePhoneNumberSettings(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateProxySession


        /// <summary>
        /// Updates the specified proxy session details, such as voice or SMS capabilities.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProxySession service method.</param>
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
        UpdateProxySessionResponse UpdateProxySession(UpdateProxySessionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateProxySession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateProxySession operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateProxySession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/UpdateProxySession">REST API Reference for UpdateProxySession Operation</seealso>
        IAsyncResult BeginUpdateProxySession(UpdateProxySessionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateProxySession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateProxySession.</param>
        /// 
        /// <returns>Returns a  UpdateProxySessionResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/UpdateProxySession">REST API Reference for UpdateProxySession Operation</seealso>
        UpdateProxySessionResponse EndUpdateProxySession(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateSipMediaApplication


        /// <summary>
        /// Updates the details of the specified SIP media application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSipMediaApplication service method.</param>
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
        UpdateSipMediaApplicationResponse UpdateSipMediaApplication(UpdateSipMediaApplicationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSipMediaApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSipMediaApplication operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSipMediaApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/UpdateSipMediaApplication">REST API Reference for UpdateSipMediaApplication Operation</seealso>
        IAsyncResult BeginUpdateSipMediaApplication(UpdateSipMediaApplicationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSipMediaApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSipMediaApplication.</param>
        /// 
        /// <returns>Returns a  UpdateSipMediaApplicationResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/UpdateSipMediaApplication">REST API Reference for UpdateSipMediaApplication Operation</seealso>
        UpdateSipMediaApplicationResponse EndUpdateSipMediaApplication(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateSipMediaApplicationCall


        /// <summary>
        /// Invokes the AWS Lambda function associated with the SIP media application and transaction
        /// ID in an update request. The Lambda function can then return a new set of actions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSipMediaApplicationCall service method.</param>
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
        UpdateSipMediaApplicationCallResponse UpdateSipMediaApplicationCall(UpdateSipMediaApplicationCallRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSipMediaApplicationCall operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSipMediaApplicationCall operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSipMediaApplicationCall
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/UpdateSipMediaApplicationCall">REST API Reference for UpdateSipMediaApplicationCall Operation</seealso>
        IAsyncResult BeginUpdateSipMediaApplicationCall(UpdateSipMediaApplicationCallRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSipMediaApplicationCall operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSipMediaApplicationCall.</param>
        /// 
        /// <returns>Returns a  UpdateSipMediaApplicationCallResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/UpdateSipMediaApplicationCall">REST API Reference for UpdateSipMediaApplicationCall Operation</seealso>
        UpdateSipMediaApplicationCallResponse EndUpdateSipMediaApplicationCall(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateSipRule


        /// <summary>
        /// Updates the details of the specified SIP rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSipRule service method.</param>
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
        UpdateSipRuleResponse UpdateSipRule(UpdateSipRuleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSipRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSipRule operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSipRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/UpdateSipRule">REST API Reference for UpdateSipRule Operation</seealso>
        IAsyncResult BeginUpdateSipRule(UpdateSipRuleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSipRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSipRule.</param>
        /// 
        /// <returns>Returns a  UpdateSipRuleResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/UpdateSipRule">REST API Reference for UpdateSipRule Operation</seealso>
        UpdateSipRuleResponse EndUpdateSipRule(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateVoiceConnector


        /// <summary>
        /// Updates the details for the specified Amazon Chime SDK Voice Connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateVoiceConnector service method.</param>
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
        UpdateVoiceConnectorResponse UpdateVoiceConnector(UpdateVoiceConnectorRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateVoiceConnector operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateVoiceConnector operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateVoiceConnector
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/UpdateVoiceConnector">REST API Reference for UpdateVoiceConnector Operation</seealso>
        IAsyncResult BeginUpdateVoiceConnector(UpdateVoiceConnectorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateVoiceConnector operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateVoiceConnector.</param>
        /// 
        /// <returns>Returns a  UpdateVoiceConnectorResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/UpdateVoiceConnector">REST API Reference for UpdateVoiceConnector Operation</seealso>
        UpdateVoiceConnectorResponse EndUpdateVoiceConnector(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateVoiceConnectorGroup


        /// <summary>
        /// Updates the settings for the specified Amazon Chime SDK Voice Connector group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateVoiceConnectorGroup service method.</param>
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
        UpdateVoiceConnectorGroupResponse UpdateVoiceConnectorGroup(UpdateVoiceConnectorGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateVoiceConnectorGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateVoiceConnectorGroup operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateVoiceConnectorGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/UpdateVoiceConnectorGroup">REST API Reference for UpdateVoiceConnectorGroup Operation</seealso>
        IAsyncResult BeginUpdateVoiceConnectorGroup(UpdateVoiceConnectorGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateVoiceConnectorGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateVoiceConnectorGroup.</param>
        /// 
        /// <returns>Returns a  UpdateVoiceConnectorGroupResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/UpdateVoiceConnectorGroup">REST API Reference for UpdateVoiceConnectorGroup Operation</seealso>
        UpdateVoiceConnectorGroupResponse EndUpdateVoiceConnectorGroup(IAsyncResult asyncResult);

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
        UpdateVoiceProfileResponse UpdateVoiceProfile(UpdateVoiceProfileRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateVoiceProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateVoiceProfile operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateVoiceProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/UpdateVoiceProfile">REST API Reference for UpdateVoiceProfile Operation</seealso>
        IAsyncResult BeginUpdateVoiceProfile(UpdateVoiceProfileRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateVoiceProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateVoiceProfile.</param>
        /// 
        /// <returns>Returns a  UpdateVoiceProfileResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/UpdateVoiceProfile">REST API Reference for UpdateVoiceProfile Operation</seealso>
        UpdateVoiceProfileResponse EndUpdateVoiceProfile(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateVoiceProfileDomain


        /// <summary>
        /// Updates the settings for the specified voice profile domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateVoiceProfileDomain service method.</param>
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
        UpdateVoiceProfileDomainResponse UpdateVoiceProfileDomain(UpdateVoiceProfileDomainRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateVoiceProfileDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateVoiceProfileDomain operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateVoiceProfileDomain
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/UpdateVoiceProfileDomain">REST API Reference for UpdateVoiceProfileDomain Operation</seealso>
        IAsyncResult BeginUpdateVoiceProfileDomain(UpdateVoiceProfileDomainRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateVoiceProfileDomain operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateVoiceProfileDomain.</param>
        /// 
        /// <returns>Returns a  UpdateVoiceProfileDomainResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/UpdateVoiceProfileDomain">REST API Reference for UpdateVoiceProfileDomain Operation</seealso>
        UpdateVoiceProfileDomainResponse EndUpdateVoiceProfileDomain(IAsyncResult asyncResult);

        #endregion
        
        #region  ValidateE911Address


        /// <summary>
        /// Validates an address to be used for 911 calls made with Amazon Chime SDK Voice Connectors.
        /// You can use validated addresses in a Presence Information Data Format Location Object
        /// file that you include in SIP requests. That helps ensure that addresses are routed
        /// to the appropriate Public Safety Answering Point.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ValidateE911Address service method.</param>
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
        ValidateE911AddressResponse ValidateE911Address(ValidateE911AddressRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ValidateE911Address operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ValidateE911Address operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndValidateE911Address
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/ValidateE911Address">REST API Reference for ValidateE911Address Operation</seealso>
        IAsyncResult BeginValidateE911Address(ValidateE911AddressRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ValidateE911Address operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginValidateE911Address.</param>
        /// 
        /// <returns>Returns a  ValidateE911AddressResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/ValidateE911Address">REST API Reference for ValidateE911Address Operation</seealso>
        ValidateE911AddressResponse EndValidateE911Address(IAsyncResult asyncResult);

        #endregion
        
    }
}