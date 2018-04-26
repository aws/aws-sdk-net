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
 * Do not modify this file. This file is generated from the glacier-2012-06-01.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Glacier.Model;

namespace Amazon.Glacier
{
    /// <summary>
    /// Interface for accessing Glacier
    ///
    /// Amazon Glacier is a storage solution for "cold data."
    /// 
    ///  
    /// <para>
    /// Amazon Glacier is an extremely low-cost storage service that provides secure, durable,
    /// and easy-to-use storage for data backup and archival. With Amazon Glacier, customers
    /// can store their data cost effectively for months, years, or decades. Amazon Glacier
    /// also enables customers to offload the administrative burdens of operating and scaling
    /// storage to AWS, so they don't have to worry about capacity planning, hardware provisioning,
    /// data replication, hardware failure and recovery, or time-consuming hardware migrations.
    /// </para>
    ///  
    /// <para>
    /// Amazon Glacier is a great storage choice when low storage cost is paramount, your
    /// data is rarely retrieved, and retrieval latency of several hours is acceptable. If
    /// your application requires fast or frequent access to your data, consider using Amazon
    /// S3. For more information, see <a href="http://aws.amazon.com/s3/">Amazon Simple Storage
    /// Service (Amazon S3)</a>.
    /// </para>
    ///  
    /// <para>
    /// You can store any kind of data in any format. There is no maximum limit on the total
    /// amount of data you can store in Amazon Glacier.
    /// </para>
    ///  
    /// <para>
    /// If you are a first-time user of Amazon Glacier, we recommend that you begin by reading
    /// the following sections in the <i>Amazon Glacier Developer Guide</i>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/introduction.html">What
    /// is Amazon Glacier</a> - This section of the Developer Guide describes the underlying
    /// data model, the operations it supports, and the AWS SDKs that you can use to interact
    /// with the service.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/amazon-glacier-getting-started.html">Getting
    /// Started with Amazon Glacier</a> - The Getting Started section walks you through the
    /// process of creating a vault, uploading archives, creating jobs to download archives,
    /// retrieving the job output, and deleting archives.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial interface IAmazonGlacier : IAmazonService, IDisposable
    {

        
        #region  AbortMultipartUpload


        /// <summary>
        /// This operation aborts a multipart upload identified by the upload ID.
        /// 
        ///  
        /// <para>
        /// After the Abort Multipart Upload request succeeds, you cannot upload any more parts
        /// to the multipart upload or complete the multipart upload. Aborting a completed upload
        /// fails. However, aborting an already-aborted upload will succeed, for a short time.
        /// For more information about uploading a part and completing a multipart upload, see
        /// <a>UploadMultipartPart</a> and <a>CompleteMultipartUpload</a>.
        /// </para>
        ///  
        /// <para>
        /// This operation is idempotent.
        /// </para>
        ///  
        /// <para>
        /// An AWS account has full permission to perform all operations (actions). However, AWS
        /// Identity and Access Management (IAM) users don't have any permissions by default.
        /// You must grant them explicit permission to perform specific actions. For more information,
        /// see <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/using-iam-with-amazon-glacier.html">Access
        /// Control Using AWS Identity and Access Management (IAM)</a>.
        /// </para>
        ///  
        /// <para>
        ///  For conceptual information and underlying REST API, see <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/working-with-archives.html">Working
        /// with Archives in Amazon Glacier</a> and <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/api-multipart-abort-upload.html">Abort
        /// Multipart Upload</a> in the <i>Amazon Glacier Developer Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AbortMultipartUpload service method.</param>
        /// 
        /// <returns>The response from the AbortMultipartUpload service method, as returned by Glacier.</returns>
        /// <exception cref="Amazon.Glacier.Model.InvalidParameterValueException">
        /// Returned if a parameter of the request is incorrectly specified.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.MissingParameterValueException">
        /// Returned if a required header or parameter is missing from the request.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.ResourceNotFoundException">
        /// Returned if the specified resource (such as a vault, upload ID, or job ID) doesn't
        /// exist.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.ServiceUnavailableException">
        /// Returned if the service cannot complete the request.
        /// </exception>
        AbortMultipartUploadResponse AbortMultipartUpload(AbortMultipartUploadRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the AbortMultipartUpload operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AbortMultipartUpload operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<AbortMultipartUploadResponse> AbortMultipartUploadAsync(AbortMultipartUploadRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AbortVaultLock


        /// <summary>
        /// This operation aborts the vault locking process if the vault lock is not in the <code>Locked</code>
        /// state. If the vault lock is in the <code>Locked</code> state when this operation is
        /// requested, the operation returns an <code>AccessDeniedException</code> error. Aborting
        /// the vault locking process removes the vault lock policy from the specified vault.
        /// 
        /// 
        ///  
        /// <para>
        /// A vault lock is put into the <code>InProgress</code> state by calling <a>InitiateVaultLock</a>.
        /// A vault lock is put into the <code>Locked</code> state by calling <a>CompleteVaultLock</a>.
        /// You can get the state of a vault lock by calling <a>GetVaultLock</a>. For more information
        /// about the vault locking process, see <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/vault-lock.html">Amazon
        /// Glacier Vault Lock</a>. For more information about vault lock policies, see <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/vault-lock-policy.html">Amazon
        /// Glacier Access Control with Vault Lock Policies</a>. 
        /// </para>
        ///  
        /// <para>
        /// This operation is idempotent. You can successfully invoke this operation multiple
        /// times, if the vault lock is in the <code>InProgress</code> state or if there is no
        /// policy associated with the vault.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AbortVaultLock service method.</param>
        /// 
        /// <returns>The response from the AbortVaultLock service method, as returned by Glacier.</returns>
        /// <exception cref="Amazon.Glacier.Model.InvalidParameterValueException">
        /// Returned if a parameter of the request is incorrectly specified.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.MissingParameterValueException">
        /// Returned if a required header or parameter is missing from the request.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.ResourceNotFoundException">
        /// Returned if the specified resource (such as a vault, upload ID, or job ID) doesn't
        /// exist.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.ServiceUnavailableException">
        /// Returned if the service cannot complete the request.
        /// </exception>
        AbortVaultLockResponse AbortVaultLock(AbortVaultLockRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the AbortVaultLock operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AbortVaultLock operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<AbortVaultLockResponse> AbortVaultLockAsync(AbortVaultLockRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AddTagsToVault


        /// <summary>
        /// This operation adds the specified tags to a vault. Each tag is composed of a key and
        /// a value. Each vault can have up to 10 tags. If your request would cause the tag limit
        /// for the vault to be exceeded, the operation throws the <code>LimitExceededException</code>
        /// error. If a tag already exists on the vault under a specified key, the existing key
        /// value will be overwritten. For more information about tags, see <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/tagging.html">Tagging
        /// Amazon Glacier Resources</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddTagsToVault service method.</param>
        /// 
        /// <returns>The response from the AddTagsToVault service method, as returned by Glacier.</returns>
        /// <exception cref="Amazon.Glacier.Model.InvalidParameterValueException">
        /// Returned if a parameter of the request is incorrectly specified.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.LimitExceededException">
        /// Returned if the request results in a vault or account limit being exceeded.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.MissingParameterValueException">
        /// Returned if a required header or parameter is missing from the request.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.ResourceNotFoundException">
        /// Returned if the specified resource (such as a vault, upload ID, or job ID) doesn't
        /// exist.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.ServiceUnavailableException">
        /// Returned if the service cannot complete the request.
        /// </exception>
        AddTagsToVaultResponse AddTagsToVault(AddTagsToVaultRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the AddTagsToVault operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddTagsToVault operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<AddTagsToVaultResponse> AddTagsToVaultAsync(AddTagsToVaultRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CompleteMultipartUpload


        /// <summary>
        /// You call this operation to inform Amazon Glacier that all the archive parts have been
        /// uploaded and that Amazon Glacier can now assemble the archive from the uploaded parts.
        /// After assembling and saving the archive to the vault, Amazon Glacier returns the URI
        /// path of the newly created archive resource. Using the URI path, you can then access
        /// the archive. After you upload an archive, you should save the archive ID returned
        /// to retrieve the archive at a later point. You can also get the vault inventory to
        /// obtain a list of archive IDs in a vault. For more information, see <a>InitiateJob</a>.
        /// 
        ///  
        /// <para>
        /// In the request, you must include the computed SHA256 tree hash of the entire archive
        /// you have uploaded. For information about computing a SHA256 tree hash, see <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/checksum-calculations.html">Computing
        /// Checksums</a>. On the server side, Amazon Glacier also constructs the SHA256 tree
        /// hash of the assembled archive. If the values match, Amazon Glacier saves the archive
        /// to the vault; otherwise, it returns an error, and the operation fails. The <a>ListParts</a>
        /// operation returns a list of parts uploaded for a specific multipart upload. It includes
        /// checksum information for each uploaded part that can be used to debug a bad checksum
        /// issue.
        /// </para>
        ///  
        /// <para>
        /// Additionally, Amazon Glacier also checks for any missing content ranges when assembling
        /// the archive, if missing content ranges are found, Amazon Glacier returns an error
        /// and the operation fails.
        /// </para>
        ///  
        /// <para>
        /// Complete Multipart Upload is an idempotent operation. After your first successful
        /// complete multipart upload, if you call the operation again within a short period,
        /// the operation will succeed and return the same archive ID. This is useful in the event
        /// you experience a network issue that causes an aborted connection or receive a 500
        /// server error, in which case you can repeat your Complete Multipart Upload request
        /// and get the same archive ID without creating duplicate archives. Note, however, that
        /// after the multipart upload completes, you cannot call the List Parts operation and
        /// the multipart upload will not appear in List Multipart Uploads response, even if idempotent
        /// complete is possible.
        /// </para>
        ///  
        /// <para>
        /// An AWS account has full permission to perform all operations (actions). However, AWS
        /// Identity and Access Management (IAM) users don't have any permissions by default.
        /// You must grant them explicit permission to perform specific actions. For more information,
        /// see <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/using-iam-with-amazon-glacier.html">Access
        /// Control Using AWS Identity and Access Management (IAM)</a>.
        /// </para>
        ///  
        /// <para>
        ///  For conceptual information and underlying REST API, see <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/uploading-archive-mpu.html">Uploading
        /// Large Archives in Parts (Multipart Upload)</a> and <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/api-multipart-complete-upload.html">Complete
        /// Multipart Upload</a> in the <i>Amazon Glacier Developer Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CompleteMultipartUpload service method.</param>
        /// 
        /// <returns>The response from the CompleteMultipartUpload service method, as returned by Glacier.</returns>
        /// <exception cref="Amazon.Glacier.Model.InvalidParameterValueException">
        /// Returned if a parameter of the request is incorrectly specified.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.MissingParameterValueException">
        /// Returned if a required header or parameter is missing from the request.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.ResourceNotFoundException">
        /// Returned if the specified resource (such as a vault, upload ID, or job ID) doesn't
        /// exist.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.ServiceUnavailableException">
        /// Returned if the service cannot complete the request.
        /// </exception>
        CompleteMultipartUploadResponse CompleteMultipartUpload(CompleteMultipartUploadRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CompleteMultipartUpload operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CompleteMultipartUpload operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CompleteMultipartUploadResponse> CompleteMultipartUploadAsync(CompleteMultipartUploadRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CompleteVaultLock


        /// <summary>
        /// This operation completes the vault locking process by transitioning the vault lock
        /// from the <code>InProgress</code> state to the <code>Locked</code> state, which causes
        /// the vault lock policy to become unchangeable. A vault lock is put into the <code>InProgress</code>
        /// state by calling <a>InitiateVaultLock</a>. You can obtain the state of the vault lock
        /// by calling <a>GetVaultLock</a>. For more information about the vault locking process,
        /// <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/vault-lock.html">Amazon
        /// Glacier Vault Lock</a>. 
        /// 
        ///  
        /// <para>
        /// This operation is idempotent. This request is always successful if the vault lock
        /// is in the <code>Locked</code> state and the provided lock ID matches the lock ID originally
        /// used to lock the vault.
        /// </para>
        ///  
        /// <para>
        /// If an invalid lock ID is passed in the request when the vault lock is in the <code>Locked</code>
        /// state, the operation returns an <code>AccessDeniedException</code> error. If an invalid
        /// lock ID is passed in the request when the vault lock is in the <code>InProgress</code>
        /// state, the operation throws an <code>InvalidParameter</code> error.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CompleteVaultLock service method.</param>
        /// 
        /// <returns>The response from the CompleteVaultLock service method, as returned by Glacier.</returns>
        /// <exception cref="Amazon.Glacier.Model.InvalidParameterValueException">
        /// Returned if a parameter of the request is incorrectly specified.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.MissingParameterValueException">
        /// Returned if a required header or parameter is missing from the request.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.ResourceNotFoundException">
        /// Returned if the specified resource (such as a vault, upload ID, or job ID) doesn't
        /// exist.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.ServiceUnavailableException">
        /// Returned if the service cannot complete the request.
        /// </exception>
        CompleteVaultLockResponse CompleteVaultLock(CompleteVaultLockRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CompleteVaultLock operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CompleteVaultLock operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CompleteVaultLockResponse> CompleteVaultLockAsync(CompleteVaultLockRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateVault


        /// <summary>
        /// This operation creates a new vault with the specified name. The name of the vault
        /// must be unique within a region for an AWS account. You can create up to 1,000 vaults
        /// per account. If you need to create more vaults, contact Amazon Glacier.
        /// 
        ///  
        /// <para>
        /// You must use the following guidelines when naming a vault.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Names can be between 1 and 255 characters long.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Allowed characters are a-z, A-Z, 0-9, '_' (underscore), '-' (hyphen), and '.' (period).
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// This operation is idempotent.
        /// </para>
        ///  
        /// <para>
        /// An AWS account has full permission to perform all operations (actions). However, AWS
        /// Identity and Access Management (IAM) users don't have any permissions by default.
        /// You must grant them explicit permission to perform specific actions. For more information,
        /// see <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/using-iam-with-amazon-glacier.html">Access
        /// Control Using AWS Identity and Access Management (IAM)</a>.
        /// </para>
        ///  
        /// <para>
        ///  For conceptual information and underlying REST API, see <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/creating-vaults.html">Creating
        /// a Vault in Amazon Glacier</a> and <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/api-vault-put.html">Create
        /// Vault </a> in the <i>Amazon Glacier Developer Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVault service method.</param>
        /// 
        /// <returns>The response from the CreateVault service method, as returned by Glacier.</returns>
        /// <exception cref="Amazon.Glacier.Model.InvalidParameterValueException">
        /// Returned if a parameter of the request is incorrectly specified.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.LimitExceededException">
        /// Returned if the request results in a vault or account limit being exceeded.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.MissingParameterValueException">
        /// Returned if a required header or parameter is missing from the request.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.ServiceUnavailableException">
        /// Returned if the service cannot complete the request.
        /// </exception>
        CreateVaultResponse CreateVault(CreateVaultRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateVault operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVault operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateVaultResponse> CreateVaultAsync(CreateVaultRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteArchive


        /// <summary>
        /// This operation deletes an archive from a vault. Subsequent requests to initiate a
        /// retrieval of this archive will fail. Archive retrievals that are in progress for this
        /// archive ID may or may not succeed according to the following scenarios:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// If the archive retrieval job is actively preparing the data for download when Amazon
        /// Glacier receives the delete archive request, the archival retrieval operation might
        /// fail.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the archive retrieval job has successfully prepared the archive for download when
        /// Amazon Glacier receives the delete archive request, you will be able to download the
        /// output.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// This operation is idempotent. Attempting to delete an already-deleted archive does
        /// not result in an error.
        /// </para>
        ///  
        /// <para>
        /// An AWS account has full permission to perform all operations (actions). However, AWS
        /// Identity and Access Management (IAM) users don't have any permissions by default.
        /// You must grant them explicit permission to perform specific actions. For more information,
        /// see <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/using-iam-with-amazon-glacier.html">Access
        /// Control Using AWS Identity and Access Management (IAM)</a>.
        /// </para>
        ///  
        /// <para>
        ///  For conceptual information and underlying REST API, see <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/deleting-an-archive.html">Deleting
        /// an Archive in Amazon Glacier</a> and <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/api-archive-delete.html">Delete
        /// Archive</a> in the <i>Amazon Glacier Developer Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteArchive service method.</param>
        /// 
        /// <returns>The response from the DeleteArchive service method, as returned by Glacier.</returns>
        /// <exception cref="Amazon.Glacier.Model.InvalidParameterValueException">
        /// Returned if a parameter of the request is incorrectly specified.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.MissingParameterValueException">
        /// Returned if a required header or parameter is missing from the request.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.ResourceNotFoundException">
        /// Returned if the specified resource (such as a vault, upload ID, or job ID) doesn't
        /// exist.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.ServiceUnavailableException">
        /// Returned if the service cannot complete the request.
        /// </exception>
        DeleteArchiveResponse DeleteArchive(DeleteArchiveRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteArchive operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteArchive operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteArchiveResponse> DeleteArchiveAsync(DeleteArchiveRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteVault


        /// <summary>
        /// This operation deletes a vault. Amazon Glacier will delete a vault only if there are
        /// no archives in the vault as of the last inventory and there have been no writes to
        /// the vault since the last inventory. If either of these conditions is not satisfied,
        /// the vault deletion fails (that is, the vault is not removed) and Amazon Glacier returns
        /// an error. You can use <a>DescribeVault</a> to return the number of archives in a vault,
        /// and you can use <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/api-initiate-job-post.html">Initiate
        /// a Job (POST jobs)</a> to initiate a new inventory retrieval for a vault. The inventory
        /// contains the archive IDs you use to delete archives using <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/api-archive-delete.html">Delete
        /// Archive (DELETE archive)</a>.
        /// 
        ///  
        /// <para>
        /// This operation is idempotent.
        /// </para>
        ///  
        /// <para>
        /// An AWS account has full permission to perform all operations (actions). However, AWS
        /// Identity and Access Management (IAM) users don't have any permissions by default.
        /// You must grant them explicit permission to perform specific actions. For more information,
        /// see <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/using-iam-with-amazon-glacier.html">Access
        /// Control Using AWS Identity and Access Management (IAM)</a>.
        /// </para>
        ///  
        /// <para>
        ///  For conceptual information and underlying REST API, see <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/deleting-vaults.html">Deleting
        /// a Vault in Amazon Glacier</a> and <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/api-vault-delete.html">Delete
        /// Vault </a> in the <i>Amazon Glacier Developer Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVault service method.</param>
        /// 
        /// <returns>The response from the DeleteVault service method, as returned by Glacier.</returns>
        /// <exception cref="Amazon.Glacier.Model.InvalidParameterValueException">
        /// Returned if a parameter of the request is incorrectly specified.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.MissingParameterValueException">
        /// Returned if a required header or parameter is missing from the request.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.ResourceNotFoundException">
        /// Returned if the specified resource (such as a vault, upload ID, or job ID) doesn't
        /// exist.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.ServiceUnavailableException">
        /// Returned if the service cannot complete the request.
        /// </exception>
        DeleteVaultResponse DeleteVault(DeleteVaultRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVault operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVault operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteVaultResponse> DeleteVaultAsync(DeleteVaultRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteVaultAccessPolicy


        /// <summary>
        /// This operation deletes the access policy associated with the specified vault. The
        /// operation is eventually consistent; that is, it might take some time for Amazon Glacier
        /// to completely remove the access policy, and you might still see the effect of the
        /// policy for a short time after you send the delete request.
        /// 
        ///  
        /// <para>
        /// This operation is idempotent. You can invoke delete multiple times, even if there
        /// is no policy associated with the vault. For more information about vault access policies,
        /// see <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/vault-access-policy.html">Amazon
        /// Glacier Access Control with Vault Access Policies</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVaultAccessPolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteVaultAccessPolicy service method, as returned by Glacier.</returns>
        /// <exception cref="Amazon.Glacier.Model.InvalidParameterValueException">
        /// Returned if a parameter of the request is incorrectly specified.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.MissingParameterValueException">
        /// Returned if a required header or parameter is missing from the request.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.ResourceNotFoundException">
        /// Returned if the specified resource (such as a vault, upload ID, or job ID) doesn't
        /// exist.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.ServiceUnavailableException">
        /// Returned if the service cannot complete the request.
        /// </exception>
        DeleteVaultAccessPolicyResponse DeleteVaultAccessPolicy(DeleteVaultAccessPolicyRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVaultAccessPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVaultAccessPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteVaultAccessPolicyResponse> DeleteVaultAccessPolicyAsync(DeleteVaultAccessPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteVaultNotifications


        /// <summary>
        /// This operation deletes the notification configuration set for a vault. The operation
        /// is eventually consistent; that is, it might take some time for Amazon Glacier to completely
        /// disable the notifications and you might still receive some notifications for a short
        /// time after you send the delete request.
        /// 
        ///  
        /// <para>
        /// An AWS account has full permission to perform all operations (actions). However, AWS
        /// Identity and Access Management (IAM) users don't have any permissions by default.
        /// You must grant them explicit permission to perform specific actions. For more information,
        /// see <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/using-iam-with-amazon-glacier.html">Access
        /// Control Using AWS Identity and Access Management (IAM)</a>.
        /// </para>
        ///  
        /// <para>
        ///  For conceptual information and underlying REST API, see <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/configuring-notifications.html">Configuring
        /// Vault Notifications in Amazon Glacier</a> and <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/api-vault-notifications-delete.html">Delete
        /// Vault Notification Configuration </a> in the Amazon Glacier Developer Guide. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVaultNotifications service method.</param>
        /// 
        /// <returns>The response from the DeleteVaultNotifications service method, as returned by Glacier.</returns>
        /// <exception cref="Amazon.Glacier.Model.InvalidParameterValueException">
        /// Returned if a parameter of the request is incorrectly specified.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.MissingParameterValueException">
        /// Returned if a required header or parameter is missing from the request.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.ResourceNotFoundException">
        /// Returned if the specified resource (such as a vault, upload ID, or job ID) doesn't
        /// exist.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.ServiceUnavailableException">
        /// Returned if the service cannot complete the request.
        /// </exception>
        DeleteVaultNotificationsResponse DeleteVaultNotifications(DeleteVaultNotificationsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVaultNotifications operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVaultNotifications operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteVaultNotificationsResponse> DeleteVaultNotificationsAsync(DeleteVaultNotificationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeJob


        /// <summary>
        /// This operation returns information about a job you previously initiated, including
        /// the job initiation date, the user who initiated the job, the job status code/message
        /// and the Amazon SNS topic to notify after Amazon Glacier completes the job. For more
        /// information about initiating a job, see <a>InitiateJob</a>. 
        /// 
        ///  <note> 
        /// <para>
        /// This operation enables you to check the status of your job. However, it is strongly
        /// recommended that you set up an Amazon SNS topic and specify it in your initiate job
        /// request so that Amazon Glacier can notify the topic after it completes the job.
        /// </para>
        ///  </note> 
        /// <para>
        /// A job ID will not expire for at least 24 hours after Amazon Glacier completes the
        /// job.
        /// </para>
        ///  
        /// <para>
        /// An AWS account has full permission to perform all operations (actions). However, AWS
        /// Identity and Access Management (IAM) users don't have any permissions by default.
        /// You must grant them explicit permission to perform specific actions. For more information,
        /// see <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/using-iam-with-amazon-glacier.html">Access
        /// Control Using AWS Identity and Access Management (IAM)</a>.
        /// </para>
        ///  
        /// <para>
        ///  For more information about using this operation, see the documentation for the underlying
        /// REST API <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/api-describe-job-get.html">Describe
        /// Job</a> in the <i>Amazon Glacier Developer Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeJob service method.</param>
        /// 
        /// <returns>The response from the DescribeJob service method, as returned by Glacier.</returns>
        /// <exception cref="Amazon.Glacier.Model.InvalidParameterValueException">
        /// Returned if a parameter of the request is incorrectly specified.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.MissingParameterValueException">
        /// Returned if a required header or parameter is missing from the request.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.ResourceNotFoundException">
        /// Returned if the specified resource (such as a vault, upload ID, or job ID) doesn't
        /// exist.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.ServiceUnavailableException">
        /// Returned if the service cannot complete the request.
        /// </exception>
        DescribeJobResponse DescribeJob(DescribeJobRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeJobResponse> DescribeJobAsync(DescribeJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeVault


        /// <summary>
        /// This operation returns information about a vault, including the vault's Amazon Resource
        /// Name (ARN), the date the vault was created, the number of archives it contains, and
        /// the total size of all the archives in the vault. The number of archives and their
        /// total size are as of the last inventory generation. This means that if you add or
        /// remove an archive from a vault, and then immediately use Describe Vault, the change
        /// in contents will not be immediately reflected. If you want to retrieve the latest
        /// inventory of the vault, use <a>InitiateJob</a>. Amazon Glacier generates vault inventories
        /// approximately daily. For more information, see <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/vault-inventory.html">Downloading
        /// a Vault Inventory in Amazon Glacier</a>. 
        /// 
        ///  
        /// <para>
        /// An AWS account has full permission to perform all operations (actions). However, AWS
        /// Identity and Access Management (IAM) users don't have any permissions by default.
        /// You must grant them explicit permission to perform specific actions. For more information,
        /// see <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/using-iam-with-amazon-glacier.html">Access
        /// Control Using AWS Identity and Access Management (IAM)</a>.
        /// </para>
        ///  
        /// <para>
        /// For conceptual information and underlying REST API, see <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/retrieving-vault-info.html">Retrieving
        /// Vault Metadata in Amazon Glacier</a> and <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/api-vault-get.html">Describe
        /// Vault </a> in the <i>Amazon Glacier Developer Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVault service method.</param>
        /// 
        /// <returns>The response from the DescribeVault service method, as returned by Glacier.</returns>
        /// <exception cref="Amazon.Glacier.Model.InvalidParameterValueException">
        /// Returned if a parameter of the request is incorrectly specified.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.MissingParameterValueException">
        /// Returned if a required header or parameter is missing from the request.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.ResourceNotFoundException">
        /// Returned if the specified resource (such as a vault, upload ID, or job ID) doesn't
        /// exist.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.ServiceUnavailableException">
        /// Returned if the service cannot complete the request.
        /// </exception>
        DescribeVaultResponse DescribeVault(DescribeVaultRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVault operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVault operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeVaultResponse> DescribeVaultAsync(DescribeVaultRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetDataRetrievalPolicy


        /// <summary>
        /// This operation returns the current data retrieval policy for the account and region
        /// specified in the GET request. For more information about data retrieval policies,
        /// see <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/data-retrieval-policy.html">Amazon
        /// Glacier Data Retrieval Policies</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataRetrievalPolicy service method.</param>
        /// 
        /// <returns>The response from the GetDataRetrievalPolicy service method, as returned by Glacier.</returns>
        /// <exception cref="Amazon.Glacier.Model.InvalidParameterValueException">
        /// Returned if a parameter of the request is incorrectly specified.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.MissingParameterValueException">
        /// Returned if a required header or parameter is missing from the request.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.ServiceUnavailableException">
        /// Returned if the service cannot complete the request.
        /// </exception>
        GetDataRetrievalPolicyResponse GetDataRetrievalPolicy(GetDataRetrievalPolicyRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetDataRetrievalPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDataRetrievalPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetDataRetrievalPolicyResponse> GetDataRetrievalPolicyAsync(GetDataRetrievalPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetJobOutput


        /// <summary>
        /// This operation downloads the output of the job you initiated using <a>InitiateJob</a>.
        /// Depending on the job type you specified when you initiated the job, the output will
        /// be either the content of an archive or a vault inventory.
        /// 
        ///  
        /// <para>
        /// You can download all the job output or download a portion of the output by specifying
        /// a byte range. In the case of an archive retrieval job, depending on the byte range
        /// you specify, Amazon Glacier returns the checksum for the portion of the data. You
        /// can compute the checksum on the client and verify that the values match to ensure
        /// the portion you downloaded is the correct data.
        /// </para>
        ///  
        /// <para>
        /// A job ID will not expire for at least 24 hours after Amazon Glacier completes the
        /// job. That a byte range. For both archive and inventory retrieval jobs, you should
        /// verify the downloaded size against the size returned in the headers from the <b>Get
        /// Job Output</b> response.
        /// </para>
        ///  
        /// <para>
        /// For archive retrieval jobs, you should also verify that the size is what you expected.
        /// If you download a portion of the output, the expected size is based on the range of
        /// bytes you specified. For example, if you specify a range of <code>bytes=0-1048575</code>,
        /// you should verify your download size is 1,048,576 bytes. If you download an entire
        /// archive, the expected size is the size of the archive when you uploaded it to Amazon
        /// Glacier The expected size is also returned in the headers from the <b>Get Job Output</b>
        /// response.
        /// </para>
        ///  
        /// <para>
        /// In the case of an archive retrieval job, depending on the byte range you specify,
        /// Amazon Glacier returns the checksum for the portion of the data. To ensure the portion
        /// you downloaded is the correct data, compute the checksum on the client, verify that
        /// the values match, and verify that the size is what you expected.
        /// </para>
        ///  
        /// <para>
        /// A job ID does not expire for at least 24 hours after Amazon Glacier completes the
        /// job. That is, you can download the job output within the 24 hours period after Amazon
        /// Glacier completes the job.
        /// </para>
        ///  
        /// <para>
        /// An AWS account has full permission to perform all operations (actions). However, AWS
        /// Identity and Access Management (IAM) users don't have any permissions by default.
        /// You must grant them explicit permission to perform specific actions. For more information,
        /// see <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/using-iam-with-amazon-glacier.html">Access
        /// Control Using AWS Identity and Access Management (IAM)</a>.
        /// </para>
        ///  
        /// <para>
        /// For conceptual information and the underlying REST API, see <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/vault-inventory.html">Downloading
        /// a Vault Inventory</a>, <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/downloading-an-archive.html">Downloading
        /// an Archive</a>, and <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/api-job-output-get.html">Get
        /// Job Output </a> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetJobOutput service method.</param>
        /// 
        /// <returns>The response from the GetJobOutput service method, as returned by Glacier.</returns>
        /// <exception cref="Amazon.Glacier.Model.InvalidParameterValueException">
        /// Returned if a parameter of the request is incorrectly specified.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.MissingParameterValueException">
        /// Returned if a required header or parameter is missing from the request.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.ResourceNotFoundException">
        /// Returned if the specified resource (such as a vault, upload ID, or job ID) doesn't
        /// exist.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.ServiceUnavailableException">
        /// Returned if the service cannot complete the request.
        /// </exception>
        GetJobOutputResponse GetJobOutput(GetJobOutputRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetJobOutput operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetJobOutput operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetJobOutputResponse> GetJobOutputAsync(GetJobOutputRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetVaultAccessPolicy


        /// <summary>
        /// This operation retrieves the <code>access-policy</code> subresource set on the vault;
        /// for more information on setting this subresource, see <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/api-SetVaultAccessPolicy.html">Set
        /// Vault Access Policy (PUT access-policy)</a>. If there is no access policy set on the
        /// vault, the operation returns a <code>404 Not found</code> error. For more information
        /// about vault access policies, see <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/vault-access-policy.html">Amazon
        /// Glacier Access Control with Vault Access Policies</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVaultAccessPolicy service method.</param>
        /// 
        /// <returns>The response from the GetVaultAccessPolicy service method, as returned by Glacier.</returns>
        /// <exception cref="Amazon.Glacier.Model.InvalidParameterValueException">
        /// Returned if a parameter of the request is incorrectly specified.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.MissingParameterValueException">
        /// Returned if a required header or parameter is missing from the request.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.ResourceNotFoundException">
        /// Returned if the specified resource (such as a vault, upload ID, or job ID) doesn't
        /// exist.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.ServiceUnavailableException">
        /// Returned if the service cannot complete the request.
        /// </exception>
        GetVaultAccessPolicyResponse GetVaultAccessPolicy(GetVaultAccessPolicyRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetVaultAccessPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetVaultAccessPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetVaultAccessPolicyResponse> GetVaultAccessPolicyAsync(GetVaultAccessPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetVaultLock


        /// <summary>
        /// This operation retrieves the following attributes from the <code>lock-policy</code>
        /// subresource set on the specified vault: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The vault lock policy set on the vault.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The state of the vault lock, which is either <code>InProgess</code> or <code>Locked</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When the lock ID expires. The lock ID is used to complete the vault locking process.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When the vault lock was initiated and put into the <code>InProgress</code> state.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// A vault lock is put into the <code>InProgress</code> state by calling <a>InitiateVaultLock</a>.
        /// A vault lock is put into the <code>Locked</code> state by calling <a>CompleteVaultLock</a>.
        /// You can abort the vault locking process by calling <a>AbortVaultLock</a>. For more
        /// information about the vault locking process, <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/vault-lock.html">Amazon
        /// Glacier Vault Lock</a>. 
        /// </para>
        ///  
        /// <para>
        /// If there is no vault lock policy set on the vault, the operation returns a <code>404
        /// Not found</code> error. For more information about vault lock policies, <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/vault-lock-policy.html">Amazon
        /// Glacier Access Control with Vault Lock Policies</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVaultLock service method.</param>
        /// 
        /// <returns>The response from the GetVaultLock service method, as returned by Glacier.</returns>
        /// <exception cref="Amazon.Glacier.Model.InvalidParameterValueException">
        /// Returned if a parameter of the request is incorrectly specified.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.MissingParameterValueException">
        /// Returned if a required header or parameter is missing from the request.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.ResourceNotFoundException">
        /// Returned if the specified resource (such as a vault, upload ID, or job ID) doesn't
        /// exist.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.ServiceUnavailableException">
        /// Returned if the service cannot complete the request.
        /// </exception>
        GetVaultLockResponse GetVaultLock(GetVaultLockRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetVaultLock operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetVaultLock operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetVaultLockResponse> GetVaultLockAsync(GetVaultLockRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetVaultNotifications


        /// <summary>
        /// This operation retrieves the <code>notification-configuration</code> subresource of
        /// the specified vault.
        /// 
        ///  
        /// <para>
        /// For information about setting a notification configuration on a vault, see <a>SetVaultNotifications</a>.
        /// If a notification configuration for a vault is not set, the operation returns a <code>404
        /// Not Found</code> error. For more information about vault notifications, see <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/configuring-notifications.html">Configuring
        /// Vault Notifications in Amazon Glacier</a>. 
        /// </para>
        ///  
        /// <para>
        /// An AWS account has full permission to perform all operations (actions). However, AWS
        /// Identity and Access Management (IAM) users don't have any permissions by default.
        /// You must grant them explicit permission to perform specific actions. For more information,
        /// see <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/using-iam-with-amazon-glacier.html">Access
        /// Control Using AWS Identity and Access Management (IAM)</a>.
        /// </para>
        ///  
        /// <para>
        /// For conceptual information and underlying REST API, see <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/configuring-notifications.html">Configuring
        /// Vault Notifications in Amazon Glacier</a> and <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/api-vault-notifications-get.html">Get
        /// Vault Notification Configuration </a> in the <i>Amazon Glacier Developer Guide</i>.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVaultNotifications service method.</param>
        /// 
        /// <returns>The response from the GetVaultNotifications service method, as returned by Glacier.</returns>
        /// <exception cref="Amazon.Glacier.Model.InvalidParameterValueException">
        /// Returned if a parameter of the request is incorrectly specified.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.MissingParameterValueException">
        /// Returned if a required header or parameter is missing from the request.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.ResourceNotFoundException">
        /// Returned if the specified resource (such as a vault, upload ID, or job ID) doesn't
        /// exist.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.ServiceUnavailableException">
        /// Returned if the service cannot complete the request.
        /// </exception>
        GetVaultNotificationsResponse GetVaultNotifications(GetVaultNotificationsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetVaultNotifications operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetVaultNotifications operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetVaultNotificationsResponse> GetVaultNotificationsAsync(GetVaultNotificationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  InitiateJob


        /// <summary>
        /// This operation initiates a job of the specified type, which can be a select, an archival
        /// retrieval, or a vault retrieval. For more information about using this operation,
        /// see the documentation for the underlying REST API <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/api-initiate-job-post.html">Initiate
        /// a Job</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InitiateJob service method.</param>
        /// 
        /// <returns>The response from the InitiateJob service method, as returned by Glacier.</returns>
        /// <exception cref="Amazon.Glacier.Model.InsufficientCapacityException">
        /// Returned if there is insufficient capacity to process this expedited request. This
        /// error only applies to expedited retrievals and not to standard or bulk retrievals.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.InvalidParameterValueException">
        /// Returned if a parameter of the request is incorrectly specified.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.MissingParameterValueException">
        /// Returned if a required header or parameter is missing from the request.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.PolicyEnforcedException">
        /// Returned if a retrieval job would exceed the current data policy's retrieval rate
        /// limit. For more information about data retrieval policies,
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.ResourceNotFoundException">
        /// Returned if the specified resource (such as a vault, upload ID, or job ID) doesn't
        /// exist.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.ServiceUnavailableException">
        /// Returned if the service cannot complete the request.
        /// </exception>
        InitiateJobResponse InitiateJob(InitiateJobRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the InitiateJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the InitiateJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<InitiateJobResponse> InitiateJobAsync(InitiateJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  InitiateMultipartUpload


        /// <summary>
        /// This operation initiates a multipart upload. Amazon Glacier creates a multipart upload
        /// resource and returns its ID in the response. The multipart upload ID is used in subsequent
        /// requests to upload parts of an archive (see <a>UploadMultipartPart</a>).
        /// 
        ///  
        /// <para>
        /// When you initiate a multipart upload, you specify the part size in number of bytes.
        /// The part size must be a megabyte (1024 KB) multiplied by a power of 2-for example,
        /// 1048576 (1 MB), 2097152 (2 MB), 4194304 (4 MB), 8388608 (8 MB), and so on. The minimum
        /// allowable part size is 1 MB, and the maximum is 4 GB.
        /// </para>
        ///  
        /// <para>
        /// Every part you upload to this resource (see <a>UploadMultipartPart</a>), except the
        /// last one, must have the same size. The last one can be the same size or smaller. For
        /// example, suppose you want to upload a 16.2 MB file. If you initiate the multipart
        /// upload with a part size of 4 MB, you will upload four parts of 4 MB each and one part
        /// of 0.2 MB. 
        /// </para>
        ///  <note> 
        /// <para>
        /// You don't need to know the size of the archive when you start a multipart upload because
        /// Amazon Glacier does not require you to specify the overall archive size.
        /// </para>
        ///  </note> 
        /// <para>
        /// After you complete the multipart upload, Amazon Glacier removes the multipart upload
        /// resource referenced by the ID. Amazon Glacier also removes the multipart upload resource
        /// if you cancel the multipart upload or it may be removed if there is no activity for
        /// a period of 24 hours.
        /// </para>
        ///  
        /// <para>
        /// An AWS account has full permission to perform all operations (actions). However, AWS
        /// Identity and Access Management (IAM) users don't have any permissions by default.
        /// You must grant them explicit permission to perform specific actions. For more information,
        /// see <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/using-iam-with-amazon-glacier.html">Access
        /// Control Using AWS Identity and Access Management (IAM)</a>.
        /// </para>
        ///  
        /// <para>
        /// For conceptual information and underlying REST API, see <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/uploading-archive-mpu.html">Uploading
        /// Large Archives in Parts (Multipart Upload)</a> and <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/api-multipart-initiate-upload.html">Initiate
        /// Multipart Upload</a> in the <i>Amazon Glacier Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InitiateMultipartUpload service method.</param>
        /// 
        /// <returns>The response from the InitiateMultipartUpload service method, as returned by Glacier.</returns>
        /// <exception cref="Amazon.Glacier.Model.InvalidParameterValueException">
        /// Returned if a parameter of the request is incorrectly specified.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.MissingParameterValueException">
        /// Returned if a required header or parameter is missing from the request.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.ResourceNotFoundException">
        /// Returned if the specified resource (such as a vault, upload ID, or job ID) doesn't
        /// exist.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.ServiceUnavailableException">
        /// Returned if the service cannot complete the request.
        /// </exception>
        InitiateMultipartUploadResponse InitiateMultipartUpload(InitiateMultipartUploadRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the InitiateMultipartUpload operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the InitiateMultipartUpload operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<InitiateMultipartUploadResponse> InitiateMultipartUploadAsync(InitiateMultipartUploadRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  InitiateVaultLock


        /// <summary>
        /// This operation initiates the vault locking process by doing the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Installing a vault lock policy on the specified vault.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Setting the lock state of vault lock to <code>InProgress</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Returning a lock ID, which is used to complete the vault locking process.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can set one vault lock policy for each vault and this policy can be up to 20 KB
        /// in size. For more information about vault lock policies, see <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/vault-lock-policy.html">Amazon
        /// Glacier Access Control with Vault Lock Policies</a>. 
        /// </para>
        ///  
        /// <para>
        /// You must complete the vault locking process within 24 hours after the vault lock enters
        /// the <code>InProgress</code> state. After the 24 hour window ends, the lock ID expires,
        /// the vault automatically exits the <code>InProgress</code> state, and the vault lock
        /// policy is removed from the vault. You call <a>CompleteVaultLock</a> to complete the
        /// vault locking process by setting the state of the vault lock to <code>Locked</code>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// After a vault lock is in the <code>Locked</code> state, you cannot initiate a new
        /// vault lock for the vault.
        /// </para>
        ///  
        /// <para>
        /// You can abort the vault locking process by calling <a>AbortVaultLock</a>. You can
        /// get the state of the vault lock by calling <a>GetVaultLock</a>. For more information
        /// about the vault locking process, <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/vault-lock.html">Amazon
        /// Glacier Vault Lock</a>.
        /// </para>
        ///  
        /// <para>
        /// If this operation is called when the vault lock is in the <code>InProgress</code>
        /// state, the operation returns an <code>AccessDeniedException</code> error. When the
        /// vault lock is in the <code>InProgress</code> state you must call <a>AbortVaultLock</a>
        /// before you can initiate a new vault lock policy. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InitiateVaultLock service method.</param>
        /// 
        /// <returns>The response from the InitiateVaultLock service method, as returned by Glacier.</returns>
        /// <exception cref="Amazon.Glacier.Model.InvalidParameterValueException">
        /// Returned if a parameter of the request is incorrectly specified.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.MissingParameterValueException">
        /// Returned if a required header or parameter is missing from the request.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.ResourceNotFoundException">
        /// Returned if the specified resource (such as a vault, upload ID, or job ID) doesn't
        /// exist.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.ServiceUnavailableException">
        /// Returned if the service cannot complete the request.
        /// </exception>
        InitiateVaultLockResponse InitiateVaultLock(InitiateVaultLockRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the InitiateVaultLock operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the InitiateVaultLock operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<InitiateVaultLockResponse> InitiateVaultLockAsync(InitiateVaultLockRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListJobs


        /// <summary>
        /// This operation lists jobs for a vault, including jobs that are in-progress and jobs
        /// that have recently finished. The List Job operation returns a list of these jobs sorted
        /// by job initiation time.
        /// 
        ///  <note> 
        /// <para>
        /// Amazon Glacier retains recently completed jobs for a period before deleting them;
        /// however, it eventually removes completed jobs. The output of completed jobs can be
        /// retrieved. Retaining completed jobs for a period of time after they have completed
        /// enables you to get a job output in the event you miss the job completion notification
        /// or your first attempt to download it fails. For example, suppose you start an archive
        /// retrieval job to download an archive. After the job completes, you start to download
        /// the archive but encounter a network error. In this scenario, you can retry and download
        /// the archive while the job exists.
        /// </para>
        ///  </note> 
        /// <para>
        /// The List Jobs operation supports pagination. You should always check the response
        /// <code>Marker</code> field. If there are no more jobs to list, the <code>Marker</code>
        /// field is set to <code>null</code>. If there are more jobs to list, the <code>Marker</code>
        /// field is set to a non-null value, which you can use to continue the pagination of
        /// the list. To return a list of jobs that begins at a specific job, set the marker request
        /// parameter to the <code>Marker</code> value for that job that you obtained from a previous
        /// List Jobs request.
        /// </para>
        ///  
        /// <para>
        /// You can set a maximum limit for the number of jobs returned in the response by specifying
        /// the <code>limit</code> parameter in the request. The default limit is 1000. The number
        /// of jobs returned might be fewer than the limit, but the number of returned jobs never
        /// exceeds the limit.
        /// </para>
        ///  
        /// <para>
        /// Additionally, you can filter the jobs list returned by specifying the optional <code>statuscode</code>
        /// parameter or <code>completed</code> parameter, or both. Using the <code>statuscode</code>
        /// parameter, you can specify to return only jobs that match either the <code>InProgress</code>,
        /// <code>Succeeded</code>, or <code>Failed</code> status. Using the <code>completed</code>
        /// parameter, you can specify to return only jobs that were completed (<code>true</code>)
        /// or jobs that were not completed (<code>false</code>).
        /// </para>
        ///  
        /// <para>
        /// For more information about using this operation, see the documentation for the underlying
        /// REST API <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/api-jobs-get.html">List
        /// Jobs</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListJobs service method.</param>
        /// 
        /// <returns>The response from the ListJobs service method, as returned by Glacier.</returns>
        /// <exception cref="Amazon.Glacier.Model.InvalidParameterValueException">
        /// Returned if a parameter of the request is incorrectly specified.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.MissingParameterValueException">
        /// Returned if a required header or parameter is missing from the request.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.ResourceNotFoundException">
        /// Returned if the specified resource (such as a vault, upload ID, or job ID) doesn't
        /// exist.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.ServiceUnavailableException">
        /// Returned if the service cannot complete the request.
        /// </exception>
        ListJobsResponse ListJobs(ListJobsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ListJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListJobs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListJobsResponse> ListJobsAsync(ListJobsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListMultipartUploads


        /// <summary>
        /// This operation lists in-progress multipart uploads for the specified vault. An in-progress
        /// multipart upload is a multipart upload that has been initiated by an <a>InitiateMultipartUpload</a>
        /// request, but has not yet been completed or aborted. The list returned in the List
        /// Multipart Upload response has no guaranteed order. 
        /// 
        ///  
        /// <para>
        /// The List Multipart Uploads operation supports pagination. By default, this operation
        /// returns up to 1,000 multipart uploads in the response. You should always check the
        /// response for a <code>marker</code> at which to continue the list; if there are no
        /// more items the <code>marker</code> is <code>null</code>. To return a list of multipart
        /// uploads that begins at a specific upload, set the <code>marker</code> request parameter
        /// to the value you obtained from a previous List Multipart Upload request. You can also
        /// limit the number of uploads returned in the response by specifying the <code>limit</code>
        /// parameter in the request.
        /// </para>
        ///  
        /// <para>
        /// Note the difference between this operation and listing parts (<a>ListParts</a>). The
        /// List Multipart Uploads operation lists all multipart uploads for a vault and does
        /// not require a multipart upload ID. The List Parts operation requires a multipart upload
        /// ID since parts are associated with a single upload.
        /// </para>
        ///  
        /// <para>
        /// An AWS account has full permission to perform all operations (actions). However, AWS
        /// Identity and Access Management (IAM) users don't have any permissions by default.
        /// You must grant them explicit permission to perform specific actions. For more information,
        /// see <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/using-iam-with-amazon-glacier.html">Access
        /// Control Using AWS Identity and Access Management (IAM)</a>.
        /// </para>
        ///  
        /// <para>
        /// For conceptual information and the underlying REST API, see <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/working-with-archives.html">Working
        /// with Archives in Amazon Glacier</a> and <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/api-multipart-list-uploads.html">List
        /// Multipart Uploads </a> in the <i>Amazon Glacier Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMultipartUploads service method.</param>
        /// 
        /// <returns>The response from the ListMultipartUploads service method, as returned by Glacier.</returns>
        /// <exception cref="Amazon.Glacier.Model.InvalidParameterValueException">
        /// Returned if a parameter of the request is incorrectly specified.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.MissingParameterValueException">
        /// Returned if a required header or parameter is missing from the request.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.ResourceNotFoundException">
        /// Returned if the specified resource (such as a vault, upload ID, or job ID) doesn't
        /// exist.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.ServiceUnavailableException">
        /// Returned if the service cannot complete the request.
        /// </exception>
        ListMultipartUploadsResponse ListMultipartUploads(ListMultipartUploadsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ListMultipartUploads operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMultipartUploads operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListMultipartUploadsResponse> ListMultipartUploadsAsync(ListMultipartUploadsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListParts


        /// <summary>
        /// This operation lists the parts of an archive that have been uploaded in a specific
        /// multipart upload. You can make this request at any time during an in-progress multipart
        /// upload before you complete the upload (see <a>CompleteMultipartUpload</a>. List Parts
        /// returns an error for completed uploads. The list returned in the List Parts response
        /// is sorted by part range. 
        /// 
        ///  
        /// <para>
        /// The List Parts operation supports pagination. By default, this operation returns up
        /// to 1,000 uploaded parts in the response. You should always check the response for
        /// a <code>marker</code> at which to continue the list; if there are no more items the
        /// <code>marker</code> is <code>null</code>. To return a list of parts that begins at
        /// a specific part, set the <code>marker</code> request parameter to the value you obtained
        /// from a previous List Parts request. You can also limit the number of parts returned
        /// in the response by specifying the <code>limit</code> parameter in the request. 
        /// </para>
        ///  
        /// <para>
        /// An AWS account has full permission to perform all operations (actions). However, AWS
        /// Identity and Access Management (IAM) users don't have any permissions by default.
        /// You must grant them explicit permission to perform specific actions. For more information,
        /// see <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/using-iam-with-amazon-glacier.html">Access
        /// Control Using AWS Identity and Access Management (IAM)</a>.
        /// </para>
        ///  
        /// <para>
        /// For conceptual information and the underlying REST API, see <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/working-with-archives.html">Working
        /// with Archives in Amazon Glacier</a> and <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/api-multipart-list-parts.html">List
        /// Parts</a> in the <i>Amazon Glacier Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListParts service method.</param>
        /// 
        /// <returns>The response from the ListParts service method, as returned by Glacier.</returns>
        /// <exception cref="Amazon.Glacier.Model.InvalidParameterValueException">
        /// Returned if a parameter of the request is incorrectly specified.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.MissingParameterValueException">
        /// Returned if a required header or parameter is missing from the request.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.ResourceNotFoundException">
        /// Returned if the specified resource (such as a vault, upload ID, or job ID) doesn't
        /// exist.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.ServiceUnavailableException">
        /// Returned if the service cannot complete the request.
        /// </exception>
        ListPartsResponse ListParts(ListPartsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ListParts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListParts operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListPartsResponse> ListPartsAsync(ListPartsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListProvisionedCapacity


        /// <summary>
        /// This operation lists the provisioned capacity units for the specified AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProvisionedCapacity service method.</param>
        /// 
        /// <returns>The response from the ListProvisionedCapacity service method, as returned by Glacier.</returns>
        /// <exception cref="Amazon.Glacier.Model.InvalidParameterValueException">
        /// Returned if a parameter of the request is incorrectly specified.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.MissingParameterValueException">
        /// Returned if a required header or parameter is missing from the request.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.ServiceUnavailableException">
        /// Returned if the service cannot complete the request.
        /// </exception>
        ListProvisionedCapacityResponse ListProvisionedCapacity(ListProvisionedCapacityRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ListProvisionedCapacity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListProvisionedCapacity operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListProvisionedCapacityResponse> ListProvisionedCapacityAsync(ListProvisionedCapacityRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTagsForVault


        /// <summary>
        /// This operation lists all the tags attached to a vault. The operation returns an empty
        /// map if there are no tags. For more information about tags, see <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/tagging.html">Tagging
        /// Amazon Glacier Resources</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForVault service method.</param>
        /// 
        /// <returns>The response from the ListTagsForVault service method, as returned by Glacier.</returns>
        /// <exception cref="Amazon.Glacier.Model.InvalidParameterValueException">
        /// Returned if a parameter of the request is incorrectly specified.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.MissingParameterValueException">
        /// Returned if a required header or parameter is missing from the request.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.ResourceNotFoundException">
        /// Returned if the specified resource (such as a vault, upload ID, or job ID) doesn't
        /// exist.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.ServiceUnavailableException">
        /// Returned if the service cannot complete the request.
        /// </exception>
        ListTagsForVaultResponse ListTagsForVault(ListTagsForVaultRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForVault operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForVault operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListTagsForVaultResponse> ListTagsForVaultAsync(ListTagsForVaultRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListVaults


        /// <summary>
        /// This operation lists all vaults owned by the calling user's account. The list returned
        /// in the response is ASCII-sorted by vault name.
        /// 
        ///  
        /// <para>
        /// By default, this operation returns up to 1,000 items. If there are more vaults to
        /// list, the response <code>marker</code> field contains the vault Amazon Resource Name
        /// (ARN) at which to continue the list with a new List Vaults request; otherwise, the
        /// <code>marker</code> field is <code>null</code>. To return a list of vaults that begins
        /// at a specific vault, set the <code>marker</code> request parameter to the vault ARN
        /// you obtained from a previous List Vaults request. You can also limit the number of
        /// vaults returned in the response by specifying the <code>limit</code> parameter in
        /// the request. 
        /// </para>
        ///  
        /// <para>
        /// An AWS account has full permission to perform all operations (actions). However, AWS
        /// Identity and Access Management (IAM) users don't have any permissions by default.
        /// You must grant them explicit permission to perform specific actions. For more information,
        /// see <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/using-iam-with-amazon-glacier.html">Access
        /// Control Using AWS Identity and Access Management (IAM)</a>.
        /// </para>
        ///  
        /// <para>
        /// For conceptual information and underlying REST API, see <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/retrieving-vault-info.html">Retrieving
        /// Vault Metadata in Amazon Glacier</a> and <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/api-vaults-get.html">List
        /// Vaults </a> in the <i>Amazon Glacier Developer Guide</i>. 
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the ListVaults service method, as returned by Glacier.</returns>
        /// <exception cref="Amazon.Glacier.Model.InvalidParameterValueException">
        /// Returned if a parameter of the request is incorrectly specified.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.MissingParameterValueException">
        /// Returned if a required header or parameter is missing from the request.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.ResourceNotFoundException">
        /// Returned if the specified resource (such as a vault, upload ID, or job ID) doesn't
        /// exist.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.ServiceUnavailableException">
        /// Returned if the service cannot complete the request.
        /// </exception>
        ListVaultsResponse ListVaults();


        /// <summary>
        /// This operation lists all vaults owned by the calling user's account. The list returned
        /// in the response is ASCII-sorted by vault name.
        /// 
        ///  
        /// <para>
        /// By default, this operation returns up to 1,000 items. If there are more vaults to
        /// list, the response <code>marker</code> field contains the vault Amazon Resource Name
        /// (ARN) at which to continue the list with a new List Vaults request; otherwise, the
        /// <code>marker</code> field is <code>null</code>. To return a list of vaults that begins
        /// at a specific vault, set the <code>marker</code> request parameter to the vault ARN
        /// you obtained from a previous List Vaults request. You can also limit the number of
        /// vaults returned in the response by specifying the <code>limit</code> parameter in
        /// the request. 
        /// </para>
        ///  
        /// <para>
        /// An AWS account has full permission to perform all operations (actions). However, AWS
        /// Identity and Access Management (IAM) users don't have any permissions by default.
        /// You must grant them explicit permission to perform specific actions. For more information,
        /// see <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/using-iam-with-amazon-glacier.html">Access
        /// Control Using AWS Identity and Access Management (IAM)</a>.
        /// </para>
        ///  
        /// <para>
        /// For conceptual information and underlying REST API, see <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/retrieving-vault-info.html">Retrieving
        /// Vault Metadata in Amazon Glacier</a> and <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/api-vaults-get.html">List
        /// Vaults </a> in the <i>Amazon Glacier Developer Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVaults service method.</param>
        /// 
        /// <returns>The response from the ListVaults service method, as returned by Glacier.</returns>
        /// <exception cref="Amazon.Glacier.Model.InvalidParameterValueException">
        /// Returned if a parameter of the request is incorrectly specified.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.MissingParameterValueException">
        /// Returned if a required header or parameter is missing from the request.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.ResourceNotFoundException">
        /// Returned if the specified resource (such as a vault, upload ID, or job ID) doesn't
        /// exist.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.ServiceUnavailableException">
        /// Returned if the service cannot complete the request.
        /// </exception>
        ListVaultsResponse ListVaults(ListVaultsRequest request);


        /// <summary>
        /// This operation lists all vaults owned by the calling user's account. The list returned
        /// in the response is ASCII-sorted by vault name.
        /// 
        ///  
        /// <para>
        /// By default, this operation returns up to 1,000 items. If there are more vaults to
        /// list, the response <code>marker</code> field contains the vault Amazon Resource Name
        /// (ARN) at which to continue the list with a new List Vaults request; otherwise, the
        /// <code>marker</code> field is <code>null</code>. To return a list of vaults that begins
        /// at a specific vault, set the <code>marker</code> request parameter to the vault ARN
        /// you obtained from a previous List Vaults request. You can also limit the number of
        /// vaults returned in the response by specifying the <code>limit</code> parameter in
        /// the request. 
        /// </para>
        ///  
        /// <para>
        /// An AWS account has full permission to perform all operations (actions). However, AWS
        /// Identity and Access Management (IAM) users don't have any permissions by default.
        /// You must grant them explicit permission to perform specific actions. For more information,
        /// see <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/using-iam-with-amazon-glacier.html">Access
        /// Control Using AWS Identity and Access Management (IAM)</a>.
        /// </para>
        ///  
        /// <para>
        /// For conceptual information and underlying REST API, see <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/retrieving-vault-info.html">Retrieving
        /// Vault Metadata in Amazon Glacier</a> and <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/api-vaults-get.html">List
        /// Vaults </a> in the <i>Amazon Glacier Developer Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListVaults service method, as returned by Glacier.</returns>
        /// <exception cref="Amazon.Glacier.Model.InvalidParameterValueException">
        /// Returned if a parameter of the request is incorrectly specified.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.MissingParameterValueException">
        /// Returned if a required header or parameter is missing from the request.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.ResourceNotFoundException">
        /// Returned if the specified resource (such as a vault, upload ID, or job ID) doesn't
        /// exist.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.ServiceUnavailableException">
        /// Returned if the service cannot complete the request.
        /// </exception>
        Task<ListVaultsResponse> ListVaultsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the ListVaults operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVaults operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListVaultsResponse> ListVaultsAsync(ListVaultsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PurchaseProvisionedCapacity


        /// <summary>
        /// This operation purchases a provisioned capacity unit for an AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PurchaseProvisionedCapacity service method.</param>
        /// 
        /// <returns>The response from the PurchaseProvisionedCapacity service method, as returned by Glacier.</returns>
        /// <exception cref="Amazon.Glacier.Model.InvalidParameterValueException">
        /// Returned if a parameter of the request is incorrectly specified.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.LimitExceededException">
        /// Returned if the request results in a vault or account limit being exceeded.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.MissingParameterValueException">
        /// Returned if a required header or parameter is missing from the request.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.ServiceUnavailableException">
        /// Returned if the service cannot complete the request.
        /// </exception>
        PurchaseProvisionedCapacityResponse PurchaseProvisionedCapacity(PurchaseProvisionedCapacityRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the PurchaseProvisionedCapacity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PurchaseProvisionedCapacity operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<PurchaseProvisionedCapacityResponse> PurchaseProvisionedCapacityAsync(PurchaseProvisionedCapacityRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RemoveTagsFromVault


        /// <summary>
        /// This operation removes one or more tags from the set of tags attached to a vault.
        /// For more information about tags, see <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/tagging.html">Tagging
        /// Amazon Glacier Resources</a>. This operation is idempotent. The operation will be
        /// successful, even if there are no tags attached to the vault.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveTagsFromVault service method.</param>
        /// 
        /// <returns>The response from the RemoveTagsFromVault service method, as returned by Glacier.</returns>
        /// <exception cref="Amazon.Glacier.Model.InvalidParameterValueException">
        /// Returned if a parameter of the request is incorrectly specified.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.MissingParameterValueException">
        /// Returned if a required header or parameter is missing from the request.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.ResourceNotFoundException">
        /// Returned if the specified resource (such as a vault, upload ID, or job ID) doesn't
        /// exist.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.ServiceUnavailableException">
        /// Returned if the service cannot complete the request.
        /// </exception>
        RemoveTagsFromVaultResponse RemoveTagsFromVault(RemoveTagsFromVaultRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the RemoveTagsFromVault operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveTagsFromVault operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<RemoveTagsFromVaultResponse> RemoveTagsFromVaultAsync(RemoveTagsFromVaultRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SetDataRetrievalPolicy


        /// <summary>
        /// This operation sets and then enacts a data retrieval policy in the region specified
        /// in the PUT request. You can set one policy per region for an AWS account. The policy
        /// is enacted within a few minutes of a successful PUT operation.
        /// 
        ///  
        /// <para>
        /// The set policy operation does not affect retrieval jobs that were in progress before
        /// the policy was enacted. For more information about data retrieval policies, see <a
        /// href="http://docs.aws.amazon.com/amazonglacier/latest/dev/data-retrieval-policy.html">Amazon
        /// Glacier Data Retrieval Policies</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetDataRetrievalPolicy service method.</param>
        /// 
        /// <returns>The response from the SetDataRetrievalPolicy service method, as returned by Glacier.</returns>
        /// <exception cref="Amazon.Glacier.Model.InvalidParameterValueException">
        /// Returned if a parameter of the request is incorrectly specified.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.MissingParameterValueException">
        /// Returned if a required header or parameter is missing from the request.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.ServiceUnavailableException">
        /// Returned if the service cannot complete the request.
        /// </exception>
        SetDataRetrievalPolicyResponse SetDataRetrievalPolicy(SetDataRetrievalPolicyRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the SetDataRetrievalPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetDataRetrievalPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<SetDataRetrievalPolicyResponse> SetDataRetrievalPolicyAsync(SetDataRetrievalPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SetVaultAccessPolicy


        /// <summary>
        /// This operation configures an access policy for a vault and will overwrite an existing
        /// policy. To configure a vault access policy, send a PUT request to the <code>access-policy</code>
        /// subresource of the vault. An access policy is specific to a vault and is also called
        /// a vault subresource. You can set one access policy per vault and the policy can be
        /// up to 20 KB in size. For more information about vault access policies, see <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/vault-access-policy.html">Amazon
        /// Glacier Access Control with Vault Access Policies</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetVaultAccessPolicy service method.</param>
        /// 
        /// <returns>The response from the SetVaultAccessPolicy service method, as returned by Glacier.</returns>
        /// <exception cref="Amazon.Glacier.Model.InvalidParameterValueException">
        /// Returned if a parameter of the request is incorrectly specified.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.MissingParameterValueException">
        /// Returned if a required header or parameter is missing from the request.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.ResourceNotFoundException">
        /// Returned if the specified resource (such as a vault, upload ID, or job ID) doesn't
        /// exist.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.ServiceUnavailableException">
        /// Returned if the service cannot complete the request.
        /// </exception>
        SetVaultAccessPolicyResponse SetVaultAccessPolicy(SetVaultAccessPolicyRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the SetVaultAccessPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetVaultAccessPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<SetVaultAccessPolicyResponse> SetVaultAccessPolicyAsync(SetVaultAccessPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SetVaultNotifications


        /// <summary>
        /// This operation configures notifications that will be sent when specific events happen
        /// to a vault. By default, you don't get any notifications.
        /// 
        ///  
        /// <para>
        /// To configure vault notifications, send a PUT request to the <code>notification-configuration</code>
        /// subresource of the vault. The request should include a JSON document that provides
        /// an Amazon SNS topic and specific events for which you want Amazon Glacier to send
        /// notifications to the topic.
        /// </para>
        ///  
        /// <para>
        /// Amazon SNS topics must grant permission to the vault to be allowed to publish notifications
        /// to the topic. You can configure a vault to publish a notification for the following
        /// vault events:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>ArchiveRetrievalCompleted</b> This event occurs when a job that was initiated
        /// for an archive retrieval is completed (<a>InitiateJob</a>). The status of the completed
        /// job can be "Succeeded" or "Failed". The notification sent to the SNS topic is the
        /// same output as returned from <a>DescribeJob</a>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>InventoryRetrievalCompleted</b> This event occurs when a job that was initiated
        /// for an inventory retrieval is completed (<a>InitiateJob</a>). The status of the completed
        /// job can be "Succeeded" or "Failed". The notification sent to the SNS topic is the
        /// same output as returned from <a>DescribeJob</a>. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// An AWS account has full permission to perform all operations (actions). However, AWS
        /// Identity and Access Management (IAM) users don't have any permissions by default.
        /// You must grant them explicit permission to perform specific actions. For more information,
        /// see <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/using-iam-with-amazon-glacier.html">Access
        /// Control Using AWS Identity and Access Management (IAM)</a>.
        /// </para>
        ///  
        /// <para>
        /// For conceptual information and underlying REST API, see <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/configuring-notifications.html">Configuring
        /// Vault Notifications in Amazon Glacier</a> and <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/api-vault-notifications-put.html">Set
        /// Vault Notification Configuration </a> in the <i>Amazon Glacier Developer Guide</i>.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetVaultNotifications service method.</param>
        /// 
        /// <returns>The response from the SetVaultNotifications service method, as returned by Glacier.</returns>
        /// <exception cref="Amazon.Glacier.Model.InvalidParameterValueException">
        /// Returned if a parameter of the request is incorrectly specified.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.MissingParameterValueException">
        /// Returned if a required header or parameter is missing from the request.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.ResourceNotFoundException">
        /// Returned if the specified resource (such as a vault, upload ID, or job ID) doesn't
        /// exist.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.ServiceUnavailableException">
        /// Returned if the service cannot complete the request.
        /// </exception>
        SetVaultNotificationsResponse SetVaultNotifications(SetVaultNotificationsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the SetVaultNotifications operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetVaultNotifications operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<SetVaultNotificationsResponse> SetVaultNotificationsAsync(SetVaultNotificationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UploadArchive


        /// <summary>
        /// This operation adds an archive to a vault. This is a synchronous operation, and for
        /// a successful upload, your data is durably persisted. Amazon Glacier returns the archive
        /// ID in the <code>x-amz-archive-id</code> header of the response. 
        /// 
        ///  
        /// <para>
        /// You must use the archive ID to access your data in Amazon Glacier. After you upload
        /// an archive, you should save the archive ID returned so that you can retrieve or delete
        /// the archive later. Besides saving the archive ID, you can also index it and give it
        /// a friendly name to allow for better searching. You can also use the optional archive
        /// description field to specify how the archive is referred to in an external index of
        /// archives, such as you might create in Amazon DynamoDB. You can also get the vault
        /// inventory to obtain a list of archive IDs in a vault. For more information, see <a>InitiateJob</a>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// You must provide a SHA256 tree hash of the data you are uploading. For information
        /// about computing a SHA256 tree hash, see <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/checksum-calculations.html">Computing
        /// Checksums</a>. 
        /// </para>
        ///  
        /// <para>
        /// You can optionally specify an archive description of up to 1,024 printable ASCII characters.
        /// You can get the archive description when you either retrieve the archive or get the
        /// vault inventory. For more information, see <a>InitiateJob</a>. Amazon Glacier does
        /// not interpret the description in any way. An archive description does not need to
        /// be unique. You cannot use the description to retrieve or sort the archive list. 
        /// </para>
        ///  
        /// <para>
        /// Archives are immutable. After you upload an archive, you cannot edit the archive or
        /// its description.
        /// </para>
        ///  
        /// <para>
        /// An AWS account has full permission to perform all operations (actions). However, AWS
        /// Identity and Access Management (IAM) users don't have any permissions by default.
        /// You must grant them explicit permission to perform specific actions. For more information,
        /// see <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/using-iam-with-amazon-glacier.html">Access
        /// Control Using AWS Identity and Access Management (IAM)</a>.
        /// </para>
        ///  
        /// <para>
        ///  For conceptual information and underlying REST API, see <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/uploading-an-archive.html">Uploading
        /// an Archive in Amazon Glacier</a> and <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/api-archive-post.html">Upload
        /// Archive</a> in the <i>Amazon Glacier Developer Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UploadArchive service method.</param>
        /// 
        /// <returns>The response from the UploadArchive service method, as returned by Glacier.</returns>
        /// <exception cref="Amazon.Glacier.Model.InvalidParameterValueException">
        /// Returned if a parameter of the request is incorrectly specified.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.MissingParameterValueException">
        /// Returned if a required header or parameter is missing from the request.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.RequestTimeoutException">
        /// Returned if, when uploading an archive, Amazon Glacier times out while receiving the
        /// upload.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.ResourceNotFoundException">
        /// Returned if the specified resource (such as a vault, upload ID, or job ID) doesn't
        /// exist.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.ServiceUnavailableException">
        /// Returned if the service cannot complete the request.
        /// </exception>
        UploadArchiveResponse UploadArchive(UploadArchiveRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the UploadArchive operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UploadArchive operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UploadArchiveResponse> UploadArchiveAsync(UploadArchiveRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UploadMultipartPart


        /// <summary>
        /// This operation uploads a part of an archive. You can upload archive parts in any order.
        /// You can also upload them in parallel. You can upload up to 10,000 parts for a multipart
        /// upload.
        /// 
        ///  
        /// <para>
        /// Amazon Glacier rejects your upload part request if any of the following conditions
        /// is true:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>SHA256 tree hash does not match</b>To ensure that part data is not corrupted in
        /// transmission, you compute a SHA256 tree hash of the part and include it in your request.
        /// Upon receiving the part data, Amazon Glacier also computes a SHA256 tree hash. If
        /// these hash values don't match, the operation fails. For information about computing
        /// a SHA256 tree hash, see <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/checksum-calculations.html">Computing
        /// Checksums</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Part size does not match</b>The size of each part except the last must match the
        /// size specified in the corresponding <a>InitiateMultipartUpload</a> request. The size
        /// of the last part must be the same size as, or smaller than, the specified size.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you upload a part whose size is smaller than the part size you specified in your
        /// initiate multipart upload request and that part is not the last part, then the upload
        /// part request will succeed. However, the subsequent Complete Multipart Upload request
        /// will fail.
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        ///  <b>Range does not align</b>The byte range value in the request does not align with
        /// the part size specified in the corresponding initiate request. For example, if you
        /// specify a part size of 4194304 bytes (4 MB), then 0 to 4194303 bytes (4 MB - 1) and
        /// 4194304 (4 MB) to 8388607 (8 MB - 1) are valid part ranges. However, if you set a
        /// range value of 2 MB to 6 MB, the range does not align with the part size and the upload
        /// will fail. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// This operation is idempotent. If you upload the same part multiple times, the data
        /// included in the most recent request overwrites the previously uploaded data.
        /// </para>
        ///  
        /// <para>
        /// An AWS account has full permission to perform all operations (actions). However, AWS
        /// Identity and Access Management (IAM) users don't have any permissions by default.
        /// You must grant them explicit permission to perform specific actions. For more information,
        /// see <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/using-iam-with-amazon-glacier.html">Access
        /// Control Using AWS Identity and Access Management (IAM)</a>.
        /// </para>
        ///  
        /// <para>
        ///  For conceptual information and underlying REST API, see <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/uploading-archive-mpu.html">Uploading
        /// Large Archives in Parts (Multipart Upload)</a> and <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/api-upload-part.html">Upload
        /// Part </a> in the <i>Amazon Glacier Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UploadMultipartPart service method.</param>
        /// 
        /// <returns>The response from the UploadMultipartPart service method, as returned by Glacier.</returns>
        /// <exception cref="Amazon.Glacier.Model.InvalidParameterValueException">
        /// Returned if a parameter of the request is incorrectly specified.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.MissingParameterValueException">
        /// Returned if a required header or parameter is missing from the request.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.RequestTimeoutException">
        /// Returned if, when uploading an archive, Amazon Glacier times out while receiving the
        /// upload.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.ResourceNotFoundException">
        /// Returned if the specified resource (such as a vault, upload ID, or job ID) doesn't
        /// exist.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.ServiceUnavailableException">
        /// Returned if the service cannot complete the request.
        /// </exception>
        UploadMultipartPartResponse UploadMultipartPart(UploadMultipartPartRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the UploadMultipartPart operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UploadMultipartPart operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UploadMultipartPartResponse> UploadMultipartPartAsync(UploadMultipartPartRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}