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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.S3.Model
{
    /// <summary>
    /// The parameters to request an abort of a multipart upload.
    /// </summary>
    /// <remarks>
    /// After a multipart upload is aborted, no additional parts can be uploaded using that upload ID. 
    /// The storage consumed by any previously uploaded parts will be freed. However, if any part uploads 
    /// are currently in progress, those part uploads might or might not succeed. As a result, it might be 
    /// necessary to abort a given multipart upload multiple times in order to completely free all storage 
    /// consumed by all parts.
    /// </remarks>
    public partial class AbortMultipartUploadRequest : AmazonWebServiceRequest
    {
        private string bucketName;
        private string key;
        private string uploadId;

        /// <summary>
        /// The name of the bucketName containing the S3 object that was being uploaded in parts.
        /// </summary>
        public string BucketName
        {
            get { return this.bucketName; }
            set { this.bucketName = value; }
        }

        // Check to see if Bucket property is set
        internal bool IsSetBucketName()
        {
            return this.bucketName != null;
        }

        /// <summary>
        /// The key of the S3 object that was being uploaded.
        /// </summary>
        public string Key
        {
            get { return this.key; }
            set { this.key = value; }
        }

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this.key != null;
        }

        /// <summary>
        /// The upload id for the in-progress multipart upload that should be aborted.
        /// </summary>
        public string UploadId
        {
            get { return this.uploadId; }
            set { this.uploadId = value; }
        }

        // Check to see if UploadId property is set
        internal bool IsSetUploadId()
        {
            return this.uploadId != null;
        }

    }
}
    
