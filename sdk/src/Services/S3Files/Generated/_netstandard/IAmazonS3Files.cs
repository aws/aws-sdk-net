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
 * Do not modify this file. This file is generated from the s3files-2025-05-05.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.S3Files.Model;

#pragma warning disable CS1570
namespace Amazon.S3Files
{
    /// <summary>
    /// <para>Interface for accessing S3Files</para>
    ///
    /// S3 Files makes S3 buckets accessible as high-performance file systems powered by EFS.
    /// This service enables file system interface access to S3 data with sub-millisecond
    /// latencies through mount targets, supporting AI/ML workloads, media processing, and
    /// hybrid storage workflows that require both file system and object storage access to
    /// the same data.
    /// </summary>
    public partial interface IAmazonS3Files : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IS3FilesPaginatorFactory Paginators { get; }
#endif
                
        #region  CreateAccessPoint



        /// <summary>
        /// Creates an S3 File System Access Point for application-specific access with POSIX
        /// user identity and root directory enforcement. Access points provide a way to manage
        /// access to shared datasets in multi-tenant scenarios.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAccessPoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAccessPoint service method, as returned by S3Files.</returns>
        /// <exception cref="Amazon.S3Files.Model.ConflictException">
        /// The request conflicts with the current state of the resource. This can occur when
        /// trying to create a resource that already exists or delete a resource that is in use.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource exists and that you
        /// have permission to access it.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota. Review your service quotas and either delete
        /// resources or request a quota increase.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ThrottlingException">
        /// The request was throttled. Retry your request using exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ValidationException">
        /// The input parameters are not valid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3files-2025-05-05/CreateAccessPoint">REST API Reference for CreateAccessPoint Operation</seealso>
        Task<CreateAccessPointResponse> CreateAccessPointAsync(CreateAccessPointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateFileSystem



        /// <summary>
        /// Creates an S3 File System resource scoped to a bucket or prefix within a bucket, enabling
        /// file system access to S3 data. To create a file system, you need an S3 bucket and
        /// an IAM role that grants the service permission to access the bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFileSystem service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateFileSystem service method, as returned by S3Files.</returns>
        /// <exception cref="Amazon.S3Files.Model.ConflictException">
        /// The request conflicts with the current state of the resource. This can occur when
        /// trying to create a resource that already exists or delete a resource that is in use.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource exists and that you
        /// have permission to access it.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota. Review your service quotas and either delete
        /// resources or request a quota increase.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ThrottlingException">
        /// The request was throttled. Retry your request using exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ValidationException">
        /// The input parameters are not valid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3files-2025-05-05/CreateFileSystem">REST API Reference for CreateFileSystem Operation</seealso>
        Task<CreateFileSystemResponse> CreateFileSystemAsync(CreateFileSystemRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateMountTarget



        /// <summary>
        /// Creates a mount target resource as an endpoint for mounting the S3 File System from
        /// compute resources in a specific Availability Zone and VPC. Mount targets provide network
        /// access to the file system.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMountTarget service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateMountTarget service method, as returned by S3Files.</returns>
        /// <exception cref="Amazon.S3Files.Model.ConflictException">
        /// The request conflicts with the current state of the resource. This can occur when
        /// trying to create a resource that already exists or delete a resource that is in use.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource exists and that you
        /// have permission to access it.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota. Review your service quotas and either delete
        /// resources or request a quota increase.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ThrottlingException">
        /// The request was throttled. Retry your request using exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ValidationException">
        /// The input parameters are not valid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3files-2025-05-05/CreateMountTarget">REST API Reference for CreateMountTarget Operation</seealso>
        Task<CreateMountTargetResponse> CreateMountTargetAsync(CreateMountTargetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteAccessPoint



        /// <summary>
        /// Deletes an S3 File System Access Point. This operation is irreversible.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccessPoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAccessPoint service method, as returned by S3Files.</returns>
        /// <exception cref="Amazon.S3Files.Model.ConflictException">
        /// The request conflicts with the current state of the resource. This can occur when
        /// trying to create a resource that already exists or delete a resource that is in use.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource exists and that you
        /// have permission to access it.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ThrottlingException">
        /// The request was throttled. Retry your request using exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ValidationException">
        /// The input parameters are not valid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3files-2025-05-05/DeleteAccessPoint">REST API Reference for DeleteAccessPoint Operation</seealso>
        Task<DeleteAccessPointResponse> DeleteAccessPointAsync(DeleteAccessPointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteFileSystem



        /// <summary>
        /// Deletes an S3 File System. You can optionally force deletion of a file system that
        /// has pending export data.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFileSystem service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteFileSystem service method, as returned by S3Files.</returns>
        /// <exception cref="Amazon.S3Files.Model.ConflictException">
        /// The request conflicts with the current state of the resource. This can occur when
        /// trying to create a resource that already exists or delete a resource that is in use.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource exists and that you
        /// have permission to access it.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ThrottlingException">
        /// The request was throttled. Retry your request using exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ValidationException">
        /// The input parameters are not valid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3files-2025-05-05/DeleteFileSystem">REST API Reference for DeleteFileSystem Operation</seealso>
        Task<DeleteFileSystemResponse> DeleteFileSystemAsync(DeleteFileSystemRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteFileSystemPolicy



        /// <summary>
        /// Deletes the IAM resource policy of an S3 File System.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFileSystemPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteFileSystemPolicy service method, as returned by S3Files.</returns>
        /// <exception cref="Amazon.S3Files.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource exists and that you
        /// have permission to access it.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ThrottlingException">
        /// The request was throttled. Retry your request using exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ValidationException">
        /// The input parameters are not valid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3files-2025-05-05/DeleteFileSystemPolicy">REST API Reference for DeleteFileSystemPolicy Operation</seealso>
        Task<DeleteFileSystemPolicyResponse> DeleteFileSystemPolicyAsync(DeleteFileSystemPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteMountTarget



        /// <summary>
        /// Deletes the specified mount target. This operation is irreversible.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMountTarget service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteMountTarget service method, as returned by S3Files.</returns>
        /// <exception cref="Amazon.S3Files.Model.ConflictException">
        /// The request conflicts with the current state of the resource. This can occur when
        /// trying to create a resource that already exists or delete a resource that is in use.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource exists and that you
        /// have permission to access it.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ThrottlingException">
        /// The request was throttled. Retry your request using exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ValidationException">
        /// The input parameters are not valid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3files-2025-05-05/DeleteMountTarget">REST API Reference for DeleteMountTarget Operation</seealso>
        Task<DeleteMountTargetResponse> DeleteMountTargetAsync(DeleteMountTargetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetAccessPoint



        /// <summary>
        /// Returns resource information for an S3 File System Access Point.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccessPoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAccessPoint service method, as returned by S3Files.</returns>
        /// <exception cref="Amazon.S3Files.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource exists and that you
        /// have permission to access it.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ThrottlingException">
        /// The request was throttled. Retry your request using exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ValidationException">
        /// The input parameters are not valid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3files-2025-05-05/GetAccessPoint">REST API Reference for GetAccessPoint Operation</seealso>
        Task<GetAccessPointResponse> GetAccessPointAsync(GetAccessPointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetFileSystem



        /// <summary>
        /// Returns resource information for the specified S3 File System including status, configuration,
        /// and metadata.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFileSystem service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetFileSystem service method, as returned by S3Files.</returns>
        /// <exception cref="Amazon.S3Files.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource exists and that you
        /// have permission to access it.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ThrottlingException">
        /// The request was throttled. Retry your request using exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ValidationException">
        /// The input parameters are not valid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3files-2025-05-05/GetFileSystem">REST API Reference for GetFileSystem Operation</seealso>
        Task<GetFileSystemResponse> GetFileSystemAsync(GetFileSystemRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetFileSystemPolicy



        /// <summary>
        /// Returns the IAM resource policy of an S3 File System.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFileSystemPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetFileSystemPolicy service method, as returned by S3Files.</returns>
        /// <exception cref="Amazon.S3Files.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource exists and that you
        /// have permission to access it.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ThrottlingException">
        /// The request was throttled. Retry your request using exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ValidationException">
        /// The input parameters are not valid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3files-2025-05-05/GetFileSystemPolicy">REST API Reference for GetFileSystemPolicy Operation</seealso>
        Task<GetFileSystemPolicyResponse> GetFileSystemPolicyAsync(GetFileSystemPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetMountTarget



        /// <summary>
        /// Returns detailed resource information for the specified mount target including network
        /// configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMountTarget service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMountTarget service method, as returned by S3Files.</returns>
        /// <exception cref="Amazon.S3Files.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource exists and that you
        /// have permission to access it.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ThrottlingException">
        /// The request was throttled. Retry your request using exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ValidationException">
        /// The input parameters are not valid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3files-2025-05-05/GetMountTarget">REST API Reference for GetMountTarget Operation</seealso>
        Task<GetMountTargetResponse> GetMountTargetAsync(GetMountTargetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetSynchronizationConfiguration



        /// <summary>
        /// Returns the synchronization configuration for the specified S3 File System, including
        /// import data rules and expiration data rules.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSynchronizationConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSynchronizationConfiguration service method, as returned by S3Files.</returns>
        /// <exception cref="Amazon.S3Files.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource exists and that you
        /// have permission to access it.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ThrottlingException">
        /// The request was throttled. Retry your request using exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ValidationException">
        /// The input parameters are not valid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3files-2025-05-05/GetSynchronizationConfiguration">REST API Reference for GetSynchronizationConfiguration Operation</seealso>
        Task<GetSynchronizationConfigurationResponse> GetSynchronizationConfigurationAsync(GetSynchronizationConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListAccessPoints



        /// <summary>
        /// Returns resource information for all S3 File System Access Points associated with
        /// the specified S3 File System.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccessPoints service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAccessPoints service method, as returned by S3Files.</returns>
        /// <exception cref="Amazon.S3Files.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource exists and that you
        /// have permission to access it.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ThrottlingException">
        /// The request was throttled. Retry your request using exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ValidationException">
        /// The input parameters are not valid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3files-2025-05-05/ListAccessPoints">REST API Reference for ListAccessPoints Operation</seealso>
        Task<ListAccessPointsResponse> ListAccessPointsAsync(ListAccessPointsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListFileSystems



        /// <summary>
        /// Returns a list of all S3 File Systems owned by the account with optional filtering
        /// by bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFileSystems service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFileSystems service method, as returned by S3Files.</returns>
        /// <exception cref="Amazon.S3Files.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ThrottlingException">
        /// The request was throttled. Retry your request using exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ValidationException">
        /// The input parameters are not valid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3files-2025-05-05/ListFileSystems">REST API Reference for ListFileSystems Operation</seealso>
        Task<ListFileSystemsResponse> ListFileSystemsAsync(ListFileSystemsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListMountTargets



        /// <summary>
        /// Returns resource information for all mount targets with optional filtering by file
        /// system, access point, and VPC.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMountTargets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMountTargets service method, as returned by S3Files.</returns>
        /// <exception cref="Amazon.S3Files.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource exists and that you
        /// have permission to access it.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ThrottlingException">
        /// The request was throttled. Retry your request using exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ValidationException">
        /// The input parameters are not valid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3files-2025-05-05/ListMountTargets">REST API Reference for ListMountTargets Operation</seealso>
        Task<ListMountTargetsResponse> ListMountTargetsAsync(ListMountTargetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource



        /// <summary>
        /// Lists all tags for S3 Files resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by S3Files.</returns>
        /// <exception cref="Amazon.S3Files.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource exists and that you
        /// have permission to access it.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ThrottlingException">
        /// The request was throttled. Retry your request using exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ValidationException">
        /// The input parameters are not valid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3files-2025-05-05/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutFileSystemPolicy



        /// <summary>
        /// Creates or replaces the IAM resource policy for an S3 File System to control access
        /// permissions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutFileSystemPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutFileSystemPolicy service method, as returned by S3Files.</returns>
        /// <exception cref="Amazon.S3Files.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource exists and that you
        /// have permission to access it.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ThrottlingException">
        /// The request was throttled. Retry your request using exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ValidationException">
        /// The input parameters are not valid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3files-2025-05-05/PutFileSystemPolicy">REST API Reference for PutFileSystemPolicy Operation</seealso>
        Task<PutFileSystemPolicyResponse> PutFileSystemPolicyAsync(PutFileSystemPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutSynchronizationConfiguration



        /// <summary>
        /// Creates or updates the synchronization configuration for the specified S3 File System,
        /// including import data rules and expiration data rules.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutSynchronizationConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutSynchronizationConfiguration service method, as returned by S3Files.</returns>
        /// <exception cref="Amazon.S3Files.Model.ConflictException">
        /// The request conflicts with the current state of the resource. This can occur when
        /// trying to create a resource that already exists or delete a resource that is in use.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource exists and that you
        /// have permission to access it.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ThrottlingException">
        /// The request was throttled. Retry your request using exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ValidationException">
        /// The input parameters are not valid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3files-2025-05-05/PutSynchronizationConfiguration">REST API Reference for PutSynchronizationConfiguration Operation</seealso>
        Task<PutSynchronizationConfigurationResponse> PutSynchronizationConfigurationAsync(PutSynchronizationConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource



        /// <summary>
        /// Creates tags for S3 Files resources using standard Amazon Web Services tagging APIs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by S3Files.</returns>
        /// <exception cref="Amazon.S3Files.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource exists and that you
        /// have permission to access it.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ThrottlingException">
        /// The request was throttled. Retry your request using exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ValidationException">
        /// The input parameters are not valid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3files-2025-05-05/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource



        /// <summary>
        /// Removes tags from S3 Files resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by S3Files.</returns>
        /// <exception cref="Amazon.S3Files.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource exists and that you
        /// have permission to access it.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ThrottlingException">
        /// The request was throttled. Retry your request using exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ValidationException">
        /// The input parameters are not valid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3files-2025-05-05/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateMountTarget



        /// <summary>
        /// Updates the mount target resource, specifically security group configurations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMountTarget service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateMountTarget service method, as returned by S3Files.</returns>
        /// <exception cref="Amazon.S3Files.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource exists and that you
        /// have permission to access it.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ThrottlingException">
        /// The request was throttled. Retry your request using exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ValidationException">
        /// The input parameters are not valid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3files-2025-05-05/UpdateMountTarget">REST API Reference for UpdateMountTarget Operation</seealso>
        Task<UpdateMountTargetResponse> UpdateMountTargetAsync(UpdateMountTargetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);
        
        #endregion

        #region Static factory interface methods
#if NET8_0_OR_GREATER
// Warning CA1033 is issued when the child types can not call the method defined in parent types.
// In this use case the intended caller is only meant to be the interface as a factory
// method to create the child types. Given the SDK use case the warning can be ignored.
#pragma warning disable CA1033
        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonS3FilesConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonS3FilesConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
    Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonS3FilesConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonS3FilesConfig to create AmazonS3FilesClient");
            }

            return awsCredentials == null ? 
                    new AmazonS3FilesClient(serviceClientConfig) :
                    new AmazonS3FilesClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
        #endregion
    }
}