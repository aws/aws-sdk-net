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
using Amazon.Runtime.Resources;
using Amazon.Glacier.Model;

namespace Amazon.Glacier.Resources.Internal
{

    #region Account

    internal class Account : Resource<IAmazonGlacier>, IAccount
    {
        public string Id { get; private set; }

        public Account(string id, IAmazonGlacier client)
            : base (client)
        {
            this.IsLoaded = false;
            this.Id = id;

        }

        #region Actions

        public IVault CreateVault(CreateVaultRequest request)
        {
            var response = ResourcesUtilities.Invoke(request, this.Client.CreateVault, "CreateVault");
            return new Internal.Vault(accountId : this.Id, name : request.VaultName, client : this.Client);
            
        }

        public IVault CreateVault(string accountId, string vaultName)
        {
            var request = new CreateVaultRequest();
            request.AccountId = accountId;
            request.VaultName = vaultName;
            return CreateVault(request);
        }

        #endregion

        #region HasMany
        public IEnumerable<IVault> GetVaults(ListVaultsRequest request)
        {
        
            foreach (var item in ResourcesUtilities.InvokePaginator(request, this.Client.ListVaultsEnumerator, "Vaults"))
            {            
                yield return new Internal.Vault(model : item, accountId : request.AccountId, client : this.Client);    
            }

        }

        public IEnumerable<IVault> GetVaults()
        {
            var request = new ListVaultsRequest();
            return GetVaults(request);
        }


        #endregion

        #region Subresource

        public IVault GetVaultByName(string name)
        {
            return new Internal.Vault(accountId : this.Id, name : name, client : this.Client);
        }

        #endregion
    }

    #endregion

    #region Archive

    internal class Archive : Resource<IAmazonGlacier>, IArchive
    {
        public string AccountId { get; private set; }

        public string VaultName { get; private set; }

        public string Id { get; private set; }

        public Archive(string accountId, string vaultName, string id, IAmazonGlacier client)
            : base (client)
        {
            this.IsLoaded = false;
            this.AccountId = accountId;
            this.VaultName = vaultName;
            this.Id = id;

        }

        #region Actions

        public void Delete(DeleteArchiveRequest request)
        {
            request.AccountId = this.AccountId;
            request.VaultName = this.VaultName;
            request.ArchiveId = this.Id;
            ResourcesUtilities.Invoke(request, this.Client.DeleteArchive, "Delete");
        }

        public void Delete()
        {
            var request = new DeleteArchiveRequest();
            Delete(request);
        }

        public IJob InitiateArchiveRetreival(InitiateJobRequest request)
        {
            request.VaultName = this.VaultName;
            request.AccountId = this.AccountId;
            request.JobParameters.Type = "archive-retrieval";
            request.JobParameters.ArchiveId = this.Id;
            var response = ResourcesUtilities.Invoke(request, this.Client.InitiateJob, "InitiateArchiveRetreival");
            return new Internal.Job(id : response.JobId, accountId : this.AccountId, vaultName : this.VaultName, client : this.Client);
            
        }

        public IJob InitiateArchiveRetreival(JobParameters jobParameters)
        {
            var request = new InitiateJobRequest();
            request.JobParameters = jobParameters;
            return InitiateArchiveRetreival(request);
        }

        #endregion

    }

    #endregion

    #region Job

    internal class Job : Resource<IAmazonGlacier>, IJob
    {
        public string AccountId { get; private set; }

        public string VaultName { get; private set; }

        public string Id { get; private set; }

        private ActionCode _action;
        public ActionCode Action
        {
            get
            {
                this.CheckIfLoaded();
                return _action;
            }
        }

        private string _archiveId;
        public string ArchiveId
        {
            get
            {
                this.CheckIfLoaded();
                return _archiveId;
            }
        }

        private string _archiveSHA256TreeHash;
        public string ArchiveSHA256TreeHash
        {
            get
            {
                this.CheckIfLoaded();
                return _archiveSHA256TreeHash;
            }
        }

        private long _archiveSizeInBytes;
        public long ArchiveSizeInBytes
        {
            get
            {
                this.CheckIfLoaded();
                return _archiveSizeInBytes;
            }
        }

