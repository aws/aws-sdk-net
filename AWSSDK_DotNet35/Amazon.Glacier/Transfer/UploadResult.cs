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

namespace Amazon.Glacier.Transfer
{
    /// <summary>
    /// A type that represents the result of a single file upload.
    /// </summary>
    public class UploadResult
    {
        private string archiveId;
        private string checkSum;

        /// <summary>
        /// Constructs a new UploadResult object with the specified archive ID.
        /// </summary>
        /// <param name="archiveId">The ID of the uploaded archive.</param>
        /// <param name="checkSum">The check sum computed for the file uploaded.</param>
        internal UploadResult(string archiveId, string checkSum)
        {
            this.archiveId = archiveId;
            this.checkSum = checkSum;
        }

        /// <summary>
        /// Returns the ID of the uploaded archive.
        /// </summary>
        public string ArchiveId
        {
            get
            {
                return archiveId;
            }
        }

        public string Checksum
        {
            get
            {
                return this.checkSum;
            }
        }
    }
}
