/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the ec2-2014-06-15.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.EC2.Model;

namespace Amazon.EC2
{
    /// <summary>
    /// Interface for accessing EC2
    ///
    /// Amazon Elastic Compute Cloud 
    /// <para>
    /// Amazon Elastic Compute Cloud (Amazon EC2) provides resizable computing capacity in
    /// the Amazon Web Services (AWS) cloud. Using Amazon EC2 eliminates your need to invest
    /// in hardware up front, so you can develop and deploy applications faster.
    /// </para>
    /// </summary>
    public partial interface IAmazonEC2 : IDisposable
    {
                
        #region  AcceptVpcPeeringConnection


        /// <summary>
        /// Initiates the asynchronous execution of the AcceptVpcPeeringConnection operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AcceptVpcPeeringConnection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<AcceptVpcPeeringConnectionResponse> AcceptVpcPeeringConnectionAsync(AcceptVpcPeeringConnectionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AllocateAddress


        /// <summary>
        /// Initiates the asynchronous execution of the AllocateAddress operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AllocateAddress operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<AllocateAddressResponse> AllocateAddressAsync(AllocateAddressRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AssignPrivateIpAddresses


        /// <summary>
        /// Initiates the asynchronous execution of the AssignPrivateIpAddresses operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssignPrivateIpAddresses operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<AssignPrivateIpAddressesResponse> AssignPrivateIpAddressesAsync(AssignPrivateIpAddressesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AssociateAddress


        /// <summary>
        /// Initiates the asynchronous execution of the AssociateAddress operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateAddress operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<AssociateAddressResponse> AssociateAddressAsync(AssociateAddressRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AssociateDhcpOptions


        /// <summary>
        /// Initiates the asynchronous execution of the AssociateDhcpOptions operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateDhcpOptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<AssociateDhcpOptionsResponse> AssociateDhcpOptionsAsync(AssociateDhcpOptionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AssociateRouteTable


        /// <summary>
        /// Initiates the asynchronous execution of the AssociateRouteTable operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateRouteTable operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<AssociateRouteTableResponse> AssociateRouteTableAsync(AssociateRouteTableRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AttachInternetGateway


        /// <summary>
        /// Initiates the asynchronous execution of the AttachInternetGateway operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachInternetGateway operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<AttachInternetGatewayResponse> AttachInternetGatewayAsync(AttachInternetGatewayRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AttachNetworkInterface


        /// <summary>
        /// Initiates the asynchronous execution of the AttachNetworkInterface operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachNetworkInterface operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<AttachNetworkInterfaceResponse> AttachNetworkInterfaceAsync(AttachNetworkInterfaceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AttachVolume


        /// <summary>
        /// Initiates the asynchronous execution of the AttachVolume operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachVolume operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<AttachVolumeResponse> AttachVolumeAsync(AttachVolumeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AttachVpnGateway


        /// <summary>
        /// Initiates the asynchronous execution of the AttachVpnGateway operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachVpnGateway operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<AttachVpnGatewayResponse> AttachVpnGatewayAsync(AttachVpnGatewayRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AuthorizeSecurityGroupEgress


        /// <summary>
        /// Initiates the asynchronous execution of the AuthorizeSecurityGroupEgress operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AuthorizeSecurityGroupEgress operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<AuthorizeSecurityGroupEgressResponse> AuthorizeSecurityGroupEgressAsync(AuthorizeSecurityGroupEgressRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AuthorizeSecurityGroupIngress


        /// <summary>
        /// Initiates the asynchronous execution of the AuthorizeSecurityGroupIngress operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AuthorizeSecurityGroupIngress operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<AuthorizeSecurityGroupIngressResponse> AuthorizeSecurityGroupIngressAsync(AuthorizeSecurityGroupIngressRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  BundleInstance


        /// <summary>
        /// Initiates the asynchronous execution of the BundleInstance operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BundleInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<BundleInstanceResponse> BundleInstanceAsync(BundleInstanceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CancelBundleTask


