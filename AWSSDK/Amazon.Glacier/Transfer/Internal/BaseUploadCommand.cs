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
    internal abstract class BaseUploadCommand
    {
        protected ArchiveTransferManager manager;
        protected UploadOptions options;
        protected string vaultName;
        protected string archiveDescription;
        protected string filePath;

        internal BaseUploadCommand(ArchiveTransferManager manager, string vaultName, string archiveDescription, string filePath, UploadOptions options)
        {
            this.manager = manager;
            this.vaultName = vaultName;
            this.archiveDescription = archiveDescription;
            this.filePath = filePath;
            this.options = options;

            if (this.options == null)
                this.options = new UploadOptions();
        }

        internal abstract void Execute();


        public UploadResult UploadResult
        {
            get;
            protected set;
        }
    }
}
