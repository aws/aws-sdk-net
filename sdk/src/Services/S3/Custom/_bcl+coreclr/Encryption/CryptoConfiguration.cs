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
using System.Linq;
using System.Text;

namespace Amazon.S3.Encryption
{
    /// <summary>
    /// AmazonS3CryptoConfiguration allows customers
    /// to set storage mode for encryption credentials
    /// </summary>
    public class AmazonS3CryptoConfiguration: AmazonS3Config
    {
        /// <summary>
        /// Default Constructor.
        /// </summary>
        public AmazonS3CryptoConfiguration()
        {
            // By default, store encryption info in metadata
            StorageMode = CryptoStorageMode.ObjectMetadata;
        }

        /// <summary>
        /// Gets and sets the StorageMode property. This determines if the crypto metadata is stored as metadata on the object or as a separate object in S3.
        /// The default is ObjectMetadata.
        /// </summary>
        public CryptoStorageMode StorageMode
        { get; set; }
    }
}