        private bool _completed;
        public bool Completed
        {
            get
            {
                this.CheckIfLoaded();
                return _completed;
            }
        }

        private DateTime _completionDate;
        public DateTime CompletionDate
        {
            get
            {
                this.CheckIfLoaded();
                return _completionDate;
            }
        }

        private DateTime _creationDate;
        public DateTime CreationDate
        {
            get
            {
                this.CheckIfLoaded();
                return _creationDate;
            }
        }

        private InventoryRetrievalJobDescription _inventoryRetrievalParameters;
        public InventoryRetrievalJobDescription InventoryRetrievalParameters
        {
            get
            {
                this.CheckIfLoaded();
                return _inventoryRetrievalParameters;
            }
        }

        private long _inventorySizeInBytes;
        public long InventorySizeInBytes
        {
            get
            {
                this.CheckIfLoaded();
                return _inventorySizeInBytes;
            }
        }

        private string _jobDescription;
        public string JobDescription
        {
            get
            {
                this.CheckIfLoaded();
                return _jobDescription;
            }
        }

        private string _retrievalByteRange;
        public string RetrievalByteRange
        {
            get
            {
                this.CheckIfLoaded();
                return _retrievalByteRange;
            }
        }

        private string _sha256TreeHash;
        public string SHA256TreeHash
        {
            get
            {
                this.CheckIfLoaded();
                return _sha256TreeHash;
            }
        }

        private string _snsTopic;
        public string SNSTopic
        {
            get
            {
                this.CheckIfLoaded();
                return _snsTopic;
            }
        }

        private StatusCode _statusCode;
        public StatusCode StatusCode
        {
            get
            {
                this.CheckIfLoaded();
                return _statusCode;
            }
        }

        private string _statusMessage;
        public string StatusMessage
        {
            get
            {
                this.CheckIfLoaded();
                return _statusMessage;
            }
        }

        private string _vaultARN;
        public string VaultARN
        {
            get
            {
                this.CheckIfLoaded();
                return _vaultARN;
            }
        }

        public Job(Model.GlacierJobDescription model,
            string accountId,
            string vaultName,
            IAmazonGlacier client)
            : base (client)
        {
            this.IsLoaded = true;
            this.AccountId = accountId;
            this.VaultName = vaultName;
            this.Id = model.JobId;
            CopyFrom(model);
        }

        private void CopyFrom(Model.GlacierJobDescription model)
        {
            _action = model.Action;
            _archiveId = model.ArchiveId;
            _archiveSHA256TreeHash = model.ArchiveSHA256TreeHash;
            _archiveSizeInBytes = model.ArchiveSizeInBytes;
            _completed = model.Completed;
            _completionDate = model.CompletionDate;
            _creationDate = model.CreationDate;
            _inventoryRetrievalParameters = model.InventoryRetrievalParameters;
            _inventorySizeInBytes = model.InventorySizeInBytes;
            _jobDescription = model.JobDescription;
            _retrievalByteRange = model.RetrievalByteRange;
            _sha256TreeHash = model.SHA256TreeHash;
            _snsTopic = model.SNSTopic;
            _statusCode = model.StatusCode;
            _statusMessage = model.StatusMessage;
            _vaultARN = model.VaultARN;
        }

        private void CopyFrom(Model.DescribeJobResponse model)
        {
            _action = model.Action;
            _archiveId = model.ArchiveId;
            _archiveSHA256TreeHash = model.ArchiveSHA256TreeHash;
            _archiveSizeInBytes = model.ArchiveSizeInBytes;
            _completed = model.Completed;
            _completionDate = model.CompletionDate;
            _creationDate = model.CreationDate;
            _inventoryRetrievalParameters = model.InventoryRetrievalParameters;
            _inventorySizeInBytes = model.InventorySizeInBytes;
            _jobDescription = model.JobDescription;
            _retrievalByteRange = model.RetrievalByteRange;
            _sha256TreeHash = model.SHA256TreeHash;
            _snsTopic = model.SNSTopic;
            _statusCode = model.StatusCode;
            _statusMessage = model.StatusMessage;
            _vaultARN = model.VaultARN;
        }

      
        protected override void LoadResource()
        {
            var request = new DescribeJobRequest();
            request.AccountId = this.AccountId;
            request.VaultName = this.VaultName;
            request.JobId = this.Id;

            var response = this.Client.DescribeJob(request);
            this.CopyFrom(response);
        }