        /// <summary>
        /// Initiates the asynchronous execution of the CancelBundleTask operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelBundleTask operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CancelBundleTaskResponse> CancelBundleTaskAsync(CancelBundleTaskRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CancelConversionTask


        /// <summary>
        /// Initiates the asynchronous execution of the CancelConversionTask operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelConversionTask operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CancelConversionTaskResponse> CancelConversionTaskAsync(CancelConversionTaskRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CancelExportTask


        /// <summary>
        /// Initiates the asynchronous execution of the CancelExportTask operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelExportTask operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CancelExportTaskResponse> CancelExportTaskAsync(CancelExportTaskRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CancelReservedInstancesListing


        /// <summary>
        /// Initiates the asynchronous execution of the CancelReservedInstancesListing operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelReservedInstancesListing operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CancelReservedInstancesListingResponse> CancelReservedInstancesListingAsync(CancelReservedInstancesListingRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CancelSpotInstanceRequests


        /// <summary>
        /// Initiates the asynchronous execution of the CancelSpotInstanceRequests operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelSpotInstanceRequests operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CancelSpotInstanceRequestsResponse> CancelSpotInstanceRequestsAsync(CancelSpotInstanceRequestsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ConfirmProductInstance


        /// <summary>
        /// Initiates the asynchronous execution of the ConfirmProductInstance operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ConfirmProductInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ConfirmProductInstanceResponse> ConfirmProductInstanceAsync(ConfirmProductInstanceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CopyImage


        /// <summary>
        /// Initiates the asynchronous execution of the CopyImage operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CopyImage operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CopyImageResponse> CopyImageAsync(CopyImageRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CopySnapshot


        /// <summary>
        /// Initiates the asynchronous execution of the CopySnapshot operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CopySnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CopySnapshotResponse> CopySnapshotAsync(CopySnapshotRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateCustomerGateway


        /// <summary>
        /// Initiates the asynchronous execution of the CreateCustomerGateway operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCustomerGateway operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateCustomerGatewayResponse> CreateCustomerGatewayAsync(CreateCustomerGatewayRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateDhcpOptions


        /// <summary>
        /// Initiates the asynchronous execution of the CreateDhcpOptions operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDhcpOptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateDhcpOptionsResponse> CreateDhcpOptionsAsync(CreateDhcpOptionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateImage


        /// <summary>
        /// Initiates the asynchronous execution of the CreateImage operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateImage operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateImageResponse> CreateImageAsync(CreateImageRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateInstanceExportTask


        /// <summary>
        /// Initiates the asynchronous execution of the CreateInstanceExportTask operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateInstanceExportTask operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateInstanceExportTaskResponse> CreateInstanceExportTaskAsync(CreateInstanceExportTaskRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateInternetGateway


        /// <summary>
        /// Initiates the asynchronous execution of the CreateInternetGateway operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateInternetGateway operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateInternetGatewayResponse> CreateInternetGatewayAsync(CreateInternetGatewayRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateKeyPair


        /// <summary>
        /// Initiates the asynchronous execution of the CreateKeyPair operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateKeyPair operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateKeyPairResponse> CreateKeyPairAsync(CreateKeyPairRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateNetworkAcl


        /// <summary>
        /// Initiates the asynchronous execution of the CreateNetworkAcl operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateNetworkAcl operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateNetworkAclResponse> CreateNetworkAclAsync(CreateNetworkAclRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateNetworkAclEntry


        /// <summary>
        /// Initiates the asynchronous execution of the CreateNetworkAclEntry operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateNetworkAclEntry operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateNetworkAclEntryResponse> CreateNetworkAclEntryAsync(CreateNetworkAclEntryRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateNetworkInterface


        /// <summary>
        /// Initiates the asynchronous execution of the CreateNetworkInterface operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateNetworkInterface operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateNetworkInterfaceResponse> CreateNetworkInterfaceAsync(CreateNetworkInterfaceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreatePlacementGroup


        /// <summary>
        /// Initiates the asynchronous execution of the CreatePlacementGroup operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePlacementGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreatePlacementGroupResponse> CreatePlacementGroupAsync(CreatePlacementGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateReservedInstancesListing


