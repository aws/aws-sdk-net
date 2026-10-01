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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

#if NETFRAMEWORK
        /// <summary>
        /// Accepts a link request between gateways.
        /// 
        ///  
        /// <para>
        /// When a requester gateway requests to link with a responder gateway, the responder
        /// can use this operation to accept the link request and establish the connection.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptLink service method.</param>
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
#endif

        /// <summary>
        /// Accepts a link request between gateways.
        /// 
        ///  
        /// <para>
        /// When a requester gateway requests to link with a responder gateway, the responder
        /// can use this operation to accept the link request and establish the connection.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptLink service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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

#if NETFRAMEWORK
        /// <summary>
        /// Associates an ACM certificate with a responder gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateCertificate service method.</param>
        /// <returns>The response from the AssociateCertificate service method, as returned by RTBFabric.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/AssociateCertificate">REST API Reference for AssociateCertificate Operation</seealso>
        AssociateCertificateResponse AssociateCertificate(AssociateCertificateRequest request);
#endif

        /// <summary>
        /// Associates an ACM certificate with a responder gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateCertificate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the AssociateCertificate service method, as returned by RTBFabric.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/AssociateCertificate">REST API Reference for AssociateCertificate Operation</seealso>
        Task<AssociateCertificateResponse> AssociateCertificateAsync(AssociateCertificateRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Creates an inbound external link.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateInboundExternalLink service method.</param>
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
#endif

        /// <summary>
        /// Creates an inbound external link.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateInboundExternalLink service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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

#if NETFRAMEWORK
        /// <summary>
        /// Creates a new link between gateways.
        /// 
        ///  
        /// <para>
        /// Establishes a connection that allows gateways to communicate and exchange bid requests
        /// and responses.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLink service method.</param>
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
#endif

        /// <summary>
        /// Creates a new link between gateways.
        /// 
        ///  
        /// <para>
        /// Establishes a connection that allows gateways to communicate and exchange bid requests
        /// and responses.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLink service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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

#if NETFRAMEWORK
        /// <summary>
        /// Creates a routing rule for a link.
        /// 
        ///  
        /// <para>
        /// Routing rules use priority-based evaluation where lower priority numbers are evaluated
        /// first. Each rule specifies conditions that must all match for the rule to apply.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLinkRoutingRule service method.</param>
        /// <returns>The response from the CreateLinkRoutingRule service method, as returned by RTBFabric.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/CreateLinkRoutingRule">REST API Reference for CreateLinkRoutingRule Operation</seealso>
        CreateLinkRoutingRuleResponse CreateLinkRoutingRule(CreateLinkRoutingRuleRequest request);
#endif

        /// <summary>
        /// Creates a routing rule for a link.
        /// 
        ///  
        /// <para>
        /// Routing rules use priority-based evaluation where lower priority numbers are evaluated
        /// first. Each rule specifies conditions that must all match for the rule to apply.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLinkRoutingRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateLinkRoutingRule service method, as returned by RTBFabric.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/CreateLinkRoutingRule">REST API Reference for CreateLinkRoutingRule Operation</seealso>
        Task<CreateLinkRoutingRuleResponse> CreateLinkRoutingRuleAsync(CreateLinkRoutingRuleRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Creates an outbound external link.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateOutboundExternalLink service method.</param>
        /// <returns>The response from the CreateOutboundExternalLink service method, as returned by RTBFabric.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/CreateOutboundExternalLink">REST API Reference for CreateOutboundExternalLink Operation</seealso>
        CreateOutboundExternalLinkResponse CreateOutboundExternalLink(CreateOutboundExternalLinkRequest request);
#endif

        /// <summary>
        /// Creates an outbound external link.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateOutboundExternalLink service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateOutboundExternalLink service method, as returned by RTBFabric.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/CreateOutboundExternalLink">REST API Reference for CreateOutboundExternalLink Operation</seealso>
        Task<CreateOutboundExternalLinkResponse> CreateOutboundExternalLinkAsync(CreateOutboundExternalLinkRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Creates a requester gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRequesterGateway service method.</param>
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
#endif

        /// <summary>
        /// Creates a requester gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRequesterGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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

#if NETFRAMEWORK
        /// <summary>
        /// Creates a responder gateway.
        /// 
        ///  <important> 
        /// <para>
        /// A domain name or managed endpoint is required.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateResponderGateway service method.</param>
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
#endif

        /// <summary>
        /// Creates a responder gateway.
        /// 
        ///  <important> 
        /// <para>
        /// A domain name or managed endpoint is required.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateResponderGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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

#if NETFRAMEWORK
        /// <summary>
        /// Deletes an inbound external link.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInboundExternalLink service method.</param>
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
#endif

        /// <summary>
        /// Deletes an inbound external link.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInboundExternalLink service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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

#if NETFRAMEWORK
        /// <summary>
        /// Deletes a link between gateways.
        /// 
        ///  
        /// <para>
        /// Permanently removes the connection between gateways. This action cannot be undone.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLink service method.</param>
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
#endif

        /// <summary>
        /// Deletes a link between gateways.
        /// 
        ///  
        /// <para>
        /// Permanently removes the connection between gateways. This action cannot be undone.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLink service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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

#if NETFRAMEWORK
        /// <summary>
        /// Deletes a routing rule from a link.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLinkRoutingRule service method.</param>
        /// <returns>The response from the DeleteLinkRoutingRule service method, as returned by RTBFabric.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/DeleteLinkRoutingRule">REST API Reference for DeleteLinkRoutingRule Operation</seealso>
        DeleteLinkRoutingRuleResponse DeleteLinkRoutingRule(DeleteLinkRoutingRuleRequest request);
#endif

        /// <summary>
        /// Deletes a routing rule from a link.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLinkRoutingRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteLinkRoutingRule service method, as returned by RTBFabric.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/DeleteLinkRoutingRule">REST API Reference for DeleteLinkRoutingRule Operation</seealso>
        Task<DeleteLinkRoutingRuleResponse> DeleteLinkRoutingRuleAsync(DeleteLinkRoutingRuleRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Deletes an outbound external link.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteOutboundExternalLink service method.</param>
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
#endif

        /// <summary>
        /// Deletes an outbound external link.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteOutboundExternalLink service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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

#if NETFRAMEWORK
        /// <summary>
        /// Deletes a requester gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRequesterGateway service method.</param>
        /// <returns>The response from the DeleteRequesterGateway service method, as returned by RTBFabric.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/DeleteRequesterGateway">REST API Reference for DeleteRequesterGateway Operation</seealso>
        DeleteRequesterGatewayResponse DeleteRequesterGateway(DeleteRequesterGatewayRequest request);
#endif

        /// <summary>
        /// Deletes a requester gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRequesterGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteRequesterGateway service method, as returned by RTBFabric.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/DeleteRequesterGateway">REST API Reference for DeleteRequesterGateway Operation</seealso>
        Task<DeleteRequesterGatewayResponse> DeleteRequesterGatewayAsync(DeleteRequesterGatewayRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Deletes a responder gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResponderGateway service method.</param>
        /// <returns>The response from the DeleteResponderGateway service method, as returned by RTBFabric.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/DeleteResponderGateway">REST API Reference for DeleteResponderGateway Operation</seealso>
        DeleteResponderGatewayResponse DeleteResponderGateway(DeleteResponderGatewayRequest request);
#endif

        /// <summary>
        /// Deletes a responder gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResponderGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteResponderGateway service method, as returned by RTBFabric.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/DeleteResponderGateway">REST API Reference for DeleteResponderGateway Operation</seealso>
        Task<DeleteResponderGatewayResponse> DeleteResponderGatewayAsync(DeleteResponderGatewayRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Removes a certificate association from a responder gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateCertificate service method.</param>
        /// <returns>The response from the DisassociateCertificate service method, as returned by RTBFabric.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/DisassociateCertificate">REST API Reference for DisassociateCertificate Operation</seealso>
        DisassociateCertificateResponse DisassociateCertificate(DisassociateCertificateRequest request);
#endif

        /// <summary>
        /// Removes a certificate association from a responder gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateCertificate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DisassociateCertificate service method, as returned by RTBFabric.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/DisassociateCertificate">REST API Reference for DisassociateCertificate Operation</seealso>
        Task<DisassociateCertificateResponse> DisassociateCertificateAsync(DisassociateCertificateRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves the details of a certificate association with a responder gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCertificateAssociation service method.</param>
        /// <returns>The response from the GetCertificateAssociation service method, as returned by RTBFabric.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/GetCertificateAssociation">REST API Reference for GetCertificateAssociation Operation</seealso>
        GetCertificateAssociationResponse GetCertificateAssociation(GetCertificateAssociationRequest request);
#endif

        /// <summary>
        /// Retrieves the details of a certificate association with a responder gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCertificateAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetCertificateAssociation service method, as returned by RTBFabric.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/GetCertificateAssociation">REST API Reference for GetCertificateAssociation Operation</seealso>
        Task<GetCertificateAssociationResponse> GetCertificateAssociationAsync(GetCertificateAssociationRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves information about an inbound external link.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInboundExternalLink service method.</param>
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
#endif

        /// <summary>
        /// Retrieves information about an inbound external link.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInboundExternalLink service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves information about a link between gateways.
        /// 
        ///  
        /// <para>
        /// Returns detailed information about the link configuration, status, and associated
        /// gateways.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLink service method.</param>
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
#endif

        /// <summary>
        /// Retrieves information about a link between gateways.
        /// 
        ///  
        /// <para>
        /// Returns detailed information about the link configuration, status, and associated
        /// gateways.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLink service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves the details of a routing rule for a link.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLinkRoutingRule service method.</param>
        /// <returns>The response from the GetLinkRoutingRule service method, as returned by RTBFabric.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/GetLinkRoutingRule">REST API Reference for GetLinkRoutingRule Operation</seealso>
        GetLinkRoutingRuleResponse GetLinkRoutingRule(GetLinkRoutingRuleRequest request);
#endif

        /// <summary>
        /// Retrieves the details of a routing rule for a link.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLinkRoutingRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetLinkRoutingRule service method, as returned by RTBFabric.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/GetLinkRoutingRule">REST API Reference for GetLinkRoutingRule Operation</seealso>
        Task<GetLinkRoutingRuleResponse> GetLinkRoutingRuleAsync(GetLinkRoutingRuleRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves information about an outbound external link.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOutboundExternalLink service method.</param>
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
#endif

        /// <summary>
        /// Retrieves information about an outbound external link.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOutboundExternalLink service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves information about a requester gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRequesterGateway service method.</param>
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
#endif

        /// <summary>
        /// Retrieves information about a requester gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRequesterGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves information about a responder gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResponderGateway service method.</param>
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
#endif

        /// <summary>
        /// Retrieves information about a responder gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResponderGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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

#if NETFRAMEWORK
        /// <summary>
        /// Lists the certificate associations for a responder gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCertificateAssociations service method.</param>
        /// <returns>The response from the ListCertificateAssociations service method, as returned by RTBFabric.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/ListCertificateAssociations">REST API Reference for ListCertificateAssociations Operation</seealso>
        ListCertificateAssociationsResponse ListCertificateAssociations(ListCertificateAssociationsRequest request);
#endif

        /// <summary>
        /// Lists the certificate associations for a responder gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCertificateAssociations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListCertificateAssociations service method, as returned by RTBFabric.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/ListCertificateAssociations">REST API Reference for ListCertificateAssociations Operation</seealso>
        Task<ListCertificateAssociationsResponse> ListCertificateAssociationsAsync(ListCertificateAssociationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Lists the routing rules for a link.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLinkRoutingRules service method.</param>
        /// <returns>The response from the ListLinkRoutingRules service method, as returned by RTBFabric.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/ListLinkRoutingRules">REST API Reference for ListLinkRoutingRules Operation</seealso>
        ListLinkRoutingRulesResponse ListLinkRoutingRules(ListLinkRoutingRulesRequest request);
#endif

        /// <summary>
        /// Lists the routing rules for a link.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLinkRoutingRules service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListLinkRoutingRules service method, as returned by RTBFabric.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/ListLinkRoutingRules">REST API Reference for ListLinkRoutingRules Operation</seealso>
        Task<ListLinkRoutingRulesResponse> ListLinkRoutingRulesAsync(ListLinkRoutingRulesRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Lists links associated with gateways.
        /// 
        ///  
        /// <para>
        /// Returns a list of all links for the specified gateways, including their status and
        /// configuration details.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLinks service method.</param>
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
#endif

        /// <summary>
        /// Lists links associated with gateways.
        /// 
        ///  
        /// <para>
        /// Returns a list of all links for the specified gateways, including their status and
        /// configuration details.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLinks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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

#if NETFRAMEWORK
        /// <summary>
        /// Lists requester gateways.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRequesterGateways service method.</param>
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
#endif

        /// <summary>
        /// Lists requester gateways.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRequesterGateways service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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

#if NETFRAMEWORK
        /// <summary>
        /// Lists reponder gateways.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResponderGateways service method.</param>
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
#endif

        /// <summary>
        /// Lists reponder gateways.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResponderGateways service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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

#if NETFRAMEWORK
        /// <summary>
        /// Lists tags for a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
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
#endif

        /// <summary>
        /// Lists tags for a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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

#if NETFRAMEWORK
        /// <summary>
        /// Rejects a link request between gateways.
        /// 
        ///  
        /// <para>
        /// When a requester gateway requests to link with a responder gateway, the responder
        /// can use this operation to decline the link request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RejectLink service method.</param>
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
#endif

        /// <summary>
        /// Rejects a link request between gateways.
        /// 
        ///  
        /// <para>
        /// When a requester gateway requests to link with a responder gateway, the responder
        /// can use this operation to decline the link request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RejectLink service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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

#if NETFRAMEWORK
        /// <summary>
        /// Assigns one or more tags (key-value pairs) to the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
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
#endif

        /// <summary>
        /// Assigns one or more tags (key-value pairs) to the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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

#if NETFRAMEWORK
        /// <summary>
        /// Removes a tag or tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
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
#endif

        /// <summary>
        /// Removes a tag or tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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

#if NETFRAMEWORK
        /// <summary>
        /// Updates the configuration of a link between gateways.
        /// 
        ///  
        /// <para>
        /// Allows you to modify settings and parameters for an existing link.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLink service method.</param>
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
#endif

        /// <summary>
        /// Updates the configuration of a link between gateways.
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

#if NETFRAMEWORK
        /// <summary>
        /// Updates a link module flow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLinkModuleFlow service method.</param>
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
#endif

        /// <summary>
        /// Updates a link module flow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLinkModuleFlow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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

#if NETFRAMEWORK
        /// <summary>
        /// Updates a routing rule for a link.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLinkRoutingRule service method.</param>
        /// <returns>The response from the UpdateLinkRoutingRule service method, as returned by RTBFabric.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/UpdateLinkRoutingRule">REST API Reference for UpdateLinkRoutingRule Operation</seealso>
        UpdateLinkRoutingRuleResponse UpdateLinkRoutingRule(UpdateLinkRoutingRuleRequest request);
#endif

        /// <summary>
        /// Updates a routing rule for a link.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLinkRoutingRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateLinkRoutingRule service method, as returned by RTBFabric.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/UpdateLinkRoutingRule">REST API Reference for UpdateLinkRoutingRule Operation</seealso>
        Task<UpdateLinkRoutingRuleResponse> UpdateLinkRoutingRuleAsync(UpdateLinkRoutingRuleRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Updates a requester gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRequesterGateway service method.</param>
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
#endif

        /// <summary>
        /// Updates a requester gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRequesterGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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

#if NETFRAMEWORK
        /// <summary>
        /// Updates the description, Auto Scaling group managed endpoint configuration, trust
        /// store configuration, and client routing policy of a responder gateway. This operation
        /// also updates the <c>protocols</c> list in the listener configuration.
        /// 
        ///  
        /// <para>
        /// You cannot change the <c>domainName</c>, <c>port</c>, and <c>protocol</c> values that
        /// you set when you create a responder gateway. To change any of them, delete the gateway
        /// and create a new one.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateResponderGateway service method.</param>
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
#endif

        /// <summary>
        /// Updates the description, Auto Scaling group managed endpoint configuration, trust
        /// store configuration, and client routing policy of a responder gateway. This operation
        /// also updates the <c>protocols</c> list in the listener configuration.
        /// 
        ///  
        /// <para>
        /// You cannot change the <c>domainName</c>, <c>port</c>, and <c>protocol</c> values that
        /// you set when you create a responder gateway. To change any of them, delete the gateway
        /// and create a new one.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateResponderGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);

#if NET8_0_OR_GREATER
        // Warning CA1033 is issued when the child types can not call the method defined in parent types.
        // In this use case the intended caller is only meant to be the interface as a factory
        // method to create the child types. Given the SDK use case the warning can be ignored.
#pragma warning disable CA1033
        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonRTBFabricConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonRTBFabricConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
            Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonRTBFabricConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonRTBFabricConfig to create AmazonRTBFabricClient");
            }

            return awsCredentials == null ?
                    new AmazonRTBFabricClient(serviceClientConfig) :
                    new AmazonRTBFabricClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
    }
}