        public Job(string accountId, string vaultName, string id, IAmazonGlacier client)
            : base (client)
        {
            this.IsLoaded = false;
            this.AccountId = accountId;
            this.VaultName = vaultName;
            this.Id = id;

        }

        #region Actions

        public GetJobOutputResponse GetOutput(GetJobOutputRequest request)
        {
            request.AccountId = this.AccountId;
            request.VaultName = this.VaultName;
            request.JobId = this.Id;
            var response = ResourcesUtilities.Invoke(request, this.Client.GetJobOutput, "GetOutput");
           return response;
        }

        public GetJobOutputResponse GetOutput()
        {
            var request = new GetJobOutputRequest();
            return GetOutput(request);
        }

        #endregion

    }

    #endregion

    #region MultipartUpload

    internal class MultipartUpload : Resource<IAmazonGlacier>, IMultipartUpload
    {
        public string AccountId { get; private set; }

        public string VaultName { get; private set; }

        public string Id { get; private set; }

        private string _archiveDescription;
        public string ArchiveDescription
        {
            get
            {
                this.CheckIfLoaded();
                return _archiveDescription;
            }
        }

        private DateTime _creationDate;
        public DateTime CreationDate
        {
            get
            {
                this.CheckIfLoaded();
                return _creationDate;
            }
        }

        private long _partSizeInBytes;
        public long PartSizeInBytes
        {
            get
            {
                this.CheckIfLoaded();
                return _partSizeInBytes;
            }
        }

        private string _vaultARN;
        public string VaultARN
        {
            get
            {
                this.CheckIfLoaded();
                return _vaultARN;
            }
        }

        public MultipartUpload(Model.UploadListElement model,
            string accountId,
            string vaultName,
            IAmazonGlacier client)
            : base (client)
        {
            this.IsLoaded = true;
            this.AccountId = accountId;
            this.VaultName = vaultName;
            this.Id = model.MultipartUploadId;
            CopyFrom(model);
        }

        private void CopyFrom(Model.UploadListElement model)
        {
            _archiveDescription = model.ArchiveDescription;
            _creationDate = model.CreationDate;
            _partSizeInBytes = model.PartSizeInBytes;
            _vaultARN = model.VaultARN;
        }

        public MultipartUpload(string accountId, string vaultName, string id, IAmazonGlacier client)
            : base (client)
        {
            this.IsLoaded = false;
            this.AccountId = accountId;
            this.VaultName = vaultName;
            this.Id = id;

        }

        #region Actions

        public void Abort(AbortMultipartUploadRequest request)
        {
            request.AccountId = this.AccountId;
            request.VaultName = this.VaultName;
            request.UploadId = this.Id;
            ResourcesUtilities.Invoke(request, this.Client.AbortMultipartUpload, "Abort");
        }

        public void Abort()
        {
            var request = new AbortMultipartUploadRequest();
            Abort(request);
        }

        public CompleteMultipartUploadResponse Complete(CompleteMultipartUploadRequest request)
        {
            request.AccountId = this.AccountId;
            request.VaultName = this.VaultName;
            request.UploadId = this.Id;
            var response = ResourcesUtilities.Invoke(request, this.Client.CompleteMultipartUpload, "Complete");
           return response;
        }

        public CompleteMultipartUploadResponse Complete(string archiveSize, string checksum)
        {
            var request = new CompleteMultipartUploadRequest();
            request.ArchiveSize = archiveSize;
            request.Checksum = checksum;
            return Complete(request);
        }

        public UploadMultipartPartResponse UploadPart(UploadMultipartPartRequest request)
        {
            request.AccountId = this.AccountId;
            request.VaultName = this.VaultName;
            request.UploadId = this.Id;
            var response = ResourcesUtilities.Invoke(request, this.Client.UploadMultipartPart, "UploadPart");
           return response;
        }

