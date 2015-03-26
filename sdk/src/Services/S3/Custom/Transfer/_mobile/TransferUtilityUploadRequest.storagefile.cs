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
using System.Collections.Specialized;
using System.Text;

using Amazon.S3.Model;
using Amazon.Util;
using Windows.Storage;

namespace Amazon.S3.Transfer
{
    /// <summary>
    /// Contains all the parameters
    /// that can be set when making a this request with the 
    /// <c>TransferUtility</c> method.
    /// </summary>
    public partial class TransferUtilityUploadRequest
    {
        private IStorageFile _storageFile;

        /// <summary>
        /// Gets and sets the StorageFile property. The Windows.Storage.IStorageFile that will be read 
        /// from and upload to Amazon S3.
        /// </summary>
        [System.CLSCompliant(false)]
        public IStorageFile StorageFile
        {
            get { return _storageFile; }
            set 
            { 
                _storageFile = value;
                if (!this.IsSetFilePath())
                {
                    this.FilePath = _storageFile.Path;    
                }
            }
        }

        /// <summary>
        /// Checks if StorageFile property is set.
        /// </summary>
        /// <returns>True if StorageFile property is set.</returns>
        internal bool IsSetStorageFile()
        {
            return this.StorageFile != null;
        }
    }
}
