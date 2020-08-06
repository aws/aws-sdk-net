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
