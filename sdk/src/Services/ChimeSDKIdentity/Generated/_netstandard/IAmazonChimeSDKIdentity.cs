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
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.ChimeSDKIdentity.Model;

#pragma warning disable CS1570
namespace Amazon.ChimeSDKIdentity
{
    /// <summary>
    /// <para>Interface for accessing ChimeSDKIdentity</para>
    ///
    /// The Amazon Chime SDK Identity APIs in this section allow software developers to create
    /// and manage unique instances of their messaging applications. These APIs provide the
    /// overarching framework for creating and sending messages. For more information about
    /// the identity APIs, refer to <a href="https://docs.aws.amazon.com/chime/latest/APIReference/API_Operations_Amazon_Chime_SDK_Identity.html">Amazon
    /// Chime SDK identity</a>.
    /// </summary>
    public partial interface IAmazonChimeSDKIdentity : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IChimeSDKIdentityPaginatorFactory Paginators { get; }
#endif
                
        #region  CreateAppInstance



        /// <summary>
        /// Creates an Amazon Chime SDK messaging <c>AppInstance</c> under an AWS account. Only
        /// SDK messaging customers use this API. <c>CreateAppInstance</c> supports idempotency
        /// behavior as described in the AWS API Standard.
        /// 
        ///  
        /// <para>
        /// identity
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAppInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateAppInstanceResponse> CreateAppInstanceAsync(CreateAppInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateAppInstanceAdmin



        /// <summary>
        /// Promotes an <c>AppInstanceUser</c> or <c>AppInstanceBot</c> to an <c>AppInstanceAdmin</c>.
        /// The promoted entity can perform the following actions. 
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <c>ChannelModerator</c> actions across all channels in the <c>AppInstance</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DeleteChannelMessage</c> actions.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Only an <c>AppInstanceUser</c> and <c>AppInstanceBot</c> can be promoted to an <c>AppInstanceAdmin</c>
        /// role.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAppInstanceAdmin service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateAppInstanceAdminResponse> CreateAppInstanceAdminAsync(CreateAppInstanceAdminRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateAppInstanceBot



        /// <summary>
        /// Creates a bot under an Amazon Chime <c>AppInstance</c>. The request consists of a
        /// unique <c>Configuration</c> and <c>Name</c> for that bot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAppInstanceBot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateAppInstanceBotResponse> CreateAppInstanceBotAsync(CreateAppInstanceBotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateAppInstanceUser



        /// <summary>
        /// Creates a user under an Amazon Chime <c>AppInstance</c>. The request consists of a
        /// unique <c>appInstanceUserId</c> and <c>Name</c> for that user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAppInstanceUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateAppInstanceUserResponse> CreateAppInstanceUserAsync(CreateAppInstanceUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteAppInstance



        /// <summary>
        /// Deletes an <c>AppInstance</c> and all associated data asynchronously.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAppInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteAppInstanceResponse> DeleteAppInstanceAsync(DeleteAppInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteAppInstanceAdmin



        /// <summary>
        /// Demotes an <c>AppInstanceAdmin</c> to an <c>AppInstanceUser</c> or <c>AppInstanceBot</c>.
        /// This action does not delete the user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAppInstanceAdmin service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteAppInstanceAdminResponse> DeleteAppInstanceAdminAsync(DeleteAppInstanceAdminRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteAppInstanceBot



        /// <summary>
        /// Deletes an <c>AppInstanceBot</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAppInstanceBot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteAppInstanceBotResponse> DeleteAppInstanceBotAsync(DeleteAppInstanceBotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteAppInstanceUser



        /// <summary>
        /// Deletes an <c>AppInstanceUser</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAppInstanceUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteAppInstanceUserResponse> DeleteAppInstanceUserAsync(DeleteAppInstanceUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeregisterAppInstanceUserEndpoint



        /// <summary>
        /// Deregisters an <c>AppInstanceUserEndpoint</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterAppInstanceUserEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeregisterAppInstanceUserEndpointResponse> DeregisterAppInstanceUserEndpointAsync(DeregisterAppInstanceUserEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeAppInstance



        /// <summary>
        /// Returns the full details of an <c>AppInstance</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAppInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DescribeAppInstanceResponse> DescribeAppInstanceAsync(DescribeAppInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeAppInstanceAdmin



        /// <summary>
        /// Returns the full details of an <c>AppInstanceAdmin</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAppInstanceAdmin service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DescribeAppInstanceAdminResponse> DescribeAppInstanceAdminAsync(DescribeAppInstanceAdminRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeAppInstanceBot



        /// <summary>
        /// The <c>AppInstanceBot's</c> information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAppInstanceBot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DescribeAppInstanceBotResponse> DescribeAppInstanceBotAsync(DescribeAppInstanceBotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeAppInstanceUser



        /// <summary>
        /// Returns the full details of an <c>AppInstanceUser</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAppInstanceUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DescribeAppInstanceUserResponse> DescribeAppInstanceUserAsync(DescribeAppInstanceUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeAppInstanceUserEndpoint



        /// <summary>
        /// Returns the full details of an <c>AppInstanceUserEndpoint</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAppInstanceUserEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DescribeAppInstanceUserEndpointResponse> DescribeAppInstanceUserEndpointAsync(DescribeAppInstanceUserEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetAppInstanceRetentionSettings



        /// <summary>
        /// Gets the retention settings for an <c>AppInstance</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAppInstanceRetentionSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetAppInstanceRetentionSettingsResponse> GetAppInstanceRetentionSettingsAsync(GetAppInstanceRetentionSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListAppInstanceAdmins



        /// <summary>
        /// Returns a list of the administrators in the <c>AppInstance</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAppInstanceAdmins service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListAppInstanceAdminsResponse> ListAppInstanceAdminsAsync(ListAppInstanceAdminsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListAppInstanceBots



        /// <summary>
        /// Lists all <c>AppInstanceBots</c> created under a single <c>AppInstance</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAppInstanceBots service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListAppInstanceBotsResponse> ListAppInstanceBotsAsync(ListAppInstanceBotsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListAppInstances



        /// <summary>
        /// Lists all Amazon Chime <c>AppInstance</c>s created under a single AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAppInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListAppInstancesResponse> ListAppInstancesAsync(ListAppInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListAppInstanceUserEndpoints



        /// <summary>
        /// Lists all the <c>AppInstanceUserEndpoints</c> created under a single <c>AppInstanceUser</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAppInstanceUserEndpoints service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListAppInstanceUserEndpointsResponse> ListAppInstanceUserEndpointsAsync(ListAppInstanceUserEndpointsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListAppInstanceUsers



        /// <summary>
        /// List all <c>AppInstanceUsers</c> created under a single <c>AppInstance</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAppInstanceUsers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListAppInstanceUsersResponse> ListAppInstanceUsersAsync(ListAppInstanceUsersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource



        /// <summary>
        /// Lists the tags applied to an Amazon Chime SDK identity resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutAppInstanceRetentionSettings



        /// <summary>
        /// Sets the amount of time in days that a given <c>AppInstance</c> retains data.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAppInstanceRetentionSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<PutAppInstanceRetentionSettingsResponse> PutAppInstanceRetentionSettingsAsync(PutAppInstanceRetentionSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutAppInstanceUserExpirationSettings



        /// <summary>
        /// Sets the number of days before the <c>AppInstanceUser</c> is automatically deleted.
        /// 
        ///  <note> 
        /// <para>
        /// A background process deletes expired <c>AppInstanceUsers</c> within 6 hours of expiration.
        /// Actual deletion times may vary.
        /// </para>
        ///  
        /// <para>
        /// Expired <c>AppInstanceUsers</c> that have not yet been deleted appear as active, and
        /// you can update their expiration settings. The system honors the new settings.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAppInstanceUserExpirationSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<PutAppInstanceUserExpirationSettingsResponse> PutAppInstanceUserExpirationSettingsAsync(PutAppInstanceUserExpirationSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RegisterAppInstanceUserEndpoint



        /// <summary>
        /// Registers an endpoint under an Amazon Chime <c>AppInstanceUser</c>. The endpoint receives
        /// messages for a user. For push notifications, the endpoint is a mobile device used
        /// to receive mobile push notifications for a user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterAppInstanceUserEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<RegisterAppInstanceUserEndpointResponse> RegisterAppInstanceUserEndpointAsync(RegisterAppInstanceUserEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource



        /// <summary>
        /// Applies the specified tags to the specified Amazon Chime SDK identity resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource



        /// <summary>
        /// Removes the specified tags from the specified Amazon Chime SDK identity resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateAppInstance



        /// <summary>
        /// Updates <c>AppInstance</c> metadata.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAppInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateAppInstanceResponse> UpdateAppInstanceAsync(UpdateAppInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateAppInstanceBot



        /// <summary>
        /// Updates the name and metadata of an <c>AppInstanceBot</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAppInstanceBot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateAppInstanceBotResponse> UpdateAppInstanceBotAsync(UpdateAppInstanceBotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateAppInstanceUser



        /// <summary>
        /// Updates the details of an <c>AppInstanceUser</c>. You can update names and metadata.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAppInstanceUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateAppInstanceUserResponse> UpdateAppInstanceUserAsync(UpdateAppInstanceUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateAppInstanceUserEndpoint



        /// <summary>
        /// Updates the details of an <c>AppInstanceUserEndpoint</c>. You can update the name
        /// and <c>AllowMessage</c> values.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAppInstanceUserEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateAppInstanceUserEndpointResponse> UpdateAppInstanceUserEndpointAsync(UpdateAppInstanceUserEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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