/*******************************************************************************
 *  Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2006-03-01
 *
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Amazon.Runtime;

namespace Amazon.S3.Transfer.Internal
{
    /// <summary>
    /// This command files all the files that meets the criteria specified in the TransferUtilityUploadDirectoryRequest request
    /// and uploads them.
    /// </summary>
    internal partial class UploadDirectoryCommand : BaseCommand
    {
        public override void Execute()
        {
            string prefix = GetKeyPrefix();

            string basePath = new DirectoryInfo(this._request.Directory).FullName;
            string[] filePaths = Directory.GetFiles(basePath, this._request.SearchPattern, this._request.SearchOption);
            this._totalNumberOfFiles = filePaths.Length;

            foreach (string filepath in filePaths)
            {
                _totalBytes += new FileInfo(filepath).Length;
            }

            foreach (string filepath in filePaths)
            {
                var uploadRequest = ConstructRequest(basePath, filepath, prefix);
                this._utility.Upload(uploadRequest);
            }
        }

    }
}
