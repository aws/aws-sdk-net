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
    /// The <i>AWS Chatbot API Reference</i> provides descriptions, API request parameters,
    /// and the XML response for each of the AWS Chatbot API actions.
    /// 
    ///  
    /// <para>
    /// AWS Chatbot APIs are currently available in the following Regions:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// US East (Ohio) - <c>us-east-2</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// US West (Oregon) - <c>us-west-2</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Asia Pacific (Singapore) - <c>ap-southeast-1</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Europe (Ireland) - <c>eu-west-1</c> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// The AWS Chatbot console can only be used in US East (Ohio). Your configuration data
    /// however, is stored in each of the relevant available Regions.
    /// </para>
    ///  <note> 
    /// <para>
    /// Your AWS CloudTrail events are logged in whatever Region you call from, not US East
    /// (N. Virginia) by default.
    /// </para>
    ///  </note>
    /// </summary>
    public partial interface IAmazonChatbot : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IChatbotPaginatorFactory Paginators { get; }
#endif


        
        #region  AssociateToConfiguration


        /// <summary>
        /// Links a resource (for example, a custom action) to a channel configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateToConfiguration service method.</param>
        /// 
        /// <returns>The response from the AssociateToConfiguration service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.InternalServiceErrorException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.UnauthorizedException">
        /// The request was rejected because it doesn't have valid credentials for the target
        /// resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/AssociateToConfiguration">REST API Reference for AssociateToConfiguration Operation</seealso>
        AssociateToConfigurationResponse AssociateToConfiguration(AssociateToConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateToConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateToConfiguration operation on AmazonChatbotClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateToConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/AssociateToConfiguration">REST API Reference for AssociateToConfiguration Operation</seealso>
        IAsyncResult BeginAssociateToConfiguration(AssociateToConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateToConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateToConfiguration.</param>
        /// 
        /// <returns>Returns a  AssociateToConfigurationResult from Chatbot.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/AssociateToConfiguration">REST API Reference for AssociateToConfiguration Operation</seealso>
        AssociateToConfigurationResponse EndAssociateToConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateChimeWebhookConfiguration


        /// <summary>
        /// Creates an AWS Chatbot configuration for Amazon Chime.
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
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
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
        
        #region  CreateCustomAction


        /// <summary>
        /// Creates a custom action that can be invoked as an alias or as a button on a notification.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCustomAction service method.</param>
        /// 
        /// <returns>The response from the CreateCustomAction service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.ConflictException">
        /// There was an issue processing your request.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InternalServiceErrorException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.LimitExceededException">
        /// You have exceeded a service limit for AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.UnauthorizedException">
        /// The request was rejected because it doesn't have valid credentials for the target
        /// resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/CreateCustomAction">REST API Reference for CreateCustomAction Operation</seealso>
        CreateCustomActionResponse CreateCustomAction(CreateCustomActionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCustomAction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCustomAction operation on AmazonChatbotClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCustomAction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/CreateCustomAction">REST API Reference for CreateCustomAction Operation</seealso>
        IAsyncResult BeginCreateCustomAction(CreateCustomActionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCustomAction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCustomAction.</param>
        /// 
        /// <returns>Returns a  CreateCustomActionResult from Chatbot.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/CreateCustomAction">REST API Reference for CreateCustomAction Operation</seealso>
        CreateCustomActionResponse EndCreateCustomAction(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateMicrosoftTeamsChannelConfiguration


        /// <summary>
        /// Creates an AWS Chatbot configuration for Microsoft Teams.
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
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
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
        /// Creates an AWS Chatbot confugration for Slack.
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
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
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
        /// Deletes a Amazon Chime webhook configuration for AWS Chatbot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteChimeWebhookConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteChimeWebhookConfiguration service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.DeleteChimeWebhookConfigurationException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.ResourceNotFoundException">
        /// We were unable to find the resource for your request
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
        
        #region  DeleteCustomAction


        /// <summary>
        /// Deletes a custom action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCustomAction service method.</param>
        /// 
        /// <returns>The response from the DeleteCustomAction service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.InternalServiceErrorException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.ResourceNotFoundException">
        /// We were unable to find the resource for your request
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.UnauthorizedException">
        /// The request was rejected because it doesn't have valid credentials for the target
        /// resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/DeleteCustomAction">REST API Reference for DeleteCustomAction Operation</seealso>
        DeleteCustomActionResponse DeleteCustomAction(DeleteCustomActionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCustomAction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCustomAction operation on AmazonChatbotClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCustomAction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/DeleteCustomAction">REST API Reference for DeleteCustomAction Operation</seealso>
        IAsyncResult BeginDeleteCustomAction(DeleteCustomActionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCustomAction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCustomAction.</param>
        /// 
        /// <returns>Returns a  DeleteCustomActionResult from Chatbot.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/DeleteCustomAction">REST API Reference for DeleteCustomAction Operation</seealso>
        DeleteCustomActionResponse EndDeleteCustomAction(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteMicrosoftTeamsChannelConfiguration


        /// <summary>
        /// Deletes a Microsoft Teams channel configuration for AWS Chatbot
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMicrosoftTeamsChannelConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteMicrosoftTeamsChannelConfiguration service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.DeleteTeamsChannelConfigurationException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.ResourceNotFoundException">
        /// We were unable to find the resource for your request
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
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
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
        /// Identifes a user level permission for a channel configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMicrosoftTeamsUserIdentity service method.</param>
        /// 
        /// <returns>The response from the DeleteMicrosoftTeamsUserIdentity service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.DeleteMicrosoftTeamsUserIdentityException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.ResourceNotFoundException">
        /// We were unable to find the resource for your request
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
        /// Deletes a Slack channel configuration for AWS Chatbot
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSlackChannelConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteSlackChannelConfiguration service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.DeleteSlackChannelConfigurationException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.ResourceNotFoundException">
        /// We were unable to find the resource for your request
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
        /// Deletes a user level permission for a Slack channel configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSlackUserIdentity service method.</param>
        /// 
        /// <returns>The response from the DeleteSlackUserIdentity service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.DeleteSlackUserIdentityException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.ResourceNotFoundException">
        /// We were unable to find the resource for your request
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
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
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
        /// Lists Amazon Chime webhook configurations optionally filtered by ChatConfigurationArn
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeChimeWebhookConfigurations service method.</param>
        /// 
        /// <returns>The response from the DescribeChimeWebhookConfigurations service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.DescribeChimeWebhookConfigurationsException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
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
        /// Lists Slack channel configurations optionally filtered by ChatConfigurationArn
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSlackChannelConfigurations service method.</param>
        /// 
        /// <returns>The response from the DescribeSlackChannelConfigurations service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.DescribeSlackChannelConfigurationsException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
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
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
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
        /// List all authorized Slack workspaces connected to the AWS Account onboarded with AWS
        /// Chatbot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSlackWorkspaces service method.</param>
        /// 
        /// <returns>The response from the DescribeSlackWorkspaces service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.DescribeSlackWorkspacesException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
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
        
        #region  DisassociateFromConfiguration


        /// <summary>
        /// Unlink a resource, for example a custom action, from a channel configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateFromConfiguration service method.</param>
        /// 
        /// <returns>The response from the DisassociateFromConfiguration service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.InternalServiceErrorException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.UnauthorizedException">
        /// The request was rejected because it doesn't have valid credentials for the target
        /// resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/DisassociateFromConfiguration">REST API Reference for DisassociateFromConfiguration Operation</seealso>
        DisassociateFromConfigurationResponse DisassociateFromConfiguration(DisassociateFromConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateFromConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateFromConfiguration operation on AmazonChatbotClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateFromConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/DisassociateFromConfiguration">REST API Reference for DisassociateFromConfiguration Operation</seealso>
        IAsyncResult BeginDisassociateFromConfiguration(DisassociateFromConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateFromConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateFromConfiguration.</param>
        /// 
        /// <returns>Returns a  DisassociateFromConfigurationResult from Chatbot.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/DisassociateFromConfiguration">REST API Reference for DisassociateFromConfiguration Operation</seealso>
        DisassociateFromConfigurationResponse EndDisassociateFromConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  GetAccountPreferences


        /// <summary>
        /// Returns AWS Chatbot account preferences.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccountPreferences service method.</param>
        /// 
        /// <returns>The response from the GetAccountPreferences service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.GetAccountPreferencesException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
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
        
        #region  GetCustomAction


        /// <summary>
        /// Returns a custom action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCustomAction service method.</param>
        /// 
        /// <returns>The response from the GetCustomAction service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.InternalServiceErrorException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.ResourceNotFoundException">
        /// We were unable to find the resource for your request
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.UnauthorizedException">
        /// The request was rejected because it doesn't have valid credentials for the target
        /// resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/GetCustomAction">REST API Reference for GetCustomAction Operation</seealso>
        GetCustomActionResponse GetCustomAction(GetCustomActionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetCustomAction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCustomAction operation on AmazonChatbotClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCustomAction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/GetCustomAction">REST API Reference for GetCustomAction Operation</seealso>
        IAsyncResult BeginGetCustomAction(GetCustomActionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetCustomAction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCustomAction.</param>
        /// 
        /// <returns>Returns a  GetCustomActionResult from Chatbot.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/GetCustomAction">REST API Reference for GetCustomAction Operation</seealso>
        GetCustomActionResponse EndGetCustomAction(IAsyncResult asyncResult);

        #endregion
        
        #region  GetMicrosoftTeamsChannelConfiguration


        /// <summary>
        /// Returns a Microsoft Teams channel configuration in an AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMicrosoftTeamsChannelConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetMicrosoftTeamsChannelConfiguration service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.GetTeamsChannelConfigurationException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
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
        
        #region  ListAssociations


        /// <summary>
        /// Lists resources associated with a channel configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssociations service method.</param>
        /// 
        /// <returns>The response from the ListAssociations service method, as returned by Chatbot.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/ListAssociations">REST API Reference for ListAssociations Operation</seealso>
        ListAssociationsResponse ListAssociations(ListAssociationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAssociations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAssociations operation on AmazonChatbotClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAssociations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/ListAssociations">REST API Reference for ListAssociations Operation</seealso>
        IAsyncResult BeginListAssociations(ListAssociationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAssociations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAssociations.</param>
        /// 
        /// <returns>Returns a  ListAssociationsResult from Chatbot.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/ListAssociations">REST API Reference for ListAssociations Operation</seealso>
        ListAssociationsResponse EndListAssociations(IAsyncResult asyncResult);

        #endregion
        
        #region  ListCustomActions


        /// <summary>
        /// Lists custom actions defined in this account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCustomActions service method.</param>
        /// 
        /// <returns>The response from the ListCustomActions service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.InternalServiceErrorException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.UnauthorizedException">
        /// The request was rejected because it doesn't have valid credentials for the target
        /// resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/ListCustomActions">REST API Reference for ListCustomActions Operation</seealso>
        ListCustomActionsResponse ListCustomActions(ListCustomActionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListCustomActions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCustomActions operation on AmazonChatbotClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCustomActions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/ListCustomActions">REST API Reference for ListCustomActions Operation</seealso>
        IAsyncResult BeginListCustomActions(ListCustomActionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListCustomActions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCustomActions.</param>
        /// 
        /// <returns>Returns a  ListCustomActionsResult from Chatbot.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/ListCustomActions">REST API Reference for ListCustomActions Operation</seealso>
        ListCustomActionsResponse EndListCustomActions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListMicrosoftTeamsChannelConfigurations


        /// <summary>
        /// Lists all AWS Chatbot Microsoft Teams channel configurations in an AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMicrosoftTeamsChannelConfigurations service method.</param>
        /// 
        /// <returns>The response from the ListMicrosoftTeamsChannelConfigurations service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
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
        /// Lists all authorized Microsoft Teams for an AWS Account
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMicrosoftTeamsConfiguredTeams service method.</param>
        /// 
        /// <returns>The response from the ListMicrosoftTeamsConfiguredTeams service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
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
        /// A list all Microsoft Teams user identities with a mapped role.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMicrosoftTeamsUserIdentities service method.</param>
        /// 
        /// <returns>The response from the ListMicrosoftTeamsUserIdentities service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
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
        /// Lists all of the tags associated with the Amazon Resource Name (ARN) that you specify.
        /// The resource can be a user, server, or role.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.InternalServiceErrorException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.ResourceNotFoundException">
        /// We were unable to find the resource for your request
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
        /// Attaches a key-value pair to a resource, as identified by its Amazon Resource Name
        /// (ARN). Resources are users, servers, roles, and other entities.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.InternalServiceErrorException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.ResourceNotFoundException">
        /// We were unable to find the resource for your request
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
        /// Detaches a key-value pair from a resource, as identified by its Amazon Resource Name
        /// (ARN). Resources are users, servers, roles, and other entities.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.InternalServiceErrorException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.ResourceNotFoundException">
        /// We were unable to find the resource for your request
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
        /// Updates AWS Chatbot account preferences.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccountPreferences service method.</param>
        /// 
        /// <returns>The response from the UpdateAccountPreferences service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
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
        /// Updates a Amazon Chime webhook configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateChimeWebhookConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateChimeWebhookConfiguration service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.ResourceNotFoundException">
        /// We were unable to find the resource for your request
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
        
        #region  UpdateCustomAction


        /// <summary>
        /// Updates a custom action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCustomAction service method.</param>
        /// 
        /// <returns>The response from the UpdateCustomAction service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.InternalServiceErrorException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.ResourceNotFoundException">
        /// We were unable to find the resource for your request
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.UnauthorizedException">
        /// The request was rejected because it doesn't have valid credentials for the target
        /// resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/UpdateCustomAction">REST API Reference for UpdateCustomAction Operation</seealso>
        UpdateCustomActionResponse UpdateCustomAction(UpdateCustomActionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateCustomAction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCustomAction operation on AmazonChatbotClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateCustomAction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/UpdateCustomAction">REST API Reference for UpdateCustomAction Operation</seealso>
        IAsyncResult BeginUpdateCustomAction(UpdateCustomActionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateCustomAction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateCustomAction.</param>
        /// 
        /// <returns>Returns a  UpdateCustomActionResult from Chatbot.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/UpdateCustomAction">REST API Reference for UpdateCustomAction Operation</seealso>
        UpdateCustomActionResponse EndUpdateCustomAction(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateMicrosoftTeamsChannelConfiguration


        /// <summary>
        /// Updates an Microsoft Teams channel configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMicrosoftTeamsChannelConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateMicrosoftTeamsChannelConfiguration service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.ResourceNotFoundException">
        /// We were unable to find the resource for your request
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
        /// Updates a Slack channel configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSlackChannelConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateSlackChannelConfiguration service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.ResourceNotFoundException">
        /// We were unable to find the resource for your request
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