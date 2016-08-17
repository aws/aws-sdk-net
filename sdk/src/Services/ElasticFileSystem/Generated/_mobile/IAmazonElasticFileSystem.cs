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

using Amazon.Runtime;
using Amazon.ElasticFileSystem.Model;

namespace Amazon.ElasticFileSystem
{
    /// <summary>
    /// Interface for accessing ElasticFileSystem
    ///
    /// Amazon Elastic File System
    /// </summary>
    public partial interface IAmazonElasticFileSystem : IAmazonService, IDisposable
    {
                
        #region  CreateFileSystem


        /// <summary>
        /// Creates a new, empty file system. The operation requires a creation token in the request
        /// that Amazon EFS uses to ensure idempotent creation (calling the operation with same
        /// creation token has no effect). If a file system does not currently exist that is owned
        /// by the caller's AWS account with the specified creation token, this operation does
        /// the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Creates a new, empty file system. The file system will have an Amazon EFS assigned
        /// ID, and an initial lifecycle state <code>creating</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Returns with the description of the created file system.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Otherwise, this operation returns a <code>FileSystemAlreadyExists</code> error with
        /// the ID of the existing file system.
        /// </para>
        ///  <note> 
        /// <para>
        /// For basic use cases, you can use a randomly generated UUID for the creation token.
        /// </para>
        ///  </note> 
        /// <para>
        ///  The idempotent operation allows you to retry a <code>CreateFileSystem</code> call
        /// without risk of creating an extra file system. This can happen when an initial call
        /// fails in a way that leaves it uncertain whether or not a file system was actually
        /// created. An example might be that a transport level timeout occurred or your connection
        /// was reset. As long as you use the same creation token, if the initial call had succeeded
        /// in creating a file system, the client can learn of its existence from the <code>FileSystemAlreadyExists</code>
        /// error.
        /// </para>
        ///  <note> 
        /// <para>
        /// The <code>CreateFileSystem</code> call returns while the file system's lifecycle state
        /// is still <code>creating</code>. You can check the file system creation status by calling
        /// the <a>DescribeFileSystems</a> operation, which among other things returns the file
        /// system state.
        /// </para>
        ///  </note> 
        /// <para>
        /// This operation also takes an optional <code>PerformanceMode</code> parameter that
        /// you choose for your file system. We recommend <code>generalPurpose</code> performance
        /// mode for most file systems. File systems using the <code>maxIO</code> performance
        /// mode can scale to higher levels of aggregate throughput and operations per second
        /// with a tradeoff of slightly higher latencies for most file operations. The performance
        /// mode can't be changed after the file system has been created. For more information,
        /// see <a href="http://docs.aws.amazon.com/efs/latest/ug/performance.html#performancemodes.html">Amazon
        /// EFS: Performance Modes</a>.
        /// </para>
        ///  
        /// <para>
        /// After the file system is fully created, Amazon EFS sets its lifecycle state to <code>available</code>,
        /// at which point you can create one or more mount targets for the file system in your
        /// VPC. For more information, see <a>CreateMountTarget</a>. You mount your Amazon EFS
        /// file system on an EC2 instances in your VPC via the mount target. For more information,
        /// see <a href="http://docs.aws.amazon.com/efs/latest/ug/how-it-works.html">Amazon EFS:
        /// How it Works</a>. 
        /// </para>
        ///  
        /// <para>
        ///  This operation requires permissions for the <code>elasticfilesystem:CreateFileSystem</code>
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
        Task<CreateFileSystemResponse> CreateFileSystemAsync(CreateFileSystemRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateMountTarget


        /// <summary>
        /// Initiates the asynchronous execution of the CreateMountTarget operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateMountTarget operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateMountTargetResponse> CreateMountTargetAsync(CreateMountTargetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateTags


        /// <summary>
        /// Initiates the asynchronous execution of the CreateTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateTagsResponse> CreateTagsAsync(CreateTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteFileSystem


        /// <summary>
        /// Deletes a file system, permanently severing access to its contents. Upon return, the
        /// file system no longer exists and you can't access any contents of the deleted file
        /// system.
        /// 
        ///  
        /// <para>
        ///  You can't delete a file system that is in use. That is, if the file system has any
        /// mount targets, you must first delete them. For more information, see <a>DescribeMountTargets</a>
        /// and <a>DeleteMountTarget</a>. 
        /// </para>
        ///  <note> 
        /// <para>
        /// The <code>DeleteFileSystem</code> call returns while the file system state is still
        /// <code>deleting</code>. You can check the file system deletion status by calling the
        /// <a>DescribeFileSystems</a> operation, which returns a list of file systems in your
        /// account. If you pass file system ID or creation token for the deleted file system,
        /// the <a>DescribeFileSystems</a> returns a <code>404 FileSystemNotFound</code> error.
        /// </para>
        ///  </note> 
        /// <para>
        /// This operation requires permissions for the <code>elasticfilesystem:DeleteFileSystem</code>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="fileSystemId">ID of the file system you want to delete.</param>
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
        Task<DeleteFileSystemResponse> DeleteFileSystemAsync(DeleteFileSystemRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteMountTarget


        /// <summary>
        /// Deletes the specified mount target.
        /// 
        ///  
        /// <para>
        /// This operation forcibly breaks any mounts of the file system via the mount target
        /// that is being deleted, which might disrupt instances or applications using those mounts.
        /// To avoid applications getting cut off abruptly, you might consider unmounting any
        /// mounts of the mount target, if feasible. The operation also deletes the associated
        /// network interface. Uncommitted writes may be lost, but breaking a mount target using
        /// this operation does not corrupt the file system itself. The file system you created
        /// remains. You can mount an EC2 instance in your VPC via another mount target.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions for the following action on the file system:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>elasticfilesystem:DeleteMountTarget</code> 
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// The <code>DeleteMountTarget</code> call returns while the mount target state is still
        /// <code>deleting</code>. You can check the mount target deletion by calling the <a>DescribeMountTargets</a>
        /// operation, which returns a list of mount target descriptions for the given file system.
        /// 
        /// </para>
        ///  </note> 
        /// <para>
        /// The operation also requires permissions for the following Amazon EC2 action on the
        /// mount target's network interface:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>ec2:DeleteNetworkInterface</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="mountTargetId">ID of the mount target to delete (String).</param>
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
        Task<DeleteMountTargetResponse> DeleteMountTargetAsync(DeleteMountTargetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteTags


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteTagsResponse> DeleteTagsAsync(DeleteTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeFileSystems


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeFileSystems operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeFileSystems operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeFileSystemsResponse> DescribeFileSystemsAsync(DescribeFileSystemsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeMountTargets


        /// <summary>
        /// Returns the descriptions of all the current mount targets, or a specific mount target,
        /// for a file system. When requesting all of the current mount targets, the order of
        /// mount targets returned in the response is unspecified.
        /// 
        ///  
        /// <para>
        /// This operation requires permissions for the <code>elasticfilesystem:DescribeMountTargets</code>
        /// action, on either the file system ID that you specify in <code>FileSystemId</code>,
        /// or on the file system of the mount target that you specify in <code>MountTargetId</code>.
        /// </para>
        /// </summary>
        /// <param name="fileSystemId">(Optional) ID of the file system whose mount targets you want to list (String). It must be included in your request if <code>MountTargetId</code> is not included.</param>
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
        Task<DescribeMountTargetsResponse> DescribeMountTargetsAsync(DescribeMountTargetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeMountTargetSecurityGroups


        /// <summary>
        /// Returns the security groups currently in effect for a mount target. This operation
        /// requires that the network interface of the mount target has been created and the lifecycle
        /// state of the mount target is not <code>deleted</code>.
        /// 
        ///  
        /// <para>
        /// This operation requires permissions for the following actions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>elasticfilesystem:DescribeMountTargetSecurityGroups</code> action on the mount
        /// target's file system. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ec2:DescribeNetworkInterfaceAttribute</code> action on the mount target's network
        /// interface. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="mountTargetId">ID of the mount target whose security groups you want to retrieve.</param>
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
        Task<DescribeMountTargetSecurityGroupsResponse> DescribeMountTargetSecurityGroupsAsync(DescribeMountTargetSecurityGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeTags


        /// <summary>
        /// Returns the tags associated with a file system. The order of tags returned in the
        /// response of one <code>DescribeTags</code> call and the order of tags returned across
        /// the responses of a multi-call iteration (when using pagination) is unspecified. 
        /// 
        ///  
        /// <para>
        ///  This operation requires permissions for the <code>elasticfilesystem:DescribeTags</code>
        /// action. 
        /// </para>
        /// </summary>
        /// <param name="fileSystemId">ID of the file system whose tag set you want to retrieve.</param>
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
        Task<DescribeTagsResponse> DescribeTagsAsync(DescribeTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifyMountTargetSecurityGroups


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyMountTargetSecurityGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyMountTargetSecurityGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ModifyMountTargetSecurityGroupsResponse> ModifyMountTargetSecurityGroupsAsync(ModifyMountTargetSecurityGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}