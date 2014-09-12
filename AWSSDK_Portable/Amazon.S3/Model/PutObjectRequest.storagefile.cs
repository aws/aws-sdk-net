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
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Windows.Storage;

using Amazon.Runtime;
using Amazon.Runtime.Internal;
using System.Threading.Tasks;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Container for the parameters to the PutObject operation.
    /// <para>Adds an object to a bucket.</para>
    /// </summary>
    public partial class PutObjectRequest : PutWithACLRequest
    {

        /// <summary>
        /// Gets and sets the StorageFile property. The Windows.Storage.IStorageFile that will be read 
        /// from and upload to Amazon S3.
        /// </summary>
        [System.CLSCompliant(false)]
        public IStorageFile StorageFile
        {
            get;
            set;
        }

        internal void SetupForFilePath()
        {
            var storageFile = Task.Run(
                () => Windows.Storage.StorageFile.GetFileFromApplicationUriAsync(new Uri(this.FilePath)).AsTask()
                ).Result;

            this.InputStream = Task.Run(
                () => storageFile.OpenAsync(Windows.Storage.FileAccessMode.Read).AsTask()).Result.AsStreamForRead();

            if (string.IsNullOrEmpty(this.Key))
            {
                this.Key = Path.GetFileName(this.FilePath);
            }
        }
    }
}
