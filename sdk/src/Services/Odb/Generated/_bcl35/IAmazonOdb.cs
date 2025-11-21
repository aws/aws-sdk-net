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
 * Do not modify this file. This file is generated from the odb-2024-08-20.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Odb.Model;

#pragma warning disable CS1570
namespace Amazon.Odb
{
    /// <summary>
    /// <para>Interface for accessing Odb</para>
    ///
    /// Oracle Database@Amazon Web Services is an offering that enables you to access Oracle
    /// Exadata infrastructure managed by Oracle Cloud Infrastructure (OCI) inside Amazon
    /// Web Services data centers. You can migrate your Oracle Exadata workloads, establish
    /// low-latency connectivity with applications running on Amazon Web Services, and integrate
    /// with Amazon Web Services services. For example, you can run application servers in
    /// a Virtual Private Cloud (VPC) and access an Oracle Exadata system running in Oracle
    /// Database@Amazon Web Services. You can get started with Oracle Database@Amazon Web
    /// Services by using the familiar Amazon Web Services Management Console, APIs, or CLI.
    /// 
    ///  
    /// <para>
    /// This interface reference for Oracle Database@Amazon Web Services contains documentation
    /// for a programming or command line interface that you can use to manage Oracle Database@Amazon
    /// Web Services. Oracle Database@Amazon Web Services is asynchronous, which means that
    /// some interfaces might require techniques such as polling or callback functions to
    /// determine when a command has been applied. The reference structure is as follows.
    /// </para>
    ///  
    /// <para>
    ///  <b>Oracle Database@Amazon Web Services API Reference</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// For the alphabetical list of API actions, see <a href="https://docs.aws.amazon.com/odb/latest/APIReference/API_Operations.html">API
    /// Actions</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For the alphabetical list of data types, see <a href="https://docs.aws.amazon.com/odb/latest/APIReference/API_Types.html">Data
    /// Types</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For a list of common query parameters, see <a href="https://docs.aws.amazon.com/odb/latest/APIReference/CommonParameters.html">Common
    /// Parameters</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For descriptions of the error codes, see <a href="https://docs.aws.amazon.com/odb/latest/APIReference/CommonErrors.html">Common
    /// Errors</a>.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial interface IAmazonOdb : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IOdbPaginatorFactory Paginators { get; }
#endif


        
        #region  AcceptMarketplaceRegistration


