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
using System.IO;
using System.Collections.Generic;
using Amazon.Glacier.Model;

namespace Amazon.Glacier.Resources
{

    #region IAccount

    /// <summary>
    /// This interface represents the Account resource.
    /// </summary>
    public interface IAccount
    {
        /// <summary>
        /// Gets the value of the Id identifier for this resource. 
        /// </summary>        
        string Id { get; }


        #region Actions

        /// <summary>
        /// Calls the CreateVault operation on the Account resource.
        /// </summary>
        /// <para>
        /// This method internally calls the CreateVault operation on the service.
        /// </para>
        /// <param name="request">Container for the necessary parameters to execute the CreateVault operation.</param>
        /// <returns>An instance of Vault resource.</returns>
        IVault CreateVault(CreateVaultRequest request);

        /// <summary>
        /// Calls the CreateVault operation on the Account resource.
        /// </summary>
        /// <para>
        /// This method internally calls the CreateVault operation on the service.
        /// </para>
        /// <returns>An instance of Vault resource.</returns>
        /// <param name="accountId">The <code>AccountId</code> is the AWS Account ID. You can specify either the AWS Account ID or optionally a '-', in which case Amazon Glacier uses the AWS Account ID associated with the credentials used to sign the request. If you specify your Account ID, do not include hyphens in it. </param>
        /// <param name="vaultName">The name of the vault.</param>
        IVault CreateVault(string accountId, string vaultName);


        #endregion

        #region Enumerable collections

        /// <summary>
        /// Gets the Vaults associated with this Account.        
        /// <para>
        /// NOTE : This method calls a service operation that supports paging. Enumerating through the
        /// result of this method can potentially make multiple service operation calls.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVaultsEnumerator operation.</param>
        /// <returns>Returns an enumerable collection of Vaults.</returns>
        IEnumerable<IVault> GetVaults(ListVaultsRequest request);

        /// <summary>
        /// Gets the Vaults associated with this Account.        
        /// <para>
        /// NOTE : This method calls a service operation that supports paging. Enumerating through the
        /// result of this method can potentially make multiple service operation calls.
        /// </para>
        /// </summary>
        /// <returns>Returns an enumerable collection of Vaults.</returns>
        IEnumerable<IVault> GetVaults();


        #endregion

        #region Subresources

        /// <summary>
        /// Gets a Vault associated with this Account resource using its identifier.
        /// <para>
        /// This method does not make a service call, it returns a resource instance
        /// only with its identifier properties initialized. Accessing any non-identifier 
        /// properties or operations on the resource that in turn access any non-identifier 
        /// properties will cause the resource to make a service call to load its data.
        /// </para>
        /// <para>
        /// NOTE : This method does not make a service call when the resource is initally
        /// constructed. If you pass invalid identifiers to this method, it will return a resource
        /// that may not exist on the server. In this case an exception will be thrown when 
        /// the resource tries to load itself due to conditions listed in the previous section.
        /// </para>
        /// </summary>
        /// <param name="name">The name of the Vault.</param>
        /// <returns>Returns an instance of Vault.</returns>
        IVault GetVaultByName(string name);


        #endregion
    }    
    #endregion

    #region IArchive

    /// <summary>
    /// This interface represents the Archive resource.
    /// </summary>
    public interface IArchive
    {
        /// <summary>
        /// Gets the value of the AccountId identifier for this resource. 
        /// </summary>        
        string AccountId { get; }

        /// <summary>
        /// Gets the value of the VaultName identifier for this resource. 
        /// </summary>        
        string VaultName { get; }

        /// <summary>
        /// Gets the value of the Id identifier for this resource. 
        /// </summary>        
        string Id { get; }


        #region Actions

        /// <summary>
        /// Calls the Delete operation on the Archive resource.
        /// </summary>
        /// <para>
        /// This method internally calls the DeleteArchive operation on the service.
        /// </para>
        /// <param name="request">Container for the necessary parameters to execute the DeleteArchive operation.</param>
        void Delete(DeleteArchiveRequest request);

        /// <summary>
        /// Calls the Delete operation on the Archive resource.
        /// </summary>
        /// <para>
        /// This method internally calls the DeleteArchive operation on the service.
        /// </para>
        void Delete();

