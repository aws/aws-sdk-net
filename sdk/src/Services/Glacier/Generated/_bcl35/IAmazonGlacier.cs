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
    /// S3. For more information, go to <a href="http://aws.amazon.com/s3/">Amazon Simple
    /// Storage Service (Amazon S3)</a>.
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
    /// <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/introduction.html">What
    /// is Amazon Glacier</a> - This section of the Developer Guide describes the underlying
    /// data model, the operations it supports, and the AWS SDKs that you can use to interact
    /// with the service.
    /// </para>
    /// </li> <li>
    /// <para>
    /// <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/amazon-glacier-getting-started.html">Getting
    /// Started with Amazon Glacier</a> - The Getting Started section walks you through the
    /// process of creating a vault, uploading archives, creating jobs to download archives,
    /// retrieving the job output, and deleting archives.
    /// </para>
    /// </li> </ul>
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
        ///  For conceptual information and underlying REST API, go to <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/working-with-archives.html">Working
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
        /// Returned if the specified resource, such as a vault, upload ID, or job ID, does not
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
        /// <param name="request">Container for the necessary parameters to execute the AbortMultipartUpload operation on AmazonGlacierClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAbortMultipartUpload
        ///         operation.</returns>
        IAsyncResult BeginAbortMultipartUpload(AbortMultipartUploadRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AbortMultipartUpload operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAbortMultipartUpload.</param>
        /// 
        /// <returns>Returns a  AbortMultipartUploadResult from Glacier.</returns>
        AbortMultipartUploadResponse EndAbortMultipartUpload(IAsyncResult asyncResult);

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
        /// Returned if the specified resource, such as a vault, upload ID, or job ID, does not
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
        /// <param name="request">Container for the necessary parameters to execute the AbortVaultLock operation on AmazonGlacierClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAbortVaultLock
        ///         operation.</returns>
        IAsyncResult BeginAbortVaultLock(AbortVaultLockRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AbortVaultLock operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAbortVaultLock.</param>
        /// 
        /// <returns>Returns a  AbortVaultLockResult from Glacier.</returns>
        AbortVaultLockResponse EndAbortVaultLock(IAsyncResult asyncResult);

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
        /// Returned if the specified resource, such as a vault, upload ID, or job ID, does not
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
        /// <param name="request">Container for the necessary parameters to execute the AddTagsToVault operation on AmazonGlacierClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAddTagsToVault
        ///         operation.</returns>
        IAsyncResult BeginAddTagsToVault(AddTagsToVaultRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AddTagsToVault operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddTagsToVault.</param>
        /// 
        /// <returns>Returns a  AddTagsToVaultResult from Glacier.</returns>
        AddTagsToVaultResponse EndAddTagsToVault(IAsyncResult asyncResult);

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
        ///  For conceptual information and underlying REST API, go to <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/uploading-archive-mpu.html">Uploading
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
        /// Returned if the specified resource, such as a vault, upload ID, or job ID, does not
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
        /// <param name="request">Container for the necessary parameters to execute the CompleteMultipartUpload operation on AmazonGlacierClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCompleteMultipartUpload
        ///         operation.</returns>
        IAsyncResult BeginCompleteMultipartUpload(CompleteMultipartUploadRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CompleteMultipartUpload operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCompleteMultipartUpload.</param>
        /// 
        /// <returns>Returns a  CompleteMultipartUploadResult from Glacier.</returns>
        CompleteMultipartUploadResponse EndCompleteMultipartUpload(IAsyncResult asyncResult);

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
        /// Returned if the specified resource, such as a vault, upload ID, or job ID, does not
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
        /// <param name="request">Container for the necessary parameters to execute the CompleteVaultLock operation on AmazonGlacierClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCompleteVaultLock
        ///         operation.</returns>
        IAsyncResult BeginCompleteVaultLock(CompleteVaultLockRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CompleteVaultLock operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCompleteVaultLock.</param>
        /// 
        /// <returns>Returns a  CompleteVaultLockResult from Glacier.</returns>
        CompleteVaultLockResponse EndCompleteVaultLock(IAsyncResult asyncResult);

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
        ///  
        /// <para>
        ///  <ul> <li> 
        /// <para>
        ///  Names can be between 1 and 255 characters long. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Allowed characters are a-z, A-Z, 0-9, '_' (underscore), '-' (hyphen), and '.' (period).
        /// </para>
        ///  </li> </ul> 
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
        ///  For conceptual information and underlying REST API, go to <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/creating-vaults.html">Creating
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
        /// <param name="request">Container for the necessary parameters to execute the CreateVault operation on AmazonGlacierClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateVault
        ///         operation.</returns>
        IAsyncResult BeginCreateVault(CreateVaultRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateVault operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateVault.</param>
        /// 
        /// <returns>Returns a  CreateVaultResult from Glacier.</returns>
        CreateVaultResponse EndCreateVault(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteArchive


        /// <summary>
        /// This operation deletes an archive from a vault. Subsequent requests to initiate a
        /// retrieval of this archive will fail. Archive retrievals that are in progress for this
        /// archive ID may or may not succeed according to the following scenarios:
        /// 
        ///  <ul> <li>If the archive retrieval job is actively preparing the data for download
        /// when Amazon Glacier receives the delete archive request, the archival retrieval operation
        /// might fail. </li> <li>If the archive retrieval job has successfully prepared the archive
        /// for download when Amazon Glacier receives the delete archive request, you will be
        /// able to download the output. </li> </ul> 
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
        ///  For conceptual information and underlying REST API, go to <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/deleting-an-archive.html">Deleting
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
        /// Returned if the specified resource, such as a vault, upload ID, or job ID, does not
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
        /// <param name="request">Container for the necessary parameters to execute the DeleteArchive operation on AmazonGlacierClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteArchive
        ///         operation.</returns>
        IAsyncResult BeginDeleteArchive(DeleteArchiveRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteArchive operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteArchive.</param>
        /// 
        /// <returns>Returns a  DeleteArchiveResult from Glacier.</returns>
        DeleteArchiveResponse EndDeleteArchive(IAsyncResult asyncResult);

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
        ///  For conceptual information and underlying REST API, go to <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/deleting-vaults.html">Deleting
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
        /// Returned if the specified resource, such as a vault, upload ID, or job ID, does not
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
        /// <param name="request">Container for the necessary parameters to execute the DeleteVault operation on AmazonGlacierClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVault
        ///         operation.</returns>
        IAsyncResult BeginDeleteVault(DeleteVaultRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVault operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVault.</param>
        /// 
        /// <returns>Returns a  DeleteVaultResult from Glacier.</returns>
        DeleteVaultResponse EndDeleteVault(IAsyncResult asyncResult);

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
        /// Returned if the specified resource, such as a vault, upload ID, or job ID, does not
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
        /// <param name="request">Container for the necessary parameters to execute the DeleteVaultAccessPolicy operation on AmazonGlacierClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVaultAccessPolicy
        ///         operation.</returns>
        IAsyncResult BeginDeleteVaultAccessPolicy(DeleteVaultAccessPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVaultAccessPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVaultAccessPolicy.</param>
        /// 
        /// <returns>Returns a  DeleteVaultAccessPolicyResult from Glacier.</returns>
        DeleteVaultAccessPolicyResponse EndDeleteVaultAccessPolicy(IAsyncResult asyncResult);

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
        /// see <a href="http://docs.aws.amazon.com/latest/dev/using-iam-with-amazon-glacier.html">Access
        /// Control Using AWS Identity and Access Management (IAM)</a>.
        /// </para>
        ///  
        /// <para>
        ///  For conceptual information and underlying REST API, go to <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/configuring-notifications.html">Configuring
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
        /// Returned if the specified resource, such as a vault, upload ID, or job ID, does not
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
        /// <param name="request">Container for the necessary parameters to execute the DeleteVaultNotifications operation on AmazonGlacierClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVaultNotifications
        ///         operation.</returns>
        IAsyncResult BeginDeleteVaultNotifications(DeleteVaultNotificationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVaultNotifications operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVaultNotifications.</param>
        /// 
        /// <returns>Returns a  DeleteVaultNotificationsResult from Glacier.</returns>
        DeleteVaultNotificationsResponse EndDeleteVaultNotifications(IAsyncResult asyncResult);

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
        /// </note> 
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
        ///  For information about the underlying REST API, go to <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/api-describe-job-get.html">Working
        /// with Archives in Amazon Glacier</a> in the <i>Amazon Glacier Developer Guide</i>.
        /// 
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
        /// Returned if the specified resource, such as a vault, upload ID, or job ID, does not
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeJob operation on AmazonGlacierClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeJob
        ///         operation.</returns>
        IAsyncResult BeginDescribeJob(DescribeJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeJob.</param>
        /// 
        /// <returns>Returns a  DescribeJobResult from Glacier.</returns>
        DescribeJobResponse EndDescribeJob(IAsyncResult asyncResult);

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
        /// For conceptual information and underlying REST API, go to <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/retrieving-vault-info.html">Retrieving
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
        /// Returned if the specified resource, such as a vault, upload ID, or job ID, does not
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeVault operation on AmazonGlacierClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeVault
        ///         operation.</returns>
        IAsyncResult BeginDescribeVault(DescribeVaultRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeVault operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeVault.</param>
        /// 
        /// <returns>Returns a  DescribeVaultResult from Glacier.</returns>
        DescribeVaultResponse EndDescribeVault(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the GetDataRetrievalPolicy operation on AmazonGlacierClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDataRetrievalPolicy
        ///         operation.</returns>
        IAsyncResult BeginGetDataRetrievalPolicy(GetDataRetrievalPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDataRetrievalPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDataRetrievalPolicy.</param>
        /// 
        /// <returns>Returns a  GetDataRetrievalPolicyResult from Glacier.</returns>
        GetDataRetrievalPolicyResponse EndGetDataRetrievalPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  GetJobOutput


        /// <summary>
        /// This operation downloads the output of the job you initiated using <a>InitiateJob</a>.
        /// Depending on the job type you specified when you initiated the job, the output will
        /// be either the content of an archive or a vault inventory.
        /// 
        ///  
        /// <para>
        /// A job ID will not expire for at least 24 hours after Amazon Glacier completes the
        /// job. That is, you can download the job output within the 24 hours period after Amazon
        /// Glacier completes the job.
        /// </para>
        ///  
        /// <para>
        /// If the job output is large, then you can use the <code>Range</code> request header
        /// to retrieve a portion of the output. This allows you to download the entire output
        /// in smaller chunks of bytes. For example, suppose you have 1 GB of job output you want
        /// to download and you decide to download 128 MB chunks of data at a time, which is a
        /// total of eight Get Job Output requests. You use the following process to download
        /// the job output:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Download a 128 MB chunk of output by specifying the appropriate byte range using the
        /// <code>Range</code> header.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Along with the data, the response includes a SHA256 tree hash of the payload. You
        /// compute the checksum of the payload on the client and compare it with the checksum
        /// you received in the response to ensure you received all the expected data.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Repeat steps 1 and 2 for all the eight 128 MB chunks of output data, each time specifying
        /// the appropriate byte range.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// After downloading all the parts of the job output, you have a list of eight checksum
        /// values. Compute the tree hash of these values to find the checksum of the entire output.
        /// Using the <a>DescribeJob</a> API, obtain job information of the job that provided
        /// you the output. The response includes the checksum of the entire archive stored in
        /// Amazon Glacier. You compare this value with the checksum you computed to ensure you
        /// have downloaded the entire archive content with no errors.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// An AWS account has full permission to perform all operations (actions). However, AWS
        /// Identity and Access Management (IAM) users don't have any permissions by default.
        /// You must grant them explicit permission to perform specific actions. For more information,
        /// see <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/using-iam-with-amazon-glacier.html">Access
        /// Control Using AWS Identity and Access Management (IAM)</a>.
        /// </para>
        ///  
        /// <para>
        /// For conceptual information and the underlying REST API, go to <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/vault-inventory.html">Downloading
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
        /// Returned if the specified resource, such as a vault, upload ID, or job ID, does not
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
        /// <param name="request">Container for the necessary parameters to execute the GetJobOutput operation on AmazonGlacierClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetJobOutput
        ///         operation.</returns>
        IAsyncResult BeginGetJobOutput(GetJobOutputRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetJobOutput operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetJobOutput.</param>
        /// 
        /// <returns>Returns a  GetJobOutputResult from Glacier.</returns>
        GetJobOutputResponse EndGetJobOutput(IAsyncResult asyncResult);

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
        /// Returned if the specified resource, such as a vault, upload ID, or job ID, does not
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
        /// <param name="request">Container for the necessary parameters to execute the GetVaultAccessPolicy operation on AmazonGlacierClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetVaultAccessPolicy
        ///         operation.</returns>
        IAsyncResult BeginGetVaultAccessPolicy(GetVaultAccessPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetVaultAccessPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetVaultAccessPolicy.</param>
        /// 
        /// <returns>Returns a  GetVaultAccessPolicyResult from Glacier.</returns>
        GetVaultAccessPolicyResponse EndGetVaultAccessPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  GetVaultLock


        /// <summary>
        /// This operation retrieves the following attributes from the <code>lock-policy</code>
        /// subresource set on the specified vault: <ul> <li> 
        /// <para>
        /// The vault lock policy set on the vault.
        /// 
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
        /// </para>
        ///  
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
        /// Returned if the specified resource, such as a vault, upload ID, or job ID, does not
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
        /// <param name="request">Container for the necessary parameters to execute the GetVaultLock operation on AmazonGlacierClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetVaultLock
        ///         operation.</returns>
        IAsyncResult BeginGetVaultLock(GetVaultLockRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetVaultLock operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetVaultLock.</param>
        /// 
        /// <returns>Returns a  GetVaultLockResult from Glacier.</returns>
        GetVaultLockResponse EndGetVaultLock(IAsyncResult asyncResult);

        #endregion
        
        #region  GetVaultNotifications


        /// <summary>
        /// This operation retrieves the <code class="code">notification-configuration</code>
        /// subresource of the specified vault.
        /// 
        ///  
        /// <para>
        /// For information about setting a notification configuration on a vault, see <a>SetVaultNotifications</a>.
        /// If a notification configuration for a vault is not set, the operation returns a <code
        /// class="code">404 Not Found</code> error. For more information about vault notifications,
        /// see <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/configuring-notifications.html">Configuring
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
        /// For conceptual information and underlying REST API, go to <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/configuring-notifications.html">Configuring
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
        /// Returned if the specified resource, such as a vault, upload ID, or job ID, does not
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
        /// <param name="request">Container for the necessary parameters to execute the GetVaultNotifications operation on AmazonGlacierClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetVaultNotifications
        ///         operation.</returns>
        IAsyncResult BeginGetVaultNotifications(GetVaultNotificationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetVaultNotifications operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetVaultNotifications.</param>
        /// 
        /// <returns>Returns a  GetVaultNotificationsResult from Glacier.</returns>
        GetVaultNotificationsResponse EndGetVaultNotifications(IAsyncResult asyncResult);

        #endregion
        
        #region  InitiateJob


        /// <summary>
        /// This operation initiates a job of the specified type. In this release, you can initiate
        /// a job to retrieve either an archive or a vault inventory (a list of archives in a
        /// vault). 
        /// 
        ///  
        /// <para>
        /// Retrieving data from Amazon Glacier is a two-step process: 
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Initiate a retrieval job.
        /// </para>
        ///  <note>
        /// <para>
        /// A data retrieval policy can cause your initiate retrieval job request to fail with
        /// a PolicyEnforcedException exception. For more information about data retrieval policies,
        /// see <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/data-retrieval-policy.html">Amazon
        /// Glacier Data Retrieval Policies</a>. For more information about the PolicyEnforcedException
        /// exception, see <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/api-error-responses.html">Error
        /// Responses</a>.
        /// </para>
        ///  </note> </li> <li>
        /// <para>
        /// After the job completes, download the bytes.
        /// </para>
        /// </li> </ol> 
        /// <para>
        /// The retrieval request is executed asynchronously. When you initiate a retrieval job,
        /// Amazon Glacier creates a job and returns a job ID in the response. When Amazon Glacier
        /// completes the job, you can get the job output (archive or inventory data). For information
        /// about getting job output, see <a>GetJobOutput</a> operation. 
        /// </para>
        ///  
        /// <para>
        /// The job must complete before you can get its output. To determine when a job is complete,
        /// you have the following options:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// <b>Use Amazon SNS Notification</b> You can specify an Amazon Simple Notification Service
        /// (Amazon SNS) topic to which Amazon Glacier can post a notification after the job is
        /// completed. You can specify an SNS topic per job request. The notification is sent
        /// only after Amazon Glacier completes the job. In addition to specifying an SNS topic
        /// per job request, you can configure vault notifications for a vault so that job notifications
        /// are always sent. For more information, see <a>SetVaultNotifications</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <b>Get job details</b> You can make a <a>DescribeJob</a> request to obtain job status
        /// information while a job is in progress. However, it is more efficient to use an Amazon
        /// SNS notification to determine when a job is complete.
        /// </para>
        ///  </li> </ul> <note>
        /// <para>
        /// The information you get via notification is same that you get by calling <a>DescribeJob</a>.
        /// </para>
        /// </note> 
        /// <para>
        /// If for a specific event, you add both the notification configuration on the vault
        /// and also specify an SNS topic in your initiate job request, Amazon Glacier sends both
        /// notifications. For more information, see <a>SetVaultNotifications</a>.
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
        /// <b>About the Vault Inventory</b>
        /// </para>
        ///  
        /// <para>
        /// Amazon Glacier prepares an inventory for each vault periodically, every 24 hours.
        /// When you initiate a job for a vault inventory, Amazon Glacier returns the last inventory
        /// for the vault. The inventory data you get might be up to a day or two days old. Also,
        /// the initiate inventory job might take some time to complete before you can download
        /// the vault inventory. So you do not want to retrieve a vault inventory for each vault
        /// operation. However, in some scenarios, you might find the vault inventory useful.
        /// For example, when you upload an archive, you can provide an archive description but
        /// not an archive name. Amazon Glacier provides you a unique archive ID, an opaque string
        /// of characters. So, you might maintain your own database that maps archive names to
        /// their corresponding Amazon Glacier assigned archive IDs. You might find the vault
        /// inventory useful in the event you need to reconcile information in your database with
        /// the actual vault inventory. 
        /// </para>
        ///  
        /// <para>
        /// <b>Range Inventory Retrieval</b>
        /// </para>
        ///  
        /// <para>
        /// You can limit the number of inventory items retrieved by filtering on the archive
        /// creation date or by setting a limit.
        /// </para>
        ///  
        /// <para>
        /// <i>Filtering by Archive Creation Date</i>
        /// </para>
        ///  
        /// <para>
        /// You can retrieve inventory items for archives created between <code>StartDate</code>
        /// and <code>EndDate</code> by specifying values for these parameters in the <b>InitiateJob</b>
        /// request. Archives created on or after the <code>StartDate</code> and before the <code>EndDate</code>
        /// will be returned. If you only provide the <code>StartDate</code> without the <code>EndDate</code>,
        /// you will retrieve the inventory for all archives created on or after the <code>StartDate</code>.
        /// If you only provide the <code>EndDate</code> without the <code>StartDate</code>, you
        /// will get back the inventory for all archives created before the <code>EndDate</code>.
        /// </para>
        ///  
        /// <para>
        /// <i>Limiting Inventory Items per Retrieval</i>
        /// </para>
        ///  
        /// <para>
        /// You can limit the number of inventory items returned by setting the <code>Limit</code>
        /// parameter in the <b>InitiateJob</b> request. The inventory job output will contain
        /// inventory items up to the specified <code>Limit</code>. If there are more inventory
        /// items available, the result is paginated. After a job is complete you can use the
        /// <a>DescribeJob</a> operation to get a marker that you use in a subsequent <b>InitiateJob</b>
        /// request. The marker will indicate the starting point to retrieve the next set of inventory
        /// items. You can page through your entire inventory by repeatedly making <b>InitiateJob</b>
        /// requests with the marker from the previous <b>DescribeJob</b> output, until you get
        /// a marker from <b>DescribeJob</b> that returns null, indicating that there are no more
        /// inventory items available.
        /// </para>
        ///  
        /// <para>
        /// You can use the <code>Limit</code> parameter together with the date range parameters.
        /// </para>
        ///  
        /// <para>
        /// <b>About Ranged Archive Retrieval</b>
        /// </para>
        ///  
        /// <para>
        ///  You can initiate an archive retrieval for the whole archive or a range of the archive.
        /// In the case of ranged archive retrieval, you specify a byte range to return or the
        /// whole archive. The range specified must be megabyte (MB) aligned, that is the range
        /// start value must be divisible by 1 MB and range end value plus 1 must be divisible
        /// by 1 MB or equal the end of the archive. If the ranged archive retrieval is not megabyte
        /// aligned, this operation returns a 400 response. Furthermore, to ensure you get checksum
        /// values for data you download using Get Job Output API, the range must be tree hash
        /// aligned. 
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
        /// For conceptual information and the underlying REST API, go to <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/api-initiate-job-post.html">Initiate
        /// a Job</a> and <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/vault-inventory.html">Downloading
        /// a Vault Inventory</a> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InitiateJob service method.</param>
        /// 
        /// <returns>The response from the InitiateJob service method, as returned by Glacier.</returns>
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
        /// Returned if the specified resource, such as a vault, upload ID, or job ID, does not
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
        /// <param name="request">Container for the necessary parameters to execute the InitiateJob operation on AmazonGlacierClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndInitiateJob
        ///         operation.</returns>
        IAsyncResult BeginInitiateJob(InitiateJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  InitiateJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginInitiateJob.</param>
        /// 
        /// <returns>Returns a  InitiateJobResult from Glacier.</returns>
        InitiateJobResponse EndInitiateJob(IAsyncResult asyncResult);

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
        /// </note> 
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
        /// For conceptual information and underlying REST API, go to <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/uploading-archive-mpu.html">Uploading
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
        /// Returned if the specified resource, such as a vault, upload ID, or job ID, does not
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
        /// <param name="request">Container for the necessary parameters to execute the InitiateMultipartUpload operation on AmazonGlacierClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndInitiateMultipartUpload
        ///         operation.</returns>
        IAsyncResult BeginInitiateMultipartUpload(InitiateMultipartUploadRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  InitiateMultipartUpload operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginInitiateMultipartUpload.</param>
        /// 
        /// <returns>Returns a  InitiateMultipartUploadResult from Glacier.</returns>
        InitiateMultipartUploadResponse EndInitiateMultipartUpload(IAsyncResult asyncResult);

        #endregion
        
        #region  InitiateVaultLock


        /// <summary>
        /// This operation initiates the vault locking process by doing the following: <ul> <li>
        /// 
        /// <para>
        /// Installing a vault lock policy on the specified vault.
        /// 
        ///  </li> <li> 
        /// <para>
        /// Setting the lock state of vault lock to <code>InProgress</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Returning a lock ID, which is used to complete the vault locking process. 
        /// </para>
        ///  </li> </ul> 
        /// </para>
        ///  
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
        /// Returned if the specified resource, such as a vault, upload ID, or job ID, does not
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
        /// <param name="request">Container for the necessary parameters to execute the InitiateVaultLock operation on AmazonGlacierClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndInitiateVaultLock
        ///         operation.</returns>
        IAsyncResult BeginInitiateVaultLock(InitiateVaultLockRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  InitiateVaultLock operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginInitiateVaultLock.</param>
        /// 
        /// <returns>Returns a  InitiateVaultLockResult from Glacier.</returns>
        InitiateVaultLockResponse EndInitiateVaultLock(IAsyncResult asyncResult);

        #endregion
        
        #region  ListJobs


        /// <summary>
        /// This operation lists jobs for a vault, including jobs that are in-progress and jobs
        /// that have recently finished. 
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
        /// </note> 
        /// <para>
        /// To retrieve an archive or retrieve a vault inventory from Amazon Glacier, you first
        /// initiate a job, and after the job completes, you download the data. For an archive
        /// retrieval, the output is the archive data, and for an inventory retrieval, it is the
        /// inventory list. The List Job operation returns a list of these jobs sorted by job
        /// initiation time.
        /// </para>
        ///  
        /// <para>
        /// This List Jobs operation supports pagination. By default, this operation returns up
        /// to 1,000 jobs in the response. You should always check the response for a <code>marker</code>
        /// at which to continue the list; if there are no more items the <code>marker</code>
        /// is <code>null</code>. To return a list of jobs that begins at a specific job, set
        /// the <code>marker</code> request parameter to the value you obtained from a previous
        /// List Jobs request. You can also limit the number of jobs returned in the response
        /// by specifying the <code>limit</code> parameter in the request.
        /// </para>
        ///  
        /// <para>
        /// Additionally, you can filter the jobs list returned by specifying an optional <code>statuscode</code>
        /// (InProgress, Succeeded, or Failed) and <code>completed</code> (true, false) parameter.
        /// The <code>statuscode</code> allows you to specify that only jobs that match a specified
        /// status are returned. The <code>completed</code> parameter allows you to specify that
        /// only jobs in a specific completion state are returned.
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
        /// For the underlying REST API, go to <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/api-jobs-get.html">List
        /// Jobs </a> 
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
        /// Returned if the specified resource, such as a vault, upload ID, or job ID, does not
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
        /// <param name="request">Container for the necessary parameters to execute the ListJobs operation on AmazonGlacierClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListJobs
        ///         operation.</returns>
        IAsyncResult BeginListJobs(ListJobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListJobs.</param>
        /// 
        /// <returns>Returns a  ListJobsResult from Glacier.</returns>
        ListJobsResponse EndListJobs(IAsyncResult asyncResult);

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
        /// For conceptual information and the underlying REST API, go to <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/working-with-archives.html">Working
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
        /// Returned if the specified resource, such as a vault, upload ID, or job ID, does not
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
        /// <param name="request">Container for the necessary parameters to execute the ListMultipartUploads operation on AmazonGlacierClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMultipartUploads
        ///         operation.</returns>
        IAsyncResult BeginListMultipartUploads(ListMultipartUploadsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListMultipartUploads operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMultipartUploads.</param>
        /// 
        /// <returns>Returns a  ListMultipartUploadsResult from Glacier.</returns>
        ListMultipartUploadsResponse EndListMultipartUploads(IAsyncResult asyncResult);

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
        /// a <code class="code">marker</code> at which to continue the list; if there are no
        /// more items the <code class="code">marker</code> is <code class="code">null</code>.
        /// To return a list of parts that begins at a specific part, set the <code>marker</code>
        /// request parameter to the value you obtained from a previous List Parts request. You
        /// can also limit the number of parts returned in the response by specifying the <code>limit</code>
        /// parameter in the request. 
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
        /// For conceptual information and the underlying REST API, go to <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/working-with-archives.html">Working
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
        /// Returned if the specified resource, such as a vault, upload ID, or job ID, does not
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
        /// <param name="request">Container for the necessary parameters to execute the ListParts operation on AmazonGlacierClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListParts
        ///         operation.</returns>
        IAsyncResult BeginListParts(ListPartsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListParts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListParts.</param>
        /// 
        /// <returns>Returns a  ListPartsResult from Glacier.</returns>
        ListPartsResponse EndListParts(IAsyncResult asyncResult);

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
        /// Returned if the specified resource, such as a vault, upload ID, or job ID, does not
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
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForVault operation on AmazonGlacierClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForVault
        ///         operation.</returns>
        IAsyncResult BeginListTagsForVault(ListTagsForVaultRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForVault operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForVault.</param>
        /// 
        /// <returns>Returns a  ListTagsForVaultResult from Glacier.</returns>
        ListTagsForVaultResponse EndListTagsForVault(IAsyncResult asyncResult);

        #endregion
        
        #region  ListVaults


        /// <summary>
        /// This operation lists all vaults owned by the calling user's account. The list returned
        /// in the response is ASCII-sorted by vault name. 
        /// 
        ///  
        /// <para>
        /// By default, this operation returns up to 1,000 items. If there are more vaults to
        /// list, the response <code class="code">marker</code> field contains the vault Amazon
        /// Resource Name (ARN) at which to continue the list with a new List Vaults request;
        /// otherwise, the <code class="code">marker</code> field is <code class="code">null</code>.
        /// To return a list of vaults that begins at a specific vault, set the <code class="code">marker</code>
        /// request parameter to the vault ARN you obtained from a previous List Vaults request.
        /// You can also limit the number of vaults returned in the response by specifying the
        /// <code class="code">limit</code> parameter in the request. 
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
        /// For conceptual information and underlying REST API, go to <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/retrieving-vault-info.html">Retrieving
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
        /// Returned if the specified resource, such as a vault, upload ID, or job ID, does not
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
        /// list, the response <code class="code">marker</code> field contains the vault Amazon
        /// Resource Name (ARN) at which to continue the list with a new List Vaults request;
        /// otherwise, the <code class="code">marker</code> field is <code class="code">null</code>.
        /// To return a list of vaults that begins at a specific vault, set the <code class="code">marker</code>
        /// request parameter to the vault ARN you obtained from a previous List Vaults request.
        /// You can also limit the number of vaults returned in the response by specifying the
        /// <code class="code">limit</code> parameter in the request. 
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
        /// For conceptual information and underlying REST API, go to <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/retrieving-vault-info.html">Retrieving
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
        /// Returned if the specified resource, such as a vault, upload ID, or job ID, does not
        /// exist.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.ServiceUnavailableException">
        /// Returned if the service cannot complete the request.
        /// </exception>
        ListVaultsResponse ListVaults(ListVaultsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListVaults operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVaults operation on AmazonGlacierClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListVaults
        ///         operation.</returns>
        IAsyncResult BeginListVaults(ListVaultsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListVaults operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListVaults.</param>
        /// 
        /// <returns>Returns a  ListVaultsResult from Glacier.</returns>
        ListVaultsResponse EndListVaults(IAsyncResult asyncResult);

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
        /// Returned if the specified resource, such as a vault, upload ID, or job ID, does not
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
        /// <param name="request">Container for the necessary parameters to execute the RemoveTagsFromVault operation on AmazonGlacierClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRemoveTagsFromVault
        ///         operation.</returns>
        IAsyncResult BeginRemoveTagsFromVault(RemoveTagsFromVaultRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RemoveTagsFromVault operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemoveTagsFromVault.</param>
        /// 
        /// <returns>Returns a  RemoveTagsFromVaultResult from Glacier.</returns>
        RemoveTagsFromVaultResponse EndRemoveTagsFromVault(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the SetDataRetrievalPolicy operation on AmazonGlacierClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSetDataRetrievalPolicy
        ///         operation.</returns>
        IAsyncResult BeginSetDataRetrievalPolicy(SetDataRetrievalPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SetDataRetrievalPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetDataRetrievalPolicy.</param>
        /// 
        /// <returns>Returns a  SetDataRetrievalPolicyResult from Glacier.</returns>
        SetDataRetrievalPolicyResponse EndSetDataRetrievalPolicy(IAsyncResult asyncResult);

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
        /// Returned if the specified resource, such as a vault, upload ID, or job ID, does not
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
        /// <param name="request">Container for the necessary parameters to execute the SetVaultAccessPolicy operation on AmazonGlacierClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSetVaultAccessPolicy
        ///         operation.</returns>
        IAsyncResult BeginSetVaultAccessPolicy(SetVaultAccessPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SetVaultAccessPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetVaultAccessPolicy.</param>
        /// 
        /// <returns>Returns a  SetVaultAccessPolicyResult from Glacier.</returns>
        SetVaultAccessPolicyResponse EndSetVaultAccessPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  SetVaultNotifications


        /// <summary>
        /// This operation configures notifications that will be sent when specific events happen
        /// to a vault. By default, you don't get any notifications. 
        /// 
        ///  
        /// <para>
        /// To configure vault notifications, send a PUT request to the <code class="code">notification-configuration</code>
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
        ///  <ul> <li> <b>ArchiveRetrievalCompleted</b> This event occurs when a job that was
        /// initiated for an archive retrieval is completed (<a>InitiateJob</a>). The status of
        /// the completed job can be "Succeeded" or "Failed". The notification sent to the SNS
        /// topic is the same output as returned from <a>DescribeJob</a>. </li> <li> <b>InventoryRetrievalCompleted</b>
        /// This event occurs when a job that was initiated for an inventory retrieval is completed
        /// (<a>InitiateJob</a>). The status of the completed job can be "Succeeded" or "Failed".
        /// The notification sent to the SNS topic is the same output as returned from <a>DescribeJob</a>.
        /// </li> </ul> 
        /// <para>
        /// An AWS account has full permission to perform all operations (actions). However, AWS
        /// Identity and Access Management (IAM) users don't have any permissions by default.
        /// You must grant them explicit permission to perform specific actions. For more information,
        /// see <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/using-iam-with-amazon-glacier.html">Access
        /// Control Using AWS Identity and Access Management (IAM)</a>.
        /// </para>
        ///  
        /// <para>
        /// For conceptual information and underlying REST API, go to <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/configuring-notifications.html">Configuring
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
        /// Returned if the specified resource, such as a vault, upload ID, or job ID, does not
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
        /// <param name="request">Container for the necessary parameters to execute the SetVaultNotifications operation on AmazonGlacierClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSetVaultNotifications
        ///         operation.</returns>
        IAsyncResult BeginSetVaultNotifications(SetVaultNotificationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SetVaultNotifications operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetVaultNotifications.</param>
        /// 
        /// <returns>Returns a  SetVaultNotificationsResult from Glacier.</returns>
        SetVaultNotificationsResponse EndSetVaultNotifications(IAsyncResult asyncResult);

        #endregion
        
        #region  UploadArchive


        /// <summary>
        /// This operation adds an archive to a vault. This is a synchronous operation, and for
        /// a successful upload, your data is durably persisted. Amazon Glacier returns the archive
        /// ID in the <code class="code">x-amz-archive-id</code> header of the response. 
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
        ///  For conceptual information and underlying REST API, go to <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/uploading-an-archive.html">Uploading
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
        /// Returned if the specified resource, such as a vault, upload ID, or job ID, does not
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
        /// <param name="request">Container for the necessary parameters to execute the UploadArchive operation on AmazonGlacierClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUploadArchive
        ///         operation.</returns>
        IAsyncResult BeginUploadArchive(UploadArchiveRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UploadArchive operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUploadArchive.</param>
        /// 
        /// <returns>Returns a  UploadArchiveResult from Glacier.</returns>
        UploadArchiveResponse EndUploadArchive(IAsyncResult asyncResult);

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
        /// <b>SHA256 tree hash does not match</b>To ensure that part data is not corrupted in
        /// transmission, you compute a SHA256 tree hash of the part and include it in your request.
        /// Upon receiving the part data, Amazon Glacier also computes a SHA256 tree hash. If
        /// these hash values don't match, the operation fails. For information about computing
        /// a SHA256 tree hash, see <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/checksum-calculations.html">Computing
        /// Checksums</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <b>Part size does not match</b>The size of each part except the last must match the
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
        /// </note> </li> <li> <b>Range does not align</b>The byte range value in the request
        /// does not align with the part size specified in the corresponding initiate request.
        /// For example, if you specify a part size of 4194304 bytes (4 MB), then 0 to 4194303
        /// bytes (4 MB - 1) and 4194304 (4 MB) to 8388607 (8 MB - 1) are valid part ranges. However,
        /// if you set a range value of 2 MB to 6 MB, the range does not align with the part size
        /// and the upload will fail. </li> </ul> 
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
        ///  For conceptual information and underlying REST API, go to <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/uploading-archive-mpu.html">Uploading
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
        /// Returned if the specified resource, such as a vault, upload ID, or job ID, does not
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
        /// <param name="request">Container for the necessary parameters to execute the UploadMultipartPart operation on AmazonGlacierClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUploadMultipartPart
        ///         operation.</returns>
        IAsyncResult BeginUploadMultipartPart(UploadMultipartPartRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UploadMultipartPart operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUploadMultipartPart.</param>
        /// 
        /// <returns>Returns a  UploadMultipartPartResult from Glacier.</returns>
        UploadMultipartPartResponse EndUploadMultipartPart(IAsyncResult asyncResult);

        #endregion
        
    }
}