        public UploadMultipartPartResponse UploadPart(System.IO.Stream body, string checksum, string range)
        {
            var request = new UploadMultipartPartRequest();
            request.Body = body;
            request.Checksum = checksum;
            request.Range = range;
            return UploadPart(request);
        }

        #endregion

    }

    #endregion

    #region Notification

    internal class Notification : Resource<IAmazonGlacier>, INotification
    {
        public string AccountId { get; private set; }

        public string VaultName { get; private set; }

        private List<string> _events;
        public List<string> Events
        {
            get
            {
                this.CheckIfLoaded();
                return _events;
            }
        }

        private string _snsTopic;
        public string SNSTopic
        {
            get
            {
                this.CheckIfLoaded();
                return _snsTopic;
            }
        }

        public Notification(Model.VaultNotificationConfig model,
            string accountId,
            string vaultName,
            IAmazonGlacier client)
            : base (client)
        {
            this.IsLoaded = true;
            this.AccountId = accountId;
            this.VaultName = vaultName;
            CopyFrom(model);
        }

        private void CopyFrom(Model.VaultNotificationConfig model)
        {
            _events = model.Events;
            _snsTopic = model.SNSTopic;
        }

      
        protected override void LoadResource()
        {
            var request = new GetVaultNotificationsRequest();
            request.AccountId = this.AccountId;
            request.VaultName = this.VaultName;

            var response = this.Client.GetVaultNotifications(request);
            this.CopyFrom(response.VaultNotificationConfig);
        }

        public Notification(string accountId, string vaultName, IAmazonGlacier client)
            : base (client)
        {
            this.IsLoaded = false;
            this.AccountId = accountId;
            this.VaultName = vaultName;

        }

        #region Actions

        public void Delete(DeleteVaultNotificationsRequest request)
        {
            request.AccountId = this.AccountId;
            request.VaultName = this.VaultName;
            ResourcesUtilities.Invoke(request, this.Client.DeleteVaultNotifications, "Delete");
        }

        public void Delete()
        {
            var request = new DeleteVaultNotificationsRequest();
            Delete(request);
        }

        public void Set(SetVaultNotificationsRequest request)
        {
            request.AccountId = this.AccountId;
            request.VaultName = this.VaultName;
            ResourcesUtilities.Invoke(request, this.Client.SetVaultNotifications, "Set");
        }

        public void Set(VaultNotificationConfig vaultNotificationConfig)
        {
            var request = new SetVaultNotificationsRequest();
            request.VaultNotificationConfig = vaultNotificationConfig;
            Set(request);
        }

        #endregion

    }

    #endregion

    #region Vault

    internal class Vault : Resource<IAmazonGlacier>, IVault
    {
        public string AccountId { get; private set; }

        public string Name { get; private set; }

        private DateTime _creationDate;
        public DateTime CreationDate
        {
            get
            {
                this.CheckIfLoaded();
                return _creationDate;
            }
        }

        private DateTime _lastInventoryDate;
        public DateTime LastInventoryDate
        {
            get
            {
                this.CheckIfLoaded();
                return _lastInventoryDate;
            }
        }

        private long _numberOfArchives;
        public long NumberOfArchives
        {
            get
            {
                this.CheckIfLoaded();
                return _numberOfArchives;
            }
        }

        private long _sizeInBytes;
        public long SizeInBytes
        {
            get
            {
                this.CheckIfLoaded();
                return _sizeInBytes;
            }
        }

        private string _vaultARN;
        public string VaultARN
        {
            get
            {
                this.CheckIfLoaded();
                return _vaultARN;
            }
        }

        public Vault(Model.DescribeVaultOutput model,
            string accountId,
            IAmazonGlacier client)
            : base (client)
        {
            this.IsLoaded = true;
            this.AccountId = accountId;
            this.Name = model.VaultName;
            CopyFrom(model);
        }

        private void CopyFrom(Model.DescribeVaultOutput model)
        {
            _creationDate = model.CreationDate;
            _lastInventoryDate = model.LastInventoryDate;
            _numberOfArchives = model.NumberOfArchives;
            _sizeInBytes = model.SizeInBytes;
            _vaultARN = model.VaultARN;
        }