        /// <summary>
        /// Calls the InitiateArchiveRetreival operation on the Archive resource.
        /// </summary>
        /// <para>
        /// This method internally calls the InitiateJob operation on the service.
        /// </para>
        /// <param name="request">Container for the necessary parameters to execute the InitiateJob operation.</param>
        /// <returns>An instance of Job resource.</returns>
        IJob InitiateArchiveRetreival(InitiateJobRequest request);

        /// <summary>
        /// Calls the InitiateArchiveRetreival operation on the Archive resource.
        /// </summary>
        /// <para>
        /// This method internally calls the InitiateJob operation on the service.
        /// </para>
        /// <returns>An instance of Job resource.</returns>
        /// <param name="jobParameters">Provides options for specifying job information.</param>
        IJob InitiateArchiveRetreival(JobParameters jobParameters);


        #endregion

    }    
    #endregion

    #region IJob

    /// <summary>
    /// This interface represents the Job resource.
    /// </summary>
    public interface IJob
    {
        /// <summary>
        /// Gets the value of the AccountId identifier for this resource. 
        /// </summary>        
        string AccountId { get; }

        /// <summary>
        /// Gets the value of the VaultName identifier for this resource. 
        /// </summary>        
        string VaultName { get; }

        /// <summary>
        /// Gets the value of the Id identifier for this resource. 
        /// </summary>        
        string Id { get; }

        /// <summary>
        /// Gets the value of the property Action. 
        /// <para>
        /// The job type. It is either ArchiveRetrieval or InventoryRetrieval.
        /// </para>
        /// </summary>
        ActionCode Action { get; }

        /// <summary>
        /// Gets the value of the property ArchiveId. 
        /// <para>
        /// For an ArchiveRetrieval job, this is the archive ID requested for download. Otherwise,
        /// this field is null.
        /// </para>
        /// </summary>
        string ArchiveId { get; }

        /// <summary>
        /// Gets the value of the property ArchiveSHA256TreeHash. 
        /// <para>
        /// The SHA256 tree hash of the entire archive for an archive retrieval. For inventory
        /// retrieval jobs, this field is null. 
        /// </para>
        /// </summary>
        string ArchiveSHA256TreeHash { get; }

        /// <summary>
        /// Gets the value of the property ArchiveSizeInBytes. 
        /// <para>
        /// For an ArchiveRetrieval job, this is the size in bytes of the archive being requested
        /// for download. For the InventoryRetrieval job, the value is null.
        /// </para>
        /// </summary>
        long ArchiveSizeInBytes { get; }

        /// <summary>
        /// Gets the value of the property Completed. 
        /// <para>
        /// The job status. When a job is completed, you get the job's output.
        /// </para>
        /// </summary>
        bool Completed { get; }

        /// <summary>
        /// Gets the value of the property CompletionDate. 
        /// <para>
        /// The UTC time that the archive retrieval request completed. While the job is in progress,
        /// the value will be null.
        /// </para>
        /// </summary>
        DateTime CompletionDate { get; }

        /// <summary>
        /// Gets the value of the property CreationDate. 
        /// <para>
        /// The UTC date when the job was created. A string representation of ISO 8601 date format,
        /// for example, "2012-03-20T17:03:43.221Z".
        /// </para>
        /// </summary>
        DateTime CreationDate { get; }

        /// <summary>
        /// Gets the value of the property InventoryRetrievalParameters. 
        /// <para>
        /// Parameters used for range inventory retrieval.
        /// </para>
        /// </summary>
        InventoryRetrievalJobDescription InventoryRetrievalParameters { get; }

        /// <summary>
        /// Gets the value of the property InventorySizeInBytes. 
        /// <para>
        /// For an InventoryRetrieval job, this is the size in bytes of the inventory requested
        /// for download. For the ArchiveRetrieval job, the value is null.
        /// </para>
        /// </summary>
        long InventorySizeInBytes { get; }

        /// <summary>
        /// Gets the value of the property JobDescription. 
        /// <para>
        /// The job description you provided when you initiated the job.
        /// </para>
        /// </summary>
        string JobDescription { get; }

