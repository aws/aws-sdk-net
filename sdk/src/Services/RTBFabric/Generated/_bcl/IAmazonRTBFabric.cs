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
 * Do not modify this file. This file is generated from the rtbfabric-2023-05-15.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.RTBFabric.Model;

#pragma warning disable CS1570
namespace Amazon.RTBFabric
{
    /// <summary>
    /// <para>Interface for accessing RTBFabric</para>
    ///
    /// Amazon Web Services RTB Fabric provides secure, low-latency infrastructure for connecting
    /// real-time bidding (RTB) applications. Rather than hosting applications directly, RTB
    /// Fabric acts as the connecting fabric that enables your applications to communicate
    /// efficiently over private networks instead of the public internet. You maintain complete
    /// control over your applications, data, and bidding decisions, while RTB Fabric provides
    /// the underlying infrastructure for secure, reliable connectivity.
    /// 
    ///  
    /// <para>
    /// You can use these APIs to complete RTB Fabric tasks, such as setting up audit log
    /// ingestions or viewing user access. For more information about RTB Fabric, including
    /// the required permissions to use the service, see the <a href="https://docs.aws.amazon.com/rtb-fabric/latest/userguide/">Amazon
    /// Web Services RTB Fabric User Guide</a>.
    /// </para>
    /// </summary>
    public partial interface IAmazonRTBFabric : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        IRTBFabricPaginatorFactory Paginators { get; }

        
        #region  AcceptLink


        /// <summary>
        /// Accepts a link request between RTB applications.
        /// 
        ///  
        /// <para>
        /// When a requester RTB application requests to link with a responder RTB application,
        /// the responder can use this operation to accept the link request and establish the
        /// connection.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptLink service method.</param>
        /// 
        /// <returns>The response from the AcceptLink service method, as returned by RTBFabric.</returns>
        /// <exception cref="Amazon.RTBFabric.Model.AccessDeniedException">
        /// The request could not be completed because you do not have sufficient access to perform
        /// this action.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ConflictException">
        /// The request could not be completed because of a conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.InternalServerException">
        /// The request could not be completed because of an internal server error. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ResourceNotFoundException">
        /// The request could not be completed because the resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ValidationException">
        /// The request could not be completed because it fails satisfy the constraints specified
        /// by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/AcceptLink">REST API Reference for AcceptLink Operation</seealso>
        AcceptLinkResponse AcceptLink(AcceptLinkRequest request);



