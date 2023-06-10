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
 * Do not modify this file. This file is generated from the vpc-lattice-2022-11-30.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.VPCLattice.Model;

namespace Amazon.VPCLattice
{
    /// <summary>
    /// Interface for accessing VPCLattice
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
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IVPCLatticePaginatorFactory Paginators { get; }
#endif
                
        #region  BatchUpdateRule



        /// <summary>
        /// Updates the listener rules in a batch. You can use this operation to change the priority
        /// of listener rules. This can be useful when bulk updating or swapping rule priority.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdateRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
        Task<BatchUpdateRuleResponse> BatchUpdateRuleAsync(BatchUpdateRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateAccessLogSubscription



        /// <summary>
        /// Enables access logs to be sent to Amazon CloudWatch, Amazon S3, and Amazon Kinesis
        /// Data Firehose. The service network owner can use the access logs to audit the services
        /// in the network. The service network owner will only see access logs from clients and
        /// services that are associated with their service network. Access log entries represent
        /// traffic originated from VPCs associated with that network. For more information, see
        /// <a href="https://docs.aws.amazon.com/vpc-lattice/latest/ug/monitoring-access-logs.html">Access
        /// logs</a> in the <i>Amazon VPC Lattice User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAccessLogSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
        Task<CreateAccessLogSubscriptionResponse> CreateAccessLogSubscriptionAsync(CreateAccessLogSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateListener



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
        /// 
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
        Task<CreateListenerResponse> CreateListenerAsync(CreateListenerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateRule



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
        /// 
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
        Task<CreateRuleResponse> CreateRuleAsync(CreateRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateService



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
        /// 
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
        Task<CreateServiceResponse> CreateServiceAsync(CreateServiceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateServiceNetwork



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
        /// 
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
        Task<CreateServiceNetworkResponse> CreateServiceNetworkAsync(CreateServiceNetworkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateServiceNetworkServiceAssociation



        /// <summary>
        /// Associates a service with a service network.
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
        /// 
        /// <returns>The response from the CreateServiceNetworkServiceAssociation service method, as returned by VPCLattice.</returns>
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
        Task<CreateServiceNetworkServiceAssociationResponse> CreateServiceNetworkServiceAssociationAsync(CreateServiceNetworkServiceAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateServiceNetworkVpcAssociation



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
        /// 
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
        Task<CreateServiceNetworkVpcAssociationResponse> CreateServiceNetworkVpcAssociationAsync(CreateServiceNetworkVpcAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateTargetGroup



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
        /// 
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
        Task<CreateTargetGroupResponse> CreateTargetGroupAsync(CreateTargetGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteAccessLogSubscription



        /// <summary>
        /// Deletes the specified access log subscription.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccessLogSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
        Task<DeleteAccessLogSubscriptionResponse> DeleteAccessLogSubscriptionAsync(DeleteAccessLogSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteAuthPolicy



        /// <summary>
        /// Deletes the specified auth policy. If an auth is set to <code>AWS_IAM</code> and the
        /// auth policy is deleted, all requests will be denied by default. If you are trying
        /// to remove the auth policy completely, you must set the auth_type to <code>NONE</code>.
        /// If auth is enabled on the resource, but no auth policy is set, all requests will be
        /// denied.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAuthPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
        Task<DeleteAuthPolicyResponse> DeleteAuthPolicyAsync(DeleteAuthPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteListener



        /// <summary>
        /// Deletes the specified listener.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteListener service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
        Task<DeleteListenerResponse> DeleteListenerAsync(DeleteListenerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteResourcePolicy



        /// <summary>
        /// Deletes the specified resource policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourcePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
        Task<DeleteResourcePolicyResponse> DeleteResourcePolicyAsync(DeleteResourcePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteRule



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
        /// 
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
        Task<DeleteRuleResponse> DeleteRuleAsync(DeleteRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteService



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
        /// 
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
        Task<DeleteServiceResponse> DeleteServiceAsync(DeleteServiceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteServiceNetwork



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
        /// 
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
        Task<DeleteServiceNetworkResponse> DeleteServiceNetworkAsync(DeleteServiceNetworkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteServiceNetworkServiceAssociation



        /// <summary>
        /// Deletes the association between a specified service and the specific service network.
        /// This request will fail if an association is still in progress.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteServiceNetworkServiceAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
        Task<DeleteServiceNetworkServiceAssociationResponse> DeleteServiceNetworkServiceAssociationAsync(DeleteServiceNetworkServiceAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteServiceNetworkVpcAssociation



        /// <summary>
        /// Disassociates the VPC from the service network. You can't disassociate the VPC if
        /// there is a create or update association in progress.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteServiceNetworkVpcAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
        Task<DeleteServiceNetworkVpcAssociationResponse> DeleteServiceNetworkVpcAssociationAsync(DeleteServiceNetworkVpcAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteTargetGroup



        /// <summary>
        /// Deletes a target group. You can't delete a target group if it is used in a listener
        /// rule or if the target group creation is in progress.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTargetGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
        Task<DeleteTargetGroupResponse> DeleteTargetGroupAsync(DeleteTargetGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeregisterTargets



        /// <summary>
        /// Deregisters the specified targets from the specified target group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterTargets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
        Task<DeregisterTargetsResponse> DeregisterTargetsAsync(DeregisterTargetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetAccessLogSubscription



        /// <summary>
        /// Retrieves information about the specified access log subscription.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccessLogSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
        Task<GetAccessLogSubscriptionResponse> GetAccessLogSubscriptionAsync(GetAccessLogSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetAuthPolicy



        /// <summary>
        /// Retrieves information about the auth policy for the specified service or service network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAuthPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
        Task<GetAuthPolicyResponse> GetAuthPolicyAsync(GetAuthPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetListener



        /// <summary>
        /// Retrieves information about the specified listener for the specified service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetListener service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
        Task<GetListenerResponse> GetListenerAsync(GetListenerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetResourcePolicy



        /// <summary>
        /// Retrieves information about the resource policy. The resource policy is an IAM policy
        /// created on behalf of the resource owner when they share a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
        Task<GetResourcePolicyResponse> GetResourcePolicyAsync(GetResourcePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetRule



        /// <summary>
        /// Retrieves information about listener rules. You can also retrieve information about
        /// the default listener rule. For more information, see <a href="https://docs.aws.amazon.com/vpc-lattice/latest/ug/listeners.html#listener-rules">Listener
        /// rules</a> in the <i>Amazon VPC Lattice User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
        Task<GetRuleResponse> GetRuleAsync(GetRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetService



        /// <summary>
        /// Retrieves information about the specified service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetService service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
        Task<GetServiceResponse> GetServiceAsync(GetServiceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetServiceNetwork



        /// <summary>
        /// Retrieves information about the specified service network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServiceNetwork service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
        Task<GetServiceNetworkResponse> GetServiceNetworkAsync(GetServiceNetworkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetServiceNetworkServiceAssociation



        /// <summary>
        /// Retrieves information about the specified association between a service network and
        /// a service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServiceNetworkServiceAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
        Task<GetServiceNetworkServiceAssociationResponse> GetServiceNetworkServiceAssociationAsync(GetServiceNetworkServiceAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetServiceNetworkVpcAssociation



        /// <summary>
        /// Retrieves information about the association between a service network and a VPC.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServiceNetworkVpcAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
        Task<GetServiceNetworkVpcAssociationResponse> GetServiceNetworkVpcAssociationAsync(GetServiceNetworkVpcAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetTargetGroup



        /// <summary>
        /// Retrieves information about the specified target group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTargetGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTargetGroup service method, as returned by VPCLattice.</returns>
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
        Task<GetTargetGroupResponse> GetTargetGroupAsync(GetTargetGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListAccessLogSubscriptions



        /// <summary>
        /// Lists all access log subscriptions for the specified service network or service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccessLogSubscriptions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAccessLogSubscriptions service method, as returned by VPCLattice.</returns>
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
        Task<ListAccessLogSubscriptionsResponse> ListAccessLogSubscriptionsAsync(ListAccessLogSubscriptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListListeners



        /// <summary>
        /// Lists the listeners for the specified service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListListeners service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
        Task<ListListenersResponse> ListListenersAsync(ListListenersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListRules



        /// <summary>
        /// Lists the rules for the listener.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRules service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
        Task<ListRulesResponse> ListRulesAsync(ListRulesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListServiceNetworks



        /// <summary>
        /// Lists the service networks owned by the caller account or shared with the caller account.
        /// Also includes the account ID in the ARN to show which account owns the service network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServiceNetworks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
        Task<ListServiceNetworksResponse> ListServiceNetworksAsync(ListServiceNetworksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListServiceNetworkServiceAssociations



        /// <summary>
        /// Lists the associations between the service network and the service. You can filter
        /// the list either by service or service network. You must provide either the service
        /// network identifier or the service identifier.
        /// 
        ///  
        /// <para>
        /// Every association in Amazon VPC Lattice is given a unique Amazon Resource Name (ARN),
        /// such as when a service network is associated with a VPC or when a service is associated
        /// with a service network. If the association is for a resource that is shared with another
        /// account, the association will include the local account ID as the prefix in the ARN
        /// for each account the resource is shared with.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServiceNetworkServiceAssociations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
        Task<ListServiceNetworkServiceAssociationsResponse> ListServiceNetworkServiceAssociationsAsync(ListServiceNetworkServiceAssociationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListServiceNetworkVpcAssociations



        /// <summary>
        /// Lists the service network and VPC associations. You can filter the list either by
        /// VPC or service network. You must provide either the service network identifier or
        /// the VPC identifier.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServiceNetworkVpcAssociations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
        Task<ListServiceNetworkVpcAssociationsResponse> ListServiceNetworkVpcAssociationsAsync(ListServiceNetworkVpcAssociationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListServices



        /// <summary>
        /// Lists the services owned by the caller account or shared with the caller account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServices service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
        Task<ListServicesResponse> ListServicesAsync(ListServicesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource



        /// <summary>
        /// Lists the tags for the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by VPCLattice.</returns>
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
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTargetGroups



        /// <summary>
        /// Lists your target groups. You can narrow your search by using the filters below in
        /// your request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTargetGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
        Task<ListTargetGroupsResponse> ListTargetGroupsAsync(ListTargetGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTargets



        /// <summary>
        /// Lists the targets for the target group. By default, all targets are included. You
        /// can use this API to check the health status of targets. You can also ﬁlter the results
        /// by target.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTargets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
        Task<ListTargetsResponse> ListTargetsAsync(ListTargetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutAuthPolicy



        /// <summary>
        /// Creates or updates the auth policy. The policy string in JSON must not contain newlines
        /// or blank lines.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAuthPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
        Task<PutAuthPolicyResponse> PutAuthPolicyAsync(PutAuthPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutResourcePolicy



        /// <summary>
        /// Attaches a resource-based permission policy to a service or service network. The policy
        /// must contain the same actions and condition statements as the Amazon Web Services
        /// Resource Access Manager permission for sharing services and service networks.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutResourcePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
        Task<PutResourcePolicyResponse> PutResourcePolicyAsync(PutResourcePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RegisterTargets



        /// <summary>
        /// Registers the targets with the target group. If it's a Lambda target, you can only
        /// have one target in a target group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterTargets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
        Task<RegisterTargetsResponse> RegisterTargetsAsync(RegisterTargetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource



        /// <summary>
        /// Adds the specified tags to the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource



        /// <summary>
        /// Removes the specified tags from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by VPCLattice.</returns>
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
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateAccessLogSubscription



        /// <summary>
        /// Updates the specified access log subscription.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccessLogSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
        Task<UpdateAccessLogSubscriptionResponse> UpdateAccessLogSubscriptionAsync(UpdateAccessLogSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateListener



        /// <summary>
        /// Updates the specified listener for the specified service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateListener service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/UpdateListener">REST API Reference for UpdateListener Operation</seealso>
        Task<UpdateListenerResponse> UpdateListenerAsync(UpdateListenerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateRule



        /// <summary>
        /// Updates a rule for the listener. You can't modify a default listener rule. To modify
        /// a default listener rule, use <code>UpdateListener</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/UpdateRule">REST API Reference for UpdateRule Operation</seealso>
        Task<UpdateRuleResponse> UpdateRuleAsync(UpdateRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateService



        /// <summary>
        /// Updates the specified service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateService service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
        /// <exception cref="Amazon.VPCLattice.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.VPCLattice.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/UpdateService">REST API Reference for UpdateService Operation</seealso>
        Task<UpdateServiceResponse> UpdateServiceAsync(UpdateServiceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateServiceNetwork



        /// <summary>
        /// Updates the specified service network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateServiceNetwork service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
        Task<UpdateServiceNetworkResponse> UpdateServiceNetworkAsync(UpdateServiceNetworkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateServiceNetworkVpcAssociation



        /// <summary>
        /// Updates the service network and VPC association. If you add a security group to the
        /// service network and VPC association, the association must continue to always have
        /// at least one security group. You can add or edit security groups at any time. However,
        /// to remove all security groups, you must first delete the association and recreate
        /// it without security groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateServiceNetworkVpcAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
        Task<UpdateServiceNetworkVpcAssociationResponse> UpdateServiceNetworkVpcAssociationAsync(UpdateServiceNetworkVpcAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateTargetGroup



        /// <summary>
        /// Updates the specified target group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTargetGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateTargetGroup service method, as returned by VPCLattice.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/UpdateTargetGroup">REST API Reference for UpdateTargetGroup Operation</seealso>
        Task<UpdateTargetGroupResponse> UpdateTargetGroupAsync(UpdateTargetGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}