        /// <summary>
        /// Gets the value of the property RetrievalByteRange. 
        /// <para>
        /// The retrieved byte range for archive retrieval jobs in the form "<i>StartByteValue</i>-<i>EndByteValue</i>"
        /// If no range was specified in the archive retrieval, then the whole archive is retrieved
        /// and <i>StartByteValue</i> equals 0 and <i>EndByteValue</i> equals the size of the
        /// archive minus 1. For inventory retrieval jobs this field is null. 
        /// </para>
        /// </summary>
        string RetrievalByteRange { get; }

        /// <summary>
        /// Gets the value of the property SHA256TreeHash. 
        /// <para>
        /// For an ArchiveRetrieval job, it is the checksum of the archive. Otherwise, the value
        /// is null.
        /// </para>
        ///  
        /// <para>
        ///  The SHA256 tree hash value for the requested range of an archive. If the Initiate
        /// a Job request for an archive specified a tree-hash aligned range, then this field
        /// returns a value. 
        /// </para>
        ///  
        /// <para>
        ///  For the specific case when the whole archive is retrieved, this value is the same
        /// as the ArchiveSHA256TreeHash value. 
        /// </para>
        ///  
        /// <para>
        ///  This field is null in the following situations: <ul> <li>
        /// <para>
        /// Archive retrieval jobs that specify a range that is not tree-hash aligned.
        /// </para>
        /// </li> </ul> <ul> <li>
        /// <para>
        /// Archival jobs that specify a range that is equal to the whole archive and the job
        /// status is InProgress.
        /// </para>
        /// </li> </ul> <ul> <li>
        /// <para>
        /// Inventory jobs.
        /// </para>
        /// </li> </ul> 
        /// </para>
        /// </summary>
        string SHA256TreeHash { get; }

        /// <summary>
        /// Gets the value of the property SNSTopic. 
        /// <para>
        /// An Amazon Simple Notification Service (Amazon SNS) topic that receives notification.
        /// </para>
        /// </summary>
        string SNSTopic { get; }

        /// <summary>
        /// Gets the value of the property StatusCode. 
        /// <para>
        /// The status code can be InProgress, Succeeded, or Failed, and indicates the status
        /// of the job.
        /// </para>
        /// </summary>
        StatusCode StatusCode { get; }

        /// <summary>
        /// Gets the value of the property StatusMessage. 
        /// <para>
        /// A friendly message that describes the job status.
        /// </para>
        /// </summary>
        string StatusMessage { get; }

        /// <summary>
        /// Gets the value of the property VaultARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the vault from which the archive retrieval was requested.
        /// </para>
        /// </summary>
        string VaultARN { get; }


        #region Actions

        /// <summary>
        /// Calls the GetOutput operation on the Job resource.
        /// </summary>
        /// <para>
        /// This method internally calls the GetJobOutput operation on the service.
        /// </para>
        /// <param name="request">Container for the necessary parameters to execute the GetJobOutput operation.</param>
        /// <returns>An instance of  resource.</returns>
        GetJobOutputResponse GetOutput(GetJobOutputRequest request);

        /// <summary>
        /// Calls the GetOutput operation on the Job resource.
        /// </summary>
        /// <para>
        /// This method internally calls the GetJobOutput operation on the service.
        /// </para>
        /// <returns>An instance of  resource.</returns>
        GetJobOutputResponse GetOutput();


        #endregion

    }    
    #endregion

    #region IMultipartUpload

    /// <summary>
    /// This interface represents the MultipartUpload resource.
    /// </summary>
    public interface IMultipartUpload
    {
        /// <summary>
        /// Gets the value of the AccountId identifier for this resource. 
        /// </summary>        
        string AccountId { get; }

        /// <summary>
        /// Gets the value of the VaultName identifier for this resource. 
        /// </summary>        
        string VaultName { get; }

        /// <summary>
        /// Gets the value of the Id identifier for this resource. 
        /// </summary>        
        string Id { get; }

        /// <summary>
        /// Gets the value of the property ArchiveDescription. 
        /// <para>
        /// The description of the archive that was specified in the Initiate Multipart Upload
        /// request.
        /// </para>
        /// </summary>
        string ArchiveDescription { get; }

