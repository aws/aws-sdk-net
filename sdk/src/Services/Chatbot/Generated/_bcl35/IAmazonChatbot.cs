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
 * Do not modify this file. This file is generated from the chatbot-2017-10-11.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Chatbot.Model;

#pragma warning disable CS1570
namespace Amazon.Chatbot
{
    /// <summary>
    /// <para>Interface for accessing Chatbot</para>
    ///
    /// AWS Chatbot API
    /// </summary>
    public partial interface IAmazonChatbot : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IChatbotPaginatorFactory Paginators { get; }
#endif


        
        #region  CreateChimeWebhookConfiguration


        /// <summary>
        /// Creates Chime Webhook Configuration
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateChimeWebhookConfiguration service method.</param>
        /// 
        /// <returns>The response from the CreateChimeWebhookConfiguration service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.ConflictException">
        /// There was an issue processing your request.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.CreateChimeWebhookConfigurationException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.LimitExceededException">
        /// You have exceeded a service limit for AWS Chatbot.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/CreateChimeWebhookConfiguration">REST API Reference for CreateChimeWebhookConfiguration Operation</seealso>
        CreateChimeWebhookConfigurationResponse CreateChimeWebhookConfiguration(CreateChimeWebhookConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateChimeWebhookConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateChimeWebhookConfiguration operation on AmazonChatbotClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateChimeWebhookConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/CreateChimeWebhookConfiguration">REST API Reference for CreateChimeWebhookConfiguration Operation</seealso>
        IAsyncResult BeginCreateChimeWebhookConfiguration(CreateChimeWebhookConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateChimeWebhookConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateChimeWebhookConfiguration.</param>
        /// 
        /// <returns>Returns a  CreateChimeWebhookConfigurationResult from Chatbot.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/CreateChimeWebhookConfiguration">REST API Reference for CreateChimeWebhookConfiguration Operation</seealso>
        CreateChimeWebhookConfigurationResponse EndCreateChimeWebhookConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateMicrosoftTeamsChannelConfiguration


        /// <summary>
        /// Creates MS Teams Channel Configuration
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMicrosoftTeamsChannelConfiguration service method.</param>
        /// 
        /// <returns>The response from the CreateMicrosoftTeamsChannelConfiguration service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.ConflictException">
        /// There was an issue processing your request.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.CreateTeamsChannelConfigurationException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.LimitExceededException">
        /// You have exceeded a service limit for AWS Chatbot.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/CreateMicrosoftTeamsChannelConfiguration">REST API Reference for CreateMicrosoftTeamsChannelConfiguration Operation</seealso>
        CreateMicrosoftTeamsChannelConfigurationResponse CreateMicrosoftTeamsChannelConfiguration(CreateMicrosoftTeamsChannelConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateMicrosoftTeamsChannelConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateMicrosoftTeamsChannelConfiguration operation on AmazonChatbotClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateMicrosoftTeamsChannelConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/CreateMicrosoftTeamsChannelConfiguration">REST API Reference for CreateMicrosoftTeamsChannelConfiguration Operation</seealso>
        IAsyncResult BeginCreateMicrosoftTeamsChannelConfiguration(CreateMicrosoftTeamsChannelConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateMicrosoftTeamsChannelConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateMicrosoftTeamsChannelConfiguration.</param>
        /// 
        /// <returns>Returns a  CreateMicrosoftTeamsChannelConfigurationResult from Chatbot.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/CreateMicrosoftTeamsChannelConfiguration">REST API Reference for CreateMicrosoftTeamsChannelConfiguration Operation</seealso>
        CreateMicrosoftTeamsChannelConfigurationResponse EndCreateMicrosoftTeamsChannelConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateSlackChannelConfiguration


        /// <summary>
        /// Creates Slack Channel Configuration
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSlackChannelConfiguration service method.</param>
        /// 
        /// <returns>The response from the CreateSlackChannelConfiguration service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.ConflictException">
        /// There was an issue processing your request.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.CreateSlackChannelConfigurationException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.LimitExceededException">
        /// You have exceeded a service limit for AWS Chatbot.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/CreateSlackChannelConfiguration">REST API Reference for CreateSlackChannelConfiguration Operation</seealso>
        CreateSlackChannelConfigurationResponse CreateSlackChannelConfiguration(CreateSlackChannelConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSlackChannelConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSlackChannelConfiguration operation on AmazonChatbotClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSlackChannelConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/CreateSlackChannelConfiguration">REST API Reference for CreateSlackChannelConfiguration Operation</seealso>
        IAsyncResult BeginCreateSlackChannelConfiguration(CreateSlackChannelConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSlackChannelConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSlackChannelConfiguration.</param>
        /// 
        /// <returns>Returns a  CreateSlackChannelConfigurationResult from Chatbot.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/CreateSlackChannelConfiguration">REST API Reference for CreateSlackChannelConfiguration Operation</seealso>
        CreateSlackChannelConfigurationResponse EndCreateSlackChannelConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteChimeWebhookConfiguration


        /// <summary>
        /// Deletes a Chime Webhook Configuration
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteChimeWebhookConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteChimeWebhookConfiguration service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.DeleteChimeWebhookConfigurationException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.ResourceNotFoundException">
        /// We were not able to find the resource for your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/DeleteChimeWebhookConfiguration">REST API Reference for DeleteChimeWebhookConfiguration Operation</seealso>
        DeleteChimeWebhookConfigurationResponse DeleteChimeWebhookConfiguration(DeleteChimeWebhookConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteChimeWebhookConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteChimeWebhookConfiguration operation on AmazonChatbotClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteChimeWebhookConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/DeleteChimeWebhookConfiguration">REST API Reference for DeleteChimeWebhookConfiguration Operation</seealso>
        IAsyncResult BeginDeleteChimeWebhookConfiguration(DeleteChimeWebhookConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteChimeWebhookConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteChimeWebhookConfiguration.</param>
        /// 
        /// <returns>Returns a  DeleteChimeWebhookConfigurationResult from Chatbot.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/DeleteChimeWebhookConfiguration">REST API Reference for DeleteChimeWebhookConfiguration Operation</seealso>
        DeleteChimeWebhookConfigurationResponse EndDeleteChimeWebhookConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteMicrosoftTeamsChannelConfiguration


        /// <summary>
        /// Deletes MS Teams Channel Configuration
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMicrosoftTeamsChannelConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteMicrosoftTeamsChannelConfiguration service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.DeleteTeamsChannelConfigurationException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.ResourceNotFoundException">
        /// We were not able to find the resource for your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/DeleteMicrosoftTeamsChannelConfiguration">REST API Reference for DeleteMicrosoftTeamsChannelConfiguration Operation</seealso>
        DeleteMicrosoftTeamsChannelConfigurationResponse DeleteMicrosoftTeamsChannelConfiguration(DeleteMicrosoftTeamsChannelConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteMicrosoftTeamsChannelConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMicrosoftTeamsChannelConfiguration operation on AmazonChatbotClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteMicrosoftTeamsChannelConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/DeleteMicrosoftTeamsChannelConfiguration">REST API Reference for DeleteMicrosoftTeamsChannelConfiguration Operation</seealso>
        IAsyncResult BeginDeleteMicrosoftTeamsChannelConfiguration(DeleteMicrosoftTeamsChannelConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteMicrosoftTeamsChannelConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteMicrosoftTeamsChannelConfiguration.</param>
        /// 
        /// <returns>Returns a  DeleteMicrosoftTeamsChannelConfigurationResult from Chatbot.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/DeleteMicrosoftTeamsChannelConfiguration">REST API Reference for DeleteMicrosoftTeamsChannelConfiguration Operation</seealso>
        DeleteMicrosoftTeamsChannelConfigurationResponse EndDeleteMicrosoftTeamsChannelConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteMicrosoftTeamsConfiguredTeam


        /// <summary>
        /// Deletes the Microsoft Teams team authorization allowing for channels to be configured
        /// in that Microsoft Teams team. Note that the Microsoft Teams team must have no channels
        /// configured to remove it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMicrosoftTeamsConfiguredTeam service method.</param>
        /// 
        /// <returns>The response from the DeleteMicrosoftTeamsConfiguredTeam service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.DeleteTeamsConfiguredTeamException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/DeleteMicrosoftTeamsConfiguredTeam">REST API Reference for DeleteMicrosoftTeamsConfiguredTeam Operation</seealso>
        DeleteMicrosoftTeamsConfiguredTeamResponse DeleteMicrosoftTeamsConfiguredTeam(DeleteMicrosoftTeamsConfiguredTeamRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteMicrosoftTeamsConfiguredTeam operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMicrosoftTeamsConfiguredTeam operation on AmazonChatbotClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteMicrosoftTeamsConfiguredTeam
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/DeleteMicrosoftTeamsConfiguredTeam">REST API Reference for DeleteMicrosoftTeamsConfiguredTeam Operation</seealso>
        IAsyncResult BeginDeleteMicrosoftTeamsConfiguredTeam(DeleteMicrosoftTeamsConfiguredTeamRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteMicrosoftTeamsConfiguredTeam operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteMicrosoftTeamsConfiguredTeam.</param>
        /// 
        /// <returns>Returns a  DeleteMicrosoftTeamsConfiguredTeamResult from Chatbot.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/DeleteMicrosoftTeamsConfiguredTeam">REST API Reference for DeleteMicrosoftTeamsConfiguredTeam Operation</seealso>
        DeleteMicrosoftTeamsConfiguredTeamResponse EndDeleteMicrosoftTeamsConfiguredTeam(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteMicrosoftTeamsUserIdentity


        /// <summary>
        /// Deletes a Teams user identity
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMicrosoftTeamsUserIdentity service method.</param>
        /// 
        /// <returns>The response from the DeleteMicrosoftTeamsUserIdentity service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.DeleteMicrosoftTeamsUserIdentityException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.ResourceNotFoundException">
        /// We were not able to find the resource for your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/DeleteMicrosoftTeamsUserIdentity">REST API Reference for DeleteMicrosoftTeamsUserIdentity Operation</seealso>
        DeleteMicrosoftTeamsUserIdentityResponse DeleteMicrosoftTeamsUserIdentity(DeleteMicrosoftTeamsUserIdentityRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteMicrosoftTeamsUserIdentity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMicrosoftTeamsUserIdentity operation on AmazonChatbotClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteMicrosoftTeamsUserIdentity
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/DeleteMicrosoftTeamsUserIdentity">REST API Reference for DeleteMicrosoftTeamsUserIdentity Operation</seealso>
        IAsyncResult BeginDeleteMicrosoftTeamsUserIdentity(DeleteMicrosoftTeamsUserIdentityRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteMicrosoftTeamsUserIdentity operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteMicrosoftTeamsUserIdentity.</param>
        /// 
        /// <returns>Returns a  DeleteMicrosoftTeamsUserIdentityResult from Chatbot.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/DeleteMicrosoftTeamsUserIdentity">REST API Reference for DeleteMicrosoftTeamsUserIdentity Operation</seealso>
        DeleteMicrosoftTeamsUserIdentityResponse EndDeleteMicrosoftTeamsUserIdentity(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteSlackChannelConfiguration


        /// <summary>
        /// Deletes Slack Channel Configuration
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSlackChannelConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteSlackChannelConfiguration service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.DeleteSlackChannelConfigurationException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.ResourceNotFoundException">
        /// We were not able to find the resource for your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/DeleteSlackChannelConfiguration">REST API Reference for DeleteSlackChannelConfiguration Operation</seealso>
        DeleteSlackChannelConfigurationResponse DeleteSlackChannelConfiguration(DeleteSlackChannelConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSlackChannelConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSlackChannelConfiguration operation on AmazonChatbotClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSlackChannelConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/DeleteSlackChannelConfiguration">REST API Reference for DeleteSlackChannelConfiguration Operation</seealso>
        IAsyncResult BeginDeleteSlackChannelConfiguration(DeleteSlackChannelConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSlackChannelConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSlackChannelConfiguration.</param>
        /// 
        /// <returns>Returns a  DeleteSlackChannelConfigurationResult from Chatbot.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/DeleteSlackChannelConfiguration">REST API Reference for DeleteSlackChannelConfiguration Operation</seealso>
        DeleteSlackChannelConfigurationResponse EndDeleteSlackChannelConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteSlackUserIdentity


        /// <summary>
        /// Deletes a Slack user identity
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSlackUserIdentity service method.</param>
        /// 
        /// <returns>The response from the DeleteSlackUserIdentity service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.DeleteSlackUserIdentityException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.ResourceNotFoundException">
        /// We were not able to find the resource for your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/DeleteSlackUserIdentity">REST API Reference for DeleteSlackUserIdentity Operation</seealso>
        DeleteSlackUserIdentityResponse DeleteSlackUserIdentity(DeleteSlackUserIdentityRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSlackUserIdentity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSlackUserIdentity operation on AmazonChatbotClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSlackUserIdentity
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/DeleteSlackUserIdentity">REST API Reference for DeleteSlackUserIdentity Operation</seealso>
        IAsyncResult BeginDeleteSlackUserIdentity(DeleteSlackUserIdentityRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSlackUserIdentity operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSlackUserIdentity.</param>
        /// 
        /// <returns>Returns a  DeleteSlackUserIdentityResult from Chatbot.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/DeleteSlackUserIdentity">REST API Reference for DeleteSlackUserIdentity Operation</seealso>
        DeleteSlackUserIdentityResponse EndDeleteSlackUserIdentity(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteSlackWorkspaceAuthorization


        /// <summary>
        /// Deletes the Slack workspace authorization that allows channels to be configured in
        /// that workspace. This requires all configured channels in the workspace to be deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSlackWorkspaceAuthorization service method.</param>
        /// 
        /// <returns>The response from the DeleteSlackWorkspaceAuthorization service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.DeleteSlackWorkspaceAuthorizationException">
        /// There was an issue deleting your Slack workspace.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/DeleteSlackWorkspaceAuthorization">REST API Reference for DeleteSlackWorkspaceAuthorization Operation</seealso>
        DeleteSlackWorkspaceAuthorizationResponse DeleteSlackWorkspaceAuthorization(DeleteSlackWorkspaceAuthorizationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSlackWorkspaceAuthorization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSlackWorkspaceAuthorization operation on AmazonChatbotClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSlackWorkspaceAuthorization
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/DeleteSlackWorkspaceAuthorization">REST API Reference for DeleteSlackWorkspaceAuthorization Operation</seealso>
        IAsyncResult BeginDeleteSlackWorkspaceAuthorization(DeleteSlackWorkspaceAuthorizationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSlackWorkspaceAuthorization operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSlackWorkspaceAuthorization.</param>
        /// 
        /// <returns>Returns a  DeleteSlackWorkspaceAuthorizationResult from Chatbot.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/DeleteSlackWorkspaceAuthorization">REST API Reference for DeleteSlackWorkspaceAuthorization Operation</seealso>
        DeleteSlackWorkspaceAuthorizationResponse EndDeleteSlackWorkspaceAuthorization(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeChimeWebhookConfigurations


        /// <summary>
        /// Lists Chime Webhook Configurations optionally filtered by ChatConfigurationArn
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeChimeWebhookConfigurations service method.</param>
        /// 
        /// <returns>The response from the DescribeChimeWebhookConfigurations service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.DescribeChimeWebhookConfigurationsException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/DescribeChimeWebhookConfigurations">REST API Reference for DescribeChimeWebhookConfigurations Operation</seealso>
        DescribeChimeWebhookConfigurationsResponse DescribeChimeWebhookConfigurations(DescribeChimeWebhookConfigurationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeChimeWebhookConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeChimeWebhookConfigurations operation on AmazonChatbotClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeChimeWebhookConfigurations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/DescribeChimeWebhookConfigurations">REST API Reference for DescribeChimeWebhookConfigurations Operation</seealso>
        IAsyncResult BeginDescribeChimeWebhookConfigurations(DescribeChimeWebhookConfigurationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeChimeWebhookConfigurations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeChimeWebhookConfigurations.</param>
        /// 
        /// <returns>Returns a  DescribeChimeWebhookConfigurationsResult from Chatbot.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/DescribeChimeWebhookConfigurations">REST API Reference for DescribeChimeWebhookConfigurations Operation</seealso>
        DescribeChimeWebhookConfigurationsResponse EndDescribeChimeWebhookConfigurations(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeSlackChannelConfigurations


        /// <summary>
        /// Lists Slack Channel Configurations optionally filtered by ChatConfigurationArn
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSlackChannelConfigurations service method.</param>
        /// 
        /// <returns>The response from the DescribeSlackChannelConfigurations service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.DescribeSlackChannelConfigurationsException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/DescribeSlackChannelConfigurations">REST API Reference for DescribeSlackChannelConfigurations Operation</seealso>
        DescribeSlackChannelConfigurationsResponse DescribeSlackChannelConfigurations(DescribeSlackChannelConfigurationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSlackChannelConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSlackChannelConfigurations operation on AmazonChatbotClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeSlackChannelConfigurations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/DescribeSlackChannelConfigurations">REST API Reference for DescribeSlackChannelConfigurations Operation</seealso>
        IAsyncResult BeginDescribeSlackChannelConfigurations(DescribeSlackChannelConfigurationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSlackChannelConfigurations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSlackChannelConfigurations.</param>
        /// 
        /// <returns>Returns a  DescribeSlackChannelConfigurationsResult from Chatbot.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/DescribeSlackChannelConfigurations">REST API Reference for DescribeSlackChannelConfigurations Operation</seealso>
        DescribeSlackChannelConfigurationsResponse EndDescribeSlackChannelConfigurations(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeSlackUserIdentities


        /// <summary>
        /// Lists all Slack user identities with a mapped role.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSlackUserIdentities service method.</param>
        /// 
        /// <returns>The response from the DescribeSlackUserIdentities service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.DescribeSlackUserIdentitiesException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/DescribeSlackUserIdentities">REST API Reference for DescribeSlackUserIdentities Operation</seealso>
        DescribeSlackUserIdentitiesResponse DescribeSlackUserIdentities(DescribeSlackUserIdentitiesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSlackUserIdentities operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSlackUserIdentities operation on AmazonChatbotClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeSlackUserIdentities
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/DescribeSlackUserIdentities">REST API Reference for DescribeSlackUserIdentities Operation</seealso>
        IAsyncResult BeginDescribeSlackUserIdentities(DescribeSlackUserIdentitiesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSlackUserIdentities operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSlackUserIdentities.</param>
        /// 
        /// <returns>Returns a  DescribeSlackUserIdentitiesResult from Chatbot.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/DescribeSlackUserIdentities">REST API Reference for DescribeSlackUserIdentities Operation</seealso>
        DescribeSlackUserIdentitiesResponse EndDescribeSlackUserIdentities(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeSlackWorkspaces


        /// <summary>
        /// Lists all authorized Slack Workspaces for AWS Account
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSlackWorkspaces service method.</param>
        /// 
        /// <returns>The response from the DescribeSlackWorkspaces service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.DescribeSlackWorkspacesException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/DescribeSlackWorkspaces">REST API Reference for DescribeSlackWorkspaces Operation</seealso>
        DescribeSlackWorkspacesResponse DescribeSlackWorkspaces(DescribeSlackWorkspacesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSlackWorkspaces operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSlackWorkspaces operation on AmazonChatbotClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeSlackWorkspaces
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/DescribeSlackWorkspaces">REST API Reference for DescribeSlackWorkspaces Operation</seealso>
        IAsyncResult BeginDescribeSlackWorkspaces(DescribeSlackWorkspacesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSlackWorkspaces operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSlackWorkspaces.</param>
        /// 
        /// <returns>Returns a  DescribeSlackWorkspacesResult from Chatbot.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/DescribeSlackWorkspaces">REST API Reference for DescribeSlackWorkspaces Operation</seealso>
        DescribeSlackWorkspacesResponse EndDescribeSlackWorkspaces(IAsyncResult asyncResult);

        #endregion
        
        #region  GetAccountPreferences


        /// <summary>
        /// Get Chatbot account level preferences
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccountPreferences service method.</param>
        /// 
        /// <returns>The response from the GetAccountPreferences service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.GetAccountPreferencesException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/GetAccountPreferences">REST API Reference for GetAccountPreferences Operation</seealso>
        GetAccountPreferencesResponse GetAccountPreferences(GetAccountPreferencesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetAccountPreferences operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAccountPreferences operation on AmazonChatbotClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAccountPreferences
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/GetAccountPreferences">REST API Reference for GetAccountPreferences Operation</seealso>
        IAsyncResult BeginGetAccountPreferences(GetAccountPreferencesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAccountPreferences operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAccountPreferences.</param>
        /// 
        /// <returns>Returns a  GetAccountPreferencesResult from Chatbot.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/GetAccountPreferences">REST API Reference for GetAccountPreferences Operation</seealso>
        GetAccountPreferencesResponse EndGetAccountPreferences(IAsyncResult asyncResult);

        #endregion
        
        #region  GetMicrosoftTeamsChannelConfiguration


        /// <summary>
        /// Get a single MS Teams Channel Configurations
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMicrosoftTeamsChannelConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetMicrosoftTeamsChannelConfiguration service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.GetTeamsChannelConfigurationException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/GetMicrosoftTeamsChannelConfiguration">REST API Reference for GetMicrosoftTeamsChannelConfiguration Operation</seealso>
        GetMicrosoftTeamsChannelConfigurationResponse GetMicrosoftTeamsChannelConfiguration(GetMicrosoftTeamsChannelConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetMicrosoftTeamsChannelConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMicrosoftTeamsChannelConfiguration operation on AmazonChatbotClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMicrosoftTeamsChannelConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/GetMicrosoftTeamsChannelConfiguration">REST API Reference for GetMicrosoftTeamsChannelConfiguration Operation</seealso>
        IAsyncResult BeginGetMicrosoftTeamsChannelConfiguration(GetMicrosoftTeamsChannelConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetMicrosoftTeamsChannelConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMicrosoftTeamsChannelConfiguration.</param>
        /// 
        /// <returns>Returns a  GetMicrosoftTeamsChannelConfigurationResult from Chatbot.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/GetMicrosoftTeamsChannelConfiguration">REST API Reference for GetMicrosoftTeamsChannelConfiguration Operation</seealso>
        GetMicrosoftTeamsChannelConfigurationResponse EndGetMicrosoftTeamsChannelConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  ListMicrosoftTeamsChannelConfigurations


        /// <summary>
        /// Lists MS Teams Channel Configurations optionally filtered by TeamId
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMicrosoftTeamsChannelConfigurations service method.</param>
        /// 
        /// <returns>The response from the ListMicrosoftTeamsChannelConfigurations service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.ListTeamsChannelConfigurationsException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/ListMicrosoftTeamsChannelConfigurations">REST API Reference for ListMicrosoftTeamsChannelConfigurations Operation</seealso>
        ListMicrosoftTeamsChannelConfigurationsResponse ListMicrosoftTeamsChannelConfigurations(ListMicrosoftTeamsChannelConfigurationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListMicrosoftTeamsChannelConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMicrosoftTeamsChannelConfigurations operation on AmazonChatbotClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMicrosoftTeamsChannelConfigurations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/ListMicrosoftTeamsChannelConfigurations">REST API Reference for ListMicrosoftTeamsChannelConfigurations Operation</seealso>
        IAsyncResult BeginListMicrosoftTeamsChannelConfigurations(ListMicrosoftTeamsChannelConfigurationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListMicrosoftTeamsChannelConfigurations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMicrosoftTeamsChannelConfigurations.</param>
        /// 
        /// <returns>Returns a  ListMicrosoftTeamsChannelConfigurationsResult from Chatbot.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/ListMicrosoftTeamsChannelConfigurations">REST API Reference for ListMicrosoftTeamsChannelConfigurations Operation</seealso>
        ListMicrosoftTeamsChannelConfigurationsResponse EndListMicrosoftTeamsChannelConfigurations(IAsyncResult asyncResult);

        #endregion
        
        #region  ListMicrosoftTeamsConfiguredTeams


        /// <summary>
        /// Lists all authorized MS teams for AWS Account
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMicrosoftTeamsConfiguredTeams service method.</param>
        /// 
        /// <returns>The response from the ListMicrosoftTeamsConfiguredTeams service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.ListMicrosoftTeamsConfiguredTeamsException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/ListMicrosoftTeamsConfiguredTeams">REST API Reference for ListMicrosoftTeamsConfiguredTeams Operation</seealso>
        ListMicrosoftTeamsConfiguredTeamsResponse ListMicrosoftTeamsConfiguredTeams(ListMicrosoftTeamsConfiguredTeamsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListMicrosoftTeamsConfiguredTeams operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMicrosoftTeamsConfiguredTeams operation on AmazonChatbotClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMicrosoftTeamsConfiguredTeams
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/ListMicrosoftTeamsConfiguredTeams">REST API Reference for ListMicrosoftTeamsConfiguredTeams Operation</seealso>
        IAsyncResult BeginListMicrosoftTeamsConfiguredTeams(ListMicrosoftTeamsConfiguredTeamsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListMicrosoftTeamsConfiguredTeams operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMicrosoftTeamsConfiguredTeams.</param>
        /// 
        /// <returns>Returns a  ListMicrosoftTeamsConfiguredTeamsResult from Chatbot.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/ListMicrosoftTeamsConfiguredTeams">REST API Reference for ListMicrosoftTeamsConfiguredTeams Operation</seealso>
        ListMicrosoftTeamsConfiguredTeamsResponse EndListMicrosoftTeamsConfiguredTeams(IAsyncResult asyncResult);

        #endregion
        
        #region  ListMicrosoftTeamsUserIdentities


        /// <summary>
        /// Lists all Microsoft Teams user identities with a mapped role.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMicrosoftTeamsUserIdentities service method.</param>
        /// 
        /// <returns>The response from the ListMicrosoftTeamsUserIdentities service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.ListMicrosoftTeamsUserIdentitiesException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/ListMicrosoftTeamsUserIdentities">REST API Reference for ListMicrosoftTeamsUserIdentities Operation</seealso>
        ListMicrosoftTeamsUserIdentitiesResponse ListMicrosoftTeamsUserIdentities(ListMicrosoftTeamsUserIdentitiesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListMicrosoftTeamsUserIdentities operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMicrosoftTeamsUserIdentities operation on AmazonChatbotClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMicrosoftTeamsUserIdentities
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/ListMicrosoftTeamsUserIdentities">REST API Reference for ListMicrosoftTeamsUserIdentities Operation</seealso>
        IAsyncResult BeginListMicrosoftTeamsUserIdentities(ListMicrosoftTeamsUserIdentitiesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListMicrosoftTeamsUserIdentities operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMicrosoftTeamsUserIdentities.</param>
        /// 
        /// <returns>Returns a  ListMicrosoftTeamsUserIdentitiesResult from Chatbot.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/ListMicrosoftTeamsUserIdentities">REST API Reference for ListMicrosoftTeamsUserIdentities Operation</seealso>
        ListMicrosoftTeamsUserIdentitiesResponse EndListMicrosoftTeamsUserIdentities(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Retrieves the list of tags applied to a configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.InternalServiceErrorException">
        /// Customer/consumer-facing internal service exception. https://w.amazon.com/index.php/AWS/API_Standards/Exceptions#InternalServiceError
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.ResourceNotFoundException">
        /// We were not able to find the resource for your request.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.ServiceUnavailableException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonChatbotClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from Chatbot.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Applies the supplied tags to a configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.InternalServiceErrorException">
        /// Customer/consumer-facing internal service exception. https://w.amazon.com/index.php/AWS/API_Standards/Exceptions#InternalServiceError
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.ResourceNotFoundException">
        /// We were not able to find the resource for your request.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.ServiceUnavailableException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.TooManyTagsException">
        /// The supplied list of tags contains too many tags.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonChatbotClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from Chatbot.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes the supplied tags from a configuration
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.InternalServiceErrorException">
        /// Customer/consumer-facing internal service exception. https://w.amazon.com/index.php/AWS/API_Standards/Exceptions#InternalServiceError
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.ResourceNotFoundException">
        /// We were not able to find the resource for your request.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.ServiceUnavailableException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonChatbotClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from Chatbot.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateAccountPreferences


        /// <summary>
        /// Update Chatbot account level preferences
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccountPreferences service method.</param>
        /// 
        /// <returns>The response from the UpdateAccountPreferences service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.UpdateAccountPreferencesException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/UpdateAccountPreferences">REST API Reference for UpdateAccountPreferences Operation</seealso>
        UpdateAccountPreferencesResponse UpdateAccountPreferences(UpdateAccountPreferencesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAccountPreferences operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccountPreferences operation on AmazonChatbotClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAccountPreferences
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/UpdateAccountPreferences">REST API Reference for UpdateAccountPreferences Operation</seealso>
        IAsyncResult BeginUpdateAccountPreferences(UpdateAccountPreferencesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAccountPreferences operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAccountPreferences.</param>
        /// 
        /// <returns>Returns a  UpdateAccountPreferencesResult from Chatbot.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/UpdateAccountPreferences">REST API Reference for UpdateAccountPreferences Operation</seealso>
        UpdateAccountPreferencesResponse EndUpdateAccountPreferences(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateChimeWebhookConfiguration


        /// <summary>
        /// Updates a Chime Webhook Configuration
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateChimeWebhookConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateChimeWebhookConfiguration service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.ResourceNotFoundException">
        /// We were not able to find the resource for your request.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.UpdateChimeWebhookConfigurationException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/UpdateChimeWebhookConfiguration">REST API Reference for UpdateChimeWebhookConfiguration Operation</seealso>
        UpdateChimeWebhookConfigurationResponse UpdateChimeWebhookConfiguration(UpdateChimeWebhookConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateChimeWebhookConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateChimeWebhookConfiguration operation on AmazonChatbotClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateChimeWebhookConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/UpdateChimeWebhookConfiguration">REST API Reference for UpdateChimeWebhookConfiguration Operation</seealso>
        IAsyncResult BeginUpdateChimeWebhookConfiguration(UpdateChimeWebhookConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateChimeWebhookConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateChimeWebhookConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateChimeWebhookConfigurationResult from Chatbot.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/UpdateChimeWebhookConfiguration">REST API Reference for UpdateChimeWebhookConfiguration Operation</seealso>
        UpdateChimeWebhookConfigurationResponse EndUpdateChimeWebhookConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateMicrosoftTeamsChannelConfiguration


        /// <summary>
        /// Updates MS Teams Channel Configuration
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMicrosoftTeamsChannelConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateMicrosoftTeamsChannelConfiguration service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.ResourceNotFoundException">
        /// We were not able to find the resource for your request.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.UpdateTeamsChannelConfigurationException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/UpdateMicrosoftTeamsChannelConfiguration">REST API Reference for UpdateMicrosoftTeamsChannelConfiguration Operation</seealso>
        UpdateMicrosoftTeamsChannelConfigurationResponse UpdateMicrosoftTeamsChannelConfiguration(UpdateMicrosoftTeamsChannelConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateMicrosoftTeamsChannelConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateMicrosoftTeamsChannelConfiguration operation on AmazonChatbotClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateMicrosoftTeamsChannelConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/UpdateMicrosoftTeamsChannelConfiguration">REST API Reference for UpdateMicrosoftTeamsChannelConfiguration Operation</seealso>
        IAsyncResult BeginUpdateMicrosoftTeamsChannelConfiguration(UpdateMicrosoftTeamsChannelConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateMicrosoftTeamsChannelConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateMicrosoftTeamsChannelConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateMicrosoftTeamsChannelConfigurationResult from Chatbot.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/UpdateMicrosoftTeamsChannelConfiguration">REST API Reference for UpdateMicrosoftTeamsChannelConfiguration Operation</seealso>
        UpdateMicrosoftTeamsChannelConfigurationResponse EndUpdateMicrosoftTeamsChannelConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateSlackChannelConfiguration


        /// <summary>
        /// Updates Slack Channel Configuration
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSlackChannelConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateSlackChannelConfiguration service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints that AWS Chatbot requires.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.ResourceNotFoundException">
        /// We were not able to find the resource for your request.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.UpdateSlackChannelConfigurationException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/UpdateSlackChannelConfiguration">REST API Reference for UpdateSlackChannelConfiguration Operation</seealso>
        UpdateSlackChannelConfigurationResponse UpdateSlackChannelConfiguration(UpdateSlackChannelConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSlackChannelConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSlackChannelConfiguration operation on AmazonChatbotClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSlackChannelConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/UpdateSlackChannelConfiguration">REST API Reference for UpdateSlackChannelConfiguration Operation</seealso>
        IAsyncResult BeginUpdateSlackChannelConfiguration(UpdateSlackChannelConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSlackChannelConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSlackChannelConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateSlackChannelConfigurationResult from Chatbot.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/UpdateSlackChannelConfiguration">REST API Reference for UpdateSlackChannelConfiguration Operation</seealso>
        UpdateSlackChannelConfigurationResponse EndUpdateSlackChannelConfiguration(IAsyncResult asyncResult);

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