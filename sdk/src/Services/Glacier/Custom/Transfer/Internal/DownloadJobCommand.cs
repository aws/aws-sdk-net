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
using System.Threading;

using Amazon.Glacier.Model;
using Amazon.Util;
using System.Globalization;

namespace Amazon.Glacier.Transfer.Internal
{
    internal partial class DownloadJobCommand
    {
        const int PART_STREAM_HASH_SIZE = 1024 * 1024;

        ArchiveTransferManager manager;
        string vaultName;
        string jobId;
        string filePath;
        DownloadOptions options;

        internal DownloadJobCommand(ArchiveTransferManager manager, string vaultName, string jobId, string filePath, DownloadOptions options)
        {
            this.manager = manager;
            this.vaultName = vaultName;
            this.jobId = jobId;
            this.filePath = filePath;
            this.options = options;

            if (this.options == null)
                this.options = new DownloadOptions();
        }
    }
}