        /// <summary>
        /// Gets the value of the property CreationDate. 
        /// <para>
        /// The UTC time at which the multipart upload was initiated.
        /// </para>
        /// </summary>
        DateTime CreationDate { get; }

        /// <summary>
        /// Gets the value of the property PartSizeInBytes. 
        /// <para>
        /// The part size, in bytes, specified in the Initiate Multipart Upload request. This
        /// is the size of all the parts in the upload except the last part, which may be smaller
        /// than this size.
        /// </para>
        /// </summary>
        long PartSizeInBytes { get; }

        /// <summary>
        /// Gets the value of the property VaultARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the vault that contains the archive.
        /// </para>
        /// </summary>
        string VaultARN { get; }


        #region Actions

        /// <summary>
        /// Calls the Abort operation on the MultipartUpload resource.
        /// </summary>
        /// <para>
        /// This method internally calls the AbortMultipartUpload operation on the service.
        /// </para>
        /// <param name="request">Container for the necessary parameters to execute the AbortMultipartUpload operation.</param>
        void Abort(AbortMultipartUploadRequest request);

        /// <summary>
        /// Calls the Abort operation on the MultipartUpload resource.
        /// </summary>
        /// <para>
        /// This method internally calls the AbortMultipartUpload operation on the service.
        /// </para>
        void Abort();

        /// <summary>
        /// Calls the Complete operation on the MultipartUpload resource.
        /// </summary>
        /// <para>
        /// This method internally calls the CompleteMultipartUpload operation on the service.
        /// </para>
        /// <param name="request">Container for the necessary parameters to execute the CompleteMultipartUpload operation.</param>
        /// <returns>An instance of  resource.</returns>
        CompleteMultipartUploadResponse Complete(CompleteMultipartUploadRequest request);

        /// <summary>
        /// Calls the Complete operation on the MultipartUpload resource.
        /// </summary>
        /// <para>
        /// This method internally calls the CompleteMultipartUpload operation on the service.
        /// </para>
        /// <returns>An instance of  resource.</returns>
        /// <param name="archiveSize">The total size, in bytes, of the entire archive. This value should be the sum of all the sizes of the individual parts that you uploaded.</param>
        /// <param name="checksum">The SHA256 tree hash of the entire archive. It is the tree hash of SHA256 tree hash of the individual parts. If the value you specify in the request does not match the SHA256 tree hash of the final assembled archive as computed by Amazon Glacier, Amazon Glacier returns an error and the request fails.</param>
        CompleteMultipartUploadResponse Complete(string archiveSize, string checksum);

        /// <summary>
        /// Calls the UploadPart operation on the MultipartUpload resource.
        /// </summary>
        /// <para>
        /// This method internally calls the UploadMultipartPart operation on the service.
        /// </para>
        /// <param name="request">Container for the necessary parameters to execute the UploadMultipartPart operation.</param>
        /// <returns>An instance of  resource.</returns>
        UploadMultipartPartResponse UploadPart(UploadMultipartPartRequest request);

        /// <summary>
        /// Calls the UploadPart operation on the MultipartUpload resource.
        /// </summary>
        /// <para>
        /// This method internally calls the UploadMultipartPart operation on the service.
        /// </para>
        /// <returns>An instance of  resource.</returns>
        /// <param name="body">The data to upload.</param>
        /// <param name="checksum">The SHA256 tree hash of the data being uploaded. </param>
        /// <param name="range">Identifies the range of bytes in the assembled archive that will be uploaded in this part. Amazon Glacier uses this information to assemble the archive in the proper sequence. The format of this header follows RFC 2616. An example header is Content-Range:bytes 0-4194303/*.</param>
        UploadMultipartPartResponse UploadPart(System.IO.Stream body, string checksum, string range);


        #endregion

    }    
    #endregion

    #region INotification

    /// <summary>
    /// This interface represents the Notification resource.
    /// </summary>
    public interface INotification
    {
        /// <summary>
        /// Gets the value of the AccountId identifier for this resource. 
        /// </summary>        
        string AccountId { get; }

        /// <summary>
        /// Gets the value of the VaultName identifier for this resource. 
        /// </summary>        
        string VaultName { get; }

