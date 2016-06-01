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

using Amazon.Runtime;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Returns information about the  InitiateMultipartUpload response and response metadata.
    /// </summary>
    public class InitiateMultipartUploadResponse : AmazonWebServiceResponse
    {
        private string bucketName;
        private string key;
        private string uploadId;
        private ServerSideEncryptionMethod serverSideEncryption;
        private string serverSideEncryptionKeyManagementServiceKeyId;
        private DateTime? abortDate;
        private string abortRuleId;

        /// <summary>
        /// Name of the bucketName to which the multipart upload was initiated.
        ///  
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
        /// Object key for which the multipart upload was initiated.
        ///  
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
        /// Gets and sets the initiated multipart upload id.
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

        /// <summary>
        /// The Server-side encryption algorithm used when storing this object in S3.
        ///  
        /// </summary>
        public ServerSideEncryptionMethod ServerSideEncryptionMethod
        {
            get { return this.serverSideEncryption; }
            set { this.serverSideEncryption = value; }
        }

        /// <summary>
        /// The id of the AWS Key Management Service key that Amazon S3 uses to encrypt and decrypt the object.
        /// </summary>
        public string ServerSideEncryptionKeyManagementServiceKeyId
        {
            get { return this.serverSideEncryptionKeyManagementServiceKeyId; }
            set { this.serverSideEncryptionKeyManagementServiceKeyId = value; }
        }

        /// <summary>
        /// Checks if ServerSideEncryptionKeyManagementServiceKeyId property is set.
        /// </summary>
        /// <returns>true if ServerSideEncryptionKeyManagementServiceKeyId property is set.</returns>
        internal bool IsSetServerSideEncryptionKeyManagementServiceKeyId()
        {
            return !System.String.IsNullOrEmpty(this.serverSideEncryptionKeyManagementServiceKeyId);
        }

        /// <summary>
        /// Date when multipart upload will become eligible for abort operation by lifecycle.
        /// </summary>
        public DateTime AbortDate
        {
            get { return this.abortDate.GetValueOrDefault(); }
            set { this.abortDate = value; }
        }

        // Check to see if AbortDate property is set
        internal bool IsSetAbortDate()
        {
            return this.abortDate.HasValue;
        }

        /// <summary>
        /// Id of the lifecycle rule that makes a multipart upload eligible for abort operation.
        /// </summary>
        public string AbortRuleId
        {
            get { return this.abortRuleId; }
            set { this.abortRuleId = value; }
        }

        // Check to see if AbortRuleId property is set
        internal bool IsSetAbortRuleId()
        {
            return this.abortRuleId != null;
        }
    }
}
    
