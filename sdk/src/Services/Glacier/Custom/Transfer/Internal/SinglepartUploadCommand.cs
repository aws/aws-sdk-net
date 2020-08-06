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
using Amazon.Util;

namespace Amazon.Glacier.Transfer.Internal
{
    internal partial class SinglepartUploadCommand : BaseUploadCommand
    {
        internal SinglepartUploadCommand(ArchiveTransferManager mananger, string vaultName, string archiveDescription, string filePath, UploadOptions options)
            : base(mananger, vaultName, archiveDescription, filePath, options)
        {
        }

        void ProgressCallback(object sender, Runtime.StreamTransferProgressArgs args)
        {
            AWSSDKUtils.InvokeInBackground(this.options.StreamTransferProgress, args, this);
        }
    }
}