        /// <summary>
        /// Gets the value of the property Events. 
        /// <para>
        /// A list of one or more events for which Amazon Glacier will send a notification to
        /// the specified Amazon SNS topic.
        /// </para>
        /// </summary>
        List<string> Events { get; }

        /// <summary>
        /// Gets the value of the property SNSTopic. 
        /// <para>
        /// The Amazon Simple Notification Service (Amazon SNS) topic Amazon Resource Name (ARN).
        /// </para>
        /// </summary>
        string SNSTopic { get; }


        #region Actions

        /// <summary>
        /// Calls the Delete operation on the Notification resource.
        /// </summary>
        /// <para>
        /// This method internally calls the DeleteVaultNotifications operation on the service.
        /// </para>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVaultNotifications operation.</param>
        void Delete(DeleteVaultNotificationsRequest request);

        /// <summary>
        /// Calls the Delete operation on the Notification resource.
        /// </summary>
        /// <para>
        /// This method internally calls the DeleteVaultNotifications operation on the service.
        /// </para>
        void Delete();

        /// <summary>
        /// Calls the Set operation on the Notification resource.
        /// </summary>
        /// <para>
        /// This method internally calls the SetVaultNotifications operation on the service.
        /// </para>
        /// <param name="request">Container for the necessary parameters to execute the SetVaultNotifications operation.</param>
        void Set(SetVaultNotificationsRequest request);

        /// <summary>
        /// Calls the Set operation on the Notification resource.
        /// </summary>
        /// <para>
        /// This method internally calls the SetVaultNotifications operation on the service.
        /// </para>
        /// <param name="vaultNotificationConfig">Provides options for specifying notification configuration.</param>
        void Set(VaultNotificationConfig vaultNotificationConfig);


        #endregion

    }    
    #endregion

    #region IVault

    /// <summary>
    /// This interface represents the Vault resource.
    /// </summary>
    public interface IVault
    {
        /// <summary>
        /// Gets the value of the AccountId identifier for this resource. 
        /// </summary>        
        string AccountId { get; }

        /// <summary>
        /// Gets the value of the Name identifier for this resource. 
        /// </summary>        
        string Name { get; }

        /// <summary>
        /// Gets the value of the property CreationDate. 
        /// <para>
        /// The UTC date when the vault was created. A string representation of ISO 8601 date
        /// format, for example, "2012-03-20T17:03:43.221Z".
        /// </para>
        /// </summary>
        DateTime CreationDate { get; }

        /// <summary>
        /// Gets the value of the property LastInventoryDate. 
        /// <para>
        /// The UTC date when Amazon Glacier completed the last vault inventory. A string representation
        /// of ISO 8601 date format, for example, "2012-03-20T17:03:43.221Z".
        /// </para>
        /// </summary>
        DateTime LastInventoryDate { get; }

        /// <summary>
        /// Gets the value of the property NumberOfArchives. 
        /// <para>
        /// The number of archives in the vault as of the last inventory date. This field will
        /// return <code>null</code> if an inventory has not yet run on the vault, for example,
        /// if you just created the vault.
        /// </para>
        /// </summary>
        long NumberOfArchives { get; }

        /// <summary>
        /// Gets the value of the property SizeInBytes. 
        /// <para>
        /// Total size, in bytes, of the archives in the vault as of the last inventory date.
        /// This field will return null if an inventory has not yet run on the vault, for example,
        /// if you just created the vault.
        /// </para>
        /// </summary>
        long SizeInBytes { get; }

        /// <summary>
        /// Gets the value of the property VaultARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the vault.
        /// </para>
        /// </summary>
        string VaultARN { get; }


        #region Actions

        /// <summary>
        /// Calls the Create operation on the Vault resource.
        /// </summary>
        /// <para>
        /// This method internally calls the CreateVault operation on the service.
        /// </para>
        /// <param name="request">Container for the necessary parameters to execute the CreateVault operation.</param>
        /// <returns>An instance of  resource.</returns>
        CreateVaultResponse Create(CreateVaultRequest request);

        /// <summary>
        /// Calls the Create operation on the Vault resource.
        /// </summary>
        /// <para>
        /// This method internally calls the CreateVault operation on the service.
        /// </para>
        /// <returns>An instance of  resource.</returns>
        CreateVaultResponse Create();

