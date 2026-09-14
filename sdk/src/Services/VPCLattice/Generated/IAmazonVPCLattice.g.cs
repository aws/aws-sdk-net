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
using Amazon.VPCLattice.Model;

#pragma warning disable CS1570

namespace Amazon.VPCLattice
{
    /// <summary>
    /// <para>Interface for accessing VPCLattice</para>
    ///
    /// Amazon VPC Lattice is a fully managed application networking service that you use
    /// to connect, secure, and monitor all of your services across multiple accounts and
    /// virtual private clouds (VPCs). Amazon VPC Lattice interconnects your microservices
    /// and legacy services within a logical boundary, so that you can discover and manage
    /// them more efficiently. For more information, see the <a href="https://docs.aws.amazon.com/vpc-lattice/latest/ug/">Amazon
    /// VPC Lattice User Guide</a>
    /// </summary>
    public partial interface IAmazonVPCLattice : IAmazonService, IDisposable
    {
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IVPCLatticePaginatorFactory Paginators { get; }

#if NETFRAMEWORK
        /// <summary>
        /// Updates the listener rules in a batch. You can use this operation to change the priority
        /// of listener rules. This can be useful when bulk updating or swapping rule priority.
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions:</b> <c>vpc-lattice:UpdateRule</c> 
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/vpc-lattice/latest/ug/security_iam_service-with-iam.html">How
        /// Amazon VPC Lattice works with IAM</a> in the <i>Amazon VPC Lattice User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdateRule service method.</param>
        /// <returns>The response from the BatchUpdateRule service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/BatchUpdateRule">REST API Reference for BatchUpdateRule Operation</seealso>
        BatchUpdateRuleResponse BatchUpdateRule(BatchUpdateRuleRequest request);
#endif