        /// <summary>
        /// Registers the Amazon Web Services Marketplace token for your Amazon Web Services account
        /// to activate your Oracle Database@Amazon Web Services subscription.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptMarketplaceRegistration service method.</param>
        /// 
        /// <returns>The response from the AcceptMarketplaceRegistration service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ConflictException">
        /// Occurs when a conflict with the current status of your resource. Fix any inconsistencies
        /// with your resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/AcceptMarketplaceRegistration">REST API Reference for AcceptMarketplaceRegistration Operation</seealso>
        AcceptMarketplaceRegistrationResponse AcceptMarketplaceRegistration(AcceptMarketplaceRegistrationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AcceptMarketplaceRegistration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AcceptMarketplaceRegistration operation on AmazonOdbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAcceptMarketplaceRegistration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/AcceptMarketplaceRegistration">REST API Reference for AcceptMarketplaceRegistration Operation</seealso>
        IAsyncResult BeginAcceptMarketplaceRegistration(AcceptMarketplaceRegistrationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AcceptMarketplaceRegistration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAcceptMarketplaceRegistration.</param>
        /// 
        /// <returns>Returns a  AcceptMarketplaceRegistrationResult from Odb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/AcceptMarketplaceRegistration">REST API Reference for AcceptMarketplaceRegistration Operation</seealso>
        AcceptMarketplaceRegistrationResponse EndAcceptMarketplaceRegistration(IAsyncResult asyncResult);

        #endregion
        
        #region  AssociateIamRoleToResource


        /// <summary>
        /// Associates an Amazon Web Services Identity and Access Management (IAM) service role
        /// with a specified resource to enable Amazon Web Services service integration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateIamRoleToResource service method.</param>
        /// 
        /// <returns>The response from the AssociateIamRoleToResource service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ConflictException">
        /// Occurs when a conflict with the current status of your resource. Fix any inconsistencies
        /// with your resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/AssociateIamRoleToResource">REST API Reference for AssociateIamRoleToResource Operation</seealso>
        AssociateIamRoleToResourceResponse AssociateIamRoleToResource(AssociateIamRoleToResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateIamRoleToResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateIamRoleToResource operation on AmazonOdbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateIamRoleToResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/AssociateIamRoleToResource">REST API Reference for AssociateIamRoleToResource Operation</seealso>
        IAsyncResult BeginAssociateIamRoleToResource(AssociateIamRoleToResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateIamRoleToResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateIamRoleToResource.</param>
        /// 
        /// <returns>Returns a  AssociateIamRoleToResourceResult from Odb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/AssociateIamRoleToResource">REST API Reference for AssociateIamRoleToResource Operation</seealso>
        AssociateIamRoleToResourceResponse EndAssociateIamRoleToResource(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateCloudAutonomousVmCluster


        /// <summary>
        /// Creates a new Autonomous VM cluster in the specified Exadata infrastructure.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCloudAutonomousVmCluster service method.</param>
        /// 
        /// <returns>The response from the CreateCloudAutonomousVmCluster service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ConflictException">
        /// Occurs when a conflict with the current status of your resource. Fix any inconsistencies
        /// with your resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ServiceQuotaExceededException">
        /// You have exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/CreateCloudAutonomousVmCluster">REST API Reference for CreateCloudAutonomousVmCluster Operation</seealso>
        CreateCloudAutonomousVmClusterResponse CreateCloudAutonomousVmCluster(CreateCloudAutonomousVmClusterRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCloudAutonomousVmCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCloudAutonomousVmCluster operation on AmazonOdbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCloudAutonomousVmCluster
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/CreateCloudAutonomousVmCluster">REST API Reference for CreateCloudAutonomousVmCluster Operation</seealso>
        IAsyncResult BeginCreateCloudAutonomousVmCluster(CreateCloudAutonomousVmClusterRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCloudAutonomousVmCluster operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCloudAutonomousVmCluster.</param>
        /// 
        /// <returns>Returns a  CreateCloudAutonomousVmClusterResult from Odb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/CreateCloudAutonomousVmCluster">REST API Reference for CreateCloudAutonomousVmCluster Operation</seealso>
        CreateCloudAutonomousVmClusterResponse EndCreateCloudAutonomousVmCluster(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateCloudExadataInfrastructure


        /// <summary>
        /// Creates an Exadata infrastructure.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCloudExadataInfrastructure service method.</param>
        /// 
        /// <returns>The response from the CreateCloudExadataInfrastructure service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ConflictException">
        /// Occurs when a conflict with the current status of your resource. Fix any inconsistencies
        /// with your resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ServiceQuotaExceededException">
        /// You have exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/CreateCloudExadataInfrastructure">REST API Reference for CreateCloudExadataInfrastructure Operation</seealso>
        CreateCloudExadataInfrastructureResponse CreateCloudExadataInfrastructure(CreateCloudExadataInfrastructureRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCloudExadataInfrastructure operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCloudExadataInfrastructure operation on AmazonOdbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCloudExadataInfrastructure
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/CreateCloudExadataInfrastructure">REST API Reference for CreateCloudExadataInfrastructure Operation</seealso>
        IAsyncResult BeginCreateCloudExadataInfrastructure(CreateCloudExadataInfrastructureRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCloudExadataInfrastructure operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCloudExadataInfrastructure.</param>
        /// 
        /// <returns>Returns a  CreateCloudExadataInfrastructureResult from Odb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/CreateCloudExadataInfrastructure">REST API Reference for CreateCloudExadataInfrastructure Operation</seealso>
        CreateCloudExadataInfrastructureResponse EndCreateCloudExadataInfrastructure(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateCloudVmCluster


        /// <summary>
        /// Creates a VM cluster on the specified Exadata infrastructure.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCloudVmCluster service method.</param>
        /// 
        /// <returns>The response from the CreateCloudVmCluster service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ConflictException">
        /// Occurs when a conflict with the current status of your resource. Fix any inconsistencies
        /// with your resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ServiceQuotaExceededException">
        /// You have exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/CreateCloudVmCluster">REST API Reference for CreateCloudVmCluster Operation</seealso>
        CreateCloudVmClusterResponse CreateCloudVmCluster(CreateCloudVmClusterRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCloudVmCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCloudVmCluster operation on AmazonOdbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCloudVmCluster
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/CreateCloudVmCluster">REST API Reference for CreateCloudVmCluster Operation</seealso>
        IAsyncResult BeginCreateCloudVmCluster(CreateCloudVmClusterRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCloudVmCluster operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCloudVmCluster.</param>
        /// 
        /// <returns>Returns a  CreateCloudVmClusterResult from Odb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/CreateCloudVmCluster">REST API Reference for CreateCloudVmCluster Operation</seealso>
        CreateCloudVmClusterResponse EndCreateCloudVmCluster(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateOdbNetwork


        /// <summary>
        /// Creates an ODB network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateOdbNetwork service method.</param>
        /// 
        /// <returns>The response from the CreateOdbNetwork service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ConflictException">
        /// Occurs when a conflict with the current status of your resource. Fix any inconsistencies
        /// with your resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ServiceQuotaExceededException">
        /// You have exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/CreateOdbNetwork">REST API Reference for CreateOdbNetwork Operation</seealso>
        CreateOdbNetworkResponse CreateOdbNetwork(CreateOdbNetworkRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateOdbNetwork operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateOdbNetwork operation on AmazonOdbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateOdbNetwork
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/CreateOdbNetwork">REST API Reference for CreateOdbNetwork Operation</seealso>
        IAsyncResult BeginCreateOdbNetwork(CreateOdbNetworkRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateOdbNetwork operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateOdbNetwork.</param>
        /// 
        /// <returns>Returns a  CreateOdbNetworkResult from Odb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/CreateOdbNetwork">REST API Reference for CreateOdbNetwork Operation</seealso>
        CreateOdbNetworkResponse EndCreateOdbNetwork(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateOdbPeeringConnection


        /// <summary>
        /// Creates a peering connection between an ODB network and a VPC.
        /// 
        ///  
        /// <para>
        /// A peering connection enables private connectivity between the networks for application-tier
        /// communication.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateOdbPeeringConnection service method.</param>
        /// 
        /// <returns>The response from the CreateOdbPeeringConnection service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ConflictException">
        /// Occurs when a conflict with the current status of your resource. Fix any inconsistencies
        /// with your resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/CreateOdbPeeringConnection">REST API Reference for CreateOdbPeeringConnection Operation</seealso>
        CreateOdbPeeringConnectionResponse CreateOdbPeeringConnection(CreateOdbPeeringConnectionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateOdbPeeringConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateOdbPeeringConnection operation on AmazonOdbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateOdbPeeringConnection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/CreateOdbPeeringConnection">REST API Reference for CreateOdbPeeringConnection Operation</seealso>
        IAsyncResult BeginCreateOdbPeeringConnection(CreateOdbPeeringConnectionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateOdbPeeringConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateOdbPeeringConnection.</param>
        /// 
        /// <returns>Returns a  CreateOdbPeeringConnectionResult from Odb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/CreateOdbPeeringConnection">REST API Reference for CreateOdbPeeringConnection Operation</seealso>
        CreateOdbPeeringConnectionResponse EndCreateOdbPeeringConnection(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteCloudAutonomousVmCluster


        /// <summary>
        /// Deletes an Autonomous VM cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCloudAutonomousVmCluster service method.</param>
        /// 
        /// <returns>The response from the DeleteCloudAutonomousVmCluster service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ConflictException">
        /// Occurs when a conflict with the current status of your resource. Fix any inconsistencies
        /// with your resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/DeleteCloudAutonomousVmCluster">REST API Reference for DeleteCloudAutonomousVmCluster Operation</seealso>
        DeleteCloudAutonomousVmClusterResponse DeleteCloudAutonomousVmCluster(DeleteCloudAutonomousVmClusterRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCloudAutonomousVmCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCloudAutonomousVmCluster operation on AmazonOdbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCloudAutonomousVmCluster
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/DeleteCloudAutonomousVmCluster">REST API Reference for DeleteCloudAutonomousVmCluster Operation</seealso>
        IAsyncResult BeginDeleteCloudAutonomousVmCluster(DeleteCloudAutonomousVmClusterRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCloudAutonomousVmCluster operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCloudAutonomousVmCluster.</param>
        /// 
        /// <returns>Returns a  DeleteCloudAutonomousVmClusterResult from Odb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/DeleteCloudAutonomousVmCluster">REST API Reference for DeleteCloudAutonomousVmCluster Operation</seealso>
        DeleteCloudAutonomousVmClusterResponse EndDeleteCloudAutonomousVmCluster(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteCloudExadataInfrastructure


        /// <summary>
        /// Deletes the specified Exadata infrastructure. Before you use this operation, make
        /// sure to delete all of the VM clusters that are hosted on this Exadata infrastructure.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCloudExadataInfrastructure service method.</param>
        /// 
        /// <returns>The response from the DeleteCloudExadataInfrastructure service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ConflictException">
        /// Occurs when a conflict with the current status of your resource. Fix any inconsistencies
        /// with your resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/DeleteCloudExadataInfrastructure">REST API Reference for DeleteCloudExadataInfrastructure Operation</seealso>
        DeleteCloudExadataInfrastructureResponse DeleteCloudExadataInfrastructure(DeleteCloudExadataInfrastructureRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCloudExadataInfrastructure operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCloudExadataInfrastructure operation on AmazonOdbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCloudExadataInfrastructure
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/DeleteCloudExadataInfrastructure">REST API Reference for DeleteCloudExadataInfrastructure Operation</seealso>
        IAsyncResult BeginDeleteCloudExadataInfrastructure(DeleteCloudExadataInfrastructureRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCloudExadataInfrastructure operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCloudExadataInfrastructure.</param>
        /// 
        /// <returns>Returns a  DeleteCloudExadataInfrastructureResult from Odb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/DeleteCloudExadataInfrastructure">REST API Reference for DeleteCloudExadataInfrastructure Operation</seealso>
        DeleteCloudExadataInfrastructureResponse EndDeleteCloudExadataInfrastructure(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteCloudVmCluster


        /// <summary>
        /// Deletes the specified VM cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCloudVmCluster service method.</param>
        /// 
        /// <returns>The response from the DeleteCloudVmCluster service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ConflictException">
        /// Occurs when a conflict with the current status of your resource. Fix any inconsistencies
        /// with your resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/DeleteCloudVmCluster">REST API Reference for DeleteCloudVmCluster Operation</seealso>
        DeleteCloudVmClusterResponse DeleteCloudVmCluster(DeleteCloudVmClusterRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCloudVmCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCloudVmCluster operation on AmazonOdbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCloudVmCluster
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/DeleteCloudVmCluster">REST API Reference for DeleteCloudVmCluster Operation</seealso>
        IAsyncResult BeginDeleteCloudVmCluster(DeleteCloudVmClusterRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCloudVmCluster operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCloudVmCluster.</param>
        /// 
        /// <returns>Returns a  DeleteCloudVmClusterResult from Odb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/DeleteCloudVmCluster">REST API Reference for DeleteCloudVmCluster Operation</seealso>
        DeleteCloudVmClusterResponse EndDeleteCloudVmCluster(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteOdbNetwork


        /// <summary>
        /// Deletes the specified ODB network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteOdbNetwork service method.</param>
        /// 
        /// <returns>The response from the DeleteOdbNetwork service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/DeleteOdbNetwork">REST API Reference for DeleteOdbNetwork Operation</seealso>
        DeleteOdbNetworkResponse DeleteOdbNetwork(DeleteOdbNetworkRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteOdbNetwork operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteOdbNetwork operation on AmazonOdbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteOdbNetwork
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/DeleteOdbNetwork">REST API Reference for DeleteOdbNetwork Operation</seealso>
        IAsyncResult BeginDeleteOdbNetwork(DeleteOdbNetworkRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteOdbNetwork operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteOdbNetwork.</param>
        /// 
        /// <returns>Returns a  DeleteOdbNetworkResult from Odb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/DeleteOdbNetwork">REST API Reference for DeleteOdbNetwork Operation</seealso>
        DeleteOdbNetworkResponse EndDeleteOdbNetwork(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteOdbPeeringConnection


        /// <summary>
        /// Deletes an ODB peering connection.
        /// 
        ///  
        /// <para>
        /// When you delete an ODB peering connection, the underlying VPC peering connection is
        /// also deleted.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteOdbPeeringConnection service method.</param>
        /// 
        /// <returns>The response from the DeleteOdbPeeringConnection service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/DeleteOdbPeeringConnection">REST API Reference for DeleteOdbPeeringConnection Operation</seealso>
        DeleteOdbPeeringConnectionResponse DeleteOdbPeeringConnection(DeleteOdbPeeringConnectionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteOdbPeeringConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteOdbPeeringConnection operation on AmazonOdbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteOdbPeeringConnection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/DeleteOdbPeeringConnection">REST API Reference for DeleteOdbPeeringConnection Operation</seealso>
        IAsyncResult BeginDeleteOdbPeeringConnection(DeleteOdbPeeringConnectionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteOdbPeeringConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteOdbPeeringConnection.</param>
        /// 
        /// <returns>Returns a  DeleteOdbPeeringConnectionResult from Odb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/DeleteOdbPeeringConnection">REST API Reference for DeleteOdbPeeringConnection Operation</seealso>
        DeleteOdbPeeringConnectionResponse EndDeleteOdbPeeringConnection(IAsyncResult asyncResult);

        #endregion
        
        #region  DisassociateIamRoleFromResource


        /// <summary>
        /// Disassociates an Amazon Web Services Identity and Access Management (IAM) service
        /// role from a specified resource to disable Amazon Web Services service integration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateIamRoleFromResource service method.</param>
        /// 
        /// <returns>The response from the DisassociateIamRoleFromResource service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ConflictException">
        /// Occurs when a conflict with the current status of your resource. Fix any inconsistencies
        /// with your resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/DisassociateIamRoleFromResource">REST API Reference for DisassociateIamRoleFromResource Operation</seealso>
        DisassociateIamRoleFromResourceResponse DisassociateIamRoleFromResource(DisassociateIamRoleFromResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateIamRoleFromResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateIamRoleFromResource operation on AmazonOdbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateIamRoleFromResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/DisassociateIamRoleFromResource">REST API Reference for DisassociateIamRoleFromResource Operation</seealso>
        IAsyncResult BeginDisassociateIamRoleFromResource(DisassociateIamRoleFromResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateIamRoleFromResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateIamRoleFromResource.</param>
        /// 
        /// <returns>Returns a  DisassociateIamRoleFromResourceResult from Odb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/DisassociateIamRoleFromResource">REST API Reference for DisassociateIamRoleFromResource Operation</seealso>
        DisassociateIamRoleFromResourceResponse EndDisassociateIamRoleFromResource(IAsyncResult asyncResult);

        #endregion
        
        #region  GetCloudAutonomousVmCluster


        /// <summary>
        /// Gets information about a specific Autonomous VM cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCloudAutonomousVmCluster service method.</param>
        /// 
        /// <returns>The response from the GetCloudAutonomousVmCluster service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/GetCloudAutonomousVmCluster">REST API Reference for GetCloudAutonomousVmCluster Operation</seealso>
        GetCloudAutonomousVmClusterResponse GetCloudAutonomousVmCluster(GetCloudAutonomousVmClusterRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetCloudAutonomousVmCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCloudAutonomousVmCluster operation on AmazonOdbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCloudAutonomousVmCluster
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/GetCloudAutonomousVmCluster">REST API Reference for GetCloudAutonomousVmCluster Operation</seealso>
        IAsyncResult BeginGetCloudAutonomousVmCluster(GetCloudAutonomousVmClusterRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetCloudAutonomousVmCluster operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCloudAutonomousVmCluster.</param>
        /// 
        /// <returns>Returns a  GetCloudAutonomousVmClusterResult from Odb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/GetCloudAutonomousVmCluster">REST API Reference for GetCloudAutonomousVmCluster Operation</seealso>
        GetCloudAutonomousVmClusterResponse EndGetCloudAutonomousVmCluster(IAsyncResult asyncResult);

        #endregion
        
        #region  GetCloudExadataInfrastructure


        /// <summary>
        /// Returns information about the specified Exadata infrastructure.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCloudExadataInfrastructure service method.</param>
        /// 
        /// <returns>The response from the GetCloudExadataInfrastructure service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/GetCloudExadataInfrastructure">REST API Reference for GetCloudExadataInfrastructure Operation</seealso>
        GetCloudExadataInfrastructureResponse GetCloudExadataInfrastructure(GetCloudExadataInfrastructureRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetCloudExadataInfrastructure operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCloudExadataInfrastructure operation on AmazonOdbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCloudExadataInfrastructure
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/GetCloudExadataInfrastructure">REST API Reference for GetCloudExadataInfrastructure Operation</seealso>
        IAsyncResult BeginGetCloudExadataInfrastructure(GetCloudExadataInfrastructureRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetCloudExadataInfrastructure operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCloudExadataInfrastructure.</param>
        /// 
        /// <returns>Returns a  GetCloudExadataInfrastructureResult from Odb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/GetCloudExadataInfrastructure">REST API Reference for GetCloudExadataInfrastructure Operation</seealso>
        GetCloudExadataInfrastructureResponse EndGetCloudExadataInfrastructure(IAsyncResult asyncResult);

        #endregion
        
        #region  GetCloudExadataInfrastructureUnallocatedResources


        /// <summary>
        /// Retrieves information about unallocated resources in a specified Cloud Exadata Infrastructure.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCloudExadataInfrastructureUnallocatedResources service method.</param>
        /// 
        /// <returns>The response from the GetCloudExadataInfrastructureUnallocatedResources service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/GetCloudExadataInfrastructureUnallocatedResources">REST API Reference for GetCloudExadataInfrastructureUnallocatedResources Operation</seealso>
        GetCloudExadataInfrastructureUnallocatedResourcesResponse GetCloudExadataInfrastructureUnallocatedResources(GetCloudExadataInfrastructureUnallocatedResourcesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetCloudExadataInfrastructureUnallocatedResources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCloudExadataInfrastructureUnallocatedResources operation on AmazonOdbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCloudExadataInfrastructureUnallocatedResources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/GetCloudExadataInfrastructureUnallocatedResources">REST API Reference for GetCloudExadataInfrastructureUnallocatedResources Operation</seealso>
        IAsyncResult BeginGetCloudExadataInfrastructureUnallocatedResources(GetCloudExadataInfrastructureUnallocatedResourcesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetCloudExadataInfrastructureUnallocatedResources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCloudExadataInfrastructureUnallocatedResources.</param>
        /// 
        /// <returns>Returns a  GetCloudExadataInfrastructureUnallocatedResourcesResult from Odb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/GetCloudExadataInfrastructureUnallocatedResources">REST API Reference for GetCloudExadataInfrastructureUnallocatedResources Operation</seealso>
        GetCloudExadataInfrastructureUnallocatedResourcesResponse EndGetCloudExadataInfrastructureUnallocatedResources(IAsyncResult asyncResult);

        #endregion
        
        #region  GetCloudVmCluster


        /// <summary>
        /// Returns information about the specified VM cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCloudVmCluster service method.</param>
        /// 
        /// <returns>The response from the GetCloudVmCluster service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/GetCloudVmCluster">REST API Reference for GetCloudVmCluster Operation</seealso>
        GetCloudVmClusterResponse GetCloudVmCluster(GetCloudVmClusterRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetCloudVmCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCloudVmCluster operation on AmazonOdbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCloudVmCluster
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/GetCloudVmCluster">REST API Reference for GetCloudVmCluster Operation</seealso>
        IAsyncResult BeginGetCloudVmCluster(GetCloudVmClusterRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetCloudVmCluster operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCloudVmCluster.</param>
        /// 
        /// <returns>Returns a  GetCloudVmClusterResult from Odb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/GetCloudVmCluster">REST API Reference for GetCloudVmCluster Operation</seealso>
        GetCloudVmClusterResponse EndGetCloudVmCluster(IAsyncResult asyncResult);

        #endregion
        
        #region  GetDbNode


        /// <summary>
        /// Returns information about the specified DB node.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDbNode service method.</param>
        /// 
        /// <returns>The response from the GetDbNode service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/GetDbNode">REST API Reference for GetDbNode Operation</seealso>
        GetDbNodeResponse GetDbNode(GetDbNodeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetDbNode operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDbNode operation on AmazonOdbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDbNode
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/GetDbNode">REST API Reference for GetDbNode Operation</seealso>
        IAsyncResult BeginGetDbNode(GetDbNodeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDbNode operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDbNode.</param>
        /// 
        /// <returns>Returns a  GetDbNodeResult from Odb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/GetDbNode">REST API Reference for GetDbNode Operation</seealso>
        GetDbNodeResponse EndGetDbNode(IAsyncResult asyncResult);

        #endregion
        
        #region  GetDbServer


        /// <summary>
        /// Returns information about the specified database server.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDbServer service method.</param>
        /// 
        /// <returns>The response from the GetDbServer service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/GetDbServer">REST API Reference for GetDbServer Operation</seealso>
        GetDbServerResponse GetDbServer(GetDbServerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetDbServer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDbServer operation on AmazonOdbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDbServer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/GetDbServer">REST API Reference for GetDbServer Operation</seealso>
        IAsyncResult BeginGetDbServer(GetDbServerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDbServer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDbServer.</param>
        /// 
        /// <returns>Returns a  GetDbServerResult from Odb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/GetDbServer">REST API Reference for GetDbServer Operation</seealso>
        GetDbServerResponse EndGetDbServer(IAsyncResult asyncResult);

        #endregion
        
        #region  GetOciOnboardingStatus


        /// <summary>
        /// Returns the tenancy activation link and onboarding status for your Amazon Web Services
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOciOnboardingStatus service method.</param>
        /// 
        /// <returns>The response from the GetOciOnboardingStatus service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/GetOciOnboardingStatus">REST API Reference for GetOciOnboardingStatus Operation</seealso>
        GetOciOnboardingStatusResponse GetOciOnboardingStatus(GetOciOnboardingStatusRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetOciOnboardingStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetOciOnboardingStatus operation on AmazonOdbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetOciOnboardingStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/GetOciOnboardingStatus">REST API Reference for GetOciOnboardingStatus Operation</seealso>
        IAsyncResult BeginGetOciOnboardingStatus(GetOciOnboardingStatusRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetOciOnboardingStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetOciOnboardingStatus.</param>
        /// 
        /// <returns>Returns a  GetOciOnboardingStatusResult from Odb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/GetOciOnboardingStatus">REST API Reference for GetOciOnboardingStatus Operation</seealso>
        GetOciOnboardingStatusResponse EndGetOciOnboardingStatus(IAsyncResult asyncResult);

        #endregion
        
        #region  GetOdbNetwork


        /// <summary>
        /// Returns information about the specified ODB network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOdbNetwork service method.</param>
        /// 
        /// <returns>The response from the GetOdbNetwork service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/GetOdbNetwork">REST API Reference for GetOdbNetwork Operation</seealso>
        GetOdbNetworkResponse GetOdbNetwork(GetOdbNetworkRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetOdbNetwork operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetOdbNetwork operation on AmazonOdbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetOdbNetwork
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/GetOdbNetwork">REST API Reference for GetOdbNetwork Operation</seealso>
        IAsyncResult BeginGetOdbNetwork(GetOdbNetworkRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetOdbNetwork operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetOdbNetwork.</param>
        /// 
        /// <returns>Returns a  GetOdbNetworkResult from Odb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/GetOdbNetwork">REST API Reference for GetOdbNetwork Operation</seealso>
        GetOdbNetworkResponse EndGetOdbNetwork(IAsyncResult asyncResult);

        #endregion
        
        #region  GetOdbPeeringConnection


        /// <summary>
        /// Retrieves information about an ODB peering connection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOdbPeeringConnection service method.</param>
        /// 
        /// <returns>The response from the GetOdbPeeringConnection service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/GetOdbPeeringConnection">REST API Reference for GetOdbPeeringConnection Operation</seealso>
        GetOdbPeeringConnectionResponse GetOdbPeeringConnection(GetOdbPeeringConnectionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetOdbPeeringConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetOdbPeeringConnection operation on AmazonOdbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetOdbPeeringConnection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/GetOdbPeeringConnection">REST API Reference for GetOdbPeeringConnection Operation</seealso>
        IAsyncResult BeginGetOdbPeeringConnection(GetOdbPeeringConnectionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetOdbPeeringConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetOdbPeeringConnection.</param>
        /// 
        /// <returns>Returns a  GetOdbPeeringConnectionResult from Odb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/GetOdbPeeringConnection">REST API Reference for GetOdbPeeringConnection Operation</seealso>
        GetOdbPeeringConnectionResponse EndGetOdbPeeringConnection(IAsyncResult asyncResult);

        #endregion
        
        #region  InitializeService


        /// <summary>
        /// Initializes the ODB service for the first time in an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InitializeService service method.</param>
        /// 
        /// <returns>The response from the InitializeService service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/InitializeService">REST API Reference for InitializeService Operation</seealso>
        InitializeServiceResponse InitializeService(InitializeServiceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the InitializeService operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the InitializeService operation on AmazonOdbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndInitializeService
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/InitializeService">REST API Reference for InitializeService Operation</seealso>
        IAsyncResult BeginInitializeService(InitializeServiceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  InitializeService operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginInitializeService.</param>
        /// 
        /// <returns>Returns a  InitializeServiceResult from Odb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/InitializeService">REST API Reference for InitializeService Operation</seealso>
        InitializeServiceResponse EndInitializeService(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAutonomousVirtualMachines


        /// <summary>
        /// Lists all Autonomous VMs in an Autonomous VM cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAutonomousVirtualMachines service method.</param>
        /// 
        /// <returns>The response from the ListAutonomousVirtualMachines service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListAutonomousVirtualMachines">REST API Reference for ListAutonomousVirtualMachines Operation</seealso>
        ListAutonomousVirtualMachinesResponse ListAutonomousVirtualMachines(ListAutonomousVirtualMachinesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAutonomousVirtualMachines operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAutonomousVirtualMachines operation on AmazonOdbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAutonomousVirtualMachines
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListAutonomousVirtualMachines">REST API Reference for ListAutonomousVirtualMachines Operation</seealso>
        IAsyncResult BeginListAutonomousVirtualMachines(ListAutonomousVirtualMachinesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAutonomousVirtualMachines operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAutonomousVirtualMachines.</param>
        /// 
        /// <returns>Returns a  ListAutonomousVirtualMachinesResult from Odb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListAutonomousVirtualMachines">REST API Reference for ListAutonomousVirtualMachines Operation</seealso>
        ListAutonomousVirtualMachinesResponse EndListAutonomousVirtualMachines(IAsyncResult asyncResult);

        #endregion
        
        #region  ListCloudAutonomousVmClusters


        /// <summary>
        /// Lists all Autonomous VM clusters in a specified Cloud Exadata infrastructure.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCloudAutonomousVmClusters service method.</param>
        /// 
        /// <returns>The response from the ListCloudAutonomousVmClusters service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListCloudAutonomousVmClusters">REST API Reference for ListCloudAutonomousVmClusters Operation</seealso>
        ListCloudAutonomousVmClustersResponse ListCloudAutonomousVmClusters(ListCloudAutonomousVmClustersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListCloudAutonomousVmClusters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCloudAutonomousVmClusters operation on AmazonOdbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCloudAutonomousVmClusters
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListCloudAutonomousVmClusters">REST API Reference for ListCloudAutonomousVmClusters Operation</seealso>
        IAsyncResult BeginListCloudAutonomousVmClusters(ListCloudAutonomousVmClustersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListCloudAutonomousVmClusters operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCloudAutonomousVmClusters.</param>
        /// 
        /// <returns>Returns a  ListCloudAutonomousVmClustersResult from Odb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListCloudAutonomousVmClusters">REST API Reference for ListCloudAutonomousVmClusters Operation</seealso>
        ListCloudAutonomousVmClustersResponse EndListCloudAutonomousVmClusters(IAsyncResult asyncResult);

        #endregion
        
        #region  ListCloudExadataInfrastructures


        /// <summary>
        /// Returns information about the Exadata infrastructures owned by your Amazon Web Services
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCloudExadataInfrastructures service method.</param>
        /// 
        /// <returns>The response from the ListCloudExadataInfrastructures service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListCloudExadataInfrastructures">REST API Reference for ListCloudExadataInfrastructures Operation</seealso>
        ListCloudExadataInfrastructuresResponse ListCloudExadataInfrastructures(ListCloudExadataInfrastructuresRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListCloudExadataInfrastructures operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCloudExadataInfrastructures operation on AmazonOdbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCloudExadataInfrastructures
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListCloudExadataInfrastructures">REST API Reference for ListCloudExadataInfrastructures Operation</seealso>
        IAsyncResult BeginListCloudExadataInfrastructures(ListCloudExadataInfrastructuresRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListCloudExadataInfrastructures operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCloudExadataInfrastructures.</param>
        /// 
        /// <returns>Returns a  ListCloudExadataInfrastructuresResult from Odb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListCloudExadataInfrastructures">REST API Reference for ListCloudExadataInfrastructures Operation</seealso>
        ListCloudExadataInfrastructuresResponse EndListCloudExadataInfrastructures(IAsyncResult asyncResult);

        #endregion
        
        #region  ListCloudVmClusters


        /// <summary>
        /// Returns information about the VM clusters owned by your Amazon Web Services account
        /// or only the ones on the specified Exadata infrastructure.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCloudVmClusters service method.</param>
        /// 
        /// <returns>The response from the ListCloudVmClusters service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListCloudVmClusters">REST API Reference for ListCloudVmClusters Operation</seealso>
        ListCloudVmClustersResponse ListCloudVmClusters(ListCloudVmClustersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListCloudVmClusters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCloudVmClusters operation on AmazonOdbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCloudVmClusters
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListCloudVmClusters">REST API Reference for ListCloudVmClusters Operation</seealso>
        IAsyncResult BeginListCloudVmClusters(ListCloudVmClustersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListCloudVmClusters operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCloudVmClusters.</param>
        /// 
        /// <returns>Returns a  ListCloudVmClustersResult from Odb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListCloudVmClusters">REST API Reference for ListCloudVmClusters Operation</seealso>
        ListCloudVmClustersResponse EndListCloudVmClusters(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDbNodes


        /// <summary>
        /// Returns information about the DB nodes for the specified VM cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDbNodes service method.</param>
        /// 
        /// <returns>The response from the ListDbNodes service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListDbNodes">REST API Reference for ListDbNodes Operation</seealso>
        ListDbNodesResponse ListDbNodes(ListDbNodesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDbNodes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDbNodes operation on AmazonOdbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDbNodes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListDbNodes">REST API Reference for ListDbNodes Operation</seealso>
        IAsyncResult BeginListDbNodes(ListDbNodesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDbNodes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDbNodes.</param>
        /// 
        /// <returns>Returns a  ListDbNodesResult from Odb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListDbNodes">REST API Reference for ListDbNodes Operation</seealso>
        ListDbNodesResponse EndListDbNodes(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDbServers


        /// <summary>
        /// Returns information about the database servers that belong to the specified Exadata
        /// infrastructure.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDbServers service method.</param>
        /// 
        /// <returns>The response from the ListDbServers service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListDbServers">REST API Reference for ListDbServers Operation</seealso>
        ListDbServersResponse ListDbServers(ListDbServersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDbServers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDbServers operation on AmazonOdbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDbServers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListDbServers">REST API Reference for ListDbServers Operation</seealso>
        IAsyncResult BeginListDbServers(ListDbServersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDbServers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDbServers.</param>
        /// 
        /// <returns>Returns a  ListDbServersResult from Odb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListDbServers">REST API Reference for ListDbServers Operation</seealso>
        ListDbServersResponse EndListDbServers(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDbSystemShapes


        /// <summary>
        /// Returns information about the shapes that are available for an Exadata infrastructure.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDbSystemShapes service method.</param>
        /// 
        /// <returns>The response from the ListDbSystemShapes service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListDbSystemShapes">REST API Reference for ListDbSystemShapes Operation</seealso>
        ListDbSystemShapesResponse ListDbSystemShapes(ListDbSystemShapesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDbSystemShapes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDbSystemShapes operation on AmazonOdbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDbSystemShapes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListDbSystemShapes">REST API Reference for ListDbSystemShapes Operation</seealso>
        IAsyncResult BeginListDbSystemShapes(ListDbSystemShapesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDbSystemShapes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDbSystemShapes.</param>
        /// 
        /// <returns>Returns a  ListDbSystemShapesResult from Odb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListDbSystemShapes">REST API Reference for ListDbSystemShapes Operation</seealso>
        ListDbSystemShapesResponse EndListDbSystemShapes(IAsyncResult asyncResult);

        #endregion
        
        #region  ListGiVersions


        /// <summary>
        /// Returns information about Oracle Grid Infrastructure (GI) software versions that are
        /// available for a VM cluster for the specified shape.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGiVersions service method.</param>
        /// 
        /// <returns>The response from the ListGiVersions service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListGiVersions">REST API Reference for ListGiVersions Operation</seealso>
        ListGiVersionsResponse ListGiVersions(ListGiVersionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListGiVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGiVersions operation on AmazonOdbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListGiVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListGiVersions">REST API Reference for ListGiVersions Operation</seealso>
        IAsyncResult BeginListGiVersions(ListGiVersionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListGiVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListGiVersions.</param>
        /// 
        /// <returns>Returns a  ListGiVersionsResult from Odb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListGiVersions">REST API Reference for ListGiVersions Operation</seealso>
        ListGiVersionsResponse EndListGiVersions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListOdbNetworks


        /// <summary>
        /// Returns information about the ODB networks owned by your Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOdbNetworks service method.</param>
        /// 
        /// <returns>The response from the ListOdbNetworks service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListOdbNetworks">REST API Reference for ListOdbNetworks Operation</seealso>
        ListOdbNetworksResponse ListOdbNetworks(ListOdbNetworksRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListOdbNetworks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListOdbNetworks operation on AmazonOdbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListOdbNetworks
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListOdbNetworks">REST API Reference for ListOdbNetworks Operation</seealso>
        IAsyncResult BeginListOdbNetworks(ListOdbNetworksRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListOdbNetworks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListOdbNetworks.</param>
        /// 
        /// <returns>Returns a  ListOdbNetworksResult from Odb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListOdbNetworks">REST API Reference for ListOdbNetworks Operation</seealso>
        ListOdbNetworksResponse EndListOdbNetworks(IAsyncResult asyncResult);

        #endregion
        
        #region  ListOdbPeeringConnections


        /// <summary>
        /// Lists all ODB peering connections or those associated with a specific ODB network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOdbPeeringConnections service method.</param>
        /// 
        /// <returns>The response from the ListOdbPeeringConnections service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListOdbPeeringConnections">REST API Reference for ListOdbPeeringConnections Operation</seealso>
        ListOdbPeeringConnectionsResponse ListOdbPeeringConnections(ListOdbPeeringConnectionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListOdbPeeringConnections operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListOdbPeeringConnections operation on AmazonOdbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListOdbPeeringConnections
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListOdbPeeringConnections">REST API Reference for ListOdbPeeringConnections Operation</seealso>
        IAsyncResult BeginListOdbPeeringConnections(ListOdbPeeringConnectionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListOdbPeeringConnections operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListOdbPeeringConnections.</param>
        /// 
        /// <returns>Returns a  ListOdbPeeringConnectionsResult from Odb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListOdbPeeringConnections">REST API Reference for ListOdbPeeringConnections Operation</seealso>
        ListOdbPeeringConnectionsResponse EndListOdbPeeringConnections(IAsyncResult asyncResult);

        #endregion
        
        #region  ListSystemVersions


        /// <summary>
        /// Returns information about the system versions that are available for a VM cluster
        /// for the specified <c>giVersion</c> and <c>shape</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSystemVersions service method.</param>
        /// 
        /// <returns>The response from the ListSystemVersions service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListSystemVersions">REST API Reference for ListSystemVersions Operation</seealso>
        ListSystemVersionsResponse ListSystemVersions(ListSystemVersionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListSystemVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSystemVersions operation on AmazonOdbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSystemVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListSystemVersions">REST API Reference for ListSystemVersions Operation</seealso>
        IAsyncResult BeginListSystemVersions(ListSystemVersionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListSystemVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSystemVersions.</param>
        /// 
        /// <returns>Returns a  ListSystemVersionsResult from Odb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListSystemVersions">REST API Reference for ListSystemVersions Operation</seealso>
        ListSystemVersionsResponse EndListSystemVersions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Returns information about the tags applied to this resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonOdbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from Odb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  RebootDbNode


        /// <summary>
        /// Reboots the specified DB node in a VM cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RebootDbNode service method.</param>
        /// 
        /// <returns>The response from the RebootDbNode service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/RebootDbNode">REST API Reference for RebootDbNode Operation</seealso>
        RebootDbNodeResponse RebootDbNode(RebootDbNodeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RebootDbNode operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RebootDbNode operation on AmazonOdbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRebootDbNode
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/RebootDbNode">REST API Reference for RebootDbNode Operation</seealso>
        IAsyncResult BeginRebootDbNode(RebootDbNodeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RebootDbNode operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRebootDbNode.</param>
        /// 
        /// <returns>Returns a  RebootDbNodeResult from Odb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/RebootDbNode">REST API Reference for RebootDbNode Operation</seealso>
        RebootDbNodeResponse EndRebootDbNode(IAsyncResult asyncResult);

        #endregion
        
        #region  StartDbNode


        /// <summary>
        /// Starts the specified DB node in a VM cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDbNode service method.</param>
        /// 
        /// <returns>The response from the StartDbNode service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/StartDbNode">REST API Reference for StartDbNode Operation</seealso>
        StartDbNodeResponse StartDbNode(StartDbNodeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartDbNode operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartDbNode operation on AmazonOdbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartDbNode
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/StartDbNode">REST API Reference for StartDbNode Operation</seealso>
        IAsyncResult BeginStartDbNode(StartDbNodeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartDbNode operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartDbNode.</param>
        /// 
        /// <returns>Returns a  StartDbNodeResult from Odb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/StartDbNode">REST API Reference for StartDbNode Operation</seealso>
        StartDbNodeResponse EndStartDbNode(IAsyncResult asyncResult);

        #endregion
        
        #region  StopDbNode


        /// <summary>
        /// Stops the specified DB node in a VM cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopDbNode service method.</param>
        /// 
        /// <returns>The response from the StopDbNode service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/StopDbNode">REST API Reference for StopDbNode Operation</seealso>
        StopDbNodeResponse StopDbNode(StopDbNodeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StopDbNode operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopDbNode operation on AmazonOdbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopDbNode
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/StopDbNode">REST API Reference for StopDbNode Operation</seealso>
        IAsyncResult BeginStopDbNode(StopDbNodeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopDbNode operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopDbNode.</param>
        /// 
        /// <returns>Returns a  StopDbNodeResult from Odb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/StopDbNode">REST API Reference for StopDbNode Operation</seealso>
        StopDbNodeResponse EndStopDbNode(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Applies tags to the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ServiceQuotaExceededException">
        /// You have exceeded the service quota.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonOdbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from Odb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes tags from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonOdbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from Odb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateCloudExadataInfrastructure


        /// <summary>
        /// Updates the properties of an Exadata infrastructure resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCloudExadataInfrastructure service method.</param>
        /// 
        /// <returns>The response from the UpdateCloudExadataInfrastructure service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ConflictException">
        /// Occurs when a conflict with the current status of your resource. Fix any inconsistencies
        /// with your resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/UpdateCloudExadataInfrastructure">REST API Reference for UpdateCloudExadataInfrastructure Operation</seealso>
        UpdateCloudExadataInfrastructureResponse UpdateCloudExadataInfrastructure(UpdateCloudExadataInfrastructureRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateCloudExadataInfrastructure operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCloudExadataInfrastructure operation on AmazonOdbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateCloudExadataInfrastructure
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/UpdateCloudExadataInfrastructure">REST API Reference for UpdateCloudExadataInfrastructure Operation</seealso>
        IAsyncResult BeginUpdateCloudExadataInfrastructure(UpdateCloudExadataInfrastructureRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateCloudExadataInfrastructure operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateCloudExadataInfrastructure.</param>
        /// 
        /// <returns>Returns a  UpdateCloudExadataInfrastructureResult from Odb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/UpdateCloudExadataInfrastructure">REST API Reference for UpdateCloudExadataInfrastructure Operation</seealso>
        UpdateCloudExadataInfrastructureResponse EndUpdateCloudExadataInfrastructure(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateOdbNetwork


        /// <summary>
        /// Updates properties of a specified ODB network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateOdbNetwork service method.</param>
        /// 
        /// <returns>The response from the UpdateOdbNetwork service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ConflictException">
        /// Occurs when a conflict with the current status of your resource. Fix any inconsistencies
        /// with your resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/UpdateOdbNetwork">REST API Reference for UpdateOdbNetwork Operation</seealso>
        UpdateOdbNetworkResponse UpdateOdbNetwork(UpdateOdbNetworkRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateOdbNetwork operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateOdbNetwork operation on AmazonOdbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateOdbNetwork
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/UpdateOdbNetwork">REST API Reference for UpdateOdbNetwork Operation</seealso>
        IAsyncResult BeginUpdateOdbNetwork(UpdateOdbNetworkRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateOdbNetwork operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateOdbNetwork.</param>
        /// 
        /// <returns>Returns a  UpdateOdbNetworkResult from Odb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/UpdateOdbNetwork">REST API Reference for UpdateOdbNetwork Operation</seealso>
        UpdateOdbNetworkResponse EndUpdateOdbNetwork(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateOdbPeeringConnection


        /// <summary>
        /// Modifies the settings of an Oracle Database@Amazon Web Services peering connection.
        /// You can update the display name and add or remove CIDR blocks from the peering connection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateOdbPeeringConnection service method.</param>
        /// 
        /// <returns>The response from the UpdateOdbPeeringConnection service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ConflictException">
        /// Occurs when a conflict with the current status of your resource. Fix any inconsistencies
        /// with your resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/UpdateOdbPeeringConnection">REST API Reference for UpdateOdbPeeringConnection Operation</seealso>
        UpdateOdbPeeringConnectionResponse UpdateOdbPeeringConnection(UpdateOdbPeeringConnectionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateOdbPeeringConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateOdbPeeringConnection operation on AmazonOdbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateOdbPeeringConnection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/UpdateOdbPeeringConnection">REST API Reference for UpdateOdbPeeringConnection Operation</seealso>
        IAsyncResult BeginUpdateOdbPeeringConnection(UpdateOdbPeeringConnectionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateOdbPeeringConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateOdbPeeringConnection.</param>
        /// 
        /// <returns>Returns a  UpdateOdbPeeringConnectionResult from Odb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/UpdateOdbPeeringConnection">REST API Reference for UpdateOdbPeeringConnection Operation</seealso>
        UpdateOdbPeeringConnectionResponse EndUpdateOdbPeeringConnection(IAsyncResult asyncResult);

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