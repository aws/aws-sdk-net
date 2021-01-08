﻿/*
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
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.S3.Model
{
    /// <summary>
    /// ServerSideEncryptionRule class
    /// </summary>
    public class ServerSideEncryptionRule
    {
        private ServerSideEncryptionByDefault serverSideEncryptionByDefault;
        private bool? bucketKeyEnabled;

        /// <summary>
        /// Describes the default server-side encryption to apply to 
        /// new objects in the bucket. If Put Object request 
        /// does not specify any server-side encryption, 
        /// this default encryption will be applied.
        /// </summary>
        public ServerSideEncryptionByDefault ServerSideEncryptionByDefault
        {
            get { return this.serverSideEncryptionByDefault; }
            set { this.serverSideEncryptionByDefault = value; }
        }
        // Check to see if ServerSideEncryptionByDefault property is set
        internal bool IsSetServerSideEncryptionByDefault()
        {
            return this.serverSideEncryptionByDefault != null;
        }

        /// <summary>
        /// <para>Specifies whether Amazon S3 should use bucket key with 
        /// server-side encryption using KMS (SSE-KMS) for new objects in the bucket. 
        /// Existing objects are not affected. Setting the <code>BucketKeyEnabled</code> 
        /// element to <code>true</code> causes Amazon S3 to use bucket key. By default, 
        /// bucket key is not enabled.</para> <para>For more information, 
        /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/bucket-key.html\">Bucket key</a> in 
        /// the <i>Amazon Simple Storage Service Developer Guide</i>.</para>",
        /// </summary>
        public bool BucketKeyEnabled
        {
            get { return this.bucketKeyEnabled.GetValueOrDefault(); }
            set { this.bucketKeyEnabled = value; }
        }

        internal bool IsSetBucketKeyEnabled()
        {
            return bucketKeyEnabled.HasValue;
        }
    }
}