        /// <summary>
        /// Updates the listener rules in a batch. You can use this operation to change the priority
        /// of listener rules. This can be useful when bulk updating or swapping rule priority.
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions:</b> <c>vpc-lattice:UpdateRule</c> 
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/vpc-lattice/latest/ug/security_iam_service-with-iam.html">How
        /// Amazon VPC Lattice works with IAM</a> in the <i>Amazon VPC Lattice User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdateRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the BatchUpdateRule service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/BatchUpdateRule">REST API Reference for BatchUpdateRule Operation</seealso>
        Task<BatchUpdateRuleResponse> BatchUpdateRuleAsync(BatchUpdateRuleRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Enables access logs to be sent to Amazon CloudWatch, Amazon S3, and Amazon Kinesis
        /// Data Firehose. The service network owner can use the access logs to audit the services
        /// in the network. The service network owner can only see access logs from clients and
        /// services that are associated with their service network. Access log entries represent
        /// traffic originated from VPCs associated with that network. For more information, see
        /// <a href="https://docs.aws.amazon.com/vpc-lattice/latest/ug/monitoring-access-logs.html">Access
        /// logs</a> in the <i>Amazon VPC Lattice User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAccessLogSubscription service method.</param>
        /// <returns>The response from the CreateAccessLogSubscription service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/CreateAccessLogSubscription">REST API Reference for CreateAccessLogSubscription Operation</seealso>
        CreateAccessLogSubscriptionResponse CreateAccessLogSubscription(CreateAccessLogSubscriptionRequest request);
#endif

        /// <summary>
        /// Enables access logs to be sent to Amazon CloudWatch, Amazon S3, and Amazon Kinesis
        /// Data Firehose. The service network owner can use the access logs to audit the services
        /// in the network. The service network owner can only see access logs from clients and
        /// services that are associated with their service network. Access log entries represent
        /// traffic originated from VPCs associated with that network. For more information, see
        /// <a href="https://docs.aws.amazon.com/vpc-lattice/latest/ug/monitoring-access-logs.html">Access
        /// logs</a> in the <i>Amazon VPC Lattice User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAccessLogSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateAccessLogSubscription service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/CreateAccessLogSubscription">REST API Reference for CreateAccessLogSubscription Operation</seealso>
        Task<CreateAccessLogSubscriptionResponse> CreateAccessLogSubscriptionAsync(CreateAccessLogSubscriptionRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Creates a listener for a service. Before you start using your Amazon VPC Lattice service,
        /// you must add one or more listeners. A listener is a process that checks for connection
        /// requests to your services. For more information, see <a href="https://docs.aws.amazon.com/vpc-lattice/latest/ug/listeners.html">Listeners</a>
        /// in the <i>Amazon VPC Lattice User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateListener service method.</param>
        /// <returns>The response from the CreateListener service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/CreateListener">REST API Reference for CreateListener Operation</seealso>
        CreateListenerResponse CreateListener(CreateListenerRequest request);
#endif

        /// <summary>
        /// Creates a listener for a service. Before you start using your Amazon VPC Lattice service,
        /// you must add one or more listeners. A listener is a process that checks for connection
        /// requests to your services. For more information, see <a href="https://docs.aws.amazon.com/vpc-lattice/latest/ug/listeners.html">Listeners</a>
        /// in the <i>Amazon VPC Lattice User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateListener service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateListener service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/CreateListener">REST API Reference for CreateListener Operation</seealso>
        Task<CreateListenerResponse> CreateListenerAsync(CreateListenerRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Creates a resource configuration. A resource configuration defines a specific resource.
        /// You can associate a resource configuration with a service network or a VPC endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateResourceConfiguration service method.</param>
        /// <returns>The response from the CreateResourceConfiguration service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/CreateResourceConfiguration">REST API Reference for CreateResourceConfiguration Operation</seealso>
        CreateResourceConfigurationResponse CreateResourceConfiguration(CreateResourceConfigurationRequest request);
#endif

        /// <summary>
        /// Creates a resource configuration. A resource configuration defines a specific resource.
        /// You can associate a resource configuration with a service network or a VPC endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateResourceConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateResourceConfiguration service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/CreateResourceConfiguration">REST API Reference for CreateResourceConfiguration Operation</seealso>
        Task<CreateResourceConfigurationResponse> CreateResourceConfigurationAsync(CreateResourceConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// A resource gateway is a point of ingress into the VPC where a resource resides. It
        /// spans multiple Availability Zones. For your resource to be accessible from all Availability
        /// Zones, you should create your resource gateways to span as many Availability Zones
        /// as possible. A VPC can have multiple resource gateways.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateResourceGateway service method.</param>
        /// <returns>The response from the CreateResourceGateway service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/CreateResourceGateway">REST API Reference for CreateResourceGateway Operation</seealso>
        CreateResourceGatewayResponse CreateResourceGateway(CreateResourceGatewayRequest request);
#endif

        /// <summary>
        /// A resource gateway is a point of ingress into the VPC where a resource resides. It
        /// spans multiple Availability Zones. For your resource to be accessible from all Availability
        /// Zones, you should create your resource gateways to span as many Availability Zones
        /// as possible. A VPC can have multiple resource gateways.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateResourceGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateResourceGateway service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/CreateResourceGateway">REST API Reference for CreateResourceGateway Operation</seealso>
        Task<CreateResourceGatewayResponse> CreateResourceGatewayAsync(CreateResourceGatewayRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Creates a listener rule. Each listener has a default rule for checking connection
        /// requests, but you can define additional rules. Each rule consists of a priority, one
        /// or more actions, and one or more conditions. For more information, see <a href="https://docs.aws.amazon.com/vpc-lattice/latest/ug/listeners.html#listener-rules">Listener
        /// rules</a> in the <i>Amazon VPC Lattice User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRule service method.</param>
        /// <returns>The response from the CreateRule service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/CreateRule">REST API Reference for CreateRule Operation</seealso>
        CreateRuleResponse CreateRule(CreateRuleRequest request);
#endif

        /// <summary>
        /// Creates a listener rule. Each listener has a default rule for checking connection
        /// requests, but you can define additional rules. Each rule consists of a priority, one
        /// or more actions, and one or more conditions. For more information, see <a href="https://docs.aws.amazon.com/vpc-lattice/latest/ug/listeners.html#listener-rules">Listener
        /// rules</a> in the <i>Amazon VPC Lattice User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateRule service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/CreateRule">REST API Reference for CreateRule Operation</seealso>
        Task<CreateRuleResponse> CreateRuleAsync(CreateRuleRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Creates a service. A service is any software application that can run on instances
        /// containers, or serverless functions within an account or virtual private cloud (VPC).
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/vpc-lattice/latest/ug/services.html">Services</a>
        /// in the <i>Amazon VPC Lattice User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateService service method.</param>
        /// <returns>The response from the CreateService service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/CreateService">REST API Reference for CreateService Operation</seealso>
        CreateServiceResponse CreateService(CreateServiceRequest request);
#endif

        /// <summary>
        /// Creates a service. A service is any software application that can run on instances
        /// containers, or serverless functions within an account or virtual private cloud (VPC).
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/vpc-lattice/latest/ug/services.html">Services</a>
        /// in the <i>Amazon VPC Lattice User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateService service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateService service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/CreateService">REST API Reference for CreateService Operation</seealso>
        Task<CreateServiceResponse> CreateServiceAsync(CreateServiceRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Creates a service network. A service network is a logical boundary for a collection
        /// of services. You can associate services and VPCs with a service network.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/vpc-lattice/latest/ug/service-networks.html">Service
        /// networks</a> in the <i>Amazon VPC Lattice User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateServiceNetwork service method.</param>
        /// <returns>The response from the CreateServiceNetwork service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/CreateServiceNetwork">REST API Reference for CreateServiceNetwork Operation</seealso>
        CreateServiceNetworkResponse CreateServiceNetwork(CreateServiceNetworkRequest request);
#endif

        /// <summary>
        /// Creates a service network. A service network is a logical boundary for a collection
        /// of services. You can associate services and VPCs with a service network.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/vpc-lattice/latest/ug/service-networks.html">Service
        /// networks</a> in the <i>Amazon VPC Lattice User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateServiceNetwork service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateServiceNetwork service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/CreateServiceNetwork">REST API Reference for CreateServiceNetwork Operation</seealso>
        Task<CreateServiceNetworkResponse> CreateServiceNetworkAsync(CreateServiceNetworkRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Associates the specified service network with the specified resource configuration.
        /// This allows the resource configuration to receive connections through the service
        /// network, including through a service network VPC endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateServiceNetworkResourceAssociation service method.</param>
        /// <returns>The response from the CreateServiceNetworkResourceAssociation service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/CreateServiceNetworkResourceAssociation">REST API Reference for CreateServiceNetworkResourceAssociation Operation</seealso>
        CreateServiceNetworkResourceAssociationResponse CreateServiceNetworkResourceAssociation(CreateServiceNetworkResourceAssociationRequest request);
#endif

        /// <summary>
        /// Associates the specified service network with the specified resource configuration.
        /// This allows the resource configuration to receive connections through the service
        /// network, including through a service network VPC endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateServiceNetworkResourceAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateServiceNetworkResourceAssociation service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/CreateServiceNetworkResourceAssociation">REST API Reference for CreateServiceNetworkResourceAssociation Operation</seealso>
        Task<CreateServiceNetworkResourceAssociationResponse> CreateServiceNetworkResourceAssociationAsync(CreateServiceNetworkResourceAssociationRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Associates the specified service with the specified service network. For more information,
        /// see <a href="https://docs.aws.amazon.com/vpc-lattice/latest/ug/service-network-associations.html#service-network-service-associations">Manage
        /// service associations</a> in the <i>Amazon VPC Lattice User Guide</i>.
        /// 
        ///  
        /// <para>
        /// You can't use this operation if the service and service network are already associated
        /// or if there is a disassociation or deletion in progress. If the association fails,
        /// you can retry the operation by deleting the association and recreating it.
        /// </para>
        ///  
        /// <para>
        /// You cannot associate a service and service network that are shared with a caller.
        /// The caller must own either the service or the service network.
        /// </para>
        ///  
        /// <para>
        /// As a result of this operation, the association is created in the service network account
        /// and the association owner account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateServiceNetworkServiceAssociation service method.</param>
        /// <returns>The response from the CreateServiceNetworkServiceAssociation service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/CreateServiceNetworkServiceAssociation">REST API Reference for CreateServiceNetworkServiceAssociation Operation</seealso>
        CreateServiceNetworkServiceAssociationResponse CreateServiceNetworkServiceAssociation(CreateServiceNetworkServiceAssociationRequest request);
#endif

        /// <summary>
        /// Associates the specified service with the specified service network. For more information,
        /// see <a href="https://docs.aws.amazon.com/vpc-lattice/latest/ug/service-network-associations.html#service-network-service-associations">Manage
        /// service associations</a> in the <i>Amazon VPC Lattice User Guide</i>.
        /// 
        ///  
        /// <para>
        /// You can't use this operation if the service and service network are already associated
        /// or if there is a disassociation or deletion in progress. If the association fails,
        /// you can retry the operation by deleting the association and recreating it.
        /// </para>
        ///  
        /// <para>
        /// You cannot associate a service and service network that are shared with a caller.
        /// The caller must own either the service or the service network.
        /// </para>
        ///  
        /// <para>
        /// As a result of this operation, the association is created in the service network account
        /// and the association owner account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateServiceNetworkServiceAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateServiceNetworkServiceAssociation service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/CreateServiceNetworkServiceAssociation">REST API Reference for CreateServiceNetworkServiceAssociation Operation</seealso>
        Task<CreateServiceNetworkServiceAssociationResponse> CreateServiceNetworkServiceAssociationAsync(CreateServiceNetworkServiceAssociationRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Associates a VPC with a service network. When you associate a VPC with the service
        /// network, it enables all the resources within that VPC to be clients and communicate
        /// with other services in the service network. For more information, see <a href="https://docs.aws.amazon.com/vpc-lattice/latest/ug/service-network-associations.html#service-network-vpc-associations">Manage
        /// VPC associations</a> in the <i>Amazon VPC Lattice User Guide</i>.
        /// 
        ///  
        /// <para>
        /// You can't use this operation if there is a disassociation in progress. If the association
        /// fails, retry by deleting the association and recreating it.
        /// </para>
        ///  
        /// <para>
        /// As a result of this operation, the association gets created in the service network
        /// account and the VPC owner account.
        /// </para>
        ///  
        /// <para>
        /// If you add a security group to the service network and VPC association, the association
        /// must continue to always have at least one security group. You can add or edit security
        /// groups at any time. However, to remove all security groups, you must first delete
        /// the association and recreate it without security groups.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateServiceNetworkVpcAssociation service method.</param>
        /// <returns>The response from the CreateServiceNetworkVpcAssociation service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/CreateServiceNetworkVpcAssociation">REST API Reference for CreateServiceNetworkVpcAssociation Operation</seealso>
        CreateServiceNetworkVpcAssociationResponse CreateServiceNetworkVpcAssociation(CreateServiceNetworkVpcAssociationRequest request);
#endif

        /// <summary>
        /// Associates a VPC with a service network. When you associate a VPC with the service
        /// network, it enables all the resources within that VPC to be clients and communicate
        /// with other services in the service network. For more information, see <a href="https://docs.aws.amazon.com/vpc-lattice/latest/ug/service-network-associations.html#service-network-vpc-associations">Manage
        /// VPC associations</a> in the <i>Amazon VPC Lattice User Guide</i>.
        /// 
        ///  
        /// <para>
        /// You can't use this operation if there is a disassociation in progress. If the association
        /// fails, retry by deleting the association and recreating it.
        /// </para>
        ///  
        /// <para>
        /// As a result of this operation, the association gets created in the service network
        /// account and the VPC owner account.
        /// </para>
        ///  
        /// <para>
        /// If you add a security group to the service network and VPC association, the association
        /// must continue to always have at least one security group. You can add or edit security
        /// groups at any time. However, to remove all security groups, you must first delete
        /// the association and recreate it without security groups.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateServiceNetworkVpcAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateServiceNetworkVpcAssociation service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/CreateServiceNetworkVpcAssociation">REST API Reference for CreateServiceNetworkVpcAssociation Operation</seealso>
        Task<CreateServiceNetworkVpcAssociationResponse> CreateServiceNetworkVpcAssociationAsync(CreateServiceNetworkVpcAssociationRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Creates a target group. A target group is a collection of targets, or compute resources,
        /// that run your application or service. A target group can only be used by a single
        /// service.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/vpc-lattice/latest/ug/target-groups.html">Target
        /// groups</a> in the <i>Amazon VPC Lattice User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTargetGroup service method.</param>
        /// <returns>The response from the CreateTargetGroup service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/CreateTargetGroup">REST API Reference for CreateTargetGroup Operation</seealso>
        CreateTargetGroupResponse CreateTargetGroup(CreateTargetGroupRequest request);
#endif

        /// <summary>
        /// Creates a target group. A target group is a collection of targets, or compute resources,
        /// that run your application or service. A target group can only be used by a single
        /// service.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/vpc-lattice/latest/ug/target-groups.html">Target
        /// groups</a> in the <i>Amazon VPC Lattice User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTargetGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateTargetGroup service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/CreateTargetGroup">REST API Reference for CreateTargetGroup Operation</seealso>
        Task<CreateTargetGroupResponse> CreateTargetGroupAsync(CreateTargetGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Deletes the specified access log subscription.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccessLogSubscription service method.</param>
        /// <returns>The response from the DeleteAccessLogSubscription service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/DeleteAccessLogSubscription">REST API Reference for DeleteAccessLogSubscription Operation</seealso>
        DeleteAccessLogSubscriptionResponse DeleteAccessLogSubscription(DeleteAccessLogSubscriptionRequest request);
#endif

        /// <summary>
        /// Deletes the specified access log subscription.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccessLogSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteAccessLogSubscription service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/DeleteAccessLogSubscription">REST API Reference for DeleteAccessLogSubscription Operation</seealso>
        Task<DeleteAccessLogSubscriptionResponse> DeleteAccessLogSubscriptionAsync(DeleteAccessLogSubscriptionRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Deletes the specified auth policy. If an auth is set to <c>AWS_IAM</c> and the auth
        /// policy is deleted, all requests are denied. If you are trying to remove the auth policy
        /// completely, you must set the auth type to <c>NONE</c>. If auth is enabled on the resource,
        /// but no auth policy is set, all requests are denied.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAuthPolicy service method.</param>
        /// <returns>The response from the DeleteAuthPolicy service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/DeleteAuthPolicy">REST API Reference for DeleteAuthPolicy Operation</seealso>
        DeleteAuthPolicyResponse DeleteAuthPolicy(DeleteAuthPolicyRequest request);
#endif

        /// <summary>
        /// Deletes the specified auth policy. If an auth is set to <c>AWS_IAM</c> and the auth
        /// policy is deleted, all requests are denied. If you are trying to remove the auth policy
        /// completely, you must set the auth type to <c>NONE</c>. If auth is enabled on the resource,
        /// but no auth policy is set, all requests are denied.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAuthPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteAuthPolicy service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/DeleteAuthPolicy">REST API Reference for DeleteAuthPolicy Operation</seealso>
        Task<DeleteAuthPolicyResponse> DeleteAuthPolicyAsync(DeleteAuthPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Deletes the specified domain verification.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomainVerification service method.</param>
        /// <returns>The response from the DeleteDomainVerification service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/DeleteDomainVerification">REST API Reference for DeleteDomainVerification Operation</seealso>
        DeleteDomainVerificationResponse DeleteDomainVerification(DeleteDomainVerificationRequest request);
#endif

        /// <summary>
        /// Deletes the specified domain verification.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomainVerification service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteDomainVerification service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/DeleteDomainVerification">REST API Reference for DeleteDomainVerification Operation</seealso>
        Task<DeleteDomainVerificationResponse> DeleteDomainVerificationAsync(DeleteDomainVerificationRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Deletes the specified listener.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteListener service method.</param>
        /// <returns>The response from the DeleteListener service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/DeleteListener">REST API Reference for DeleteListener Operation</seealso>
        DeleteListenerResponse DeleteListener(DeleteListenerRequest request);
#endif

        /// <summary>
        /// Deletes the specified listener.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteListener service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteListener service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/DeleteListener">REST API Reference for DeleteListener Operation</seealso>
        Task<DeleteListenerResponse> DeleteListenerAsync(DeleteListenerRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Deletes the specified resource configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourceConfiguration service method.</param>
        /// <returns>The response from the DeleteResourceConfiguration service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/DeleteResourceConfiguration">REST API Reference for DeleteResourceConfiguration Operation</seealso>
        DeleteResourceConfigurationResponse DeleteResourceConfiguration(DeleteResourceConfigurationRequest request);
#endif

        /// <summary>
        /// Deletes the specified resource configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourceConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteResourceConfiguration service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/DeleteResourceConfiguration">REST API Reference for DeleteResourceConfiguration Operation</seealso>
        Task<DeleteResourceConfigurationResponse> DeleteResourceConfigurationAsync(DeleteResourceConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Disassociates the resource configuration from the resource VPC endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourceEndpointAssociation service method.</param>
        /// <returns>The response from the DeleteResourceEndpointAssociation service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/DeleteResourceEndpointAssociation">REST API Reference for DeleteResourceEndpointAssociation Operation</seealso>
        DeleteResourceEndpointAssociationResponse DeleteResourceEndpointAssociation(DeleteResourceEndpointAssociationRequest request);
#endif

        /// <summary>
        /// Disassociates the resource configuration from the resource VPC endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourceEndpointAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteResourceEndpointAssociation service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/DeleteResourceEndpointAssociation">REST API Reference for DeleteResourceEndpointAssociation Operation</seealso>
        Task<DeleteResourceEndpointAssociationResponse> DeleteResourceEndpointAssociationAsync(DeleteResourceEndpointAssociationRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Deletes the specified resource gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourceGateway service method.</param>
        /// <returns>The response from the DeleteResourceGateway service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/DeleteResourceGateway">REST API Reference for DeleteResourceGateway Operation</seealso>
        DeleteResourceGatewayResponse DeleteResourceGateway(DeleteResourceGatewayRequest request);
#endif

        /// <summary>
        /// Deletes the specified resource gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourceGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteResourceGateway service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/DeleteResourceGateway">REST API Reference for DeleteResourceGateway Operation</seealso>
        Task<DeleteResourceGatewayResponse> DeleteResourceGatewayAsync(DeleteResourceGatewayRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Deletes the specified resource policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourcePolicy service method.</param>
        /// <returns>The response from the DeleteResourcePolicy service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/DeleteResourcePolicy">REST API Reference for DeleteResourcePolicy Operation</seealso>
        DeleteResourcePolicyResponse DeleteResourcePolicy(DeleteResourcePolicyRequest request);
#endif

        /// <summary>
        /// Deletes the specified resource policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourcePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteResourcePolicy service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/DeleteResourcePolicy">REST API Reference for DeleteResourcePolicy Operation</seealso>
        Task<DeleteResourcePolicyResponse> DeleteResourcePolicyAsync(DeleteResourcePolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Deletes a listener rule. Each listener has a default rule for checking connection
        /// requests, but you can define additional rules. Each rule consists of a priority, one
        /// or more actions, and one or more conditions. You can delete additional listener rules,
        /// but you cannot delete the default rule.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/vpc-lattice/latest/ug/listeners.html#listener-rules">Listener
        /// rules</a> in the <i>Amazon VPC Lattice User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRule service method.</param>
        /// <returns>The response from the DeleteRule service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/DeleteRule">REST API Reference for DeleteRule Operation</seealso>
        DeleteRuleResponse DeleteRule(DeleteRuleRequest request);
#endif

        /// <summary>
        /// Deletes a listener rule. Each listener has a default rule for checking connection
        /// requests, but you can define additional rules. Each rule consists of a priority, one
        /// or more actions, and one or more conditions. You can delete additional listener rules,
        /// but you cannot delete the default rule.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/vpc-lattice/latest/ug/listeners.html#listener-rules">Listener
        /// rules</a> in the <i>Amazon VPC Lattice User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteRule service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/DeleteRule">REST API Reference for DeleteRule Operation</seealso>
        Task<DeleteRuleResponse> DeleteRuleAsync(DeleteRuleRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Deletes a service. A service can't be deleted if it's associated with a service network.
        /// If you delete a service, all resources related to the service, such as the resource
        /// policy, auth policy, listeners, listener rules, and access log subscriptions, are
        /// also deleted. For more information, see <a href="https://docs.aws.amazon.com/vpc-lattice/latest/ug/services.html#delete-service">Delete
        /// a service</a> in the <i>Amazon VPC Lattice User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteService service method.</param>
        /// <returns>The response from the DeleteService service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/DeleteService">REST API Reference for DeleteService Operation</seealso>
        DeleteServiceResponse DeleteService(DeleteServiceRequest request);
#endif

        /// <summary>
        /// Deletes a service. A service can't be deleted if it's associated with a service network.
        /// If you delete a service, all resources related to the service, such as the resource
        /// policy, auth policy, listeners, listener rules, and access log subscriptions, are
        /// also deleted. For more information, see <a href="https://docs.aws.amazon.com/vpc-lattice/latest/ug/services.html#delete-service">Delete
        /// a service</a> in the <i>Amazon VPC Lattice User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteService service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteService service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/DeleteService">REST API Reference for DeleteService Operation</seealso>
        Task<DeleteServiceResponse> DeleteServiceAsync(DeleteServiceRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Deletes a service network. You can only delete the service network if there is no
        /// service or VPC associated with it. If you delete a service network, all resources
        /// related to the service network, such as the resource policy, auth policy, and access
        /// log subscriptions, are also deleted. For more information, see <a href="https://docs.aws.amazon.com/vpc-lattice/latest/ug/service-networks.html#delete-service-network">Delete
        /// a service network</a> in the <i>Amazon VPC Lattice User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteServiceNetwork service method.</param>
        /// <returns>The response from the DeleteServiceNetwork service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/DeleteServiceNetwork">REST API Reference for DeleteServiceNetwork Operation</seealso>
        DeleteServiceNetworkResponse DeleteServiceNetwork(DeleteServiceNetworkRequest request);
#endif

        /// <summary>
        /// Deletes a service network. You can only delete the service network if there is no
        /// service or VPC associated with it. If you delete a service network, all resources
        /// related to the service network, such as the resource policy, auth policy, and access
        /// log subscriptions, are also deleted. For more information, see <a href="https://docs.aws.amazon.com/vpc-lattice/latest/ug/service-networks.html#delete-service-network">Delete
        /// a service network</a> in the <i>Amazon VPC Lattice User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteServiceNetwork service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteServiceNetwork service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/DeleteServiceNetwork">REST API Reference for DeleteServiceNetwork Operation</seealso>
        Task<DeleteServiceNetworkResponse> DeleteServiceNetworkAsync(DeleteServiceNetworkRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Deletes the association between a service network and a resource configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteServiceNetworkResourceAssociation service method.</param>
        /// <returns>The response from the DeleteServiceNetworkResourceAssociation service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/DeleteServiceNetworkResourceAssociation">REST API Reference for DeleteServiceNetworkResourceAssociation Operation</seealso>
        DeleteServiceNetworkResourceAssociationResponse DeleteServiceNetworkResourceAssociation(DeleteServiceNetworkResourceAssociationRequest request);
#endif

        /// <summary>
        /// Deletes the association between a service network and a resource configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteServiceNetworkResourceAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteServiceNetworkResourceAssociation service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/DeleteServiceNetworkResourceAssociation">REST API Reference for DeleteServiceNetworkResourceAssociation Operation</seealso>
        Task<DeleteServiceNetworkResourceAssociationResponse> DeleteServiceNetworkResourceAssociationAsync(DeleteServiceNetworkResourceAssociationRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Deletes the association between a service and a service network. This operation fails
        /// if an association is still in progress.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteServiceNetworkServiceAssociation service method.</param>
        /// <returns>The response from the DeleteServiceNetworkServiceAssociation service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/DeleteServiceNetworkServiceAssociation">REST API Reference for DeleteServiceNetworkServiceAssociation Operation</seealso>
        DeleteServiceNetworkServiceAssociationResponse DeleteServiceNetworkServiceAssociation(DeleteServiceNetworkServiceAssociationRequest request);
#endif

        /// <summary>
        /// Deletes the association between a service and a service network. This operation fails
        /// if an association is still in progress.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteServiceNetworkServiceAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteServiceNetworkServiceAssociation service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/DeleteServiceNetworkServiceAssociation">REST API Reference for DeleteServiceNetworkServiceAssociation Operation</seealso>
        Task<DeleteServiceNetworkServiceAssociationResponse> DeleteServiceNetworkServiceAssociationAsync(DeleteServiceNetworkServiceAssociationRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Disassociates the VPC from the service network. You can't disassociate the VPC if
        /// there is a create or update association in progress.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteServiceNetworkVpcAssociation service method.</param>
        /// <returns>The response from the DeleteServiceNetworkVpcAssociation service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/DeleteServiceNetworkVpcAssociation">REST API Reference for DeleteServiceNetworkVpcAssociation Operation</seealso>
        DeleteServiceNetworkVpcAssociationResponse DeleteServiceNetworkVpcAssociation(DeleteServiceNetworkVpcAssociationRequest request);
#endif

        /// <summary>
        /// Disassociates the VPC from the service network. You can't disassociate the VPC if
        /// there is a create or update association in progress.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteServiceNetworkVpcAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteServiceNetworkVpcAssociation service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/DeleteServiceNetworkVpcAssociation">REST API Reference for DeleteServiceNetworkVpcAssociation Operation</seealso>
        Task<DeleteServiceNetworkVpcAssociationResponse> DeleteServiceNetworkVpcAssociationAsync(DeleteServiceNetworkVpcAssociationRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Deletes a target group. You can't delete a target group if it is used in a listener
        /// rule or if the target group creation is in progress.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTargetGroup service method.</param>
        /// <returns>The response from the DeleteTargetGroup service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/DeleteTargetGroup">REST API Reference for DeleteTargetGroup Operation</seealso>
        DeleteTargetGroupResponse DeleteTargetGroup(DeleteTargetGroupRequest request);
#endif

        /// <summary>
        /// Deletes a target group. You can't delete a target group if it is used in a listener
        /// rule or if the target group creation is in progress.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTargetGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteTargetGroup service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/DeleteTargetGroup">REST API Reference for DeleteTargetGroup Operation</seealso>
        Task<DeleteTargetGroupResponse> DeleteTargetGroupAsync(DeleteTargetGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Deregisters the specified targets from the specified target group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterTargets service method.</param>
        /// <returns>The response from the DeregisterTargets service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/DeregisterTargets">REST API Reference for DeregisterTargets Operation</seealso>
        DeregisterTargetsResponse DeregisterTargets(DeregisterTargetsRequest request);
#endif

        /// <summary>
        /// Deregisters the specified targets from the specified target group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterTargets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeregisterTargets service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/DeregisterTargets">REST API Reference for DeregisterTargets Operation</seealso>
        Task<DeregisterTargetsResponse> DeregisterTargetsAsync(DeregisterTargetsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves information about the specified access log subscription.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccessLogSubscription service method.</param>
        /// <returns>The response from the GetAccessLogSubscription service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/GetAccessLogSubscription">REST API Reference for GetAccessLogSubscription Operation</seealso>
        GetAccessLogSubscriptionResponse GetAccessLogSubscription(GetAccessLogSubscriptionRequest request);
#endif

        /// <summary>
        /// Retrieves information about the specified access log subscription.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccessLogSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetAccessLogSubscription service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/GetAccessLogSubscription">REST API Reference for GetAccessLogSubscription Operation</seealso>
        Task<GetAccessLogSubscriptionResponse> GetAccessLogSubscriptionAsync(GetAccessLogSubscriptionRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves information about the auth policy for the specified service or service network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAuthPolicy service method.</param>
        /// <returns>The response from the GetAuthPolicy service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/GetAuthPolicy">REST API Reference for GetAuthPolicy Operation</seealso>
        GetAuthPolicyResponse GetAuthPolicy(GetAuthPolicyRequest request);
#endif

        /// <summary>
        /// Retrieves information about the auth policy for the specified service or service network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAuthPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetAuthPolicy service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/GetAuthPolicy">REST API Reference for GetAuthPolicy Operation</seealso>
        Task<GetAuthPolicyResponse> GetAuthPolicyAsync(GetAuthPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves information about a domain verification.ß
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDomainVerification service method.</param>
        /// <returns>The response from the GetDomainVerification service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/GetDomainVerification">REST API Reference for GetDomainVerification Operation</seealso>
        GetDomainVerificationResponse GetDomainVerification(GetDomainVerificationRequest request);
#endif

        /// <summary>
        /// Retrieves information about a domain verification.ß
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDomainVerification service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetDomainVerification service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/GetDomainVerification">REST API Reference for GetDomainVerification Operation</seealso>
        Task<GetDomainVerificationResponse> GetDomainVerificationAsync(GetDomainVerificationRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves information about the specified listener for the specified service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetListener service method.</param>
        /// <returns>The response from the GetListener service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/GetListener">REST API Reference for GetListener Operation</seealso>
        GetListenerResponse GetListener(GetListenerRequest request);
#endif

        /// <summary>
        /// Retrieves information about the specified listener for the specified service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetListener service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetListener service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/GetListener">REST API Reference for GetListener Operation</seealso>
        Task<GetListenerResponse> GetListenerAsync(GetListenerRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves information about the specified resource configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourceConfiguration service method.</param>
        /// <returns>The response from the GetResourceConfiguration service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/GetResourceConfiguration">REST API Reference for GetResourceConfiguration Operation</seealso>
        GetResourceConfigurationResponse GetResourceConfiguration(GetResourceConfigurationRequest request);
#endif

        /// <summary>
        /// Retrieves information about the specified resource configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourceConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetResourceConfiguration service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/GetResourceConfiguration">REST API Reference for GetResourceConfiguration Operation</seealso>
        Task<GetResourceConfigurationResponse> GetResourceConfigurationAsync(GetResourceConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves information about the specified resource gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourceGateway service method.</param>
        /// <returns>The response from the GetResourceGateway service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/GetResourceGateway">REST API Reference for GetResourceGateway Operation</seealso>
        GetResourceGatewayResponse GetResourceGateway(GetResourceGatewayRequest request);
#endif

        /// <summary>
        /// Retrieves information about the specified resource gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourceGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetResourceGateway service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/GetResourceGateway">REST API Reference for GetResourceGateway Operation</seealso>
        Task<GetResourceGatewayResponse> GetResourceGatewayAsync(GetResourceGatewayRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves information about the specified resource policy. The resource policy is
        /// an IAM policy created on behalf of the resource owner when they share a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePolicy service method.</param>
        /// <returns>The response from the GetResourcePolicy service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/GetResourcePolicy">REST API Reference for GetResourcePolicy Operation</seealso>
        GetResourcePolicyResponse GetResourcePolicy(GetResourcePolicyRequest request);
#endif

        /// <summary>
        /// Retrieves information about the specified resource policy. The resource policy is
        /// an IAM policy created on behalf of the resource owner when they share a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetResourcePolicy service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/GetResourcePolicy">REST API Reference for GetResourcePolicy Operation</seealso>
        Task<GetResourcePolicyResponse> GetResourcePolicyAsync(GetResourcePolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves information about the specified listener rules. You can also retrieve information
        /// about the default listener rule. For more information, see <a href="https://docs.aws.amazon.com/vpc-lattice/latest/ug/listeners.html#listener-rules">Listener
        /// rules</a> in the <i>Amazon VPC Lattice User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRule service method.</param>
        /// <returns>The response from the GetRule service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/GetRule">REST API Reference for GetRule Operation</seealso>
        GetRuleResponse GetRule(GetRuleRequest request);
#endif

        /// <summary>
        /// Retrieves information about the specified listener rules. You can also retrieve information
        /// about the default listener rule. For more information, see <a href="https://docs.aws.amazon.com/vpc-lattice/latest/ug/listeners.html#listener-rules">Listener
        /// rules</a> in the <i>Amazon VPC Lattice User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetRule service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/GetRule">REST API Reference for GetRule Operation</seealso>
        Task<GetRuleResponse> GetRuleAsync(GetRuleRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves information about the specified service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetService service method.</param>
        /// <returns>The response from the GetService service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/GetService">REST API Reference for GetService Operation</seealso>
        GetServiceResponse GetService(GetServiceRequest request);
#endif

        /// <summary>
        /// Retrieves information about the specified service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetService service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetService service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/GetService">REST API Reference for GetService Operation</seealso>
        Task<GetServiceResponse> GetServiceAsync(GetServiceRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves information about the specified service network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServiceNetwork service method.</param>
        /// <returns>The response from the GetServiceNetwork service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/GetServiceNetwork">REST API Reference for GetServiceNetwork Operation</seealso>
        GetServiceNetworkResponse GetServiceNetwork(GetServiceNetworkRequest request);
#endif

        /// <summary>
        /// Retrieves information about the specified service network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServiceNetwork service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetServiceNetwork service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/GetServiceNetwork">REST API Reference for GetServiceNetwork Operation</seealso>
        Task<GetServiceNetworkResponse> GetServiceNetworkAsync(GetServiceNetworkRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves information about the specified association between a service network and
        /// a resource configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServiceNetworkResourceAssociation service method.</param>
        /// <returns>The response from the GetServiceNetworkResourceAssociation service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/GetServiceNetworkResourceAssociation">REST API Reference for GetServiceNetworkResourceAssociation Operation</seealso>
        GetServiceNetworkResourceAssociationResponse GetServiceNetworkResourceAssociation(GetServiceNetworkResourceAssociationRequest request);
#endif

        /// <summary>
        /// Retrieves information about the specified association between a service network and
        /// a resource configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServiceNetworkResourceAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetServiceNetworkResourceAssociation service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/GetServiceNetworkResourceAssociation">REST API Reference for GetServiceNetworkResourceAssociation Operation</seealso>
        Task<GetServiceNetworkResourceAssociationResponse> GetServiceNetworkResourceAssociationAsync(GetServiceNetworkResourceAssociationRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves information about the specified association between a service network and
        /// a service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServiceNetworkServiceAssociation service method.</param>
        /// <returns>The response from the GetServiceNetworkServiceAssociation service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/GetServiceNetworkServiceAssociation">REST API Reference for GetServiceNetworkServiceAssociation Operation</seealso>
        GetServiceNetworkServiceAssociationResponse GetServiceNetworkServiceAssociation(GetServiceNetworkServiceAssociationRequest request);
#endif

        /// <summary>
        /// Retrieves information about the specified association between a service network and
        /// a service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServiceNetworkServiceAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetServiceNetworkServiceAssociation service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/GetServiceNetworkServiceAssociation">REST API Reference for GetServiceNetworkServiceAssociation Operation</seealso>
        Task<GetServiceNetworkServiceAssociationResponse> GetServiceNetworkServiceAssociationAsync(GetServiceNetworkServiceAssociationRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves information about the specified association between a service network and
        /// a VPC.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServiceNetworkVpcAssociation service method.</param>
        /// <returns>The response from the GetServiceNetworkVpcAssociation service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/GetServiceNetworkVpcAssociation">REST API Reference for GetServiceNetworkVpcAssociation Operation</seealso>
        GetServiceNetworkVpcAssociationResponse GetServiceNetworkVpcAssociation(GetServiceNetworkVpcAssociationRequest request);
#endif

        /// <summary>
        /// Retrieves information about the specified association between a service network and
        /// a VPC.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServiceNetworkVpcAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetServiceNetworkVpcAssociation service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/GetServiceNetworkVpcAssociation">REST API Reference for GetServiceNetworkVpcAssociation Operation</seealso>
        Task<GetServiceNetworkVpcAssociationResponse> GetServiceNetworkVpcAssociationAsync(GetServiceNetworkVpcAssociationRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves information about the specified target group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTargetGroup service method.</param>
        /// <returns>The response from the GetTargetGroup service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/GetTargetGroup">REST API Reference for GetTargetGroup Operation</seealso>
        GetTargetGroupResponse GetTargetGroup(GetTargetGroupRequest request);
#endif

        /// <summary>
        /// Retrieves information about the specified target group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTargetGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetTargetGroup service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/GetTargetGroup">REST API Reference for GetTargetGroup Operation</seealso>
        Task<GetTargetGroupResponse> GetTargetGroupAsync(GetTargetGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Lists the access log subscriptions for the specified service network or service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccessLogSubscriptions service method.</param>
        /// <returns>The response from the ListAccessLogSubscriptions service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/ListAccessLogSubscriptions">REST API Reference for ListAccessLogSubscriptions Operation</seealso>
        ListAccessLogSubscriptionsResponse ListAccessLogSubscriptions(ListAccessLogSubscriptionsRequest request);
#endif

        /// <summary>
        /// Lists the access log subscriptions for the specified service network or service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccessLogSubscriptions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListAccessLogSubscriptions service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/ListAccessLogSubscriptions">REST API Reference for ListAccessLogSubscriptions Operation</seealso>
        Task<ListAccessLogSubscriptionsResponse> ListAccessLogSubscriptionsAsync(ListAccessLogSubscriptionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Lists the domain verifications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDomainVerifications service method.</param>
        /// <returns>The response from the ListDomainVerifications service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/ListDomainVerifications">REST API Reference for ListDomainVerifications Operation</seealso>
        ListDomainVerificationsResponse ListDomainVerifications(ListDomainVerificationsRequest request);
#endif

        /// <summary>
        /// Lists the domain verifications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDomainVerifications service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListDomainVerifications service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/ListDomainVerifications">REST API Reference for ListDomainVerifications Operation</seealso>
        Task<ListDomainVerificationsResponse> ListDomainVerificationsAsync(ListDomainVerificationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Lists the listeners for the specified service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListListeners service method.</param>
        /// <returns>The response from the ListListeners service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/ListListeners">REST API Reference for ListListeners Operation</seealso>
        ListListenersResponse ListListeners(ListListenersRequest request);
#endif

        /// <summary>
        /// Lists the listeners for the specified service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListListeners service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListListeners service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/ListListeners">REST API Reference for ListListeners Operation</seealso>
        Task<ListListenersResponse> ListListenersAsync(ListListenersRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Lists the resource configurations owned by or shared with this account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourceConfigurations service method.</param>
        /// <returns>The response from the ListResourceConfigurations service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/ListResourceConfigurations">REST API Reference for ListResourceConfigurations Operation</seealso>
        ListResourceConfigurationsResponse ListResourceConfigurations(ListResourceConfigurationsRequest request);
#endif

        /// <summary>
        /// Lists the resource configurations owned by or shared with this account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourceConfigurations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListResourceConfigurations service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/ListResourceConfigurations">REST API Reference for ListResourceConfigurations Operation</seealso>
        Task<ListResourceConfigurationsResponse> ListResourceConfigurationsAsync(ListResourceConfigurationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Lists the associations for the specified VPC endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourceEndpointAssociations service method.</param>
        /// <returns>The response from the ListResourceEndpointAssociations service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/ListResourceEndpointAssociations">REST API Reference for ListResourceEndpointAssociations Operation</seealso>
        ListResourceEndpointAssociationsResponse ListResourceEndpointAssociations(ListResourceEndpointAssociationsRequest request);
#endif

        /// <summary>
        /// Lists the associations for the specified VPC endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourceEndpointAssociations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListResourceEndpointAssociations service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/ListResourceEndpointAssociations">REST API Reference for ListResourceEndpointAssociations Operation</seealso>
        Task<ListResourceEndpointAssociationsResponse> ListResourceEndpointAssociationsAsync(ListResourceEndpointAssociationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Lists the resource gateways that you own or that were shared with you.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourceGateways service method.</param>
        /// <returns>The response from the ListResourceGateways service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/ListResourceGateways">REST API Reference for ListResourceGateways Operation</seealso>
        ListResourceGatewaysResponse ListResourceGateways(ListResourceGatewaysRequest request);
#endif

        /// <summary>
        /// Lists the resource gateways that you own or that were shared with you.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourceGateways service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListResourceGateways service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/ListResourceGateways">REST API Reference for ListResourceGateways Operation</seealso>
        Task<ListResourceGatewaysResponse> ListResourceGatewaysAsync(ListResourceGatewaysRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Lists the rules for the specified listener.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRules service method.</param>
        /// <returns>The response from the ListRules service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/ListRules">REST API Reference for ListRules Operation</seealso>
        ListRulesResponse ListRules(ListRulesRequest request);
#endif

        /// <summary>
        /// Lists the rules for the specified listener.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRules service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListRules service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/ListRules">REST API Reference for ListRules Operation</seealso>
        Task<ListRulesResponse> ListRulesAsync(ListRulesRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Lists the associations between a service network and a resource configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServiceNetworkResourceAssociations service method.</param>
        /// <returns>The response from the ListServiceNetworkResourceAssociations service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/ListServiceNetworkResourceAssociations">REST API Reference for ListServiceNetworkResourceAssociations Operation</seealso>
        ListServiceNetworkResourceAssociationsResponse ListServiceNetworkResourceAssociations(ListServiceNetworkResourceAssociationsRequest request);
#endif

        /// <summary>
        /// Lists the associations between a service network and a resource configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServiceNetworkResourceAssociations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListServiceNetworkResourceAssociations service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/ListServiceNetworkResourceAssociations">REST API Reference for ListServiceNetworkResourceAssociations Operation</seealso>
        Task<ListServiceNetworkResourceAssociationsResponse> ListServiceNetworkResourceAssociationsAsync(ListServiceNetworkResourceAssociationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Lists the associations between a service network and a service. You can filter the
        /// list either by service or service network. You must provide either the service network
        /// identifier or the service identifier.
        /// 
        ///  
        /// <para>
        /// Every association in Amazon VPC Lattice has a unique Amazon Resource Name (ARN), such
        /// as when a service network is associated with a VPC or when a service is associated
        /// with a service network. If the association is for a resource is shared with another
        /// account, the association includes the local account ID as the prefix in the ARN.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServiceNetworkServiceAssociations service method.</param>
        /// <returns>The response from the ListServiceNetworkServiceAssociations service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/ListServiceNetworkServiceAssociations">REST API Reference for ListServiceNetworkServiceAssociations Operation</seealso>
        ListServiceNetworkServiceAssociationsResponse ListServiceNetworkServiceAssociations(ListServiceNetworkServiceAssociationsRequest request);
#endif

        /// <summary>
        /// Lists the associations between a service network and a service. You can filter the
        /// list either by service or service network. You must provide either the service network
        /// identifier or the service identifier.
        /// 
        ///  
        /// <para>
        /// Every association in Amazon VPC Lattice has a unique Amazon Resource Name (ARN), such
        /// as when a service network is associated with a VPC or when a service is associated
        /// with a service network. If the association is for a resource is shared with another
        /// account, the association includes the local account ID as the prefix in the ARN.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServiceNetworkServiceAssociations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListServiceNetworkServiceAssociations service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/ListServiceNetworkServiceAssociations">REST API Reference for ListServiceNetworkServiceAssociations Operation</seealso>
        Task<ListServiceNetworkServiceAssociationsResponse> ListServiceNetworkServiceAssociationsAsync(ListServiceNetworkServiceAssociationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Lists the associations between a service network and a VPC. You can filter the list
        /// either by VPC or service network. You must provide either the ID of the service network
        /// identifier or the ID of the VPC.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServiceNetworkVpcAssociations service method.</param>
        /// <returns>The response from the ListServiceNetworkVpcAssociations service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/ListServiceNetworkVpcAssociations">REST API Reference for ListServiceNetworkVpcAssociations Operation</seealso>
        ListServiceNetworkVpcAssociationsResponse ListServiceNetworkVpcAssociations(ListServiceNetworkVpcAssociationsRequest request);
#endif

        /// <summary>
        /// Lists the associations between a service network and a VPC. You can filter the list
        /// either by VPC or service network. You must provide either the ID of the service network
        /// identifier or the ID of the VPC.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServiceNetworkVpcAssociations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListServiceNetworkVpcAssociations service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/ListServiceNetworkVpcAssociations">REST API Reference for ListServiceNetworkVpcAssociations Operation</seealso>
        Task<ListServiceNetworkVpcAssociationsResponse> ListServiceNetworkVpcAssociationsAsync(ListServiceNetworkVpcAssociationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Lists the associations between a service network and a VPC endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServiceNetworkVpcEndpointAssociations service method.</param>
        /// <returns>The response from the ListServiceNetworkVpcEndpointAssociations service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/ListServiceNetworkVpcEndpointAssociations">REST API Reference for ListServiceNetworkVpcEndpointAssociations Operation</seealso>
        ListServiceNetworkVpcEndpointAssociationsResponse ListServiceNetworkVpcEndpointAssociations(ListServiceNetworkVpcEndpointAssociationsRequest request);
#endif

        /// <summary>
        /// Lists the associations between a service network and a VPC endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServiceNetworkVpcEndpointAssociations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListServiceNetworkVpcEndpointAssociations service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/ListServiceNetworkVpcEndpointAssociations">REST API Reference for ListServiceNetworkVpcEndpointAssociations Operation</seealso>
        Task<ListServiceNetworkVpcEndpointAssociationsResponse> ListServiceNetworkVpcEndpointAssociationsAsync(ListServiceNetworkVpcEndpointAssociationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Lists the service networks owned by or shared with this account. The account ID in
        /// the ARN shows which account owns the service network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServiceNetworks service method.</param>
        /// <returns>The response from the ListServiceNetworks service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/ListServiceNetworks">REST API Reference for ListServiceNetworks Operation</seealso>
        ListServiceNetworksResponse ListServiceNetworks(ListServiceNetworksRequest request);
#endif

        /// <summary>
        /// Lists the service networks owned by or shared with this account. The account ID in
        /// the ARN shows which account owns the service network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServiceNetworks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListServiceNetworks service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/ListServiceNetworks">REST API Reference for ListServiceNetworks Operation</seealso>
        Task<ListServiceNetworksResponse> ListServiceNetworksAsync(ListServiceNetworksRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Lists the services owned by the caller account or shared with the caller account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServices service method.</param>
        /// <returns>The response from the ListServices service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/ListServices">REST API Reference for ListServices Operation</seealso>
        ListServicesResponse ListServices(ListServicesRequest request);
#endif

        /// <summary>
        /// Lists the services owned by the caller account or shared with the caller account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServices service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListServices service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/ListServices">REST API Reference for ListServices Operation</seealso>
        Task<ListServicesResponse> ListServicesAsync(ListServicesRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Lists the tags for the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <returns>The response from the ListTagsForResource service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);
#endif

        /// <summary>
        /// Lists the tags for the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListTagsForResource service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Lists your target groups. You can narrow your search by using the filters below in
        /// your request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTargetGroups service method.</param>
        /// <returns>The response from the ListTargetGroups service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/ListTargetGroups">REST API Reference for ListTargetGroups Operation</seealso>
        ListTargetGroupsResponse ListTargetGroups(ListTargetGroupsRequest request);
#endif

        /// <summary>
        /// Lists your target groups. You can narrow your search by using the filters below in
        /// your request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTargetGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListTargetGroups service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/ListTargetGroups">REST API Reference for ListTargetGroups Operation</seealso>
        Task<ListTargetGroupsResponse> ListTargetGroupsAsync(ListTargetGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Lists the targets for the target group. By default, all targets are included. You
        /// can use this API to check the health status of targets. You can also ﬁlter the results
        /// by target.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTargets service method.</param>
        /// <returns>The response from the ListTargets service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/ListTargets">REST API Reference for ListTargets Operation</seealso>
        ListTargetsResponse ListTargets(ListTargetsRequest request);
#endif

        /// <summary>
        /// Lists the targets for the target group. By default, all targets are included. You
        /// can use this API to check the health status of targets. You can also ﬁlter the results
        /// by target.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTargets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListTargets service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/ListTargets">REST API Reference for ListTargets Operation</seealso>
        Task<ListTargetsResponse> ListTargetsAsync(ListTargetsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Creates or updates the auth policy. The policy string in JSON must not contain newlines
        /// or blank lines.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/vpc-lattice/latest/ug/auth-policies.html">Auth
        /// policies</a> in the <i>Amazon VPC Lattice User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAuthPolicy service method.</param>
        /// <returns>The response from the PutAuthPolicy service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/PutAuthPolicy">REST API Reference for PutAuthPolicy Operation</seealso>
        PutAuthPolicyResponse PutAuthPolicy(PutAuthPolicyRequest request);
#endif

        /// <summary>
        /// Creates or updates the auth policy. The policy string in JSON must not contain newlines
        /// or blank lines.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/vpc-lattice/latest/ug/auth-policies.html">Auth
        /// policies</a> in the <i>Amazon VPC Lattice User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAuthPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the PutAuthPolicy service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/PutAuthPolicy">REST API Reference for PutAuthPolicy Operation</seealso>
        Task<PutAuthPolicyResponse> PutAuthPolicyAsync(PutAuthPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Attaches a resource-based permission policy to a service or service network. The policy
        /// must contain the same actions and condition statements as the Amazon Web Services
        /// Resource Access Manager permission for sharing services and service networks.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutResourcePolicy service method.</param>
        /// <returns>The response from the PutResourcePolicy service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
        PutResourcePolicyResponse PutResourcePolicy(PutResourcePolicyRequest request);
#endif

        /// <summary>
        /// Attaches a resource-based permission policy to a service or service network. The policy
        /// must contain the same actions and condition statements as the Amazon Web Services
        /// Resource Access Manager permission for sharing services and service networks.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutResourcePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the PutResourcePolicy service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
        Task<PutResourcePolicyResponse> PutResourcePolicyAsync(PutResourcePolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Registers the targets with the target group. If it's a Lambda target, you can only
        /// have one target in a target group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterTargets service method.</param>
        /// <returns>The response from the RegisterTargets service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/RegisterTargets">REST API Reference for RegisterTargets Operation</seealso>
        RegisterTargetsResponse RegisterTargets(RegisterTargetsRequest request);
#endif

        /// <summary>
        /// Registers the targets with the target group. If it's a Lambda target, you can only
        /// have one target in a target group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterTargets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the RegisterTargets service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/RegisterTargets">REST API Reference for RegisterTargets Operation</seealso>
        Task<RegisterTargetsResponse> RegisterTargetsAsync(RegisterTargetsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Starts the domain verification process for a custom domain name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDomainVerification service method.</param>
        /// <returns>The response from the StartDomainVerification service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/StartDomainVerification">REST API Reference for StartDomainVerification Operation</seealso>
        StartDomainVerificationResponse StartDomainVerification(StartDomainVerificationRequest request);
#endif

        /// <summary>
        /// Starts the domain verification process for a custom domain name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDomainVerification service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the StartDomainVerification service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/StartDomainVerification">REST API Reference for StartDomainVerification Operation</seealso>
        Task<StartDomainVerificationResponse> StartDomainVerificationAsync(StartDomainVerificationRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Adds the specified tags to the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <returns>The response from the TagResource service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);
#endif

        /// <summary>
        /// Adds the specified tags to the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the TagResource service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Removes the specified tags from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <returns>The response from the UntagResource service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);
#endif

        /// <summary>
        /// Removes the specified tags from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UntagResource service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Updates the specified access log subscription.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccessLogSubscription service method.</param>
        /// <returns>The response from the UpdateAccessLogSubscription service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/UpdateAccessLogSubscription">REST API Reference for UpdateAccessLogSubscription Operation</seealso>
        UpdateAccessLogSubscriptionResponse UpdateAccessLogSubscription(UpdateAccessLogSubscriptionRequest request);
#endif

        /// <summary>
        /// Updates the specified access log subscription.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccessLogSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateAccessLogSubscription service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/UpdateAccessLogSubscription">REST API Reference for UpdateAccessLogSubscription Operation</seealso>
        Task<UpdateAccessLogSubscriptionResponse> UpdateAccessLogSubscriptionAsync(UpdateAccessLogSubscriptionRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Updates the specified listener for the specified service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateListener service method.</param>
        /// <returns>The response from the UpdateListener service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/UpdateListener">REST API Reference for UpdateListener Operation</seealso>
        UpdateListenerResponse UpdateListener(UpdateListenerRequest request);
#endif

        /// <summary>
        /// Updates the specified listener for the specified service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateListener service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateListener service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/UpdateListener">REST API Reference for UpdateListener Operation</seealso>
        Task<UpdateListenerResponse> UpdateListenerAsync(UpdateListenerRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Updates the specified resource configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateResourceConfiguration service method.</param>
        /// <returns>The response from the UpdateResourceConfiguration service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/UpdateResourceConfiguration">REST API Reference for UpdateResourceConfiguration Operation</seealso>
        UpdateResourceConfigurationResponse UpdateResourceConfiguration(UpdateResourceConfigurationRequest request);
#endif

        /// <summary>
        /// Updates the specified resource configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateResourceConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateResourceConfiguration service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/UpdateResourceConfiguration">REST API Reference for UpdateResourceConfiguration Operation</seealso>
        Task<UpdateResourceConfigurationResponse> UpdateResourceConfigurationAsync(UpdateResourceConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Updates the specified resource gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateResourceGateway service method.</param>
        /// <returns>The response from the UpdateResourceGateway service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/UpdateResourceGateway">REST API Reference for UpdateResourceGateway Operation</seealso>
        UpdateResourceGatewayResponse UpdateResourceGateway(UpdateResourceGatewayRequest request);
#endif

        /// <summary>
        /// Updates the specified resource gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateResourceGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateResourceGateway service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/UpdateResourceGateway">REST API Reference for UpdateResourceGateway Operation</seealso>
        Task<UpdateResourceGatewayResponse> UpdateResourceGatewayAsync(UpdateResourceGatewayRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Updates a specified rule for the listener. You can't modify a default listener rule.
        /// To modify a default listener rule, use <c>UpdateListener</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRule service method.</param>
        /// <returns>The response from the UpdateRule service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/UpdateRule">REST API Reference for UpdateRule Operation</seealso>
        UpdateRuleResponse UpdateRule(UpdateRuleRequest request);
#endif

        /// <summary>
        /// Updates a specified rule for the listener. You can't modify a default listener rule.
        /// To modify a default listener rule, use <c>UpdateListener</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateRule service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/UpdateRule">REST API Reference for UpdateRule Operation</seealso>
        Task<UpdateRuleResponse> UpdateRuleAsync(UpdateRuleRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Updates the specified service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateService service method.</param>
        /// <returns>The response from the UpdateService service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/UpdateService">REST API Reference for UpdateService Operation</seealso>
        UpdateServiceResponse UpdateService(UpdateServiceRequest request);
#endif

        /// <summary>
        /// Updates the specified service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateService service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateService service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/UpdateService">REST API Reference for UpdateService Operation</seealso>
        Task<UpdateServiceResponse> UpdateServiceAsync(UpdateServiceRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Updates the specified service network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateServiceNetwork service method.</param>
        /// <returns>The response from the UpdateServiceNetwork service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/UpdateServiceNetwork">REST API Reference for UpdateServiceNetwork Operation</seealso>
        UpdateServiceNetworkResponse UpdateServiceNetwork(UpdateServiceNetworkRequest request);
#endif

        /// <summary>
        /// Updates the specified service network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateServiceNetwork service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateServiceNetwork service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/UpdateServiceNetwork">REST API Reference for UpdateServiceNetwork Operation</seealso>
        Task<UpdateServiceNetworkResponse> UpdateServiceNetworkAsync(UpdateServiceNetworkRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Updates the service network and VPC association. If you add a security group to the
        /// service network and VPC association, the association must continue to have at least
        /// one security group. You can add or edit security groups at any time. However, to remove
        /// all security groups, you must first delete the association and then recreate it without
        /// security groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateServiceNetworkVpcAssociation service method.</param>
        /// <returns>The response from the UpdateServiceNetworkVpcAssociation service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/UpdateServiceNetworkVpcAssociation">REST API Reference for UpdateServiceNetworkVpcAssociation Operation</seealso>
        UpdateServiceNetworkVpcAssociationResponse UpdateServiceNetworkVpcAssociation(UpdateServiceNetworkVpcAssociationRequest request);
#endif

        /// <summary>
        /// Updates the service network and VPC association. If you add a security group to the
        /// service network and VPC association, the association must continue to have at least
        /// one security group. You can add or edit security groups at any time. However, to remove
        /// all security groups, you must first delete the association and then recreate it without
        /// security groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateServiceNetworkVpcAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateServiceNetworkVpcAssociation service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/UpdateServiceNetworkVpcAssociation">REST API Reference for UpdateServiceNetworkVpcAssociation Operation</seealso>
        Task<UpdateServiceNetworkVpcAssociationResponse> UpdateServiceNetworkVpcAssociationAsync(UpdateServiceNetworkVpcAssociationRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Updates the specified target group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTargetGroup service method.</param>
        /// <returns>The response from the UpdateTargetGroup service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/UpdateTargetGroup">REST API Reference for UpdateTargetGroup Operation</seealso>
        UpdateTargetGroupResponse UpdateTargetGroup(UpdateTargetGroupRequest request);
#endif

        /// <summary>
        /// Updates the specified target group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTargetGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateTargetGroup service method, as returned by VPCLattice.</returns>
        /// <exception cref="Amazon.VPCLattice.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Updating or deleting
        /// a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/UpdateTargetGroup">REST API Reference for UpdateTargetGroup Operation</seealso>
        Task<UpdateTargetGroupResponse> UpdateTargetGroupAsync(UpdateTargetGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonVPCLatticeConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonVPCLatticeConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
            Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonVPCLatticeConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonVPCLatticeConfig to create AmazonVPCLatticeClient");
            }

            return awsCredentials == null ?
                    new AmazonVPCLatticeClient(serviceClientConfig) :
                    new AmazonVPCLatticeClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
    }
}
