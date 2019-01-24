/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the sms-voice-2018-09-05.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.PinpointSMSVoice.Model;

namespace Amazon.PinpointSMSVoice
{
    /// <summary>
    /// Interface for accessing PinpointSMSVoice
    ///
    /// Pinpoint SMS and Voice Messaging public facing APIs
    /// </summary>
    public partial interface IAmazonPinpointSMSVoice : IAmazonService, IDisposable
    {

        
        #region  CreateConfigurationSet


        /// <summary>
        /// Create a new configuration set. After you create the configuration set, you can add
        /// one or more event destinations to it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConfigurationSet service method.</param>
        /// 
        /// <returns>The response from the CreateConfigurationSet service method, as returned by PinpointSMSVoice.</returns>
        /// <exception cref="Amazon.PinpointSMSVoice.Model.AlreadyExistsException">
        /// The resource specified in your request already exists.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoice.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoice.Model.InternalServiceErrorException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoice.Model.LimitExceededException">
        /// There are too many instances of the specified resource type.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoice.Model.TooManyRequestsException">
        /// You've issued too many requests to the resource. Wait a few minutes, and then try
        /// again.
        /// </exception>
        CreateConfigurationSetResponse CreateConfigurationSet(CreateConfigurationSetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateConfigurationSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateConfigurationSet operation on AmazonPinpointSMSVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateConfigurationSet
        ///         operation.</returns>
        IAsyncResult BeginCreateConfigurationSet(CreateConfigurationSetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateConfigurationSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateConfigurationSet.</param>
        /// 
        /// <returns>Returns a  CreateConfigurationSetResult from PinpointSMSVoice.</returns>
        CreateConfigurationSetResponse EndCreateConfigurationSet(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateConfigurationSetEventDestination


        /// <summary>
        /// Create a new event destination in a configuration set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConfigurationSetEventDestination service method.</param>
        /// 
        /// <returns>The response from the CreateConfigurationSetEventDestination service method, as returned by PinpointSMSVoice.</returns>
        /// <exception cref="Amazon.PinpointSMSVoice.Model.AlreadyExistsException">
        /// The resource specified in your request already exists.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoice.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoice.Model.InternalServiceErrorException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoice.Model.LimitExceededException">
        /// There are too many instances of the specified resource type.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoice.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoice.Model.TooManyRequestsException">
        /// You've issued too many requests to the resource. Wait a few minutes, and then try
        /// again.
        /// </exception>
        CreateConfigurationSetEventDestinationResponse CreateConfigurationSetEventDestination(CreateConfigurationSetEventDestinationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateConfigurationSetEventDestination operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateConfigurationSetEventDestination operation on AmazonPinpointSMSVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateConfigurationSetEventDestination
        ///         operation.</returns>
        IAsyncResult BeginCreateConfigurationSetEventDestination(CreateConfigurationSetEventDestinationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateConfigurationSetEventDestination operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateConfigurationSetEventDestination.</param>
        /// 
        /// <returns>Returns a  CreateConfigurationSetEventDestinationResult from PinpointSMSVoice.</returns>
        CreateConfigurationSetEventDestinationResponse EndCreateConfigurationSetEventDestination(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteConfigurationSet


        /// <summary>
        /// Deletes an existing configuration set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfigurationSet service method.</param>
        /// 
        /// <returns>The response from the DeleteConfigurationSet service method, as returned by PinpointSMSVoice.</returns>
        /// <exception cref="Amazon.PinpointSMSVoice.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoice.Model.InternalServiceErrorException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoice.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoice.Model.TooManyRequestsException">
        /// You've issued too many requests to the resource. Wait a few minutes, and then try
        /// again.
        /// </exception>
        DeleteConfigurationSetResponse DeleteConfigurationSet(DeleteConfigurationSetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteConfigurationSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfigurationSet operation on AmazonPinpointSMSVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteConfigurationSet
        ///         operation.</returns>
        IAsyncResult BeginDeleteConfigurationSet(DeleteConfigurationSetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteConfigurationSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteConfigurationSet.</param>
        /// 
        /// <returns>Returns a  DeleteConfigurationSetResult from PinpointSMSVoice.</returns>
        DeleteConfigurationSetResponse EndDeleteConfigurationSet(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteConfigurationSetEventDestination


        /// <summary>
        /// Deletes an event destination in a configuration set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfigurationSetEventDestination service method.</param>
        /// 
        /// <returns>The response from the DeleteConfigurationSetEventDestination service method, as returned by PinpointSMSVoice.</returns>
        /// <exception cref="Amazon.PinpointSMSVoice.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoice.Model.InternalServiceErrorException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoice.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoice.Model.TooManyRequestsException">
        /// You've issued too many requests to the resource. Wait a few minutes, and then try
        /// again.
        /// </exception>
        DeleteConfigurationSetEventDestinationResponse DeleteConfigurationSetEventDestination(DeleteConfigurationSetEventDestinationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteConfigurationSetEventDestination operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfigurationSetEventDestination operation on AmazonPinpointSMSVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteConfigurationSetEventDestination
        ///         operation.</returns>
        IAsyncResult BeginDeleteConfigurationSetEventDestination(DeleteConfigurationSetEventDestinationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteConfigurationSetEventDestination operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteConfigurationSetEventDestination.</param>
        /// 
        /// <returns>Returns a  DeleteConfigurationSetEventDestinationResult from PinpointSMSVoice.</returns>
        DeleteConfigurationSetEventDestinationResponse EndDeleteConfigurationSetEventDestination(IAsyncResult asyncResult);

        #endregion
        
        #region  GetConfigurationSetEventDestinations


        /// <summary>
        /// Obtain information about an event destination, including the types of events it reports,
        /// the Amazon Resource Name (ARN) of the destination, and the name of the event destination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConfigurationSetEventDestinations service method.</param>
        /// 
        /// <returns>The response from the GetConfigurationSetEventDestinations service method, as returned by PinpointSMSVoice.</returns>
        /// <exception cref="Amazon.PinpointSMSVoice.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoice.Model.InternalServiceErrorException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoice.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoice.Model.TooManyRequestsException">
        /// You've issued too many requests to the resource. Wait a few minutes, and then try
        /// again.
        /// </exception>
        GetConfigurationSetEventDestinationsResponse GetConfigurationSetEventDestinations(GetConfigurationSetEventDestinationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetConfigurationSetEventDestinations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetConfigurationSetEventDestinations operation on AmazonPinpointSMSVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetConfigurationSetEventDestinations
        ///         operation.</returns>
        IAsyncResult BeginGetConfigurationSetEventDestinations(GetConfigurationSetEventDestinationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetConfigurationSetEventDestinations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetConfigurationSetEventDestinations.</param>
        /// 
        /// <returns>Returns a  GetConfigurationSetEventDestinationsResult from PinpointSMSVoice.</returns>
        GetConfigurationSetEventDestinationsResponse EndGetConfigurationSetEventDestinations(IAsyncResult asyncResult);

        #endregion
        
        #region  ListConfigurationSets


        /// <summary>
        /// List all of the configuration sets associated with your Amazon Pinpoint account in
        /// the current region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConfigurationSets service method.</param>
        /// 
        /// <returns>The response from the ListConfigurationSets service method, as returned by PinpointSMSVoice.</returns>
        /// <exception cref="Amazon.PinpointSMSVoice.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoice.Model.InternalServiceErrorException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoice.Model.TooManyRequestsException">
        /// You've issued too many requests to the resource. Wait a few minutes, and then try
        /// again.
        /// </exception>
        ListConfigurationSetsResponse ListConfigurationSets(ListConfigurationSetsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListConfigurationSets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListConfigurationSets operation on AmazonPinpointSMSVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListConfigurationSets
        ///         operation.</returns>
        IAsyncResult BeginListConfigurationSets(ListConfigurationSetsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListConfigurationSets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListConfigurationSets.</param>
        /// 
        /// <returns>Returns a  ListConfigurationSetsResult from PinpointSMSVoice.</returns>
        ListConfigurationSetsResponse EndListConfigurationSets(IAsyncResult asyncResult);

        #endregion
        
        #region  SendVoiceMessage


        /// <summary>
        /// Create a new voice message and send it to a recipient's phone number.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendVoiceMessage service method.</param>
        /// 
        /// <returns>The response from the SendVoiceMessage service method, as returned by PinpointSMSVoice.</returns>
        /// <exception cref="Amazon.PinpointSMSVoice.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoice.Model.InternalServiceErrorException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoice.Model.TooManyRequestsException">
        /// You've issued too many requests to the resource. Wait a few minutes, and then try
        /// again.
        /// </exception>
        SendVoiceMessageResponse SendVoiceMessage(SendVoiceMessageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SendVoiceMessage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SendVoiceMessage operation on AmazonPinpointSMSVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSendVoiceMessage
        ///         operation.</returns>
        IAsyncResult BeginSendVoiceMessage(SendVoiceMessageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SendVoiceMessage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSendVoiceMessage.</param>
        /// 
        /// <returns>Returns a  SendVoiceMessageResult from PinpointSMSVoice.</returns>
        SendVoiceMessageResponse EndSendVoiceMessage(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateConfigurationSetEventDestination


        /// <summary>
        /// Update an event destination in a configuration set. An event destination is a location
        /// that you publish information about your voice calls to. For example, you can log an
        /// event to an Amazon CloudWatch destination when a call fails.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfigurationSetEventDestination service method.</param>
        /// 
        /// <returns>The response from the UpdateConfigurationSetEventDestination service method, as returned by PinpointSMSVoice.</returns>
        /// <exception cref="Amazon.PinpointSMSVoice.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoice.Model.InternalServiceErrorException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoice.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoice.Model.TooManyRequestsException">
        /// You've issued too many requests to the resource. Wait a few minutes, and then try
        /// again.
        /// </exception>
        UpdateConfigurationSetEventDestinationResponse UpdateConfigurationSetEventDestination(UpdateConfigurationSetEventDestinationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateConfigurationSetEventDestination operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfigurationSetEventDestination operation on AmazonPinpointSMSVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateConfigurationSetEventDestination
        ///         operation.</returns>
        IAsyncResult BeginUpdateConfigurationSetEventDestination(UpdateConfigurationSetEventDestinationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateConfigurationSetEventDestination operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateConfigurationSetEventDestination.</param>
        /// 
        /// <returns>Returns a  UpdateConfigurationSetEventDestinationResult from PinpointSMSVoice.</returns>
        UpdateConfigurationSetEventDestinationResponse EndUpdateConfigurationSetEventDestination(IAsyncResult asyncResult);

        #endregion
        
    }
}