        private void CopyFrom(Model.DescribeVaultResponse model)
        {
            _creationDate = model.CreationDate;
            _lastInventoryDate = model.LastInventoryDate;
            _numberOfArchives = model.NumberOfArchives;
            _sizeInBytes = model.SizeInBytes;
            _vaultARN = model.VaultARN;
        }

      
        protected override void LoadResource()
        {
            var request = new DescribeVaultRequest();
            request.VaultName = this.Name;
            request.AccountId = this.AccountId;

            var response = this.Client.DescribeVault(request);
            this.CopyFrom(response);
        }

        public Vault(string accountId, string name, IAmazonGlacier client)
            : base (client)
        {
            this.IsLoaded = false;
            this.AccountId = accountId;
            this.Name = name;

        }

        #region Actions

        public CreateVaultResponse Create(CreateVaultRequest request)
        {
            request.VaultName = this.Name;
            request.AccountId = this.AccountId;
            var response = ResourcesUtilities.Invoke(request, this.Client.CreateVault, "Create");
           return response;
        }

        public CreateVaultResponse Create()
        {
            var request = new CreateVaultRequest();
            return Create(request);
        }

        public void Delete(DeleteVaultRequest request)
        {
            request.VaultName = this.Name;
            request.AccountId = this.AccountId;
            ResourcesUtilities.Invoke(request, this.Client.DeleteVault, "Delete");
        }

        public void Delete()
        {
            var request = new DeleteVaultRequest();
            Delete(request);
        }

        public IJob InitiateInventoryRetrieval(InitiateJobRequest request)
        {
            request.VaultName = this.Name;
            request.AccountId = this.AccountId;
            request.JobParameters.Type = "inventory-retrieval";
            var response = ResourcesUtilities.Invoke(request, this.Client.InitiateJob, "InitiateInventoryRetrieval");
            return new Internal.Job(id : response.JobId, accountId : this.AccountId, vaultName : this.Name, client : this.Client);
            
        }

        public IJob InitiateInventoryRetrieval(JobParameters jobParameters)
        {
            var request = new InitiateJobRequest();
            request.JobParameters = jobParameters;
            return InitiateInventoryRetrieval(request);
        }

        public IMultipartUpload InitiateMultipartUpload(InitiateMultipartUploadRequest request)
        {
            request.VaultName = this.Name;
            request.AccountId = this.AccountId;
            var response = ResourcesUtilities.Invoke(request, this.Client.InitiateMultipartUpload, "InitiateMultipartUpload");
            return new Internal.MultipartUpload(id : response.UploadId, accountId : this.AccountId, vaultName : this.Name, client : this.Client);
            
        }

        public IMultipartUpload InitiateMultipartUpload(string archiveDescription)
        {
            var request = new InitiateMultipartUploadRequest();
            request.ArchiveDescription = archiveDescription;
            return InitiateMultipartUpload(request);
        }

        public IMultipartUpload InitiateMultipartUpload(string archiveDescription, long partSize)
        {
            var request = new InitiateMultipartUploadRequest();
            request.ArchiveDescription = archiveDescription;
            request.PartSize = partSize;
            return InitiateMultipartUpload(request);
        }

        public IArchive UploadArchive(UploadArchiveRequest request)
        {
            request.VaultName = this.Name;
            request.AccountId = this.AccountId;
            var response = ResourcesUtilities.Invoke(request, this.Client.UploadArchive, "UploadArchive");
            return new Internal.Archive(id : response.ArchiveId, accountId : this.AccountId, vaultName : this.Name, client : this.Client);
            
        }

        public IArchive UploadArchive(System.IO.Stream body, string checksum)
        {
            var request = new UploadArchiveRequest();
            request.Body = body;
            request.Checksum = checksum;
            return UploadArchive(request);
        }

        #endregion

        #region HasMany
        public IEnumerable<IJob> GetCompletedJobs(ListJobsRequest request)
        {
            request.AccountId = this.AccountId;
            request.VaultName = this.Name;
            request.Completed = true;
        
            foreach (var item in ResourcesUtilities.InvokePaginator(request, this.Client.ListJobsEnumerator, "CompletedJobs"))
            {            
                yield return new Internal.Job(model : item, accountId : this.AccountId, vaultName : this.Name, client : this.Client);    
            }

        }