        /// <summary>
        /// Calls the Delete operation on the Vault resource.
        /// </summary>
        /// <para>
        /// This method internally calls the DeleteVault operation on the service.
        /// </para>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVault operation.</param>
        void Delete(DeleteVaultRequest request);

        /// <summary>
        /// Calls the Delete operation on the Vault resource.
        /// </summary>
        /// <para>
        /// This method internally calls the DeleteVault operation on the service.
        /// </para>
        void Delete();

        /// <summary>
        /// Calls the InitiateInventoryRetrieval operation on the Vault resource.
        /// </summary>
        /// <para>
        /// This method internally calls the InitiateJob operation on the service.
        /// </para>
        /// <param name="request">Container for the necessary parameters to execute the InitiateJob operation.</param>
        /// <returns>An instance of Job resource.</returns>
        IJob InitiateInventoryRetrieval(InitiateJobRequest request);

        /// <summary>
        /// Calls the InitiateInventoryRetrieval operation on the Vault resource.
        /// </summary>
        /// <para>
        /// This method internally calls the InitiateJob operation on the service.
        /// </para>
        /// <returns>An instance of Job resource.</returns>
        /// <param name="jobParameters">Provides options for specifying job information.</param>
        IJob InitiateInventoryRetrieval(JobParameters jobParameters);

        /// <summary>
        /// Calls the InitiateMultipartUpload operation on the Vault resource.
        /// </summary>
        /// <para>
        /// This method internally calls the InitiateMultipartUpload operation on the service.
        /// </para>
        /// <param name="request">Container for the necessary parameters to execute the InitiateMultipartUpload operation.</param>
        /// <returns>An instance of MultipartUpload resource.</returns>
        IMultipartUpload InitiateMultipartUpload(InitiateMultipartUploadRequest request);

        /// <summary>
        /// Calls the InitiateMultipartUpload operation on the Vault resource.
        /// </summary>
        /// <para>
        /// This method internally calls the InitiateMultipartUpload operation on the service.
        /// </para>
        /// <returns>An instance of MultipartUpload resource.</returns>
        /// <param name="archiveDescription">The archive description that you are uploading in parts. The part size must be a megabyte (1024 KB) multiplied by a power of 2—for example, 1048576 (1 MB), 2097152 (2 MB), 4194304 (4 MB), 8388608 (8 MB), and so on. The minimum allowable part size is 1 MB, and the maximum is 4 GB (4096 MB).</param>
        IMultipartUpload InitiateMultipartUpload(string archiveDescription);

        /// <summary>
        /// Calls the InitiateMultipartUpload operation on the Vault resource.
        /// </summary>
        /// <para>
        /// This method internally calls the InitiateMultipartUpload operation on the service.
        /// </para>
        /// <returns>An instance of MultipartUpload resource.</returns>
        /// <param name="archiveDescription">The archive description that you are uploading in parts. The part size must be a megabyte (1024 KB) multiplied by a power of 2—for example, 1048576 (1 MB), 2097152 (2 MB), 4194304 (4 MB), 8388608 (8 MB), and so on. The minimum allowable part size is 1 MB, and the maximum is 4 GB (4096 MB).</param>
        /// <param name="partSize">The size of each part except the last, in bytes. The last part can be smaller than this part size.</param>
        IMultipartUpload InitiateMultipartUpload(string archiveDescription, long partSize);

        /// <summary>
        /// Calls the UploadArchive operation on the Vault resource.
        /// </summary>
        /// <para>
        /// This method internally calls the UploadArchive operation on the service.
        /// </para>
        /// <param name="request">Container for the necessary parameters to execute the UploadArchive operation.</param>
        /// <returns>An instance of Archive resource.</returns>
        IArchive UploadArchive(UploadArchiveRequest request);

        /// <summary>
        /// Calls the UploadArchive operation on the Vault resource.
        /// </summary>
        /// <para>
        /// This method internally calls the UploadArchive operation on the service.
        /// </para>
        /// <returns>An instance of Archive resource.</returns>
        /// <param name="body">The data to upload.</param>
        /// <param name="checksum">The SHA256 tree hash of the data being uploaded.</param>
        IArchive UploadArchive(System.IO.Stream body, string checksum);


        #endregion

