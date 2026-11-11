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
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using Amazon.Glacier.Model;
using Amazon.Glacier.Transfer.Internal;
using Amazon.Runtime;
using Amazon.Util;
namespace Amazon.Glacier.Transfer
{
    public partial class ArchiveTransferManager:IDisposable
    {
        #region Public members

        /// <summary>
        /// Creates a vault.
        /// </summary>
        /// <param name="vaultName">The name of the vault to create.</param>
        public Task CreateVaultAsync(string vaultName)
        {
            CreateVaultRequest request = new CreateVaultRequest() { VaultName = vaultName };
            ((Amazon.Runtime.Internal.IAmazonWebServiceRequest)request).AddBeforeRequestHandler(new UserAgentPostFix("CreateVault").UserAgentRequestEventHandlerSync);
            return this.glacierClient.CreateVaultAsync(request);
        }

        /// <summary>
        /// Deletes the specified vault. Before deletion, the vault must be empty of all archives.
        /// </summary>
        /// <param name="vaultName">The name of the vault to delete.</param>
        public Task DeleteVaultAsync(string vaultName)
        {
            DeleteVaultRequest request = new DeleteVaultRequest() { VaultName = vaultName };
            ((Amazon.Runtime.Internal.IAmazonWebServiceRequest)request).AddBeforeRequestHandler(new UserAgentPostFix("DeleteVault").UserAgentRequestEventHandlerSync);
            return this.glacierClient.DeleteVaultAsync(request);
        }

        /// <summary>
        /// Deletes an archive specified by vault name and archive ID.
        /// </summary>
        /// <param name="vaultName">The name of the vault containing the archive.</param>
        /// <param name="archiveId">The archive ID of the archive to delete.</param>
        public Task DeleteArchiveAsync(string vaultName, string archiveId)
        {
            DeleteArchiveRequest request = new DeleteArchiveRequest() { VaultName = vaultName, ArchiveId = archiveId };
            ((Amazon.Runtime.Internal.IAmazonWebServiceRequest)request).AddBeforeRequestHandler(new UserAgentPostFix("DeleteArchive").UserAgentRequestEventHandlerSync);
            return this.glacierClient.DeleteArchiveAsync(request);
        }

        #endregion

        #region Upload
        /// <summary>
        /// Uploads the specified file to Amazon Glacier for archival storage in the
        /// specified vault in the specified user's account. For small archives, this
        /// method uploads the archive directly to Glacier. For larger archives,
        /// this method uses Glacier's multipart upload API to split the upload
        /// into multiple parts for better error recovery if any errors are
        /// encountered while streaming the data to Amazon Glacier.
        /// </summary>
        /// <param name="vaultName">The name of the vault to upload the file to.</param>
        /// <param name="archiveDescription">A description for the archive.</param>
        /// <param name="filepath">The file path to the file to upload.</param>
        /// <returns>The results of the upload including the archive ID.</returns>
        public Task<UploadResult> UploadAsync(string vaultName, string archiveDescription, string filepath)
        {
            return UploadAsync(vaultName, archiveDescription, filepath, new UploadOptions());
        }
        /// <summary>
        /// <para>
        /// Uploads the specified file to Amazon Glacier for archival storage in the
        /// specified vault in the specified user's account. For small archives, this
        /// method uploads the archive directly to Glacier. For larger archives,
        /// this method uses Glacier's multipart upload API to split the upload
        /// into multiple parts for better error recovery if any errors are
        /// encountered while streaming the data to Amazon Glacier.
        /// </para>
        /// </summary>
        /// <param name="vaultName">The name of the vault to download the archive from.</param>
        /// <param name="archiveDescription">A description for the archive.</param>
        /// <param name="filepath">The file path to the file to upload.</param>
        /// <param name="options">Additional options that can be used for the upload.</param>
        /// <returns>The results of the upload including the archive ID.</returns>
        public async Task<UploadResult> UploadAsync(string vaultName, string archiveDescription, string filepath, UploadOptions options)
        {
            FileInfo fi = new FileInfo(filepath);
            BaseUploadCommand command;
            if (fi.Length > MULTIPART_UPLOAD_SIZE_THRESHOLD)
                command = new MultipartUploadCommand(this, vaultName, archiveDescription, filepath, options);
            else
                command = new SinglepartUploadCommand(this, vaultName, archiveDescription, filepath, options);
            await command.ExecuteAsync().ConfigureAwait(false);
            return command.UploadResult;
        }

        #endregion

