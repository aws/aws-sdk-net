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
 * Do not modify this file. This file is generated from the chime-sdk-identity-2021-04-20.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.ChimeSDKIdentity.Model;

namespace Amazon.ChimeSDKIdentity
{
    /// <summary>
    /// Interface for accessing ChimeSDKIdentity
    ///
    /// The Amazon Chime SDK Identity APIs in this section allow software developers to create
    /// and manage unique instances of their messaging applications. These APIs provide the
    /// overarching framework for creating and sending messages. For more information about
    /// the identity APIs, refer to <a href="https://docs.aws.amazon.com/chime/latest/APIReference/API_Operations_Amazon_Chime_SDK_Identity.html">Amazon
    /// Chime SDK identity</a>.
    /// </summary>
    public partial interface IAmazonChimeSDKIdentity : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IChimeSDKIdentityPaginatorFactory Paginators { get; }
#endif


        
        #region  CreateAppInstance


        /// <summary>
        /// Creates an Amazon Chime SDK messaging <code>AppInstance</code> under an AWS account.
        /// Only SDK messaging customers use this API. <code>CreateAppInstance</code> supports
        /// idempotency behavior as described in the AWS API Standard.
        /// 
        ///  
        /// <para>
        /// identity
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAppInstance service method.</param>
        /// 
        /// <returns>The response from the CreateAppInstance service method, as returned by ChimeSDKIdentity.</returns>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/CreateAppInstance">REST API Reference for CreateAppInstance Operation</seealso>
        CreateAppInstanceResponse CreateAppInstance(CreateAppInstanceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAppInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAppInstance operation on AmazonChimeSDKIdentityClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAppInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/CreateAppInstance">REST API Reference for CreateAppInstance Operation</seealso>
        IAsyncResult BeginCreateAppInstance(CreateAppInstanceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAppInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAppInstance.</param>
        /// 
        /// <returns>Returns a  CreateAppInstanceResult from ChimeSDKIdentity.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/CreateAppInstance">REST API Reference for CreateAppInstance Operation</seealso>
        CreateAppInstanceResponse EndCreateAppInstance(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateAppInstanceAdmin


        /// <summary>
        /// Promotes an <code>AppInstanceUser</code> or <code>AppInstanceBot</code> to an <code>AppInstanceAdmin</code>.
        /// The promoted entity can perform the following actions. 
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <code>ChannelModerator</code> actions across all channels in the <code>AppInstance</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DeleteChannelMessage</code> actions.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Only an <code>AppInstanceUser</code> and <code>AppInstanceBot</code> can be promoted
        /// to an <code>AppInstanceAdmin</code> role.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAppInstanceAdmin service method.</param>
        /// 
        /// <returns>The response from the CreateAppInstanceAdmin service method, as returned by ChimeSDKIdentity.</returns>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/CreateAppInstanceAdmin">REST API Reference for CreateAppInstanceAdmin Operation</seealso>
        CreateAppInstanceAdminResponse CreateAppInstanceAdmin(CreateAppInstanceAdminRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAppInstanceAdmin operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAppInstanceAdmin operation on AmazonChimeSDKIdentityClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAppInstanceAdmin
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/CreateAppInstanceAdmin">REST API Reference for CreateAppInstanceAdmin Operation</seealso>
        IAsyncResult BeginCreateAppInstanceAdmin(CreateAppInstanceAdminRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAppInstanceAdmin operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAppInstanceAdmin.</param>
        /// 
        /// <returns>Returns a  CreateAppInstanceAdminResult from ChimeSDKIdentity.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/CreateAppInstanceAdmin">REST API Reference for CreateAppInstanceAdmin Operation</seealso>
        CreateAppInstanceAdminResponse EndCreateAppInstanceAdmin(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateAppInstanceBot


        /// <summary>
        /// Creates a bot under an Amazon Chime <code>AppInstance</code>. The request consists
        /// of a unique <code>Configuration</code> and <code>Name</code> for that bot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAppInstanceBot service method.</param>
        /// 
        /// <returns>The response from the CreateAppInstanceBot service method, as returned by ChimeSDKIdentity.</returns>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/CreateAppInstanceBot">REST API Reference for CreateAppInstanceBot Operation</seealso>
        CreateAppInstanceBotResponse CreateAppInstanceBot(CreateAppInstanceBotRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAppInstanceBot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAppInstanceBot operation on AmazonChimeSDKIdentityClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAppInstanceBot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/CreateAppInstanceBot">REST API Reference for CreateAppInstanceBot Operation</seealso>
        IAsyncResult BeginCreateAppInstanceBot(CreateAppInstanceBotRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAppInstanceBot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAppInstanceBot.</param>
        /// 
        /// <returns>Returns a  CreateAppInstanceBotResult from ChimeSDKIdentity.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/CreateAppInstanceBot">REST API Reference for CreateAppInstanceBot Operation</seealso>
        CreateAppInstanceBotResponse EndCreateAppInstanceBot(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateAppInstanceUser


        /// <summary>
        /// Creates a user under an Amazon Chime <code>AppInstance</code>. The request consists
        /// of a unique <code>appInstanceUserId</code> and <code>Name</code> for that user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAppInstanceUser service method.</param>
        /// 
        /// <returns>The response from the CreateAppInstanceUser service method, as returned by ChimeSDKIdentity.</returns>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/CreateAppInstanceUser">REST API Reference for CreateAppInstanceUser Operation</seealso>
        CreateAppInstanceUserResponse CreateAppInstanceUser(CreateAppInstanceUserRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAppInstanceUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAppInstanceUser operation on AmazonChimeSDKIdentityClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAppInstanceUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/CreateAppInstanceUser">REST API Reference for CreateAppInstanceUser Operation</seealso>
        IAsyncResult BeginCreateAppInstanceUser(CreateAppInstanceUserRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAppInstanceUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAppInstanceUser.</param>
        /// 
        /// <returns>Returns a  CreateAppInstanceUserResult from ChimeSDKIdentity.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/CreateAppInstanceUser">REST API Reference for CreateAppInstanceUser Operation</seealso>
        CreateAppInstanceUserResponse EndCreateAppInstanceUser(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteAppInstance


        /// <summary>
        /// Deletes an <code>AppInstance</code> and all associated data asynchronously.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAppInstance service method.</param>
        /// 
        /// <returns>The response from the DeleteAppInstance service method, as returned by ChimeSDKIdentity.</returns>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/DeleteAppInstance">REST API Reference for DeleteAppInstance Operation</seealso>
        DeleteAppInstanceResponse DeleteAppInstance(DeleteAppInstanceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAppInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAppInstance operation on AmazonChimeSDKIdentityClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAppInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/DeleteAppInstance">REST API Reference for DeleteAppInstance Operation</seealso>
        IAsyncResult BeginDeleteAppInstance(DeleteAppInstanceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAppInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAppInstance.</param>
        /// 
        /// <returns>Returns a  DeleteAppInstanceResult from ChimeSDKIdentity.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/DeleteAppInstance">REST API Reference for DeleteAppInstance Operation</seealso>
        DeleteAppInstanceResponse EndDeleteAppInstance(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteAppInstanceAdmin


        /// <summary>
        /// Demotes an <code>AppInstanceAdmin</code> to an <code>AppInstanceUser</code> or <code>AppInstanceBot</code>.
        /// This action does not delete the user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAppInstanceAdmin service method.</param>
        /// 
        /// <returns>The response from the DeleteAppInstanceAdmin service method, as returned by ChimeSDKIdentity.</returns>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/DeleteAppInstanceAdmin">REST API Reference for DeleteAppInstanceAdmin Operation</seealso>
        DeleteAppInstanceAdminResponse DeleteAppInstanceAdmin(DeleteAppInstanceAdminRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAppInstanceAdmin operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAppInstanceAdmin operation on AmazonChimeSDKIdentityClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAppInstanceAdmin
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/DeleteAppInstanceAdmin">REST API Reference for DeleteAppInstanceAdmin Operation</seealso>
        IAsyncResult BeginDeleteAppInstanceAdmin(DeleteAppInstanceAdminRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAppInstanceAdmin operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAppInstanceAdmin.</param>
        /// 
        /// <returns>Returns a  DeleteAppInstanceAdminResult from ChimeSDKIdentity.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/DeleteAppInstanceAdmin">REST API Reference for DeleteAppInstanceAdmin Operation</seealso>
        DeleteAppInstanceAdminResponse EndDeleteAppInstanceAdmin(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteAppInstanceBot


        /// <summary>
        /// Deletes an <code>AppInstanceBot</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAppInstanceBot service method.</param>
        /// 
        /// <returns>The response from the DeleteAppInstanceBot service method, as returned by ChimeSDKIdentity.</returns>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/DeleteAppInstanceBot">REST API Reference for DeleteAppInstanceBot Operation</seealso>
        DeleteAppInstanceBotResponse DeleteAppInstanceBot(DeleteAppInstanceBotRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAppInstanceBot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAppInstanceBot operation on AmazonChimeSDKIdentityClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAppInstanceBot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/DeleteAppInstanceBot">REST API Reference for DeleteAppInstanceBot Operation</seealso>
        IAsyncResult BeginDeleteAppInstanceBot(DeleteAppInstanceBotRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAppInstanceBot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAppInstanceBot.</param>
        /// 
        /// <returns>Returns a  DeleteAppInstanceBotResult from ChimeSDKIdentity.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/DeleteAppInstanceBot">REST API Reference for DeleteAppInstanceBot Operation</seealso>
        DeleteAppInstanceBotResponse EndDeleteAppInstanceBot(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteAppInstanceUser


        /// <summary>
        /// Deletes an <code>AppInstanceUser</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAppInstanceUser service method.</param>
        /// 
        /// <returns>The response from the DeleteAppInstanceUser service method, as returned by ChimeSDKIdentity.</returns>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/DeleteAppInstanceUser">REST API Reference for DeleteAppInstanceUser Operation</seealso>
        DeleteAppInstanceUserResponse DeleteAppInstanceUser(DeleteAppInstanceUserRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAppInstanceUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAppInstanceUser operation on AmazonChimeSDKIdentityClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAppInstanceUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/DeleteAppInstanceUser">REST API Reference for DeleteAppInstanceUser Operation</seealso>
        IAsyncResult BeginDeleteAppInstanceUser(DeleteAppInstanceUserRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAppInstanceUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAppInstanceUser.</param>
        /// 
        /// <returns>Returns a  DeleteAppInstanceUserResult from ChimeSDKIdentity.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/DeleteAppInstanceUser">REST API Reference for DeleteAppInstanceUser Operation</seealso>
        DeleteAppInstanceUserResponse EndDeleteAppInstanceUser(IAsyncResult asyncResult);

        #endregion
        
        #region  DeregisterAppInstanceUserEndpoint


        /// <summary>
        /// Deregisters an <code>AppInstanceUserEndpoint</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterAppInstanceUserEndpoint service method.</param>
        /// 
        /// <returns>The response from the DeregisterAppInstanceUserEndpoint service method, as returned by ChimeSDKIdentity.</returns>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/DeregisterAppInstanceUserEndpoint">REST API Reference for DeregisterAppInstanceUserEndpoint Operation</seealso>
        DeregisterAppInstanceUserEndpointResponse DeregisterAppInstanceUserEndpoint(DeregisterAppInstanceUserEndpointRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeregisterAppInstanceUserEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterAppInstanceUserEndpoint operation on AmazonChimeSDKIdentityClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeregisterAppInstanceUserEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/DeregisterAppInstanceUserEndpoint">REST API Reference for DeregisterAppInstanceUserEndpoint Operation</seealso>
        IAsyncResult BeginDeregisterAppInstanceUserEndpoint(DeregisterAppInstanceUserEndpointRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeregisterAppInstanceUserEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeregisterAppInstanceUserEndpoint.</param>
        /// 
        /// <returns>Returns a  DeregisterAppInstanceUserEndpointResult from ChimeSDKIdentity.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/DeregisterAppInstanceUserEndpoint">REST API Reference for DeregisterAppInstanceUserEndpoint Operation</seealso>
        DeregisterAppInstanceUserEndpointResponse EndDeregisterAppInstanceUserEndpoint(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeAppInstance


        /// <summary>
        /// Returns the full details of an <code>AppInstance</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAppInstance service method.</param>
        /// 
        /// <returns>The response from the DescribeAppInstance service method, as returned by ChimeSDKIdentity.</returns>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/DescribeAppInstance">REST API Reference for DescribeAppInstance Operation</seealso>
        DescribeAppInstanceResponse DescribeAppInstance(DescribeAppInstanceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAppInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAppInstance operation on AmazonChimeSDKIdentityClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAppInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/DescribeAppInstance">REST API Reference for DescribeAppInstance Operation</seealso>
        IAsyncResult BeginDescribeAppInstance(DescribeAppInstanceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAppInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAppInstance.</param>
        /// 
        /// <returns>Returns a  DescribeAppInstanceResult from ChimeSDKIdentity.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/DescribeAppInstance">REST API Reference for DescribeAppInstance Operation</seealso>
        DescribeAppInstanceResponse EndDescribeAppInstance(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeAppInstanceAdmin


        /// <summary>
        /// Returns the full details of an <code>AppInstanceAdmin</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAppInstanceAdmin service method.</param>
        /// 
        /// <returns>The response from the DescribeAppInstanceAdmin service method, as returned by ChimeSDKIdentity.</returns>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/DescribeAppInstanceAdmin">REST API Reference for DescribeAppInstanceAdmin Operation</seealso>
        DescribeAppInstanceAdminResponse DescribeAppInstanceAdmin(DescribeAppInstanceAdminRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAppInstanceAdmin operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAppInstanceAdmin operation on AmazonChimeSDKIdentityClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAppInstanceAdmin
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/DescribeAppInstanceAdmin">REST API Reference for DescribeAppInstanceAdmin Operation</seealso>
        IAsyncResult BeginDescribeAppInstanceAdmin(DescribeAppInstanceAdminRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAppInstanceAdmin operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAppInstanceAdmin.</param>
        /// 
        /// <returns>Returns a  DescribeAppInstanceAdminResult from ChimeSDKIdentity.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/DescribeAppInstanceAdmin">REST API Reference for DescribeAppInstanceAdmin Operation</seealso>
        DescribeAppInstanceAdminResponse EndDescribeAppInstanceAdmin(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeAppInstanceBot


        /// <summary>
        /// The <code>AppInstanceBot's</code> information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAppInstanceBot service method.</param>
        /// 
        /// <returns>The response from the DescribeAppInstanceBot service method, as returned by ChimeSDKIdentity.</returns>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/DescribeAppInstanceBot">REST API Reference for DescribeAppInstanceBot Operation</seealso>
        DescribeAppInstanceBotResponse DescribeAppInstanceBot(DescribeAppInstanceBotRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAppInstanceBot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAppInstanceBot operation on AmazonChimeSDKIdentityClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAppInstanceBot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/DescribeAppInstanceBot">REST API Reference for DescribeAppInstanceBot Operation</seealso>
        IAsyncResult BeginDescribeAppInstanceBot(DescribeAppInstanceBotRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAppInstanceBot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAppInstanceBot.</param>
        /// 
        /// <returns>Returns a  DescribeAppInstanceBotResult from ChimeSDKIdentity.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/DescribeAppInstanceBot">REST API Reference for DescribeAppInstanceBot Operation</seealso>
        DescribeAppInstanceBotResponse EndDescribeAppInstanceBot(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeAppInstanceUser


        /// <summary>
        /// Returns the full details of an <code>AppInstanceUser</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAppInstanceUser service method.</param>
        /// 
        /// <returns>The response from the DescribeAppInstanceUser service method, as returned by ChimeSDKIdentity.</returns>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/DescribeAppInstanceUser">REST API Reference for DescribeAppInstanceUser Operation</seealso>
        DescribeAppInstanceUserResponse DescribeAppInstanceUser(DescribeAppInstanceUserRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAppInstanceUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAppInstanceUser operation on AmazonChimeSDKIdentityClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAppInstanceUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/DescribeAppInstanceUser">REST API Reference for DescribeAppInstanceUser Operation</seealso>
        IAsyncResult BeginDescribeAppInstanceUser(DescribeAppInstanceUserRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAppInstanceUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAppInstanceUser.</param>
        /// 
        /// <returns>Returns a  DescribeAppInstanceUserResult from ChimeSDKIdentity.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/DescribeAppInstanceUser">REST API Reference for DescribeAppInstanceUser Operation</seealso>
        DescribeAppInstanceUserResponse EndDescribeAppInstanceUser(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeAppInstanceUserEndpoint


        /// <summary>
        /// Returns the full details of an <code>AppInstanceUserEndpoint</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAppInstanceUserEndpoint service method.</param>
        /// 
        /// <returns>The response from the DescribeAppInstanceUserEndpoint service method, as returned by ChimeSDKIdentity.</returns>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/DescribeAppInstanceUserEndpoint">REST API Reference for DescribeAppInstanceUserEndpoint Operation</seealso>
        DescribeAppInstanceUserEndpointResponse DescribeAppInstanceUserEndpoint(DescribeAppInstanceUserEndpointRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAppInstanceUserEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAppInstanceUserEndpoint operation on AmazonChimeSDKIdentityClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAppInstanceUserEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/DescribeAppInstanceUserEndpoint">REST API Reference for DescribeAppInstanceUserEndpoint Operation</seealso>
        IAsyncResult BeginDescribeAppInstanceUserEndpoint(DescribeAppInstanceUserEndpointRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAppInstanceUserEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAppInstanceUserEndpoint.</param>
        /// 
        /// <returns>Returns a  DescribeAppInstanceUserEndpointResult from ChimeSDKIdentity.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/DescribeAppInstanceUserEndpoint">REST API Reference for DescribeAppInstanceUserEndpoint Operation</seealso>
        DescribeAppInstanceUserEndpointResponse EndDescribeAppInstanceUserEndpoint(IAsyncResult asyncResult);

        #endregion
        
        #region  GetAppInstanceRetentionSettings


        /// <summary>
        /// Gets the retention settings for an <code>AppInstance</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAppInstanceRetentionSettings service method.</param>
        /// 
        /// <returns>The response from the GetAppInstanceRetentionSettings service method, as returned by ChimeSDKIdentity.</returns>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/GetAppInstanceRetentionSettings">REST API Reference for GetAppInstanceRetentionSettings Operation</seealso>
        GetAppInstanceRetentionSettingsResponse GetAppInstanceRetentionSettings(GetAppInstanceRetentionSettingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetAppInstanceRetentionSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAppInstanceRetentionSettings operation on AmazonChimeSDKIdentityClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAppInstanceRetentionSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/GetAppInstanceRetentionSettings">REST API Reference for GetAppInstanceRetentionSettings Operation</seealso>
        IAsyncResult BeginGetAppInstanceRetentionSettings(GetAppInstanceRetentionSettingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAppInstanceRetentionSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAppInstanceRetentionSettings.</param>
        /// 
        /// <returns>Returns a  GetAppInstanceRetentionSettingsResult from ChimeSDKIdentity.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/GetAppInstanceRetentionSettings">REST API Reference for GetAppInstanceRetentionSettings Operation</seealso>
        GetAppInstanceRetentionSettingsResponse EndGetAppInstanceRetentionSettings(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAppInstanceAdmins


        /// <summary>
        /// Returns a list of the administrators in the <code>AppInstance</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAppInstanceAdmins service method.</param>
        /// 
        /// <returns>The response from the ListAppInstanceAdmins service method, as returned by ChimeSDKIdentity.</returns>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/ListAppInstanceAdmins">REST API Reference for ListAppInstanceAdmins Operation</seealso>
        ListAppInstanceAdminsResponse ListAppInstanceAdmins(ListAppInstanceAdminsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAppInstanceAdmins operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAppInstanceAdmins operation on AmazonChimeSDKIdentityClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAppInstanceAdmins
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/ListAppInstanceAdmins">REST API Reference for ListAppInstanceAdmins Operation</seealso>
        IAsyncResult BeginListAppInstanceAdmins(ListAppInstanceAdminsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAppInstanceAdmins operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAppInstanceAdmins.</param>
        /// 
        /// <returns>Returns a  ListAppInstanceAdminsResult from ChimeSDKIdentity.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/ListAppInstanceAdmins">REST API Reference for ListAppInstanceAdmins Operation</seealso>
        ListAppInstanceAdminsResponse EndListAppInstanceAdmins(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAppInstanceBots


        /// <summary>
        /// Lists all <code>AppInstanceBots</code> created under a single <code>AppInstance</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAppInstanceBots service method.</param>
        /// 
        /// <returns>The response from the ListAppInstanceBots service method, as returned by ChimeSDKIdentity.</returns>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/ListAppInstanceBots">REST API Reference for ListAppInstanceBots Operation</seealso>
        ListAppInstanceBotsResponse ListAppInstanceBots(ListAppInstanceBotsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAppInstanceBots operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAppInstanceBots operation on AmazonChimeSDKIdentityClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAppInstanceBots
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/ListAppInstanceBots">REST API Reference for ListAppInstanceBots Operation</seealso>
        IAsyncResult BeginListAppInstanceBots(ListAppInstanceBotsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAppInstanceBots operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAppInstanceBots.</param>
        /// 
        /// <returns>Returns a  ListAppInstanceBotsResult from ChimeSDKIdentity.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/ListAppInstanceBots">REST API Reference for ListAppInstanceBots Operation</seealso>
        ListAppInstanceBotsResponse EndListAppInstanceBots(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAppInstances


        /// <summary>
        /// Lists all Amazon Chime <code>AppInstance</code>s created under a single AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAppInstances service method.</param>
        /// 
        /// <returns>The response from the ListAppInstances service method, as returned by ChimeSDKIdentity.</returns>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/ListAppInstances">REST API Reference for ListAppInstances Operation</seealso>
        ListAppInstancesResponse ListAppInstances(ListAppInstancesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAppInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAppInstances operation on AmazonChimeSDKIdentityClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAppInstances
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/ListAppInstances">REST API Reference for ListAppInstances Operation</seealso>
        IAsyncResult BeginListAppInstances(ListAppInstancesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAppInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAppInstances.</param>
        /// 
        /// <returns>Returns a  ListAppInstancesResult from ChimeSDKIdentity.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/ListAppInstances">REST API Reference for ListAppInstances Operation</seealso>
        ListAppInstancesResponse EndListAppInstances(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAppInstanceUserEndpoints


        /// <summary>
        /// Lists all the <code>AppInstanceUserEndpoints</code> created under a single <code>AppInstanceUser</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAppInstanceUserEndpoints service method.</param>
        /// 
        /// <returns>The response from the ListAppInstanceUserEndpoints service method, as returned by ChimeSDKIdentity.</returns>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/ListAppInstanceUserEndpoints">REST API Reference for ListAppInstanceUserEndpoints Operation</seealso>
        ListAppInstanceUserEndpointsResponse ListAppInstanceUserEndpoints(ListAppInstanceUserEndpointsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAppInstanceUserEndpoints operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAppInstanceUserEndpoints operation on AmazonChimeSDKIdentityClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAppInstanceUserEndpoints
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/ListAppInstanceUserEndpoints">REST API Reference for ListAppInstanceUserEndpoints Operation</seealso>
        IAsyncResult BeginListAppInstanceUserEndpoints(ListAppInstanceUserEndpointsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAppInstanceUserEndpoints operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAppInstanceUserEndpoints.</param>
        /// 
        /// <returns>Returns a  ListAppInstanceUserEndpointsResult from ChimeSDKIdentity.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/ListAppInstanceUserEndpoints">REST API Reference for ListAppInstanceUserEndpoints Operation</seealso>
        ListAppInstanceUserEndpointsResponse EndListAppInstanceUserEndpoints(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAppInstanceUsers


        /// <summary>
        /// List all <code>AppInstanceUsers</code> created under a single <code>AppInstance</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAppInstanceUsers service method.</param>
        /// 
        /// <returns>The response from the ListAppInstanceUsers service method, as returned by ChimeSDKIdentity.</returns>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/ListAppInstanceUsers">REST API Reference for ListAppInstanceUsers Operation</seealso>
        ListAppInstanceUsersResponse ListAppInstanceUsers(ListAppInstanceUsersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAppInstanceUsers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAppInstanceUsers operation on AmazonChimeSDKIdentityClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAppInstanceUsers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/ListAppInstanceUsers">REST API Reference for ListAppInstanceUsers Operation</seealso>
        IAsyncResult BeginListAppInstanceUsers(ListAppInstanceUsersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAppInstanceUsers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAppInstanceUsers.</param>
        /// 
        /// <returns>Returns a  ListAppInstanceUsersResult from ChimeSDKIdentity.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/ListAppInstanceUsers">REST API Reference for ListAppInstanceUsers Operation</seealso>
        ListAppInstanceUsersResponse EndListAppInstanceUsers(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists the tags applied to an Amazon Chime SDK identity resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by ChimeSDKIdentity.</returns>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonChimeSDKIdentityClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from ChimeSDKIdentity.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  PutAppInstanceRetentionSettings


        /// <summary>
        /// Sets the amount of time in days that a given <code>AppInstance</code> retains data.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAppInstanceRetentionSettings service method.</param>
        /// 
        /// <returns>The response from the PutAppInstanceRetentionSettings service method, as returned by ChimeSDKIdentity.</returns>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/PutAppInstanceRetentionSettings">REST API Reference for PutAppInstanceRetentionSettings Operation</seealso>
        PutAppInstanceRetentionSettingsResponse PutAppInstanceRetentionSettings(PutAppInstanceRetentionSettingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutAppInstanceRetentionSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutAppInstanceRetentionSettings operation on AmazonChimeSDKIdentityClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutAppInstanceRetentionSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/PutAppInstanceRetentionSettings">REST API Reference for PutAppInstanceRetentionSettings Operation</seealso>
        IAsyncResult BeginPutAppInstanceRetentionSettings(PutAppInstanceRetentionSettingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutAppInstanceRetentionSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutAppInstanceRetentionSettings.</param>
        /// 
        /// <returns>Returns a  PutAppInstanceRetentionSettingsResult from ChimeSDKIdentity.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/PutAppInstanceRetentionSettings">REST API Reference for PutAppInstanceRetentionSettings Operation</seealso>
        PutAppInstanceRetentionSettingsResponse EndPutAppInstanceRetentionSettings(IAsyncResult asyncResult);

        #endregion
        
        #region  PutAppInstanceUserExpirationSettings


        /// <summary>
        /// Sets the number of days before the <code>AppInstanceUser</code> is automatically deleted.
        /// 
        ///  <note> 
        /// <para>
        /// A background process deletes expired <code>AppInstanceUsers</code> within 6 hours
        /// of expiration. Actual deletion times may vary.
        /// </para>
        ///  
        /// <para>
        /// Expired <code>AppInstanceUsers</code> that have not yet been deleted appear as active,
        /// and you can update their expiration settings. The system honors the new settings.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAppInstanceUserExpirationSettings service method.</param>
        /// 
        /// <returns>The response from the PutAppInstanceUserExpirationSettings service method, as returned by ChimeSDKIdentity.</returns>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/PutAppInstanceUserExpirationSettings">REST API Reference for PutAppInstanceUserExpirationSettings Operation</seealso>
        PutAppInstanceUserExpirationSettingsResponse PutAppInstanceUserExpirationSettings(PutAppInstanceUserExpirationSettingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutAppInstanceUserExpirationSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutAppInstanceUserExpirationSettings operation on AmazonChimeSDKIdentityClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutAppInstanceUserExpirationSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/PutAppInstanceUserExpirationSettings">REST API Reference for PutAppInstanceUserExpirationSettings Operation</seealso>
        IAsyncResult BeginPutAppInstanceUserExpirationSettings(PutAppInstanceUserExpirationSettingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutAppInstanceUserExpirationSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutAppInstanceUserExpirationSettings.</param>
        /// 
        /// <returns>Returns a  PutAppInstanceUserExpirationSettingsResult from ChimeSDKIdentity.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/PutAppInstanceUserExpirationSettings">REST API Reference for PutAppInstanceUserExpirationSettings Operation</seealso>
        PutAppInstanceUserExpirationSettingsResponse EndPutAppInstanceUserExpirationSettings(IAsyncResult asyncResult);

        #endregion
        
        #region  RegisterAppInstanceUserEndpoint


        /// <summary>
        /// Registers an endpoint under an Amazon Chime <code>AppInstanceUser</code>. The endpoint
        /// receives messages for a user. For push notifications, the endpoint is a mobile device
        /// used to receive mobile push notifications for a user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterAppInstanceUserEndpoint service method.</param>
        /// 
        /// <returns>The response from the RegisterAppInstanceUserEndpoint service method, as returned by ChimeSDKIdentity.</returns>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/RegisterAppInstanceUserEndpoint">REST API Reference for RegisterAppInstanceUserEndpoint Operation</seealso>
        RegisterAppInstanceUserEndpointResponse RegisterAppInstanceUserEndpoint(RegisterAppInstanceUserEndpointRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RegisterAppInstanceUserEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterAppInstanceUserEndpoint operation on AmazonChimeSDKIdentityClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRegisterAppInstanceUserEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/RegisterAppInstanceUserEndpoint">REST API Reference for RegisterAppInstanceUserEndpoint Operation</seealso>
        IAsyncResult BeginRegisterAppInstanceUserEndpoint(RegisterAppInstanceUserEndpointRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RegisterAppInstanceUserEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterAppInstanceUserEndpoint.</param>
        /// 
        /// <returns>Returns a  RegisterAppInstanceUserEndpointResult from ChimeSDKIdentity.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/RegisterAppInstanceUserEndpoint">REST API Reference for RegisterAppInstanceUserEndpoint Operation</seealso>
        RegisterAppInstanceUserEndpointResponse EndRegisterAppInstanceUserEndpoint(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Applies the specified tags to the specified Amazon Chime SDK identity resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by ChimeSDKIdentity.</returns>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonChimeSDKIdentityClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from ChimeSDKIdentity.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes the specified tags from the specified Amazon Chime SDK identity resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by ChimeSDKIdentity.</returns>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonChimeSDKIdentityClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from ChimeSDKIdentity.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateAppInstance


        /// <summary>
        /// Updates <code>AppInstance</code> metadata.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAppInstance service method.</param>
        /// 
        /// <returns>The response from the UpdateAppInstance service method, as returned by ChimeSDKIdentity.</returns>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/UpdateAppInstance">REST API Reference for UpdateAppInstance Operation</seealso>
        UpdateAppInstanceResponse UpdateAppInstance(UpdateAppInstanceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAppInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAppInstance operation on AmazonChimeSDKIdentityClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAppInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/UpdateAppInstance">REST API Reference for UpdateAppInstance Operation</seealso>
        IAsyncResult BeginUpdateAppInstance(UpdateAppInstanceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAppInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAppInstance.</param>
        /// 
        /// <returns>Returns a  UpdateAppInstanceResult from ChimeSDKIdentity.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/UpdateAppInstance">REST API Reference for UpdateAppInstance Operation</seealso>
        UpdateAppInstanceResponse EndUpdateAppInstance(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateAppInstanceBot


        /// <summary>
        /// Updates the name and metadata of an <code>AppInstanceBot</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAppInstanceBot service method.</param>
        /// 
        /// <returns>The response from the UpdateAppInstanceBot service method, as returned by ChimeSDKIdentity.</returns>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/UpdateAppInstanceBot">REST API Reference for UpdateAppInstanceBot Operation</seealso>
        UpdateAppInstanceBotResponse UpdateAppInstanceBot(UpdateAppInstanceBotRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAppInstanceBot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAppInstanceBot operation on AmazonChimeSDKIdentityClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAppInstanceBot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/UpdateAppInstanceBot">REST API Reference for UpdateAppInstanceBot Operation</seealso>
        IAsyncResult BeginUpdateAppInstanceBot(UpdateAppInstanceBotRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAppInstanceBot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAppInstanceBot.</param>
        /// 
        /// <returns>Returns a  UpdateAppInstanceBotResult from ChimeSDKIdentity.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/UpdateAppInstanceBot">REST API Reference for UpdateAppInstanceBot Operation</seealso>
        UpdateAppInstanceBotResponse EndUpdateAppInstanceBot(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateAppInstanceUser


        /// <summary>
        /// Updates the details of an <code>AppInstanceUser</code>. You can update names and metadata.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAppInstanceUser service method.</param>
        /// 
        /// <returns>The response from the UpdateAppInstanceUser service method, as returned by ChimeSDKIdentity.</returns>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/UpdateAppInstanceUser">REST API Reference for UpdateAppInstanceUser Operation</seealso>
        UpdateAppInstanceUserResponse UpdateAppInstanceUser(UpdateAppInstanceUserRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAppInstanceUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAppInstanceUser operation on AmazonChimeSDKIdentityClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAppInstanceUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/UpdateAppInstanceUser">REST API Reference for UpdateAppInstanceUser Operation</seealso>
        IAsyncResult BeginUpdateAppInstanceUser(UpdateAppInstanceUserRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAppInstanceUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAppInstanceUser.</param>
        /// 
        /// <returns>Returns a  UpdateAppInstanceUserResult from ChimeSDKIdentity.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/UpdateAppInstanceUser">REST API Reference for UpdateAppInstanceUser Operation</seealso>
        UpdateAppInstanceUserResponse EndUpdateAppInstanceUser(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateAppInstanceUserEndpoint


        /// <summary>
        /// Updates the details of an <code>AppInstanceUserEndpoint</code>. You can update the
        /// name and <code>AllowMessage</code> values.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAppInstanceUserEndpoint service method.</param>
        /// 
        /// <returns>The response from the UpdateAppInstanceUserEndpoint service method, as returned by ChimeSDKIdentity.</returns>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKIdentity.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/UpdateAppInstanceUserEndpoint">REST API Reference for UpdateAppInstanceUserEndpoint Operation</seealso>
        UpdateAppInstanceUserEndpointResponse UpdateAppInstanceUserEndpoint(UpdateAppInstanceUserEndpointRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAppInstanceUserEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAppInstanceUserEndpoint operation on AmazonChimeSDKIdentityClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAppInstanceUserEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/UpdateAppInstanceUserEndpoint">REST API Reference for UpdateAppInstanceUserEndpoint Operation</seealso>
        IAsyncResult BeginUpdateAppInstanceUserEndpoint(UpdateAppInstanceUserEndpointRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAppInstanceUserEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAppInstanceUserEndpoint.</param>
        /// 
        /// <returns>Returns a  UpdateAppInstanceUserEndpointResult from ChimeSDKIdentity.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-identity-2021-04-20/UpdateAppInstanceUserEndpoint">REST API Reference for UpdateAppInstanceUserEndpoint Operation</seealso>
        UpdateAppInstanceUserEndpointResponse EndUpdateAppInstanceUserEndpoint(IAsyncResult asyncResult);

        #endregion
        
    }
}