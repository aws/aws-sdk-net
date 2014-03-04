/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Threading;

using Amazon.Glacier.Model;
using Amazon.Glacier.Transfer.Internal;
using Amazon.Runtime;
using Amazon.Util;


namespace Amazon.Glacier.Transfer
{


    /// <summary>
    /// Provides a high level API for managing transfers to and from Amazon Glacier. This removes 
    /// complexities such as breaking files into parts and computing check sums.
    /// </summary>
    public class ArchiveTransferManager : IDisposable
    {
        // Threshold for when to use multipart upload operations
        internal const long MULTIPART_UPLOAD_SIZE_THRESHOLD = 1024L * 1024L * 10L;


        bool shouldDispose;
        AmazonGlacier glacierClient;

        /// <summary>
        /// Constructs an ArchiveTransferManager object for the specified Amazon Glacier region endpoint using the credentials
        /// loaded from the application's default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">Amazon Glacier region endpoint</param>
        public ArchiveTransferManager(RegionEndpoint region)
        {
            this.glacierClient = new AmazonGlacierClient(region);
            this.shouldDispose = true;
        }

        /// <summary>
        /// Constructs an ArchiveTransferManager object using an existing Amazon Glacier client.
        /// </summary>
        /// <param name="glacier">An AmazonGlacier client that used to make service calls.</param>
        public ArchiveTransferManager(AmazonGlacier glacier)
        {
            this.glacierClient = glacier;
            this.shouldDispose = false;
        }

        /// <summary>
        /// Constructs an ArchiveTransferManager object using the specified AWS credentials and Amazon Glacier region endpoint.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">Amazon Glacier region endpoint</param>
        public ArchiveTransferManager(AWSCredentials credentials, RegionEndpoint region)
            : this(new AmazonGlacierClient(credentials, region))
        {
            this.shouldDispose = true;
        }