        #region Download
        /// <summary>
        /// <para>
        /// Downloads an Amazon Glacier archive from the specified vault for the
        /// current user's account. Saves the archive to the specified file. 
        /// </para>
        ///
        /// <para>
        /// This method creates an Amazon SNS topic, and an Amazon SQS queue that is subscribed 
        /// to that topic.  It then initiates the archive retrieval job and polls the queue
        /// for the archive to be available.  This polling takes about 4 hours. Once the archive
        /// is available, download will begin.
        /// </para>
        /// </summary>
        /// <param name="filePath">The file path to save the archive to.</param>
        /// <param name="vaultName">The name of the vault to download the archive from.</param>
        /// <param name="archiveId">The unique ID of the archive to download.</param>
        public Task DownloadAsync(string vaultName, string archiveId, string filePath)
        {
            return DownloadAsync(vaultName, archiveId, filePath, new DownloadOptions());
        }
        /// <summary>
        /// <para>
        /// Downloads an archive from Amazon Glacier from the specified vault for the
        /// current user's account. Saves the archive to the specified file. 
        /// </para>
        ///
        /// <para>
        /// This method creates an Amazon SNS topic, and an Amazon SQS queue that is subscribed 
        /// to that topic.  It then initiates the archive retrieval job and polls the queue
        /// for the archive to be available.  This polling takes about 4 hours. Once the archive
        /// is available, download will begin.
        /// </para>
        ///
        /// <para>
        /// Additional options can be set using the UploadDirectoryOptions object. For example, you
        /// can set the FilesTransferProgress property to a delegate to track progress.  
        /// </para>
        /// </summary>
        /// <param name="filePath">The file path to save the archive at.</param>
        /// <param name="vaultName">The name of the vault to download the archive from.</param>
        /// <param name="archiveId">The unique ID of the archive to download.</param>
        /// <param name="options">Additional options that can be used for the download.</param>
        public Task DownloadAsync(string vaultName, string archiveId, string filePath, DownloadOptions options)
        {
            var command = new DownloadFileCommand(this, vaultName, archiveId, filePath, options);
            return command.ExecuteAsync();
        }
        #endregion

        #region DownloadJob
        /// <summary>
        /// <para>
        /// Downloads the results from a completed archive retrieval.  Saves the job output
        /// to the specified file.
        /// </para>
        /// <para>
        /// If there is an error during download the download will be retried from the last point read.
        /// Once the download is complete the checksum will be compared.
        /// </para>
        /// </summary>
        /// <param name="vaultName">The name of the vault to download the job output from.</param>
        /// <param name="jobId">The unique job ID for an archive retrieval job.</param>
        /// <param name="filePath">The file path to save the job output at.</param>
        public Task DownloadJobAsync(string vaultName, string jobId, string filePath)
        {
            return DownloadJobAsync(vaultName, jobId, filePath, new DownloadOptions());
        }

        /// <summary>
        /// <para>
        /// Downloads the results from a completed archive retrieval.  Saves the job output
        /// to the specified file.
        /// </para>
        /// <para>
        /// If there is an error during download the download will be retried from the last point read.
        /// Once the download is complete the checksum will be compared.
        /// </para>
        /// </summary>
        /// <param name="vaultName">The name of the vault to download the job output from.</param>
        /// <param name="jobId">The unique job ID for an archive retrieval job.</param>
        /// <param name="filePath">The file path to save the job output at.</param>
        /// <param name="options">Additional options that can be used for the download.</param>
        public Task DownloadJobAsync(string vaultName, string jobId, string filePath, DownloadOptions options)
        {
            var command = new DownloadJobCommand(this, vaultName, jobId, filePath, options);
            return command.ExecuteAsync();
        }

        #endregion

        #region Initiate Archive Retieval
        /// <summary>
        /// This method initiates an archive retieval job for the specified archive and returns back the job id.
        /// Once the job is complete
        /// </summary>
        /// <param name="vaultName">The name of the vault that contains the archive to initiate the job for.</param>
        /// <param name="archiveId">The archive id that the download job will retrieve.</param>
        /// <returns>The job id for the initiated job.</returns>
        public Task<string> InitiateArchiveRetrievalJobAsync(string vaultName, string archiveId)
        {
            return InitiateArchiveRetrievalJobAsync(vaultName, archiveId, null);
        }
        /// <summary>
        /// This method initiates an archive retieval job for the specified archive and returns back the job id.
        /// Once the job is complete
        /// </summary>
        /// <param name="vaultName">The name of the vault that contains the archive to initiate the job for.</param>
        /// <param name="archiveId">The archive id that the download job will retrieve.</param>
        /// <param name="options">Additional options that can be used for initiating archive retrieval.</param>
        /// <returns>The job id for the initiated job.</returns>
        public async Task<string> InitiateArchiveRetrievalJobAsync(string vaultName, string archiveId, InitiateArchiveRetrievalOptions options)
        { 
            InitiateJobRequest jobRequest = new InitiateJobRequest()
            {
                VaultName = vaultName,
                JobParameters = new JobParameters()
                {
                    ArchiveId = archiveId,
                    Type = "archive-retrieval"
                }
            };

            if (options != null)
            {
                jobRequest.AccountId = options.AccountId;
                jobRequest.JobParameters.SNSTopic = options.SNSTopic;
                jobRequest.JobParameters.Tier = options.Tier;
            }

            var glacierClientTask = await glacierClient.InitiateJobAsync(jobRequest).ConfigureAwait(false);
            return glacierClientTask.JobId;
        }
        #endregion
    }
}