        #region Enumerable collections

        /// <summary>
        /// Gets the CompletedJobs associated with this Vault.        
        /// <para>
        /// NOTE : This method calls a service operation that supports paging. Enumerating through the
        /// result of this method can potentially make multiple service operation calls.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListJobsEnumerator operation.</param>
        /// <returns>Returns an enumerable collection of CompletedJobs.</returns>
        IEnumerable<IJob> GetCompletedJobs(ListJobsRequest request);

        /// <summary>
        /// Gets the CompletedJobs associated with this Vault.        
        /// <para>
        /// NOTE : This method calls a service operation that supports paging. Enumerating through the
        /// result of this method can potentially make multiple service operation calls.
        /// </para>
        /// </summary>
        /// <returns>Returns an enumerable collection of CompletedJobs.</returns>
        IEnumerable<IJob> GetCompletedJobs();

        /// <summary>
        /// Gets the FailedJobs associated with this Vault.        
        /// <para>
        /// NOTE : This method calls a service operation that supports paging. Enumerating through the
        /// result of this method can potentially make multiple service operation calls.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListJobsEnumerator operation.</param>
        /// <returns>Returns an enumerable collection of FailedJobs.</returns>
        IEnumerable<IJob> GetFailedJobs(ListJobsRequest request);

        /// <summary>
        /// Gets the FailedJobs associated with this Vault.        
        /// <para>
        /// NOTE : This method calls a service operation that supports paging. Enumerating through the
        /// result of this method can potentially make multiple service operation calls.
        /// </para>
        /// </summary>
        /// <returns>Returns an enumerable collection of FailedJobs.</returns>
        IEnumerable<IJob> GetFailedJobs();

        /// <summary>
        /// Gets the Jobs associated with this Vault.        
        /// <para>
        /// NOTE : This method calls a service operation that supports paging. Enumerating through the
        /// result of this method can potentially make multiple service operation calls.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListJobsEnumerator operation.</param>
        /// <returns>Returns an enumerable collection of Jobs.</returns>
        IEnumerable<IJob> GetJobs(ListJobsRequest request);

        /// <summary>
        /// Gets the Jobs associated with this Vault.        
        /// <para>
        /// NOTE : This method calls a service operation that supports paging. Enumerating through the
        /// result of this method can potentially make multiple service operation calls.
        /// </para>
        /// </summary>
        /// <returns>Returns an enumerable collection of Jobs.</returns>
        IEnumerable<IJob> GetJobs();

        /// <summary>
        /// Gets the JobsInProgress associated with this Vault.        
        /// <para>
        /// NOTE : This method calls a service operation that supports paging. Enumerating through the
        /// result of this method can potentially make multiple service operation calls.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListJobsEnumerator operation.</param>
        /// <returns>Returns an enumerable collection of JobsInProgress.</returns>
        IEnumerable<IJob> GetJobsInProgress(ListJobsRequest request);

        /// <summary>
        /// Gets the JobsInProgress associated with this Vault.        
        /// <para>
        /// NOTE : This method calls a service operation that supports paging. Enumerating through the
        /// result of this method can potentially make multiple service operation calls.
        /// </para>
        /// </summary>
        /// <returns>Returns an enumerable collection of JobsInProgress.</returns>
        IEnumerable<IJob> GetJobsInProgress();

        /// <summary>
        /// Gets the MultipartUplaods associated with this Vault.        
        /// <para>
        /// NOTE : This method calls a service operation that supports paging. Enumerating through the
        /// result of this method can potentially make multiple service operation calls.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMultipartUploadsEnumerator operation.</param>
        /// <returns>Returns an enumerable collection of MultipartUplaods.</returns>
        IEnumerable<IMultipartUpload> GetMultipartUplaods(ListMultipartUploadsRequest request);

        /// <summary>
        /// Gets the MultipartUplaods associated with this Vault.        
        /// <para>
        /// NOTE : This method calls a service operation that supports paging. Enumerating through the
        /// result of this method can potentially make multiple service operation calls.
        /// </para>
        /// </summary>
        /// <returns>Returns an enumerable collection of MultipartUplaods.</returns>
        IEnumerable<IMultipartUpload> GetMultipartUplaods();

