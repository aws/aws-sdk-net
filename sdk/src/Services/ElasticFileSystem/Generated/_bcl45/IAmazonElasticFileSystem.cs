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
 * Do not modify this file. This file is generated from the elasticfilesystem-2015-02-01.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.ElasticFileSystem.Model;

namespace Amazon.ElasticFileSystem
{
    /// <summary>
    /// Interface for accessing ElasticFileSystem
    ///
    /// Amazon Elastic File System
    /// </summary>
    public partial interface IAmazonElasticFileSystem : IDisposable
    {

        
        #region  CreateFileSystem


        /// <summary>
        /// Creates a new, empty file system. The operation requires a creation token in the
        /// request that Amazon EFS uses to ensure idempotent creation (calling the operation
        /// with same creation token has no effect). If a file system does not currently exist
        /// that is owned by the caller's AWS account with the specified creation token, this
        /// operation does the following: 
        /// 
        ///  <ul> <li>Creates a new, empty file system. The file system will have an Amazon EFS
        /// assigned ID, and an initial lifecycle state "creating". </li> <li> Returns with the
        /// description of the created file system. </li> </ul> 
        /// <para>
        /// Otherwise, this operation returns a <code>FileSystemAlreadyExists</code> error with
        /// the ID of the existing file system.
        /// </para>
        ///  <note>For basic use cases, you can use a randomly generated UUID for the creation
        /// token.</note> 
        /// <para>
        ///  The idempotent operation allows you to retry a <code>CreateFileSystem</code> call
        /// without risk of creating an extra file system. This can happen when an initial call
        /// fails in a way that leaves it uncertain whether or not a file system was actually
        /// created. An example might be that a transport level timeout occurred or your connection
        /// was reset. As long as you use the same creation token, if the initial call had succeeded
        /// in creating a file system, the client can learn of its existence from the <code>FileSystemAlreadyExists</code>
        /// error. 
        /// </para>
        ///  <note>The <code>CreateFileSystem</code> call returns while the file system's lifecycle
        /// state is still "creating". You can check the file system creation status by calling
        /// the <a>DescribeFileSystems</a> API, which among other things returns the file system
        /// state.</note> 
        /// <para>
        ///  After the file system is fully created, Amazon EFS sets its lifecycle state to "available",
        /// at which point you can create one or more mount targets for the file system (<a>CreateMountTarget</a>)
        /// in your VPC. You mount your Amazon EFS file system on an EC2 instances in your VPC
        /// via the mount target. For more information, see <a href="http://docs.aws.amazon.com/efs/latest/ug/how-it-works.html">Amazon
        /// EFS: How it Works</a> 
        /// </para>
        ///  
        /// <para>
        ///  This operation requires permission for the <code>elasticfilesystem:CreateFileSystem</code>
        /// action. 
        /// </para>
        /// </summary>
        /// <param name="creationToken">String of up to 64 ASCII characters. Amazon EFS uses this to ensure idempotent creation.</param>
        /// 
        /// <returns>The response from the CreateFileSystem service method, as returned by ElasticFileSystem.</returns>
        /// <exception cref="Amazon.ElasticFileSystem.Model.BadRequestException">
        /// Returned if the request is malformed or contains an error such as an invalid parameter
        /// value or a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.FileSystemAlreadyExistsException">
        /// Returned if the file system you are trying to create already exists, with the creation
        /// token you provided.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.FileSystemLimitExceededException">
        /// Returned if the AWS account has already created maximum number of file systems allowed
        /// per account.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.InternalServerErrorException">
        /// Returned if an error occurred on the server side.
        /// </exception>
        CreateFileSystemResponse CreateFileSystem(string creationToken);

        /// <summary>
        /// Creates a new, empty file system. The operation requires a creation token in the
        /// request that Amazon EFS uses to ensure idempotent creation (calling the operation
        /// with same creation token has no effect). If a file system does not currently exist
        /// that is owned by the caller's AWS account with the specified creation token, this
        /// operation does the following: 
        /// 
        ///  <ul> <li>Creates a new, empty file system. The file system will have an Amazon EFS
        /// assigned ID, and an initial lifecycle state "creating". </li> <li> Returns with the
        /// description of the created file system. </li> </ul> 
        /// <para>
        /// Otherwise, this operation returns a <code>FileSystemAlreadyExists</code> error with
        /// the ID of the existing file system.
        /// </para>
        ///  <note>For basic use cases, you can use a randomly generated UUID for the creation
        /// token.</note> 
        /// <para>
        ///  The idempotent operation allows you to retry a <code>CreateFileSystem</code> call
        /// without risk of creating an extra file system. This can happen when an initial call
        /// fails in a way that leaves it uncertain whether or not a file system was actually
        /// created. An example might be that a transport level timeout occurred or your connection
        /// was reset. As long as you use the same creation token, if the initial call had succeeded
        /// in creating a file system, the client can learn of its existence from the <code>FileSystemAlreadyExists</code>
        /// error. 
        /// </para>
        ///  <note>The <code>CreateFileSystem</code> call returns while the file system's lifecycle
        /// state is still "creating". You can check the file system creation status by calling
        /// the <a>DescribeFileSystems</a> API, which among other things returns the file system
        /// state.</note> 
        /// <para>
        ///  After the file system is fully created, Amazon EFS sets its lifecycle state to "available",
        /// at which point you can create one or more mount targets for the file system (<a>CreateMountTarget</a>)
        /// in your VPC. You mount your Amazon EFS file system on an EC2 instances in your VPC
        /// via the mount target. For more information, see <a href="http://docs.aws.amazon.com/efs/latest/ug/how-it-works.html">Amazon
        /// EFS: How it Works</a> 
        /// </para>
        ///  
        /// <para>
        ///  This operation requires permission for the <code>elasticfilesystem:CreateFileSystem</code>
        /// action. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFileSystem service method.</param>
        /// 
        /// <returns>The response from the CreateFileSystem service method, as returned by ElasticFileSystem.</returns>
        /// <exception cref="Amazon.ElasticFileSystem.Model.BadRequestException">
        /// Returned if the request is malformed or contains an error such as an invalid parameter
        /// value or a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.FileSystemAlreadyExistsException">
        /// Returned if the file system you are trying to create already exists, with the creation
        /// token you provided.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.FileSystemLimitExceededException">
        /// Returned if the AWS account has already created maximum number of file systems allowed
        /// per account.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.InternalServerErrorException">
        /// Returned if an error occurred on the server side.
        /// </exception>
        CreateFileSystemResponse CreateFileSystem(CreateFileSystemRequest request);