        public IEnumerable<IJob> GetCompletedJobs()
        {
            var request = new ListJobsRequest();
            return GetCompletedJobs(request);
        }

        public IEnumerable<IJob> GetFailedJobs(ListJobsRequest request)
        {
            request.AccountId = this.AccountId;
            request.VaultName = this.Name;
            request.Statuscode = "Failed";
        
            foreach (var item in ResourcesUtilities.InvokePaginator(request, this.Client.ListJobsEnumerator, "FailedJobs"))
            {            
                yield return new Internal.Job(model : item, accountId : this.AccountId, vaultName : this.Name, client : this.Client);    
            }

        }

        public IEnumerable<IJob> GetFailedJobs()
        {
            var request = new ListJobsRequest();
            return GetFailedJobs(request);
        }

        public IEnumerable<IJob> GetJobs(ListJobsRequest request)
        {
            request.AccountId = this.AccountId;
            request.VaultName = this.Name;
        
            foreach (var item in ResourcesUtilities.InvokePaginator(request, this.Client.ListJobsEnumerator, "Jobs"))
            {            
                yield return new Internal.Job(model : item, accountId : this.AccountId, vaultName : this.Name, client : this.Client);    
            }

        }

        public IEnumerable<IJob> GetJobs()
        {
            var request = new ListJobsRequest();
            return GetJobs(request);
        }

        public IEnumerable<IJob> GetJobsInProgress(ListJobsRequest request)
        {
            request.AccountId = this.AccountId;
            request.VaultName = this.Name;
            request.Statuscode = "InProgress";
        
            foreach (var item in ResourcesUtilities.InvokePaginator(request, this.Client.ListJobsEnumerator, "JobsInProgress"))
            {            
                yield return new Internal.Job(model : item, accountId : this.AccountId, vaultName : this.Name, client : this.Client);    
            }

        }

        public IEnumerable<IJob> GetJobsInProgress()
        {
            var request = new ListJobsRequest();
            return GetJobsInProgress(request);
        }

        public IEnumerable<IMultipartUpload> GetMultipartUplaods(ListMultipartUploadsRequest request)
        {
            request.VaultName = this.Name;
            request.AccountId = this.AccountId;
        
            foreach (var item in ResourcesUtilities.InvokePaginator(request, this.Client.ListMultipartUploadsEnumerator, "MultipartUplaods"))
            {            
                yield return new Internal.MultipartUpload(model : item, accountId : this.AccountId, vaultName : this.Name, client : this.Client);    
            }

        }

        public IEnumerable<IMultipartUpload> GetMultipartUplaods()
        {
            var request = new ListMultipartUploadsRequest();
            return GetMultipartUplaods(request);
        }

        public IEnumerable<IJob> GetSucceededJobs(ListJobsRequest request)
        {
            request.AccountId = this.AccountId;
            request.VaultName = this.Name;
            request.Statuscode = "Succeeded";
        
            foreach (var item in ResourcesUtilities.InvokePaginator(request, this.Client.ListJobsEnumerator, "SucceededJobs"))
            {            
                yield return new Internal.Job(model : item, accountId : this.AccountId, vaultName : this.Name, client : this.Client);    
            }

        }

        public IEnumerable<IJob> GetSucceededJobs()
        {
            var request = new ListJobsRequest();
            return GetSucceededJobs(request);
        }


        #endregion

        #region Subresource

        public INotification GetNotification()
        {
            return new Internal.Notification(accountId : this.AccountId, vaultName : this.Name, client : this.Client);
        }
        public IJob GetJobById(string id)
        {
            return new Internal.Job(accountId : this.AccountId, vaultName : this.Name, id : id, client : this.Client);
        }
        public IArchive GetArchiveById(string id)
        {
            return new Internal.Archive(accountId : this.AccountId, vaultName : this.Name, id : id, client : this.Client);
        }
        public IMultipartUpload GetMultipartUploadById(string id)
        {
            return new Internal.MultipartUpload(accountId : this.AccountId, vaultName : this.Name, id : id, client : this.Client);
        }

        #endregion
    }

    #endregion
}