        /// <summary>
        /// Accepts a link request between RTB applications.
        /// 
        ///  
        /// <para>
        /// When a requester RTB application requests to link with a responder RTB application,
        /// the responder can use this operation to accept the link request and establish the
        /// connection.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptLink service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AcceptLink service method, as returned by RTBFabric.</returns>
        /// <exception cref="Amazon.RTBFabric.Model.AccessDeniedException">
        /// The request could not be completed because you do not have sufficient access to perform
        /// this action.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ConflictException">
        /// The request could not be completed because of a conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.InternalServerException">
        /// The request could not be completed because of an internal server error. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ResourceNotFoundException">
        /// The request could not be completed because the resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ValidationException">
        /// The request could not be completed because it fails satisfy the constraints specified
        /// by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/AcceptLink">REST API Reference for AcceptLink Operation</seealso>
        Task<AcceptLinkResponse> AcceptLinkAsync(AcceptLinkRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateInboundExternalLink


        /// <summary>
        /// Creates an inbound external link.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateInboundExternalLink service method.</param>
        /// 
        /// <returns>The response from the CreateInboundExternalLink service method, as returned by RTBFabric.</returns>
        /// <exception cref="Amazon.RTBFabric.Model.AccessDeniedException">
        /// The request could not be completed because you do not have sufficient access to perform
        /// this action.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ConflictException">
        /// The request could not be completed because of a conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.InternalServerException">
        /// The request could not be completed because of an internal server error. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ResourceNotFoundException">
        /// The request could not be completed because the resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ServiceQuotaExceededException">
        /// The request could not be completed because you exceeded a service quota.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ValidationException">
        /// The request could not be completed because it fails satisfy the constraints specified
        /// by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/CreateInboundExternalLink">REST API Reference for CreateInboundExternalLink Operation</seealso>
        CreateInboundExternalLinkResponse CreateInboundExternalLink(CreateInboundExternalLinkRequest request);



        /// <summary>
        /// Creates an inbound external link.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateInboundExternalLink service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateInboundExternalLink service method, as returned by RTBFabric.</returns>
        /// <exception cref="Amazon.RTBFabric.Model.AccessDeniedException">
        /// The request could not be completed because you do not have sufficient access to perform
        /// this action.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ConflictException">
        /// The request could not be completed because of a conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.InternalServerException">
        /// The request could not be completed because of an internal server error. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ResourceNotFoundException">
        /// The request could not be completed because the resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ServiceQuotaExceededException">
        /// The request could not be completed because you exceeded a service quota.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ValidationException">
        /// The request could not be completed because it fails satisfy the constraints specified
        /// by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/CreateInboundExternalLink">REST API Reference for CreateInboundExternalLink Operation</seealso>
        Task<CreateInboundExternalLinkResponse> CreateInboundExternalLinkAsync(CreateInboundExternalLinkRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateLink


        /// <summary>
        /// Creates a new link between RTB applications.
        /// 
        ///  
        /// <para>
        /// Establishes a connection that allows RTB applications to communicate and exchange
        /// bid requests and responses.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLink service method.</param>
        /// 
        /// <returns>The response from the CreateLink service method, as returned by RTBFabric.</returns>
        /// <exception cref="Amazon.RTBFabric.Model.AccessDeniedException">
        /// The request could not be completed because you do not have sufficient access to perform
        /// this action.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ConflictException">
        /// The request could not be completed because of a conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.InternalServerException">
        /// The request could not be completed because of an internal server error. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ResourceNotFoundException">
        /// The request could not be completed because the resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ServiceQuotaExceededException">
        /// The request could not be completed because you exceeded a service quota.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ValidationException">
        /// The request could not be completed because it fails satisfy the constraints specified
        /// by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/CreateLink">REST API Reference for CreateLink Operation</seealso>
        CreateLinkResponse CreateLink(CreateLinkRequest request);



        /// <summary>
        /// Creates a new link between RTB applications.
        /// 
        ///  
        /// <para>
        /// Establishes a connection that allows RTB applications to communicate and exchange
        /// bid requests and responses.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLink service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateLink service method, as returned by RTBFabric.</returns>
        /// <exception cref="Amazon.RTBFabric.Model.AccessDeniedException">
        /// The request could not be completed because you do not have sufficient access to perform
        /// this action.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ConflictException">
        /// The request could not be completed because of a conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.InternalServerException">
        /// The request could not be completed because of an internal server error. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ResourceNotFoundException">
        /// The request could not be completed because the resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ServiceQuotaExceededException">
        /// The request could not be completed because you exceeded a service quota.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ValidationException">
        /// The request could not be completed because it fails satisfy the constraints specified
        /// by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/CreateLink">REST API Reference for CreateLink Operation</seealso>
        Task<CreateLinkResponse> CreateLinkAsync(CreateLinkRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateOutboundExternalLink


        /// <summary>
        /// Creates an outbound external link.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateOutboundExternalLink service method.</param>
        /// 
        /// <returns>The response from the CreateOutboundExternalLink service method, as returned by RTBFabric.</returns>
        /// <exception cref="Amazon.RTBFabric.Model.AccessDeniedException">
        /// The request could not be completed because you do not have sufficient access to perform
        /// this action.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.InternalServerException">
        /// The request could not be completed because of an internal server error. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ResourceNotFoundException">
        /// The request could not be completed because the resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ServiceQuotaExceededException">
        /// The request could not be completed because you exceeded a service quota.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ValidationException">
        /// The request could not be completed because it fails satisfy the constraints specified
        /// by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/CreateOutboundExternalLink">REST API Reference for CreateOutboundExternalLink Operation</seealso>
        CreateOutboundExternalLinkResponse CreateOutboundExternalLink(CreateOutboundExternalLinkRequest request);



        /// <summary>
        /// Creates an outbound external link.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateOutboundExternalLink service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateOutboundExternalLink service method, as returned by RTBFabric.</returns>
        /// <exception cref="Amazon.RTBFabric.Model.AccessDeniedException">
        /// The request could not be completed because you do not have sufficient access to perform
        /// this action.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.InternalServerException">
        /// The request could not be completed because of an internal server error. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ResourceNotFoundException">
        /// The request could not be completed because the resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ServiceQuotaExceededException">
        /// The request could not be completed because you exceeded a service quota.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ValidationException">
        /// The request could not be completed because it fails satisfy the constraints specified
        /// by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/CreateOutboundExternalLink">REST API Reference for CreateOutboundExternalLink Operation</seealso>
        Task<CreateOutboundExternalLinkResponse> CreateOutboundExternalLinkAsync(CreateOutboundExternalLinkRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateRequesterGateway


        /// <summary>
        /// Creates a requester gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRequesterGateway service method.</param>
        /// 
        /// <returns>The response from the CreateRequesterGateway service method, as returned by RTBFabric.</returns>
        /// <exception cref="Amazon.RTBFabric.Model.AccessDeniedException">
        /// The request could not be completed because you do not have sufficient access to perform
        /// this action.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.InternalServerException">
        /// The request could not be completed because of an internal server error. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ResourceNotFoundException">
        /// The request could not be completed because the resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ServiceQuotaExceededException">
        /// The request could not be completed because you exceeded a service quota.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ValidationException">
        /// The request could not be completed because it fails satisfy the constraints specified
        /// by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/CreateRequesterGateway">REST API Reference for CreateRequesterGateway Operation</seealso>
        CreateRequesterGatewayResponse CreateRequesterGateway(CreateRequesterGatewayRequest request);



        /// <summary>
        /// Creates a requester gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRequesterGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRequesterGateway service method, as returned by RTBFabric.</returns>
        /// <exception cref="Amazon.RTBFabric.Model.AccessDeniedException">
        /// The request could not be completed because you do not have sufficient access to perform
        /// this action.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.InternalServerException">
        /// The request could not be completed because of an internal server error. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ResourceNotFoundException">
        /// The request could not be completed because the resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ServiceQuotaExceededException">
        /// The request could not be completed because you exceeded a service quota.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ValidationException">
        /// The request could not be completed because it fails satisfy the constraints specified
        /// by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/CreateRequesterGateway">REST API Reference for CreateRequesterGateway Operation</seealso>
        Task<CreateRequesterGatewayResponse> CreateRequesterGatewayAsync(CreateRequesterGatewayRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateResponderGateway


        /// <summary>
        /// Creates a responder gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateResponderGateway service method.</param>
        /// 
        /// <returns>The response from the CreateResponderGateway service method, as returned by RTBFabric.</returns>
        /// <exception cref="Amazon.RTBFabric.Model.AccessDeniedException">
        /// The request could not be completed because you do not have sufficient access to perform
        /// this action.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.InternalServerException">
        /// The request could not be completed because of an internal server error. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ResourceNotFoundException">
        /// The request could not be completed because the resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ServiceQuotaExceededException">
        /// The request could not be completed because you exceeded a service quota.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ValidationException">
        /// The request could not be completed because it fails satisfy the constraints specified
        /// by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/CreateResponderGateway">REST API Reference for CreateResponderGateway Operation</seealso>
        CreateResponderGatewayResponse CreateResponderGateway(CreateResponderGatewayRequest request);



        /// <summary>
        /// Creates a responder gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateResponderGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateResponderGateway service method, as returned by RTBFabric.</returns>
        /// <exception cref="Amazon.RTBFabric.Model.AccessDeniedException">
        /// The request could not be completed because you do not have sufficient access to perform
        /// this action.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.InternalServerException">
        /// The request could not be completed because of an internal server error. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ResourceNotFoundException">
        /// The request could not be completed because the resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ServiceQuotaExceededException">
        /// The request could not be completed because you exceeded a service quota.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ValidationException">
        /// The request could not be completed because it fails satisfy the constraints specified
        /// by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/CreateResponderGateway">REST API Reference for CreateResponderGateway Operation</seealso>
        Task<CreateResponderGatewayResponse> CreateResponderGatewayAsync(CreateResponderGatewayRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteInboundExternalLink


        /// <summary>
        /// Deletes an inbound external link.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInboundExternalLink service method.</param>
        /// 
        /// <returns>The response from the DeleteInboundExternalLink service method, as returned by RTBFabric.</returns>
        /// <exception cref="Amazon.RTBFabric.Model.AccessDeniedException">
        /// The request could not be completed because you do not have sufficient access to perform
        /// this action.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ConflictException">
        /// The request could not be completed because of a conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.InternalServerException">
        /// The request could not be completed because of an internal server error. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ResourceNotFoundException">
        /// The request could not be completed because the resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ValidationException">
        /// The request could not be completed because it fails satisfy the constraints specified
        /// by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/DeleteInboundExternalLink">REST API Reference for DeleteInboundExternalLink Operation</seealso>
        DeleteInboundExternalLinkResponse DeleteInboundExternalLink(DeleteInboundExternalLinkRequest request);



        /// <summary>
        /// Deletes an inbound external link.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInboundExternalLink service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteInboundExternalLink service method, as returned by RTBFabric.</returns>
        /// <exception cref="Amazon.RTBFabric.Model.AccessDeniedException">
        /// The request could not be completed because you do not have sufficient access to perform
        /// this action.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ConflictException">
        /// The request could not be completed because of a conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.InternalServerException">
        /// The request could not be completed because of an internal server error. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ResourceNotFoundException">
        /// The request could not be completed because the resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ValidationException">
        /// The request could not be completed because it fails satisfy the constraints specified
        /// by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/DeleteInboundExternalLink">REST API Reference for DeleteInboundExternalLink Operation</seealso>
        Task<DeleteInboundExternalLinkResponse> DeleteInboundExternalLinkAsync(DeleteInboundExternalLinkRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteLink


        /// <summary>
        /// Deletes a link between RTB applications.
        /// 
        ///  
        /// <para>
        /// Permanently removes the connection between RTB applications. This action cannot be
        /// undone.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLink service method.</param>
        /// 
        /// <returns>The response from the DeleteLink service method, as returned by RTBFabric.</returns>
        /// <exception cref="Amazon.RTBFabric.Model.AccessDeniedException">
        /// The request could not be completed because you do not have sufficient access to perform
        /// this action.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ConflictException">
        /// The request could not be completed because of a conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.InternalServerException">
        /// The request could not be completed because of an internal server error. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ResourceNotFoundException">
        /// The request could not be completed because the resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ValidationException">
        /// The request could not be completed because it fails satisfy the constraints specified
        /// by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/DeleteLink">REST API Reference for DeleteLink Operation</seealso>
        DeleteLinkResponse DeleteLink(DeleteLinkRequest request);



        /// <summary>
        /// Deletes a link between RTB applications.
        /// 
        ///  
        /// <para>
        /// Permanently removes the connection between RTB applications. This action cannot be
        /// undone.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLink service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteLink service method, as returned by RTBFabric.</returns>
        /// <exception cref="Amazon.RTBFabric.Model.AccessDeniedException">
        /// The request could not be completed because you do not have sufficient access to perform
        /// this action.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ConflictException">
        /// The request could not be completed because of a conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.InternalServerException">
        /// The request could not be completed because of an internal server error. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ResourceNotFoundException">
        /// The request could not be completed because the resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ValidationException">
        /// The request could not be completed because it fails satisfy the constraints specified
        /// by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/DeleteLink">REST API Reference for DeleteLink Operation</seealso>
        Task<DeleteLinkResponse> DeleteLinkAsync(DeleteLinkRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteOutboundExternalLink


        /// <summary>
        /// Deletes an outbound external link.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteOutboundExternalLink service method.</param>
        /// 
        /// <returns>The response from the DeleteOutboundExternalLink service method, as returned by RTBFabric.</returns>
        /// <exception cref="Amazon.RTBFabric.Model.AccessDeniedException">
        /// The request could not be completed because you do not have sufficient access to perform
        /// this action.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ConflictException">
        /// The request could not be completed because of a conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.InternalServerException">
        /// The request could not be completed because of an internal server error. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ResourceNotFoundException">
        /// The request could not be completed because the resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ValidationException">
        /// The request could not be completed because it fails satisfy the constraints specified
        /// by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/DeleteOutboundExternalLink">REST API Reference for DeleteOutboundExternalLink Operation</seealso>
        DeleteOutboundExternalLinkResponse DeleteOutboundExternalLink(DeleteOutboundExternalLinkRequest request);



        /// <summary>
        /// Deletes an outbound external link.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteOutboundExternalLink service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteOutboundExternalLink service method, as returned by RTBFabric.</returns>
        /// <exception cref="Amazon.RTBFabric.Model.AccessDeniedException">
        /// The request could not be completed because you do not have sufficient access to perform
        /// this action.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ConflictException">
        /// The request could not be completed because of a conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.InternalServerException">
        /// The request could not be completed because of an internal server error. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ResourceNotFoundException">
        /// The request could not be completed because the resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ValidationException">
        /// The request could not be completed because it fails satisfy the constraints specified
        /// by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/DeleteOutboundExternalLink">REST API Reference for DeleteOutboundExternalLink Operation</seealso>
        Task<DeleteOutboundExternalLinkResponse> DeleteOutboundExternalLinkAsync(DeleteOutboundExternalLinkRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteRequesterGateway


        /// <summary>
        /// Deletes a requester gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRequesterGateway service method.</param>
        /// 
        /// <returns>The response from the DeleteRequesterGateway service method, as returned by RTBFabric.</returns>
        /// <exception cref="Amazon.RTBFabric.Model.AccessDeniedException">
        /// The request could not be completed because you do not have sufficient access to perform
        /// this action.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.InternalServerException">
        /// The request could not be completed because of an internal server error. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ResourceNotFoundException">
        /// The request could not be completed because the resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ValidationException">
        /// The request could not be completed because it fails satisfy the constraints specified
        /// by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/DeleteRequesterGateway">REST API Reference for DeleteRequesterGateway Operation</seealso>
        DeleteRequesterGatewayResponse DeleteRequesterGateway(DeleteRequesterGatewayRequest request);



        /// <summary>
        /// Deletes a requester gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRequesterGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRequesterGateway service method, as returned by RTBFabric.</returns>
        /// <exception cref="Amazon.RTBFabric.Model.AccessDeniedException">
        /// The request could not be completed because you do not have sufficient access to perform
        /// this action.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.InternalServerException">
        /// The request could not be completed because of an internal server error. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ResourceNotFoundException">
        /// The request could not be completed because the resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ValidationException">
        /// The request could not be completed because it fails satisfy the constraints specified
        /// by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/DeleteRequesterGateway">REST API Reference for DeleteRequesterGateway Operation</seealso>
        Task<DeleteRequesterGatewayResponse> DeleteRequesterGatewayAsync(DeleteRequesterGatewayRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteResponderGateway


        /// <summary>
        /// Deletes a responder gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResponderGateway service method.</param>
        /// 
        /// <returns>The response from the DeleteResponderGateway service method, as returned by RTBFabric.</returns>
        /// <exception cref="Amazon.RTBFabric.Model.AccessDeniedException">
        /// The request could not be completed because you do not have sufficient access to perform
        /// this action.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.InternalServerException">
        /// The request could not be completed because of an internal server error. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ResourceNotFoundException">
        /// The request could not be completed because the resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ValidationException">
        /// The request could not be completed because it fails satisfy the constraints specified
        /// by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/DeleteResponderGateway">REST API Reference for DeleteResponderGateway Operation</seealso>
        DeleteResponderGatewayResponse DeleteResponderGateway(DeleteResponderGatewayRequest request);



        /// <summary>
        /// Deletes a responder gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResponderGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteResponderGateway service method, as returned by RTBFabric.</returns>
        /// <exception cref="Amazon.RTBFabric.Model.AccessDeniedException">
        /// The request could not be completed because you do not have sufficient access to perform
        /// this action.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.InternalServerException">
        /// The request could not be completed because of an internal server error. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ResourceNotFoundException">
        /// The request could not be completed because the resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ValidationException">
        /// The request could not be completed because it fails satisfy the constraints specified
        /// by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/DeleteResponderGateway">REST API Reference for DeleteResponderGateway Operation</seealso>
        Task<DeleteResponderGatewayResponse> DeleteResponderGatewayAsync(DeleteResponderGatewayRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetInboundExternalLink


        /// <summary>
        /// Retrieves information about an inbound external link.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInboundExternalLink service method.</param>
        /// 
        /// <returns>The response from the GetInboundExternalLink service method, as returned by RTBFabric.</returns>
        /// <exception cref="Amazon.RTBFabric.Model.AccessDeniedException">
        /// The request could not be completed because you do not have sufficient access to perform
        /// this action.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.InternalServerException">
        /// The request could not be completed because of an internal server error. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ResourceNotFoundException">
        /// The request could not be completed because the resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ValidationException">
        /// The request could not be completed because it fails satisfy the constraints specified
        /// by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/GetInboundExternalLink">REST API Reference for GetInboundExternalLink Operation</seealso>
        GetInboundExternalLinkResponse GetInboundExternalLink(GetInboundExternalLinkRequest request);



        /// <summary>
        /// Retrieves information about an inbound external link.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInboundExternalLink service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetInboundExternalLink service method, as returned by RTBFabric.</returns>
        /// <exception cref="Amazon.RTBFabric.Model.AccessDeniedException">
        /// The request could not be completed because you do not have sufficient access to perform
        /// this action.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.InternalServerException">
        /// The request could not be completed because of an internal server error. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ResourceNotFoundException">
        /// The request could not be completed because the resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ValidationException">
        /// The request could not be completed because it fails satisfy the constraints specified
        /// by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/GetInboundExternalLink">REST API Reference for GetInboundExternalLink Operation</seealso>
        Task<GetInboundExternalLinkResponse> GetInboundExternalLinkAsync(GetInboundExternalLinkRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetLink


        /// <summary>
        /// Retrieves information about a link between RTB applications.
        /// 
        ///  
        /// <para>
        /// Returns detailed information about the link configuration, status, and associated
        /// RTB applications.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLink service method.</param>
        /// 
        /// <returns>The response from the GetLink service method, as returned by RTBFabric.</returns>
        /// <exception cref="Amazon.RTBFabric.Model.AccessDeniedException">
        /// The request could not be completed because you do not have sufficient access to perform
        /// this action.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ConflictException">
        /// The request could not be completed because of a conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.InternalServerException">
        /// The request could not be completed because of an internal server error. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ResourceNotFoundException">
        /// The request could not be completed because the resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ValidationException">
        /// The request could not be completed because it fails satisfy the constraints specified
        /// by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/GetLink">REST API Reference for GetLink Operation</seealso>
        GetLinkResponse GetLink(GetLinkRequest request);



        /// <summary>
        /// Retrieves information about a link between RTB applications.
        /// 
        ///  
        /// <para>
        /// Returns detailed information about the link configuration, status, and associated
        /// RTB applications.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLink service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetLink service method, as returned by RTBFabric.</returns>
        /// <exception cref="Amazon.RTBFabric.Model.AccessDeniedException">
        /// The request could not be completed because you do not have sufficient access to perform
        /// this action.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ConflictException">
        /// The request could not be completed because of a conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.InternalServerException">
        /// The request could not be completed because of an internal server error. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ResourceNotFoundException">
        /// The request could not be completed because the resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ValidationException">
        /// The request could not be completed because it fails satisfy the constraints specified
        /// by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/GetLink">REST API Reference for GetLink Operation</seealso>
        Task<GetLinkResponse> GetLinkAsync(GetLinkRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetOutboundExternalLink


        /// <summary>
        /// Retrieves information about an outbound external link.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOutboundExternalLink service method.</param>
        /// 
        /// <returns>The response from the GetOutboundExternalLink service method, as returned by RTBFabric.</returns>
        /// <exception cref="Amazon.RTBFabric.Model.AccessDeniedException">
        /// The request could not be completed because you do not have sufficient access to perform
        /// this action.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.InternalServerException">
        /// The request could not be completed because of an internal server error. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ResourceNotFoundException">
        /// The request could not be completed because the resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ValidationException">
        /// The request could not be completed because it fails satisfy the constraints specified
        /// by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/GetOutboundExternalLink">REST API Reference for GetOutboundExternalLink Operation</seealso>
        GetOutboundExternalLinkResponse GetOutboundExternalLink(GetOutboundExternalLinkRequest request);



        /// <summary>
        /// Retrieves information about an outbound external link.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOutboundExternalLink service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetOutboundExternalLink service method, as returned by RTBFabric.</returns>
        /// <exception cref="Amazon.RTBFabric.Model.AccessDeniedException">
        /// The request could not be completed because you do not have sufficient access to perform
        /// this action.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.InternalServerException">
        /// The request could not be completed because of an internal server error. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ResourceNotFoundException">
        /// The request could not be completed because the resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ValidationException">
        /// The request could not be completed because it fails satisfy the constraints specified
        /// by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/GetOutboundExternalLink">REST API Reference for GetOutboundExternalLink Operation</seealso>
        Task<GetOutboundExternalLinkResponse> GetOutboundExternalLinkAsync(GetOutboundExternalLinkRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetRequesterGateway


        /// <summary>
        /// Retrieves information about a requester gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRequesterGateway service method.</param>
        /// 
        /// <returns>The response from the GetRequesterGateway service method, as returned by RTBFabric.</returns>
        /// <exception cref="Amazon.RTBFabric.Model.AccessDeniedException">
        /// The request could not be completed because you do not have sufficient access to perform
        /// this action.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.InternalServerException">
        /// The request could not be completed because of an internal server error. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ResourceNotFoundException">
        /// The request could not be completed because the resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ValidationException">
        /// The request could not be completed because it fails satisfy the constraints specified
        /// by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/GetRequesterGateway">REST API Reference for GetRequesterGateway Operation</seealso>
        GetRequesterGatewayResponse GetRequesterGateway(GetRequesterGatewayRequest request);



        /// <summary>
        /// Retrieves information about a requester gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRequesterGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRequesterGateway service method, as returned by RTBFabric.</returns>
        /// <exception cref="Amazon.RTBFabric.Model.AccessDeniedException">
        /// The request could not be completed because you do not have sufficient access to perform
        /// this action.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.InternalServerException">
        /// The request could not be completed because of an internal server error. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ResourceNotFoundException">
        /// The request could not be completed because the resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ValidationException">
        /// The request could not be completed because it fails satisfy the constraints specified
        /// by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/GetRequesterGateway">REST API Reference for GetRequesterGateway Operation</seealso>
        Task<GetRequesterGatewayResponse> GetRequesterGatewayAsync(GetRequesterGatewayRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetResponderGateway


        /// <summary>
        /// Retrieves information about a responder gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResponderGateway service method.</param>
        /// 
        /// <returns>The response from the GetResponderGateway service method, as returned by RTBFabric.</returns>
        /// <exception cref="Amazon.RTBFabric.Model.AccessDeniedException">
        /// The request could not be completed because you do not have sufficient access to perform
        /// this action.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.InternalServerException">
        /// The request could not be completed because of an internal server error. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ResourceNotFoundException">
        /// The request could not be completed because the resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ValidationException">
        /// The request could not be completed because it fails satisfy the constraints specified
        /// by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/GetResponderGateway">REST API Reference for GetResponderGateway Operation</seealso>
        GetResponderGatewayResponse GetResponderGateway(GetResponderGatewayRequest request);



        /// <summary>
        /// Retrieves information about a responder gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResponderGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetResponderGateway service method, as returned by RTBFabric.</returns>
        /// <exception cref="Amazon.RTBFabric.Model.AccessDeniedException">
        /// The request could not be completed because you do not have sufficient access to perform
        /// this action.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.InternalServerException">
        /// The request could not be completed because of an internal server error. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ResourceNotFoundException">
        /// The request could not be completed because the resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ValidationException">
        /// The request could not be completed because it fails satisfy the constraints specified
        /// by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/GetResponderGateway">REST API Reference for GetResponderGateway Operation</seealso>
        Task<GetResponderGatewayResponse> GetResponderGatewayAsync(GetResponderGatewayRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListLinks


        /// <summary>
        /// Lists links associated with an RTB application.
        /// 
        ///  
        /// <para>
        /// Returns a list of all links for the specified RTB application, including their status
        /// and configuration details.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLinks service method.</param>
        /// 
        /// <returns>The response from the ListLinks service method, as returned by RTBFabric.</returns>
        /// <exception cref="Amazon.RTBFabric.Model.AccessDeniedException">
        /// The request could not be completed because you do not have sufficient access to perform
        /// this action.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.InternalServerException">
        /// The request could not be completed because of an internal server error. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ResourceNotFoundException">
        /// The request could not be completed because the resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ValidationException">
        /// The request could not be completed because it fails satisfy the constraints specified
        /// by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/ListLinks">REST API Reference for ListLinks Operation</seealso>
        ListLinksResponse ListLinks(ListLinksRequest request);



        /// <summary>
        /// Lists links associated with an RTB application.
        /// 
        ///  
        /// <para>
        /// Returns a list of all links for the specified RTB application, including their status
        /// and configuration details.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLinks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListLinks service method, as returned by RTBFabric.</returns>
        /// <exception cref="Amazon.RTBFabric.Model.AccessDeniedException">
        /// The request could not be completed because you do not have sufficient access to perform
        /// this action.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.InternalServerException">
        /// The request could not be completed because of an internal server error. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ResourceNotFoundException">
        /// The request could not be completed because the resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ValidationException">
        /// The request could not be completed because it fails satisfy the constraints specified
        /// by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/ListLinks">REST API Reference for ListLinks Operation</seealso>
        Task<ListLinksResponse> ListLinksAsync(ListLinksRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListRequesterGateways


        /// <summary>
        /// Lists requester gateways.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRequesterGateways service method.</param>
        /// 
        /// <returns>The response from the ListRequesterGateways service method, as returned by RTBFabric.</returns>
        /// <exception cref="Amazon.RTBFabric.Model.InternalServerException">
        /// The request could not be completed because of an internal server error. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ValidationException">
        /// The request could not be completed because it fails satisfy the constraints specified
        /// by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/ListRequesterGateways">REST API Reference for ListRequesterGateways Operation</seealso>
        ListRequesterGatewaysResponse ListRequesterGateways(ListRequesterGatewaysRequest request);



        /// <summary>
        /// Lists requester gateways.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRequesterGateways service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRequesterGateways service method, as returned by RTBFabric.</returns>
        /// <exception cref="Amazon.RTBFabric.Model.InternalServerException">
        /// The request could not be completed because of an internal server error. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ValidationException">
        /// The request could not be completed because it fails satisfy the constraints specified
        /// by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/ListRequesterGateways">REST API Reference for ListRequesterGateways Operation</seealso>
        Task<ListRequesterGatewaysResponse> ListRequesterGatewaysAsync(ListRequesterGatewaysRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListResponderGateways


        /// <summary>
        /// Lists reponder gateways.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResponderGateways service method.</param>
        /// 
        /// <returns>The response from the ListResponderGateways service method, as returned by RTBFabric.</returns>
        /// <exception cref="Amazon.RTBFabric.Model.InternalServerException">
        /// The request could not be completed because of an internal server error. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ValidationException">
        /// The request could not be completed because it fails satisfy the constraints specified
        /// by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/ListResponderGateways">REST API Reference for ListResponderGateways Operation</seealso>
        ListResponderGatewaysResponse ListResponderGateways(ListResponderGatewaysRequest request);



        /// <summary>
        /// Lists reponder gateways.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResponderGateways service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListResponderGateways service method, as returned by RTBFabric.</returns>
        /// <exception cref="Amazon.RTBFabric.Model.InternalServerException">
        /// The request could not be completed because of an internal server error. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ValidationException">
        /// The request could not be completed because it fails satisfy the constraints specified
        /// by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/ListResponderGateways">REST API Reference for ListResponderGateways Operation</seealso>
        Task<ListResponderGatewaysResponse> ListResponderGatewaysAsync(ListResponderGatewaysRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists tags for a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by RTBFabric.</returns>
        /// <exception cref="Amazon.RTBFabric.Model.AccessDeniedException">
        /// The request could not be completed because you do not have sufficient access to perform
        /// this action.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.InternalServerException">
        /// The request could not be completed because of an internal server error. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ResourceNotFoundException">
        /// The request could not be completed because the resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ValidationException">
        /// The request could not be completed because it fails satisfy the constraints specified
        /// by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);



        /// <summary>
        /// Lists tags for a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by RTBFabric.</returns>
        /// <exception cref="Amazon.RTBFabric.Model.AccessDeniedException">
        /// The request could not be completed because you do not have sufficient access to perform
        /// this action.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.InternalServerException">
        /// The request could not be completed because of an internal server error. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ResourceNotFoundException">
        /// The request could not be completed because the resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ValidationException">
        /// The request could not be completed because it fails satisfy the constraints specified
        /// by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RejectLink


        /// <summary>
        /// Rejects a link request between RTB applications.
        /// 
        ///  
        /// <para>
        /// When a requester RTB application requests to link with a responder RTB application,
        /// the responder can use this operation to decline the link request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RejectLink service method.</param>
        /// 
        /// <returns>The response from the RejectLink service method, as returned by RTBFabric.</returns>
        /// <exception cref="Amazon.RTBFabric.Model.AccessDeniedException">
        /// The request could not be completed because you do not have sufficient access to perform
        /// this action.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ConflictException">
        /// The request could not be completed because of a conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.InternalServerException">
        /// The request could not be completed because of an internal server error. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ResourceNotFoundException">
        /// The request could not be completed because the resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ValidationException">
        /// The request could not be completed because it fails satisfy the constraints specified
        /// by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/RejectLink">REST API Reference for RejectLink Operation</seealso>
        RejectLinkResponse RejectLink(RejectLinkRequest request);



        /// <summary>
        /// Rejects a link request between RTB applications.
        /// 
        ///  
        /// <para>
        /// When a requester RTB application requests to link with a responder RTB application,
        /// the responder can use this operation to decline the link request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RejectLink service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RejectLink service method, as returned by RTBFabric.</returns>
        /// <exception cref="Amazon.RTBFabric.Model.AccessDeniedException">
        /// The request could not be completed because you do not have sufficient access to perform
        /// this action.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ConflictException">
        /// The request could not be completed because of a conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.InternalServerException">
        /// The request could not be completed because of an internal server error. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ResourceNotFoundException">
        /// The request could not be completed because the resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ValidationException">
        /// The request could not be completed because it fails satisfy the constraints specified
        /// by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/RejectLink">REST API Reference for RejectLink Operation</seealso>
        Task<RejectLinkResponse> RejectLinkAsync(RejectLinkRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Assigns one or more tags (key-value pairs) to the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by RTBFabric.</returns>
        /// <exception cref="Amazon.RTBFabric.Model.AccessDeniedException">
        /// The request could not be completed because you do not have sufficient access to perform
        /// this action.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.InternalServerException">
        /// The request could not be completed because of an internal server error. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ResourceNotFoundException">
        /// The request could not be completed because the resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ValidationException">
        /// The request could not be completed because it fails satisfy the constraints specified
        /// by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);



        /// <summary>
        /// Assigns one or more tags (key-value pairs) to the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by RTBFabric.</returns>
        /// <exception cref="Amazon.RTBFabric.Model.AccessDeniedException">
        /// The request could not be completed because you do not have sufficient access to perform
        /// this action.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.InternalServerException">
        /// The request could not be completed because of an internal server error. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ResourceNotFoundException">
        /// The request could not be completed because the resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ValidationException">
        /// The request could not be completed because it fails satisfy the constraints specified
        /// by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes a tag or tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by RTBFabric.</returns>
        /// <exception cref="Amazon.RTBFabric.Model.AccessDeniedException">
        /// The request could not be completed because you do not have sufficient access to perform
        /// this action.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.InternalServerException">
        /// The request could not be completed because of an internal server error. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ResourceNotFoundException">
        /// The request could not be completed because the resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ValidationException">
        /// The request could not be completed because it fails satisfy the constraints specified
        /// by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);



        /// <summary>
        /// Removes a tag or tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by RTBFabric.</returns>
        /// <exception cref="Amazon.RTBFabric.Model.AccessDeniedException">
        /// The request could not be completed because you do not have sufficient access to perform
        /// this action.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.InternalServerException">
        /// The request could not be completed because of an internal server error. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ResourceNotFoundException">
        /// The request could not be completed because the resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ValidationException">
        /// The request could not be completed because it fails satisfy the constraints specified
        /// by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateLink


        /// <summary>
        /// Updates the configuration of a link between RTB applications.
        /// 
        ///  
        /// <para>
        /// Allows you to modify settings and parameters for an existing link.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLink service method.</param>
        /// 
        /// <returns>The response from the UpdateLink service method, as returned by RTBFabric.</returns>
        /// <exception cref="Amazon.RTBFabric.Model.AccessDeniedException">
        /// The request could not be completed because you do not have sufficient access to perform
        /// this action.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ConflictException">
        /// The request could not be completed because of a conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.InternalServerException">
        /// The request could not be completed because of an internal server error. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ResourceNotFoundException">
        /// The request could not be completed because the resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ValidationException">
        /// The request could not be completed because it fails satisfy the constraints specified
        /// by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/UpdateLink">REST API Reference for UpdateLink Operation</seealso>
        UpdateLinkResponse UpdateLink(UpdateLinkRequest request);



        /// <summary>
        /// Updates the configuration of a link between RTB applications.
        /// 
        ///  
        /// <para>
        /// Allows you to modify settings and parameters for an existing link.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLink service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateLink service method, as returned by RTBFabric.</returns>
        /// <exception cref="Amazon.RTBFabric.Model.AccessDeniedException">
        /// The request could not be completed because you do not have sufficient access to perform
        /// this action.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ConflictException">
        /// The request could not be completed because of a conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.InternalServerException">
        /// The request could not be completed because of an internal server error. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ResourceNotFoundException">
        /// The request could not be completed because the resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ValidationException">
        /// The request could not be completed because it fails satisfy the constraints specified
        /// by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/UpdateLink">REST API Reference for UpdateLink Operation</seealso>
        Task<UpdateLinkResponse> UpdateLinkAsync(UpdateLinkRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateLinkModuleFlow


        /// <summary>
        /// Updates a link module flow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLinkModuleFlow service method.</param>
        /// 
        /// <returns>The response from the UpdateLinkModuleFlow service method, as returned by RTBFabric.</returns>
        /// <exception cref="Amazon.RTBFabric.Model.AccessDeniedException">
        /// The request could not be completed because you do not have sufficient access to perform
        /// this action.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ConflictException">
        /// The request could not be completed because of a conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.InternalServerException">
        /// The request could not be completed because of an internal server error. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ResourceNotFoundException">
        /// The request could not be completed because the resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ServiceQuotaExceededException">
        /// The request could not be completed because you exceeded a service quota.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ValidationException">
        /// The request could not be completed because it fails satisfy the constraints specified
        /// by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/UpdateLinkModuleFlow">REST API Reference for UpdateLinkModuleFlow Operation</seealso>
        UpdateLinkModuleFlowResponse UpdateLinkModuleFlow(UpdateLinkModuleFlowRequest request);



        /// <summary>
        /// Updates a link module flow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLinkModuleFlow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateLinkModuleFlow service method, as returned by RTBFabric.</returns>
        /// <exception cref="Amazon.RTBFabric.Model.AccessDeniedException">
        /// The request could not be completed because you do not have sufficient access to perform
        /// this action.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ConflictException">
        /// The request could not be completed because of a conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.InternalServerException">
        /// The request could not be completed because of an internal server error. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ResourceNotFoundException">
        /// The request could not be completed because the resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ServiceQuotaExceededException">
        /// The request could not be completed because you exceeded a service quota.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ValidationException">
        /// The request could not be completed because it fails satisfy the constraints specified
        /// by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/UpdateLinkModuleFlow">REST API Reference for UpdateLinkModuleFlow Operation</seealso>
        Task<UpdateLinkModuleFlowResponse> UpdateLinkModuleFlowAsync(UpdateLinkModuleFlowRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateRequesterGateway


        /// <summary>
        /// Updates a requester gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRequesterGateway service method.</param>
        /// 
        /// <returns>The response from the UpdateRequesterGateway service method, as returned by RTBFabric.</returns>
        /// <exception cref="Amazon.RTBFabric.Model.AccessDeniedException">
        /// The request could not be completed because you do not have sufficient access to perform
        /// this action.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ConflictException">
        /// The request could not be completed because of a conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.InternalServerException">
        /// The request could not be completed because of an internal server error. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ResourceNotFoundException">
        /// The request could not be completed because the resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ValidationException">
        /// The request could not be completed because it fails satisfy the constraints specified
        /// by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/UpdateRequesterGateway">REST API Reference for UpdateRequesterGateway Operation</seealso>
        UpdateRequesterGatewayResponse UpdateRequesterGateway(UpdateRequesterGatewayRequest request);



        /// <summary>
        /// Updates a requester gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRequesterGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateRequesterGateway service method, as returned by RTBFabric.</returns>
        /// <exception cref="Amazon.RTBFabric.Model.AccessDeniedException">
        /// The request could not be completed because you do not have sufficient access to perform
        /// this action.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ConflictException">
        /// The request could not be completed because of a conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.InternalServerException">
        /// The request could not be completed because of an internal server error. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ResourceNotFoundException">
        /// The request could not be completed because the resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ValidationException">
        /// The request could not be completed because it fails satisfy the constraints specified
        /// by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/UpdateRequesterGateway">REST API Reference for UpdateRequesterGateway Operation</seealso>
        Task<UpdateRequesterGatewayResponse> UpdateRequesterGatewayAsync(UpdateRequesterGatewayRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateResponderGateway


        /// <summary>
        /// Updates a responder gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateResponderGateway service method.</param>
        /// 
        /// <returns>The response from the UpdateResponderGateway service method, as returned by RTBFabric.</returns>
        /// <exception cref="Amazon.RTBFabric.Model.AccessDeniedException">
        /// The request could not be completed because you do not have sufficient access to perform
        /// this action.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ConflictException">
        /// The request could not be completed because of a conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.InternalServerException">
        /// The request could not be completed because of an internal server error. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ResourceNotFoundException">
        /// The request could not be completed because the resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ValidationException">
        /// The request could not be completed because it fails satisfy the constraints specified
        /// by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/UpdateResponderGateway">REST API Reference for UpdateResponderGateway Operation</seealso>
        UpdateResponderGatewayResponse UpdateResponderGateway(UpdateResponderGatewayRequest request);



        /// <summary>
        /// Updates a responder gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateResponderGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateResponderGateway service method, as returned by RTBFabric.</returns>
        /// <exception cref="Amazon.RTBFabric.Model.AccessDeniedException">
        /// The request could not be completed because you do not have sufficient access to perform
        /// this action.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ConflictException">
        /// The request could not be completed because of a conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.InternalServerException">
        /// The request could not be completed because of an internal server error. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ResourceNotFoundException">
        /// The request could not be completed because the resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ValidationException">
        /// The request could not be completed because it fails satisfy the constraints specified
        /// by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/UpdateResponderGateway">REST API Reference for UpdateResponderGateway Operation</seealso>
        Task<UpdateResponderGatewayResponse> UpdateResponderGatewayAsync(UpdateResponderGatewayRequest request, CancellationToken cancellationToken = default(CancellationToken));

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