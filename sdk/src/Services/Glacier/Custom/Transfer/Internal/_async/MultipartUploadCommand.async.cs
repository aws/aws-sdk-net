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
using System.Threading;
using System.Threading.Tasks;
using Amazon.Glacier.Model;
using Amazon.Glacier.Transfer.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Util;
using Amazon.Util;
using System.Globalization;


namespace Amazon.Glacier.Transfer.Internal
{
    internal partial class MultipartUploadCommand : BaseUploadCommand
    {
        internal override async Task ExecuteAsync()
        {
            FileInfo fileInfo = new FileInfo(filePath);
            FileStream fileStream = File.OpenRead(filePath);
            string uploadId = null;
            try
            {
                this.currentUploadProgressArgs = new StreamTransferProgressArgs(0, 0, fileInfo.Length);

                long partSize = CalculatePartSize(fileInfo.Length);
                InitiateMultipartUploadRequest initiateRequest = new InitiateMultipartUploadRequest()
                {
                    AccountId = this.options.AccountId,
                    ArchiveDescription = archiveDescription,
                    VaultName = vaultName,
                    PartSize = partSize
                };

                ((Amazon.Runtime.Internal.IAmazonWebServiceRequest)initiateRequest).AddBeforeRequestHandler(new ArchiveTransferManager.UserAgentPostFix("MultiUpload").UserAgentRequestEventHandlerSync);
                InitiateMultipartUploadResponse initiateResponse = await this.manager.GlacierClient.InitiateMultipartUploadAsync(initiateRequest).ConfigureAwait(false);


                uploadId = initiateResponse.UploadId;

                List<string> partTreeHashs = new List<string>();
                long currentPosition = 0;
                while (currentPosition < fileInfo.Length)
                {
                    long length = partSize;
                    if (currentPosition + partSize > fileInfo.Length)
                    {
                        length = fileInfo.Length - currentPosition;
                    }

                    Stream partStream = new PartialWrapperStream(fileStream, length);

                    string checksum = TreeHashGenerator.CalculateTreeHash(partStream);
                    partTreeHashs.Add(checksum);

                    UploadMultipartPartRequest uploadRequest = new UploadMultipartPartRequest()
                    {
                        AccountId = this.options.AccountId,
                        Checksum = checksum,
                        Range = "bytes " + currentPosition + "-" + (currentPosition + length - 1) + "/*",
                        UploadId = uploadId,
                        VaultName = vaultName,
                        Body = partStream
                    };

                    uploadRequest.StreamTransferProgress += this.ProgressCallback;
                    ((Amazon.Runtime.Internal.IAmazonWebServiceRequest)uploadRequest).AddBeforeRequestHandler(new ArchiveTransferManager.UserAgentPostFix("MultiUpload").UserAgentRequestEventHandlerSync);

                    await this.manager.GlacierClient.UploadMultipartPartAsync(uploadRequest).ConfigureAwait(false);
                    currentPosition += partSize;
                }

                string totalFileChecksum = TreeHashGenerator.CalculateTreeHash(partTreeHashs);
                string archiveSize = fileInfo.Length.ToString(CultureInfo.InvariantCulture);
                CompleteMultipartUploadRequest compRequest = new CompleteMultipartUploadRequest()
                {
                    AccountId = this.options.AccountId,
                    ArchiveSize = archiveSize,
                    VaultName = vaultName,
                    Checksum = totalFileChecksum,
                    UploadId = uploadId
                };

                ((Amazon.Runtime.Internal.IAmazonWebServiceRequest)compRequest).AddBeforeRequestHandler(new ArchiveTransferManager.UserAgentPostFix("MultiUpload").UserAgentRequestEventHandlerSync);
                CompleteMultipartUploadResponse completeMultipartUploadResponse = await this.manager.GlacierClient.CompleteMultipartUploadAsync(compRequest).ConfigureAwait(false);

                string archiveId = completeMultipartUploadResponse.ArchiveId;
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
                    ((Amazon.Runtime.Internal.IAmazonWebServiceRequest)abortRequest).AddBeforeRequestHandler(new ArchiveTransferManager.UserAgentPostFix("MultiUpload").UserAgentRequestEventHandlerSync);
                    this.manager.GlacierClient.AbortMultipartUploadAsync(abortRequest).Wait();
                }

                throw;
            }
            finally
            {
                try { fileStream.Dispose(); }
                catch (Exception) { }
            }
        }
    }
}