        /// <summary>
        /// Initiates the asynchronous execution of the CreateReservedInstancesListing operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateReservedInstancesListing operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateReservedInstancesListingResponse> CreateReservedInstancesListingAsync(CreateReservedInstancesListingRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateRoute


        /// <summary>
        /// Initiates the asynchronous execution of the CreateRoute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRoute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateRouteResponse> CreateRouteAsync(CreateRouteRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateRouteTable


        /// <summary>
        /// Initiates the asynchronous execution of the CreateRouteTable operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRouteTable operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateRouteTableResponse> CreateRouteTableAsync(CreateRouteTableRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateSecurityGroup


        /// <summary>
        /// Initiates the asynchronous execution of the CreateSecurityGroup operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSecurityGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateSecurityGroupResponse> CreateSecurityGroupAsync(CreateSecurityGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateSnapshot


        /// <summary>
        /// Initiates the asynchronous execution of the CreateSnapshot operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateSnapshotResponse> CreateSnapshotAsync(CreateSnapshotRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateSpotDatafeedSubscription


        /// <summary>
        /// Initiates the asynchronous execution of the CreateSpotDatafeedSubscription operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSpotDatafeedSubscription operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateSpotDatafeedSubscriptionResponse> CreateSpotDatafeedSubscriptionAsync(CreateSpotDatafeedSubscriptionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateSubnet


        /// <summary>
        /// Initiates the asynchronous execution of the CreateSubnet operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSubnet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateSubnetResponse> CreateSubnetAsync(CreateSubnetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateTags


        /// <summary>
        /// Initiates the asynchronous execution of the CreateTags operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateTagsResponse> CreateTagsAsync(CreateTagsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateVolume


        /// <summary>
        /// Initiates the asynchronous execution of the CreateVolume operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVolume operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateVolumeResponse> CreateVolumeAsync(CreateVolumeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateVpc


        /// <summary>
        /// Initiates the asynchronous execution of the CreateVpc operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVpc operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateVpcResponse> CreateVpcAsync(CreateVpcRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateVpcPeeringConnection


        /// <summary>
        /// Initiates the asynchronous execution of the CreateVpcPeeringConnection operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVpcPeeringConnection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateVpcPeeringConnectionResponse> CreateVpcPeeringConnectionAsync(CreateVpcPeeringConnectionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateVpnConnection


        /// <summary>
        /// Initiates the asynchronous execution of the CreateVpnConnection operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVpnConnection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateVpnConnectionResponse> CreateVpnConnectionAsync(CreateVpnConnectionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateVpnConnectionRoute


        /// <summary>
        /// Initiates the asynchronous execution of the CreateVpnConnectionRoute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVpnConnectionRoute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateVpnConnectionRouteResponse> CreateVpnConnectionRouteAsync(CreateVpnConnectionRouteRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateVpnGateway


        /// <summary>
        /// Initiates the asynchronous execution of the CreateVpnGateway operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVpnGateway operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateVpnGatewayResponse> CreateVpnGatewayAsync(CreateVpnGatewayRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteCustomerGateway


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCustomerGateway operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCustomerGateway operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteCustomerGatewayResponse> DeleteCustomerGatewayAsync(DeleteCustomerGatewayRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteDhcpOptions


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDhcpOptions operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDhcpOptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteDhcpOptionsResponse> DeleteDhcpOptionsAsync(DeleteDhcpOptionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteInternetGateway


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteInternetGateway operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteInternetGateway operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteInternetGatewayResponse> DeleteInternetGatewayAsync(DeleteInternetGatewayRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteKeyPair


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteKeyPair operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteKeyPair operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteKeyPairResponse> DeleteKeyPairAsync(DeleteKeyPairRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteNetworkAcl


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteNetworkAcl operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteNetworkAcl operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteNetworkAclResponse> DeleteNetworkAclAsync(DeleteNetworkAclRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteNetworkAclEntry


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteNetworkAclEntry operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteNetworkAclEntry operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteNetworkAclEntryResponse> DeleteNetworkAclEntryAsync(DeleteNetworkAclEntryRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteNetworkInterface


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteNetworkInterface operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteNetworkInterface operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteNetworkInterfaceResponse> DeleteNetworkInterfaceAsync(DeleteNetworkInterfaceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeletePlacementGroup


        /// <summary>
        /// Initiates the asynchronous execution of the DeletePlacementGroup operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePlacementGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeletePlacementGroupResponse> DeletePlacementGroupAsync(DeletePlacementGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteRoute


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRoute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRoute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteRouteResponse> DeleteRouteAsync(DeleteRouteRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteRouteTable


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRouteTable operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRouteTable operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteRouteTableResponse> DeleteRouteTableAsync(DeleteRouteTableRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteSecurityGroup


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSecurityGroup operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSecurityGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteSecurityGroupResponse> DeleteSecurityGroupAsync(DeleteSecurityGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteSnapshot


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSnapshot operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteSnapshotResponse> DeleteSnapshotAsync(DeleteSnapshotRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteSpotDatafeedSubscription


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSpotDatafeedSubscription operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSpotDatafeedSubscription operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteSpotDatafeedSubscriptionResponse> DeleteSpotDatafeedSubscriptionAsync(DeleteSpotDatafeedSubscriptionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteSubnet


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSubnet operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSubnet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteSubnetResponse> DeleteSubnetAsync(DeleteSubnetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteTags


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTags operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteTagsResponse> DeleteTagsAsync(DeleteTagsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteVolume


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVolume operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVolume operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteVolumeResponse> DeleteVolumeAsync(DeleteVolumeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteVpc


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVpc operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpc operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteVpcResponse> DeleteVpcAsync(DeleteVpcRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteVpcPeeringConnection


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVpcPeeringConnection operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpcPeeringConnection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteVpcPeeringConnectionResponse> DeleteVpcPeeringConnectionAsync(DeleteVpcPeeringConnectionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteVpnConnection


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVpnConnection operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpnConnection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteVpnConnectionResponse> DeleteVpnConnectionAsync(DeleteVpnConnectionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteVpnConnectionRoute


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVpnConnectionRoute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpnConnectionRoute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteVpnConnectionRouteResponse> DeleteVpnConnectionRouteAsync(DeleteVpnConnectionRouteRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteVpnGateway


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVpnGateway operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpnGateway operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteVpnGatewayResponse> DeleteVpnGatewayAsync(DeleteVpnGatewayRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeregisterImage


        /// <summary>
        /// Initiates the asynchronous execution of the DeregisterImage operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterImage operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeregisterImageResponse> DeregisterImageAsync(DeregisterImageRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeAccountAttributes


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAccountAttributes operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeAccountAttributesResponse> DescribeAccountAttributesAsync(DescribeAccountAttributesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeAddresses


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAddresses operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAddresses operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeAddressesResponse> DescribeAddressesAsync(DescribeAddressesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeAvailabilityZones


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAvailabilityZones operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAvailabilityZones operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeAvailabilityZonesResponse> DescribeAvailabilityZonesAsync(DescribeAvailabilityZonesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeBundleTasks


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeBundleTasks operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeBundleTasks operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeBundleTasksResponse> DescribeBundleTasksAsync(DescribeBundleTasksRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeConversionTasks


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeConversionTasks operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeConversionTasks operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeConversionTasksResponse> DescribeConversionTasksAsync(DescribeConversionTasksRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeCustomerGateways


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCustomerGateways operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCustomerGateways operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeCustomerGatewaysResponse> DescribeCustomerGatewaysAsync(DescribeCustomerGatewaysRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeDhcpOptions


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDhcpOptions operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDhcpOptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeDhcpOptionsResponse> DescribeDhcpOptionsAsync(DescribeDhcpOptionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeExportTasks


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeExportTasks operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeExportTasks operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeExportTasksResponse> DescribeExportTasksAsync(DescribeExportTasksRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeImageAttribute


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeImageAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeImageAttribute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeImageAttributeResponse> DescribeImageAttributeAsync(DescribeImageAttributeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeImages


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeImages operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeImages operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeImagesResponse> DescribeImagesAsync(DescribeImagesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeInstanceAttribute


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeInstanceAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstanceAttribute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeInstanceAttributeResponse> DescribeInstanceAttributeAsync(DescribeInstanceAttributeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeInstances


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeInstances operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeInstancesResponse> DescribeInstancesAsync(DescribeInstancesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeInstanceStatus


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeInstanceStatus operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstanceStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeInstanceStatusResponse> DescribeInstanceStatusAsync(DescribeInstanceStatusRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeInternetGateways


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeInternetGateways operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInternetGateways operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeInternetGatewaysResponse> DescribeInternetGatewaysAsync(DescribeInternetGatewaysRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeKeyPairs


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeKeyPairs operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeKeyPairs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeKeyPairsResponse> DescribeKeyPairsAsync(DescribeKeyPairsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeNetworkAcls


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeNetworkAcls operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeNetworkAcls operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeNetworkAclsResponse> DescribeNetworkAclsAsync(DescribeNetworkAclsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeNetworkInterfaceAttribute


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeNetworkInterfaceAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeNetworkInterfaceAttribute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeNetworkInterfaceAttributeResponse> DescribeNetworkInterfaceAttributeAsync(DescribeNetworkInterfaceAttributeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeNetworkInterfaces


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeNetworkInterfaces operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeNetworkInterfaces operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeNetworkInterfacesResponse> DescribeNetworkInterfacesAsync(DescribeNetworkInterfacesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribePlacementGroups


        /// <summary>
        /// Initiates the asynchronous execution of the DescribePlacementGroups operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePlacementGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribePlacementGroupsResponse> DescribePlacementGroupsAsync(DescribePlacementGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeRegions


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRegions operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRegions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeRegionsResponse> DescribeRegionsAsync(DescribeRegionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeReservedInstances


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReservedInstances operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeReservedInstancesResponse> DescribeReservedInstancesAsync(DescribeReservedInstancesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeReservedInstancesListings


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReservedInstancesListings operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedInstancesListings operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeReservedInstancesListingsResponse> DescribeReservedInstancesListingsAsync(DescribeReservedInstancesListingsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeReservedInstancesModifications


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReservedInstancesModifications operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedInstancesModifications operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeReservedInstancesModificationsResponse> DescribeReservedInstancesModificationsAsync(DescribeReservedInstancesModificationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeReservedInstancesOfferings


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReservedInstancesOfferings operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedInstancesOfferings operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeReservedInstancesOfferingsResponse> DescribeReservedInstancesOfferingsAsync(DescribeReservedInstancesOfferingsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeRouteTables


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRouteTables operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRouteTables operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeRouteTablesResponse> DescribeRouteTablesAsync(DescribeRouteTablesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeSecurityGroups


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSecurityGroups operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSecurityGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeSecurityGroupsResponse> DescribeSecurityGroupsAsync(DescribeSecurityGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeSnapshotAttribute


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSnapshotAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSnapshotAttribute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeSnapshotAttributeResponse> DescribeSnapshotAttributeAsync(DescribeSnapshotAttributeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeSnapshots


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSnapshots operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSnapshots operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeSnapshotsResponse> DescribeSnapshotsAsync(DescribeSnapshotsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeSpotDatafeedSubscription


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSpotDatafeedSubscription operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSpotDatafeedSubscription operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeSpotDatafeedSubscriptionResponse> DescribeSpotDatafeedSubscriptionAsync(DescribeSpotDatafeedSubscriptionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeSpotInstanceRequests


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSpotInstanceRequests operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSpotInstanceRequests operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeSpotInstanceRequestsResponse> DescribeSpotInstanceRequestsAsync(DescribeSpotInstanceRequestsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeSpotPriceHistory


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSpotPriceHistory operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSpotPriceHistory operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeSpotPriceHistoryResponse> DescribeSpotPriceHistoryAsync(DescribeSpotPriceHistoryRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeSubnets


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSubnets operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSubnets operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeSubnetsResponse> DescribeSubnetsAsync(DescribeSubnetsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeTags


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTags operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeTagsResponse> DescribeTagsAsync(DescribeTagsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeVolumeAttribute


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVolumeAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVolumeAttribute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeVolumeAttributeResponse> DescribeVolumeAttributeAsync(DescribeVolumeAttributeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeVolumes


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVolumes operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVolumes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeVolumesResponse> DescribeVolumesAsync(DescribeVolumesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeVolumeStatus


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVolumeStatus operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVolumeStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeVolumeStatusResponse> DescribeVolumeStatusAsync(DescribeVolumeStatusRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeVpcAttribute


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVpcAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcAttribute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeVpcAttributeResponse> DescribeVpcAttributeAsync(DescribeVpcAttributeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeVpcPeeringConnections


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVpcPeeringConnections operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcPeeringConnections operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeVpcPeeringConnectionsResponse> DescribeVpcPeeringConnectionsAsync(DescribeVpcPeeringConnectionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeVpcs


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVpcs operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeVpcsResponse> DescribeVpcsAsync(DescribeVpcsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeVpnConnections


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVpnConnections operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpnConnections operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeVpnConnectionsResponse> DescribeVpnConnectionsAsync(DescribeVpnConnectionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeVpnGateways


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVpnGateways operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpnGateways operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeVpnGatewaysResponse> DescribeVpnGatewaysAsync(DescribeVpnGatewaysRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DetachInternetGateway


        /// <summary>
        /// Initiates the asynchronous execution of the DetachInternetGateway operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachInternetGateway operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DetachInternetGatewayResponse> DetachInternetGatewayAsync(DetachInternetGatewayRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DetachNetworkInterface


        /// <summary>
        /// Initiates the asynchronous execution of the DetachNetworkInterface operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachNetworkInterface operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DetachNetworkInterfaceResponse> DetachNetworkInterfaceAsync(DetachNetworkInterfaceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DetachVolume


        /// <summary>
        /// Initiates the asynchronous execution of the DetachVolume operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachVolume operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DetachVolumeResponse> DetachVolumeAsync(DetachVolumeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DetachVpnGateway


        /// <summary>
        /// Initiates the asynchronous execution of the DetachVpnGateway operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachVpnGateway operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DetachVpnGatewayResponse> DetachVpnGatewayAsync(DetachVpnGatewayRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisableVgwRoutePropagation


        /// <summary>
        /// Initiates the asynchronous execution of the DisableVgwRoutePropagation operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableVgwRoutePropagation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DisableVgwRoutePropagationResponse> DisableVgwRoutePropagationAsync(DisableVgwRoutePropagationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisassociateAddress


        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateAddress operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateAddress operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DisassociateAddressResponse> DisassociateAddressAsync(DisassociateAddressRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisassociateRouteTable


        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateRouteTable operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateRouteTable operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DisassociateRouteTableResponse> DisassociateRouteTableAsync(DisassociateRouteTableRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  EnableVgwRoutePropagation


        /// <summary>
        /// Initiates the asynchronous execution of the EnableVgwRoutePropagation operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableVgwRoutePropagation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<EnableVgwRoutePropagationResponse> EnableVgwRoutePropagationAsync(EnableVgwRoutePropagationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  EnableVolumeIO


        /// <summary>
        /// Initiates the asynchronous execution of the EnableVolumeIO operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableVolumeIO operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<EnableVolumeIOResponse> EnableVolumeIOAsync(EnableVolumeIORequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetConsoleOutput


        /// <summary>
        /// Initiates the asynchronous execution of the GetConsoleOutput operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetConsoleOutput operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetConsoleOutputResponse> GetConsoleOutputAsync(GetConsoleOutputRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetPasswordData


        /// <summary>
        /// Initiates the asynchronous execution of the GetPasswordData operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPasswordData operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetPasswordDataResponse> GetPasswordDataAsync(GetPasswordDataRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ImportInstance


        /// <summary>
        /// Initiates the asynchronous execution of the ImportInstance operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ImportInstanceResponse> ImportInstanceAsync(ImportInstanceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ImportKeyPair


        /// <summary>
        /// Initiates the asynchronous execution of the ImportKeyPair operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportKeyPair operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ImportKeyPairResponse> ImportKeyPairAsync(ImportKeyPairRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ImportVolume


        /// <summary>
        /// Initiates the asynchronous execution of the ImportVolume operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportVolume operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ImportVolumeResponse> ImportVolumeAsync(ImportVolumeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifyImageAttribute


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyImageAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyImageAttribute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ModifyImageAttributeResponse> ModifyImageAttributeAsync(ModifyImageAttributeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifyInstanceAttribute


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyInstanceAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyInstanceAttribute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ModifyInstanceAttributeResponse> ModifyInstanceAttributeAsync(ModifyInstanceAttributeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifyNetworkInterfaceAttribute


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyNetworkInterfaceAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyNetworkInterfaceAttribute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ModifyNetworkInterfaceAttributeResponse> ModifyNetworkInterfaceAttributeAsync(ModifyNetworkInterfaceAttributeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifyReservedInstances


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyReservedInstances operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyReservedInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ModifyReservedInstancesResponse> ModifyReservedInstancesAsync(ModifyReservedInstancesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifySnapshotAttribute


        /// <summary>
        /// Initiates the asynchronous execution of the ModifySnapshotAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifySnapshotAttribute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ModifySnapshotAttributeResponse> ModifySnapshotAttributeAsync(ModifySnapshotAttributeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifySubnetAttribute


        /// <summary>
        /// Initiates the asynchronous execution of the ModifySubnetAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifySubnetAttribute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ModifySubnetAttributeResponse> ModifySubnetAttributeAsync(ModifySubnetAttributeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifyVolumeAttribute


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyVolumeAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyVolumeAttribute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ModifyVolumeAttributeResponse> ModifyVolumeAttributeAsync(ModifyVolumeAttributeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifyVpcAttribute


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyVpcAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyVpcAttribute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ModifyVpcAttributeResponse> ModifyVpcAttributeAsync(ModifyVpcAttributeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  MonitorInstances


        /// <summary>
        /// Initiates the asynchronous execution of the MonitorInstances operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the MonitorInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<MonitorInstancesResponse> MonitorInstancesAsync(MonitorInstancesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PurchaseReservedInstancesOffering


        /// <summary>
        /// Initiates the asynchronous execution of the PurchaseReservedInstancesOffering operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PurchaseReservedInstancesOffering operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<PurchaseReservedInstancesOfferingResponse> PurchaseReservedInstancesOfferingAsync(PurchaseReservedInstancesOfferingRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RebootInstances


        /// <summary>
        /// Initiates the asynchronous execution of the RebootInstances operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RebootInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<RebootInstancesResponse> RebootInstancesAsync(RebootInstancesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RegisterImage


        /// <summary>
        /// Initiates the asynchronous execution of the RegisterImage operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterImage operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<RegisterImageResponse> RegisterImageAsync(RegisterImageRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RejectVpcPeeringConnection


        /// <summary>
        /// Initiates the asynchronous execution of the RejectVpcPeeringConnection operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RejectVpcPeeringConnection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<RejectVpcPeeringConnectionResponse> RejectVpcPeeringConnectionAsync(RejectVpcPeeringConnectionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ReleaseAddress


        /// <summary>
        /// Initiates the asynchronous execution of the ReleaseAddress operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReleaseAddress operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ReleaseAddressResponse> ReleaseAddressAsync(ReleaseAddressRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ReplaceNetworkAclAssociation


        /// <summary>
        /// Initiates the asynchronous execution of the ReplaceNetworkAclAssociation operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReplaceNetworkAclAssociation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ReplaceNetworkAclAssociationResponse> ReplaceNetworkAclAssociationAsync(ReplaceNetworkAclAssociationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ReplaceNetworkAclEntry


        /// <summary>
        /// Initiates the asynchronous execution of the ReplaceNetworkAclEntry operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReplaceNetworkAclEntry operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ReplaceNetworkAclEntryResponse> ReplaceNetworkAclEntryAsync(ReplaceNetworkAclEntryRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ReplaceRoute


        /// <summary>
        /// Initiates the asynchronous execution of the ReplaceRoute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReplaceRoute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ReplaceRouteResponse> ReplaceRouteAsync(ReplaceRouteRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ReplaceRouteTableAssociation


        /// <summary>
        /// Initiates the asynchronous execution of the ReplaceRouteTableAssociation operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReplaceRouteTableAssociation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ReplaceRouteTableAssociationResponse> ReplaceRouteTableAssociationAsync(ReplaceRouteTableAssociationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ReportInstanceStatus


        /// <summary>
        /// Initiates the asynchronous execution of the ReportInstanceStatus operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReportInstanceStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ReportInstanceStatusResponse> ReportInstanceStatusAsync(ReportInstanceStatusRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RequestSpotInstances


        /// <summary>
        /// Initiates the asynchronous execution of the RequestSpotInstances operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RequestSpotInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<RequestSpotInstancesResponse> RequestSpotInstancesAsync(RequestSpotInstancesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ResetImageAttribute


        /// <summary>
        /// Initiates the asynchronous execution of the ResetImageAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetImageAttribute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ResetImageAttributeResponse> ResetImageAttributeAsync(ResetImageAttributeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ResetInstanceAttribute


        /// <summary>
        /// Initiates the asynchronous execution of the ResetInstanceAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetInstanceAttribute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ResetInstanceAttributeResponse> ResetInstanceAttributeAsync(ResetInstanceAttributeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ResetNetworkInterfaceAttribute


        /// <summary>
        /// Initiates the asynchronous execution of the ResetNetworkInterfaceAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetNetworkInterfaceAttribute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ResetNetworkInterfaceAttributeResponse> ResetNetworkInterfaceAttributeAsync(ResetNetworkInterfaceAttributeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ResetSnapshotAttribute


        /// <summary>
        /// Initiates the asynchronous execution of the ResetSnapshotAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetSnapshotAttribute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ResetSnapshotAttributeResponse> ResetSnapshotAttributeAsync(ResetSnapshotAttributeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RevokeSecurityGroupEgress


        /// <summary>
        /// Initiates the asynchronous execution of the RevokeSecurityGroupEgress operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RevokeSecurityGroupEgress operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<RevokeSecurityGroupEgressResponse> RevokeSecurityGroupEgressAsync(RevokeSecurityGroupEgressRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RevokeSecurityGroupIngress


        /// <summary>
        /// Initiates the asynchronous execution of the RevokeSecurityGroupIngress operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RevokeSecurityGroupIngress operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<RevokeSecurityGroupIngressResponse> RevokeSecurityGroupIngressAsync(RevokeSecurityGroupIngressRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RunInstances


        /// <summary>
        /// Initiates the asynchronous execution of the RunInstances operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RunInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<RunInstancesResponse> RunInstancesAsync(RunInstancesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartInstances


        /// <summary>
        /// Initiates the asynchronous execution of the StartInstances operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<StartInstancesResponse> StartInstancesAsync(StartInstancesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StopInstances


        /// <summary>
        /// Initiates the asynchronous execution of the StopInstances operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<StopInstancesResponse> StopInstancesAsync(StopInstancesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TerminateInstances


        /// <summary>
        /// Initiates the asynchronous execution of the TerminateInstances operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TerminateInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<TerminateInstancesResponse> TerminateInstancesAsync(TerminateInstancesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UnassignPrivateIpAddresses


        /// <summary>
        /// Initiates the asynchronous execution of the UnassignPrivateIpAddresses operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UnassignPrivateIpAddresses operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UnassignPrivateIpAddressesResponse> UnassignPrivateIpAddressesAsync(UnassignPrivateIpAddressesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UnmonitorInstances


        /// <summary>
        /// Initiates the asynchronous execution of the UnmonitorInstances operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UnmonitorInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UnmonitorInstancesResponse> UnmonitorInstancesAsync(UnmonitorInstancesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}