        /// <summary>
        /// Constructs an ArchiveTransferManager object with the specified AWS Access Key ID, AWS Secret Key, and Amazon Glacier region endpoint.
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">Amazon Glacier region endpoint</param>
        public ArchiveTransferManager(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(new AmazonGlacierClient(awsAccessKeyId, awsSecretAccessKey, region))
        {
            this.shouldDispose = true;
        }

        /// <summary>
        /// 	Disposes of allocated resources and initiates garbage collection
        /// 	for the <see cref="ArchiveTransferManager"/> object.
        /// </summary>
        public void Dispose()
        {
            if (this.shouldDispose)
            {
                this.glacierClient.Dispose();
            }
        }

        /// <summary>
        /// The Glacier client used by the ArchiveTransferManager.
        /// </summary>
        internal AmazonGlacierClient GlacierClient
        {
            get { return this.glacierClient as AmazonGlacierClient; }
        }

        /// <summary>
        /// Creates a vault.
        /// </summary>
        /// <param name="vaultName">The name of the vault to create.</param>
        public void CreateVault(string vaultName)
        {
            CreateVaultRequest request = new CreateVaultRequest() { VaultName = vaultName };
            request.BeforeRequestEvent += new UserAgentPostFix("CreateVault").UserAgentRequestEventHandlerSync;
            this.glacierClient.CreateVault(request);
        }

        /// <summary>
        /// Deletes the specified vault. Before deletion, the vault must be empty of all archives.
        /// </summary>
        /// <param name="vaultName">The name of the vault to delete.</param>
        public void DeleteVault(string vaultName)
        {
            DeleteVaultRequest request = new DeleteVaultRequest() { VaultName = vaultName };
            request.BeforeRequestEvent += new UserAgentPostFix("DeleteVault").UserAgentRequestEventHandlerSync;
            this.glacierClient.DeleteVault(request);
        }

        /// <summary>
        /// Deletes an archive specified by vault name and archive ID.
        /// </summary>
        /// <param name="vaultName">The name of the vault containing the archive.</param>
        /// <param name="archiveId">The archive ID of the archive to delete.</param>
        public void DeleteArchive(string vaultName, string archiveId)
        {
            DeleteArchiveRequest request = new DeleteArchiveRequest() { VaultName = vaultName, ArchiveId = archiveId };
            request.BeforeRequestEvent += new UserAgentPostFix("DeleteArchive").UserAgentRequestEventHandlerSync;
            this.glacierClient.DeleteArchive(request);
        }

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
        public UploadResult Upload(string vaultName, string archiveDescription, string filepath)
        {
            return Upload(vaultName, archiveDescription, filepath, new UploadOptions());
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
        public UploadResult Upload(string vaultName, string archiveDescription, string filepath, UploadOptions options)
        {
            FileInfo fi = new FileInfo(filepath);
            BaseUploadCommand command;
            if (fi.Length > MULTIPART_UPLOAD_SIZE_THRESHOLD)
                command = new MultipartUploadCommand(this, vaultName, archiveDescription, filepath, options);
            else
                command = new SinglepartUploadCommand(this, vaultName, archiveDescription, filepath, options);

            command.Execute();            
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
        public void Download(string vaultName, string archiveId, string filePath)
        {
            Download(vaultName, archiveId, filePath, new DownloadOptions());
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
        public void Download(string vaultName, string archiveId, string filePath, DownloadOptions options)
        {
            var command = new DownloadFileCommand(this, vaultName, archiveId, filePath, options);
            command.Execute();
        }

        #endregion

        #region Download Job

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
        public void DownloadJob(string vaultName, string jobId, string filePath)
        {
            var command = new DownloadJobCommand(this, vaultName, jobId, filePath, new DownloadOptions());
            command.Execute();
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
        public void DownloadJob(string vaultName, string jobId, string filePath, DownloadOptions options)
        {
            var command = new DownloadJobCommand(this, vaultName, jobId, filePath, options);
            command.Execute();
        }
    
        #endregion

        #region Initiate Archive Retieval
        /// <summary>
        /// This method initiates an archive retieval job for the specified archive and returns back the job id.
        /// Once the is complete
        /// </summary>
        /// <param name="vaultName">The name of the vault that contains the archive to initiate the job for.</param>
        /// <param name="archiveId">The archive id that the download job will retrieve.</param>
        /// <returns>The job id for the initiated job.</returns>
        public string InitiateArchiveRetrievalJob(string vaultName, string archiveId)
        {
            return InitiateArchiveRetrievalJob(vaultName, archiveId, null);
        }

        /// <summary>
        /// This method initiates an archive retieval job for the specified archive and returns back the job id.
        /// Once the is complete
        /// </summary>
        /// <param name="vaultName">The name of the vault that contains the archive to initiate the job for.</param>
        /// <param name="archiveId">The archive id that the download job will retrieve.</param>
        /// <param name="options">Additional options that can be used for initiating archive retrieval.</param>
        /// <returns>The job id for the initiated job.</returns>
        public string InitiateArchiveRetrievalJob(string vaultName, string archiveId, InitiateArchiveRetrievalOptions options)
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
            }

            var jobId = glacierClient.InitiateJob(jobRequest).InitiateJobResult.JobId;
            return jobId;
        }
        #endregion
    }

    internal class UserAgentPostFix
    {
        string operation;

        internal UserAgentPostFix(string operation)
        {
            this.operation = operation;
        }

        internal void UserAgentRequestEventHandlerSync(object sender, RequestEventArgs args)
        {
            WebServiceRequestEventArgs wsArgs = args as WebServiceRequestEventArgs;
            if (wsArgs != null)
            {
                string currentUserAgent = wsArgs.Headers[AWSSDKUtils.UserAgentHeader];
                wsArgs.Headers[AWSSDKUtils.UserAgentHeader] = currentUserAgent + " ArchiveTransferManager/" + this.operation;
            }
        }
    }
}
