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
using Amazon.Util;

namespace Amazon.Glacier.Transfer.Internal
{
    internal class SinglepartUploadCommand : BaseUploadCommand
    {
        internal SinglepartUploadCommand(ArchiveTransferManager mananger, string vaultName, string archiveDescription, string filePath, UploadOptions options)
            : base(mananger, vaultName, archiveDescription, filePath, options)
        {
        }

        internal override void Execute()
        {
            FileStream input = File.OpenRead(filePath);

            string checksum = TreeHashGenerator.CalculateTreeHash(input);

            try
            {
                UploadArchiveRequest uploadRequest = new UploadArchiveRequest()
                {
                    AccountId = this.options.AccountId,
                    ArchiveDescription = archiveDescription,
                    VaultName = vaultName,
                    Checksum = checksum,
                    Body = input
                };

                uploadRequest.StreamTransferProgress += this.ProgressCallback;
                uploadRequest.BeforeRequestEvent += new UserAgentPostFix("SingleUpload").UserAgentRequestEventHandlerSync;

                UploadArchiveResponse uploadArchivResponse =
                    this.manager.GlacierClient.UploadArchive(uploadRequest);
                string archiveId = uploadArchivResponse.ArchiveId;
                this.UploadResult = new UploadResult(archiveId, checksum);
            }
            finally
            {
                try { input.Close(); }
                catch (Exception) { }
            }
        }

        void ProgressCallback(object sender, Runtime.StreamTransferProgressArgs args)
        {
            AWSSDKUtils.InvokeInBackground(this.options.StreamTransferProgress, args, this);
        }
    }
}
