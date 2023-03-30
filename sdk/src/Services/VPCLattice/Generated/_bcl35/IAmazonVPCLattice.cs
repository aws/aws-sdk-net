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


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
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
        BatchUpdateRuleResponse BatchUpdateRule(BatchUpdateRuleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchUpdateRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdateRule operation on AmazonVPCLatticeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchUpdateRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/BatchUpdateRule">REST API Reference for BatchUpdateRule Operation</seealso>
        IAsyncResult BeginBatchUpdateRule(BatchUpdateRuleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchUpdateRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchUpdateRule.</param>
        /// 
        /// <returns>Returns a  BatchUpdateRuleResult from VPCLattice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/BatchUpdateRule">REST API Reference for BatchUpdateRule Operation</seealso>
        BatchUpdateRuleResponse EndBatchUpdateRule(IAsyncResult asyncResult);

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
        CreateAccessLogSubscriptionResponse CreateAccessLogSubscription(CreateAccessLogSubscriptionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAccessLogSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAccessLogSubscription operation on AmazonVPCLatticeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAccessLogSubscription
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/CreateAccessLogSubscription">REST API Reference for CreateAccessLogSubscription Operation</seealso>
        IAsyncResult BeginCreateAccessLogSubscription(CreateAccessLogSubscriptionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAccessLogSubscription operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAccessLogSubscription.</param>
        /// 
        /// <returns>Returns a  CreateAccessLogSubscriptionResult from VPCLattice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/CreateAccessLogSubscription">REST API Reference for CreateAccessLogSubscription Operation</seealso>
        CreateAccessLogSubscriptionResponse EndCreateAccessLogSubscription(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateListener


        /// <summary>
        /// Creates a listener for a service. Before you start using your Amazon VPC Lattice service,
        /// you must add one or more listeners. A listener is a process that checks for connection
        /// requests to your services. For more information, see <a href="https://docs.aws.amazon.com/vpc-lattice/latest/ug/listeners.html">Listeners</a>
        /// in the <i>Amazon VPC Lattice User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateListener service method.</param>
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
        CreateListenerResponse CreateListener(CreateListenerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateListener operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateListener operation on AmazonVPCLatticeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateListener
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/CreateListener">REST API Reference for CreateListener Operation</seealso>
        IAsyncResult BeginCreateListener(CreateListenerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateListener operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateListener.</param>
        /// 
        /// <returns>Returns a  CreateListenerResult from VPCLattice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/CreateListener">REST API Reference for CreateListener Operation</seealso>
        CreateListenerResponse EndCreateListener(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateRule


        /// <summary>
        /// Creates a listener rule. Each listener has a default rule for checking connection
        /// requests, but you can define additional rules. Each rule consists of a priority, one
        /// or more actions, and one or more conditions. For more information, see <a href="https://docs.aws.amazon.com/vpc-lattice/latest/ug/listeners.html#listener-rules">Listener
        /// rules</a> in the <i>Amazon VPC Lattice User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRule service method.</param>
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
        CreateRuleResponse CreateRule(CreateRuleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRule operation on AmazonVPCLatticeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/CreateRule">REST API Reference for CreateRule Operation</seealso>
        IAsyncResult BeginCreateRule(CreateRuleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRule.</param>
        /// 
        /// <returns>Returns a  CreateRuleResult from VPCLattice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/CreateRule">REST API Reference for CreateRule Operation</seealso>
        CreateRuleResponse EndCreateRule(IAsyncResult asyncResult);

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
        CreateServiceResponse CreateService(CreateServiceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateService operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateService operation on AmazonVPCLatticeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateService
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/CreateService">REST API Reference for CreateService Operation</seealso>
        IAsyncResult BeginCreateService(CreateServiceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateService operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateService.</param>
        /// 
        /// <returns>Returns a  CreateServiceResult from VPCLattice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/CreateService">REST API Reference for CreateService Operation</seealso>
        CreateServiceResponse EndCreateService(IAsyncResult asyncResult);

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
        CreateServiceNetworkResponse CreateServiceNetwork(CreateServiceNetworkRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateServiceNetwork operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateServiceNetwork operation on AmazonVPCLatticeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateServiceNetwork
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/CreateServiceNetwork">REST API Reference for CreateServiceNetwork Operation</seealso>
        IAsyncResult BeginCreateServiceNetwork(CreateServiceNetworkRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateServiceNetwork operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateServiceNetwork.</param>
        /// 
        /// <returns>Returns a  CreateServiceNetworkResult from VPCLattice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/CreateServiceNetwork">REST API Reference for CreateServiceNetwork Operation</seealso>
        CreateServiceNetworkResponse EndCreateServiceNetwork(IAsyncResult asyncResult);

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
        CreateServiceNetworkServiceAssociationResponse CreateServiceNetworkServiceAssociation(CreateServiceNetworkServiceAssociationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateServiceNetworkServiceAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateServiceNetworkServiceAssociation operation on AmazonVPCLatticeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateServiceNetworkServiceAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/CreateServiceNetworkServiceAssociation">REST API Reference for CreateServiceNetworkServiceAssociation Operation</seealso>
        IAsyncResult BeginCreateServiceNetworkServiceAssociation(CreateServiceNetworkServiceAssociationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateServiceNetworkServiceAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateServiceNetworkServiceAssociation.</param>
        /// 
        /// <returns>Returns a  CreateServiceNetworkServiceAssociationResult from VPCLattice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/CreateServiceNetworkServiceAssociation">REST API Reference for CreateServiceNetworkServiceAssociation Operation</seealso>
        CreateServiceNetworkServiceAssociationResponse EndCreateServiceNetworkServiceAssociation(IAsyncResult asyncResult);

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
        /// Once a security group is added to the VPC association it cannot be removed. You can
        /// add or update the security groups being used for the VPC association once a security
        /// group is attached. To remove all security groups you must reassociate the VPC.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateServiceNetworkVpcAssociation service method.</param>
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
        CreateServiceNetworkVpcAssociationResponse CreateServiceNetworkVpcAssociation(CreateServiceNetworkVpcAssociationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateServiceNetworkVpcAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateServiceNetworkVpcAssociation operation on AmazonVPCLatticeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateServiceNetworkVpcAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/CreateServiceNetworkVpcAssociation">REST API Reference for CreateServiceNetworkVpcAssociation Operation</seealso>
        IAsyncResult BeginCreateServiceNetworkVpcAssociation(CreateServiceNetworkVpcAssociationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateServiceNetworkVpcAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateServiceNetworkVpcAssociation.</param>
        /// 
        /// <returns>Returns a  CreateServiceNetworkVpcAssociationResult from VPCLattice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/CreateServiceNetworkVpcAssociation">REST API Reference for CreateServiceNetworkVpcAssociation Operation</seealso>
        CreateServiceNetworkVpcAssociationResponse EndCreateServiceNetworkVpcAssociation(IAsyncResult asyncResult);

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
        CreateTargetGroupResponse CreateTargetGroup(CreateTargetGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTargetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTargetGroup operation on AmazonVPCLatticeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateTargetGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/CreateTargetGroup">REST API Reference for CreateTargetGroup Operation</seealso>
        IAsyncResult BeginCreateTargetGroup(CreateTargetGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateTargetGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTargetGroup.</param>
        /// 
        /// <returns>Returns a  CreateTargetGroupResult from VPCLattice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/CreateTargetGroup">REST API Reference for CreateTargetGroup Operation</seealso>
        CreateTargetGroupResponse EndCreateTargetGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteAccessLogSubscription


        /// <summary>
        /// Deletes the specified access log subscription.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccessLogSubscription service method.</param>
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
        DeleteAccessLogSubscriptionResponse DeleteAccessLogSubscription(DeleteAccessLogSubscriptionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAccessLogSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccessLogSubscription operation on AmazonVPCLatticeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAccessLogSubscription
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/DeleteAccessLogSubscription">REST API Reference for DeleteAccessLogSubscription Operation</seealso>
        IAsyncResult BeginDeleteAccessLogSubscription(DeleteAccessLogSubscriptionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAccessLogSubscription operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAccessLogSubscription.</param>
        /// 
        /// <returns>Returns a  DeleteAccessLogSubscriptionResult from VPCLattice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/DeleteAccessLogSubscription">REST API Reference for DeleteAccessLogSubscription Operation</seealso>
        DeleteAccessLogSubscriptionResponse EndDeleteAccessLogSubscription(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteAuthPolicy


        /// <summary>
        /// Deletes the specified auth policy. If an auth is set to <code>Amazon Web Services_IAM</code>
        /// and the auth policy is deleted, all requests will be denied by default. If you are
        /// trying to remove the auth policy completely, you must set the auth_type to <code>NONE</code>.
        /// If auth is enabled on the resource, but no auth policy is set, all requests will be
        /// denied.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAuthPolicy service method.</param>
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
        DeleteAuthPolicyResponse DeleteAuthPolicy(DeleteAuthPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAuthPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAuthPolicy operation on AmazonVPCLatticeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAuthPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/DeleteAuthPolicy">REST API Reference for DeleteAuthPolicy Operation</seealso>
        IAsyncResult BeginDeleteAuthPolicy(DeleteAuthPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAuthPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAuthPolicy.</param>
        /// 
        /// <returns>Returns a  DeleteAuthPolicyResult from VPCLattice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/DeleteAuthPolicy">REST API Reference for DeleteAuthPolicy Operation</seealso>
        DeleteAuthPolicyResponse EndDeleteAuthPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteListener


        /// <summary>
        /// Deletes the specified listener.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteListener service method.</param>
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
        DeleteListenerResponse DeleteListener(DeleteListenerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteListener operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteListener operation on AmazonVPCLatticeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteListener
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/DeleteListener">REST API Reference for DeleteListener Operation</seealso>
        IAsyncResult BeginDeleteListener(DeleteListenerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteListener operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteListener.</param>
        /// 
        /// <returns>Returns a  DeleteListenerResult from VPCLattice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/DeleteListener">REST API Reference for DeleteListener Operation</seealso>
        DeleteListenerResponse EndDeleteListener(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteResourcePolicy


        /// <summary>
        /// Deletes the specified resource policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourcePolicy service method.</param>
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
        DeleteResourcePolicyResponse DeleteResourcePolicy(DeleteResourcePolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourcePolicy operation on AmazonVPCLatticeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteResourcePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/DeleteResourcePolicy">REST API Reference for DeleteResourcePolicy Operation</seealso>
        IAsyncResult BeginDeleteResourcePolicy(DeleteResourcePolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteResourcePolicy.</param>
        /// 
        /// <returns>Returns a  DeleteResourcePolicyResult from VPCLattice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/DeleteResourcePolicy">REST API Reference for DeleteResourcePolicy Operation</seealso>
        DeleteResourcePolicyResponse EndDeleteResourcePolicy(IAsyncResult asyncResult);

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
        DeleteRuleResponse DeleteRule(DeleteRuleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRule operation on AmazonVPCLatticeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/DeleteRule">REST API Reference for DeleteRule Operation</seealso>
        IAsyncResult BeginDeleteRule(DeleteRuleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRule.</param>
        /// 
        /// <returns>Returns a  DeleteRuleResult from VPCLattice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/DeleteRule">REST API Reference for DeleteRule Operation</seealso>
        DeleteRuleResponse EndDeleteRule(IAsyncResult asyncResult);

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
        DeleteServiceResponse DeleteService(DeleteServiceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteService operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteService operation on AmazonVPCLatticeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteService
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/DeleteService">REST API Reference for DeleteService Operation</seealso>
        IAsyncResult BeginDeleteService(DeleteServiceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteService operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteService.</param>
        /// 
        /// <returns>Returns a  DeleteServiceResult from VPCLattice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/DeleteService">REST API Reference for DeleteService Operation</seealso>
        DeleteServiceResponse EndDeleteService(IAsyncResult asyncResult);

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
        DeleteServiceNetworkResponse DeleteServiceNetwork(DeleteServiceNetworkRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteServiceNetwork operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteServiceNetwork operation on AmazonVPCLatticeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteServiceNetwork
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/DeleteServiceNetwork">REST API Reference for DeleteServiceNetwork Operation</seealso>
        IAsyncResult BeginDeleteServiceNetwork(DeleteServiceNetworkRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteServiceNetwork operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteServiceNetwork.</param>
        /// 
        /// <returns>Returns a  DeleteServiceNetworkResult from VPCLattice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/DeleteServiceNetwork">REST API Reference for DeleteServiceNetwork Operation</seealso>
        DeleteServiceNetworkResponse EndDeleteServiceNetwork(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteServiceNetworkServiceAssociation


        /// <summary>
        /// Deletes the association between a specified service and the specific service network.
        /// This request will fail if an association is still in progress.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteServiceNetworkServiceAssociation service method.</param>
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
        DeleteServiceNetworkServiceAssociationResponse DeleteServiceNetworkServiceAssociation(DeleteServiceNetworkServiceAssociationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteServiceNetworkServiceAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteServiceNetworkServiceAssociation operation on AmazonVPCLatticeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteServiceNetworkServiceAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/DeleteServiceNetworkServiceAssociation">REST API Reference for DeleteServiceNetworkServiceAssociation Operation</seealso>
        IAsyncResult BeginDeleteServiceNetworkServiceAssociation(DeleteServiceNetworkServiceAssociationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteServiceNetworkServiceAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteServiceNetworkServiceAssociation.</param>
        /// 
        /// <returns>Returns a  DeleteServiceNetworkServiceAssociationResult from VPCLattice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/DeleteServiceNetworkServiceAssociation">REST API Reference for DeleteServiceNetworkServiceAssociation Operation</seealso>
        DeleteServiceNetworkServiceAssociationResponse EndDeleteServiceNetworkServiceAssociation(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteServiceNetworkVpcAssociation


        /// <summary>
        /// Disassociates the VPC from the service network. You can't disassociate the VPC if
        /// there is a create or update association in progress.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteServiceNetworkVpcAssociation service method.</param>
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
        DeleteServiceNetworkVpcAssociationResponse DeleteServiceNetworkVpcAssociation(DeleteServiceNetworkVpcAssociationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteServiceNetworkVpcAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteServiceNetworkVpcAssociation operation on AmazonVPCLatticeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteServiceNetworkVpcAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/DeleteServiceNetworkVpcAssociation">REST API Reference for DeleteServiceNetworkVpcAssociation Operation</seealso>
        IAsyncResult BeginDeleteServiceNetworkVpcAssociation(DeleteServiceNetworkVpcAssociationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteServiceNetworkVpcAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteServiceNetworkVpcAssociation.</param>
        /// 
        /// <returns>Returns a  DeleteServiceNetworkVpcAssociationResult from VPCLattice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/DeleteServiceNetworkVpcAssociation">REST API Reference for DeleteServiceNetworkVpcAssociation Operation</seealso>
        DeleteServiceNetworkVpcAssociationResponse EndDeleteServiceNetworkVpcAssociation(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteTargetGroup


        /// <summary>
        /// Deletes a target group. You can't delete a target group if it is used in a listener
        /// rule or if the target group creation is in progress.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTargetGroup service method.</param>
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
        DeleteTargetGroupResponse DeleteTargetGroup(DeleteTargetGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTargetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTargetGroup operation on AmazonVPCLatticeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTargetGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/DeleteTargetGroup">REST API Reference for DeleteTargetGroup Operation</seealso>
        IAsyncResult BeginDeleteTargetGroup(DeleteTargetGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTargetGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTargetGroup.</param>
        /// 
        /// <returns>Returns a  DeleteTargetGroupResult from VPCLattice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/DeleteTargetGroup">REST API Reference for DeleteTargetGroup Operation</seealso>
        DeleteTargetGroupResponse EndDeleteTargetGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  DeregisterTargets


        /// <summary>
        /// Deregisters the specified targets from the specified target group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterTargets service method.</param>
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
        DeregisterTargetsResponse DeregisterTargets(DeregisterTargetsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeregisterTargets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterTargets operation on AmazonVPCLatticeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeregisterTargets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/DeregisterTargets">REST API Reference for DeregisterTargets Operation</seealso>
        IAsyncResult BeginDeregisterTargets(DeregisterTargetsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeregisterTargets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeregisterTargets.</param>
        /// 
        /// <returns>Returns a  DeregisterTargetsResult from VPCLattice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/DeregisterTargets">REST API Reference for DeregisterTargets Operation</seealso>
        DeregisterTargetsResponse EndDeregisterTargets(IAsyncResult asyncResult);

        #endregion
        
        #region  GetAccessLogSubscription


        /// <summary>
        /// Retrieves information about the specified access log subscription.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccessLogSubscription service method.</param>
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
        GetAccessLogSubscriptionResponse GetAccessLogSubscription(GetAccessLogSubscriptionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetAccessLogSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAccessLogSubscription operation on AmazonVPCLatticeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAccessLogSubscription
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/GetAccessLogSubscription">REST API Reference for GetAccessLogSubscription Operation</seealso>
        IAsyncResult BeginGetAccessLogSubscription(GetAccessLogSubscriptionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAccessLogSubscription operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAccessLogSubscription.</param>
        /// 
        /// <returns>Returns a  GetAccessLogSubscriptionResult from VPCLattice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/GetAccessLogSubscription">REST API Reference for GetAccessLogSubscription Operation</seealso>
        GetAccessLogSubscriptionResponse EndGetAccessLogSubscription(IAsyncResult asyncResult);

        #endregion
        
        #region  GetAuthPolicy


        /// <summary>
        /// Retrieves information about the auth policy for the specified service or service network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAuthPolicy service method.</param>
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
        GetAuthPolicyResponse GetAuthPolicy(GetAuthPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetAuthPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAuthPolicy operation on AmazonVPCLatticeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAuthPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/GetAuthPolicy">REST API Reference for GetAuthPolicy Operation</seealso>
        IAsyncResult BeginGetAuthPolicy(GetAuthPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAuthPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAuthPolicy.</param>
        /// 
        /// <returns>Returns a  GetAuthPolicyResult from VPCLattice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/GetAuthPolicy">REST API Reference for GetAuthPolicy Operation</seealso>
        GetAuthPolicyResponse EndGetAuthPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  GetListener


        /// <summary>
        /// Retrieves information about the specified listener for the specified service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetListener service method.</param>
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
        GetListenerResponse GetListener(GetListenerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetListener operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetListener operation on AmazonVPCLatticeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetListener
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/GetListener">REST API Reference for GetListener Operation</seealso>
        IAsyncResult BeginGetListener(GetListenerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetListener operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetListener.</param>
        /// 
        /// <returns>Returns a  GetListenerResult from VPCLattice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/GetListener">REST API Reference for GetListener Operation</seealso>
        GetListenerResponse EndGetListener(IAsyncResult asyncResult);

        #endregion
        
        #region  GetResourcePolicy


        /// <summary>
        /// Retrieves information about the resource policy. The resource policy is an IAM policy
        /// created by AWS RAM on behalf of the resource owner when they share a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePolicy service method.</param>
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
        GetResourcePolicyResponse GetResourcePolicy(GetResourcePolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePolicy operation on AmazonVPCLatticeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetResourcePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/GetResourcePolicy">REST API Reference for GetResourcePolicy Operation</seealso>
        IAsyncResult BeginGetResourcePolicy(GetResourcePolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetResourcePolicy.</param>
        /// 
        /// <returns>Returns a  GetResourcePolicyResult from VPCLattice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/GetResourcePolicy">REST API Reference for GetResourcePolicy Operation</seealso>
        GetResourcePolicyResponse EndGetResourcePolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  GetRule


        /// <summary>
        /// Retrieves information about listener rules. You can also retrieve information about
        /// the default listener rule. For more information, see <a href="https://docs.aws.amazon.com/vpc-lattice/latest/ug/listeners.html#listener-rules">Listener
        /// rules</a> in the <i>Amazon VPC Lattice User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRule service method.</param>
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
        GetRuleResponse GetRule(GetRuleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRule operation on AmazonVPCLatticeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/GetRule">REST API Reference for GetRule Operation</seealso>
        IAsyncResult BeginGetRule(GetRuleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRule.</param>
        /// 
        /// <returns>Returns a  GetRuleResult from VPCLattice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/GetRule">REST API Reference for GetRule Operation</seealso>
        GetRuleResponse EndGetRule(IAsyncResult asyncResult);

        #endregion
        
        #region  GetService


        /// <summary>
        /// Retrieves information about the specified service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetService service method.</param>
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
        GetServiceResponse GetService(GetServiceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetService operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetService operation on AmazonVPCLatticeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetService
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/GetService">REST API Reference for GetService Operation</seealso>
        IAsyncResult BeginGetService(GetServiceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetService operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetService.</param>
        /// 
        /// <returns>Returns a  GetServiceResult from VPCLattice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/GetService">REST API Reference for GetService Operation</seealso>
        GetServiceResponse EndGetService(IAsyncResult asyncResult);

        #endregion
        
        #region  GetServiceNetwork


        /// <summary>
        /// Retrieves information about the specified service network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServiceNetwork service method.</param>
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
        GetServiceNetworkResponse GetServiceNetwork(GetServiceNetworkRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetServiceNetwork operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetServiceNetwork operation on AmazonVPCLatticeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetServiceNetwork
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/GetServiceNetwork">REST API Reference for GetServiceNetwork Operation</seealso>
        IAsyncResult BeginGetServiceNetwork(GetServiceNetworkRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetServiceNetwork operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetServiceNetwork.</param>
        /// 
        /// <returns>Returns a  GetServiceNetworkResult from VPCLattice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/GetServiceNetwork">REST API Reference for GetServiceNetwork Operation</seealso>
        GetServiceNetworkResponse EndGetServiceNetwork(IAsyncResult asyncResult);

        #endregion
        
        #region  GetServiceNetworkServiceAssociation


        /// <summary>
        /// Retrieves information about the specified association between a service network and
        /// a service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServiceNetworkServiceAssociation service method.</param>
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
        GetServiceNetworkServiceAssociationResponse GetServiceNetworkServiceAssociation(GetServiceNetworkServiceAssociationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetServiceNetworkServiceAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetServiceNetworkServiceAssociation operation on AmazonVPCLatticeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetServiceNetworkServiceAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/GetServiceNetworkServiceAssociation">REST API Reference for GetServiceNetworkServiceAssociation Operation</seealso>
        IAsyncResult BeginGetServiceNetworkServiceAssociation(GetServiceNetworkServiceAssociationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetServiceNetworkServiceAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetServiceNetworkServiceAssociation.</param>
        /// 
        /// <returns>Returns a  GetServiceNetworkServiceAssociationResult from VPCLattice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/GetServiceNetworkServiceAssociation">REST API Reference for GetServiceNetworkServiceAssociation Operation</seealso>
        GetServiceNetworkServiceAssociationResponse EndGetServiceNetworkServiceAssociation(IAsyncResult asyncResult);

        #endregion
        
        #region  GetServiceNetworkVpcAssociation


        /// <summary>
        /// Retrieves information about the association between a service network and a VPC.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServiceNetworkVpcAssociation service method.</param>
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
        GetServiceNetworkVpcAssociationResponse GetServiceNetworkVpcAssociation(GetServiceNetworkVpcAssociationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetServiceNetworkVpcAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetServiceNetworkVpcAssociation operation on AmazonVPCLatticeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetServiceNetworkVpcAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/GetServiceNetworkVpcAssociation">REST API Reference for GetServiceNetworkVpcAssociation Operation</seealso>
        IAsyncResult BeginGetServiceNetworkVpcAssociation(GetServiceNetworkVpcAssociationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetServiceNetworkVpcAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetServiceNetworkVpcAssociation.</param>
        /// 
        /// <returns>Returns a  GetServiceNetworkVpcAssociationResult from VPCLattice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/GetServiceNetworkVpcAssociation">REST API Reference for GetServiceNetworkVpcAssociation Operation</seealso>
        GetServiceNetworkVpcAssociationResponse EndGetServiceNetworkVpcAssociation(IAsyncResult asyncResult);

        #endregion
        
        #region  GetTargetGroup


        /// <summary>
        /// Retrieves information about the specified target group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTargetGroup service method.</param>
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
        GetTargetGroupResponse GetTargetGroup(GetTargetGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetTargetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTargetGroup operation on AmazonVPCLatticeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTargetGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/GetTargetGroup">REST API Reference for GetTargetGroup Operation</seealso>
        IAsyncResult BeginGetTargetGroup(GetTargetGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetTargetGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTargetGroup.</param>
        /// 
        /// <returns>Returns a  GetTargetGroupResult from VPCLattice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/GetTargetGroup">REST API Reference for GetTargetGroup Operation</seealso>
        GetTargetGroupResponse EndGetTargetGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAccessLogSubscriptions


        /// <summary>
        /// Lists all access log subscriptions for the specified service network or service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccessLogSubscriptions service method.</param>
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
        ListAccessLogSubscriptionsResponse ListAccessLogSubscriptions(ListAccessLogSubscriptionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAccessLogSubscriptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAccessLogSubscriptions operation on AmazonVPCLatticeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAccessLogSubscriptions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/ListAccessLogSubscriptions">REST API Reference for ListAccessLogSubscriptions Operation</seealso>
        IAsyncResult BeginListAccessLogSubscriptions(ListAccessLogSubscriptionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAccessLogSubscriptions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAccessLogSubscriptions.</param>
        /// 
        /// <returns>Returns a  ListAccessLogSubscriptionsResult from VPCLattice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/ListAccessLogSubscriptions">REST API Reference for ListAccessLogSubscriptions Operation</seealso>
        ListAccessLogSubscriptionsResponse EndListAccessLogSubscriptions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListListeners


        /// <summary>
        /// Lists the listeners for the specified service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListListeners service method.</param>
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
        ListListenersResponse ListListeners(ListListenersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListListeners operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListListeners operation on AmazonVPCLatticeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListListeners
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/ListListeners">REST API Reference for ListListeners Operation</seealso>
        IAsyncResult BeginListListeners(ListListenersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListListeners operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListListeners.</param>
        /// 
        /// <returns>Returns a  ListListenersResult from VPCLattice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/ListListeners">REST API Reference for ListListeners Operation</seealso>
        ListListenersResponse EndListListeners(IAsyncResult asyncResult);

        #endregion
        
        #region  ListRules


        /// <summary>
        /// Lists the rules for the listener.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRules service method.</param>
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
        ListRulesResponse ListRules(ListRulesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListRules operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRules operation on AmazonVPCLatticeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRules
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/ListRules">REST API Reference for ListRules Operation</seealso>
        IAsyncResult BeginListRules(ListRulesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListRules operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRules.</param>
        /// 
        /// <returns>Returns a  ListRulesResult from VPCLattice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/ListRules">REST API Reference for ListRules Operation</seealso>
        ListRulesResponse EndListRules(IAsyncResult asyncResult);

        #endregion
        
        #region  ListServiceNetworks


        /// <summary>
        /// Lists the service networks owned by the caller account or shared with the caller account.
        /// Also includes the account ID in the ARN to show which account owns the service network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServiceNetworks service method.</param>
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
        ListServiceNetworksResponse ListServiceNetworks(ListServiceNetworksRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListServiceNetworks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListServiceNetworks operation on AmazonVPCLatticeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListServiceNetworks
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/ListServiceNetworks">REST API Reference for ListServiceNetworks Operation</seealso>
        IAsyncResult BeginListServiceNetworks(ListServiceNetworksRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListServiceNetworks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListServiceNetworks.</param>
        /// 
        /// <returns>Returns a  ListServiceNetworksResult from VPCLattice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/ListServiceNetworks">REST API Reference for ListServiceNetworks Operation</seealso>
        ListServiceNetworksResponse EndListServiceNetworks(IAsyncResult asyncResult);

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
        ListServiceNetworkServiceAssociationsResponse ListServiceNetworkServiceAssociations(ListServiceNetworkServiceAssociationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListServiceNetworkServiceAssociations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListServiceNetworkServiceAssociations operation on AmazonVPCLatticeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListServiceNetworkServiceAssociations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/ListServiceNetworkServiceAssociations">REST API Reference for ListServiceNetworkServiceAssociations Operation</seealso>
        IAsyncResult BeginListServiceNetworkServiceAssociations(ListServiceNetworkServiceAssociationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListServiceNetworkServiceAssociations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListServiceNetworkServiceAssociations.</param>
        /// 
        /// <returns>Returns a  ListServiceNetworkServiceAssociationsResult from VPCLattice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/ListServiceNetworkServiceAssociations">REST API Reference for ListServiceNetworkServiceAssociations Operation</seealso>
        ListServiceNetworkServiceAssociationsResponse EndListServiceNetworkServiceAssociations(IAsyncResult asyncResult);

        #endregion
        
        #region  ListServiceNetworkVpcAssociations


        /// <summary>
        /// Lists the service network and VPC associations. You can filter the list either by
        /// VPC or service network. You must provide either the service network identifier or
        /// the VPC identifier.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServiceNetworkVpcAssociations service method.</param>
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
        ListServiceNetworkVpcAssociationsResponse ListServiceNetworkVpcAssociations(ListServiceNetworkVpcAssociationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListServiceNetworkVpcAssociations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListServiceNetworkVpcAssociations operation on AmazonVPCLatticeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListServiceNetworkVpcAssociations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/ListServiceNetworkVpcAssociations">REST API Reference for ListServiceNetworkVpcAssociations Operation</seealso>
        IAsyncResult BeginListServiceNetworkVpcAssociations(ListServiceNetworkVpcAssociationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListServiceNetworkVpcAssociations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListServiceNetworkVpcAssociations.</param>
        /// 
        /// <returns>Returns a  ListServiceNetworkVpcAssociationsResult from VPCLattice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/ListServiceNetworkVpcAssociations">REST API Reference for ListServiceNetworkVpcAssociations Operation</seealso>
        ListServiceNetworkVpcAssociationsResponse EndListServiceNetworkVpcAssociations(IAsyncResult asyncResult);

        #endregion
        
        #region  ListServices


        /// <summary>
        /// Lists the services owned by the caller account or shared with the caller account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServices service method.</param>
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
        ListServicesResponse ListServices(ListServicesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListServices operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListServices operation on AmazonVPCLatticeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListServices
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/ListServices">REST API Reference for ListServices Operation</seealso>
        IAsyncResult BeginListServices(ListServicesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListServices operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListServices.</param>
        /// 
        /// <returns>Returns a  ListServicesResult from VPCLattice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/ListServices">REST API Reference for ListServices Operation</seealso>
        ListServicesResponse EndListServices(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists the tags for the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
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
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonVPCLatticeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from VPCLattice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTargetGroups


        /// <summary>
        /// Lists your target groups. You can narrow your search by using the filters below in
        /// your request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTargetGroups service method.</param>
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
        ListTargetGroupsResponse ListTargetGroups(ListTargetGroupsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTargetGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTargetGroups operation on AmazonVPCLatticeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTargetGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/ListTargetGroups">REST API Reference for ListTargetGroups Operation</seealso>
        IAsyncResult BeginListTargetGroups(ListTargetGroupsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTargetGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTargetGroups.</param>
        /// 
        /// <returns>Returns a  ListTargetGroupsResult from VPCLattice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/ListTargetGroups">REST API Reference for ListTargetGroups Operation</seealso>
        ListTargetGroupsResponse EndListTargetGroups(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTargets


        /// <summary>
        /// Lists the targets for the target group. By default, all targets are included. You
        /// can use this API to check the health status of targets. You can also ﬁlter the results
        /// by target.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTargets service method.</param>
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
        ListTargetsResponse ListTargets(ListTargetsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTargets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTargets operation on AmazonVPCLatticeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTargets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/ListTargets">REST API Reference for ListTargets Operation</seealso>
        IAsyncResult BeginListTargets(ListTargetsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTargets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTargets.</param>
        /// 
        /// <returns>Returns a  ListTargetsResult from VPCLattice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/ListTargets">REST API Reference for ListTargets Operation</seealso>
        ListTargetsResponse EndListTargets(IAsyncResult asyncResult);

        #endregion
        
        #region  PutAuthPolicy


        /// <summary>
        /// Creates or updates the auth policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAuthPolicy service method.</param>
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
        PutAuthPolicyResponse PutAuthPolicy(PutAuthPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutAuthPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutAuthPolicy operation on AmazonVPCLatticeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutAuthPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/PutAuthPolicy">REST API Reference for PutAuthPolicy Operation</seealso>
        IAsyncResult BeginPutAuthPolicy(PutAuthPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutAuthPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutAuthPolicy.</param>
        /// 
        /// <returns>Returns a  PutAuthPolicyResult from VPCLattice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/PutAuthPolicy">REST API Reference for PutAuthPolicy Operation</seealso>
        PutAuthPolicyResponse EndPutAuthPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  PutResourcePolicy


        /// <summary>
        /// Attaches a resource-based permission policy to a service or service network. The policy
        /// must contain the same actions and condition statements as the Amazon Web Services
        /// Resource Access Manager permission for sharing services and service networks.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutResourcePolicy service method.</param>
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
        PutResourcePolicyResponse PutResourcePolicy(PutResourcePolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutResourcePolicy operation on AmazonVPCLatticeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutResourcePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
        IAsyncResult BeginPutResourcePolicy(PutResourcePolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutResourcePolicy.</param>
        /// 
        /// <returns>Returns a  PutResourcePolicyResult from VPCLattice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
        PutResourcePolicyResponse EndPutResourcePolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  RegisterTargets


        /// <summary>
        /// Registers the targets with the target group. If it's a Lambda target, you can only
        /// have one target in a target group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterTargets service method.</param>
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
        RegisterTargetsResponse RegisterTargets(RegisterTargetsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RegisterTargets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterTargets operation on AmazonVPCLatticeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRegisterTargets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/RegisterTargets">REST API Reference for RegisterTargets Operation</seealso>
        IAsyncResult BeginRegisterTargets(RegisterTargetsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RegisterTargets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterTargets.</param>
        /// 
        /// <returns>Returns a  RegisterTargetsResult from VPCLattice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/RegisterTargets">REST API Reference for RegisterTargets Operation</seealso>
        RegisterTargetsResponse EndRegisterTargets(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds the specified tags to the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
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
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonVPCLatticeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from VPCLattice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes the specified tags from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
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
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonVPCLatticeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from VPCLattice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateAccessLogSubscription


        /// <summary>
        /// Updates the specified access log subscription.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccessLogSubscription service method.</param>
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
        UpdateAccessLogSubscriptionResponse UpdateAccessLogSubscription(UpdateAccessLogSubscriptionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAccessLogSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccessLogSubscription operation on AmazonVPCLatticeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAccessLogSubscription
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/UpdateAccessLogSubscription">REST API Reference for UpdateAccessLogSubscription Operation</seealso>
        IAsyncResult BeginUpdateAccessLogSubscription(UpdateAccessLogSubscriptionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAccessLogSubscription operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAccessLogSubscription.</param>
        /// 
        /// <returns>Returns a  UpdateAccessLogSubscriptionResult from VPCLattice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/UpdateAccessLogSubscription">REST API Reference for UpdateAccessLogSubscription Operation</seealso>
        UpdateAccessLogSubscriptionResponse EndUpdateAccessLogSubscription(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateListener


        /// <summary>
        /// Updates the specified listener for the specified service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateListener service method.</param>
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
        UpdateListenerResponse UpdateListener(UpdateListenerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateListener operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateListener operation on AmazonVPCLatticeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateListener
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/UpdateListener">REST API Reference for UpdateListener Operation</seealso>
        IAsyncResult BeginUpdateListener(UpdateListenerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateListener operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateListener.</param>
        /// 
        /// <returns>Returns a  UpdateListenerResult from VPCLattice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/UpdateListener">REST API Reference for UpdateListener Operation</seealso>
        UpdateListenerResponse EndUpdateListener(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateRule


        /// <summary>
        /// Updates a rule for the listener. You can't modify a default listener rule. To modify
        /// a default listener rule, use <code>UpdateListener</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRule service method.</param>
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
        UpdateRuleResponse UpdateRule(UpdateRuleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRule operation on AmazonVPCLatticeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/UpdateRule">REST API Reference for UpdateRule Operation</seealso>
        IAsyncResult BeginUpdateRule(UpdateRuleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRule.</param>
        /// 
        /// <returns>Returns a  UpdateRuleResult from VPCLattice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/UpdateRule">REST API Reference for UpdateRule Operation</seealso>
        UpdateRuleResponse EndUpdateRule(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateService


        /// <summary>
        /// Updates the specified service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateService service method.</param>
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
        UpdateServiceResponse UpdateService(UpdateServiceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateService operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateService operation on AmazonVPCLatticeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateService
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/UpdateService">REST API Reference for UpdateService Operation</seealso>
        IAsyncResult BeginUpdateService(UpdateServiceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateService operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateService.</param>
        /// 
        /// <returns>Returns a  UpdateServiceResult from VPCLattice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/UpdateService">REST API Reference for UpdateService Operation</seealso>
        UpdateServiceResponse EndUpdateService(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateServiceNetwork


        /// <summary>
        /// Updates the specified service network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateServiceNetwork service method.</param>
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
        UpdateServiceNetworkResponse UpdateServiceNetwork(UpdateServiceNetworkRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateServiceNetwork operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateServiceNetwork operation on AmazonVPCLatticeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateServiceNetwork
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/UpdateServiceNetwork">REST API Reference for UpdateServiceNetwork Operation</seealso>
        IAsyncResult BeginUpdateServiceNetwork(UpdateServiceNetworkRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateServiceNetwork operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateServiceNetwork.</param>
        /// 
        /// <returns>Returns a  UpdateServiceNetworkResult from VPCLattice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/UpdateServiceNetwork">REST API Reference for UpdateServiceNetwork Operation</seealso>
        UpdateServiceNetworkResponse EndUpdateServiceNetwork(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateServiceNetworkVpcAssociation


        /// <summary>
        /// Updates the service network and VPC association. Once you add a security group, it
        /// cannot be removed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateServiceNetworkVpcAssociation service method.</param>
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
        UpdateServiceNetworkVpcAssociationResponse UpdateServiceNetworkVpcAssociation(UpdateServiceNetworkVpcAssociationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateServiceNetworkVpcAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateServiceNetworkVpcAssociation operation on AmazonVPCLatticeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateServiceNetworkVpcAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/UpdateServiceNetworkVpcAssociation">REST API Reference for UpdateServiceNetworkVpcAssociation Operation</seealso>
        IAsyncResult BeginUpdateServiceNetworkVpcAssociation(UpdateServiceNetworkVpcAssociationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateServiceNetworkVpcAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateServiceNetworkVpcAssociation.</param>
        /// 
        /// <returns>Returns a  UpdateServiceNetworkVpcAssociationResult from VPCLattice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/UpdateServiceNetworkVpcAssociation">REST API Reference for UpdateServiceNetworkVpcAssociation Operation</seealso>
        UpdateServiceNetworkVpcAssociationResponse EndUpdateServiceNetworkVpcAssociation(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateTargetGroup


        /// <summary>
        /// Updates the specified target group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTargetGroup service method.</param>
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
        UpdateTargetGroupResponse UpdateTargetGroup(UpdateTargetGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTargetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTargetGroup operation on AmazonVPCLatticeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateTargetGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/UpdateTargetGroup">REST API Reference for UpdateTargetGroup Operation</seealso>
        IAsyncResult BeginUpdateTargetGroup(UpdateTargetGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateTargetGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateTargetGroup.</param>
        /// 
        /// <returns>Returns a  UpdateTargetGroupResult from VPCLattice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/vpc-lattice-2022-11-30/UpdateTargetGroup">REST API Reference for UpdateTargetGroup Operation</seealso>
        UpdateTargetGroupResponse EndUpdateTargetGroup(IAsyncResult asyncResult);

        #endregion
        
    }
}