        /// <summary>
        /// Gets the SucceededJobs associated with this Vault.        
        /// <para>
        /// NOTE : This method calls a service operation that supports paging. Enumerating through the
        /// result of this method can potentially make multiple service operation calls.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListJobsEnumerator operation.</param>
        /// <returns>Returns an enumerable collection of SucceededJobs.</returns>
        IEnumerable<IJob> GetSucceededJobs(ListJobsRequest request);

        /// <summary>
        /// Gets the SucceededJobs associated with this Vault.        
        /// <para>
        /// NOTE : This method calls a service operation that supports paging. Enumerating through the
        /// result of this method can potentially make multiple service operation calls.
        /// </para>
        /// </summary>
        /// <returns>Returns an enumerable collection of SucceededJobs.</returns>
        IEnumerable<IJob> GetSucceededJobs();


        #endregion

        #region Subresources

        /// <summary>
        /// Gets the Notification associated with this Vault resource.
        /// <para>
        /// This method does not make a service call, it returns a resource instance
        /// only with its identifier properties initialized. Accessing any non-identifier 
        /// properties or operations on the resource that in turn access any non-identifier 
        /// properties will cause the resource to make a service call to load its data.
        /// </para>
        /// <para>
        /// NOTE : This method does not make a service call when the resource is initally
        /// constructed. If you pass invalid identifiers to this method, it will return a resource
        /// that may not exist on the server. In this case an exception will be thrown when 
        /// the resource tries to load itself due to conditions listed in the previous section.
        /// </para>
        /// </summary>
        /// <returns>Returns an instance of Notification.</returns>
        INotification GetNotification();

        /// <summary>
        /// Gets a Job associated with this Vault resource using its identifier.
        /// <para>
        /// This method does not make a service call, it returns a resource instance
        /// only with its identifier properties initialized. Accessing any non-identifier 
        /// properties or operations on the resource that in turn access any non-identifier 
        /// properties will cause the resource to make a service call to load its data.
        /// </para>
        /// <para>
        /// NOTE : This method does not make a service call when the resource is initally
        /// constructed. If you pass invalid identifiers to this method, it will return a resource
        /// that may not exist on the server. In this case an exception will be thrown when 
        /// the resource tries to load itself due to conditions listed in the previous section.
        /// </para>
        /// </summary>
        /// <param name="id">The id of the Job.</param>
        /// <returns>Returns an instance of Job.</returns>
        IJob GetJobById(string id);

        /// <summary>
        /// Gets a Archive associated with this Vault resource using its identifier.
        /// <para>
        /// This method does not make a service call, it returns a resource instance
        /// only with its identifier properties initialized. Accessing any non-identifier 
        /// properties or operations on the resource that in turn access any non-identifier 
        /// properties will cause the resource to make a service call to load its data.
        /// </para>
        /// <para>
        /// NOTE : This method does not make a service call when the resource is initally
        /// constructed. If you pass invalid identifiers to this method, it will return a resource
        /// that may not exist on the server. In this case an exception will be thrown when 
        /// the resource tries to load itself due to conditions listed in the previous section.
        /// </para>
        /// </summary>
        /// <param name="id">The id of the Archive.</param>
        /// <returns>Returns an instance of Archive.</returns>
        IArchive GetArchiveById(string id);

        /// <summary>
        /// Gets a MultipartUpload associated with this Vault resource using its identifier.
        /// <para>
        /// This method does not make a service call, it returns a resource instance
        /// only with its identifier properties initialized. Accessing any non-identifier 
        /// properties or operations on the resource that in turn access any non-identifier 
        /// properties will cause the resource to make a service call to load its data.
        /// </para>
        /// <para>
        /// NOTE : This method does not make a service call when the resource is initally
        /// constructed. If you pass invalid identifiers to this method, it will return a resource
        /// that may not exist on the server. In this case an exception will be thrown when 
        /// the resource tries to load itself due to conditions listed in the previous section.
        /// </para>
        /// </summary>
        /// <param name="id">The id of the MultipartUpload.</param>
        /// <returns>Returns an instance of MultipartUpload.</returns>
        IMultipartUpload GetMultipartUploadById(string id);


        #endregion
    }    
    #endregion
}