        /// <summary>
        /// Creates a new, empty file system. The operation requires a creation token in the
        /// request that Amazon EFS uses to ensure idempotent creation (calling the operation
        /// with same creation token has no effect). If a file system does not currently exist
        /// that is owned by the caller's AWS account with the specified creation token, this
        /// operation does the following: 
        /// 
        ///  <ul> <li>Creates a new, empty file system. The file system will have an Amazon EFS
        /// assigned ID, and an initial lifecycle state "creating". </li> <li> Returns with the
        /// description of the created file system. </li> </ul> 
        /// <para>
        /// Otherwise, this operation returns a <code>FileSystemAlreadyExists</code> error with
        /// the ID of the existing file system.
        /// </para>
        ///  <note>For basic use cases, you can use a randomly generated UUID for the creation
        /// token.</note> 
        /// <para>
        ///  The idempotent operation allows you to retry a <code>CreateFileSystem</code> call
        /// without risk of creating an extra file system. This can happen when an initial call
        /// fails in a way that leaves it uncertain whether or not a file system was actually
        /// created. An example might be that a transport level timeout occurred or your connection
        /// was reset. As long as you use the same creation token, if the initial call had succeeded
        /// in creating a file system, the client can learn of its existence from the <code>FileSystemAlreadyExists</code>
        /// error. 
        /// </para>
        ///  <note>The <code>CreateFileSystem</code> call returns while the file system's lifecycle
        /// state is still "creating". You can check the file system creation status by calling
        /// the <a>DescribeFileSystems</a> API, which among other things returns the file system
        /// state.</note> 
        /// <para>
        ///  After the file system is fully created, Amazon EFS sets its lifecycle state to "available",
        /// at which point you can create one or more mount targets for the file system (<a>CreateMountTarget</a>)
        /// in your VPC. You mount your Amazon EFS file system on an EC2 instances in your VPC
        /// via the mount target. For more information, see <a href="http://docs.aws.amazon.com/efs/latest/ug/how-it-works.html">Amazon
        /// EFS: How it Works</a> 
        /// </para>
        ///  
        /// <para>
        ///  This operation requires permission for the <code>elasticfilesystem:CreateFileSystem</code>
        /// action. 
        /// </para>
        /// </summary>
        /// <param name="creationToken">String of up to 64 ASCII characters. Amazon EFS uses this to ensure idempotent creation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateFileSystem service method, as returned by ElasticFileSystem.</returns>
        /// <exception cref="Amazon.ElasticFileSystem.Model.BadRequestException">
        /// Returned if the request is malformed or contains an error such as an invalid parameter
        /// value or a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.FileSystemAlreadyExistsException">
        /// Returned if the file system you are trying to create already exists, with the creation
        /// token you provided.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.FileSystemLimitExceededException">
        /// Returned if the AWS account has already created maximum number of file systems allowed
        /// per account.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.InternalServerErrorException">
        /// Returned if an error occurred on the server side.
        /// </exception>
        Task<CreateFileSystemResponse> CreateFileSystemAsync(string creationToken, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the CreateFileSystem operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateFileSystem operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateFileSystemResponse> CreateFileSystemAsync(CreateFileSystemRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateMountTarget


        /// <summary>
        /// Creates a mount target for a file system. You can then mount the file system on EC2
        /// instances via the mount target. 
        /// 
        ///  
        /// <para>
        /// You can create one mount target in each Availability Zone in your VPC. All EC2 instances
        /// in a VPC within a given Availability Zone share a single mount target for a given
        /// file system. If you have multiple subnets in an Availability Zone, you create a mount
        /// target in one of the subnets. EC2 instances do not need to be in the same subnet as
        /// the mount target in order to access their file system. For more information, see <a
        /// href="http://docs.aws.amazon.com/efs/latest/ug/how-it-works.html">Amazon EFS: How
        /// it Works</a>. 
        /// </para>
        ///  
        /// <para>
        /// In the request, you also specify a file system ID for which you are creating the mount
        /// target and the file system's lifecycle state must be "available" (see <a>DescribeFileSystems</a>).
        /// </para>
        ///  
        /// <para>
        ///  In the request, you also provide a subnet ID, which serves several purposes:
        /// </para>
        ///  <ul> <li>It determines the VPC in which Amazon EFS creates the mount target.</li>
        /// <li>It determines the Availability Zone in which Amazon EFS creates the mount target.
        /// </li> <li>It determines the IP address range from which Amazon EFS selects the IP
        /// address of the mount target if you don't specify an IP address in the request. </li>
        /// </ul> 
        /// <para>
        /// After creating the mount target, Amazon EFS returns a response that includes, a <code>MountTargetId</code>
        /// and an <code>IpAddress</code>. You use this IP address when mounting the file system
        /// in an EC2 instance. You can also use the mount target's DNS name when mounting the
        /// file system. The EC2 instance on which you mount the file system via the mount target
        /// can resolve the mount target's DNS name to its IP address. For more information, see
        /// <a href="http://docs.aws.amazon.com/efs/latest/ug/how-it-works.html#how-it-works-implementation">How
        /// it Works: Implementation Overview</a>. 
        /// </para>
        ///  
        /// <para>
        ///  Note that you can create mount targets for a file system in only one VPC, and there
        /// can be only one mount target per Availability Zone. That is, if the file system already
        /// has one or more mount targets created for it, the request to add another mount target
        /// must meet the following requirements: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The subnet specified in the request must belong to the same VPC as the subnets of
        /// the existing mount targets.
        /// </para>
        ///  </li> <li>The subnet specified in the request must not be in the same Availability
        /// Zone as any of the subnets of the existing mount targets.</li> </ul> 
        /// <para>
        /// If the request satisfies the requirements, Amazon EFS does the following:
        /// </para>
        ///  <ul> <li>Creates a new mount target in the specified subnet. </li> <li>Also creates
        /// a new network interface in the subnet as follows: <ul> <li>If the request provides
        /// an <code>IpAddress</code>, Amazon EFS assigns that IP address to the network interface.
        /// Otherwise, Amazon EFS assigns a free address in the subnet (in the same way that the
        /// Amazon EC2 <code>CreateNetworkInterface</code> call does when a request does not specify
        /// a primary private IP address).</li> <li>If the request provides <code>SecurityGroups</code>,
        /// this network interface is associated with those security groups. Otherwise, it belongs
        /// to the default security group for the subnet's VPC.</li> <li>Assigns the description
        /// <code>"Mount target <i>fsmt-id</i> for file system <i>fs-id</i>"</code> where <code><i>fsmt-id</i></code>
        /// is the mount target ID, and <code><i>fs-id</i></code> is the <code>FileSystemId</code>.</li>
        /// <li>Sets the <code>requesterManaged</code> property of the network interface to "true",
        /// and the <code>requesterId</code> value to "EFS".</li> </ul> 
        /// <para>
        /// Each Amazon EFS mount target has one corresponding requestor-managed EC2 network interface.
        /// After the network interface is created, Amazon EFS sets the <code>NetworkInterfaceId</code>
        /// field in the mount target's description to the network interface ID, and the <code>IpAddress</code>
        /// field to its address. If network interface creation fails, the entire <code>CreateMountTarget</code>
        /// operation fails.
        /// </para>
        ///  </li> </ul> <note>The <code>CreateMountTarget</code> call returns only after creating
        /// the network interface, but while the mount target state is still "creating". You can
        /// check the mount target creation status by calling the <a>DescribeFileSystems</a> API,
        /// which among other things returns the mount target state.</note> 
        /// <para>
        /// We recommend you create a mount target in each of the Availability Zones. There are
        /// cost considerations for using a file system in an Availability Zone through a mount
        /// target created in another Availability Zone. For more information, go to <a href="http://aws.amazon.com/efs/">Amazon
        /// EFS</a> product detail page. In addition, by always using a mount target local to
        /// the instance's Availability Zone, you eliminate a partial failure scenario; if the
        /// Availability Zone in which your mount target is created goes down, then you won't
        /// be able to access your file system through that mount target. 
        /// </para>
        ///  
        /// <para>
        /// This operation requires permission for the following action on the file system:
        /// </para>
        ///  <ul> <li> <code>elasticfilesystem:CreateMountTarget</code> </li> </ul> 
        /// <para>
        /// This operation also requires permission for the following Amazon EC2 actions:
        /// </para>
        ///  <ul> <li> <code>ec2:DescribeSubnets</code> </li> <li> <code>ec2:DescribeNetworkInterfaces</code>
        /// </li> <li> <code>ec2:CreateNetworkInterface</code> </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMountTarget service method.</param>
        /// 
        /// <returns>The response from the CreateMountTarget service method, as returned by ElasticFileSystem.</returns>
        /// <exception cref="Amazon.ElasticFileSystem.Model.BadRequestException">
        /// Returned if the request is malformed or contains an error such as an invalid parameter
        /// value or a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.FileSystemNotFoundException">
        /// Returned if the specified <code>FileSystemId</code> does not exist in the requester's
        /// AWS account.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.IncorrectFileSystemLifeCycleStateException">
        /// Returned if the file system's life cycle state is not "created".
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.InternalServerErrorException">
        /// Returned if an error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.IpAddressInUseException">
        /// Returned if the request specified an <code>IpAddress</code> that is already in use
        /// in the subnet.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.MountTargetConflictException">
        /// Returned if the mount target would violate one of the specified restrictions based
        /// on the file system's existing mount targets.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.NetworkInterfaceLimitExceededException">
        /// The calling account has reached the ENI limit for the specific AWS region. Client
        /// should try to delete some ENIs or get its account limit raised. For more information,
        /// go to <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Appendix_Limits.html">Amazon
        /// VPC Limits</a> in the Amazon Virtual Private Cloud User Guide (see the Network interfaces
        /// per VPC entry in the table).
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.NoFreeAddressesInSubnetException">
        /// Returned if <code>IpAddress</code> was not specified in the request and there are
        /// no free IP addresses in the subnet.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.SecurityGroupLimitExceededException">
        /// Returned if the size of <code>SecurityGroups</code> specified in the request is greater
        /// than five.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.SecurityGroupNotFoundException">
        /// Returned if one of the specified security groups does not exist in the subnet's VPC.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.SubnetNotFoundException">
        /// Returned if there is no subnet with ID <code>SubnetId</code> provided in the request.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.UnsupportedAvailabilityZoneException">
        /// 
        /// </exception>
        CreateMountTargetResponse CreateMountTarget(CreateMountTargetRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateMountTarget operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateMountTarget operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateMountTargetResponse> CreateMountTargetAsync(CreateMountTargetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateTags


        /// <summary>
        /// Creates or overwrites tags associated with a file system. Each tag is a key-value
        /// pair. If a tag key specified in the request already exists on the file system, this
        /// operation overwrites its value with the value provided in the request. If you add
        /// the "Name" tag to your file system, Amazon EFS returns it in the response to the <a>DescribeFileSystems</a>
        /// API. 
        /// 
        ///  
        /// <para>
        /// This operation requires permission for the <code>elasticfilesystem:CreateTags</code>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTags service method.</param>
        /// 
        /// <returns>The response from the CreateTags service method, as returned by ElasticFileSystem.</returns>
        /// <exception cref="Amazon.ElasticFileSystem.Model.BadRequestException">
        /// Returned if the request is malformed or contains an error such as an invalid parameter
        /// value or a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.FileSystemNotFoundException">
        /// Returned if the specified <code>FileSystemId</code> does not exist in the requester's
        /// AWS account.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.InternalServerErrorException">
        /// Returned if an error occurred on the server side.
        /// </exception>
        CreateTagsResponse CreateTags(CreateTagsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateTagsResponse> CreateTagsAsync(CreateTagsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteFileSystem


        /// <summary>
        /// Deletes a file system, permanently severing access to its contents. Upon return,
        /// the file system no longer exists and you will not be able to access any contents of
        /// the deleted file system. 
        /// 
        ///  
        /// <para>
        ///  You cannot delete a file system that is in use. That is, if the file system has any
        /// mount targets, you must first delete them. For more information, see <a>DescribeMountTargets</a>
        /// and <a>DeleteMountTarget</a>. 
        /// </para>
        ///  <note>The <code>DeleteFileSystem</code> call returns while the file system state
        /// is still "deleting". You can check the file system deletion status by calling the
        /// <a>DescribeFileSystems</a> API, which returns a list of file systems in your account.
        /// If you pass file system ID or creation token for the deleted file system, the <a>DescribeFileSystems</a>
        /// will return a 404 "FileSystemNotFound" error.</note> 
        /// <para>
        /// This operation requires permission for the <code>elasticfilesystem:DeleteFileSystem</code>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="fileSystemId">The ID of the file system you want to delete.</param>
        /// 
        /// <returns>The response from the DeleteFileSystem service method, as returned by ElasticFileSystem.</returns>
        /// <exception cref="Amazon.ElasticFileSystem.Model.BadRequestException">
        /// Returned if the request is malformed or contains an error such as an invalid parameter
        /// value or a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.FileSystemInUseException">
        /// Returned if a file system has mount targets.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.FileSystemNotFoundException">
        /// Returned if the specified <code>FileSystemId</code> does not exist in the requester's
        /// AWS account.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.InternalServerErrorException">
        /// Returned if an error occurred on the server side.
        /// </exception>
        DeleteFileSystemResponse DeleteFileSystem(string fileSystemId);

        /// <summary>
        /// Deletes a file system, permanently severing access to its contents. Upon return,
        /// the file system no longer exists and you will not be able to access any contents of
        /// the deleted file system. 
        /// 
        ///  
        /// <para>
        ///  You cannot delete a file system that is in use. That is, if the file system has any
        /// mount targets, you must first delete them. For more information, see <a>DescribeMountTargets</a>
        /// and <a>DeleteMountTarget</a>. 
        /// </para>
        ///  <note>The <code>DeleteFileSystem</code> call returns while the file system state
        /// is still "deleting". You can check the file system deletion status by calling the
        /// <a>DescribeFileSystems</a> API, which returns a list of file systems in your account.
        /// If you pass file system ID or creation token for the deleted file system, the <a>DescribeFileSystems</a>
        /// will return a 404 "FileSystemNotFound" error.</note> 
        /// <para>
        /// This operation requires permission for the <code>elasticfilesystem:DeleteFileSystem</code>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFileSystem service method.</param>
        /// 
        /// <returns>The response from the DeleteFileSystem service method, as returned by ElasticFileSystem.</returns>
        /// <exception cref="Amazon.ElasticFileSystem.Model.BadRequestException">
        /// Returned if the request is malformed or contains an error such as an invalid parameter
        /// value or a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.FileSystemInUseException">
        /// Returned if a file system has mount targets.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.FileSystemNotFoundException">
        /// Returned if the specified <code>FileSystemId</code> does not exist in the requester's
        /// AWS account.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.InternalServerErrorException">
        /// Returned if an error occurred on the server side.
        /// </exception>
        DeleteFileSystemResponse DeleteFileSystem(DeleteFileSystemRequest request);


        /// <summary>
        /// Deletes a file system, permanently severing access to its contents. Upon return,
        /// the file system no longer exists and you will not be able to access any contents of
        /// the deleted file system. 
        /// 
        ///  
        /// <para>
        ///  You cannot delete a file system that is in use. That is, if the file system has any
        /// mount targets, you must first delete them. For more information, see <a>DescribeMountTargets</a>
        /// and <a>DeleteMountTarget</a>. 
        /// </para>
        ///  <note>The <code>DeleteFileSystem</code> call returns while the file system state
        /// is still "deleting". You can check the file system deletion status by calling the
        /// <a>DescribeFileSystems</a> API, which returns a list of file systems in your account.
        /// If you pass file system ID or creation token for the deleted file system, the <a>DescribeFileSystems</a>
        /// will return a 404 "FileSystemNotFound" error.</note> 
        /// <para>
        /// This operation requires permission for the <code>elasticfilesystem:DeleteFileSystem</code>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="fileSystemId">The ID of the file system you want to delete.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteFileSystem service method, as returned by ElasticFileSystem.</returns>
        /// <exception cref="Amazon.ElasticFileSystem.Model.BadRequestException">
        /// Returned if the request is malformed or contains an error such as an invalid parameter
        /// value or a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.FileSystemInUseException">
        /// Returned if a file system has mount targets.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.FileSystemNotFoundException">
        /// Returned if the specified <code>FileSystemId</code> does not exist in the requester's
        /// AWS account.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.InternalServerErrorException">
        /// Returned if an error occurred on the server side.
        /// </exception>
        Task<DeleteFileSystemResponse> DeleteFileSystemAsync(string fileSystemId, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteFileSystem operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFileSystem operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteFileSystemResponse> DeleteFileSystemAsync(DeleteFileSystemRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteMountTarget


        /// <summary>
        /// Deletes the specified mount target. 
        /// 
        ///  
        /// <para>
        ///  This operation forcibly breaks any mounts of the file system via the mount target
        /// being deleted, which might disrupt instances or applications using those mounts. To
        /// avoid applications getting cut off abruptly, you might consider unmounting any mounts
        /// of the mount target, if feasible. The operation also deletes the associated network
        /// interface. Uncommitted writes may be lost, but breaking a mount target using this
        /// operation does not corrupt the file system itself. The file system you created remains.
        /// You can mount an EC2 instance in your VPC using another mount target. 
        /// </para>
        ///  
        /// <para>
        ///  This operation requires permission for the following action on the file system: 
        /// </para>
        ///  <ul> <li> <code>elasticfilesystem:DeleteMountTarget</code> </li> </ul> <note>The
        /// <code>DeleteMountTarget</code> call returns while the mount target state is still
        /// "deleting". You can check the mount target deletion by calling the <a>DescribeMountTargets</a>
        /// API, which returns a list of mount target descriptions for the given file system.
        /// </note> 
        /// <para>
        /// The operation also requires permission for the following Amazon EC2 action on the
        /// mount target's network interface:
        /// </para>
        ///  <ul> <li> <code>ec2:DeleteNetworkInterface</code> </li> </ul>
        /// </summary>
        /// <param name="mountTargetId">String. The ID of the mount target to delete.</param>
        /// 
        /// <returns>The response from the DeleteMountTarget service method, as returned by ElasticFileSystem.</returns>
        /// <exception cref="Amazon.ElasticFileSystem.Model.BadRequestException">
        /// Returned if the request is malformed or contains an error such as an invalid parameter
        /// value or a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.DependencyTimeoutException">
        /// The service timed out trying to fulfill the request, and the client should try the
        /// call again.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.InternalServerErrorException">
        /// Returned if an error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.MountTargetNotFoundException">
        /// Returned if there is no mount target with the specified ID found in the caller's account.
        /// </exception>
        DeleteMountTargetResponse DeleteMountTarget(string mountTargetId);

        /// <summary>
        /// Deletes the specified mount target. 
        /// 
        ///  
        /// <para>
        ///  This operation forcibly breaks any mounts of the file system via the mount target
        /// being deleted, which might disrupt instances or applications using those mounts. To
        /// avoid applications getting cut off abruptly, you might consider unmounting any mounts
        /// of the mount target, if feasible. The operation also deletes the associated network
        /// interface. Uncommitted writes may be lost, but breaking a mount target using this
        /// operation does not corrupt the file system itself. The file system you created remains.
        /// You can mount an EC2 instance in your VPC using another mount target. 
        /// </para>
        ///  
        /// <para>
        ///  This operation requires permission for the following action on the file system: 
        /// </para>
        ///  <ul> <li> <code>elasticfilesystem:DeleteMountTarget</code> </li> </ul> <note>The
        /// <code>DeleteMountTarget</code> call returns while the mount target state is still
        /// "deleting". You can check the mount target deletion by calling the <a>DescribeMountTargets</a>
        /// API, which returns a list of mount target descriptions for the given file system.
        /// </note> 
        /// <para>
        /// The operation also requires permission for the following Amazon EC2 action on the
        /// mount target's network interface:
        /// </para>
        ///  <ul> <li> <code>ec2:DeleteNetworkInterface</code> </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMountTarget service method.</param>
        /// 
        /// <returns>The response from the DeleteMountTarget service method, as returned by ElasticFileSystem.</returns>
        /// <exception cref="Amazon.ElasticFileSystem.Model.BadRequestException">
        /// Returned if the request is malformed or contains an error such as an invalid parameter
        /// value or a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.DependencyTimeoutException">
        /// The service timed out trying to fulfill the request, and the client should try the
        /// call again.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.InternalServerErrorException">
        /// Returned if an error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.MountTargetNotFoundException">
        /// Returned if there is no mount target with the specified ID found in the caller's account.
        /// </exception>
        DeleteMountTargetResponse DeleteMountTarget(DeleteMountTargetRequest request);


        /// <summary>
        /// Deletes the specified mount target. 
        /// 
        ///  
        /// <para>
        ///  This operation forcibly breaks any mounts of the file system via the mount target
        /// being deleted, which might disrupt instances or applications using those mounts. To
        /// avoid applications getting cut off abruptly, you might consider unmounting any mounts
        /// of the mount target, if feasible. The operation also deletes the associated network
        /// interface. Uncommitted writes may be lost, but breaking a mount target using this
        /// operation does not corrupt the file system itself. The file system you created remains.
        /// You can mount an EC2 instance in your VPC using another mount target. 
        /// </para>
        ///  
        /// <para>
        ///  This operation requires permission for the following action on the file system: 
        /// </para>
        ///  <ul> <li> <code>elasticfilesystem:DeleteMountTarget</code> </li> </ul> <note>The
        /// <code>DeleteMountTarget</code> call returns while the mount target state is still
        /// "deleting". You can check the mount target deletion by calling the <a>DescribeMountTargets</a>
        /// API, which returns a list of mount target descriptions for the given file system.
        /// </note> 
        /// <para>
        /// The operation also requires permission for the following Amazon EC2 action on the
        /// mount target's network interface:
        /// </para>
        ///  <ul> <li> <code>ec2:DeleteNetworkInterface</code> </li> </ul>
        /// </summary>
        /// <param name="mountTargetId">String. The ID of the mount target to delete.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteMountTarget service method, as returned by ElasticFileSystem.</returns>
        /// <exception cref="Amazon.ElasticFileSystem.Model.BadRequestException">
        /// Returned if the request is malformed or contains an error such as an invalid parameter
        /// value or a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.DependencyTimeoutException">
        /// The service timed out trying to fulfill the request, and the client should try the
        /// call again.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.InternalServerErrorException">
        /// Returned if an error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.MountTargetNotFoundException">
        /// Returned if there is no mount target with the specified ID found in the caller's account.
        /// </exception>
        Task<DeleteMountTargetResponse> DeleteMountTargetAsync(string mountTargetId, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteMountTarget operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMountTarget operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteMountTargetResponse> DeleteMountTargetAsync(DeleteMountTargetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteTags


        /// <summary>
        /// Deletes the specified tags from a file system. If the <code>DeleteTags</code> request
        /// includes a tag key that does not exist, Amazon EFS ignores it; it is not an error.
        /// For more information about tags and related restrictions, go to <a href="http://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/cost-alloc-tags.html">Tag
        /// Restrictions</a> in the <i>AWS Billing and Cost Management User Guide</i>.
        /// 
        ///  
        /// <para>
        /// This operation requires permission for the <code>elasticfilesystem:DeleteTags</code>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTags service method.</param>
        /// 
        /// <returns>The response from the DeleteTags service method, as returned by ElasticFileSystem.</returns>
        /// <exception cref="Amazon.ElasticFileSystem.Model.BadRequestException">
        /// Returned if the request is malformed or contains an error such as an invalid parameter
        /// value or a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.FileSystemNotFoundException">
        /// Returned if the specified <code>FileSystemId</code> does not exist in the requester's
        /// AWS account.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.InternalServerErrorException">
        /// Returned if an error occurred on the server side.
        /// </exception>
        DeleteTagsResponse DeleteTags(DeleteTagsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteTagsResponse> DeleteTagsAsync(DeleteTagsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeFileSystems


        /// <summary>
        /// Returns the description of a specific Amazon EFS file system if either the file system
        /// <code>CreationToken</code> or the <code>FileSystemId</code> is provided; otherwise,
        /// returns descriptions of all file systems owned by the caller's AWS account in the
        /// AWS region of the endpoint that you're calling.
        /// 
        ///  
        /// <para>
        ///  When retrieving all file system descriptions, you can optionally specify the <code>MaxItems</code>
        /// parameter to limit the number of descriptions in a response. If more file system descriptions
        /// remain, Amazon EFS returns a <code>NextMarker</code>, an opaque token, in the response.
        /// In this case, you should send a subsequent request with the <code>Marker</code> request
        /// parameter set to the value of <code>NextMarker</code>. 
        /// </para>
        ///  
        /// <para>
        ///  So to retrieve a list of your file system descriptions, the expected usage of this
        /// API is an iterative process of first calling <code>DescribeFileSystems</code> without
        /// the <code>Marker</code> and then continuing to call it with the <code>Marker</code>
        /// parameter set to the value of the <code>NextMarker</code> from the previous response
        /// until the response has no <code>NextMarker</code>. 
        /// </para>
        ///  
        /// <para>
        ///  Note that the implementation may return fewer than <code>MaxItems</code> file system
        /// descriptions while still including a <code>NextMarker</code> value. 
        /// </para>
        ///  
        /// <para>
        ///  The order of file systems returned in the response of one <code>DescribeFileSystems</code>
        /// call, and the order of file systems returned across the responses of a multi-call
        /// iteration, is unspecified. 
        /// </para>
        ///  
        /// <para>
        ///  This operation requires permission for the <code>elasticfilesystem:DescribeFileSystems</code>
        /// action. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFileSystems service method.</param>
        /// 
        /// <returns>The response from the DescribeFileSystems service method, as returned by ElasticFileSystem.</returns>
        /// <exception cref="Amazon.ElasticFileSystem.Model.BadRequestException">
        /// Returned if the request is malformed or contains an error such as an invalid parameter
        /// value or a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.FileSystemNotFoundException">
        /// Returned if the specified <code>FileSystemId</code> does not exist in the requester's
        /// AWS account.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.InternalServerErrorException">
        /// Returned if an error occurred on the server side.
        /// </exception>
        DescribeFileSystemsResponse DescribeFileSystems(DescribeFileSystemsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeFileSystems operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeFileSystems operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeFileSystemsResponse> DescribeFileSystemsAsync(DescribeFileSystemsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeMountTargets


        /// <summary>
        /// Returns the descriptions of all the current mount targets, or a specific mount target,
        /// for a file system. When requesting all of the current mount targets, the order of
        /// mount targets returned in the response is unspecified.
        /// 
        ///  
        /// <para>
        /// This operation requires permission for the <code>elasticfilesystem:DescribeMountTargets</code>
        /// action, on either the file system id that you specify in <code>FileSystemId</code>,
        /// or on the file system of the mount target that you specify in <code>MountTargetId</code>.
        /// </para>
        /// </summary>
        /// <param name="fileSystemId">Optional. String. The ID of the file system whose mount targets you want to list. It must be included in your request if <code>MountTargetId</code> is not included.</param>
        /// 
        /// <returns>The response from the DescribeMountTargets service method, as returned by ElasticFileSystem.</returns>
        /// <exception cref="Amazon.ElasticFileSystem.Model.BadRequestException">
        /// Returned if the request is malformed or contains an error such as an invalid parameter
        /// value or a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.FileSystemNotFoundException">
        /// Returned if the specified <code>FileSystemId</code> does not exist in the requester's
        /// AWS account.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.InternalServerErrorException">
        /// Returned if an error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.MountTargetNotFoundException">
        /// Returned if there is no mount target with the specified ID found in the caller's account.
        /// </exception>
        DescribeMountTargetsResponse DescribeMountTargets(string fileSystemId);

        /// <summary>
        /// Returns the descriptions of all the current mount targets, or a specific mount target,
        /// for a file system. When requesting all of the current mount targets, the order of
        /// mount targets returned in the response is unspecified.
        /// 
        ///  
        /// <para>
        /// This operation requires permission for the <code>elasticfilesystem:DescribeMountTargets</code>
        /// action, on either the file system id that you specify in <code>FileSystemId</code>,
        /// or on the file system of the mount target that you specify in <code>MountTargetId</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMountTargets service method.</param>
        /// 
        /// <returns>The response from the DescribeMountTargets service method, as returned by ElasticFileSystem.</returns>
        /// <exception cref="Amazon.ElasticFileSystem.Model.BadRequestException">
        /// Returned if the request is malformed or contains an error such as an invalid parameter
        /// value or a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.FileSystemNotFoundException">
        /// Returned if the specified <code>FileSystemId</code> does not exist in the requester's
        /// AWS account.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.InternalServerErrorException">
        /// Returned if an error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.MountTargetNotFoundException">
        /// Returned if there is no mount target with the specified ID found in the caller's account.
        /// </exception>
        DescribeMountTargetsResponse DescribeMountTargets(DescribeMountTargetsRequest request);


        /// <summary>
        /// Returns the descriptions of all the current mount targets, or a specific mount target,
        /// for a file system. When requesting all of the current mount targets, the order of
        /// mount targets returned in the response is unspecified.
        /// 
        ///  
        /// <para>
        /// This operation requires permission for the <code>elasticfilesystem:DescribeMountTargets</code>
        /// action, on either the file system id that you specify in <code>FileSystemId</code>,
        /// or on the file system of the mount target that you specify in <code>MountTargetId</code>.
        /// </para>
        /// </summary>
        /// <param name="fileSystemId">Optional. String. The ID of the file system whose mount targets you want to list. It must be included in your request if <code>MountTargetId</code> is not included.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeMountTargets service method, as returned by ElasticFileSystem.</returns>
        /// <exception cref="Amazon.ElasticFileSystem.Model.BadRequestException">
        /// Returned if the request is malformed or contains an error such as an invalid parameter
        /// value or a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.FileSystemNotFoundException">
        /// Returned if the specified <code>FileSystemId</code> does not exist in the requester's
        /// AWS account.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.InternalServerErrorException">
        /// Returned if an error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.MountTargetNotFoundException">
        /// Returned if there is no mount target with the specified ID found in the caller's account.
        /// </exception>
        Task<DescribeMountTargetsResponse> DescribeMountTargetsAsync(string fileSystemId, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeMountTargets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeMountTargets operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeMountTargetsResponse> DescribeMountTargetsAsync(DescribeMountTargetsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeMountTargetSecurityGroups


        /// <summary>
        /// Returns the security groups currently in effect for a mount target. This operation
        /// requires that the network interface of the mount target has been created and the life
        /// cycle state of the mount target is not "deleted".
        /// 
        ///  
        /// <para>
        /// This operation requires permissions for the following actions:
        /// </para>
        ///  <ul> <li> <code>elasticfilesystem:DescribeMountTargetSecurityGroups</code> action
        /// on the mount target's file system. </li> <li> <code>ec2:DescribeNetworkInterfaceAttribute</code>
        /// action on the mount target's network interface. </li> </ul>
        /// </summary>
        /// <param name="mountTargetId">The ID of the mount target whose security groups you want to retrieve.</param>
        /// 
        /// <returns>The response from the DescribeMountTargetSecurityGroups service method, as returned by ElasticFileSystem.</returns>
        /// <exception cref="Amazon.ElasticFileSystem.Model.BadRequestException">
        /// Returned if the request is malformed or contains an error such as an invalid parameter
        /// value or a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.IncorrectMountTargetStateException">
        /// Returned if the mount target is not in the correct state for the operation.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.InternalServerErrorException">
        /// Returned if an error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.MountTargetNotFoundException">
        /// Returned if there is no mount target with the specified ID found in the caller's account.
        /// </exception>
        DescribeMountTargetSecurityGroupsResponse DescribeMountTargetSecurityGroups(string mountTargetId);

        /// <summary>
        /// Returns the security groups currently in effect for a mount target. This operation
        /// requires that the network interface of the mount target has been created and the life
        /// cycle state of the mount target is not "deleted".
        /// 
        ///  
        /// <para>
        /// This operation requires permissions for the following actions:
        /// </para>
        ///  <ul> <li> <code>elasticfilesystem:DescribeMountTargetSecurityGroups</code> action
        /// on the mount target's file system. </li> <li> <code>ec2:DescribeNetworkInterfaceAttribute</code>
        /// action on the mount target's network interface. </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMountTargetSecurityGroups service method.</param>
        /// 
        /// <returns>The response from the DescribeMountTargetSecurityGroups service method, as returned by ElasticFileSystem.</returns>
        /// <exception cref="Amazon.ElasticFileSystem.Model.BadRequestException">
        /// Returned if the request is malformed or contains an error such as an invalid parameter
        /// value or a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.IncorrectMountTargetStateException">
        /// Returned if the mount target is not in the correct state for the operation.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.InternalServerErrorException">
        /// Returned if an error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.MountTargetNotFoundException">
        /// Returned if there is no mount target with the specified ID found in the caller's account.
        /// </exception>
        DescribeMountTargetSecurityGroupsResponse DescribeMountTargetSecurityGroups(DescribeMountTargetSecurityGroupsRequest request);


        /// <summary>
        /// Returns the security groups currently in effect for a mount target. This operation
        /// requires that the network interface of the mount target has been created and the life
        /// cycle state of the mount target is not "deleted".
        /// 
        ///  
        /// <para>
        /// This operation requires permissions for the following actions:
        /// </para>
        ///  <ul> <li> <code>elasticfilesystem:DescribeMountTargetSecurityGroups</code> action
        /// on the mount target's file system. </li> <li> <code>ec2:DescribeNetworkInterfaceAttribute</code>
        /// action on the mount target's network interface. </li> </ul>
        /// </summary>
        /// <param name="mountTargetId">The ID of the mount target whose security groups you want to retrieve.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeMountTargetSecurityGroups service method, as returned by ElasticFileSystem.</returns>
        /// <exception cref="Amazon.ElasticFileSystem.Model.BadRequestException">
        /// Returned if the request is malformed or contains an error such as an invalid parameter
        /// value or a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.IncorrectMountTargetStateException">
        /// Returned if the mount target is not in the correct state for the operation.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.InternalServerErrorException">
        /// Returned if an error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.MountTargetNotFoundException">
        /// Returned if there is no mount target with the specified ID found in the caller's account.
        /// </exception>
        Task<DescribeMountTargetSecurityGroupsResponse> DescribeMountTargetSecurityGroupsAsync(string mountTargetId, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeMountTargetSecurityGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeMountTargetSecurityGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeMountTargetSecurityGroupsResponse> DescribeMountTargetSecurityGroupsAsync(DescribeMountTargetSecurityGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeTags


        /// <summary>
        /// Returns the tags associated with a file system. The order of tags returned in the
        /// response of one <code>DescribeTags</code> call, and the order of tags returned across
        /// the responses of a multi-call iteration (when using pagination), is unspecified. 
        /// 
        ///  
        /// <para>
        ///  This operation requires permission for the <code>elasticfilesystem:DescribeTags</code>
        /// action. 
        /// </para>
        /// </summary>
        /// <param name="fileSystemId">The ID of the file system whose tag set you want to retrieve.</param>
        /// 
        /// <returns>The response from the DescribeTags service method, as returned by ElasticFileSystem.</returns>
        /// <exception cref="Amazon.ElasticFileSystem.Model.BadRequestException">
        /// Returned if the request is malformed or contains an error such as an invalid parameter
        /// value or a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.FileSystemNotFoundException">
        /// Returned if the specified <code>FileSystemId</code> does not exist in the requester's
        /// AWS account.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.InternalServerErrorException">
        /// Returned if an error occurred on the server side.
        /// </exception>
        DescribeTagsResponse DescribeTags(string fileSystemId);

        /// <summary>
        /// Returns the tags associated with a file system. The order of tags returned in the
        /// response of one <code>DescribeTags</code> call, and the order of tags returned across
        /// the responses of a multi-call iteration (when using pagination), is unspecified. 
        /// 
        ///  
        /// <para>
        ///  This operation requires permission for the <code>elasticfilesystem:DescribeTags</code>
        /// action. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTags service method.</param>
        /// 
        /// <returns>The response from the DescribeTags service method, as returned by ElasticFileSystem.</returns>
        /// <exception cref="Amazon.ElasticFileSystem.Model.BadRequestException">
        /// Returned if the request is malformed or contains an error such as an invalid parameter
        /// value or a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.FileSystemNotFoundException">
        /// Returned if the specified <code>FileSystemId</code> does not exist in the requester's
        /// AWS account.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.InternalServerErrorException">
        /// Returned if an error occurred on the server side.
        /// </exception>
        DescribeTagsResponse DescribeTags(DescribeTagsRequest request);


        /// <summary>
        /// Returns the tags associated with a file system. The order of tags returned in the
        /// response of one <code>DescribeTags</code> call, and the order of tags returned across
        /// the responses of a multi-call iteration (when using pagination), is unspecified. 
        /// 
        ///  
        /// <para>
        ///  This operation requires permission for the <code>elasticfilesystem:DescribeTags</code>
        /// action. 
        /// </para>
        /// </summary>
        /// <param name="fileSystemId">The ID of the file system whose tag set you want to retrieve.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTags service method, as returned by ElasticFileSystem.</returns>
        /// <exception cref="Amazon.ElasticFileSystem.Model.BadRequestException">
        /// Returned if the request is malformed or contains an error such as an invalid parameter
        /// value or a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.FileSystemNotFoundException">
        /// Returned if the specified <code>FileSystemId</code> does not exist in the requester's
        /// AWS account.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.InternalServerErrorException">
        /// Returned if an error occurred on the server side.
        /// </exception>
        Task<DescribeTagsResponse> DescribeTagsAsync(string fileSystemId, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeTagsResponse> DescribeTagsAsync(DescribeTagsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ModifyMountTargetSecurityGroups


        /// <summary>
        /// Modifies the set of security groups in effect for a mount target.
        /// 
        ///  
        /// <para>
        /// When you create a mount target, Amazon EFS also creates a new network interface (see
        /// <a>CreateMountTarget</a>). This operation replaces the security groups in effect for
        /// the network interface associated with a mount target, with the <code>SecurityGroups</code>
        /// provided in the request. This operation requires that the network interface of the
        /// mount target has been created and the life cycle state of the mount target is not
        /// "deleted". 
        /// </para>
        ///  
        /// <para>
        /// The operation requires permissions for the following actions:
        /// </para>
        ///  <ul> <li> <code>elasticfilesystem:ModifyMountTargetSecurityGroups</code> action on
        /// the mount target's file system. </li> <li> <code>ec2:ModifyNetworkInterfaceAttribute</code>
        /// action on the mount target's network interface. </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyMountTargetSecurityGroups service method.</param>
        /// 
        /// <returns>The response from the ModifyMountTargetSecurityGroups service method, as returned by ElasticFileSystem.</returns>
        /// <exception cref="Amazon.ElasticFileSystem.Model.BadRequestException">
        /// Returned if the request is malformed or contains an error such as an invalid parameter
        /// value or a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.IncorrectMountTargetStateException">
        /// Returned if the mount target is not in the correct state for the operation.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.InternalServerErrorException">
        /// Returned if an error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.MountTargetNotFoundException">
        /// Returned if there is no mount target with the specified ID found in the caller's account.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.SecurityGroupLimitExceededException">
        /// Returned if the size of <code>SecurityGroups</code> specified in the request is greater
        /// than five.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.SecurityGroupNotFoundException">
        /// Returned if one of the specified security groups does not exist in the subnet's VPC.
        /// </exception>
        ModifyMountTargetSecurityGroupsResponse ModifyMountTargetSecurityGroups(ModifyMountTargetSecurityGroupsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyMountTargetSecurityGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyMountTargetSecurityGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ModifyMountTargetSecurityGroupsResponse> ModifyMountTargetSecurityGroupsAsync(ModifyMountTargetSecurityGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}