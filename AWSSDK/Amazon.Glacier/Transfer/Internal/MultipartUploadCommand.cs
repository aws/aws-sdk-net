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


namespace Amazon.Glacier.Transfer.Internal
{
    internal class MultipartUploadCommand : BaseUploadCommand
    {
        // The maximum part size for a Glacier multipart upload.
        const long MAXIMUM_PART_SIZE = 1024L * 1024 * 1024 * 4;

        // The minimum part size for a Glacier multipart upload.
        const long MINIMUM_PART_SIZE = 1024L * 1024;

        object currentUploadProgressArgsLock = new object();
        StreamTransferProgressArgs currentUploadProgressArgs;

        internal MultipartUploadCommand(ArchiveTransferManager manager, string vaultName, string archiveDescription, string filePath, UploadOptions options)
            : base(manager, vaultName, archiveDescription, filePath, options)
        {
        }

        internal override void Execute()
        {
            FileInfo fileInfo = new FileInfo(filePath);
            FileStream fileStream = File.OpenRead(filePath);
            string uploadId = null;
            try
            {
                this.currentUploadProgressArgs = new StreamTransferProgressArgs(0, 0, fileInfo.Length);

                long partSize = CalculatePartSize(fileInfo.Length);
                InitiateMultipartUploadRequest initiateRequest = new InitiateMultipartUploadRequest()
                    .WithAccountId(this.options.AccountId)
                    .WithArchiveDescription(archiveDescription)
                    .WithVaultName(vaultName)
                    .WithPartSize(partSize);
                initiateRequest.BeforeRequestEvent += new UserAgentPostFix("MultiUpload").UserAgentRequestEventHandlerSync;
                InitiateMultipartUploadResult initiateResult = this.manager.GlacierClient.InitiateMultipartUpload(initiateRequest).InitiateMultipartUploadResult;


                uploadId = initiateResult.UploadId;

                List<string> partTreeHashs = new List<string>();
                long currentPosition = 0;
                while (currentPosition < fileInfo.Length)
                {
                    long length = partSize;
                    if (currentPosition + partSize > fileInfo.Length)
                    {
                        length = fileInfo.Length - currentPosition;
                    }

                    PartStreamWrapper partStream = new PartStreamWrapper(fileStream, length);

                    string checksum = TreeHashGenerator.CalculateTreeHash(partStream);
                    partTreeHashs.Add(checksum);

                    UploadMultipartPartRequest uploadRequest = new UploadMultipartPartRequest()
                        .WithAccountId(this.options.AccountId)
                        .WithChecksum(checksum)
                        .WithBody(partStream)
                        .WithRange("bytes " + currentPosition + "-" + (currentPosition + length - 1) + "/*")
                        .WithUploadId(uploadId)
                        .WithVaultName(vaultName);
                    uploadRequest.StreamTransferProgress += this.ProgressCallback;
                    uploadRequest.BeforeRequestEvent += new UserAgentPostFix("MultiUpload").UserAgentRequestEventHandlerSync;

                    this.manager.GlacierClient.UploadMultipartPart(uploadRequest);
                    currentPosition += partSize;
                }

                string totalFileChecksum = TreeHashGenerator.CalculateTreeHash(partTreeHashs);
                string archiveSize = fileInfo.Length.ToString();
                CompleteMultipartUploadRequest compRequest = new CompleteMultipartUploadRequest()
                        .WithAccountId(this.options.AccountId)
                        .WithArchiveSize(archiveSize)
                        .WithVaultName(vaultName)
                        .WithChecksum(totalFileChecksum)
                        .WithUploadId(uploadId);
                compRequest.BeforeRequestEvent += new UserAgentPostFix("MultiUpload").UserAgentRequestEventHandlerSync;
                CompleteMultipartUploadResult completeMultipartUploadResult = this.manager.GlacierClient.CompleteMultipartUpload(compRequest).CompleteMultipartUploadResult;

                string archiveId = completeMultipartUploadResult.ArchiveId;
                this.UploadResult = new UploadResult(archiveId, totalFileChecksum);
            }
            catch (Exception)
            {
                // If we got an unrecoverable then abort the upload.
                if (!string.IsNullOrEmpty(uploadId))
                {
                    AbortMultipartUploadRequest abortRequest = new AbortMultipartUploadRequest()
                    {
                        AccountId = this.options.AccountId,
                        VaultName = this.vaultName,
                        UploadId = uploadId
                    };
                    abortRequest.BeforeRequestEvent += new UserAgentPostFix("MultiUpload").UserAgentRequestEventHandlerSync;
                    this.manager.GlacierClient.AbortMultipartUpload(abortRequest);
                }

                throw;
            }
            finally
            {
                try { fileStream.Close(); }
                catch (Exception) { }
            }
        }


        void ProgressCallback(object sender, Runtime.StreamTransferProgressArgs args)
        {
            lock (currentUploadProgressArgsLock)
            {
                this.currentUploadProgressArgs = new StreamTransferProgressArgs(args.IncrementTransferred,
                    this.currentUploadProgressArgs.TransferredBytes + args.IncrementTransferred,
                    this.currentUploadProgressArgs.TotalBytes);
            }

            AWSSDKUtils.InvokeInBackground(this.options.StreamTransferProgress,
                this.currentUploadProgressArgs, this);
        }

        /// <summary>
        /// Calculates the part size to use when uploading an archive of the
        /// specified size using Glacier's multipart upload APIs. Because of the tree
        /// hashing algorithm, part sizes must be aligned on 2^n MB boundaries (ex:
        /// 1MB, 2MB, 4MB, 8MB, etc). All parts must be the same size, except for the
        /// last part.
        /// </summary>
        /// <param name="fileSize">The size of the file being uploaded.</param>
        /// <returns>The part size to use in the multipart upload.</returns>
        internal static long CalculatePartSize(long fileSize)
        {
            long partSize = MINIMUM_PART_SIZE;
            int approxNumParts = 1;
	        while (partSize * approxNumParts < fileSize && partSize*2 <= MAXIMUM_PART_SIZE) 
            {
                partSize *= 2;
                approxNumParts *= 2;
            }
	
            return partSize;        
        }
    }
}
