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
using System.Threading;
using System.Threading.Tasks;
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
    /// a virtual private cloud (VPC) and access an Oracle Exadata system running in Oracle
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
    ///  <note> 
    /// <para>
    /// In this preview release documentation, the links in the "See Also" sections do not
    /// work.
    /// </para>
    ///  </note> 
    /// <para>
    ///  <b>Oracle Database@Amazon Web Services API Reference</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// For the alphabetical list of API actions, see .
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For the alphabetical list of data types, see .
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For a list of common parameters, see <a>CommonParameters</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For descriptions of the error codes, see <a>CommonErrors</a>.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial interface IAmazonOdb : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        IOdbPaginatorFactory Paginators { get; }

        
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
        /// Registers the Amazon Web Services Marketplace token for your Amazon Web Services account
        /// to activate your Oracle Database@Amazon Web Services subscription.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptMarketplaceRegistration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<AcceptMarketplaceRegistrationResponse> AcceptMarketplaceRegistrationAsync(AcceptMarketplaceRegistrationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Creates a new Autonomous VM cluster in the specified Exadata infrastructure.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCloudAutonomousVmCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateCloudAutonomousVmClusterResponse> CreateCloudAutonomousVmClusterAsync(CreateCloudAutonomousVmClusterRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Creates an Exadata infrastructure.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCloudExadataInfrastructure service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateCloudExadataInfrastructureResponse> CreateCloudExadataInfrastructureAsync(CreateCloudExadataInfrastructureRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Creates a VM cluster on the specified Exadata infrastructure.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCloudVmCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateCloudVmClusterResponse> CreateCloudVmClusterAsync(CreateCloudVmClusterRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Creates an ODB network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateOdbNetwork service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateOdbNetworkResponse> CreateOdbNetworkAsync(CreateOdbNetworkRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateOdbPeeringConnection


        /// <summary>
        /// Creates a peering connection between an ODB network and either another ODB network
        /// or a customer-owned VPC.
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
        /// Creates a peering connection between an ODB network and either another ODB network
        /// or a customer-owned VPC.
        /// 
        ///  
        /// <para>
        /// A peering connection enables private connectivity between the networks for application-tier
        /// communication.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateOdbPeeringConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateOdbPeeringConnectionResponse> CreateOdbPeeringConnectionAsync(CreateOdbPeeringConnectionRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Deletes an Autonomous VM cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCloudAutonomousVmCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteCloudAutonomousVmClusterResponse> DeleteCloudAutonomousVmClusterAsync(DeleteCloudAutonomousVmClusterRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Deletes the specified Exadata infrastructure. Before you use this operation, make
        /// sure to delete all of the VM clusters that are hosted on this Exadata infrastructure.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCloudExadataInfrastructure service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteCloudExadataInfrastructureResponse> DeleteCloudExadataInfrastructureAsync(DeleteCloudExadataInfrastructureRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Deletes the specified VM cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCloudVmCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteCloudVmClusterResponse> DeleteCloudVmClusterAsync(DeleteCloudVmClusterRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Deletes the specified ODB network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteOdbNetwork service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteOdbNetworkResponse> DeleteOdbNetworkAsync(DeleteOdbNetworkRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Deletes an ODB peering connection.
        /// 
        ///  
        /// <para>
        /// When you delete an ODB peering connection, the underlying VPC peering connection is
        /// also deleted.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteOdbPeeringConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteOdbPeeringConnectionResponse> DeleteOdbPeeringConnectionAsync(DeleteOdbPeeringConnectionRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Gets information about a specific Autonomous VM cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCloudAutonomousVmCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetCloudAutonomousVmClusterResponse> GetCloudAutonomousVmClusterAsync(GetCloudAutonomousVmClusterRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Returns information about the specified Exadata infrastructure.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCloudExadataInfrastructure service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetCloudExadataInfrastructureResponse> GetCloudExadataInfrastructureAsync(GetCloudExadataInfrastructureRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Retrieves information about unallocated resources in a specified Cloud Exadata Infrastructure.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCloudExadataInfrastructureUnallocatedResources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetCloudExadataInfrastructureUnallocatedResourcesResponse> GetCloudExadataInfrastructureUnallocatedResourcesAsync(GetCloudExadataInfrastructureUnallocatedResourcesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Returns information about the specified VM cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCloudVmCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetCloudVmClusterResponse> GetCloudVmClusterAsync(GetCloudVmClusterRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Returns information about the specified DB node.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDbNode service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetDbNodeResponse> GetDbNodeAsync(GetDbNodeRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Returns information about the specified database server.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDbServer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetDbServerResponse> GetDbServerAsync(GetDbServerRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Returns the tenancy activation link and onboarding status for your Amazon Web Services
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOciOnboardingStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetOciOnboardingStatusResponse> GetOciOnboardingStatusAsync(GetOciOnboardingStatusRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Returns information about the specified ODB network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOdbNetwork service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetOdbNetworkResponse> GetOdbNetworkAsync(GetOdbNetworkRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Retrieves information about an ODB peering connection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOdbPeeringConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetOdbPeeringConnectionResponse> GetOdbPeeringConnectionAsync(GetOdbPeeringConnectionRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Initializes the ODB service for the first time in an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InitializeService service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<InitializeServiceResponse> InitializeServiceAsync(InitializeServiceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Lists all Autonomous VMs in an Autonomous VM cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAutonomousVirtualMachines service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListAutonomousVirtualMachinesResponse> ListAutonomousVirtualMachinesAsync(ListAutonomousVirtualMachinesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Lists all Autonomous VM clusters in a specified Cloud Exadata infrastructure.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCloudAutonomousVmClusters service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListCloudAutonomousVmClustersResponse> ListCloudAutonomousVmClustersAsync(ListCloudAutonomousVmClustersRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Returns information about the Exadata infrastructures owned by your Amazon Web Services
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCloudExadataInfrastructures service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListCloudExadataInfrastructuresResponse> ListCloudExadataInfrastructuresAsync(ListCloudExadataInfrastructuresRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Returns information about the VM clusters owned by your Amazon Web Services account
        /// or only the ones on the specified Exadata infrastructure.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCloudVmClusters service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListCloudVmClustersResponse> ListCloudVmClustersAsync(ListCloudVmClustersRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Returns information about the DB nodes for the specified VM cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDbNodes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListDbNodesResponse> ListDbNodesAsync(ListDbNodesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Returns information about the database servers that belong to the specified Exadata
        /// infrastructure.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDbServers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListDbServersResponse> ListDbServersAsync(ListDbServersRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Returns information about the shapes that are available for an Exadata infrastructure.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDbSystemShapes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListDbSystemShapesResponse> ListDbSystemShapesAsync(ListDbSystemShapesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Returns information about Oracle Grid Infrastructure (GI) software versions that are
        /// available for a VM cluster for the specified shape.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGiVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListGiVersionsResponse> ListGiVersionsAsync(ListGiVersionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Returns information about the ODB networks owned by your Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOdbNetworks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListOdbNetworksResponse> ListOdbNetworksAsync(ListOdbNetworksRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Lists all ODB peering connections or those associated with a specific ODB network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOdbPeeringConnections service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListOdbPeeringConnectionsResponse> ListOdbPeeringConnectionsAsync(ListOdbPeeringConnectionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Returns information about the system versions that are available for a VM cluster
        /// for the specified <c>giVersion</c> and <c>shape</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSystemVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListSystemVersionsResponse> ListSystemVersionsAsync(ListSystemVersionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Returns information about the tags applied to this resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Reboots the specified DB node in a VM cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RebootDbNode service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<RebootDbNodeResponse> RebootDbNodeAsync(RebootDbNodeRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Starts the specified DB node in a VM cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDbNode service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<StartDbNodeResponse> StartDbNodeAsync(StartDbNodeRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Stops the specified DB node in a VM cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopDbNode service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<StopDbNodeResponse> StopDbNodeAsync(StopDbNodeRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Applies tags to the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Removes tags from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Updates the properties of an Exadata infrastructure resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCloudExadataInfrastructure service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateCloudExadataInfrastructureResponse> UpdateCloudExadataInfrastructureAsync(UpdateCloudExadataInfrastructureRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Updates properties of a specified ODB network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateOdbNetwork service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateOdbNetworkResponse> UpdateOdbNetworkAsync(UpdateOdbNetworkRequest request, CancellationToken cancellationToken = default(CancellationToken));

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